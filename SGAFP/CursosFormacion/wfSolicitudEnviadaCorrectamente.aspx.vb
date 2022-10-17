
Partial Class CursosFormacion_wfSolicitudEnviadaCorrectamente
    Inherits wfBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            'Me.LabelMensaje.Text = "Solicitud de Inscripcion #" + Me.Request.QueryString("s") + " fue Enviada Exitosamente !!!"
            Me.LabelMensaje.Text = "Solicitud de Inscripcion Enviada Exitosamente !!!"
            If Me.EstaEnRol(RolUsuario.Administrador) _
                Or Me.EstaEnRol(RolUsuario.CentroCapacitador) _
                Or Me.EstaEnRol(RolUsuario.Proveedor) Then
                Me.HyperLinkNuevaSolicitud.NavigateUrl = "~/CursosFormacion/wfSolicitudInscripcion.aspx?modoOp=1&ID_ACCION_FORMATIVA=" + Me.Request.QueryString("af") + "&ID_PROVEEDOR_AF=" + Me.Request.QueryString("p")
                Me.HyperLinkNuevaSolicitud.Visible = True
            Else
                Me.HyperLinkNuevaSolicitud.Visible = False
            End If
        End If
    End Sub
End Class
