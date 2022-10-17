<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleOPCION_GRUPO.ascx.vb" Inherits="controles_ucVistaDetalleOPCION_GRUPO" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_OPCION_GRUPO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_OPCION_GRUPO" runat="server">Id opcion grupo:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoLlaveDerecha" id="txtID_OPCION_GRUPO" runat="server" ReadOnly="True" Width="70px"></asp:textbox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_OPCION_MENU">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_OPCION_MENU" runat="server">Opcion menu:</asp:label></TD>
		<TD>
			<cc1:ddlOPCION_MENU id="ddlOPCION_MENU1" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlOPCION_MENU></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_GRUPO_USUARIO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_GRUPO_USUARIO" runat="server">Grupo usuario:</asp:label></TD>
		<TD>
			<cc1:ddlGRUPO_USUARIO id="ddlGRUPO_USUARIO1" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlGRUPO_USUARIO></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_INGRESO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblFECHA_INGRESO" runat="server">Fecha ingreso:</asp:label></TD>
		<TD>
			<asp:TextBox id="txtFECHA_INGRESO" runat="server" Width="80px" CssClass="TextoNormalCentrado"></asp:TextBox>
            <asp:ImageButton ID="ibtnCalendarFECHA_INGRESO" runat="Server" AlternateText="Click para mostrar el Calendario"
                ImageUrl="~/imagenes/Calendar_scheduleHS.png" CausesValidation="False" />
            <ajaxToolkit:MaskedEditValidator ID="mevFECHA_INGRESO" runat="server"
                ControlExtender="meedFECHA_INGRESO" ControlToValidate="txtFECHA_INGRESO" 
                InvalidValueMessage="Fecha no Válida" Width="300px" Display="Dynamic" 
                ErrorMessage="MaskedEditValidatorDate" >
            </ajaxToolkit:MaskedEditValidator>
            <ajaxToolkit:MaskedEditExtender ID="meedFECHA_INGRESO" runat="server" 
                BehaviorID="meedFECHA_INGRESO" TargetControlID="txtFECHA_INGRESO" 
                MaskType=Date Mask="99/99/9999">
            </ajaxToolkit:MaskedEditExtender>    
            <ajaxToolkit:calendarextender id="cbeFECHA_INGRESO" runat="server" 
                popupbuttonid="ibtnCalendarFECHA_INGRESO" targetcontrolid="txtFECHA_INGRESO" 
                Format="dd/MM/yyyy" Animated="true" CssClass="calendario" >
            </ajaxToolkit:calendarextender>

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
