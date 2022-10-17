Imports SGAFP.RL

Partial Class Reportes_wfReporteSolicitudfInscripcion
    Inherits wfBase
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim reporte As New xrSolicitudInscripcion
        reporte.CargarDatosPorSolicitud(Me.Request.QueryString("IDS"))
        reporte.ResumeLayout()
        Me.ReportViewer1.Report = reporte
        Me.ReportViewer1.DataBind()
    End Sub
End Class
