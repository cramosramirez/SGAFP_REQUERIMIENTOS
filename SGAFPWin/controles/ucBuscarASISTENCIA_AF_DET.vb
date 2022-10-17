Imports SGAFP.EL
Public Class ucBuscarASISTENCIA_AF_DET

    Public Event Seleccionado(ByVal ID_ASISTENCIA_DET As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaASISTENCIA_AF_DET1 As New listaASISTENCIA_AF_DET
        listaASISTENCIA_AF_DET1 = CType((New cASISTENCIA_AF_DET).ObtenerListaPorBusqueda(New ASISTENCIA_AF_DET, Me.CriteriaList.ToArray()), listaASISTENCIA_AF_DET)
        Me.UcListaASISTENCIA_AF_DET1.CargarDatosPorLista(listaASISTENCIA_AF_DET1)
    End Sub

    Private Sub UcListaASISTENCIA_AF_DET1_Seleccionado(ByVal ID_ASISTENCIA_DET As Decimal) Handles UcListaASISTENCIA_AF_DET1.Seleccionado
        RaiseEvent Seleccionado(ID_ASISTENCIA_DET)
    End Sub

End Class
