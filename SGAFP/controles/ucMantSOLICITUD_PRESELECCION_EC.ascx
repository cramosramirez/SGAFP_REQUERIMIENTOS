<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantSOLICITUD_PRESELECCION_EC.ascx.vb" Inherits="controles_ucMantSOLICITUD_PRESELECCION_EC" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaSOLICITUD_PRESELECCION_EC" Src="~/controles/ucListaSOLICITUD_PRESELECCION_EC.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro" Src="~/controles/ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaGRUPO_SELECCION" Src="~/controles/ucListaGRUPO_SELECCION.ascx" %>
<%@ Register assembly="SGAFP_WebUC" namespace="SGAFP.WebUC" tagprefix="cc1" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

<style type="text/css">
        .TextoInfo
        {
            font-family:Verdana, Arial;
            font-size: 8pt;
        }
        .TextoCelda
        {
            font-family:Verdana, Arial;
            font-size: 8pt;
        }        
        .TextoInfoAdd
        {
            font-family:Verdana, Arial;
            font-size: 8pt;
            color:blue;               
        }    
    </style>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" runat="server">ASPIRANTES REGISTRADOS</asp:Label></TD>
		   </TR>
        <tr id="trCriterios" runat="server">
            <td>
                <table>
                     <tr id="trProveedor" runat="server">
                        <td class="TextoCelda" style="width:125px" >
                            PROVEEDOR:     
                        </td>
                        <th colspan="3"  style="font-size: small;" class="TextoInfo">
                            <cc1:ddlPROVEEDOR_AF ID="ddlPROVEEDOR_AF1" runat="server" AutoPostBack="True" Width="400px" class="TextoInfo">
                            </cc1:ddlPROVEEDOR_AF>
                        </th>                          
                    </tr>
                    <tr id="trContratoLici" runat="server">
                        <td class="TextoCelda">
                            CONTRATO:                
                        </td> 
                        <td class="TextoCelda">
                            <asp:TextBox ID="txtNUM_CONTRATO" runat="server" Columns="8" MaxLength="40"
                                class="TextoInfo" Width="150px" CssClass="NormalUPPER"></asp:TextBox>
                        </td> 
                        <td class="TextoCelda" style="width:125px" >
                            No. GRUPO:     
                        </td>  
                        <td class="TextoCelda">
                            <asp:TextBox ID="txtNO_GRUPO" runat="server" Columns="8" MaxLength="40"
                                class="TextoInfo" Width="100%" CssClass="NormalUPPER"></asp:TextBox>
                        </td>      
                    </tr>
                </table>
            </td>
        </tr>
	       <TR>
            <TD><uc1:ucListaSOLICITUD_PRESELECCION_EC id="ucListaSOLICITUD_PRESELECCION_EC1" runat="server" VerAutorizar="true" PermitirFilaDeFiltro="false" MostrarCheckVariaSeleccion="true" ></uc1:ucListaSOLICITUD_PRESELECCION_EC>
                <uc1:ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro ID="ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro1" runat="server" Visible="false" ></uc1:ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro></TD>
        </TR>
    </TBODY>
</TABLE>

 <dx:ASPxPopupControl ID="popupError" Modal="True" runat="server"  
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" PopupElementID="BuscarNombresbtn" HeaderStyle-Font-Bold="true" HeaderText="Alerta" Width="300px"    
        AllowDragging="True" ClientInstanceName="popupError"
        CloseAction="CloseButton" CssFilePath="~/App_Themes/Office2010Blue/{0}/styles.css" CssPostfix="Office2010Blue" EnableHotTrack="False" SpriteCssFilePath="~/App_Themes/Office2010Blue/{0}/sprite.css">  
                 <LoadingPanelStyle ImageSpacing="5px">
                 </LoadingPanelStyle>
                 <ContentCollection>
                     <dx:PopupControlContentControl ID="PopupControlContentControl2" runat="server" >          
                        <table width="100%">
                            <tr>
                                <td align="center">                                   
                                    <asp:Literal ID="Literal1" runat="server" Text="" />
                                </td>                                
                            </tr>                           
                            <tr>
                                <td align="center">
                                    <br />
                                    <dx:ASPxButton ID="btnCerrarMsj" runat="server" Text="Cerrar" > 
                                        <ClientSideEvents Click="function(s,e){popupError.Hide()}" />
                                     </dx:ASPxButton>
                                </td>
                            </tr>
                        </table>         
                     </dx:PopupControlContentControl>
                 </ContentCollection>
                 <LoadingPanelImage Url="~/App_Themes/Office2010Blue/Web/Loading.gif">
                 </LoadingPanelImage>
                <HeaderStyle Font-Bold="True"></HeaderStyle>
   </dx:ASPxPopupControl>

 <dx:ASPxPopupControl ID="popupAsignacion" Modal="True" runat="server" 
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" PopupElementID="BuscarNombresbtn" HeaderStyle-Font-Bold="true" HeaderText="Elegir grupo a asignar" Width="1000px"    
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
                                            <td class="TextoCelda">Contrato/Licitacion: </td>
                                            <td>
                                                <asp:TextBox ID="txtNUM_CONTRATOpopup" runat="server" class="TextoInfo" CssClass="NormalUPPER" MaxLength="40" Width="120px"></asp:TextBox>
                                            </td>
                                            <td>
                                                <dx:ASPxButton ID="btnBuscarPopup" runat="server" Text="Buscar" />     
                                            </td>
                                            <td class="TextoInfoAdd">Busque el grupo por el número de contrato/licitación, luego seleccionelo y haga clic en Aceptar </td>
                                        </tr>
                                    </table>
                                </td>                                
                            </tr>
                            <tr>
                                <td align="center">                                   
                                    <uc1:ucListaGRUPO_SELECCION id="ucListaGRUPO_SELECCION1" PermitirFilaDeFiltro="false" PermitirFiltroEnEncabezado="false" MostrarCheckUnaSeleccion="True" VerPROVEEDOR="false" PermitirRegistrarAspirante="False" PermitirEditar="false" PermitirEditarInline="false" runat="server"></uc1:ucListaGRUPO_SELECCION>
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
