Public Class frmMantSUPERVISION_AF

    Private Sub frmMantSUPERVISION_AF_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " SUPERVISION_AF"
        Me.miMantenimiento = Me.UcMantSUPERVISION_AF1
        Me.UcMantSUPERVISION_AF1.CargarDatos()
    End Sub

End Class
