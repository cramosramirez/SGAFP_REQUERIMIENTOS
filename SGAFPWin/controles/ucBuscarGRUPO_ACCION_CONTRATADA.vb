Imports SGAFP.EL
Public Class ucBuscarGRUPO_ACCION_CONTRATADA

    Public Event Seleccionado(ByVal ID_GRUPO_ACCION As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaGRUPO_ACCION_CONTRATADA1 As New listaGRUPO_ACCION_CONTRATADA
        listaGRUPO_ACCION_CONTRATADA1 = CType((New cGRUPO_ACCION_CONTRATADA).ObtenerListaPorBusqueda(New GRUPO_ACCION_CONTRATADA, Me.CriteriaList.ToArray()), listaGRUPO_ACCION_CONTRATADA)
        Me.UcListaGRUPO_ACCION_CONTRATADA1.CargarDatosPorLista(listaGRUPO_ACCION_CONTRATADA1)
    End Sub

    Private Sub UcListaGRUPO_ACCION_CONTRATADA1_Seleccionado(ByVal ID_GRUPO_ACCION As Decimal) Handles UcListaGRUPO_ACCION_CONTRATADA1.Seleccionado
        RaiseEvent Seleccionado(ID_GRUPO_ACCION)
    End Sub

End Class
