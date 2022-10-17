<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleCIUU.ascx.vb" Inherits="controles_ucVistaDetalleCIUU" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trCIUU">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblCIUU" runat="server">Ciuu:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtCIUU" runat="server" Width="70px" MaxLength="14"></asp:textbox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDESCRIPCION_CIIU">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblDESCRIPCION_CIIU" runat="server">Descripcion ciiu:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtDESCRIPCION_CIIU" runat="server" Width="100px" MaxLength="250"></asp:TextBox>
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
