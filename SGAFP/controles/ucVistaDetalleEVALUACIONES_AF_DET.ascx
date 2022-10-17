<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleEVALUACIONES_AF_DET.ascx.vb" Inherits="controles_ucVistaDetalleEVALUACIONES_AF_DET" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_EVALUACION_DET">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_EVALUACION_DET" runat="server">Id evaluacion det:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoLlaveDerecha" id="txtID_EVALUACION_DET" runat="server" ReadOnly="True" Width="70px"></asp:textbox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_PARTICIPANTE">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_PARTICIPANTE" runat="server">Participante:</asp:label></TD>
		<TD>
			<cc1:ddlPARTICIPANTE id="ddlPARTICIPANTE1" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlPARTICIPANTE></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_EVALUACION_AF">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_EVALUACION_AF" runat="server">Evaluacion af:</asp:label></TD>
		<TD>
			<cc1:ddlEVALUACION_AF id="ddlEVALUACION_AF1" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlEVALUACION_AF></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNOTA_OBTENIDA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblNOTA_OBTENIDA" runat="server">Nota obtenida:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtNOTA_OBTENIDA" runat="server" Width="100px"></asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorNOTA_OBTENIDA" runat="server" ControlToValidate="txtNOTA_OBTENIDA"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNOTAS">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblNOTAS" runat="server">Observacion:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtNOTAS" runat="server" Width="100px" MaxLength="100"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
</TABLE>
