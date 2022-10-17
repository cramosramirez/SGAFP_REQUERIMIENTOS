Public Class frmMantMETODO_EVALUACION

    Private Sub frmMantMETODO_EVALUACION_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " METODO_EVALUACION"
        Me.miMantenimiento = Me.UcMantMETODO_EVALUACION1
        Me.UcMantMETODO_EVALUACION1.CargarDatos()
    End Sub

End Class
