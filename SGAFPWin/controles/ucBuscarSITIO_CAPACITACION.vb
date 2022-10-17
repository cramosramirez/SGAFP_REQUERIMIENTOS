Imports SGAFP.EL
Public Class ucBuscarSITIO_CAPACITACION

    Public Event Seleccionado(ByVal ID_SITIO_CAPACITACION As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaSITIO_CAPACITACION1 As New listaSITIO_CAPACITACION
        listaSITIO_CAPACITACION1 = CType((New cSITIO_CAPACITACION).ObtenerListaPorBusqueda(New SITIO_CAPACITACION, Me.CriteriaList.ToArray()), listaSITIO_CAPACITACION)
        Me.UcListaSITIO_CAPACITACION1.CargarDatosPorLista(listaSITIO_CAPACITACION1)
    End Sub

    Private Sub UcListaSITIO_CAPACITACION1_Seleccionado(ByVal ID_SITIO_CAPACITACION As Decimal) Handles UcListaSITIO_CAPACITACION1.Seleccionado
        RaiseEvent Seleccionado(ID_SITIO_CAPACITACION)
    End Sub

End Class
