<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucDesembolsoPATI_Aplicacion.ascx.vb" Inherits="controles_ucDesembolsoPATI_Aplicacion" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxHiddenField" tagprefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>

<script language="javascript" type="text/javascript"> 
 function AgregarLiquidaciones() {
        MostrarPanelModal(true, 'Cargando...');
        cpDesembolsoPATI_Aplicacion.PerformCallback('MostrarPopup');
    }   
</script>
<dx:ASPxCallbackPanel runat="server" ID="cpDesembolsoPATI_Aplicacion" ClientInstanceName="cpDesembolsoPATI_Aplicacion" ShowLoadingPanel="false">        
     <ClientSideEvents EndCallback="function(s,e){                                            
                                            MostrarPanelModal(false,''); 
                                            if(s.cpResultCallback != undefined){
                                                switch(s.cpResultCallback){       
                                                    case 'ActualizarGrid':                                               
                                                        dxgvAplicacion.Refresh();
                                                        break;  
                                                    case 'MostrarPopup':                                                                                                   
                                                        popupAgregarLiquidacion.Show();
                                                        break;                                                                                                                                      
                                                    default:                                                
                                                        if(s.cpResultCallback != ''){ 
                                                            popupAgregarLiquidacion.Hide();
                                                            AsignarMensaje(s.cpResultCallback);                                                                                                                                 
                                                        }                                                                                                                           
                                                }  
                                                delete s.cpResultCallback;                                     
                                            }                                          
                                        }" />  
    <PanelCollection>        
        <dx:PanelContent ID="PanelContent1" runat="server">  
            <table cellpadding="0" cellspacing="3" border="0" >
                <tr>
                    <td style="width:100px">
                        <dx:ASPxLabel ID="lblFuente" runat="server" Font-Size="X-Small" Text="Fuente:" />
                    </td>
                    <td>
                         <dx:ASPxLabel ID="lblNOMBRE_FUENTE" runat="server" Font-Size="X-Small" />
                    </td>
                    <td style="width:10px"></td> 
                   <td>
                        <dx:ASPxLabel ID="lblConvocatoria" runat="server" Font-Size="X-Small" Text="N° Convocatoria:" />
                    </td>
                    <td>
                         <dx:ASPxLabel ID="lblNO_CONVOCATORIA" runat="server" Font-Size="X-Small" />
                    </td>
                </tr>  
                <tr>
                    <td>
                        <dx:ASPxLabel ID="lblNoDesembolso" runat="server" Font-Size="X-Small" Text="N° Desembolso:" />
                    </td>
                    <td>
                         <dx:ASPxLabel ID="lblNUM_DESEMBOLSO" runat="server" Font-Size="X-Small" />
                    </td>
                    <td></td>
                    <td>
                        <dx:ASPxLabel ID="lblFechaDesembolso" runat="server" Font-Size="X-Small" Text="Fecha Desembolso:" />
                    </td>
                    <td>
                         <dx:ASPxLabel ID="lblFECHA_DESEMBOLSO" runat="server" Font-Size="X-Small" />
                    </td>
                </tr>   
                <tr>
                    <td>
                        <dx:ASPxLabel ID="lblMontoAutorizado" runat="server" Font-Size="X-Small" Text="Monto Autorizado:" />
                    </td>
                    <td>
                         <dx:ASPxLabel ID="lblMONTO_AUTORIZADO" runat="server" Font-Size="X-Small"  />
                    </td>
                    <td></td><td></td><td></td>
                </tr>   
                 <tr>
                    <td>
                        <dx:ASPxLabel ID="lblMontoAplicado" runat="server" Font-Size="X-Small" Text="Monto Aplicado:" />
                    </td>
                    <td>
                         <dx:ASPxLabel ID="lblMONTO_APLICADO" runat="server" Font-Size="X-Small"  ForeColor="Blue" />
                    </td>
                    <td></td><td></td><td></td>
                </tr>   
                 <tr>
                    <td>
                        <dx:ASPxLabel ID="lblDiferencia" runat="server" Font-Size="X-Small" Text="Diferencia:" />
                    </td>
                    <td>
                         <dx:ASPxLabel ID="lblMONTO_DIFERENCIA" runat="server" Font-Size="X-Small" 
                              ForeColor="Red" />
                    </td>
                    <td></td><td></td><td></td>
                </tr>                   
            </table>  
              
            <dx:ASPxGridView ID="dxgvAplicacion" ClientInstanceName="dxgvAplicacion" runat="server" AutoGenerateColumns="False" KeyFieldName="ID_LIQUIDACION_DET" Font-Size="X-Small" >
                <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
                <SettingsPager PageSize="10" >                    
                    <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
                        Text="Pag. {0} de {1} ({2} registros)" />
                </SettingsPager>
                <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
                    EmptyDataRow="No existen registros para mostrar" />    
                <Columns>       
                    <dx:GridViewDataTextColumn FieldName="NOMBRE_MUNICIPIO" VisibleIndex="0" Caption="Municipio" />
                    <dx:GridViewDataTextColumn FieldName="NO_LIQUIDACION" VisibleIndex="1" Caption="N° Liquidacion" />
                    <dx:GridViewDataTextColumn FieldName="FECHA_ELABORACION" VisibleIndex="2" 
                        Caption="Fecha Elaboración" PropertiesTextEdit-DisplayFormatString="dd/MM/yyy">
<PropertiesTextEdit DisplayFormatString="dd/MM/yyy"></PropertiesTextEdit>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="NOMBRE_ACCION_FORMATIVA" VisibleIndex="3" Caption="Curso" />
                    <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" VisibleIndex="4" Caption="Proveedor" />
                    <dx:GridViewDataTextColumn FieldName="NUMERO_DOCUMENTO" VisibleIndex="5" 
                        Caption="Factura" CellStyle-HorizontalAlign="Center" 
                        Settings-AllowHeaderFilter="True" >
<Settings AllowHeaderFilter="True"></Settings>

<CellStyle HorizontalAlign="Center"></CellStyle>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="SOLICITADO" VisibleIndex="6" 
                        Caption="Solicitado" PropertiesTextEdit-DisplayFormatString="#,##0.00">
<PropertiesTextEdit DisplayFormatString="#,##0.00"></PropertiesTextEdit>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="DESEMBOLSO_ANTERIOR" VisibleIndex="7" 
                        Caption="Desembolso Acumulado" 
                        PropertiesTextEdit-DisplayFormatString="#,##0.00" >
<PropertiesTextEdit DisplayFormatString="#,##0.00"></PropertiesTextEdit>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="APLICA" UnboundType="Boolean" VisibleIndex="8" Caption="Aplica" Settings-AllowAutoFilter="False" >            
<Settings AllowAutoFilter="False"></Settings>
                        <DataItemTemplate>
                            <dx:ASPxCheckBox ID="chkAPLICA" runat="server" OnInit="chkAPLICA_Init" AllowGrayed="false" ValueType="System.Boolean" />
                        </DataItemTemplate>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="ESTE_DESEMBOLSO" VisibleIndex="9" Caption="Este Desembolso" Settings-AllowHeaderFilter="True"  >                            
<Settings AllowAutoFilter="False"></Settings>
                        <DataItemTemplate>
                            <dx:ASPxTextBox ID="txtESTE_DESEMBOLSO" Width="100px" Font-Size="X-Small" runat="server" Value='<%#Bind("ESTE_DESEMBOLSO")%>' OnInit="txtESTE_DESEMBOLSO_Init">
                                <MaskSettings Mask="<0..9999999g>.<00..99>" IncludeLiterals="DecimalSymbol" />
                                <ValidationSettings ErrorDisplayMode="ImageWithTooltip" />
                           </dx:ASPxTextBox>
                        </DataItemTemplate>
                    </dx:GridViewDataTextColumn>
	               </Columns>	      
                <Settings ShowGroupPanel="True" ShowHeaderFilterButton="true" ShowFilterRow="True" />                                  
                <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"/>                    
                <GroupSummary>
                    <dx:ASPxSummaryItem FieldName="ESTE_DESEMBOLSO" SummaryType="Sum" DisplayFormat="#,##0.00"  />                    
                </GroupSummary>
            </dx:ASPxGridView>         
            
            <dx:ASPxPopupControl ID="popupAgregarLiquidacion" Modal="true" runat="server" 
                    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" PopupElementID="BuscarNombresbtn" 
                    AllowResize="False" DragElement="Header" HeaderStyle-Font-Bold="true" HeaderText="Agregar liquidaciones de Municipios"    
                    AllowDragging="True" ClientInstanceName="popupAgregarLiquidacion" ShowShadow="true" EnableClientSideAPI="true"  
                    CloseAction="CloseButton" Width="320px">                                      
                 <ContentCollection>
                     <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server" >          
                        <table>   
                            <tr>
                                <th colspan="4">
                                    <dx:ASPxLabel ID="ASPxLabel1" runat="server" Font-Size="XX-Small" Text="Marque los Municipios de los que agregará cursos pendientes de desembolso y digite las fechas de sus respectivas liquidaciones" />
                                </th> 
                            </tr>
                            <tr>                                
                                <th colspan="4">
                                    <dx:ASPxListBox ID="lsbMunicipio" runat="server" SelectionMode="CheckColumn" 
                                        Width="270px" Font-Size="XX-Small"  EnableSynchronization="True" TextField="NOMBRE" ValueField="CODIGO_DEPARTAMENTO" ValueType="System.String"     
                                        ClientInstanceName="lsbMunicipio" DataSourceID="odsMunicipio" >                                        
                                        <Columns>
                                            <dx:ListBoxColumn FieldName="NOMBRE" Caption="Municipio" Width="100%"  />
                                            <dx:ListBoxColumn FieldName="CODIGO_DEPARTAMENTO" Visible="false" />
                                            <dx:ListBoxColumn FieldName="CODIGO_MUNICIPIO" Visible="false" />
                                        </Columns>
                                    </dx:ASPxListBox>                                   
                                </th>
                            </tr>            
                            <tr>                                
                                <td>
                                    <dx:ASPxLabel ID="lblPeriodoInicial" runat="server" Font-Size="X-Small" Text="Entre el:" />
                                </td>
                                <td>
                                     <dx:ASPxDateEdit ID="dteFECHA_LIQUIDACION_INICIAL" Font-Size="X-Small" ClientInstanceName="dteFECHA_LIQUIDACION_INICIAL" Width="80px" runat="server" EditFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="true" >
                                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                                        <RequiredField IsRequired="True" ErrorText="Fecha inicial es requerida."></RequiredField>
                                        </ValidationSettings>
                                     </dx:ASPxDateEdit>
                                </td>                              
                                <td>
                                    <dx:ASPxLabel ID="lblPeriodoFinal" runat="server" Font-Size="X-Small" Text=" y " />
                                </td>
                                <td>
                                     <dx:ASPxDateEdit ID="dteFECHA_LIQUIDACION_FINAL" Font-Size="X-Small" ClientInstanceName="dteFECHA_LIQUIDACION_FINAL" Width="80px" runat="server" EditFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="true" >
                                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                                        <RequiredField IsRequired="True" ErrorText="Fecha final es requerida."></RequiredField>
                                        </ValidationSettings>
                                     </dx:ASPxDateEdit>
                                </td>                 
                            </tr> 
                         </table>
                         <table>                           
                            <tr>
                                <td align="center" >
                                    <table width="50%">
                                        <tr align="center" >
                                            <td>
                                                <dx:ASPxButton ID="btnAceptar" ClientInstanceName="btnAceptar" 
                                                    AutoPostBack="false" CausesValidation="True" Text="Aceptar" runat="server" >                                                
                                                <ClientSideEvents Click="function(s,e){    
                                                                            if (ASPxClientEdit.ValidateEditorsInContainer(null)){    
                                                                                if(lsbMunicipio.GetSelectedItems().length==0){
                                                                                    AsignarMensaje('Seleccione al menos un Municipio');
                                                                                    return;
                                                                                }
                                                                                var items = lsbMunicipio.GetSelectedItems();
                                                                                var result = '';                                                                                
                                                                                for(var i = items.length - 1; i >= 0; i = i - 1) {
                                                                                    result += items[i].text;
                                                                                    result += '|';
                                                                                    result += items[i].value;    
                                                                                    result += ';';                                                                               
                                                                                }                                                                                                                                                                            
                                                                                cpDesembolsoPATI_Aplicacion.PerformCallback('ProcesarLiquidaciones;'+result);
                                                                            }                                                                                                                                                                                                         
                                                                          }" />                                                
                                                </dx:ASPxButton>
                                            </td>
                                            <td>
                                                <dx:ASPxButton ID="btnCancelar" ClientInstanceName="btnCancelar" 
                                                    AutoPostBack="false" CausesValidation="False" Text="Cancelar" runat="server" >                                                
                                                <ClientSideEvents Click="function(s,e){
                                                                            popupAgregarLiquidacion.Hide();                                                                                 
                                                                         }" />
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
               
            <dx:ASPxHiddenField runat="server" ID="hfucDesembolsoPATI_Aplicacion" /> 
        </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>
            
 <asp:ObjectDataSource ID="odsListaAplicacionDesembolso" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="GetDataByFuenteConvocatoriaFechas" 
    TypeName="SGAFP.DL.DS_DLTableAdapters.AplicacionDesembolsoPATITableAdapter">
    <SelectParameters>
        <asp:Parameter Name="ID_FUENTE" Type="Decimal" />
        <asp:Parameter Name="NO_CONVOCATORIA" Type="Decimal" />
        <asp:Parameter Name="NUM_DESEMBOLSO" Type="String" />
        <asp:Parameter Name="FECHA_ELABORACION_INICIAL" Type="DateTime"  />
        <asp:Parameter Name="FECHA_ELABORACION_FINAL" Type="DateTime" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsMunicipio" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerListaParaPATIPorFUENTE" TypeName="SGAFP.BL.cMUNICIPIO">
<SelectParameters>                    
    <asp:Parameter Name="ID_FUENTE" Type="Decimal" />         
</SelectParameters>
</asp:ObjectDataSource>
            

 
            