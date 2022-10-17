
Partial Class Reporte_wfReportesPECENTRO
    Inherits System.Web.UI.Page

    Protected Sub Reporte_wfReportesPECENTRO_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CargarDatosReporte()
    End Sub

    Private Sub CargarDatosReporte()
        Dim opcion As Integer = CDec(Me.Request.QueryString("n"))
        Dim id As Integer = 0
        Dim i As Integer = 0

        Select Case opcion
            Case 0
                id = Me.Request.QueryString("id")

                If id > 0 Then
                    Dim reporte As New xrInformeAvanceEC
                    reporte.CargarDatos(id)
                    reporte.ResumeLayout()
                    Me.ucReporte1.CargarDatos(reporte)
                End If

            Case 1
                id = Me.Request.QueryString("id")

                If id > 0 Then
                    Dim reporte As New xrInformeAvanceAspirantesEC
                    reporte.CargarAspirantesSeleccionados(id)
                    reporte.ResumeLayout()
                    Me.ucReporte1.CargarDatos(reporte)
                End If

            Case 2
                id = Me.Request.QueryString("id")

                If id > 0 Then
                    Dim reporte As New xrInformeAvanceAspirantesEC
                    reporte.CargarReclutamientoExtraordinario(id)
                    reporte.ResumeLayout()
                    Me.ucReporte1.CargarDatos(reporte)
                End If

        End Select

    End Sub


End Class
