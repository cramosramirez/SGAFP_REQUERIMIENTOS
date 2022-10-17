Public Class frmMantMUNICIPIO

    Private Sub frmMantMUNICIPIO_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " MUNICIPIO"
        Me.miMantenimiento = Me.UcMantMUNICIPIO1
        Me.UcMantMUNICIPIO1.CargarDatos()
    End Sub

End Class
