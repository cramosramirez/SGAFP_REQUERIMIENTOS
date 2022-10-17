Public Class frmBuscarOFERTA_FORMATIVA

    Public Event Seleccionado(ByVal ID_OFERTA_FORMATIVA As Decimal) 

    Private Sub UcBuscarOFERTA_FORMATIVA1_Seleccionado(ByVal ID_OFERTA_FORMATIVA As Decimal) Handles UcBuscarOFERTA_FORMATIVA1.Seleccionado
        RaiseEvent Seleccionado(ID_OFERTA_FORMATIVA)
    End Sub

End Class
