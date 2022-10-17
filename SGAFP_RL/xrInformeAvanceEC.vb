Public Class xrInformeAvanceEC

    Public Sub CargarDatos(ByVal ID_GRUPO_SELEC As Decimal)
        Me.DS_DL1.Clear()
        Me.InformE_AVANCE_ECTableAdapter1.FillPorGrupo(Me.DS_DL1.INFORME_AVANCE_EC, ID_GRUPO_SELEC)

    End Sub

    Public Sub CargarInforme(ByVal ID_INFORME_FINAL As Decimal)
        Me.DS_DL1.Clear()
        Me.InformE_AVANCE_ECTableAdapter1.FillPorInforme(Me.DS_DL1.INFORME_AVANCE_EC, ID_INFORME_FINAL)
    End Sub
End Class