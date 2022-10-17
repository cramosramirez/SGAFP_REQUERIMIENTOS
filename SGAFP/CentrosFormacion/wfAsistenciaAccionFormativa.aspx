<%@ Page Title="Asistencia a Cursos" Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfAsistenciaAccionFormativa.aspx.vb" Inherits="CentrosFormacion_wfAsistenciaAccionFormativa" %>
<%@ Register src="../controles/ucAsistenciaAccionFormativa.ascx" tagname="ucAsistenciaAccionFormativa" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc1:ucAsistenciaAccionFormativa ID="ucAsistenciaAccionFormativa1" 
        runat="server" />
</asp:Content>

