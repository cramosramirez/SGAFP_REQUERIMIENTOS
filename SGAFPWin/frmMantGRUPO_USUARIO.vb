Public Class frmMantGRUPO_USUARIO

    Private Sub frmMantGRUPO_USUARIO_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " GRUPO_USUARIO"
        Me.miMantenimiento = Me.UcMantGRUPO_USUARIO1
        Me.UcMantGRUPO_USUARIO1.CargarDatos()
    End Sub

End Class
