<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleUSUARIO.ascx.vb" Inherits="controles_ucVistaDetalleUSUARIO" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<asp:Menu
    ID="Menu1"
    runat="server"
    Orientation="Horizontal" 
    BackColor="#B5C7DE" 
    DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" 
    ForeColor="#284E98" StaticSubMenuIndent="10px" 
    >
    <StaticSelectedStyle  CssClass="TabSeleccionado" />
    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <DynamicHoverStyle BackColor="#284E98" ForeColor="White"/>
    <DynamicMenuStyle BackColor="#B5C7DE" />
    <DynamicSelectedStyle BackColor="#507CD1" />
    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <StaticHoverStyle BackColor="#284E98" ForeColor="White"/>
    <Items>
        <asp:MenuItem Text="Detalle" Value="0" Selected="true"></asp:MenuItem>
        <asp:MenuItem Text="Autenticacion" Value="1"></asp:MenuItem>
        <asp:MenuItem Text="Roles" Value="2"></asp:MenuItem>
    </Items>
</asp:Menu>
<asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
    <asp:View ID="View1" runat="server">
    <table cellpadding="0" cellspacing="0" width="90%"><tr valign="top"><td class="TabArea">
       <TABLE ID="VistaDetalle" border="0" cellPadding="0" cellSpacing="0" 
            width="100%">
            <tr id="trUSUARIO" runat="server">
            <td width="10">
            </td>
            <td align="right">
                <asp:Label ID="lblUSUARIO" runat="server" CssClass="Normal">Usuario:</asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUSUARIO" runat="server" CssClass="TextoNormalIzquierda" 
                MaxLength="100" Width="70px"></asp:TextBox>
            </td>
            <td width="10">
            </td>
        </tr>
            <tr id="trID_PROVEEDOR_AF" runat="server">
            <td width="10">
            </td>
            <td align="right">
                <asp:Label ID="lblID_PROVEEDOR_AF" runat="server" CssClass="Normal">Proveedor af:</asp:Label>
            </td>
            <td>
                <cc1:ddlPROVEEDOR_AF ID="ddlPROVEEDOR_AF1" runat="server" 
                AutoPostBack="True" CssClass="DDLClass">
                </cc1:ddlPROVEEDOR_AF>
            </td>
            <td width="10">
            </td>
        </tr>
            <tr id="trID_SITIO_CAPACITACION" runat="server">
            <td width="10">
            </td>
            <td align="right">
                <asp:Label ID="lblID_SITIO_CAPACITACION" runat="server" CssClass="Normal">Sitio capacitacion:</asp:Label>
            </td>
            <td>
                <cc1:ddlSITIO_CAPACITACION ID="ddlSITIO_CAPACITACION1" runat="server" 
                CssClass="DDLClass">
                </cc1:ddlSITIO_CAPACITACION>
            </td>
            <td width="10">
            </td>
        </tr>
            <tr id="trID_PARTICIPANTE" runat="server">
            <td width="10">
            </td>
            <td align="right">
                <asp:Label ID="lblID_PARTICIPANTE" runat="server" CssClass="Normal">Participante:</asp:Label>
            </td>
            <td>
                <cc1:ddlPARTICIPANTE ID="ddlPARTICIPANTE1" runat="server" 
                CssClass="DDLClass">
                </cc1:ddlPARTICIPANTE>
            </td>
            <td width="10">
            </td>
        </tr>
        </TABLE>
    </td></tr></table>
    </asp:View>
    <asp:View ID="View2" runat="server">
    <table cellpadding="0" cellspacing="0" width="90%"><tr valign="top"><td class="TabArea">
        &nbsp;</td></tr></table>
    </asp:View>
    <asp:View ID="View3" runat="server">
    <table cellpadding="0" cellspacing="0" width="90%"><tr valign="top"><td class="TabArea">
    </td></tr></table>
    </asp:View>
</asp:MultiView>

<asp:LoginView ID="LoginView1" runat="server">
</asp:LoginView>


