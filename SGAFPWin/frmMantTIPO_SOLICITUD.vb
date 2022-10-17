Public Class frmMantTIPO_SOLICITUD

    Private Sub frmMantTIPO_SOLICITUD_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " TIPO_SOLICITUD"
        Me.miMantenimiento = Me.UcMantTIPO_SOLICITUD1
        Me.UcMantTIPO_SOLICITUD1.CargarDatos()
    End Sub

End Class
