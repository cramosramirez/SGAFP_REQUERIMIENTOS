<%@ Page Title="" Language="VB" MasterPageFile="~/principalVacio.master"
    AutoEventWireup="false" CodeFile="wfSolicitudInscripcion.aspx.vb" Inherits="CursosFormacion_wfSolicitudInscripcion" %>
<%@ Register src="~/controles/ucMantSOLICITUD_INSCRIPCION_AF.ascx" tagname="ucMantSOLICITUD_INSCRIPCION_AF" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <uc2:ucMantSOLICITUD_INSCRIPCION_AF ID="ucMantSOLICITUD_INSCRIPCION_AF1" runat="server" />
</asp:Content>

