Imports SGAFP.EL
Public Class ucBuscarSOLICITUD_INSCRIPCION_AF

    Public Event Seleccionado(ByVal ID_SOLICITUD As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaSOLICITUD_INSCRIPCION_AF1 As New listaSOLICITUD_INSCRIPCION_AF
        listaSOLICITUD_INSCRIPCION_AF1 = CType((New cSOLICITUD_INSCRIPCION_AF).ObtenerListaPorBusqueda(New SOLICITUD_INSCRIPCION_AF, Me.CriteriaList.ToArray()), listaSOLICITUD_INSCRIPCION_AF)
        Me.UcListaSOLICITUD_INSCRIPCION_AF1.CargarDatosPorLista(listaSOLICITUD_INSCRIPCION_AF1)
    End Sub

    Private Sub UcListaSOLICITUD_INSCRIPCION_AF1_Seleccionado(ByVal ID_SOLICITUD As Decimal) Handles UcListaSOLICITUD_INSCRIPCION_AF1.Seleccionado
        RaiseEvent Seleccionado(ID_SOLICITUD)
    End Sub

End Class
