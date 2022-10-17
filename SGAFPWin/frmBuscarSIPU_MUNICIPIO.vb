Public Class frmBuscarSIPU_MUNICIPIO

    Public Event Seleccionado(ByVal IDMUNICIPIO As Decimal) 

    Private Sub UcBuscarSIPU_MUNICIPIO1_Seleccionado(ByVal IDMUNICIPIO As Decimal) Handles UcBuscarSIPU_MUNICIPIO1.Seleccionado
        RaiseEvent Seleccionado(IDMUNICIPIO)
    End Sub

End Class
