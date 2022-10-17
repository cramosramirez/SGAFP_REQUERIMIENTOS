<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaUNIDAD_ORGANIZATIVA.ascx.vb" Inherits="controles_ucListaUNIDAD_ORGANIZATIVA" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register src="ucVistaDetalleUNIDAD_ORGANIZATIVA.ascx" tagname="ucVistaDetalleUNIDAD_ORGANIZATIVA" tagprefix="uc1" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_UNIDAD_ORGANIZATIVA">
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
                    CommandArgument='<%# Bind("ID_UNIDAD_ORGANIZATIVA") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_UNIDAD_ORGANIZATIVA") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_UNIDAD_ORGANIZATIVA" ReadOnly="True" VisibleIndex="2" Caption="Id unidad organizativa" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_UNIDAD" VisibleIndex="3" Caption="Nombre unidad" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_UNIDAD" VisibleIndex="4" Caption="Codigo unidad" />
        <dx:GridViewDataTextColumn FieldName="ID_UNIDAD_PADRE" VisibleIndex="5" Caption="Id unidad padre" />
        <dx:GridViewDataTextColumn FieldName="ESTADO" VisibleIndex="6" Caption="Estado" />
        <dx:GridViewDataTextColumn FieldName="USERID" VisibleIndex="7" Caption="Userid" />
        <dx:GridViewDataTextColumn FieldName="LASTUPDATE" VisibleIndex="8" Caption="Lastupdate" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="9">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>
    <Templates>
        <EditForm>
            <uc1:ucVistaDetalleUNIDAD_ORGANIZATIVA ID="ucVistaDetalleUNIDAD_ORGANIZATIVA1" runat="server" 
                ID_UNIDAD_ORGANIZATIVA='<%# Bind("ID_UNIDAD_ORGANIZATIVA") %>' NOMBRE_UNIDAD='<%# Bind("NOMBRE_UNIDAD") %>' CODIGO_UNIDAD='<%# Bind("CODIGO_UNIDAD") %>' ID_UNIDAD_PADRE='<%# Bind("ID_UNIDAD_PADRE") %>' ESTADO='<%# Bind("ESTADO") %>' USERID='<%# Bind("USERID") %>' LASTUPDATE='<%# Bind("LASTUPDATE") %>' />
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
    SelectMethod="ObtenerLista" InsertMethod="AgregarUNIDAD_ORGANIZATIVA" DeleteMethod="EliminarUNIDAD_ORGANIZATIVA" UpdateMethod="ActualizarUNIDAD_ORGANIZATIVA"
    TypeName="SGAFP.BL.cUNIDAD_ORGANIZATIVA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_UNIDAD_ORGANIZATIVA" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_UNIDAD" Type="String" />
        <asp:Parameter Name="CODIGO_UNIDAD" Type="String" />
        <asp:Parameter Name="ID_UNIDAD_PADRE" Type="Decimal" />
        <asp:Parameter Name="ESTADO" Type="Decimal" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_UNIDAD_ORGANIZATIVA" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_UNIDAD" Type="String" />
        <asp:Parameter Name="CODIGO_UNIDAD" Type="String" />
        <asp:Parameter Name="ID_UNIDAD_PADRE" Type="Decimal" />
        <asp:Parameter Name="ESTADO" Type="Decimal" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_UNIDAD_ORGANIZATIVA" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
