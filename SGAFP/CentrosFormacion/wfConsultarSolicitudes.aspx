<%@ Page Title="Consulta de Solicitudes" Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfConsultarSolicitudes.aspx.vb" Inherits="CentrosFormacion_wfConsultarSolicitudes" %>

<%@ Register src="../controles/ucConsultarSolicitudes.ascx" tagname="ucConsultarSolicitudes" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucConsultarSolicitudes ID="ucConsultarSolicitudes1" runat="server" />
</asp:Content>

