<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleFASE_ESTADO_INFORME.ascx.vb" Inherits="controles_ucVistaDetalleFASE_ESTADO_INFORME" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_FASE_ESTADO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_FASE_ESTADO" runat="server" Text="Id fase estado:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoLlaveDerecha" id="txtID_FASE_ESTADO" runat="server" ReadOnly="True" Width="70px"></dx:ASPxTextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNOMBRE_FASE_ESTADO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblNOMBRE_FASE_ESTADO" runat="server" Text="Nombre fase estado:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtNOMBRE_FASE_ESTADO" runat="server" Width="100px" MaxLength="256">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Nombre fase estado es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxTextBox>
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
