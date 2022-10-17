Public Class frmBuscarSITIO_CAPACITACION

    Public Event Seleccionado(ByVal ID_SITIO_CAPACITACION As Decimal) 

    Private Sub UcBuscarSITIO_CAPACITACION1_Seleccionado(ByVal ID_SITIO_CAPACITACION As Decimal) Handles UcBuscarSITIO_CAPACITACION1.Seleccionado
        RaiseEvent Seleccionado(ID_SITIO_CAPACITACION)
    End Sub

End Class
