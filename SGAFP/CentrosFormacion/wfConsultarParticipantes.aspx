<%@ Page Title="Consulta de Participantes" Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfConsultarParticipantes.aspx.vb" Inherits="CentrosFormacion_wfConsultarParticipantes" %>
<%@ Register src="~/controles/ucMantPARTICIPANTE.ascx" tagname="ucMantPARTICIPANTE" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucMantPARTICIPANTE ID="ucMantPARTICIPANTE1" EsConsultaParticipante="true" runat="server" />
</asp:Content>

