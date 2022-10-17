<%@ Page Title="" Language="VB" MasterPageFile="~/principal.master" CodeFile="wfRecuperarClave.aspx.vb" Inherits="wfRecuperarClave" %>

<%@ Register assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxRoundPanel" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPanel" tagprefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <table cellpadding="0" cellspacing="0" border="0" width="100%" style="width:100%;height:100%">
<tr valign="top" align="center" >
<td>
    <dx:ASPxRoundPanel ID="ASPxRoundPanel2" runat="server" Width="400px" EnableDefaultAppearance="False"
        EnableTheming="False" SkinID="None" HeaderText="Recuperar Clave"
        HeaderStyle-HorizontalAlign="Center" CssFilePath="~/App_Themes/MacOS/{0}/styles.css"
        CssPostfix="MacOS">
        <ContentPaddings Padding="2px" PaddingBottom="8px" />
        <BottomRightCorner Height="23px" Width="23px" Url="~/imagenes/esquinaInferiorDerecha.png">
        </BottomRightCorner>
        <BottomLeftCorner Height="23px" Width="23px" Url="~/imagenes/esquinaInferiorIzquierda.png">
        </BottomLeftCorner>
        <LeftEdge>
            <BackgroundImage ImageUrl="~/imagenes/bordeIzquierdo.png" />
        </LeftEdge>
        <Border BorderStyle="None" />
        <BottomEdge>
            <BackgroundImage ImageUrl="~/imagenes/bordeInferior.png" />
        </BottomEdge>
        <RightEdge>
            <BackgroundImage ImageUrl="~/imagenes/bordeDerecho.png" />
        </RightEdge>
        <HeaderRightEdge>
            <BackgroundImage ImageUrl="~/imagenes/esquinaSuperiorDerecha.png" VerticalPosition="top" />
        </HeaderRightEdge>
        <HeaderLeftEdge>
            <BackgroundImage ImageUrl="~/imagenes/esquinaSuperiorIzquierda.png" VerticalPosition="top" />
        </HeaderLeftEdge>
        <HeaderStyle Height="27px" HorizontalAlign="Center">
            <Paddings PaddingTop="4px" />
            <Border BorderStyle="None" />
        </HeaderStyle>
        <Content>
            <BackgroundImage ImageUrl="~/imagenes/fondoPanel.png" />
        </Content>
        <PanelCollection>
            <dx:PanelContent ID="PanelContent1" runat="server" Font-Size="Medium">
                <asp:PasswordRecovery ID="PasswordRecovery1" runat="server" BorderStyle="None" Font-Names="Verdana"
                    Font-Size="0.8em" ForeColor="#333333" Height="118px" Width="400px">
                    <MailDefinition Priority="High" 
                        Subject="Envío de Contraseña - Sistema de Gestión y Administración de la Formación Profesional" 
                        IsBodyHtml="false" From="cramos@insaforp.org.sv">
                    </MailDefinition>
                    <SubmitButtonStyle Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />                  
                    <UserNameTemplate>
                        <table border="0" cellpadding="1" cellspacing="0" style="border-collapse: collapse;"
                            align="center">
                            <tr>
                                <td>
                                    <table border="0" cellpadding="0">
                                        <tr>
                                            <td align="center" colspan="2">
                                                &#191;Olvidó su clave?
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="center" colspan="2">
                                                Escriba su usuario para recibir su clave por correo.
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right">
                                                <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Usuario:</asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="UserName" runat="server" SkinID="TextBox"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName"
                                                    ErrorMessage="El nombre de usuario es obligatorio." ToolTip="El nombre de usuario es obligatorio."
                                                    ValidationGroup="PasswordRecovery1">*</asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="center" colspan="2" style="color: Red;">
                                                <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="center" colspan="2">
                                                <asp:Button ID="SubmitButton" runat="server" BackColor="#FFFBFF" BorderColor="#CCCCCC"
                                                    BorderStyle="Solid" BorderWidth="1px" CommandName="Submit" Font-Names="Verdana"
                                                    Font-Size="0.9em" ForeColor="#284775" Text="Enviar" ValidationGroup="PasswordRecovery1"
                                                    Width="62px" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </UserNameTemplate>
                    <SuccessTemplate>
                        <table border="0" cellpadding="4" cellspacing="0" style="border-collapse: collapse;">
                            <tr>
                                <td>
                                    <table border="0" cellpadding="0" style="height: 118px; width: 400px;">
                                        <tr>
                                            <td style="text-align: center">
                                                <asp:Label ID="MsgResultado" runat="server">Se ha enviado la contraseña.</asp:Label>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </SuccessTemplate>
                </asp:PasswordRecovery>
            </dx:PanelContent>
        </PanelCollection>
        <HeaderContent>
            <BackgroundImage ImageUrl="~/imagenes/fondoTituloPanel.png" Repeat="RepeatX" VerticalPosition="top" />
        </HeaderContent>
    </dx:ASPxRoundPanel>
</td>
</tr>
</table>
</asp:Content>

