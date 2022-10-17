<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleACCION_FORMATIVA_PENA.ascx.vb" Inherits="controles_ucVistaDetalleACCION_FORMATIVA_PENA" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<TABLE id="VistaDetalle" cellSpacing="2" cellPadding="0" border="0">
	<TR runat="server" id="trID_ACCION_FORMATIVA_PENA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_ACCION_FORMATIVA_PENA" runat="server" Text="Id Penalización:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoLlaveDerecha" id="txtID_ACCION_FORMATIVA_PENA" runat="server" ReadOnly="True" Width="120px"></dx:ASPxTextBox></TD>		
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
	<TR runat="server" id="trPORC_PENALIZACION">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblPORC_PENALIZACION" runat="server" Text="(%) de Penalización:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtPORC_PENALIZACION" runat="server" Height="21px" Number="0" Font-Bold="true" DecimalPlaces="2" Increment="1">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Porcentaje penalizacion es requerido" IsRequired="True" />
			    </ValidationSettings>                
			</dx:ASPxSpinEdit>            
		</TD>	       
	</TR>
	<TR runat="server" id="trMOTIVO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblMOTIVO" runat="server" Text="Motivo:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxMemo CssClass="TextoNormalIzquierda" id="txtMOTIVO" runat="server" Width="100%" MaxLength="1000" Height="80px" >
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Motivo es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxMemo>
</TD>		
	</TR>
    
    <TR runat="server" id="trUSUARIO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="ASPxLabel2" runat="server" Text="Usuario:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtUSUARIO" runat="server" Width="100%" MaxLength="40">			    
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />
			</dx:ASPxTextBox>
</TD>
		
	</TR>	
        <TR runat="server" id="trFECHA_CREACION">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="ASPxLabel3" runat="server" Text="Fecha aplicación:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtFECHA_CREACION" runat="server" Width="150px" MaxLength="40">			    
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />
			</dx:ASPxTextBox>
</TD>
		
	</TR>
    <tr>
        <th colspan="4" style="font-size: medium" align="justify">        
            </br><center><b>RECORDATORIO</b><br /></center>
            <span lang="ES" style="font-family:Arial">                
                Si se han generado Informes de Ejecución para este curso se recalculará su monto a pagar descontándose el porcentaje penalizado. Esto puede tardar unos minutos.<br /><br />               
            </span>
        </th>
    </tr>
</TABLE>
