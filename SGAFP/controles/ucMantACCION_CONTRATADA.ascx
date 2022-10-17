<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantACCION_CONTRATADA.ascx.vb" Inherits="controles_ucMantACCION_CONTRATADA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaACCION_CONTRATADA" Src="~/controles/ucListaACCION_CONTRATADA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleGRUPO_SELECCION" Src="~/controles/ucVistaDetalleGRUPO_SELECCION.ascx" %>
<%@ Register Src="ucCriteriosAccionFormativa.ascx" TagName="ucCriteriosAccionFormativa" TagPrefix="uc1" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
         <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" runat="server">CARRERAS ADJUDICADAS EN PROGRAMA EMPRESA CENTRO</asp:Label></TD>
		   </TR>
        <tr>
            <td>
                <uc1:ucCriteriosAccionFormativa ID="ucCriteriosAccionFormativa1" runat="server" VerCentroFormacion="false" VerContratoLicitacion="true" VerCodigoGrupo="false" VerAreaFormacion="false" VerEjercicio="False" VerEstado="False" />
            </td>
        </tr>		  
	       <TR>
            <TD><uc1:ucListaACCION_CONTRATADA id="ucListaACCION_CONTRATADA1" PermitirFilaDeFiltro="false" PermitirEditar="false" PermitirEliminarInline="false"  runat="server"></uc1:ucListaACCION_CONTRATADA>
                </TD>
        </TR>
        <tr>
            <td>
                <uc1:ucVistaDetalleGRUPO_SELECCION id="ucVistaDetalleGRUPO_SELECCION1" runat="server" />
            </td>
        </tr>
    </TBODY>
</TABLE>
