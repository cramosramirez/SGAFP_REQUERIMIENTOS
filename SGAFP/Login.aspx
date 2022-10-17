<%@ Page Title="" Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Login" %>

<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>    
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">    
        <dx:ASPxCallbackPanel runat="server" ID="cpRecuperarClave" ClientInstanceName="cpRecuperarClave" ShowLoadingPanel="false"  > 
        <ClientSideEvents EndCallback="function(s,e){
                                            popupRecuperarClave.SetSize(300,0);
                                            popupRecuperarClave.UpdatePosition();
                                       }" /> 
        <PanelCollection>        
            <dx:PanelContent ID="PanelContent1" runat="server">   
            
                <dx:ASPxPopupControl ID="popupRecuperarClave" Modal="true" runat="server" 
                    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" PopupElementID="RecuperarClave" 
                    AllowResize="False" DragElement="Header" HeaderStyle-Font-Bold="true" HeaderText="Restablecer clave"   
                    AllowDragging="True" ClientInstanceName="popupRecuperarClave" ShowShadow="true"
                    CloseAction="CloseButton">  
                     <ContentCollection>
                         <dx:PopupControlContentControl ID="PopupControlContentControl2" runat="server" >                             
                            <table width="100%">
                                <tr>
                                    <td>
                                        <dx:ASPxLabel ID="lblMensaje" ClientInstanceName="lblMensaje"  runat="server" Font-Names="Arial,Tahoma" Font-Size="X-Small" Font-Bold="true" />                                        
                                    </td>
                               </tr>
                               <tr>
                                    <td>
                                       <dx:ASPxTextBox ID="txtUsuario" ClientInstanceName="txtUsuario" MaxLength="100" runat="server" Width="100%" Text=""
                                        ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Usuario es requerido." />
                                    </td>
                                </tr>
                                <tr>                                    
                                    <td style="text-align:center;">
                                        <table>
                                            <tr>
                                                <td style="width:100px">
                                                    <dx:ASPxButton ID="btnAceptar" ClientInstanceName="btnAceptar"  Text="Aceptar" Font-Names="Arial,Tahoma" Font-Size="X-Small" Font-Bold="true"
                                                          AutoPostBack="false" CausesValidation="True" runat="server" Width="80px" >
                                                           <ClientSideEvents  Click="function(s, e){                                                                               
                                                                                        if(cpRecuperarClave.cpResultCallback == undefined){                                                                                                                                                                        
                                                                                            if(txtUsuario.GetText()!=''){
                                                                                                cpRecuperarClave.PerformCallback(txtUsuario.GetValue());
                                                                                            }                                                                                
                                                                                        }                                                                                                                                                                             
                                                                                     }"  />
                                                    </dx:ASPxButton>
                                                </td>
                                                <td style="width:100px">
                                                    <dx:ASPxButton ID="btnCancelar" Text="Cerrar" CausesValidation="false" Font-Names="Arial,Tahoma" Font-Size="X-Small" Font-Bold="true"
                                                          AutoPostBack="false" runat="server" Width="80px" >
                                                           <ClientSideEvents Click="function(s,e){popupRecuperarClave.Hide()}"  />
                                                    </dx:ASPxButton>
                                                </td>
                                            </tr>
                                        </table>                                        
                                    </td>
                                </tr>
                            </table> 
                         </dx:PopupControlContentControl>
                     </ContentCollection>
                </dx:ASPxPopupControl>  
                
            </dx:PanelContent>
        </PanelCollection>   
    </dx:ASPxCallbackPanel>
    <table style="width: 96%">
   <tr>
        <td style="font-family:'Agency FB'; font-size:25px" align="center">
            <b>Bienvenidos al Sistema de Gestión y Administración de la Formación Profesional(SGAFP) del INSAFORP.</b></td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>    
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>        
        <td align="center">
            <table border="0" >
                <tr>
                    <td>
                        <dx:ASPxImage ImageUrl="~/imagenes/insaforpLogin.png"  runat="server" ID="imgPresentacion" />  
                    </td>
                    <td style="border: 1px solid #ddd;" >
                          <asp:Login ID="Login1" runat="server" BorderPadding="4" Font-Names="Verdana" 
                            Font-Size="0.8em" ForeColor="#333333" Height="118px" 
                            DestinationPageUrl="~/Default.aspx" DisplayRememberMe="True"  >
                            <TextBoxStyle Font-Size="0.8em" />
                            <LoginButtonStyle Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
                            <LayoutTemplate>
                                <table border="0" cellpadding="0" cellspacing="0" >
                                    <tr>
                                        <td>
                                            <table border="0" width="100%" style="width:100%">
                                                <tr>
                                                    <td valign="top">                                            
                                                        <dx:ASPxLabel ID="UserNameLabel" runat="server" Font-Size="13px"  AssociatedControlID="UserName" Text="Usuario:" CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx" ></dx:ASPxLabel>
                                                    </td>
                                                    <td >                                            
                                                        <dx:ASPxTextBox ID="UserName"  runat="server"  Font-Size="13px" Width="150px" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" >                                               
                                                            <ValidationSettings>
                                                                <ErrorFrameStyle ImageSpacing="4px">
                                                                    <ErrorTextPaddings PaddingLeft="4px" />
                                                                </ErrorFrameStyle>
                                                            </ValidationSettings>
                                                        </dx:ASPxTextBox>
                                                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" 
                                                            ControlToValidate="UserName" ErrorMessage="Escriba el usuario" 
                                                            ToolTip="Escriba el usuario" ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="No se permite el uso de espacios o caracteres especiales en el Usuario"
                                                            ControlToValidate="UserName" Text="*" ValidationExpression="^[a-zA-Z0-9@._-]+$"
                                                            Display="Dynamic"></asp:RegularExpressionValidator>    
                                                    </td>
                                                </tr>
                                                <tr>
                                                     <td valign="top">                                            
                                                        <dx:ASPxLabel ID="ASPxLabel1" runat="server" Font-Size="13px" AssociatedControlID="Password" Text="Clave:" CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx" ></dx:ASPxLabel>
                                                    </td>
                                                    <td style="width: 158px">
                                                        <dx:ASPxTextBox ID="Password" runat="server" Font-Size="13px" Password="True" Width="150px" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" >                                               
                                                            <ValidationSettings>
                                                                <ErrorFrameStyle ImageSpacing="4px">
                                                                    <ErrorTextPaddings PaddingLeft="4px" />
                                                                </ErrorFrameStyle>
                                                            </ValidationSettings>
                                                        </dx:ASPxTextBox>                                         
                                                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" 
                                                            ControlToValidate="Password" ErrorMessage="Escriba la clave" 
                                                            ToolTip="Escriba la clave" ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>                                                                                
                                                <%--<tr>
                                                    <td colspan="2" align="center">
                                                        <asp:CheckBox ID="RememberMe" runat="server" Text="Recordar mi Cuenta." />
                                                    </td>
                                                </tr>  --%>                                
                                                <tr>
                                                    <td align="center" colspan="2" style="color:Red;">
                                                        <asp:Literal ID="FailureText"  runat="server" ></asp:Literal>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="center" colspan="2">
                                                        <dx:ASPxButton ID="LoginButton" runat="server" Width="200px"  CommandName="Login" Text="Ingresar" CssFilePath="~/App_Themes/SoftOrange/{0}/styles.css" CssPostfix="SoftOrange" SpriteCssFilePath="~/App_Themes/SoftOrange/{0}/sprite.css"  />
                                                        <%--<asp:Button ID="LoginButton" runat="server" BackColor="#FFFBFF" 
                                                            BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" CommandName="Login" 
                                                            Font-Names="Verdana" Font-Size="0.9em" ForeColor="#284775" Text="Ingresar" 
                                                            ValidationGroup="Login1" Width="62px" />--%>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="height:10px" ></td>
                                                </tr>
                                                <tr id="trRecuperarClave" runat="server"  >
                                                    <td colspan="2" align="center">
                                                        <asp:LinkButton runat="server" ID="RecuperarClave" Text="&#191;Olvidó su clave?"   
                                                            OnClientClick="    
                                                                           delete cpRecuperarClave.cpResultCallback;                                                           
                                                                           lblMensaje.SetText('Para restablecer la clave, escribe el usuario con el que accesas al sistema.'); 
                                                                           txtUsuario.SetEnabled(true);
                                                                           txtUsuario.SetText(''); 
                                                                           txtUsuario.SetVisible(true);
                                                                           btnAceptar.SetVisible(true);
                                                                           popupRecuperarClave.Show();
                                                                           popupRecuperarClave.SetSize(300,0);
                                                                           popupRecuperarClave.UpdatePosition();
                                                                           return false;" />   
                                                    </td>
                                                </tr>     
                                            </table>


                                        </td>
                                    </tr>
                                </table>
                            </LayoutTemplate>
                            <InstructionTextStyle Font-Italic="True" ForeColor="Black" HorizontalAlign="Center" />
                            <TitleTextStyle Font-Bold="True" Font-Size="0.9em"  
                                ForeColor="White" />    
                        </asp:Login>
                    </td>
                </tr>
            </table>
          

        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>

