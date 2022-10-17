Public Class frmBuscarETAPA

    Public Event Seleccionado(ByVal CODIGO_ETAPA As String, ByVal CODIGO_PROCESO As String) 

    Private Sub UcBuscarETAPA1_Seleccionado(ByVal CODIGO_ETAPA As String, ByVal CODIGO_PROCESO As String) Handles UcBuscarETAPA1.Seleccionado
        RaiseEvent Seleccionado(CODIGO_ETAPA, CODIGO_PROCESO)
    End Sub

End Class
