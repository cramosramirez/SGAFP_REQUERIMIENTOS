Public Class frmMantMODALIDAD_DE_FORMACION

    Private Sub frmMantMODALIDAD_DE_FORMACION_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " MODALIDAD_DE_FORMACION"
        Me.miMantenimiento = Me.UcMantMODALIDAD_DE_FORMACION1
        Me.UcMantMODALIDAD_DE_FORMACION1.CargarDatos()
    End Sub

End Class
