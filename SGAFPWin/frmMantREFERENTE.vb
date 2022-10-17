Public Class frmMantREFERENTE

    Private Sub frmMantREFERENTE_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " REFERENTE"
        Me.miMantenimiento = Me.UcMantREFERENTE1
        Me.UcMantREFERENTE1.CargarDatos()
    End Sub

End Class
