Public Class frmBuscarSOLIC_EMPLEO_ANTERIOR

    Public Event Seleccionado(ByVal ID_EMPLEO_ANT As Decimal) 

    Private Sub UcBuscarSOLIC_EMPLEO_ANTERIOR1_Seleccionado(ByVal ID_EMPLEO_ANT As Decimal) Handles UcBuscarSOLIC_EMPLEO_ANTERIOR1.Seleccionado
        RaiseEvent Seleccionado(ID_EMPLEO_ANT)
    End Sub

End Class
