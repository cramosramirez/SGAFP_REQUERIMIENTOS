Public Class frmMantCIUO

    Private Sub frmMantCIUO_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " CIUO"
        Me.miMantenimiento = Me.UcMantCIUO1
        Me.UcMantCIUO1.CargarDatos()
    End Sub

End Class
