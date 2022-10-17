Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_DL
''' Class	 : DL.dbACCION_FORMATIVA_REPROG
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla ACCION_FORMATIVA_REPROG
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/06/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbACCION_FORMATIVA_REPROG
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
    ''' 	[GenApp]	01/06/2010	Created
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
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As ACCION_FORMATIVA_REPROG
        lEntidad = CType(aEntidad, ACCION_FORMATIVA_REPROG)

        Dim lID As Decimal
        If lEntidad.ID_ACCION_FORMATIVA_REPROG =  0 _
            Or lEntidad.ID_ACCION_FORMATIVA_REPROG = Nothing Then 

            lID = CType(Me.ObtenerID(lEntidad), Decimal)

            If lID = -1 Then Return -1

            lEntidad.ID_ACCION_FORMATIVA_REPROG = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder

        CType(aEntidad, ACCION_FORMATIVA_REPROG).LASTUPDATE = Now

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
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim strSQL As New StringBuilder

        CType(aEntidad, ACCION_FORMATIVA_REPROG).LASTUPDATE = Now

        Dim args(0) As OracleParameter

        strSQL.Append(Me.QueryInsert(aEntidad, args))


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ACCION_FORMATIVA_REPROG que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ACCION_FORMATIVA_REPROG que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
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
    ''' 	[GenApp]	01/06/2010	Created
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
                dbAsignarEntidades.AsignarACCION_FORMATIVA_REPROG(dr, CType(aEntidad, ACCION_FORMATIVA_REPROG))
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
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As ACCION_FORMATIVA_REPROG, Optional ByVal aESTADO_REPROG As Boolean = False, Optional ByVal aOFERTA_FORMATIVA As Boolean = False, Optional ByVal aSITIO_CAPACITACION As Boolean = False, Optional ByVal aPROVEEDOR_AF As Boolean = False, Optional ByVal aESTADO_ACCION_FORMATIVA As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As OracleParameter

        If aESTADO_REPROG Or aOFERTA_FORMATIVA Or aSITIO_CAPACITACION Or aPROVEEDOR_AF Or aESTADO_ACCION_FORMATIVA Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(ACCION_FORMATIVA_REPROG), GetType(OracleParameter), strCampos, strWhere, 0, "ACCION_FORMATIVA_REPROG")
            strSQL.AppendLine("SELECT " + strCampos)
            If aESTADO_REPROG Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New ESTADO_REPROG, Nothing, GetType(ESTADO_REPROG), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aOFERTA_FORMATIVA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New OFERTA_FORMATIVA, Nothing, GetType(OFERTA_FORMATIVA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aSITIO_CAPACITACION Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New SITIO_CAPACITACION, Nothing, GetType(SITIO_CAPACITACION), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aPROVEEDOR_AF Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New PROVEEDOR_AF, Nothing, GetType(PROVEEDOR_AF), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aESTADO_ACCION_FORMATIVA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New ESTADO_ACCION_FORMATIVA, Nothing, GetType(ESTADO_ACCION_FORMATIVA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM ACCION_FORMATIVA_REPROG")
            numTabla = 0
            If aESTADO_REPROG Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN ESTADO_REPROG T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_ESTADO_REPROG = ACCION_FORMATIVA_REPROG.ID_ESTADO_REPROG")
            End If
            If aOFERTA_FORMATIVA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN OFERTA_FORMATIVA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_OFERTA_FORMATIVA = ACCION_FORMATIVA_REPROG.ID_OFERTA_FORMATIVA")
            End If
            If aSITIO_CAPACITACION Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN SITIO_CAPACITACION T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_SITIO_CAPACITACION = ACCION_FORMATIVA_REPROG.ID_SITIO_CAPACITACION")
            End If
            If aPROVEEDOR_AF Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN PROVEEDOR_AF T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_PROVEEDOR_AF = ACCION_FORMATIVA_REPROG.ID_PROVEEDOR_AF")
            End If
            If aESTADO_ACCION_FORMATIVA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN ESTADO_ACCION_FORMATIVA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".CODIGO_ESTADO_AF = ACCION_FORMATIVA_REPROG.CODIGO_ESTADO_AF")
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
                dbAsignarEntidades.AsignarACCION_FORMATIVA_REPROG(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aESTADO_REPROG Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarESTADO_REPROG(dr, aEntidad.fkID_ESTADO_REPROG, "T" + numTabla.ToString())
                End If
                If aOFERTA_FORMATIVA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarOFERTA_FORMATIVA(dr, aEntidad.fkID_OFERTA_FORMATIVA, "T" + numTabla.ToString())
                End If
                If aSITIO_CAPACITACION Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarSITIO_CAPACITACION(dr, aEntidad.fkID_SITIO_CAPACITACION, "T" + numTabla.ToString())
                End If
                If aPROVEEDOR_AF Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarPROVEEDOR_AF(dr, aEntidad.fkID_PROVEEDOR_AF, "T" + numTabla.ToString())
                End If
                If aESTADO_ACCION_FORMATIVA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarESTADO_ACCION_FORMATIVA(dr, aEntidad.fkCODIGO_ESTADO_AF, "T" + numTabla.ToString())
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
        strSQL.Append("SELECT NVL(MAX(ID_ACCION_FORMATIVA_REPROG),0) + 1 ")
        strSQL.Append(" FROM ACCION_FORMATIVA_REPROG ")

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
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaACCION_FORMATIVA_REPROG

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ACCION_FORMATIVA_REPROG))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim dr As OracleDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaACCION_FORMATIVA_REPROG

        Try
            Do While dr.Read()
                Dim mEntidad As New ACCION_FORMATIVA_REPROG
                dbAsignarEntidades.AsignarACCION_FORMATIVA_REPROG(dr, mEntidad)
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
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ACCION_FORMATIVA_REPROG))
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
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ACCION_FORMATIVA_REPROG))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim tables(0) As String
        tables(0) = New String("ACCION_FORMATIVA_REPROG".ToCharArray())

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
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT ACCION_FORMATIVA_REPROG.ID_ACCION_FORMATIVA_REPROG, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.ID_ESTADO_REPROG, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.ID_ACCION_FORMATIVA, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.ID_OFERTA_FORMATIVA, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.ID_SITIO_CAPACITACION, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.ID_PROVEEDOR_AF, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.ID_TEMA_CURSO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.ID_EJERCICIO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.NOMBRE_ACCION_FORMATIVA, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.CODIGO_GRUPO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.NUMERO_PARTICIPANTES, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.PARTICIPANTES_INSCRITOS, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.HORARIO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.NOTAS, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.CODIGO_ESTADO_AF, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.DURACION_HORAS, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.COSTO_X_PARTICIPANTE, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.LASTUPDATE, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.USERID, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.FECHA_INICIO_REAL, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.FECHA_FIN_REAL, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.MOTIVOREPROG, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.MOTIVORECHAZO, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.FECHA_SOLIC_REPROG, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.CODI_FORMADOR, ")
        strSQL.AppendLine(" ACCION_FORMATIVA_REPROG.NOMBRE_FORMADOR ")
        strSQL.AppendLine(" FROM ACCION_FORMATIVA_REPROG ")

    End Sub

#Region "Obtener Listas Por Foraneas"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_ESTADO_REPROG"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorESTADO_REPROG(ByVal ID_ESTADO_REPROG As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaACCION_FORMATIVA_REPROG

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ACCION_FORMATIVA_REPROG))
        strSQL.Append(" WHERE ID_ESTADO_REPROG = :ID_ESTADO_REPROG ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_ESTADO_REPROG", OracleType.Number)
        args(0).Value = ID_ESTADO_REPROG

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaACCION_FORMATIVA_REPROG

        Try
            Do While dr.Read()
                Dim mEntidad As New ACCION_FORMATIVA_REPROG
                dbAsignarEntidades.AsignarACCION_FORMATIVA_REPROG(dr, mEntidad)
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
    ''' <param name="ID_OFERTA_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorOFERTA_FORMATIVA(ByVal ID_OFERTA_FORMATIVA As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaACCION_FORMATIVA_REPROG

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ACCION_FORMATIVA_REPROG))
        strSQL.Append(" WHERE ID_OFERTA_FORMATIVA = :ID_OFERTA_FORMATIVA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_OFERTA_FORMATIVA", OracleType.Number)
        args(0).Value = ID_OFERTA_FORMATIVA

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaACCION_FORMATIVA_REPROG

        Try
            Do While dr.Read()
                Dim mEntidad As New ACCION_FORMATIVA_REPROG
                dbAsignarEntidades.AsignarACCION_FORMATIVA_REPROG(dr, mEntidad)
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
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorSITIO_CAPACITACION(ByVal ID_SITIO_CAPACITACION As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaACCION_FORMATIVA_REPROG

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ACCION_FORMATIVA_REPROG))
        strSQL.Append(" WHERE ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Number)
        args(0).Value = ID_SITIO_CAPACITACION

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaACCION_FORMATIVA_REPROG

        Try
            Do While dr.Read()
                Dim mEntidad As New ACCION_FORMATIVA_REPROG
                dbAsignarEntidades.AsignarACCION_FORMATIVA_REPROG(dr, mEntidad)
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
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaACCION_FORMATIVA_REPROG

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ACCION_FORMATIVA_REPROG))
        strSQL.Append(" WHERE ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
        args(0).Value = ID_PROVEEDOR_AF

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaACCION_FORMATIVA_REPROG

        Try
            Do While dr.Read()
                Dim mEntidad As New ACCION_FORMATIVA_REPROG
                dbAsignarEntidades.AsignarACCION_FORMATIVA_REPROG(dr, mEntidad)
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
    ''' <param name="CODIGO_ESTADO_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorESTADO_ACCION_FORMATIVA(ByVal CODIGO_ESTADO_AF As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaACCION_FORMATIVA_REPROG

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ACCION_FORMATIVA_REPROG))
        strSQL.Append(" WHERE CODIGO_ESTADO_AF = :CODIGO_ESTADO_AF ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":CODIGO_ESTADO_AF", OracleType.VarChar)
        args(0).Value = CODIGO_ESTADO_AF

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaACCION_FORMATIVA_REPROG

        Try
            Do While dr.Read()
                Dim mEntidad As New ACCION_FORMATIVA_REPROG
                dbAsignarEntidades.AsignarACCION_FORMATIVA_REPROG(dr, mEntidad)
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
