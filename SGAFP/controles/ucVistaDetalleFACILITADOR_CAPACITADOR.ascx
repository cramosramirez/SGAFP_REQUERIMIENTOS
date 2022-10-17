<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleFACILITADOR_CAPACITADOR.ascx.vb" Inherits="controles_ucVistaDetalleFACILITADOR_CAPACITADOR" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_FACILITADOR">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_FACILITADOR" runat="server" Text="Id facilitador:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoLlaveDerecha" id="txtID_FACILITADOR" runat="server" ReadOnly="True" Width="70px"></dx:ASPxTextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_TIPO_PERSONA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_TIPO_PERSONA" runat="server" Text="Tipo persona:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlTIPO_PERSONA id="ddlTIPO_PERSONAID_TIPO_PERSONA" runat="server" CssClass="DDLClass"></cc1:ddlTIPO_PERSONA></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_PROVEEDOR_AF">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_PROVEEDOR_AF" runat="server" Text="Proveedor af:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlPROVEEDOR_AF id="ddlPROVEEDOR_AFID_PROVEEDOR_AF" runat="server" CssClass="DDLClass"></cc1:ddlPROVEEDOR_AF></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCODIGO_MUNICIPIO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblCODIGO_MUNICIPIO" runat="server" Text="Municipio:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlMUNICIPIO id="ddlMUNICIPIOCODIGO_MUNICIPIO" runat="server" CssClass="DDLClass"></cc1:ddlMUNICIPIO></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCODIGO_DEPARTAMENTO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblCODIGO_DEPARTAMENTO" runat="server" Text="Departamento:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlDEPARTAMENTO id="ddlDEPARTAMENTOCODIGO_DEPARTAMENTO" runat="server" CssClass="DDLClass"></cc1:ddlDEPARTAMENTO></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNOMBRE_FACILITADOR">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblNOMBRE_FACILITADOR" runat="server" Text="Nombre facilitador:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtNOMBRE_FACILITADOR" runat="server" Width="100px" MaxLength="100">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNIT">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblNIT" runat="server" Text="Nit:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtNIT" runat="server" Width="100px" MaxLength="14">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDUI">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblDUI" runat="server" Text="Dui:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtDUI" runat="server" Width="100px" MaxLength="9">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trISSS">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblISSS" runat="server" Text="Isss:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtISSS" runat="server" Width="100px" MaxLength="9">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_INGRESO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblFECHA_INGRESO" runat="server" Text="Fecha ingreso:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deFECHA_INGRESO" runat="server" EditFormat="DateTime">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxDateEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTELEFONO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblTELEFONO" runat="server" Text="Telefono:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtTELEFONO" runat="server" Width="100px" MaxLength="8">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trEMAIL">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblEMAIL" runat="server" Text="Email:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtEMAIL" runat="server" Width="100px" MaxLength="50">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDIRECCION">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblDIRECCION" runat="server" Text="Direccion:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtDIRECCION" runat="server" Width="100px" MaxLength="150">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNOTAS">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblNOTAS" runat="server" Text="Notas:"></dx:ASPxLabel></TD>
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
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblUSERID" runat="server" Text="Userid:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtUSERID" runat="server" Width="40px" MaxLength="16" ReadOnly="True"></dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trLASTUPDATE">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblLASTUPDATE" runat="server" Text="Lastupdate:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deLASTUPDATE" runat="server" EditFormat="DateTime">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxDateEdit>
</TD>
		<TD width="10"></TD>
	</TR>
</TABLE>
