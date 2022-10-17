Imports SGAFP.EL
Public Class ucBuscarTIPO_SOLICITUD

    Public Event Seleccionado(ByVal ID_TIPO_SOLICITUD As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaTIPO_SOLICITUD1 As New listaTIPO_SOLICITUD
        listaTIPO_SOLICITUD1 = CType((New cTIPO_SOLICITUD).ObtenerListaPorBusqueda(New TIPO_SOLICITUD, Me.CriteriaList.ToArray()), listaTIPO_SOLICITUD)
        Me.UcListaTIPO_SOLICITUD1.CargarDatosPorLista(listaTIPO_SOLICITUD1)
    End Sub

    Private Sub UcListaTIPO_SOLICITUD1_Seleccionado(ByVal ID_TIPO_SOLICITUD As Decimal) Handles UcListaTIPO_SOLICITUD1.Seleccionado
        RaiseEvent Seleccionado(ID_TIPO_SOLICITUD)
    End Sub

End Class
