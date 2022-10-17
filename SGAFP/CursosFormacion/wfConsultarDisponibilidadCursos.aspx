<%@ Page Title="" Language="VB" MasterPageFile="~/principalSinUpdatePanel.master"
    AutoEventWireup="false" CodeFile="wfConsultarDisponibilidadCursos.aspx.vb" Inherits="CursosFormacion_wfConsultarDisponibilidadCursos" %>

<%@ Register src="~/controles/ucConsultarDisponibilidadCursos.ascx" tagname="ucConsultarDisponibilidadCursos" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucConsultarDisponibilidadCursos ID="ucConsultarDisponibilidadCursos1" 
        runat="server" />
</asp:Content>

