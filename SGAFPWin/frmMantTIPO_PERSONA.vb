Public Class frmMantTIPO_PERSONA

    Private Sub frmMantTIPO_PERSONA_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " TIPO_PERSONA"
        Me.miMantenimiento = Me.UcMantTIPO_PERSONA1
        Me.UcMantTIPO_PERSONA1.CargarDatos()
    End Sub

End Class
