Public Class frmMantPROCESO

    Private Sub frmMantPROCESO_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " PROCESO"
        Me.miMantenimiento = Me.UcMantPROCESO1
        Me.UcMantPROCESO1.CargarDatos()
    End Sub

End Class
