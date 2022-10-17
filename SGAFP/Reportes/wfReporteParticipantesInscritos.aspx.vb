Imports SGAFP.RL

Partial Class Reportes_wfReporteParticipantesInscritos
    Inherits wfBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.Request.QueryString("ID_ACCION_FORMATIVA") IsNot Nothing Then
            Dim lAccionDetalle As ACCION_FORMATIVA_DETALLE = _
                (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(Decimal.Parse(Me.Request.QueryString("ID_ACCION_FORMATIVA")))
            If lAccionDetalle IsNot Nothing Then
                Select Case lAccionDetalle.ID_PROGRAMA_FORMACION
                    Case Enumeradores.ProgramasFormacion.PATI_BM, Enumeradores.ProgramasFormacion.PATI_USAID, Enumeradores.ProgramasFormacion.PATI_2
                        Dim reporte As New xrParticipantesInscritosPATI
                        reporte.CargarDatosPorCurso(Me.Request.QueryString("ID_ACCION_FORMATIVA"))
                        reporte.ResumeLayout()
                        Me.ReportViewer1.Report = reporte
                        Me.ReportViewer1.DataBind()
                    Case Enumeradores.ProgramasFormacion.EMPRESA_CENTRO
                        Dim reporte As New xrParticipantesInscritosEC
                        reporte.CargarDatosPorCurso(Me.Request.QueryString("ID_ACCION_FORMATIVA"))
                        reporte.ResumeLayout()
                        Me.ReportViewer1.Report = reporte
                        Me.ReportViewer1.DataBind()

                    Case Else
                        Dim reporte As New xrParticipantesInscritos
                        reporte.CargarDatosPorCurso(Me.Request.QueryString("ID_ACCION_FORMATIVA"))
                        reporte.ResumeLayout()
                        Me.ReportViewer1.Report = reporte
                        Me.ReportViewer1.DataBind()
                End Select

            End If
        End If
    End Sub
End Class
