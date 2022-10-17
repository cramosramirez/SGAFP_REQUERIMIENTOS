Imports SGAFP.EL
Public Class ucBuscarPARTICIPANTE

    Public Event Seleccionado(ByVal ID_PARTICIPANTE As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaPARTICIPANTE1 As New listaPARTICIPANTE
        listaPARTICIPANTE1 = CType((New cPARTICIPANTE).ObtenerListaPorBusqueda(New PARTICIPANTE, Me.CriteriaList.ToArray()), listaPARTICIPANTE)
        Me.UcListaPARTICIPANTE1.CargarDatosPorLista(listaPARTICIPANTE1)
    End Sub

    Private Sub UcListaPARTICIPANTE1_Seleccionado(ByVal ID_PARTICIPANTE As Decimal) Handles UcListaPARTICIPANTE1.Seleccionado
        RaiseEvent Seleccionado(ID_PARTICIPANTE)
    End Sub

End Class
