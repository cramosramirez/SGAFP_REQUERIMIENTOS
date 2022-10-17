<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucEvaluarSolicitudes.ascx.vb" Inherits="controles_ucEvaluarSolicitudes" %>
<%@ Register src="ucCriteriosSolicitudes.ascx" tagname="ucCriteriosSolicitudes" tagprefix="uc1" %>
<%@ Register src="ucBarraNavegacion.ascx" tagname="ucBarraNavegacion" tagprefix="uc2" %>
<%@ Register src="ucListaSOLICITUD_INSCRIPCION_AF.ascx" tagname="ucListaSOLICITUD_INSCRIPCION_AF" tagprefix="uc3" %>
<%@ Register src="ucVistaDetalleSOLICITUD_INSCRIPCION_AF.ascx" tagname="ucVistaDetalleSOLICITUD_INSCRIPCION_AF" tagprefix="uc4" %>
<%@ Register src="ucListaACCION_FORMATIVA.ascx" tagname="ucListaACCION_FORMATIVA" tagprefix="uc5" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<style type="text/css">
    .style2
    {
        width: 100%;
    }
    .style3
    {
        width: 167px;
    }
</style>
<uc2:ucBarraNavegacion ID="ucBarraNavegacion1" runat="server" 
    Navegacion="False" PermitirAgregar="False" PermitirEditar="False" 
    PermitirGuardar="False" PermitirNavegacion="False" />
<uc1:ucCriteriosSolicitudes ID="ucCriteriosSolicitudes1" runat="server" VerEstadoSolicitud="False" />
<asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" 
    BackColor="#B5C7DE" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em"
    ForeColor="#284E98" StaticSubMenuIndent="10px">
    <StaticSelectedStyle CssClass="TabSeleccionado" />
    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
    <DynamicMenuStyle BackColor="#B5C7DE" />
    <DynamicSelectedStyle BackColor="#507CD1" />
    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
    <Items>
        <asp:MenuItem Text="Lista de Solicitudes" Value="0" Selected="true"></asp:MenuItem>
        <asp:MenuItem Text="Detalle Solicitud" Value="1"></asp:MenuItem>
        <asp:MenuItem Text="Cursos Recibidos" Value="2"></asp:MenuItem>
        <asp:MenuItem Text="Evaluacion" Value="3"></asp:MenuItem>
    </Items>
</asp:Menu>
<asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
    <asp:View ID="View1" runat="server">
        <table cellpadding="0" cellspacing="0" width="90%">
            <tr valign="top">
                <td class="TabArea">
                    <uc3:ucListaSOLICITUD_INSCRIPCION_AF ID="ucListaSOLICITUD_INSCRIPCION_AF1" 
                        runat="server" PermitirEditar="False" PermitirEliminar="False" 
                        PermitirPaginacion="True" PermitirSeleccionar="True" 
                        VerBENEF_CAMB_EMP_X_CURSO="False" VerBENEF_OBT_EMPLEO="False" 
                        VerBENEF_OBT_ING_EXTRA="False" VerBENEF_OTRO="False" 
                        VerBENEF_PROM_EMP_ACT="False" VerBENEF_TRAB_CTA_PROPIA="False" VerCARGO="False" VerCIUO="False" VerCODIGO_DEPARTAMENTO="False" VerCODIGO_MUNICIPIO="False" VerCODIGO_REGION="False" VerDEPARTAMENTO_NAC="False" VerDIRECCION="False" VerDIRECCION_FAMILIAR="False" VerDUI="False" VerEDAD="False" VerEMAIL="False" VerESTADO_CIVIL="False" VerEXPFOR_CAMBIAR_EMPLEO="False" VerEXPFOR_INGRESOS_EXTRAS="False" VerEXPFOR_OBTENER_EMPLEO="False" VerEXPFOR_OTRO="False" VerEXPFOR_PROMOCION_EMPLEO="False" VerEXPFOR_TRABAJAR_CTA_PROPIA="False" VerFAX="False" VerFECHA_NACIMIENTO="False" VerGENERO="False" VerID_ESTADO_SOLICITUD="False" VerID_PARTICIPANTE="False" VerID_PROVEEDOR_AF="False" VerID_TIPO_SOLICITUD="False" VerINGRESO_MENSUAL_FAMILIAR="False" VerINGRESO_MENSUAL_INDIVIDUAL="False" VerISSS="False" VerLUGAR_NACIMIENTO="False" VerLUGAR_PRESENTACION="False" VerMIEMBROS_GRUPO_FAMILIAR="False" VerMOVIL="False" VerMUNICIPIO_NAC="False" VerNIT="False" VerNIT_EMPRESA="False" VerNIVEL_ACADEMICO="False" VerNOMBRE_EMPRESA="False" VerNOMBRE_FAMILIAR="False" VerNUMERO_DOCUMENTO="False" VerNUMERO_PATRONAL="False" VerOBTUVO_BENEFICIOS_CURSO="False" VerOCUACT_DESOCUPADO="False" VerOCUACT_ESTUDIA="False" VerOCUACT_OFICIO_HOGAR="False" VerOCUACT_TRABAJA="False" VerPARENTESCO="False" VerPROFESION_OFICIO="False" VerRAZON_NO_BENEFICIO="False" VerRECIBIO_CURSO_ANTERIOR="False" VerRTC_INDEPENDIENTE="False" VerRTC_NO_INDEPENDIENTE="False" VerRTC_NO_OCUPACION_EMPRESA="False" VerRTC_NO_PROPIA_EMPRESA="False" VerRTC_NO_TRABAJO_EVENTUAL="False" VerRTC_NO_TRABAJO_MEDIO_TIEMPO="False" VerRTC_OCUPACION_EMPRESA="False" VerRTC_PROPIA_EMPRESA="False" VerRTC_TRABAJO_EVENTUAL="False" VerRTC_TRABAJO_MEDIO_TIEMPO="False" VerSUGERENCIAS="False" VerTELEFONO="False" VerTELEFONO_FAMILIAR="False" VerTIEMPO_DEJO_ESTUDIAR="False" VerTIPTRA_EMPLEADO_EMPRESA="False" VerTIPTRA_EMPRESA_PROPIA="False" VerTIPTRA_EVENTUAL="False" VerTIPTRA_INDEPENDIENTE="False" VerTIPTRA_MEDIO_TIEMPO="False" VerTITULO_CERTIFICADO_OBTENIDO="False" VerTRABAJA_ACTUALMENTE="False" VerTRABAJO_ANTERIOR="False" VerZONA="False" />
                </td>
            </tr>
        </table>
    </asp:View>
    <asp:View ID="View2" runat="server">
        <table cellpadding="0" cellspacing="0" width="90%">
            <tr valign="top">
                <td class="TabArea">
                    <uc4:ucVistaDetalleSOLICITUD_INSCRIPCION_AF ID="ucVistaDetalleSOLICITUD_INSCRIPCION_AF1" 
                        runat="server" />
                </td>
            </tr>
        </table>
    </asp:View>
    <asp:View ID="View3" runat="server">
        <table cellpadding="0" cellspacing="0" width="90%">
            <tr valign="top">
                <td class="TabArea">
                    <table>
                        <tr>
                            <td>
                                Cursos Recibidos
                            </td>
                        </tr>
                        <tr>
                            <td valign="top">
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
                                    <Columns>
                                        <asp:BoundField DataField="NOMBRE_PROVEEDOR" HeaderText="PROVEEDOR" SortExpression="NOMBRE_PROVEEDOR" />
                                        <asp:BoundField DataField="NOMBRE_SITIO" HeaderText="CENTRO" SortExpression="NOMBRE_SITIO" />
                                        <asp:BoundField DataField="NOMBRE_ACCION_FORMATIVA" HeaderText="NOMBRE CURSO" SortExpression="NOMBRE_ACCION_FORMATIVA" />
                                        <asp:BoundField DataField="ID_EJERCICIO" HeaderText="EJERCICIO" SortExpression="ID_EJERCICIO" />
                                    </Columns>
                                </asp:GridView>
                                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}"
                                    SelectMethod="GetCursosPorIDParticipante" TypeName="SGAFP.DL.DS_DLTableAdapters.CursosRecibidosParticipanteTableAdapter">
                                    <SelectParameters>
                                        <asp:Parameter DefaultValue="0" Name="ID_PARTICIPANTE" Type="Decimal" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </asp:View>
    <asp:View ID="View4" runat="server">
        <table cellpadding="0" cellspacing="0" width="90%">
            <tr valign="top">
                <td class="TabArea">
                    <table>
                        <tr>
                            <td colspan="2">
                                Horarios Curso
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <uc5:ucListaACCION_FORMATIVA ID="ucListaACCION_FORMATIVA1" runat="server" 
                                    PermitirEditar="False" PermitirEliminar="False" PermitirPaginacion="false" PermitirSeleccionar="True" 
                                    VerCODIGO_ESTADO_AF="False" VerCOSTO_X_PARTICIPANTE="False" 
                                    VerDURACION_HORAS="False" VerID_ACCION_FORMATIVA="False" 
                                    VerID_EJERCICIO="False" VerID_OFERTA_FORMATIVA="False"
                                    VerID_PROVEEDOR_AF="false" VerID_SITIO_CAPACITACION="false"
                                     VerID_TEMA_CURSO="false" VerLASTUPDATE="false" VerUSERID="false" />
                            </td>
                            <td valign="top">
                                <asp:Button ID="Button_Aprobar" runat="server" Text="Aprobar"
                                    Width="87px" Visible="False" />
                                <br />
                                <br />
                                <asp:Button ID="Button_Rechazar" runat="server" Text="Rechazar"
                                    Width="87px" Visible="False" />
                                <br />
                                <br />
                                <asp:Button ID="Button_EnEspera" runat="server" Text="En Espera"
                                    Width="87px" Visible="False" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </asp:View>
</asp:MultiView>
<asp:Label ID="Label_id_proveedor_af" runat="server" Visible="False" Text="-1"></asp:Label>
<asp:Label ID="Label_ID_TEMA_CURSO" runat="server" Text="-1" Visible="False"></asp:Label>
<asp:Label ID="Label_ID_ACCION_FORMATIVA" runat="server" Text="-1" Visible="False"></asp:Label>

<ajaxToolkit:ModalPopupExtender runat="server" ID="mpObservacionEvaluacion" BehaviorID="mpObservacionEvaluacionBehavior"
    TargetControlID="hiddenTargetControlForMpObservacionEvaluacion" PopupControlID="pObservacionEvaluacion"
    BackgroundCssClass="modalBackground" DropShadow="True" PopupDragHandleControlID="pObservacionEvaluacionDragHandle"
    RepositionMode="RepositionOnWindowScroll">
        </ajaxtoolkit:modalpopupextender>
<asp:Button runat="server" ID="hiddenTargetControlForMpObservacionEvaluacion" Style="display: none" />
<asp:Panel runat="server" CssClass="modalPopup" ID="pObservacionEvaluacion" Style="padding: 10px;
    background-color: #fef5c9; overflow: hidden;">
    <asp:Panel runat="Server" ID="pObservacionEvaluacionDragHandle" Style="cursor: move;
        background-color: #DDDDDD; border: solid 1px Gray; color: Black; text-align: center;">
        Ingreso de Comentario/Observacion por Rechazo de Solicitud
    </asp:Panel>
    <div style="overflow: auto; height: 375px">
        <table class="style2">
            <tr>
                <td class="style3">
                    <asp:Label ID="lblObservacion" runat="server" Text="Comentario/Observacion:"></asp:Label>
                </td>
            </tr>
            <tr>
                 <td>
                <asp:TextBox ID="txtObservacion" runat="server" Height="66px" ValidationGroup="Observaciones"
                    Width="400px" TextMode="MultiLine"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtObservacion"
                    Display="Dynamic" ErrorMessage="*" ValidationGroup="Observaciones">Es requerido la Observacion para poder Rechazar la Solicitud</asp:RequiredFieldValidator></td>
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
    <a id="hideMpObservacionEvaluacionViaClientButton" href="#">Cerrar</a>
</asp:Panel>
