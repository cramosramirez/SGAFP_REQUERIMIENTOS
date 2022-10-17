Imports SGAFP.EL
Public Class ucBuscarCONTROL_DOCUMENTOS

    Public Event Seleccionado(ByVal NUMERO_DOCUMENTO As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaCONTROL_DOCUMENTOS1 As New listaCONTROL_DOCUMENTOS
        listaCONTROL_DOCUMENTOS1 = CType((New cCONTROL_DOCUMENTOS).ObtenerListaPorBusqueda(New CONTROL_DOCUMENTOS, Me.CriteriaList.ToArray()), listaCONTROL_DOCUMENTOS)
        Me.UcListaCONTROL_DOCUMENTOS1.CargarDatosPorLista(listaCONTROL_DOCUMENTOS1)
    End Sub

    Private Sub UcListaCONTROL_DOCUMENTOS1_Seleccionado(ByVal NUMERO_DOCUMENTO As Decimal) Handles UcListaCONTROL_DOCUMENTOS1.Seleccionado
        RaiseEvent Seleccionado(NUMERO_DOCUMENTO)
    End Sub

End Class
