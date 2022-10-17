
Partial Class Reportes_wfReporteFormularioF8
    Inherits wfBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim idAccionFormativa As Integer = Me.Request.QueryString("af")
        Dim lTermino As TERMINO_REFERENCIA_AF
        lTermino = (New cTERMINO_REFERENCIA_AF).ObtenerTERMINO_REFERENCIA_AF(idAccionFormativa)
        If lTermino Is Nothing Then
            Me.AsignarMensaje("La Accion Formativa no es del Programa PATI", True)
            Return
        End If
        Dim reporte As New xrFormularioF8
        reporte.CargarDatos(lTermino.TDR)
        reporte.ResumeLayout()
        Me.ReportViewer1.Report = reporte
        Me.ReportViewer1.DataBind()
    End Sub

End Class
