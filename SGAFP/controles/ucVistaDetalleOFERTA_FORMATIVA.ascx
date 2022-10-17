<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleOFERTA_FORMATIVA.ascx.vb" Inherits="controles_ucVistaDetalleOFERTA_FORMATIVA" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_OFERTA_FORMATIVA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_OFERTA_FORMATIVA" runat="server">Id oferta formativa:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoLlaveDerecha" id="txtID_OFERTA_FORMATIVA" runat="server" ReadOnly="True" Width="70px"></asp:textbox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_EJERCICIO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_EJERCICIO" runat="server">Ejercicio:</asp:label></TD>
		<TD>
			<cc1:ddlEJERCICIO id="ddlEJERCICIO1" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlEJERCICIO></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_TEMA_CURSO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_TEMA_CURSO" runat="server">Curso tema:</asp:label></TD>
		<TD>
			<cc1:ddlCURSO_TEMA id="ddlCURSO_TEMA1" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlCURSO_TEMA></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_PROVEEDOR_AF">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_PROVEEDOR_AF" runat="server">Proveedor af:</asp:label></TD>
		<TD>
			<cc1:ddlPROVEEDOR_AF id="ddlPROVEEDOR_AF1" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlPROVEEDOR_AF></TD>
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
	<TR runat="server" id="trCOSTO_X_PARTICIPANTE">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblCOSTO_X_PARTICIPANTE" runat="server">Costo x participante:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtCOSTO_X_PARTICIPANTE" runat="server" Width="100px"></asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorCOSTO_X_PARTICIPANTE" runat="server" ControlToValidate="txtCOSTO_X_PARTICIPANTE"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
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
	<TR runat="server" id="trESTADO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblESTADO" runat="server">Estado:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtESTADO" runat="server" Width="100px" MaxLength="1"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_APROBACION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblFECHA_APROBACION" runat="server">Fecha aprobacion:</asp:label></TD>
		<TD>
			<asp:TextBox id="txtFECHA_APROBACION" runat="server" Width="80px" CssClass="TextoNormalCentrado"></asp:TextBox>
            <asp:ImageButton ID="ibtnCalendarFECHA_APROBACION" runat="Server" AlternateText="Click para mostrar el Calendario"
                ImageUrl="~/imagenes/Calendar_scheduleHS.png" CausesValidation="False" />
            <ajaxToolkit:MaskedEditValidator ID="mevFECHA_APROBACION" runat="server"
                ControlExtender="meedFECHA_APROBACION" ControlToValidate="txtFECHA_APROBACION" 
                InvalidValueMessage="Fecha no Válida" Width="300px" Display="Dynamic" 
                ErrorMessage="MaskedEditValidatorDate" >
            </ajaxToolkit:MaskedEditValidator>
            <ajaxToolkit:MaskedEditExtender ID="meedFECHA_APROBACION" runat="server" 
                BehaviorID="meedFECHA_APROBACION" TargetControlID="txtFECHA_APROBACION" 
                MaskType=Date Mask="99/99/9999">
            </ajaxToolkit:MaskedEditExtender>    
            <ajaxToolkit:calendarextender id="cbeFECHA_APROBACION" runat="server" 
                popupbuttonid="ibtnCalendarFECHA_APROBACION" targetcontrolid="txtFECHA_APROBACION" 
                Format="dd/MM/yyyy" Animated="true" CssClass="calendario" >
            </ajaxToolkit:calendarextender>

</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trUSUARIO_APROBACION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblUSUARIO_APROBACION" runat="server">Usuario aprobacion:</asp:label></TD>
		<TD>
			<asp:TextBox id="txtUSUARIO_APROBACION" runat="server" Width="80px" CssClass="TextoNormalCentrado"></asp:TextBox>
            <asp:ImageButton ID="ibtnCalendarUSUARIO_APROBACION" runat="Server" AlternateText="Click para mostrar el Calendario"
                ImageUrl="~/imagenes/Calendar_scheduleHS.png" CausesValidation="False" />
            <ajaxToolkit:MaskedEditValidator ID="mevUSUARIO_APROBACION" runat="server"
                ControlExtender="meedUSUARIO_APROBACION" ControlToValidate="txtUSUARIO_APROBACION" 
                InvalidValueMessage="Fecha no Válida" Width="300px" Display="Dynamic" 
                ErrorMessage="MaskedEditValidatorDate" >
            </ajaxToolkit:MaskedEditValidator>
            <ajaxToolkit:MaskedEditExtender ID="meedUSUARIO_APROBACION" runat="server" 
                BehaviorID="meedUSUARIO_APROBACION" TargetControlID="txtUSUARIO_APROBACION" 
                MaskType=Date Mask="99/99/9999">
            </ajaxToolkit:MaskedEditExtender>    
            <ajaxToolkit:calendarextender id="cbeUSUARIO_APROBACION" runat="server" 
                popupbuttonid="ibtnCalendarUSUARIO_APROBACION" targetcontrolid="txtUSUARIO_APROBACION" 
                Format="dd/MM/yyyy" Animated="true" CssClass="calendario" >
            </ajaxToolkit:calendarextender>

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
