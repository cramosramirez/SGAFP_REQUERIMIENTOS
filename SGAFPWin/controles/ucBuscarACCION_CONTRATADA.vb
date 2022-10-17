Imports SGAFP.EL
Public Class ucBuscarACCION_CONTRATADA

    Public Event Seleccionado(ByVal ID_ACCION_CONTRATADA As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaACCION_CONTRATADA1 As New listaACCION_CONTRATADA
        listaACCION_CONTRATADA1 = CType((New cACCION_CONTRATADA).ObtenerListaPorBusqueda(New ACCION_CONTRATADA, Me.CriteriaList.ToArray()), listaACCION_CONTRATADA)
        Me.UcListaACCION_CONTRATADA1.CargarDatosPorLista(listaACCION_CONTRATADA1)
    End Sub

    Private Sub UcListaACCION_CONTRATADA1_Seleccionado(ByVal ID_ACCION_CONTRATADA As Decimal) Handles UcListaACCION_CONTRATADA1.Seleccionado
        RaiseEvent Seleccionado(ID_ACCION_CONTRATADA)
    End Sub

End Class
