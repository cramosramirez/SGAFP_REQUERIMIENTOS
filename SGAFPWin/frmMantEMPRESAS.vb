Public Class frmMantEMPRESAS

    Private Sub frmMantEMPRESAS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " EMPRESAS"
        Me.miMantenimiento = Me.UcMantEMPRESAS1
        Me.UcMantEMPRESAS1.CargarDatos()
    End Sub

End Class
