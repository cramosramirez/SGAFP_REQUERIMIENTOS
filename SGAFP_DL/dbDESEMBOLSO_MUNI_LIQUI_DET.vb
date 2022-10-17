Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_DL
''' Class	 : DL.dbDESEMBOLSO_MUNI_LIQUI_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla DESEMBOLSO_MUNI_LIQUI_DET
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/04/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbDESEMBOLSO_MUNI_LIQUI_DET
    Inherits dbBase

#Region " Metodos Generador "

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Actualizar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de 
    ''' parámetro; en el caso de que sea actualizar toma en cuenta el Tipo de 
    ''' Concurrencia recibida de parametro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia del Registro a Actualizar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As DESEMBOLSO_MUNI_LIQUI_DET
        lEntidad = CType(aEntidad, DESEMBOLSO_MUNI_LIQUI_DET)

        Dim lID As Decimal
        If lEntidad.ID_DESEMBOLSO_MUNI =  0 _
            Or lEntidad.ID_DESEMBOLSO_MUNI = Nothing Then 

            lID = CType(Me.ObtenerID(lEntidad), Decimal)

            If lID = -1 Then Return -1

            lEntidad.ID_DESEMBOLSO_MUNI = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder

        CType(aEntidad, DESEMBOLSO_MUNI_LIQUI_DET).LASTUPDATE = Now
        CType(aEntidad, DESEMBOLSO_MUNI_LIQUI_DET).USERID = EL.configuracion.usuarioActualiza

        Dim args(0) As OracleParameter

        strSQL.Append(Me.QueryUpdate(aEntidad, args, aTipoConcurrencia))

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Ingresa un registro de la Entidad que recibe como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados al menos los
    ''' valores de la Llave Primaria, para su inserción.</remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim strSQL As New StringBuilder

        CType(aEntidad, DESEMBOLSO_MUNI_LIQUI_DET).LASTUPDATE = Now
        CType(aEntidad, DESEMBOLSO_MUNI_LIQUI_DET).USERID = EL.configuracion.usuarioActualiza

        Dim args(0) As OracleParameter

        strSQL.Append(Me.QueryInsert(aEntidad, args))


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla DESEMBOLSO_MUNI_LIQUI_DET que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla DESEMBOLSO_MUNI_LIQUI_DET que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Eliminar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As OracleParameter

        strSQL.Append(Me.QueryDelete(aEntidad, args, aTipoConcurrencia))

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un registro y lo setea en la Entidad que recibe de
    ''' parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde se ingresara el registro seleccionado.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As OracleParameter

        strSQL.Append(Me.QuerySelect(aEntidad, args))

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dr Is Nothing Then Return 0

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarDESEMBOLSO_MUNI_LIQUI_DET(dr, CType(aEntidad,DESEMBOLSO_MUNI_LIQUI_DET))
            Else
                Return 0
            End If
        Catch ex As Exception 
            Throw ex
        Finally
            dr.Close()
        End Try

        Return 1

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un registro y lo setea en la Entidad que recibe de
    ''' parámetro, ademas de permitir agregar en la Entidad las Foraneas.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde se ingresara el registro seleccionado.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As DESEMBOLSO_MUNI_LIQUI_DET, Optional ByVal aDESEMBOLSO As Boolean = False, Optional ByVal aMUNICIPIO_LIQUIDACION_DET As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As OracleParameter

        If aDESEMBOLSO Or aMUNICIPIO_LIQUIDACION_DET Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(DESEMBOLSO_MUNI_LIQUI_DET), GetType(OracleParameter), strCampos, strWhere, 0, "DESEMBOLSO_MUNI_LIQUI_DET")
            strSQL.AppendLine("SELECT " + strCampos)
            If aDESEMBOLSO Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New DESEMBOLSO, Nothing, GetType(DESEMBOLSO), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aMUNICIPIO_LIQUIDACION_DET Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New MUNICIPIO_LIQUIDACION_DET, Nothing, GetType(MUNICIPIO_LIQUIDACION_DET), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM DESEMBOLSO_MUNI_LIQUI_DET")
            numTabla = 0
            If aDESEMBOLSO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN DESEMBOLSO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_DESEMBOLSO = DESEMBOLSO_MUNI_LIQUI_DET.ID_DESEMBOLSO")
            End If
            If aMUNICIPIO_LIQUIDACION_DET Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN MUNICIPIO_LIQUIDACION_DET T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_LIQUIDACION_DET = DESEMBOLSO_MUNI_LIQUI_DET.ID_LIQUIDACION_DET")
            End If
            strSQL.Append(strWhere)
        Else
            strSQL.Append(Me.QuerySelect(aEntidad, args))
        End If

        Dim dr As IDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dr Is Nothing Then Return 0

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarDESEMBOLSO_MUNI_LIQUI_DET(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aDESEMBOLSO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarDESEMBOLSO(dr, aEntidad.fkID_DESEMBOLSO, "T" + numTabla.ToString())
                End If
                If aMUNICIPIO_LIQUIDACION_DET Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarMUNICIPIO_LIQUIDACION_DET(dr, aEntidad.fkID_LIQUIDACION_DET, "T" + numTabla.ToString())
                End If
            Else
                Return 0
            End If
        Catch ex As Exception 
            Throw ex
        Finally
            dr.Close()
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Object

        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT NVL(MAX(ID_DESEMBOLSO_MUNI),0) + 1 ")
        strSQL.AppendLine(" FROM DESEMBOLSO_MUNI_LIQUI_DET ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaDESEMBOLSO_MUNI_LIQUI_DET

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DESEMBOLSO_MUNI_LIQUI_DET))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim dr As IDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaDESEMBOLSO_MUNI_LIQUI_DET

        Try
            Do While dr.Read()
                Dim mEntidad As New DESEMBOLSO_MUNI_LIQUI_DET
                dbAsignarEntidades.AsignarDESEMBOLSO_MUNI_LIQUI_DET(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre devuelve todos los registros de la Entidad.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DESEMBOLSO_MUNI_LIQUI_DET))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim ds As DataSet

        ds = sql.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que llena un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre llena con todos los registros de la Entidad.
    ''' </summary>
    ''' <param name="ds"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DESEMBOLSO_MUNI_LIQUI_DET))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim tables(0) As String
        tables(0) = New String("DESEMBOLSO_MUNI_LIQUI_DET".ToCharArray())

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve en el StringBuilder que recibe como parámetro el Query
    ''' de la Tabla de la Clase.
    ''' </summary>
    ''' <param name="strSQL">StringBuilder donde se escribe el Query</param>
    ''' <remarks>
    ''' Obsoleto, se recomienda utilizar los métodos del ancestro para esta operación.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT DESEMBOLSO_MUNI_LIQUI_DET.ID_DESEMBOLSO_MUNI, ")
        strSQL.AppendLine(" DESEMBOLSO_MUNI_LIQUI_DET.ID_DESEMBOLSO, ")
        strSQL.AppendLine(" DESEMBOLSO_MUNI_LIQUI_DET.ID_LIQUIDACION_DET, ")
        strSQL.AppendLine(" DESEMBOLSO_MUNI_LIQUI_DET.MONTO_DESEMBOLSO, ")
        strSQL.AppendLine(" DESEMBOLSO_MUNI_LIQUI_DET.USERID, ")
        strSQL.AppendLine(" DESEMBOLSO_MUNI_LIQUI_DET.LASTUPDATE ")
        strSQL.AppendLine(" FROM DESEMBOLSO_MUNI_LIQUI_DET ")

    End Sub

#Region "Obtener Listas Por Foraneas"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_DESEMBOLSO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorDESEMBOLSO(ByVal ID_DESEMBOLSO As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaDESEMBOLSO_MUNI_LIQUI_DET

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DESEMBOLSO_MUNI_LIQUI_DET))
        strSQL.Append(" WHERE ID_DESEMBOLSO = :ID_DESEMBOLSO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_DESEMBOLSO", OracleType.Number)
        args(0).Value = ID_DESEMBOLSO

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaDESEMBOLSO_MUNI_LIQUI_DET

        Try
            Do While dr.Read()
                Dim mEntidad As New DESEMBOLSO_MUNI_LIQUI_DET
                dbAsignarEntidades.AsignarDESEMBOLSO_MUNI_LIQUI_DET(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_LIQUIDACION_DET"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorMUNICIPIO_LIQUIDACION_DET(ByVal ID_LIQUIDACION_DET As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaDESEMBOLSO_MUNI_LIQUI_DET

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New DESEMBOLSO_MUNI_LIQUI_DET))
        strSQL.Append(" WHERE ID_LIQUIDACION_DET = :ID_LIQUIDACION_DET ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_LIQUIDACION_DET", OracleType.Number)
        args(0).Value = ID_LIQUIDACION_DET

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaDESEMBOLSO_MUNI_LIQUI_DET

        Try
            Do While dr.Read()
                Dim mEntidad As New DESEMBOLSO_MUNI_LIQUI_DET
                dbAsignarEntidades.AsignarDESEMBOLSO_MUNI_LIQUI_DET(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

#End Region

#End Region

End Class
