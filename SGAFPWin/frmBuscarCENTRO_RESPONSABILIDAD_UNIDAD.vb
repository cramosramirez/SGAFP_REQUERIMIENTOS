Public Class frmBuscarCENTRO_RESPONSABILIDAD_UNIDAD

    Public Event Seleccionado(ByVal ID_CENTRO_RESPONSABILIDAD As Decimal, ByVal ID_UNIDAD_ORGANIZATIVA As Decimal) 

    Private Sub UcBuscarCENTRO_RESPONSABILIDAD_UNIDAD1_Seleccionado(ByVal ID_CENTRO_RESPONSABILIDAD As Decimal, ByVal ID_UNIDAD_ORGANIZATIVA As Decimal) Handles UcBuscarCENTRO_RESPONSABILIDAD_UNIDAD1.Seleccionado
        RaiseEvent Seleccionado(ID_CENTRO_RESPONSABILIDAD, ID_UNIDAD_ORGANIZATIVA)
    End Sub

End Class
