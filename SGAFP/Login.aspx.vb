
Partial Class Login
    Inherits wfBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.Master.FindControl("LoginStatus1").Visible = False
        End If
        If Request.IsAuthenticated Then
            Response.Redirect("Default.aspx")
        End If
    End Sub

    Protected Sub Login1_LoggedIn(ByVal sender As Object, ByVal e As System.EventArgs) Handles Login1.LoggedIn
        Response.Redirect("Default.aspx")
    End Sub

    Protected Sub cpRecuperarClave_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cpRecuperarClave.Callback
        cpRecuperarClave.JSProperties.Remove("cpResultCallback")

        Dim cMsProvider As New cmembershipProvider
        Dim NuevaClave As String
        Dim Cuerpo As New StringBuilder
        Dim Usuario As cmembershipUser
        Dim UsuarioAdmin As cmembershipUser

        cMsProvider = CType(Membership.Provider, cmembershipProvider)

        Usuario = cMsProvider.ObtenerUsuario(e.Parameter)
        UsuarioAdmin = cMsProvider.ObtenerUsuario("administrador")
        If Usuario IsNot Nothing Then
            If Usuario.IsLockedOut Then Usuario.UnlockUser()
            NuevaClave = cMsProvider.ResetPassword(e.Parameter, "")
            Cuerpo.AppendLine(Usuario.Nombre)
            Cuerpo.Append("Su usuario es: ")
            Cuerpo.AppendLine(Usuario.UserName)
            Cuerpo.Append("Su nueva clave es: ")
            Cuerpo.AppendLine(NuevaClave)
            Cuerpo.AppendLine("")
            Cuerpo.AppendLine("Para cambiar esta clave ingrese al sistema, luego vaya al menu 'Seguridad' opcion 'Cambiar mi contrasena'.")
            Cuerpo.AppendLine("En la pantalla que se presenta digite en el primer campo la clave que se le envio y en los otros campos la clave que usted desea,")
            Cuerpo.AppendLine("finalmente haga clic en el boton Cambiar Contrasena.")

            If cMsProvider.EnviarCorreo(UsuarioAdmin.Email, Usuario.Email, "INSAFORP - Recuperación de clave para el SGAFP", Cuerpo.ToString) = 1 Then
                cpRecuperarClave.JSProperties.Add("cpResultCallback", "ok")
                Me.lblMensaje.Text = "En estos momentos se ha enviado un correo a su cuenta con una nueva clave para ingresar al sistema."
                Me.txtUsuario.ClientVisible = False
                Me.btnAceptar.ClientVisible = False
            Else
                Me.lblMensaje.Text = "Fallo al enviar clave al usuario"
            End If
        Else
            Me.lblMensaje.Text = "El usuario que usted ingreso no se encuentra registrado. Intente ingresarlo nuevamente o póngase en contacto con soporte técnico."
            Me.txtUsuario.Text = ""
        End If
    End Sub

    Protected Sub Login1_LoggingIn(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.LoginCancelEventArgs) Handles Login1.LoggingIn
        Dim lUsuario As New USUARIO
        lUsuario = (New cUSUARIO).ObtenerUSUARIO(Login1.UserName)

        Dim ltl As Literal
        ltl = Login1.FindControl("FailureText")
        If lUsuario Is Nothing Then
            ltl.Text = "El usuario ingresado no es valido."
            e.Cancel = True
        Else
            ltl.Text = String.Empty
        End If
    End Sub
   
    Protected Sub Login1_LoginError(sender As Object, e As EventArgs) Handles Login1.LoginError
        Dim c As New cmembershipProvider
        Dim u As MembershipUser = Membership.GetUser(Login1.UserName)

        If u IsNot Nothing Then
            If u.IsLockedOut Then
                Login1.FailureText = "El usuario ha sido bloqueado por intentos de conexión incorrectos. Seleccione la opción Olvido su clave para enviar una nueva clave al correo asociado al usuario"
            Else
                c = CType(Membership.Provider, cmembershipProvider)
                If Not c.ValidateUser(Login1.UserName, Login1.Password) Then
                    Login1.FailureText = "La clave ingresada no es valida"
                End If
            End If
        End If
    End Sub
End Class
