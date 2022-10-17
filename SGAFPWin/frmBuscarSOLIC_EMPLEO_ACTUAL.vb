Public Class frmBuscarSOLIC_EMPLEO_ACTUAL

    Public Event Seleccionado(ByVal ID_EMPLEO_ACTUAL As Decimal) 

    Private Sub UcBuscarSOLIC_EMPLEO_ACTUAL1_Seleccionado(ByVal ID_EMPLEO_ACTUAL As Decimal) Handles UcBuscarSOLIC_EMPLEO_ACTUAL1.Seleccionado
        RaiseEvent Seleccionado(ID_EMPLEO_ACTUAL)
    End Sub

End Class
