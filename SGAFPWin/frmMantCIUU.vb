Public Class frmMantCIUU

    Private Sub frmMantCIUU_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " CIUU"
        Me.miMantenimiento = Me.UcMantCIUU1
        Me.UcMantCIUU1.CargarDatos()
    End Sub

End Class
