Public Class frmBuscarGRUPO_SOLICITUD

    Public Event Seleccionado(ByVal ID_GRUPO_SOLICITUD As Decimal) 

    Private Sub UcBuscarGRUPO_SOLICITUD1_Seleccionado(ByVal ID_GRUPO_SOLICITUD As Decimal) Handles UcBuscarGRUPO_SOLICITUD1.Seleccionado
        RaiseEvent Seleccionado(ID_GRUPO_SOLICITUD)
    End Sub

End Class
