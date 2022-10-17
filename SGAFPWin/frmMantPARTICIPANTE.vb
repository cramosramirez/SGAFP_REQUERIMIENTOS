Public Class frmMantPARTICIPANTE

    Private Sub frmMantPARTICIPANTE_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " PARTICIPANTE"
        Me.miMantenimiento = Me.UcMantPARTICIPANTE1
        Me.UcMantPARTICIPANTE1.CargarDatos()
    End Sub

End Class
