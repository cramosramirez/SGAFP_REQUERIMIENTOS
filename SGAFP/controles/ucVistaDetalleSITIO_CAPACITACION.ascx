<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleSITIO_CAPACITACION.ascx.vb" Inherits="controles_ucVistaDetalleSITIO_CAPACITACION" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<style type="text/css">       
       .textUpper input{text-transform:uppercase;}     
       .textLower input{text-transform:lowercase;}   
</style>
<table id="VistaDetalle" cellspacing="0" cellpadding="0" border="0">
	<tr runat="server" id="trID_SITIO_CAPACITACION">
		<td width="10"></td>
		<td align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_SITIO_CAPACITACION" runat="server" Text="Id sitio capacitacion:"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxTextBox CssClass="TextoLlaveDerecha" id="txtID_SITIO_CAPACITACION" runat="server" ReadOnly="True" Width="100px"></dx:ASPxTextBox></td>
		<td width="10"></td>
	</tr>
	<tr runat="server" id="trID_PROVEEDOR_AF">
		<td width="10"></td>
		<td align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_PROVEEDOR_AF" runat="server" Text="Proveedor:"></dx:ASPxLabel></td>
		<td>
		    <dx:ASPxComboBox ID="cbxPROVEEDOR_AF" ClientInstanceName="cbxPROVEEDOR_AF"  Width="300px" runat="server" 
                DataSourceID="odsProveedor" TextField="NOMBRE_PROVEEDOR" ValueField="ID_PROVEEDOR_AF" >
                <ClientSideEvents SelectedIndexChanged="function(s,e){
                                                            cbxSITIO_CAPACITACION.PerformCallback(cbxPROVEEDOR_AF.GetValue().toString());                                                                                                                
                                                        }"  />
            </dx:ASPxComboBox>
	    </td>
		<td width="10"></td>
	</tr>
	<tr runat="server" id="trNOMBRE_SITIO">
		<td width="10"></td>
		<td align="right"><dx:ASPxLabel CssClass="textUpper" id="lblNOMBRE_SITIO" runat="server" Text="Centro Formación:"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxComboBox ID="cbxSITIO_CAPACITACION" ClientInstanceName="cbxSITIO_CAPACITACION"  Width="300px" runat="server" 
                DataSourceID="odsSitioCapacitacion" TextField="NOMBRE_SITIO" ValueField="ID_SITIO_CAPACITACION" />
        </td>
		<td width="10"></td>
	</tr>
	<tr runat="server" id="trCODIGO_DEPARTAMENTO">
		<td width="10"></td>
		<td align="right"><dx:ASPxLabel CssClass="Normal" id="lblCODIGO_DEPARTAMENTO" runat="server" Text="Departamento:"></dx:ASPxLabel></td>
		<td>
		    <dx:ASPxComboBox ID="cbxDEPARTAMENTO" ClientInstanceName="cbxDEPARTAMENTO"  Width="180px" runat="server" IncrementalFilteringMode="StartsWith" DropDownStyle="DropDownList"
                    DataSourceID="odsDepartamento" TextField="NOMBRE" ValueField="CODIGO_DEPARTAMENTO" 
                    ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Departamento de residencia es requerido." >                                                    
                     <ClientSideEvents SelectedIndexChanged="function(s,e){
                                                            cbxMUNICIPIO.PerformCallback(cbxDEPARTAMENTO.GetValue().toString());                                                                                                                
                                                        }"  />
            </dx:ASPxComboBox>
	    </td>
		<td width="10"></td>
	</tr>
	<tr runat="server" id="trCODIGO_MUNICIPIO">
		<td width="10"></td>
		<td align="right"><dx:ASPxLabel CssClass="Normal" id="lblCODIGO_MUNICIPIO" runat="server" Text="Municipio:"></dx:ASPxLabel></td>
		<td>
		    <dx:ASPxComboBox ID="cbxMUNICIPIO" ClientInstanceName="cbxMUNICIPIO" Width="180px" runat="server" IncrementalFilteringMode="StartsWith" DropDownStyle="DropDownList"
                 DataSourceID="odsMunicipio" TextField="NOMBRE" ValueField="CODIGO_MUNICIPIO" EnableSynchronization="False"
                 ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Municipio de residencia es requerido." />     	
		</td>
		<td width="10"></td>
	</tr>	
	<tr runat="server" id="trFORMATO_CODIGO_CURSO">
		<td width="10"></td>
		<td align="right"><dx:ASPxLabel CssClass="Normal" id="lblFORMATO_CODIGO_CURSO" runat="server" Text="Formato codigo curso:"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxTextBox CssClass="textUpper" id="txtFORMATO_CODIGO_CURSO" runat="server" Width="100px" MaxLength="50">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</td>
		<td width="10"></td>
	</tr>
	<tr runat="server" id="trDIRECCION">
		<td width="10"></td>
		<td align="right"><dx:ASPxLabel CssClass="Normal" id="lblDIRECCION" runat="server" Text="Direccion:"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxTextBox CssClass="Normal" id="txtDIRECCION" runat="server" Width="300px" MaxLength="150">
			    <ValidationSettings Display="Dynamic" RequiredField-IsRequired="true" RequiredField-ErrorText="Se requiere Dirección" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="True">
			    </ValidationSettings>			    
			</dx:ASPxTextBox>
</td>
		<td width="10"></td>
	</tr>
	<tr runat="server" id="trTELEFONO">
		<td width="10"></td>
		<td align="right"><dx:ASPxLabel CssClass="Normal" id="lblTELEFONO" runat="server" Text="Telefono:"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxTextBox CssClass="textUpper" id="txtTELEFONO" runat="server" Width="180px" MaxLength="8">
			    <MaskSettings Mask="0000-0000" PromptChar="_" ErrorText="Teléfono no válido" IncludeLiterals="None" />   
			    <ValidationSettings Display="Dynamic" RequiredField-IsRequired="true" RequiredField-ErrorText="Se requiere Teléfono" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</td>
		<td width="10"></td>
	</tr>
	<tr runat="server" id="trFAX">
		<td width="10"></td>
		<td align="right"><dx:ASPxLabel CssClass="Normal" id="lblFAX" runat="server" Text="Fax:"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxTextBox CssClass="textUpper" id="txtFAX" runat="server" Width="180px" MaxLength="8">
			    <MaskSettings Mask="####-####" PromptChar="_" ErrorText="Fax no válido" IncludeLiterals="None"  />   
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</td>
		<td width="10"></td>
	</tr>
	<tr runat="server" id="trEMAIL">
		<td width="10"></td>
		<td align="right"><dx:ASPxLabel CssClass="Normal" id="lblEMAIL" runat="server" Text="Email:"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxTextBox CssClass="textLower" id="txtEMAIL" runat="server" Width="180px" MaxLength="50">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</td>
		<td width="10"></td>
	</tr>
	<tr runat="server" id="trNUMERO_AULAS">
		<td width="10"></td>
		<td align="right"><dx:ASPxLabel CssClass="Normal" id="lblNUMERO_AULAS" runat="server" Text="Numero aulas:"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxSpinEdit ID="txtNUMERO_AULAS" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</td>
		<td width="10"></td>
	</tr>
	<tr runat="server" id="trFECHA_REGISTRO">
		<td width="10"></td>
		<td align="right"><dx:ASPxLabel CssClass="Normal" id="lblFECHA_REGISTRO" runat="server" Text="Fecha registro:"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxDateEdit id="deFECHA_REGISTRO" runat="server" EditFormat="DateTime">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxDateEdit>
</td>
		<td width="10"></td>
	</tr>
	
	<tr runat="server" id="trENCARGADO">
		<td width="10"></td>
		<td align="right"><dx:ASPxLabel CssClass="Normal" id="lblENCARGADO" runat="server" Text="Encargado:"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxTextBox CssClass="Normal" id="txtENCARGADO" runat="server" Width="180px" MaxLength="60">
			    <ValidationSettings Display="Dynamic" RequiredField-IsRequired="true" RequiredField-ErrorText="Se requiere Encargado" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</td>
		<td width="10"></td>
	</tr>
	<tr runat="server" id="trCARGO_ENCARGADO">
		<td width="10"></td>
		<td align="right"><dx:ASPxLabel CssClass="Normal" id="lblCARGO_ENCARGADO" runat="server" Text="Cargo encargado:"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxTextBox CssClass="textUpper" id="txtCARGO_ENCARGADO" runat="server" Width="180px" MaxLength="60">
			    <ValidationSettings Display="Dynamic" RequiredField-IsRequired="true" RequiredField-ErrorText="Se requiere Cargo del Encargado" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</td>
		<td width="10"></td>
	</tr>
	<tr runat="server" id="trTELEFONO_ENCARGADO">
		<td width="10"></td>
		<td align="right"><dx:ASPxLabel CssClass="Normal" id="lblTELEFONO_ENCARGADO" runat="server" Text="Telefono encargado:"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtTELEFONO_ENCARGADO" runat="server" Width="180px" MaxLength="8">
			    <MaskSettings Mask="0000-0000" PromptChar="_" ErrorText="Teléfono no válido"  IncludeLiterals="None" />   
			    <ValidationSettings Display="Dynamic" RequiredField-IsRequired="true" RequiredField-ErrorText="Se requiere Teléfono del Encargado" ErrorDisplayMode="ImageWithTooltip" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</td>
		<td width="10"></td>
	</tr>
	<tr runat="server" id="trEMAIL_ENCARGADO">
		<td width="10"></td>
		<td align="right"><dx:ASPxLabel CssClass="Normal" id="lblEMAIL_ENCARGADO" runat="server" Text="Email encargado:"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxTextBox CssClass="textLower" id="txtEMAIL_ENCARGADO" runat="server" Width="180px" MaxLength="50">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</td>
		<td width="10"></td>
	</tr>
	
	<tr runat="server" id="trUSERID">
		<td width="10"></td>
		<td align="right"><dx:ASPxLabel CssClass="Normal" id="lblUSERID" runat="server" Text="Userid:"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxTextBox CssClass="textUpper" id="txtUSERID" runat="server" Width="100px" MaxLength="16">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</td>
		<td width="10"></td>
	</tr>
	<tr runat="server" id="trLASTUPDATE">
		<td width="10"></td>
		<td align="right"><dx:ASPxLabel CssClass="Normal" id="lblLASTUPDATE" runat="server" Text="Lastupdate:"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxDateEdit id="deLASTUPDATE" runat="server" EditFormat="DateTime">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxDateEdit>
</td>
		<td width="10"></td>
	</tr>
	<tr runat="server" id="trLATITUD">
		<td width="10"></td>
		<td align="right"><dx:ASPxLabel CssClass="Normal" id="lblLATITUD" runat="server" Text="Latitud:"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxTextBox ID="txtLATITUD" runat="server" Height="21px" MaxLength="30">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</td>
		<td width="10"></td>
	</tr>
	<tr runat="server" id="trLONGITUD">
		<td width="10"></td>
		<td align="right"><dx:ASPxLabel CssClass="Normal" id="lblLONGITUD" runat="server" Text="Longitud:"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxTextBox ID="txtLONGITUD" runat="server" Height="21px" MaxLength="30" >
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</td>
		<td width="10"></td>
	</tr>
</table>

<asp:ObjectDataSource ID="odsProveedor" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cPROVEEDOR_AF">
    <SelectParameters>               
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />        
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />      
        <asp:Parameter DefaultValue="NOMBRE_PROVEEDOR" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsSitioCapacitacion" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerListaPorPROVEEDOR_AF" TypeName="SGAFP.BL.cSITIO_CAPACITACION">
    <SelectParameters>               
        <asp:Parameter DefaultValue="0" Name="ID_PROVEEDOR_AF" Type="Decimal" />   
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />        
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />      
        <asp:Parameter DefaultValue="NOMBRE_SITIO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsDepartamento" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cDEPARTAMENTO">
    <SelectParameters>               
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />        
        <asp:Parameter DefaultValue="NOMBRE" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsMunicipio" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cMUNICIPIO">
    <SelectParameters>               
        <asp:Parameter DefaultValue="" Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />        
        <asp:Parameter DefaultValue="NOMBRE" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>