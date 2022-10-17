Public Class frmBuscarSIPU_TIPOCAPACITACIONES

    Public Event Seleccionado(ByVal IDTIPOCAPACITACION As Decimal) 

    Private Sub UcBuscarSIPU_TIPOCAPACITACIONES1_Seleccionado(ByVal IDTIPOCAPACITACION As Decimal) Handles UcBuscarSIPU_TIPOCAPACITACIONES1.Seleccionado
        RaiseEvent Seleccionado(IDTIPOCAPACITACION)
    End Sub

End Class
