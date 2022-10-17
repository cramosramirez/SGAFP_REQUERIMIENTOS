<%@ Page Title="Informe Final" Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfInformeFinalAccionFormativa.aspx.vb" Inherits="CentrosFormacion_wfInformeFinalAccionFormativa" %>

<%@ Register src="~/controles/ucInformeFinalAccionFormativa.ascx" tagname="ucInformeFinalAccionFormativa" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucInformeFinalAccionFormativa ID="ucInformeFinalAccionFormativa1" 
        runat="server" />
</asp:Content>

