<%@ Page Title="" Language="VB" MasterPageFile="~/principalVacio.master" AutoEventWireup="false" CodeFile="wfDesembolsosPATI.aspx.vb" Inherits="LiquidacionPATI_Desembolso_wfConsultaDesembolso" %>
<%@ Register Src="~/controles/ucDesembolsoPATI.ascx" TagName="ucDesembolsoPATI" TagPrefix="uc1" %>

    
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
   <uc1:ucDesembolsoPATI id="ucDesembolsoPATI1" runat="server" />
</asp:Content>

