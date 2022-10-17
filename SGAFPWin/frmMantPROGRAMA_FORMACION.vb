Public Class frmMantPROGRAMA_FORMACION

    Private Sub frmMantPROGRAMA_FORMACION_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " PROGRAMA_FORMACION"
        Me.miMantenimiento = Me.UcMantPROGRAMA_FORMACION1
        Me.UcMantPROGRAMA_FORMACION1.CargarDatos()
    End Sub

End Class
