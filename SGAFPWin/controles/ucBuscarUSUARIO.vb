Imports SGAFP.EL
Public Class ucBuscarUSUARIO

    Public Event Seleccionado(ByVal USUARIO As String) 

    Protected Overrides Sub Buscar()
        Dim listaUSUARIO1 As New listaUSUARIO
        listaUSUARIO1 = CType((New cUSUARIO).ObtenerListaPorBusqueda(New USUARIO, Me.CriteriaList.ToArray()), listaUSUARIO)
        Me.UcListaUSUARIO1.CargarDatosPorLista(listaUSUARIO1)
    End Sub

    Private Sub UcListaUSUARIO1_Seleccionado(ByVal USUARIO As String) Handles UcListaUSUARIO1.Seleccionado
        RaiseEvent Seleccionado(USUARIO)
    End Sub

End Class
