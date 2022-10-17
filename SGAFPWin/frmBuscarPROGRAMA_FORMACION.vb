Public Class frmBuscarPROGRAMA_FORMACION

    Public Event Seleccionado(ByVal ID_PROGRAMA_FORMACION As Decimal) 

    Private Sub UcBuscarPROGRAMA_FORMACION1_Seleccionado(ByVal ID_PROGRAMA_FORMACION As Decimal) Handles UcBuscarPROGRAMA_FORMACION1.Seleccionado
        RaiseEvent Seleccionado(ID_PROGRAMA_FORMACION)
    End Sub

End Class
