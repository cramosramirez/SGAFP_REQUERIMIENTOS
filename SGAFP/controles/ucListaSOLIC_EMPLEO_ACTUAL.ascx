<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaSOLIC_EMPLEO_ACTUAL.ascx.vb" Inherits="controles_ucListaSOLIC_EMPLEO_ACTUAL" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register src="ucVistaDetalleSOLIC_EMPLEO_ACTUAL.ascx" tagname="ucVistaDetalleSOLIC_EMPLEO_ACTUAL" tagprefix="uc1" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_EMPLEO_ACTUAL">
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
                    CommandArgument='<%# Bind("ID_EMPLEO_ACTUAL") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_EMPLEO_ACTUAL") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_EMPLEO_ACTUAL" ReadOnly="True" VisibleIndex="2" Caption="Id empleo actual" />
        <dx:GridViewDataTextColumn FieldName="ID_SOLICITUD" VisibleIndex="3" Caption="Id solicitud" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_EMPRESA" VisibleIndex="4" Caption="Nombre empresa" />
        <dx:GridViewDataTextColumn FieldName="DIRECCION" VisibleIndex="5" Caption="Direccion" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_DEPARTAMENTO" VisibleIndex="6" Caption="Codigo departamento" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_MUNICIPIO" VisibleIndex="7" Caption="Codigo municipio" />
        <dx:GridViewDataTextColumn FieldName="TELEFONOS" VisibleIndex="8" Caption="Telefonos" />
        <dx:GridViewDataTextColumn FieldName="TIEMPO_TRABAJO" VisibleIndex="9" Caption="Tiempo trabajo" />
        <dx:GridViewDataTextColumn FieldName="AREA_TRABAJO" VisibleIndex="10" Caption="Area trabajo" />
        <dx:GridViewDataTextColumn FieldName="AREA_OTRO" VisibleIndex="11" Caption="Area otro" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="12">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>
    <Templates>
        <EditForm>
            <uc1:ucVistaDetalleSOLIC_EMPLEO_ACTUAL ID="ucVistaDetalleSOLIC_EMPLEO_ACTUAL1" runat="server" 
                ID_EMPLEO_ACTUAL='<%# Bind("ID_EMPLEO_ACTUAL") %>' ID_SOLICITUD='<%# Bind("ID_SOLICITUD") %>' NOMBRE_EMPRESA='<%# Bind("NOMBRE_EMPRESA") %>' DIRECCION='<%# Bind("DIRECCION") %>' CODIGO_DEPARTAMENTO='<%# Bind("CODIGO_DEPARTAMENTO") %>' CODIGO_MUNICIPIO='<%# Bind("CODIGO_MUNICIPIO") %>' TELEFONOS='<%# Bind("TELEFONOS") %>' TIEMPO_TRABAJO='<%# Bind("TIEMPO_TRABAJO") %>' AREA_TRABAJO='<%# Bind("AREA_TRABAJO") %>' AREA_OTRO='<%# Bind("AREA_OTRO") %>' />
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
    SelectMethod="ObtenerLista" InsertMethod="AgregarSOLIC_EMPLEO_ACTUAL" DeleteMethod="EliminarSOLIC_EMPLEO_ACTUAL" UpdateMethod="ActualizarSOLIC_EMPLEO_ACTUAL"
    TypeName="SGAFP.BL.cSOLIC_EMPLEO_ACTUAL">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_EMPLEO_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_EMPRESA" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONOS" Type="String" />
        <asp:Parameter Name="TIEMPO_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="AREA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="AREA_OTRO" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_EMPLEO_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_EMPRESA" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONOS" Type="String" />
        <asp:Parameter Name="TIEMPO_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="AREA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="AREA_OTRO" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_EMPLEO_ACTUAL" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorSOLICITUD_INSCRIPCION_AF" runat="server" 
    SelectMethod="ObtenerListaPorSOLICITUD_INSCRIPCION_AF" InsertMethod="AgregarSOLIC_EMPLEO_ACTUAL" DeleteMethod="EliminarSOLIC_EMPLEO_ACTUAL" UpdateMethod="ActualizarSOLIC_EMPLEO_ACTUAL"
    TypeName="SGAFP.BL.cSOLIC_EMPLEO_ACTUAL">
    <SelectParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_EMPLEO_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_EMPRESA" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONOS" Type="String" />
        <asp:Parameter Name="TIEMPO_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="AREA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="AREA_OTRO" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_EMPLEO_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_EMPRESA" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONOS" Type="String" />
        <asp:Parameter Name="TIEMPO_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="AREA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="AREA_OTRO" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_EMPLEO_ACTUAL" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorDEPARTAMENTO" runat="server" 
    SelectMethod="ObtenerListaPorDEPARTAMENTO" InsertMethod="AgregarSOLIC_EMPLEO_ACTUAL" DeleteMethod="EliminarSOLIC_EMPLEO_ACTUAL" UpdateMethod="ActualizarSOLIC_EMPLEO_ACTUAL"
    TypeName="SGAFP.BL.cSOLIC_EMPLEO_ACTUAL">
    <SelectParameters>
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_EMPLEO_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_EMPRESA" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONOS" Type="String" />
        <asp:Parameter Name="TIEMPO_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="AREA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="AREA_OTRO" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_EMPLEO_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_EMPRESA" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONOS" Type="String" />
        <asp:Parameter Name="TIEMPO_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="AREA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="AREA_OTRO" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_EMPLEO_ACTUAL" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorMUNICIPIO" runat="server" 
    SelectMethod="ObtenerListaPorMUNICIPIO" InsertMethod="AgregarSOLIC_EMPLEO_ACTUAL" DeleteMethod="EliminarSOLIC_EMPLEO_ACTUAL" UpdateMethod="ActualizarSOLIC_EMPLEO_ACTUAL"
    TypeName="SGAFP.BL.cSOLIC_EMPLEO_ACTUAL">
    <SelectParameters>
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_EMPLEO_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_EMPRESA" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONOS" Type="String" />
        <asp:Parameter Name="TIEMPO_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="AREA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="AREA_OTRO" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_EMPLEO_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_EMPRESA" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONOS" Type="String" />
        <asp:Parameter Name="TIEMPO_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="AREA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="AREA_OTRO" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_EMPLEO_ACTUAL" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
