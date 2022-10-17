<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantACCION_FORMATIVA.ascx.vb" Inherits="controles_ucMantACCION_FORMATIVA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaACCION_FORMATIVA" Src="~/controles/ucListaACCION_FORMATIVA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleACCION_FORMATIVA" Src="~/controles/ucVistaDetalleACCION_FORMATIVA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleACCION_FORMATIVA_REPROG" Src="~/controles/ucVistaDetalleACCION_FORMATIVA_REPROG.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleACCION_FORMATIVA_PENA" Src="~/controles/ucVistaDetalleACCION_FORMATIVA_PENA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucCriteriosAccionFormativa" Src="~/controles/ucCriteriosAccionFormativa.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucGenerarInformeParcial" Src="~/controles/ucGenerarInformeParcial.ascx" %>

<table id="TableMant" cellspacing="0" cellpadding="0" width="100%" border="0">   
        <tbody>
	        <tr>
			   <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
            </tr>
            <tr>
		       <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">CALENDARIZACION DE CURSOS</asp:Label></td>
		   </tr>
		   <tr>
			   <td><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></td>
		   </tr>		 
            <tr>
                <td><uc1:ucCriteriosAccionFormativa ID="ucCriteriosAccionFormativa1" runat="server" VerEjercicio="False" EsConsulta="False"></uc1:ucCriteriosAccionFormativa></td>
            </tr>		   
            <tr>	       
               <td><uc1:ucListaACCION_FORMATIVA id="ucListaACCION_FORMATIVA1" runat="server" VerNOMBRE_PROVEEDOR="true"
                       VerCODIGO_ESTADO_AF="False" VerCOSTO_X_PARTICIPANTE="False" 
                       VerID_EJERCICIO="False" VerID_OFERTA_FORMATIVA="False" 
                       VerID_PROVEEDOR_AF="False" VerID_SITIO_CAPACITACION="False" 
                       VerID_TEMA_CURSO="False" VerLASTUPDATE="False" 
                       VerNOMBRE_ACCION_FORMATIVA="True" VerNOTAS="False" 
                       VerNUMERO_PARTICIPANTES="False" VerPARTICIPANTES_INSCRITOS="True" VerINFO_CONTRATO="true"  
                       VerUSERID="False" PermitirCambiarEstado="True" PermitirEliminar="True" VerColumnaReporte="true"></uc1:ucListaACCION_FORMATIVA>
               <uc1:ucVistaDetalleACCION_FORMATIVA ID="ucVistaDetalleACCION_FORMATIVA1" PermitirEditarProgramacion="true"  
                                      runat="server" Visible="false" 
                       VerFECHA_INICIO="False" VerFECHA_FIN="False"  
                       VerFECHA_INICIO_REAL="False" VerFECHA_FIN_REAL="False" VerHORARIO="False"                         
                       VerPARTICIPANTES_INSCRITOS="False" VerID_ACCION_FORMATIVA="False" ></uc1:ucVistaDetalleACCION_FORMATIVA>
               <uc1:ucVistaDetalleACCION_FORMATIVA_REPROG ID="ucVistaDetalleACCION_FORMATIVA_REPROG1"  runat="server" Visible="false"                         
                       VerPARTICIPANTES_INSCRITOS="False"  VerID_ACCION_FORMATIVA="False" ></uc1:ucVistaDetalleACCION_FORMATIVA_REPROG>     
               <uc1:ucGenerarInformeParcial ID="ucGenerarInformeParcial1"  runat="server" Visible="false" />
                <uc1:ucVistaDetalleACCION_FORMATIVA_PENA ID="ucVistaDetalleACCION_FORMATIVA_PENA1" runat="server" Visible="false"></uc1:ucVistaDetalleACCION_FORMATIVA_PENA>
               </td>
            </tr>    
       </tbody> 
</table>

