Public Class frmBuscarTIPO_SOLICITUD

    Public Event Seleccionado(ByVal ID_TIPO_SOLICITUD As Decimal) 

    Private Sub UcBuscarTIPO_SOLICITUD1_Seleccionado(ByVal ID_TIPO_SOLICITUD As Decimal) Handles UcBuscarTIPO_SOLICITUD1.Seleccionado
        RaiseEvent Seleccionado(ID_TIPO_SOLICITUD)
    End Sub

End Class
