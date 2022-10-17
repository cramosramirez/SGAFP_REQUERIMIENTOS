 <%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCriteriosMunicipiosPATI.ascx.vb" Inherits="controles_ucCriteriosMunicipiosPATI" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>

<table cellpadding="0" cellspacing="2" border="0" >
    <tr id="trPrograma" runat="server" >
        <td>
            <dx:ASPxLabel ID="lblFuente" runat="server" Font-Size="X-Small" Text="Fuente:" />
        </td>
        <td>
            <dx:ASPxComboBox runat="server" ID="cbxFuenteFinanciamiento" DataSourceID="odsFuente" TextField="NOMBRE_FUENTE" 
                ValueField="ID_FUENTE" ClientInstanceName="cbxFuenteFinanciamiento" AutoPostBack="True"  
                ValueType="System.Decimal" Width="170px" Font-Size="X-Small" >                                              
            </dx:ASPxComboBox>
        </td>
    </tr>
    <tr id="trDepartamento" runat="server" >
        <td>
            <dx:ASPxLabel ID="lblDepartamento" runat="server" Font-Size="X-Small" Text="Departamento:" />
        </td>
        <td>
            <dx:ASPxComboBox runat="server" ID="cbxDepartamento" DataSourceID="odsDepartamento" TextField="NOMBRE" 
                ValueField="CODIGO_DEPARTAMENTO" ClientInstanceName="cbxDepartamento" ValueType="System.String" Width="170px" Font-Size="X-Small">                   
                 <ClientSideEvents SelectedIndexChanged="function(s,e){cbxMunicipio.PerformCallback(cbxFuenteFinanciamiento.GetValue() + ';' + cbxDepartamento.GetValue())}"  />
            </dx:ASPxComboBox>            
        </td>
    </tr>
     <tr id="trMunicipio" runat="server">
        <td>
            <dx:ASPxLabel ID="lblMunicipio" runat="server" Font-Size="X-Small" Text="Municipio:" />
        </td>
        <td>
            <dx:ASPxComboBox runat="server" ID="cbxMunicipio" DataSourceID="odsMunicipio" TextField="NOMBRE" 
                ValueField="CODIGO_MUNICIPIO" ClientInstanceName="cbxMunicipio" ValueType="System.String" Width="170px" Font-Size="X-Small">  
                <ClientSideEvents EndCallback="function(s,e){s.SetValue('-1');}"  />                 
            </dx:ASPxComboBox>            
        </td>
    </tr> 
    <tr id="trConvocatoria" runat="server">
        <td>
            <dx:ASPxLabel ID="lblConvocatoria" runat="server" Font-Size="X-Small" Text="N° Convocatoria:" />
        </td>
        <td>
            <dx:ASPxSpinEdit ID="speConvocatoria" ClientInstanceName="speConvocatoria" Font-Size="XX-Small" runat="server" NumberType="Integer" AllowUserInput="true" Number="1" MinValue="1" MaxValue="1000"  >                                          
            </dx:ASPxSpinEdit>          
        </td>
    </tr> 
    </table>    
    <dx:ASPxHiddenField runat="server" ID="hf" ClientInstanceName="hf" SyncWithServer="true" /> 
    
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