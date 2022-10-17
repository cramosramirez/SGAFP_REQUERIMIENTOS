Public Class frmMantCURSO_TEMA

    Private Sub frmMantCURSO_TEMA_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " CURSO_TEMA"
        Me.miMantenimiento = Me.UcMantCURSO_TEMA1
        Me.UcMantCURSO_TEMA1.CargarDatos()
    End Sub

End Class
