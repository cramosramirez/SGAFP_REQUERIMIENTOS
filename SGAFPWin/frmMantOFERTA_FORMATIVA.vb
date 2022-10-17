Public Class frmMantOFERTA_FORMATIVA

    Private Sub frmMantOFERTA_FORMATIVA_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " OFERTA_FORMATIVA"
        Me.miMantenimiento = Me.UcMantOFERTA_FORMATIVA1
        Me.UcMantOFERTA_FORMATIVA1.CargarDatos()
    End Sub

End Class
