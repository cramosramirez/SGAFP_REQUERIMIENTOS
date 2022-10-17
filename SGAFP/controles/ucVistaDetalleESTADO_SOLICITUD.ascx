<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleESTADO_SOLICITUD.ascx.vb" Inherits="controles_ucVistaDetalleESTADO_SOLICITUD" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_ESTADO_SOLICITUD">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_ESTADO_SOLICITUD" runat="server">Id estado solicitud:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoLlaveDerecha" id="txtID_ESTADO_SOLICITUD" runat="server" ReadOnly="True" Width="70px"></asp:textbox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trESTADO_SOLICITUD">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblESTADO_SOLICITUD" runat="server">Estado solicitud:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtESTADO_SOLICITUD" runat="server" Width="100px" MaxLength="60"></asp:TextBox>
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
