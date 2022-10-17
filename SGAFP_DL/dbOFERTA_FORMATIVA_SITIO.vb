Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_DL
''' Class	 : DL.dbOFERTA_FORMATIVA_SITIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla OFERTA_FORMATIVA_SITIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	25/09/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbOFERTA_FORMATIVA_SITIO
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
    ''' 	[GenApp]	25/09/2012	Created
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
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As OFERTA_FORMATIVA_SITIO
        lEntidad = CType(aEntidad, OFERTA_FORMATIVA_SITIO)


        Dim strSQL As New StringBuilder

        CType(aEntidad, OFERTA_FORMATIVA_SITIO).LASTUPDATE = Now

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
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim strSQL As New StringBuilder

        CType(aEntidad, OFERTA_FORMATIVA_SITIO).LASTUPDATE = Now

        Dim args(0) As OracleParameter

        strSQL.Append(Me.QueryInsert(aEntidad, args))


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla OFERTA_FORMATIVA_SITIO que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla OFERTA_FORMATIVA_SITIO que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/09/2012	Created
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
    ''' 	[GenApp]	25/09/2012	Created
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
                dbAsignarEntidades.AsignarOFERTA_FORMATIVA_SITIO(dr, CType(aEntidad,OFERTA_FORMATIVA_SITIO))
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
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As OFERTA_FORMATIVA_SITIO, Optional ByVal aOFERTA_FORMATIVA As Boolean = False, Optional ByVal aPROVEEDOR_AF As Boolean = False, Optional ByVal aSITIO_CAPACITACION As Boolean = False, Optional ByVal aSITIO_CAPACITACION_EJERCICIO As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As OracleParameter

        If aOFERTA_FORMATIVA Or aPROVEEDOR_AF Or aSITIO_CAPACITACION Or aSITIO_CAPACITACION_EJERCICIO Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(OFERTA_FORMATIVA_SITIO), GetType(OracleParameter), strCampos, strWhere, 0, "OFERTA_FORMATIVA_SITIO")
            strSQL.AppendLine("SELECT " + strCampos)
            If aOFERTA_FORMATIVA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New OFERTA_FORMATIVA, Nothing, GetType(OFERTA_FORMATIVA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aPROVEEDOR_AF Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New PROVEEDOR_AF, Nothing, GetType(PROVEEDOR_AF), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aSITIO_CAPACITACION Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New SITIO_CAPACITACION, Nothing, GetType(SITIO_CAPACITACION), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aSITIO_CAPACITACION_EJERCICIO Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New SITIO_CAPACITACION_EJERCICIO, Nothing, GetType(SITIO_CAPACITACION_EJERCICIO), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM OFERTA_FORMATIVA_SITIO")
            numTabla = 0
            If aOFERTA_FORMATIVA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN OFERTA_FORMATIVA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_OFERTA_FORMATIVA = OFERTA_FORMATIVA_SITIO.ID_OFERTA_FORMATIVA")
            End If
            If aPROVEEDOR_AF Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN PROVEEDOR_AF T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_PROVEEDOR_AF = OFERTA_FORMATIVA_SITIO.ID_PROVEEDOR_AF")
            End If
            If aSITIO_CAPACITACION Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN SITIO_CAPACITACION T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_SITIO_CAPACITACION = OFERTA_FORMATIVA_SITIO.ID_SITIO_CAPACITACION")
            End If
            If aSITIO_CAPACITACION_EJERCICIO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN SITIO_CAPACITACION_EJERCICIO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_EJERCICIO = OFERTA_FORMATIVA_SITIO.ID_EJERCICIO")
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
                dbAsignarEntidades.AsignarOFERTA_FORMATIVA_SITIO(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aOFERTA_FORMATIVA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarOFERTA_FORMATIVA(dr, aEntidad.fkID_OFERTA_FORMATIVA, "T" + numTabla.ToString())
                End If
                If aPROVEEDOR_AF Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarPROVEEDOR_AF(dr, aEntidad.fkID_PROVEEDOR_AF, "T" + numTabla.ToString())
                End If
                If aSITIO_CAPACITACION Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarSITIO_CAPACITACION(dr, aEntidad.fkID_SITIO_CAPACITACION, "T" + numTabla.ToString())
                End If
                If aSITIO_CAPACITACION_EJERCICIO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarSITIO_CAPACITACION_EJERCICIO(dr, aEntidad.fkID_EJERCICIO, "T" + numTabla.ToString())
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

        Return -1

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_EJERCICIO As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaOFERTA_FORMATIVA_SITIO

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New OFERTA_FORMATIVA_SITIO))
        strSQL.Append(" WHERE ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ") 
        strSQL.Append(" AND ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION ") 
        strSQL.Append(" AND ID_EJERCICIO = :ID_EJERCICIO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(2) As OracleParameter
        args(0) = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
        args(0).Value = ID_PROVEEDOR_AF
        args(1) = New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Number)
        args(1).Value = ID_SITIO_CAPACITACION
        args(2) = New OracleParameter(":ID_EJERCICIO", OracleType.VarChar)
        args(2).Value = ID_EJERCICIO

        Dim dr As IDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaOFERTA_FORMATIVA_SITIO

        Try
            Do While dr.Read()
                Dim mEntidad As New OFERTA_FORMATIVA_SITIO
                dbAsignarEntidades.AsignarOFERTA_FORMATIVA_SITIO(dr, mEntidad)
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
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_EJERCICIO As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New OFERTA_FORMATIVA_SITIO))
        strSQL.Append(" WHERE ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ") 
        strSQL.Append(" AND ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION ") 
        strSQL.Append(" AND ID_EJERCICIO = :ID_EJERCICIO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(2) As OracleParameter
        args(0) = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
        args(0).Value = ID_PROVEEDOR_AF
        args(1) = New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Number)
        args(1).Value = ID_SITIO_CAPACITACION
        args(2) = New OracleParameter(":ID_EJERCICIO", OracleType.VarChar)
        args(2).Value = ID_EJERCICIO

        Dim ds As DataSet

        ds = sql.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que llena un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre llena con todos los registros de la Entidad.
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <param name="ds"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_EJERCICIO As String, ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New OFERTA_FORMATIVA_SITIO))
        strSQL.Append(" WHERE ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ") 
        strSQL.Append(" AND ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION ") 
        strSQL.Append(" AND ID_EJERCICIO = :ID_EJERCICIO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(2) As OracleParameter
        args(0) = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
        args(0).Value = ID_PROVEEDOR_AF
        args(1) = New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Number)
        args(1).Value = ID_SITIO_CAPACITACION
        args(2) = New OracleParameter(":ID_EJERCICIO", OracleType.VarChar)
        args(2).Value = ID_EJERCICIO

        Dim tables(0) As String
        tables(0) = New String("OFERTA_FORMATIVA_SITIO".ToCharArray())

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

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
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT OFERTA_FORMATIVA_SITIO.ID_OFERTA_FORMATIVA, ")
        strSQL.AppendLine(" OFERTA_FORMATIVA_SITIO.ID_PROVEEDOR_AF, ")
        strSQL.AppendLine(" OFERTA_FORMATIVA_SITIO.ID_SITIO_CAPACITACION, ")
        strSQL.AppendLine(" OFERTA_FORMATIVA_SITIO.ID_EJERCICIO, ")
        strSQL.AppendLine(" OFERTA_FORMATIVA_SITIO.DURACION_HORAS, ")
        strSQL.AppendLine(" OFERTA_FORMATIVA_SITIO.COSTO_X_PARTICIPANTE, ")
        strSQL.AppendLine(" OFERTA_FORMATIVA_SITIO.USER_ID, ")
        strSQL.AppendLine(" OFERTA_FORMATIVA_SITIO.LASTUPDATE, ")
        strSQL.AppendLine(" OFERTA_FORMATIVA_SITIO.PARTICIPACION_ADJUDICADA, ")
        strSQL.AppendLine(" OFERTA_FORMATIVA_SITIO.MONTO_ADJUDICADO ")
        strSQL.AppendLine(" FROM OFERTA_FORMATIVA_SITIO ")

    End Sub

#Region "Obtener Listas Por Foraneas"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' las Columnas de la LLave de la Tabla OFERTA_FORMATIVA.
    ''' </summary>
    ''' <param name="ID_OFERTA_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorOFERTA_FORMATIVA(ByVal ID_OFERTA_FORMATIVA As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaOFERTA_FORMATIVA_SITIO

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New OFERTA_FORMATIVA_SITIO))
        strSQL.Append(" WHERE ID_OFERTA_FORMATIVA = :ID_OFERTA_FORMATIVA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_OFERTA_FORMATIVA", OracleType.Number)
        args(0).Value = ID_OFERTA_FORMATIVA

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaOFERTA_FORMATIVA_SITIO

        Try
            Do While dr.Read()
                Dim mEntidad As New OFERTA_FORMATIVA_SITIO
                dbAsignarEntidades.AsignarOFERTA_FORMATIVA_SITIO(dr, mEntidad)
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
    ''' las Columnas de la LLave de la Tabla PROVEEDOR_AF.
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaOFERTA_FORMATIVA_SITIO

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New OFERTA_FORMATIVA_SITIO))
        strSQL.Append(" WHERE ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
        args(0).Value = ID_PROVEEDOR_AF

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaOFERTA_FORMATIVA_SITIO

        Try
            Do While dr.Read()
                Dim mEntidad As New OFERTA_FORMATIVA_SITIO
                dbAsignarEntidades.AsignarOFERTA_FORMATIVA_SITIO(dr, mEntidad)
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
    ''' las Columnas de la LLave de la Tabla SITIO_CAPACITACION.
    ''' </summary>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorSITIO_CAPACITACION(ByVal ID_SITIO_CAPACITACION As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaOFERTA_FORMATIVA_SITIO

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New OFERTA_FORMATIVA_SITIO))
        strSQL.Append(" WHERE ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Number)
        args(0).Value = ID_SITIO_CAPACITACION

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaOFERTA_FORMATIVA_SITIO

        Try
            Do While dr.Read()
                Dim mEntidad As New OFERTA_FORMATIVA_SITIO
                dbAsignarEntidades.AsignarOFERTA_FORMATIVA_SITIO(dr, mEntidad)
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
    ''' las Columnas de la LLave de la Tabla SITIO_CAPACITACION_EJERCICIO.
    ''' </summary>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorSITIO_CAPACITACION_EJERCICIO(ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_EJERCICIO As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaOFERTA_FORMATIVA_SITIO

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New OFERTA_FORMATIVA_SITIO))
        strSQL.Append(" WHERE ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION ") 
        strSQL.Append(" AND ID_EJERCICIO = :ID_EJERCICIO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Number)
        args(0).Value = ID_SITIO_CAPACITACION
        args(1) = New OracleParameter(":ID_EJERCICIO", OracleType.VarChar)
        args(1).Value = ID_EJERCICIO

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaOFERTA_FORMATIVA_SITIO

        Try
            Do While dr.Read()
                Dim mEntidad As New OFERTA_FORMATIVA_SITIO
                dbAsignarEntidades.AsignarOFERTA_FORMATIVA_SITIO(dr, mEntidad)
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
