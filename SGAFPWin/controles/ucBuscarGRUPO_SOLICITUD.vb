Imports SGAFP.EL
Public Class ucBuscarGRUPO_SOLICITUD

    Public Event Seleccionado(ByVal ID_GRUPO_SOLICITUD As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaGRUPO_SOLICITUD1 As New listaGRUPO_SOLICITUD
        listaGRUPO_SOLICITUD1 = CType((New cGRUPO_SOLICITUD).ObtenerListaPorBusqueda(New GRUPO_SOLICITUD, Me.CriteriaList.ToArray()), listaGRUPO_SOLICITUD)
        Me.UcListaGRUPO_SOLICITUD1.CargarDatosPorLista(listaGRUPO_SOLICITUD1)
    End Sub

    Private Sub UcListaGRUPO_SOLICITUD1_Seleccionado(ByVal ID_GRUPO_SOLICITUD As Decimal) Handles UcListaGRUPO_SOLICITUD1.Seleccionado
        RaiseEvent Seleccionado(ID_GRUPO_SOLICITUD)
    End Sub

End Class
