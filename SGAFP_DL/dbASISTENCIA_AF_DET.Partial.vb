Imports System.Text

Partial Class dbASISTENCIA_AF_DET

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
    ''' 	[GenApp]	07/04/2010	Created
    ''' 	[ecarias]	07/04/2010	Se agrego columna USERID para que asignara usuario
    '''                             de la sesion activa.
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As ASISTENCIA_AF_DET
        lEntidad = CType(aEntidad, ASISTENCIA_AF_DET)

        Dim lID As Decimal
        If lEntidad.ID_ASISTENCIA_DET = 0 _
            Or lEntidad.ID_ASISTENCIA_DET = Nothing Then

            lID = CType(Me.ObtenerID(lEntidad), Decimal)

            If lID = -1 Then Return -1

            lEntidad.ID_ASISTENCIA_DET = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder

        CType(aEntidad, ASISTENCIA_AF_DET).USERID = Utilerias.ObtenerUsuario()
        CType(aEntidad, ASISTENCIA_AF_DET).LASTUPDATE = Now

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
    ''' 	[GenApp]	07/04/2010	Created
    ''' 	[ecarias]	07/04/2010	Se agrego columna USERID para que asignara usuario
    '''                             de la sesion activa.
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim strSQL As New StringBuilder

        CType(aEntidad, ASISTENCIA_AF_DET).USERID = Utilerias.ObtenerUsuario()
        CType(aEntidad, ASISTENCIA_AF_DET).LASTUPDATE = Now

        Dim args(0) As OracleParameter

        strSQL.Append(Me.QueryInsert(aEntidad, args))


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSet del Listado de Asistencia de una Accion Formativa
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	20/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetListadoAsistencia(ByVal ID_ASISTENCIA_AF As Decimal, ByVal ID_ACCION_FORMATIVA As Decimal, ByVal EsCursosFinalizado As Boolean) As DataSet

        Dim strSQL As New StringBuilder

        strSQL.AppendLine(" select NVL((select MAX(ID_ASISTENCIA_DET) from ASISTENCIA_AF_DET, ASISTENCIA_AF ")
        strSQL.AppendLine("              where ASISTENCIA_AF.ID_ASISTENCIA_AF = ASISTENCIA_AF_DET.ID_ASISTENCIA_AF ")
        strSQL.AppendLine("              and ASISTENCIA_AF.ID_ACCION_FORMATIVA = PARTICIPANTE_AF.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("              and ASISTENCIA_AF_DET.ID_PARTICIPANTE = PARTICIPANTE.ID_PARTICIPANTE ")
        strSQL.AppendLine("              and ASISTENCIA_AF.ID_ASISTENCIA_AF = :ID_ASISTENCIA_AF),0) AS ID_ASISTENCIA_DET, ")
        strSQL.AppendLine(" PARTICIPANTE.ID_PARTICIPANTE, PARTICIPANTE.NOMBRES as NOMBRES, ")
        strSQL.AppendLine(" PARTICIPANTE.APELLIDOS as APELLIDOS, ")
        strSQL.AppendLine(" NVL((select DISTINCT 'NO' from ASISTENCIA_AF_DET, ASISTENCIA_AF ")
        strSQL.AppendLine("       where(ASISTENCIA_AF.ID_ASISTENCIA_AF = ASISTENCIA_AF_DET.ID_ASISTENCIA_AF) ")
        strSQL.AppendLine("       and ASISTENCIA_AF.ID_ACCION_FORMATIVA = PARTICIPANTE_AF.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("       and ASISTENCIA_AF_DET.ID_PARTICIPANTE = PARTICIPANTE.ID_PARTICIPANTE ")
        strSQL.AppendLine("       and ASISTENCIA_AF.ID_ASISTENCIA_AF = :ID_ASISTENCIA_AF), 'SI') AS ASISTIO, ")
        strSQL.AppendLine(" NVL((select DISTINCT 'SI' from ASISTENCIA_AF_DET, ASISTENCIA_AF ")
        strSQL.AppendLine("       where ASISTENCIA_AF.ID_ASISTENCIA_AF = ASISTENCIA_AF_DET.ID_ASISTENCIA_AF ")
        strSQL.AppendLine("       and ASISTENCIA_AF.ID_ACCION_FORMATIVA = PARTICIPANTE_AF.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("       and ASISTENCIA_AF_DET.ID_PARTICIPANTE = PARTICIPANTE.ID_PARTICIPANTE ")
        strSQL.AppendLine("       AND PRESENTA_JUSTIFICACION = 1 ")
        strSQL.AppendLine("       and ASISTENCIA_AF.ID_ASISTENCIA_AF = :ID_ASISTENCIA_AF), 'NO') AS PRESENTA_JUSTIFICACION, ")
        strSQL.AppendLine(" NVL((select MAX(JUSTIFICACION) from ASISTENCIA_AF_DET, ASISTENCIA_AF ")
        strSQL.AppendLine("       where ASISTENCIA_AF.ID_ASISTENCIA_AF = ASISTENCIA_AF_DET.ID_ASISTENCIA_AF ")
        strSQL.AppendLine("       and ASISTENCIA_AF.ID_ACCION_FORMATIVA = PARTICIPANTE_AF.ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("       and ASISTENCIA_AF_DET.ID_PARTICIPANTE = PARTICIPANTE.ID_PARTICIPANTE ")
        strSQL.AppendLine("       and ASISTENCIA_AF.ID_ASISTENCIA_AF = :ID_ASISTENCIA_AF), '') AS JUSTIFICACION ")
        strSQL.AppendLine(" from PARTICIPANTE, ")
        strSQL.AppendLine("      PARTICIPANTE_AF ")
        strSQL.AppendLine(" WHERE PARTICIPANTE.ID_PARTICIPANTE = PARTICIPANTE_AF.ID_PARTICIPANTE ")
        strSQL.AppendLine(" and PARTICIPANTE_AF.ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA ")
        If EsCursosFinalizado Then
            strSQL.AppendLine(" AND (PARTICIPANTE_AF.ESTADO = '" + Enumeradores.EstadoParticipanteEnCurso.Evaluado + "' ")
            strSQL.AppendLine(" OR PARTICIPANTE_AF.ESTADO = '" + Enumeradores.EstadoParticipanteEnCurso.CambioDeCursoPorSistema + "') ")
        Else
            strSQL.AppendLine(" AND PARTICIPANTE_AF.ESTADO = '" + Enumeradores.EstadoParticipanteEnCurso.Inscrito + "' ")
        End If
        strSQL.AppendLine(" ORDER BY PARTICIPANTE.APELLIDOS, PARTICIPANTE.NOMBRES ")

        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":ID_ASISTENCIA_AF", OracleType.Number)
        args(0).Value = ID_ASISTENCIA_AF
        args(1) = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
        args(1).Value = ID_ACCION_FORMATIVA

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSet del Listado de Asistencia de una Accion Formativa
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	07/10/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetListaAsistencia(ByVal ID_ASISTENCIA_AF As Decimal, ByVal ID_ACCION_FORMATIVA As Decimal) As DataSet

        Dim strSQL As New StringBuilder

        strSQL.AppendLine("SELECT asistencia_af_det.id_asistencia_det, ")
        strSQL.AppendLine("participante_af.id_participante, ")
        strSQL.AppendLine("participante.apellidos, ")
        strSQL.AppendLine("participante.nombres, ")
        strSQL.AppendLine("asistencia_af_det.asistio, ")
        strSQL.AppendLine("asistencia_af_det.horas_asistencia, ")
        strSQL.AppendLine("asistencia_af_det.presenta_justificacion, ")
        strSQL.AppendLine("asistencia_af_det.justificacion ")
        strSQL.AppendLine("FROM asistencia_af, asistencia_af_det, participante_af, participante ")
        strSQL.AppendLine("WHERE asistencia_af.id_accion_formativa = :ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("AND asistencia_af.id_asistencia_af = :ID_ASISTENCIA_AF ")
        strSQL.AppendLine("AND asistencia_af.id_asistencia_af = asistencia_af_det.id_asistencia_af ")
        strSQL.AppendLine("AND asistencia_af.id_accion_formativa = participante_af.id_accion_formativa ")
        strSQL.AppendLine("AND asistencia_af_det.id_participante = participante_af.id_participante ")
        strSQL.AppendLine("AND participante_af.id_participante = participante.id_participante ")

        strSQL.AppendLine("AND (participante_af.estado = '" + Enumeradores.EstadoParticipanteEnCurso.Evaluado + "' ")
        strSQL.AppendLine("OR participante_af.estado = '" + Enumeradores.EstadoParticipanteEnCurso.CambioDeCursoPorSistema + "' ")
        strSQL.AppendLine("OR participante_af.estado = '" + Enumeradores.EstadoParticipanteEnCurso.Inscrito + "') ")

        strSQL.AppendLine("UNION ALL ")
        strSQL.AppendLine("SELECT 0 as id_asistencia_det, ")
        strSQL.AppendLine("participante_af.id_participante, ")
        strSQL.AppendLine("participante.apellidos, ")
        strSQL.AppendLine("participante.nombres, ")
        strSQL.AppendLine("'1' as asistio, ")
        strSQL.AppendLine("(SELECT asistencia_af.cantidad_horas FROM asistencia_af WHERE asistencia_af.id_asistencia_af = :ID_ASISTENCIA_AF ) as horas_asistencia, ")
        strSQL.AppendLine("'0' as presenta_justificacion, ")
        strSQL.AppendLine("'' as justificacion ")
        strSQL.AppendLine("FROM accion_formativa, participante_af, participante ")
        strSQL.AppendLine("WHERE accion_formativa.id_accion_formativa = :ID_ACCION_FORMATIVA ")
        strSQL.AppendLine("AND accion_formativa.id_accion_formativa = participante_af.id_accion_formativa ")
        strSQL.AppendLine("AND participante_af.id_participante = participante.id_participante ")
        strSQL.AppendLine("AND participante_af.id_participante = participante.id_participante ")

        strSQL.AppendLine("AND (participante_af.estado = '" + Enumeradores.EstadoParticipanteEnCurso.Evaluado + "' ")
        strSQL.AppendLine("OR participante_af.estado = '" + Enumeradores.EstadoParticipanteEnCurso.CambioDeCursoPorSistema + "' ")
        strSQL.AppendLine("OR participante_af.estado = '" + Enumeradores.EstadoParticipanteEnCurso.Inscrito + "') ")
        
        strSQL.AppendLine("AND NOT EXISTS( SELECT * FROM asistencia_af_det WHERE asistencia_af_det.id_participante = participante_af.id_participante AND asistencia_af_det.id_asistencia_af = :ID_ASISTENCIA_AF  ) ")
        strSQL.AppendLine("ORDER BY apellidos, nombres ")

        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":ID_ASISTENCIA_AF", OracleType.Number)
        args(0).Value = ID_ASISTENCIA_AF
        args(1) = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
        args(1).Value = ID_ACCION_FORMATIVA

        Dim ds As DataSet

        ds = sql.ExecuteDataset(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ASISTENCIA_AF_DET que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_ASISTENCIA_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	08/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarASISTENCIA_AF_DETPorIdAsistenciaAF(ByVal ID_ASISTENCIA_AF As Decimal) As Integer

        Dim lRet As Integer
        Dim strSQL As New StringBuilder

        strSQL.Append("DELETE FROM ASISTENCIA_AF_DET ")
        strSQL.Append("WHERE EXISTS ( ")
        strSQL.Append(" SELECT * FROM ASISTENCIA_AF A1 ")
        strSQL.Append(" WHERE A1.ID_ASISTENCIA_AF = :ID_ASISTENCIA_AF ")
        strSQL.Append(" AND A1.ID_ASISTENCIA_AF = ASISTENCIA_AF_DET.ID_ASISTENCIA_AF )")

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_ASISTENCIA_AF", OracleType.Number)
        args(0).Value = ID_ASISTENCIA_AF

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)
    End Function


End Class
