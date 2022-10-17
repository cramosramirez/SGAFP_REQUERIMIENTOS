<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleASISTENCIA_AF_DET.ascx.vb" Inherits="controles_ucVistaDetalleASISTENCIA_AF_DET" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_ASISTENCIA_DET">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_ASISTENCIA_DET" runat="server">Id asistencia det:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoLlaveDerecha" id="txtID_ASISTENCIA_DET" runat="server" ReadOnly="True" Width="70px"></asp:textbox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_ASISTENCIA_AF">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_ASISTENCIA_AF" runat="server">Asistencia af:</asp:label></TD>
		<TD>
			<cc1:ddlASISTENCIA_AF id="ddlASISTENCIA_AF1" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlASISTENCIA_AF></TD>
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
	<TR runat="server" id="trASISTIO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblASISTIO" runat="server">Asistio:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtASISTIO" runat="server" Width="100px" MaxLength="1"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trPRESENTA_JUSTIFICACION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblPRESENTA_JUSTIFICACION" runat="server">Presenta justificacion:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtPRESENTA_JUSTIFICACION" runat="server" Width="100px" MaxLength="1"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trJUSTIFICACION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblJUSTIFICACION" runat="server">Justificacion:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtJUSTIFICACION" runat="server" Width="100px" MaxLength="80"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
</TABLE>
