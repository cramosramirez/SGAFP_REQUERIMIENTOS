<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCalendarizarGrupo.ascx.vb" Inherits="controles_ucCalendarizarGrupo" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaGRUPO_SELECCION" Src="~/controles/ucListaGRUPO_SELECCION.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleGRUPO_SELECCION" Src="~/controles/ucVistaDetalleGRUPO_SELECCION.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro" Src="~/controles/ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleCALENDARIZACION" Src="~/controles/ucVistaDetalleCALENDARIZACION.ascx" %>

<%@ Register Src="ucCriteriosAccionFormativa.ascx" TagName="ucCriteriosAccionFormativa" TagPrefix="uc1" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>


<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <tr>
			   <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
        </tr>
		   <tr>
		       <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" runat="server">CALENDARIZAR GRUPOS</asp:Label></td>
		   </tr>
        <tr>
            <td>
                <uc1:ucCriteriosAccionFormativa ID="ucCriteriosAccionFormativa1" runat="server" VerCentroFormacion="false" VerContratoLicitacion="true" VerCodigoGrupo="false" VerAreaFormacion="false" VerEjercicio="False" VerEstado="False" />
            </td>
        </tr>		
	    <tr>
            <td><uc1:ucListaGRUPO_SELECCION id="ucListaGRUPO_SELECCION1" PermitirCalendarizarGrupo="true" VerInformeAspirantes="false" PermitirFilaDeFiltro="false" PermitirEditar="False" runat="server"
                VerHORAS_TOTALES="true" VerHORAS_CALENDARIZADAS="true" VerULT_PERIODO="true"></uc1:ucListaGRUPO_SELECCION>                
            </td>
        </tr>
        <tr>
            <td align="center">
            <uc1:ucVistaDetalleCALENDARIZACION id="ucVistaDetalleCALENDARIZACION1" runat="server"></uc1:ucVistaDetalleCALENDARIZACION>
            </td>
        </tr>
    </TBODY>
</TABLE>

 <dx:ASPxPopupControl ID="popupError" Modal="true" runat="server"  ClientInstanceName="popupError" 
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" PopupElementID="BuscarNombresbtn" 
        AllowResize="False" DragElement="Header" HeaderStyle-Font-Bold="true" HeaderText="Alerta" Width="300px"    
        AllowDragging="True" ShowShadow="true"
        CloseAction="CloseButton">  
                 <ContentCollection>
                     <dx:PopupControlContentControl ID="PopupControlContentControl2" runat="server" >          
                        <table width="100%">
                            <tr>
                                <td align="center">                                   
                                    <asp:Literal ID="Literal1" runat="server" Text="" />
                                </td>
                            </tr>
                            <tr>
                                <td><hr /></td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <dx:ASPxButton ID="btnCerrar" runat="server" Text="Cerrar" Width="80px" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css" CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"  > 
                                        <ClientSideEvents Click="function(s,e){popupError.Hide()}" />
                                    </dx:ASPxButton>
                                </td>
                            </tr>
                        </table>                                  
                     </dx:PopupControlContentControl>
                 </ContentCollection>

                <HeaderStyle Font-Bold="True"></HeaderStyle>
   </dx:ASPxPopupControl>


