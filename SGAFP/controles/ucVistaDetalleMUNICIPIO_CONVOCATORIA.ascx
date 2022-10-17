<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleMUNICIPIO_CONVOCATORIA.ascx.vb" Inherits="controles_ucVistaDetalleMUNICIPIO_CONVOCATORIA" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>

<dx:ASPxCallbackPanel runat="server" ID="cVistaDetalleMUNICIPIO_CONVOCATORIA" ClientInstanceName="cVistaDetalleMUNICIPIO_CONVOCATORIA" ShowLoadingPanel="false">  
    <PanelCollection>        
        <dx:PanelContent ID="PanelContent1" runat="server">   
<table cellpadding="0" cellspacing="2" border="0" >
    <tr id="trPrograma" runat="server" >
        <td>
            <dx:ASPxLabel ID="lblFuente" runat="server" Font-Size="X-Small" Text="Fuente:" />
        </td>
        <td>
            <dx:ASPxComboBox runat="server" ID="cbxID_FUENTE" DataSourceID="odsFuente" TextField="NOMBRE_FUENTE" 
                ValueField="ID_FUENTE" ClientInstanceName="cbxID_FUENTE" 
                ValueType="System.Decimal" Width="170px" Font-Size="X-Small" >      
                <ClientSideEvents SelectedIndexChanged="function(s,e){cbxCODIGO_DEPARTAMENTO.PerformCallback(cbxID_FUENTE.GetValue())}"  />                                        
            </dx:ASPxComboBox>
        </td>
    </tr>
    <tr id="trDepartamento" runat="server" >
        <td>
            <dx:ASPxLabel ID="lblDepartamento" runat="server" Font-Size="X-Small" Text="Departamento:" />
        </td>
        <td>
            <dx:ASPxComboBox runat="server" ID="cbxCODIGO_DEPARTAMENTO" DataSourceID="odsDepartamento" TextField="NOMBRE" 
                ValueField="CODIGO_DEPARTAMENTO" ClientInstanceName="cbxCODIGO_DEPARTAMENTO" ValueType="System.String" Width="170px" Font-Size="X-Small">                   
                 <ClientSideEvents SelectedIndexChanged="function(s,e){cbxCODIGO_MUNICIPIO.PerformCallback(cbxID_FUENTE.GetValue() + ';' + cbxCODIGO_DEPARTAMENTO.GetValue())}"  
                     EndCallback="function(s,e){
                                        if (s.GetText()!='') {
                                            cbxCODIGO_MUNICIPIO.PerformCallback(cbxID_FUENTE.GetValue() + ';' + cbxCODIGO_DEPARTAMENTO.GetValue());                                            
                                        } 
                                  }" />                                                    
            </dx:ASPxComboBox>            
        </td>
    </tr>
     <tr id="trMunicipio" runat="server">
        <td>
            <dx:ASPxLabel ID="lblMunicipio" runat="server" Font-Size="X-Small" Text="Municipio:" />
        </td>
        <td>
            <dx:ASPxComboBox runat="server" ID="cbxCODIGO_MUNICIPIO" DataSourceID="odsMunicipio" TextField="NOMBRE" 
                ValueField="CODIGO_MUNICIPIO" ClientInstanceName="cbxCODIGO_MUNICIPIO" ValueType="System.String" Width="170px" Font-Size="X-Small"> 
                <ClientSideEvents EndCallback="function(s,e){MostrarPanelModal(false,'')}" />                                                        
            </dx:ASPxComboBox>            
        </td>
    </tr> 
    <tr id="trConvocatoria" runat="server">
        <td>
            <dx:ASPxLabel ID="lblConvocatoria" runat="server" Font-Size="X-Small" Text="N° Convocatoria:" />
        </td>
        <td>
            <dx:ASPxTextBox ID="txtNO_CONVOCATORIA" runat="server" Font-Size="X-Small" Width="100px" ClientInstanceName="txtNO_CONVOCATORIA" >
                <MaskSettings Mask="<0..100g>" IncludeLiterals="None"  />
                <ValidationSettings ErrorDisplayMode="ImageWithTooltip" ErrorText="Convocatoria no válida." >                        
                    <RequiredField IsRequired="true" ErrorText="Convocatoria es requerida" />   
                </ValidationSettings>
            </dx:ASPxTextBox>        
        </td>
    </tr> 
    <tr id="trAporteFISDL" runat="server">
        <td>
            <dx:ASPxLabel ID="lblAporteFISDL" runat="server" Font-Size="X-Small" Text="Aporte FISDL:" />
        </td>
        <td>
            <dx:ASPxTextBox ID="txtAporteFISDL" runat="server" Font-Size="X-Small" Width="100px" ClientInstanceName="txtAporteFISDL" >
                <MaskSettings Mask="<0..9999999g>.<00..99>" IncludeLiterals="DecimalSymbol" />
                <ValidationSettings ErrorDisplayMode="ImageWithTooltip" />                                           
            </dx:ASPxTextBox>     
        </td>
    </tr> 
    <tr id="trMontoLiquidado" runat="server">
        <td>
            <dx:ASPxLabel ID="lblMontoLiquidado" runat="server" Font-Size="X-Small" Text="Monto Liquidado:" />
        </td>
        <td>
            <dx:ASPxTextBox ID="txtMontoLiquidado" Enabled="false" Font-Size="X-Small" runat="server" Width="100px" ClientInstanceName="txtMontoLiquidado" >
                <MaskSettings Mask="<0..9999999g>.<00..99>" IncludeLiterals="DecimalSymbol" />
                <ValidationSettings ErrorDisplayMode="ImageWithTooltip" />                                           
            </dx:ASPxTextBox>     
        </td>
    </tr> 
    <tr id="trAsesorMunicipal" runat="server">
        <td>
            <dx:ASPxLabel ID="lblAsesorMunicipal" runat="server" Font-Size="X-Small" Text="Asesor Municipal:"  />
        </td>
        <td>
            <dx:ASPxTextBox ID="txtAsesorMunicipal" runat="server" Width="170px" ClientInstanceName="txtAsesorMunicipal" Font-Size="X-Small" MaxLength="100"  />                                                               
        </td>
    </tr> 
    <tr id="trCodigoProyecto" runat="server">
        <td>
            <dx:ASPxLabel ID="lblCodigoProyecto" runat="server" Font-Size="X-Small" Text="Código Proyecto:" />
        </td>
        <td>
            <dx:ASPxTextBox ID="txtCodigoProyecto" runat="server" Width="170px" ClientInstanceName="txtCodigoProyecto" Font-Size="X-Small" MaxLength="10">                                                               
                <ValidationSettings ErrorDisplayMode="ImageWithTooltip"  >
                    <RequiredField IsRequired="true" ErrorText="Código de Proyecto es requerido." />                                        
                </ValidationSettings> 
            </dx:ASPxTextBox>
        </td>
    </tr>
    <tr id="trNombreProyecto" runat="server">
        <td>
            <dx:ASPxLabel ID="lblNombreProyecto" runat="server" Font-Size="X-Small" Text="Nombre Proyecto:" />
        </td>
        <td>
            <dx:ASPxTextBox ID="txtNombreProyecto" runat="server" Width="170px" ClientInstanceName="txtNombreProyecto" Font-Size="X-Small" MaxLength="200" >                                                               
                <ValidationSettings ErrorDisplayMode="ImageWithTooltip"  >
                    <RequiredField IsRequired="true" ErrorText="Nombre de Proyecto es requerido." />                                        
                </ValidationSettings> 
            </dx:ASPxTextBox>
        </td>
    </tr>
    <tr id="trChequeReintegro" runat="server">
        <td>
            <dx:ASPxLabel ID="lblNumeroChequeReintegro" runat="server" Font-Size="X-Small" Text="N° Cheque Reintegro:" />
        </td>
        <td>
            <dx:ASPxTextBox ID="txtNumeroChequeReintegro" runat="server" Width="100px" ClientInstanceName="txtNumeroChequeReintegro" Font-Size="X-Small" MaxLength="200" />                                                                                           
        </td>
    </tr>
    <tr id="trFechaChequeReintegro" runat="server">
        <td>
            <dx:ASPxLabel ID="lblFechaChequeReintegro" runat="server" Font-Size="X-Small" Text="Fecha Cheque:" />
        </td>
        <td>
            <dx:ASPxDateEdit id="dteFechaChequeReint" ClientInstanceName="dteFechaChequeReint" Font-Size="X-Small" Width="100px" runat="server" EditFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="true" />			                                          
        </td>
    </tr>
    <tr id="trUserId" runat="server">
        <td>
            <dx:ASPxLabel ID="lblUserId" runat="server" Font-Size="X-Small" Text="Usuario:" />
        </td>
        <td>
            <dx:ASPxTextBox ID="txtUserId" runat="server" Width="170px" ClientInstanceName="txtUserId" />                                                               
        </td>
    </tr>
    <tr id="trLastUpdate" runat="server">
        <td>
            <dx:ASPxLabel ID="lblLastUpdate" runat="server" Font-Size="X-Small" Text="LastUpdate:" />
        </td>
        <td>
            <dx:ASPxDateEdit id="dteLastUpdate" ClientInstanceName="dteLastUpdate" Width="100px" runat="server" EditFormat="DateTime" />			                                          
        </td>
    </tr>    
</table>   
<dx:ASPxHiddenField runat="server" ID="hfucVistaDetalleMUNICIPIO_CONVOCATORIA" ClientInstanceName="hfucVistaDetalleMUNICIPIO_CONVOCATORIA" SyncWithServer="true" />   
</dx:PanelContent>
</PanelCollection>
</dx:ASPxCallbackPanel>

<asp:ObjectDataSource ID="odsFuente" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cFUENTE_FINANCIAMIENTO">
    <SelectParameters>                
    <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Object" />        
    <asp:Parameter DefaultValue="NOMBRE_FUENTE" Name="asColumnaOrden" Type="String" />
    <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
</SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsDepartamento" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerListaParaPATIPorFuente" TypeName="SGAFP.BL.cDEPARTAMENTO">
<SelectParameters>                    
    <asp:Parameter Name="ID_FUENTE" Type="Decimal" />    
</SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsMunicipio" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerListaParaPATIPorDEPARTAMENTO_FUENTE" TypeName="SGAFP.BL.cMUNICIPIO">
<SelectParameters>                    
    <asp:Parameter Name="ID_FUENTE" Type="Decimal" />    
    <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />    
</SelectParameters>
</asp:ObjectDataSource>