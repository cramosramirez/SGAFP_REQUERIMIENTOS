
Partial Class controles_ucReporte
    Inherits ucBase

    Public Sub CargarDatos(ByVal reporte As DevExpress.XtraReports.UI.XtraReport)
        Me.ReportViewer1.Report = reporte
        Me.ReportViewer1.DataBind()
    End Sub

End Class
