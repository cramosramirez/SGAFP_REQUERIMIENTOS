<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCriteriosUsuario.ascx.vb" Inherits="controles_ucCriteriosUsuario" %>
<%@ Register assembly="SGAFP_WebUC" namespace="SGAFP.WebUC" tagprefix="cc1" %>
<style type="text/css">
        .TextoInfo
        {
            font-family: Verdana, Arial;
            font-size: 8pt;
        }
        .TextoCelda
        {
            font-family: Verdana, Arial;
            font-size: 8pt;    
            width: 125px;        
        }        
</style>
<table cellpadding="0" cellspacing="0" border="0" >
    <tr id="Tr1" runat="server">
        <td class="TextoCelda">
            PROVEEDOR:     
        </td>
        <td style="font-size: small;" class="TextoInfo">
            <cc1:ddlPROVEEDOR_AF ID="ddlPROVEEDOR_AF1" runat="server" AutoPostBack="True" class="TextoInfo">
            </cc1:ddlPROVEEDOR_AF>
        </td>        
    </tr>
    <tr id="Tr2" runat="server">
        <td class="TextoCelda">
            CENTRO: 
        </td>
        <td class="TextoInfo">
            <cc1:ddlSITIO_CAPACITACION ID="ddlSITIO_CAPACITACION1" runat="server" class="TextoInfo">
            </cc1:ddlSITIO_CAPACITACION>
        </td>
    </tr>
    <tr id="Tr3" runat="server">
        <td class="TextoCelda">
            USUARIO:
        </td>
        <td>
            <asp:TextBox ID="USUARIOTextBox" runat="server" Columns="8" MaxLength="200"
               class="TextoInfo" Width="261px" ></asp:TextBox>
        </td>      
    </tr>                                   
    <tr id="Tr4" runat="server">
        <td class="TextoCelda">
            CORREO:
        </td>
        <td>
            <asp:TextBox ID="CORREOTextBox" runat="server" Columns="8" MaxLength="200"
               class="TextoInfo" Width="261px" ></asp:TextBox>
        </td>      
    </tr>                                   
</table>    