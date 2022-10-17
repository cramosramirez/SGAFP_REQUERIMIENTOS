<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleACCION_PROGRA_RETRO.ascx.vb" Inherits="controles_ucVistaDetalleACCION_PROGRA_RETRO" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<style type="text/css">
    .auto-style1 {
        height: 21px;
    }
</style>

<TABLE id="VistaDetalle" cellSpacing="2" cellPadding="0" border="0">
	<TR runat="server" id="trID_ACCION_PROGRA_RETRO">
		<TD width="10"></TD>
		<TD align="right" style="width:150px" ><dx:ASPxLabel CssClass="Normal" id="lblID_ACCION_PROGRA_RETRO" runat="server" Text="ID:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoLlaveDerecha" id="txtID_ACCION_PROGRA_RETRO" runat="server" ReadOnly="True" Width="70px"></dx:ASPxTextBox></TD>
		
	</TR>
	<TR runat="server" id="trID_PROVEEDOR_AF">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_PROVEEDOR_AF" runat="server" Text="Proveedor:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlPROVEEDOR_AF id="ddlPROVEEDOR_AFID_PROVEEDOR_AF" runat="server" Width="700px"  CssClass="DDLClass"></cc1:ddlPROVEEDOR_AF></TD>
		
	</TR>
	<TR runat="server" id="trID_EJERCICIO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_EJERCICIO" runat="server" Text="Ejercicio:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlEJERCICIO id="ddlEJERCICIOID_EJERCICIO" runat="server" Width="150px"  CssClass="DDLClass"></cc1:ddlEJERCICIO></TD>
		
	</TR>	
    <tr>
        <TD width="10"></TD>
        <TD align="right"><dx:ASPxLabel CssClass="Normal" id="ASPxLabel1" runat="server" Text="Tipo de Autorización:" ></dx:ASPxLabel></TD>
        <td>
            <asp:DropDownList ID="ddlESTADO_ACCION_FORMATIVA" AutoPostBack="true" runat="server" Width="400px" >
                <asp:ListItem Text="PROGRAMACION RETROACTIVA" Value="09" />  
                <asp:ListItem Text="FINALIZACION DE CURSO" Value="04" />
                <asp:ListItem Text="INSCRIPCION EXTEMPORANEA DE PARTICIPANTES" Value="02" />
                <asp:ListItem Text="HORARIO SIMULTANEO IMPARTIDO POR INSTRUCTOR" Value="90" />
                <asp:ListItem Text="HORARIO SIMULTANEO CURSO RECIBIDO POR PARTICIPANTE" Value="91" />
                <asp:ListItem Text="LIQUIDACION DE MONTO DE CONTRATO CON ESTE CURSO" Value="92" />
                <asp:ListItem Text="INICIAR CURSO POSTERIOR A LA ULTIMA FECHA INICIO DE CURSO EN OFERTA" Value="93" />
                <asp:ListItem Text="ELIMINAR ACCION FORMATIVA" Value="94" />
            </asp:DropDownList>
        </td>
    </tr>
	<TR runat="server" id="trNOMBRE_ACCION_FORMATIVA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblNOMBRE_ACCION_FORMATIVA" runat="server" Text="Descripción del Curso:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtNOMBRE_ACCION_FORMATIVA" runat="server" Width="100%" MaxLength="150">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Nombre accion formativa es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		
	</TR>
	<TR runat="server" id="trCODIGO_GRUPO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblCODIGO_GRUPO" runat="server" Text="Codigo curso:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtCODIGO_GRUPO" runat="server" Width="100%" MaxLength="40">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Codigo grupo es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		
	</TR>
	<TR runat="server" id="trFECHA_EXPIRA">
		<TD width="10" ></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblFECHA_EXPIRA" runat="server" Text="Fecha expira:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deFECHA_EXPIRA" Width="150px" runat="server" EditFormat="Custom" DisplayFormatString="dd/MM/yyyy"   >			   
			</dx:ASPxDateEdit>
</TD>
		
	</TR>
	<TR runat="server" id="trMOTIVO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblMOTIVO" runat="server" Text="Motivo de la autorización:"></dx:ASPxLabel></TD>
		<TD>           
			<dx:ASPxMemo CssClass="TextoNormalIzquierda" id="txtMOTIVO" runat="server" Width="100%" MaxLength="1000" Height="50px" >
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Motivo es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxMemo>
</TD>
		
	</TR>
	<TR runat="server" id="trACTIVO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblACTIVO" runat="server" Text="Activo:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxCheckBox ID="chkACTIVO" runat="server">			    
			</dx:ASPxCheckBox>
</TD>
		
	</TR>
	<TR runat="server" id="trUSUARIO_CREACION">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblUSUARIO_CREACION" runat="server" Text="Usuario autoriza:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtUSUARIO_CREACION" runat="server" Width="100%" MaxLength="255">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Usuario creacion es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		
	</TR>
	<TR runat="server" id="trFECHA_CREACION">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblFECHA_CREACION" runat="server" Text="Fecha autoriza:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deFECHA_CREACION" Width="150px" runat="server" EditFormat="Custom" DisplayFormatString="dd/MM/yyyy HH:mm" >
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="La fecha es Requerida" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxDateEdit>
</TD>
		
	</TR>
	<TR runat="server" id="trUSUARIO_PROGRAMO">
		<TD width="10" class="auto-style1"></TD>
		<TD align="right" class="auto-style1"><dx:ASPxLabel CssClass="Normal" id="lblUSUARIO_PROGRAMO" runat="server" Text="Usuario aplicó:"></dx:ASPxLabel></TD>
		<TD class="auto-style1">
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtUSUARIO_PROGRAMO" runat="server" Width="100%" MaxLength="255">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		
	</TR>
	<TR runat="server" id="trFECHA_PROGRAMO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblFECHA_PROGRAMO" runat="server" Text="Fecha aplicó:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deFECHA_PROGRAMO" Width="150px" runat="server" EditFormat="Custom" DisplayFormatString="dd/MM/yyyy" >
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxDateEdit>
</TD>		
	</TR>	
</TABLE>
