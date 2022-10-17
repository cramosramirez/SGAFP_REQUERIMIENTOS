Imports SGAFP.EL
Public Class ucBuscarCONTRATO_BOLPROS

    Public Event Seleccionado(ByVal ID_CONTRATO As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaCONTRATO_BOLPROS1 As New listaCONTRATO_BOLPROS
        listaCONTRATO_BOLPROS1 = CType((New cCONTRATO_BOLPROS).ObtenerListaPorBusqueda(New CONTRATO_BOLPROS, Me.CriteriaList.ToArray()), listaCONTRATO_BOLPROS)
        Me.UcListaCONTRATO_BOLPROS1.CargarDatosPorLista(listaCONTRATO_BOLPROS1)
    End Sub

    Private Sub UcListaCONTRATO_BOLPROS1_Seleccionado(ByVal ID_CONTRATO As Decimal) Handles UcListaCONTRATO_BOLPROS1.Seleccionado
        RaiseEvent Seleccionado(ID_CONTRATO)
    End Sub

End Class
