<%@ Page Title="Consulta de Oferta Formativa" Language="VB" MasterPageFile="~/principalSinUpdatePanel.master" AutoEventWireup="false" CodeFile="wfConsultarOfertaFormativa.aspx.vb" Inherits="Consultas_wfConsultarOfertaFormativa" %>

<%@ Register src="../controles/ucCriteriosConsultaEjecucion.ascx" tagname="ucCriteriosConsultaEjecucion" tagprefix="uc1" %>
<%@ Register src="../controles/ucConsultaOfertaFormativa.ascx" tagname="ucConsultaOfertaFormativa" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">    
    <uc1:ucCriteriosConsultaEjecucion ID="ucCriteriosConsultaEjecucion1" runat="server" 
       VerPrograma="false" VerClasificacionCursos="False" VerCodigoGrupo="False" ucIDClientInstanceCallbackPanel = "ucConsultaOfertaFormativa_CallbackPanel"   />
    <uc2:ucConsultaOfertaFormativa ID="ucConsultaOfertaFormativa1" runat="server" />
</asp:Content>

