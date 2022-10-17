Public Class frmMantACCION_FORMATIVA

    Private Sub frmMantACCION_FORMATIVA_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " ACCION_FORMATIVA"
        Me.miMantenimiento = Me.UcMantACCION_FORMATIVA1
        Me.UcMantACCION_FORMATIVA1.CargarDatos()
    End Sub

End Class
