<%@ Page Title="" Language="VB" MasterPageFile="~/principalVacio.master" AutoEventWireup="false" CodeFile="wfReporteResumenEjecucion.aspx.vb" Inherits="Consultas_wfReporteResumenEjecucion" %>
<%@ Register src="~/controles/ucReporteResumenEjecucionHTP.ascx" tagname="ucReporteResumenEjecucionHTP" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucReporteResumenEjecucionHTP ID="ucReporteResumenEjecucionHTP1" runat="server" />  
</asp:Content>

