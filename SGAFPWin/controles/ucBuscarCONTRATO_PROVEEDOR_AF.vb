Imports SGAFP.EL
Public Class ucBuscarCONTRATO_PROVEEDOR_AF

    Public Event Seleccionado(ByVal ID_CONTRATO As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaCONTRATO_PROVEEDOR_AF1 As New listaCONTRATO_PROVEEDOR_AF
        listaCONTRATO_PROVEEDOR_AF1 = CType((New cCONTRATO_PROVEEDOR_AF).ObtenerListaPorBusqueda(New CONTRATO_PROVEEDOR_AF, Me.CriteriaList.ToArray()), listaCONTRATO_PROVEEDOR_AF)
        Me.UcListaCONTRATO_PROVEEDOR_AF1.CargarDatosPorLista(listaCONTRATO_PROVEEDOR_AF1)
    End Sub

    Private Sub UcListaCONTRATO_PROVEEDOR_AF1_Seleccionado(ByVal ID_CONTRATO As Decimal) Handles UcListaCONTRATO_PROVEEDOR_AF1.Seleccionado
        RaiseEvent Seleccionado(ID_CONTRATO)
    End Sub

End Class
