Public Class frmMantEJERCICIO

    Private Sub frmMantEJERCICIO_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " EJERCICIO"
        Me.miMantenimiento = Me.UcMantEJERCICIO1
        Me.UcMantEJERCICIO1.CargarDatos()
    End Sub

End Class
