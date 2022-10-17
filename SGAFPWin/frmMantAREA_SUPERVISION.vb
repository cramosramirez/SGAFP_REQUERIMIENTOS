Public Class frmMantAREA_SUPERVISION

    Private Sub frmMantAREA_SUPERVISION_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " AREA_SUPERVISION"
        Me.miMantenimiento = Me.UcMantAREA_SUPERVISION1
        Me.UcMantAREA_SUPERVISION1.CargarDatos()
    End Sub

End Class
