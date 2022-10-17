Imports SGAFP.EL
Public Class ucBuscarSOLIC_CURSOS_RECIBIDOS

    Public Event Seleccionado(ByVal ID_CURSO_RECIBIDO As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaSOLIC_CURSOS_RECIBIDOS1 As New listaSOLIC_CURSOS_RECIBIDOS
        listaSOLIC_CURSOS_RECIBIDOS1 = CType((New cSOLIC_CURSOS_RECIBIDOS).ObtenerListaPorBusqueda(New SOLIC_CURSOS_RECIBIDOS, Me.CriteriaList.ToArray()), listaSOLIC_CURSOS_RECIBIDOS)
        Me.UcListaSOLIC_CURSOS_RECIBIDOS1.CargarDatosPorLista(listaSOLIC_CURSOS_RECIBIDOS1)
    End Sub

    Private Sub UcListaSOLIC_CURSOS_RECIBIDOS1_Seleccionado(ByVal ID_CURSO_RECIBIDO As Decimal) Handles UcListaSOLIC_CURSOS_RECIBIDOS1.Seleccionado
        RaiseEvent Seleccionado(ID_CURSO_RECIBIDO)
    End Sub

End Class
