Imports System.Configuration.ConfigurationManager
Imports System.Web.UI.WebControls
Imports PATI
Imports DevExpress.Web.ASPxEditors
Imports SGAFP.BL
Imports SGAFP.EL
Imports SGAFP.EL.Enumeradores
Imports System.Collections.Generic
Imports SQLMembershipProvider.BL

Public Class ucBase
    Inherits System.Web.UI.UserControl

    Private _PermitirMaximizar As Boolean = False
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Permitir Que el Titulo del Control contenga una forma de Minimizar su contenido
    ''' mediante una imagen del simbolo (+) o minimizarlo (-)
    ''' </summary>
    ''' <value>Por defecto un control de usuario no Permite Maximizar</value>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	18/10/2006	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Property PermitirMaximizar() As Boolean
        Get
            Return _PermitirMaximizar
        End Get
        Set(ByVal Value As Boolean)
            _PermitirMaximizar = Value
            If Not Me.ViewState(Me.ID + "_PermitirMaximizar") Is Nothing Then Me.ViewState.Remove(Me.ID + "_PermitirMaximizar")
            Me.ViewState.Add(Me.ID + "_PermitirMaximizar", Value)
        End Set
    End Property

    Private _VerTitulo As Boolean = False
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Permite agregarle un recuadro con Titulo al Control
    ''' </summary>
    ''' <value>Por defecto un control de usuario no tiene Titulo</value>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	18/10/2006	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Property VerTitulo() As Boolean
        Get
            Return _VerTitulo
        End Get
        Set(ByVal Value As Boolean)
            _VerTitulo = Value
            If Not Me.ViewState(Me.ID + "_VerTitulo") Is Nothing Then Me.ViewState.Remove(Me.ID + "_VerTitulo")
            Me.ViewState.Add(Me.ID + "_VerTitulo", Value)
        End Set
    End Property

    Private _VerTituloCentrado As Boolean = False
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Permite agregarle un recuadro con Titulo al Control Centrado
    ''' </summary>
    ''' <value>Por defecto un control de usuario no tiene Titulo</value>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	01/11/2006	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Property VerTituloCentrado() As Boolean
        Get
            Return _VerTituloCentrado
        End Get
        Set(ByVal Value As Boolean)
            _VerTituloCentrado = Value
            If Value Then _VerTitulo = Value
            If Not Me.ViewState(Me.ID + "_VerTituloCentrado") Is Nothing Then Me.ViewState.Remove(Me.ID + "_VerTituloCentrado")
            Me.ViewState.Add(Me.ID + "_VerTituloCentrado", Value)
        End Set
    End Property

    Private _TituloControl As String = ""
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Si la Propiedad VerTitulo es True, en esta propiedad se le asigna el Titulo que
    ''' se le agregara al Control de Usuario
    ''' </summary>
    ''' <value>Por defecto un control de usuario no Tiene nada en su titulo. Si se le asigna 
    ''' un valor al Titulo automaticamente se pone la Propiedad VerTitulo=True</value>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	18/10/2006	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Property TituloControl() As String
        Get
            Return _TituloControl
        End Get
        Set(ByVal Value As String)
            _TituloControl = Value
            Me.VerTitulo = Value <> ""
            If Not Me.ViewState(Me.ID + "_TituloControl") Is Nothing Then Me.ViewState.Remove(Me.ID + "_TituloControl")
            Me.ViewState.Add(Me.ID + "_TituloControl", Value)
        End Set
    End Property

    Private _VerMaximizado As Boolean = True
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Permite que al inicializar el Control se Vea con el contenido visible y no Minimizado
    ''' </summary>
    ''' <value>Por defecto un control de usuario ve maximizada la información del mismo</value>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	18/10/2006	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Property VerMaximizado() As Boolean
        Get
            Return _VerMaximizado
        End Get
        Set(ByVal Value As Boolean)
            _VerMaximizado = Value
            If Not Me.ViewState(Me.ID + "_VerMaximizado") Is Nothing Then Me.ViewState.Remove(Me.ID + "_VerMaximizado")
            Me.ViewState.Add(Me.ID + "_VerMaximizado", Value)
        End Set
    End Property

    Private _VerRecuadro As Boolean = False
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Permite que el Render del Control de Usuario se le agregue un Recuadro a todo
    ''' el contenido.
    ''' </summary>
    ''' <value>Por defecto un control de Usuario no tiene Recuadro</value>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	18/10/2006	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Property VerRecuadro() As Boolean
        Get
            Return _VerRecuadro
        End Get
        Set(ByVal Value As Boolean)
            _VerRecuadro = Value
            If Not Me.ViewState(Me.ID + "_VerRecuadro") Is Nothing Then Me.ViewState.Remove(Me.ID + "_VerRecuadro")
            Me.ViewState.Add(Me.ID + "_VerRecuadro", Value)
        End Set
    End Property

    Private _VerRecuadroRedondeado As Boolean = False
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Permite que el Render del Control de Usuario se le agregue un Recuadro Redondeado
    ''' a todo el contenido.
    ''' </summary>
    ''' <value>Por defecto un control de Usuario no tiene Recuadro Redondeado. Si se le 
    ''' activa esta Propiedad automaticamente se pone VerRecuadro=True</value>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	18/10/2006	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Property VerRecuadroRedondeado() As Boolean
        Get
            Return _VerRecuadroRedondeado
        End Get
        Set(ByVal Value As Boolean)
            _VerRecuadroRedondeado = Value
            If Value Then Me.VerRecuadro = True
            If Not Me.ViewState(Me.ID + "_VerRecuadroRedondeado") Is Nothing Then Me.ViewState.Remove(Me.ID + "_VerRecuadroRedondeado")
            Me.ViewState.Add(Me.ID + "_VerRecuadroRedondeado", Value)
        End Set
    End Property

    Public Sub AsignarTituloOpcion(ByVal asTitulo As String, Optional ByVal asImagen As String = "")

        Dim lblTitulo As ASPxLabel
        lblTitulo = Page.Master.FindControl("contenidoSplitter").FindControl("lblTituloOpcion")

        If lblTitulo Is Nothing Then Return
        lblTitulo.Visible = True
        lblTitulo.Text = asTitulo

        If asImagen <> "" Then
            Dim imgTituloOpcion As ASPxImage
            imgTituloOpcion = Page.Master.FindControl("contenidoSplitter").FindControl("imgTituloOpcion")
            If imgTituloOpcion Is Nothing Then Return
            imgTituloOpcion.Visible = True
            imgTituloOpcion.ImageUrl = asImagen
        End If

    End Sub

    Private _AnchoControl As Integer = 0
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Ancho del Control 
    ''' </summary>
    ''' <value></value>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	30/10/2006	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Property AnchoControl() As Integer
        Get
            Return _AnchoControl
        End Get
        Set(ByVal Value As Integer)
            _AnchoControl = Value
            If Not Me.ViewState(Me.ID + "_AnchoControl") Is Nothing Then Me.ViewState.Remove(Me.ID + "_AnchoControl")
            Me.ViewState.Add(Me.ID + "_AnchoControl", Value)
        End Set
    End Property

    Private _AltoControl As Integer = 0
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Alto del Control 
    ''' </summary>
    ''' <value></value>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	30/10/2006	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Property AltoControl() As Integer
        Get
            Return _AltoControl
        End Get
        Set(ByVal Value As Integer)
            _AltoControl = Value
            If Not Me.ViewState(Me.ID + "_AltoControl") Is Nothing Then Me.ViewState.Remove(Me.ID + "_AltoControl")
            Me.ViewState.Add(Me.ID + "_AltoControl", Value)
        End Set
    End Property

    Private _idOpcionMenu As Integer = 0
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Id Opcion Menu
    ''' </summary>
    ''' <value></value>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	27/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Property idOpcionMenu() As Integer
        Get
            Return _idOpcionMenu
        End Get
        Set(ByVal Value As Integer)
            _idOpcionMenu = Value
            If Not Me.ViewState(Me.ID + "_idOpcionMenu") Is Nothing Then Me.ViewState.Remove(Me.ID + "_idOpcionMenu")
            Me.ViewState.Add(Me.ID + "_idOpcionMenu", Value)
        End Set
    End Property

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

    Public Sub AsignarMensaje(ByVal asMensaje As String, Optional ByVal EsError As Boolean = False, Optional ByVal EsAlerta As Boolean = True, Optional ByVal abrirPagina As String = "", Optional ByVal asTarget As String = "_self")

        'Dim LabelMensajeError As Label = Me.Page.Master.FindControl("LabelMensajeError")
        'If Not LabelMensajeError Is Nothing Then
        '    LabelMensajeError.Visible = True
        '    LabelMensajeError.Text = asMensaje
        '    If EsError Then
        '        LabelMensajeError.CssClass = "MensajeError"
        '    Else
        '        LabelMensajeError.CssClass = "MensajeInformativo"
        '    End If
        'End If
        'If Me.Page.IsCallback And EsAlerta Then
        If Me.Page.IsCallback And EsAlerta Then
            Me.AsignarMensajeCallback(asMensaje, EsError, abrirPagina, asTarget)
            Return
        End If

        If EsAlerta Then
            If EsError Then
                If Me.Page.Master.FindControl("ScriptManager1") Is Nothing Then
                    If abrirPagina <> "" Then
                        Me.Page.ClientScript.RegisterStartupScript(Me.Page.GetType(), "Mensaje", "alert('Suceso inesperado : " + FormatearJava(asMensaje.Replace("'", """")) + "');window.open('" + abrirPagina + "','" + asTarget + "','')", True)
                    Else
                        Me.Page.ClientScript.RegisterStartupScript(Me.Page.GetType(), "Mensaje", "alert('Suceso inesperado : " + FormatearJava(asMensaje.Replace("'", """")) + "');", True)
                    End If
                Else
                    If abrirPagina <> "" Then
                        ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "Mensaje", "alert('Suceso inesperado : " + FormatearJava(asMensaje.Replace("'", """")) + "');window.open('" + abrirPagina + "','" + asTarget + "','')", True)
                    Else
                        ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "Mensaje", "alert('Suceso inesperado : " + FormatearJava(asMensaje.Replace("'", """")) + "');", True)
                    End If
                    'CType(Me.Page.Master.FindControl("ScriptManager1"), ScriptManager).RegisterStartupScript(Me.Page, Me.Page.GetType(), "Mensaje", "alert('Suceso inesperado : " + asMensaje.Replace("'", """") + "');", True)
                End If
            Else
                If Me.Page.Master.FindControl("ScriptManager1") Is Nothing Then
                    If abrirPagina <> "" Then
                        Me.Page.ClientScript.RegisterStartupScript(Me.Page.GetType(), "Mensaje", "alert('" + FormatearJava(asMensaje.Replace("'", """")) + "');window.open('" + abrirPagina + "','" + asTarget + "','')", True)
                    Else
                        Me.Page.ClientScript.RegisterStartupScript(Me.Page.GetType(), "Mensaje", "alert('" + FormatearJava(asMensaje.Replace("'", """")) + "');", True)
                    End If
                Else
                    If abrirPagina <> "" Then
                        ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "Mensaje", "alert('" + FormatearJava(asMensaje.Replace("'", """")) + "');window.open('" + abrirPagina + "','" + asTarget + "','')", True)
                    Else
                        'ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "Mensaje", "alert('" + FormatearJava(asMensaje.Replace("'", """")) + "');", True)
                        ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "Mensaje", "alert('" + FormatearJava(asMensaje.Replace("'", """")) + "');", True)
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
            Case RolUsuario.AsistenteGFI
                Return EstaEnRol(RolDeUsuario.AsistenteGFI)
            Case RolUsuario.TecnicoCentroHTP
                Return EstaEnRol(RolDeUsuario.TecnicoCentroHTP)
            Case RolUsuario.JefeHTP
                Return EstaEnRol(RolDeUsuario.JefeHTP)
            Case RolUsuario.AplicarRecalculoMontoPagarInforme
                Return EstaEnRol(RolDeUsuario.AplicarRecalculoMontoPagarInforme)
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

    Sub ServerValidateLenght255(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
        If Len(args.Value) > 255 Then
            args.IsValid = False
        Else
            args.IsValid = True
        End If
    End Sub

    Sub ServerValidateLenght50(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
        If Len(args.Value) > 50 Then
            args.IsValid = False
        Else
            args.IsValid = True
        End If
    End Sub

    Sub ServerValidateLenght100(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
        If Len(args.Value) > 100 Then
            args.IsValid = False
        Else
            args.IsValid = True
        End If
    End Sub

    Sub ServerValidateLenght150(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
        If Len(args.Value) > 150 Then
            args.IsValid = False
        Else
            args.IsValid = True
        End If
    End Sub

    Sub ServerValidateLenght200(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
        If Len(args.Value) > 200 Then
            args.IsValid = False
        Else
            args.IsValid = True
        End If
    End Sub

    Sub ServerValidateLenght500(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs)
        If Len(args.Value) > 500 Then
            args.IsValid = False
        Else
            args.IsValid = True
        End If
    End Sub

    'Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    If Not IsPostBack Then
    '        If Me.Session("idEmpresa") = Nothing And Request.IsAuthenticated Then
    '            Dim lcLogin As New cLogin
    '            Dim idUsuario As Integer
    '            idUsuario = lcLogin.ObtenerIdUsuario(Context.User.Identity.Name)
    '            Dim lUsuario As Usuarios
    '            lUsuario = (New cUsuarios).ObtenerUsuarios(idUsuario)
    '            If Not lUsuario Is Nothing Then
    '                Me.Session("idEmpresa") = lUsuario.idEmpresa
    '            End If

    '        End If
    '    End If
    'End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Permite ejecutar el código para Cerrar el Browser(Ventana) Activo del Usuario.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	18/10/2006	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CerrarVentana()
        Me.Page.ClientScript.RegisterStartupScript(GetType(String), "cerrarVentana", "<script language='JavaScript'>window.close();</script>")
        'Response.Write("<script language='JavaScript'>window.close();</script>")
    End Sub

    Public Function FormatearJava(ByVal Message As String) As String
        Message = Message.Replace("'", "\'")
        Message = Message.Replace("""", "\'")
        Message = Message.Replace("\", "\\")
        Message = Message.Replace(Convert.ToChar(10), "\n")
        Message = Message.Replace(Convert.ToChar(13), "\n")
        Return Message
    End Function

    Public Function FormatearHTML(ByVal Message As String) As String
        Message = Message.Replace(Convert.ToChar(10), "<br>")
        Message = Message.Replace(Convert.ToChar(13), "<br>")
        Return Message
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Sobreescribe el Render comun de un Web Control normal, permitiendo asi 
    ''' dependiendo de la configuracion de los parametros mostrar lo siguiente:
    ''' VerTitulo, PermitirMaximizar, VerMaximizado, VerRecuadroRedondeado,
    ''' VerRecuadro(Ver Detalle de cada propiedad para su funcionalidad)
    ''' </summary>
    ''' <param name="writer"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	18/10/2006	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Protected Overrides Sub Render(ByVal writer As System.Web.UI.HtmlTextWriter)
        If Me.VerTitulo Then
            'writer.WriteLine("<div id='TituloControl_" + Me.ID + "' style='POSITION: relative; TOP: 1px; BACKGROUND-COLOR: transparent'>")
            writer.WriteLine("<div id='TituloControl_" + Me.ID + "' style='BACKGROUND-COLOR: transparent'>")
            writer.WriteLine("	<TABLE id='TableEncabezado_" + Me.ID + "' cellSpacing='0' cellPadding='0' class=""" + IIf(Me.VerRecuadro And Not Me.VerRecuadroRedondeado, "RecuadroControl", "RecuadroControlSinBorde") + """>")
            writer.WriteLine("  <TBODY>")
            writer.WriteLine("  <TR>")
            If Me.VerRecuadro Then
                If Me.VerRecuadroRedondeado Then
                    writer.WriteLine("    <TD width=""12"" ><IMG alt="""" height=23 src=""imagenes/v1_ESI.gif"" width=12 ")
                    writer.WriteLine("      border=0 name=v1_ESI></TD>")
                Else
                    writer.WriteLine("    <TD width=""12"" height=23 background=""imagenes/v1_BordeSup.gif""></TD>")
                End If
            Else
                writer.WriteLine("    <TD width=""12"" background=""imagenes/v1_BordeSup.gif""></TD>")
            End If
            writer.WriteLine("    <TD background=""imagenes/v1_BordeSup.gif"" class=""TituloControl""" + IIf(Me.VerTituloCentrado, " align='center'", "") + ">" + Me.TituloControl + "</TD>")

            If Me.PermitirMaximizar Then
                If Me.VerMaximizado Then
                    writer.WriteLine("    <TD align=""right""  background=""imagenes/v1_BordeSup.gif"" >")
                    writer.WriteLine("			<a id='Maximizar_" + Me.ID + "' title='Minimizar' onclick=""if(this.all['ImagenMaximizar_" + Me.ID + "'].alt=='Maximizar'){document.all['div_" + Me.ID + "'].style.display='';this.all['ImagenMaximizar_" + Me.ID + "'].alt='Minimizar';this.all['ImagenMaximizar_" + Me.ID + "'].title='Minimizar';this.all['ImagenMaximizar_" + Me.ID + "'].src='imagenes/contraer.gif';}else{document.all['div_" + Me.ID + "'].style.display='none';this.all['ImagenMaximizar_" + Me.ID + "'].alt='Maximizar';this.all['ImagenMaximizar_" + Me.ID + "'].title='Maximizar';this.all['ImagenMaximizar_" + Me.ID + "'].src='imagenes/expandir.gif';}return false;""><IMG id='ImagenMaximizar_" + Me.ID + "' title='Minimizar' alt='Minimizar' src='imagenes/contraer.gif' border='0' style='CURSOR: hand'></a></TD>")
                Else
                    writer.WriteLine("    <TD align=""right""  background=""imagenes/v1_BordeSup.gif"" >")
                    writer.WriteLine("			<a id='Maximizar_" + Me.ID + "' title='Maximizar' onclick=""if(this.all['ImagenMaximizar_" + Me.ID + "'].alt=='Maximizar'){document.all['div_" + Me.ID + "'].style.display='';this.all['ImagenMaximizar_" + Me.ID + "'].alt='Minimizar';this.all['ImagenMaximizar_" + Me.ID + "'].title='Minimizar';this.all['ImagenMaximizar_" + Me.ID + "'].src='imagenes/contraer.gif';}else{document.all['div_" + Me.ID + "'].style.display='none';this.all['ImagenMaximizar_" + Me.ID + "'].alt='Maximizar';this.all['ImagenMaximizar_" + Me.ID + "'].title='Maximizar';this.all['ImagenMaximizar_" + Me.ID + "'].src='imagenes/expandir.gif';}return false;""><IMG id='ImagenMaximizar_" + Me.ID + "' title='Maximizar' alt='Maximizar' src='imagenes/expandir.gif' border='0' style='CURSOR: hand'></a></TD>")
                End If
            Else
                writer.WriteLine("    <TD align=""right""  background=""imagenes/v1_BordeSup.gif"" ></TD>")
            End If

            If Me.VerRecuadro Then
                If Me.VerRecuadroRedondeado Then
                    writer.WriteLine("    <TD width=""12"" ><IMG alt="""" height=23 src=""imagenes/v1_ESD.gif"" width=12 ")
                    writer.WriteLine("      border=0 name=v1_ESD></TD>")
                Else
                    writer.WriteLine("    <TD width=""12"" height=23 background=""imagenes/v1_BordeSup.gif""></TD>")
                End If
            Else
                writer.WriteLine("    <TD width=""12"" background=""imagenes/v1_BordeSup.gif""></TD>")
            End If

            writer.WriteLine("    </TR>")
            writer.WriteLine("  <TR>")
            If Me.VerRecuadro Then
                If Me.VerRecuadroRedondeado Then
                    writer.WriteLine("    <TD width=""12"" background=""imagenes/v1_BordeIzq.gif""></TD>")
                Else
                    writer.WriteLine("    <TD width=""12""></TD>")
                End If
            Else
                writer.WriteLine("    <TD width=""12""></TD>")
            End If
            writer.WriteLine("    <TD colSpan=2>")
            writer.WriteLine("<div id='div_" + Me.ID + "' style='" + IIf(Me.PermitirMaximizar, IIf(Me.VerMaximizado, "", "DISPLAY: none;"), "") + "BACKGROUND-COLOR: transparent;WIDTH: " + IIf(Me.AnchoControl = 0, "100%", Me.AnchoControl.ToString() + "px") + "; " + IIf(Me.AltoControl = 0, "", "HEIGHT: " + Me.AltoControl.ToString() + "px; ") + "'>")
        End If
        MyBase.Render(writer)
        If Me.VerTitulo Then
            writer.WriteLine("</div>")
            writer.WriteLine("</TD>")
            If Me.VerRecuadro Then
                If Me.VerRecuadroRedondeado Then
                    writer.WriteLine("    <TD width=""12"" background=""imagenes/v1_BordeDer.gif""></TD>")
                Else
                    writer.WriteLine("    <TD width=""12""></TD>")
                End If
            Else
                writer.WriteLine("    <TD width=""12""></TD>")
            End If
            writer.WriteLine("    </TR>")
            If Me.VerRecuadro Then
                If Me.VerRecuadroRedondeado Then
                    writer.WriteLine("  <TR>")
                    writer.WriteLine("    <TD ><IMG alt="""" height=12 src=""imagenes/v1_EII.gif"" width=12 ")
                    writer.WriteLine("      border=0 name=v1_EII></TD>")
                    writer.WriteLine("    <TD colspan=""2"" background=""imagenes/v1_BordeInf.gif""><IMG height=12 alt="""" src=""imagenes/v1_BordeInf.gif"" width=6 border=0 name=v1_BordeInf></TD>")
                    writer.WriteLine("    <TD ><IMG alt="""" height=12 src=""imagenes/v1_EID.gif"" width=12 ")
                    writer.WriteLine("      border=0 name=v1_EID></TD>")
                    writer.WriteLine("</TR>")
                Else
                    writer.WriteLine("  <TR>")
                    writer.WriteLine("    <TD width=""12"" ></TD>")
                    writer.WriteLine("    <TD colspan=""2"" ></TD>")
                    writer.WriteLine("    <TD width=""12"" ></TD>")
                    writer.WriteLine("</TR>")
                End If
            End If
            writer.WriteLine("</TBODY>")
            writer.WriteLine("</TABLE>")
            writer.WriteLine("</div>")
        End If


    End Sub

    Public Sub ConfigurarOpcionMenu(ByVal aIdOpcionMenu As Integer)

        Me.idOpcionMenu = aIdOpcionMenu
        Dim lOpcion As SQLMembershipProvider.EL.OpcionesMenu = (New cOpcionesMenu).ObtenerOpcionesMenu(Me.idOpcionMenu)
        Me.AsignarTituloOpcion(lOpcion.CodigoMenu, lOpcion.UrlImagen)
        Me.GenerarOpcionesMenu(lOpcion.IdOpcionMenu)

    End Sub

#Region "Creacion Opciones Barra Menu"

    Public Sub GenerarOpcionesMenu(ByVal idOpcionMenu As Integer)
        Dim cMsProvider As New cmembershipProvider
        Dim lOpciones As SQLMembershipProvider.EL.listaOpcionesMenu = cMsProvider.ObtenerOpcionesHabilitadasPorUsuario(Me.idSistema, Me.ObtenerUsuario(), idOpcionMenu, False)
        If lOpciones.Count > 0 Then
            Dim lOpcionesBarra As New ListaOpcionesBarra
            For Each lOpcion As SQLMembershipProvider.EL.OpcionesMenu In lOpciones
                Dim lOpcionBarra As New OpcionesBarra
                lOpcionBarra.CommandName = lOpcion.CodigoMenu
                lOpcionBarra.AlternateText = lOpcion.CodigoMenu
                If lOpcion.UrlOpcion.Length > 1 Then
                    lOpcionBarra.AtributoKey = "onclick"
                    lOpcionBarra.AtributoValue = lOpcion.UrlOpcion
                End If
                If lOpcion.UrlImagen <> "" Then
                    lOpcionBarra.ImageUrl = lOpcion.UrlImagen
                End If
                lOpcionesBarra.Add(lOpcionBarra)
            Next
            Me.CargarOpciones(lOpcionesBarra)
        End If
    End Sub

    Public Sub CrearOpcion(ByVal CommandName As String, ByVal AlternateText As String, ByVal CausesValidation As Boolean, ByVal ImageUrl As String, Optional ByVal AtributoKey As String = "", Optional ByVal AtributoValue As String = "")
        Dim lucBarra As Object
        lucBarra = Me.Page.Master.FindControl("contenidoSplitter").FindControl("ucBarraNavegacion1")
        If lucBarra Is Nothing Then
            lucBarra = Me.FindControl("ucBarraNavegacion1")
        End If
        If lucBarra Is Nothing Then Return
        lucBarra.CrearOpcion(CommandName, AlternateText, CausesValidation, ImageUrl, AtributoKey, AtributoValue)
    End Sub

    Public Sub VerOpcion(ByVal CommandName As String, ByVal EsVisible As Boolean)
        Dim lucBarra As Object
        lucBarra = Me.Page.Master.FindControl("contenidoSplitter").FindControl("ucBarraNavegacion1")
        If lucBarra Is Nothing Then
            lucBarra = Me.FindControl("ucBarraNavegacion1")
        End If
        If lucBarra Is Nothing Then Return
        lucBarra.VerOpcion(CommandName, EsVisible)
    End Sub

    Public Sub HabilitarOpcion(ByVal CommandName As String, ByVal Enabled As Boolean)
        Dim lucBarra As Object
        lucBarra = Me.Page.Master.FindControl("contenidoSplitter").FindControl("ucBarraNavegacion1")
        If lucBarra Is Nothing Then
            lucBarra = Me.FindControl("ucBarraNavegacion1")
        End If
        If lucBarra Is Nothing Then Return
        lucBarra.HabilitarOpcion(CommandName, Enabled)
    End Sub

    Public Sub CargarOpciones()
        Dim lucBarra As Object
        lucBarra = Me.Page.Master.FindControl("contenidoSplitter").FindControl("ucBarraNavegacion1")
        If lucBarra Is Nothing Then
            lucBarra = Me.FindControl("ucBarraNavegacion1")
        End If
        If lucBarra Is Nothing Then Return
        lucBarra.Visible = True
        lucBarra.CargarOpciones()
    End Sub

    Public Sub CargarOpciones(ByVal aLista As ListaOpcionesBarra)
        Dim lucBarra As Object
        lucBarra = Me.Page.Master.FindControl("contenidoSplitter").FindControl("ucBarraNavegacion1")
        If lucBarra Is Nothing Then
            lucBarra = Me.FindControl("ucBarraNavegacion1")
        End If
        If lucBarra Is Nothing Then Return
        lucBarra.Visible = True
        lucBarra.CargarOpciones(aLista)
    End Sub

    Public Sub LimpiarOpciones()
        Dim lucBarra As Object
        lucBarra = Me.Page.Master.FindControl("contenidoSplitter").FindControl("ucBarraNavegacion1")
        If lucBarra Is Nothing Then
            lucBarra = Me.FindControl("ucBarraNavegacion1")
        End If
        If lucBarra Is Nothing Then Return
        lucBarra.Visible = False
        lucBarra.LimpiarOpciones()
    End Sub

    Public Overridable Sub EjecutarOpcion(ByVal CommandName As String)

    End Sub

#End Region

    Public Function ObtenerIdProveedorAF() As Decimal
        Dim lUsuario As USUARIO
        lUsuario = (New cUSUARIO).ObtenerUSUARIO(Me.ObtenerUsuario())
        If lUsuario Is Nothing Then Return -1
        Return lUsuario.ID_PROVEEDOR_AF
    End Function

    Public Function ObtenerIdParticipante() As Decimal
        Dim lUsuario As USUARIO
        lUsuario = (New cUSUARIO).ObtenerUSUARIO(Me.ObtenerUsuario())
        If lUsuario Is Nothing Then Return -1
        Return lUsuario.ID_PARTICIPANTE
    End Function

    Public Function ObtenerIdSitioCapacitacion() As Decimal
        Dim lUsuario As USUARIO
        lUsuario = (New cUSUARIO).ObtenerUSUARIO(Me.ObtenerUsuario())
        If lUsuario Is Nothing Then Return -1
        Return lUsuario.ID_SITIO_CAPACITACION
    End Function
End Class

<Serializable()> Public Class OpcionesBarra
    Inherits EL.entidadBase

    Private _ImageUrl As String
    Public Property ImageUrl() As String
        Get
            Return Me._ImageUrl
        End Get
        Set(ByVal value As String)
            Me._ImageUrl = value
        End Set
    End Property

    Private _AlternateText As String
    Public Property AlternateText() As String
        Get
            Return Me._AlternateText
        End Get
        Set(ByVal value As String)
            Me._AlternateText = value
        End Set
    End Property

    Private _CausesValidation As Boolean
    Public Property CausesValidation() As Boolean
        Get
            Return Me._CausesValidation
        End Get
        Set(ByVal value As Boolean)
            Me._CausesValidation = value
        End Set
    End Property

    Private _CommandName As String
    Public Property CommandName() As String
        Get
            Return Me._CommandName
        End Get
        Set(ByVal value As String)
            Me._CommandName = value
        End Set
    End Property

    Private _AtributoKey As String
    Public Property AtributoKey() As String
        Get
            Return Me._AtributoKey
        End Get
        Set(ByVal value As String)
            Me._AtributoKey = value
        End Set
    End Property

    Private _AtributoValue As String
    Public Property AtributoValue() As String
        Get
            Return Me._AtributoValue
        End Get
        Set(ByVal value As String)
            Me._AtributoValue = value
        End Set
    End Property

End Class

<Serializable()> Public Class ListaOpcionesBarra
    Inherits List(Of OpcionesBarra)
End Class

Public Enum RolUsuario As Integer
    Administrador = 1
    Proveedor = 2
    CentroCapacitador = 3
    Participante = 4
    TecnicoCentroHTP = 5
    JefeHTP = 6
    AsistenteGFI = 7
    GerenteGFI = 8
    TecnicoGFI = 9
    AplicarRecalculoMontoPagarInforme = 10
End Enum

'Public Class RolDeUsuario
'    Public Const Administrador As String = "Administrador"
'    Public Const Proveedor As String = "Proveedor"
'    Public Const CentroCapacitador As String = "CentroCapacitador"
'    Public Const Participante As String = "Participante"
'    Public Const TecnicoCentroHTP As String = "TecnicoCentroHTP"
'    Public Const JefeHTP As String = "JefeHTP"
'    Public Const AsistenteGFI As String = "AsistenteGFI"
'    Public Const GerenteGFI As String = "GerenteGFI"
'End Class
