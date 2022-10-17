<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleEVALUACION_AF.ascx.vb" Inherits="controles_ucVistaDetalleEVALUACION_AF" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_EVALUACION_AF">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_EVALUACION_AF" runat="server">Id Evaluacion:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoLlaveDerecha" id="txtID_EVALUACION_AF" runat="server" ReadOnly="True" Width="70px"></asp:textbox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_ACCION_FORMATIVA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_ACCION_FORMATIVA" runat="server">Accion formativa:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoLlaveDerecha" id="txtID_ACCION_FORMATIVA" 
                runat="server" ReadOnly="True" Width="70px"></asp:textbox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_EVALUACION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblFECHA_EVALUACION" runat="server">Fecha Evaluacion:</asp:label></TD>
		<TD>
			<asp:TextBox id="txtFECHA_EVALUACION" runat="server" Width="80px" CssClass="TextoNormalCentrado"></asp:TextBox>
            <asp:ImageButton ID="ibtnCalendarFECHA_EVALUACION" runat="Server" AlternateText="Click para mostrar el Calendario"
                ImageUrl="~/imagenes/Calendar_scheduleHS.png" CausesValidation="False" />
            <ajaxToolkit:MaskedEditValidator ID="mevFECHA_EVALUACION" runat="server"
                ControlExtender="meedFECHA_EVALUACION" ControlToValidate="txtFECHA_EVALUACION" 
                InvalidValueMessage="Fecha no Válida" Width="300px" Display="Dynamic" 
                ErrorMessage="MaskedEditValidatorDate" >
            </ajaxToolkit:MaskedEditValidator>
            <ajaxToolkit:MaskedEditExtender ID="meedFECHA_EVALUACION" runat="server" 
                BehaviorID="meedFECHA_EVALUACION" TargetControlID="txtFECHA_EVALUACION" 
                MaskType=Date Mask="99/99/9999">
            </ajaxToolkit:MaskedEditExtender>    
            <ajaxToolkit:calendarextender id="cbeFECHA_EVALUACION" runat="server" 
                popupbuttonid="ibtnCalendarFECHA_EVALUACION" targetcontrolid="txtFECHA_EVALUACION" 
                Format="dd/MM/yyyy" Animated="true" CssClass="calendario" >
            </ajaxToolkit:calendarextender>

</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTEMA_EVALUACION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblTEMA_EVALUACION" runat="server">Tema Evaluacion:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="NormalUPPER" ID="txtTEMA_EVALUACION" runat="server" Width="472px"
                MaxLength="100"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNOTAS">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblNOTAS" runat="server">Comentario:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="NormalUPPER" ID="txtNOTAS" runat="server" Width="472px" MaxLength="255"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trEVALUADOR">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblEVALUADOR" runat="server">Evaluador:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="NormalUPPER" ID="txtEVALUADOR" runat="server" Width="472px"
                MaxLength="100"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTIPO_EVALUACION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblTIPO_EVALUACION" runat="server">Tipo evaluacion:</asp:label></TD>
		<TD>
            <asp:DropDownList ID="ddlTipoEvaluacion1" runat="server" >
                <asp:ListItem Value="P">Practica</asp:ListItem>
                <asp:ListItem Value="T">Teorica</asp:ListItem>
            </asp:DropDownList>			
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trPORC_APROBACION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblPORC_APROBACION" runat="server">% Aprobados:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtPORC_APROBACION" runat="server" Width="100px">0</asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorPORC_APROBACION" runat="server" ControlToValidate="txtPORC_APROBACION"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trPORC_REPROBADOS">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblPORC_REPROBADOS" runat="server">% Reprobados:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtPORC_REPROBADOS" runat="server" Width="100px">0</asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorPORC_REPROBADOS" runat="server" ControlToValidate="txtPORC_REPROBADOS"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
</TABLE>
