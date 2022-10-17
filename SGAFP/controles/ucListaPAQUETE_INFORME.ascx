<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaPAQUETE_INFORME.ascx.vb" Inherits="controles_ucListaPAQUETE_INFORME" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" KeyFieldName="ID_PAQUETE">
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <Columns>        
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1">
            <DataItemTemplate>
                <asp:LinkButton ID="lbtnEditar" runat="server" CommandName="Editar" 
                    CommandArgument='<%# Bind("ID_PAQUETE") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_PAQUETE") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_PAQUETE" Caption="ID PAQUETE"  ReadOnly="True" VisibleIndex="2" />
        <dx:GridViewDataTextColumn FieldName="FECHA" VisibleIndex="3" >
            <PropertiesTextEdit DisplayFormatString="{0:d}">
            </PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="COMENTARIOS" Caption="DESCRIPCION" VisibleIndex="4" />
        <dx:GridViewDataTextColumn FieldName="LASTUPDATE" VisibleIndex="5"/>
        <dx:GridViewDataTextColumn FieldName="USERID" VisibleIndex="6" />
        <dx:GridViewDataColumn VisibleIndex="7" Caption="CANTIDAD DE INFORMES" FieldName="NUM_INFORMES" UnboundType="Integer"></dx:GridViewDataColumn>                         
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="8">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">                
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>      
        
        <dx:GridViewDataTextColumn VisibleIndex="9">
            <DataItemTemplate>
                <dx:ASPxHyperLink ID="ASPxHyperLink1" runat="server" Text='<%# Bind("ID_PAQUETE") %>' NavigateUrl='<%# "../Reportes/wfReportePaquetesInformes.aspx?IDP=" + Cstr(Eval("ID_PAQUETE"))%>' ImageUrl="~/imagenes/imprimir.gif" Target="_blank" />
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>       
       
	   </Columns>
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
</dx:ASPxGridView>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" 
    TypeName="SGAFP.BL.cPAQUETE_INFORME">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTecnico" runat="server" 
    SelectMethod="ObtenerListaPorTecnico" 
    TypeName="SGAFP.BL.cPAQUETE_INFORME">
    <SelectParameters>
        <asp:Parameter DefaultValue="" Name="USUARIO_TECNICO" Type="String" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCriterios" runat="server" 
    SelectMethod="ObtenerListaPorCriterios" 
    TypeName="SGAFP.BL.cPAQUETE_INFORME">
    <SelectParameters>
        <asp:Parameter DefaultValue="" Name="ID_PAQUETE" Type="Decimal" />
        <asp:Parameter DefaultValue="" Name="FECHA" Type="Object" />
        <asp:Parameter DefaultValue="" Name="USUARIO_TECNICO" Type="String" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
