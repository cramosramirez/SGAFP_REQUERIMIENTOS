<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaACCION_PROGRA_RETRO.ascx.vb" Inherits="controles_ucListaACCION_PROGRA_RETRO" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" Width="100%"  KeyFieldName="ID_ACCION_PROGRA_RETRO" CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx">
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>       
        <dx:GridViewDataTextColumn VisibleIndex="1">
            <DataItemTemplate>
                <asp:LinkButton ID="lbtnEditar" runat="server" CommandName="Editar" 
                    CommandArgument='<%# Bind("ID_ACCION_PROGRA_RETRO") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_ACCION_PROGRA_RETRO") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_ACCION_PROGRA_RETRO" ReadOnly="True" VisibleIndex="2" Caption="Id accion progra retro" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_PROVEEDOR_AF" VisibleIndex="3" Caption="Id proveedor af" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_ACCION_FORMATIVA" VisibleIndex="5" Caption="Id accion formativa" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_EJERCICIO" VisibleIndex="6" Caption="Ejercicio" Width="70px"  />        
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" VisibleIndex="6" Caption="Proveedor" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ACCION_FORMATIVA" VisibleIndex="6" Caption="Curso" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_GRUPO" VisibleIndex="7" Caption="Codigo Grupo" Width="100px" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ESTADO_INFORME" VisibleIndex="7" Caption="Tipo Autorización" Width="100px" UnboundType="String"   />
        <dx:GridViewDataTextColumn FieldName="FECHA_EXPIRA" VisibleIndex="8" HeaderStyle-Wrap="True" Width="100px" Caption="Fecha Expira Autorización" >           
             <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy"  />

<HeaderStyle Wrap="True"></HeaderStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="MOTIVO" VisibleIndex="9" Caption="Motivo" Visible="false" />
        <dx:GridViewDataCheckColumn FieldName="ES_ACTIVO" VisibleIndex="10" Caption="Activo" Width="60px" UnboundType="Boolean" />        
        <dx:GridViewDataTextColumn FieldName="NOMBRE_USUARIO_AUTORIZO" VisibleIndex="11" Caption="Usuario Autorizo" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREACION" VisibleIndex="11" Caption="Fecha Autorizo" >           
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy HH:mm"  />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="NOMBRE_USUARIO_PROGRAMO" VisibleIndex="11" Caption="Usuario Programo" UnboundType="String" />  
        <dx:GridViewDataTextColumn FieldName="FECHA_PROGRAMACION" VisibleIndex="11" Caption="Fecha Programo" UnboundType="String" >            
        </dx:GridViewDataTextColumn>      
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " Name="Eliminar" VisibleIndex="17">
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

<asp:ObjectDataSource ID="odsCriterios" runat="server" SelectMethod="ObtenerACCION_PROGRA_RETRO_PorCriterios"  TypeName="SGAFP.BL.cACCION_PROGRA_RETRO">
    <SelectParameters>
        <asp:Parameter DefaultValue="-100" Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter DefaultValue="" Name="ID_EJERCICIO" Type="String" />
        <asp:Parameter DefaultValue="" Name="CODIGO_GRUPO" Type="String" />
        <asp:Parameter DefaultValue="" Name="CODIGO_ESTADO_AF_PROP" Type="String" />
        <asp:Parameter DefaultValue="" Name="ACTIVO" Type="Decimal" />
    </SelectParameters>   
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarACCION_PROGRA_RETRO" DeleteMethod="EliminarACCION_PROGRA_RETRO" UpdateMethod="ActualizarACCION_PROGRA_RETRO"
    TypeName="SGAFP.BL.cACCION_PROGRA_RETRO">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ACCION_PROGRA_RETRO" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_EJERCICIO" Type="String" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_ACCION_FORMATIVA" Type="String" />
        <asp:Parameter Name="CODIGO_GRUPO" Type="String" />
        <asp:Parameter Name="FECHA_EXPIRA" Type="DateTime" />
        <asp:Parameter Name="MOTIVO" Type="String" />
        <asp:Parameter Name="ACTIVO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_PROGRAMO" Type="String" />
        <asp:Parameter Name="FECHA_PROGRAMO" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ACCION_PROGRA_RETRO" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_EJERCICIO" Type="String" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_ACCION_FORMATIVA" Type="String" />
        <asp:Parameter Name="CODIGO_GRUPO" Type="String" />
        <asp:Parameter Name="FECHA_EXPIRA" Type="DateTime" />
        <asp:Parameter Name="MOTIVO" Type="String" />
        <asp:Parameter Name="ACTIVO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_PROGRAMO" Type="String" />
        <asp:Parameter Name="FECHA_PROGRAMO" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ACCION_PROGRA_RETRO" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPROVEEDOR_AF" runat="server" 
    SelectMethod="ObtenerListaPorPROVEEDOR_AF" InsertMethod="AgregarACCION_PROGRA_RETRO" DeleteMethod="EliminarACCION_PROGRA_RETRO" UpdateMethod="ActualizarACCION_PROGRA_RETRO"
    TypeName="SGAFP.BL.cACCION_PROGRA_RETRO">
    <SelectParameters>
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ACCION_PROGRA_RETRO" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_EJERCICIO" Type="String" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_ACCION_FORMATIVA" Type="String" />
        <asp:Parameter Name="CODIGO_GRUPO" Type="String" />
        <asp:Parameter Name="FECHA_EXPIRA" Type="DateTime" />
        <asp:Parameter Name="MOTIVO" Type="String" />
        <asp:Parameter Name="ACTIVO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_PROGRAMO" Type="String" />
        <asp:Parameter Name="FECHA_PROGRAMO" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ACCION_PROGRA_RETRO" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_EJERCICIO" Type="String" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_ACCION_FORMATIVA" Type="String" />
        <asp:Parameter Name="CODIGO_GRUPO" Type="String" />
        <asp:Parameter Name="FECHA_EXPIRA" Type="DateTime" />
        <asp:Parameter Name="MOTIVO" Type="String" />
        <asp:Parameter Name="ACTIVO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_PROGRAMO" Type="String" />
        <asp:Parameter Name="FECHA_PROGRAMO" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ACCION_PROGRA_RETRO" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorEJERCICIO" runat="server" 
    SelectMethod="ObtenerListaPorEJERCICIO" InsertMethod="AgregarACCION_PROGRA_RETRO" DeleteMethod="EliminarACCION_PROGRA_RETRO" UpdateMethod="ActualizarACCION_PROGRA_RETRO"
    TypeName="SGAFP.BL.cACCION_PROGRA_RETRO">
    <SelectParameters>
        <asp:Parameter Name="ID_EJERCICIO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ACCION_PROGRA_RETRO" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_EJERCICIO" Type="String" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_ACCION_FORMATIVA" Type="String" />
        <asp:Parameter Name="CODIGO_GRUPO" Type="String" />
        <asp:Parameter Name="FECHA_EXPIRA" Type="DateTime" />
        <asp:Parameter Name="MOTIVO" Type="String" />
        <asp:Parameter Name="ACTIVO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_PROGRAMO" Type="String" />
        <asp:Parameter Name="FECHA_PROGRAMO" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ACCION_PROGRA_RETRO" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_EJERCICIO" Type="String" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_ACCION_FORMATIVA" Type="String" />
        <asp:Parameter Name="CODIGO_GRUPO" Type="String" />
        <asp:Parameter Name="FECHA_EXPIRA" Type="DateTime" />
        <asp:Parameter Name="MOTIVO" Type="String" />
        <asp:Parameter Name="ACTIVO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_PROGRAMO" Type="String" />
        <asp:Parameter Name="FECHA_PROGRAMO" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ACCION_PROGRA_RETRO" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorACCION_FORMATIVA" runat="server" 
    SelectMethod="ObtenerListaPorACCION_FORMATIVA" InsertMethod="AgregarACCION_PROGRA_RETRO" DeleteMethod="EliminarACCION_PROGRA_RETRO" UpdateMethod="ActualizarACCION_PROGRA_RETRO"
    TypeName="SGAFP.BL.cACCION_PROGRA_RETRO">
    <SelectParameters>
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ACCION_PROGRA_RETRO" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_EJERCICIO" Type="String" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_ACCION_FORMATIVA" Type="String" />
        <asp:Parameter Name="CODIGO_GRUPO" Type="String" />
        <asp:Parameter Name="FECHA_EXPIRA" Type="DateTime" />
        <asp:Parameter Name="MOTIVO" Type="String" />
        <asp:Parameter Name="ACTIVO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_PROGRAMO" Type="String" />
        <asp:Parameter Name="FECHA_PROGRAMO" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ACCION_PROGRA_RETRO" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_EJERCICIO" Type="String" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_ACCION_FORMATIVA" Type="String" />
        <asp:Parameter Name="CODIGO_GRUPO" Type="String" />
        <asp:Parameter Name="FECHA_EXPIRA" Type="DateTime" />
        <asp:Parameter Name="MOTIVO" Type="String" />
        <asp:Parameter Name="ACTIVO" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_PROGRAMO" Type="String" />
        <asp:Parameter Name="FECHA_PROGRAMO" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ACCION_PROGRA_RETRO" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
