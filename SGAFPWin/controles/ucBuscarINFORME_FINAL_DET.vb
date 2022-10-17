Imports SGAFP.EL
Public Class ucBuscarINFORME_FINAL_DET

    Public Event Seleccionado(ByVal ID_INFORME_FINAL_DET As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaINFORME_FINAL_DET1 As New listaINFORME_FINAL_DET
        listaINFORME_FINAL_DET1 = CType((New cINFORME_FINAL_DET).ObtenerListaPorBusqueda(New INFORME_FINAL_DET, Me.CriteriaList.ToArray()), listaINFORME_FINAL_DET)
        Me.UcListaINFORME_FINAL_DET1.CargarDatosPorLista(listaINFORME_FINAL_DET1)
    End Sub

    Private Sub UcListaINFORME_FINAL_DET1_Seleccionado(ByVal ID_INFORME_FINAL_DET As Decimal) Handles UcListaINFORME_FINAL_DET1.Seleccionado
        RaiseEvent Seleccionado(ID_INFORME_FINAL_DET)
    End Sub

End Class
