<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCriteriosOfertaFormativa.ascx.vb" Inherits="controles_ucCriteriosOfertaFormativa" %>
<%@ Register assembly="SGAFP_WebUC" namespace="SGAFP.WebUC" tagprefix="cc1" %>
<table cellpadding="0" cellspacing="0" style="width: 689px">
    <tr>
        <td class="style1" style="font-size: x-small">
            Proveedor:</td>
        <td>
            <cc1:ddlPROVEEDOR_AF ID="ddlPROVEEDOR_AF1" runat="server">
            </cc1:ddlPROVEEDOR_AF>
        </td>
        <td style="font-size: x-small">
            Ejercicio:</td>
        <td>
            <cc1:ddlEJERCICIO ID="ddlEJERCICIO1" runat="server">
            </cc1:ddlEJERCICIO>
        </td>
    </tr>
    <tr>
        <td class="style1" style="font-size: x-small">
            Área de Formación:</td>
        <td>
            <cc1:ddlAREA_FORMACION ID="ddlAREA_FORMACION1" runat="server">
            </cc1:ddlAREA_FORMACION>
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style1" style="font-size: x-small">
            Curso o Tema:</td>
        <td>
            <asp:TextBox ID="NOMBRE_CURSOTextBox" runat="server" Width="179px" 
                Font-Size="X-Small" CssClass="NormalUPPER"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    </table>


            