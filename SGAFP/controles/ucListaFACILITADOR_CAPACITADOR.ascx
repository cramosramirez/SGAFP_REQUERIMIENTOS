<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaFACILITADOR_CAPACITADOR.ascx.vb" Inherits="controles_ucListaFACILITADOR_CAPACITADOR" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register src="ucVistaDetalleFACILITADOR_CAPACITADOR.ascx" tagname="ucVistaDetalleFACILITADOR_CAPACITADOR" tagprefix="uc1" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_FACILITADOR">
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
                    CommandArgument='<%# Bind("ID_FACILITADOR") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_FACILITADOR") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_FACILITADOR" ReadOnly="True" VisibleIndex="2" Caption="Id facilitador" />
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_PERSONA" VisibleIndex="3" Caption="Id tipo persona" />
        <dx:GridViewDataTextColumn FieldName="ID_PROVEEDOR_AF" VisibleIndex="4" Caption="Id proveedor af" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_MUNICIPIO" VisibleIndex="5" Caption="Codigo municipio" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_DEPARTAMENTO" VisibleIndex="6" Caption="Codigo departamento" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_FACILITADOR" VisibleIndex="7" Caption="Nombre facilitador" />
        <dx:GridViewDataTextColumn FieldName="NIT" VisibleIndex="8" Caption="Nit" />
        <dx:GridViewDataTextColumn FieldName="DUI" VisibleIndex="9" Caption="Dui" />
        <dx:GridViewDataTextColumn FieldName="ISSS" VisibleIndex="10" Caption="Isss" />
        <dx:GridViewDataTextColumn FieldName="FECHA_INGRESO" VisibleIndex="11" Caption="Fecha ingreso" />
        <dx:GridViewDataTextColumn FieldName="TELEFONO" VisibleIndex="12" Caption="Telefono" />
        <dx:GridViewDataTextColumn FieldName="EMAIL" VisibleIndex="13" Caption="Email" />
        <dx:GridViewDataTextColumn FieldName="DIRECCION" VisibleIndex="14" Caption="Direccion" />
        <dx:GridViewDataTextColumn FieldName="NOTAS" VisibleIndex="15" Caption="Notas" />
        <dx:GridViewDataTextColumn FieldName="USERID" VisibleIndex="16" Caption="Userid" />
        <dx:GridViewDataTextColumn FieldName="LASTUPDATE" VisibleIndex="17" Caption="Lastupdate" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="18">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>
    <Templates>
        <EditForm>
            <uc1:ucVistaDetalleFACILITADOR_CAPACITADOR ID="ucVistaDetalleFACILITADOR_CAPACITADOR1" runat="server" 
                ID_FACILITADOR='<%# Bind("ID_FACILITADOR") %>' ID_TIPO_PERSONA='<%# Bind("ID_TIPO_PERSONA") %>' ID_PROVEEDOR_AF='<%# Bind("ID_PROVEEDOR_AF") %>' CODIGO_MUNICIPIO='<%# Bind("CODIGO_MUNICIPIO") %>' CODIGO_DEPARTAMENTO='<%# Bind("CODIGO_DEPARTAMENTO") %>' NOMBRE_FACILITADOR='<%# Bind("NOMBRE_FACILITADOR") %>' NIT='<%# Bind("NIT") %>' DUI='<%# Bind("DUI") %>' ISSS='<%# Bind("ISSS") %>' FECHA_INGRESO='<%# Bind("FECHA_INGRESO") %>' TELEFONO='<%# Bind("TELEFONO") %>' EMAIL='<%# Bind("EMAIL") %>' DIRECCION='<%# Bind("DIRECCION") %>' NOTAS='<%# Bind("NOTAS") %>' USERID='<%# Bind("USERID") %>' LASTUPDATE='<%# Bind("LASTUPDATE") %>' />
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
    SelectMethod="ObtenerLista" InsertMethod="AgregarFACILITADOR_CAPACITADOR" DeleteMethod="EliminarFACILITADOR_CAPACITADOR" UpdateMethod="ActualizarFACILITADOR_CAPACITADOR"
    TypeName="SGAFP.BL.cFACILITADOR_CAPACITADOR">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_FACILITADOR" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_PERSONA" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="NOMBRE_FACILITADOR" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="FECHA_INGRESO" Type="DateTime" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="NOTAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_FACILITADOR" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_PERSONA" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="NOMBRE_FACILITADOR" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="FECHA_INGRESO" Type="DateTime" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="NOTAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_FACILITADOR" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIPO_PERSONA" runat="server" 
    SelectMethod="ObtenerListaPorTIPO_PERSONA" InsertMethod="AgregarFACILITADOR_CAPACITADOR" DeleteMethod="EliminarFACILITADOR_CAPACITADOR" UpdateMethod="ActualizarFACILITADOR_CAPACITADOR"
    TypeName="SGAFP.BL.cFACILITADOR_CAPACITADOR">
    <SelectParameters>
        <asp:Parameter Name="ID_TIPO_PERSONA" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_FACILITADOR" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_PERSONA" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="NOMBRE_FACILITADOR" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="FECHA_INGRESO" Type="DateTime" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="NOTAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_FACILITADOR" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_PERSONA" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="NOMBRE_FACILITADOR" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="FECHA_INGRESO" Type="DateTime" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="NOTAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_FACILITADOR" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPROVEEDOR_AF" runat="server" 
    SelectMethod="ObtenerListaPorPROVEEDOR_AF" InsertMethod="AgregarFACILITADOR_CAPACITADOR" DeleteMethod="EliminarFACILITADOR_CAPACITADOR" UpdateMethod="ActualizarFACILITADOR_CAPACITADOR"
    TypeName="SGAFP.BL.cFACILITADOR_CAPACITADOR">
    <SelectParameters>
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_FACILITADOR" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_PERSONA" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="NOMBRE_FACILITADOR" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="FECHA_INGRESO" Type="DateTime" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="NOTAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_FACILITADOR" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_PERSONA" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="NOMBRE_FACILITADOR" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="FECHA_INGRESO" Type="DateTime" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="NOTAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_FACILITADOR" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorMUNICIPIO" runat="server" 
    SelectMethod="ObtenerListaPorMUNICIPIO" InsertMethod="AgregarFACILITADOR_CAPACITADOR" DeleteMethod="EliminarFACILITADOR_CAPACITADOR" UpdateMethod="ActualizarFACILITADOR_CAPACITADOR"
    TypeName="SGAFP.BL.cFACILITADOR_CAPACITADOR">
    <SelectParameters>
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_FACILITADOR" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_PERSONA" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="NOMBRE_FACILITADOR" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="FECHA_INGRESO" Type="DateTime" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="NOTAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_FACILITADOR" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_PERSONA" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="NOMBRE_FACILITADOR" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="FECHA_INGRESO" Type="DateTime" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="NOTAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_FACILITADOR" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorDEPARTAMENTO" runat="server" 
    SelectMethod="ObtenerListaPorDEPARTAMENTO" InsertMethod="AgregarFACILITADOR_CAPACITADOR" DeleteMethod="EliminarFACILITADOR_CAPACITADOR" UpdateMethod="ActualizarFACILITADOR_CAPACITADOR"
    TypeName="SGAFP.BL.cFACILITADOR_CAPACITADOR">
    <SelectParameters>
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_FACILITADOR" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_PERSONA" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="NOMBRE_FACILITADOR" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="FECHA_INGRESO" Type="DateTime" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="NOTAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_FACILITADOR" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_PERSONA" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="NOMBRE_FACILITADOR" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="FECHA_INGRESO" Type="DateTime" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="NOTAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_FACILITADOR" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
