<%@ Page Title="" Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfReporteParticipantesSolicitados.aspx.vb" Inherits="Reportes_wfReporteParticipantesSolicitados" %>
<%@ Register TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" TagPrefix="uc1" %>
<%@ Register TagName="ucCriteriosMunicipiosPATI" Src="~/controles/ucCriteriosMunicipiosPATI.ascx" TagPrefix="uc1" %>
<%@ Register Assembly="DevExpress.XtraReports.v11.1.Web, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
<uc1:ucBarraNavegacion ID="ucBarraNavegacion1" HabilitarCallBacks="true" runat="server" />
    <uc1:ucCriteriosMunicipiosPATI ID="ucCriteriosMunicipiosPATI1" runat="server" />
</asp:Content>

