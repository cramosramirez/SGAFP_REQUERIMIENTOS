Public Class frmMantHALLAZGO_SUPERVISION

    Private Sub frmMantHALLAZGO_SUPERVISION_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " HALLAZGO_SUPERVISION"
        Me.miMantenimiento = Me.UcMantHALLAZGO_SUPERVISION1
        Me.UcMantHALLAZGO_SUPERVISION1.CargarDatos()
    End Sub

End Class
