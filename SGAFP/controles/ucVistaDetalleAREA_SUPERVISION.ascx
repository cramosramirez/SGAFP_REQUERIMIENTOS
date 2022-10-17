<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleAREA_SUPERVISION.ascx.vb" Inherits="controles_ucVistaDetalleAREA_SUPERVISION" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_AREA_SUPERVISION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_AREA_SUPERVISION" runat="server">Id area supervision:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoLlaveDerecha" id="txtID_AREA_SUPERVISION" runat="server" ReadOnly="True" Width="70px"></asp:textbox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trAREA_SUPERVISION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblAREA_SUPERVISION" runat="server">Area supervision:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtAREA_SUPERVISION" runat="server" Width="100px" MaxLength="60"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trSANCIONATORIA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblSANCIONATORIA" runat="server">Sancionatoria:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtSANCIONATORIA" runat="server" Width="100px" MaxLength="1"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trMONTO_SANCION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblMONTO_SANCION" runat="server">Monto sancion:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtMONTO_SANCION" runat="server" Width="100px"></asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorMONTO_SANCION" runat="server" ControlToValidate="txtMONTO_SANCION"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTIEMPO_SANCION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblTIEMPO_SANCION" runat="server">Tiempo sancion:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtTIEMPO_SANCION" runat="server" Width="100px"></asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorTIEMPO_SANCION" runat="server" ControlToValidate="txtTIEMPO_SANCION"
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
