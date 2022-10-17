Imports SGAFP.EL
Public Class ucBuscarTERMINO_REFERENCIA_AF

    Public Event Seleccionado(ByVal ID_ACCION_FORMATIVA As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaTERMINO_REFERENCIA_AF1 As New listaTERMINO_REFERENCIA_AF
        listaTERMINO_REFERENCIA_AF1 = CType((New cTERMINO_REFERENCIA_AF).ObtenerListaPorBusqueda(New TERMINO_REFERENCIA_AF, Me.CriteriaList.ToArray()), listaTERMINO_REFERENCIA_AF)
        Me.UcListaTERMINO_REFERENCIA_AF1.CargarDatosPorLista(listaTERMINO_REFERENCIA_AF1)
    End Sub

    Private Sub UcListaTERMINO_REFERENCIA_AF1_Seleccionado(ByVal ID_ACCION_FORMATIVA As Decimal) Handles UcListaTERMINO_REFERENCIA_AF1.Seleccionado
        RaiseEvent Seleccionado(ID_ACCION_FORMATIVA)
    End Sub

End Class
