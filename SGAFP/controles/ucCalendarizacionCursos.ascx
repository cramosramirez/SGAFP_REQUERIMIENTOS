<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCalendarizacionCursos.ascx.vb" Inherits="controles_ucCalendarizacionCursos" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<%@ Register Src="ucCriteriosAccionFormativa.ascx" TagName="ucCriteriosAccionFormativa" TagPrefix="uc1" %>
<%@ Register Src="ucBarraNavegacion.ascx" TagName="ucBarraNavegacion" TagPrefix="uc1" %>
<%@ Register Src="ucListaACCION_FORMATIVA.ascx" TagName="ucListaACCION_FORMATIVA" TagPrefix="uc1" %>
<%@ Register src="ucVistaDetalleACCION_FORMATIVA.ascx" tagname="ucVistaDetalleACCION_FORMATIVA" tagprefix="uc2" %>
<asp:panel id="PanelPagina" runat="server">
    <asp:panel id="PanelNavegacion" runat="server">    
        <uc1:ucBarraNavegacion ID="UcBarraNavegacion1" runat="server" 
                        PermitirAgregar="false"  PermitirEditar="false" 
                        PermitirGuardar="false" 
                        PermitirNavegacion="false" Visible="true" />
    </asp:panel>    
    <asp:panel id="PanelCriterios" runat="server">    
        <uc1:ucCriteriosAccionFormativa ID="ucCriteriosAccionFormativa1" runat="server" VerEjercicio="True"
             VerEstado="True" />
    </asp:panel>
    <asp:panel id="PanelLista" runat="server">    
        <uc1:ucListaACCION_FORMATIVA ID="ucListaACCION_FORMATIVA1" runat="server" 
                            PermitirEditar="False" PermitirEliminar="False" PermitirPaginacion="True" 
                            VerCODIGO_ESTADO_AF="False" VerCOSTO_X_PARTICIPANTE="False" 
                            VerID_EJERCICIO="False" VerID_OFERTA_FORMATIVA="False" 
                            VerID_PROVEEDOR_AF="False" VerID_SITIO_CAPACITACION="True" 
                            VerID_TEMA_CURSO="False" VerLASTUPDATE="False" VerUSERID="False"
                            VerNOTAS="False" VerCODIGO_GRUPO="True" 
                            VerDURACION_HORAS="True" VerFECHA_FIN="False" VerFECHA_INICIO="True" 
                            VerHORARIO="True" VerID_ACCION_FORMATIVA="True" 
                            VerNOMBRE_ACCION_FORMATIVA="True" VerNUMERO_PARTICIPANTES="True" 
                            VerPARTICIPANTES_INSCRITOS="True" VerLUGAR_EJECUCION="True" VerINFO_CONTRATO="True"
            PermitirFiltroPorFila="True"/>                        
    </asp:panel>
    <asp:panel id="PanelDetalleAccion" runat="server">    
        <uc2:ucVistaDetalleACCION_FORMATIVA ID="ucVistaDetalleACCION_FORMATIVA1" runat="server" />
    </asp:panel>                        
</asp:panel>


