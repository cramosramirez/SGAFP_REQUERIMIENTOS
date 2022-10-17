<%@ Page Title="" Language="VB" MasterPageFile="~/principalSinUpdatePanel.master" AutoEventWireup="false" CodeFile="wfConsultarEjecucionOfertaFormativa.aspx.vb" Inherits="Consultas_wfConsultarEjecucionOfertaFormativa" %>

<%@ Register src="../controles/ucCriteriosConsultaEjecucion.ascx" tagname="ucCriteriosConsultaEjecucion" tagprefix="uc1" %>
<%@ Register src="../controles/ucConsultaEjecucionOfertaFormativa.ascx" tagname="ucConsultaEjecucionOfertaFormativa" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
        <uc1:ucCriteriosConsultaEjecucion ID="ucCriteriosConsultaEjecucion1" runat="server" 
            VerAreaFormacion="False"  ucIDClientInstanceCallbackPanel = "ucConsultaEjecucionOfertaFormativa_CallbackPanel" />
        <uc1:ucConsultaEjecucionOfertaFormativa ID="ucConsultaEjecucionOfertaFormativa1" runat="server"   />
</asp:Content>

