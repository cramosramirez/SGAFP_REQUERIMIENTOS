<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucEvaluacionesAccionFormativa.ascx.vb" Inherits="controles_ucEvaluacionesAccionFormativa" %>
<%@ Register Src="ucBarraNavegacion.ascx" TagName="ucBarraNavegacion" TagPrefix="uc1" %>
<%@ Register Src="ucCriteriosSolicitudes.ascx" TagName="ucCriteriosSolicitudes" TagPrefix="uc2" %>
<%@ Register Src="ucCriteriosAccionFormativa.ascx" TagName="ucCriteriosAccionFormativa"
    TagPrefix="uc1" %>
<%@ Register Src="ucListaACCION_FORMATIVA.ascx" TagName="ucListaACCION_FORMATIVA"
    TagPrefix="uc2" %>
<%@ Register src="ucListaEVALUACION_AF.ascx" tagname="ucListaEVALUACION_AF" tagprefix="uc6" %>
<%@ Register src="ucVistaDetalleEVALUACION_AF.ascx" tagname="ucVistaDetalleEVALUACION_AF" tagprefix="uc7" %>
<%@ Register src="ucListaEVALUACIONES_AF_DET.ascx" tagname="ucListaEVALUACIONES_AF_DET" tagprefix="uc8" %>


<uc1:ucBarraNavegacion ID="UcBarraNavegacion1" runat="server" PermitirAgregar="false" 
    PermitirEditar="false" PermitirGuardar="false" PermitirNavegacion="false" Visible="true" />
<table width="100%">
    <tr>
	    <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">EVALUACIONES EN CURSOS</asp:Label></td>
    </tr>
    <tr>
	    <td><asp:Image ID="Image2" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></td>
    </tr>
</table>
<uc1:ucCriteriosAccionFormativa ID="ucCriteriosAccionFormativa1" runat="server" VerEjercicio="true" />
<asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" OnMenuItemClick="Menu1_MenuItemClick"
    BackColor="#B5C7DE" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em"
    ForeColor="#284E98" StaticSubMenuIndent="10px">
    <StaticSelectedStyle CssClass="TabSeleccionado" />
    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
    <DynamicMenuStyle BackColor="#B5C7DE" />
    <DynamicSelectedStyle BackColor="#507CD1" />
    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
    <Items>
        <asp:MenuItem Text="Cursos En Ejecucion" Value="0" Selected="true"></asp:MenuItem>
        <asp:MenuItem Text="Evaluaciones" Value="1"></asp:MenuItem>
        <asp:MenuItem Text="Detalle Evaluacion" Value="2"></asp:MenuItem>
    </Items>
</asp:Menu>
<asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
    <asp:View ID="View1" runat="server">
        <table cellpadding="0" cellspacing="0" width="90%">
            <tr valign="top">
                <td class="TabArea">
                    <uc2:ucListaACCION_FORMATIVA ID="ucListaACCION_FORMATIVA1" runat="server" PermitirEditar="False"
                        PermitirEliminar="False" PermitirPaginacion="True" PermitirSeleccionar="true"
                        VerCODIGO_ESTADO_AF="False" VerCOSTO_X_PARTICIPANTE="True" VerID_EJERCICIO="False"
                        VerID_OFERTA_FORMATIVA="False" VerID_PROVEEDOR_AF="False" VerID_SITIO_CAPACITACION="False"
                        VerID_TEMA_CURSO="False" VerLASTUPDATE="False" VerNOTAS="False" VerUSERID="False" />
                </td>
            </tr>
        </table>
    </asp:View>
    <asp:View ID="View2" runat="server">
        <table cellpadding="0" cellspacing="0" width="90%">
            <tr valign="top">
                <td class="TabArea">
                    <uc6:ucListaEVALUACION_AF ID="ucListaEVALUACION_AF1" runat="server" 
                        PermitirEditar="False" PermitirSeleccionar="True" VerEVALUADOR="False" 
                        VerID_ACCION_FORMATIVA="False" />
                </td>
            </tr>
        </table>
    </asp:View>
    <asp:View ID="View3" runat="server">
        <table cellpadding="0" cellspacing="0" width="90%">
            <tr valign="top">
                <td class="TabArea">
                    <uc7:ucVistaDetalleEVALUACION_AF ID="ucVistaDetalleEVALUACION_AF1" 
                        runat="server" VerID_ACCION_FORMATIVA="False" VerPORC_APROBACION="False" 
                        VerPORC_REPROBADOS="False" VerEVALUADOR="false" />
                    <uc8:ucListaEVALUACIONES_AF_DET ID="ucListaEVALUACIONES_AF_DET1" 
                        runat="server" PermitirEditar="False" PermitirEliminar="False" 
                        VerID_EVALUACION_AF="False" VerID_EVALUACION_DET="False" PermitirPaginacion="False"
                        VerNOTA_OBTENIDA="False" VerNOTA_OBTENIDAEdicion="True" VerNOTAS="False" 
                        VerNOTASEdicion="True" />
                </td>
            </tr>
        </table>
    </asp:View>
</asp:MultiView>
