Public Class frmBuscarHALLAZGO_SUPERVISION

    Public Event Seleccionado(ByVal ID_HALLAZGO_SUPERVISION As Decimal) 

    Private Sub UcBuscarHALLAZGO_SUPERVISION1_Seleccionado(ByVal ID_HALLAZGO_SUPERVISION As Decimal) Handles UcBuscarHALLAZGO_SUPERVISION1.Seleccionado
        RaiseEvent Seleccionado(ID_HALLAZGO_SUPERVISION)
    End Sub

End Class
