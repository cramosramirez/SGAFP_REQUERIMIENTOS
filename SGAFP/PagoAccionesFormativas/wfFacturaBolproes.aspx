<%@ Page Title="" Language="VB" MasterPageFile="~/principalVacio.master" AutoEventWireup="false" CodeFile="wfFacturaBolproes.aspx.vb" Inherits="PagoAccionesFormativas_wfFacturaBolproes" %>
<%@ Register src="~/controles/ucFacturaBolproes.ascx" tagname="ucFacturaBolproes" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucFacturaBolproes ID="ucFacturaBolproes1" runat="server" />
</asp:Content>

