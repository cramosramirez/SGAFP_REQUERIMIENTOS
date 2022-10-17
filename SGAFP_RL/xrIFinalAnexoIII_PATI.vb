Public Class xrIFinalAnexoIII_PATI

    Public Sub CargarDatosPorAccionFormativa(ByVal ID_ACCION_FORMATIVA As Decimal)
        Me.DS_DL1.Clear()
        Me.InformeFinalPATINotasTableAdapter1.Fill(Me.DS_DL1.InformeFinalPATINotas, ID_ACCION_FORMATIVA)
        Me.lblAUPs.Text = (New cACCION_FORMATIVA).ObtenerListaAUPsPorAccionFormativa(ID_ACCION_FORMATIVA)

        Dim lAccionDetalle As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(ID_ACCION_FORMATIVA)
        Dim lFuenteFinanciamiento = (New cFUENTE_FINANCIAMIENTO).ObtenerFUENTE_FINANCIAMIENTO(lAccionDetalle.ID_FUENTE)
        Me.lblFUENTE_FINANCIAMIENTO.Text = lFuenteFinanciamiento.NOMBRE_FUENTE
    End Sub

End Class