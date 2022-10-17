Public Class frmMantSIPU_DETALLECAPACITACIONES

    Private Sub frmMantSIPU_DETALLECAPACITACIONES_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " SIPU_DETALLECAPACITACIONES"
        Me.miMantenimiento = Me.UcMantSIPU_DETALLECAPACITACIONES1
        Me.UcMantSIPU_DETALLECAPACITACIONES1.CargarDatos()
    End Sub

End Class
