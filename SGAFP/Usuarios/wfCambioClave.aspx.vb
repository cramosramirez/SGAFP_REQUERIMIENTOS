
Partial Class wfCambioClave
    Inherits System.Web.UI.Page

    Protected Sub ChangePassword1_ChangedPassword(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChangePassword1.ChangedPassword
        Dim Usuario As MembershipUser = Membership.GetUser(Page.User.Identity.Name)
        Dim oldPassword As String = CType(Me.ChangePassword1.ChangePasswordTemplateContainer.FindControl("CurrentPassword"), TextBox).Text
        Dim newPassword As String = CType(Me.ChangePassword1.ChangePasswordTemplateContainer.FindControl("NewPassword"), TextBox).Text
        Usuario.ChangePassword(oldPassword, newPassword)
    End Sub
End Class
