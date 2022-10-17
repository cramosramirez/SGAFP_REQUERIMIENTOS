<%@ Page Title="" Language="VB" MasterPageFile="~/principalSinUpdatePanel.master" AutoEventWireup="false" CodeFile="wfConsultarEjecucionCursosPATI.aspx.vb" Inherits="Consultas_wfConsultarEjecucionCursosPATI" %>

<%@ Register src="../controles/ucConsultaEjecucionCursosPATI.ascx" tagname="ucConsultaEjecucionCursosPATI" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
        <uc1:ucConsultaEjecucionCursosPATI ID="ucConsultaEjecucionCursosPATI1" runat="server" 
            VerAreaFormacion="False"  ucIDClientInstanceCallbackPanel = "ucConsultaEjecucionCursosPATI_CallbackPanel" />
        </asp:Content>

