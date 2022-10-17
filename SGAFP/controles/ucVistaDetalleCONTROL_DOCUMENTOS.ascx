<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleCONTROL_DOCUMENTOS.ascx.vb" Inherits="controles_ucVistaDetalleCONTROL_DOCUMENTOS" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trNUMERO_DOCUMENTO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblNUMERO_DOCUMENTO" runat="server">Numero documento:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoLlaveDerecha" id="txtNUMERO_DOCUMENTO" runat="server" ReadOnly="True" Width="70px"></asp:textbox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNUMERO_PATRONAL">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblNUMERO_PATRONAL" runat="server">Numero patronal:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtNUMERO_PATRONAL" runat="server" Width="100px" MaxLength="9"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNUMERO_FOLIO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblNUMERO_FOLIO" runat="server">Numero folio:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtNUMERO_FOLIO" runat="server" Width="100px" MaxLength="14"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_TIPO_SOLICITUD">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblID_TIPO_SOLICITUD" runat="server">Tipo solicitud:</asp:label></TD>
		<TD>
			<cc1:ddlTIPO_SOLICITUD id="ddlTIPO_SOLICITUD1" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlTIPO_SOLICITUD></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCODIGO_ETAPA">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblCODIGO_ETAPA" runat="server">Etapa:</asp:label></TD>
		<TD>
			<cc1:ddlETAPA id="ddlETAPA1" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlETAPA></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCODIGO_PROCESO">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblCODIGO_PROCESO" runat="server">Proceso:</asp:label></TD>
		<TD>
			<cc1:ddlPROCESO id="ddlPROCESO1" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlPROCESO></TD>
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
	<TR runat="server" id="trNIT">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblNIT" runat="server">Nit:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtNIT" runat="server" Width="100px" MaxLength="14"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trPRESENTADO_POR">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblPRESENTADO_POR" runat="server">Presentado por:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtPRESENTADO_POR" runat="server" Width="100px" MaxLength="60"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_RECEPCION">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblFECHA_RECEPCION" runat="server">Fecha recepcion:</asp:label></TD>
		<TD>
			<asp:TextBox id="txtFECHA_RECEPCION" runat="server" Width="80px" CssClass="TextoNormalCentrado"></asp:TextBox>
            <asp:ImageButton ID="ibtnCalendarFECHA_RECEPCION" runat="Server" AlternateText="Click para mostrar el Calendario"
                ImageUrl="~/imagenes/Calendar_scheduleHS.png" CausesValidation="False" />
            <ajaxToolkit:MaskedEditValidator ID="mevFECHA_RECEPCION" runat="server"
                ControlExtender="meedFECHA_RECEPCION" ControlToValidate="txtFECHA_RECEPCION" 
                InvalidValueMessage="Fecha no Válida" Width="300px" Display="Dynamic" 
                ErrorMessage="MaskedEditValidatorDate" >
            </ajaxToolkit:MaskedEditValidator>
            <ajaxToolkit:MaskedEditExtender ID="meedFECHA_RECEPCION" runat="server" 
                BehaviorID="meedFECHA_RECEPCION" TargetControlID="txtFECHA_RECEPCION" 
                MaskType=Date Mask="99/99/9999">
            </ajaxToolkit:MaskedEditExtender>    
            <ajaxToolkit:calendarextender id="cbeFECHA_RECEPCION" runat="server" 
                popupbuttonid="ibtnCalendarFECHA_RECEPCION" targetcontrolid="txtFECHA_RECEPCION" 
                Format="dd/MM/yyyy" Animated="true" CssClass="calendario" >
            </ajaxToolkit:calendarextender>

</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trRESPONSABLE_ACTUAL">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblRESPONSABLE_ACTUAL" runat="server">Responsable actual:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtRESPONSABLE_ACTUAL" runat="server" Width="100px" MaxLength="16"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trRESPONSABLE_ANTERIOR">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblRESPONSABLE_ANTERIOR" runat="server">Responsable anterior:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtRESPONSABLE_ANTERIOR" runat="server" Width="100px" MaxLength="16"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trPRIORIDAD">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblPRIORIDAD" runat="server">Prioridad:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalIzquierda" id="txtPRIORIDAD" runat="server" Width="100px" MaxLength="1"></asp:TextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNO_DOCUMENTO_ORIGEN">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblNO_DOCUMENTO_ORIGEN" runat="server">No documento origen:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtNO_DOCUMENTO_ORIGEN" runat="server" Width="100px"></asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorNO_DOCUMENTO_ORIGEN" runat="server" ControlToValidate="txtNO_DOCUMENTO_ORIGEN"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNO_DOCUMENTO_PADRE">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblNO_DOCUMENTO_PADRE" runat="server">No documento padre:</asp:label></TD>
		<TD>
			<asp:TextBox CssClass="TextoNormalDerecha" id="txtNO_DOCUMENTO_PADRE" runat="server" Width="100px"></asp:TextBox>
			<asp:RegularExpressionValidator ID="RegularExpressionValidatorNO_DOCUMENTO_PADRE" runat="server" ControlToValidate="txtNO_DOCUMENTO_PADRE"
			Display="Dynamic" ErrorMessage="Debe ingresar una numero valida" ValidationExpression="^(\d{1,3},?(\d{3},?)*\d{3}(\.\d{0,2})?|\d{1,3}(\.\d{0,2})?|\.\d{1,2}?)$" >*</asp:RegularExpressionValidator>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_REQUERIDA_FIN">
		<TD width="10"></TD>
		<TD align="right">
			<asp:Label CssClass="Normal" id="lblFECHA_REQUERIDA_FIN" runat="server">Fecha requerida fin:</asp:label></TD>
		<TD>
			<asp:TextBox id="txtFECHA_REQUERIDA_FIN" runat="server" Width="80px" CssClass="TextoNormalCentrado"></asp:TextBox>
            <asp:ImageButton ID="ibtnCalendarFECHA_REQUERIDA_FIN" runat="Server" AlternateText="Click para mostrar el Calendario"
                ImageUrl="~/imagenes/Calendar_scheduleHS.png" CausesValidation="False" />
            <ajaxToolkit:MaskedEditValidator ID="mevFECHA_REQUERIDA_FIN" runat="server"
                ControlExtender="meedFECHA_REQUERIDA_FIN" ControlToValidate="txtFECHA_REQUERIDA_FIN" 
                InvalidValueMessage="Fecha no Válida" Width="300px" Display="Dynamic" 
                ErrorMessage="MaskedEditValidatorDate" >
            </ajaxToolkit:MaskedEditValidator>
            <ajaxToolkit:MaskedEditExtender ID="meedFECHA_REQUERIDA_FIN" runat="server" 
                BehaviorID="meedFECHA_REQUERIDA_FIN" TargetControlID="txtFECHA_REQUERIDA_FIN" 
                MaskType=Date Mask="99/99/9999">
            </ajaxToolkit:MaskedEditExtender>    
            <ajaxToolkit:calendarextender id="cbeFECHA_REQUERIDA_FIN" runat="server" 
                popupbuttonid="ibtnCalendarFECHA_REQUERIDA_FIN" targetcontrolid="txtFECHA_REQUERIDA_FIN" 
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
