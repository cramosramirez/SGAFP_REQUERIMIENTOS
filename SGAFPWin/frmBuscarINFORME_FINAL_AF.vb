Public Class frmBuscarINFORME_FINAL_AF

    Public Event Seleccionado(ByVal ID_INFORME_FINAL As Decimal) 

    Private Sub UcBuscarINFORME_FINAL_AF1_Seleccionado(ByVal ID_INFORME_FINAL As Decimal) Handles UcBuscarINFORME_FINAL_AF1.Seleccionado
        RaiseEvent Seleccionado(ID_INFORME_FINAL)
    End Sub

End Class
