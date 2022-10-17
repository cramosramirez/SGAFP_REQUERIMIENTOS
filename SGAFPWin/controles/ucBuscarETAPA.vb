Imports SGAFP.EL
Public Class ucBuscarETAPA

    Public Event Seleccionado(ByVal CODIGO_ETAPA As String, ByVal CODIGO_PROCESO As String) 

    Protected Overrides Sub Buscar()
        Dim listaETAPA1 As New listaETAPA
        listaETAPA1 = CType((New cETAPA).ObtenerListaPorBusqueda(New ETAPA, Me.CriteriaList.ToArray()), listaETAPA)
        Me.UcListaETAPA1.CargarDatosPorLista(listaETAPA1)
    End Sub

    Private Sub UcListaETAPA1_Seleccionado(ByVal CODIGO_ETAPA As String, ByVal CODIGO_PROCESO As String) Handles UcListaETAPA1.Seleccionado
        RaiseEvent Seleccionado(CODIGO_ETAPA, CODIGO_PROCESO)
    End Sub

End Class
