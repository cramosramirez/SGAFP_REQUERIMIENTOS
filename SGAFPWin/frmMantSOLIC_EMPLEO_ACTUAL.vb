Public Class frmMantSOLIC_EMPLEO_ACTUAL

    Private Sub frmMantSOLIC_EMPLEO_ACTUAL_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " SOLIC_EMPLEO_ACTUAL"
        Me.miMantenimiento = Me.UcMantSOLIC_EMPLEO_ACTUAL1
        Me.UcMantSOLIC_EMPLEO_ACTUAL1.CargarDatos()
    End Sub

End Class
