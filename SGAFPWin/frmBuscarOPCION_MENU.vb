Public Class frmBuscarOPCION_MENU

    Public Event Seleccionado(ByVal ID_OPCION_MENU As Decimal) 

    Private Sub UcBuscarOPCION_MENU1_Seleccionado(ByVal ID_OPCION_MENU As Decimal) Handles UcBuscarOPCION_MENU1.Seleccionado
        RaiseEvent Seleccionado(ID_OPCION_MENU)
    End Sub

End Class
