<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCriteriosConsultaEjecucionPATI.ascx.vb" Inherits="controles_ucCriteriosConsultaEjecucionPATI" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>

<script type="text/javascript" language="javascript" >
        function SetTodos(s) {            
            s.SetText('[Todos]');
        }
</script>
<table cellpadding="0" cellspacing="2" border="0" >
    <tr id="trFuente" runat="server" >
        <td>
            <dx:ASPxLabel ID="lblFuente" runat="server" Text="Fuente:" 
                Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small" />
        </td>
        <td>
            <dx:ASPxComboBox ID="cbxFuenteFinanc" runat="server" 
                ClientInstanceName="cbxFuenteFinanc" DataSourceID="odsFuenteFinanc" 
                EnableCallbackMode="True" TextField="NOMBRE_FUENTE" TextFormatString="{1}" 
                ValueField="ID_FUENTE" ValueType="System.String">
                <Columns>
                    <dx:ListBoxColumn FieldName="ID_FUENTE" />
                    <dx:ListBoxColumn FieldName="NOMBRE_FUENTE" />
                </Columns>
            </dx:ASPxComboBox>
            <asp:ObjectDataSource ID="odsFuenteFinanc" runat="server" 
                OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
                TypeName="SGAFP.BL.cFUENTE_FINANCIAMIENTO">
                <SelectParameters>
                    <asp:Parameter Name="recuperarHijas" Type="Boolean" />
                    <asp:Parameter Name="asColumnaOrden" Type="String" />
                    <asp:Parameter Name="asTipoOrden" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </td>
    </tr>
    <tr id="trConvocatoria" runat="server" >
        <td>
            <dx:ASPxLabel ID="lblConvocatoria" runat="server" Text="Convocatoria:" 
                Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small" />
        </td>
        <td>
            <dx:ASPxSpinEdit ID="seConvocatoria" runat="server" Height="21px" Number="1" 
                ClientInstanceName="seConvocatoria" MaxValue="10" MinValue="1" 
                NumberType="Integer" Width="42px" />
        </td>
    </tr>
  
     <%--<tr id="trMostrar" runat="server">
        <th colspan="2" align="right"  >
            <dx:ASPxButton runat="server" ID="btnMostrar" Text="Mostrar" AutoPostBack="false" UseSubmitBehavior="false"
            CssFilePath="~/App_Themes/Aqua/{0}/styles.css" CssPostfix="Aqua" Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small"
            SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" >                                       
            <ClientSideEvents Click="function(s,e) {                                                                                                         
                      CallbackPanel.PerformCallback(cbxFuenteFinanc.GetValue() + ';' + seConvocatoria.GetValue()) }" />
        </dx:ASPxButton> 
        </th>        
     </tr>     --%>                           
</table>    
<dx:ASPxHiddenField runat="server" ID="hf" ClientInstanceName="hf" SyncWithServer="true" /> 


