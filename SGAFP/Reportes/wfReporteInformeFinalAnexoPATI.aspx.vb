
Partial Class Reportes_wfReporteInformeFinalAnexoPATI
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CargarDatosReporte()
    End Sub

    Private Sub CargarDatosReporte()
        Select Case Me.Request.QueryString("a")
            Case 1
                Dim reporte As New xrIFinalAnexoI_PATI
                reporte.CargarDatosPorInformeEjecucion(Me.Request.QueryString("af"))
                reporte.ResumeLayout()
                Me.ucReporte1.CargarDatos(reporte)
            Case 2
                Dim reporte As New xrIFinalAnexoII_PATI
                reporte.CargarDatosPorInformeEjecucion(Me.Request.QueryString("af"))
                reporte.ResumeLayout()
                Me.ucReporte1.CargarDatos(reporte)
            Case 3
                Dim reporte As New xrIFinalAnexoIII_PATI
                reporte.CargarDatosPorAccionFormativa(Me.Request.QueryString("af"))
                reporte.ResumeLayout()
                Me.ucReporte1.CargarDatos(reporte)
        End Select
    End Sub
End Class
