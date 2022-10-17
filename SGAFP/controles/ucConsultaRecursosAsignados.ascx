<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucConsultaRecursosAsignados.ascx.vb" Inherits="controles_ucConsultaRecursosAsignados" %>
<%@ Register assembly="DevExpress.Web.ASPxPivotGrid.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPivotGrid" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

<dx:ASPxPivotGrid ID="pgRecursos" runat="server" Width = "100%" ClientInstanceName="pgRecursos" OnCustomCallback="pgRecursos_CustomCallback" DataSourceID="odsRecursosAsignados"  >
     <Fields>                                       
         <dx:PivotGridField ID="fieldPROVEEDOR" Area="RowArea" AreaIndex="0" Caption="Institución" FieldName="NOMBRE_PROVEEDOR" />
         <dx:PivotGridField ID="fieldRECURSOS" Area="DataArea" AreaIndex="0" Caption="Recurso asignado" FieldName="RECURSOS" SummaryType="Sum" />         
         <dx:PivotGridField ID="fieldEJECUCION" Area="DataArea" AreaIndex="2" Caption="En Ejecucion" FieldName="EJECUCION" SummaryType="Sum" />
         <dx:PivotGridField ID="fieldFINALIZADO" Area="DataArea" AreaIndex="3" Caption="Finalizado" FieldName="FINALIZADO" SummaryType="Sum"  />                                        
         <dx:PivotGridField ID="fieldTOTAL" Area="DataArea" AreaIndex="4" Caption="A Iniciar" FieldName="" SummaryType="Sum" UnboundType="Decimal" />
     </Fields>               
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
<asp:ObjectDataSource ID="odsRecursosAsignados" runat="server"
    OldValuesParameterFormatString="original_{0}" SelectMethod="GetDataByEjercicio" 
    TypeName="SGAFP.DL.DS_DLTableAdapters.RecursosAsignadosProveedorTableAdapter">
    <SelectParameters>       
        <asp:Parameter Name="ID_EJERCICIO" Type="String" DefaultValue="" />                                                    
    </SelectParameters>
</asp:ObjectDataSource>    

<asp:ObjectDataSource ID="odsRecursosAsignadosProveedor" runat="server"
    OldValuesParameterFormatString="original_{0}" SelectMethod="GetDataByEjercicioProveedor" 
    TypeName="SGAFP.DL.DS_DLTableAdapters.RecursosAsignadosProveedorTableAdapter">
    <SelectParameters>       
        <asp:Parameter Name="ID_EJERCICIO" Type="String" DefaultValue="" />                                                    
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" DefaultValue="-1" />                                                    
    </SelectParameters>
</asp:ObjectDataSource> 
  


