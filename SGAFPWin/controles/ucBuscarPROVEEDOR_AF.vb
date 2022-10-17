Imports SGAFP.EL
Public Class ucBuscarPROVEEDOR_AF

    Public Event Seleccionado(ByVal ID_PROVEEDOR_AF As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaPROVEEDOR_AF1 As New listaPROVEEDOR_AF
        listaPROVEEDOR_AF1 = CType((New cPROVEEDOR_AF).ObtenerListaPorBusqueda(New PROVEEDOR_AF, Me.CriteriaList.ToArray()), listaPROVEEDOR_AF)
        Me.UcListaPROVEEDOR_AF1.CargarDatosPorLista(listaPROVEEDOR_AF1)
    End Sub

    Private Sub UcListaPROVEEDOR_AF1_Seleccionado(ByVal ID_PROVEEDOR_AF As Decimal) Handles UcListaPROVEEDOR_AF1.Seleccionado
        RaiseEvent Seleccionado(ID_PROVEEDOR_AF)
    End Sub

End Class
