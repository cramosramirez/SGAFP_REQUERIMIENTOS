Public Class frmMantASISTENCIA_AF

    Private Sub frmMantASISTENCIA_AF_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " ASISTENCIA_AF"
        Me.miMantenimiento = Me.UcMantASISTENCIA_AF1
        Me.UcMantASISTENCIA_AF1.CargarDatos()
    End Sub

End Class
