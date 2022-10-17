Public Class frmBuscarEVALUACION_AF

    Public Event Seleccionado(ByVal ID_EVALUACION_AF As Decimal) 

    Private Sub UcBuscarEVALUACION_AF1_Seleccionado(ByVal ID_EVALUACION_AF As Decimal) Handles UcBuscarEVALUACION_AF1.Seleccionado
        RaiseEvent Seleccionado(ID_EVALUACION_AF)
    End Sub

End Class
