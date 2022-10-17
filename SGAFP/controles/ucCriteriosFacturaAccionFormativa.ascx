<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCriteriosFacturaAccionFormativa.ascx.vb" Inherits="controles_ucCriteriosFacturaAccionFormativa" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>

<table cellpadding="0" cellspacing="2" border="0" >   
    <tr id="trTipoSolicitud" runat="server" >
        <td>
            <dx:ASPxLabel ID="lblTipoSolicitud" runat="server" Text="Programa:" />
        </td>
        <td>
             <dx:ASPxComboBox runat="server" ID="cbxProgramaFormacion" LoadingPanelText="Cargando Programas..." ShowLoadingPanel="true" 
                DataSourceID="odsProgramaFormacion" TextField="NOMBRE_PROGRAMA_FORMACION" 
                ValueField="ID_PROGRAMA_FORMACION" ClientInstanceName="cbxProgramaFormacion" ValueType="System.Decimal" Width="315px" >                    
            </dx:ASPxComboBox>                                         
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr id="trProveedor" runat="server" >
        <td>
            <dx:ASPxLabel ID="lblProveedor" runat="server" Text="Proveedor:" />
        </td>
        <td>
            <dx:ASPxComboBox runat="server" ID="cbxProveedor" LoadingPanelText="Cargando Proveedores..." ShowLoadingPanel="true" 
                DataSourceID="odsProveedor" TextField="NOMBRE_PROVEEDOR" 
                ValueField="ID_PROVEEDOR_AF" ClientInstanceName="cbxProveedor" ValueType="System.Decimal" Width="315px" >    
            <ClientSideEvents EndCallback="function(s,e){s.SetText('[Todos]');}" />         
            </dx:ASPxComboBox>            
        </td>
        <td style="width:120px; text-align:right;" >
            <dx:ASPxLabel ID="lblNIT" runat="server" Text="NIT:" />
        </td>
        <td>
            <dx:ASPxTextBox ID="txtNIT" ClientInstanceName="txtNIT" ValidationSettings-Display="Dynamic" runat="server" Width="180px" >                            
                <MaskSettings Mask="9999-999999-999-9" IncludeLiterals="None" /> 
            </dx:ASPxTextBox>
        </td>
    </tr>
    <tr id="trDocumento" runat="server">
        <td>
            <dx:ASPxLabel ID="lblNumeroDocumento" runat="server" Text="N° Documento:"  />
        </td>
        <td>
            <dx:ASPxTextBox ID="txtNumeroDocumento" ClientInstanceName="txtNumeroDocumento"  
                runat="server" Width="130px" >
                 <ClientSideEvents TextChanged="function(s, e) {
                        s.SetText(s.GetText().toUpperCase());
                        }" />
            </dx:ASPxTextBox>
        </td>      
        <td style="text-align:right;">
            <dx:ASPxLabel ID="lblFechaEmision" runat="server" Text="Fecha Emisión:"  />
        </td>
        <td>
             <dx:ASPxDateEdit ID="dteFechaEmision" ClientInstanceName="dteFechaEmision" Width="130px" runat="server" EditFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="true" />
        </td>
    </tr> 
     <tr id="trResolucion" runat="server">
        <td>
            <dx:ASPxLabel ID="lblResolucion" runat="server" 
                Text="Orden Compra/Contrato:" />
        </td>
        <td>
            <dx:ASPxTextBox ID="txtResolucion" ClientInstanceName="txtResolucion"  
                runat="server" Width="130px" >
                 <ClientSideEvents TextChanged="function(s, e) {
                        s.SetText(s.GetText().toUpperCase());
                        }" />
            </dx:ASPxTextBox>
        </td> 
          <td style="text-align:right;">
            <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Código Curso:"  />
        </td> 
        <td>
            <dx:ASPxTextBox ID="txtCODIGO_GRUPO" ClientInstanceName="txtCODIGO_GRUPO"  
                runat="server" Width="180px" >
                 <ClientSideEvents TextChanged="function(s, e) {
                        s.SetText(s.GetText().toUpperCase());
                        }" />
            </dx:ASPxTextBox>
        </td>         
    </tr>     
    </table>    

<asp:ObjectDataSource ID="odsProveedor" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cPROVEEDOR_AF">
<SelectParameters>                
    <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean"  />        
    <asp:Parameter DefaultValue="false" Name="recuperarForaneas" Type="Boolean"  />        
    <asp:Parameter DefaultValue="NOMBRE_PROVEEDOR" Name="asColumnaOrden" Type="String" />
    <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
</SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsProgramaFormacion" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerListaPorROLES" TypeName="SGAFP.BL.cPROGRAMA_FORMACION">  
    <SelectParameters>                
    <asp:Parameter Name="listaRoles" Type="Object" />        
    </SelectParameters>
</asp:ObjectDataSource>
<dx:ASPxHiddenField runat="server" ID="hf" ClientInstanceName="hf" SyncWithServer="true" /> 