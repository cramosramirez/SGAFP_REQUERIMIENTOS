<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetallePAQUETE_INFORME_DET.ascx.vb" Inherits="controles_ucVistaDetallePAQUETE_INFORME_DET" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_PAQUETE">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_PAQUETE" runat="server">Paquete informe:</asp:label></TD>
		<TD>
			<cc1:ddlPAQUETE_INFORME id="ddlPAQUETE_INFORME1" runat="server" AutoPostBack="True" CssClass="DDLClassDisabled" Enabled="False"></cc1:ddlPAQUETE_INFORME></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_INFORME_FINAL">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_INFORME_FINAL" runat="server">Informe final af:</asp:label></TD>
		<TD>
			<cc1:ddlINFORME_FINAL_AF id="ddlINFORME_FINAL_AF1" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlINFORME_FINAL_AF></TD>
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
	<TR runat="server" id="trUSERID">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblUSERID" runat="server">Userid:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtUSERID" runat="server" Width="40px" MaxLength="256"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
</TABLE>
