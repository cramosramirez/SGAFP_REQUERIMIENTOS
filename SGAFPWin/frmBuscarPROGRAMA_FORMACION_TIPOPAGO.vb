Public Class frmBuscarPROGRAMA_FORMACION_TIPOPAGO

    Public Event Seleccionado(ByVal ID_TIPO_PAGO As Decimal) 

    Private Sub UcBuscarPROGRAMA_FORMACION_TIPOPAGO1_Seleccionado(ByVal ID_TIPO_PAGO As Decimal) Handles UcBuscarPROGRAMA_FORMACION_TIPOPAGO1.Seleccionado
        RaiseEvent Seleccionado(ID_TIPO_PAGO)
    End Sub

End Class
