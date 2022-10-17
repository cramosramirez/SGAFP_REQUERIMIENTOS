Imports SGAFP.EL
Public Class ucBuscarHALLAZGO_SUPERVISION

    Public Event Seleccionado(ByVal ID_HALLAZGO_SUPERVISION As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaHALLAZGO_SUPERVISION1 As New listaHALLAZGO_SUPERVISION
        listaHALLAZGO_SUPERVISION1 = CType((New cHALLAZGO_SUPERVISION).ObtenerListaPorBusqueda(New HALLAZGO_SUPERVISION, Me.CriteriaList.ToArray()), listaHALLAZGO_SUPERVISION)
        Me.UcListaHALLAZGO_SUPERVISION1.CargarDatosPorLista(listaHALLAZGO_SUPERVISION1)
    End Sub

    Private Sub UcListaHALLAZGO_SUPERVISION1_Seleccionado(ByVal ID_HALLAZGO_SUPERVISION As Decimal) Handles UcListaHALLAZGO_SUPERVISION1.Seleccionado
        RaiseEvent Seleccionado(ID_HALLAZGO_SUPERVISION)
    End Sub

End Class
