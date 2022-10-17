<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaMUNICIPIO_CONVOCATORIA.ascx.vb" Inherits="controles_ucListaMUNICIPIO_CONVOCATORIA" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register src="ucVistaDetalleMUNICIPIO_CONVOCATORIA.ascx" tagname="ucVistaDetalleMUNICIPIO_CONVOCATORIA" tagprefix="uc1" %>

<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxHiddenField" tagprefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxMenu" tagprefix="dx" %>

<script language="javascript" type="text/javascript">
    var rutaReporteTAF3A = '../Reportes/wfReporteAnexosTAF.aspx?a=3&idl=';
    var rutaReporteTAF4A = '../Reportes/wfReporteAnexosTAF.aspx?a=4&idl=';
    var rutaReporteTAF5Rev = '../Reportes/wfReporteAnexosTAF.aspx?a=51&idl=';
    var rutaReporteTAF5 = '../Reportes/wfReporteAnexosTAF.aspx?a=5&idl=';
    var rutaReporteTAF9 = '../Reportes/wfReporteAnexosTAF.aspx?a=9';
        
    function mostrarMenuAnexos(elemento, id, idFuente, depto, muni, con) {       
        lnkTAF3A.SetNavigateUrl(rutaReporteTAF3A + id);
        lnkTAF4A.SetNavigateUrl(rutaReporteTAF4A + id);
        lnkTAF5Rev.SetNavigateUrl(rutaReporteTAF5Rev + id);
        lnkTAF5.SetNavigateUrl(rutaReporteTAF5 + id);
        lnkTAF9.SetNavigateUrl(rutaReporteTAF9 + '&depto=' + depto + '&muni=' + muni + '&con=' + con);      

        switch (idFuente) {
            case '1':
                lnkTAF3A.SetVisible(true);
                lnkTAF4A.SetVisible(false);
                lnkTAF5Rev.SetVisible(true);
                lnkTAF5.SetVisible(true);                
                lnkTAF9.SetVisible(false);
                break;
            case '2':
                lnkTAF3A.SetVisible(true);
                lnkTAF4A.SetVisible(true);
                lnkTAF5Rev.SetVisible(true);
                lnkTAF5.SetVisible(true);
                lnkTAF9.SetVisible(true);
                break;
            case '3':
                lnkTAF3A.SetVisible(true);
                lnkTAF4A.SetVisible(false);
                lnkTAF5Rev.SetVisible(true);
                lnkTAF5.SetVisible(true);
                lnkTAF9.SetVisible(false);
                break;
            default:
                return; 
        }        
        popupAnexos.ShowAtElement(elemento);    
    }        
</script>
<dx:ASPxCallbackPanel runat="server" ID="cbpucListaACCION_FORMATIVA" ClientInstanceName="cbpucListaACCION_FORMATIVA">    
        <PanelCollection>
            <dx:PanelContent ID="PanelContent1" runat="server">             
                <dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="CLAVE_COMPUESTA">
                    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
                    <SettingsPager>
                        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
                            Text="Pag. {0} de {1} ({2} registros)" />
                    </SettingsPager>
                    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
                        EmptyDataRow="No existen registros para mostrar" />
                    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" 
                            CustomButtonClick="function(s,e){
                                                    if(e.buttonID =='btnEditar'){                                                        
                                                        cMunicipioConv.PerformCallback('EditarConvocatoria;' + s.cpKeyValues[e.visibleIndex]);
                                                        return;                                                        
                                                    }
                                                    if(e.buttonID =='btnGenerarLiquidacion'){                                                                                       
                                                        MostrarCursosPorLiquidarEnMunicipio(s.cpKeyValues[e.visibleIndex]);
                                                        return;                                                        
                                                    }
                                                    e.processOnServer = true;
                                               }" />
                    <Columns>                        
                        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Editar" ButtonType="Image" Width="30px" VisibleIndex="1">
                            <CustomButtons>
                                <dx:GridViewCommandColumnCustomButton ID="btnEditar" Text="Editar Convocatoria" Image-Url="../imagenes/modificar.png" >
<Image Url="../imagenes/modificar.png"></Image>
                                </dx:GridViewCommandColumnCustomButton>
                            </CustomButtons>
                        </dx:GridViewCommandColumn>
                        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " Name="GenerarLiquidacion" ButtonType="Image" Width="30px" VisibleIndex="1">
                            <CustomButtons>
                                <dx:GridViewCommandColumnCustomButton ID="btnGenerarLiquidacion" Text="Generar Liquidación"  Image-Url="../imagenes/dinero2.png" >
<Image Url="../imagenes/dinero2.png"></Image>
                                </dx:GridViewCommandColumnCustomButton>
                            </CustomButtons>
                        </dx:GridViewCommandColumn>
                        <dx:GridViewDataTextColumn FieldName="CLAVE_COMPUESTA" Visible="false" VisibleIndex="1" Caption=" " />
                        <dx:GridViewDataTextColumn FieldName="CORRELATIVO" UnboundType="Integer" VisibleIndex="1" Caption="#" />
                        <dx:GridViewDataTextColumn FieldName="ID_FUENTE" VisibleIndex="1" Caption="Id Fuente." />
                        <dx:GridViewDataTextColumn FieldName="NO_CONVOCATORIA" VisibleIndex="1" Caption="Conv." />
                        <dx:GridViewDataTextColumn FieldName="NOMBRE_DEPARTAMENTO" VisibleIndex="2" Caption="Departamento" />        
                        <dx:GridViewDataTextColumn FieldName="NOMBRE_MUNICIPIO" UnboundType="String" VisibleIndex="3" Caption="Municipio" />        
                        <dx:GridViewDataTextColumn FieldName="CODIGO_DEPARTAMENTO"  VisibleIndex="4" Caption="Codigo Departamento" />        
                        <dx:GridViewDataTextColumn FieldName="CODIGO_MUNICIPIO" VisibleIndex="5" Caption="Codigo Municipio" />                                
                        <dx:GridViewDataTextColumn FieldName="APORTE_FISDL" VisibleIndex="7" Caption="Aporte FISDL" >
                             <PropertiesTextEdit DisplayFormatString="#,##0.00" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="MONTO_LIQUIDADO" VisibleIndex="8" Caption="Monto Liquidado" >
                             <PropertiesTextEdit DisplayFormatString="#,##0.00" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="NUM_LIQUIDACIONES" VisibleIndex="8" Caption="N° Liquidaciones" />
                        <dx:GridViewDataTextColumn FieldName="SALDO_LIQUIDAR" VisibleIndex="9" Caption="Saldo por Liquidar" >
                             <PropertiesTextEdit DisplayFormatString="#,##0.00" />                            
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataProgressBarColumn FieldName="PORC_MONTO_CUBIERTO" PropertiesProgressBar-IndicatorStyle-BackColor="Green" PropertiesProgressBar-Style-Font-Names="tahoma" PropertiesProgressBar-Style-Font-Size="XX-Small" PropertiesProgressBar-Height="15px" Caption="Cobertura Saldo" VisibleIndex="9" >                            
<PropertiesProgressBar Width="" Height="15px">
<Style Font-Names="tahoma" Font-Size="XX-Small"></Style>
</PropertiesProgressBar>
                        </dx:GridViewDataProgressBarColumn>
                        <dx:GridViewDataTextColumn FieldName="ASESOR_MUNICIPAL" VisibleIndex="10" Caption="Asesor Municipal" />
                        <dx:GridViewDataTextColumn FieldName="CODIGO_PROYECTO" VisibleIndex="11" Caption="Codigo proyecto" />
                        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROYECTO" VisibleIndex="12" Caption="Nombre proyecto" />
                        <dx:GridViewDataTextColumn FieldName="USERID" VisibleIndex="13" Caption="Userid" />
                        <dx:GridViewDataTextColumn FieldName="LASTUPDATE" VisibleIndex="14" Caption="Lastupdate" />
                        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " Name="Eliminar" VisibleIndex="13">
                            <CustomButtons>
                                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" >
                                </dx:GridViewCommandColumnCustomButton>
                            </CustomButtons>
                        </dx:GridViewCommandColumn>
	                   </Columns>    
                    <Settings ShowFilterRow="False"  ShowHeaderFilterButton="False" />
                    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />   
                    <SettingsDetail AllowOnlyOneMasterRowExpanded="true" ShowDetailRow="true"  />                     
                    <Templates>
                        <DetailRow>        
                            <table style="font-family:Verdana;font-size:x-small;" >
                                <tr>
                                    <td>Aporte FISDL:</td>
                                    <td><b><%#Format(Eval("APORTE_FISDL"), "#,##0.00")%></b></td>
                                </tr>                                                                
                            </table>    
                            <dx:ASPxGridView ID="dgvConvocatoriaLiquidacion" ClientInstanceName="dgvDetalle" runat="server" DataSourceID="odsLiquidacionesPorMunicipio" KeyFieldName="ID_LIQUIDACION"
                                Width="100%" OnBeforePerformDataSelect="detailGrid_DataSelect" OnCustomButtonInitialize="detailGrid_CustomButtonInitialize"  OnCustomJSProperties="detailGrid_CustomJSProperties" OnCustomUnboundColumnData="detailGrid_UnboundColumn" Font-Size="XX-Small" Font-Names="tahoma" >                                                                                 
                                <ClientSideEvents CustomButtonClick="function(s,e){
                                                                                    if(e.buttonID=='btnEliminar'){
                                                                                        if(window.confirm('Esta seguro de Eliminar la Liquidación?')){
                                                                                            cMunicipioConv.PerformCallback('EliminarLiquidacion;' + s.cpKeyValues[e.visibleIndex]);
                                                                                        }
                                                                                    }
                                                                                    e.processOnserver=true;
                                                                                   }" /> 
                                <Columns>
                                    <dx:GridViewDataTextColumn FieldName="NO_LIQUIDACION" Caption="N° Liquidacion" VisibleIndex="1" />                                                                                                                                   
                                    <dx:GridViewDataTextColumn FieldName="FECHA_ELABORACION" Caption="Fecha Liquidación" VisibleIndex="2" >
                                        <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" />
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="ANTERIOR_LIQUIDADO" UnboundType="Decimal" Caption="Liquidado Anterior" VisibleIndex="3" >
                                        <PropertiesTextEdit DisplayFormatString="#,##0.00" />
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="POR_LIQUIDAR" UnboundType="Decimal" Caption="Por Liquidar" VisibleIndex="4" >
                                        <PropertiesTextEdit DisplayFormatString="#,##0.00" />
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="MONTO_LIQUIDADO" Caption="Esta Liquidacion" VisibleIndex="5">
                                        <PropertiesTextEdit DisplayFormatString="#,##0.00" />
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataTextColumn FieldName="SALDO_PENDIENTE" UnboundType="Decimal" Caption="Saldo Pendiente" VisibleIndex="6" >
                                        <PropertiesTextEdit DisplayFormatString="#,##0.00" />
                                    </dx:GridViewDataTextColumn>
                                    <dx:GridViewDataColumn Caption=" " VisibleIndex="7">
                                        <DataItemTemplate>
                                            <a href="javascript:void(0);" onclick="mostrarMenuAnexos(this,'<%# Container.KeyValue %>','<%# ObtenerIdFuente(Container.KeyValue) %>','<%# Eval("CODIGO_DEPARTAMENTO") %>','<%# Eval("CODIGO_MUNICIPIO") %>','<%# Eval("NO_CONVOCATORIA") %>')">
                                                Anexos...</a>
                                        </DataItemTemplate>
                                    </dx:GridViewDataColumn>
                                    <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " ButtonType="Image" Name="Eliminar" VisibleIndex="8">
                                        <CustomButtons>
                                            <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar" Image-Url="../imagenes/eliminar.png" >
                                            </dx:GridViewCommandColumnCustomButton>
                                        </CustomButtons>
                                    </dx:GridViewCommandColumn>
                                </Columns>   
                                 <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
                                    EmptyDataRow="No existen registros para mostrar"                
                                    CommandCancel="Cerrar" CommandUpdate="Aceptar" />
                                <SettingsPager>
                                    <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" Text="Pag. {0} de {1} ({2} registros)" />
                                </SettingsPager>                                                                                          
                            </dx:ASPxGridView>
                            <table style="font-family:Verdana;font-size:x-small;" >
                                <tr>
                                    <td>Cobertura actual del Saldo por Liquidar:</td>                                    
                                    <td><dx:ASPxLabel ID="lblProximaLiquidacion" runat="server" Font-Size="X-Small" Font-Bold="true" />&nbsp;&nbsp;&nbsp;</td>
                                    <td><b><%#Format(Eval("PORC_MONTO_CUBIERTO") / 100, "0.00%")%></b></td>
                                </tr>                                                                
                            </table>                               
                        </DetailRow>
                    </Templates>
                </dx:ASPxGridView>
                <dx:ASPxHiddenField runat="server" ID="hfdxgv" />                 
        </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>

 <dx:ASPxPopupControl ID="popupAnexos" ClientInstanceName="popupAnexos" runat="server" AllowDragging="true"
        PopupHorizontalAlign="OutsideLeft" HeaderText="Anexos" ShowCloseButton="false" ShowHeader="false" Width="96px" 
        ContentStyle-Paddings-PaddingTop="3" ContentStyle-Paddings-PaddingLeft="3" >
<ContentStyle>
<Paddings PaddingLeft="3px" PaddingTop="3px"></Paddings>
</ContentStyle>
        <ContentCollection>
            <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">
                <dx:ASPxCallbackPanel ID="callbackPanel" ClientInstanceName="callbackPanel" runat="server" RenderMode="Table">
                    <PanelCollection>
                        <dx:PanelContent ID="PanelContent2" runat="server">
                            <table>
                                <tr>
                                    <td><dx:ASPxHyperLink ID="lnkTAF3A" Text="TAF-3A" ClientInstanceName="lnkTAF3A" NavigateUrl="../Reportes/wfReporteAnexosTAF.aspx" runat="server" Target="_blank"  Font-Size="XX-Small" /></td>
                                </tr>
                                <tr>
                                    <td><dx:ASPxHyperLink ID="lnkTAF4A" Text="TAF-4A" ClientInstanceName="lnkTAF4A" NavigateUrl="../Reportes/wfReporteAnexosTAF.aspx" runat="server" Target="_blank" Font-Size="XX-Small" /></td>
                                </tr>
                                 <tr>
                                    <td><dx:ASPxHyperLink ID="lnkTAF5Rev" Text="TAF-5 Revisión" ClientInstanceName="lnkTAF5Rev" NavigateUrl="../Reportes/wfReporteAnexosTAF.aspx" runat="server" Target="_blank" Font-Size="XX-Small" /></td>
                                </tr>
                                <tr>
                                    <td><dx:ASPxHyperLink ID="lnkTAF5" Text="TAF-5" ClientInstanceName="lnkTAF5" NavigateUrl="../Reportes/wfReporteAnexosTAF.aspx" runat="server" Target="_blank" Font-Size="XX-Small" /></td>
                                </tr>
                                <tr>
                                    <td><dx:ASPxHyperLink ID="lnkTAF9" Text="TAF-9" ClientInstanceName="lnkTAF9" NavigateUrl="../Reportes/wfReporteAnexosTAF.aspx" runat="server" Target="_blank" Font-Size="XX-Small" /></td>
                                </tr>
                            </table>
                        </dx:PanelContent>
                    </PanelCollection>
                </dx:ASPxCallbackPanel>
            </dx:PopupControlContentControl>
        </ContentCollection>        
</dx:ASPxPopupControl>


<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarMUNICIPIO_CONVOCATORIA" DeleteMethod="EliminarMUNICIPIO_CONVOCATORIA" UpdateMethod="ActualizarMUNICIPIO_CONVOCATORIA"
    TypeName="SGAFP.BL.cMUNICIPIO_CONVOCATORIA">
    <SelectParameters>
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="NO_CONVOCATORIA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="APORTE_FISDL" Type="Decimal" />
        <asp:Parameter Name="MONTO_LIQUIDADO" Type="Decimal" />
        <asp:Parameter Name="ASESOR_MUNICIPAL" Type="String" />
        <asp:Parameter Name="CODIGO_PROYECTO" Type="String" />
        <asp:Parameter Name="NOMBRE_PROYECTO" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="NO_CONVOCATORIA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="APORTE_FISDL" Type="Decimal" />
        <asp:Parameter Name="MONTO_LIQUIDADO" Type="Decimal" />
        <asp:Parameter Name="ASESOR_MUNICIPAL" Type="String" />
        <asp:Parameter Name="CODIGO_PROYECTO" Type="String" />
        <asp:Parameter Name="NOMBRE_PROYECTO" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="NO_CONVOCATORIA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLiquidacionesPorMunicipio" runat="server" 
    SelectMethod="ObtenerListaPorMUNICIPIO_CONVOCATORIA" TypeName="SGAFP.BL.cMUNICIPIO_LIQUIDACION">
    <SelectParameters>
        <asp:SessionParameter Name="ID_FUENTE" SessionField="ID_FUENTE" Type="Decimal" />
        <asp:SessionParameter Name="NO_CONVOCATORIA" SessionField="NO_CONVOCATORIA" Type="Decimal" />
        <asp:SessionParameter Name="CODIGO_DEPARTAMENTO" SessionField="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:SessionParameter Name="CODIGO_MUNICIPIO" SessionField="CODIGO_MUNICIPIO" Type="String" />   
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="NO_LIQUIDACION" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />   
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCriterios" runat="server" 
    SelectMethod="ObtenerDataSetPorCriterios" TypeName="SGAFP.BL.cMUNICIPIO_CONVOCATORIA">
    <SelectParameters>
        <asp:Parameter Name="ID_FUENTE" Type="Decimal" />
        <asp:Parameter Name="NO_CONVOCATORIA" Type="Decimal" />    
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />            
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsListaPorDEPARTAMENTO" runat="server" 
    SelectMethod="ObtenerListaPorDEPARTAMENTO" InsertMethod="AgregarMUNICIPIO_CONVOCATORIA" DeleteMethod="EliminarMUNICIPIO_CONVOCATORIA" UpdateMethod="ActualizarMUNICIPIO_CONVOCATORIA"
    TypeName="SGAFP.BL.cMUNICIPIO_CONVOCATORIA">
    <SelectParameters>
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="NO_CONVOCATORIA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="APORTE_FISDL" Type="Decimal" />
        <asp:Parameter Name="MONTO_LIQUIDADO" Type="Decimal" />
        <asp:Parameter Name="ASESOR_MUNICIPAL" Type="String" />
        <asp:Parameter Name="CODIGO_PROYECTO" Type="String" />
        <asp:Parameter Name="NOMBRE_PROYECTO" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="NO_CONVOCATORIA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="APORTE_FISDL" Type="Decimal" />
        <asp:Parameter Name="MONTO_LIQUIDADO" Type="Decimal" />
        <asp:Parameter Name="ASESOR_MUNICIPAL" Type="String" />
        <asp:Parameter Name="CODIGO_PROYECTO" Type="String" />
        <asp:Parameter Name="NOMBRE_PROYECTO" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="NO_CONVOCATORIA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorMUNICIPIO" runat="server" 
    SelectMethod="ObtenerListaPorMUNICIPIO" InsertMethod="AgregarMUNICIPIO_CONVOCATORIA" DeleteMethod="EliminarMUNICIPIO_CONVOCATORIA" UpdateMethod="ActualizarMUNICIPIO_CONVOCATORIA"
    TypeName="SGAFP.BL.cMUNICIPIO_CONVOCATORIA">
    <SelectParameters>
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="NO_CONVOCATORIA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="APORTE_FISDL" Type="Decimal" />
        <asp:Parameter Name="MONTO_LIQUIDADO" Type="Decimal" />
        <asp:Parameter Name="ASESOR_MUNICIPAL" Type="String" />
        <asp:Parameter Name="CODIGO_PROYECTO" Type="String" />
        <asp:Parameter Name="NOMBRE_PROYECTO" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="NO_CONVOCATORIA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="APORTE_FISDL" Type="Decimal" />
        <asp:Parameter Name="MONTO_LIQUIDADO" Type="Decimal" />
        <asp:Parameter Name="ASESOR_MUNICIPAL" Type="String" />
        <asp:Parameter Name="CODIGO_PROYECTO" Type="String" />
        <asp:Parameter Name="NOMBRE_PROYECTO" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="NO_CONVOCATORIA" Type="Decimal" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
