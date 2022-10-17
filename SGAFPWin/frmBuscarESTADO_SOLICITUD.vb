Public Class frmBuscarESTADO_SOLICITUD

    Public Event Seleccionado(ByVal ID_ESTADO_SOLICITUD As Decimal) 

    Private Sub UcBuscarESTADO_SOLICITUD1_Seleccionado(ByVal ID_ESTADO_SOLICITUD As Decimal) Handles UcBuscarESTADO_SOLICITUD1.Seleccionado
        RaiseEvent Seleccionado(ID_ESTADO_SOLICITUD)
    End Sub

End Class
