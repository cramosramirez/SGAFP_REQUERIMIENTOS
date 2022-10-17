Public Class frmMantGRUPO_ACCION_CONTRATADA

    Private Sub frmMantGRUPO_ACCION_CONTRATADA_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " GRUPO_ACCION_CONTRATADA"
        Me.miMantenimiento = Me.UcMantGRUPO_ACCION_CONTRATADA1
        Me.UcMantGRUPO_ACCION_CONTRATADA1.CargarDatos()
    End Sub

End Class
