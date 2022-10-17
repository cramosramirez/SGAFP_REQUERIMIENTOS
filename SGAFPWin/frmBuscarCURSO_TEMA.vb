Public Class frmBuscarCURSO_TEMA

    Public Event Seleccionado(ByVal ID_TEMA_CURSO As Decimal) 

    Private Sub UcBuscarCURSO_TEMA1_Seleccionado(ByVal ID_TEMA_CURSO As Decimal) Handles UcBuscarCURSO_TEMA1.Seleccionado
        RaiseEvent Seleccionado(ID_TEMA_CURSO)
    End Sub

End Class
