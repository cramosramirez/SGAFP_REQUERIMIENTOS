Imports SGAFP.EL
Public Class ucBuscarASISTENCIA_AF

    Public Event Seleccionado(ByVal ID_ASISTENCIA_AF As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaASISTENCIA_AF1 As New listaASISTENCIA_AF
        listaASISTENCIA_AF1 = CType((New cASISTENCIA_AF).ObtenerListaPorBusqueda(New ASISTENCIA_AF, Me.CriteriaList.ToArray()), listaASISTENCIA_AF)
        Me.UcListaASISTENCIA_AF1.CargarDatosPorLista(listaASISTENCIA_AF1)
    End Sub

    Private Sub UcListaASISTENCIA_AF1_Seleccionado(ByVal ID_ASISTENCIA_AF As Decimal) Handles UcListaASISTENCIA_AF1.Seleccionado
        RaiseEvent Seleccionado(ID_ASISTENCIA_AF)
    End Sub

End Class
