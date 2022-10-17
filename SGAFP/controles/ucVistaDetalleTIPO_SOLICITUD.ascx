<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleTIPO_SOLICITUD.ascx.vb" Inherits="controles_ucVistaDetalleTIPO_SOLICITUD" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_TIPO_SOLICITUD">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_TIPO_SOLICITUD" runat="server">Id tipo solicitud:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoLlaveDerecha" id="txtID_TIPO_SOLICITUD" runat="server" ReadOnly="True" Width="70px"></asp:textbox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCODIGO_PROCESO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblCODIGO_PROCESO" runat="server">Proceso:</asp:label></TD>
		<TD>
			<cc1:ddlPROCESO id="ddlPROCESO1" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlPROCESO></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTIPO_SOLICITUD">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblTIPO_SOLICITUD" runat="server">Tipo solicitud:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtTIPO_SOLICITUD" runat="server" Width="100px" MaxLength="60"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTABLA_RELACIONAL">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblTABLA_RELACIONAL" runat="server">Tabla relacional:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtTABLA_RELACIONAL" runat="server" Width="100px" MaxLength="40"></asp:TextBox>
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
	<TR runat="server" id="trUSERID">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblUSERID" runat="server">Userid:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtUSERID" runat="server" Width="40px" MaxLength="16"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trLASTUPDATE">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblLASTUPDATE" runat="server">Lastupdate:</asp:label></TD>
		<TD>
			<asp:TextBox id="txtLASTUPDATE" runat="server" Width="80px" CssClass="TextoNormalCentrado"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
</TABLE>
