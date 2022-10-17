<%@ Page Title="" Language="VB" MasterPageFile="~/principalVacio.master" AutoEventWireup="false" CodeFile="wfReporteAnexosTAF.aspx.vb" Inherits="Reportes_wfAnexosTAF" %>
<%@ Register src="~/controles/ucReporte.ascx" tagname="ucReporte" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
   <uc1:ucReporte ID="ucReporte1" runat="server" />
</asp:Content>

