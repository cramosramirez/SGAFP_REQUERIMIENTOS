Public Class frmMantSIPU_GENERACION

    Private Sub frmMantSIPU_GENERACION_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " SIPU_GENERACION"
        Me.miMantenimiento = Me.UcMantSIPU_GENERACION1
        Me.UcMantSIPU_GENERACION1.CargarDatos()
    End Sub

End Class
