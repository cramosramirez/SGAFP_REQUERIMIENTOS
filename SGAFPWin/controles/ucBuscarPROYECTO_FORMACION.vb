Imports SGAFP.EL
Public Class ucBuscarPROYECTO_FORMACION

    Public Event Seleccionado(ByVal ID_PROYECTO_FORMACION As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaPROYECTO_FORMACION1 As New listaPROYECTO_FORMACION
        listaPROYECTO_FORMACION1 = CType((New cPROYECTO_FORMACION).ObtenerListaPorBusqueda(New PROYECTO_FORMACION, Me.CriteriaList.ToArray()), listaPROYECTO_FORMACION)
        Me.UcListaPROYECTO_FORMACION1.CargarDatosPorLista(listaPROYECTO_FORMACION1)
    End Sub

    Private Sub UcListaPROYECTO_FORMACION1_Seleccionado(ByVal ID_PROYECTO_FORMACION As Decimal) Handles UcListaPROYECTO_FORMACION1.Seleccionado
        RaiseEvent Seleccionado(ID_PROYECTO_FORMACION)
    End Sub

End Class
