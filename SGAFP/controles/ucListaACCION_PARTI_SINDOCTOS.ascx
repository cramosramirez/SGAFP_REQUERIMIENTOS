<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaACCION_PARTI_SINDOCTOS.ascx.vb" Inherits="controles_ucListaACCION_PARTI_SINDOCTOS" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register src="ucVistaDetalleACCION_PARTI_SINDOCTOS.ascx" tagname="ucVistaDetalleACCION_PARTI_SINDOCTOS" tagprefix="uc1" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_ACCION_PARTI" CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx">
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
                    CommandArgument='<%# Bind("ID_ACCION_PARTI") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_ACCION_PARTI") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_ACCION_PARTI" ReadOnly="True" VisibleIndex="2" Caption="Id accion parti" />
        <dx:GridViewDataTextColumn FieldName="ID_ACCION_FORMATIVA" VisibleIndex="3" Caption="Id Curso" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ACCION_FORMATIVA" VisibleIndex="4" Caption="Curso" UnboundType="String"  />        
        <dx:GridViewDataTextColumn FieldName="CODIGO_GRUPO" VisibleIndex="5" Caption="Código Grupo" UnboundType="String" />        
        <dx:GridViewDataTextColumn FieldName="CANT_PARTICIPANTES" VisibleIndex="6" Caption="N° Participantes Exonerados" />        
        <dx:GridViewDataCheckColumn FieldName="ES_ACTIVA" VisibleIndex="7" Caption="Activa" ReadOnly="True" />
        <dx:GridViewDataTextColumn FieldName="AUTORIZACION" VisibleIndex="7" Caption="Tipo autorización" UnboundType="String" />        
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREACION" VisibleIndex="8" Caption="Usuario creacion" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREACION" VisibleIndex="9" Caption="Fecha creacion" />
        <dx:GridViewDataTextColumn FieldName="USERID" VisibleIndex="10" Caption="Userid" />
        <dx:GridViewDataTextColumn FieldName="LASTUPDATE" VisibleIndex="11" Caption="Lastupdate" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="10">
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
            <uc1:ucVistaDetalleACCION_PARTI_SINDOCTOS ID="ucVistaDetalleACCION_PARTI_SINDOCTOS1" runat="server" 
                ID_ACCION_PARTI='<%# Bind("ID_ACCION_PARTI") %>' ID_ACCION_FORMATIVA='<%# Bind("ID_ACCION_FORMATIVA") %>' CANT_PARTICIPANTES='<%# Bind("CANT_PARTICIPANTES") %>' ES_ACTIVA='<%# Bind("ES_ACTIVA") %>' USUARIO_CREACION='<%# Bind("USUARIO_CREACION") %>' FECHA_CREACION='<%# Bind("FECHA_CREACION") %>' USERID='<%# Bind("USERID") %>' LASTUPDATE='<%# Bind("LASTUPDATE") %>' />
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
    SelectMethod="ObtenerLista" InsertMethod="AgregarACCION_PARTI_SINDOCTOS" DeleteMethod="EliminarACCION_PARTI_SINDOCTOS" UpdateMethod="ActualizarACCION_PARTI_SINDOCTOS"
    TypeName="SGAFP.BL.cACCION_PARTI_SINDOCTOS">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ACCION_PARTI" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="CANT_PARTICIPANTES" Type="Decimal" />
        <asp:Parameter Name="ES_ACTIVA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="TIPO_AUTORIZACION" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ACCION_PARTI" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="CANT_PARTICIPANTES" Type="Decimal" />
        <asp:Parameter Name="ES_ACTIVA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="TIPO_AUTORIZACION" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ACCION_PARTI" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorACCION_FORMATIVA" runat="server" 
    SelectMethod="ObtenerListaPorACCION_FORMATIVA" InsertMethod="AgregarACCION_PARTI_SINDOCTOS" DeleteMethod="EliminarACCION_PARTI_SINDOCTOS" UpdateMethod="ActualizarACCION_PARTI_SINDOCTOS"
    TypeName="SGAFP.BL.cACCION_PARTI_SINDOCTOS">
    <SelectParameters>
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ACCION_PARTI" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="CANT_PARTICIPANTES" Type="Decimal" />
        <asp:Parameter Name="ES_ACTIVA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="TIPO_AUTORIZACION" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ACCION_PARTI" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="CANT_PARTICIPANTES" Type="Decimal" />
        <asp:Parameter Name="ES_ACTIVA" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="TIPO_AUTORIZACION" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ACCION_PARTI" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
