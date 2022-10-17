Public Class frmBuscarTIPO_CONTRATACION

    Public Event Seleccionado(ByVal ID_TIPO_CONTRA As Decimal) 

    Private Sub UcBuscarTIPO_CONTRATACION1_Seleccionado(ByVal ID_TIPO_CONTRA As Decimal) Handles UcBuscarTIPO_CONTRATACION1.Seleccionado
        RaiseEvent Seleccionado(ID_TIPO_CONTRA)
    End Sub

End Class
