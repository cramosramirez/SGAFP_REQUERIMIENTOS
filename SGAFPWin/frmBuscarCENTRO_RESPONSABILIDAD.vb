Public Class frmBuscarCENTRO_RESPONSABILIDAD

    Public Event Seleccionado(ByVal ID_CENTRO_RESPONSABILIDAD As Decimal) 

    Private Sub UcBuscarCENTRO_RESPONSABILIDAD1_Seleccionado(ByVal ID_CENTRO_RESPONSABILIDAD As Decimal) Handles UcBuscarCENTRO_RESPONSABILIDAD1.Seleccionado
        RaiseEvent Seleccionado(ID_CENTRO_RESPONSABILIDAD)
    End Sub

End Class
