<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantGRUPO_SELECCION.ascx.vb" Inherits="controles_ucMantGRUPO_SELECCION" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaGRUPO_SELECCION" Src="~/controles/ucListaGRUPO_SELECCION.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleGRUPO_SELECCION" Src="~/controles/ucVistaDetalleGRUPO_SELECCION.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro" Src="~/controles/ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro.ascx" %>
<%@ Register Src="ucCriteriosAccionFormativa.ascx" TagName="ucCriteriosAccionFormativa" TagPrefix="uc1" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>


<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" runat="server">GRUPOS POR CARRERA</asp:Label></TD>
		   </TR>
        <tr>
            <td>
                <uc1:ucCriteriosAccionFormativa ID="ucCriteriosAccionFormativa1" runat="server" VerCentroFormacion="false" VerContratoLicitacion="true" VerCodigoGrupo="false" VerAreaFormacion="false" VerEjercicio="False" VerEstado="False" />
            </td>
        </tr>		
	       <TR>
            <TD><uc1:ucListaGRUPO_SELECCION id="ucListaGRUPO_SELECCION1" PermitirRegistrarAspirante="true" VerGenerarInforme="true" VerAspirantesSeleccionados="true" VerReclutamientoExtraordinario="true" PermitirFilaDeFiltro="false" PermitirEditar="True" runat="server"></uc1:ucListaGRUPO_SELECCION>
                <uc1:ucVistaDetalleGRUPO_SELECCION ID="ucVistaDetalleGRUPO_SELECCION1" runat="server" Visible="false" ></uc1:ucVistaDetalleGRUPO_SELECCION>
                <uc1:ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro ID="ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro1" runat="server" Visible="false" ></uc1:ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro>
            </TD>
        </TR>
    </TBODY>
</TABLE>

 <dx:ASPxPopupControl ID="popupError" Modal="true" runat="server" 
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
                        </table>         
                     </dx:PopupControlContentControl>
                 </ContentCollection>

                <HeaderStyle Font-Bold="True"></HeaderStyle>
   </dx:ASPxPopupControl>


