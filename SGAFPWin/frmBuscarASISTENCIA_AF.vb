Public Class frmBuscarASISTENCIA_AF

    Public Event Seleccionado(ByVal ID_ASISTENCIA_AF As Decimal) 

    Private Sub UcBuscarASISTENCIA_AF1_Seleccionado(ByVal ID_ASISTENCIA_AF As Decimal) Handles UcBuscarASISTENCIA_AF1.Seleccionado
        RaiseEvent Seleccionado(ID_ASISTENCIA_AF)
    End Sub

End Class
