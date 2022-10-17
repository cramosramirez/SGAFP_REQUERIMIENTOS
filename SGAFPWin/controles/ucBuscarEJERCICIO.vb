Imports SGAFP.EL
Public Class ucBuscarEJERCICIO

    Public Event Seleccionado(ByVal ID_EJERCICIO As String) 

    Protected Overrides Sub Buscar()
        Dim listaEJERCICIO1 As New listaEJERCICIO
        listaEJERCICIO1 = CType((New cEJERCICIO).ObtenerListaPorBusqueda(New EJERCICIO, Me.CriteriaList.ToArray()), listaEJERCICIO)
        Me.UcListaEJERCICIO1.CargarDatosPorLista(listaEJERCICIO1)
    End Sub

    Private Sub UcListaEJERCICIO1_Seleccionado(ByVal ID_EJERCICIO As String) Handles UcListaEJERCICIO1.Seleccionado
        RaiseEvent Seleccionado(ID_EJERCICIO)
    End Sub

End Class
