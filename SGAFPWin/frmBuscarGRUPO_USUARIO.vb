Public Class frmBuscarGRUPO_USUARIO

    Public Event Seleccionado(ByVal ID_GRUPO_USUARIO As Decimal) 

    Private Sub UcBuscarGRUPO_USUARIO1_Seleccionado(ByVal ID_GRUPO_USUARIO As Decimal) Handles UcBuscarGRUPO_USUARIO1.Seleccionado
        RaiseEvent Seleccionado(ID_GRUPO_USUARIO)
    End Sub

End Class
