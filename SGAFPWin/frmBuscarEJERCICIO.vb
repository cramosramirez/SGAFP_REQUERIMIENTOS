Public Class frmBuscarEJERCICIO

    Public Event Seleccionado(ByVal ID_EJERCICIO As String) 

    Private Sub UcBuscarEJERCICIO1_Seleccionado(ByVal ID_EJERCICIO As String) Handles UcBuscarEJERCICIO1.Seleccionado
        RaiseEvent Seleccionado(ID_EJERCICIO)
    End Sub

End Class
