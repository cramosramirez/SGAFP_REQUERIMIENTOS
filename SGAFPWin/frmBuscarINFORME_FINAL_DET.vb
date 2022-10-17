Public Class frmBuscarINFORME_FINAL_DET

    Public Event Seleccionado(ByVal ID_INFORME_FINAL_DET As Decimal) 

    Private Sub UcBuscarINFORME_FINAL_DET1_Seleccionado(ByVal ID_INFORME_FINAL_DET As Decimal) Handles UcBuscarINFORME_FINAL_DET1.Seleccionado
        RaiseEvent Seleccionado(ID_INFORME_FINAL_DET)
    End Sub

End Class
