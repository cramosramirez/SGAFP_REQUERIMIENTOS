<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleCURSO_TEMA.ascx.vb" Inherits="controles_ucVistaDetalleCURSO_TEMA" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_TEMA_CURSO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_TEMA_CURSO" runat="server">Id tema curso:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoLlaveDerecha" id="txtID_TEMA_CURSO" runat="server" ReadOnly="True" Width="70px"></asp:textbox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_AREA_FORMACION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_AREA_FORMACION" runat="server">Area formacion:</asp:label></TD>
		<TD>
			<cc1:ddlAREA_FORMACION id="ddlAREA_FORMACION1" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlAREA_FORMACION></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTEMA_CURSO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblTEMA_CURSO" runat="server">Tema curso:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtTEMA_CURSO" runat="server" Width="100px" MaxLength="150"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDURACION_HORAS">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblDURACION_HORAS" runat="server">Duracion horas:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtDURACION_HORAS" runat="server" Width="100px"></asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorDURACION_HORAS" runat="server" ControlToValidate="txtDURACION_HORAS"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_ACREDITACION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblFECHA_ACREDITACION" runat="server">Fecha acreditacion:</asp:label></TD>
		<TD>
			<asp:TextBox id="txtFECHA_ACREDITACION" runat="server" Width="80px" CssClass="TextoNormalCentrado"></asp:TextBox>
            <asp:ImageButton ID="ibtnCalendarFECHA_ACREDITACION" runat="Server" AlternateText="Click para mostrar el Calendario"
                ImageUrl="~/imagenes/Calendar_scheduleHS.png" CausesValidation="False" />
            <ajaxToolkit:MaskedEditValidator ID="mevFECHA_ACREDITACION" runat="server"
                ControlExtender="meedFECHA_ACREDITACION" ControlToValidate="txtFECHA_ACREDITACION" 
                InvalidValueMessage="Fecha no Válida" Width="300px" Display="Dynamic" 
                ErrorMessage="MaskedEditValidatorDate" >
            </ajaxToolkit:MaskedEditValidator>
            <ajaxToolkit:MaskedEditExtender ID="meedFECHA_ACREDITACION" runat="server" 
                BehaviorID="meedFECHA_ACREDITACION" TargetControlID="txtFECHA_ACREDITACION" 
                MaskType=Date Mask="99/99/9999">
            </ajaxToolkit:MaskedEditExtender>    
            <ajaxToolkit:calendarextender id="cbeFECHA_ACREDITACION" runat="server" 
                popupbuttonid="ibtnCalendarFECHA_ACREDITACION" targetcontrolid="txtFECHA_ACREDITACION" 
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
