<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleETAPA.ascx.vb" Inherits="controles_ucVistaDetalleETAPA" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trCODIGO_ETAPA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblCODIGO_ETAPA" runat="server">Codigo etapa:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtCODIGO_ETAPA" runat="server" Width="70px" MaxLength="2"></asp:textbox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCODIGO_PROCESO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblCODIGO_PROCESO" runat="server">Proceso:</asp:label></TD>
		<TD>
			<cc1:ddlPROCESO id="ddlPROCESO1" runat="server" AutoPostBack="True" CssClass="DDLClassDisabled" Enabled="False"></cc1:ddlPROCESO></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_ESTADO_SOLICITUD">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_ESTADO_SOLICITUD" runat="server">Estado solicitud:</asp:label></TD>
		<TD>
			<cc1:ddlESTADO_SOLICITUD id="ddlESTADO_SOLICITUD1" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlESTADO_SOLICITUD></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trUNIDAD_DE_TIEMPO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblUNIDAD_DE_TIEMPO" runat="server">Unidad de tiempo:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtUNIDAD_DE_TIEMPO" runat="server" Width="100px" MaxLength="1"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNOMBRE_ETAPA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblNOMBRE_ETAPA" runat="server">Nombre etapa:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtNOMBRE_ETAPA" runat="server" Width="100px" MaxLength="50"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trETAPA_ANT">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblETAPA_ANT" runat="server">Etapa ant:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtETAPA_ANT" runat="server" Width="100px" MaxLength="2"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trETAPA_SIG">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblETAPA_SIG" runat="server">Etapa sig:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtETAPA_SIG" runat="server" Width="100px" MaxLength="2"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTIPO_ETAPA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblTIPO_ETAPA" runat="server">Tipo etapa:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtTIPO_ETAPA" runat="server" Width="100px" MaxLength="1"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDURACION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblDURACION" runat="server">Duracion:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtDURACION" runat="server" Width="100px"></asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorDURACION" runat="server" ControlToValidate="txtDURACION"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trORDEN_EJECUCION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblORDEN_EJECUCION" runat="server">Orden ejecucion:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtORDEN_EJECUCION" runat="server" Width="100px"></asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorORDEN_EJECUCION" runat="server" ControlToValidate="txtORDEN_EJECUCION"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
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
