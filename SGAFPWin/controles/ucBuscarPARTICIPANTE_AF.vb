Imports SGAFP.EL
Public Class ucBuscarPARTICIPANTE_AF

    Public Event Seleccionado(ByVal ID_PARTICIPANTE As Decimal, ByVal ID_ACCION_FORMATIVA As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaPARTICIPANTE_AF1 As New listaPARTICIPANTE_AF
        listaPARTICIPANTE_AF1 = CType((New cPARTICIPANTE_AF).ObtenerListaPorBusqueda(New PARTICIPANTE_AF, Me.CriteriaList.ToArray()), listaPARTICIPANTE_AF)
        Me.UcListaPARTICIPANTE_AF1.CargarDatosPorLista(listaPARTICIPANTE_AF1)
    End Sub

    Private Sub UcListaPARTICIPANTE_AF1_Seleccionado(ByVal ID_PARTICIPANTE As Decimal, ByVal ID_ACCION_FORMATIVA As Decimal) Handles UcListaPARTICIPANTE_AF1.Seleccionado
        RaiseEvent Seleccionado(ID_PARTICIPANTE, ID_ACCION_FORMATIVA)
    End Sub

End Class
