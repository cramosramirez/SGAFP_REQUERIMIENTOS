<%@ Page Title="" Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfGestionUsuarios.aspx.vb" Inherits="GFI_wfGestionUsuarios" %>
<%@ Register TagPrefix="uc1" Src="~/controles/ucMantUSUARIO.ascx" TagName="ucMantUSUARIO" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucMantUSUARIO ID="ucMantUSUARIO1" runat="server" /> 
</asp:Content>

