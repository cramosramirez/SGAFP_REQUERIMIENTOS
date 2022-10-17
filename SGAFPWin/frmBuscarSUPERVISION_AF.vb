Public Class frmBuscarSUPERVISION_AF

    Public Event Seleccionado(ByVal ID_SUPERVISION_AF As Decimal) 

    Private Sub UcBuscarSUPERVISION_AF1_Seleccionado(ByVal ID_SUPERVISION_AF As Decimal) Handles UcBuscarSUPERVISION_AF1.Seleccionado
        RaiseEvent Seleccionado(ID_SUPERVISION_AF)
    End Sub

End Class
