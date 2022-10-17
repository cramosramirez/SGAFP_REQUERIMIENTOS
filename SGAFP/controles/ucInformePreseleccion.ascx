<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucInformePreseleccion.ascx.vb" Inherits="controles_ucInformePreseleccion" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaGRUPO_SELECCION" Src="~/controles/ucListaGRUPO_SELECCION.ascx" %>

<%@ Register Src="ucCriteriosAccionFormativa.ascx" TagName="ucCriteriosAccionFormativa" TagPrefix="uc1" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <tr>
			   <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
        </tr>
		   <tr>
		       <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" runat="server">INFORME DE PRESELECCION</asp:Label></td>
		   </tr>
        <tr>
            <td>
                <uc1:ucCriteriosAccionFormativa ID="ucCriteriosAccionFormativa1" runat="server" VerCentroFormacion="false" VerContratoLicitacion="true" VerCodigoGrupo="false" VerAreaFormacion="false" VerEjercicio="False" VerEstado="False" />
            </td>
        </tr>		
	    <tr>
            <td><uc1:ucListaGRUPO_SELECCION id="ucListaGRUPO_SELECCION1" VerInformePreseleccion="true" PermitirCalendarizarGrupo="false" VerInformeAspirantes="false" PermitirFilaDeFiltro="false" PermitirEditar="False" runat="server"
                ></uc1:ucListaGRUPO_SELECCION>                
            </td>
        </tr>        
    </TBODY>
</TABLE>

 