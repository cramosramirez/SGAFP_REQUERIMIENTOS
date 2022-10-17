<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleACCION_FORMATIVA_SEGUI.ascx.vb" Inherits="controles_ucVistaDetalleACCION_FORMATIVA_SEGUI" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<TABLE id="VistaDetalle" cellSpacing="2" cellPadding="0" border="0">
	<TR runat="server" id="trID_ACCION_FORMATIVA_PENA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_ACCION_FORMATIVA_SEGUI" runat="server" Text="Id Seguimiento:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoLlaveDerecha" id="txtID_ACCION_FORMATIVA_SEGUI" runat="server" ReadOnly="True" Width="120px"></dx:ASPxTextBox></TD>		
	</TR>
	<TR runat="server" id="trID_ACCION_FORMATIVA">
		<TD width="10"></TD>
        <TD align="right"><dx:ASPxLabel CssClass="Normal" id="ASPxLabel1" runat="server" Text="Id Accion Formativa:"></dx:ASPxLabel></TD>
		<TD>
            <dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtID_ACCION_FORMATIVA" runat="server" Width="120px" MaxLength="150">			    
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />
			</dx:ASPxTextBox>
		</TD>
	</TR>
    <TR runat="server" id="trPROVEEDOR_AF">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="ASPxLabel4" runat="server" Text="Proveedor:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtPROVEEDOR_AF" runat="server" Width="600px" >			    
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />                                   
			</dx:ASPxTextBox>
</TD>
		
	</TR>
    <TR runat="server" id="trNOMBRE_ACCION_FORMATIVA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblNOMBRE_ACCION_FORMATIVA" runat="server" Text="Nombre del Curso:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtNOMBRE_ACCION_FORMATIVA" runat="server" Width="100%" >			   
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />                                   
			</dx:ASPxTextBox>
</TD>
		
	</TR>
	<TR runat="server" id="trCODIGO_GRUPO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblCODIGO_GRUPO" runat="server" Text="Codigo curso:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtCODIGO_GRUPO" runat="server" Width="100%" MaxLength="40">			   
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />
			</dx:ASPxTextBox>
</TD>
		
	</TR>
	<TR runat="server" id="trFECHA_VISITA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblFECHA_VISITA" runat="server" Text="Fecha visita:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deFECHA_VISITA" runat="server" EditFormat="Custom" DisplayFormatString="dd/MM/yyyy" Width="150px" >	
                 <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />		   
			</dx:ASPxDateEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trOBSERVACION">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblOBSERVACION" runat="server" Text="Observacion:"></dx:ASPxLabel></TD>
		<TD>			
            <dx:ASPxMemo CssClass="TextoNormalIzquierda" id="txtOBSERVACION" runat="server" Width="100%" MaxLength="1000" Height="200px" >			    
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />
			</dx:ASPxMemo>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCOMENTARIO_ADMIN_PROGRA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblCOMENTARIO_ADMIN_PROGRA" runat="server" Text="Comentario Administrador del Programa:"></dx:ASPxLabel></TD>
		<TD>			
            <dx:ASPxMemo CssClass="TextoNormalIzquierda" id="txtCOMENTARIO_ADMIN_PROGRA" runat="server" Width="100%" MaxLength="1000" Height="120px" >			    
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />
			</dx:ASPxMemo>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_UNIDAD_ORGANIZATIVA" visible="false">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_UNIDAD_ORGANIZATIVA" runat="server" Text="Unidad organizativa:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlUNIDAD_ORGANIZATIVA id="ddlUNIDAD_ORGANIZATIVAID_UNIDAD_ORGANIZATIVA" runat="server" Width="100%"  CssClass="DDLClass"></cc1:ddlUNIDAD_ORGANIZATIVA></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trUSUARIO_CREACION">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblUSUARIO_CREACION" runat="server" Text="Usuario creacion:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtUSUARIO_CREACION" runat="server" Width="100%" MaxLength="255">			    
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_CREACION">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblFECHA_CREACION" runat="server" Text="Fecha registro:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deFECHA_CREACION" runat="server" EditFormat="Custom" DisplayFormatString="dd/MM/yyyy HH:mm" Width="150px" >		
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />	    
			</dx:ASPxDateEdit>
</TD>
		<TD width="10"></TD>
	</TR>
</TABLE>
