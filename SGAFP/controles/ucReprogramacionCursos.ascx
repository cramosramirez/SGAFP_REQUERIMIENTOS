<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucReprogramacionCursos.ascx.vb" Inherits="controles_ucReprogramacionCursos" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaACCION_FORMATIVA_REPROG" Src="~/controles/ucListaACCION_FORMATIVA_REPROG.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleACCION_FORMATIVA" Src="~/controles/ucVistaDetalleACCION_FORMATIVA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleACCION_FORMATIVA_REPROG" Src="~/controles/ucVistaDetalleACCION_FORMATIVA_REPROG.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucCriteriosAccionFormativaReprog" Src="~/controles/ucCriteriosAccionFormativaReprog.ascx" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<table id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <tbody>
	        <tr>
			   <td><uc1:ucBarraNavegacion ID="UcBarraNavegacion1" 
                        runat="server" Navegacion="False" PermitirAgregar="False" PermitirEditar="False"  
                        PermitirGuardar="False" PermitirNavegacion="False"
                        Visible="true" /></td>
            </tr>
        <tr>
	            <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">REPROGRAMACION DE CURSOS</asp:Label></td>
            </tr>
            <tr>
	            <td><asp:Image ID="Image2" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></td>
            </tr>
            <tr>
                <td><uc1:ucCriteriosAccionFormativaReprog ID="ucCriteriosAccionFormativaReprog1" runat="server"></uc1:ucCriteriosAccionFormativaReprog></td>
            </tr>		   
            <tr>	       
               <td><uc1:ucListaACCION_FORMATIVA_REPROG id="ucListaACCION_FORMATIVA_REPROG1" runat="server" 
                       VerCODIGO_ESTADO_AF="False" VerCOSTO_X_PARTICIPANTE="False" VerID_ESTADO_REPROG="False" 
                       VerID_EJERCICIO="False" VerID_OFERTA_FORMATIVA="False" 
                       VerID_PROVEEDOR_AF="False" VerID_SITIO_CAPACITACION="False" 
                       VerID_TEMA_CURSO="False" VerLASTUPDATE="False" 
                       VerNOMBRE_ACCION_FORMATIVA="True" VerNOTAS="False" VerMOTIVORECHAZO="False" VerMOTIVOREPROG="False"
                       VerNUMERO_PARTICIPANTES="False" VerPARTICIPANTES_INSCRITOS="True" 
                       VerUSERID="False" PermitirCambiarEstado="True" PermitirEliminar="True" VerColumnaReporte="true"></uc1:ucListaACCION_FORMATIVA_REPROG>
                       </td>
                <table>
                    <tr>
                        <td align="center" >                                               
                            <asp:Label ID="lblInfoCursoOriginal" runat="server" Text="Información original del Curso " 
                                Font-Bold="True" Font-Names="Arial"></asp:Label>                                               
                        </td>
                        <td align="center">   
                            <asp:Label ID="lblReprogramacionCurso" runat="server" Text="Solicitud de Reprogramación del Curso "
                                Font-Bold="True" Font-Names="Arial"></asp:Label>                   
                        </td>
                    </tr>
                    <tr>
                        <td style="vertical-align:top">                            
                            <uc1:ucVistaDetalleACCION_FORMATIVA ID="ucVistaDetalleACCION_FORMATIVA1" PermitirEditarProgramacion="false"  
                            runat="server" Visible="false" VerNOMBRE_ACCION_FORMATIVA="False" VerCODIGO_ESTADO_AF = "false" VerID_EJERCICIO="false"   
                            VerFECHA_INICIO_REAL="true" VerFECHA_FIN_REAL ="True"  VerFECHA_INICIO="false" VerFECHA_FIN="false"   
                            VerPARTICIPANTES_INSCRITOS="False" VerID_ACCION_FORMATIVA="False" ></uc1:ucVistaDetalleACCION_FORMATIVA>
                        </td>                            
                        <td style="vertical-align:top">
                            <uc1:ucVistaDetalleACCION_FORMATIVA_REPROG ID="ucVistaDetalleACCION_FORMATIVA_REPROG1" PermitirEditarReProgramacion = "false"   
                            runat="server" Visible="false" VerID_ESTADO_REPROG="false" VerAREA_FORMACION="false"    
                            VerFECHA_INICIO_REAL="true" VerFECHA_FIN_REAL ="True" VerCODIGO_ESTADO_AF = "false" VerID_EJERCICIO="false"    
                            VerPARTICIPANTES_INSCRITOS="False" VerID_ACCION_FORMATIVA="False" ></uc1:ucVistaDetalleACCION_FORMATIVA_REPROG>
                        </td>
                    </tr>
                </table>                       
               
            </tr>
    </tbody>
</table>

<ajaxToolkit:ModalPopupExtender runat="server" ID="mpObservacionEvaluacion" BehaviorID="mpObservacionEvaluacionBehavior"
    TargetControlID="hiddenTargetControlForMpObservacionEvaluacion" PopupControlID="pObservacionEvaluacion" CancelControlID="btnCancelar" 
    BackgroundCssClass="modalBackground" DropShadow="True" PopupDragHandleControlID="pObservacionEvaluacionDragHandle"
    RepositionMode="RepositionOnWindowScroll" X="10" Y="10" >
        </ajaxtoolkit:ModalPopupExtender>
<asp:Button runat="server" ID="hiddenTargetControlForMpObservacionEvaluacion" Style="display: none" />
<asp:Panel runat="server" CssClass="modalPopup" ID="pObservacionEvaluacion" Style="padding: 5px;
    background-color: #EAF4F9; overflow: hidden; font:8pt Verdana, Arial; width: 400px; height: 200px  ">
    <asp:Panel runat="Server" ID="pObservacionEvaluacionDragHandle" Style="cursor: move;
        background-color: #DDDDDD; border: solid 1px Gray; color: Black; text-align: center;">
        Ingreso de Comentario/Observacion por rechazo de Reprogramacion
    </asp:Panel>
    <div style="overflow: auto; height: 200px; width: 400px ">
        <table>
            <tr>
                <td class="style3">
                    <asp:Label ID="lblObservacion" runat="server" Text="Comentario/Observacion:"></asp:Label>
                </td>
            </tr>
            <tr>
                 <td>
                <asp:TextBox ID="txtObservacion" runat="server" Height="66px" ValidationGroup="Observaciones" Width="385px" 
                    TextMode="MultiLine"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtObservacion"
                    Display="Dynamic" ErrorMessage="*" ValidationGroup="Observaciones">Es requerida la observacion para poder rechazar la Reprogramación</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnRechazar" runat="server" Text="Rechazar" 
                        ValidationGroup="Observaciones" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
                </td>
            </tr>
        </table>
    </div>  
</asp:Panel>

