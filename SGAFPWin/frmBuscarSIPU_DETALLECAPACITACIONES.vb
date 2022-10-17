Public Class frmBuscarSIPU_DETALLECAPACITACIONES

    Public Event Seleccionado(ByVal IDDETALLECAPACITACION As Decimal) 

    Private Sub UcBuscarSIPU_DETALLECAPACITACIONES1_Seleccionado(ByVal IDDETALLECAPACITACION As Decimal) Handles UcBuscarSIPU_DETALLECAPACITACIONES1.Seleccionado
        RaiseEvent Seleccionado(IDDETALLECAPACITACION)
    End Sub

End Class
