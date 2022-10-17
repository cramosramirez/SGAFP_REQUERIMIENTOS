Imports SGAFP.EL
Public Class ucBuscarPROCESO

    Public Event Seleccionado(ByVal CODIGO_PROCESO As String) 

    Protected Overrides Sub Buscar()
        Dim listaPROCESO1 As New listaPROCESO
        listaPROCESO1 = CType((New cPROCESO).ObtenerListaPorBusqueda(New PROCESO, Me.CriteriaList.ToArray()), listaPROCESO)
        Me.UcListaPROCESO1.CargarDatosPorLista(listaPROCESO1)
    End Sub

    Private Sub UcListaPROCESO1_Seleccionado(ByVal CODIGO_PROCESO As String) Handles UcListaPROCESO1.Seleccionado
        RaiseEvent Seleccionado(CODIGO_PROCESO)
    End Sub

End Class
