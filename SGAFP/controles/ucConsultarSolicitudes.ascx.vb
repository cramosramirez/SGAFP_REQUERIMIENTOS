Imports System.Collections.Generic

Partial Class controles_ucConsultarSolicitudes
    Inherits ucBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.CargarDatos()
        End If
    End Sub

    Private Sub CargarDatos()
        Me.AsignarTituloOpcion("Consulta de Solicitudes")
        Me.UcBarraNavegacion1.CrearOpcion("BuscarSolicitudes", "Buscar", False, "~/imagenes/ButtonSearch.png")
        Me.UcBarraNavegacion1.CargarOpciones()
        If Not Me.EstaEnRol(RolDeUsuario.TecnicoCentroHTP) AndAlso Not Me.EstaEnRol(RolDeUsuario.JefeHTP) AndAlso Not Me.EstaEnRol(RolDeUsuario.AsistenteGFI) AndAlso Not Me.EstaEnRol(RolDeUsuario.GerenteGFI) Then
            'Me.ucListaSOLICITUD_INSCRIPCION_AF1.AgregarHyperLinkField("ID_SOLICITUD".Split(","), "~/CursosFormacion/wfSolicitudInscripcion.aspx?modoOp=2&ID_SOLICITUD={0}", "Editar", "_self")
        End If
        'Me.ucListaSOLICITUD_INSCRIPCION_AF1.AgregarHyperLinkField("ID_SOLICITUD".Split(","), "~/CursosFormacion/wfSolicitudInscripcion.aspx?modoOp=3&ID_SOLICITUD={0}", "Consultar", "_self")
        'Me.ucListaSOLICITUD_INSCRIPCION_AF1.AgregarHyperLinkField("ID_SOLICITUD".Split(","), "~/Reportes/wfReporteSolicitudfInscripcion.aspx?IDS={0}", "<img src='../imagenes/Imprimir.gif' style='border-style:none;border-width:0px;height:16px;width:16px;' alt='Imprimir inscripci&oacute;n' title='Imprimir inscripci&oacute;n' />", "_self")
        'Me.ucListaSOLICITUD_INSCRIPCION_AF1.EliminarHyperLinkField("Editar")
        'Me.ucListaSOLICITUD_INSCRIPCION_AF1.EliminarHyperLinkField("Consultar")
    End Sub

    Protected Sub UcBarraNavegacion1_OpcionSeleccionada(ByVal CommandName As String) Handles UcBarraNavegacion1.OpcionSeleccionada
        If CommandName = "BuscarSolicitudes" Then
            Me.BuscarSolicitudes()
        End If
    End Sub

    Private Sub BuscarSolicitudes()
        If Not Me.EstaEnRol(RolDeUsuario.TecnicoCentroHTP) AndAlso Not Me.EstaEnRol(RolDeUsuario.JefeHTP) AndAlso Not Me.EstaEnRol(RolDeUsuario.AsistenteGFI) AndAlso Not Me.EstaEnRol(RolDeUsuario.GerenteGFI) Then
            'Me.ucListaSOLICITUD_INSCRIPCION_AF1.PermitirAnular = (Me.ucCriteriosSolicitudes1.idEstadoSolicitud = Enumeradores.EstadoSolicitud.Aprobada Or _
            '    Me.ucCriteriosSolicitudes1.idEstadoSolicitud = Enumeradores.EstadoSolicitud.EnEsperaDeAprobacion Or _
            '    Me.ucCriteriosSolicitudes1.idEstadoSolicitud = Enumeradores.EstadoSolicitud.EnEsperaDeCupo)
        Else
            'Me.ucListaSOLICITUD_INSCRIPCION_AF1.PermitirAnular = False
        End If
        Select Case Me.ucCriteriosSolicitudes1.idEstadoSolicitud
            Case Enumeradores.EstadoSolicitud.Ingresada, Enumeradores.EstadoSolicitud.EnEsperaDeAprobacion
                'If Not Me.EstaEnRol(RolDeUsuario.TecnicoCentroHTP) AndAlso Not Me.EstaEnRol(RolDeUsuario.JefeHTP) AndAlso Not Me.EstaEnRol(RolDeUsuario.AsistenteGFI) AndAlso Not Me.EstaEnRol(RolDeUsuario.GerenteGFI) Then
                '    Me.ucListaSOLICITUD_INSCRIPCION_AF1.AgregarHyperLinkField("ID_SOLICITUD".Split(","), "~/CursosFormacion/wfSolicitudInscripcion.aspx?modoOp=2&ID_SOLICITUD={0}", "Editar", "_self")
                'End If
                'Me.ucListaSOLICITUD_INSCRIPCION_AF1.EliminarHyperLinkField("Consultar")
            Case Else
                'Me.ucListaSOLICITUD_INSCRIPCION_AF1.AgregarHyperLinkField("ID_SOLICITUD".Split(","), "~/CursosFormacion/wfSolicitudInscripcion.aspx?modoOp=3&ID_SOLICITUD={0}", "Consultar", "_self")
                'Me.ucListaSOLICITUD_INSCRIPCION_AF1.EliminarHyperLinkField("Editar")
        End Select

        Me.ucListaSOLICITUD_INSCRIPCION_AF1.CargarDatosPorCriterios(Me.ucCriteriosSolicitudes1.idSolicitud, _
                                                                Me.ucCriteriosSolicitudes1.idProveedor, _
                                                                Me.ucCriteriosSolicitudes1.idSitioCapacitacion, _
                                                                -1, _
                                                                Me.ucCriteriosSolicitudes1.idEstadoSolicitud, _
                                                                Me.ucCriteriosSolicitudes1.nombreAccionFormativa, _
                                                                Me.ucCriteriosSolicitudes1.codigoGrupo, _
                                                                Me.ucCriteriosSolicitudes1.nombresSolicitante, _
                                                                Me.ucCriteriosSolicitudes1.apellidosSolicitante)
    End Sub

    Private Sub AnularSolicitud(ByVal preguntar As Boolean, Optional ByVal ID_SOLICITUD As Decimal = 0)
        If preguntar Then
            'Me.lblIdSolicitud.Text = ID_SOLICITUD.ToString
            'Me.txtObservacion.Text = ""
            'Me.mpObservacionAnulacion.Show()
        Else
            Dim lSolicitud As SOLICITUD_INSCRIPCION_AF

            'lSolicitud = (New cSOLICITUD_INSCRIPCION_AF).ObtenerSOLICITUD_INSCRIPCION_AF(Decimal.Parse(Me.lblIdSolicitud.Text))
            'lSolicitud.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Anulada

            Dim cSolicitud As New cSOLICITUD_INSCRIPCION_AF

            'Dim liRet As String = cSolicitud.ActualizarSOLICITUD_INSCRIPCION_AF(lSolicitud, Me.txtObservacion.Text)

            'If liRet < 1 Then
            '    If cSolicitud.sError <> "" Then
            '        Me.AsignarMensaje(cSolicitud.sError, True)
            '        Return
            '    End If
            '    Me.AsignarMensaje("No se pudo cambiar el estado a la solicitud", True)
            '    Return
            'End If

            Me.BuscarSolicitudes()
            Me.AsignarMensaje("Solicitud se Anuló satisfactoriamente")
        End If
    End Sub

    'Protected Sub btnAnular_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAnular.Click
    '    Me.AnularSolicitud(False)
    'End Sub

    'Protected Sub ucListaSOLICITUD_INSCRIPCION_AF1_Anulando(ByVal ID_SOLICITUD As Decimal) Handles ucListaSOLICITUD_INSCRIPCION_AF1.Anulando
    '    Me.AnularSolicitud(True, ID_SOLICITUD)
    'End Sub
End Class
