Imports SGAFP.RL

Partial Class Reportes_wfReporteSolicitudParticipantesInscritosPATI
    Inherits wfBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim reporte As New xrParticipantesSolicitudInscritosPATI

        If Me.Request.QueryString("af") Is Nothing Then
            If Me.EstaEnRol(RolDeUsuario.ColaboradorUACIPATI) Then
                reporte.CargarDatosTotal(Me.Request.QueryString("if"), Me.Request.QueryString("nc"), Me.Request.QueryString("cd"), Me.Request.QueryString("cm"))
                reporte.ResumeLayout()
                Me.ReportViewer1.Report = reporte
                Me.ReportViewer1.DataBind()
            Else
                reporte.CargarDatosIdAF(Me.Request.QueryString("if"))
                reporte.ResumeLayout()
                Me.ReportViewer1.Report = reporte
                Me.ReportViewer1.DataBind()
            End If
        Else
            Dim idAccionFormativa As Decimal = Me.Request.QueryString("af")
            reporte.CargarDatos(idAccionFormativa)
            reporte.ResumeLayout()
            Me.ReportViewer1.Report = reporte
            Me.ReportViewer1.DataBind()
        End If


    End Sub
End Class
