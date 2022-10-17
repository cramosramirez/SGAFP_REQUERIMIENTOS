Imports SGAFP.RL

Partial Class Reportes_wfReporteParticipantesSolicitados
    Inherits wfBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.inicializar()
        End If
    End Sub

    Private Sub inicializar()
        Me.ucBarraNavegacion1.CrearOpcion("CargarReporte", "Cargar Reporte", False, "~/imagenes/ButtonSearch.png")
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub

    Private Sub CargarReporte(ByVal IdFuente As Integer, ByVal NoConvocatoria As Integer, ByVal CodigoDepartamento As String, ByVal CodigoMunicipio As String)
        Response.Redirect("~/Reportes/wfReporteSolicitudParticipantesInscritosPATI.aspx?if=" + IdFuente.ToString + "&nc=" + NoConvocatoria.ToString + "&cd=" + CodigoDepartamento + "&cm=" + CodigoMunicipio)
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(ByVal CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "CargarReporte" Then
            Me.CargarReporte(Me.ucCriteriosMunicipiosPATI1.IdFuente, Me.ucCriteriosMunicipiosPATI1.NoConvocatoria, Me.ucCriteriosMunicipiosPATI1.CodigoDepartamento, Me.ucCriteriosMunicipiosPATI1.CodigoMunicipio)
        End If
    End Sub
End Class
