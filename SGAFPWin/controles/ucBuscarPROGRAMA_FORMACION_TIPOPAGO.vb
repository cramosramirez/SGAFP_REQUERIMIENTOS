Imports SGAFP.EL
Public Class ucBuscarPROGRAMA_FORMACION_TIPOPAGO

    Public Event Seleccionado(ByVal ID_TIPO_PAGO As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaPROGRAMA_FORMACION_TIPOPAGO1 As New listaPROGRAMA_FORMACION_TIPOPAGO
        listaPROGRAMA_FORMACION_TIPOPAGO1 = CType((New cPROGRAMA_FORMACION_TIPOPAGO).ObtenerListaPorBusqueda(New PROGRAMA_FORMACION_TIPOPAGO, Me.CriteriaList.ToArray()), listaPROGRAMA_FORMACION_TIPOPAGO)
        Me.UcListaPROGRAMA_FORMACION_TIPOPAGO1.CargarDatosPorLista(listaPROGRAMA_FORMACION_TIPOPAGO1)
    End Sub

    Private Sub UcListaPROGRAMA_FORMACION_TIPOPAGO1_Seleccionado(ByVal ID_TIPO_PAGO As Decimal) Handles UcListaPROGRAMA_FORMACION_TIPOPAGO1.Seleccionado
        RaiseEvent Seleccionado(ID_TIPO_PAGO)
    End Sub

End Class
