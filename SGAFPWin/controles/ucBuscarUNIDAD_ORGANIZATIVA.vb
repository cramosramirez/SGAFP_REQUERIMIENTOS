Imports SGAFP.EL
Public Class ucBuscarUNIDAD_ORGANIZATIVA

    Public Event Seleccionado(ByVal ID_UNIDAD_ORGANIZATIVA As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaUNIDAD_ORGANIZATIVA1 As New listaUNIDAD_ORGANIZATIVA
        listaUNIDAD_ORGANIZATIVA1 = CType((New cUNIDAD_ORGANIZATIVA).ObtenerListaPorBusqueda(New UNIDAD_ORGANIZATIVA, Me.CriteriaList.ToArray()), listaUNIDAD_ORGANIZATIVA)
        Me.UcListaUNIDAD_ORGANIZATIVA1.CargarDatosPorLista(listaUNIDAD_ORGANIZATIVA1)
    End Sub

    Private Sub UcListaUNIDAD_ORGANIZATIVA1_Seleccionado(ByVal ID_UNIDAD_ORGANIZATIVA As Decimal) Handles UcListaUNIDAD_ORGANIZATIVA1.Seleccionado
        RaiseEvent Seleccionado(ID_UNIDAD_ORGANIZATIVA)
    End Sub

End Class
