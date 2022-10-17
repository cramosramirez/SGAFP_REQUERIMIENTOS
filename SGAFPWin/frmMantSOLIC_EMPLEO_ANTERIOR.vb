Public Class frmMantSOLIC_EMPLEO_ANTERIOR

    Private Sub frmMantSOLIC_EMPLEO_ANTERIOR_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " SOLIC_EMPLEO_ANTERIOR"
        Me.miMantenimiento = Me.UcMantSOLIC_EMPLEO_ANTERIOR1
        Me.UcMantSOLIC_EMPLEO_ANTERIOR1.CargarDatos()
    End Sub

End Class
