Public Class frmBuscarPROCESO

    Public Event Seleccionado(ByVal CODIGO_PROCESO As String) 

    Private Sub UcBuscarPROCESO1_Seleccionado(ByVal CODIGO_PROCESO As String) Handles UcBuscarPROCESO1.Seleccionado
        RaiseEvent Seleccionado(CODIGO_PROCESO)
    End Sub

End Class
