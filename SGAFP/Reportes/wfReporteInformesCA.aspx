<%@ Page Title="" Language="VB" MasterPageFile="~/principalVacio.master" AutoEventWireup="false" CodeFile="wfReporteInformesCA.aspx.vb" Inherits="Reportes_wfReporteInformesCA" %>
<%@ Register src="~/controles/ucReporteInformesCA.ascx" tagname="ucReporteInformesCA" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucReporteInformesCA ID="ucReporteInformesCA1" runat="server" />
</asp:Content>

