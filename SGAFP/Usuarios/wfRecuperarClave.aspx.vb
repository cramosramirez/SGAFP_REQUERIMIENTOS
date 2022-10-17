Imports System.Net.Mail

Partial Class wfRecuperarClave
    Inherits System.Web.UI.Page

    Protected Sub PasswordRecovery1_SendMailError(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SendMailErrorEventArgs) Handles PasswordRecovery1.SendMailError
        Dim Msg As New Label
        Msg = Me.PasswordRecovery1.SuccessTemplateContainer.FindControl("MsgResultado")
        Msg.Text = e.Exception.Message
        e.Handled = True
    End Sub
End Class
