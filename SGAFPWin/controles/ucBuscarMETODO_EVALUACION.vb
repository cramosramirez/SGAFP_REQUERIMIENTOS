Imports SGAFP.EL
Public Class ucBuscarMETODO_EVALUACION

    Public Event Seleccionado(ByVal ID_METODO_EVALUACION As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaMETODO_EVALUACION1 As New listaMETODO_EVALUACION
        listaMETODO_EVALUACION1 = CType((New cMETODO_EVALUACION).ObtenerListaPorBusqueda(New METODO_EVALUACION, Me.CriteriaList.ToArray()), listaMETODO_EVALUACION)
        Me.UcListaMETODO_EVALUACION1.CargarDatosPorLista(listaMETODO_EVALUACION1)
    End Sub

    Private Sub UcListaMETODO_EVALUACION1_Seleccionado(ByVal ID_METODO_EVALUACION As Decimal) Handles UcListaMETODO_EVALUACION1.Seleccionado
        RaiseEvent Seleccionado(ID_METODO_EVALUACION)
    End Sub

End Class
