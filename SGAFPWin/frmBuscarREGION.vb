Public Class frmBuscarREGION

    Public Event Seleccionado(ByVal CODIGO_REGION As String) 

    Private Sub UcBuscarREGION1_Seleccionado(ByVal CODIGO_REGION As String) Handles UcBuscarREGION1.Seleccionado
        RaiseEvent Seleccionado(CODIGO_REGION)
    End Sub

End Class
