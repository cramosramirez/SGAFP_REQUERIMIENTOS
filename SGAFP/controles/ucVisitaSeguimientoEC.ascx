<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVisitaSeguimientoEC.ascx.vb" Inherits="controles_ucVisitaSeguimientoEC" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaACCION_FORMATIVA" Src="~/controles/ucListaACCION_FORMATIVA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucCriteriosAccionFormativa" Src="~/controles/ucCriteriosAccionFormativa.ascx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

<table id="TableMant" cellspacing="0" cellpadding="0" width="100%" border="0">   
        <tbody>
	        <tr>
			   <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
            </tr>
            <tr>
                <td><uc1:ucCriteriosAccionFormativa ID="ucCriteriosAccionFormativa1" runat="server" VerCentroFormacion="false" VerAreaFormacion="false" VerEjercicio="True" VerEstado="False" /></td>
            </tr>		   
            <tr>	       
               <td><uc1:ucListaACCION_FORMATIVA id="ucListaACCION_FORMATIVA1" runat="server" VerNOMBRE_PROVEEDOR="true" VerNoVisitasSeguimiento="true" 
                       VerCODIGO_ESTADO_AF="False" VerCOSTO_X_PARTICIPANTE="False" PermitirEditar="false" 
                       VerID_EJERCICIO="False" VerID_OFERTA_FORMATIVA="False"
                       VerID_PROVEEDOR_AF="False" VerID_SITIO_CAPACITACION="False" 
                       VerID_TEMA_CURSO="False" VerLASTUPDATE="False" PermitirAccesoAutorizacionParti="False"
                       VerNOMBRE_ACCION_FORMATIVA="True" VerNOTAS="False" PermitirIngresarVisitasSeguimientoEC="true" 
                       VerNUMERO_PARTICIPANTES="False" VerPARTICIPANTES_INSCRITOS="True"
                       VerUSERID="False" PermitirCambiarEstado="False" PermitirEliminar="False" VerColumnaReporte="true"></uc1:ucListaACCION_FORMATIVA>              
               </td>
            </tr>    
       </tbody> 
</table>

 <dx:ASPxPopupControl ID="popupNoVisitasSeguimiento" Modal="True" runat="server" 
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" PopupElementID="BuscarNombresbtn" HeaderStyle-Font-Bold="true" HeaderText="Ingrese el No. de visitas de seguimiento" Width="400px"    
        AllowDragging="True"
        CloseAction="CloseButton" CssFilePath="~/App_Themes/Office2010Blue/{0}/styles.css" CssPostfix="Office2010Blue" EnableHotTrack="False" SpriteCssFilePath="~/App_Themes/Office2010Blue/{0}/sprite.css">  
                 <LoadingPanelStyle ImageSpacing="5px">
                 </LoadingPanelStyle>
                 <ContentCollection>
                     <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server" >          
                        <table width="100%">
                            <tr>
                                <td>
                                    <table>                                        
                                        <tr>
                                            <td class="TextoCelda">No. de Visitas: </td>
                                            <td>
                                                <dx:ASPxSpinEdit ID="speNO_VISITASpopup" runat="server" NumberType="Integer" Width="100px"   >                                                     
                                                </dx:ASPxSpinEdit>
                                            </td>                                            
                                        </tr>
                                    </table>
                                </td>                                
                            </tr>                          
                            <tr>
                                <td>
                                    <table>
                                        <tr>
                                            <td>
                                                <dx:ASPxButton ID="btnAceptarPopup" runat="server" Text="Aceptar" />
                                            </td>
                                            <td>
                                                <dx:ASPxButton ID="btnCancelarPopup" runat="server" Text="Cancelar" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>      
                            
                     </dx:PopupControlContentControl>
                 </ContentCollection>
                 <LoadingPanelImage Url="~/App_Themes/Office2010Blue/Web/Loading.gif">
                 </LoadingPanelImage>
                <HeaderStyle Font-Bold="True"></HeaderStyle>
   </dx:ASPxPopupControl>

