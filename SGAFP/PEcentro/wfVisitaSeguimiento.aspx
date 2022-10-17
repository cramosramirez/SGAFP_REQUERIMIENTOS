<%@ Page Title="" Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfVisitaSeguimiento.aspx.vb" Inherits="PEcentro_wfVisitaSeguimiento" %>
<%@ Register Src="~/controles/ucVisitaSeguimientoEC.ascx" TagName="ucVisitaSeguimientoEC" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucVisitaSeguimientoEC id="ucVisitaSeguimientoEC1" runat="server">
    </uc1:ucVisitaSeguimientoEC>
</asp:Content>

