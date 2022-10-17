Public Class frmMantUSUARIO

    Private Sub frmMantUSUARIO_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " USUARIO"
        Me.miMantenimiento = Me.UcMantUSUARIO1
        Me.UcMantUSUARIO1.CargarDatos()
    End Sub

End Class
