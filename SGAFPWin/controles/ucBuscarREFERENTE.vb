Imports SGAFP.EL
Public Class ucBuscarREFERENTE

    Public Event Seleccionado(ByVal ID_REFERENTE As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaREFERENTE1 As New listaREFERENTE
        listaREFERENTE1 = CType((New cREFERENTE).ObtenerListaPorBusqueda(New REFERENTE, Me.CriteriaList.ToArray()), listaREFERENTE)
        Me.UcListaREFERENTE1.CargarDatosPorLista(listaREFERENTE1)
    End Sub

    Private Sub UcListaREFERENTE1_Seleccionado(ByVal ID_REFERENTE As Decimal) Handles UcListaREFERENTE1.Seleccionado
        RaiseEvent Seleccionado(ID_REFERENTE)
    End Sub

End Class
