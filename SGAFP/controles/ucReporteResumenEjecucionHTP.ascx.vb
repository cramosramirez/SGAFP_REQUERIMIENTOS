
Partial Class controles_ucReporteResumenEjecucionHTP
    Inherits System.Web.UI.UserControl

    Public Sub InicializarLista()
        Me.ucBarraNavegacion1.LimpiarOpciones()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.HabilitarEdicion(False)

        Me.ucBarraNavegacion1.CrearOpcion("VerReporte", "Ver Reporte", True, "~/imagenes/view.gif", "onclick", "e.processOnServer=false;VerReporte();")
        Me.ucBarraNavegacion1.CargarOpciones()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ObtenerQueryString()
        End If
        InicializarLista()
        MostrarReporte()
    End Sub

    Private Sub ObtenerQueryString()
        If Request.QueryString("e") IsNot Nothing Then
            hf.Add("Ejercicio", Request.QueryString("e"))
        End If
    End Sub

    Protected Sub cReporte_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cReporte.Callback
        Dim parametros As String() = e.Parameter.Split(";")
        Dim reporte As New xrInformeEjecucion

        hf.Clear()
        hf.Add("Ejercicio", parametros(0))
        MostrarReporte()
    End Sub

    Private Sub MostrarReporte()
        Dim reporte As New xrResumenEjecucion

        If hf.Contains("Ejercicio") Then
            reporte.CargarDatosPorEjercicio(hf("Ejercicio"))
            reporte.ResumeLayout()
            Me.ucReporte1.CargarDatos(reporte)
        End If
    End Sub
End Class
