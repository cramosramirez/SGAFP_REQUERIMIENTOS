Public Class frmBuscarSIPU_CAPACITACIONES

    Public Event Seleccionado(ByVal IDCAPACITACION As Decimal) 

    Private Sub UcBuscarSIPU_CAPACITACIONES1_Seleccionado(ByVal IDCAPACITACION As Decimal) Handles UcBuscarSIPU_CAPACITACIONES1.Seleccionado
        RaiseEvent Seleccionado(IDCAPACITACION)
    End Sub

End Class
