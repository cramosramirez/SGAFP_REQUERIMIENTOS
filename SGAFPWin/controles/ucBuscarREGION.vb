Imports SGAFP.EL
Public Class ucBuscarREGION

    Public Event Seleccionado(ByVal CODIGO_REGION As String) 

    Protected Overrides Sub Buscar()
        Dim listaREGION1 As New listaREGION
        listaREGION1 = CType((New cREGION).ObtenerListaPorBusqueda(New REGION, Me.CriteriaList.ToArray()), listaREGION)
        Me.UcListaREGION1.CargarDatosPorLista(listaREGION1)
    End Sub

    Private Sub UcListaREGION1_Seleccionado(ByVal CODIGO_REGION As String) Handles UcListaREGION1.Seleccionado
        RaiseEvent Seleccionado(CODIGO_REGION)
    End Sub

End Class
