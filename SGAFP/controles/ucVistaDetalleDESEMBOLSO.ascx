<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleDESEMBOLSO.ascx.vb" Inherits="controles_ucVistaDetalleDESEMBOLSO" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_DESEMBOLSO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_DESEMBOLSO" runat="server" Text="Id desembolso:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoLlaveDerecha" id="txtID_DESEMBOLSO" runat="server" ReadOnly="True" Width="70px"></dx:ASPxTextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_FUENTE">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_FUENTE" Font-Size="X-Small" runat="server" Text="Fuente:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlFUENTE_FINANCIAMIENTO id="ddlFUENTE_FINANCIAMIENTOID_FUENTE" Font-Size="X-Small" runat="server" CssClass="DDLClass"></cc1:ddlFUENTE_FINANCIAMIENTO></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNO_CONVOCATORIA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblNO_CONVOCATORIA" Font-Size="X-Small" runat="server" Text="N° Convocatoria:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtNO_CONVOCATORIA" runat="server" Height="21px"  Number="0" DecimalPlaces="0" Increment="1">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo N° convocatoria es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNUM_DESEMBOLSO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblNUM_DESEMBOLSO" Font-Size="X-Small" runat="server" Text="N° de Desembolso:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtNUM_DESEMBOLSO" runat="server" Height="21px"  Number="0" DecimalPlaces="0" Increment="1">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo N° de Desembolso es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_DESEMBOLSO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblFECHA_DESEMBOLSO"  Font-Size="X-Small" runat="server" Text="Fecha del Desembolso:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deFECHA_DESEMBOLSO" runat="server" EditFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="true">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="La fecha es Requerida" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxDateEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trMONTO_AUTORIZADO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblMONTO_AUTORIZADO" runat="server" Font-Size="X-Small" Text="Monto Autorizado:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtMONTO_AUTORIZADO" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="10">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Monto autorizado es requerido" IsRequired="True" />
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
