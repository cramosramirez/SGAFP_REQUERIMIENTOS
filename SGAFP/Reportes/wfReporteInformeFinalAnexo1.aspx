<%@ Page Title="" Language="VB" MasterPageFile="~/principalSinUpdatePanel.master" AutoEventWireup="false" CodeFile="wfReporteInformeFinalAnexo1.aspx.vb" Inherits="Reportes_wfReporteInformeFinalAnexo1" %>
<%@ Register src="~/controles/ucReporte.ascx" tagname="ucReporte" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucReporte ID="ucReporte1" runat="server" />
</asp:Content>

