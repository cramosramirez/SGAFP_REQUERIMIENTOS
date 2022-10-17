Public Class frmMantSIPU_CAPACITACIONES

    Private Sub frmMantSIPU_CAPACITACIONES_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " SIPU_CAPACITACIONES"
        Me.miMantenimiento = Me.UcMantSIPU_CAPACITACIONES1
        Me.UcMantSIPU_CAPACITACIONES1.CargarDatos()
    End Sub

End Class
