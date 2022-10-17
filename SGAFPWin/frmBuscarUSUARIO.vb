Public Class frmBuscarUSUARIO

    Public Event Seleccionado(ByVal USUARIO As String) 

    Private Sub UcBuscarUSUARIO1_Seleccionado(ByVal USUARIO As String) Handles UcBuscarUSUARIO1.Seleccionado
        RaiseEvent Seleccionado(USUARIO)
    End Sub

End Class
