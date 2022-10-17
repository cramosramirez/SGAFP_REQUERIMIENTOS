<%@ Page Title="" Language="VB" MasterPageFile="~/principalVacio.master" AutoEventWireup="false" CodeFile="wfGestionOpcionesPorRol.aspx.vb" Inherits="Usuarios_wfGestionOpcionesPorRol" %>
<%@ Register src="~/controles/ucGestionOpcionesPorRol.ascx" tagname="ucGestionOpcionesPorRol" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucGestionOpcionesPorRol Id="ucGestionOpcionesPorRol1" runat="server" />
</asp:Content>

