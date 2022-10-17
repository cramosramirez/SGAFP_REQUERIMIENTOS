Public Class frmMantESTADO_ACCION_FORMATIVA

    Private Sub frmMantESTADO_ACCION_FORMATIVA_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " ESTADO_ACCION_FORMATIVA"
        Me.miMantenimiento = Me.UcMantESTADO_ACCION_FORMATIVA1
        Me.UcMantESTADO_ACCION_FORMATIVA1.CargarDatos()
    End Sub

End Class
