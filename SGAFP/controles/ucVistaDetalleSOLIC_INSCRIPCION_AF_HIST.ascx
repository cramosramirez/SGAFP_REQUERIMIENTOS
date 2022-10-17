<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleSOLIC_INSCRIPCION_AF_HIST.ascx.vb" Inherits="controles_ucVistaDetalleSOLIC_INSCRIPCION_AF_HIST" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_SOLICITUD_HIST">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_SOLICITUD_HIST" runat="server" Text="Id solicitud hist:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoLlaveDerecha" id="txtID_SOLICITUD_HIST" runat="server" ReadOnly="True" Width="70px"></dx:ASPxTextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_SOLICITUD">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_SOLICITUD" runat="server" Text="Solicitud inscripcion af:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlSOLICITUD_INSCRIPCION_AF id="ddlSOLICITUD_INSCRIPCION_AFID_SOLICITUD" runat="server" CssClass="DDLClass"></cc1:ddlSOLICITUD_INSCRIPCION_AF></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_PRESENTACION">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblFECHA_PRESENTACION" runat="server" Text="Fecha presentacion:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deFECHA_PRESENTACION" runat="server" EditFormat="DateTime">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="La fecha es Requerida" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxDateEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_PARTICIPANTE">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_PARTICIPANTE" runat="server" Text="Participante:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlPARTICIPANTE id="ddlPARTICIPANTEID_PARTICIPANTE" runat="server" CssClass="DDLClass"></cc1:ddlPARTICIPANTE></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_ACCION_FORMATIVA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_ACCION_FORMATIVA" runat="server" Text="Accion formativa:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlACCION_FORMATIVA id="ddlACCION_FORMATIVAID_ACCION_FORMATIVA" runat="server" CssClass="DDLClass"></cc1:ddlACCION_FORMATIVA></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_ESTADO_SOLICITUD">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_ESTADO_SOLICITUD" runat="server" Text="Estado solicitud:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlESTADO_SOLICITUD id="ddlESTADO_SOLICITUDID_ESTADO_SOLICITUD" runat="server" CssClass="DDLClass"></cc1:ddlESTADO_SOLICITUD></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNOMBRES">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblNOMBRES" runat="server" Text="Nombres:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtNOMBRES" runat="server" Width="100px" MaxLength="50">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Nombres es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trAPELLIDOS">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblAPELLIDOS" runat="server" Text="Apellidos:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtAPELLIDOS" runat="server" Width="100px" MaxLength="50">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Apellidos es requerido" IsRequired="True" />
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
	<TR runat="server" id="trTIPO_DOCTO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblTIPO_DOCTO" runat="server" Text="Tipo docto:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtTIPO_DOCTO" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNUM_DOCTO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblNUM_DOCTO" runat="server" Text="Num docto:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtNUM_DOCTO" runat="server" Width="100px" MaxLength="25">
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
	<TR runat="server" id="trID_TIPO_SOLICITUD">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_TIPO_SOLICITUD" runat="server" Text="Tipo solicitud:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlTIPO_SOLICITUD id="ddlTIPO_SOLICITUDID_TIPO_SOLICITUD" runat="server" CssClass="DDLClass"></cc1:ddlTIPO_SOLICITUD></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_PAIS">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_PAIS" runat="server" Text="Pais:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlPAIS id="ddlPAISID_PAIS" runat="server" CssClass="DDLClass"></cc1:ddlPAIS></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDEPARTAMENTO_NAC">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblDEPARTAMENTO_NAC" runat="server" Text="Departamento nac:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtDEPARTAMENTO_NAC" runat="server" Width="100px" MaxLength="2">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trMUNICIPIO_NAC">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblMUNICIPIO_NAC" runat="server" Text="Municipio nac:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtMUNICIPIO_NAC" runat="server" Width="100px" MaxLength="2">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_NACIMIENTO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblFECHA_NACIMIENTO" runat="server" Text="Fecha nacimiento:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deFECHA_NACIMIENTO" runat="server" EditFormat="DateTime">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxDateEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trGENERO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblGENERO" runat="server" Text="Genero:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtGENERO" runat="server" Width="100px" MaxLength="1">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trEDAD">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblEDAD" runat="server" Text="Edad:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtEDAD" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trMIEMBROS_GRUPO_FAMILIAR">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblMIEMBROS_GRUPO_FAMILIAR" runat="server" Text="Miembros grupo familiar:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtMIEMBROS_GRUPO_FAMILIAR" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_ESTADO_CIVIL">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_ESTADO_CIVIL" runat="server" Text="Estado civil:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlESTADO_CIVIL id="ddlESTADO_CIVILID_ESTADO_CIVIL" runat="server" CssClass="DDLClass"></cc1:ddlESTADO_CIVIL></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trES_JEFE_HOGAR">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblES_JEFE_HOGAR" runat="server" Text="Es jefe hogar:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtES_JEFE_HOGAR" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTIENE_HIJOS">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblTIENE_HIJOS" runat="server" Text="Tiene hijos:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtTIENE_HIJOS" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNO_DE_HIJOS">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblNO_DE_HIJOS" runat="server" Text="No de hijos:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtNO_DE_HIJOS" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trSE_DEDICA_ALGUNA_PROFESION">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblSE_DEDICA_ALGUNA_PROFESION" runat="server" Text="Se dedica alguna profesion:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtSE_DEDICA_ALGUNA_PROFESION" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trPROFESION_OFICIO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblPROFESION_OFICIO" runat="server" Text="Profesion oficio:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtPROFESION_OFICIO" runat="server" Width="100px" MaxLength="60">
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
	<TR runat="server" id="trCODIGO_DEPARTAMENTO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblCODIGO_DEPARTAMENTO" runat="server" Text="Departamento:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlDEPARTAMENTO id="ddlDEPARTAMENTOCODIGO_DEPARTAMENTO" runat="server" CssClass="DDLClass"></cc1:ddlDEPARTAMENTO></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCODIGO_MUNICIPIO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblCODIGO_MUNICIPIO" runat="server" Text="Municipio:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlMUNICIPIO id="ddlMUNICIPIOCODIGO_MUNICIPIO" runat="server" CssClass="DDLClass"></cc1:ddlMUNICIPIO></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTELEFONO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblTELEFONO" runat="server" Text="Telefono:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtTELEFONO" runat="server" Width="100px" MaxLength="40">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trMOVIL">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblMOVIL" runat="server" Text="Movil:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtMOVIL" runat="server" Width="100px" MaxLength="40">
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
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtEMAIL" runat="server" Width="100px" MaxLength="100">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCON_DISCAPACIDAD">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblCON_DISCAPACIDAD" runat="server" Text="Con discapacidad:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtCON_DISCAPACIDAD" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDISC_OTRA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblDISC_OTRA" runat="server" Text="Disc otra:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtDISC_OTRA" runat="server" Width="100px" MaxLength="60">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_LEE_ESCRIBE">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_LEE_ESCRIBE" runat="server" Text="Educ lee escribe:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlEDUC_LEE_ESCRIBE id="ddlEDUC_LEE_ESCRIBEID_LEE_ESCRIBE" runat="server" CssClass="DDLClass"></cc1:ddlEDUC_LEE_ESCRIBE></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_NIVEL_ACADEMICO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_NIVEL_ACADEMICO" runat="server" Text="Nivel academico:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlNIVEL_ACADEMICO id="ddlNIVEL_ACADEMICOID_NIVEL_ACADEMICO" runat="server" CssClass="DDLClass"></cc1:ddlNIVEL_ACADEMICO></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trOTRA_EDUCACION_FORMAL">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblOTRA_EDUCACION_FORMAL" runat="server" Text="Otra educacion formal:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtOTRA_EDUCACION_FORMAL" runat="server" Width="100px" MaxLength="60">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTITULO_CERTIFICADO_OBTENIDO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblTITULO_CERTIFICADO_OBTENIDO" runat="server" Text="Titulo certificado obtenido:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtTITULO_CERTIFICADO_OBTENIDO" runat="server" Width="100px" MaxLength="60">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trESTUDIA_ACTUALMENTE">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblESTUDIA_ACTUALMENTE" runat="server" Text="Estudia actualmente:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtESTUDIA_ACTUALMENTE" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_TIEMPO_DEJO_ESTUDIAR">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_TIEMPO_DEJO_ESTUDIAR" runat="server" Text="Tiempo dejo estudiar:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlTIEMPO_DEJO_ESTUDIAR id="ddlTIEMPO_DEJO_ESTUDIARID_TIEMPO_DEJO_ESTUDIAR" runat="server" CssClass="DDLClass"></cc1:ddlTIEMPO_DEJO_ESTUDIAR></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trRECIBIO_CURSO_ANTERIOR">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblRECIBIO_CURSO_ANTERIOR" runat="server" Text="Recibio curso anterior:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtRECIBIO_CURSO_ANTERIOR" runat="server" Width="100px" MaxLength="1">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trBENEF_PROM_EMP_ACT">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblBENEF_PROM_EMP_ACT" runat="server" Text="Benef prom emp act:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtBENEF_PROM_EMP_ACT" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trBENEF_OBT_EMPLEO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblBENEF_OBT_EMPLEO" runat="server" Text="Benef obt empleo:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtBENEF_OBT_EMPLEO" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trBENEF_OBT_ING_EXTRA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblBENEF_OBT_ING_EXTRA" runat="server" Text="Benef obt ing extra:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtBENEF_OBT_ING_EXTRA" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trBENEF_CAMB_EMP_X_CURSO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblBENEF_CAMB_EMP_X_CURSO" runat="server" Text="Benef camb emp x curso:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtBENEF_CAMB_EMP_X_CURSO" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trBENEF_TRAB_CTA_PROPIA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblBENEF_TRAB_CTA_PROPIA" runat="server" Text="Benef trab cta propia:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtBENEF_TRAB_CTA_PROPIA" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trBENEF_OTRO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblBENEF_OTRO" runat="server" Text="Benef otro:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtBENEF_OTRO" runat="server" Width="100px" MaxLength="100">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trRAZON_NO_BENEFICIO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblRAZON_NO_BENEFICIO" runat="server" Text="Razon no beneficio:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtRAZON_NO_BENEFICIO" runat="server" Width="100px" MaxLength="100">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trOCUACT_TRABAJA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblOCUACT_TRABAJA" runat="server" Text="Ocuact trabaja:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtOCUACT_TRABAJA" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trOCUACT_ESTUDIA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblOCUACT_ESTUDIA" runat="server" Text="Ocuact estudia:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtOCUACT_ESTUDIA" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trOCUACT_DESOCUPADO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblOCUACT_DESOCUPADO" runat="server" Text="Ocuact desocupado:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtOCUACT_DESOCUPADO" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trOCUACT_OFICIO_HOGAR">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblOCUACT_OFICIO_HOGAR" runat="server" Text="Ocuact oficio hogar:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtOCUACT_OFICIO_HOGAR" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trOCUACT_BUSCA_TRABAJO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblOCUACT_BUSCA_TRABAJO" runat="server" Text="Ocuact busca trabajo:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtOCUACT_BUSCA_TRABAJO" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trOCUACT_OTRA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblOCUACT_OTRA" runat="server" Text="Ocuact otra:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtOCUACT_OTRA" runat="server" Width="100px" MaxLength="100">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_TIPO_EMPLEO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_TIPO_EMPLEO" runat="server" Text="Tipo empleo:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlTIPO_EMPLEO id="ddlTIPO_EMPLEOID_TIPO_EMPLEO" runat="server" CssClass="DDLClass"></cc1:ddlTIPO_EMPLEO></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trSECTOR_EMPLEO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblSECTOR_EMPLEO" runat="server" Text="Sector empleo:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtSECTOR_EMPLEO" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTRABAJO_ANTERIOR">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblTRABAJO_ANTERIOR" runat="server" Text="Trabajo anterior:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtTRABAJO_ANTERIOR" runat="server" Width="100px" MaxLength="1">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trRECIBE_INGRESOS">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblRECIBE_INGRESOS" runat="server" Text="Recibe ingresos:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtRECIBE_INGRESOS" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trMANERA_OBT_ING_TRABAJO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblMANERA_OBT_ING_TRABAJO" runat="server" Text="Manera obt ing trabajo:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtMANERA_OBT_ING_TRABAJO" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trMANERA_OBT_ING_AYUDA_FAM">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblMANERA_OBT_ING_AYUDA_FAM" runat="server" Text="Manera obt ing ayuda fam:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtMANERA_OBT_ING_AYUDA_FAM" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trMANERA_OBT_ING_REMESA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblMANERA_OBT_ING_REMESA" runat="server" Text="Manera obt ing remesa:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtMANERA_OBT_ING_REMESA" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trMANERA_OBT_ING_PENSION">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblMANERA_OBT_ING_PENSION" runat="server" Text="Manera obt ing pension:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtMANERA_OBT_ING_PENSION" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trMANERA_OBT_ING_OTRO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblMANERA_OBT_ING_OTRO" runat="server" Text="Manera obt ing otro:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtMANERA_OBT_ING_OTRO" runat="server" Width="100px" MaxLength="60">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trEXPFOR_PROMOCION_EMPLEO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblEXPFOR_PROMOCION_EMPLEO" runat="server" Text="Expfor promocion empleo:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtEXPFOR_PROMOCION_EMPLEO" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trEXPFOR_CAMBIAR_EMPLEO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblEXPFOR_CAMBIAR_EMPLEO" runat="server" Text="Expfor cambiar empleo:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtEXPFOR_CAMBIAR_EMPLEO" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trEXPFOR_OBTENER_EMPLEO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblEXPFOR_OBTENER_EMPLEO" runat="server" Text="Expfor obtener empleo:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtEXPFOR_OBTENER_EMPLEO" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trEXPFOR_TRABAJAR_CTA_PROPIA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblEXPFOR_TRABAJAR_CTA_PROPIA" runat="server" Text="Expfor trabajar cta propia:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtEXPFOR_TRABAJAR_CTA_PROPIA" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trEXPFOR_INGRESOS_EXTRAS">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblEXPFOR_INGRESOS_EXTRAS" runat="server" Text="Expfor ingresos extras:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtEXPFOR_INGRESOS_EXTRAS" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trEXPFOR_NINGUNO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblEXPFOR_NINGUNO" runat="server" Text="Expfor ninguno:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtEXPFOR_NINGUNO" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trEXPFOR_OTRO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblEXPFOR_OTRO" runat="server" Text="Expfor otro:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtEXPFOR_OTRO" runat="server" Width="100px" MaxLength="100">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCURSO_REL_TRAB_ACTUAL">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblCURSO_REL_TRAB_ACTUAL" runat="server" Text="Curso rel trab actual:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtCURSO_REL_TRAB_ACTUAL" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCURSO_REL_TRAB_NUEVO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblCURSO_REL_TRAB_NUEVO" runat="server" Text="Curso rel trab nuevo:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtCURSO_REL_TRAB_NUEVO" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNOMBRE_REFERENCIA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblNOMBRE_REFERENCIA" runat="server" Text="Nombre referencia:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtNOMBRE_REFERENCIA" runat="server" Width="100px" MaxLength="80">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_REFERENCIA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_REFERENCIA" runat="server" Text="Referencia:"></dx:ASPxLabel></TD>
		<TD>
			<cc1:ddlREFERENCIA id="ddlREFERENCIAID_REFERENCIA" runat="server" CssClass="DDLClass"></cc1:ddlREFERENCIA></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDIRECCION_REFERENCIA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblDIRECCION_REFERENCIA" runat="server" Text="Direccion referencia:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtDIRECCION_REFERENCIA" runat="server" Width="100px" MaxLength="100">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDEPARTAMENTO_REFERENCIA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblDEPARTAMENTO_REFERENCIA" runat="server" Text="Departamento referencia:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtDEPARTAMENTO_REFERENCIA" runat="server" Width="100px" MaxLength="2">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trMUNICIPIO_REFERENCIA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblMUNICIPIO_REFERENCIA" runat="server" Text="Municipio referencia:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtMUNICIPIO_REFERENCIA" runat="server" Width="100px" MaxLength="2">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trTELEFONO_REFERENCIA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblTELEFONO_REFERENCIA" runat="server" Text="Telefono referencia:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtTELEFONO_REFERENCIA" runat="server" Width="100px" MaxLength="8">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trMOVIL_REFERENCIA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblMOVIL_REFERENCIA" runat="server" Text="Movil referencia:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtMOVIL_REFERENCIA" runat="server" Width="100px" MaxLength="8">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trEMAIL_REFERENCIA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblEMAIL_REFERENCIA" runat="server" Text="Email referencia:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtEMAIL_REFERENCIA" runat="server" Width="100px" MaxLength="100">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trSUGERENCIAS">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblSUGERENCIAS" runat="server" Text="Sugerencias:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtSUGERENCIAS" runat="server" Width="100px" MaxLength="600">
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
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtUSERID" runat="server" Width="100px" MaxLength="256">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
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
