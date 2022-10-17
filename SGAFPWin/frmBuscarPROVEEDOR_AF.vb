Public Class frmBuscarPROVEEDOR_AF

    Public Event Seleccionado(ByVal ID_PROVEEDOR_AF As Decimal) 

    Private Sub UcBuscarPROVEEDOR_AF1_Seleccionado(ByVal ID_PROVEEDOR_AF As Decimal) Handles UcBuscarPROVEEDOR_AF1.Seleccionado
        RaiseEvent Seleccionado(ID_PROVEEDOR_AF)
    End Sub

End Class
