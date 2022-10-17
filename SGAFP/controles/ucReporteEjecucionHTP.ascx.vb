
Partial Class controles_ucReporteEjecucionHTP
    Inherits ucBase

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
        If Request.QueryString("modo") IsNot Nothing Then
            Select Case Request.QueryString("modo")
                Case 1  'Ejercicio
                    hf.Add("Opcion", "CargarInformacion")
                    hf.Add("Ejercicio", Request.QueryString("e"))

                Case 2  'Por Proveedor, Ejercicio
                    hf.Add("Opcion", "CargarInformacionProveedor")
                    hf.Add("Ejercicio", Request.QueryString("e"))
                    hf.Add("IdProveedorAF", Request.QueryString("p"))

                Case 3  'Por Centro, Ejercicio
                    hf.Add("Opcion", "CargarInformacionCentro")
                    hf.Add("Ejercicio", Request.QueryString("e"))
                    hf.Add("IdProveedorAF", Request.QueryString("p"))
                    hf.Add("IdSitioCapacitacion", Request.QueryString("c"))
            End Select
        End If
    End Sub

    Protected Sub cReporte_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cReporte.Callback
        Dim parametros As String() = e.Parameter.Split(";")
        Dim reporte As New xrInformeEjecucion

        hf.Clear()
        hf.Add("Opcion", parametros(0))

        Select Case parametros(0)
            Case "CargarInformacion"
                hf.Add("Ejercicio", parametros(3))

            Case "CargarInformacionProveedor"
                hf.Add("Ejercicio", parametros(3))
                hf.Add("IdProveedorAF", parametros(1))

            Case "CargarInformacionCentro"
                hf.Add("Ejercicio", parametros(3))
                hf.Add("IdSitioCapacitacion", parametros(2))
        End Select

        MostrarReporte
    End Sub

    Private Sub MostrarReporte()
        Dim reporte As New xrInformeEjecucion

        If hf.Contains("Opcion") Then
            Select Case hf("Opcion")
                Case "CargarInformacion"
                    reporte.CargarDatosPorEjercicio(hf("Ejercicio"))

                Case "CargarInformacionProveedor"
                    reporte.CargarDatosPorEjercicioProveedor(hf("Ejercicio"), CDec(hf("IdProveedorAF")))

                Case "CargarInformacionCentro"
                    reporte.CargarDatosPorEjercicioSitioCapacitacion(hf("Ejercicio"), CDec(hf("IdSitioCapacitacion")))
            End Select

            reporte.ResumeLayout()
            Me.ucReporte1.CargarDatos(reporte)
        End If
    End Sub
End Class
