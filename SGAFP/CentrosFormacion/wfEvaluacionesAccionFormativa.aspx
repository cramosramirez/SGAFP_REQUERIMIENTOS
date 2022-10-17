<%@ Page Title="" Language="VB" MasterPageFile="~/principalSinUpdatePanel.master" AutoEventWireup="false" CodeFile="wfEvaluacionesAccionFormativa.aspx.vb" Inherits="CentrosFormacion_wfEvaluacionesAccionFormativa" %>

<%@ Register src="~/controles/ucEvaluacionesAccionFormativa.ascx" tagname="ucEvaluacionesAccionFormativa" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucEvaluacionesAccionFormativa ID="ucEvaluacionesAccionFormativa1" 
        runat="server" />
</asp:Content>

