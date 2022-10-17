Public Class frmBuscarSIPU_GENERACION

    Public Event Seleccionado(ByVal ID_GENERACION As Decimal) 

    Private Sub UcBuscarSIPU_GENERACION1_Seleccionado(ByVal ID_GENERACION As Decimal) Handles UcBuscarSIPU_GENERACION1.Seleccionado
        RaiseEvent Seleccionado(ID_GENERACION)
    End Sub

End Class
