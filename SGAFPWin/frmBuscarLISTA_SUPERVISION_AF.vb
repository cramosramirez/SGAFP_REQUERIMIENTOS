Public Class frmBuscarLISTA_SUPERVISION_AF

    Public Event Seleccionado(ByVal ID_LISTA_SUPERVISION As Decimal) 

    Private Sub UcBuscarLISTA_SUPERVISION_AF1_Seleccionado(ByVal ID_LISTA_SUPERVISION As Decimal) Handles UcBuscarLISTA_SUPERVISION_AF1.Seleccionado
        RaiseEvent Seleccionado(ID_LISTA_SUPERVISION)
    End Sub

End Class
