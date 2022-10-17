Imports SQLMembershipProvider.BL
Imports System.Collections.Generic
Imports System.Data

Partial Class controles_ucReprogramacionCursos
    Inherits ucBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.InicializarLista()
        End If
    End Sub

    Private Sub InicializarLista()
        Me.UcBarraNavegacion1.LimpiarOpciones()
        Me.UcBarraNavegacion1.CrearOpcion("BuscarAccionFormativa", "Buscar", False, "~/imagenes/ButtonSearch.png")
        Me.UcBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, "~/imagenes/cancelar.gif")
        Me.UcBarraNavegacion1.CrearOpcion("AprobarReprogramacion", "Aprobar", False, "~/imagenes/aprobar.gif")
        Me.UcBarraNavegacion1.CrearOpcion("RechazarReprogramacion", "Rechazar", False, "~/imagenes/rechazar.gif")
        Me.UcBarraNavegacion1.CargarOpciones()
        Me.ucCriteriosAccionFormativaReprog1.VerEstado = True
        Me.ucCriteriosAccionFormativaReprog1.VerEjercicio = True
        Me.ucCriteriosAccionFormativaReprog1.EsConsulta = True
        Me.ucCriteriosAccionFormativaReprog1.Visible = True
        Me.ucListaACCION_FORMATIVA_REPROG1.Visible = True

        Me.lblInfoCursoOriginal.Visible = False
        Me.lblReprogramacionCurso.Visible = False
        Me.ucVistaDetalleACCION_FORMATIVA1.Visible = False
        Me.ucVistaDetalleACCION_FORMATIVA_REPROG1.Visible = False

        Me.UcBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.UcBarraNavegacion1.VerOpcion("AprobarReprogramacion", False)
        Me.UcBarraNavegacion1.VerOpcion("RechazarReprogramacion", False)
    End Sub

    Private Sub InicializarDetalle()
        Me.ucCriteriosAccionFormativaReprog1.Visible = False
        Me.ucListaACCION_FORMATIVA_REPROG1.Visible = False

        Me.lblInfoCursoOriginal.Visible = True
        Me.lblReprogramacionCurso.Visible = True
        Me.ucVistaDetalleACCION_FORMATIVA1.Visible = True
        Me.ucVistaDetalleACCION_FORMATIVA_REPROG1.Visible = True

        Me.UcBarraNavegacion1.VerOpcion("BuscarAccionFormativa", False)
        Me.UcBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.UcBarraNavegacion1.VerOpcion("AprobarReprogramacion", True)
        Me.UcBarraNavegacion1.VerOpcion("RechazarReprogramacion", True)
    End Sub

    Protected Sub UcBarraNavegacion1_OpcionSeleccionada(ByVal CommandName As String) Handles UcBarraNavegacion1.OpcionSeleccionada
        If CommandName = "BuscarAccionFormativa" Then
            Me.CargarDatos()
        End If

        If CommandName = "Cancelar" Then
            Me.InicializarLista()
        End If

        If CommandName = "AprobarReprogramacion" Then
            Me.EvaluarReprogramacion(False, True)
        End If

        If CommandName = "RechazarReprogramacion" Then
            Me.EvaluarReprogramacion(True)
        End If
    End Sub

    Public Function CargarDatos() As Integer
        Try
            Return Me.CargarACCION_FORMATIVA_REPROG()
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Function CargarACCION_FORMATIVA_REPROG() As Integer
        Me.ucListaACCION_FORMATIVA_REPROG1.PermitirEvaluar = (ucCriteriosAccionFormativaReprog1.idEstadoAccionReprog = Enumeradores.EstadoReprogramaciones.Solicitada)
        Me.ucListaACCION_FORMATIVA_REPROG1.PermitirEliminar = False

        Dim c As SQLMembershipProvider.BL.cmembershipProvider
        Dim listaRoles As New List(Of String)
        Dim sbRoles As New StringBuilder

        'Obteniendo los Roles asignados al usuario actual
        c = CType(System.Web.Security.Membership.Provider, SQLMembershipProvider.BL.cmembershipProvider)
        listaRoles = c.ObtenerRoles(Me.ObtenerUsuario)

        For i As Integer = 0 To listaRoles.Count - 1
            sbRoles.Append(listaRoles(i))
            If i < listaRoles.Count - 1 Then sbRoles.Append(";")
        Next

        If Me.ucListaACCION_FORMATIVA_REPROG1.CargarDatosPorCriteriosRoles(Me.ucCriteriosAccionFormativaReprog1.idProveedor, _
                Me.ucCriteriosAccionFormativaReprog1.idSitioCapacitacion, _
                Me.ucCriteriosAccionFormativaReprog1.idAreaFormacion, _
                Me.ucCriteriosAccionFormativaReprog1.nombreAccionFormativa, _
                Me.ucCriteriosAccionFormativaReprog1.codigoGrupo, _
                Me.ucCriteriosAccionFormativaReprog1.idEjercicio, _
                sbRoles.ToString, _
                Me.ucCriteriosAccionFormativaReprog1.idEstadoAccionReprog, _
                Me.ucCriteriosAccionFormativaReprog1.tdr) <> 1 Then Return -1
        Return 1
    End Function

    Private Sub ucBarraNavegacion1_Cancelar(ByVal sender As Object, ByVal e As System.EventArgs) Handles UcBarraNavegacion1.Cancelar
        Me.InicializarLista()
    End Sub

    Protected Sub ucListaACCION_FORMATIVA_REPROG1_Evaluando(ByVal ID_ACCION_FORMATIVA_REPROG As Decimal) Handles ucListaACCION_FORMATIVA_REPROG1.Evaluando
        Me.InicializarDetalle()
        Me.ucVistaDetalleACCION_FORMATIVA1.ID_ACCION_FORMATIVA = (New cACCION_FORMATIVA_REPROG).ObtenerACCION_FORMATIVA_REPROG(ID_ACCION_FORMATIVA_REPROG).ID_ACCION_FORMATIVA
        Me.ucVistaDetalleACCION_FORMATIVA1.Enabled = False
        Me.ucVistaDetalleACCION_FORMATIVA_REPROG1.ID_ACCION_FORMATIVA_REPROG = ID_ACCION_FORMATIVA_REPROG
        Me.ucVistaDetalleACCION_FORMATIVA_REPROG1.Enabled = False
    End Sub

    

    Private Sub EvaluarReprogramacion(ByVal preguntar As Boolean, Optional ByVal Aprobada As Boolean = False)
        If preguntar Then
            Me.txtObservacion.Text = ""
            Me.mpObservacionEvaluacion.Show()
        Else
            Dim lAccionReprog As ACCION_FORMATIVA_REPROG
            Dim cAccionReprog As New cACCION_FORMATIVA_REPROG
            Dim lAccionFormativa As ACCION_FORMATIVA
            Dim cAccionFormativa As New cACCION_FORMATIVA
            Dim liRet As Integer


            lAccionReprog = cAccionReprog.ObtenerACCION_FORMATIVA_REPROG(Me.ucVistaDetalleACCION_FORMATIVA_REPROG1.ID_ACCION_FORMATIVA_REPROG)
            lAccionFormativa = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(lAccionReprog.ID_ACCION_FORMATIVA)

            If Aprobada Then
                'Validar que la programación esté comprendido en el período de ejecucion del contrato
                Dim lContrato As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROSPorID_ACCION_FORMATIVA(lAccionReprog.ID_ACCION_FORMATIVA)
                If lContrato IsNot Nothing AndAlso lContrato.ID_CONTRATO > 0 AndAlso (lAccionReprog.FECHA_INICIO_REAL < lContrato.FECHA_INI_EJEC OrElse lAccionReprog.FECHA_FIN_REAL > lContrato.FECHA_FIN_EJEC) Then
                    Me.AsignarMensaje("Las fechas de la reprogramacion están fuera del periodo de ejecucion del contrato " + lContrato.NUM_CONTRATO + " que comprende del " + _
                                     lContrato.FECHA_INI_EJEC.ToString("dd/MM/yyyy") + " al " + lContrato.FECHA_FIN_EJEC.ToString("dd/MM/yyyy"), True, True)
                    Return
                End If

                'Validar que el horario de la reprogramación no esté conflicto con otro horario del formador
                If lAccionFormativa.CODI_FORMADOR <> "" Then
                    Dim sErrorVal As String = Me.ucVistaDetalleACCION_FORMATIVA_REPROG1.ValidarHorarioParaFormador(lAccionFormativa.ID_ACCION_FORMATIVA, lAccionFormativa.CODI_FORMADOR)
                    If sErrorVal <> "" Then
                        Return
                    End If
                End If

                'Cambiando el estado de la reprogramación
                lAccionReprog.ID_ESTADO_REPROG = Enumeradores.EstadoReprogramaciones.Aprobada
                lAccionReprog.MOTIVORECHAZO = ""
                lAccionReprog.USERIDOld = lAccionReprog.USERID
                lAccionReprog.USERID = Me.ObtenerUsuario
                lAccionReprog.LASTUPDATE = DateTime.Now
                liRet = cAccionReprog.ActualizarACCION_FORMATIVA_REPROG(lAccionReprog)
                If liRet = -2 Then
                    Me.AsignarMensaje(cAccionReprog.sError, True, True)
                ElseIf liRet = -1 Then
                    If cAccionReprog.sError <> "" Then
                        Me.AsignarMensaje("Error al Guardar registro. " & vbCrLf & cAccionReprog.sError, True, True)
                        Return
                    End If
                End If
                lAccionFormativa.ID_PROVEEDOR_AF = lAccionReprog.ID_PROVEEDOR_AF
                lAccionFormativa.ID_SITIO_CAPACITACION = lAccionReprog.ID_SITIO_CAPACITACION
                lAccionFormativa.ID_TEMA_CURSO = lAccionReprog.ID_TEMA_CURSO
                lAccionFormativa.ID_OFERTA_FORMATIVA = lAccionReprog.ID_OFERTA_FORMATIVA
                lAccionFormativa.NOMBRE_ACCION_FORMATIVA = lAccionReprog.NOMBRE_ACCION_FORMATIVA
                lAccionFormativa.CODIGO_GRUPO = lAccionReprog.CODIGO_GRUPO
                lAccionFormativa.NUMERO_PARTICIPANTES = lAccionReprog.NUMERO_PARTICIPANTES
                lAccionFormativa.FECHA_INICIO_REAL = lAccionReprog.FECHA_INICIO_REAL
                lAccionFormativa.FECHA_FIN_REAL = lAccionReprog.FECHA_FIN_REAL
                lAccionFormativa.HORARIO = lAccionReprog.HORARIO
                lAccionFormativa.NOTAS = If(lAccionReprog.CODI_FORMADOR.Trim = "", lAccionReprog.NOTAS, lAccionReprog.NOMBRE_FORMADOR)
                lAccionFormativa.CODI_FORMADOR = lAccionReprog.CODI_FORMADOR
                lAccionFormativa.NOMBRE_FORMADOR = lAccionReprog.NOMBRE_FORMADOR

                'Cambiando el estado del curso          
                lAccionFormativa.CODIGO_ESTADO_AF = Me.ucVistaDetalleACCION_FORMATIVA_REPROG1.CODIGO_ESTADO_AF
                If Me.ucVistaDetalleACCION_FORMATIVA_REPROG1.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.Finalizada Then
                    Dim listaInformeFinal As New listaINFORME_FINAL_AF
                    listaInformeFinal = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA(lAccionFormativa.ID_ACCION_FORMATIVA)
                    If Not listaInformeFinal Is Nothing Then
                        If listaInformeFinal.Count = 0 Then
                            lAccionFormativa.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.Iniciada
                        End If
                    End If
                End If

                'Actualizando la accion formativa
                liRet = cAccionFormativa.ActualizarACCION_FORMATIVA(lAccionFormativa, TipoConcurrencia.Pesimistica, False, False, False, True)
                If liRet < 1 Then
                    If cAccionFormativa.sError <> "" Then
                        Me.AsignarMensaje(cAccionFormativa.sError, True)
                        Return
                    End If
                    Me.AsignarMensaje("No se aplicaron los cambios al curso", True)
                    Return
                End If

                If ActualizarProgramacionAccionFormativa(Me.ucVistaDetalleACCION_FORMATIVA1.ID_ACCION_FORMATIVA, Me.ucVistaDetalleACCION_FORMATIVA_REPROG1.ID_ACCION_FORMATIVA_REPROG) <> 1 Then
                    Me.AsignarMensaje("No se aplicó la nueva programación al curso", True)
                    Return
                End If

                
            Else
                'Cambiando el estado de la reprogramación
                lAccionReprog.ID_ESTADO_REPROG = Enumeradores.EstadoReprogramaciones.Rechazada
                lAccionReprog.MOTIVORECHAZO = Me.txtObservacion.Text
                lAccionReprog.USERIDOld = lAccionReprog.USERID
                lAccionReprog.USERID = Me.ObtenerUsuario
                lAccionReprog.LASTUPDATE = DateTime.Now
                liRet = cAccionReprog.ActualizarACCION_FORMATIVA_REPROG(lAccionReprog)
                If liRet = -2 Then
                    Me.AsignarMensaje(cAccionReprog.sError, True, True)
                ElseIf liRet = -1 Then
                    If cAccionReprog.sError <> "" Then
                        Me.AsignarMensaje("Error al Guardar registro. " & vbCrLf & cAccionReprog.sError, True, True)
                        Return
                    End If
                End If

                'Cambiando el estado del curso  
                lAccionFormativa.USERID = Me.ObtenerUsuario
                lAccionFormativa.LASTUPDATE = Now
                lAccionFormativa.CODIGO_ESTADO_AF = Me.ucVistaDetalleACCION_FORMATIVA_REPROG1.CODIGO_ESTADO_AF
                liRet = cAccionFormativa.ActualizarACCION_FORMATIVA(lAccionFormativa, TipoConcurrencia.Pesimistica, False, False, False, True)
                If liRet < 1 Then
                    If cAccionFormativa.sError <> "" Then
                        Me.AsignarMensaje(cAccionFormativa.sError, True)
                        Return
                    End If
                    Me.AsignarMensaje("No se aplicaron los cambios al curso", True)
                    Return
                End If
            End If


            If Aprobada Then
                Me.AsignarMensaje("Reprogramacion se Aprobo Satisfactoriamente")
            Else
                Me.AsignarMensaje("Reprogramacion se Rechazo Satisfactoriamente")
            End If
            InicializarLista()
            Me.CargarACCION_FORMATIVA_REPROG()
        End If
    End Sub

    Private Function ActualizarProgramacionAccionFormativa(ByVal IdAccionFormativa As Decimal, ByVal IdReprogramacion As Decimal) As Integer
        Dim bAsistenciaAF As New cASISTENCIA_AF
        Dim bAsistenciaAFHorario As New cASISTENCIA_AF_HORARIO
        Dim bAsistenciaDet As New cASISTENCIA_AF_DET
        Dim bAsistenciaAFReprog As New cASISTENCIA_AF_REPROG
        Dim bAsistenciaAFHorarioReprog As New cASISTENCIA_AF_HORARIO_REPROG
        Dim lAsistenciaAF As listaASISTENCIA_AF = bAsistenciaAF.ObtenerListaPorACCION_FORMATIVA(IdAccionFormativa)
        Dim lAsistenciaAFReprog As listaASISTENCIA_AF_REPROG = bAsistenciaAFReprog.ObtenerListaPorACCION_FORMATIVA_REPROG(IdReprogramacion)
        Dim lAsistenciaHorarioReprog As listaASISTENCIA_AF_HORARIO_REPROG
        Dim lAsistenciaHorario As listaASISTENCIA_AF_HORARIO
        Dim ReingresarHorario As Boolean

        If lAsistenciaAFReprog IsNot Nothing Then
            For Each asisReprog As ASISTENCIA_AF_REPROG In lAsistenciaAFReprog
                Dim DiaAsistencia As ASISTENCIA_AF
                ReingresarHorario = False

                'Obtener el día de Programación y verificar si han cambiado la cantidad de horas
                DiaAsistencia = (New cASISTENCIA_AF).ObtenerASISTENCIA_AFPorIdAccionFormativa_Fecha(IdAccionFormativa, asisReprog.FECHA)

                If DiaAsistencia IsNot Nothing Then
                    'Si la cantidad de horas cambia eliminar registro de inasistencia/asistencia parcial
                    If DiaAsistencia.CANTIDAD_HORAS <> asisReprog.CANTIDAD_HORAS Then
                        DiaAsistencia.CANTIDAD_HORAS = asisReprog.CANTIDAD_HORAS
                        If bAsistenciaAF.ActualizarASISTENCIA_AF(DiaAsistencia) < 0 Then Return -1

                        'Eliminar inasistencias/asistencia parcial de participantes y horarios
                        bAsistenciaDet.EliminarASISTENCIA_AF_DETPorIdAsistenciaAF(DiaAsistencia.ID_ASISTENCIA_AF)
                        bAsistenciaAFHorario.EliminarASISTENCIA_AF_HORARIOPorID_ASISTENCIA_AF(DiaAsistencia.ID_ASISTENCIA_AF)
                        ReingresarHorario = True
                    Else
                        'Verificar si el horario cambió en el día actual
                        lAsistenciaHorario = bAsistenciaAFHorario.ObtenerListaPorASISTENCIA_AF(DiaAsistencia.ID_ASISTENCIA_AF)
                        lAsistenciaHorarioReprog = bAsistenciaAFHorarioReprog.ObtenerListaPorASISTENCIA_AF_REPROG(asisReprog.ID_ASISTENCIA_AF)

                        If lAsistenciaHorario.Count <> lAsistenciaHorarioReprog.Count Then
                            'Eliminar inasistencias/asistencia parcial de participantes y horarios
                            bAsistenciaDet.EliminarASISTENCIA_AF_DETPorIdAsistenciaAF(DiaAsistencia.ID_ASISTENCIA_AF)
                            bAsistenciaAFHorario.EliminarASISTENCIA_AF_HORARIOPorID_ASISTENCIA_AF(DiaAsistencia.ID_ASISTENCIA_AF)
                            ReingresarHorario = True
                        Else
                            lAsistenciaHorario = bAsistenciaAFHorario.ObtenerListaPorASISTENCIA_AF(DiaAsistencia.ID_ASISTENCIA_AF)
                            lAsistenciaHorarioReprog = bAsistenciaAFHorarioReprog.ObtenerListaPorASISTENCIA_AF_REPROG(asisReprog.ID_ASISTENCIA_AF)

                            For i As Integer = 0 To lAsistenciaHorario.Count - 1
                                If lAsistenciaHorario(i).HORA_INICIO <> lAsistenciaHorarioReprog(i).HORA_INICIO OrElse _
                                   lAsistenciaHorario(i).HORA_FIN <> lAsistenciaHorarioReprog(i).HORA_FIN OrElse _
                                   lAsistenciaHorario(i).CANTIDAD_MINUTOS <> lAsistenciaHorarioReprog(i).CANTIDAD_MINUTOS Then
                                    'Eliminar inasistencias/asistencia parcial de participantes y horarios
                                    bAsistenciaDet.EliminarASISTENCIA_AF_DETPorIdAsistenciaAF(DiaAsistencia.ID_ASISTENCIA_AF)
                                    bAsistenciaAFHorario.EliminarASISTENCIA_AF_HORARIOPorID_ASISTENCIA_AF(DiaAsistencia.ID_ASISTENCIA_AF)
                                    ReingresarHorario = True
                                    Exit For
                                End If
                            Next
                        End If
                    End If

                    If ReingresarHorario Then
                        lAsistenciaHorarioReprog = bAsistenciaAFHorarioReprog.ObtenerListaPorASISTENCIA_AF_REPROG(asisReprog.ID_ASISTENCIA_AF)
                        For Each asisHorarioReprog As ASISTENCIA_AF_HORARIO_REPROG In lAsistenciaHorarioReprog
                            Dim Horario As ASISTENCIA_AF_HORARIO

                            Horario = New ASISTENCIA_AF_HORARIO(DiaAsistencia.ID_ASISTENCIA_AF, 0, asisHorarioReprog.HORA_INICIO, asisHorarioReprog.HORA_FIN, asisHorarioReprog.CANTIDAD_MINUTOS)
                            If bAsistenciaAFHorario.ActualizarASISTENCIA_AF_HORARIO(Horario, TipoConcurrencia.Pesimistica) < 0 Then Return -1
                        Next
                    End If
                Else
                    'Agregar nuevo día de programacion
                    DiaAsistencia = New ASISTENCIA_AF(0, IdAccionFormativa, asisReprog.FECHA, asisReprog.INSTRUCTOR, asisReprog.NOTAS, asisReprog.USERID, asisReprog.LASTUPDATE, asisReprog.CANTIDAD_HORAS)
                    If bAsistenciaAF.ActualizarASISTENCIA_AF(DiaAsistencia, TipoConcurrencia.Pesimistica) < 0 Then Return -1

                    'Agregar horarios para el día de programación
                    lAsistenciaHorarioReprog = bAsistenciaAFHorarioReprog.ObtenerListaPorASISTENCIA_AF_REPROG(asisReprog.ID_ASISTENCIA_AF)
                    For Each asisHorarioReprog As ASISTENCIA_AF_HORARIO_REPROG In lAsistenciaHorarioReprog
                        Dim Horario As ASISTENCIA_AF_HORARIO

                        Horario = New ASISTENCIA_AF_HORARIO(DiaAsistencia.ID_ASISTENCIA_AF, 0, asisHorarioReprog.HORA_INICIO, asisHorarioReprog.HORA_FIN, asisHorarioReprog.CANTIDAD_MINUTOS)
                        If bAsistenciaAFHorario.ActualizarASISTENCIA_AF_HORARIO(Horario, TipoConcurrencia.Pesimistica) < 0 Then Return -1
                    Next
                End If
            Next
        End If

        If lAsistenciaAF IsNot Nothing Then
            For Each asis As ASISTENCIA_AF In lAsistenciaAF
                If bAsistenciaAFReprog.ObtenerASISTENCIA_AFPorIdAccionFormativaReprog_Fecha(IdReprogramacion, asis.FECHA) Is Nothing Then
                    bAsistenciaDet.EliminarASISTENCIA_AF_DETPorIdAsistenciaAF(asis.ID_ASISTENCIA_AF)
                    bAsistenciaAFHorario.EliminarASISTENCIA_AF_HORARIOPorID_ASISTENCIA_AF(asis.ID_ASISTENCIA_AF)
                    bAsistenciaAF.EliminarASISTENCIA_AF(asis.ID_ASISTENCIA_AF)
                End If
            Next
        End If
        Return 1
    End Function

    Function EnviarRespuestaPorCorreo(ByVal UsuarioDestino As String, ByVal CUERPO As String) As Integer
        Try
            Dim CorreoTecnico As String
            Dim CorreoCentro As String


            'Referencia al MembershipProvider personalizado
            Dim _mp As New cmembershipProvider
            _mp = CType(Membership.Provider, cmembershipProvider)

            'Obtener el correo electrónico del técnico asignado
            CorreoTecnico = _mp.ObtenerEmailPorNombreUsuario(Me.ObtenerUsuario)

            'Obtener el correo electrónico del usuario actual
            CorreoCentro = _mp.ObtenerEmailPorNombreUsuario(UsuarioDestino)

            If CorreoTecnico <> "" And CorreoCentro <> "" Then
                Return _mp.EnviarCorreo(CorreoTecnico, CorreoCentro, "Evaluacion de Solicitud de Reprogramacion", CUERPO)
            Else
                Return -1
            End If

        Catch ex As Exception
            Return -1
        End Try
    End Function

    Protected Sub btnRechazar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRechazar.Click
        Me.EvaluarReprogramacion(False, False)
    End Sub
End Class
