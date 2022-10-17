Public Class frmMantPROYECTO_FORMACION

    Private Sub frmMantPROYECTO_FORMACION_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " PROYECTO_FORMACION"
        Me.miMantenimiento = Me.UcMantPROYECTO_FORMACION1
        Me.UcMantPROYECTO_FORMACION1.CargarDatos()
    End Sub

End Class
