Public Class frmMantESTADO_SOLICITUD

    Private Sub frmMantESTADO_SOLICITUD_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " ESTADO_SOLICITUD"
        Me.miMantenimiento = Me.UcMantESTADO_SOLICITUD1
        Me.UcMantESTADO_SOLICITUD1.CargarDatos()
    End Sub

End Class
