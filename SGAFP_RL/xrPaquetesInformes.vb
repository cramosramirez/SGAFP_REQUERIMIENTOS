Public Class xrPaquetesInformes

    Public Sub CargarDatosPorIdPaquete(ByVal ID_PAQUETE As Decimal)
        Me.DS_DL1.Clear()
        Me.PaquetesInformesTableAdapter1.FillPorIdPaquete(Me.DS_DL1.PaquetesInformes, ID_PAQUETE)
    End Sub
End Class