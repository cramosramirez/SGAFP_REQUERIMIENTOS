<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCONTRATO_COMPRA.ascx.vb" Inherits="controles_ucListaCONTRATO_COMPRA" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_CONTRATO_COMPRA" Width="100%" CssFilePath="~/App_Themes/Office2010Silver/{0}/styles.css" CssPostfix="Office2010Silver" >
    <SettingsPager PageSize="15">
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />    
    <Columns>
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" CellStyle-HorizontalAlign="Center">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_CONTRATO_COMPRA") %>'></asp:ImageButton>
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_CONTRATO_COMPRA") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_CONTRATO_COMPRA" ReadOnly="True" VisibleIndex="2" Caption="Id contrato compra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="UNIDAD_ORGANIZATIVA" VisibleIndex="3" Caption="Unidad Organizativa" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="NO_CONTRATO_COMPRA" VisibleIndex="3" Caption="No. oferta de compra" />
        <dx:GridViewDataTextColumn FieldName="FECHA_INGRESO" VisibleIndex="4" Caption="Fecha de ingreso" SortIndex="0" SortOrder="Descending" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="5" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="6" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="7" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="8" Caption="Fecha act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_INI_EJEC" VisibleIndex="9" Caption="Fecha validez inicial" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="FECHA_FIN_EJEC" VisibleIndex="10" Caption="Fecha validez final" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="PORC_ASISTENCIA_MIN" VisibleIndex="11" Caption="% Mínimo de asistencia requerida" />
        <dx:GridViewDataCheckColumn FieldName="PAGO_POR_PARTICIPACION" VisibleIndex="12" Caption="Pago por participación" />
        <dx:GridViewDataTextColumn FieldName="BASE_PARTI" VisibleIndex="13" Caption="Base pago parti." Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ULTFECHA_CALENDARIZA" VisibleIndex="14" Caption="Ultfecha calendariza" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_UNIDAD_ORGANIZATIVA" VisibleIndex="15" Caption="Id unidad organizativa" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_USUARIO_CREA" VisibleIndex="15" Caption="Usuario registró" UnboundType="String" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="16">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text=" " Image-ToolTip="Eliminar" >
<Image ToolTip="Eliminar"></Image>
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
    <Images SpriteCssFilePath="~/App_Themes/Office2010Silver/{0}/sprite.css">
        <LoadingPanelOnStatusBar Url="~/App_Themes/Office2010Silver/GridView/Loading.gif">
        </LoadingPanelOnStatusBar>
        <LoadingPanel Url="~/App_Themes/Office2010Silver/GridView/Loading.gif">
        </LoadingPanel>
    </Images>
    <ImagesFilterControl>
        <LoadingPanel Url="~/App_Themes/Office2010Silver/GridView/Loading.gif">
        </LoadingPanel>
    </ImagesFilterControl>
    <Styles CssFilePath="~/App_Themes/Office2010Silver/{0}/styles.css" CssPostfix="Office2010Silver">
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
    SelectMethod="ObtenerLista" InsertMethod="AgregarCONTRATO_COMPRA" DeleteMethod="EliminarCONTRATO_COMPRA" UpdateMethod="ActualizarCONTRATO_COMPRA"
    TypeName="SGAFP.BL.cCONTRATO_COMPRA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />        
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CONTRATO_COMPRA" Type="Decimal" />
        <asp:Parameter Name="NO_CONTRATO_COMPRA" Type="String" />
        <asp:Parameter Name="FECHA_INGRESO" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="FECHA_INI_EJEC" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN_EJEC" Type="DateTime" />
        <asp:Parameter Name="PORC_ASISTENCIA_MIN" Type="Decimal" />
        <asp:Parameter Name="PAGO_POR_PARTICIPACION" Type="Decimal" />
        <asp:Parameter Name="BASE_PARTI" Type="Decimal" />
        <asp:Parameter Name="ULTFECHA_CALENDARIZA" Type="DateTime" />
        <asp:Parameter Name="ID_UNIDAD_ORGANIZATIVA" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CONTRATO_COMPRA" Type="Decimal" />
        <asp:Parameter Name="NO_CONTRATO_COMPRA" Type="String" />
        <asp:Parameter Name="FECHA_INGRESO" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="FECHA_INI_EJEC" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN_EJEC" Type="DateTime" />
        <asp:Parameter Name="PORC_ASISTENCIA_MIN" Type="Decimal" />
        <asp:Parameter Name="PAGO_POR_PARTICIPACION" Type="Decimal" />
        <asp:Parameter Name="BASE_PARTI" Type="Decimal" />
        <asp:Parameter Name="ULTFECHA_CALENDARIZA" Type="DateTime" />
        <asp:Parameter Name="ID_UNIDAD_ORGANIZATIVA" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CONTRATO_COMPRA" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorUNIDAD_ORGANIZATIVA" runat="server" 
    SelectMethod="ObtenerListaPorUNIDAD_ORGANIZATIVA" InsertMethod="AgregarCONTRATO_COMPRA" DeleteMethod="EliminarCONTRATO_COMPRA" UpdateMethod="ActualizarCONTRATO_COMPRA"
    TypeName="SGAFP.BL.cCONTRATO_COMPRA">
    <SelectParameters>
        <asp:Parameter Name="ID_UNIDAD_ORGANIZATIVA" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CONTRATO_COMPRA" Type="Decimal" />
        <asp:Parameter Name="NO_CONTRATO_COMPRA" Type="String" />
        <asp:Parameter Name="FECHA_INGRESO" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="FECHA_INI_EJEC" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN_EJEC" Type="DateTime" />
        <asp:Parameter Name="PORC_ASISTENCIA_MIN" Type="Decimal" />
        <asp:Parameter Name="PAGO_POR_PARTICIPACION" Type="Decimal" />
        <asp:Parameter Name="BASE_PARTI" Type="Decimal" />
        <asp:Parameter Name="ULTFECHA_CALENDARIZA" Type="DateTime" />
        <asp:Parameter Name="ID_UNIDAD_ORGANIZATIVA" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CONTRATO_COMPRA" Type="Decimal" />
        <asp:Parameter Name="NO_CONTRATO_COMPRA" Type="String" />
        <asp:Parameter Name="FECHA_INGRESO" Type="DateTime" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="FECHA_INI_EJEC" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN_EJEC" Type="DateTime" />
        <asp:Parameter Name="PORC_ASISTENCIA_MIN" Type="Decimal" />
        <asp:Parameter Name="PAGO_POR_PARTICIPACION" Type="Decimal" />
        <asp:Parameter Name="BASE_PARTI" Type="Decimal" />
        <asp:Parameter Name="ULTFECHA_CALENDARIZA" Type="DateTime" />
        <asp:Parameter Name="ID_UNIDAD_ORGANIZATIVA" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CONTRATO_COMPRA" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
