<%@ Page Title="Evaluacion de Solicitudes" Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfEvaluarSolicitudes.aspx.vb" Inherits="CentrosFormacion_wfEvaluarSolicitudes" %>

<%@ Register src="~/controles/ucEvaluarSolicitudes.ascx" tagname="ucEvaluarSolicitudes" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
        <uc1:ucEvaluarSolicitudes ID="ucEvaluarSolicitudes1" runat="server" />
</asp:Content>

