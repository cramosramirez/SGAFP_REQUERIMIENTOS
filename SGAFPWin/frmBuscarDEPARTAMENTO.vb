Public Class frmBuscarDEPARTAMENTO

    Public Event Seleccionado(ByVal CODIGO_REGION As String, ByVal CODIGO_DEPARTAMENTO As String) 

    Private Sub UcBuscarDEPARTAMENTO1_Seleccionado(ByVal CODIGO_REGION As String, ByVal CODIGO_DEPARTAMENTO As String) Handles UcBuscarDEPARTAMENTO1.Seleccionado
        RaiseEvent Seleccionado(CODIGO_REGION, CODIGO_DEPARTAMENTO)
    End Sub

End Class
