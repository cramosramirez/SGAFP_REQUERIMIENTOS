<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleGRUPO_USUARIO.ascx.vb" Inherits="controles_ucVistaDetalleGRUPO_USUARIO" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_GRUPO_USUARIO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_GRUPO_USUARIO" runat="server">Id grupo usuario:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoLlaveDerecha" id="txtID_GRUPO_USUARIO" runat="server" ReadOnly="True" Width="70px"></asp:textbox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trROL_USUARIO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblROL_USUARIO" runat="server">Rol usuario:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtROL_USUARIO" runat="server" Width="100px" MaxLength="40"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNIVEL">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblNIVEL" runat="server">Nivel:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtNIVEL" runat="server" Width="100px"></asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorNIVEL" runat="server" ControlToValidate="txtNIVEL"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
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
