Public Class frmBuscarCATCURSO_2

    Public Event Seleccionado(ByVal ID_CURSO As Decimal) 

    Private Sub UcBuscarCATCURSO_21_Seleccionado(ByVal ID_CURSO As Decimal) Handles UcBuscarCATCURSO_21.Seleccionado
        RaiseEvent Seleccionado(ID_CURSO)
    End Sub

End Class
