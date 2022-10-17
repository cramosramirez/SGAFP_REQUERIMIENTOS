<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucAsistenciaAccionFormativa.ascx.vb" Inherits="controles_ucAsistenciaAccionFormativa" %>
<%@ Register src="ucBarraNavegacion.ascx" tagname="ucBarraNavegacion" tagprefix="uc1" %>
<%@ Register src="ucCriteriosSolicitudes.ascx" tagname="ucCriteriosSolicitudes" tagprefix="uc2" %>
<%@ Register src="ucCriteriosAccionFormativa.ascx" tagname="ucCriteriosAccionFormativa" tagprefix="uc1" %>
<%@ Register src="ucListaACCION_FORMATIVA.ascx" tagname="ucListaACCION_FORMATIVA" tagprefix="uc2" %>
<%@ Register src="ucAsistenciaAccionFormativaHoras.ascx" tagname="ucAsistenciaAccionFormativaHoras" tagprefix="uc6" %>
<%@ Register assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxTabControl" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxClasses" tagprefix="dx" %>
<uc1:ucBarraNavegacion ID="UcBarraNavegacion1" runat="server" PermitirAgregar="false"
    PermitirEditar="false" PermitirGuardar="false" PermitirNavegacion="false" 
    Visible="true" />
<table width="100%">
    <tr>
	    <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">ASISTENCIA A CURSOS</asp:Label></td>
    </tr>
    <tr>
	    <td><asp:Image ID="Image2" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></td>
    </tr>
</table>

<uc1:ucCriteriosAccionFormativa ID="ucCriteriosAccionFormativa1" 
    runat="server" VerEjercicio="True" />
<dx:ASPxPageControl ID="ASPxPageControl1" Width="100%"  runat="server" ActiveTabIndex="0" 
    AutoPostBack="True">
    <TabPages>
        <dx:TabPage Text="Cursos En Ejecucion">
            <ContentCollection>
                <dx:ContentControl runat="server">
                    <uc2:ucListaACCION_FORMATIVA ID="ucListaACCION_FORMATIVA1" runat="server" 
                        PermitirEditar="False" PermitirEliminar="False" PermitirPaginacion="True" 
                        PermitirSeleccionar="true" VerCODIGO_ESTADO_AF="False" 
                        VerCOSTO_X_PARTICIPANTE="True" VerID_EJERCICIO="False" 
                        VerID_OFERTA_FORMATIVA="False" VerID_PROVEEDOR_AF="False" 
                        VerID_SITIO_CAPACITACION="False" VerID_TEMA_CURSO="False" VerLASTUPDATE="False" 
                        VerNOTAS="False" VerUSERID="False" />
                </dx:ContentControl>
            </ContentCollection>
        </dx:TabPage>
        <dx:TabPage Text="Asistencia">
            <ContentCollection>
                <dx:ContentControl runat="server">
                    <uc6:ucAsistenciaAccionFormativaHoras ID="ucAsistenciaAccionFormativaHoras1" 
                        runat="server" TamanoPagina="30" />
                </dx:ContentControl>
            </ContentCollection>
        </dx:TabPage>
    </TabPages>
</dx:ASPxPageControl>

