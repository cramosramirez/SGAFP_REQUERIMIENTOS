Public Class frmMantSUPERVISION_AF_DET

    Private Sub frmMantSUPERVISION_AF_DET_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " SUPERVISION_AF_DET"
        Me.miMantenimiento = Me.UcMantSUPERVISION_AF_DET1
        Me.UcMantSUPERVISION_AF_DET1.CargarDatos()
    End Sub

End Class
