<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucGenerarInformeParcial.ascx.vb" Inherits="controles_ucGenerarInformeParcial" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaINFORME_FINAL_AF" Src="~/controles/ucListaINFORME_FINAL_AF.ascx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxLoadingPanel" TagPrefix="dx" %>

<script language="javascript" type="text/javascript">
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
    
<dx:ASPxCallbackPanel runat="server" ID="cpInformeParcial" ClientInstanceName="cpInformeParcial" ShowLoadingPanel="false">      
<ClientSideEvents EndCallback="function(s,e){                                            
                                            //MostrarPanelModal(false,'');
                                            if(s.cpResultCallback != undefined){         
                                               if(s.cpResultCallback != ''){ 
                                                    AsignarMensaje(s.cpResultCallback);                                                                                                                                 
                                               }                                
                                               delete s.cpResultCallback;                                     
                                            }
                                        }" />       
    <PanelCollection>        
        <dx:PanelContent ID="PanelContent1" runat="server">  
            <table cellpadding="0" cellspacing="3" border="0" >  
                <tr>
                    <td><dx:ASPxLabel ID="ASPxLabel3" runat="server" Font-Names="Arial" 
                            Width="500px" Font-Bold="true"                       
                            Text="Seleccione la fecha del curso hasta la que se reportará este Informe. A continuación el sistema desplegará una Vista Previa del Informe a generar." />
                     </td>                     
                </tr>     
                <tr>
                    <td></td>
                </tr>          
            </table>
            <table cellpadding="0" cellspacing="3" border="0" >               
                <tr>
                    <th colspan="4" style="text-align:left">
                         <dx:ASPxLabel ID="ASPxLabel4" runat="server" Font-Names="Arial" Text="Período de Ejecución"  />
                    </th>
                </tr>
                <tr>                     
                     <td>
                         <dx:ASPxLabel ID="lblFechaInicio" runat="server" Font-Names="Arial" Text="Desde el "  />
                    </td>
                     <td style="width:100px">
                         <dx:ASPxLabel ID="lblInicioPeriodo" runat="server" Font-Names="Arial" 
                             Font-Bold="true" ForeColor="Blue"  />
                    </td>
                     <td>
                         <dx:ASPxLabel ID="ASPxLabel2" runat="server" Font-Names="Arial"  Text=" hasta el "  />
                    </td>
                     <td style="width:100px">
                        <dx:ASPxDateEdit ID="dteFechaFinal" Font-Names="Arial"   
                             ClientInstanceName="dteFechaFinal" Width="101px" ForeColor="Blue" 
                             runat="server" EditFormatString="dd/MM/yyyy" EditFormat="Custom" 
                             UseMaskBehavior="true" Height="22px" >
                                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                                        <RequiredField IsRequired="True" ErrorText="Fecha final es requerida."></RequiredField>
                                        </ValidationSettings>
                             <ClientSideEvents ValueChanged="function(s,e){
                                                                cpInformeParcial.PerformCallback('MostrarInforme');
                                                            }"  />
                        </dx:ASPxDateEdit>
                        <dx:ASPxComboBox runat="server" ID="cbxFechaFinPeriodo" ForeColor="Blue" Font-Bold="true" 
                             ClientInstanceName="cbxFechaFinPeriodo" Width="120px"  >  
                              <ClientSideEvents ValueChanged="function(s,e){
                                                                cpInformeParcial.PerformCallback('MostrarInforme');
                                                            }"  />                                                                                                    
                        </dx:ASPxComboBox>
                    </td>
                </tr>                
              </table>   
               <dx:ASPxGridView ID="dgvInformeParcial" runat="server" AutoGenerateColumns="False" Width="100%" CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx" >
                        <Columns>                                                                               
                            <dx:GridViewDataTextColumn Caption="Curso" FieldName="Curso" UnboundType="String"  VisibleIndex="1" />                             
                            <dx:GridViewDataTextColumn Caption="No. HI" FieldName="CodigoGrupo" UnboundType="String" VisibleIndex="2" />                            
                            <dx:GridViewDataTextColumn Caption="Lugar Ejecución" FieldName="LugarEjecucion" UnboundType="String" VisibleIndex="3" />                            
                            <dx:GridViewDataDateColumn Caption="Desde" FieldName="FECHA_INICIAL" 
                                VisibleIndex="4" HeaderStyle-HorizontalAlign="Center" 
                                CellStyle-HorizontalAlign="Center" >                            
                                <PropertiesDateEdit Spacing="0">
                                </PropertiesDateEdit>
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
                            </dx:GridViewDataDateColumn>
                            <dx:GridViewDataDateColumn Caption="Hasta" FieldName="FECHA_FINAL" 
                                VisibleIndex="5" HeaderStyle-HorizontalAlign="Center" 
                                CellStyle-HorizontalAlign="Center" >                                                        
                                <PropertiesDateEdit Spacing="0">
                                </PropertiesDateEdit>
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
                            </dx:GridViewDataDateColumn>
                            <dx:GridViewDataTextColumn Caption="Horario" FieldName="HORARIO" VisibleIndex="6" />                            
                            <dx:GridViewDataTextColumn Caption="Horas<br>Totales" FieldName="HorasTotales" UnboundType="Integer" 
                                VisibleIndex="7" HeaderStyle-HorizontalAlign="Center" 
                                CellStyle-HorizontalAlign="Center" >                            
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Horas<br>Desarrolladas" 
                                FieldName="HORAS_DESARROLLADAS" VisibleIndex="8" 
                                HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" >                            
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Horas<br>Acumuladas" FieldName="HorasAcumuladas" UnboundType="Integer" 
                                VisibleIndex="9" HeaderStyle-HorizontalAlign="Center" 
                                CellStyle-HorizontalAlign="Center" >                            
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
                            </dx:GridViewDataTextColumn>

                             <dx:GridViewDataTextColumn Caption="Porcentaje<br>de ejecución" 
                                FieldName="PORCENTAJE_EJECUCION" VisibleIndex="10"  UnboundType="Decimal" 
                                HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" >                            
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
<CellStyle HorizontalAlign="Center"></CellStyle>
                                 <PropertiesTextEdit DisplayFormatString="#,##0.00%"   />
                            </dx:GridViewDataTextColumn>

                            <dx:GridViewDataTextColumn Caption="Inscritos" 
                                FieldName="PARTICIPANTES_INSCRITOS" VisibleIndex="10" 
                                HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" >                            
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Activos" FieldName="PARTICIPANTES_FINALES" 
                                VisibleIndex="11" HeaderStyle-HorizontalAlign="Center" 
                                CellStyle-HorizontalAlign="Center" >                            
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Costo Hora<br>según contratación " FieldName="COSTO_X_HORA" 
                                VisibleIndex="12" HeaderStyle-HorizontalAlign="Center" 
                                CellStyle-HorizontalAlign="Center" >                   
                                <PropertiesTextEdit DisplayFormatString="$ #,##0.00####" />     
<HeaderStyle HorizontalAlign="Center"></HeaderStyle> 
<CellStyle HorizontalAlign="Center"></CellStyle>
                            </dx:GridViewDataTextColumn>
                             <dx:GridViewDataTextColumn Caption="Costo por Participante<br>según contratación" FieldName="COSTO_X_PARTICIPANTE" 
                                VisibleIndex="13" HeaderStyle-HorizontalAlign="Center"  UnboundType="Decimal"  
                                CellStyle-HorizontalAlign="Center" >                                           
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
 <PropertiesTextEdit DisplayFormatString="$ #,##0.00####"     />
<CellStyle HorizontalAlign="Center"></CellStyle>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Monto parcial a<br>Pagar" 
                                FieldName="MONTO_FACTURA"  VisibleIndex="14" Width="150px"   
                                HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center">                                                                                          
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
 <PropertiesTextEdit DisplayFormatString="$ #,##0.00"     />
<CellStyle HorizontalAlign="Center"></CellStyle>
                            </dx:GridViewDataTextColumn>
                        </Columns>                        
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
                 </dx:ASPxGridView>         
                 <table>
                    <tr>
                        <td style="height:30px">
                        <dx:ASPxLabel ID="ASPxLabel1" runat="server" Font-Names="Arial" Font-Size="X-Small" Font-Bold="True" Text="Listado de Participantes"  />
                        </td>
                    </tr>
                 </table>
                <dx:ASPxGridView ID="dgvDetalleInformeParcial" runat="server" AutoGenerateColumns="False" Width="100%"  CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx">
                        <Columns>
                            <dx:GridViewDataColumn VisibleIndex="0" Caption="N°" FieldName="CORRELATIVO" 
                                UnboundType="Integer" CellStyle-Font-Bold="true" HeaderStyle-Font-Bold="true" Visible="false" >
<HeaderStyle Font-Bold="True"></HeaderStyle>

<CellStyle Font-Bold="True"></CellStyle>
                            </dx:GridViewDataColumn>
                            <dx:GridViewDataTextColumn FieldName="NOMBRES_APELLIDOS" VisibleIndex="1" SortIndex="0" SortOrder="Ascending" Caption="Apellidos y Nombres" UnboundType="String"  >                            
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="NOTA_TEORICA_OBTENIDA" 
                                PropertiesTextEdit-DisplayFormatString="#,##0.00" VisibleIndex="2" 
                                UnboundType="Decimal"  Caption="Nota Final<br>Teórica" Visible="false"  >                            
<PropertiesTextEdit DisplayFormatString="#,##0.00"></PropertiesTextEdit>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="NOTA_PRACTICA_OBTENIDA" 
                                UnboundType="Decimal" PropertiesTextEdit-DisplayFormatString="#,##0.00" 
                                VisibleIndex="3" Caption="Nota Final<br>Practica" Visible="false"  >                            
<PropertiesTextEdit DisplayFormatString="#,##0.00"></PropertiesTextEdit>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="NOTA_FINAL" UnboundType="Decimal" 
                                PropertiesTextEdit-DisplayFormatString="#,##0.00" VisibleIndex="4" 
                                Caption="Promedio<br>Final" CellStyle-Font-Bold="true" Visible="false"  >                            
<PropertiesTextEdit DisplayFormatString="#,##0.00"></PropertiesTextEdit>

<CellStyle Font-Bold="True"></CellStyle>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="PORC_ASISTENCIA" VisibleIndex="5" 
                                Caption="Porcentaje de Asistencia<br>en función de las horas contratadas" CellStyle-Font-Bold="true" >                            
<CellStyle Font-Bold="True"></CellStyle>
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                            </dx:GridViewDataTextColumn>                            
                            <dx:GridViewDataTextColumn FieldName="MONTO_APROBADO" VisibleIndex="5" 
                                Caption="Monto a pagar por participante<br>en función del costo por participante contratado" CellStyle-Font-Bold="true" >                                                            
<CellStyle Font-Bold="True"></CellStyle>            
                                <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                <PropertiesTextEdit DisplayFormatString="$ #,##0.00####" />                   
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="NOTAS" VisibleIndex="6" Caption="Observaciones" Visible="false"   />     
                            <dx:GridViewDataTextColumn UnboundType="String" Caption=" " 
                                FieldName="COMENTARIO"  VisibleIndex="7" CellStyle-ForeColor="Red" >  
<CellStyle ForeColor="Red"></CellStyle>
                            </dx:GridViewDataTextColumn>
                        </Columns>
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
                            <AlternatingRow Enabled = "True" />
                            <LoadingPanel ImageSpacing="5px">
                            </LoadingPanel>
                        </Styles>
                        <SettingsPager  Mode="ShowAllRecords"  >                        
                        </SettingsPager>
                        <StylesEditors ButtonEditCellSpacing="0">
                            <ProgressBar Height="21px">
                            </ProgressBar>
                        </StylesEditors>
                    </dx:ASPxGridView>
                              
        </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>
<dx:ASPxLoadingPanel ID="LoadingPanel" runat="server" ClientInstanceName="LoadingPanel" Text="Cargando..."  Modal="True" />