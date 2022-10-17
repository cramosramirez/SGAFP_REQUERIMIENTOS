Imports System.Collections.Generic

Partial Class controles_ucEvaluarSolicitudes
    Inherits ucBase

    Private ReadOnly Property idAccionFormativa() As Decimal
        Get
            If Me.ViewState("idAccionFormativa") Is Nothing Then Return 0
            Return Me.ViewState("idAccionFormativa")
        End Get
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.CargarDatos()
        End If
    End Sub

    Private Sub CargarDatos()
        Me.ucBarraNavegacion1.CrearOpcion("BuscarSolicitudes", "Buscar", False, "~/imagenes/ButtonSearch.png")
        Me.ucBarraNavegacion1.CrearOpcion("AprobarSolicitud", "Aprobar", False, "~/imagenes/SolicitudAprobada.gif")
        Me.ucBarraNavegacion1.CrearOpcion("RechazarSolicitud", "Rechazar", False, "~/imagenes/SolicitudRechazada.gif")
        Me.ucBarraNavegacion1.CrearOpcion("EnEsperaSolicitud", "En Espera", False, "~/imagenes/SolicitudEnEspera.gif")
        Me.ucBarraNavegacion1.CargarOpciones()
        Me.ucBarraNavegacion1.VerOpcion("AprobarSolicitud", False)
        Me.ucBarraNavegacion1.VerOpcion("RechazarSolicitud", False)
        Me.ucBarraNavegacion1.VerOpcion("EnEsperaSolicitud", False)
    End Sub

    Protected Sub ucListaSOLICITUD_INSCRIPCION_AF1_Seleccionado(ByVal ID_SOLICITUD As Decimal) Handles ucListaSOLICITUD_INSCRIPCION_AF1.Seleccionado
        Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF1.ID_SOLICITUD = ID_SOLICITUD
        Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF1.Enabled = False

        Me.CargarHorarios(ID_SOLICITUD)
        Me.CargarCursosRecibidos(ID_SOLICITUD)
    End Sub

    Private Sub CargarCursosRecibidos(ByVal ID_SOLICITUD As Integer)

        Dim lSolicitud As SOLICITUD_INSCRIPCION_AF = (New cSOLICITUD_INSCRIPCION_AF).ObtenerSOLICITUD_INSCRIPCION_AF(ID_SOLICITUD)
        If lSolicitud Is Nothing Then Return

        Me.ObjectDataSource1.SelectParameters("ID_PARTICIPANTE").DefaultValue = lSolicitud.ID_PARTICIPANTE
        Me.ObjectDataSource1.DataBind()
        Me.GridView1.DataBind()

    End Sub

    Private Sub CargarHorarios(ByVal ID_SOLICITUD As Integer)
        Dim lSolicitud As SOLICITUD_INSCRIPCION_AF = (New cSOLICITUD_INSCRIPCION_AF).ObtenerSOLICITUD_INSCRIPCION_AF(ID_SOLICITUD)
        If lSolicitud Is Nothing Then Return

        Dim lAccionFormativa As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(lSolicitud.ID_ACCION_FORMATIVA)
        If lAccionFormativa Is Nothing Then Return

        Me.ViewState("idAccionFormativa") = lAccionFormativa.ID_ACCION_FORMATIVA

        Me.ucListaACCION_FORMATIVA1.CargarDatosPorAccionFormativaEnMatricula(lAccionFormativa.ID_ACCION_FORMATIVA)

    End Sub

    Protected Sub UcBarraNavegacion1_OpcionSeleccionada(ByVal CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "BuscarSolicitudes" Then
            Me.BuscarSolicitudes()
        End If
        If CommandName = "AprobarSolicitud" Then
            Me.AprobarSolicitud()
        End If
        If CommandName = "RechazarSolicitud" Then
            Me.RechazarSolicitud(True)
        End If
        If CommandName = "EnEsperaSolicitud" Then
            Me.EnEsperaSolicitud()
        End If
    End Sub

    Private Sub BuscarSolicitudes()

        Me.ucListaSOLICITUD_INSCRIPCION_AF1.AsignarFilaSeleccionada(-1)
        'Me.ucListaSOLICITUD_INSCRIPCION_AF1.CargarDatosPorCriterios(Me.ucCriteriosSolicitudes1.idSolicitud, _
        '                                                Me.ucCriteriosSolicitudes1.idProveedor, _
        '                                                Me.ucCriteriosSolicitudes1.idSitioCapacitacion, _
        '                                                Me.ucCriteriosSolicitudes1.idAreaFormacion, _
        '                                                Enumeradores.EstadoSolicitud.EnEsperaDeAprobacion, _
        '                                                Me.ucCriteriosSolicitudes1.nombreAccionFormativa, _
        '                                                Me.ucCriteriosSolicitudes1.codigoGrupo, _
        '                                                Me.ucCriteriosSolicitudes1.nombresSolicitante, _
        '                                                Me.ucCriteriosSolicitudes1.apellidosSolicitante)

    End Sub

    Protected Sub Menu1_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu1.MenuItemClick

        Me.MultiView1.ActiveViewIndex = Int32.Parse(e.Item.Value)
        If e.Item.Text = "Evaluacion" Then
            Me.ucBarraNavegacion1.VerOpcion("AprobarSolicitud", True)
            Me.ucBarraNavegacion1.VerOpcion("RechazarSolicitud", True)
            Me.ucBarraNavegacion1.VerOpcion("EnEsperaSolicitud", True)
        Else
            Me.ucBarraNavegacion1.VerOpcion("AprobarSolicitud", False)
            Me.ucBarraNavegacion1.VerOpcion("RechazarSolicitud", False)
            Me.ucBarraNavegacion1.VerOpcion("EnEsperaSolicitud", False)
        End If
    End Sub

    Protected Sub ucListaACCION_FORMATIVA1_Seleccionado(ByVal ID_ACCION_FORMATIVA As Decimal) Handles ucListaACCION_FORMATIVA1.Seleccionado
        Me.ViewState("idAccionFormativa") = ID_ACCION_FORMATIVA
    End Sub

    Private Sub AprobarSolicitud()

        Dim lSolicitud As SOLICITUD_INSCRIPCION_AF

        lSolicitud = (New cSOLICITUD_INSCRIPCION_AF).ObtenerSOLICITUD_INSCRIPCION_AF(Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF1.ID_SOLICITUD)
        lSolicitud.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Aprobada
        lSolicitud.ID_ACCION_FORMATIVA = Me.idAccionFormativa

        Dim cSolicitud As New cSOLICITUD_INSCRIPCION_AF

        Dim liRet As String = cSolicitud.ActualizarSOLICITUD_INSCRIPCION_AF(lSolicitud)

        If liRet < 1 Then
            If cSolicitud.sError <> "" Then
                Me.AsignarMensaje(cSolicitud.sError, True)
                Return
            End If
            Me.AsignarMensaje("No se pudo cambiar el estado a la solicitud", True)
            Return
        End If

        Me.BuscarSolicitudes()
        Me.MultiView1.ActiveViewIndex = 0
        Me.Menu1.Items(0).Selected = True

        Me.ucBarraNavegacion1.VerOpcion("AprobarSolicitud", False)
        Me.ucBarraNavegacion1.VerOpcion("RechazarSolicitud", False)
        Me.ucBarraNavegacion1.VerOpcion("EnEsperaSolicitud", False)

        Me.AsignarMensaje("Solicitud se Aprobo satisfactoriamente")

    End Sub

    Private Sub RechazarSolicitud(ByVal preguntar As Boolean)
        If preguntar Then
            Me.txtObservacion.Text = ""
            Me.mpObservacionEvaluacion.Show()
        Else
            Dim lSolicitud As SOLICITUD_INSCRIPCION_AF

            lSolicitud = (New cSOLICITUD_INSCRIPCION_AF).ObtenerSOLICITUD_INSCRIPCION_AF(Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF1.ID_SOLICITUD)
            lSolicitud.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Rechazada

            Dim cSolicitud As New cSOLICITUD_INSCRIPCION_AF

            Dim liRet As String = cSolicitud.ActualizarSOLICITUD_INSCRIPCION_AF(lSolicitud, Me.txtObservacion.Text)

            If liRet < 1 Then
                If cSolicitud.sError <> "" Then
                    Me.AsignarMensaje(cSolicitud.sError, True)
                    Return
                End If
                Me.AsignarMensaje("No se pudo cambiar el estado a la solicitud", True)
                Return
            End If

            Me.BuscarSolicitudes()
            Me.MultiView1.ActiveViewIndex = 0
            Me.Menu1.Items(0).Selected = True

            Me.ucBarraNavegacion1.VerOpcion("AprobarSolicitud", False)
            Me.ucBarraNavegacion1.VerOpcion("RechazarSolicitud", False)
            Me.ucBarraNavegacion1.VerOpcion("EnEsperaSolicitud", False)

            Me.AsignarMensaje("Solicitud se Rechazo satisfactoriamente")
        End If
    End Sub

    Private Sub EnEsperaSolicitud()

        Dim lSolicitud As SOLICITUD_INSCRIPCION_AF

        lSolicitud = (New cSOLICITUD_INSCRIPCION_AF).ObtenerSOLICITUD_INSCRIPCION_AF(Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF1.ID_SOLICITUD)
        lSolicitud.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.EnEsperaDeCupo

        Dim cSolicitud As New cSOLICITUD_INSCRIPCION_AF

        Dim liRet As String = cSolicitud.ActualizarSOLICITUD_INSCRIPCION_AF(lSolicitud)

        If liRet < 1 Then
            If cSolicitud.sError <> "" Then
                Me.AsignarMensaje(cSolicitud.sError, True)
                Return
            End If
            Me.AsignarMensaje("No se pudo cambiar el estado a la solicitud", True)
            Return
        End If

        Me.BuscarSolicitudes()
        Me.MultiView1.ActiveViewIndex = 0
        Me.Menu1.Items(0).Selected = True

        Me.ucBarraNavegacion1.VerOpcion("AprobarSolicitud", False)
        Me.ucBarraNavegacion1.VerOpcion("RechazarSolicitud", False)
        Me.ucBarraNavegacion1.VerOpcion("EnEsperaSolicitud", False)

        Me.AsignarMensaje("Solicitud se coloco en Espera de Cupo satisfactoriamente")

    End Sub

    Protected Sub btnRechazar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRechazar.Click
        Me.RechazarSolicitud(False)
    End Sub

End Class
