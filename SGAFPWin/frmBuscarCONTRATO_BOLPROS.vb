Public Class frmBuscarCONTRATO_BOLPROS

    Public Event Seleccionado(ByVal ID_CONTRATO As Decimal) 

    Private Sub UcBuscarCONTRATO_BOLPROS1_Seleccionado(ByVal ID_CONTRATO As Decimal) Handles UcBuscarCONTRATO_BOLPROS1.Seleccionado
        RaiseEvent Seleccionado(ID_CONTRATO)
    End Sub

End Class
