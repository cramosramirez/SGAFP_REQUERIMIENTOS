Public Class frmMantSOLIC_CURSOS_RECIBIDOS

    Private Sub frmMantSOLIC_CURSOS_RECIBIDOS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " SOLIC_CURSOS_RECIBIDOS"
        Me.miMantenimiento = Me.UcMantSOLIC_CURSOS_RECIBIDOS1
        Me.UcMantSOLIC_CURSOS_RECIBIDOS1.CargarDatos()
    End Sub

End Class
