Imports SGAFP.EL
Public Class ucBuscarSOLIC_EMPLEO_ANTERIOR

    Public Event Seleccionado(ByVal ID_EMPLEO_ANT As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaSOLIC_EMPLEO_ANTERIOR1 As New listaSOLIC_EMPLEO_ANTERIOR
        listaSOLIC_EMPLEO_ANTERIOR1 = CType((New cSOLIC_EMPLEO_ANTERIOR).ObtenerListaPorBusqueda(New SOLIC_EMPLEO_ANTERIOR, Me.CriteriaList.ToArray()), listaSOLIC_EMPLEO_ANTERIOR)
        Me.UcListaSOLIC_EMPLEO_ANTERIOR1.CargarDatosPorLista(listaSOLIC_EMPLEO_ANTERIOR1)
    End Sub

    Private Sub UcListaSOLIC_EMPLEO_ANTERIOR1_Seleccionado(ByVal ID_EMPLEO_ANT As Decimal) Handles UcListaSOLIC_EMPLEO_ANTERIOR1.Seleccionado
        RaiseEvent Seleccionado(ID_EMPLEO_ANT)
    End Sub

End Class
