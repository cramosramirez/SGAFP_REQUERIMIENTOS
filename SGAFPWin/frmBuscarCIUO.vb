Public Class frmBuscarCIUO

    Public Event Seleccionado(ByVal CIUO As String) 

    Private Sub UcBuscarCIUO1_Seleccionado(ByVal CIUO As String) Handles UcBuscarCIUO1.Seleccionado
        RaiseEvent Seleccionado(CIUO)
    End Sub

End Class
