<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucFacturaAccionFormativa.ascx.vb" Inherits="controles_ucFacturaAccionFormativa" %>
<%@ Register TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" TagPrefix="uc1" %>
<%@ Register TagName="ucCriteriosFacturaAccionFormativa" Src="~/controles/ucCriteriosFacturaAccionFormativa.ascx" TagPrefix="uc1" %>
<%@ Register TagName="ucListaINFORME_FINAL_AF" Src="ucListaINFORME_FINAL_AF.ascx"  TagPrefix="uc1" %>

<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxLoadingPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>


<script language="javascript" type="text/javascript">    
    var _visibleIndex_dxgvLista;

    function CargarFacturas() {
        var ID_PROGRAMA_FORMACION = '-1';
        var ID_PROVEEDOR_AF = '-1';
        var NIT = '';
        var NUMERO_DOCUMENTO = '';
        var FECHA_DOCUMENTO = '';
        var ORDEN_COMPRA = '';
        var CODIGO_GRUPO = '';
        var ID_INFORME_FINAL = '-1';

        if (cbxProgramaFormacion.GetValue() != null) {
            ID_PROGRAMA_FORMACION = cbxProgramaFormacion.GetValue();
            }
        else {
            AsignarMensaje('Seleccione un Programa');
            return;
            }
        if (cbxProveedor.GetValue() != null) { ID_PROVEEDOR_AF = cbxProveedor.GetValue(); }
        if (txtNIT.GetValue() != null) { NIT = txtNIT.GetValue(); }
        if (txtNumeroDocumento.GetValue() != null) { NUMERO_DOCUMENTO = txtNumeroDocumento.GetValue(); }
        if (dteFechaEmision.GetValue() != null) {
            FECHA_DOCUMENTO = dteFechaEmision.GetValue().getDate() + '/' + (dteFechaEmision.GetValue().getMonth() + 1) + '/' + dteFechaEmision.GetValue().getFullYear();            
         }
        if (txtResolucion.GetValue() != null) { ORDEN_COMPRA = txtResolucion.GetValue(); }
        if (txtCODIGO_GRUPO.GetValue() != null) { CODIGO_GRUPO = txtCODIGO_GRUPO.GetValue(); }

        MostrarPanelModal(true, 'Cargando Facturas...');
        cFactura.PerformCallback('CargarFacturas;' +
                                        ID_PROGRAMA_FORMACION + ';' + 
                                        ID_PROVEEDOR_AF + ';' +
                                        NIT + ';' +
                                        NUMERO_DOCUMENTO + ';' +
                                        FECHA_DOCUMENTO + ';' +
                                        ORDEN_COMPRA + ';' + 
                                        CODIGO_GRUPO + ';' + 
                                        ID_INFORME_FINAL);
    }
    function RegistrarFactura(esBolproes) {
        if (esBolproes == 1) {
            window.open('../PagoAccionesFormativas/wfFacturaBolproes.aspx', '_self', '');  
        }
        else {
            cFactura.PerformCallback('RegistrarFactura;');
        }        
    }    

    function CargarCursosPorPrograma(idPrograma) {
        cFactura.PerformCallback('CargarCursosPorPrograma;' + idPrograma);
        //dxgvListaINFORME.PerformCallback('CargarCursosPorPrograma;' + idPrograma + ';' + speRegNumeroDocumento.GetValue() + ';' + cbxRegTipoDocumento.GetValue() + ';' + dteRegFechaEmision.GetValue());
    }
   
    function MostrarPopupAnulacion(id) {
        _visibleIndex_dxgvLista = id;
        memMotivo.SetValue('');
        lblMensajePopup.SetValue('Ingrese el motivo de la <span style="font-weight:bold; color:Red;">ANULACIÓN</span> de la Factura');       
        popupAnulacion.SetSize(400, 0);
        popupAnulacion.Show();
        popupAnulacion.UpdatePosition();
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

</script>

<dx:ASPxCallbackPanel runat="server" ID="cFactura" 
    ClientInstanceName="cFactura" ShowLoadingPanel="False" 
    meta:resourcekey="cFacturaResource1"> 
<ClientSideEvents EndCallback="function(s,e){   
                                            btnAceptar.SetEnabled(true);                                         
                                            MostrarPanelModal(false,'');
                                            if(s.cpResultCallback != undefined){                                               
                                                switch(s.cpResultCallback){       
                                                    case 'MostrarPopupRegistroFactura':                                                                 
                                                        cbxRegTipoDocumento.SetText('');                                      
                                                        popupRegistroFactura.SetSize(600, 0);
                                                        popupRegistroFactura.Show();
                                                        popupRegistroFactura.UpdatePosition();
                                                        break; 
                                                    case 'Factura registrada con exito!':                                                       
                                                        popupRegistroFactura.Hide();
                                                        AsignarMensaje(s.cpResultCallback);
                                                        break;                                                                                                 
                                                    default:                                                
                                                        if(s.cpResultCallback != ''){ 
                                                            AsignarMensaje(s.cpResultCallback);                                                                                                                                 
                                                        }                                                                                                                           
                                                }  
                                                delete s.cpResultCallback;                                                                                     
                                            }                                           
                                        }" />                                  
    <PanelCollection>        
        <dx:PanelContent ID="PanelContent1" runat="server" 
            meta:resourcekey="PanelContent1Resource1">   
            <uc1:ucBarraNavegacion ID="ucBarraNavegacion1" HabilitarCallBacks="true" runat="server" />
            <table width="100%">
                <TR>
		            <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">FACTURA DE CURSOS</asp:Label></TD>
	            </TR>
	            <TR>
		            <TD><asp:Image ID="Image2" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
	            </TR>
            </table>
            <uc1:ucCriteriosFacturaAccionFormativa ID="ucCriteriosFacturaAccionFormativa1" runat="server" 
                VerPrograma="true" VerProveedor="true" VerCentroFormacion="false" VerEjercicio="false" VerAreaFormacion="false" VerCodigoGrupo="false"
                VerBotonMostrar="false"  />
            
            <dx:ASPxGridView ID="dxgvFactura" ClientInstanceName="dxgvFactura" 
                runat="server" KeyFieldName="ID_FACTURA_AF" Width="100%" 
                DataSourceID="odsListaPorCriterios" meta:resourcekey="dxgvFacturaResource1" CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx">
                <ClientSideEvents CustomButtonClick="function(s,e){
                                                        if (e.buttonID =='btnAnularFactura'){
                                                            MostrarPopupAnulacion(e.visibleIndex.toString());                                                    
                                                            return;
                                                        }
                                                        e.processOnServer = true;
                                                      }" 
                                  EndCallback="function(s,e){                                            
                                            MostrarPanelModal(false,'');
                                            if(s.cpResultCallback != undefined){AsignarMensaje(s.cpResultCallback); delete s.cpResultCallback;}                                                                                       
                                        }" />  
                <Columns>        
                    <dx:GridViewCommandColumn ButtonType="Image" Caption=" " Width="30px" 
                        CellStyle-HorizontalAlign="Center" VisibleIndex="0" 
                        meta:resourcekey="GridViewCommandColumnResource1" >
                        <CustomButtons>                                        
                            <dx:GridViewCommandColumnCustomButton ID="btnAprobarFactura" 
                                Text="Aprobar Factura para Pago" 
                                meta:resourcekey="GridViewCommandColumnCustomButtonResource1" >                                                         
<Image Url="../imagenes/aprobar.gif"></Image>
                            </dx:GridViewCommandColumnCustomButton>
                        </CustomButtons> 
                        <CellStyle HorizontalAlign="Center"></CellStyle>
                    </dx:GridViewCommandColumn>  
                    <dx:GridViewCommandColumn ButtonType="Image" Caption=" " Width="30px" 
                        CellStyle-HorizontalAlign="Center" VisibleIndex="1" 
                        meta:resourcekey="GridViewCommandColumnResource2" >
                        <CustomButtons>                                                                    
                            <dx:GridViewCommandColumnCustomButton ID="btnAnularFactura" 
                                Text="Anular Factura" 
                                meta:resourcekey="GridViewCommandColumnCustomButtonResource2"  >                             
<Image Url="../imagenes/anular.gif"></Image>
                            </dx:GridViewCommandColumnCustomButton>
                        </CustomButtons> 
                        <CellStyle HorizontalAlign="Center"></CellStyle>
                    </dx:GridViewCommandColumn>  
                    <dx:GridViewDataColumn FieldName="RESOLUCION" Caption="Orden Compra/Contrato" 
                        VisibleIndex="2" meta:resourcekey="GridViewDataColumnResource1" >
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                    </dx:GridViewDataColumn>
                    <dx:GridViewDataColumn FieldName="NOMBRE_PROVEEDOR" Caption="Proveedor" 
                        VisibleIndex="2" meta:resourcekey="GridViewDataColumnResource2" >
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                    </dx:GridViewDataColumn>
                    <dx:GridViewDataColumn FieldName="NUMERO_DOCUMENTO" Caption="N° Documento" 
                        VisibleIndex="3" meta:resourcekey="GridViewDataColumnResource3" >
                    <CellStyle HorizontalAlign="Center"></CellStyle>
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                    </dx:GridViewDataColumn>
                    <dx:GridViewDataColumn FieldName="TIPO_DOCUMENTO" Caption="Tipo" 
                        VisibleIndex="4" meta:resourcekey="GridViewDataColumnResource4" >
                    <CellStyle HorizontalAlign="Center"></CellStyle>
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                    </dx:GridViewDataColumn>
                    <dx:GridViewDataColumn FieldName="FECHA_DOCUMENTO" Caption="Fecha" 
                        VisibleIndex="5" meta:resourcekey="GridViewDataColumnResource5" >
                    <CellStyle HorizontalAlign="Center"></CellStyle>
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                    </dx:GridViewDataColumn>
                    <dx:GridViewDataColumn FieldName="NOMBRE_ESTADO" Caption="Estado" 
                        VisibleIndex="6" meta:resourcekey="GridViewDataColumnResource6" >
<CellStyle HorizontalAlign="Center"></CellStyle>
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                    </dx:GridViewDataColumn>
                    <dx:GridViewDataTextColumn FieldName="MONTO" Caption="Monto Total($)" 
                        VisibleIndex="7" meta:resourcekey="GridViewDataTextColumnResource1"  >
                        <PropertiesTextEdit DisplayFormatString="#,##0.00" />
                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                        <CellStyle HorizontalAlign="Right"></CellStyle>
                    </dx:GridViewDataTextColumn> 
                    <dx:GridViewDataTextColumn FieldName="NUMERO_QUEDAN" Caption="N° Quedan" 
                        UnboundType="String" VisibleIndex="8" 
                        meta:resourcekey="GridViewDataTextColumnResource2" />
                    <dx:GridViewDataTextColumn FieldName="NUMERO_CHEQUE" Caption="N° Cheque" 
                        UnboundType="String" Visible="false" VisibleIndex="9" 
                        meta:resourcekey="GridViewDataTextColumnResource3" />                   
                </Columns>
                <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
                    EmptyDataRow="No existen registros para mostrar"                
                    CommandCancel="Cerrar" CommandUpdate="Aceptar" />
                <SettingsPager>
                    <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" Text="Pag. {0} de {1} ({2} registros)" />
                </SettingsPager>  
                <SettingsDetail AllowOnlyOneMasterRowExpanded="true" /> 
                <Images SpriteCssFilePath="~/App_Themes/DevEx/{0}/sprite.css">
                    <LoadingPanelOnStatusBar Url="~/App_Themes/DevEx/GridView/StatusBarLoading.gif">
                    </LoadingPanelOnStatusBar>
                    <LoadingPanel Url="~/App_Themes/DevEx/GridView/Loading.gif">
                    </LoadingPanel>
                </Images>
                <ImagesFilterControl>
                    <LoadingPanel Url="~/App_Themes/DevEx/GridView/Loading.gif">
                    </LoadingPanel>
                </ImagesFilterControl>
                <Styles CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx">
                    <Header ImageSpacing="5px" SortingImageSpacing="5px">
                    </Header>
                    <LoadingPanel ImageSpacing="5px">
                    </LoadingPanel>
                </Styles>
                <StylesEditors ButtonEditCellSpacing="0">
                    <ProgressBar Height="21px">
                    </ProgressBar>
                </StylesEditors>
                <Templates>
                    <DetailRow>           
                        <dx:ASPxGridView ID="dxgvFactura_Detalle" runat="server" 
                            DataSourceID="odsListaAccionFormativaPorFactura" KeyFieldName="ID_FACTURA_DET"
                                OnBeforePerformDataSelect="detailGrid_DataSelect" OnCustomUnboundColumnData="detailGrid_UnboundColumn"
                            Width="100%" AutoGenerateColumns="False" 
                            meta:resourcekey="dxgvFactura_DetalleResource1" >                
                            <TotalSummary>                    
                                <dx:ASPxSummaryItem FieldName="MONTO_FACTURA" SummaryType="Sum" 
                                    DisplayFormat="Facturado: #,##0.00" 
                                    meta:resourcekey="ASPxSummaryItemResource1" />
                            </TotalSummary>                              
                            <Columns>
                                <dx:GridViewDataTextColumn FieldName="CORRELATIVO" Caption="N°" 
                                    UnboundType="String" VisibleIndex="1" 
                                    meta:resourcekey="GridViewDataTextColumnResource4" />                                                                                       
                                <dx:GridViewDataColumn FieldName="MUNICIPIO" Caption="Municipio" 
                                    VisibleIndex="3" meta:resourcekey="GridViewDataColumnResource7" />
                                <dx:GridViewDataColumn FieldName="NOMBRE_ACCION_FORMATIVA" Caption="Curso" 
                                    VisibleIndex="4" meta:resourcekey="GridViewDataColumnResource8" />
                                <dx:GridViewDataColumn FieldName="CODIGO_GRUPO" Caption="Codigo Grupo" 
                                    VisibleIndex="5" meta:resourcekey="GridViewDataColumnResource9" />
                                <dx:GridViewDataColumn FieldName="FECHA_INICIAL" Caption="Fecha Inicio" 
                                    VisibleIndex="6" meta:resourcekey="GridViewDataColumnResource10" />
                                <dx:GridViewDataColumn FieldName="FECHA_FINAL" Caption="Fecha Finalización" 
                                    VisibleIndex="7" meta:resourcekey="GridViewDataColumnResource11" />
                                <dx:GridViewDataColumn FieldName="HORARIO" Caption="Horario" VisibleIndex="8" 
                                    meta:resourcekey="GridViewDataColumnResource12" />                                                                 
                                <dx:GridViewDataColumn FieldName="PARTICIPANTES_ACTIVOS" Caption="Activos" 
                                    VisibleIndex="9" meta:resourcekey="GridViewDataColumnResource13" >                                              
                                    <cellstyle horizontalalign="Center">
                                    </cellstyle>
                                </dx:GridViewDataColumn>
                                <dx:GridViewDataTextColumn FieldName="MONTO_FACTURA" Caption="Monto($)" 
                                    VisibleIndex="12" meta:resourcekey="GridViewDataTextColumnResource5" >
                                    <PropertiesTextEdit DisplayFormatString="#,##0.00" />
                                    <HeaderStyle HorizontalAlign="Right" />
                                </dx:GridViewDataTextColumn>                                                                                                                                                             
                            </Columns>   
                            <SettingsBehavior AllowFocusedRow="True" /> 
                            <SettingsPager>
                                <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" Text="Pag. {0} de {1} ({2} registros)" />
                            </SettingsPager>              
                            <Settings ShowFooter="True" />  
                             <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
                                EmptyDataRow="No existen registros para mostrar"                
                                CommandCancel="Cerrar" CommandUpdate="Aceptar" />
                        </dx:ASPxGridView>
                    </DetailRow>
                </Templates>
                <SettingsDetail ShowDetailRow="true" />
            </dx:ASPxGridView>
            
            <dx:ASPxPopupControl ID="popupAnulacion" Modal="true" runat="server" 
                    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" PopupElementID="BuscarNombresbtn" 
                    AllowResize="False" DragElement="Header" HeaderStyle-Font-Bold="true" HeaderText="Mensaje"    
                    AllowDragging="True" ClientInstanceName="popupAnulacion" 
                ShowShadow="true" EnableClientSideAPI="true"  
                    CloseAction="CloseButton" meta:resourcekey="popupAnulacionResource1">  
                 <ContentCollection>
                     <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server" 
                         meta:resourcekey="PopupControlContentControl1Resource1" >          
                        <table>               
                            <tr>
                                <td>
                                    <dx:ASPxLabel ID="lblMensajePopup" ClientInstanceName="lblMensajePopup" 
                                        runat="server" Font-Names="Verdana,Arial,Tahoma" Font-Size="XX-Small" 
                                        meta:resourcekey="lblMensajePopupResource1" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <dx:ASPxMemo AutoResizeWithContainer="true" CssClass="textUpper" 
                                        ID="memMotivo"  ClientInstanceName="memMotivo" runat="server" Height="71px" 
                                        Width="400px" meta:resourcekey="memMotivoResource1"  />                          
                                </td>
                            </tr>
                            <tr>
                                <td align="center" >
                                    <table width="50%">
                                        <tr align="center" >
                                            <td>
                                                <dx:ASPxButton ID="btnAceptarAnulacion" ClientInstanceName="btnAceptarAnulacion" 
                                                    AutoPostBack="false" CausesValidation="True" Text="Aceptar" runat="server" 
                                                    meta:resourcekey="btnAceptarAnulacionResource1" >                                                
                                                <ClientSideEvents Click="function(s,e){
                                                                                if(memMotivo.GetValue() != '' && memMotivo.GetValue() != null){                                                                                      
                                                                                    popupAnulacion.Hide();                                                                                                                                                                                                                                                          
                                                                                    cFactura.PerformCallback('AnularFactura;' + _visibleIndex_dxgvLista + ';' + memMotivo.GetValue());                                                                                                                                                                     
                                                                                } 
                                                                                else{
                                                                                    AsignarMensaje('El Motivo es requerido para Anular la Factura');
                                                                                }                                                                                                                                               
                                                                            }" 
                                                />
                                                </dx:ASPxButton>
                                            </td>
                                            <td>
                                                <dx:ASPxButton ID="btnCancelarAnulacion" ClientInstanceName="btnCancelarAnulacion" 
                                                    AutoPostBack="false" CausesValidation="False" Text="Cancelar" 
                                                    runat="server" meta:resourcekey="btnCancelarAnulacionResource1" >                                                
                                                <ClientSideEvents Click="function(s,e){
                                                                                 popupAnulacion.Hide();                                                                                                                           
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
            
            
            <dx:ASPxPopupControl ID="popupRegistroFactura" Modal="true" runat="server"  
                    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" PopupElementID="BuscarNombresbtn" 
                    AllowResize="False" DragElement="Window" HeaderStyle-Font-Bold="true" HeaderText="Registro de Factura"    
                    AllowDragging="True" ClientInstanceName="popupRegistroFactura" 
                ShowShadow="true" EnableClientSideAPI="true"  
                    CloseAction="CloseButton" Width="600px" 
                meta:resourcekey="popupRegistroFacturaResource1" >  
                 <ContentCollection>
                     <dx:PopupControlContentControl ID="PopupControlContentControl2" runat="server" 
                         meta:resourcekey="PopupControlContentControl2Resource1" >          
                        <table width="600px" >               
                            <tr>                                
                                <td>  
                                    <dx:ASPxLabel ID="lblTipoSolicitud"  Text="Programa:" runat="server" 
                                        meta:resourcekey="lblTipoSolicitudResource1" />                                  
                                </td>
                                <td> 
                                    <dx:ASPxComboBox runat="server" ID="cbxProgramaFormacionPopup" 
                                        LoadingPanelText="Cargando Programas..." ShowLoadingPanel="true" 
                                        DataSourceID="odsProgramaFormacion" TextField="NOMBRE_PROGRAMA_FORMACION" 
                                        ValueField="ID_PROGRAMA_FORMACION" 
                                        ClientInstanceName="cbxProgramaFormacionPopup" ValueType="System.Decimal" 
                                        Font-Size="X-Small" meta:resourcekey="cbxProgramaFormacionPopupResource1">                    
                                        <ClientSideEvents  SelectedIndexChanged="function(s,e){CargarCursosPorPrograma(s.GetValue().toString())}" 
                                        />
                                    </dx:ASPxComboBox>                                            
                                </td>
                                <td>
                                    <dx:ASPxLabel ID="lblRegNumeroDocumento"  Text="N° Documento:" runat="server" 
                                        meta:resourcekey="lblRegNumeroDocumentoResource1" />
                                </td>
                                <td>                                    
                                    <dx:ASPxSpinEdit ID="speRegNumeroDocumento" 
                                        ClientInstanceName="speRegNumeroDocumento" Width="130px" runat="server" 
                                        NumberType="Integer" AllowUserInput="true" Number="0" MinValue="0" 
                                        meta:resourcekey="speRegNumeroDocumentoResource1" >                                          
                                    </dx:ASPxSpinEdit>     
                                </td>
                            </tr>    
                            <tr>
                                 <td>
                                    <dx:ASPxLabel ID="ASPxLabel2"  Text="Tipo Documento:" runat="server" 
                                         meta:resourcekey="ASPxLabel2Resource1" />
                                </td>
                                <td>
                                    <dx:ASPxComboBox runat="server" ID="cbxRegTipoDocumento" 
                                        ClientInstanceName="cbxRegTipoDocumento" 
                                        meta:resourcekey="cbxRegTipoDocumentoResource1"  >                              
                                        <Items>
                                            <dx:ListEditItem Text="FACTURA" Value="1" Selected="true" 
                                                meta:resourcekey="ListEditItemResource1"  />
                                            <dx:ListEditItem Text="RECIBO" Value="2" 
                                                meta:resourcekey="ListEditItemResource2" />
                                        </Items>                                        
                                    </dx:ASPxComboBox>
                                </td>
                                <td>
                                    <dx:ASPxLabel ID="lblRegFechaEmision" runat="server" Text="Fecha Emisión:" 
                                        meta:resourcekey="lblRegFechaEmisionResource1"  />
                                </td>
                                <td>                                    
                                    <dx:ASPxDateEdit ID="dteRegFechaEmision" Width="130px"  runat="server" 
                                        EditFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="true" 
                                        ClientInstanceName="dteRegFechaEmision" 
                                        meta:resourcekey="dteRegFechaEmisionResource1" >
                                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                                        <RequiredField IsRequired="True" ErrorText="Fecha de emisi&#243;n es requerida."></RequiredField>
                                        </ValidationSettings>
                                    </dx:ASPxDateEdit>
                                </td>                               
                            </tr>
                        </table> 
                        <table width="100%" >               
                            <tr>
                                <td>
                                    <dx:ASPxLabel ID="ASPxLabel1" runat="server" 
                                        Text="Seleccione únicamente un Curso de la lista siguiente:" ForeColor="Blue" 
                                        Font-Bold="true" meta:resourcekey="ASPxLabel1Resource1"  />
                                </td>
                            </tr>
                            <tr>                               
                                <td>
                                    <uc1:ucListaINFORME_FINAL_AF ID="ucListaINFORME_FINAL_AF1" runat="server" PermitirEditar="False"
                                    PermitirEliminar="False" PermitirPaginacion="True" PermitirSeleccionar="false" PermitirMarcar="true"
                                    VerCODIGO_ESTADO_AF="False" VerID_PROVEEDOR_AF="False"  VerID_INFORME_FINAL="false" 
                                    VerLASTUPDATE="False" VerUSERID="False"  PermitirFocoEnFilas="false" PermitirRowHotTrack="false"
                                    VerID_ACCION_FORMATIVA="false" VerFECHA_INFORME="false" VerNUMERO_FACTURA="False"
                                    VerELABORADO_POR="False" VerMONTO_APROBADO="False" VerPORC_PROM_ASISTENCIA="False"
                                    VerNOTA_PROMEDIO="false" VerESTADO="false" VerCOMENTARIOS="false" VerUSUARIO_APROBACION="false"
                                    VerID_ESTADO_INFORME="false" PermitirFiltroEnEncabezado="false" />   
                                </td>
                            </tr>
                        </table>
                        <table>
                                                <tr>
                                                    <td>
                                                        <dx:ASPxButton ID="btnAceptar" ClientInstanceName="btnAceptar" 
                                                            AutoPostBack="False" runat="server" Text="Aceptar" Width="60px" 
                                                            Font-Names="Verdana, Arial" Font-Size="10px" 
                                                            meta:resourcekey="btnAceptarResource1" >                            
                                                            <ClientSideEvents Click="function(s,e){    
                                                                                         if (ASPxClientEdit.ValidateEditorsInContainer(null,null,true)){                                                                                                                                                                                                                                                     
                                                                                            if(dxgvListaINFORME.GetSelectedRowCount()==1){    
                                                                                                s.SetEnabled(false);
                                                                                                cFactura.PerformCallback('GuardarFactura');
                                                                                            }
                                                                                            else{
                                                                                                if(dxgvListaINFORME.GetSelectedRowCount()==0){AsignarMensaje('Seleccione un Curso.')};
                                                                                                if(dxgvListaINFORME.GetSelectedRowCount()>1){AsignarMensaje('Ha seleccionado mas de un Curso. Por favor verifique.')};
                                                                                            }                                                                                                                    
                                                                                        }
                                                                                     }"  />         
                                                        </dx:ASPxButton>
                                                    </td>
                                                    <td>
                                                        <dx:ASPxButton ID="btnCancelar" ClientInstanceName="btnCancelar" 
                                                            AutoPostBack="False" CausesValidation="false" runat="server" Text="Cancelar" 
                                                            Width="60px" Font-Names="Verdana, Arial" Font-Size="10px" 
                                                            meta:resourcekey="btnCancelarResource1" >  
                                                            <ClientSideEvents Click="function(s,e){
                                                                                        ASPxClientEdit.ClearEditorsInContainer(null,null,true);
                                                                                        popupRegistroFactura.Hide();
                                                                                        cFactura.PerformCallback('LimpiarDatosFactura');
                                                                                     }"  />                                                                                  
                                                        </dx:ASPxButton>
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
    TypeName="SGAFP.BL.cFACTURA_AF">
    <SelectParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PROGRAMA_FORMACION" Type="Decimal" />    
        <asp:Parameter DefaultValue="0" Name="ID_PROVEEDOR_AF" Type="Decimal" />    
        <asp:Parameter Name="NIT" Type="String" />  
        <asp:Parameter Name="NUMERO_DOCUMENTO" Type="String" />  
        <asp:Parameter Name="FECHA_DOCUMENTO" Type="Object" />            
        <asp:Parameter Name="RESOLUCION" Type="String" />       
        <asp:Parameter Name="CODIGO_GRUPO" Type="String" />   
        <asp:Parameter DefaultValue="0" Name="ID_INFORME_FINAL" Type="Decimal" /> 
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaAccionFormativaPorFactura" runat="server" SelectMethod="ObtenerDataSetPorFactura"
    TypeName="SGAFP.BL.cACCION_FORMATIVA">
    <SelectParameters>    
        <asp:SessionParameter Name="ID_FACTURA_AF" SessionField="ID_FACTURA_AF" Type="String" />    
        <asp:Parameter DefaultValue="CODIGO_GRUPO" Name="asColumnaOrden" Type="String" />    
        <asp:Parameter Name="asTipoOrden" Type="String" />    
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsProgramaFormacion" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerListaPorROLES" TypeName="SGAFP.BL.cPROGRAMA_FORMACION">  
    <SelectParameters>                
    <asp:Parameter Name="listaRoles" Type="Object" />        
    </SelectParameters>
</asp:ObjectDataSource>

<dx:ASPxLoadingPanel ID="LoadingPanel" runat="server" 
    ClientInstanceName="LoadingPanel" Text="Cargando..."  Modal="True" 
    meta:resourcekey="LoadingPanelResource1" />