Public Class frmBuscarTIPO_PERSONA

    Public Event Seleccionado(ByVal ID_TIPO_PERSONA As Decimal) 

    Private Sub UcBuscarTIPO_PERSONA1_Seleccionado(ByVal ID_TIPO_PERSONA As Decimal) Handles UcBuscarTIPO_PERSONA1.Seleccionado
        RaiseEvent Seleccionado(ID_TIPO_PERSONA)
    End Sub

End Class
