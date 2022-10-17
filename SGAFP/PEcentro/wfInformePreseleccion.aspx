<%@ Page Title="" Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfInformePreseleccion.aspx.vb" Inherits="PEcentro_wfInformePreseleccion" %>
<%@ Register Src="~/controles/ucInformePreseleccion.ascx" TagName="ucInformePreseleccion" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucInformePreseleccion id="ucInformePreseleccion1" runat="server"></uc1:ucInformePreseleccion>
</asp:Content>

