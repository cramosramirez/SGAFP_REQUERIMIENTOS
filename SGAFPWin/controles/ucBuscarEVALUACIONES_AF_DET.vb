Imports SGAFP.EL
Public Class ucBuscarEVALUACIONES_AF_DET

    Public Event Seleccionado(ByVal ID_EVALUACION_DET As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaEVALUACIONES_AF_DET1 As New listaEVALUACIONES_AF_DET
        listaEVALUACIONES_AF_DET1 = CType((New cEVALUACIONES_AF_DET).ObtenerListaPorBusqueda(New EVALUACIONES_AF_DET, Me.CriteriaList.ToArray()), listaEVALUACIONES_AF_DET)
        Me.UcListaEVALUACIONES_AF_DET1.CargarDatosPorLista(listaEVALUACIONES_AF_DET1)
    End Sub

    Private Sub UcListaEVALUACIONES_AF_DET1_Seleccionado(ByVal ID_EVALUACION_DET As Decimal) Handles UcListaEVALUACIONES_AF_DET1.Seleccionado
        RaiseEvent Seleccionado(ID_EVALUACION_DET)
    End Sub

End Class
