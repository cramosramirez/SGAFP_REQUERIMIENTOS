<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCriteriosConsultaEjecucion.ascx.vb" Inherits="controles_ucCriteriosConsultaEjecucion" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>

<script type="text/javascript" language="javascript" >
        function SetTodos(s) {            
            s.SetText('[Todos]');
        }
</script>
<table cellpadding="0" cellspacing="2" border="0" >
    <tr id="trPrograma" runat="server" >
        <td>
            <dx:ASPxLabel ID="lblPrograma" runat="server" Text="Programa:" Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small" />
        </td>
        <td>
            <dx:ASPxComboBox runat="server" ID="cbxTipoSolicitud" DropDownStyle="DropDownList"
                DataSourceID="odsTipoSolicitud" TextField="TIPO_SOLICITUD" LoadingPanelText="Cargando..."   
                ValueField="ID_TIPO_SOLICITUD" ClientInstanceName="cbxTipoSolicitud" ValueType="System.Int32"   
                CssFilePath="~/App_Themes/Aqua/{0}/styles.css" Width="315px" 
                CssPostfix="Aqua" LoadingPanelImagePosition="Top" ShowShadow="False" 
                SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" 
                Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small">
                 <ClientSideEvents SelectedIndexChanged="function(s,e){                        
                                                           if(cbxTipoSolicitud.GetValue().toString() == '1' ){
                                                                cbxCentroFormacion.SetEnabled(true);
                                                           }
                                                           else{                                                      
                                                                cbxCentroFormacion.SetEnabled(false);
                                                           }                  
                                                           cbxProveedor.PerformCallback(cbxTipoSolicitud.GetValue().toString());                                                                                                                                                                                                                                                             
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
        </td>
    </tr>
    <tr id="trProveedor" runat="server" >
        <td>
            <dx:ASPxLabel ID="lblProveedor" runat="server" Text="Proveedor:" Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small" />
        </td>
        <td>
            <dx:ASPxComboBox runat="server" ID="cbxProveedor" DropDownStyle="DropDownList"
                DataSourceID="odsProveedor" TextField="NOMBRE_PROVEEDOR" LoadingPanelText="Cargando..."   
                ValueField="ID_PROVEEDOR_AF" ClientInstanceName="cbxProveedor" ValueType="System.Int32"  
                CssFilePath="~/App_Themes/Aqua/{0}/styles.css" Width="315px" 
                CssPostfix="Aqua" LoadingPanelImagePosition="Top" ShowShadow="False" 
                SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" 
                Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small">
                 <ClientSideEvents SelectedIndexChanged="function(s,e){      
                                            if(typeof cbxCentroFormacion == 'undefined'){return;}                                                                                                                                                                                                                                           
                                             cbxCentroFormacion.PerformCallback(cbxProveedor.GetValue().toString()); 
                                     }"  />
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
        </td>
    </tr>
    <tr id="trCentroFormacion" runat="server">
        <td>          
            <dx:ASPxLabel ID="lblCentro" runat="server" Text="Centro:" Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small" />    
        </td>                            
        <td>
            <dx:ASPxComboBox runat="server" ID="cbxCentroFormacion"  
                DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" 
                DataSourceID="odsCentroFormacion" TextField="NOMBRE_SITIO" OnCallback="cbxCentroFormacion_Callback"  
                ValueField="ID_SITIO_CAPACITACION" ClientInstanceName="cbxCentroFormacion"  
                CssFilePath="~/App_Themes/Aqua/{0}/styles.css"  Width="315px" ValueType="System.Int32"  
                CssPostfix="Aqua" LoadingPanelImagePosition="Top" ShowShadow="False" 
                SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" 
                Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small">     
                <ClientSideEvents EndCallback="function(s,e){SetTodos(s)}" />                                                             
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
        </td>
    </tr>        
    <tr id="trEjercicio" runat="server">
        <td>
            <dx:ASPxLabel ID="lblEjercicio" runat="server" Text="Ejercicio:" Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small" />
        </td>
        <td>
            <dx:ASPxComboBox runat="server" ID="cbxEjercicio" Width="100px" DataSourceID="odsEjercicio" 
                ClientInstanceName="cbxEjercicio" ValueType="System.String" ValueField="ID_EJERCICIO" TextField="ID_EJERCICIO"
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
    </tr>
     <tr id="trAreaFormacion" runat="server">
        <td>          
            <dx:ASPxLabel ID="lblAreaFormacion" runat="server" Text="Area de Formación:" Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small" />    
        </td>                            
        <td>
            <dx:ASPxComboBox runat="server" ID="cbxAreaFormacion"  
                DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith" 
                DataSourceID="odsAreaFormacion" TextField="AREA_FORMACION"
                ValueField="ID_AREA_FORMACION" ClientInstanceName="cbxAreaFormacion"  
                CssFilePath="~/App_Themes/Aqua/{0}/styles.css"  Width="315px" 
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
        </td>
    </tr>        
    <tr id="trCodigoGrupo" runat="server">
        <td>
            <dx:ASPxLabel ID="lblCodigoGrupo" runat="server" Text="Codigo Grupo:" Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small" />
        </td>
        <td>
            <dx:ASPxTextBox ID="txtCodigoGrupo" ClientInstanceName="txtCodigoGrupo"  
                runat="server" Width="315px" Font-Names="Verdana,Arial,Tahoma" 
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
    </tr> 
    <tr id="trClasificacionCursos" runat="server">
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
     </tr>  
     <tr id="trMostrar" runat="server">
        <th colspan="2" align="right"  >
            <dx:ASPxButton runat="server" ID="btnMostrar" Text="Mostrar" AutoPostBack="false" UseSubmitBehavior="false"
            CssFilePath="~/App_Themes/Aqua/{0}/styles.css" CssPostfix="Aqua" Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small"
            SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" >                                       
            <ClientSideEvents Click="function(s,e) {                                                                                                         
                      CallbackPanel.PerformCallback(cbxEjecucion.GetValue() + ';' + cbxEjercicio.GetValue() + ';' + cbxProveedor.GetValue() + ';' + cbxCentroFormacion.GetValue() + ';' + txtCodigoGrupo.GetValue() ) }" />
        </dx:ASPxButton> 
        </th>        
     </tr>                                
</table>    
<dx:ASPxHiddenField runat="server" ID="hf" ClientInstanceName="hf" SyncWithServer="true" /> 

<asp:ObjectDataSource ID="odsTipoSolicitud" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cTIPO_SOLICITUD">
<SelectParameters>            
    <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
    <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />        
    <asp:Parameter DefaultValue="TIPO_SOLICITUD" Name="asColumnaOrden" Type="String" />
    <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
</SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsProveedor" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerListaProveedoresPorTipoSolicitud" TypeName="SGAFP.BL.cPROVEEDOR_AF">
<SelectParameters>                
    <asp:Parameter DefaultValue="1" Name="ID_TIPO_SOLICITUD" Type="Int32" />        
    <asp:Parameter DefaultValue="NOMBRE_PROVEEDOR" Name="asColumnaOrden" Type="String" />
    <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
</SelectParameters>
</asp:ObjectDataSource>
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
<asp:ObjectDataSource ID="odsEjercicio" runat="server" EnableCaching="True" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cEJERCICIO">
    <SelectParameters>       
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="String" />
        <asp:Parameter DefaultValue="ID_EJERCICIO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>      
<asp:ObjectDataSource ID="odsAreaFormacion" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cAREA_FORMACION">
    <SelectParameters>            
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />   
        <asp:Parameter DefaultValue="AREA_FORMACION" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
