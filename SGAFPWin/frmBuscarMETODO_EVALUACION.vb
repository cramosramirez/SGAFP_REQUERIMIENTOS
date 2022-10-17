Public Class frmBuscarMETODO_EVALUACION

    Public Event Seleccionado(ByVal ID_METODO_EVALUACION As Decimal) 

    Private Sub UcBuscarMETODO_EVALUACION1_Seleccionado(ByVal ID_METODO_EVALUACION As Decimal) Handles UcBuscarMETODO_EVALUACION1.Seleccionado
        RaiseEvent Seleccionado(ID_METODO_EVALUACION)
    End Sub

End Class
