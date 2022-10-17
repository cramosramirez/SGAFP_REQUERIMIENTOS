Public Class frmBuscarAREA_FORMACION

    Public Event Seleccionado(ByVal ID_AREA_FORMACION As Decimal) 

    Private Sub UcBuscarAREA_FORMACION1_Seleccionado(ByVal ID_AREA_FORMACION As Decimal) Handles UcBuscarAREA_FORMACION1.Seleccionado
        RaiseEvent Seleccionado(ID_AREA_FORMACION)
    End Sub

End Class
