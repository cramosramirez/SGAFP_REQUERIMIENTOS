Public Class frmMantINFORME_FINAL_DET

    Private Sub frmMantINFORME_FINAL_DET_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " INFORME_FINAL_DET"
        Me.miMantenimiento = Me.UcMantINFORME_FINAL_DET1
        Me.UcMantINFORME_FINAL_DET1.CargarDatos()
    End Sub

End Class
