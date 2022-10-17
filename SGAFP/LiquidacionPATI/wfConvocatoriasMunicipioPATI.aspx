<%@ Page Title="" Language="VB" MasterPageFile="~/principalVacio.master" AutoEventWireup="false" CodeFile="wfConvocatoriasMunicipioPATI.aspx.vb" Inherits="LiquidacionPATI_wfConvocatoriasPATI" %>
<%@ Register TagName="ucConvocatoriasMunicipioPATI" Src="~/controles/ucConvocatoriasMunicipioPATI.ascx" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucConvocatoriasMunicipioPATI ID="ucConvocatoriasMunicipioPATI1" runat="server" />
</asp:Content>

