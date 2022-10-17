<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucConsultaEjecucionCursosPATI.ascx.vb" Inherits="controles_ucConsultaEjecucionCursosPATI" %>
<%@ Register assembly="DevExpress.Web.ASPxPivotGrid.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPivotGrid" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v11.1.Export, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPivotGrid.Export" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<%@ Register TagName="ucListaACCION_FORMATIVA_HIST" Src="~/controles/ucListaACCION_FORMATIVA_HIST.ascx" TagPrefix="uc1" %>

<%@ Register src="ucCriteriosConsultaEjecucionPATI.ascx" tagname="ucCriteriosConsultaEjecucionPATI" tagprefix="uc2" %>

<uc2:ucCriteriosConsultaEjecucionPATI ID="ucCriteriosConsultaEjecucionPATI1" runat="server" />
<dx:ASPxCallbackPanel ID="CallbackPanel" runat="server" ClientInstanceName="ucCECPATI_CP" Width="100%" LoadingPanelText="Cargando..."  >    
    <PanelCollection>     
    <dx:PanelContent ID="PanelContent1" runat="server">        
          <dx:ASPxPivotGrid ID="pgLista" runat="server" ClientInstanceName="" 
            Width = "100%" DataSourceID="odsEjecucionCursosPATI" >
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
                 <dx:PivotGridField ID="fieldID" Area="FilterArea" AreaIndex="3" Caption="ID" 
                     FieldName="" SummaryDisplayType="AbsoluteVariation" UnboundType="String" 
                     UnboundFieldName="fieldID" />                                                                    
                 <dx:PivotGridField ID="fieldCURSO" Area="FilterArea" AreaIndex="4" 
                     Caption="Acción Formativa" FieldName="NOMBRE_ACCION_FORMATIVA" />
                 <dx:PivotGridField ID="fieldGRUPO" Area="FilterArea" AreaIndex="5" 
                     Caption="Grupo" FieldName="CODIGO_GRUPO" />                 
                 <dx:PivotGridField ID="fieldHORARIO" Area="FilterArea" AreaIndex="6" 
                     Caption="Horario" FieldName="HORARIO" /> 
                 <dx:PivotGridField ID="fieldHORARIO_X_DIA" Area="FilterArea" AreaIndex="7" 
                     Caption=" " FieldName="" SummaryDisplayType="AbsoluteVariation" 
                     UnboundType="String" UnboundFieldName="fieldHORARIO_X_DIA" />                                                              
                 <dx:PivotGridField ID="fieldINICIO" Area="FilterArea" AreaIndex="8" 
                     Caption="Inicio" FieldName="FECHA_INICIO_REAL" 
                     ValueFormat-FormatString="dd/MM/yyyy" ValueFormat-FormatType="DateTime"  />                              
                 <dx:PivotGridField ID="fieldFINALIZACION" Area="FilterArea" AreaIndex="9" 
                     Caption="Finalización" FieldName="FECHA_FIN_REAL" 
                     ValueFormat-FormatString="dd/MM/yyyy" ValueFormat-FormatType="DateTime"/>         
                 
                 <dx:PivotGridField ID="fieldCOSTO_X_PARTICIPANTE" Area="FilterArea" 
                     AreaIndex="10" Caption="Costo por participante" FieldName="COSTO_X_PARTICIPANTE" 
                     ValueStyle-HorizontalAlign="Right" ValueFormat-FormatString="$#,###,##0.00" 
                     ValueFormat-FormatType="Numeric"  >
<ValueStyle HorizontalAlign="Right"></ValueStyle>
                 </dx:PivotGridField>
                 <dx:PivotGridField ID="fieldDURACION_HORAS" Area="FilterArea" AreaIndex="11" 
                     Caption="Duracion (horas)" FieldName="DURACION_HORAS" 
                     ValueStyle-HorizontalAlign="Right"  >
                 
<ValueStyle HorizontalAlign="Right"></ValueStyle>
                 </dx:PivotGridField>
                 
                 <dx:PivotGridField ID="fieldDIRECCION" Area="FilterArea" AreaIndex="12" 
                     Caption="Dirección" FieldName="DIRECCION" />
                 <dx:PivotGridField ID="fieldENCARGADO" Area="FilterArea" AreaIndex="13" 
                     Caption="Contacto" FieldName="ENCARGADO" />
                 <dx:PivotGridField ID="fieldTELCONTACTO" Area="FilterArea" AreaIndex="14" 
                     Caption="Telefono" FieldName="TELEFONO_ENCARGADO" />
                 <dx:PivotGridField ID="fieldPORCENTAJEEJEC" Area="FilterArea" AreaIndex="15" 
                     Caption="Ejecución" FieldName="PORCENTAJEEJEC"  />                              
                 <dx:PivotGridField ID="fieldESTADO" Area="FilterArea" AreaIndex="16" 
                     Caption="Estado" FieldName="NOMBRE_ESTADO_AF"  />                              
                 <dx:PivotGridField ID="fieldNOTAS" Area="FilterArea" AreaIndex="17" 
                     Caption="Instructor" FieldName="NOTAS"  />                              
                 
                <dx:PivotGridField ID="Area1" Area="FilterArea" AreaIndex="18" 
                     Caption="N° Cursos" FieldName="ID_ACCION_FORMATIVA" SummaryType="Count" >                   
                    <cellformat formatstring="#,###,##0" formattype="Numeric" />
                 </dx:PivotGridField>
                 <dx:PivotGridField ID="Area2" Area="DataArea" AreaIndex="0" Caption="Inscritos" 
                     FieldName="PARTICIPANTES_INSCRITOS" SummaryType="Sum" >                   
                    <cellformat formatstring="#,###,##0" formattype="Numeric" />
                 </dx:PivotGridField>         
                 <dx:PivotGridField ID="Area3" Area="DataArea" AreaIndex="1" Caption="Costo" 
                     FieldName="COSTO_TOTAL" SummaryType="Sum" />          
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
<asp:ObjectDataSource ID="odsEjecucionCursosPATI" runat="server" OldValuesParameterFormatString="{0}" 
    SelectMethod="GetDataPorCursosProgramadosFechas" EnableCaching="True"
    TypeName="SGAFP.DL.DS_DLTableAdapters.PATIEjecucionTableAdapter">
    <SelectParameters>       
        <asp:Parameter Name="id_tipo_solicitud" Type="String" DefaultValue="0"  />                                                    
        <asp:Parameter Name="no_convocatoria" Type="String" DefaultValue="0" />     
        <asp:Parameter Name="fecha_inicio" Type="DateTime" />             
        <asp:Parameter Name="fecha_fin" Type="DateTime" />     
    </SelectParameters>
</asp:ObjectDataSource> 

