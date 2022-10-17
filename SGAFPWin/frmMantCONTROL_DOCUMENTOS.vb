Public Class frmMantCONTROL_DOCUMENTOS

    Private Sub frmMantCONTROL_DOCUMENTOS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " CONTROL_DOCUMENTOS"
        Me.miMantenimiento = Me.UcMantCONTROL_DOCUMENTOS1
        Me.UcMantCONTROL_DOCUMENTOS1.CargarDatos()
    End Sub

End Class
