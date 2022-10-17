<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetallePROGRAMA_FORMACION.ascx.vb" Inherits="controles_ucVistaDetallePROGRAMA_FORMACION" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_PROGRAMA_FORMACION">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_PROGRAMA_FORMACION" runat="server" Text="Id programa formacion:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoLlaveDerecha" id="txtID_PROGRAMA_FORMACION" runat="server" ClientEnabled="false" Width="70px">
                <DisabledStyle BackColor ="WhiteSmoke" ForeColor="Black"></DisabledStyle>
			</dx:ASPxTextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNOMBRE_PROGRAMA_FORMACION">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblNOMBRE_PROGRAMA_FORMACION"   runat="server" Text="Nombre programa formacion:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtNOMBRE_PROGRAMA_FORMACION" runat="server" Width="300px" MaxLength="100">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
                <DisabledStyle BackColor ="WhiteSmoke" ForeColor="Black"></DisabledStyle>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trUSERID" visible="false">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblUSERID" runat="server" Text="Userid:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtUSERID" runat="server" Width="40px" MaxLength="256" ReadOnly="True"></dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trLASTUPDATE" visible="false">
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
	<TR runat="server" id="trPORC_ASISTENCIA_MINIMA" visible="false">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblPORC_ASISTENCIA_MINIMA" runat="server" Text="Porc asistencia minima:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtPORC_ASISTENCIA_MINIMA" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5" Width="75px">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNOTA_MINIMA" visible="false">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblNOTA_MINIMA" runat="server" Text="Nota minima:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="txtNOTA_MINIMA" runat="server" Height="21px" Number="0" DecimalPlaces="2" Increment="0.5" Width="75px">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_TIPO_PAGO" visible="false" >
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_TIPO_PAGO" runat="server" Text="Programa formacion tipopago:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxComboBox ID="cbxPROGRAMA_FORMACION_TIPOPAGOID_TIPO_PAGO" runat="server" 
                DataSourceID="odsPROGRAMA_FORMACION_TIPOPAGO" Height="18px" TextField="NOMBRE_TIPO_PAGO" 
                ValueField="ID_TIPO_PAGO"
                ValueType="System.Int32">
         </dx:ASPxComboBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trMONTO_APOYO_PARTI">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="ASPxLabel1" runat="server" Text="Monto de apoyo por participante:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxSpinEdit ID="speMONTO_APOYO_PARTI" runat="server" DisplayFormatString="#,##0.00"  Height="21px" Number="0" DecimalPlaces="2" Increment="0.5" Width="170px">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor Numerico Invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxSpinEdit>
</TD>
		<TD width="10"></TD>
	</TR>
</TABLE>
<asp:ObjectDataSource ID="odsPROGRAMA_FORMACION_TIPOPAGO" runat="server" 
    OldValuesParameterFormatString="{0}" SelectMethod="ObtenerLista" 
    TypeName="SGAFP.BL.cPROGRAMA_FORMACION_TIPOPAGO">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter Name="asColumnaOrden" Type="String" />
        <asp:Parameter Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
