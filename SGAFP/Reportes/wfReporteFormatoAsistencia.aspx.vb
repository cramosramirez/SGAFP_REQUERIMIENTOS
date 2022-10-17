Imports SGAFP.RL

Partial Class Reportes_wfReporteFormatoAsistencia
    Inherits wfBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim numAsitencia As Integer = (New cASISTENCIA_AF).ObtenerListaPorACCION_FORMATIVA(Me.Request.QueryString("af")).Count
        If numAsitencia = 0 Then
            Me.AsignarMensaje("No existe Asistencia para el Curso Elegido", True, True)
            Me.ReportViewer1.Visible = False
            'Me.ReportViewer1.Report = Nothing
            Return
        End If

        Dim idAccionFormativa As Integer = Me.Request.QueryString("af")
        Dim lProgramaFormacion As Integer = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(idAccionFormativa).ID_PROGRAMA_FORMACION

        If Me.Request.QueryString("real") Is Nothing Then
            Select Case lProgramaFormacion
                Case Enumeradores.ProgramasFormacion.PATI_BM, Enumeradores.ProgramasFormacion.PATI_USAID, Enumeradores.ProgramasFormacion.PATI_2
                    Dim reporte As New xrListadoAsistenciaPATI
                    reporte.CargarDatosPorAccionFormativa(idAccionFormativa)
                    reporte.ResumeLayout()
                    Me.ReportViewer1.Report = reporte
                    Me.ReportViewer1.DataBind()
                Case Else
                    Dim reporte As New xrListadoAsistencia
                    reporte.CargarDatosPorAccionFormativa(idAccionFormativa)
                    reporte.ResumeLayout()
                    Me.ReportViewer1.Report = reporte
                    Me.ReportViewer1.DataBind()
            End Select
        Else
            Select Case lProgramaFormacion
                Case Enumeradores.ProgramasFormacion.PATI_USAID, Enumeradores.ProgramasFormacion.PATI_BM, Enumeradores.ProgramasFormacion.PATI_2
                    Dim reporte As New xrListadoAsistenciaRealPATI
                    reporte.CargarDatosPorAccionFormativa(idAccionFormativa)
                    reporte.ResumeLayout()
                    Me.ReportViewer1.Report = reporte
                    Me.ReportViewer1.DataBind()
                Case Else
                    Dim reporte As New xrListadoAsistenciaReal
                    reporte.CargarDatosPorAccionFormativa(idAccionFormativa)
                    reporte.ResumeLayout()
                    Me.ReportViewer1.Report = reporte
                    Me.ReportViewer1.DataBind()
            End Select

        End If
    End Sub

End Class
