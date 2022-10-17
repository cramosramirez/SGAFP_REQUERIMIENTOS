Imports SGAFP.EL
Public Class ucBuscarEVALUACION_AF

    Public Event Seleccionado(ByVal ID_EVALUACION_AF As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaEVALUACION_AF1 As New listaEVALUACION_AF
        listaEVALUACION_AF1 = CType((New cEVALUACION_AF).ObtenerListaPorBusqueda(New EVALUACION_AF, Me.CriteriaList.ToArray()), listaEVALUACION_AF)
        Me.UcListaEVALUACION_AF1.CargarDatosPorLista(listaEVALUACION_AF1)
    End Sub

    Private Sub UcListaEVALUACION_AF1_Seleccionado(ByVal ID_EVALUACION_AF As Decimal) Handles UcListaEVALUACION_AF1.Seleccionado
        RaiseEvent Seleccionado(ID_EVALUACION_AF)
    End Sub

End Class
