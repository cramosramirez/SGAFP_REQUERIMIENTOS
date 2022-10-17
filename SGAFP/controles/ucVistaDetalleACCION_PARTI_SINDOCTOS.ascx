<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleACCION_PARTI_SINDOCTOS.ascx.vb" Inherits="controles_ucVistaDetalleACCION_PARTI_SINDOCTOS" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_ACCION_PARTI">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_ACCION_PARTI" runat="server" Text="Id accion parti:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoLlaveDerecha" id="txtID_ACCION_PARTI" runat="server" ReadOnly="True" Width="70px"></dx:ASPxTextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_ACCION_FORMATIVA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_ACCION_FORMATIVA" 
                runat="server" Text="Nombre del Curso:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxComboBox ID="cbxACCION_FORMATIVAID_ACCION_FORMATIVA" runat="server" 
                DataSourceID="odsACCION_FORMATIVA" Height="18px" TextField="NOMBRE_ACCION_FORMATIVA" 
                ValueField="ID_ACCION_FORMATIVA" 
                ValueType="System.Decimal" Width="350px">
         </dx:ASPxComboBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trCANT_PARTICIPANTES">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblCANT_PARTICIPANTES" 
                runat="server" Text="Cantidad de Participantes exonerados:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtCANT_PARTICIPANTES" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5" Width="75px">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Cant participantes es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trES_ACTIVA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblES_ACTIVA" runat="server" Text="Es activa:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtES_ACTIVA" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5" Width="75px">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Es activa es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
    <TR runat="server" id="trTIPO_AUTORIZACION">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="ASPxLabel1" runat="server" Text="Tipo de Autorización:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxComboBox runat="server" ID="cbxTIPO_AUTORIZACION" 
                ValueType="System.String" Width="250px" DropDownStyle="DropDownList" >
                <Items>
                    <dx:ListEditItem Text="PARTICIPANTES SIN DOCUMENTOS" Value="S/D" />
                    <dx:ListEditItem Text="MENORES DE 16 AÑOS" Value="M/E" />
                </Items>
            </dx:ASPxComboBox>   
        </TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trUSUARIO_CREACION">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblUSUARIO_CREACION" runat="server" Text="Usuario creacion:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtUSUARIO_CREACION" runat="server" Width="100px" MaxLength="255">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Usuario creacion es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_CREACION">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblFECHA_CREACION" runat="server" Text="Fecha creacion:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deFECHA_CREACION" runat="server" EditFormat="DateTime">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="La fecha es Requerida" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxDateEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trUSERID">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblUSERID" runat="server" Text="Userid:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtUSERID" runat="server" Width="40px" MaxLength="255" ReadOnly="True"></dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trLASTUPDATE">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblLASTUPDATE" runat="server" Text="Lastupdate:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deLASTUPDATE" runat="server" EditFormat="DateTime">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="La fecha es Requerida" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxDateEdit>
</TD>
		<TD width="10"></TD>
	</TR>
    <tr>
        <th colspan="4" style="font-size: medium" align="justify">        
            </br><center><b>TIPOS DE AUTORIZACIÓN</b><br /></center>
            <span lang="ES" style="font-family:Arial">
                <b>PARTICIPANTES SIN DOCUMENTOS:</b><br />
                Eliga esta opción si desea autorizar inscripción de participantes que no poseen DUI y NIT. En esta autorización no interesa que edad tenga el participante simplemente el sistema no exigirá los documentos de identidad 
            al momento de la inscripción.<br /><br />
                <b>MENORES DE 16 AÑOS:</b><br />
                Eliga esta opción si desea autorizar inscripción de participantes menores de 16 años de edad. En esta autorización el sistema exigirá que el participante posea NIT.
            </span>
        </th>
    </tr>
</TABLE>
<asp:ObjectDataSource ID="odsACCION_FORMATIVA" runat="server" 
    OldValuesParameterFormatString="{0}" SelectMethod="ObtenerACCION_FORMATIVA" 
    TypeName="SGAFP.BL.cACCION_FORMATIVA">
    <SelectParameters>
        <asp:Parameter DefaultValue="-1" Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />        
    </SelectParameters>
</asp:ObjectDataSource>
