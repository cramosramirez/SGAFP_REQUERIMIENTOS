Imports SGAFP.EL
Public Class ucBuscarEMPRESAS

    Public Event Seleccionado(ByVal NUMERO_PATRONAL As String) 

    Protected Overrides Sub Buscar()
        Dim listaEMPRESAS1 As New listaEMPRESAS
        listaEMPRESAS1 = CType((New cEMPRESAS).ObtenerListaPorBusqueda(New EMPRESAS, Me.CriteriaList.ToArray()), listaEMPRESAS)
        Me.UcListaEMPRESAS1.CargarDatosPorLista(listaEMPRESAS1)
    End Sub

    Private Sub UcListaEMPRESAS1_Seleccionado(ByVal NUMERO_PATRONAL As String) Handles UcListaEMPRESAS1.Seleccionado
        RaiseEvent Seleccionado(NUMERO_PATRONAL)
    End Sub

End Class
