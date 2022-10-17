<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleSOLIC_EMPLEO_ACTUAL.ascx.vb" Inherits="controles_ucVistaDetalleSOLIC_EMPLEO_ACTUAL" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_EMPLEO_ACTUAL">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_EMPLEO_ACTUAL" runat="server" Text="Id empleo actual:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoLlaveDerecha" id="txtID_EMPLEO_ACTUAL" runat="server" ReadOnly="True" Width="70px"></dx:ASPxTextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_SOLICITUD">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_SOLICITUD" runat="server" Text="Solicitud inscripcion af:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlSOLICITUD_INSCRIPCION_AF id="ddlSOLICITUD_INSCRIPCION_AFID_SOLICITUD" runat="server" CssClass="DDLClass"></cc1:ddlSOLICITUD_INSCRIPCION_AF></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNOMBRE_EMPRESA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblNOMBRE_EMPRESA" runat="server" Text="Nombre empresa:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtNOMBRE_EMPRESA" runat="server" Width="100px" MaxLength="100">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDIRECCION">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblDIRECCION" runat="server" Text="Direccion:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtDIRECCION" runat="server" Width="100px" MaxLength="150">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCODIGO_DEPARTAMENTO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblCODIGO_DEPARTAMENTO" runat="server" Text="Departamento:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlDEPARTAMENTO id="ddlDEPARTAMENTOCODIGO_DEPARTAMENTO" runat="server" CssClass="DDLClass"></cc1:ddlDEPARTAMENTO></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCODIGO_MUNICIPIO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblCODIGO_MUNICIPIO" runat="server" Text="Municipio:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlMUNICIPIO id="ddlMUNICIPIOCODIGO_MUNICIPIO" runat="server" CssClass="DDLClass"></cc1:ddlMUNICIPIO></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTELEFONOS">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblTELEFONOS" runat="server" Text="Telefonos:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtTELEFONOS" runat="server" Width="100px" MaxLength="40">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTIEMPO_TRABAJO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblTIEMPO_TRABAJO" runat="server" Text="Tiempo trabajo:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtTIEMPO_TRABAJO" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trAREA_TRABAJO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblAREA_TRABAJO" runat="server" Text="Area trabajo:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtAREA_TRABAJO" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trAREA_OTRO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblAREA_OTRO" runat="server" Text="Area otro:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtAREA_OTRO" runat="server" Width="100px" MaxLength="60">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
</TABLE>
