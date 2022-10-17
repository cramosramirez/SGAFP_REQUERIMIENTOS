Public Class frmBuscarPROYECTO_FORMACION

    Public Event Seleccionado(ByVal ID_PROYECTO_FORMACION As Decimal) 

    Private Sub UcBuscarPROYECTO_FORMACION1_Seleccionado(ByVal ID_PROYECTO_FORMACION As Decimal) Handles UcBuscarPROYECTO_FORMACION1.Seleccionado
        RaiseEvent Seleccionado(ID_PROYECTO_FORMACION)
    End Sub

End Class
