<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucOrdenesCompraPATI.ascx.vb" Inherits="controles_ucOrdenesCompra" %>
<%@ Register TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" TagPrefix="uc1" %>
<%@ Register TagName="ucCriteriosOrdenCompraPATI" Src="~/controles/ucCriteriosOrdenCompraPATI.ascx" TagPrefix="uc1" %>

<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxLoadingPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>


<script language="javascript" type="text/javascript">
    var _visibleIndexEncabezado;
    var _visibleIndexDetalle;
    
    function CargarOrdenes() {
        var ID_PROGRAMA_FORMACION = '-1';
        var ID_PROVEEDOR_AF = '-1';
        var ORDEN_COMPRA = '';

        if (cbxProgramaFormacion.GetValue() != null) { ID_PROGRAMA_FORMACION = cbxProgramaFormacion.GetValue(); }
        if (cbxProveedor.GetValue() != null) { ID_PROVEEDOR_AF = cbxProveedor.GetValue(); }
        if (txtResolucion.GetValue() != null) { ORDEN_COMPRA = txtResolucion.GetValue(); }

        MostrarPanelModal(true, 'Cargando Orden(es) de Compra...');
        cOrdenCompra.PerformCallback('CargarOrdenes;' +
                                        ID_PROGRAMA_FORMACION + ';' + 
                                        ID_PROVEEDOR_AF + ';' +
                                        ORDEN_COMPRA);
    }

    function MostrarPanelModal(mostrar, mensaje) {
        if (mostrar) {
            if (mensaje == '') {
                LoadingPanel.SetText('Cargando...');
            }
            else {
                LoadingPanel.SetText(mensaje);
            }
            LoadingPanel.Show();

        }
        else {
            LoadingPanel.Hide();
        }
    }

    function MostrarPopupDevolucion(id) {
        _visibleIndexDetalle = id;
        popupDevolucion.SetSize(400, 0);
        popupDevolucion.Show();
        popupDevolucion.UpdatePosition();
    }       

</script>
<dx:ASPxCallbackPanel runat="server" ID="cOrdenCompra" ClientInstanceName="cOrdenCompra" ShowLoadingPanel="false"> 
<ClientSideEvents EndCallback="function(s,e){
                                            MostrarPanelModal(false,'');                                          
                                            }" /> 
    <PanelCollection>        
        <dx:PanelContent ID="PanelContent1" runat="server">   
            <uc1:ucBarraNavegacion ID="ucBarraNavegacion1" HabilitarCallBacks="true" runat="server" />
            <uc1:ucCriteriosOrdenCompraPATI ID="ucCriteriosOrdenCompraPATI1" runat="server" 
                VerPrograma="true" VerProveedor="true" VerCentroFormacion="false" VerEjercicio="false" VerAreaFormacion="false" VerCodigoGrupo="false"
                VerBotonMostrar="false"  />
            <dx:ASPxGridView ID="dgvOC" ClientInstanceName="dgvOC" runat="server" KeyFieldName="RESOLUCION" Width="100%" DataSourceID="odsListaPorCriterios">
                    <ClientSideEvents DetailRowExpanding="function(s,e){_visibleIndexEncabezado = e.visibleIndex;}" />
                <Columns>        
                    <dx:GridViewDataColumn FieldName="RESOLUCION" Caption="Orden Compra" VisibleIndex="0" >
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                    </dx:GridViewDataColumn>
                    <dx:GridViewDataColumn FieldName="TDR" Caption="Término de Referencia" VisibleIndex="1" >
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                    </dx:GridViewDataColumn>
                    <dx:GridViewDataColumn FieldName="PROGRAMA" Caption="Programa" UnboundType="String" VisibleIndex="1" >
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                    </dx:GridViewDataColumn>
                    <dx:GridViewDataColumn FieldName="NOMBRE_PROVEEDOR" Caption="Proveedor" VisibleIndex="2" >
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                    </dx:GridViewDataColumn>
                    <dx:GridViewDataTextColumn FieldName="HORARIO" Caption="Horario" UnboundType="String" VisibleIndex="3" CellStyle-ForeColor="Blue" >
<CellStyle ForeColor="Blue"></CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="ADJUDICADO" Caption="Total Adjudicado($)" UnboundType="Decimal"  VisibleIndex="4" CellStyle-ForeColor="Blue" >        
                        <PropertiesTextEdit DisplayFormatString="#,##0.00" />
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<CellStyle HorizontalAlign="Center"></CellStyle>
                    </dx:GridViewDataTextColumn>
                </Columns>
                <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
                    EmptyDataRow="No existen registros para mostrar"                
                    CommandCancel="Cerrar" CommandUpdate="Aceptar" />
                <SettingsPager>
                    <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" Text="Pag. {0} de {1} ({2} registros)" />
                </SettingsPager>  
                <SettingsDetail AllowOnlyOneMasterRowExpanded="true" /> 
                <Templates>
                    <DetailRow>       
                        <table style="font-family:Verdana;font-size:x-small;" >
                            <tr>
                                <td>Adjudicado:</td>
                                <td><b><%#Format(Eval("MONTO_ADJUDICADO"), "#,##0.00")%></b></td>
                            </tr>
                            <tr>                                
                                <td>Facturado:</td>
                                <td><b><%#Format(Eval("FACTURADO"), "#,##0.00")%></b></td>
                            </tr>
                            <tr>
                                <td>Saldo:</td>
                                <td><b><%#Format(Eval("MONTO_ADJUDICADO") - Eval("FACTURADO"), "#,##0.00")%></b></td>
                            </tr>
                        </table>    
                        <dx:ASPxGridView ID="dgvOC_AccionesFormativas" runat="server" DataSourceID="odsListaInformeEjecucionPorResolucion" KeyFieldName="ID_ACCION_FORMATIVA"
                            Width="100%" OnBeforePerformDataSelect="detailGrid_DataSelect" OnCustomUnboundColumnData="detailGrid_UnboundColumn"   
                             OnCustomButtonInitialize="detailGrid_CustomButtonInitialize" OnCustomButtonCallback="detailGrid_CustomButtonCallback" >                
                             <ClientSideEvents EndCallback="function(s,e){if(s.cpResultCallback != undefined && s.cpResultCallback == 'CorreoEnviado'){AsignarMensaje('El Proveedor ha sido Notificado que Envie la Factura');}}"
                                               CustomButtonClick="function(s,e){
                                                        if (e.buttonID =='btnDevolverInforme'){
                                                            memMotivo.SetValue('');
                                                            MostrarPopupDevolucion(e.visibleIndex.toString());                                                    
                                                            return;
                                                        }
                                                        e.processOnServer = true;
                                                      }" 
                              />                             
                            <Columns>
                                <dx:GridViewDataTextColumn FieldName="CORRELATIVO" Caption="N°" UnboundType="String" VisibleIndex="1" />
                                <dx:GridViewCommandColumn ButtonType="Image" Caption=" " Width="30px" CellStyle-HorizontalAlign="Center" VisibleIndex="2" >
                                    <CustomButtons>                                        
                                        <dx:GridViewCommandColumnCustomButton ID="btnEnviarSolicitarFactura" Text="Enviar Solicitud de Factura al Proveedor" Image-Url="../imagenes/correo_proveedor.gif"/> 
                                        <dx:GridViewCommandColumnCustomButton ID="btnReEnviarSolicitarFactura" Text="Reenviar Solicitud de Factura al Proveedor" Image-Url="../imagenes/reenviar_correo.gif"/> 
                                    </CustomButtons> 
                                </dx:GridViewCommandColumn>                                                                   
                                <dx:GridViewCommandColumn ButtonType="Image" Caption=" " Width="30px" CellStyle-HorizontalAlign="Center" VisibleIndex="2" >
                                    <CustomButtons>                                        
                                        <dx:GridViewCommandColumnCustomButton ID="btnDevolverInforme" Text="Devolver Informe a la GFI" Image-Url="../imagenes/rechazar.png"/>                                         
                                    </CustomButtons> 
                                </dx:GridViewCommandColumn>    
                                <dx:GridViewDataColumn FieldName="MUNICIPIO" Caption="Municipio" VisibleIndex="3" />
                                <dx:GridViewDataColumn FieldName="AUP" HeaderStyle-HorizontalAlign="Center" Caption="AUP" UnboundType="String" VisibleIndex="3" />
                                <dx:GridViewDataColumn FieldName="NOMBRE_ACCION_FORMATIVA" Caption="Curso" VisibleIndex="4" />
                                <dx:GridViewDataColumn FieldName="CODIGO_GRUPO" Caption="Codigo Grupo" VisibleIndex="5" />
                                <dx:GridViewDataColumn FieldName="FECHA_INICIAL" Caption="Fecha Inicio" VisibleIndex="6" />
                                <dx:GridViewDataColumn FieldName="FECHA_FINAL" Caption="Fecha Finalización" VisibleIndex="7" />
                                <dx:GridViewDataColumn FieldName="HORARIO" Caption="Horario" VisibleIndex="8" CellStyle-Font-Size="XX-Small"  />                                                                 
                                <dx:GridViewDataColumn FieldName="PARTICIPANTES_FINALES" Caption="Activos" VisibleIndex="9" CellStyle-HorizontalAlign="Center" />
                                <dx:GridViewDataTextColumn FieldName="COSTO_X_PARTICIPANTE" Caption="Costo Part.($)" Visible="false" VisibleIndex="10" >
                                    <PropertiesTextEdit DisplayFormatString="#,##0.00" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="COSTO_GRUPO" UnboundType="Decimal" Caption="Adjudicado($)" VisibleIndex="11" CellStyle-ForeColor="Blue" >
                                    <PropertiesTextEdit DisplayFormatString="#,##0.00" />
                                </dx:GridViewDataTextColumn>  
                                <dx:GridViewDataTextColumn FieldName="MONTO_FACTURA" Caption="Ejecutado($)" VisibleIndex="12" HeaderStyle-HorizontalAlign="Right" >
                                    <PropertiesTextEdit DisplayFormatString="#,##0.00" />
                                </dx:GridViewDataTextColumn>    
                                <dx:GridViewDataTextColumn FieldName="ESTADO" Caption="Estado" UnboundType="String" VisibleIndex="12" CellStyle-Font-Bold="True"  CellStyle-Font-Size="XX-Small" >
                                    <CellStyle HorizontalAlign="Center"></CellStyle>
                                </dx:GridViewDataTextColumn>                                                             
                                <dx:GridViewDataTextColumn FieldName="NUM_FACTURA" Caption="N° Factura" UnboundType="String" VisibleIndex="13" >
                                    <CellStyle HorizontalAlign="Center"></CellStyle>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="NUM_QUEDAN" Caption="N° Quedan" UnboundType="String" VisibleIndex="14" >
                                    <CellStyle HorizontalAlign="Center"></CellStyle>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="NUM_CHEQUE" Caption="N° Cheque" UnboundType="String" VisibleIndex="15" >                                                                    
                                    <CellStyle HorizontalAlign="Center"></CellStyle>
                                </dx:GridViewDataTextColumn>
                            </Columns>   
                             <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
                                EmptyDataRow="No existen registros para mostrar"                
                                CommandCancel="Cerrar" CommandUpdate="Aceptar" />
                            <SettingsPager>
                                <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" Text="Pag. {0} de {1} ({2} registros)" />
                            </SettingsPager>              
                            <Settings ShowFooter="True" />  
                            <TotalSummary>                    
                                <dx:ASPxSummaryItem FieldName="MONTO_FACTURA" SummaryType="Sum" DisplayFormat="Ejecutado: #,##0.00" />
                            </TotalSummary>                              
                        </dx:ASPxGridView>
                    </DetailRow>
                </Templates>
                <SettingsDetail ShowDetailRow="true" />
            </dx:ASPxGridView>
            
            <dx:ASPxPopupControl ID="popupDevolucion" Modal="true" runat="server" 
                    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" PopupElementID="BuscarNombresbtn" 
                    AllowResize="False" DragElement="Header" HeaderStyle-Font-Bold="true" HeaderText="Mensaje"    
                    AllowDragging="True" ClientInstanceName="popupDevolucion" ShowShadow="true" EnableClientSideAPI="true"  
                    CloseAction="CloseButton">  
                 <ContentCollection>
                     <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server" >          
                        <table>               
                            <tr>
                                <td>
                                    <dx:ASPxLabel ID="lblMensajePopup" Text="Ingrese el Motivo para Devolver el Informe"  ClientInstanceName="lblMensajePopup" runat="server" Font-Names="Verdana,Arial,Tahoma" Font-Size="XX-Small" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <dx:ASPxMemo AutoResizeWithContainer="true" CssClass="textUpper" ID="memMotivo"  ClientInstanceName="memMotivo" runat="server" Height="71px" Width="400px"  />                          
                                </td>
                            </tr>
                            <tr>
                                <td align="center" >
                                    <table width="50%">
                                        <tr align="center" >
                                            <td>
                                                <dx:ASPxButton ID="btnAceptarAnulacion" ClientInstanceName="btnAceptarAnulacion" 
                                                    AutoPostBack="false" CausesValidation="True" Text="Aceptar" runat="server" >                                                
                                                <ClientSideEvents Click="function(s,e){
                                                                                if(memMotivo.GetValue() != '' && memMotivo.GetValue() != null){                                                                                      
                                                                                    popupDevolucion.Hide();                                                                                                                                                                                                                                                          
                                                                                    cOrdenCompra.PerformCallback('DevolverInforme;' + _visibleIndexEncabezado + ';' + _visibleIndexDetalle + ';' + memMotivo.GetValue());                                                                                                                                                                     
                                                                                } 
                                                                                else{
                                                                                    AsignarMensaje('El Motivo es requerido para Devolver el Informe');
                                                                                }                                                                                                                                               
                                                                            }" 
                                                />
                                                </dx:ASPxButton>
                                            </td>
                                            <td>
                                                <dx:ASPxButton ID="btnCancelarAnulacion" ClientInstanceName="btnCancelarAnulacion" 
                                                    AutoPostBack="false" CausesValidation="False" Text="Cancelar" runat="server" >                                                
                                                <ClientSideEvents Click="function(s,e){
                                                                                 popupDevolucion.Hide();                                                                                                                           
                                                                            }" 
                                                />
                                            </dx:ASPxButton>
                                            </td>
                                        </tr>                                        
                                    </table>
                               </td>
                             </tr> 
                        </table>             
                     </dx:PopupControlContentControl>
                 </ContentCollection>

                <HeaderStyle Font-Bold="True"></HeaderStyle>
            </dx:ASPxPopupControl> 
            
            <dx:ASPxHiddenField runat="server" ID="hf" /> 
        </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>


<asp:ObjectDataSource ID="odsListaPorCriterios" runat="server" SelectMethod="ObtenerDataSetPorCriterios"
    TypeName="SGAFP.BL.cTERMINO_REFERENCIA_AF">
    <SelectParameters>
        <asp:Parameter Name="ID_PROGRAMA_FORMACION" Type="Decimal" />    
        <asp:Parameter DefaultValue="0"  Name="ID_PROVEEDOR_AF" Type="Decimal" />    
        <asp:Parameter Name="RESOLUCION" Type="String" />       
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaInformeEjecucionPorResolucion" runat="server" SelectMethod="ObtenerDataSetPorResolucion"
    TypeName="SGAFP.BL.cINFORME_FINAL_AF">
    <SelectParameters>    
        <asp:SessionParameter Name="RESOLUCION" SessionField="RESOLUCION" Type="String" />    
        <asp:Parameter DefaultValue="CODIGO_GRUPO" Name="asColumnaOrden" Type="String" />    
        <asp:Parameter Name="asTipoOrden" Type="String" />    
    </SelectParameters>
</asp:ObjectDataSource>

<dx:ASPxLoadingPanel ID="LoadingPanel" runat="server" ClientInstanceName="LoadingPanel" Text="Cargando..."  Modal="True" />