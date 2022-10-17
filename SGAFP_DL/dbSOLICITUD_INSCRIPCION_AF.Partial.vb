Imports System.Text

Partial Class dbSOLICITUD_INSCRIPCION_AF

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve el numero de Solicitudes pendientes de 
    ''' Aprobar/Rechazar/En Espera de un Curso Especifico
    ''' </summary>
    ''' <remarks></remarks>
    ''' <history>
    ''' 	[ecarias]	11/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCantidadPendienteAprobacionDenegacionPorCurso(ByVal ID_ACCION_FORMATIVA As Decimal) As Integer
        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT  COUNT(*) ")
        strSQL.AppendLine("FROM SOLICITUD_INSCRIPCION_AF ")
        strSQL.AppendLine("WHERE ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("AND (ID_ESTADO_SOLICITUD = 1 ")
        strSQL.AppendLine("OR ID_ESTADO_SOLICITUD = 2) ")

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Double)
        args(0).Value = ID_ACCION_FORMATIVA

        Return CInt(sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args))

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una lista de Registros de la tabla SOLICITUD_INSCRIPCION_AF
    ''' en base a los parametros recibidos.
    ''' </summary>
    ''' <remarks></remarks>
    ''' <history>
    ''' 	[ecarias]	16/03/2010	Created
    ''' 	[ecarias]	20/04/2010	Se agrego que convirtiera a Mayusculas las cadenas en SQL
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriterios(ByVal idSolicitud As Decimal, ByVal idProveedor As Decimal, _
                    ByVal idSitioCapacitacion As Decimal, ByVal idEjercicio As String, _
                    ByVal idEstadoSolicitud As Enumeradores.EstadoSolicitud, ByVal nombreAccionFormativa As String, _
                    ByVal codigoGrupo As String, _
                    ByVal nombresSolicitante As String, ByVal apellidosSolicitante As String) As listaSOLICITUD_INSCRIPCION_AF

        Dim strSQL As New StringBuilder
        Dim strSQLCondicion As New StringBuilder

        strSQL.AppendLine("SELECT SI.*, (SELECT SC.NOMBRE_SITIO FROM SITIO_CAPACITACION SC WHERE SC.ID_SITIO_CAPACITACION = AF.ID_SITIO_CAPACITACION) AS NOMBRE_SITIO ")
        strSQL.AppendLine(" FROM SOLICITUD_INSCRIPCION_AF SI ")
        strSQL.AppendLine(" JOIN ACCION_FORMATIVA AF ON AF.ID_ACCION_FORMATIVA = SI.ID_ACCION_FORMATIVA ")

        Dim args As New List(Of OracleParameter)

        If idSolicitud <> -1 Then
            Dim oParam As New OracleParameter(":ID_SOLICITUD", OracleType.Number)
            oParam.Value = idSolicitud
            args.Add(oParam)
            AgregarCondicion(strSQLCondicion, " SI.ID_SOLICITUD = :ID_SOLICITUD ")
        End If

        If idEstadoSolicitud <> -1 Then
            Dim oParam As New OracleParameter(":ID_ESTADO_SOLICITUD", OracleType.Int32)
            oParam.Value = CInt(idEstadoSolicitud)
            args.Add(oParam)
            AgregarCondicion(strSQLCondicion, " SI.ID_ESTADO_SOLICITUD = :ID_ESTADO_SOLICITUD ")
        End If

        If nombresSolicitante <> "" Then
            Dim oParam As New OracleParameter(":NOMBRES", OracleType.VarChar)
            oParam.Value = "%" + nombresSolicitante.ToUpper + "%"
            args.Add(oParam)
            AgregarCondicion(strSQLCondicion, " UPPER(SI.NOMBRES) LIKE :NOMBRES ")
        End If

        If apellidosSolicitante <> "" Then
            Dim oParam As New OracleParameter(":APELLIDOS", OracleType.VarChar)
            oParam.Value = "%" + apellidosSolicitante.ToUpper + "%"
            args.Add(oParam)
            AgregarCondicion(strSQLCondicion, " UPPER(SI.APELLIDOS) LIKE :APELLIDOS ")
        End If

        If idProveedor <> -1 Then
            Dim oParam As New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
            oParam.Value = idProveedor
            args.Add(oParam)
            AgregarCondicion(strSQLCondicion, " AF.ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ")
        End If

        If idSitioCapacitacion <> -1 Then
            Dim oParam As New OracleParameter(":ID_SITIO_CAPACITACION", OracleType.Number)
            oParam.Value = idSitioCapacitacion
            args.Add(oParam)
            AgregarCondicion(strSQLCondicion, " EXISTS(SELECT 1 FROM SITIO_CAPACITACION SC WHERE SC.ID_SITIO_CAPACITACION = AF.ID_SITIO_CAPACITACION AND AF.ID_SITIO_CAPACITACION = :ID_SITIO_CAPACITACION) ")
        End If

        If idEjercicio <> "" Then
            Dim oParam As New OracleParameter(":ID_EJERCICIO", OracleType.VarChar)
            oParam.Value = idEjercicio
            args.Add(oParam)
            AgregarCondicion(strSQLCondicion, " AF.ID_EJERCICIO = :ID_EJERCICIO ")
        End If

        If nombreAccionFormativa <> "" Then
            Dim oParam As New OracleParameter(":nombreAccionFormativa", OracleType.VarChar)
            oParam.Value = "%" + nombreAccionFormativa.ToUpper + "%"
            args.Add(oParam)
            AgregarCondicion(strSQLCondicion, " UPPER(AF.NOMBRE_ACCION_FORMATIVA) LIKE :nombreAccionFormativa ")
        End If

        If codigoGrupo <> "" Then
            Dim oParam As New OracleParameter(":codigoGrupo", OracleType.VarChar)
            oParam.Value = "%" + codigoGrupo.ToUpper + "%"
            args.Add(oParam)
            AgregarCondicion(strSQLCondicion, " UPPER(AF.CODIGO_GRUPO) LIKE :codigoGrupo ")
        End If

        strSQL.AppendLine(strSQLCondicion.ToString)
        strSQL.AppendLine(" ORDER BY SI.APELLIDOS, SI.NOMBRES ")

        Dim dr As OracleDataReader

        If args.Count > 0 Then
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args.ToArray())
        Else
            dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())
        End If

        Dim lista As New listaSOLICITUD_INSCRIPCION_AF

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_AF
                Me.CargarEntidad(dr, CType(mEntidad, entidadBase))
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    Private Sub AgregarCondicion(ByRef sql As StringBuilder, ByVal condicion As String)
        If sql.Length = 0 Then sql.Append(" WHERE ") Else sql.Append(" AND ")
        sql.AppendLine(condicion)
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve el numero de Solicitudes ingresadas de un Participante
    ''' en una Accion Formativa
    ''' </summary>
    ''' <remarks></remarks>
    ''' <history>
    ''' 	[ecarias]	26/03/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCantidadPorCurso(ByVal ID_PARTICIPANTE As Decimal, ByVal ID_ACCION_FORMATIVA As Decimal) As Integer
        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT  COUNT(*) ")
        strSQL.AppendLine("FROM SOLICITUD_INSCRIPCION_AF ")
        strSQL.AppendLine("WHERE ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("AND ID_PARTICIPANTE = :ID_PARTICIPANTE ")

        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Double)
        args(0).Value = ID_ACCION_FORMATIVA
        args(1) = New OracleParameter(":ID_PARTICIPANTE", OracleType.Double)
        args(1).Value = ID_PARTICIPANTE

        Return CInt(sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args))

    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve la cantidad de cursos en los que aparece inscrito un Participante
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	11/07/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCantidadCursosPorParticipanteInscrito(ByVal ID_PARTICIPANTE As Decimal, ByVal TIPO_SOLICITUDES As List(Of Integer)) As Integer

        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT  COUNT(*) ")
        strSQL.AppendLine("FROM SOLICITUD_INSCRIPCION_AF ")
        strSQL.AppendLine("WHERE ID_PARTICIPANTE = :ID_PARTICIPANTE ")
        If TIPO_SOLICITUDES.Count > 0 Then
            strSQL.AppendLine("AND ( ")
            For i As Integer = 0 To TIPO_SOLICITUDES.Count - 1
                strSQL.AppendLine(" ID_TIPO_SOLICITUD = ")
                strSQL.AppendLine(TIPO_SOLICITUDES(i).ToString)
                If i < (TIPO_SOLICITUDES.Count - 1) Then strSQL.AppendLine(" OR ")
            Next
            strSQL.AppendLine(") ")
        End If
        strSQL.AppendLine("AND ( ")
        strSQL.AppendLine(" ESTADO = '" + Enumeradores.EstadoParticipanteEnCurso.Inscrito + "' OR ")
        strSQL.AppendLine(" ESTADO = '" + Enumeradores.EstadoParticipanteEnCurso.Evaluado + "' OR ")
        strSQL.AppendLine(" ESTADO = '" + Enumeradores.EstadoParticipanteEnCurso.CambioDeCursoPorSistema + "' ) ")

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_PARTICIPANTE", OracleType.Double)
        args(0).Value = ID_PARTICIPANTE

        Return CInt(sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args))

    End Function
End Class
