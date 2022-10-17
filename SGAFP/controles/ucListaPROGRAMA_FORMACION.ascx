<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaPROGRAMA_FORMACION.ascx.vb" Inherits="controles_ucListaPROGRAMA_FORMACION" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register src="ucVistaDetallePROGRAMA_FORMACION.ascx" tagname="ucVistaDetallePROGRAMA_FORMACION" tagprefix="uc1" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_PROGRAMA_FORMACION" Width="100%" CssFilePath="~/App_Themes/Office2010Silver/{0}/styles.css" CssPostfix="Office2010Silver" >
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
        <dx:GridViewDataTextColumn VisibleIndex="1" CellStyle-HorizontalAlign="Center" Width="50px"  >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_PROGRAMA_FORMACION") %>'></asp:ImageButton>
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_PROGRAMA_FORMACION") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_PROGRAMA_FORMACION" ReadOnly="True" Width="170px"  VisibleIndex="2" Caption="Id programa formacion" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROGRAMA_FORMACION" VisibleIndex="3" Caption="Nombre programa formacion" />
        <dx:GridViewDataTextColumn FieldName="USERID" VisibleIndex="4" Caption="Userid" />
        <dx:GridViewDataTextColumn FieldName="LASTUPDATE" VisibleIndex="5" Caption="Lastupdate" />
        <dx:GridViewDataTextColumn FieldName="PORC_ASISTENCIA_MINIMA" VisibleIndex="6" Caption="Porc asistencia minima" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOTA_MINIMA" VisibleIndex="7" Caption="Nota minima" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_PAGO" VisibleIndex="8" Caption="Id tipo pago" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="MONTO_APOYO_PARTI" VisibleIndex="8" Caption="Monto apoyo por participante" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" /> 
        </dx:GridViewDataTextColumn>
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="9">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>
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
    <Templates>
        <EditForm>
            <uc1:ucVistaDetallePROGRAMA_FORMACION ID="ucVistaDetallePROGRAMA_FORMACION1" runat="server" 
                ID_PROGRAMA_FORMACION='<%# Bind("ID_PROGRAMA_FORMACION") %>' NOMBRE_PROGRAMA_FORMACION='<%# Bind("NOMBRE_PROGRAMA_FORMACION") %>' USERID='<%# Bind("USERID") %>' LASTUPDATE='<%# Bind("LASTUPDATE") %>' PORC_ASISTENCIA_MINIMA='<%# Bind("PORC_ASISTENCIA_MINIMA") %>' NOTA_MINIMA='<%# Bind("NOTA_MINIMA") %>' ID_TIPO_PAGO='<%# Bind("ID_TIPO_PAGO") %>' />
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
    SelectMethod="ObtenerLista" InsertMethod="AgregarPROGRAMA_FORMACION" DeleteMethod="EliminarPROGRAMA_FORMACION" UpdateMethod="ActualizarPROGRAMA_FORMACION"
    TypeName="SGAFP.BL.cPROGRAMA_FORMACION">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PROGRAMA_FORMACION" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_PROGRAMA_FORMACION" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="PORC_ASISTENCIA_MINIMA" Type="Decimal" />
        <asp:Parameter Name="NOTA_MINIMA" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_PAGO" Type="Decimal" />
        <asp:Parameter Name="MONTO_APOYO_PARTI" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PROGRAMA_FORMACION" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_PROGRAMA_FORMACION" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="PORC_ASISTENCIA_MINIMA" Type="Decimal" />
        <asp:Parameter Name="NOTA_MINIMA" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_PAGO" Type="Decimal" />
        <asp:Parameter Name="MONTO_APOYO_PARTI" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PROGRAMA_FORMACION" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPROGRAMA_FORMACION_TIPOPAGO" runat="server" 
    SelectMethod="ObtenerListaPorPROGRAMA_FORMACION_TIPOPAGO" InsertMethod="AgregarPROGRAMA_FORMACION" DeleteMethod="EliminarPROGRAMA_FORMACION" UpdateMethod="ActualizarPROGRAMA_FORMACION"
    TypeName="SGAFP.BL.cPROGRAMA_FORMACION">
    <SelectParameters>
        <asp:Parameter Name="ID_TIPO_PAGO" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PROGRAMA_FORMACION" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_PROGRAMA_FORMACION" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="PORC_ASISTENCIA_MINIMA" Type="Decimal" />
        <asp:Parameter Name="NOTA_MINIMA" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_PAGO" Type="Decimal" />
        <asp:Parameter Name="MONTO_APOYO_PARTI" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PROGRAMA_FORMACION" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_PROGRAMA_FORMACION" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="PORC_ASISTENCIA_MINIMA" Type="Decimal" />
        <asp:Parameter Name="NOTA_MINIMA" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_PAGO" Type="Decimal" />
        <asp:Parameter Name="MONTO_APOYO_PARTI" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PROGRAMA_FORMACION" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
