Public Class frmBuscarACCION_FORMATIVA

    Public Event Seleccionado(ByVal ID_ACCION_FORMATIVA As Decimal) 

    Private Sub UcBuscarACCION_FORMATIVA1_Seleccionado(ByVal ID_ACCION_FORMATIVA As Decimal) Handles UcBuscarACCION_FORMATIVA1.Seleccionado
        RaiseEvent Seleccionado(ID_ACCION_FORMATIVA)
    End Sub

End Class
