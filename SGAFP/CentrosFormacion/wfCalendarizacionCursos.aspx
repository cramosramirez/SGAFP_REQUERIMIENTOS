<%@ Page Title="" Language="VB" MasterPageFile="~/principal.master"
    AutoEventWireup="false" CodeFile="wfCalendarizacionCursos.aspx.vb" Inherits="CursosFormacion_wfCalendarizacionCursos" %>

<%@ Register Src="~/controles/ucMantACCION_FORMATIVA.ascx" TagName="ucMantACCION_FORMATIVA"
    TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucMantACCION_FORMATIVA id="ucMantACCION_FORMATIVA1" runat="server">
    </uc1:ucMantACCION_FORMATIVA>
</asp:Content>

