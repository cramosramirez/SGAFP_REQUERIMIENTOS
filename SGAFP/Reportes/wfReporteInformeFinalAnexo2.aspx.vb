Imports SGAFP.RL

Partial Class Reportes_wfReporteInformeFinalAnexo2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim reporte As New xrInformeFinalAnexo2
        reporte.CargarDatosPorInformeEjecucion(Me.Request.QueryString("af"))
        reporte.ResumeLayout()
        Me.ReportViewer1.Report = reporte
        Me.ReportViewer1.DataBind()
    End Sub
End Class
