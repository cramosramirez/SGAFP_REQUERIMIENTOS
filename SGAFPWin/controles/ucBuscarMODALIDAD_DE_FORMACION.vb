Imports SGAFP.EL
Public Class ucBuscarMODALIDAD_DE_FORMACION

    Public Event Seleccionado(ByVal ID_MODALIDAD_FORMACION As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaMODALIDAD_DE_FORMACION1 As New listaMODALIDAD_DE_FORMACION
        listaMODALIDAD_DE_FORMACION1 = CType((New cMODALIDAD_DE_FORMACION).ObtenerListaPorBusqueda(New MODALIDAD_DE_FORMACION, Me.CriteriaList.ToArray()), listaMODALIDAD_DE_FORMACION)
        Me.UcListaMODALIDAD_DE_FORMACION1.CargarDatosPorLista(listaMODALIDAD_DE_FORMACION1)
    End Sub

    Private Sub UcListaMODALIDAD_DE_FORMACION1_Seleccionado(ByVal ID_MODALIDAD_FORMACION As Decimal) Handles UcListaMODALIDAD_DE_FORMACION1.Seleccionado
        RaiseEvent Seleccionado(ID_MODALIDAD_FORMACION)
    End Sub

End Class
