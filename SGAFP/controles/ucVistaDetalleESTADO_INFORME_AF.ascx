<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleESTADO_INFORME_AF.ascx.vb" Inherits="controles_ucVistaDetalleESTADO_INFORME_AF" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<TABLE id="VistaDetalle" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR runat="server" id="trID_ESTADO_INFORME">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_ESTADO_INFORME" runat="server" Text="Id estado informe:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoLlaveDerecha" id="txtID_ESTADO_INFORME" runat="server" ReadOnly="True" Width="70px"></dx:ASPxTextBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trID_FASE_ESTADO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_FASE_ESTADO" runat="server" Text="Fase estado informe:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxComboBox ID="cbxFASE_ESTADO_INFORMEID_FASE_ESTADO" runat="server" 
                DataSourceID="odsFASE_ESTADO_INFORME" Height="18px" TextField="NOMBRE_FASE_ESTADO" 
                ValueField="ID_FASE_ESTADO"
                ValueType="System.Int32">
         </dx:ASPxComboBox></TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trNOMBRE_ESTADO_INFORME">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblNOMBRE_ESTADO_INFORME" runat="server" Text="Nombre estado informe:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtNOMBRE_ESTADO_INFORME" runat="server" Width="100px" MaxLength="40">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Nombre estado informe es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxTextBox>
</TD>
		<TD width="10"></TD>
	</TR>
	<TR runat="server" id="trDESCRIPCION_ESTADO">
		<TD width="10"></TD>
		<TD align="right"><dx:ASPxLabel CssClass="Normal" id="lblDESCRIPCION_ESTADO" runat="server" Text="Descripcion estado:"></dx:ASPxLabel></TD>
		<TD>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtDESCRIPCION_ESTADO" runat="server" Width="100px" MaxLength="256">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Descripcion estado es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxTextBox>
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
</TABLE>
<asp:ObjectDataSource ID="odsFASE_ESTADO_INFORME" runat="server" 
    OldValuesParameterFormatString="{0}" SelectMethod="ObtenerLista" 
    TypeName="SGAFP.BL.cFASE_ESTADO_INFORME">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter Name="asColumnaOrden" Type="String" />
        <asp:Parameter Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
