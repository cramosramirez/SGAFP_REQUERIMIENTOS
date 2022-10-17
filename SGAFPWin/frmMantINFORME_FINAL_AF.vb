Public Class frmMantINFORME_FINAL_AF

    Private Sub frmMantINFORME_FINAL_AF_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " INFORME_FINAL_AF"
        Me.miMantenimiento = Me.UcMantINFORME_FINAL_AF1
        Me.UcMantINFORME_FINAL_AF1.CargarDatos()
    End Sub

End Class
