Imports SGAFP.EL
Public Class ucBuscarACCION_FORMATIVA

    Public Event Seleccionado(ByVal ID_ACCION_FORMATIVA As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaACCION_FORMATIVA1 As New listaACCION_FORMATIVA
        listaACCION_FORMATIVA1 = CType((New cACCION_FORMATIVA).ObtenerListaPorBusqueda(New ACCION_FORMATIVA, Me.CriteriaList.ToArray()), listaACCION_FORMATIVA)
        Me.UcListaACCION_FORMATIVA1.CargarDatosPorLista(listaACCION_FORMATIVA1)
    End Sub

    Private Sub UcListaACCION_FORMATIVA1_Seleccionado(ByVal ID_ACCION_FORMATIVA As Decimal) Handles UcListaACCION_FORMATIVA1.Seleccionado
        RaiseEvent Seleccionado(ID_ACCION_FORMATIVA)
    End Sub

End Class
