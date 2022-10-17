Public Class frmBuscarEVALUACIONES_AF_DET

    Public Event Seleccionado(ByVal ID_EVALUACION_DET As Decimal) 

    Private Sub UcBuscarEVALUACIONES_AF_DET1_Seleccionado(ByVal ID_EVALUACION_DET As Decimal) Handles UcBuscarEVALUACIONES_AF_DET1.Seleccionado
        RaiseEvent Seleccionado(ID_EVALUACION_DET)
    End Sub

End Class
