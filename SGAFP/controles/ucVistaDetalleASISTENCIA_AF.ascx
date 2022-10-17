<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleASISTENCIA_AF.ascx.vb" Inherits="controles_ucVistaDetalleASISTENCIA_AF" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_ASISTENCIA_AF">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_ASISTENCIA_AF" runat="server">Id Asistencia:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoLlaveDerecha" id="txtID_ASISTENCIA_AF" runat="server" ReadOnly="True" Width="70px"></asp:textbox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_ACCION_FORMATIVA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_ACCION_FORMATIVA" runat="server">Accion formativa:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoLlaveDerecha" ID="txtID_ACCION_FORMATIVA" runat="server"
                ReadOnly="True" Width="70px"></asp:textbox></TD>
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
	<TR runat="server" id="trINSTRUCTOR">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblINSTRUCTOR" runat="server">Instructor:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="NormalUPPER" ID="txtINSTRUCTOR" runat="server" Width="100px"
                MaxLength="255"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNOTAS">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblNOTAS" runat="server">Comentarios:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="NormalUPPER" ID="txtNOTAS" runat="server" Width="255px" MaxLength="255"
                Height="74px"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
</TABLE>
