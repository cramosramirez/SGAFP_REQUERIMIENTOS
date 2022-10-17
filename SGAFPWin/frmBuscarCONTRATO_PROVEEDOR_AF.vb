Public Class frmBuscarCONTRATO_PROVEEDOR_AF

    Public Event Seleccionado(ByVal ID_CONTRATO As Decimal) 

    Private Sub UcBuscarCONTRATO_PROVEEDOR_AF1_Seleccionado(ByVal ID_CONTRATO As Decimal) Handles UcBuscarCONTRATO_PROVEEDOR_AF1.Seleccionado
        RaiseEvent Seleccionado(ID_CONTRATO)
    End Sub

End Class
