Public Class frmBuscarUNIDAD_ORGANIZATIVA

    Public Event Seleccionado(ByVal ID_UNIDAD_ORGANIZATIVA As Decimal) 

    Private Sub UcBuscarUNIDAD_ORGANIZATIVA1_Seleccionado(ByVal ID_UNIDAD_ORGANIZATIVA As Decimal) Handles UcBuscarUNIDAD_ORGANIZATIVA1.Seleccionado
        RaiseEvent Seleccionado(ID_UNIDAD_ORGANIZATIVA)
    End Sub

End Class
