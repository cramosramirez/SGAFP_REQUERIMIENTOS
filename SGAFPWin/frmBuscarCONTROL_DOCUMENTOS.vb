Public Class frmBuscarCONTROL_DOCUMENTOS

    Public Event Seleccionado(ByVal NUMERO_DOCUMENTO As Decimal) 

    Private Sub UcBuscarCONTROL_DOCUMENTOS1_Seleccionado(ByVal NUMERO_DOCUMENTO As Decimal) Handles UcBuscarCONTROL_DOCUMENTOS1.Seleccionado
        RaiseEvent Seleccionado(NUMERO_DOCUMENTO)
    End Sub

End Class
