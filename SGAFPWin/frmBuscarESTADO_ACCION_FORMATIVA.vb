Public Class frmBuscarESTADO_ACCION_FORMATIVA

    Public Event Seleccionado(ByVal CODIGO_ESTADO_AF As String) 

    Private Sub UcBuscarESTADO_ACCION_FORMATIVA1_Seleccionado(ByVal CODIGO_ESTADO_AF As String) Handles UcBuscarESTADO_ACCION_FORMATIVA1.Seleccionado
        RaiseEvent Seleccionado(CODIGO_ESTADO_AF)
    End Sub

End Class
