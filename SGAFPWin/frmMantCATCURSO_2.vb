Public Class frmMantCATCURSO_2

    Private Sub frmMantCATCURSO_2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " CATCURSO_2"
        Me.miMantenimiento = Me.UcMantCATCURSO_21
        Me.UcMantCATCURSO_21.CargarDatos()
    End Sub

End Class
