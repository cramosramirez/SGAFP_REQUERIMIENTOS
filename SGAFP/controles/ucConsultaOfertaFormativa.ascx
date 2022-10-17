<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucConsultaOfertaFormativa.ascx.vb" Inherits="controles_ucConsultaOfertaFormativa" %>
<%@ Register assembly="DevExpress.Web.ASPxPivotGrid.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPivotGrid" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v11.1.Export, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPivotGrid.Export" TagPrefix="dx" %>

<dx:ASPxCallbackPanel ID="CallbackPanel" runat="server" ClientInstanceName="ucConsultaOfertaFormativa_CallbackPanel" Width="100%" LoadingPanelText="Cargando..."  >    
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
                 <dx:PivotGridField ID="fieldPROVEEDOR" Area="RowArea" AreaIndex="0" Caption="Institución" FieldName="NOMBRE_PROVEEDOR" />
                 <dx:PivotGridField ID="fieldCENTRO" Area="RowArea" AreaIndex="1" Caption="Centro" FieldName="NOMBRE_SITIO" />
                 <dx:PivotGridField ID="fieldAREA" Area="RowArea" AreaIndex="2" Caption="Area de Formación" FieldName="AREA_FORMACION" />                 
                 <dx:PivotGridField ID="fieldCONTRATO" Area="RowArea" AreaIndex="3" Caption="Contrato" FieldName="CONTRATO" />                 
                 <dx:PivotGridField ID="fieldCURSO" Area="RowArea" AreaIndex="4" Caption="Oferta Formativa" FieldName="TEMA_CURSO" />
                 <dx:PivotGridField ID="fieldDURACION_HORAS" Area="RowArea" AreaIndex="5" Caption="Duracion (Horas)" FieldName="DURACION_HORAS" />
                 <dx:PivotGridField ID="fieldCOSTO_X_PARTICIPANTE" Area="RowArea" AreaIndex="6" 
                     Caption="Costo por participante" FieldName="COSTO_X_PARTICIPANTE"
                     ValueStyle-HorizontalAlign="Right" ValueFormat-FormatString="$#,###,##0.00" 
                     ValueFormat-FormatType="Numeric" >                            
<ValueStyle HorizontalAlign="Right"></ValueStyle>
                 </dx:PivotGridField>
                 <dx:PivotGridField ID="fieldDEPARTAMENTO" Area="RowArea" AreaIndex="6" Caption="Departamento" FieldName="NOMBRE_DEPARTAMENTO"   />
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
<asp:ObjectDataSource ID="odsOfertaFormativa" runat="server" OldValuesParameterFormatString="original_{0}" 
    SelectMethod="ObtenerOfertaFormativa" EnableCaching="true"
    TypeName="SGAFP.BL.cOFERTA_FORMATIVA">
    <SelectParameters>       
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />     
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal"  />             
        <asp:Parameter Name="ID_EJERCICIO" Type="String" />     
        <asp:Parameter Name="ID_AREA_FORMACION" Type="Decimal"  />             
    </SelectParameters>
</asp:ObjectDataSource>   