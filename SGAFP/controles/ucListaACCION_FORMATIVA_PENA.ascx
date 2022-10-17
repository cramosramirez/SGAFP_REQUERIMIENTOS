<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaACCION_FORMATIVA_PENA.ascx.vb" Inherits="controles_ucListaACCION_FORMATIVA_PENA" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register src="ucVistaDetalleACCION_FORMATIVA_PENA.ascx" tagname="ucVistaDetalleACCION_FORMATIVA_PENA" tagprefix="uc1" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" KeyFieldName="ID_ACCION_FORMATIVA_PENA" Width="100%" CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx" >
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
       <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" Visible="false" FieldName="Edicion" Caption=" " CellStyle-HorizontalAlign="Center" Width="50px" >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/editar.png"  CommandArgument='<%# Bind("ID_ACCION_FORMATIVA_PENA")%>'></asp:ImageButton>                                
            </DataItemTemplate>
<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_ACCION_FORMATIVA_PENA" ReadOnly="True" VisibleIndex="2" Caption="Id accion formativa pena" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_ACCION_FORMATIVA" VisibleIndex="3" Caption="Id Curso" />
        <dx:GridViewDataTextColumn FieldName="CONTRATO" VisibleIndex="3" Caption="Contrato" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR_AF" VisibleIndex="3" Caption="Proveedor" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ACCION_FORMATIVA" VisibleIndex="3" Caption="Nombre Curso" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_GRUPO" VisibleIndex="3" Caption="Codigo grupo" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="TIPO_PENALIZACION" VisibleIndex="3" Caption="Tipo Penalizacion" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="PORC_PENALIZACION" VisibleIndex="4" Caption="% Penalizacion" Width="100px" CellStyle-HorizontalAlign="Center" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" /> 
<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="MOTIVO" VisibleIndex="5" Caption="Motivo" CellStyle-Wrap="True" >
<CellStyle Wrap="True"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREACION" VisibleIndex="6" Caption="Usuario creacion" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_USUARIO" VisibleIndex="6" Caption="Usuario que aplicó" UnboundType="String" Width="200px" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREACION" VisibleIndex="7" Caption="Fecha aplicación" Width="120px" SortIndex="0" SortOrder="Descending"    >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" /> 
        </dx:GridViewDataTextColumn>        
	   </Columns>   
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
    <Images SpriteCssFilePath="~/App_Themes/DevEx/{0}/sprite.css">
        <LoadingPanelOnStatusBar Url="~/App_Themes/DevEx/GridView/StatusBarLoading.gif">
        </LoadingPanelOnStatusBar>
        <LoadingPanel Url="~/App_Themes/DevEx/GridView/Loading.gif">
        </LoadingPanel>
    </Images>
    <ImagesFilterControl>
        <LoadingPanel Url="~/App_Themes/DevEx/GridView/Loading.gif">
        </LoadingPanel>
    </ImagesFilterControl>
    <Styles CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx">
        <Header ImageSpacing="5px" SortingImageSpacing="5px">
        </Header>
        <LoadingPanel ImageSpacing="5px">
        </LoadingPanel>
    </Styles>
    <StylesEditors ButtonEditCellSpacing="0">
        <ProgressBar Height="21px">
        </ProgressBar>
    </StylesEditors>
</dx:ASPxGridView>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarACCION_FORMATIVA_PENA" DeleteMethod="EliminarACCION_FORMATIVA_PENA" UpdateMethod="ActualizarACCION_FORMATIVA_PENA"
    TypeName="SGAFP.BL.cACCION_FORMATIVA_PENA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ACCION_FORMATIVA_PENA" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="PORC_PENALIZACION" Type="Decimal" />
        <asp:Parameter Name="MOTIVO" Type="String" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ACCION_FORMATIVA_PENA" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="PORC_PENALIZACION" Type="Decimal" />
        <asp:Parameter Name="MOTIVO" Type="String" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ACCION_FORMATIVA_PENA" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorACCION_FORMATIVA" runat="server" 
    SelectMethod="ObtenerListaPorACCION_FORMATIVA" InsertMethod="AgregarACCION_FORMATIVA_PENA" DeleteMethod="EliminarACCION_FORMATIVA_PENA" UpdateMethod="ActualizarACCION_FORMATIVA_PENA"
    TypeName="SGAFP.BL.cACCION_FORMATIVA_PENA">
    <SelectParameters>
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ACCION_FORMATIVA_PENA" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="PORC_PENALIZACION" Type="Decimal" />
        <asp:Parameter Name="MOTIVO" Type="String" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ACCION_FORMATIVA_PENA" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="PORC_PENALIZACION" Type="Decimal" />
        <asp:Parameter Name="MOTIVO" Type="String" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ACCION_FORMATIVA_PENA" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
