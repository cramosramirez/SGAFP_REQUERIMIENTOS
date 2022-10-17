<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleINFORME_FINAL_AF_HIS.ascx.vb" Inherits="controles_ucVistaDetalleINFORME_FINAL_AF_HIS" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_INFORME_FINAL_HIS">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_INFORME_FINAL_HIS" runat="server" Text="Id informe final his:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoLlaveDerecha" id="txtID_INFORME_FINAL_HIS" runat="server" ReadOnly="True" Width="70px"></dx:ASPxTextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_INFORME_FINAL">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_INFORME_FINAL" runat="server" Text="Informe final af:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxComboBox ID="cbxINFORME_FINAL_AFID_INFORME_FINAL" runat="server" 
                DataSourceID="odsINFORME_FINAL_AF" Height="18px" TextField="FECHA_INFORME" 
                ValueField="ID_INFORME_FINAL"
                ValueType="System.Int32">
         </dx:ASPxComboBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_ACCION_FORMATIVA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_ACCION_FORMATIVA" runat="server" Text="Accion formativa:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxComboBox ID="cbxACCION_FORMATIVAID_ACCION_FORMATIVA" runat="server" 
                DataSourceID="odsACCION_FORMATIVA" Height="18px" TextField="NOMBRE_ACCION_FORMATIVA" 
                ValueField="ID_ACCION_FORMATIVA"
                ValueType="System.Int32">
         </dx:ASPxComboBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_PROVEEDOR_AF">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_PROVEEDOR_AF" runat="server" Text="Proveedor af:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxComboBox ID="cbxPROVEEDOR_AFID_PROVEEDOR_AF" runat="server" 
                DataSourceID="odsPROVEEDOR_AF" Height="18px" TextField="NOMBRE_PROVEEDOR" 
                ValueField="ID_PROVEEDOR_AF"
                ValueType="System.Int32">
         </dx:ASPxComboBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_INFORME">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblFECHA_INFORME" runat="server" Text="Fecha informe:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deFECHA_INFORME" runat="server" EditFormat="DateTime">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="La fecha es Requerida" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxDateEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNUMERO_FACTURA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblNUMERO_FACTURA" runat="server" Text="Numero factura:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtNUMERO_FACTURA" runat="server" Width="100px" MaxLength="20">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trELABORADO_POR">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblELABORADO_POR" runat="server" Text="Elaborado por:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtELABORADO_POR" runat="server" Width="100px" MaxLength="70">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trMONTO_FACTURA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblMONTO_FACTURA" runat="server" Text="Monto factura:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtMONTO_FACTURA" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5" Width="75px">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Monto factura es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trMONTO_APROBADO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblMONTO_APROBADO" runat="server" Text="Monto aprobado:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtMONTO_APROBADO" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5" Width="75px">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Monto aprobado es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trPARTICIPANTES_INSCRITOS">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblPARTICIPANTES_INSCRITOS" runat="server" Text="Participantes inscritos:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtPARTICIPANTES_INSCRITOS" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5" Width="75px">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Participantes inscritos es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trPARTICIPANTES_FINALES">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblPARTICIPANTES_FINALES" runat="server" Text="Participantes finales:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtPARTICIPANTES_FINALES" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5" Width="75px">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Participantes finales es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trPORC_PROM_ASISTENCIA">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblPORC_PROM_ASISTENCIA" runat="server" Text="Porc prom asistencia:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtPORC_PROM_ASISTENCIA" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5" Width="75px">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Porc prom asistencia es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNOTA_PROMEDIO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblNOTA_PROMEDIO" runat="server" Text="Nota promedio:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtNOTA_PROMEDIO" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5" Width="75px">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>	
	<TR runat="server" id="trCOMENTARIOS">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblCOMENTARIOS" runat="server" Text="Comentarios:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtCOMENTARIOS" runat="server" Width="100px" MaxLength="1000">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trUSUARIO_APROBACION">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblUSUARIO_APROBACION" runat="server" Text="Usuario aprobacion:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtUSUARIO_APROBACION" runat="server" Width="100px" MaxLength="16">
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
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtUSERID" runat="server" Width="40px" MaxLength="256" ReadOnly="True"></dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_ESTADO_INFORME">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_ESTADO_INFORME" runat="server" Text="Estado informe af:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxComboBox ID="cbxESTADO_INFORME_AFID_ESTADO_INFORME" runat="server" 
                DataSourceID="odsESTADO_INFORME_AF" Height="18px" TextField="NOMBRE_ESTADO_INFORME" 
                ValueField="ID_ESTADO_INFORME"
                ValueType="System.Int32">
         </dx:ASPxComboBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trHORAS_DESARROLLADAS">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblHORAS_DESARROLLADAS" runat="server" Text="Horas desarrolladas:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtHORAS_DESARROLLADAS" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5" Width="75px">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_INICIAL">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblFECHA_INICIAL" runat="server" Text="Fecha inicial:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deFECHA_INICIAL" runat="server" EditFormat="DateTime">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxDateEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trFECHA_FINAL">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblFECHA_FINAL" runat="server" Text="Fecha final:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxDateEdit id="deFECHA_FINAL" runat="server" EditFormat="DateTime">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxDateEdit>
</TD>
		<TD width="10"></TD>
	</TR>
</TABLE>
<asp:ObjectDataSource ID="odsINFORME_FINAL_AF" runat="server" 
    OldValuesParameterFormatString="{0}" SelectMethod="ObtenerLista" 
    TypeName="SGAFP.BL.cINFORME_FINAL_AF">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter Name="asColumnaOrden" Type="String" />
        <asp:Parameter Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsACCION_FORMATIVA" runat="server" 
    OldValuesParameterFormatString="{0}" SelectMethod="ObtenerLista" 
    TypeName="SGAFP.BL.cACCION_FORMATIVA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter Name="asColumnaOrden" Type="String" />
        <asp:Parameter Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsPROVEEDOR_AF" runat="server" 
    OldValuesParameterFormatString="{0}" SelectMethod="ObtenerLista" 
    TypeName="SGAFP.BL.cPROVEEDOR_AF">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter Name="asColumnaOrden" Type="String" />
        <asp:Parameter Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsESTADO_INFORME_AF" runat="server" 
    OldValuesParameterFormatString="{0}" SelectMethod="ObtenerLista" 
    TypeName="SGAFP.BL.cESTADO_INFORME_AF">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter Name="asColumnaOrden" Type="String" />
        <asp:Parameter Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
