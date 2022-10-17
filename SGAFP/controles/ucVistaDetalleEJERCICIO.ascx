<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleEJERCICIO.ascx.vb" Inherits="controles_ucVistaDetalleEJERCICIO" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_EJERCICIO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_EJERCICIO" runat="server">Id ejercicio:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtID_EJERCICIO" runat="server" Width="70px" MaxLength="4"></asp:textbox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trETIQUETA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblETIQUETA" runat="server">Etiqueta:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtETIQUETA" runat="server" Width="100px" MaxLength="20"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_INICIO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblFECHA_INICIO" runat="server">Fecha inicio:</asp:label></TD>
		<TD>
			<asp:TextBox id="txtFECHA_INICIO" runat="server" Width="80px" CssClass="TextoNormalCentrado"></asp:TextBox>
            <asp:ImageButton ID="ibtnCalendarFECHA_INICIO" runat="Server" AlternateText="Click para mostrar el Calendario"
                ImageUrl="~/imagenes/Calendar_scheduleHS.png" CausesValidation="False" />
            <ajaxToolkit:MaskedEditValidator ID="mevFECHA_INICIO" runat="server"
                ControlExtender="meedFECHA_INICIO" ControlToValidate="txtFECHA_INICIO" 
                InvalidValueMessage="Fecha no Válida" Width="300px" Display="Dynamic" 
                ErrorMessage="MaskedEditValidatorDate" >
            </ajaxToolkit:MaskedEditValidator>
            <ajaxToolkit:MaskedEditExtender ID="meedFECHA_INICIO" runat="server" 
                BehaviorID="meedFECHA_INICIO" TargetControlID="txtFECHA_INICIO" 
                MaskType=Date Mask="99/99/9999">
            </ajaxToolkit:MaskedEditExtender>    
            <ajaxToolkit:calendarextender id="cbeFECHA_INICIO" runat="server" 
                popupbuttonid="ibtnCalendarFECHA_INICIO" targetcontrolid="txtFECHA_INICIO" 
                Format="dd/MM/yyyy" Animated="true" CssClass="calendario" >
            </ajaxToolkit:calendarextender>

</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_FIN">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblFECHA_FIN" runat="server">Fecha fin:</asp:label></TD>
		<TD>
			<asp:TextBox id="txtFECHA_FIN" runat="server" Width="80px" CssClass="TextoNormalCentrado"></asp:TextBox>
            <asp:ImageButton ID="ibtnCalendarFECHA_FIN" runat="Server" AlternateText="Click para mostrar el Calendario"
                ImageUrl="~/imagenes/Calendar_scheduleHS.png" CausesValidation="False" />
            <ajaxToolkit:MaskedEditValidator ID="mevFECHA_FIN" runat="server"
                ControlExtender="meedFECHA_FIN" ControlToValidate="txtFECHA_FIN" 
                InvalidValueMessage="Fecha no Válida" Width="300px" Display="Dynamic" 
                ErrorMessage="MaskedEditValidatorDate" >
            </ajaxToolkit:MaskedEditValidator>
            <ajaxToolkit:MaskedEditExtender ID="meedFECHA_FIN" runat="server" 
                BehaviorID="meedFECHA_FIN" TargetControlID="txtFECHA_FIN" 
                MaskType=Date Mask="99/99/9999">
            </ajaxToolkit:MaskedEditExtender>    
            <ajaxToolkit:calendarextender id="cbeFECHA_FIN" runat="server" 
                popupbuttonid="ibtnCalendarFECHA_FIN" targetcontrolid="txtFECHA_FIN" 
                Format="dd/MM/yyyy" Animated="true" CssClass="calendario" >
            </ajaxToolkit:calendarextender>

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
