Public Class frmMantASISTENCIA_AF_DET

    Private Sub frmMantASISTENCIA_AF_DET_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " ASISTENCIA_AF_DET"
        Me.miMantenimiento = Me.UcMantASISTENCIA_AF_DET1
        Me.UcMantASISTENCIA_AF_DET1.CargarDatos()
    End Sub

End Class
