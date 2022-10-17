Imports SGAFP.EL
Public Class ucBuscarSOLICITUD_CAPACITACION

    Public Event Seleccionado(ByVal ID_SOLICITUD As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaSOLICITUD_CAPACITACION1 As New listaSOLICITUD_CAPACITACION
        listaSOLICITUD_CAPACITACION1 = CType((New cSOLICITUD_CAPACITACION).ObtenerListaPorBusqueda(New SOLICITUD_CAPACITACION, Me.CriteriaList.ToArray()), listaSOLICITUD_CAPACITACION)
        Me.UcListaSOLICITUD_CAPACITACION1.CargarDatosPorLista(listaSOLICITUD_CAPACITACION1)
    End Sub

    Private Sub UcListaSOLICITUD_CAPACITACION1_Seleccionado(ByVal ID_SOLICITUD As Decimal) Handles UcListaSOLICITUD_CAPACITACION1.Seleccionado
        RaiseEvent Seleccionado(ID_SOLICITUD)
    End Sub

End Class
