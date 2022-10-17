Public Class frmMantSIPU_MUNICIPIO

    Private Sub frmMantSIPU_MUNICIPIO_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " SIPU_MUNICIPIO"
        Me.miMantenimiento = Me.UcMantSIPU_MUNICIPIO1
        Me.UcMantSIPU_MUNICIPIO1.CargarDatos()
    End Sub

End Class
