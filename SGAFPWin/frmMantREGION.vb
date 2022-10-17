Public Class frmMantREGION

    Private Sub frmMantREGION_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " REGION"
        Me.miMantenimiento = Me.UcMantREGION1
        Me.UcMantREGION1.CargarDatos()
    End Sub

End Class
