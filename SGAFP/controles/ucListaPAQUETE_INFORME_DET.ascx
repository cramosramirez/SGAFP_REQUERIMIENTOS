<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaPAQUETE_INFORME_DET.ascx.vb" Inherits="controles_ucListaPAQUETE_INFORME_DET" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" KeyFieldName="ID_INFORME_FINAL">
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <Columns>
        <dx:GridViewDataColumn VisibleIndex="0" Caption="N°" FieldName="CORRELATIVO" UnboundType="Integer"  />
        <dx:GridViewCommandColumn ShowSelectCheckbox="True" Name="#" Caption="#"  VisibleIndex="1" />      
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="2" />        
        <dx:GridViewDataTextColumn VisibleIndex="3">
            <DataItemTemplate>
                <asp:LinkButton ID="lbtnEditar" runat="server" CommandName="Editar" 
                    CommandArgument=''>Editar</asp:LinkButton>
               <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandName="Seleccionar"
                    Visible="False" CommandArgument=''>Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataColumn VisibleIndex="4" Caption="PROVEEDOR" FieldName="NOMBRE_PROVEEDOR"  />
        <dx:GridViewDataColumn VisibleIndex="5" Caption="CURSO EJECUTADO" FieldName="NOMBRE_ACCION_FORMATIVA" />
        <dx:GridViewDataColumn VisibleIndex="6" Caption="N° HI" FieldName="CODIGO_GRUPO" />
        <dx:GridViewDataColumn VisibleIndex="7" Caption="LUGAR EJECUCION" FieldName="LUGAR_EJECUCION" />
        <dx:GridViewDataColumn VisibleIndex="8" Caption="INICIO" FieldName="FECHA_INICIO_REAL" >           
        </dx:GridViewDataColumn>
        <dx:GridViewDataColumn VisibleIndex="9" Caption="FINALIZACION" FieldName="FECHA_FIN_REAL" >            
        </dx:GridViewDataColumn> 
        <dx:GridViewDataColumn VisibleIndex="10" Caption="HORARIO" FieldName="HORARIO" />
        <dx:GridViewDataColumn VisibleIndex="11" Caption="HORAS" FieldName="DURACION_HORAS" />
        <dx:GridViewDataColumn VisibleIndex="12" Caption="INSCRITOS" FieldName="PARTICIPANTES_INSCRITOS" />
        <dx:GridViewDataColumn VisibleIndex="13" Caption="ACTIVOS" FieldName="PARTICIPANTES_FINALES" />
        <dx:GridViewDataTextColumn VisibleIndex="14" Caption="COSTO" FieldName="COSTO_X_PARTICIPANTE">
            <PropertiesTextEdit DisplayFormatString="{0:c}"></PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn VisibleIndex="15" Caption="TOTAL A PAGAR" FieldName="MONTO_FACTURA">
            <PropertiesTextEdit DisplayFormatString="{0:c}"></PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn VisibleIndex="16" FieldName="ID_INFORME_FINAL" ReadOnly="True" />
        <dx:GridViewDataTextColumn VisibleIndex="17" FieldName="LASTUPDATE" />
        <dx:GridViewDataTextColumn VisibleIndex="18" FieldName="USERID" />
        <dx:GridViewCommandColumn VisibleIndex="19" AllowDragDrop="False"  Caption=" " Name="Eliminar" >
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>
    <Settings ShowFilterRow="True" ShowHeaderFilterButton="True" />
</dx:ASPxGridView>
<asp:ObjectDataSource ID="odsListaPorESTADO_ACCION_FORMATIVA_USUARIO" runat="server" 
    SelectMethod="GetPorCODIGO_ESTADO_AF_USUARIO" 
    TypeName="SGAFP.DL.DS_DLTableAdapters.InformeFinal1TableAdapter" 
    OldValuesParameterFormatString="original_{0}">
    <SelectParameters>
        <asp:Parameter Name="ID_ESTADO_INFORME" Type="Decimal" DefaultValue="-1" />               
        <asp:Parameter Name="USUARIO" Type="String" DefaultValue="" />     
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPAQUETE_INFORME" runat="server" 
    SelectMethod="GetPorID_PAQUETE" 
    TypeName="SGAFP.DL.DS_DLTableAdapters.InformeFinal1TableAdapter" 
    OldValuesParameterFormatString="original_{0}">
    <SelectParameters>
        <asp:Parameter Name="ID_PAQUETE" Type="Decimal" DefaultValue="0" />        
    </SelectParameters>
</asp:ObjectDataSource>

