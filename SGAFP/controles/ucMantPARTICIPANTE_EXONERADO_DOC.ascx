<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantPARTICIPANTE_EXONERADO_DOC.ascx.vb" Inherits="controles_ucMantPARTICIPANTE_EXONERADO_DOC" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucCriteriosParticipanteExoneradoDoc" Src="~/controles/ucCriteriosParticipanteExoneradoDoc.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPARTICIPANTE_EXONERADO_DOC" Src="~/controles/ucListaPARTICIPANTE_EXONERADO_DOC.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPARTICIPANTE" Src="~/controles/ucListaPARTICIPANTE.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetallePARTICIPANTE_EXONERADO_DOC" Src="~/controles/ucVistaDetallePARTICIPANTE_EXONERADO_DOC.ascx" %>
<table id="TableMant" cellspacing="0" cellpadding="0" width="100%" border="0">
    <tbody>
	       <tr>
			   <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
        </tr>
		   <tr>
		       <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">PARTICIPANTEX EXONERADOS DE DOCUMENTOS</asp:Label></td>
		   </tr>
		   <tr>
			   <td><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></td>
		   </tr>		 
	       <tr>
            <td>
            <uc1:ucCriteriosParticipanteExoneradoDoc id="ucCriteriosParticipanteExoneradoDoc1" runat="server" />            
            <uc1:ucListaPARTICIPANTE_EXONERADO_DOC id="ucListaPARTICIPANTE_EXONERADO_DOC1" runat="server"                  
                 VerCON_DISCAPACIDAD="false" VerDEPARTAMENTO_NAC="false" VerDIRECCION="false" VerEMAIL="false" 
                 VerCODIGO_DEPARTAMENTO="false"  VerCODIGO_MUNICIPIO="false" VerID_PARTICIPANTE_EXONERADO="false"   
                 VerES_APROBADO="false" VerFECHA_EVALUA="false" VerGENERO="false" VerID_ESTADO_CIVIL="false" PermitirFilaDeFiltro="false" VerESTADO="false"   
                 VerID_NIVEL_ACADEMICO="false" VerID_PAIS="false" VerID_PARTICIPANTE="false" VerID_PROVEEDOR_AF="false" PermitirFiltroEnEncabezado="false" 
                 VerID_SITIO_CAPACITACION="false" VerLASTUPDATE="false" VerMOVIL="false" VerMUNICIPIO_NAC="false" PermitirFocoEnFilas="false" 
                 VerTELEFONO="false" VerUSERID="false" VerUSUARIO_EVALUA="false" VerMensajeGrid="false"  ></uc1:ucListaPARTICIPANTE_EXONERADO_DOC>                                  
                <uc1:ucVistaDetallePARTICIPANTE_EXONERADO_DOC ID="ucVistaDetallePARTICIPANTE_EXONERADO_DOC1" runat="server" Visible="false" 
                  VerFECHA_INGRESO="false" VerUSERID="false" VerID_PARTICIPANTE="false" VerID_PARTICIPANTE_EXONERADO="false"
                  VerUSUARIO_EVALUA="false" VerLASTUPDATE="false" VerFECHA_EVALUA="false"        
                />
                <uc1:ucListaPARTICIPANTE_EXONERADO_DOC id="ucListaPARTICIPANTE_EXONERADO_DOC2" runat="server"                                                   
                 VerNOMBRE_PROVEEDOR="false" VerNOMBRE_SITIO="false"  
                 VerCON_DISCAPACIDAD="false" VerDEPARTAMENTO_NAC="false" VerDIRECCION="true" VerEMAIL="false"
                 VerCODIGO_DEPARTAMENTO="false"  VerCODIGO_MUNICIPIO="false" VerID_PARTICIPANTE_EXONERADO="false" 
                 VerES_APROBADO="false" VerFECHA_EVALUA="false" VerGENERO="false" VerID_ESTADO_CIVIL="false" PermitirFilaDeFiltro="false" VerESTADO="false"   
                 VerID_NIVEL_ACADEMICO="false" VerID_PAIS="false" VerID_PARTICIPANTE="false" VerID_PROVEEDOR_AF="false" PermitirFiltroEnEncabezado="false" 
                 VerID_SITIO_CAPACITACION="false" VerLASTUPDATE="false" VerMOVIL="true" VerMUNICIPIO_NAC="false" PermitirFocoEnFilas="false" 
                 VerTELEFONO="true" VerUSERID="false" VerUSUARIO_EVALUA="false" VerFECHA_INGRESO="false" PermitirEliminar="false"  
                 PermitirEditar="false" VerMensajeGrid="false"></uc1:ucListaPARTICIPANTE_EXONERADO_DOC>                
                <uc1:ucListaPARTICIPANTE id="ucListaPARTICIPANTE1" runat="server" VerCODIGO_DEPARTAMENTO="false"
                 VerCODIGO_MUNICIPIO="false" VerCON_DISCAPACIDAD="false" VerCursosRecibidos="false" VerDEPARTAMENTO_NAC="false"
                 VerDISC_OTRA="false" VerEMAIL="false" VerGENERO="false" VerID_ESTADO_CIVIL="false" VerID_NIVEL_ACADEMICO="false"
                 VerID_PAIS="false" VerISSS="false" VerLASTUPDATE="false" VerMUNICIPIO_NAC="false" VerNUM_DOCTO="false"
                 VerOCUPACION_ACTUAL="false" VerOTRA_EDUCACION_FORMAL="false" VerPROFESION_OFICIO="false" VerTIPO_DOCTO="false"
                 VerTITULO_CERTIFICADO_OBTENIDO="false" VerUSERID="false" Visible="false" 
                 PermitirFilaDeFiltro="false" PermitirFocoEnFilas="false" PermitirEliminar="false" 
                 PermitirEditar="false" VerMensajeGrid="false" PermitirFiltroEnEncabezado="false"     />
           </td>
        </tr>
    </tbody>
</table>
