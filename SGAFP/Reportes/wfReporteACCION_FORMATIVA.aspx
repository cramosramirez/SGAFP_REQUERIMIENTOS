<%@ Page Title="" Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfReporteACCION_FORMATIVA.aspx.vb" Inherits="wfReporteACCION_FORMATIVA" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" 
        Font-Size="8pt" Height="400px" Width="100%">
        <LocalReport ReportPath="reportes\repoACCION_FORMATIVA.rdlc">
            <DataSources>
                <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="ACCION_FORMATIVA" />
            </DataSources>
        </LocalReport>
    </rsweb:ReportViewer>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cACCION_FORMATIVA">
        <SelectParameters>
            <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean">
            </asp:Parameter>
            <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean">
            </asp:Parameter>
            <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String">
            </asp:Parameter>
            <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String">
            </asp:Parameter>
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>

