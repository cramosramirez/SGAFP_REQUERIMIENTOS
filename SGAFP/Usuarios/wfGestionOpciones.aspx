<%@ Page Title="" Language="VB" MasterPageFile="~/principalVacio.master" AutoEventWireup="false" CodeFile="wfGestionOpciones.aspx.vb" Inherits="Usuarios_wfGestionOpciones" %>
<%@ Register src="~/controles/ucGestionOpciones.ascx" tagname="ucGestionOpciones" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucGestionOpciones Id="ucGestionOpciones1" runat="server" />
</asp:Content>

