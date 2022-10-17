<%@ Page Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfGestionSistemas.aspx.vb" Inherits="wfGestionSistemas" title="Mantenimiento de Sistemas" %>
<%@ Register Src="~/controles/ucMantSistemas.ascx" TagName="ucMantSistemas" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucMantSistemas id="ucMantSistemas1" runat="server"></uc1:ucMantSistemas>
</asp:Content>
