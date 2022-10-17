Imports SGAFP.EL
Public Class ucBuscarPROGRAMA_FORMACION

    Public Event Seleccionado(ByVal ID_PROGRAMA_FORMACION As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaPROGRAMA_FORMACION1 As New listaPROGRAMA_FORMACION
        listaPROGRAMA_FORMACION1 = CType((New cPROGRAMA_FORMACION).ObtenerListaPorBusqueda(New PROGRAMA_FORMACION, Me.CriteriaList.ToArray()), listaPROGRAMA_FORMACION)
        Me.UcListaPROGRAMA_FORMACION1.CargarDatosPorLista(listaPROGRAMA_FORMACION1)
    End Sub

    Private Sub UcListaPROGRAMA_FORMACION1_Seleccionado(ByVal ID_PROGRAMA_FORMACION As Decimal) Handles UcListaPROGRAMA_FORMACION1.Seleccionado
        RaiseEvent Seleccionado(ID_PROGRAMA_FORMACION)
    End Sub

End Class
