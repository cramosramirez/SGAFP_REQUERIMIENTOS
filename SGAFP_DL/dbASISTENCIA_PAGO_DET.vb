Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_DL
''' Class	 : DL.dbASISTENCIA_PAGO_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla ASISTENCIA_PAGO_DET
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	30/01/2022	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbASISTENCIA_PAGO_DET
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
    ''' 	[GenApp]	30/01/2022	Created
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
    ''' 	[GenApp]	30/01/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As ASISTENCIA_PAGO_DET
        lEntidad = CType(aEntidad, ASISTENCIA_PAGO_DET)

        Dim lID As Decimal
        If lEntidad.ID_ASISTE_PAGO_DET =  0 _
            Or lEntidad.ID_ASISTE_PAGO_DET = Nothing Then 

            lID = CType(Me.ObtenerID(lEntidad), Decimal)

            If lID = -1 Then Return -1

            lEntidad.ID_ASISTE_PAGO_DET = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder


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
    ''' 	[GenApp]	30/01/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim strSQL As New StringBuilder


        Dim args(0) As OracleParameter

        strSQL.Append(Me.QueryInsert(aEntidad, args))


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ASISTENCIA_PAGO_DET que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/01/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ASISTENCIA_PAGO_DET que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/01/2022	Created
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
    ''' 	[GenApp]	30/01/2022	Created
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
                dbAsignarEntidades.AsignarASISTENCIA_PAGO_DET(dr, CType(aEntidad,ASISTENCIA_PAGO_DET))
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
    ''' 	[GenApp]	30/01/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As ASISTENCIA_PAGO_DET, Optional ByVal aASISTENCIA_PAGO As Boolean = False, Optional ByVal aMODALIDAD_DE_FORMACION As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As OracleParameter

        If aASISTENCIA_PAGO Or aMODALIDAD_DE_FORMACION Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(ASISTENCIA_PAGO_DET), GetType(OracleParameter), strCampos, strWhere, 0, "ASISTENCIA_PAGO_DET")
            strSQL.AppendLine("SELECT " + strCampos)
            If aASISTENCIA_PAGO Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New ASISTENCIA_PAGO, Nothing, GetType(ASISTENCIA_PAGO), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aMODALIDAD_DE_FORMACION Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New MODALIDAD_DE_FORMACION, Nothing, GetType(MODALIDAD_DE_FORMACION), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM ASISTENCIA_PAGO_DET")
            numTabla = 0
            If aASISTENCIA_PAGO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN ASISTENCIA_PAGO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_ASISTE_PAGO = ASISTENCIA_PAGO_DET.ID_ASISTE_PAGO")
            End If
            If aMODALIDAD_DE_FORMACION Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN MODALIDAD_DE_FORMACION T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_MODALIDAD_FORMACION = ASISTENCIA_PAGO_DET.ID_MODALIDAD_FORMACION")
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
                dbAsignarEntidades.AsignarASISTENCIA_PAGO_DET(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aASISTENCIA_PAGO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarASISTENCIA_PAGO(dr, aEntidad.fkID_ASISTE_PAGO, "T" + numTabla.ToString())
                End If
                If aMODALIDAD_DE_FORMACION Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarMODALIDAD_DE_FORMACION(dr, aEntidad.fkID_MODALIDAD_FORMACION, "T" + numTabla.ToString())
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
        strSQL.AppendLine("SELECT NVL(MAX(ID_ASISTE_PAGO_DET),0) + 1 ")
        strSQL.AppendLine(" FROM ASISTENCIA_PAGO_DET ")

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
    ''' 	[GenApp]	30/01/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaASISTENCIA_PAGO_DET

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ASISTENCIA_PAGO_DET))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim dr As IDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaASISTENCIA_PAGO_DET

        Try
            Do While dr.Read()
                Dim mEntidad As New ASISTENCIA_PAGO_DET
                dbAsignarEntidades.AsignarASISTENCIA_PAGO_DET(dr, mEntidad)
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
    ''' 	[GenApp]	30/01/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ASISTENCIA_PAGO_DET))
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
    ''' 	[GenApp]	30/01/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ASISTENCIA_PAGO_DET))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim tables(0) As String
        tables(0) = New String("ASISTENCIA_PAGO_DET".ToCharArray())

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
    ''' 	[GenApp]	30/01/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT ASISTENCIA_PAGO_DET.ID_ASISTE_PAGO_DET, ")
        strSQL.AppendLine(" ASISTENCIA_PAGO_DET.ID_ASISTE_PAGO, ")
        strSQL.AppendLine(" ASISTENCIA_PAGO_DET.ID_MODALIDAD_FORMACION, ")
        strSQL.AppendLine(" ASISTENCIA_PAGO_DET.PORC_ASISTE_INI, ")
        strSQL.AppendLine(" ASISTENCIA_PAGO_DET.PORC_ASISTE_FIN, ")
        strSQL.AppendLine(" ASISTENCIA_PAGO_DET.PORC_PAGO_COSTO_PARTI, ")
        strSQL.AppendLine(" ASISTENCIA_PAGO_DET.USUARIO_CREA, ")
        strSQL.AppendLine(" ASISTENCIA_PAGO_DET.FECHA_CREA, ")
        strSQL.AppendLine(" ASISTENCIA_PAGO_DET.USUARIO_ACT, ")
        strSQL.AppendLine(" ASISTENCIA_PAGO_DET.FECHA_ACT ")
        strSQL.AppendLine(" FROM ASISTENCIA_PAGO_DET ")

    End Sub

#Region "Obtener Listas Por Foraneas"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_ASISTE_PAGO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/01/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorASISTENCIA_PAGO(ByVal ID_ASISTE_PAGO As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaASISTENCIA_PAGO_DET

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ASISTENCIA_PAGO_DET))
        strSQL.Append(" WHERE ID_ASISTE_PAGO = :ID_ASISTE_PAGO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_ASISTE_PAGO", OracleType.Number)
        args(0).Value = ID_ASISTE_PAGO

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaASISTENCIA_PAGO_DET

        Try
            Do While dr.Read()
                Dim mEntidad As New ASISTENCIA_PAGO_DET
                dbAsignarEntidades.AsignarASISTENCIA_PAGO_DET(dr, mEntidad)
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
    ''' <param name="ID_MODALIDAD_FORMACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	30/01/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorMODALIDAD_DE_FORMACION(ByVal ID_MODALIDAD_FORMACION As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaASISTENCIA_PAGO_DET

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ASISTENCIA_PAGO_DET))
        strSQL.Append(" WHERE ID_MODALIDAD_FORMACION = :ID_MODALIDAD_FORMACION ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_MODALIDAD_FORMACION", OracleType.Number)
        args(0).Value = ID_MODALIDAD_FORMACION

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaASISTENCIA_PAGO_DET

        Try
            Do While dr.Read()
                Dim mEntidad As New ASISTENCIA_PAGO_DET
                dbAsignarEntidades.AsignarASISTENCIA_PAGO_DET(dr, mEntidad)
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
