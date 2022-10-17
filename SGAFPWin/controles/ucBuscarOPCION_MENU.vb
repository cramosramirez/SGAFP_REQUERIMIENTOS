Imports SGAFP.EL
Public Class ucBuscarOPCION_MENU

    Public Event Seleccionado(ByVal ID_OPCION_MENU As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaOPCION_MENU1 As New listaOPCION_MENU
        listaOPCION_MENU1 = CType((New cOPCION_MENU).ObtenerListaPorBusqueda(New OPCION_MENU, Me.CriteriaList.ToArray()), listaOPCION_MENU)
        Me.UcListaOPCION_MENU1.CargarDatosPorLista(listaOPCION_MENU1)
    End Sub

    Private Sub UcListaOPCION_MENU1_Seleccionado(ByVal ID_OPCION_MENU As Decimal) Handles UcListaOPCION_MENU1.Seleccionado
        RaiseEvent Seleccionado(ID_OPCION_MENU)
    End Sub

End Class
