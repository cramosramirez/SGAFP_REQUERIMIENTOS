Imports Microsoft.Reporting.WebForms
Imports SGAFP.RL

Partial Class Reportes_wfCursosRecibidosParticipante
    Inherits wfBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dtCursosSolicitados As New SGAFP.DL.DS_DL.CursosSolicitadosParticipanteDataTable
        Dim dtCursosRecibidos As New SGAFP.DL.DS_DL.CursosRecibidosParticipanteDataTable
        Dim adCursosSolicitados As New SGAFP.DL.DS_DLTableAdapters.CursosSolicitadosParticipanteTableAdapter
        Dim adCursosRecibidos As New SGAFP.DL.DS_DLTableAdapters.CursosRecibidosParticipanteTableAdapter

        adCursosSolicitados.Fill(dtCursosSolicitados, Decimal.Parse(Me.Request.QueryString("IDPA")))
        adCursosRecibidos.FillPorIDParticipante(dtCursosRecibidos, Decimal.Parse(Me.Request.QueryString("IDPA")))


        If dtCursosSolicitados.Rows.Count = 0 And dtCursosRecibidos.Rows.Count = 0 Then
            Me.AsignarMensaje("No existen Cursos Solicitados y Recibidos para el Participante Elegido", True, True)
            Me.ReportViewer1.Visible = False
            Return
        End If

        Dim reporte As New xrCursosRecibidosParticipante
        reporte.CargarDatosPorParticipante(Me.Request.QueryString("IDPA"))
        reporte.ResumeLayout()
        Me.ReportViewer1.Report = reporte
        Me.ReportViewer1.DataBind()
    End Sub

End Class
