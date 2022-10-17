Public Class frmBuscarACCION_FORMATIVA_DETALLE

    Public Event Seleccionado(ByVal ID_ACCION_FORMATIVA As Decimal) 

    Private Sub UcBuscarACCION_FORMATIVA_DETALLE1_Seleccionado(ByVal ID_ACCION_FORMATIVA As Decimal) Handles UcBuscarACCION_FORMATIVA_DETALLE1.Seleccionado
        RaiseEvent Seleccionado(ID_ACCION_FORMATIVA)
    End Sub

End Class
