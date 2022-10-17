<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCriteriosSolicitudes.ascx.vb" Inherits="controles_ucCriteriosSolicitudes" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

<style type="text/css">       
       .textUpper input{text-transform:uppercase;}     
</style>
<table  border="0" cellpadding="0" cellspacing="0">
    <tr id="trIDSolicitud" runat="server">
        <td style="width:150px" >
            <dx:ASPxLabel ID="lblIdSolicitud" runat="server" Font-Names="Verdana,Arial,Tahoma" Font-Size="XX-Small" Text="ID SOLICITUD:" />            
        </td>        
        <td style="width:320px">
            <dx:ASPxTextBox ID="txtID_SOLICITUD" CssClass="textUpper" ClientInstanceName="txtID_SOLICITUD" runat="server" Width="150px" />
        </td>  
        <td style="width:160px"></td>     
        <td></td>
    </tr>
    <tr id="trProveedor" runat="server">
        <td>
            <dx:ASPxLabel ID="lblProveedor" runat="server" Font-Names="Verdana,Arial,Tahoma" Font-Size="XX-Small" Text="PROVEEDOR:" />
        </td>
        <td>
            <dx:ASPxComboBox ID="cbxPROVEEDOR_AF" ClientInstanceName="cbxPROVEEDOR_AF"  Width="300px" runat="server" 
                DataSourceID="odsProveedor" TextField="NOMBRE_PROVEEDOR" ValueField="ID_PROVEEDOR_AF" >
                <ClientSideEvents SelectedIndexChanged="function(s,e){
                                                            cbxSITIO_CAPACITACION.PerformCallback(cbxPROVEEDOR_AF.GetValue().toString());                                                                                                                
                                                        }"  />
            </dx:ASPxComboBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr id="trSitioCapacitacion" runat="server">
        <td>
            <dx:ASPxLabel ID="lblCentro" runat="server" Font-Names="Verdana,Arial,Tahoma" Font-Size="XX-Small" Text="CENTRO FORMACIÓN:" />
        </td>
        <td>
            <dx:ASPxComboBox ID="cbxSITIO_CAPACITACION" ClientInstanceName="cbxSITIO_CAPACITACION"  Width="300px" runat="server" 
                DataSourceID="odsSitioCapacitacion" TextField="NOMBRE_SITIO" ValueField="ID_SITIO_CAPACITACION" />
        </td>
        <td></td>     
        <td></td>
    </tr>
    <tr>
        <td>
            <dx:ASPxLabel ID="lblNombresSolic" runat="server" Font-Names="Verdana,Arial,Tahoma" Font-Size="XX-Small" Text="NOMBRES EN SOLICITUD:" />
        </td>
        <td style="font-size: small;">
            <dx:ASPxTextBox ID="txtNOMBRES_SOLICITANTE" CssClass="textUpper" ClientInstanceName="txtNOMBRES_SOLICITANTE" runat="server" Width="150px" />
        </td>
        <td>
            <dx:ASPxLabel ID="lblApellidosSolic" runat="server" Font-Names="Verdana,Arial,Tahoma" Font-Size="XX-Small" Text="APELLIDOS EN SOLICITUD:" />
        </td>
        <td>
            <dx:ASPxTextBox ID="txtAPELLIDOS_SOLICITANTE" ClientInstanceName="txtAPELLIDOS_SOLICITANTE" runat="server" Width="150px" />
        </td>
    </tr>
    <tr>        
        <td>
            <dx:ASPxLabel ID="lblCodigoGrupo" runat="server" Font-Names="Verdana,Arial,Tahoma" Font-Size="XX-Small" Text="CÓDIGO CURSO:" />   
        </td>
        <td>
            <dx:ASPxTextBox ID="txtCODIGO_GRUPO" CssClass="textUpper" ClientInstanceName="txtCODIGO_GRUPO" runat="server" Width="150px" />
        </td>
        <td>
            <dx:ASPxLabel ID="lblCurso" runat="server" Font-Names="Verdana,Arial,Tahoma" Font-Size="XX-Small" Text="NOMBRE DE CURSO:" />            
        </td>
        <td style="font-size: small;">            
            <dx:ASPxTextBox ID="txtNOMBRE_ACCION_FORMATIVA" CssClass="textUpper" ClientInstanceName="txtNOMBRE_ACCION_FORMATIVA" runat="server" Width="150px" />
        </td>
    </tr>
    <tr id="trEstadoSolicitud" runat="server">
        <td>
            <dx:ASPxLabel ID="lblEstadoSolic" runat="server" Font-Names="Verdana,Arial,Tahoma" Font-Size="XX-Small" Text="ESTADO SOLICITUD:" />           
        </td>
        <td>
            <dx:ASPxComboBox ID="cbxESTADO_SOLICITUD" ClientInstanceName="cbxESTADO_SOLICITUD"  Width="260px" runat="server" />
        </td>
        <td>
            <dx:ASPxLabel ID="lblEjercicio" runat="server" Font-Names="Verdana,Arial,Tahoma" Font-Size="XX-Small" Text="EJERCICIO:" />            
        </td>     
        <td>
            <dx:ASPxComboBox ID="cbxEJERCICIO" ClientInstanceName="cbxEJERCICIO"  Width="100px" runat="server" 
                DataSourceID="odsEjercicio" TextField="ID_EJERCICIO" ValueField="ID_EJERCICIO" />
        </td>
    </tr>
</table>


<asp:ObjectDataSource ID="odsProveedor" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cPROVEEDOR_AF">
    <SelectParameters>               
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />        
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />      
        <asp:Parameter DefaultValue="NOMBRE_PROVEEDOR" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsSitioCapacitacion" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerListaPorPROVEEDOR_AF" TypeName="SGAFP.BL.cSITIO_CAPACITACION">
    <SelectParameters>               
        <asp:Parameter DefaultValue="0" Name="ID_PROVEEDOR_AF" Type="Decimal" />   
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />        
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />      
        <asp:Parameter DefaultValue="NOMBRE_SITIO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsEstadoSolicitud" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cESTADO_SOLICITUD">
    <SelectParameters>                       
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />                
        <asp:Parameter DefaultValue="ID_ESTADO_SOLICITUD" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsEjercicio" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cEJERCICIO">
    <SelectParameters>                       
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />                
        <asp:Parameter DefaultValue="ID_EJERCICIO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>