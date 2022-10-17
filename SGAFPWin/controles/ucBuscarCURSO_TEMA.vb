Imports SGAFP.EL
Public Class ucBuscarCURSO_TEMA

    Public Event Seleccionado(ByVal ID_TEMA_CURSO As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaCURSO_TEMA1 As New listaCURSO_TEMA
        listaCURSO_TEMA1 = CType((New cCURSO_TEMA).ObtenerListaPorBusqueda(New CURSO_TEMA, Me.CriteriaList.ToArray()), listaCURSO_TEMA)
        Me.UcListaCURSO_TEMA1.CargarDatosPorLista(listaCURSO_TEMA1)
    End Sub

    Private Sub UcListaCURSO_TEMA1_Seleccionado(ByVal ID_TEMA_CURSO As Decimal) Handles UcListaCURSO_TEMA1.Seleccionado
        RaiseEvent Seleccionado(ID_TEMA_CURSO)
    End Sub

End Class
