Public Class frmMantEVALUACIONES_AF_DET

    Private Sub frmMantEVALUACIONES_AF_DET_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " EVALUACIONES_AF_DET"
        Me.miMantenimiento = Me.UcMantEVALUACIONES_AF_DET1
        Me.UcMantEVALUACIONES_AF_DET1.CargarDatos()
    End Sub

End Class
