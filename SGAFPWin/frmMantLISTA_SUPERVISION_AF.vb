Public Class frmMantLISTA_SUPERVISION_AF

    Private Sub frmMantLISTA_SUPERVISION_AF_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " LISTA_SUPERVISION_AF"
        Me.miMantenimiento = Me.UcMantLISTA_SUPERVISION_AF1
        Me.UcMantLISTA_SUPERVISION_AF1.CargarDatos()
    End Sub

End Class
