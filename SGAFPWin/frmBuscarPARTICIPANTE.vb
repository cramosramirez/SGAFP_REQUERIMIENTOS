Public Class frmBuscarPARTICIPANTE

    Public Event Seleccionado(ByVal ID_PARTICIPANTE As Decimal) 

    Private Sub UcBuscarPARTICIPANTE1_Seleccionado(ByVal ID_PARTICIPANTE As Decimal) Handles UcBuscarPARTICIPANTE1.Seleccionado
        RaiseEvent Seleccionado(ID_PARTICIPANTE)
    End Sub

End Class
