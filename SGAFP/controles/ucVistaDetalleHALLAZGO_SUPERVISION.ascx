<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleHALLAZGO_SUPERVISION.ascx.vb" Inherits="controles_ucVistaDetalleHALLAZGO_SUPERVISION" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_HALLAZGO_SUPERVISION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_HALLAZGO_SUPERVISION" runat="server">Id hallazgo supervision:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoLlaveDerecha" id="txtID_HALLAZGO_SUPERVISION" runat="server" ReadOnly="True" Width="70px"></asp:textbox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_AREA_SUPERVISION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_AREA_SUPERVISION" runat="server">Area supervision:</asp:label></TD>
		<TD>
			<cc1:ddlAREA_SUPERVISION id="ddlAREA_SUPERVISION1" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlAREA_SUPERVISION></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_SUPERVISION_AF">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_SUPERVISION_AF" runat="server">Supervision af:</asp:label></TD>
		<TD>
			<cc1:ddlSUPERVISION_AF id="ddlSUPERVISION_AF1" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlSUPERVISION_AF></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trHALLAZGO_SUPERVISION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblHALLAZGO_SUPERVISION" runat="server">Hallazgo supervision:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtHALLAZGO_SUPERVISION" runat="server" Width="100px" MaxLength="255"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblFECHA" runat="server">Fecha:</asp:label></TD>
		<TD>
			<asp:TextBox id="txtFECHA" runat="server" Width="80px" CssClass="TextoNormalCentrado"></asp:TextBox>
            <asp:ImageButton ID="ibtnCalendarFECHA" runat="Server" AlternateText="Click para mostrar el Calendario"
                ImageUrl="~/imagenes/Calendar_scheduleHS.png" CausesValidation="False" />
            <ajaxToolkit:MaskedEditValidator ID="mevFECHA" runat="server"
                ControlExtender="meedFECHA" ControlToValidate="txtFECHA" 
                InvalidValueMessage="Fecha no Válida" Width="300px" Display="Dynamic" 
                ErrorMessage="MaskedEditValidatorDate" >
            </ajaxToolkit:MaskedEditValidator>
            <ajaxToolkit:MaskedEditExtender ID="meedFECHA" runat="server" 
                BehaviorID="meedFECHA" TargetControlID="txtFECHA" 
                MaskType=Date Mask="99/99/9999">
            </ajaxToolkit:MaskedEditExtender>    
            <ajaxToolkit:calendarextender id="cbeFECHA" runat="server" 
                popupbuttonid="ibtnCalendarFECHA" targetcontrolid="txtFECHA" 
                Format="dd/MM/yyyy" Animated="true" CssClass="calendario" >
            </ajaxToolkit:calendarextender>

</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTIPO_SANCION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblTIPO_SANCION" runat="server">Tipo sancion:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtTIPO_SANCION" runat="server" Width="100px" MaxLength="1"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTIEMPO_SANCION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblTIEMPO_SANCION" runat="server">Tiempo sancion:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtTIEMPO_SANCION" runat="server" Width="100px"></asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorTIEMPO_SANCION" runat="server" ControlToValidate="txtTIEMPO_SANCION"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trMONTO_SANCION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblMONTO_SANCION" runat="server">Monto sancion:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtMONTO_SANCION" runat="server" Width="100px"></asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorMONTO_SANCION" runat="server" ControlToValidate="txtMONTO_SANCION"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTIEMPO_SUBSANACION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblTIEMPO_SUBSANACION" runat="server">Tiempo subsanacion:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtTIEMPO_SUBSANACION" runat="server" Width="100px"></asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorTIEMPO_SUBSANACION" runat="server" ControlToValidate="txtTIEMPO_SUBSANACION"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
</TABLE>
