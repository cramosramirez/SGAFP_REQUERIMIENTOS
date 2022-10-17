Imports SGAFP.EL
Public Class ucBuscarFACILITADOR_CAPACITADOR

    Public Event Seleccionado(ByVal ID_FACILITADOR As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaFACILITADOR_CAPACITADOR1 As New listaFACILITADOR_CAPACITADOR
        listaFACILITADOR_CAPACITADOR1 = CType((New cFACILITADOR_CAPACITADOR).ObtenerListaPorBusqueda(New FACILITADOR_CAPACITADOR, Me.CriteriaList.ToArray()), listaFACILITADOR_CAPACITADOR)
        Me.UcListaFACILITADOR_CAPACITADOR1.CargarDatosPorLista(listaFACILITADOR_CAPACITADOR1)
    End Sub

    Private Sub UcListaFACILITADOR_CAPACITADOR1_Seleccionado(ByVal ID_FACILITADOR As Decimal) Handles UcListaFACILITADOR_CAPACITADOR1.Seleccionado
        RaiseEvent Seleccionado(ID_FACILITADOR)
    End Sub

End Class
