Imports SGAFP.EL
Public Class ucBuscarSIPU_TIPOCAPACITACIONES

    Public Event Seleccionado(ByVal IDTIPOCAPACITACION As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaSIPU_TIPOCAPACITACIONES1 As New listaSIPU_TIPOCAPACITACIONES
        listaSIPU_TIPOCAPACITACIONES1 = CType((New cSIPU_TIPOCAPACITACIONES).ObtenerListaPorBusqueda(New SIPU_TIPOCAPACITACIONES, Me.CriteriaList.ToArray()), listaSIPU_TIPOCAPACITACIONES)
        Me.UcListaSIPU_TIPOCAPACITACIONES1.CargarDatosPorLista(listaSIPU_TIPOCAPACITACIONES1)
    End Sub

    Private Sub UcListaSIPU_TIPOCAPACITACIONES1_Seleccionado(ByVal IDTIPOCAPACITACION As Decimal) Handles UcListaSIPU_TIPOCAPACITACIONES1.Seleccionado
        RaiseEvent Seleccionado(IDTIPOCAPACITACION)
    End Sub

End Class
