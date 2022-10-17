<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaACCION_FORMATIVA_SEGUI.ascx.vb" Inherits="controles_ucListaACCION_FORMATIVA_SEGUI" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_ACCION_FORMATIVA_SEGUI" Font-Names="Arial Narrow" Font-Size="Small" Width="100%" CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx">
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
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/editar.png"  CommandArgument='<%# Bind("ID_ACCION_FORMATIVA_SEGUI")%>'></asp:ImageButton>                
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_ACCION_FORMATIVA_SEGUI") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_ACCION_FORMATIVA_SEGUI" ReadOnly="True" VisibleIndex="2" Caption="Id accion formativa segui" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_ACCION_FORMATIVA" VisibleIndex="3" Caption="Id accion formativa" Visible="false" />        
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" VisibleIndex="3" Caption="Proveedor" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ACCION_FORMATIVA" VisibleIndex="3" Caption="Curso" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_GRUPO" VisibleIndex="3" Caption="Código Grupo" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="FECHA_VISITA" VisibleIndex="4" Caption="Fecha Visita" Width="100px"  >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="OBSERVACION_BREVE" VisibleIndex="5" Caption="Observacion" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="COMENTARIO_ADMIN_PROGRA" VisibleIndex="6" Caption="Comentario admin progra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_UNIDAD_ORGANIZATIVA" VisibleIndex="7" Caption="Id unidad organizativa" Visible="false" />        
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREACION" VisibleIndex="8" Caption="Usuario creacion" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO" VisibleIndex="8" Caption="Usuario" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREACION" VisibleIndex="9" Caption="Fecha registro" Width="150px"  >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy HH:mm" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="10" Visible="false">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
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
    SelectMethod="ObtenerLista" InsertMethod="AgregarACCION_FORMATIVA_SEGUI" DeleteMethod="EliminarACCION_FORMATIVA_SEGUI" UpdateMethod="ActualizarACCION_FORMATIVA_SEGUI"
    TypeName="SGAFP.BL.cACCION_FORMATIVA_SEGUI">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ACCION_FORMATIVA_SEGUI" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="FECHA_VISITA" Type="DateTime" />
        <asp:Parameter Name="OBSERVACION" Type="String" />
        <asp:Parameter Name="COMENTARIO_ADMIN_PROGRA" Type="String" />
        <asp:Parameter Name="ID_UNIDAD_ORGANIZATIVA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ACCION_FORMATIVA_SEGUI" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="FECHA_VISITA" Type="DateTime" />
        <asp:Parameter Name="OBSERVACION" Type="String" />
        <asp:Parameter Name="COMENTARIO_ADMIN_PROGRA" Type="String" />
        <asp:Parameter Name="ID_UNIDAD_ORGANIZATIVA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ACCION_FORMATIVA_SEGUI" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorACCION_FORMATIVA" runat="server" 
    SelectMethod="ObtenerListaPorACCION_FORMATIVA" InsertMethod="AgregarACCION_FORMATIVA_SEGUI" DeleteMethod="EliminarACCION_FORMATIVA_SEGUI" UpdateMethod="ActualizarACCION_FORMATIVA_SEGUI"
    TypeName="SGAFP.BL.cACCION_FORMATIVA_SEGUI">
    <SelectParameters>
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ACCION_FORMATIVA_SEGUI" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="FECHA_VISITA" Type="DateTime" />
        <asp:Parameter Name="OBSERVACION" Type="String" />
        <asp:Parameter Name="COMENTARIO_ADMIN_PROGRA" Type="String" />
        <asp:Parameter Name="ID_UNIDAD_ORGANIZATIVA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ACCION_FORMATIVA_SEGUI" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="FECHA_VISITA" Type="DateTime" />
        <asp:Parameter Name="OBSERVACION" Type="String" />
        <asp:Parameter Name="COMENTARIO_ADMIN_PROGRA" Type="String" />
        <asp:Parameter Name="ID_UNIDAD_ORGANIZATIVA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ACCION_FORMATIVA_SEGUI" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorUNIDAD_ORGANIZATIVA" runat="server" 
    SelectMethod="ObtenerListaPorUNIDAD_ORGANIZATIVA" InsertMethod="AgregarACCION_FORMATIVA_SEGUI" DeleteMethod="EliminarACCION_FORMATIVA_SEGUI" UpdateMethod="ActualizarACCION_FORMATIVA_SEGUI"
    TypeName="SGAFP.BL.cACCION_FORMATIVA_SEGUI">
    <SelectParameters>
        <asp:Parameter Name="ID_UNIDAD_ORGANIZATIVA" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ACCION_FORMATIVA_SEGUI" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="FECHA_VISITA" Type="DateTime" />
        <asp:Parameter Name="OBSERVACION" Type="String" />
        <asp:Parameter Name="COMENTARIO_ADMIN_PROGRA" Type="String" />
        <asp:Parameter Name="ID_UNIDAD_ORGANIZATIVA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ACCION_FORMATIVA_SEGUI" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="FECHA_VISITA" Type="DateTime" />
        <asp:Parameter Name="OBSERVACION" Type="String" />
        <asp:Parameter Name="COMENTARIO_ADMIN_PROGRA" Type="String" />
        <asp:Parameter Name="ID_UNIDAD_ORGANIZATIVA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ACCION_FORMATIVA_SEGUI" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
