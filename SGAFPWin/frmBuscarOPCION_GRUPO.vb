Public Class frmBuscarOPCION_GRUPO

    Public Event Seleccionado(ByVal ID_OPCION_GRUPO As Decimal) 

    Private Sub UcBuscarOPCION_GRUPO1_Seleccionado(ByVal ID_OPCION_GRUPO As Decimal) Handles UcBuscarOPCION_GRUPO1.Seleccionado
        RaiseEvent Seleccionado(ID_OPCION_GRUPO)
    End Sub

End Class
