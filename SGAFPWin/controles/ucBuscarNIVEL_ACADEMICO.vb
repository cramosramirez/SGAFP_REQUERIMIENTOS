Imports SGAFP.EL
Public Class ucBuscarNIVEL_ACADEMICO

    Public Event Seleccionado(ByVal NIVEL_ACADEMICO As String) 

    Protected Overrides Sub Buscar()
        Dim listaNIVEL_ACADEMICO1 As New listaNIVEL_ACADEMICO
        listaNIVEL_ACADEMICO1 = CType((New cNIVEL_ACADEMICO).ObtenerListaPorBusqueda(New NIVEL_ACADEMICO, Me.CriteriaList.ToArray()), listaNIVEL_ACADEMICO)
        Me.UcListaNIVEL_ACADEMICO1.CargarDatosPorLista(listaNIVEL_ACADEMICO1)
    End Sub

    Private Sub UcListaNIVEL_ACADEMICO1_Seleccionado(ByVal NIVEL_ACADEMICO As String) Handles UcListaNIVEL_ACADEMICO1.Seleccionado
        RaiseEvent Seleccionado(NIVEL_ACADEMICO)
    End Sub

End Class
