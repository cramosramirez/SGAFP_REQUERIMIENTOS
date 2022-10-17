Public Class frmMantSOLICITUD_INSCRIPCION_AF

    Private Sub frmMantSOLICITUD_INSCRIPCION_AF_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " SOLICITUD_INSCRIPCION_AF"
        Me.miMantenimiento = Me.UcMantSOLICITUD_INSCRIPCION_AF1
        Me.UcMantSOLICITUD_INSCRIPCION_AF1.CargarDatos()
    End Sub

End Class
