<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleINFORME_FINAL_DET.ascx.vb" Inherits="controles_ucVistaDetalleINFORME_FINAL_DET" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_INFORME_FINAL_DET">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_INFORME_FINAL_DET" runat="server">Id informe final det:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoLlaveDerecha" id="txtID_INFORME_FINAL_DET" runat="server" ReadOnly="True" Width="70px"></asp:textbox></TD>
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
	<TR runat="server" id="trID_PARTICIPANTE">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_PARTICIPANTE" runat="server">Participante:</asp:label></TD>
		<TD>
			<cc1:ddlPARTICIPANTE id="ddlPARTICIPANTE1" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlPARTICIPANTE></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_ACCION_FORMATIVA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_ACCION_FORMATIVA" runat="server">Accion formativa:</asp:label></TD>
		<TD>
			<cc1:ddlACCION_FORMATIVA id="ddlACCION_FORMATIVA1" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlACCION_FORMATIVA></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNOTA_OBTENIDA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblNOTA_OBTENIDA" runat="server">Nota obtenida:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtNOTA_OBTENIDA" runat="server" Width="100px"></asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorNOTA_OBTENIDA" runat="server" ControlToValidate="txtNOTA_OBTENIDA"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trPORC_ASISTENCIA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblPORC_ASISTENCIA" runat="server">Porc asistencia:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtPORC_ASISTENCIA" runat="server" Width="100px"></asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorPORC_ASISTENCIA" runat="server" ControlToValidate="txtPORC_ASISTENCIA"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trMONTO_SOLICITADO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblMONTO_SOLICITADO" runat="server">Monto solicitado:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtMONTO_SOLICITADO" runat="server" Width="100px"></asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorMONTO_SOLICITADO" runat="server" ControlToValidate="txtMONTO_SOLICITADO"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trMONTO_APROBADO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblMONTO_APROBADO" runat="server">Monto aprobado:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtMONTO_APROBADO" runat="server" Width="100px"></asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorMONTO_APROBADO" runat="server" ControlToValidate="txtMONTO_APROBADO"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trESTADO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblESTADO" runat="server">Estado:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtESTADO" runat="server" Width="100px" MaxLength="1"></asp:TextBox>
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
	<TR runat="server" id="trUSERID">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblUSERID" runat="server">Userid:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtUSERID" runat="server" Width="40px" MaxLength="256"></asp:TextBox>
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
