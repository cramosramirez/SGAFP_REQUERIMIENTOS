Public Class frmBuscarMODALIDAD_DE_FORMACION

    Public Event Seleccionado(ByVal ID_MODALIDAD_FORMACION As Decimal) 

    Private Sub UcBuscarMODALIDAD_DE_FORMACION1_Seleccionado(ByVal ID_MODALIDAD_FORMACION As Decimal) Handles UcBuscarMODALIDAD_DE_FORMACION1.Seleccionado
        RaiseEvent Seleccionado(ID_MODALIDAD_FORMACION)
    End Sub

End Class
