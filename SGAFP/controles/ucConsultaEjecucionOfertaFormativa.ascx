<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucConsultaEjecucionOfertaFormativa.ascx.vb" Inherits="controles_ucConsultaEjecucionOfertaFormativa" %>
<%@ Register assembly="DevExpress.Web.ASPxPivotGrid.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPivotGrid" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v11.1.Export, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPivotGrid.Export" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagName="ucListaACCION_FORMATIVA_HIST" Src="~/controles/ucListaACCION_FORMATIVA_HIST.ascx" TagPrefix="uc1" %>

<dx:ASPxCallbackPanel ID="CallbackPanel" runat="server" ClientInstanceName="ucConsultaEjecucionOfertaFormativa_CallbackPanel" Width="100%" LoadingPanelText="Cargando..."  >    
    <PanelCollection>     
    <dx:PanelContent ID="PanelContent1" runat="server">        
        <table style=" font-family:Verdana,Arial; font-size:8pt; font-weight:bold" >
        <tr>
            <td>
                Exportar a:
            </td>
            <td>            
                <dx:ASPxComboBox runat="server" ID="cbxExportar" Width="100px"  
                        ValueType="System.Int32" SelectedIndex="0" ClientInstanceName="cbxExportar" 
                        CssFilePath="~/App_Themes/Aqua/{0}/styles.css" CssPostfix="Aqua" 
                        LoadingPanelImagePosition="Top" ShowShadow="False" 
                        SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small" >                   
                    <Items>
                        <dx:ListEditItem Text="Excel" Value="0" />
                        <dx:ListEditItem Text="Pdf" Value="1" />                                    
                    </Items>                                   
                    <LoadingPanelImage Url="~/App_Themes/Aqua/Editors/Loading.gif">
                    </LoadingPanelImage>
                    <DropDownButton>
                        <Image>
                            <SpriteProperties HottrackedCssClass="dxEditors_edtDropDownHover_Aqua" 
                                PressedCssClass="dxEditors_edtDropDownPressed_Aqua" />
                        </Image>
                    </DropDownButton>
                    <ValidationSettings>
                        <ErrorFrameStyle ImageSpacing="4px">
                            <ErrorTextPaddings PaddingLeft="4px" />
                        </ErrorFrameStyle>
                    </ValidationSettings>
                </dx:ASPxComboBox>                
            </td>
            <td>
                <dx:ASPxButton runat="server" ID="btnExportar"  OnClick="btnExportar_Click"
                    AutoPostBack="True" UseSubmitBehavior="False" Image-Url = "~/imagenes/exportar.gif" 
                    CssFilePath="~/App_Themes/Aqua/{0}/styles.css" CssPostfix="Aqua" Image-AlternateText="Exportar"  
                    SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" 
                    Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small" ImagePosition="Right" >                                                                
<Image AlternateText="Exportar" Url="~/imagenes/exportar.gif"></Image>
                </dx:ASPxButton>
            </td>
        </tr>        
    </table>
          <dx:ASPxPivotGrid ID="pgLista" runat="server" ClientInstanceName="" Width = "100%" >
             <Fields>                                            
                 <dx:PivotGridField ID="fieldEJERCICIO" Area="ColumnArea" AreaIndex="0" 
                     Caption="Ejercicio" FieldName="ID_EJERCICIO"
                     UnboundFieldName="fieldEJERCICIO" />         
                 <dx:PivotGridField ID="fieldGENERO" Area="ColumnArea" AreaIndex="1" 
                     Caption="Genero" FieldName="GENERO"  
                     UnboundFieldName="fieldGENERO" /> 
                 <dx:PivotGridField ID="fieldPROVEEDOR" Area="FilterArea" AreaIndex="0" Caption="Institución" FieldName="NOMBRE_PROVEEDOR" />
                 <dx:PivotGridField ID="fieldCENTRO" Area="FilterArea" AreaIndex="1" Caption="Centro" FieldName="NOMBRE_SITIO" />
                 <dx:PivotGridField ID="fieldAREA" Area="FilterArea" AreaIndex="2" Caption="Area de Formación" FieldName="AREA_FORMACION" />
                 <dx:PivotGridField ID="fieldID" Area="FilterArea" AreaIndex="3" Caption="ID" FieldName="" SummaryDisplayType="AbsoluteVariation" UnboundType="String" />                                                                    
                 <dx:PivotGridField ID="fieldCURSO" Area="FilterArea" AreaIndex="5" Caption="Acción Formativa" FieldName="NOMBRE_ACCION_FORMATIVA" />
                 <dx:PivotGridField ID="fieldGRUPO" Area="FilterArea" AreaIndex="6" Caption="Grupo" FieldName="CODIGO_GRUPO" />                 
                 <dx:PivotGridField ID="fieldHORARIO" Area="FilterArea" AreaIndex="7" Caption="Horario" FieldName="HORARIO" /> 
                 <dx:PivotGridField ID="fieldHORARIO_X_DIA" Area="FilterArea" AreaIndex="8" Caption=" " FieldName="" SummaryDisplayType="AbsoluteVariation" UnboundType="String" />                                                              
                 <dx:PivotGridField ID="fieldINICIO" Area="FilterArea" AreaIndex="9" Caption="Inicio" FieldName="FECHA_INICIO_REAL" ValueFormat-FormatString="dd/MM/yyyy" ValueFormat-FormatType="DateTime"  />                              
                 <dx:PivotGridField ID="fieldFINALIZACION" Area="FilterArea" AreaIndex="10" Caption="Finalización" FieldName="FECHA_FIN_REAL" ValueFormat-FormatString="dd/MM/yyyy" ValueFormat-FormatType="DateTime"/>         
                 
                 <dx:PivotGridField ID="fieldCOSTO_X_PARTICIPANTE" Area="FilterArea" 
                     AreaIndex="11" Caption="Costo por participante" FieldName="COSTO_X_PARTICIPANTE" 
                     ValueStyle-HorizontalAlign="Right" ValueFormat-FormatString="$#,###,##0.00" 
                     ValueFormat-FormatType="Numeric"  >
<ValueStyle HorizontalAlign="Right"></ValueStyle>
                 </dx:PivotGridField>
                 <dx:PivotGridField ID="fieldDURACION_HORAS" Area="FilterArea" AreaIndex="12" 
                     Caption="Duracion (horas)" FieldName="DURACION_HORAS" 
                     ValueStyle-HorizontalAlign="Right"  >
                 
<ValueStyle HorizontalAlign="Right"></ValueStyle>
                 </dx:PivotGridField>
                 
                 <dx:PivotGridField ID="fieldDIRECCION" Area="FilterArea" AreaIndex="13" Caption="Dirección" FieldName="DIRECCION" />
                 <dx:PivotGridField ID="fieldENCARGADO" Area="FilterArea" AreaIndex="14" Caption="Contacto" FieldName="ENCARGADO" />
                 <dx:PivotGridField ID="fieldTELCONTACTO" Area="FilterArea" AreaIndex="15" Caption="Telefono" FieldName="TELEFONO_ENCARGADO" />
                 <dx:PivotGridField ID="fieldPORCENTAJEEJEC" Area="FilterArea" AreaIndex="16" Caption="Ejecución" FieldName="PORCENTAJEEJEC"  />                              
                 <dx:PivotGridField ID="fieldESTADO" Area="FilterArea" AreaIndex="17" Caption="Estado" FieldName="NOMBRE_ESTADO_AF"  />                              
                 <dx:PivotGridField ID="fieldNOTAS" Area="FilterArea" AreaIndex="18" Caption="Instructor" FieldName="NOTAS"  />                              
                 
                <dx:PivotGridField ID="Area1" Area="FilterArea" AreaIndex="19" Caption="N° Cursos" FieldName="ID_ACCION_FORMATIVA" SummaryType="Count" >                   
                    <cellformat formatstring="#,###,##0" formattype="Numeric" />
                 </dx:PivotGridField>
                 <dx:PivotGridField ID="Area2" Area="DataArea" AreaIndex="1" Caption="Inscritos" FieldName="PARTICIPANTES_INSCRITOS" SummaryType="Sum" >                   
                    <cellformat formatstring="#,###,##0" formattype="Numeric" />
                 </dx:PivotGridField>         
                 <dx:PivotGridField ID="Area3" Area="DataArea" AreaIndex="2" Caption="Costo" FieldName="COSTO_TOTAL" SummaryType="Sum" />          
             </Fields>       
             <OptionsView ShowRowTotals="False" />                                       
             <OptionsCustomization AllowDrag="True" />                                           
             <Styles CssFilePath="~/App_Themes/Aqua/{0}/styles.css"  
                 CssPostfix="Aqua">
                 <HeaderStyle>
                 <HoverStyle>
                     <BackgroundImage ImageUrl="~/App_Themes/Aqua/PivotGrid/pgHeaderBackHot.gif" 
                         Repeat="RepeatX" />
                 </HoverStyle>
                 <Paddings PaddingBottom="4px" PaddingLeft="5px" PaddingRight="5px" 
                     PaddingTop="4px" />
                 <BackgroundImage ImageUrl="~/App_Themes/Aqua/PivotGrid/pgHeaderBack.gif" 
                     Repeat="RepeatX" />
                 </HeaderStyle>
                 <FilterAreaStyle>
                     <Paddings PaddingBottom="3px" PaddingTop="3px" />
                     <BackgroundImage ImageUrl="~/App_Themes/Aqua/PivotGrid/pgFilterAreaBack.gif" 
                         Repeat="RepeatX" />
                 </FilterAreaStyle>
                 <FieldValueStyle>
                     <Paddings PaddingBottom="3px" PaddingTop="3px" />
                 </FieldValueStyle>
                 <FilterButtonPanelStyle>
                     <BackgroundImage ImageUrl="~/App_Themes/Aqua/PivotGrid/pgFilterPanelBack.gif" 
                         Repeat="RepeatX" />
                 </FilterButtonPanelStyle>
                 <MenuStyle GutterWidth="0px" />
                 <CustomizationFieldsHeaderStyle ForeColor="#5A5A5A">
                 </CustomizationFieldsHeaderStyle>
             </Styles>
             <Images SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css">
                 <CustomizationFieldsBackground Url="~/App_Themes/Aqua/PivotGrid/pgCustomizationFormBackground.gif">
                 </CustomizationFieldsBackground>
                 <LoadingPanel Url="~/App_Themes/Aqua/PivotGrid/Loading.gif">
                 </LoadingPanel>
             </Images>
             <OptionsLoadingPanel Text="Cargando. Por favor espere..." >
                 <Image Url="~/App_Themes/Aqua/PivotGrid/Loading.gif">         
                 </Image>         
             </OptionsLoadingPanel>
             <OptionsPager>
                <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" Text="Pag. {0} de {1} ({2} registros)" /> 
             </OptionsPager>                                                                                                        
        </dx:ASPxPivotGrid>
        <dx:ASPxPivotGridExporter ID="ASPxPivotGridExporter1" runat="server" ASPxPivotGridID="pgLista" /> 
        <dx:ASPxHiddenField runat="server" ClientInstanceName="hfParametros" ID="hfParametros" />        
   </dx:PanelContent>
   </PanelCollection>
</dx:ASPxCallbackPanel>

<dx:ASPxCallbackPanel ID="CallbackPanelPopup" runat="server" ClientInstanceName="CallbackPanelPopup" Width="100%" LoadingPanelText="Cargando..."  >    
    <PanelCollection>
    <dx:PanelContent ID="PanelContent2" runat="server">  
        <dx:ASPxPopupControl ID="popupHistorico" Modal="true" runat="server" 
                PopupHorizontalAlign="Center" PopupVerticalAlign="Middle" Width="950px"  
                Left="260" Top="200" AllowResize="True" DragElement="Window"   
                AllowDragging="True" ClientInstanceName="popupHistorico" 
                CloseAction="CloseButton" HeaderText="Histórico de Acción Formativa"
                CssFilePath="~/App_Themes/Aqua/{0}/styles.css" CssPostfix="Aqua" 
                SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css">  
             <ContentCollection>
                 <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server" >
                    <uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server" PermitirExportarAExcel = "true" GridViewControlName="dxgvLista"   />
                    <uc1:ucListaACCION_FORMATIVA_HIST ID="ucListaACCION_FORMATIVA_HIST1" runat="server" PermitirEditar="False"
                        PermitirEliminar="False" PermitirPaginacion="True" PermitirSeleccionar="False" 
                        VerCODIGO_ESTADO_AF="False" VerCOSTO_X_PARTICIPANTE="False" VerID_EJERCICIO="False"
                        VerID_OFERTA_FORMATIVA="False" VerID_PROVEEDOR_AF="False" VerID_SITIO_CAPACITACION="False"
                        VerID_TEMA_CURSO="False" VerNOTAS="False" VerID_ACCION_FORMATIVA="False" 
                        VerNUMERO_PARTICIPANTES ="False" VerDURACION_HORAS = "False" VerPARTICIPANTES_INSCRITOS="False" VerOBSERVACIONES="True"
                         VerNOMBRE_ACCION_FORMATIVA = "False" VerCODIGO_GRUPO="True"  
                          />    
                 </dx:PopupControlContentControl>
             </ContentCollection>
        </dx:ASPxPopupControl>     
        <dx:ASPxPopupControl ID="popupHorarioAFDetalle" Modal="true" runat="server" 
                PopupHorizontalAlign="WindowCenter"  PopupVerticalAlign="WindowCenter" Width="569px"  
                Left="260" Top="200" AllowResize="True" DragElement="Window"   
                AllowDragging="True" ClientInstanceName="popupHorarioAFDetalle" 
                CloseAction="CloseButton" HeaderText="Horario por día"
                CssFilePath="~/App_Themes/Aqua/{0}/styles.css" CssPostfix="Aqua" 
                SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css">  
             <ContentCollection>
                 <dx:PopupControlContentControl ID="PopupControlContentControl2" runat="server" >
                    <table width="100%" style="font-family:Verdana; font-size:xx-small" >
                        <tr align="left">
                            <td style="width:50px; background-color:#E2F0FF; border-color:#A3C0E8; border-style:solid; border-width:1px">ID</td>
                            <td style="background-color:#E2F0FF; border-color:#A3C0E8; border-style:solid; border-width:1px">CURSO</td>
                            <td style="background-color:#E2F0FF; border-color:#A3C0E8; border-style:solid; border-width:1px">GRUPO</td>
                        </tr>
                        <tr align="left">
                            <td><dx:ASPxLabel ID="lblID_ACCION_FORMATIVA" runat="server" Font-Names="Verdana" Font-Size="XX-Small"></dx:ASPxLabel></td>
                            <td><dx:ASPxLabel ID="lblNOMBRE_ACCION_FORMATIVA" runat="server" Font-Names="Verdana" Font-Size="XX-Small"></dx:ASPxLabel></td>
                            <td><dx:ASPxLabel ID="lblCODIGO_GRUPO" runat="server" Font-Names="Verdana" Font-Size="XX-Small"></dx:ASPxLabel></td>
                        </tr>
                        <tr align="left">                            
                            <td colspan="3" style="background-color:#E2F0FF; border-color:#A3C0E8; border-style:solid; border-width:1px">HORARIO POR DIA</td>
                        </tr>
                        <tr align="left">                            
                            <td colspan="3"><dx:ASPxLabel ID="lblHORARIO_POR_DIA" runat="server" Font-Names="Verdana" Font-Size="XX-Small" ></dx:ASPxLabel></td>
                        </tr>
                    </table>
                 </dx:PopupControlContentControl>
             </ContentCollection>
        </dx:ASPxPopupControl>        
    </dx:PanelContent>
    </PanelCollection>
    <ClientSideEvents EndCallback="function(s, e) {
                                            if(postponedCallbackValuePopup != null) {                                                
                                                CallbackPanelPopup.PerformCallback(postponedCallbackValuePopup);
                                                postponedCallbackValuePopup = null;
                                            }                                            
                                            if(s.cpResultCallback != undefined){
                                                switch(s.cpResultCallback){
                                                    case 'MostrarHistoricoAF':
                                                        popupHistorico.Show();
                                                        break;
                                                    case 'MostrarHorarioPorDia':
                                                        popupHorarioAFDetalle.Show();
                                                        break;
                                                }
                                            }
                                            
                                   }" /> 
</dx:ASPxCallbackPanel>

<asp:ObjectDataSource ID="odsEjecucionOfertaFormativa" runat="server" OldValuesParameterFormatString="original_{0}" 
    SelectMethod="ObtenerEjecucionOfertaFormativa" EnableCaching="true"
    TypeName="SGAFP.BL.cACCION_FORMATIVA">
    <SelectParameters>       
        <asp:Parameter Name="TIPO_CONSULTA" Type="Int16"  />                                                    
        <asp:Parameter Name="ID_EJERCICIO" Type="String" />     
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />     
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal"  />             
        <asp:Parameter Name="CODIGO_GRUPO" Type="String" />     
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal"  />   
    </SelectParameters>
</asp:ObjectDataSource> 

