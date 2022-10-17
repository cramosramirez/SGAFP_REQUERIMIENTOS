Imports SGAFP.EL
Public Class ucBuscarCIUU

    Public Event Seleccionado(ByVal CIUU As String) 

    Protected Overrides Sub Buscar()
        Dim listaCIUU1 As New listaCIUU
        listaCIUU1 = CType((New cCIUU).ObtenerListaPorBusqueda(New CIUU, Me.CriteriaList.ToArray()), listaCIUU)
        Me.UcListaCIUU1.CargarDatosPorLista(listaCIUU1)
    End Sub

    Private Sub UcListaCIUU1_Seleccionado(ByVal CIUU As String) Handles UcListaCIUU1.Seleccionado
        RaiseEvent Seleccionado(CIUU)
    End Sub

End Class
