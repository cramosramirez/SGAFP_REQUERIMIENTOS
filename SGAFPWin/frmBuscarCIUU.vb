Public Class frmBuscarCIUU

    Public Event Seleccionado(ByVal CIUU As String) 

    Private Sub UcBuscarCIUU1_Seleccionado(ByVal CIUU As String) Handles UcBuscarCIUU1.Seleccionado
        RaiseEvent Seleccionado(CIUU)
    End Sub

End Class
