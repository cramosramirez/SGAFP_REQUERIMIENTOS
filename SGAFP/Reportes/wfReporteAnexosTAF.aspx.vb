
Partial Class Reportes_wfAnexosTAF
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CargarDatosReporte()
    End Sub

    Private Function TrafoFecha(ByVal f As String) As String
        Dim NuevaFecha As New StringBuilder(f)
        NuevaFecha.Insert(2, "/", 1)
        NuevaFecha.Insert(5, "/", 1)
        Return NuevaFecha.ToString
    End Function

    Private Sub CargarDatosReporte()
        Select Case Me.Request.QueryString("a")
            Case 3
                Dim reporte As New xrAnexoTAF3A
                Select Case Me.Request.QueryString("fte")
                    Case "1"
                        If Me.Request.QueryString("con") IsNot Nothing AndAlso Me.Request.QueryString("fliq") Then
                            reporte.CargarLiquidacion(Enumeradores.FuenteFinanciamientoPATI.PATI_BM, Me.Request.QueryString("con"), Date.Parse(TrafoFecha(Me.Request.QueryString("fliq")), New System.Globalization.CultureInfo("fr-FR", True), Globalization.DateTimeStyles.NoCurrentDateDefault))
                        End If
                    Case "2"
                        reporte.CargarLiquidacion(CDec(Me.Request.QueryString("idl")), Enumeradores.FuenteFinanciamientoPATI.PATI_USAID, CDec(Me.Request.QueryString("con")))
                    Case "3"
                        If Me.Request.QueryString("con") IsNot Nothing AndAlso Me.Request.QueryString("fliq") Then
                            reporte.CargarLiquidacion(Enumeradores.FuenteFinanciamientoPATI.PATI_GOES, Me.Request.QueryString("con"), Date.Parse(TrafoFecha(Me.Request.QueryString("fliq")), New System.Globalization.CultureInfo("fr-FR", True), Globalization.DateTimeStyles.NoCurrentDateDefault))
                        End If
                    Case Else
                        reporte.CargarLiquidacion(Me.Request.QueryString("idl"))
                End Select
                reporte.ResumeLayout()
                Me.ucReporte1.CargarDatos(reporte)
            Case 4
                Dim reporte As New xrAnexoTAF4A
                If Me.Request.QueryString("fte") IsNot Nothing AndAlso Me.Request.QueryString("con") IsNot Nothing AndAlso Me.Request.QueryString("fliq") Then
                    reporte.CargarLiquidacion(Me.Request.QueryString("fte"), Me.Request.QueryString("con"), Date.Parse(TrafoFecha(Me.Request.QueryString("fliq")), New System.Globalization.CultureInfo("fr-FR", True), Globalization.DateTimeStyles.NoCurrentDateDefault))
                ElseIf Me.Request.QueryString("idl") IsNot Nothing Then
                    reporte.CargarLiquidacion(Me.Request.QueryString("idl"))
                End If
                reporte.ResumeLayout()
                Me.ucReporte1.CargarDatos(reporte)
            Case 5
                Dim reporte As New xrAnexoTAF5
                Dim reporteUSAID As New xrAnexoTAF5_PATI_USAID
                If Me.Request.QueryString("fte") IsNot Nothing AndAlso Me.Request.QueryString("con") IsNot Nothing AndAlso Me.Request.QueryString("fliq") Then
                    If Convert.ToDecimal(Me.Request.QueryString("fte")) = Enumeradores.FuenteFinanciamientoPATI.PATI_BM OrElse _
                       Convert.ToDecimal(Me.Request.QueryString("fte")) = Enumeradores.FuenteFinanciamientoPATI.PATI_GOES Then
                        reporte.CargarLiquidacion(Me.Request.QueryString("fte"), Me.Request.QueryString("con"), Date.Parse(TrafoFecha(Me.Request.QueryString("fliq")), New System.Globalization.CultureInfo("fr-FR", True), Globalization.DateTimeStyles.NoCurrentDateDefault))
                        reporte.ResumeLayout()
                        Me.ucReporte1.CargarDatos(reporte)
                    Else
                        reporteUSAID.CargarLiquidacion(Me.Request.QueryString("fte"), Me.Request.QueryString("con"), Date.Parse(TrafoFecha(Me.Request.QueryString("fliq")), New System.Globalization.CultureInfo("fr-FR", True), Globalization.DateTimeStyles.NoCurrentDateDefault))
                        reporteUSAID.ResumeLayout()
                        Me.ucReporte1.CargarDatos(reporteUSAID)
                    End If
                ElseIf Me.Request.QueryString("idl") IsNot Nothing Then
                    Dim lEntidadMuniLiq As MUNICIPIO_LIQUIDACION = (New cMUNICIPIO_LIQUIDACION).ObtenerMUNICIPIO_LIQUIDACION(Convert.ToDecimal(Me.Request.QueryString("idl")))
                    If lEntidadMuniLiq IsNot Nothing Then
                        Select Case lEntidadMuniLiq.ID_FUENTE
                            Case Enumeradores.FuenteFinanciamientoPATI.PATI_BM, Enumeradores.FuenteFinanciamientoPATI.PATI_GOES
                                reporte.CargarLiquidacion(Me.Request.QueryString("idl"))
                                reporte.ResumeLayout()
                                Me.ucReporte1.CargarDatos(reporte)
                            Case Enumeradores.FuenteFinanciamientoPATI.PATI_USAID
                                reporteUSAID.CargarLiquidacion(Me.Request.QueryString("idl"))
                                reporteUSAID.ResumeLayout()
                                Me.ucReporte1.CargarDatos(reporteUSAID)
                        End Select
                    End If
                End If

            Case 51
                Dim reporte As New xrAnexoTAF5Revision
                If Me.Request.QueryString("fte") IsNot Nothing AndAlso Me.Request.QueryString("con") IsNot Nothing AndAlso Me.Request.QueryString("fliq") Then
                    reporte.CargarLiquidacion(Me.Request.QueryString("fte"), Me.Request.QueryString("con"), Date.Parse(TrafoFecha(Me.Request.QueryString("fliq")), New System.Globalization.CultureInfo("fr-FR", True), Globalization.DateTimeStyles.NoCurrentDateDefault))
                ElseIf Me.Request.QueryString("idl") IsNot Nothing Then
                    reporte.CargarLiquidacion(Me.Request.QueryString("idl"))
                End If
                reporte.ResumeLayout()
                Me.ucReporte1.CargarDatos(reporte)
            Case 9
                Dim reporte As New xrAnexoTAF9
                If Me.Request.QueryString("fte") IsNot Nothing AndAlso Me.Request.QueryString("con") IsNot Nothing Then
                    reporte.CargarLiquidacion(Me.Request.QueryString("fte"), Me.Request.QueryString("con"))
                ElseIf Me.Request.QueryString("depto") IsNot Nothing AndAlso Me.Request.QueryString("muni") Then
                    reporte.CargarLiquidacion(Me.Request.QueryString("depto"), Me.Request.QueryString("muni"), Me.Request.QueryString("con"))
                End If
                reporte.ResumeLayout()
                Me.ucReporte1.CargarDatos(reporte)
        End Select
    End Sub
End Class
