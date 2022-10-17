<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaPROVEEDOR_AF.ascx.vb" Inherits="controles_ucListaPROVEEDOR_AF" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" Width="100%" DataSourceID="odsLista" KeyFieldName="ID_PROVEEDOR_AF" CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx">
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
        <dx:GridViewCommandColumn Name="Edicion" Visible="False">
            <NewButton Visible="False" Text="Agregar">
            </NewButton>
            <EditButton Visible="False" Text="Editar"></EditButton>
            <DeleteButton Visible="False" Text="Eliminar"></DeleteButton>
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1">
            <DataItemTemplate>
                <asp:LinkButton ID="lbtnEditar" runat="server" CommandName="Editar" 
                    CommandArgument='<%# Bind("ID_PROVEEDOR_AF") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_PROVEEDOR_AF") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_PROVEEDOR_AF" ReadOnly="True" VisibleIndex="2" Caption="Id Proveedor" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_MUNICIPIO" VisibleIndex="3" Caption="Codigo municipio" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="CODIGO_DEPARTAMENTO" VisibleIndex="4" Caption="Codigo departamento" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_DEPARTAMENTO" VisibleIndex="4" Caption="Departamento" UnboundType="String"   />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_MUNICIPIO" VisibleIndex="4" Caption="Municipio" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_PERSONA" VisibleIndex="5" Caption="Id tipo persona" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" VisibleIndex="6" Caption="Nombre Proveedor" SortIndex="1" SortOrder="Ascending"    />
        <dx:GridViewDataTextColumn FieldName="RAZON_SOCIAL" VisibleIndex="7" Caption="Razon social" />
        <dx:GridViewDataTextColumn FieldName="NIT" VisibleIndex="8" Caption="NIT" />
        <dx:GridViewDataTextColumn FieldName="DUI" VisibleIndex="9" Caption="DUI" />
        <dx:GridViewDataTextColumn FieldName="NRC" VisibleIndex="10" Caption="NRC" />
        <dx:GridViewDataTextColumn FieldName="ISSS" VisibleIndex="11" Caption="Isss" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_INGRESO" VisibleIndex="12" Caption="Fecha ingreso" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACREDITACION" VisibleIndex="13" Caption="Fecha acreditacion" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="DIRECCION" VisibleIndex="14" Caption="Direccion" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="EMAIL" VisibleIndex="15" Caption="Email" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="TELEFONO" VisibleIndex="16" Caption="Telefono" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FAX" VisibleIndex="17" Caption="Fax" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="URL" VisibleIndex="18" Caption="Url" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CONTACTO" VisibleIndex="19" Caption="Contacto" />
        <dx:GridViewDataTextColumn FieldName="TELEFONO_CONTACTO" VisibleIndex="20" Caption="Telefono Contacto" />
        <dx:GridViewDataTextColumn FieldName="EMAIL_CONTACTO" VisibleIndex="21" Caption="Email contacto" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CARGO_CONTACTO" VisibleIndex="22" Caption="Cargo contacto" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ESTADO" VisibleIndex="23" Caption="Estado" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOTAS" VisibleIndex="24" Caption="Notas" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USERID" VisibleIndex="25" Caption="Userid" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="LASTUPDATE" VisibleIndex="26" Caption="Lastupdate" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " Visible="false" Name="Eliminar" VisibleIndex="27">
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
    SelectMethod="ObtenerLista" InsertMethod="AgregarPROVEEDOR_AF" DeleteMethod="EliminarPROVEEDOR_AF" UpdateMethod="ActualizarPROVEEDOR_AF"
    TypeName="SGAFP.BL.cPROVEEDOR_AF">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="ID_TIPO_PERSONA" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_PROVEEDOR" Type="String" />
        <asp:Parameter Name="RAZON_SOCIAL" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="FECHA_INGRESO" Type="DateTime" />
        <asp:Parameter Name="FECHA_ACREDITACION" Type="DateTime" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="FAX" Type="String" />
        <asp:Parameter Name="URL" Type="String" />
        <asp:Parameter Name="CONTACTO" Type="String" />
        <asp:Parameter Name="TELEFONO_CONTACTO" Type="String" />
        <asp:Parameter Name="EMAIL_CONTACTO" Type="String" />
        <asp:Parameter Name="CARGO_CONTACTO" Type="String" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="NOTAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="ID_TIPO_PERSONA" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_PROVEEDOR" Type="String" />
        <asp:Parameter Name="RAZON_SOCIAL" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="FECHA_INGRESO" Type="DateTime" />
        <asp:Parameter Name="FECHA_ACREDITACION" Type="DateTime" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="FAX" Type="String" />
        <asp:Parameter Name="URL" Type="String" />
        <asp:Parameter Name="CONTACTO" Type="String" />
        <asp:Parameter Name="TELEFONO_CONTACTO" Type="String" />
        <asp:Parameter Name="EMAIL_CONTACTO" Type="String" />
        <asp:Parameter Name="CARGO_CONTACTO" Type="String" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="NOTAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorMUNICIPIO" runat="server" 
    SelectMethod="ObtenerListaPorMUNICIPIO" InsertMethod="AgregarPROVEEDOR_AF" DeleteMethod="EliminarPROVEEDOR_AF" UpdateMethod="ActualizarPROVEEDOR_AF"
    TypeName="SGAFP.BL.cPROVEEDOR_AF">
    <SelectParameters>
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="ID_TIPO_PERSONA" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_PROVEEDOR" Type="String" />
        <asp:Parameter Name="RAZON_SOCIAL" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="FECHA_INGRESO" Type="DateTime" />
        <asp:Parameter Name="FECHA_ACREDITACION" Type="DateTime" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="FAX" Type="String" />
        <asp:Parameter Name="URL" Type="String" />
        <asp:Parameter Name="CONTACTO" Type="String" />
        <asp:Parameter Name="TELEFONO_CONTACTO" Type="String" />
        <asp:Parameter Name="EMAIL_CONTACTO" Type="String" />
        <asp:Parameter Name="CARGO_CONTACTO" Type="String" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="NOTAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="ID_TIPO_PERSONA" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_PROVEEDOR" Type="String" />
        <asp:Parameter Name="RAZON_SOCIAL" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="FECHA_INGRESO" Type="DateTime" />
        <asp:Parameter Name="FECHA_ACREDITACION" Type="DateTime" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="FAX" Type="String" />
        <asp:Parameter Name="URL" Type="String" />
        <asp:Parameter Name="CONTACTO" Type="String" />
        <asp:Parameter Name="TELEFONO_CONTACTO" Type="String" />
        <asp:Parameter Name="EMAIL_CONTACTO" Type="String" />
        <asp:Parameter Name="CARGO_CONTACTO" Type="String" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="NOTAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorDEPARTAMENTO" runat="server" 
    SelectMethod="ObtenerListaPorDEPARTAMENTO" InsertMethod="AgregarPROVEEDOR_AF" DeleteMethod="EliminarPROVEEDOR_AF" UpdateMethod="ActualizarPROVEEDOR_AF"
    TypeName="SGAFP.BL.cPROVEEDOR_AF">
    <SelectParameters>
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="ID_TIPO_PERSONA" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_PROVEEDOR" Type="String" />
        <asp:Parameter Name="RAZON_SOCIAL" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="FECHA_INGRESO" Type="DateTime" />
        <asp:Parameter Name="FECHA_ACREDITACION" Type="DateTime" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="FAX" Type="String" />
        <asp:Parameter Name="URL" Type="String" />
        <asp:Parameter Name="CONTACTO" Type="String" />
        <asp:Parameter Name="TELEFONO_CONTACTO" Type="String" />
        <asp:Parameter Name="EMAIL_CONTACTO" Type="String" />
        <asp:Parameter Name="CARGO_CONTACTO" Type="String" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="NOTAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="ID_TIPO_PERSONA" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_PROVEEDOR" Type="String" />
        <asp:Parameter Name="RAZON_SOCIAL" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="FECHA_INGRESO" Type="DateTime" />
        <asp:Parameter Name="FECHA_ACREDITACION" Type="DateTime" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="FAX" Type="String" />
        <asp:Parameter Name="URL" Type="String" />
        <asp:Parameter Name="CONTACTO" Type="String" />
        <asp:Parameter Name="TELEFONO_CONTACTO" Type="String" />
        <asp:Parameter Name="EMAIL_CONTACTO" Type="String" />
        <asp:Parameter Name="CARGO_CONTACTO" Type="String" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="NOTAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIPO_PERSONA" runat="server" 
    SelectMethod="ObtenerListaPorTIPO_PERSONA" InsertMethod="AgregarPROVEEDOR_AF" DeleteMethod="EliminarPROVEEDOR_AF" UpdateMethod="ActualizarPROVEEDOR_AF"
    TypeName="SGAFP.BL.cPROVEEDOR_AF">
    <SelectParameters>
        <asp:Parameter Name="ID_TIPO_PERSONA" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="ID_TIPO_PERSONA" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_PROVEEDOR" Type="String" />
        <asp:Parameter Name="RAZON_SOCIAL" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="FECHA_INGRESO" Type="DateTime" />
        <asp:Parameter Name="FECHA_ACREDITACION" Type="DateTime" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="FAX" Type="String" />
        <asp:Parameter Name="URL" Type="String" />
        <asp:Parameter Name="CONTACTO" Type="String" />
        <asp:Parameter Name="TELEFONO_CONTACTO" Type="String" />
        <asp:Parameter Name="EMAIL_CONTACTO" Type="String" />
        <asp:Parameter Name="CARGO_CONTACTO" Type="String" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="NOTAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="ID_TIPO_PERSONA" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_PROVEEDOR" Type="String" />
        <asp:Parameter Name="RAZON_SOCIAL" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NRC" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="FECHA_INGRESO" Type="DateTime" />
        <asp:Parameter Name="FECHA_ACREDITACION" Type="DateTime" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="FAX" Type="String" />
        <asp:Parameter Name="URL" Type="String" />
        <asp:Parameter Name="CONTACTO" Type="String" />
        <asp:Parameter Name="TELEFONO_CONTACTO" Type="String" />
        <asp:Parameter Name="EMAIL_CONTACTO" Type="String" />
        <asp:Parameter Name="CARGO_CONTACTO" Type="String" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="NOTAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
