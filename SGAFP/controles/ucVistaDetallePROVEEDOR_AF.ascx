<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetallePROVEEDOR_AF.ascx.vb" Inherits="controles_ucVistaDetallePROVEEDOR_AF" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<TABLE id="VistaDetalle" cellSpacing="3" cellPadding="0" border="0">
	<TR runat="server" id="trID_PROVEEDOR_AF">
		<TD width="10"></TD>
		<TD align="right" width="300px"><dx:ASPxLabel id="lblID_PROVEEDOR_AF" runat="server" Text="ID Proveedor:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoLlaveDerecha" id="txtID_PROVEEDOR_AF" runat="server" ReadOnly="True" Width="70px"></dx:ASPxTextBox></TD>
		<TD width="10"></TD>
	</TR>
    <TR runat="server" id="trCODIGO_DEPARTAMENTO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel id="lblCODIGO_DEPARTAMENTO" runat="server" Text="Departamento:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlDEPARTAMENTO id="ddlDEPARTAMENTOCODIGO_DEPARTAMENTO" AutoPostBack="true" runat="server" Width="300px"  CssClass="DDLClass"></cc1:ddlDEPARTAMENTO></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCODIGO_MUNICIPIO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel id="lblCODIGO_MUNICIPIO" runat="server" Text="Municipio:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlMUNICIPIO id="ddlMUNICIPIOCODIGO_MUNICIPIO" runat="server" Width="300px" CssClass="DDLClass"></cc1:ddlMUNICIPIO></TD>
		<TD width="10"></TD>
	</TR>	
	<TR runat="server" id="trID_TIPO_PERSONA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel id="lblID_TIPO_PERSONA" runat="server" Text="Tipo persona:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlTIPO_PERSONA id="ddlTIPO_PERSONAID_TIPO_PERSONA" runat="server" Width="300px" CssClass="DDLClass"></cc1:ddlTIPO_PERSONA></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNOMBRE_PROVEEDOR">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel id="lblNOMBRE_PROVEEDOR" runat="server" Text="Nombre proveedor:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtNOMBRE_PROVEEDOR" runat="server" Width="500px" MaxLength="100" ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Nombre de Proveedor obligatorio."  /> 			    
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trRAZON_SOCIAL">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel id="lblRAZON_SOCIAL" runat="server" Text="Razon social:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtRAZON_SOCIAL" runat="server" Width="500px" MaxLength="150" ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Razon Social obligatoria.">			   
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNIT">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel id="lblNIT" runat="server" Text="NIT:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtNIT" runat="server" Width="300px" MaxLength="14" ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="NIT obligatorio.">
                <MaskSettings Mask="9999-999999-999-9" IncludeLiterals="None" /> 			    
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDUI">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel id="lblDUI" runat="server" Text="DUI:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtDUI" runat="server" Width="300px" MaxLength="9">
                <MaskSettings Mask="99999999-9" IncludeLiterals="None" /> 			   
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNRC">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel id="lblNRC" runat="server" Text="NRC:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtNRC" runat="server" Width="300px" MaxLength="20">			    
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trISSS">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel id="lblISSS" runat="server" Text="Isss:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtISSS" runat="server" Width="300px" MaxLength="9">			   
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_INGRESO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel id="lblFECHA_INGRESO" runat="server" Text="Fecha ingreso:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deFECHA_INGRESO" DisplayFormatString="dd/MM/yyyy" EditFormatString="dd/MM/yyyy" runat="server" EditFormat="DateTime">
                <DisabledStyle ForeColor="Black" />  
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxDateEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_ACREDITACION">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel id="lblFECHA_ACREDITACION" runat="server" Text="Fecha acreditacion:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deFECHA_ACREDITACION" DisplayFormatString="dd/MM/yyyy" EditFormatString="dd/MM/yyyy"  runat="server" EditFormat="DateTime" ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Fecha de acreditación requerida.">			   
			</dx:ASPxDateEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDIRECCION">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel id="lblDIRECCION" runat="server" Text="Direccion:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtDIRECCION" runat="server" Width="500px" MaxLength="200" ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Direccion es requerida.">			    
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trEMAIL">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel id="lblEMAIL" runat="server" Text="Email:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtEMAIL" runat="server" Width="300px" MaxLength="50">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTELEFONO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel id="lblTELEFONO" runat="server" Text="Telefono:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtTELEFONO" runat="server" Width="100px" MaxLength="8" ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Telefono es requerido.">			   
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFAX">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel id="lblFAX" runat="server" Text="Fax:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtFAX" runat="server" Width="100px" MaxLength="8">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trURL">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel id="lblURL" runat="server" Text="Url:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtURL" runat="server" Width="300px" MaxLength="255">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCONTACTO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel id="lblCONTACTO" runat="server" Text="Nombre del Contacto:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtCONTACTO" runat="server" Width="300px" MaxLength="80" ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Contacto es requerido.">			   
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTELEFONO_CONTACTO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel id="lblTELEFONO_CONTACTO" runat="server" Text="Telefono delcontacto:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtTELEFONO_CONTACTO" runat="server" Width="100px" MaxLength="8" ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Telefono de contacto es requerido.">			   
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trEMAIL_CONTACTO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel id="lblEMAIL_CONTACTO" runat="server" Text="Email del contacto:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtEMAIL_CONTACTO" runat="server" Width="300px" MaxLength="50">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCARGO_CONTACTO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel id="lblCARGO_CONTACTO" runat="server" Text="Cargo del contacto:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtCARGO_CONTACTO" runat="server" Width="300px" MaxLength="80" ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Cargo de contacto es requerido.">			   
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trESTADO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel id="lblESTADO" runat="server" Text="Estado:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtESTADO" runat="server" Width="100px" MaxLength="1">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNOTAS">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel id="lblNOTAS" runat="server" Text="Notas:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtNOTAS" runat="server" Width="100px" MaxLength="255">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trUSERID">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel id="lblUSERID" runat="server" Text="Userid:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtUSERID" runat="server" Width="40px" MaxLength="16" ReadOnly="True"></dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trLASTUPDATE">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel id="lblLASTUPDATE" runat="server" Text="Lastupdate:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deLASTUPDATE" runat="server" EditFormat="DateTime">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxDateEdit>
</TD>
		<TD width="10"></TD>
	</TR>
</TABLE>
