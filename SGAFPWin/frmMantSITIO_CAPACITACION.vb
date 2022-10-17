Public Class frmMantSITIO_CAPACITACION

    Private Sub frmMantSITIO_CAPACITACION_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " SITIO_CAPACITACION"
        Me.miMantenimiento = Me.UcMantSITIO_CAPACITACION1
        Me.UcMantSITIO_CAPACITACION1.CargarDatos()
    End Sub

End Class
