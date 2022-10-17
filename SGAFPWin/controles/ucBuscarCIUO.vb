Imports SGAFP.EL
Public Class ucBuscarCIUO

    Public Event Seleccionado(ByVal CIUO As String) 

    Protected Overrides Sub Buscar()
        Dim listaCIUO1 As New listaCIUO
        listaCIUO1 = CType((New cCIUO).ObtenerListaPorBusqueda(New CIUO, Me.CriteriaList.ToArray()), listaCIUO)
        Me.UcListaCIUO1.CargarDatosPorLista(listaCIUO1)
    End Sub

    Private Sub UcListaCIUO1_Seleccionado(ByVal CIUO As String) Handles UcListaCIUO1.Seleccionado
        RaiseEvent Seleccionado(CIUO)
    End Sub

End Class
