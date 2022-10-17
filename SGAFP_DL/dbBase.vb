Imports System.ComponentModel
Imports System.Configuration.ConfigurationManager
Imports System.Reflection
Imports System.Text
Public MustInherit Class dbBase

#Region " Protegidas "
    Protected _sError As String
    Protected _sql As OracleHelper
    Protected _cnnStr As New String(CType(ConnectionStrings("ConnectionString").ConnectionString, Char()))
    Private _ConnectionStringName As String
#End Region

#Region " Propiedades "

    Protected Property ConnectionStringName() As String
        Get
            Return _ConnectionStringName
        End Get
        Set(ByVal value As String)
            _ConnectionStringName = value
        End Set
    End Property

    Protected Overridable Property sql() As OracleHelper
        Get
            Return Me._sql
        End Get
        Set(ByVal Value As OracleHelper)
            Me._sql = Value
        End Set
    End Property

    Protected Overridable Property sError() As String
        Get
            Return Me._sError
        End Get
        Set(ByVal Value As String)
            Me._sError = Value
        End Set
    End Property

    Protected Overridable Property cnnStr() As String
        Get
            If Not ConnectionStringName Is Nothing OrElse ConnectionStringName <> "" Then
                _cnnStr = New String(CType(ConnectionStrings(ConnectionStringName).ConnectionString, Char()))
            End If
            Return Me._cnnStr
        End Get
        Set(ByVal Value As String)
            Me._cnnStr = Value
        End Set
    End Property

#End Region

#Region " Métodos Públicos "

    Public MustOverride Function Actualizar(ByVal aEntidad As entidadBase) As Integer
    'Funcion que se encarga de Actualizar los datos de la Entidad

    Public MustOverride Function Agregar(ByVal aEntidad As entidadBase) As Integer
    'Funcion que se encarga de Insertar los datos de la Entidad

    Public MustOverride Function Eliminar(ByVal aEntidad As entidadBase) As Integer
    'Funcion que se encarga de Eliminar los datos de la Entidad

    Public MustOverride Function Recuperar(ByVal aEntidad As entidadBase) As Integer
    'Funcion que se encarga de Recuperar los datos de la Entidad

    Public MustOverride Function ObtenerID(ByVal aEntidad As entidadBase) As Object
    'Funcion que se encarga de Obtener el Maximo ID de la Entidad.

#End Region

    Public Overloads Sub CargarEntidad(ByVal origen As IDataReader, ByRef destino As entidadBase)

        If origen Is Nothing Or destino Is Nothing Then Return

        Dim tipoDestino As Type = destino.GetType()

        For i As Integer = 0 To origen.FieldCount - 1
            Try
                If Not origen(i) Is System.DBNull.Value Then
                    Dim PropiedadDestino As PropertyInfo = tipoDestino.GetProperty(origen.GetName(i))
                    Dim PropiedadDestinoOld As PropertyInfo = tipoDestino.GetProperty(origen.GetName(i) + "Old")
                    PropiedadDestino.SetValue(destino, origen(i), Nothing)
                    If Not PropiedadDestinoOld Is Nothing Then
                        PropiedadDestinoOld.SetValue(destino, origen(i), Nothing)
                    End If
                Else
                    Dim PropiedadDestino As PropertyInfo = tipoDestino.GetProperty(origen.GetName(i))
                    If (PropiedadDestino.PropertyType.Name = "Int16") Or _
                            (PropiedadDestino.PropertyType.Name = "Int32") Or _
                            (PropiedadDestino.PropertyType.Name = "Int64") Or _
                            (PropiedadDestino.PropertyType.Name = "Integer") Or _
                            (PropiedadDestino.PropertyType.Name = "Decimal") Then
                        Dim PropiedadDestinoOld As PropertyInfo = tipoDestino.GetProperty(origen.GetName(i) + "Old")
                        Select Case PropiedadDestino.PropertyType.Name
                            Case "Int16", "Int32", "Int64", "Integer"
                                PropiedadDestino.SetValue(destino, -1, Nothing)
                            Case "Decimal"
                                PropiedadDestino.SetValue(destino, Decimal.Parse("-1"), Nothing)
                        End Select
                        If Not PropiedadDestinoOld Is Nothing Then
                            Select Case PropiedadDestinoOld.PropertyType.Name
                                Case "Int16", "Int32", "Int64", "Integer"
                                    PropiedadDestinoOld.SetValue(destino, -1, Nothing)
                                Case "Decimal"
                                    PropiedadDestinoOld.SetValue(destino, Decimal.Parse("-1"), Nothing)
                            End Select
                        End If
                    End If
                End If
            Catch ex As Exception
            End Try
        Next
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' MÃƒÂ©todo que genera el Query de Update a partir de la entidad que recibe de parÃƒÂ¡metro
    ''' </summary>
    ''' <param name="entity"></param>
    ''' <param name="args"></param>
    ''' <param name="aTipoConcurrencia"></param>
    ''' <returns>Retorna el String del Query creado</returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	28/01/2007	Created
    ''' 	[ecarias]	23/04/2007	Se le agrego que si los campos DateTime eran Nothing
    '''                             le pusiera DBNull.Value
    ''' 	[ecarias]	23/04/2007	Se le agrego que le seteara el Tipo de Dato del Parametro
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function QueryUpdate(ByVal entity As entidadBase, ByRef args() As OracleParameter, Optional ByVal aTipoConcurrencia As TipoConcurrencia = TipoConcurrencia.Pesimistica) As String

        Dim tipoEntidad As Type = entity.GetType()
        Dim tipoParametro As Type = args.GetType()
        Dim strSql As New StringBuilder
        Dim strSet As String = ""
        Dim strWhere As String = ""
        Dim countArgs As Integer = 0

        Dim atributoTabla As TableAttribute = _
        CType(Attribute.GetCustomAttribute(tipoEntidad, GetType(TableAttribute)), TableAttribute)

        strSql.Append(" UPDATE " + atributoTabla.Name + " " + vbCrLf)
        strSql.Append(" SET ")

        For Each PropiedadOrigen As PropertyInfo In tipoEntidad.GetProperties()

            Dim atributoColumna As ColumnAttribute
            Dim atributoDataObject As DataObjectFieldAttribute
            Dim PropiedadDestino As PropertyInfo = tipoEntidad.GetProperty(PropiedadOrigen.Name)
            atributoColumna = CType(Attribute.GetCustomAttribute(PropiedadOrigen, GetType(ColumnAttribute)), ColumnAttribute)
            atributoDataObject = CType(Attribute.GetCustomAttribute(PropiedadOrigen, GetType(DataObjectFieldAttribute)), DataObjectFieldAttribute)

            If Not PropiedadDestino Is Nothing And Not atributoColumna Is Nothing Then
                If aTipoConcurrencia = TipoConcurrencia.Pesimistica Then
                    If atributoColumna.Id Then
                        If strWhere <> "" Then
                            strWhere += " AND "
                        Else
                            strWhere += " WHERE "
                        End If
                        If PropiedadDestino.Name.Length >= 30 Then
                            strWhere += atributoColumna.Storage + " = :" + PropiedadDestino.Name.Substring(0, 29) + " " + vbCrLf
                        Else
                            strWhere += atributoColumna.Storage + " = :" + PropiedadDestino.Name + " " + vbCrLf
                        End If
                        countArgs += 1
                        Dim i As Integer = 0
                        If countArgs - 1 > 0 Then
                            Dim tempArgs As Object = args
                            ReDim args(countArgs - 1)
                            For Each arg As IDbDataParameter In CType(tempArgs, IDbDataParameter())
                                args(i) = CType(arg, OracleParameter)
                                i += 1
                            Next
                        End If
                        args(i) = CType(Assembly.GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", "")), OracleParameter)
                        If PropiedadDestino.Name.Length >= 30 Then
                            args(i).ParameterName = ":" & PropiedadDestino.Name.Substring(0, 29)
                        Else
                            args(i).ParameterName = ":" & PropiedadDestino.Name
                        End If

                        If (PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
                           (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date")) OrElse _
                           (PropiedadDestino.GetValue(entity, Nothing) IsNot Nothing AndAlso _
                           (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date") AndAlso _
                           (DateTime.Compare(CDate(PropiedadDestino.GetValue(entity, Nothing)), #12:00:00 AM#)) = 0) Then
                            args(i).Value = DBNull.Value
                        ElseIf PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
                                (PropiedadDestino.PropertyType.Name = "String") Then
                            args(i).Value = DBNull.Value
                        ElseIf (PropiedadDestino.PropertyType.Name = "Int16") Or _
                                (PropiedadDestino.PropertyType.Name = "Int32") Or _
                                (PropiedadDestino.PropertyType.Name = "Int64") Or _
                                (PropiedadDestino.PropertyType.Name = "Integer") Or _
                                (PropiedadDestino.PropertyType.Name = "Decimal") Then
                            args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                            If args(i).Value.ToString().Equals("-1") Then
                                args(i).Value = DBNull.Value
                            End If
                        Else
                            args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                        End If
                        args(i).OracleType = Me.TipoParametro(PropiedadDestino.PropertyType.FullName)
                        If atributoColumna.DBType.ToUpper <> "TEXT" Then
                            Select Case args(i).OracleType
                                Case OracleType.Char, OracleType.LongVarChar, OracleType.NChar, OracleType.NClob, OracleType.NVarChar, OracleType.VarChar
                                    args(i).Size = atributoDataObject.Length
                                    If atributoDataObject.Length > 0 Then
                                        If Not args(i).Value Is DBNull.Value AndAlso CType(args(i).Value, String).Length > atributoDataObject.Length Then
                                            Throw New Exception("El campo " + PropiedadDestino.Name + " en la tabla " + atributoTabla.Name + " tiene una longitud menor a la recibida.")
                                        End If
                                    End If
                                Case Else
                            End Select
                        End If
                    Else
                        If strSet <> "" Then
                            If PropiedadDestino.Name.Length >= 30 Then
                                strSet += " , " + atributoColumna.Storage + " = :" + PropiedadDestino.Name.Substring(0, 29) + " " + vbCrLf
                            Else
                                strSet += " , " + atributoColumna.Storage + " = :" + PropiedadDestino.Name + " " + vbCrLf
                            End If
                        Else
                            If PropiedadDestino.Name.Length >= 30 Then
                                strSet += " " + atributoColumna.Storage + " = :" + PropiedadDestino.Name.Substring(0, 29) + " " + vbCrLf
                            Else
                                strSet += " " + atributoColumna.Storage + " = :" + PropiedadDestino.Name + " " + vbCrLf
                            End If
                        End If
                        countArgs += 1
                        Dim i As Integer = 0
                        If countArgs - 1 > 0 Then
                            Dim tempArgs As Object = args
                            ReDim args(countArgs - 1)
                            For Each arg As IDbDataParameter In CType(tempArgs, IDbDataParameter())
                                args(i) = CType(arg, OracleParameter)
                                i += 1
                            Next
                        End If
                        args(i) = CType(Assembly.GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", "")), OracleParameter)
                        If PropiedadDestino.Name.Length >= 30 Then
                            args(i).ParameterName = ":" & PropiedadDestino.Name.Substring(0, 29)
                        Else
                            args(i).ParameterName = ":" & PropiedadDestino.Name
                        End If

                        If (PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
                           (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date")) OrElse _
                           (PropiedadDestino.GetValue(entity, Nothing) IsNot Nothing AndAlso _
                           (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date") AndAlso _
                           (DateTime.Compare(CDate(PropiedadDestino.GetValue(entity, Nothing)), #12:00:00 AM#)) = 0) Then
                            args(i).Value = DBNull.Value
                        ElseIf PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
                                (PropiedadDestino.PropertyType.Name = "String") Then
                            args(i).Value = DBNull.Value
                        ElseIf (PropiedadDestino.PropertyType.Name = "Int16") Or _
                                (PropiedadDestino.PropertyType.Name = "Int32") Or _
                                (PropiedadDestino.PropertyType.Name = "Int64") Or _
                                (PropiedadDestino.PropertyType.Name = "Integer") Or _
                                (PropiedadDestino.PropertyType.Name = "Decimal") Then
                            args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                            If args(i).Value.ToString().Equals("-1") Then
                                args(i).Value = DBNull.Value
                            End If
                        Else
                            args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                        End If
                        args(i).OracleType = Me.TipoParametro(PropiedadDestino.PropertyType.FullName)
                        If atributoColumna.DBType.ToUpper <> "TEXT" Then
                            Select Case args(i).OracleType
                                Case OracleType.Char, OracleType.LongVarChar, OracleType.NChar, OracleType.NClob, OracleType.NVarChar, OracleType.VarChar
                                    args(i).Size = atributoDataObject.Length
                                    If atributoDataObject.Length > 0 Then
                                        If Not args(i).Value Is DBNull.Value AndAlso CType(args(i).Value, String).Length > atributoDataObject.Length Then
                                            Throw New Exception("El campo " + PropiedadDestino.Name + " en la tabla " + atributoTabla.Name + " tiene una longitud menor a la recibida.")
                                        End If
                                    End If
                                Case Else
                            End Select
                        End If
                    End If
                Else
                    Dim PropiedadOld As PropertyInfo = Nothing
                    Try
                        PropiedadOld = tipoEntidad.GetProperty(PropiedadOrigen.Name + "Old")
                    Catch ex As Exception

                    End Try

                    If Not PropiedadOld Is Nothing Then
                        If Not PropiedadOld.GetValue(entity, Nothing).Equals(PropiedadDestino.GetValue(entity, Nothing)) Then
                            If strSet <> "" Then
                                If PropiedadDestino.Name.Length >= 30 Then
                                    strSet += " , " + atributoColumna.Storage + " = :" + PropiedadDestino.Name.Substring(0, 29) + " " + vbCrLf
                                Else
                                    strSet += " , " + atributoColumna.Storage + " = :" + PropiedadDestino.Name + " " + vbCrLf
                                End If
                            Else
                                If PropiedadDestino.Name.Length >= 30 Then
                                    strSet += " " + atributoColumna.Storage + " = :" + PropiedadDestino.Name.Substring(0, 29) + " " + vbCrLf
                                Else
                                    strSet += " " + atributoColumna.Storage + " = :" + PropiedadDestino.Name + " " + vbCrLf
                                End If
                            End If
                            countArgs += 1
                            Dim i As Integer = 0
                            If countArgs - 1 > 0 Then
                                Dim tempArgs As Object = args
                                ReDim args(countArgs - 1)
                                For Each arg As IDbDataParameter In CType(tempArgs, IDbDataParameter())
                                    args(i) = CType(arg, OracleParameter)
                                    i += 1
                                Next
                            End If
                            args(i) = CType(Assembly.GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", "")), OracleParameter)
                            If PropiedadDestino.Name.Length >= 30 Then
                                args(i).ParameterName = ":" & PropiedadDestino.Name.Substring(0, 29)
                            Else
                                args(i).ParameterName = ":" & PropiedadDestino.Name
                            End If

                            If (PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
                               (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date")) OrElse _
                               (PropiedadDestino.GetValue(entity, Nothing) IsNot Nothing AndAlso _
                               (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date") AndAlso _
                               (DateTime.Compare(CDate(PropiedadDestino.GetValue(entity, Nothing)), #12:00:00 AM#)) = 0) Then
                                args(i).Value = DBNull.Value
                            ElseIf PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
                                    (PropiedadDestino.PropertyType.Name = "String") Then
                                args(i).Value = DBNull.Value
                            ElseIf (PropiedadDestino.PropertyType.Name = "Int16") Or _
                                    (PropiedadDestino.PropertyType.Name = "Int32") Or _
                                    (PropiedadDestino.PropertyType.Name = "Int64") Or _
                                    (PropiedadDestino.PropertyType.Name = "Integer") Or _
                                    (PropiedadDestino.PropertyType.Name = "Decimal") Then
                                args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                                If args(i).Value.ToString().Equals("-1") Then
                                    args(i).Value = DBNull.Value
                                End If
                            Else
                                args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                            End If
                            args(i).OracleType = Me.TipoParametro(PropiedadDestino.PropertyType.FullName)
                            If atributoColumna.DBType.ToUpper <> "TEXT" Then
                                Select Case args(i).OracleType
                                    Case OracleType.Char, OracleType.LongVarChar, OracleType.NChar, OracleType.NClob, OracleType.NVarChar, OracleType.VarChar
                                        args(i).Size = atributoDataObject.Length
                                        If atributoDataObject.Length > 0 Then
                                            If Not args(i).Value Is DBNull.Value AndAlso CType(args(i).Value, String).Length > atributoDataObject.Length Then
                                                Throw New Exception("El campo " + PropiedadDestino.Name + " en la tabla " + atributoTabla.Name + " tiene una longitud menor a la recibida.")
                                            End If
                                        End If
                                    Case Else
                                End Select
                            End If
                        End If
                    ElseIf Not atributoColumna.Id Then
                        If strSet <> "" Then
                            If PropiedadDestino.Name.Length >= 30 Then
                                strSet += " , " + atributoColumna.Storage + " = :" + PropiedadDestino.Name.Substring(0, 29) + " " + vbCrLf
                            Else
                                strSet += " , " + atributoColumna.Storage + " = :" + PropiedadDestino.Name + " " + vbCrLf
                            End If
                        Else
                            If PropiedadDestino.Name.Length >= 30 Then
                                strSet += " " + atributoColumna.Storage + " = :" + PropiedadDestino.Name.Substring(0, 29) + " " + vbCrLf
                            Else
                                strSet += " " + atributoColumna.Storage + " = :" + PropiedadDestino.Name + " " + vbCrLf
                            End If
                        End If
                        countArgs += 1
                        Dim i As Integer = 0
                        If countArgs - 1 > 0 Then
                            Dim tempArgs As Object = args
                            ReDim args(countArgs - 1)
                            For Each arg As IDbDataParameter In CType(tempArgs, IDbDataParameter())
                                args(i) = CType(arg, OracleParameter)
                                i += 1
                            Next
                        End If
                        args(i) = CType(Assembly.GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", "")), OracleParameter)
                        If PropiedadDestino.Name.Length >= 30 Then
                            args(i).ParameterName = ":" & PropiedadDestino.Name.Substring(0, 29)
                        Else
                            args(i).ParameterName = ":" & PropiedadDestino.Name
                        End If
                        If (PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
                           (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date")) OrElse _
                           (PropiedadDestino.GetValue(entity, Nothing) IsNot Nothing AndAlso _
                           (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date") AndAlso _
                           (DateTime.Compare(CDate(PropiedadDestino.GetValue(entity, Nothing)), #12:00:00 AM#)) = 0) Then
                            args(i).Value = DBNull.Value
                        ElseIf PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
                                (PropiedadDestino.PropertyType.Name = "String") Then
                            args(i).Value = DBNull.Value
                        ElseIf (PropiedadDestino.PropertyType.Name = "Int16") Or _
                                (PropiedadDestino.PropertyType.Name = "Int32") Or _
                                (PropiedadDestino.PropertyType.Name = "Int64") Or _
                                (PropiedadDestino.PropertyType.Name = "Integer") Or _
                                (PropiedadDestino.PropertyType.Name = "Decimal") Then
                            args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                            If args(i).Value.ToString().Equals("-1") Then
                                args(i).Value = DBNull.Value
                            End If
                        Else
                            args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                        End If
                        args(i).OracleType = Me.TipoParametro(PropiedadDestino.PropertyType.FullName)
                        If atributoColumna.DBType.ToUpper <> "TEXT" Then
                            Select Case args(i).OracleType
                                Case OracleType.Char, OracleType.LongVarChar, OracleType.NChar, OracleType.NClob, OracleType.NVarChar, OracleType.VarChar
                                    args(i).Size = atributoDataObject.Length
                                    If atributoDataObject.Length > 0 Then
                                        If Not args(i).Value Is DBNull.Value AndAlso CType(args(i).Value, String).Length > atributoDataObject.Length Then
                                            Throw New Exception("El campo " + PropiedadDestino.Name + " en la tabla " + atributoTabla.Name + " tiene una longitud menor a la recibida.")
                                        End If
                                    End If
                                Case Else
                            End Select
                        End If
                    End If
                    If atributoColumna.Id Then
                        If strWhere <> "" Then
                            strWhere += " AND "
                        Else
                            strWhere += " WHERE "
                        End If
                        If PropiedadDestino.Name.Length >= 30 Then
                            strWhere += atributoColumna.Storage + " = :" + PropiedadDestino.Name.Substring(0, 29) + " " + vbCrLf
                        Else
                            strWhere += atributoColumna.Storage + " = :" + PropiedadDestino.Name + " " + vbCrLf
                        End If
                        countArgs += 1
                        Dim i As Integer = 0
                        If countArgs - 1 > 0 Then
                            Dim tempArgs As Object = args
                            ReDim args(countArgs - 1)
                            For Each arg As IDbDataParameter In CType(tempArgs, IDbDataParameter())
                                args(i) = CType(arg, OracleParameter)
                                i += 1
                            Next
                        End If
                        args(i) = CType(Assembly.GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", "")), OracleParameter)
                        If PropiedadDestino.Name.Length >= 30 Then
                            args(i).ParameterName = ":" & PropiedadDestino.Name.Substring(0, 29)
                        Else
                            args(i).ParameterName = ":" & PropiedadDestino.Name
                        End If
                        If (PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
                           (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date")) OrElse _
                           (PropiedadDestino.GetValue(entity, Nothing) IsNot Nothing AndAlso _
                           (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date") AndAlso _
                           (DateTime.Compare(CDate(PropiedadDestino.GetValue(entity, Nothing)), #12:00:00 AM#)) = 0) Then
                            args(i).Value = DBNull.Value
                        ElseIf PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
                                (PropiedadDestino.PropertyType.Name = "String") Then
                            args(i).Value = DBNull.Value
                        ElseIf (PropiedadDestino.PropertyType.Name = "Int16") Or _
                                (PropiedadDestino.PropertyType.Name = "Int32") Or _
                                (PropiedadDestino.PropertyType.Name = "Int64") Or _
                                (PropiedadDestino.PropertyType.Name = "Integer") Or _
                                (PropiedadDestino.PropertyType.Name = "Decimal") Then
                            args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                            If args(i).Value.ToString().Equals("-1") Then
                                args(i).Value = DBNull.Value
                            End If
                        Else
                            args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                        End If
                        args(i).OracleType = Me.TipoParametro(PropiedadDestino.PropertyType.FullName)
                        If atributoColumna.DBType.ToUpper <> "TEXT" Then
                            Select Case args(i).OracleType
                                Case OracleType.Char, OracleType.LongVarChar, OracleType.NChar, OracleType.NClob, OracleType.NVarChar, OracleType.VarChar
                                    args(i).Size = atributoDataObject.Length
                                    If atributoDataObject.Length > 0 Then
                                        If Not args(i).Value Is DBNull.Value AndAlso CType(args(i).Value, String).Length > atributoDataObject.Length Then
                                            Throw New Exception("El campo " + PropiedadDestino.Name + " en la tabla " + atributoTabla.Name + " tiene una longitud menor a la recibida.")
                                        End If
                                    End If
                                Case Else
                            End Select
                        End If
                    Else
                        If strWhere <> "" Then
                            strWhere += " AND "
                        Else
                            strWhere += " WHERE "
                        End If
                        If PropiedadDestino.Name.Length >= 30 Then
                            strWhere += atributoColumna.Storage + " = :" + PropiedadOld.Name + " " + vbCrLf
                        Else
                            strWhere += atributoColumna.Storage + " = :" + PropiedadOld.Name + " " + vbCrLf
                        End If
                        countArgs += 1
                        Dim i As Integer = 0
                        If countArgs - 1 > 0 Then
                            Dim tempArgs As Object = args
                            ReDim args(countArgs - 1)
                            For Each arg As IDbDataParameter In CType(tempArgs, IDbDataParameter())
                                args(i) = CType(arg, OracleParameter)
                                i += 1
                            Next
                        End If
                        args(i) = CType(Assembly.GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", "")), OracleParameter)
                        If PropiedadDestino.Name.Length >= 30 Then
                            args(i).ParameterName = ":" & PropiedadOld.Name.Substring(0, 29)
                        Else
                            args(i).ParameterName = ":" & PropiedadOld.Name
                        End If

                        If (PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
                           (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date")) OrElse _
                           (PropiedadDestino.GetValue(entity, Nothing) IsNot Nothing AndAlso _
                           (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date") AndAlso _
                           (DateTime.Compare(CDate(PropiedadDestino.GetValue(entity, Nothing)), #12:00:00 AM#)) = 0) Then
                            args(i).Value = DBNull.Value
                        ElseIf PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
                                (PropiedadDestino.PropertyType.Name = "String") Then
                            args(i).Value = DBNull.Value
                        ElseIf (PropiedadOld.PropertyType.Name = "Int16") Or _
                                (PropiedadOld.PropertyType.Name = "Int32") Or _
                                (PropiedadOld.PropertyType.Name = "Int64") Or _
                                (PropiedadOld.PropertyType.Name = "Integer") Or _
                                (PropiedadOld.PropertyType.Name = "Decimal") Then
                            args(i).Value = PropiedadOld.GetValue(entity, Nothing)
                            If args(i).Value.ToString().Equals("-1") Then
                                args(i).Value = DBNull.Value
                            End If
                        Else
                            args(i).Value = PropiedadOld.GetValue(entity, Nothing)
                        End If
                        args(i).OracleType = Me.TipoParametro(PropiedadOld.PropertyType.FullName)
                        If atributoColumna.DBType.ToUpper <> "TEXT" Then
                            Select Case args(i).OracleType
                                Case OracleType.Char, OracleType.LongVarChar, OracleType.NChar, OracleType.NClob, OracleType.NVarChar, OracleType.VarChar
                                    args(i).Size = atributoDataObject.Length
                                    If atributoDataObject.Length > 0 Then
                                        If Not args(i).Value Is DBNull.Value AndAlso CType(args(i).Value, String).Length > atributoDataObject.Length Then
                                            Throw New Exception("El campo " + PropiedadDestino.Name + " en la tabla " + atributoTabla.Name + " tiene una longitud menor a la recibida.")
                                        End If
                                    End If
                                Case Else
                            End Select
                        End If
                    End If
                End If
            End If
        Next
        strSql.Append(strSet)
        strSql.Append(strWhere)
        Return strSql.ToString()
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Método que genera el Query de Seleccion de Campos y el Where
    ''' </summary>
    ''' <param name="entity"></param>
    ''' <param name="args"></param>
    ''' <param name="tipoEntidad"></param>
    ''' <param name="tipoParametro"></param>
    ''' <param name="strCampos"></param>
    ''' <param name="strWhere"></param>
    ''' <param name="countArgs"></param>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub QuerySelectCampos(ByVal entity As entidadBase, ByRef args() As OracleParameter, ByVal tipoEntidad As Type, ByVal tipoParametro As Type, ByRef strCampos As String, ByRef strWhere As String, ByVal countArgs As Integer, Optional ByVal aliasTabla As String = "", Optional ByVal prefijoAliasColumna As String = "")
        For Each PropiedadOrigen As PropertyInfo In tipoEntidad.GetProperties()

            Dim atributoColumna As ColumnAttribute
            Dim PropiedadDestino As PropertyInfo = tipoEntidad.GetProperty(PropiedadOrigen.Name)
            atributoColumna = CType(Attribute.GetCustomAttribute(PropiedadOrigen, GetType(ColumnAttribute)), ColumnAttribute)

            If Not PropiedadDestino Is Nothing And Not atributoColumna Is Nothing Then
                If strCampos <> "" Then
                    If prefijoAliasColumna <> "" Then
                        strCampos += String.Format(" , {0}.{1} As {2}{3} {4}", aliasTabla, atributoColumna.Storage, prefijoAliasColumna, atributoColumna.Storage, vbCrLf)
                    Else
                        If aliasTabla <> "" Then
                            strCampos += String.Format(" , {0}.{1} {2}", aliasTabla, atributoColumna.Storage, vbCrLf)
                        Else
                            strCampos += String.Format(" , {0} {1}", atributoColumna.Storage, vbCrLf)
                        End If
                    End If
                Else
                    If prefijoAliasColumna <> "" Then
                        strCampos += String.Format(" {0}.{1} As {2}{3} {4}", aliasTabla, atributoColumna.Storage, prefijoAliasColumna, atributoColumna.Storage, vbCrLf)
                    Else
                        If aliasTabla <> "" Then
                            strCampos += String.Format(" {0}.{1} {2}", aliasTabla, atributoColumna.Storage, vbCrLf)
                        Else
                            strCampos += String.Format(" {0} {1}", atributoColumna.Storage, vbCrLf)
                        End If
                    End If
                End If
                If atributoColumna.Id And Not tipoParametro Is Nothing Then
                    If strWhere <> "" Then
                        strWhere += " AND "
                    Else
                        strWhere += " WHERE "
                    End If
                    If PropiedadDestino.Name.Length >= 30 Then
                        If aliasTabla <> "" Then
                            strWhere += String.Format("{0}.{1} = :{2} {3}", aliasTabla, atributoColumna.Storage, PropiedadDestino.Name.Substring(0, 29), vbCrLf)
                        Else
                            strWhere += String.Format("{0} = :{1} {2}", atributoColumna.Storage, PropiedadDestino.Name.Substring(0, 29), vbCrLf)
                        End If
                    Else
                        If aliasTabla <> "" Then
                            strWhere += String.Format("{0}.{1} = :{2} {3}", aliasTabla, atributoColumna.Storage, PropiedadDestino.Name, vbCrLf)
                        Else
                            strWhere += String.Format("{0} = :{1} {2}", atributoColumna.Storage, PropiedadDestino.Name, vbCrLf)
                        End If
                    End If
                    countArgs += 1
                    Dim i As Integer = 0
                    If countArgs - 1 > 0 Then
                        Dim tempArgs As Object = args
                        ReDim args(countArgs - 1)
                        For Each arg As IDbDataParameter In CType(tempArgs, IDbDataParameter())
                            args(i) = CType(arg, OracleParameter)
                            i += 1
                        Next
                    End If
                    args(i) = CType(Assembly.GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", "")), OracleParameter)
                    args(i).OracleType = Me.TipoParametro(PropiedadDestino.PropertyType.FullName)
                    If PropiedadDestino.Name.Length >= 30 Then
                        args(i).ParameterName = ":" & PropiedadDestino.Name.Substring(0, 29)
                    Else
                        args(i).ParameterName = ":" & PropiedadDestino.Name
                    End If
                    args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                End If
            End If
        Next
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' MÃƒÂ©todo que genera el Query de Select a partir de la entidad que recibe de parÃƒÂ¡metro
    ''' </summary>
    ''' <param name="entity"></param>
    ''' <param name="args"></param>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/02/2008	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function QuerySelect(ByVal entity As entidadBase, Optional ByRef args() As OracleParameter = Nothing) As String

        Dim tipoEntidad As Type = entity.GetType()
        Dim tipoParametro As Type = Nothing
        If Not args Is Nothing Then
            tipoParametro = args.GetType()
        End If
        Dim strSql As New StringBuilder
        Dim strCampos As String = ""
        Dim strWhere As String = ""
        Dim countArgs As Integer = 0

        Dim atributoTabla As TableAttribute = _
        CType(Attribute.GetCustomAttribute(tipoEntidad, GetType(TableAttribute)), TableAttribute)

        strSql.Append(" SELECT ")

        For Each PropiedadOrigen As PropertyInfo In tipoEntidad.GetProperties()

            Dim atributoColumna As ColumnAttribute
            Dim PropiedadDestino As PropertyInfo = tipoEntidad.GetProperty(PropiedadOrigen.Name)
            atributoColumna = CType(Attribute.GetCustomAttribute(PropiedadOrigen, GetType(ColumnAttribute)), ColumnAttribute)

            If Not PropiedadDestino Is Nothing And Not atributoColumna Is Nothing Then
                'strSql.Append(" " + atributoColumna.Storage + " " + vbCrLf)
                If strCampos <> "" Then
                    strCampos += " , " + atributoColumna.Storage + " " + vbCrLf
                Else
                    strCampos += " " + atributoColumna.Storage + " " + vbCrLf
                End If
                If atributoColumna.Id And Not tipoParametro Is Nothing Then
                    If strWhere <> "" Then
                        strWhere += " AND "
                    Else
                        strWhere += " WHERE "
                    End If
                    strWhere += atributoColumna.Storage + " = :" + atributoColumna.Storage + "" + vbCrLf
                    countArgs += 1
                    Dim i As Integer = 0
                    If countArgs - 1 > 0 Then
                        Dim tempArgs As Object = args
                        ReDim args(countArgs - 1)
                        For Each arg As IDbDataParameter In CType(tempArgs, IDbDataParameter())
                            args(i) = CType(arg, OracleParameter)
                            i += 1
                        Next
                    End If
                    'args(i) = System.Reflection.Assembly.GetExecutingAssembly().GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", ""))
                    args(i) = CType(Assembly.GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", "")), OracleParameter)
                    'args(i).OracleType = OracleType.Object
                    args(i).OracleType = Me.TipoParametro(PropiedadDestino.PropertyType.FullName)
                    args(i).ParameterName = ":" + PropiedadDestino.Name
                    args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                End If
            End If
        Next
        strSql.Append(strCampos)
        strSql.Append(" FROM " + atributoTabla.Name + " " + vbCrLf)
        strSql.Append(strWhere)
        Return strSql.ToString()
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' MÃƒÂ©todo que genera el Query de Delete a partir de la entidad que recibe de parÃƒÂ¡metro
    ''' </summary>
    ''' <param name="entity"></param>
    ''' <param name="args"></param>
    ''' <param name="aTipoConcurrencia"></param>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/02/2008	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function QueryDelete(ByVal entity As entidadBase, ByRef args() As OracleParameter, Optional ByVal aTipoConcurrencia As TipoConcurrencia = TipoConcurrencia.Pesimistica) As String

        Dim tipoEntidad As Type = entity.GetType()
        Dim tipoParametro As Type = args.GetType()
        Dim strSql As New StringBuilder
        Dim strWhere As String = ""
        Dim countArgs As Integer = 0

        Dim atributoTabla As TableAttribute = _
        CType(Attribute.GetCustomAttribute(tipoEntidad, GetType(TableAttribute)), TableAttribute)

        strSql.Append(" DELETE FROM " + atributoTabla.Name + " " + vbCrLf)

        For Each PropiedadOrigen As PropertyInfo In tipoEntidad.GetProperties()

            Dim atributoColumna As ColumnAttribute
            Dim PropiedadDestino As PropertyInfo = tipoEntidad.GetProperty(PropiedadOrigen.Name)
            atributoColumna = CType(Attribute.GetCustomAttribute(PropiedadOrigen, GetType(ColumnAttribute)), ColumnAttribute)

            If Not PropiedadDestino Is Nothing And Not atributoColumna Is Nothing Then
                'strSql.Append(" " + atributoColumna.Storage + " = :" + PropiedadDestino.Name + "" + vbCrLf)
                If aTipoConcurrencia = TipoConcurrencia.Pesimistica Then
                    If atributoColumna.Id Then
                        If strWhere <> "" Then
                            strWhere += " AND "
                        Else
                            strWhere += " WHERE "
                        End If
                        strWhere += atributoColumna.Storage + " = :" + PropiedadDestino.Name + "" + vbCrLf
                        countArgs += 1
                        Dim i As Integer = 0
                        If countArgs - 1 > 0 Then
                            Dim tempArgs As Object = args
                            ReDim args(countArgs - 1)
                            For Each arg As IDbDataParameter In CType(tempArgs, IDbDataParameter())
                                args(i) = CType(arg, OracleParameter)
                                i += 1
                            Next
                        End If
                        'args(i) = System.Reflection.Assembly.GetExecutingAssembly().GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", ""))
                        args(i) = CType(Assembly.GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", "")), OracleParameter)
                        args(i).ParameterName = PropiedadDestino.Name

                        If PropiedadDestino.GetValue(entity, Nothing) Is Nothing And _
                            (PropiedadDestino.PropertyType.Name = "DateTime" Or _
                            PropiedadDestino.PropertyType.Name = "Date" Or _
                            PropiedadDestino.PropertyType.Name = "String") Then
                            args(i).Value = DBNull.Value
                        Else
                            args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                        End If
                    End If
                Else
                    Dim PropiedadOld As PropertyInfo = Nothing
                    Try
                        PropiedadOld = tipoEntidad.GetProperty(PropiedadOrigen.Name + "Old")
                    Catch ex As Exception
                    End Try
                    If strWhere <> "" Then
                        strWhere += " AND "
                    Else
                        strWhere += " WHERE "
                    End If
                    countArgs += 1
                    Dim i As Integer = 0
                    If countArgs - 1 > 0 Then
                        Dim tempArgs As Object = args
                        ReDim args(countArgs - 1)
                        For Each arg As IDbDataParameter In CType(tempArgs, IDbDataParameter())
                            args(i) = CType(arg, OracleParameter)
                            i += 1
                        Next
                    End If
                    If atributoColumna.Id Then
                        strWhere += atributoColumna.Storage + " = :" + PropiedadDestino.Name + "" + vbCrLf
                        'args(i) = System.Reflection.Assembly.GetExecutingAssembly().GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", ""))
                        args(i) = CType(Assembly.GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", "")), OracleParameter)
                        args(i).ParameterName = PropiedadDestino.Name
                        If PropiedadDestino.GetValue(entity, Nothing) Is Nothing And _
                            (PropiedadDestino.PropertyType.Name = "DateTime" Or _
                            PropiedadDestino.PropertyType.Name = "Date" Or _
                            PropiedadDestino.PropertyType.Name = "String") Then
                            args(i).Value = DBNull.Value
                        Else
                            args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                        End If
                    Else
                        strWhere += atributoColumna.Storage + " = :" + PropiedadOld.Name + "" + vbCrLf
                        'args(i) = System.Reflection.Assembly.GetExecutingAssembly().GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", ""))
                        args(i) = CType(Assembly.GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", "")), OracleParameter)
                        args(i).ParameterName = PropiedadOld.Name

                        If PropiedadOld.GetValue(entity, Nothing) Is Nothing And _
                            (PropiedadOld.PropertyType.Name = "DateTime" Or _
                            PropiedadOld.PropertyType.Name = "Date" Or _
                            PropiedadOld.PropertyType.Name = "String") Then
                            args(i).Value = DBNull.Value
                        Else
                            args(i).Value = PropiedadOld.GetValue(entity, Nothing)
                        End If
                    End If

                End If
            End If
        Next
        strSql.Append(strWhere)
        Return strSql.ToString()
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' MÃƒÂ©todo que genera el Query de Insert a partir de la entidad que recibe de parÃƒÂ¡metro
    ''' </summary>
    ''' <param name="entity"></param>
    ''' <param name="args"></param>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/02/2008	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function QueryInsert(ByVal entity As entidadBase, ByRef args() As OracleParameter) As String

        Dim tipoEntidad As Type = entity.GetType()
        Dim tipoParametro As Type = args.GetType()
        Dim strSql As New StringBuilder
        Dim strInsert As String = ""
        Dim strValues As String = ""
        Dim countArgs As Integer = 0

        Dim atributoTabla As TableAttribute = _
        CType(Attribute.GetCustomAttribute(tipoEntidad, GetType(TableAttribute)), TableAttribute)

        strSql.Append(" INSERT INTO " + atributoTabla.Name + " (" + vbCrLf)

        For Each PropiedadOrigen As PropertyInfo In tipoEntidad.GetProperties()

            Dim atributoColumna As ColumnAttribute
            Dim atributoDataObject As DataObjectFieldAttribute
            Dim PropiedadDestino As PropertyInfo = tipoEntidad.GetProperty(PropiedadOrigen.Name)
            atributoColumna = CType(Attribute.GetCustomAttribute(PropiedadOrigen, GetType(ColumnAttribute)), ColumnAttribute)
            atributoDataObject = CType(Attribute.GetCustomAttribute(PropiedadOrigen, GetType(DataObjectFieldAttribute)), DataObjectFieldAttribute)

            If Not PropiedadDestino Is Nothing And Not atributoColumna Is Nothing Then
                If strValues <> "" Then
                    strInsert += " , " + atributoColumna.Storage + " " + vbCrLf
                Else
                    strInsert += atributoColumna.Storage + " " + vbCrLf
                End If
                'strSql.Append(" " + atributoColumna.Storage + " " + vbCrLf)
                If strValues <> "" Then
                    strValues += " , "
                Else
                    strValues += " VALUES ( "
                End If
                strValues += " :" + atributoColumna.Storage + " " + vbCrLf
                countArgs += 1
                Dim i As Integer = 0
                If countArgs - 1 > 0 Then
                    Dim tempArgs As Object = args
                    ReDim args(countArgs - 1)
                    For Each arg As IDbDataParameter In CType(tempArgs, IDbDataParameter())
                        args(i) = CType(arg, OracleParameter)
                        i += 1
                    Next
                End If
                'args(i) = System.Reflection.Assembly.GetExecutingAssembly().GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", ""))
                args(i) = CType(Assembly.GetAssembly(tipoParametro).CreateInstance(tipoParametro.FullName.Replace("[]", "")), OracleParameter)
                args(i).ParameterName = ":" & PropiedadDestino.Name

                If (PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
                       (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date")) OrElse _
                       (PropiedadDestino.GetValue(entity, Nothing) IsNot Nothing AndAlso _
                       (PropiedadDestino.PropertyType.Name = "DateTime" Or PropiedadDestino.PropertyType.Name = "Date") AndAlso _
                       (DateTime.Compare(CDate(PropiedadDestino.GetValue(entity, Nothing)), #12:00:00 AM#)) = 0) Then
                    args(i).Value = DBNull.Value
                ElseIf PropiedadDestino.GetValue(entity, Nothing) Is Nothing AndAlso _
                        (PropiedadDestino.PropertyType.Name = "String") Then
                    args(i).Value = DBNull.Value
                ElseIf (PropiedadDestino.PropertyType.Name = "Int16") Or _
                        (PropiedadDestino.PropertyType.Name = "Int32") Or _
                        (PropiedadDestino.PropertyType.Name = "Int64") Or _
                        (PropiedadDestino.PropertyType.Name = "Integer") Or _
                        (PropiedadDestino.PropertyType.Name = "Decimal") Then
                    args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                    If args(i).Value.ToString().Equals("-1") Then
                        args(i).Value = DBNull.Value
                    End If
                Else
                    args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
                End If
                args(i).OracleType = Me.TipoParametro(PropiedadDestino.PropertyType.FullName)
                If atributoColumna.DBType.ToUpper <> "TEXT" Then

                    Select Case args(i).OracleType
                        Case OracleType.Char, OracleType.NChar, OracleType.NVarChar, OracleType.VarChar
                            args(i).Size = atributoDataObject.Length
                            If atributoDataObject.Length > 0 Then
                                If Not args(i).Value Is DBNull.Value AndAlso CType(args(i).Value, String).Length > atributoDataObject.Length Then
                                    Throw New Exception("El campo " + PropiedadDestino.Name + " de la tabla " + atributoTabla.Name + " tiene una longitud menor a la recibida.")
                                End If
                            End If
                        Case Else
                    End Select
                End If
                'args(i).Value = PropiedadDestino.GetValue(entity, Nothing)
            End If
        Next
        strSql.Append(strInsert + " ) " + vbCrLf)
        strSql.Append(strValues + " ) " + vbCrLf)
        Return strSql.ToString()
    End Function

    Public Function UsuarioActualiza() As String
        Return configuracion.usuarioActualiza
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' MÃƒÂ©todo que devuelve el Tipo de Dato del Parametro segun el Tipo de Dato .Net recibido
    ''' </summary>
    ''' <param name="asTipo">Tipo de Dato .Net</param>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/02/2008	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Protected Function TipoParametro(ByVal asTipo As String) As OracleType
        Select Case asTipo
            Case "System.String"
                Return OracleType.VarChar
            Case "System.Decimal"
                Return OracleType.Double
            Case "System.Double"
                Return OracleType.Double
            Case "System.Date", "System.DateTime"
                Return OracleType.DateTime
            Case "System.Boolean"
                Return OracleType.Int16
            Case "System.Integer", "System.Int32", "System.Long"
                Return OracleType.Int32
            Case "System.Int16"
                Return OracleType.Int16
            Case "System.Single"
                Return OracleType.Float
            Case "System.Byte[]"
                Return OracleType.LongRaw
            Case "System.Byte"
                Return OracleType.Byte
            Case Else
                Return OracleType.VarChar
        End Select
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃƒÂ³n que devuelve una lista basada en la entidad recibida, en base a los
    ''' criterios de recuperaciÃƒÂ³n del arreglo enviado
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/02/2008	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorBusqueda(ByVal aEntidad As entidadBase, ByVal aCriterios() As Criteria, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As IBindingListView
        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(aEntidad))
        Dim tipoEntidad As Type = aEntidad.GetType()
        Dim strWhere As String = ""
        Dim args(0) As OracleParameter
        Dim countArgs As Integer = 0

        For x As Integer = 0 To aCriterios.Length - 1
            Dim lCriterio As Criteria = aCriterios(x)
            Dim atributoColumna As ColumnAttribute
            Dim PropiedadDestino As PropertyInfo = tipoEntidad.GetProperty(lCriterio.ColumnName)
            Dim paramName As String
            paramName = "param" + countArgs.ToString()

            atributoColumna = CType(Attribute.GetCustomAttribute(PropiedadDestino, GetType(ColumnAttribute)), ColumnAttribute)
            If strWhere = "" Then
                strWhere += " WHERE "
            Else
                strWhere += " " + aCriterios(x - 1).QueryOperator + " "
            End If

            If atributoColumna Is Nothing Then
                Select Case lCriterio.Compare
                    Case "%*%", "*%", "%*"
                        If lCriterio.TableAlias <> "" Then
                            strWhere += lCriterio.TableAlias + "." + lCriterio.ColumnName + " LIKE :" + paramName + " " + vbCrLf
                        Else
                            strWhere += lCriterio.ColumnName + " LIKE :" + paramName + " " + vbCrLf
                        End If
                    Case "UPPER(*)"
                        If lCriterio.TableAlias <> "" Then
                            strWhere += "upper(" + lCriterio.TableAlias + "." + lCriterio.ColumnName + ") = :" + paramName + " " + vbCrLf
                        Else
                            strWhere += "upper(" + lCriterio.ColumnName + ") = :" + paramName + " " + vbCrLf
                        End If
                    Case "LOWER(*)"
                        If lCriterio.TableAlias <> "" Then
                            strWhere += "lower(" + lCriterio.TableAlias + "." + lCriterio.ColumnName + ") = :" + paramName + " " + vbCrLf
                        Else
                            strWhere += "lower(" + lCriterio.ColumnName + ") = :" + paramName + " " + vbCrLf
                        End If
                    Case "%UPPER(*)%", "UPPER(*)%", "%UPPER(*)"
                        If lCriterio.TableAlias <> "" Then
                            strWhere += "upper(" + lCriterio.TableAlias + "." + lCriterio.ColumnName + ") LIKE :" + paramName + " " + vbCrLf
                        Else
                            strWhere += "upper(" + lCriterio.ColumnName + ") LIKE :" + paramName + " " + vbCrLf
                        End If
                    Case "%LOWER(*)%", "LOWER(*)%", "%LOWER(*)"
                        If lCriterio.TableAlias <> "" Then
                            strWhere += "lower(" + lCriterio.TableAlias + "." + lCriterio.ColumnName + ") LIKE :" + paramName + " " + vbCrLf
                        Else
                            strWhere += "lower(" + lCriterio.ColumnName + ") LIKE :" + paramName + " " + vbCrLf
                        End If
                    Case "RTRIM(*)"
                        If lCriterio.TableAlias <> "" Then
                            strWhere += "RTRIM(" + lCriterio.TableAlias + "." + lCriterio.ColumnName + ") = :" + paramName + " " + vbCrLf
                        Else
                            strWhere += "RTRIM(" + lCriterio.ColumnName + ") = :" + paramName + " " + vbCrLf
                        End If
                    Case "LTRIM(*)"
                        If lCriterio.TableAlias <> "" Then
                            strWhere += "LTRIM(" + lCriterio.TableAlias + "." + lCriterio.ColumnName + ") = :" + paramName + " " + vbCrLf
                        Else
                            strWhere += "LTRIM(" + lCriterio.ColumnName + ") = :" + paramName + " " + vbCrLf
                        End If
                    Case Else
                        If lCriterio.TableAlias <> "" Then
                            strWhere += lCriterio.TableAlias + "." + lCriterio.ColumnName + " " + lCriterio.Compare + " :" + paramName + " " + vbCrLf
                        Else
                            strWhere += lCriterio.ColumnName + " " + lCriterio.Compare + " :" + paramName + " " + vbCrLf
                        End If
                End Select
            Else
                Select Case lCriterio.Compare
                    Case "%*%", "*%", "%*"
                        If lCriterio.TableAlias <> "" Then
                            strWhere += lCriterio.TableAlias + "." + atributoColumna.Storage + " LIKE :" + paramName + " " + vbCrLf
                        Else
                            strWhere += atributoColumna.Storage + " LIKE :" + paramName + " " + vbCrLf
                        End If
                    Case "UPPER(*)"
                        If lCriterio.TableAlias <> "" Then
                            strWhere += "upper(" + lCriterio.TableAlias + "." + atributoColumna.Storage + ") = :" + paramName + " " + vbCrLf
                        Else
                            strWhere += "upper(" + atributoColumna.Storage + ") = :" + paramName + " " + vbCrLf
                        End If
                    Case "LOWER(*)"
                        If lCriterio.TableAlias <> "" Then
                            strWhere += "lower(" + lCriterio.TableAlias + "." + atributoColumna.Storage + ") = :" + paramName + " " + vbCrLf
                        Else
                            strWhere += "lower(" + atributoColumna.Storage + ") = :" + paramName + " " + vbCrLf
                        End If
                    Case "%UPPER(*)%", "UPPER(*)%", "%UPPER(*)"
                        If lCriterio.TableAlias <> "" Then
                            strWhere += "upper(" + lCriterio.TableAlias + "." + atributoColumna.Storage + ") LIKE :" + paramName + " " + vbCrLf
                        Else
                            strWhere += "upper(" + atributoColumna.Storage + ") LIKE :" + paramName + " " + vbCrLf
                        End If
                    Case "%LOWER(*)%", "LOWER(*)%", "%LOWER(*)"
                        If lCriterio.TableAlias <> "" Then
                            strWhere += "lower(" + lCriterio.TableAlias + "." + atributoColumna.Storage + ") LIKE :" + paramName + " " + vbCrLf
                        Else
                            strWhere += "lower(" + atributoColumna.Storage + ") LIKE :" + paramName + " " + vbCrLf
                        End If
                    Case "RTRIM(*)"
                        If lCriterio.TableAlias <> "" Then
                            strWhere += "RTRIM(" + lCriterio.TableAlias + "." + atributoColumna.Storage + ") = :" + paramName + " " + vbCrLf
                        Else
                            strWhere += "RTRIM(" + atributoColumna.Storage + ") = :" + paramName + " " + vbCrLf
                        End If
                    Case "LTRIM(*)"
                        If lCriterio.TableAlias <> "" Then
                            strWhere += "LTRIM(" + lCriterio.TableAlias + "." + atributoColumna.Storage + ") = :" + paramName + " " + vbCrLf
                        Else
                            strWhere += "LTRIM(" + atributoColumna.Storage + ") = :" + paramName + " " + vbCrLf
                        End If
                    Case Else
                        If lCriterio.TableAlias <> "" Then
                            strWhere += lCriterio.TableAlias + "." + atributoColumna.Storage + " " + lCriterio.Compare + " :" + paramName + " " + vbCrLf
                        Else
                            strWhere += atributoColumna.Storage + " " + lCriterio.Compare + " :" + paramName + " " + vbCrLf
                        End If
                End Select
            End If

            countArgs += 1
            Dim i As Integer = 0
            If countArgs - 1 > 0 Then
                Dim tempArgs As Object = args
                ReDim args(countArgs - 1)
                For Each arg As IDbDataParameter In CType(tempArgs, IDbDataParameter())
                    args(i) = CType(arg, OracleParameter)
                    i += 1
                Next
            End If
            args(i) = CType(Assembly.GetAssembly(GetType(OracleParameter)).CreateInstance(GetType(OracleParameter).FullName.Replace("[]", "")), OracleParameter)
            args(i).OracleType = Me.TipoParametro(PropiedadDestino.PropertyType.FullName)
            args(i).ParameterName = paramName
            Select Case lCriterio.Compare
                Case "%*%"
                    args(i).Value = "%" + lCriterio.DataValue + "%"
                Case "*%"
                    args(i).Value = lCriterio.DataValue + "%"
                Case "%*"
                    args(i).Value = "%" + lCriterio.DataValue
                Case "UPPER(*)"
                    args(i).Value = lCriterio.DataValue.ToUpper()
                Case "LOWER(*)"
                    args(i).Value = lCriterio.DataValue.ToUpper()
                Case "%UPPER(*)%"
                    args(i).Value = "%" + lCriterio.DataValue.ToUpper() + "%"
                Case "UPPER(*)%"
                    args(i).Value = lCriterio.DataValue.ToUpper() + "%"
                Case "%UPPER(*)"
                    args(i).Value = "%" + lCriterio.DataValue.ToUpper()
                Case "%LOWER(*)%"
                    args(i).Value = "%" + lCriterio.DataValue.ToLower() + "%"
                Case "LOWER(*)%"
                    args(i).Value = lCriterio.DataValue.ToLower() + "%"
                Case "%LOWER(*)"
                    args(i).Value = "%" + lCriterio.DataValue.ToLower()
                Case Else
                    args(i).Value = lCriterio.DataValue
            End Select
        Next
        strSQL.Append(strWhere)

        If asColumnaOrden <> "" Then
            strSQL.AppendLine(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader
        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As IBindingListView = CType(System.Reflection.Assembly.Load("SGAFP_EL").CreateInstance("SGAFP.EL.lista" + tipoEntidad.Name), IBindingListView)

        Try
            Do While dr.Read()
                Dim mEntidad As entidadBase = CType(System.Reflection.Assembly.Load("SGAFP_EL").CreateInstance("SGAFP.EL." + tipoEntidad.Name), entidadBase)
                Me.CargarEntidad(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Public Sub AgregarCondicion(ByRef sql As StringBuilder, ByVal condicion As String, Optional ByVal tipoCondicion As String = " WHERE ")
        If sql.Length = 0 Then sql.Append(tipoCondicion) Else sql.Append(" AND ")
        sql.AppendLine(condicion)
    End Sub
End Class
