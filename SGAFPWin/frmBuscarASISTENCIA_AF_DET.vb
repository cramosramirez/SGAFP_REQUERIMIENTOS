Public Class frmBuscarASISTENCIA_AF_DET

    Public Event Seleccionado(ByVal ID_ASISTENCIA_DET As Decimal) 

    Private Sub UcBuscarASISTENCIA_AF_DET1_Seleccionado(ByVal ID_ASISTENCIA_DET As Decimal) Handles UcBuscarASISTENCIA_AF_DET1.Seleccionado
        RaiseEvent Seleccionado(ID_ASISTENCIA_DET)
    End Sub

End Class
