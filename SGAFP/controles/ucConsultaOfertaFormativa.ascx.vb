
Partial Class controles_ucConsultaOfertaFormativa
    Inherits ucBase

    Public Function CargarOfertaFormativa() As Integer
        If Me.hfParametros.Contains("Actualizar") AndAlso CBool(Me.hfParametros("Actualizar")) Then
            Me.odsOfertaFormativa.SelectParameters("ID_EJERCICIO").DefaultValue = CStr(Me.hfParametros("IdEjercicio"))
            Me.odsOfertaFormativa.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = Decimal.Parse(Me.hfParametros("IdProveedor"))
            Me.odsOfertaFormativa.SelectParameters("ID_SITIO_CAPACITACION").DefaultValue = Decimal.Parse(Me.hfParametros("IdCentroFormacion"))
            Me.odsOfertaFormativa.SelectParameters("ID_AREA_FORMACION").DefaultValue = Decimal.Parse(Me.hfParametros("IdAreaFormacion"))
            Me.pgLista.DataSourceID = "odsOfertaFormativa"
            Me.pgLista.DataBind()
        End If
        Return 1
    End Function

    Private Sub InicializarParametros()
        Me.hfParametros.Clear()
        Me.hfParametros.Add("Actualizar", False)
        Me.hfParametros.Add("IdEjercicio", "")
        Me.hfParametros.Add("IdProveedor", -1)
        Me.hfParametros.Add("IdCentroFormacion", -1)
        Me.hfParametros.Add("IdAreaFormacion", -1)
        Me.hfParametros.SyncWithServer = True
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack AndAlso Not Page.IsCallback Then
            Me.InicializarParametros()
        Else
            Me.CargarOfertaFormativa()
        End If
    End Sub

    Protected Sub CallbackPanel_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles CallbackPanel.Callback
        Dim sParametros() As String
        sParametros = e.Parameter.Split(";")

        Me.hfParametros("Actualizar") = True
        Me.hfParametros("IdProveedor") = Decimal.Parse(sParametros(0))
        Me.hfParametros("IdCentroFormacion") = Decimal.Parse(sParametros(1))
        Me.hfParametros("IdEjercicio") = sParametros(2)
        Me.hfParametros("IdAreaFormacion") = Decimal.Parse(sParametros(3))
        Me.CargarOfertaFormativa()
    End Sub

    Protected Sub btnExportar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Dim NombreArchivo As New StringBuilder

        NombreArchivo.Append("HTP ")
        If hfParametros.Contains("IdEjercicio") AndAlso hfParametros("IdEjercicio") <> "" Then
            NombreArchivo.Append(hfParametros("IdEjercicio") + " OFERTA FORMATIVA ")
        End If
        If hfParametros.Contains("IdProveedor") AndAlso hfParametros("IdProveedor") <> -1 Then
            Dim ProveedorAF As PROVEEDOR_AF = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(CDec(hfParametros("IdProveedor")))
            If ProveedorAF IsNot Nothing Then NombreArchivo.Append(ProveedorAF.NOMBRE_PROVEEDOR + " - ")
        End If
        If hfParametros.Contains("IdCentroFormacion") AndAlso hfParametros("IdCentroFormacion") <> -1 Then
            Dim SitioCapacitacion As SITIO_CAPACITACION = (New cSITIO_CAPACITACION).ObtenerSITIO_CAPACITACION(CDec(hfParametros("IdCentroFormacion")))
            If SitioCapacitacion IsNot Nothing Then NombreArchivo.Append(SitioCapacitacion.NOMBRE_SITIO + " - ")
        End If
        If hfParametros.Contains("IdAreaFormacion") AndAlso hfParametros("IdAreaFormacion") <> -1 Then
            Dim AreaFormacion As AREA_FORMACION = (New cAREA_FORMACION).ObtenerAREA_FORMACION(CDec(hfParametros("IdAreaFormacion")))
            If AreaFormacion IsNot Nothing Then NombreArchivo.Append(AreaFormacion.AREA_FORMACION + " - ")
        End If

        Select Case Me.cbxExportar.SelectedIndex
            Case 0
                Me.ASPxPivotGridExporter1.ExportXlsToResponse(NombreArchivo.ToString.Trim, True)
            Case 1
                Me.ASPxPivotGridExporter1.ExportPdfToResponse(NombreArchivo.ToString.Trim, True)
        End Select
    End Sub
End Class
