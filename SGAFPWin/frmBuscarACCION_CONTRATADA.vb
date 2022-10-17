Public Class frmBuscarACCION_CONTRATADA

    Public Event Seleccionado(ByVal ID_ACCION_CONTRATADA As Decimal) 

    Private Sub UcBuscarACCION_CONTRATADA1_Seleccionado(ByVal ID_ACCION_CONTRATADA As Decimal) Handles UcBuscarACCION_CONTRATADA1.Seleccionado
        RaiseEvent Seleccionado(ID_ACCION_CONTRATADA)
    End Sub

End Class
