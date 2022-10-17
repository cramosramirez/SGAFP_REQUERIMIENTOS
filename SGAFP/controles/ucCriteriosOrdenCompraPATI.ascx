<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCriteriosOrdenCompraPATI.ascx.vb" Inherits="controles_ucCriteriosOrdenCompra" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>

<table cellpadding="0" cellspacing="2" border="0" >
    <tr id="trPrograma" runat="server" >
        <td>
            <dx:ASPxLabel ID="lblPrograma" runat="server" Text="Programa:" />
        </td>
        <td>
            <dx:ASPxComboBox runat="server" ID="cbxProgramaFormacion" DataSourceID="odsProgramaFormacion" TextField="NOMBRE_PROGRAMA_FORMACION" 
                ValueField="ID_PROGRAMA_FORMACION" ClientInstanceName="cbxProgramaFormacion" 
                ValueType="System.Decimal" Width="315px" Font-Size="X-Small" >                                            
            </dx:ASPxComboBox>
        </td>
    </tr>
    <tr id="trProveedor" runat="server" >
        <td>
            <dx:ASPxLabel ID="lblProveedor" runat="server" Text="Proveedor:" />
        </td>
        <td>
            <dx:ASPxComboBox runat="server" ID="cbxProveedor" LoadingPanelText="Cargando Proveedores..." ShowLoadingPanel="true" 
                DataSourceID="odsProveedor" TextField="NOMBRE_PROVEEDOR" 
                ValueField="ID_PROVEEDOR_AF" ClientInstanceName="cbxProveedor" ValueType="System.Decimal" Width="315px" Font-Size="X-Small">    
            <ClientSideEvents Init ="function(s,e){s.SetText('[Todos]');}" />         
            </dx:ASPxComboBox>            
        </td>
    </tr>
     <tr id="trResolucion" runat="server">
        <td>
            <dx:ASPxLabel ID="lblResolucion" runat="server" Text="Orden Compra:" />
        </td>
        <td>
            <dx:ASPxTextBox ID="txtResolucion" ClientInstanceName="txtResolucion"  
                runat="server" Width="315px" >
                 <ClientSideEvents TextChanged="function(s, e) {
                        s.SetText(s.GetText().toUpperCase());
                        }" />
            </dx:ASPxTextBox>
        </td>      
    </tr> 
    </table>    
<asp:ObjectDataSource ID="odsProgramaFormacion" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerListaPorROLES" TypeName="SGAFP.BL.cPROGRAMA_FORMACION">
    <SelectParameters>
    <asp:Parameter Name="listaRoles" Type="Object" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsProveedor" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cPROVEEDOR_AF">
<SelectParameters>                
    <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean"  />        
    <asp:Parameter DefaultValue="false" Name="recuperarForaneas" Type="Boolean"  />
    <asp:Parameter DefaultValue="NOMBRE_PROVEEDOR" Name="asColumnaOrden" Type="String"  />
    <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
</SelectParameters>
</asp:ObjectDataSource>
<dx:ASPxHiddenField runat="server" ID="hf" ClientInstanceName="hf" SyncWithServer="true" /> 