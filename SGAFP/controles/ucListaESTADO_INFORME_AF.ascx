<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaESTADO_INFORME_AF.ascx.vb" Inherits="controles_ucListaESTADO_INFORME_AF" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register src="ucVistaDetalleESTADO_INFORME_AF.ascx" tagname="ucVistaDetalleESTADO_INFORME_AF" tagprefix="uc1" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_ESTADO_INFORME">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
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
                    CommandArgument='<%# Bind("ID_ESTADO_INFORME") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_ESTADO_INFORME") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_ESTADO_INFORME" ReadOnly="True" VisibleIndex="2" Caption="Id estado informe" />
        <dx:GridViewDataTextColumn FieldName="ID_FASE_ESTADO" VisibleIndex="3" Caption="Id fase estado" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ESTADO_INFORME" VisibleIndex="4" Caption="Nombre estado informe" />
        <dx:GridViewDataTextColumn FieldName="DESCRIPCION_ESTADO" VisibleIndex="5" Caption="Descripcion estado" />
        <dx:GridViewDataTextColumn FieldName="USERID" VisibleIndex="6" Caption="Userid" />
        <dx:GridViewDataTextColumn FieldName="LASTUPDATE" VisibleIndex="7" Caption="Lastupdate" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="8">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>
    <Templates>
        <EditForm>
            <uc1:ucVistaDetalleESTADO_INFORME_AF ID="ucVistaDetalleESTADO_INFORME_AF1" runat="server" 
                ID_ESTADO_INFORME='<%# Bind("ID_ESTADO_INFORME") %>' ID_FASE_ESTADO='<%# Bind("ID_FASE_ESTADO") %>' NOMBRE_ESTADO_INFORME='<%# Bind("NOMBRE_ESTADO_INFORME") %>' DESCRIPCION_ESTADO='<%# Bind("DESCRIPCION_ESTADO") %>' USERID='<%# Bind("USERID") %>' LASTUPDATE='<%# Bind("LASTUPDATE") %>' />
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
    SelectMethod="ObtenerLista" InsertMethod="AgregarESTADO_INFORME_AF" DeleteMethod="EliminarESTADO_INFORME_AF" UpdateMethod="ActualizarESTADO_INFORME_AF"
    TypeName="SGAFP.BL.cESTADO_INFORME_AF">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ESTADO_INFORME" Type="Decimal" />
        <asp:Parameter Name="ID_FASE_ESTADO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_ESTADO_INFORME" Type="String" />
        <asp:Parameter Name="DESCRIPCION_ESTADO" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ESTADO_INFORME" Type="Decimal" />
        <asp:Parameter Name="ID_FASE_ESTADO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_ESTADO_INFORME" Type="String" />
        <asp:Parameter Name="DESCRIPCION_ESTADO" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ESTADO_INFORME" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorFASE_ESTADO_INFORME" runat="server" 
    SelectMethod="ObtenerListaPorFASE_ESTADO_INFORME" InsertMethod="AgregarESTADO_INFORME_AF" DeleteMethod="EliminarESTADO_INFORME_AF" UpdateMethod="ActualizarESTADO_INFORME_AF"
    TypeName="SGAFP.BL.cESTADO_INFORME_AF">
    <SelectParameters>
        <asp:Parameter Name="ID_FASE_ESTADO" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ESTADO_INFORME" Type="Decimal" />
        <asp:Parameter Name="ID_FASE_ESTADO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_ESTADO_INFORME" Type="String" />
        <asp:Parameter Name="DESCRIPCION_ESTADO" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ESTADO_INFORME" Type="Decimal" />
        <asp:Parameter Name="ID_FASE_ESTADO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_ESTADO_INFORME" Type="String" />
        <asp:Parameter Name="DESCRIPCION_ESTADO" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ESTADO_INFORME" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
