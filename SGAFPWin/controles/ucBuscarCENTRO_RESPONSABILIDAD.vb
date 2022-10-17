Imports SGAFP.EL
Public Class ucBuscarCENTRO_RESPONSABILIDAD

    Public Event Seleccionado(ByVal ID_CENTRO_RESPONSABILIDAD As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaCENTRO_RESPONSABILIDAD1 As New listaCENTRO_RESPONSABILIDAD
        listaCENTRO_RESPONSABILIDAD1 = CType((New cCENTRO_RESPONSABILIDAD).ObtenerListaPorBusqueda(New CENTRO_RESPONSABILIDAD, Me.CriteriaList.ToArray()), listaCENTRO_RESPONSABILIDAD)
        Me.UcListaCENTRO_RESPONSABILIDAD1.CargarDatosPorLista(listaCENTRO_RESPONSABILIDAD1)
    End Sub

    Private Sub UcListaCENTRO_RESPONSABILIDAD1_Seleccionado(ByVal ID_CENTRO_RESPONSABILIDAD As Decimal) Handles UcListaCENTRO_RESPONSABILIDAD1.Seleccionado
        RaiseEvent Seleccionado(ID_CENTRO_RESPONSABILIDAD)
    End Sub

End Class
