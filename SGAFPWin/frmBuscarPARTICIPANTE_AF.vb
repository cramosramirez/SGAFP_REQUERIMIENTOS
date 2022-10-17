Public Class frmBuscarPARTICIPANTE_AF

    Public Event Seleccionado(ByVal ID_PARTICIPANTE As Decimal, ByVal ID_ACCION_FORMATIVA As Decimal) 

    Private Sub UcBuscarPARTICIPANTE_AF1_Seleccionado(ByVal ID_PARTICIPANTE As Decimal, ByVal ID_ACCION_FORMATIVA As Decimal) Handles UcBuscarPARTICIPANTE_AF1.Seleccionado
        RaiseEvent Seleccionado(ID_PARTICIPANTE, ID_ACCION_FORMATIVA)
    End Sub

End Class
