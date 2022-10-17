<%@ Page Title="" Language="VB" MasterPageFile="~/principalVacio.master" AutoEventWireup="false" CodeFile="wfReporteEjecucion.aspx.vb" Inherits="Consultas_wfReporteEjecucion" %>

<%@ Register src="~/controles/ucReporteEjecucionHTP.ascx" tagname="ucReporteEjecucionHTP" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">  
   <uc1:ucReporteEjecucionHTP ID="ucReporteEjecucionHTP1" runat="server" />  
</asp:Content>

