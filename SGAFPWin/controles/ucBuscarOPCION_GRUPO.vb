Imports SGAFP.EL
Public Class ucBuscarOPCION_GRUPO

    Public Event Seleccionado(ByVal ID_OPCION_GRUPO As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaOPCION_GRUPO1 As New listaOPCION_GRUPO
        listaOPCION_GRUPO1 = CType((New cOPCION_GRUPO).ObtenerListaPorBusqueda(New OPCION_GRUPO, Me.CriteriaList.ToArray()), listaOPCION_GRUPO)
        Me.UcListaOPCION_GRUPO1.CargarDatosPorLista(listaOPCION_GRUPO1)
    End Sub

    Private Sub UcListaOPCION_GRUPO1_Seleccionado(ByVal ID_OPCION_GRUPO As Decimal) Handles UcListaOPCION_GRUPO1.Seleccionado
        RaiseEvent Seleccionado(ID_OPCION_GRUPO)
    End Sub

End Class
