<%@ Page Title="" Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfSolicitudEnviadaCorrectamente.aspx.vb" Inherits="CursosFormacion_wfSolicitudEnviadaCorrectamente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <table style="width: 203%">
        <tr>
            <td>
                <p style="font-size: large; color: #FF0000">
                    <b><i>
                        <asp:Label ID="LabelMensaje" runat="server" Text="Label"></asp:Label></i></b></p>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/CursosFormacion/wfConsultarDisponibilidadCursos.aspx">Regresar a Consulta de Disponibilidad de Cursos</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <asp:HyperLink ID="HyperLinkNuevaSolicitud" runat="server" NavigateUrl="~/CursosFormacion/wfConsultarDisponibilidadCursos.aspx">Ingresar una Nueva Solicitud al mismo Curso</asp:HyperLink>
            </td>
        </tr>
    </table>
</asp:Content>

