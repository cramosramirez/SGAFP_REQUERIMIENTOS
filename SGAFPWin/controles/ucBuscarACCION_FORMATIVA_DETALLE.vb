Imports SGAFP.EL
Public Class ucBuscarACCION_FORMATIVA_DETALLE

    Public Event Seleccionado(ByVal ID_ACCION_FORMATIVA As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaACCION_FORMATIVA_DETALLE1 As New listaACCION_FORMATIVA_DETALLE
        listaACCION_FORMATIVA_DETALLE1 = CType((New cACCION_FORMATIVA_DETALLE).ObtenerListaPorBusqueda(New ACCION_FORMATIVA_DETALLE, Me.CriteriaList.ToArray()), listaACCION_FORMATIVA_DETALLE)
        Me.UcListaACCION_FORMATIVA_DETALLE1.CargarDatosPorLista(listaACCION_FORMATIVA_DETALLE1)
    End Sub

    Private Sub UcListaACCION_FORMATIVA_DETALLE1_Seleccionado(ByVal ID_ACCION_FORMATIVA As Decimal) Handles UcListaACCION_FORMATIVA_DETALLE1.Seleccionado
        RaiseEvent Seleccionado(ID_ACCION_FORMATIVA)
    End Sub

End Class
