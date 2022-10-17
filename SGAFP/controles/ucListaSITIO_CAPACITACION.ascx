<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaSITIO_CAPACITACION.ascx.vb" Inherits="controles_ucListaSITIO_CAPACITACION" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register src="ucVistaDetalleSITIO_CAPACITACION.ascx" tagname="ucVistaDetalleSITIO_CAPACITACION" tagprefix="uc1" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_SITIO_CAPACITACION" CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx">
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
                    CommandArgument='<%# Bind("ID_SITIO_CAPACITACION") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_SITIO_CAPACITACION") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_SITIO_CAPACITACION" ReadOnly="True" VisibleIndex="2" Caption="Id Centro" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_MUNICIPIO" VisibleIndex="3" Caption="Codigo municipio" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_DEPARTAMENTO" VisibleIndex="4" Caption="Codigo departamento" />
        <dx:GridViewDataTextColumn FieldName="ID_PROVEEDOR_AF" VisibleIndex="5" Caption="Id proveedor af" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_SITIO" VisibleIndex="6" Caption="Nombre Centro" />
        <dx:GridViewDataTextColumn FieldName="FORMATO_CODIGO_CURSO" VisibleIndex="7" Caption="Formato codigo curso" />
        <dx:GridViewDataTextColumn FieldName="DIRECCION" VisibleIndex="8" Caption="Direccion" />
        <dx:GridViewDataTextColumn FieldName="TELEFONO" VisibleIndex="9" Caption="Telefono" />
        <dx:GridViewDataTextColumn FieldName="FAX" VisibleIndex="10" Caption="Fax" />
        <dx:GridViewDataTextColumn FieldName="EMAIL" VisibleIndex="11" Caption="Email" />
        <dx:GridViewDataTextColumn FieldName="NUMERO_AULAS" VisibleIndex="12" Caption="Numero aulas" />
        <dx:GridViewDataTextColumn FieldName="FECHA_REGISTRO" VisibleIndex="13" Caption="Fecha registro" />
        <dx:GridViewDataTextColumn FieldName="ENCARGADO" VisibleIndex="14" Caption="Encargado" />
        <dx:GridViewDataTextColumn FieldName="TELEFONO_ENCARGADO" VisibleIndex="15" Caption="Telefono encargado" />
        <dx:GridViewDataTextColumn FieldName="EMAIL_ENCARGADO" VisibleIndex="16" Caption="Email encargado" />
        <dx:GridViewDataTextColumn FieldName="CARGO_ENCARGADO" VisibleIndex="17" Caption="Cargo encargado" />
        <dx:GridViewDataTextColumn FieldName="USERID" VisibleIndex="18" Caption="Userid" />
        <dx:GridViewDataTextColumn FieldName="LASTUPDATE" VisibleIndex="19" Caption="Lastupdate" />
        <dx:GridViewDataTextColumn FieldName="LATITUD" VisibleIndex="20" Caption="Latitud" />
        <dx:GridViewDataTextColumn FieldName="LONGITUD" VisibleIndex="21" Caption="Longitud" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="22" Visible="false"  >
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>
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
    <Templates>
        <EditForm>
            <uc1:ucVistaDetalleSITIO_CAPACITACION ID="ucVistaDetalleSITIO_CAPACITACION1" runat="server" 
                ID_SITIO_CAPACITACION='<%# Bind("ID_SITIO_CAPACITACION") %>' CODIGO_MUNICIPIO='<%# Bind("CODIGO_MUNICIPIO") %>' CODIGO_DEPARTAMENTO='<%# Bind("CODIGO_DEPARTAMENTO") %>' ID_PROVEEDOR_AF='<%# Bind("ID_PROVEEDOR_AF") %>' NOMBRE_SITIO='<%# Bind("NOMBRE_SITIO") %>' FORMATO_CODIGO_CURSO='<%# Bind("FORMATO_CODIGO_CURSO") %>' DIRECCION='<%# Bind("DIRECCION") %>' TELEFONO='<%# Bind("TELEFONO") %>' FAX='<%# Bind("FAX") %>' EMAIL='<%# Bind("EMAIL") %>' NUMERO_AULAS='<%# Bind("NUMERO_AULAS") %>' FECHA_REGISTRO='<%# Bind("FECHA_REGISTRO") %>' ENCARGADO='<%# Bind("ENCARGADO") %>' TELEFONO_ENCARGADO='<%# Bind("TELEFONO_ENCARGADO") %>' EMAIL_ENCARGADO='<%# Bind("EMAIL_ENCARGADO") %>' CARGO_ENCARGADO='<%# Bind("CARGO_ENCARGADO") %>' USERID='<%# Bind("USERID") %>' LASTUPDATE='<%# Bind("LASTUPDATE") %>' LATITUD='<%# Bind("LATITUD") %>' LONGITUD='<%# Bind("LONGITUD") %>' />
             <div style="text-align:right; padding:2px 2px 2px 2px"><table cellpadding="0" cellspacing="0">
                    <tr><td><dx:ASPxButton ID="btnGuardar" runat="server" AutoPostBack="False" Text="Guardar" Width="74px">   
                                <ClientSideEvents Click="function(s, e){if(!s.CauseValidation())return false;eval(s.cp_NombreClienteLista).UpdateEdit();}" />
                            </dx:ASPxButton></td>
                        <td style="padding-left: 13px;"><dx:ASPxButton ID="btnCancelar" runat="server" AutoPostBack="False" Text="Cancelar" Width="74px" CausesValidation="False">
                                <ClientSideEvents Click="function(s, e){eval(s.cp_NombreClienteLista).CancelEdit();}" />                            
             </dx:ASPxButton></td></tr></table></div>
        </EditForm>
        <EmptyDataRow>
            <dx:ASPxButton ID="btnAgregar" runat="server" AutoPostBack="False" Text="Agregar">
                <ClientSideEvents Click="function(s, e) {eval(s.cp_NombreClienteLista).AddNewRow();}" />
            </dx:ASPxButton>
            <dx:ASPxLabel ID="lblEmptyDataRow" runat="server" Text="No existen registros para mostrar"></dx:ASPxLabel>
        </EmptyDataRow>
    </Templates>
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarSITIO_CAPACITACION" DeleteMethod="EliminarSITIO_CAPACITACION" UpdateMethod="ActualizarSITIO_CAPACITACION"
    TypeName="SGAFP.BL.cSITIO_CAPACITACION">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_SITIO" Type="String" />
        <asp:Parameter Name="FORMATO_CODIGO_CURSO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="FAX" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="NUMERO_AULAS" Type="Decimal" />
        <asp:Parameter Name="FECHA_REGISTRO" Type="DateTime" />
        <asp:Parameter Name="ENCARGADO" Type="String" />
        <asp:Parameter Name="TELEFONO_ENCARGADO" Type="String" />
        <asp:Parameter Name="EMAIL_ENCARGADO" Type="String" />
        <asp:Parameter Name="CARGO_ENCARGADO" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="LATITUD" Type="Decimal" />
        <asp:Parameter Name="LONGITUD" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_SITIO" Type="String" />
        <asp:Parameter Name="FORMATO_CODIGO_CURSO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="FAX" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="NUMERO_AULAS" Type="Decimal" />
        <asp:Parameter Name="FECHA_REGISTRO" Type="DateTime" />
        <asp:Parameter Name="ENCARGADO" Type="String" />
        <asp:Parameter Name="TELEFONO_ENCARGADO" Type="String" />
        <asp:Parameter Name="EMAIL_ENCARGADO" Type="String" />
        <asp:Parameter Name="CARGO_ENCARGADO" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="LATITUD" Type="Decimal" />
        <asp:Parameter Name="LONGITUD" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorMUNICIPIO" runat="server" 
    SelectMethod="ObtenerListaPorMUNICIPIO" InsertMethod="AgregarSITIO_CAPACITACION" DeleteMethod="EliminarSITIO_CAPACITACION" UpdateMethod="ActualizarSITIO_CAPACITACION"
    TypeName="SGAFP.BL.cSITIO_CAPACITACION">
    <SelectParameters>
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_SITIO" Type="String" />
        <asp:Parameter Name="FORMATO_CODIGO_CURSO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="FAX" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="NUMERO_AULAS" Type="Decimal" />
        <asp:Parameter Name="FECHA_REGISTRO" Type="DateTime" />
        <asp:Parameter Name="ENCARGADO" Type="String" />
        <asp:Parameter Name="TELEFONO_ENCARGADO" Type="String" />
        <asp:Parameter Name="EMAIL_ENCARGADO" Type="String" />
        <asp:Parameter Name="CARGO_ENCARGADO" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="LATITUD" Type="Decimal" />
        <asp:Parameter Name="LONGITUD" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_SITIO" Type="String" />
        <asp:Parameter Name="FORMATO_CODIGO_CURSO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="FAX" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="NUMERO_AULAS" Type="Decimal" />
        <asp:Parameter Name="FECHA_REGISTRO" Type="DateTime" />
        <asp:Parameter Name="ENCARGADO" Type="String" />
        <asp:Parameter Name="TELEFONO_ENCARGADO" Type="String" />
        <asp:Parameter Name="EMAIL_ENCARGADO" Type="String" />
        <asp:Parameter Name="CARGO_ENCARGADO" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="LATITUD" Type="Decimal" />
        <asp:Parameter Name="LONGITUD" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorDEPARTAMENTO" runat="server" 
    SelectMethod="ObtenerListaPorDEPARTAMENTO" InsertMethod="AgregarSITIO_CAPACITACION" DeleteMethod="EliminarSITIO_CAPACITACION" UpdateMethod="ActualizarSITIO_CAPACITACION"
    TypeName="SGAFP.BL.cSITIO_CAPACITACION">
    <SelectParameters>
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_REGION" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_SITIO" Type="String" />
        <asp:Parameter Name="FORMATO_CODIGO_CURSO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="FAX" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="NUMERO_AULAS" Type="Decimal" />
        <asp:Parameter Name="FECHA_REGISTRO" Type="DateTime" />
        <asp:Parameter Name="ENCARGADO" Type="String" />
        <asp:Parameter Name="TELEFONO_ENCARGADO" Type="String" />
        <asp:Parameter Name="EMAIL_ENCARGADO" Type="String" />
        <asp:Parameter Name="CARGO_ENCARGADO" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="LATITUD" Type="Decimal" />
        <asp:Parameter Name="LONGITUD" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_SITIO" Type="String" />
        <asp:Parameter Name="FORMATO_CODIGO_CURSO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="FAX" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="NUMERO_AULAS" Type="Decimal" />
        <asp:Parameter Name="FECHA_REGISTRO" Type="DateTime" />
        <asp:Parameter Name="ENCARGADO" Type="String" />
        <asp:Parameter Name="TELEFONO_ENCARGADO" Type="String" />
        <asp:Parameter Name="EMAIL_ENCARGADO" Type="String" />
        <asp:Parameter Name="CARGO_ENCARGADO" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="LATITUD" Type="Decimal" />
        <asp:Parameter Name="LONGITUD" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPROVEEDOR_AF" runat="server" 
    SelectMethod="ObtenerListaPorPROVEEDOR_AF" InsertMethod="AgregarSITIO_CAPACITACION" DeleteMethod="EliminarSITIO_CAPACITACION" UpdateMethod="ActualizarSITIO_CAPACITACION"
    TypeName="SGAFP.BL.cSITIO_CAPACITACION">
    <SelectParameters>
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_SITIO" Type="String" />
        <asp:Parameter Name="FORMATO_CODIGO_CURSO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="FAX" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="NUMERO_AULAS" Type="Decimal" />
        <asp:Parameter Name="FECHA_REGISTRO" Type="DateTime" />
        <asp:Parameter Name="ENCARGADO" Type="String" />
        <asp:Parameter Name="TELEFONO_ENCARGADO" Type="String" />
        <asp:Parameter Name="EMAIL_ENCARGADO" Type="String" />
        <asp:Parameter Name="CARGO_ENCARGADO" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="LATITUD" Type="Decimal" />
        <asp:Parameter Name="LONGITUD" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_SITIO" Type="String" />
        <asp:Parameter Name="FORMATO_CODIGO_CURSO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="FAX" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="NUMERO_AULAS" Type="Decimal" />
        <asp:Parameter Name="FECHA_REGISTRO" Type="DateTime" />
        <asp:Parameter Name="ENCARGADO" Type="String" />
        <asp:Parameter Name="TELEFONO_ENCARGADO" Type="String" />
        <asp:Parameter Name="EMAIL_ENCARGADO" Type="String" />
        <asp:Parameter Name="CARGO_ENCARGADO" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="LATITUD" Type="Decimal" />
        <asp:Parameter Name="LONGITUD" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsListaPorSITIO_CAPACITACION" runat="server" 
    SelectMethod="ObtenerListaPorSITIO_CAPACITACION" 
    TypeName="SGAFP.BL.cSITIO_CAPACITACION">
    <SelectParameters>
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />     
    </SelectParameters>
</asp:ObjectDataSource>
