<%@ Page Title="" Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfCambioClave.aspx.vb" Inherits="wfCambioClave" %>
<%@ Register assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxRoundPanel" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPanel" tagprefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <dx:ASPxRoundPanel ID="ASPxRoundPanel2" runat="server" Width="400px" EnableDefaultAppearance="False"
        EnableTheming="False" SkinID="None" HeaderText="Cambio de Clave"
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
<asp:ChangePassword ID="ChangePassword1" runat="server" 
    CancelDestinationPageUrl="~/Default.aspx" 
    ChangePasswordButtonText="Cambiar Clave" 
    ChangePasswordTitleText="" 
    ConfirmNewPasswordLabelText="Confirmación de Clave:" 
    ConfirmPasswordCompareErrorMessage="Clave y confirmación tienen que ser iguales" 
    ConfirmPasswordRequiredErrorMessage="Confirmación de clave es requerido" 
    ContinueDestinationPageUrl="~/Default.aspx" ForeColor="#333333" Height="118px" 
    NewPasswordLabelText="Nueva Clave:" 
    NewPasswordRequiredErrorMessage="Nueva clave es requerida." 
    PasswordLabelText="Clave Actual:" 
    PasswordRequiredErrorMessage="Clave es requerida." 
    SuccessText="¡Su clave ha sido cambiada!" 
    SuccessTitleText="Cambio de clave completo" Width="463px">
            <ChangePasswordButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" 
            BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" 
            ForeColor="#284775" />
        <CancelButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" 
            BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" 
            ForeColor="#284775" />
        <ContinueButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" 
            BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" 
            ForeColor="#284775" />
            <ChangePasswordTemplate>
                <table border="0" cellpadding="1" cellspacing="0" 
                    style="border-collapse:collapse;">
                    <tr>
                        <td>
                            <table border="0" cellpadding="0" style="height:118px;width:463px;">
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="CurrentPasswordLabel" runat="server" 
                                            AssociatedControlID="CurrentPassword">Clave Actual:</asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="CurrentPassword" runat="server" TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="CurrentPasswordRequired" runat="server" 
                                            ControlToValidate="CurrentPassword" ErrorMessage="Clave es requerida." 
                                            ToolTip="Clave es requerida." ValidationGroup="ctl00$ChangePassword1">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="NewPasswordLabel" runat="server" 
                                            AssociatedControlID="NewPassword">Nueva Clave:</asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="NewPassword" runat="server" TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="NewPasswordRequired" runat="server" 
                                            ControlToValidate="NewPassword" ErrorMessage="Nueva clave es requerida." 
                                            ToolTip="Nueva clave es requerida." ValidationGroup="ctl00$ChangePassword1">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="ConfirmNewPasswordLabel" runat="server" 
                                            AssociatedControlID="ConfirmNewPassword">Confirmación de Clave:</asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="ConfirmNewPassword" runat="server" TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="ConfirmNewPasswordRequired" runat="server" 
                                            ControlToValidate="ConfirmNewPassword" 
                                            ErrorMessage="Confirmación de clave es requerido" 
                                            ToolTip="Confirmación de clave es requerido" 
                                            ValidationGroup="ctl00$ChangePassword1">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" colspan="2">
                                        <asp:CompareValidator ID="NewPasswordCompare" runat="server" 
                                            ControlToCompare="NewPassword" ControlToValidate="ConfirmNewPassword" 
                                            Display="Dynamic" ErrorMessage="Clave y confirmación tienen que ser iguales" 
                                            ValidationGroup="ctl00$ChangePassword1"></asp:CompareValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" colspan="2" style="color:Red;">
                                        <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" colspan="2" >
                                        <asp:Button ID="ChangePasswordPushButton" runat="server" BackColor="#FFFBFF" 
                                            BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" 
                                            CommandName="ChangePassword" Font-Names="Verdana" Font-Size="0.8em" 
                                            ForeColor="#284775" Text="Cambiar Clave" 
                                            ValidationGroup="ctl00$ChangePassword1" />
                                        &nbsp;
                                        <asp:Button ID="CancelPushButton" runat="server" BackColor="#FFFBFF" 
                                            BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" 
                                            CausesValidation="False" CommandName="Cancel" Font-Names="Verdana" 
                                            Font-Size="0.8em" ForeColor="#284775" Text="Cancelar" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </ChangePasswordTemplate>
</asp:ChangePassword>
            </dx:PanelContent>
        </PanelCollection>
        <HeaderContent>
            <BackgroundImage ImageUrl="~/imagenes/fondoTituloPanel.png" Repeat="RepeatX" VerticalPosition="top" />
        </HeaderContent>
    </dx:ASPxRoundPanel>
</asp:Content>

