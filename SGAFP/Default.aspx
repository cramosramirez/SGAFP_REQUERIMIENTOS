<%@ Page MasterPageFile="~/Principal.master" Title="SGAFP" Language="VB" CodeFile="Default.aspx.vb" Inherits="_Default" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<%@ Register TagName="ucListaINFORME_FINAL_AF" Src="~/controles/ucListaINFORME_FINAL_AF.ascx"  TagPrefix="uc1" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Import Namespace="System.Collections.Generic"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">     
<table style="width: 96%">
    <tr>
        <td style="font-family:'Agency FB'; font-size:25px" align="center">
            <b>Bienvenidos al Sistema de Gestión y Administración de la Formación Profesional(SGAFP) del INSAFORP.</b></td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            <p class="MsoNormal" style="text-align:justify">
                <span lang="ES" style="font-family:
Arial">El sistema <b style="mso-bidi-font-weight:normal">SGAFP</b> 
                representa el impulso tecnológico que INSAFORP utiliza para Administrar y Gestionar la Formación Profesional del país; es importante resaltar con esta herramienta informática se da servicio a los Programas Habil Tecnico Permanente(HTP) y Programas Especiales de capacitación los cuales representan el compromiso social que el INSAFORP tiene con nuestro país, ya que dichos programas son para atención a la población vulnerable, atendiendola en distintas temáticas ocupacionales.<o:p></o:p></span></p>
        </td>
    </tr>   
    <tr>
        <td>
        <dx:ASPxLabel ID="lblMensaje" runat="server" Font-Size="Small" ForeColor="Blue" Font-Bold="true" Font-Names="Tahoma" Visible="false" />
        <br />
        </td>
   </tr>
   <tr>
        <td>
        <uc1:ucListaINFORME_FINAL_AF ID="ucListaINFORME_FINAL_AF1" runat="server" PermitirEditar="False"
        PermitirEliminar="False" PermitirPaginacion="True" PermitirSeleccionar="false"
        VerCODIGO_ESTADO_AF="False" VerID_PROVEEDOR_AF="False" TamanoFuente ="X-Small"   
        VerUSERID="False"  PermitirFocoEnFilas="false" PermitirRowHotTrack="false"
        VerID_ACCION_FORMATIVA="false" VerFECHA_INFORME="false" VerNUMERO_FACTURA="False" VerHORARIO="false" VerHORAS_ACUMULADAS="false"
        VerHORAS_DESARROLLADAS="false" VerDURACION="false" VerFECHA_FINAL="false" VerFECHA_INICIAL="false"
        VerELABORADO_POR="False" VerMONTO_APROBADO="False" VerPORC_PROM_ASISTENCIA="False" Visible="false" 
        VerNOTA_PROMEDIO="false" VerESTADO="false" VerCOMENTARIOS="true" VerUSUARIO_APROBACION="false"
        VerID_ESTADO_INFORME="false" PermitirFiltroEnEncabezado="false" VerID_INFORME_FINAL="false" VerPARTICIPANTES_FINALES="false"
        VerPARTICIPANTES_INSCRITOS="false" VerMONTO_FACTURA="false" PermitirFilaDeFiltro="false" 
        VerNOMBRE_PROGRAMA_FORMACION="true" VerNOMBRE_ESTADO_INFORME="true" VerNOMBRE_USUARIO="true"
        VerLUGAR_EJECUCION="true" VerNOMBRE_PROVEEDOR="true" />   
        </td>
    </tr>  
</table>
</asp:Content>
