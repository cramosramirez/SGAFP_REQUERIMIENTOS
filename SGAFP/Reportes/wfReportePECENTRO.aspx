<%@ Page Title="" Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfReportePECENTRO.aspx.vb" Inherits="Reporte_wfReportesPECENTRO" %>
<%@ Register src="~/controles/ucReporte.ascx" tagname="ucReporte" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucReporte ID="ucReporte1" runat="server" />
</asp:Content>

