Public Class frmMantOPCION_MENU

    Private Sub frmMantOPCION_MENU_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " OPCION_MENU"
        Me.miMantenimiento = Me.UcMantOPCION_MENU1
        Me.UcMantOPCION_MENU1.CargarDatos()
    End Sub

End Class
