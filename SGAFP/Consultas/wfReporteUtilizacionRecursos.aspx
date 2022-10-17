<%@ Page Title="" Language="VB" MasterPageFile="~/principalVacio.master" AutoEventWireup="false" CodeFile="wfReporteUtilizacionRecursos.aspx.vb" Inherits="Consultas_wfReporteUtilizacionRecursos" %>
<%@ Register src="~/controles/ucReporteUtilizacionRecursosProveedorHTP.ascx" tagname="ucReporteUtilizacionRecursosProveedorHTP" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucReporteUtilizacionRecursosProveedorHTP ID="ucReporteUtilizacionRecursosProveedorHTP1" runat="server" />  
</asp:Content>

