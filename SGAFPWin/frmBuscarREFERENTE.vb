Public Class frmBuscarREFERENTE

    Public Event Seleccionado(ByVal ID_REFERENTE As Decimal) 

    Private Sub UcBuscarREFERENTE1_Seleccionado(ByVal ID_REFERENTE As Decimal) Handles UcBuscarREFERENTE1.Seleccionado
        RaiseEvent Seleccionado(ID_REFERENTE)
    End Sub

End Class
