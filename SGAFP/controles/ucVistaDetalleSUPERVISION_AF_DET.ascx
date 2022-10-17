<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleSUPERVISION_AF_DET.ascx.vb" Inherits="controles_ucVistaDetalleSUPERVISION_AF_DET" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_SUPERVISION_DET">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_SUPERVISION_DET" runat="server">Id supervision det:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoLlaveDerecha" id="txtID_SUPERVISION_DET" runat="server" ReadOnly="True" Width="70px"></asp:textbox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_LISTA_SUPERVISION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_LISTA_SUPERVISION" runat="server">Lista supervision af:</asp:label></TD>
		<TD>
			<cc1:ddlLISTA_SUPERVISION_AF id="ddlLISTA_SUPERVISION_AF1" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlLISTA_SUPERVISION_AF></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_SUPERVISION_AF">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_SUPERVISION_AF" runat="server">Supervision af:</asp:label></TD>
		<TD>
			<cc1:ddlSUPERVISION_AF id="ddlSUPERVISION_AF1" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlSUPERVISION_AF></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCOMENTARIOS">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblCOMENTARIOS" runat="server">Comentarios:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtCOMENTARIOS" runat="server" Width="100px" MaxLength="200"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
</TABLE>
