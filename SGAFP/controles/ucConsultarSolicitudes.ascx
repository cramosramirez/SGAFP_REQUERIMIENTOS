<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucConsultarSolicitudes.ascx.vb" Inherits="controles_ucConsultarSolicitudes" %>
<%@ Register src="ucBarraNavegacion.ascx" tagname="ucBarraNavegacion" tagprefix="uc1" %>
<%@ Register src="ucCriteriosSolicitudes.ascx" tagname="ucCriteriosSolicitudes" tagprefix="uc1" %>
<%@ Register Src="ucListaSOLICITUD_INSCRIPCION_AF.ascx" TagName="ucListaSOLICITUD_INSCRIPCION_AF" TagPrefix="uc1" %>
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
<uc1:ucBarraNavegacion ID="UcBarraNavegacion1" runat="server" PermitirAgregar="false"
    PermitirEditar="false" PermitirGuardar="false" PermitirNavegacion="false" Visible="true" />
<uc1:uccriteriossolicitudes ID="ucCriteriosSolicitudes1" runat="server" />
<uc1:ucListaSOLICITUD_INSCRIPCION_AF ID="ucListaSOLICITUD_INSCRIPCION_AF1" runat="server" PermitirEliminar="false" 
    NombreGridCliente="ucListaSOLICITUD_INSCRIPCION_AF1" VerID_SOLICITUD="true" VerFECHA_PRESENTACION="true"
    VerAPELLIDOS="true" VerNOMBRES="true" VerNOMBRE_ACCION_FORMATIVA="true" VerCODIGO_GRUPO="true" VerNOMBRE_SITIO="true" VerESTADO_SOLICITUD="true"   />   
    
<%--<ajaxToolkit:ModalPopupExtender runat="server" ID="mpObservacionAnulacion" BehaviorID="mpObservacionAnulacionBehavior"
    TargetControlID="hiddenTargetControlForMpObservacionAnulacion" PopupControlID="pObservacionAnulacion"
    BackgroundCssClass="modalBackground" DropShadow="True" PopupDragHandleControlID="pObservacionAnulacionDragHandle"
    RepositionMode="RepositionOnWindowScroll">
        </ajaxtoolkit:ModalPopupExtender>
<asp:Button runat="server" ID="hiddenTargetControlForMpObservacionAnulacion" Style="display: none" />
<asp:Panel runat="server" CssClass="modalPopup" ID="pObservacionAnulacion" Style="padding: 10px;
    background-color: #fef5c9; overflow: hidden;">
    <asp:Panel runat="Server" ID="pObservacionAnulacionDragHandle" Style="cursor: move;
        background-color: #DDDDDD; border: solid 1px Gray; color: Black; text-align: center;">
        Ingreso de Comentario/Observacion por Anulacion de Solicitud
    </asp:Panel>
    <div style="overflow: auto; height: 375px">
        <table class="style2">
            <tr>
                <td class="style3">
                    <asp:Label ID="lblIdSolicitud" runat="server" Text="" Visible="false"></asp:Label>
                </td>
            </tr>
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
                    Display="Dynamic" ErrorMessage="*" ValidationGroup="Observaciones">Es requerido la Observacion para poder Anular la Solicitud</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnAnular" runat="server" Text="Anular" 
                        ValidationGroup="Observaciones" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
                </td>
            </tr>
        </table>
    </div>
    <a id="hideMpObservacionAnulacionViaClientButton" href="#">Cerrar</a>
</asp:Panel>--%>
