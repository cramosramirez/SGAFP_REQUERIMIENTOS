Public Class frmBuscarFACILITADOR_CAPACITADOR

    Public Event Seleccionado(ByVal ID_FACILITADOR As Decimal) 

    Private Sub UcBuscarFACILITADOR_CAPACITADOR1_Seleccionado(ByVal ID_FACILITADOR As Decimal) Handles UcBuscarFACILITADOR_CAPACITADOR1.Seleccionado
        RaiseEvent Seleccionado(ID_FACILITADOR)
    End Sub

End Class
