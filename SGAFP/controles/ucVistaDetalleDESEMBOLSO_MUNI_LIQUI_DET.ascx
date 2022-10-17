<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleDESEMBOLSO_MUNI_LIQUI_DET.ascx.vb" Inherits="controles_ucVistaDetalleDESEMBOLSO_MUNI_LIQUI_DET" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_DESEMBOLSO_MUNI">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_DESEMBOLSO_MUNI" runat="server" Text="Id desembolso muni:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoLlaveDerecha" id="txtID_DESEMBOLSO_MUNI" runat="server" ReadOnly="True" Width="70px"></dx:ASPxTextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_DESEMBOLSO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_DESEMBOLSO" runat="server" Text="Desembolso:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlDESEMBOLSO id="ddlDESEMBOLSOID_DESEMBOLSO" runat="server" CssClass="DDLClass"></cc1:ddlDESEMBOLSO></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_LIQUIDACION_DET">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_LIQUIDACION_DET" runat="server" Text="Municipio liquidacion det:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlMUNICIPIO_LIQUIDACION_DET id="ddlMUNICIPIO_LIQUIDACION_DETID_LIQUIDACION_DET" runat="server" CssClass="DDLClass"></cc1:ddlMUNICIPIO_LIQUIDACION_DET></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trMONTO_DESEMBOLSO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblMONTO_DESEMBOLSO" runat="server" Text="Monto desembolso:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtMONTO_DESEMBOLSO" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Monto desembolso es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trUSERID">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblUSERID" runat="server" Text="Userid:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtUSERID" runat="server" Width="40px" MaxLength="256" ReadOnly="True"></dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trLASTUPDATE">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblLASTUPDATE" runat="server" Text="Lastupdate:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deLASTUPDATE" runat="server" EditFormat="DateTime">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="La fecha es Requerida" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxDateEdit>
</TD>
		<TD width="10"></TD>
	</TR>
</TABLE>
