Imports SGAFP.EL
Public Class ucBuscarPARTICIPANTE_EXONERADO_DOC

    Public Event Seleccionado(ByVal ID_PARTICIPANTE As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaPARTICIPANTE_EXONERADO_DOC1 As New listaPARTICIPANTE_EXONERADO_DOC
        listaPARTICIPANTE_EXONERADO_DOC1 = CType((New cPARTICIPANTE_EXONERADO_DOC).ObtenerListaPorBusqueda(New PARTICIPANTE_EXONERADO_DOC, Me.CriteriaList.ToArray()), listaPARTICIPANTE_EXONERADO_DOC)
        Me.UcListaPARTICIPANTE_EXONERADO_DOC1.CargarDatosPorLista(listaPARTICIPANTE_EXONERADO_DOC1)
    End Sub

    Private Sub UcListaPARTICIPANTE_EXONERADO_DOC1_Seleccionado(ByVal ID_PARTICIPANTE As Decimal) Handles UcListaPARTICIPANTE_EXONERADO_DOC1.Seleccionado
        RaiseEvent Seleccionado(ID_PARTICIPANTE)
    End Sub

End Class
