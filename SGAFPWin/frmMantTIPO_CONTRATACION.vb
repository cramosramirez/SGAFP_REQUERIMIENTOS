Public Class frmMantTIPO_CONTRATACION

    Private Sub frmMantTIPO_CONTRATACION_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " TIPO_CONTRATACION"
        Me.miMantenimiento = Me.UcMantTIPO_CONTRATACION1
        Me.UcMantTIPO_CONTRATACION1.CargarDatos()
    End Sub

End Class
