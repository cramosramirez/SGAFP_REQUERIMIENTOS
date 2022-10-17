Public Class frmBuscarGRUPO_ACCION_CONTRATADA

    Public Event Seleccionado(ByVal ID_GRUPO_ACCION As Decimal) 

    Private Sub UcBuscarGRUPO_ACCION_CONTRATADA1_Seleccionado(ByVal ID_GRUPO_ACCION As Decimal) Handles UcBuscarGRUPO_ACCION_CONTRATADA1.Seleccionado
        RaiseEvent Seleccionado(ID_GRUPO_ACCION)
    End Sub

End Class
