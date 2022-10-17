<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaDESEMBOLSO.ascx.vb" Inherits="controles_ucListaDESEMBOLSO" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register src="ucVistaDetalleDESEMBOLSO.ascx" tagname="ucVistaDetalleDESEMBOLSO" tagprefix="uc1" %>
<%@ Register assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxHiddenField" tagprefix="dx" %>


<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsListaPorFuenteConvocatoria" KeyFieldName="ID_DESEMBOLSO">  
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
        <dx:GridViewCommandColumn Name="Adicion" Visible="False" Width="25px" ButtonType="Image" Caption=" " >
            <NewButton Visible="False" Text="Agregar" Image-Url="../imagenes/ButtonNew.png" ></NewButton>                     
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn Name="Edicion" Visible="False" Width="25px" ButtonType="Image" Caption=" "   >
             <EditButton Visible="False" Text="Editar" Image-Url="../imagenes/modificar.png" ></EditButton>
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn Name="Eliminacion" Visible="False" Width="25px" ButtonType="Image" Caption=" "  >
              <DeleteButton Visible="False" Text="Eliminar" Image-Url="../imagenes/eliminar.png"></DeleteButton>
        </dx:GridViewCommandColumn>                   
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1">
            <DataItemTemplate>
                <asp:LinkButton ID="lbtnEditar" runat="server" CommandName="Editar" 
                    CommandArgument='<%# Bind("ID_DESEMBOLSO") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_DESEMBOLSO") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="FUENTE" UnboundType="String" ReadOnly="True" VisibleIndex="2" Caption="Fuente" />
        <dx:GridViewDataTextColumn FieldName="ID_DESEMBOLSO" ReadOnly="True" VisibleIndex="3" Caption="Id Desembolso" />
        <dx:GridViewDataTextColumn FieldName="ID_FUENTE" VisibleIndex="4" Caption="Id fuente" />        
        <dx:GridViewDataTextColumn FieldName="NO_CONVOCATORIA" VisibleIndex="5" Caption="N° Convocatoria" />
        <dx:GridViewDataTextColumn FieldName="NUM_DESEMBOLSO" VisibleIndex="6" Caption="N° Desembolso" />
        <dx:GridViewDataTextColumn FieldName="FECHA_DESEMBOLSO" VisibleIndex="7" Caption="Fecha" PropertiesTextEdit-DisplayFormatString="dd/MM/yyy" />
        <dx:GridViewDataTextColumn FieldName="MONTO_AUTORIZADO" VisibleIndex="8" Caption="Monto Autorizado" PropertiesTextEdit-DisplayFormatString="#,##0.00" />                    
        <dx:GridViewDataTextColumn FieldName="MONTO_APLICADO" VisibleIndex="9" ReadOnly="True" CellStyle-ForeColor="Blue" Caption="Monto Aplicado" PropertiesTextEdit-DisplayFormatString="#,##0.00" />
        <dx:GridViewDataTextColumn FieldName="MONTO_DIFERENCIA" VisibleIndex="10" ReadOnly="True" CellStyle-ForeColor="Red" Caption="Diferencia" PropertiesTextEdit-DisplayFormatString="#,##0.00" />
        <dx:GridViewDataTextColumn FieldName="USERID" VisibleIndex="11" Caption="Userid" />
        <dx:GridViewDataTextColumn FieldName="LASTUPDATE" VisibleIndex="12" Caption="Lastupdate" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="13">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>	   
    <Templates>
        <EditForm>
            <uc1:ucVistaDetalleDESEMBOLSO ID="ucVistaDetalleDESEMBOLSO1" runat="server" VerUSERID="false" VerLASTUPDATE="false" VerID_DESEMBOLSO="false"     
                ID_DESEMBOLSO='<%# Bind("ID_DESEMBOLSO") %>' ID_FUENTE='<%# Bind("ID_FUENTE") %>' NO_CONVOCATORIA='<%# Bind("NO_CONVOCATORIA") %>' NUM_DESEMBOLSO='<%# Bind("NUM_DESEMBOLSO") %>' FECHA_DESEMBOLSO='<%# Bind("FECHA_DESEMBOLSO") %>' MONTO_AUTORIZADO='<%# Bind("MONTO_AUTORIZADO") %>' USERID='<%# Bind("USERID") %>' LASTUPDATE='<%# Bind("LASTUPDATE") %>' />
             <div style="text-align:right; padding:2px 2px 2px 2px"><table cellpadding="0" cellspacing="0">
                    <tr><td><dx:ASPxButton ID="btnGuardar" runat="server" AutoPostBack="False" Text="Guardar" Font-Size="XX-Small"  Width="50px">   
                                <ClientSideEvents Click="function(s, e){if(!s.CauseValidation())return false;eval(s.cp_NombreClienteLista).UpdateEdit();}" />
                            </dx:ASPxButton></td>
                        <td style="padding-left: 13px;"><dx:ASPxButton ID="btnCancelar" runat="server" AutoPostBack="False" Text="Cancelar" Font-Size="XX-Small"  Width="50px" CausesValidation="False">
                                <ClientSideEvents Click="function(s, e){eval(s.cp_NombreClienteLista).CancelEdit();}" />                            
             </dx:ASPxButton></td></tr></table></div>
        </EditForm>
        <EmptyDataRow>               
            <dx:ASPxButton ID="btnAgregar" Image-Url="~/imagenes/ButtonNew.png" Font-Size="XX-Small" runat="server" AutoPostBack="False" Text="Agregar">
                <ClientSideEvents Click="function(s, e) {eval(s.cp_NombreClienteLista).AddNewRow();}" />
            </dx:ASPxButton>
            <dx:ASPxLabel ID="lblEmptyDataRow" runat="server" Text="No existen registros para mostrar" Font-Size="XX-Small" ></dx:ASPxLabel>
        </EmptyDataRow>
    </Templates>
    <Settings ShowFilterRow="False"  ShowHeaderFilterButton="False" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True" ConfirmDelete="true" AllowSelectByRowClick="true" AllowSelectSingleRowOnly="true" />    
</dx:ASPxGridView>
<dx:ASPxHiddenField runat="server" ID="hfdxgv" />      
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarDESEMBOLSO" DeleteMethod="EliminarDESEMBOLSO" UpdateMethod="ActualizarDESEMBOLSO"
    TypeName="SGAFP.BL.cDESEMBOLSO">
    <SelectParameters>
        <asp:Parameter DefaultValue="false" Name="recuperarForaneas" Type="Decimal"  />        
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_DESEMBOLSO" Type="Decimal" />
        <asp:Parameter Name="ID_FUENTE" Type="Decimal" />
        <asp:Parameter Name="NO_CONVOCATORIA" Type="Decimal" />
        <asp:Parameter Name="NUM_DESEMBOLSO" Type="Decimal" />
        <asp:Parameter Name="FECHA_DESEMBOLSO" Type="DateTime" />
        <asp:Parameter Name="MONTO_AUTORIZADO" Type="Decimal" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_DESEMBOLSO" Type="Decimal" />
        <asp:Parameter Name="ID_FUENTE" Type="Decimal" />
        <asp:Parameter Name="NO_CONVOCATORIA" Type="Decimal" />
        <asp:Parameter Name="NUM_DESEMBOLSO" Type="Decimal" />
        <asp:Parameter Name="FECHA_DESEMBOLSO" Type="DateTime" />
        <asp:Parameter Name="MONTO_AUTORIZADO" Type="Decimal" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_DESEMBOLSO" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorFuenteConvocatoria" runat="server" 
    SelectMethod="ObtenerListaPorFUENTE_FINANCIAMIENTO_NO_CONVOCATORIA" InsertMethod="AgregarDESEMBOLSO" DeleteMethod="EliminarDESEMBOLSO" UpdateMethod="ActualizarDESEMBOLSO"
    TypeName="SGAFP.BL.cDESEMBOLSO">
    <SelectParameters>
        <asp:Parameter DefaultValue="-1" Name="ID_FUENTE" Type="Decimal"  />
        <asp:Parameter DefaultValue="-1" Name="NO_CONVOCATORIA" Type="Decimal" />
        <asp:Parameter DefaultValue="FECHA_DESEMBOLSO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_DESEMBOLSO" Type="Decimal" />
        <asp:Parameter Name="ID_FUENTE" Type="Decimal" />
        <asp:Parameter Name="NO_CONVOCATORIA" Type="Decimal" />
        <asp:Parameter Name="NUM_DESEMBOLSO" Type="Decimal" />
        <asp:Parameter Name="FECHA_DESEMBOLSO" Type="DateTime" />
        <asp:Parameter Name="MONTO_AUTORIZADO" Type="Decimal" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_DESEMBOLSO" Type="Decimal" />
        <asp:Parameter Name="ID_FUENTE" Type="Decimal" />
        <asp:Parameter Name="NO_CONVOCATORIA" Type="Decimal" />
        <asp:Parameter Name="NUM_DESEMBOLSO" Type="Decimal" />
        <asp:Parameter Name="FECHA_DESEMBOLSO" Type="DateTime" />
        <asp:Parameter Name="MONTO_AUTORIZADO" Type="Decimal" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_DESEMBOLSO" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorFUENTE_FINANCIAMIENTO" runat="server" 
    SelectMethod="ObtenerListaPorFUENTE_FINANCIAMIENTO" InsertMethod="AgregarDESEMBOLSO" DeleteMethod="EliminarDESEMBOLSO" UpdateMethod="ActualizarDESEMBOLSO"
    TypeName="SGAFP.BL.cDESEMBOLSO">
    <SelectParameters>
        <asp:Parameter Name="ID_FUENTE" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_DESEMBOLSO" Type="Decimal" />
        <asp:Parameter Name="ID_FUENTE" Type="Decimal" />
        <asp:Parameter Name="NO_CONVOCATORIA" Type="Decimal" />
        <asp:Parameter Name="NUM_DESEMBOLSO" Type="Decimal" />
        <asp:Parameter Name="FECHA_DESEMBOLSO" Type="DateTime" />
        <asp:Parameter Name="MONTO_AUTORIZADO" Type="Decimal" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_DESEMBOLSO" Type="Decimal" />
        <asp:Parameter Name="ID_FUENTE" Type="Decimal" />
        <asp:Parameter Name="NO_CONVOCATORIA" Type="Decimal" />
        <asp:Parameter Name="NUM_DESEMBOLSO" Type="Decimal" />
        <asp:Parameter Name="FECHA_DESEMBOLSO" Type="DateTime" />
        <asp:Parameter Name="MONTO_AUTORIZADO" Type="Decimal" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_DESEMBOLSO" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
