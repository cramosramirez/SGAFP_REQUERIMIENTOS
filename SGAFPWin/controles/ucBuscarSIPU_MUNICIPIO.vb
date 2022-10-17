Imports SGAFP.EL
Public Class ucBuscarSIPU_MUNICIPIO

    Public Event Seleccionado(ByVal IDMUNICIPIO As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaSIPU_MUNICIPIO1 As New listaSIPU_MUNICIPIO
        listaSIPU_MUNICIPIO1 = CType((New cSIPU_MUNICIPIO).ObtenerListaPorBusqueda(New SIPU_MUNICIPIO, Me.CriteriaList.ToArray()), listaSIPU_MUNICIPIO)
        Me.UcListaSIPU_MUNICIPIO1.CargarDatosPorLista(listaSIPU_MUNICIPIO1)
    End Sub

    Private Sub UcListaSIPU_MUNICIPIO1_Seleccionado(ByVal IDMUNICIPIO As Decimal) Handles UcListaSIPU_MUNICIPIO1.Seleccionado
        RaiseEvent Seleccionado(IDMUNICIPIO)
    End Sub

End Class
