Public Class frmMensajeBox

    Public Sub New(ByVal titulo As String, ByVal mensaje As String)
        Me.InitializeComponent()
        Me.Text = titulo
        Me.txtMensaje.Text = mensaje
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnCopiar_Click(sender As Object, e As EventArgs) Handles btnCopiar.Click
        Clipboard.Clear()
        Clipboard.SetText(txtMensaje.Text)
    End Sub
End Class