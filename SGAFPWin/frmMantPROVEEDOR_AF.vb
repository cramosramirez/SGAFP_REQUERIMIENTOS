Public Class frmMantPROVEEDOR_AF

    Private Sub frmMantPROVEEDOR_AF_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " PROVEEDOR_AF"
        Me.miMantenimiento = Me.UcMantPROVEEDOR_AF1
        Me.UcMantPROVEEDOR_AF1.CargarDatos()
    End Sub

End Class
