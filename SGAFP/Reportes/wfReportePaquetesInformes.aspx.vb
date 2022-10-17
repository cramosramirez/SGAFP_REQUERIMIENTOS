
Partial Class Reportes_wfReportePaqueteInformes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim reporte As New xrPaquetesInformes
        reporte.CargarDatosPorIdPaquete(Me.Request.QueryString("IDP"))
        reporte.ResumeLayout()
        Me.ReportViewer1.Report = reporte
        Me.ReportViewer1.DataBind()
    End Sub
End Class
