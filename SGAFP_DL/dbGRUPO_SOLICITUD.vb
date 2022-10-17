Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_DL
''' Class	 : DL.dbGRUPO_SOLICITUD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla GRUPO_SOLICITUD
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbGRUPO_SOLICITUD
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
    ''' 	[GenApp]	05/10/2012	Created
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
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As GRUPO_SOLICITUD
        lEntidad = CType(aEntidad, GRUPO_SOLICITUD)

        Dim lID As Decimal
        If lEntidad.ID_GRUPO_SOLICITUD = 0 _
            Or lEntidad.ID_GRUPO_SOLICITUD = Nothing Then

            lID = CType(Me.ObtenerID(lEntidad), Decimal)

            If lID = -1 Then Return -1

            lEntidad.ID_GRUPO_SOLICITUD = lID
            lEntidad.USUARIO_CREACION = EL.configuracion.usuarioActualiza
            lEntidad.FECHA_CREACION = Now

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder

        CType(aEntidad, GRUPO_SOLICITUD).LASTUPDATE = Now
        CType(aEntidad, GRUPO_SOLICITUD).USERID = EL.configuracion.usuarioActualiza

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
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim strSQL As New StringBuilder

        CType(aEntidad, GRUPO_SOLICITUD).LASTUPDATE = Now
        CType(aEntidad, GRUPO_SOLICITUD).USERID = EL.configuracion.usuarioActualiza

        Dim args(0) As OracleParameter

        strSQL.Append(Me.QueryInsert(aEntidad, args))


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla GRUPO_SOLICITUD que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla GRUPO_SOLICITUD que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
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
    ''' 	[GenApp]	05/10/2012	Created
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
                dbAsignarEntidades.AsignarGRUPO_SOLICITUD(dr, CType(aEntidad, GRUPO_SOLICITUD))
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
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As GRUPO_SOLICITUD, Optional ByVal aSOLICITUD_CAPACITACION As Boolean = False, Optional ByVal aMODALIDAD_DE_FORMACION As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As OracleParameter

        If aSOLICITUD_CAPACITACION Or aMODALIDAD_DE_FORMACION Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(GRUPO_SOLICITUD), GetType(OracleParameter), strCampos, strWhere, 0, "GRUPO_SOLICITUD")
            strSQL.AppendLine("SELECT " + strCampos)
            If aSOLICITUD_CAPACITACION Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New SOLICITUD_CAPACITACION, Nothing, GetType(SOLICITUD_CAPACITACION), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aMODALIDAD_DE_FORMACION Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New MODALIDAD_DE_FORMACION, Nothing, GetType(MODALIDAD_DE_FORMACION), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM GRUPO_SOLICITUD")
            numTabla = 0
            If aSOLICITUD_CAPACITACION Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN SOLICITUD_CAPACITACION T" + numTabla.ToString())
                strSQL.Append(" ON T" + numTabla.ToString() + ".ID_SOLICITUD = GRUPO_SOLICITUD.ID_SOLICITUD")
            End If
            If aMODALIDAD_DE_FORMACION Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN MODALIDAD_DE_FORMACION T" + numTabla.ToString())
                strSQL.Append(" ON T" + numTabla.ToString() + ".ID_MODALIDAD_FORMACION = GRUPO_SOLICITUD.ID_MODALIDAD_FORMACION")
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
                dbAsignarEntidades.AsignarGRUPO_SOLICITUD(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aSOLICITUD_CAPACITACION Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarSOLICITUD_CAPACITACION(dr, aEntidad.fkID_SOLICITUD, "T" + numTabla.ToString())
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
        strSQL.AppendLine("SELECT NVL(MAX(ID_GRUPO_SOLICITUD),0) + 1 ")
        strSQL.AppendLine(" FROM GRUPO_SOLICITUD ")

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
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaGRUPO_SOLICITUD

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New GRUPO_SOLICITUD))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim dr As IDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaGRUPO_SOLICITUD

        Try
            Do While dr.Read()
                Dim mEntidad As New GRUPO_SOLICITUD
                dbAsignarEntidades.AsignarGRUPO_SOLICITUD(dr, mEntidad)
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
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New GRUPO_SOLICITUD))
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
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByRef ds As DataSet, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New GRUPO_SOLICITUD))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim tables(0) As String
        tables(0) = New String("GRUPO_SOLICITUD".ToCharArray())

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
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL As StringBuilder)

        strSQL.AppendLine(" SELECT GRUPO_SOLICITUD.ID_GRUPO_SOLICITUD, ")
        strSQL.AppendLine(" GRUPO_SOLICITUD.ID_SOLICITUD, ")
        strSQL.AppendLine(" GRUPO_SOLICITUD.ID_MODALIDAD_FORMACION, ")
        strSQL.AppendLine(" GRUPO_SOLICITUD.CODIGO_PROGRAMA, ")
        strSQL.AppendLine(" GRUPO_SOLICITUD.DURACION_HORAS, ")
        strSQL.AppendLine(" GRUPO_SOLICITUD.NUM_PARTICIPANTES, ")
        strSQL.AppendLine(" GRUPO_SOLICITUD.TDR, ")
        strSQL.AppendLine(" GRUPO_SOLICITUD.USERID, ")
        strSQL.AppendLine(" GRUPO_SOLICITUD.LASTUPDATE, ")
        strSQL.AppendLine(" GRUPO_SOLICITUD.CORRELATIVO_GRUPO, ")
        strSQL.AppendLine(" GRUPO_SOLICITUD.USUARIO_CREACION, ")
        strSQL.AppendLine(" GRUPO_SOLICITUD.FECHA_CREACION, ")
        strSQL.AppendLine(" GRUPO_SOLICITUD.CODIGO_DEPARTAMENTO, ")
        strSQL.AppendLine(" GRUPO_SOLICITUD.CODIGO_MUNICIPIO, ")
        strSQL.AppendLine(" GRUPO_SOLICITUD.LUGAR_EJECUCION, ")
        strSQL.AppendLine(" GRUPO_SOLICITUD.NOMBRE_ACCION_FORMATIVA ")
        strSQL.AppendLine(" FROM GRUPO_SOLICITUD ")

    End Sub

#Region "Obtener Listas Por Foraneas"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorSOLICITUD_CAPACITACION(ByVal ID_SOLICITUD As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaGRUPO_SOLICITUD

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New GRUPO_SOLICITUD))
        strSQL.Append(" WHERE ID_SOLICITUD = :ID_SOLICITUD ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_SOLICITUD", OracleType.Number)
        args(0).Value = ID_SOLICITUD

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaGRUPO_SOLICITUD

        Try
            Do While dr.Read()
                Dim mEntidad As New GRUPO_SOLICITUD
                dbAsignarEntidades.AsignarGRUPO_SOLICITUD(dr, mEntidad)
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
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorMODALIDAD_DE_FORMACION(ByVal ID_MODALIDAD_FORMACION As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaGRUPO_SOLICITUD

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New GRUPO_SOLICITUD))
        strSQL.Append(" WHERE ID_MODALIDAD_FORMACION = :ID_MODALIDAD_FORMACION ")
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden)
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_MODALIDAD_FORMACION", OracleType.Number)
        args(0).Value = ID_MODALIDAD_FORMACION

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaGRUPO_SOLICITUD

        Try
            Do While dr.Read()
                Dim mEntidad As New GRUPO_SOLICITUD
                dbAsignarEntidades.AsignarGRUPO_SOLICITUD(dr, mEntidad)
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
