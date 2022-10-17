Public Class frmMantEVALUACION_AF

    Private Sub frmMantEVALUACION_AF_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " EVALUACION_AF"
        Me.miMantenimiento = Me.UcMantEVALUACION_AF1
        Me.UcMantEVALUACION_AF1.CargarDatos()
    End Sub

End Class
