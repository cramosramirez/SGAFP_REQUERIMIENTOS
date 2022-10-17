<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleOPCION_MENU.ascx.vb" Inherits="controles_ucVistaDetalleOPCION_MENU" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_OPCION_MENU">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_OPCION_MENU" runat="server">Id opcion menu:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoLlaveDerecha" id="txtID_OPCION_MENU" runat="server" ReadOnly="True" Width="70px"></asp:textbox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trOPCION_MENU">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblOPCION_MENU" runat="server">Opcion menu:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtOPCION_MENU" runat="server" Width="100px" MaxLength="60"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trOPCION_SISTEMA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblOPCION_SISTEMA" runat="server">Opcion sistema:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtOPCION_SISTEMA" runat="server" Width="100px" MaxLength="1"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trURL">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblURL" runat="server">Url:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtURL" runat="server" Width="100px" MaxLength="200"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trPAGINA_HTML">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblPAGINA_HTML" runat="server">Pagina html:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtPAGINA_HTML" runat="server" Width="100px" MaxLength="200"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trOBJETO_USUARIO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblOBJETO_USUARIO" runat="server">Objeto usuario:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtOBJETO_USUARIO" runat="server" Width="100px" MaxLength="200"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNOTAS">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblNOTAS" runat="server">Notas:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtNOTAS" runat="server" Width="100px" MaxLength="255"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
</TABLE>
