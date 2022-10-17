Imports SGAFP.EL
Public Class ucBuscarAREA_SUPERVISION

    Public Event Seleccionado(ByVal ID_AREA_SUPERVISION As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaAREA_SUPERVISION1 As New listaAREA_SUPERVISION
        listaAREA_SUPERVISION1 = CType((New cAREA_SUPERVISION).ObtenerListaPorBusqueda(New AREA_SUPERVISION, Me.CriteriaList.ToArray()), listaAREA_SUPERVISION)
        Me.UcListaAREA_SUPERVISION1.CargarDatosPorLista(listaAREA_SUPERVISION1)
    End Sub

    Private Sub UcListaAREA_SUPERVISION1_Seleccionado(ByVal ID_AREA_SUPERVISION As Decimal) Handles UcListaAREA_SUPERVISION1.Seleccionado
        RaiseEvent Seleccionado(ID_AREA_SUPERVISION)
    End Sub

End Class
