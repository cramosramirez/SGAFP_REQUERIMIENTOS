<%@ Page Title="" Language="VB" MasterPageFile="~/principalVacio.master" AutoEventWireup="false" CodeFile="wfFacturaAccionFormativa.aspx.vb" Inherits="CentrosFormacion_wfFacturaAccionFormativa" %>
<%@ Register src="~/controles/ucFacturaAccionFormativa.ascx" tagname="ucFacturaAccionFormativa" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucFacturaAccionFormativa ID="ucFacturaAccionFormativa1" runat="server" />
</asp:Content>

