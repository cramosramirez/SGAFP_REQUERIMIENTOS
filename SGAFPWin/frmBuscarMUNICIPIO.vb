Public Class frmBuscarMUNICIPIO

    Public Event Seleccionado(ByVal CODIGO_MUNICIPIO As String, ByVal CODIGO_REGION As String, ByVal CODIGO_DEPARTAMENTO As String) 

    Private Sub UcBuscarMUNICIPIO1_Seleccionado(ByVal CODIGO_MUNICIPIO As String, ByVal CODIGO_REGION As String, ByVal CODIGO_DEPARTAMENTO As String) Handles UcBuscarMUNICIPIO1.Seleccionado
        RaiseEvent Seleccionado(CODIGO_MUNICIPIO, CODIGO_REGION, CODIGO_DEPARTAMENTO)
    End Sub

End Class
