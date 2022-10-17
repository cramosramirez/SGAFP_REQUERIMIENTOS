<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucGestionOpcionesPorRol.ascx.vb" Inherits="controles_ucGestionOpcionesPorRol" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxTreeList.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxTreeList" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxCallback" tagprefix="dx" %>
<%@ Register src="ucBarraNavegacion.ascx" tagname="ucBarraNavegacion" tagprefix="uc1" %>
<style type="text/css">
    .style1
    {
        width: 100%;
    }
</style>
<script language="javascript" type="text/javascript">
    function Sincronizar(valores) {
        if (valores == "") {
            AsignarMensaje("Debe de seleccionar al menos una Opción por Rol");
            return;
        }
        callSync.PerformCallback(cbRoles.GetValue().toString() + ';' + valores);
    }
</script>
<table class="style1">
    <tr>
        <td>
            <dx:ASPxLabel ID="lblSistema" runat="server" Text="Sistema:">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxComboBox ID="cbSistemas" runat="server" DataSourceID="odsSistemas" ClientInstanceName="cbSistemas" 
                TextField="NombreSistema" ValueField="IdSistema" ValueType="System.Int32">
                <ClientSideEvents SelectedIndexChanged="function(s, e) {
        if(cbRoles.GetValue()!=null){tlOpciones.PerformCallback('Recuperar;'+s.GetText());}e.processOnServer=false;
}" />
            </dx:ASPxComboBox>
        </td>
    </tr>
    <tr>
        <td>
            <dx:ASPxLabel ID="lblRol" runat="server" Text="Rol:">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxComboBox ID="cbRoles" runat="server" ClientInstanceName="cbRoles" 
                ValueType="System.String">
                <ClientSideEvents SelectedIndexChanged="function(s, e) {
	tlOpciones.PerformCallback('Recuperar;'+s.GetText());
}" />
            </dx:ASPxComboBox>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <dx:ASPxTreeList ID="tlOpciones" runat="server" AutoGenerateColumns="False" 
                ClientInstanceName="tlOpciones" DataSourceID="odsOpcionesPorRol" 
                KeyFieldName="IdOpcionMenu" ParentFieldName="IdPadre">
                <SettingsPopupEditForm Caption="Editar" HorizontalAlign="WindowCenter" 
                    Modal="True" VerticalAlign="WindowCenter" />

<SettingsText LoadingPanelText="Cargando&amp;hellip;"></SettingsText>

                <SettingsLoadingPanel Text="Cargando&amp;hellip;"></SettingsLoadingPanel>
                <SettingsSelection AllowSelectAll="True" Enabled="True" Recursive="True" />
                <Settings GridLines="Both" />
                <SettingsEditing Mode="EditForm" ConfirmDelete="true" />
                <Templates>
                    <EditForm>
                        <table class="style1">
                            <tr>
                                <td>
                                    <dx:ASPxLabel ID="lblIdOpcionMenu" runat="server" Text="Opcion Menu:">
                                    </dx:ASPxLabel>
                                </td>
                                <td>
                                    <dx:ASPxComboBox ID="cbOpcion" runat="server" DataSourceID="odsOpciones" 
                                        TextField="NombreOpcionDDL" ValueField="IdOpcionMenu" ValueType="System.String">
                                    </dx:ASPxComboBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <dx:ASPxLabel ID="lblHabilitado" runat="server" Text="Habilitado:">
                                    </dx:ASPxLabel>
                                </td>
                                <td>
                                    <dx:ASPxCheckBox ID="chkHabilitado" runat="server"></dx:ASPxCheckBox>
                               </td>
                            </tr>
                            <tr>
                                 <td colspan="2">
                                 <table cellpadding="0" cellspacing="0">
                                     <tr>
                                         <td><dx:ASPxButton ID="btnGuardar" runat="server" AutoPostBack="False" Text="Guardar" Width="74px">   
                                <ClientSideEvents Click="function(s, e){if(!s.CauseValidation())return false;tlOpciones.UpdateEdit();}" />
                            </dx:ASPxButton></td>
                        <td style="padding-left: 13px;"><dx:ASPxButton ID="btnCancelar" runat="server" AutoPostBack="False" Text="Cancelar" Width="74px" CausesValidation="False">
                                <ClientSideEvents Click="function(s, e){tlOpciones.CancelEdit();}" />                            
             </dx:ASPxButton></td>
                            </tr>
                            </table></td></tr>
                        </table>
                    </EditForm>
                </Templates>
                <Columns>
                    <dx:TreeListTextColumn FieldName="IdOpcionMenu" ReadOnly="True" 
                        VisibleIndex="0">
                    </dx:TreeListTextColumn>
                    <dx:TreeListTextColumn FieldName="CodigoMenu"  Caption="Opcion Menu" ReadOnly="True" 
                        VisibleIndex="1">
                    </dx:TreeListTextColumn>
<%--                    <dx:TreeListTextColumn Caption="Opcion Menu" VisibleIndex="1">
                        <DataCellTemplate>
                            <dx:ASPxLabel ID="lblOpcionMenu" runat="server" Text="<%# GetOpcionMenu(Container)%>"></dx:ASPxLabel>
                        </DataCellTemplate>
                    </dx:TreeListTextColumn>--%>
                    <dx:TreeListTextColumn FieldName="UrlOpcion"  Caption="Opcion URL" ReadOnly="True" 
                        VisibleIndex="2">
                    </dx:TreeListTextColumn>
<%--                    <dx:TreeListTextColumn Caption="Opcion URL" VisibleIndex="2">
                        <DataCellTemplate>
                            <dx:ASPxLabel ID="lblOpcionURL" runat="server" Text="<%# GetOpcionURL(Container)%>"></dx:ASPxLabel>
                        </DataCellTemplate>
                    </dx:TreeListTextColumn>--%>
                    <dx:TreeListTextColumn FieldName="IdPadre"  Caption="IdPadre" ReadOnly="True" 
                        VisibleIndex="3">
                    </dx:TreeListTextColumn>
                    <dx:TreeListCheckColumn FieldName="Habilitado" VisibleIndex="4">
                    </dx:TreeListCheckColumn>
                    
                    <dx:TreeListCommandColumn VisibleIndex="5">
                        <EditButton Visible="True">
                        </EditButton>
                        <NewButton Visible="True">
                        </NewButton>
                        <DeleteButton Visible="True">
                        </DeleteButton>
                    </dx:TreeListCommandColumn>
                </Columns>
            </dx:ASPxTreeList>
        </td>
    </tr>
</table>
<dx:ASPxCallback ID="callSync" runat="server" ClientInstanceName="callSync">
    <ClientSideEvents CallbackComplete="function(s, e) {
	AsignarMensaje(e.result);
}" />
</dx:ASPxCallback>
<asp:ObjectDataSource ID="odsOpcionesPorRol" runat="server" 
    OldValuesParameterFormatString="{0}" 
    SelectMethod="ObtenerListaPorSistemaRol"
    TypeName="SQLMembershipProvider.BL.cOpcionesPorRol" 
    DeleteMethod="EliminarOpcionesPorRol" InsertMethod="AgregarOpcionesPorRol" 
    UpdateMethod="ActualizarOpcionesPorRol">
    <DeleteParameters>
        <asp:Parameter DbType="Guid" Name="RoleId" />
        <asp:Parameter Name="IdOpcionMenu" Type="Int32" />
    </DeleteParameters>
    <UpdateParameters>
        <asp:Parameter DbType="Guid" Name="RoleId" />
        <asp:Parameter Name="IdOpcionMenu" Type="Int32" />
        <asp:Parameter Name="Habilitado" Type="Boolean" />
    </UpdateParameters>
    <SelectParameters>
        <asp:ControlParameter ControlID="cbSistemas"  Type="Int32" DefaultValue="" 
            Name="idSistema" PropertyName="Value" />
        <asp:ControlParameter ControlID="cbRoles" DbType="Guid" DefaultValue="" 
            Name="RoleId" PropertyName="Value" />
        <asp:Parameter DefaultValue="True" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter Name="asColumnaOrden" Type="String" />
        <asp:Parameter Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DbType="Guid" Name="RoleId" />
        <asp:Parameter Name="IdOpcionMenu" Type="Int32" />
        <asp:Parameter Name="Habilitado" Type="Boolean" />
    </InsertParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsOpciones" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaPorSistemas" 
    TypeName="SQLMembershipProvider.BL.cOpcionesMenu">
    <SelectParameters>
        <asp:ControlParameter ControlID="cbSistemas"  Type="Int32" DefaultValue="" 
        Name="IdSistema" PropertyName="Value" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="True" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsSistemas" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarSistemas" DeleteMethod="EliminarSistemas" UpdateMethod="ActualizarSistemas"
    TypeName="SQLMembershipProvider.BL.cSistemas">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>