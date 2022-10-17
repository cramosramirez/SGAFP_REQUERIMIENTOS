<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCriteriosParticipanteExoneradoDoc.ascx.vb" Inherits="controles_ucCriteriosParticipanteExoneradoDoc" %>
<%@ Register assembly="SGAFP_WebUC" namespace="SGAFP.WebUC" tagprefix="cc1" %>
    <style type="text/css">
        .TextoInfo
        {
            font-family:Verdana, Arial;
            font-size: 8pt;            
        }
        .TextoCelda
        {
            font-family:Arial, Verdana;
            font-size: 8pt;
            padding-right:5px;
            padding-left:10px;              
        }        
    </style>
<table border="0" cellpadding="2" cellspacing="0">
        <tr id="trProveedor" runat="server">
            <td class="TextoCelda" style="width:90px" >
                PROVEEDOR:     
            </td>
            <td style="font-size: small;" class="TextoInfo">
                <cc1:ddlPROVEEDOR_AF ID="ddlPROVEEDOR_AF1" runat="server" AutoPostBack="True" class="TextoInfo">
                </cc1:ddlPROVEEDOR_AF>
                </td>            
        </tr>
        <tr id="trCentroFormacion" runat="server">
            <td class="TextoCelda">
                CENTRO: 
            </td>
            <td class="TextoInfo">
                <cc1:ddlSITIO_CAPACITACION ID="ddlSITIO_CAPACITACION1" runat="server" class="TextoInfo">
                </cc1:ddlSITIO_CAPACITACION>
                </td>           
        </tr>     
        <tr id="trEstado" runat="server">
            <td class="TextoCelda">ESTADO:</td>
            <td><asp:DropDownList ID="ddlEstado" runat="server" class="TextoInfo" >
                <asp:ListItem Value="-1">[Todos]</asp:ListItem>
                <asp:ListItem Value="0">PENDIENTE DE EVALUAR</asp:ListItem>
                <asp:ListItem Value="1">APROBADO</asp:ListItem>
                <asp:ListItem Value="2">RECHAZADO</asp:ListItem>
                </asp:DropDownList>
            </td>                        
        </tr>   
</table>