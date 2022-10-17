Public Class frmMantAREA_FORMACION

    Private Sub frmMantAREA_FORMACION_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " AREA_FORMACION"
        Me.miMantenimiento = Me.UcMantAREA_FORMACION1
        Me.UcMantAREA_FORMACION1.CargarDatos()
    End Sub

End Class
