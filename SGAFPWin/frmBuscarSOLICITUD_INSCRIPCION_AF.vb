Public Class frmBuscarSOLICITUD_INSCRIPCION_AF

    Public Event Seleccionado(ByVal ID_SOLICITUD As Decimal) 

    Private Sub UcBuscarSOLICITUD_INSCRIPCION_AF1_Seleccionado(ByVal ID_SOLICITUD As Decimal) Handles UcBuscarSOLICITUD_INSCRIPCION_AF1.Seleccionado
        RaiseEvent Seleccionado(ID_SOLICITUD)
    End Sub

End Class
