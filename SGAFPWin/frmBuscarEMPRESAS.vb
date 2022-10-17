Public Class frmBuscarEMPRESAS

    Public Event Seleccionado(ByVal NUMERO_PATRONAL As String) 

    Private Sub UcBuscarEMPRESAS1_Seleccionado(ByVal NUMERO_PATRONAL As String) Handles UcBuscarEMPRESAS1.Seleccionado
        RaiseEvent Seleccionado(NUMERO_PATRONAL)
    End Sub

End Class
