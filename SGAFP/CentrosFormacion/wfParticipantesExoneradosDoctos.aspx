<%@ Page Title="" Language="VB" MasterPageFile="~/principalSinUpdatePanel.master" AutoEventWireup="false" CodeFile="wfParticipantesExoneradosDoctos.aspx.vb" Inherits="CentrosFormacion_wfParticipantesExoneradosDoctos" %>
<%@ Register Src="~/controles/ucMantPARTICIPANTE_EXONERADO_DOC.ascx" TagName="ucMantPARTICIPANTE_EXONERADO_DOC" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
     <uc1:ucMantPARTICIPANTE_EXONERADO_DOC id="ucMantPARTICIPANTE_EXONERADO_DOC1" runat="server" />
</asp:Content>

