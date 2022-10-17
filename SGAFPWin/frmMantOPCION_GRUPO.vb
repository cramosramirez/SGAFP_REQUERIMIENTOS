Public Class frmMantOPCION_GRUPO

    Private Sub frmMantOPCION_GRUPO_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " OPCION_GRUPO"
        Me.miMantenimiento = Me.UcMantOPCION_GRUPO1
        Me.UcMantOPCION_GRUPO1.CargarDatos()
    End Sub

End Class
