Public Class frmMantFACILITADOR_CAPACITADOR

    Private Sub frmMantFACILITADOR_CAPACITADOR_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " FACILITADOR_CAPACITADOR"
        Me.miMantenimiento = Me.UcMantFACILITADOR_CAPACITADOR1
        Me.UcMantFACILITADOR_CAPACITADOR1.CargarDatos()
    End Sub

End Class
