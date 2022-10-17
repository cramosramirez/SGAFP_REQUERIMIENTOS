<%@ Page Title="" Language="VB" MasterPageFile="~/principalVacio.master" AutoEventWireup="false" CodeFile="wfRecepcionAccionesFormativas.aspx.vb" Inherits="PagoAccionesFormativas_wfRecepcionAccionesFormativas" %>
<%@ Register src="~/controles/ucOrdenesCompraPATI.ascx" tagname="ucOrdenesCompraPATI" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucOrdenesCompraPATI ID="ucOrdenesCompraPATI1" runat="server" />
</asp:Content>

