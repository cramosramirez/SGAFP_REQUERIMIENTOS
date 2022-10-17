Public Class frmBuscarAREA_SUPERVISION

    Public Event Seleccionado(ByVal ID_AREA_SUPERVISION As Decimal) 

    Private Sub UcBuscarAREA_SUPERVISION1_Seleccionado(ByVal ID_AREA_SUPERVISION As Decimal) Handles UcBuscarAREA_SUPERVISION1.Seleccionado
        RaiseEvent Seleccionado(ID_AREA_SUPERVISION)
    End Sub

End Class
