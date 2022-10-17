Imports SGAFP.EL
Public Class ucBuscarSIPU_DETALLECAPACITACIONES

    Public Event Seleccionado(ByVal IDDETALLECAPACITACION As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaSIPU_DETALLECAPACITACIONES1 As New ListaSIPU_DETALLECAPACITADO
        listaSIPU_DETALLECAPACITACIONES1 = CType((New cSIPU_DETALLECAPACITADO).ObtenerListaPorBusqueda(New SIPU_DETALLECAPACITADO, Me.CriteriaList.ToArray()), ListaSIPU_DETALLECAPACITADO)
        Me.UcListaSIPU_DETALLECAPACITACIONES1.CargarDatosPorLista(listaSIPU_DETALLECAPACITACIONES1)
    End Sub

    Private Sub UcListaSIPU_DETALLECAPACITACIONES1_Seleccionado(ByVal IDDETALLECAPACITACION As Decimal) Handles UcListaSIPU_DETALLECAPACITACIONES1.Seleccionado
        RaiseEvent Seleccionado(IDDETALLECAPACITACION)
    End Sub

End Class
