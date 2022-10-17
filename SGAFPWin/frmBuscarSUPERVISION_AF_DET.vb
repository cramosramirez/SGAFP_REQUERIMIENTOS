Public Class frmBuscarSUPERVISION_AF_DET

    Public Event Seleccionado(ByVal ID_SUPERVISION_DET As Decimal) 

    Private Sub UcBuscarSUPERVISION_AF_DET1_Seleccionado(ByVal ID_SUPERVISION_DET As Decimal) Handles UcBuscarSUPERVISION_AF_DET1.Seleccionado
        RaiseEvent Seleccionado(ID_SUPERVISION_DET)
    End Sub

End Class
