Imports SGAFP.EL
Public Class ucBuscarESTADO_ACCION_FORMATIVA

    Public Event Seleccionado(ByVal CODIGO_ESTADO_AF As String) 

    Protected Overrides Sub Buscar()
        Dim listaESTADO_ACCION_FORMATIVA1 As New listaESTADO_ACCION_FORMATIVA
        listaESTADO_ACCION_FORMATIVA1 = CType((New cESTADO_ACCION_FORMATIVA).ObtenerListaPorBusqueda(New ESTADO_ACCION_FORMATIVA, Me.CriteriaList.ToArray()), listaESTADO_ACCION_FORMATIVA)
        Me.UcListaESTADO_ACCION_FORMATIVA1.CargarDatosPorLista(listaESTADO_ACCION_FORMATIVA1)
    End Sub

    Private Sub UcListaESTADO_ACCION_FORMATIVA1_Seleccionado(ByVal CODIGO_ESTADO_AF As String) Handles UcListaESTADO_ACCION_FORMATIVA1.Seleccionado
        RaiseEvent Seleccionado(CODIGO_ESTADO_AF)
    End Sub

End Class
