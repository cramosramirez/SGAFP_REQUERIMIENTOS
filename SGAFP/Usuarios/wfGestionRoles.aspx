<%@ Page Title="" Language="VB" MasterPageFile="~/principalVacio.master" AutoEventWireup="false" CodeFile="wfGestionRoles.aspx.vb" Inherits="Usuarios_wfGestionRoles" %>
<%@ Register src="~/controles/ucGestionRoles.ascx" tagname="ucGestionRoles" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucGestionRoles Id="ucGestionRoles1" runat="server" />
</asp:Content>

