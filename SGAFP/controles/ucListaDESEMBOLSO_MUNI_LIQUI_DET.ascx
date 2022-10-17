<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaDESEMBOLSO_MUNI_LIQUI_DET.ascx.vb" Inherits="controles_ucListaDESEMBOLSO_MUNI_LIQUI_DET" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register src="ucVistaDetalleDESEMBOLSO_MUNI_LIQUI_DET.ascx" tagname="ucVistaDetalleDESEMBOLSO_MUNI_LIQUI_DET" tagprefix="uc1" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_DESEMBOLSO_MUNI">
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
                    CommandArgument='<%# Bind("ID_DESEMBOLSO_MUNI") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_DESEMBOLSO_MUNI") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_DESEMBOLSO_MUNI" ReadOnly="True" VisibleIndex="2" Caption="Id desembolso muni" />
        <dx:GridViewDataTextColumn FieldName="ID_DESEMBOLSO" VisibleIndex="3" Caption="Id desembolso" />
        <dx:GridViewDataTextColumn FieldName="ID_LIQUIDACION_DET" VisibleIndex="4" Caption="Id liquidacion det" />
        <dx:GridViewDataTextColumn FieldName="MONTO_DESEMBOLSO" VisibleIndex="5" Caption="Monto desembolso" />
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
            <uc1:ucVistaDetalleDESEMBOLSO_MUNI_LIQUI_DET ID="ucVistaDetalleDESEMBOLSO_MUNI_LIQUI_DET1" runat="server" 
                ID_DESEMBOLSO_MUNI='<%# Bind("ID_DESEMBOLSO_MUNI") %>' ID_DESEMBOLSO='<%# Bind("ID_DESEMBOLSO") %>' ID_LIQUIDACION_DET='<%# Bind("ID_LIQUIDACION_DET") %>' MONTO_DESEMBOLSO='<%# Bind("MONTO_DESEMBOLSO") %>' USERID='<%# Bind("USERID") %>' LASTUPDATE='<%# Bind("LASTUPDATE") %>' />
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
    SelectMethod="ObtenerLista" InsertMethod="AgregarDESEMBOLSO_MUNI_LIQUI_DET" DeleteMethod="EliminarDESEMBOLSO_MUNI_LIQUI_DET" UpdateMethod="ActualizarDESEMBOLSO_MUNI_LIQUI_DET"
    TypeName="SGAFP.BL.cDESEMBOLSO_MUNI_LIQUI_DET">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_DESEMBOLSO_MUNI" Type="Decimal" />
        <asp:Parameter Name="ID_DESEMBOLSO" Type="Decimal" />
        <asp:Parameter Name="ID_LIQUIDACION_DET" Type="Decimal" />
        <asp:Parameter Name="MONTO_DESEMBOLSO" Type="Decimal" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_DESEMBOLSO_MUNI" Type="Decimal" />
        <asp:Parameter Name="ID_DESEMBOLSO" Type="Decimal" />
        <asp:Parameter Name="ID_LIQUIDACION_DET" Type="Decimal" />
        <asp:Parameter Name="MONTO_DESEMBOLSO" Type="Decimal" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_DESEMBOLSO_MUNI" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorDESEMBOLSO" runat="server" 
    SelectMethod="ObtenerListaPorDESEMBOLSO" InsertMethod="AgregarDESEMBOLSO_MUNI_LIQUI_DET" DeleteMethod="EliminarDESEMBOLSO_MUNI_LIQUI_DET" UpdateMethod="ActualizarDESEMBOLSO_MUNI_LIQUI_DET"
    TypeName="SGAFP.BL.cDESEMBOLSO_MUNI_LIQUI_DET">
    <SelectParameters>
        <asp:Parameter Name="ID_DESEMBOLSO" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_DESEMBOLSO_MUNI" Type="Decimal" />
        <asp:Parameter Name="ID_DESEMBOLSO" Type="Decimal" />
        <asp:Parameter Name="ID_LIQUIDACION_DET" Type="Decimal" />
        <asp:Parameter Name="MONTO_DESEMBOLSO" Type="Decimal" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_DESEMBOLSO_MUNI" Type="Decimal" />
        <asp:Parameter Name="ID_DESEMBOLSO" Type="Decimal" />
        <asp:Parameter Name="ID_LIQUIDACION_DET" Type="Decimal" />
        <asp:Parameter Name="MONTO_DESEMBOLSO" Type="Decimal" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_DESEMBOLSO_MUNI" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorMUNICIPIO_LIQUIDACION_DET" runat="server" 
    SelectMethod="ObtenerListaPorMUNICIPIO_LIQUIDACION_DET" InsertMethod="AgregarDESEMBOLSO_MUNI_LIQUI_DET" DeleteMethod="EliminarDESEMBOLSO_MUNI_LIQUI_DET" UpdateMethod="ActualizarDESEMBOLSO_MUNI_LIQUI_DET"
    TypeName="SGAFP.BL.cDESEMBOLSO_MUNI_LIQUI_DET">
    <SelectParameters>
        <asp:Parameter Name="ID_LIQUIDACION_DET" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_DESEMBOLSO_MUNI" Type="Decimal" />
        <asp:Parameter Name="ID_DESEMBOLSO" Type="Decimal" />
        <asp:Parameter Name="ID_LIQUIDACION_DET" Type="Decimal" />
        <asp:Parameter Name="MONTO_DESEMBOLSO" Type="Decimal" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_DESEMBOLSO_MUNI" Type="Decimal" />
        <asp:Parameter Name="ID_DESEMBOLSO" Type="Decimal" />
        <asp:Parameter Name="ID_LIQUIDACION_DET" Type="Decimal" />
        <asp:Parameter Name="MONTO_DESEMBOLSO" Type="Decimal" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_DESEMBOLSO_MUNI" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
