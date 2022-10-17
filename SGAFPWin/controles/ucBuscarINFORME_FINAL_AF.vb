Imports SGAFP.EL
Public Class ucBuscarINFORME_FINAL_AF

    Public Event Seleccionado(ByVal ID_INFORME_FINAL As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaINFORME_FINAL_AF1 As New listaINFORME_FINAL_AF
        listaINFORME_FINAL_AF1 = CType((New cINFORME_FINAL_AF).ObtenerListaPorBusqueda(New INFORME_FINAL_AF, Me.CriteriaList.ToArray()), listaINFORME_FINAL_AF)
        Me.UcListaINFORME_FINAL_AF1.CargarDatosPorLista(listaINFORME_FINAL_AF1)
    End Sub

    Private Sub UcListaINFORME_FINAL_AF1_Seleccionado(ByVal ID_INFORME_FINAL As Decimal) Handles UcListaINFORME_FINAL_AF1.Seleccionado
        RaiseEvent Seleccionado(ID_INFORME_FINAL)
    End Sub

End Class
