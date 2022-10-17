Imports SGAFP.EL
Public Class ucBuscarGRUPO_USUARIO

    Public Event Seleccionado(ByVal ID_GRUPO_USUARIO As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaGRUPO_USUARIO1 As New listaGRUPO_USUARIO
        listaGRUPO_USUARIO1 = CType((New cGRUPO_USUARIO).ObtenerListaPorBusqueda(New GRUPO_USUARIO, Me.CriteriaList.ToArray()), listaGRUPO_USUARIO)
        Me.UcListaGRUPO_USUARIO1.CargarDatosPorLista(listaGRUPO_USUARIO1)
    End Sub

    Private Sub UcListaGRUPO_USUARIO1_Seleccionado(ByVal ID_GRUPO_USUARIO As Decimal) Handles UcListaGRUPO_USUARIO1.Seleccionado
        RaiseEvent Seleccionado(ID_GRUPO_USUARIO)
    End Sub

End Class
