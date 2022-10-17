
Partial Class controles_ucReporteEjecucionDE
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MostrarReporte()
    End Sub

    Sub MostrarReporte()
        Dim reporte As New xrInformeEjecucionDE
        reporte.CargarDatos("2011", 1)
        reporte.ResumeLayout()
        Me.ucReporte1.CargarDatos(reporte)
    End Sub
End Class
