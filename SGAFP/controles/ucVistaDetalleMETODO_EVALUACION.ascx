<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleMETODO_EVALUACION.ascx.vb" Inherits="controles_ucVistaDetalleMETODO_EVALUACION" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_METODO_EVALUACION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_METODO_EVALUACION" runat="server">Id metodo evaluacion:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoLlaveDerecha" id="txtID_METODO_EVALUACION" runat="server" ReadOnly="True" Width="70px"></asp:textbox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trMETODO_EVALUACION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblMETODO_EVALUACION" runat="server">Metodo evaluacion:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtMETODO_EVALUACION" runat="server" Width="100px" MaxLength="100"></asp:TextBox>
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
