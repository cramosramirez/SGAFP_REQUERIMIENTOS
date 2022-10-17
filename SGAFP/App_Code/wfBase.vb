Imports System.Configuration.ConfigurationManager
Imports System.Web.UI.WebControls
Imports SGAFP.EL.Enumeradores

Public Class wfBase
    Inherits System.Web.UI.Page

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Id del Sistema actual
    ''' </summary>
    ''' <value></value>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	27/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public ReadOnly Property idSistema() As Integer
        Get
            Dim lIdSistema As Integer = AppSettings("idSistema")
            Return lIdSistema
        End Get
    End Property

    Public Sub AsignarMensaje(ByVal asMensaje As String, Optional ByVal EsError As Boolean = False, Optional ByVal EsAlerta As Boolean = False, Optional ByVal abrirPagina As String = "", Optional ByVal asTarget As String = "_self")

        If Me.Page.IsCallback And EsAlerta Then
            Me.AsignarMensajeCallback(asMensaje, EsError, abrirPagina, asTarget)
            Return
        End If

        If EsAlerta Then
            If EsError Then
                If Me.Page.Master.FindControl("ScriptManager1") Is Nothing Then
                    If abrirPagina <> "" Then
                        Me.Page.ClientScript.RegisterStartupScript(Me.Page.GetType(), "Mensaje", "alert('Suceso inesperado : " + asMensaje.Replace("'", """") + "');window.open('" + abrirPagina + "','" + asTarget + "','')")
                    Else
                        Me.Page.ClientScript.RegisterStartupScript(Me.Page.GetType(), "Mensaje", "alert('Suceso inesperado : " + asMensaje.Replace("'", """") + "');")
                    End If
                Else
                    If abrirPagina <> "" Then
                        ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "Mensaje", "alert('Suceso inesperado : " + asMensaje.Replace("'", """") + "');window.open('" + abrirPagina + "','" + asTarget + "','')", True)
                    Else
                        ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "Mensaje", "alert('Suceso inesperado : " + asMensaje.Replace("'", """") + "');", True)
                    End If
                    'CType(Me.Page.Master.FindControl("ScriptManager1"), ScriptManager).RegisterStartupScript(Me.Page, Me.Page.GetType(), "Mensaje", "alert('Suceso inesperado : " + asMensaje.Replace("'", """") + "');", True)
                End If
            Else
                If Me.Page.Master.FindControl("ScriptManager1") Is Nothing Then
                    If abrirPagina <> "" Then
                        Me.Page.ClientScript.RegisterStartupScript(Me.Page.GetType(), "Mensaje", "alert('" + asMensaje.Replace("'", """") + "');window.open('" + abrirPagina + "','" + asTarget + "','')")
                    Else
                        Me.Page.ClientScript.RegisterStartupScript(Me.Page.GetType(), "Mensaje", "alert('" + asMensaje.Replace("'", """") + "');")
                    End If
                Else
                    If abrirPagina <> "" Then
                        ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "Mensaje", "alert('" + asMensaje.Replace("'", """") + "');window.open('" + abrirPagina + "','" + asTarget + "','')", True)
                    Else
                        ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "Mensaje", "alert('" + asMensaje.Replace("'", """") + "');", True)
                    End If
                    'CType(Me.Page.Master.FindControl("ScriptManager1"), ScriptManager).RegisterStartupScript(Me.Page, Me.Page.GetType(), "Mensaje", "alert('" + asMensaje.Replace("'", """") + "');", True)
                End If
            End If
        End If

        Dim myLabel As Label
        Dim mEncabezado1 As Object
        mEncabezado1 = Page.Master.FindControl("ucEncabezado1")

        If mEncabezado1 Is Nothing Then Return
        myLabel = mEncabezado1.FindControl("Label_Mensaje")

        If myLabel Is Nothing Then Return

        If EsError Then
            myLabel.CssClass = "MensajeError"
        Else
            myLabel.CssClass = "MensajeInformativo"
        End If

        myLabel.Text = asMensaje

    End Sub

    Private Sub AsignarMensajeCallback(ByVal asMensaje As String, Optional ByVal EsError As Boolean = False, Optional ByVal abrirPagina As String = "", Optional ByVal asTarget As String = "_self")

        Dim pc As New DevExpress.Web.ASPxPopupControl.ASPxPopupControl
        pc = Me.Page.Master.FindControl("pcMessageBox")

        If pc Is Nothing Then Return

        If EsError Then
            pc.Text = "Suceso inesperado : " + asMensaje
        Else
            pc.Text = asMensaje
        End If

        'pc.FindControl("")
        'pc.AppearAfter = 0
        'pc.Modal = True
        pc.ShowOnPageLoad = True
        pc.HeaderText = "Mensaje"
        'pc.Height = New Unit(100)
        'pc.Width = New Unit(100)
        'pc.PopupHorizontalAlign = DevExpress.Web.ASPxClasses.PopupHorizontalAlign.WindowCenter
        'pc.PopupVerticalAlign = DevExpress.Web.ASPxClasses.PopupHorizontalAlign.WindowCenter

        'Me.Controls.Add(pc)
        'Me.Page.Master.FindControl("Form1").Controls.Add(pc)
        'Me.Page.FindControl("Form1").Controls.Add(pc)

    End Sub

    Public Function ObtenerIdUsuario() As Integer
        Return Context.Items("idUsuario")
    End Function

    Public Function ObtenerUsuario() As String
        Return Context.User.Identity.Name
    End Function

    Public Function EstaEnRol(ByVal rol As String) As Boolean
        Return Context.User.IsInRole(rol)
    End Function

    Public Function EstaEnRol(ByVal rol As RolUsuario) As Boolean
        Select Case rol
            Case RolUsuario.Administrador
                Return EstaEnRol(RolDeUsuario.Administrador)
            Case RolUsuario.Proveedor
                Return EstaEnRol(RolDeUsuario.Proveedor)
            Case RolUsuario.CentroCapacitador
                Return EstaEnRol(RolDeUsuario.CentroCapacitador)
            Case RolUsuario.Participante
                Return EstaEnRol(RolDeUsuario.Participante)
            Case RolUsuario.TecnicoCentroHTP
                Return EstaEnRol(RolDeUsuario.TecnicoCentroHTP)
            Case RolUsuario.JefeHTP
                Return EstaEnRol(RolDeUsuario.JefeHTP)
            Case RolUsuario.AsistenteGFI
                Return EstaEnRol(RolDeUsuario.AsistenteGFI)
        End Select
        Return False
    End Function

    Public Overridable Sub LimpiarControles()
        Dim liCntrl As Integer
        Dim Cntrl As System.Web.UI.WebControls.TextBox
        Dim DDL As System.Web.UI.WebControls.DropDownList

        For liCntrl = 0 To Me.Controls.Count - 1
            Select Case Me.Controls(liCntrl).GetType().ToString
                Case "System.Web.UI.WebControls.TextBox"
                    Cntrl = CType(Me.Controls(liCntrl), TextBox)
                    If Cntrl.Visible Then Cntrl.Text = ""
                Case "System.Web.UI.WebControls.DropDownList"
                    Dim li As System.Web.UI.WebControls.ListItem
                    ' Buscar si existe un valor 0 en la lista.  Si existe, seleccionarlo
                    DDL = CType(Me.Controls(liCntrl), DropDownList)
                    li = DDL.Items.FindByValue("0")

                    If Not li Is Nothing Then DDL.SelectedValue = "0"
            End Select

            If Me.Controls(liCntrl).GetType().ToString().IndexOf("ucDDL") > 0 Then
                Dim li As System.Web.UI.WebControls.ListItem
                ' Buscar si existe un valor 0 en la lista.  Si existe, seleccionarlo
                DDL = CType(Me.Controls(liCntrl), DropDownList)
                li = DDL.Items.FindByValue("0")

                If Not li Is Nothing Then DDL.SelectedValue = "0"
            End If
        Next
    End Sub

    Public Function ObtenerKeyValue(ByVal asKey As String) As String
        Return AppSettings(asKey)
    End Function

End Class
