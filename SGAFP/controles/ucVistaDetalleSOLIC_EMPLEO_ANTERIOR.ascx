<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleSOLIC_EMPLEO_ANTERIOR.ascx.vb" Inherits="controles_ucVistaDetalleSOLIC_EMPLEO_ANTERIOR" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_EMPLEO_ANT">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_EMPLEO_ANT" runat="server" Text="Id empleo ant:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoLlaveDerecha" id="txtID_EMPLEO_ANT" runat="server" ReadOnly="True" Width="70px"></dx:ASPxTextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_SOLICITUD">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_SOLICITUD" runat="server" Text="Solicitud inscripcion af:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlSOLICITUD_INSCRIPCION_AF id="ddlSOLICITUD_INSCRIPCION_AFID_SOLICITUD" runat="server" CssClass="DDLClass"></cc1:ddlSOLICITUD_INSCRIPCION_AF></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTIEMPO_NO_TRABAJA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblTIEMPO_NO_TRABAJA" runat="server" Text="Tiempo no trabaja:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtTIEMPO_NO_TRABAJA" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
</TABLE>
