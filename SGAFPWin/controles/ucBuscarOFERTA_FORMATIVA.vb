Imports SGAFP.EL
Public Class ucBuscarOFERTA_FORMATIVA

    Public Event Seleccionado(ByVal ID_OFERTA_FORMATIVA As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaOFERTA_FORMATIVA1 As New listaOFERTA_FORMATIVA
        listaOFERTA_FORMATIVA1 = CType((New cOFERTA_FORMATIVA).ObtenerListaPorBusqueda(New OFERTA_FORMATIVA, Me.CriteriaList.ToArray()), listaOFERTA_FORMATIVA)
        Me.UcListaOFERTA_FORMATIVA1.CargarDatosPorLista(listaOFERTA_FORMATIVA1)
    End Sub

    Private Sub UcListaOFERTA_FORMATIVA1_Seleccionado(ByVal ID_OFERTA_FORMATIVA As Decimal) Handles UcListaOFERTA_FORMATIVA1.Seleccionado
        RaiseEvent Seleccionado(ID_OFERTA_FORMATIVA)
    End Sub

End Class
