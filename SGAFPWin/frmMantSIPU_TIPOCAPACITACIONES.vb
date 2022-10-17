Public Class frmMantSIPU_TIPOCAPACITACIONES

    Private Sub frmMantSIPU_TIPOCAPACITACIONES_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " SIPU_TIPOCAPACITACIONES"
        Me.miMantenimiento = Me.UcMantSIPU_TIPOCAPACITACIONES1
        Me.UcMantSIPU_TIPOCAPACITACIONES1.CargarDatos()
    End Sub

End Class
