<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleMUNICIPIO.ascx.vb" Inherits="controles_ucVistaDetalleMUNICIPIO" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trCODIGO_MUNICIPIO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblCODIGO_MUNICIPIO" runat="server">Codigo municipio:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtCODIGO_MUNICIPIO" runat="server" Width="70px" MaxLength="2"></asp:textbox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCODIGO_REGION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblCODIGO_REGION" runat="server">Region:</asp:label></TD>
		<TD>
			<cc1:ddlREGION id="ddlREGION1" runat="server" AutoPostBack="True" CssClass="DDLClassDisabled" Enabled="False"></cc1:ddlREGION></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCODIGO_DEPARTAMENTO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblCODIGO_DEPARTAMENTO" runat="server">Departamento:</asp:label></TD>
		<TD>
			<cc1:ddlDEPARTAMENTO id="ddlDEPARTAMENTO1" runat="server" AutoPostBack="True" CssClass="DDLClassDisabled" Enabled="False"></cc1:ddlDEPARTAMENTO></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNOMBRE">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblNOMBRE" runat="server">Nombre:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtNOMBRE" runat="server" Width="100px" MaxLength="60"></asp:TextBox>
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
