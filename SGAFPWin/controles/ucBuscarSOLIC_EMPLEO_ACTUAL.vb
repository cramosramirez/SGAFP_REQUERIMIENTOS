Imports SGAFP.EL
Public Class ucBuscarSOLIC_EMPLEO_ACTUAL

    Public Event Seleccionado(ByVal ID_EMPLEO_ACTUAL As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaSOLIC_EMPLEO_ACTUAL1 As New listaSOLIC_EMPLEO_ACTUAL
        listaSOLIC_EMPLEO_ACTUAL1 = CType((New cSOLIC_EMPLEO_ACTUAL).ObtenerListaPorBusqueda(New SOLIC_EMPLEO_ACTUAL, Me.CriteriaList.ToArray()), listaSOLIC_EMPLEO_ACTUAL)
        Me.UcListaSOLIC_EMPLEO_ACTUAL1.CargarDatosPorLista(listaSOLIC_EMPLEO_ACTUAL1)
    End Sub

    Private Sub UcListaSOLIC_EMPLEO_ACTUAL1_Seleccionado(ByVal ID_EMPLEO_ACTUAL As Decimal) Handles UcListaSOLIC_EMPLEO_ACTUAL1.Seleccionado
        RaiseEvent Seleccionado(ID_EMPLEO_ACTUAL)
    End Sub

End Class
