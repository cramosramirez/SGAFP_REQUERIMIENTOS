<%@ Page Title="" Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfConsultaEjecucionOferta.aspx.vb" Inherits="GFI_wfConsultaEjecucionOferta" %>
<%@ Register TagPrefix="uc1" TagName="ucConsultaEjecucionOferta" Src="~/controles/ucConsultaEjecucionOferta.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucConsultaRecursosAsignados" Src="~/controles/ucConsultaRecursosAsignados.ascx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxTabControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxClasses" tagprefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v11.1.Export, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPivotGrid.Export" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallback" TagPrefix="dx" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">   
    <script type="text/javascript" language="javascript" >
        function SetTodos(s, e) {            
            s.SetText('[Todos]');
        }
    </script>
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
                        SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" >                   
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
                <dx:ASPxButton runat="server" ID="btnExportar" Text="Exportar" OnClick="btnExportar_Click" 
                    AutoPostBack="True" UseSubmitBehavior="False" 
                    CssFilePath="~/App_Themes/Aqua/{0}/styles.css" CssPostfix="Aqua" 
                    SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" />                                                                
            </td>
        </tr>        
    </table>
    
    <dx:ASPxPageControl ID="TabReportes" runat="server" ActiveTabIndex="0" ClientInstanceName="TabReportes" 
        EnableHierarchyRecreation="True" Height="250" Width="100%"
        CssFilePath="~/App_Themes/Aqua/{0}/styles.css" 
        CssPostfix="Aqua" >    
        <LoadingPanelImage Url="~/App_Themes/Aqua/Web/Loading.gif">
        </LoadingPanelImage>
        <ContentStyle>
            <Border BorderColor="#4E4F51" BorderStyle="Dotted" BorderWidth="1px" />
        </ContentStyle>
        <TabPages>                
         <dx:TabPage Text="Ejecución de Oferta">
            <ContentCollection>              
                <dx:ContentControl runat="server">
                    <table cellpadding="0" cellspacing="5" border="0" >
                        <tr>
                            <td>
                                <dx:ASPxLabel ID="lblProveedor" runat="server" Text="Proveedor:" Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small" />
                            </td>
                            <td>
                                <dx:ASPxComboBox runat="server" ID="cbxProveedor" DropDownStyle="DropDownList"
                                    DataSourceID="odsProveedor" TextField="NOMBRE_PROVEEDOR" 
                                    ValueField="ID_PROVEEDOR_AF" ClientInstanceName="cbxProveedor" 
                                    CssFilePath="~/App_Themes/Aqua/{0}/styles.css" 
                                    CssPostfix="Aqua" LoadingPanelImagePosition="Top" ShowShadow="False" 
                                    SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" 
                                    Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small">
                                     <ClientSideEvents SelectedIndexChanged="function(s,e){                                                                                                                                                                      
                                                         cbxCentroFormacion.PerformCallback(cbxProveedor.GetValue().toString());                                                                                                                
                                                         }" />
                                     <LoadingPanelImage Url="~/App_Themes/Aqua/Editors/Loading.gif">
                                     </LoadingPanelImage>
                                     <DropDownButton>
                                         <Image>
                                             <SpriteProperties HottrackedCssClass="dxEditors_edtDropDownHover_Aqua" PressedCssClass="dxEditors_edtDropDownPressed_Aqua" />
                                         </Image>
                                     </DropDownButton>
                                     <ValidationSettings>
                                         <ErrorFrameStyle ImageSpacing="4px">
                                             <ErrorTextPaddings PaddingLeft="4px" />
                                         </ErrorFrameStyle>
                                     </ValidationSettings>
                                </dx:ASPxComboBox>
                                <asp:ObjectDataSource ID="odsProveedor" runat="server" 
                                    OldValuesParameterFormatString="original_{0}"
                                    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cPROVEEDOR_AF">
                                    <SelectParameters>            
                                        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
                                        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />        
                                        <asp:Parameter DefaultValue="NOMBRE_PROVEEDOR" Name="asColumnaOrden" Type="String" />
                                        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>
                            </td>
                            <td>          
                                <dx:ASPxLabel ID="lblCentro" runat="server" Text="Centro:" Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small" />    
                            </td>                            
                            <td>
                                <dx:ASPxComboBox runat="server" ID="cbxCentroFormacion"  
                                    DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" 
                                    DataSourceID="odsCentroFormacion" TextField="NOMBRE_SITIO" OnCallback="cbxCentroFormacion_Callback"  
                                    ValueField="ID_SITIO_CAPACITACION" ClientInstanceName="cbxCentroFormacion"  
                                    CssFilePath="~/App_Themes/Aqua/{0}/styles.css" 
                                    CssPostfix="Aqua" LoadingPanelImagePosition="Top" ShowShadow="False" 
                                    SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" 
                                    Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small">                                      
                                    <ClientSideEvents EndCallback="SetTodos" />                               
                                     <LoadingPanelImage Url="~/App_Themes/Aqua/Editors/Loading.gif">
                                     </LoadingPanelImage>
                                     <DropDownButton>
                                         <Image>
                                             <SpriteProperties HottrackedCssClass="dxEditors_edtDropDownHover_Aqua" PressedCssClass="dxEditors_edtDropDownPressed_Aqua" />
                                         </Image>
                                     </DropDownButton>
                                     <ValidationSettings>
                                         <ErrorFrameStyle ImageSpacing="4px">
                                             <ErrorTextPaddings PaddingLeft="4px" />
                                         </ErrorFrameStyle>
                                     </ValidationSettings>
                                </dx:ASPxComboBox>
                                <asp:ObjectDataSource ID="odsCentroFormacion" runat="server" 
                                    OldValuesParameterFormatString="original_{0}"
                                    SelectMethod="ObtenerListaPorPROVEEDOR_AF" TypeName="SGAFP.BL.cSITIO_CAPACITACION">
                                    <SelectParameters>            
                                        <asp:Parameter DefaultValue="" Name="ID_PROVEEDOR_AF" Type="Decimal" />
                                        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
                                        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />        
                                        <asp:Parameter DefaultValue="NOMBRE_SITIO" Name="asColumnaOrden" Type="String" />
                                        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>
                            </td>
                            <td>
                                <dx:ASPxLabel ID="lblCodigoGrupo" runat="server" Text="Codigo Grupo:" Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small" />
                            </td>
                            <td>
                                <dx:ASPxTextBox ID="txtCodigoGrupo" ClientInstanceName="txtCodigoGrupo"  
                                    runat="server" Width="120px" Font-Names="Verdana,Arial,Tahoma" 
                                    Font-Size="X-Small" CssFilePath="~/App_Themes/Aqua/{0}/styles.css" 
                                    CssPostfix="Aqua" SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css">
                                    <ValidationSettings>
                                        <ErrorFrameStyle ImageSpacing="4px">
                                            <ErrorTextPaddings PaddingLeft="4px" />
                                        </ErrorFrameStyle>
                                    </ValidationSettings>
                                     <ClientSideEvents TextChanged="function(s, e) {
                                            s.SetText(s.GetText().toUpperCase());
                                            }" />
                                </dx:ASPxTextBox>
                            </td>
                            <td>
                            <dx:ASPxButton runat="server" ID="btnMostrar1" Text="Mostrar" AutoPostBack="false" UseSubmitBehavior="false"
                                CssFilePath="~/App_Themes/Aqua/{0}/styles.css" CssPostfix="Aqua" Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small"
                                SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" >                                       
                                <ClientSideEvents Click="function(s,e) {                                                                                      
                                          CallbackPanel.PerformCallback(cbxEjecucion.GetValue() + ';' + cbxEjercicio1.GetValue() + ';' + cbxProveedor.GetValue() + ';' + cbxCentroFormacion.GetValue() + ';' + txtCodigoGrupo.GetValue() ) }" />
                            </dx:ASPxButton> 
                            </td>
                        </tr> 
                        <tr>
                            <td>
                            <dx:ASPxLabel ID="lblCursos" runat="server" Text="Cursos:" Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small" />
                            </td>
                            <td>
                            <dx:ASPxComboBox runat="server" ID="cbxEjecucion" Width="100px"  ValueType="System.Int32" 
                                SelectedIndex="0" ClientInstanceName="cbxEjecucion" 
                                CssFilePath="~/App_Themes/Aqua/{0}/styles.css" CssPostfix="Aqua" 
                                LoadingPanelImagePosition="Top" ShowShadow="False" Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small"
                                SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" > 
                                <Items>
                                    <dx:ListEditItem Text="[Todos]" Value="0" />
                                    <dx:ListEditItem Text="Por Iniciar" Value="1" />
                                    <dx:ListEditItem Text="En Ejecución" Value="2" />
                                    <dx:ListEditItem Text="Finalizados" Value="3" />
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
                            <dx:ASPxLabel ID="lblEjercicio" runat="server" Text="Ejercicio:" Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small" />
                            </td>
                            <td>
                            <dx:ASPxComboBox runat="server" ID="cbxEjercicio1" Width="100px" DataSourceID="odsEjercicio" 
                                ClientInstanceName="cbxEjercicio1" ValueType="System.String" ValueField="ID_EJERCICIO" TextField="ID_EJERCICIO"
                                CssFilePath="~/App_Themes/Aqua/{0}/styles.css" CssPostfix="Aqua" 
                                LoadingPanelImagePosition="Top" ShowShadow="False" Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small"
                                SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" >                                                       
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
                            <td> </td>
                            <td> </td>
                            <td> </td>
                         </tr>                                  
                    </table>    
                    <table width="100%" cellpadding="0" cellspacing="5" style="margin-top: 4px">
                        <tr>
                           <td>
                           <uc1:ucConsultaEjecucionOferta id="ucConsultaEjecucionOferta1" runat="server" />    
                                                   
                            <asp:ObjectDataSource ID="odsEjercicio" runat="server" EnableCaching="True" 
                                OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cEJERCICIO">
                                <SelectParameters>       
                                    <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="String" />
                                    <asp:Parameter DefaultValue="ID_EJERCICIO" Name="asColumnaOrden" Type="String" />
                                    <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
                                </SelectParameters>
                            </asp:ObjectDataSource>         
                           </td>
                        </tr>
                    </table>                   
                </dx:ContentControl>
            </ContentCollection>
         </dx:TabPage>         
         
         
         
         
         
         
         
         
         <dx:TabPage Text="Recursos asignados">
            <ContentCollection>
                <dx:ContentControl runat="server" > 
                    <table width="300px" cellpadding="0" cellspacing="5" style="margin-top: 4px">
                        <tr>                            
                            <td>
                            Ejercicio:
                            </td>
                            <td>
                            <dx:ASPxComboBox runat="server" ID="cbxEjercicio2" Width="100px" DataSourceID="odsEjercicio" ClientInstanceName="cbxEjercicio2"  
                                ValueType="System.String" ValueField="ID_EJERCICIO" TextField="ID_EJERCICIO" 
                                CssFilePath="~/App_Themes/Aqua/{0}/styles.css" CssPostfix="Aqua" 
                                LoadingPanelImagePosition="Top" ShowShadow="False" 
                                SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" />                             
                            </td>
                            <td>
                            <dx:ASPxButton runat="server" ID="btnMostrar2" Text="Mostrar" AutoPostBack="false" UseSubmitBehavior="false"
                            CssFilePath="~/App_Themes/Aqua/{0}/styles.css" CssPostfix="Aqua" 
                            SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" >
                                <ClientSideEvents Click="function(s) { pgRecursos.PerformCallback(cbxEjercicio2.GetValue()) }" />
                            </dx:ASPxButton>
                            </td>
                         </tr>                                  
                    </table>    
                    <table width="100%" cellpadding="0" cellspacing="5" style="margin-top: 4px">
                        <tr>
                           <td>
                           <uc1:ucConsultaRecursosAsignados id="ucConsultaRecursosAsignados1" runat="server" />  
                           </td>
                        </tr>
                    </table>
                </dx:ContentControl>
            </ContentCollection>
         </dx:TabPage>      
        </TabPages>
    </dx:ASPxPageControl>  
    <dx:ASPxPivotGridExporter ID="ASPxPivotGridExporter1" runat="server" Visible="False" /> 
</asp:Content>