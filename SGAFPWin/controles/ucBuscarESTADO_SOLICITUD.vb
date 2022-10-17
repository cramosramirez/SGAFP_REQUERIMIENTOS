Imports SGAFP.EL
Public Class ucBuscarESTADO_SOLICITUD

    Public Event Seleccionado(ByVal ID_ESTADO_SOLICITUD As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaESTADO_SOLICITUD1 As New listaESTADO_SOLICITUD
        listaESTADO_SOLICITUD1 = CType((New cESTADO_SOLICITUD).ObtenerListaPorBusqueda(New ESTADO_SOLICITUD, Me.CriteriaList.ToArray()), listaESTADO_SOLICITUD)
        Me.UcListaESTADO_SOLICITUD1.CargarDatosPorLista(listaESTADO_SOLICITUD1)
    End Sub

    Private Sub UcListaESTADO_SOLICITUD1_Seleccionado(ByVal ID_ESTADO_SOLICITUD As Decimal) Handles UcListaESTADO_SOLICITUD1.Seleccionado
        RaiseEvent Seleccionado(ID_ESTADO_SOLICITUD)
    End Sub

End Class
