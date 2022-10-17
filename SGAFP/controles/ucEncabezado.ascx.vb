Partial Class controles_ucEncabezado
    Inherits ucBase

    Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Request.IsAuthenticated Then
            Me.Label_Usuario.Text = Me.ObtenerUsuario()
        End If
    End Sub
End Class
