Imports SGAFP.EL
Public Class ucBuscarCATCURSO_2

    Public Event Seleccionado(ByVal ID_CURSO As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaCATCURSO_21 As New listaCATCURSO_2
        listaCATCURSO_21 = CType((New cCATCURSO_2).ObtenerListaPorBusqueda(New CATCURSO_2, Me.CriteriaList.ToArray()), listaCATCURSO_2)
        Me.UcListaCATCURSO_21.CargarDatosPorLista(listaCATCURSO_21)
    End Sub

    Private Sub UcListaCATCURSO_21_Seleccionado(ByVal ID_CURSO As Decimal) Handles UcListaCATCURSO_21.Seleccionado
        RaiseEvent Seleccionado(ID_CURSO)
    End Sub

End Class
