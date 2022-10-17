Public Class frmMantPARTICIPANTE_AF

    Private Sub frmMantPARTICIPANTE_AF_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " PARTICIPANTE_AF"
        Me.miMantenimiento = Me.UcMantPARTICIPANTE_AF1
        Me.UcMantPARTICIPANTE_AF1.CargarDatos()
    End Sub

End Class
