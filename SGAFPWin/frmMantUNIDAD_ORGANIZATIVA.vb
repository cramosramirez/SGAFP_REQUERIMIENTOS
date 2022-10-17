Public Class frmMantUNIDAD_ORGANIZATIVA

    Private Sub frmMantUNIDAD_ORGANIZATIVA_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " UNIDAD_ORGANIZATIVA"
        Me.miMantenimiento = Me.UcMantUNIDAD_ORGANIZATIVA1
        Me.UcMantUNIDAD_ORGANIZATIVA1.CargarDatos()
    End Sub

End Class
