Public Class xrIFinalAnexoII_PATI

    Public Sub CargarDatosPorInformeEjecucion(ByVal ID_INFORME_AF As Decimal)
        Me.DS_DL1.Clear()
        Me.InformeFinalPATITableAdapter1.Fill(Me.DS_DL1.InformeFinalPATI, ID_INFORME_AF)

        Dim lInforme As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(ID_INFORME_AF)
        Dim lAccionDetalle As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(lInforme.ID_ACCION_FORMATIVA)
        Dim lFuenteFinanciamiento = (New cFUENTE_FINANCIAMIENTO).ObtenerFUENTE_FINANCIAMIENTO(lAccionDetalle.ID_FUENTE)

        Me.lblFUENTE_FINANCIAMIENTO.Text = lFuenteFinanciamiento.NOMBRE_FUENTE
    End Sub

    'Private Sub xrIFinalAnexoI_PATI_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
    '    Me.InformeFinalPATITableAdapter1.Fill(Me.DS_DL1.InformeFinalPATI, 5022)
    'End Sub
End Class