Imports SGAFP.EL
Public Class ucBuscarDEPARTAMENTO

    Public Event Seleccionado(ByVal CODIGO_REGION As String, ByVal CODIGO_DEPARTAMENTO As String) 

    Protected Overrides Sub Buscar()
        Dim listaDEPARTAMENTO1 As New listaDEPARTAMENTO
        listaDEPARTAMENTO1 = CType((New cDEPARTAMENTO).ObtenerListaPorBusqueda(New DEPARTAMENTO, Me.CriteriaList.ToArray()), listaDEPARTAMENTO)
        Me.UcListaDEPARTAMENTO1.CargarDatosPorLista(listaDEPARTAMENTO1)
    End Sub

    Private Sub UcListaDEPARTAMENTO1_Seleccionado(ByVal CODIGO_REGION As String, ByVal CODIGO_DEPARTAMENTO As String) Handles UcListaDEPARTAMENTO1.Seleccionado
        RaiseEvent Seleccionado(CODIGO_REGION, CODIGO_DEPARTAMENTO)
    End Sub

End Class
