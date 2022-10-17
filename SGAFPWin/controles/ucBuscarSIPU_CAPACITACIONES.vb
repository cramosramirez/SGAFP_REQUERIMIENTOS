Imports SGAFP.EL
Public Class ucBuscarSIPU_CAPACITACIONES

    Public Event Seleccionado(ByVal IDCAPACITACION As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaSIPU_CAPACITACIONES1 As New listaSIPU_CAPACITACIONES
        listaSIPU_CAPACITACIONES1 = CType((New cSIPU_CAPACITACIONES).ObtenerListaPorBusqueda(New SIPU_CAPACITACIONES, Me.CriteriaList.ToArray()), listaSIPU_CAPACITACIONES)
        Me.UcListaSIPU_CAPACITACIONES1.CargarDatosPorLista(listaSIPU_CAPACITACIONES1)
    End Sub

    Private Sub UcListaSIPU_CAPACITACIONES1_Seleccionado(ByVal IDCAPACITACION As Decimal) Handles UcListaSIPU_CAPACITACIONES1.Seleccionado
        RaiseEvent Seleccionado(IDCAPACITACION)
    End Sub

End Class
