Imports SGAFP.EL
Public Class ucBuscarLISTA_SUPERVISION_AF

    Public Event Seleccionado(ByVal ID_LISTA_SUPERVISION As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaLISTA_SUPERVISION_AF1 As New listaLISTA_SUPERVISION_AF
        listaLISTA_SUPERVISION_AF1 = CType((New cLISTA_SUPERVISION_AF).ObtenerListaPorBusqueda(New LISTA_SUPERVISION_AF, Me.CriteriaList.ToArray()), listaLISTA_SUPERVISION_AF)
        Me.UcListaLISTA_SUPERVISION_AF1.CargarDatosPorLista(listaLISTA_SUPERVISION_AF1)
    End Sub

    Private Sub UcListaLISTA_SUPERVISION_AF1_Seleccionado(ByVal ID_LISTA_SUPERVISION As Decimal) Handles UcListaLISTA_SUPERVISION_AF1.Seleccionado
        RaiseEvent Seleccionado(ID_LISTA_SUPERVISION)
    End Sub

End Class
