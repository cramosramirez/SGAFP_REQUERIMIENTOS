Public Class frmMantNIVEL_ACADEMICO

    Private Sub frmMantNIVEL_ACADEMICO_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " NIVEL_ACADEMICO"
        Me.miMantenimiento = Me.UcMantNIVEL_ACADEMICO1
        Me.UcMantNIVEL_ACADEMICO1.CargarDatos()
    End Sub

End Class
