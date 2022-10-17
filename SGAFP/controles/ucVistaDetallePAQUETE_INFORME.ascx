<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetallePAQUETE_INFORME.ascx.vb" Inherits="controles_ucVistaDetallePAQUETE_INFORME" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_PAQUETE">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_PAQUETE" runat="server">Id paquete:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoLlaveDerecha" id="txtID_PAQUETE" runat="server" ReadOnly="True" Width="70px"></asp:textbox></TD>
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
	<TR runat="server" id="trCOMENTARIOS">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblCOMENTARIOS" runat="server">Descripcion:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="NormalUPPER" id="txtCOMENTARIOS" runat="server" Width="300px" MaxLength="255"></asp:TextBox>
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
	<TR runat="server" id="trUSERID">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblUSERID" runat="server">Userid:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtUSERID" runat="server" Width="40px" MaxLength="256"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
</TABLE>
