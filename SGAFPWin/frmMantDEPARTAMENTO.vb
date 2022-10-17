Public Class frmMantDEPARTAMENTO

    Private Sub frmMantDEPARTAMENTO_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " DEPARTAMENTO"
        Me.miMantenimiento = Me.UcMantDEPARTAMENTO1
        Me.UcMantDEPARTAMENTO1.CargarDatos()
    End Sub

End Class
