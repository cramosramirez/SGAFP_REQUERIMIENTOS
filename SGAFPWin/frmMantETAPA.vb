Public Class frmMantETAPA

    Private Sub frmMantETAPA_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " ETAPA"
        Me.miMantenimiento = Me.UcMantETAPA1
        Me.UcMantETAPA1.CargarDatos()
    End Sub

End Class
