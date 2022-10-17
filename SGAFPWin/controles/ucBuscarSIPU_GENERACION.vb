Imports SGAFP.EL
Public Class ucBuscarSIPU_GENERACION

    Public Event Seleccionado(ByVal ID_GENERACION As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaSIPU_GENERACION1 As New listaSIPU_GENERACION
        listaSIPU_GENERACION1 = CType((New cSIPU_GENERACION).ObtenerListaPorBusqueda(New SIPU_GENERACION, Me.CriteriaList.ToArray()), listaSIPU_GENERACION)
        Me.UcListaSIPU_GENERACION1.CargarDatosPorLista(listaSIPU_GENERACION1)
    End Sub

    Private Sub UcListaSIPU_GENERACION1_Seleccionado(ByVal ID_GENERACION As Decimal) Handles UcListaSIPU_GENERACION1.Seleccionado
        RaiseEvent Seleccionado(ID_GENERACION)
    End Sub

End Class
