<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleESTADO_ACCION_FORMATIVA.ascx.vb" Inherits="controles_ucVistaDetalleESTADO_ACCION_FORMATIVA" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trCODIGO_ESTADO_AF">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblCODIGO_ESTADO_AF" runat="server">Codigo estado af:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtCODIGO_ESTADO_AF" runat="server" Width="70px" MaxLength="2"></asp:textbox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNOMBRE_ESTADO_AF">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblNOMBRE_ESTADO_AF" runat="server">Nombre estado af:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtNOMBRE_ESTADO_AF" runat="server" Width="100px" MaxLength="40"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trESTADO_INICIAL">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblESTADO_INICIAL" runat="server">Estado inicial:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtESTADO_INICIAL" runat="server" Width="100px"></asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorESTADO_INICIAL" runat="server" ControlToValidate="txtESTADO_INICIAL"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trPERMITE_INSCRIPCION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblPERMITE_INSCRIPCION" runat="server">Permite inscripcion:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtPERMITE_INSCRIPCION" runat="server" Width="100px"></asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorPERMITE_INSCRIPCION" runat="server" ControlToValidate="txtPERMITE_INSCRIPCION"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trESTADO_FINAL">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblESTADO_FINAL" runat="server">Estado final:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtESTADO_FINAL" runat="server" Width="100px"></asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorESTADO_FINAL" runat="server" ControlToValidate="txtESTADO_FINAL"
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
