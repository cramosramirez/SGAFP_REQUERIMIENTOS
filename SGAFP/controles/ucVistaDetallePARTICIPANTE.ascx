<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetallePARTICIPANTE.ascx.vb" Inherits="controles_ucVistaDetallePARTICIPANTE" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="800px" border="0">
	<TR runat="server" id="trID_PARTICIPANTE">
		<TD width="10"></TD>
		<TD align="left" style="width:200px " ><dx:ASPxLabel CssClass="Normal" id="lblID_PARTICIPANTE" runat="server" Text="Id participante:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoLlaveDerecha" id="txtID_PARTICIPANTE" runat="server" ReadOnly="True" Width="300px"></dx:ASPxTextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNOMBRES">
		<TD width="10"></TD>
		<TD align="left"><dx:ASPxLabel CssClass="Normal" id="lblNOMBRES" runat="server" Text="Nombres:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtNOMBRES" runat="server" Width="300px" MaxLength="60">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Nombres es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trAPELLIDOS">
		<TD width="10"></TD>
		<TD align="left"><dx:ASPxLabel CssClass="Normal" id="lblAPELLIDOS" runat="server" Text="Apellidos:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtAPELLIDOS" runat="server" Width="300px" MaxLength="60">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Apellidos es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trGENERO">
		<TD width="10"></TD>
		<TD align="left"><dx:ASPxLabel CssClass="Normal" id="lblGENERO" runat="server" Text="Genero (M/F):"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtGENERO" runat="server" Width="100px" MaxLength="1">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Genero es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_PAIS">
		<TD width="10"></TD>
		<TD align="left"><dx:ASPxLabel CssClass="Normal" id="lblID_PAIS" runat="server" Text="Pais:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlPAIS id="ddlPAISID_PAIS" runat="server" CssClass="DDLClass" Width="300px" ></cc1:ddlPAIS></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_NACIMIENTO">
		<TD width="10"></TD>
		<TD align="left"><dx:ASPxLabel CssClass="Normal" id="lblFECHA_NACIMIENTO" runat="server" Text="Fecha nacimiento:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deFECHA_NACIMIENTO" runat="server" EditFormat="DateTime" Width="300px" DisplayFormatString="dd/MM/yyyy"  >                
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxDateEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDIRECCION">
		<TD width="10"></TD>
		<TD align="left"><dx:ASPxLabel CssClass="Normal" id="lblDIRECCION" runat="server" Text="Direccion:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtDIRECCION" runat="server" Width="500px" MaxLength="150">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDUI">
		<TD width="10"></TD>
		<TD align="left"><dx:ASPxLabel CssClass="Normal" id="lblDUI" runat="server"  Text="Dui:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtDUI" Font-Bold="true" Font-Size="Small" runat="server" Width="300px" >
                <MaskSettings Mask="99999999-9" IncludeLiterals="None" />   
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNIT">
		<TD width="10"></TD>
		<TD align="left"><dx:ASPxLabel CssClass="Normal" id="lblNIT" runat="server" Text="Nit:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtNIT" Font-Bold="true" Font-Size="Small" runat="server" Width="300px" >
                <MaskSettings Mask="9999-999999-999-9" IncludeLiterals="None" /> 
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trISSS">
		<TD width="10"></TD>
		<TD align="left"><dx:ASPxLabel CssClass="Normal" id="lblISSS" runat="server" Text="Isss:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtISSS" runat="server" Width="300px" MaxLength="9">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTIPO_DOCTO" visible="false" >
		<TD width="10"></TD>
		<TD align="left"><dx:ASPxLabel CssClass="Normal" id="lblTIPO_DOCTO" runat="server" Text="Tipo docto:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtTIPO_DOCTO" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNUM_DOCTO" visible="false">
		<TD width="10"></TD>
		<TD align="left"><dx:ASPxLabel CssClass="Normal" id="lblNUM_DOCTO" runat="server" Text="Num docto:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtNUM_DOCTO" runat="server" Width="300px" MaxLength="25">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTELEFONO">
		<TD width="10"></TD>
		<TD align="left"><dx:ASPxLabel CssClass="Normal" id="lblTELEFONO" runat="server" Text="Telefono:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtTELEFONO" runat="server" Width="300px" MaxLength="40">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trMOVIL">
		<TD width="10"></TD>
		<TD align="left"><dx:ASPxLabel CssClass="Normal" id="lblMOVIL" runat="server" Text="Movil:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtMOVIL" runat="server" Width="300px" MaxLength="40">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trEMAIL">
		<TD width="10"></TD>
		<TD align="left"><dx:ASPxLabel CssClass="Normal" id="lblEMAIL" runat="server" Text="Email:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtEMAIL" runat="server" Width="300px" MaxLength="100">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_ESTADO_CIVIL">
		<TD width="10"></TD>
		<TD align="left"><dx:ASPxLabel CssClass="Normal" id="lblID_ESTADO_CIVIL" runat="server" Text="Estado civil:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlESTADO_CIVIL id="ddlESTADO_CIVILID_ESTADO_CIVIL" runat="server" CssClass="DDLClass" Width="300px" ></cc1:ddlESTADO_CIVIL></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trPROFESION_OFICIO">
		<TD width="10"></TD>
		<TD align="left"><dx:ASPxLabel CssClass="Normal" id="lblPROFESION_OFICIO" runat="server" Text="Profesion oficio:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtPROFESION_OFICIO" runat="server" Width="300px" MaxLength="60">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trOCUPACION_ACTUAL">
		<TD width="10"></TD>
		<TD align="left"><dx:ASPxLabel CssClass="Normal" id="lblOCUPACION_ACTUAL" runat="server" Text="Ocupacion actual:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtOCUPACION_ACTUAL" runat="server" Width="300px" MaxLength="60">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTITULO_CERTIFICADO_OBTENIDO">
		<TD width="10"></TD>
		<TD align="left"><dx:ASPxLabel CssClass="Normal" id="lblTITULO_CERTIFICADO_OBTENIDO" runat="server" Text="Titulo certificado obtenido:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtTITULO_CERTIFICADO_OBTENIDO" runat="server" Width="300px" MaxLength="60">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDEPARTAMENTO_NAC" >
		<TD width="10"></TD>
		<TD align="left"><dx:ASPxLabel CssClass="Normal" id="lblDEPARTAMENTO_NAC" runat="server" Text="Departamento nacimiento:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlDEPARTAMENTO id="ddlDEPARTAMENTO_NACIMIENTO1" AutoPostBack="true" runat="server" CssClass="DDLClass" Width="300px" ></cc1:ddlDEPARTAMENTO>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trMUNICIPIO_NAC">
		<TD width="10"></TD>
		<TD align="left"><dx:ASPxLabel CssClass="Normal" id="lblMUNICIPIO_NAC" runat="server" Text="Municipio nacimiento:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlMUNICIPIO id="ddlMUNICIPIO_NACIMIENTO1" runat="server" CssClass="DDLClass" Width="300px"></cc1:ddlMUNICIPIO>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCODIGO_DEPARTAMENTO">
		<TD width="10"></TD>
		<TD align="left"><dx:ASPxLabel CssClass="Normal" id="lblCODIGO_DEPARTAMENTO" runat="server" Text="Departamento residencia:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlDEPARTAMENTO id="ddlDEPARTAMENTOCODIGO_DEPARTAMENTO" AutoPostBack="true" runat="server" CssClass="DDLClass" Width="300px" ></cc1:ddlDEPARTAMENTO></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCODIGO_MUNICIPIO">
		<TD width="10"></TD>
		<TD align="left"><dx:ASPxLabel CssClass="Normal" id="lblCODIGO_MUNICIPIO" runat="server" Text="Municipio residencia:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlMUNICIPIO id="ddlMUNICIPIOCODIGO_MUNICIPIO" runat="server" CssClass="DDLClass" Width="300px"></cc1:ddlMUNICIPIO></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_NIVEL_ACADEMICO">
		<TD width="10"></TD>
		<TD align="left"><dx:ASPxLabel CssClass="Normal" id="lblID_NIVEL_ACADEMICO" runat="server" Text="Nivel academico:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlNIVEL_ACADEMICO id="ddlNIVEL_ACADEMICOID_NIVEL_ACADEMICO" runat="server" CssClass="DDLClass" Width="300px"></cc1:ddlNIVEL_ACADEMICO></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trOTRA_EDUCACION_FORMAL">
		<TD width="10"></TD>
		<TD align="left"><dx:ASPxLabel CssClass="Normal" id="lblOTRA_EDUCACION_FORMAL" runat="server" Text="Otra educacion formal:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtOTRA_EDUCACION_FORMAL" runat="server" Width="300px" MaxLength="60">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCON_DISCAPACIDAD" visible="false">
		<TD width="10"></TD>
		<TD align="left"><dx:ASPxLabel CssClass="Normal" id="lblCON_DISCAPACIDAD" runat="server" Text="Con discapacidad:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtCON_DISCAPACIDAD" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDISC_OTRA" visible="false">
		<TD width="10"></TD>
		<TD align="left"><dx:ASPxLabel CssClass="Normal" id="lblDISC_OTRA" runat="server" Text="Disc otra:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtDISC_OTRA" runat="server" Width="100px" MaxLength="60">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trLASTUPDATE" visible="false">
		<TD width="10"></TD>
		<TD align="left"><dx:ASPxLabel CssClass="Normal" id="lblLASTUPDATE" runat="server" Text="Lastupdate:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deLASTUPDATE" runat="server" EditFormat="DateTime">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxDateEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trUSERID" visible="false" >
		<TD width="10"></TD>
		<TD align="left"><dx:ASPxLabel CssClass="Normal" id="lblUSERID" runat="server" Text="Userid:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtUSERID" runat="server" Width="40px" MaxLength="256" ReadOnly="True"></dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
</TABLE>
