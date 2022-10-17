Imports SGAFP.EL
Public Class ucBuscarAREA_FORMACION

    Public Event Seleccionado(ByVal ID_AREA_FORMACION As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaAREA_FORMACION1 As New listaAREA_FORMACION
        listaAREA_FORMACION1 = CType((New cAREA_FORMACION).ObtenerListaPorBusqueda(New AREA_FORMACION, Me.CriteriaList.ToArray()), listaAREA_FORMACION)
        Me.UcListaAREA_FORMACION1.CargarDatosPorLista(listaAREA_FORMACION1)
    End Sub

    Private Sub UcListaAREA_FORMACION1_Seleccionado(ByVal ID_AREA_FORMACION As Decimal) Handles UcListaAREA_FORMACION1.Seleccionado
        RaiseEvent Seleccionado(ID_AREA_FORMACION)
    End Sub

End Class
