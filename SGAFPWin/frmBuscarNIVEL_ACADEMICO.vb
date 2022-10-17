Public Class frmBuscarNIVEL_ACADEMICO

    Public Event Seleccionado(ByVal NIVEL_ACADEMICO As String) 

    Private Sub UcBuscarNIVEL_ACADEMICO1_Seleccionado(ByVal NIVEL_ACADEMICO As String) Handles UcBuscarNIVEL_ACADEMICO1.Seleccionado
        RaiseEvent Seleccionado(NIVEL_ACADEMICO)
    End Sub

End Class
