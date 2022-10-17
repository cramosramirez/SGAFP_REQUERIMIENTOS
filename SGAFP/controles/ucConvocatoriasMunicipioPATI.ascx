<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucConvocatoriasMunicipioPATI.ascx.vb" Inherits="controles_ucConvocatoriasMunicipioPATI" %>

<%@ Register TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" TagPrefix="uc1" %>
<%@ Register TagName="ucCriteriosMunicipiosPATI" Src="~/controles/ucCriteriosMunicipiosPATI.ascx" TagPrefix="uc1" %>
<%@ Register TagName="ucListaMUNICIPIO_CONVOCATORIA" Src="~/controles/ucListaMUNICIPIO_CONVOCATORIA.ascx" TagPrefix="uc1" %>
<%@ Register TagName="ucVistaDetalleMUNICIPIO_CONVOCATORIA" Src="~/controles/ucVistaDetalleMUNICIPIO_CONVOCATORIA.ascx" TagPrefix="uc1" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxLoadingPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxHiddenField" tagprefix="dx" %>

<script language="javascript" type="text/javascript">
    var NuevoRegistroConv;
    var fechaLiq;
    function CargarConvocatorias() {
        var ID_FUENTE = '-1';
        var CODIGO_DEPARTAMENTO = '';
        var CODIGO_MUNICIPIO = '';
        var NO_CONVOCATORIA = '-1';

        if (cbxFuenteFinanciamiento.GetValue() != null) { ID_FUENTE = cbxFuenteFinanciamiento.GetValue(); }
        if (cbxDepartamento.GetValue() != null && cbxDepartamento.GetValue() != -1) { CODIGO_DEPARTAMENTO = cbxDepartamento.GetValue(); }
        if (cbxMunicipio.GetValue() != null && cbxMunicipio.GetValue() != -1) { CODIGO_MUNICIPIO = cbxMunicipio.GetValue(); }
        if (speConvocatoria.GetValue() != null) { NO_CONVOCATORIA = speConvocatoria.GetValue(); }

        MostrarPanelModal(true, 'Cargando Convocatorias...');
        cMunicipioConv.PerformCallback('CargarConvocatorias;' +
                                        ID_FUENTE + ';' +
                                        CODIGO_DEPARTAMENTO + ';' +
                                        CODIGO_MUNICIPIO + ';' +
                                        NO_CONVOCATORIA);
    }
    function RegistrarConvocatoria() {
        cMunicipioConv.PerformCallback('RegistrarConvocatoria');
    }  

    function FechaDDMMYYYY(f) {
        return f.getDate() + '/' + (f.getMonth() + 1) + '/' + f.getFullYear()
    }

    function MostrarCursosPorLiquidar() {
        if (cbxFuenteFinanciamiento.GetValue() == null) { AsignarMensaje('Seleccione la Fuente de Financiamiento'); return; }
        if (speConvocatoria.GetValue() == null) { AsignarMensaje('Seleccione la Convocatoria'); return; }
        MostrarPanelModal(true, 'Cargando cursos por Liquidar...');
        cMunicipioConv.PerformCallback('CargarCursosPorLiquidar;' + cbxFuenteFinanciamiento.GetValue() + ';' + speConvocatoria.GetValue() + ';;');
    }
    function MostrarCursosPorLiquidarEnMunicipio(parametros) {
        if (cbxFuenteFinanciamiento.GetValue() == null) { AsignarMensaje('Seleccione la Fuente de Financiamiento'); return; }
        if (speConvocatoria.GetValue() == null) { AsignarMensaje('Seleccione la Convocatoria'); return; }
        MostrarPanelModal(true, 'Cargando cursos por Liquidar...');
        cMunicipioConv.PerformCallback('CargarCursosPorLiquidar;' + parametros);
    }
    function MostrarPopupAnexosTAF() {
        MostrarPanelModal(true, 'Cargando Anexos...');
        cbxFechasLiquidacion.SetText('');
        cMunicipioConv.PerformCallback('MostrarPopupAnexosTAF;' + cbxFuenteFinanciamiento.GetValue() + ';' + speConvocatoria.GetValue());
    }

    function ActualizarURLreportes(s) {
        MostrarPanelModal(true, 'Actualizando Anexos...');
        cMunicipioConv.PerformCallback('ActualizarURLreportes;' + cbxFuenteFinanciamiento.GetValue() + ';' + speConvocatoria.GetValue() + ';' + s.GetValue());
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
<dx:ASPxCallbackPanel runat="server" ID="cMunicipioConv" ClientInstanceName="cMunicipioConv" ShowLoadingPanel="false" >
<ClientSideEvents EndCallback="function(s,e){                                            
                                            MostrarPanelModal(false,'');
                                            if(s.cpResultCallback != undefined){
                                                switch(s.cpResultCallback){       
                                                    case 'MostrarPopupRegistroConvocatoria': 
                                                        NuevoRegistroConv = true;
                                                        MostrarPanelModal(true,'');                                                                                                      
                                                        popupRegistroConvocatoria.Show();
                                                        popupRegistroConvocatoria.UpdatePosition();
                                                        break; 
                                                    case 'MostrarPopupEdicion': 
                                                        NuevoRegistroConv = false;                                                                                                                                                       
                                                        popupRegistroConvocatoria.Show();
                                                        popupRegistroConvocatoria.UpdatePosition();
                                                        break; 
                                                    case 'MostrarPopupCursosPorLiquidar': 
                                                        NuevoRegistroConv = false;       
                                                        dxgvCursosPorLiquidar.ExpandAll()                                                                                                                                                
                                                        popupCursosPorLiquidar.Show();
                                                        popupCursosPorLiquidar.UpdatePosition();
                                                        break; 
                                                    case 'Convocatoria registrada con éxito!':
                                                        popupRegistroConvocatoria.Hide();
                                                        gridMunicipioConv.Refresh();
                                                        AsignarMensaje(s.cpResultCallback);
                                                        break; 
                                                    case 'Liquidación Generada con éxito!':                                                       
                                                        gridMunicipioConv.Refresh();
                                                        AsignarMensaje(s.cpResultCallback);
                                                        break;  
                                                    case 'Liquidación por Municipio Generada con éxito!':                                                       
                                                        gridMunicipioConv.Refresh();
                                                        AsignarMensaje(s.cpCommentCallback);
                                                        delete s.cpCommentCallback;
                                                        break;  
                                                    case 'Liquidación Eliminada con éxito!':                                                       
                                                        gridMunicipioConv.Refresh();                                                       
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
        <dx:PanelContent ID="PanelContent1" runat="server">   
            <uc1:ucBarraNavegacion ID="ucBarraNavegacion1" HabilitarCallBacks="true" runat="server" />
            <uc1:ucCriteriosMunicipiosPATI ID="ucCriteriosMunicipiosPATI1" runat="server" />
            <uc1:ucListaMUNICIPIO_CONVOCATORIA ID="ucListaMUNICIPIO_CONVOCATORIA1" NombreGridCliente="gridMunicipioConv" runat="server" 
                VerCODIGO_DEPARTAMENTO="false" VerCODIGO_MUNICIPIO="false" VerCODIGO_PROYECTO="false" VerNOMBRE_PROYECTO="false" 
                VerUSERID="false" VerLASTUPDATE="false" VerNO_CONVOCATORIA="false" TamanoFuente="XX-Small" NombreFuente="tahoma" TamanoPagina="30"   />                       
                
            <dx:ASPxPopupControl ID="popupRegistroConvocatoria" Modal="true" runat="server" 
                    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" PopupElementID="BuscarNombresbtn" 
                    AllowResize="False" DragElement="Header" HeaderStyle-Font-Bold="true" HeaderText="Registro de Convocatoria"    
                    AllowDragging="True" ClientInstanceName="popupRegistroConvocatoria" ShowShadow="true" EnableClientSideAPI="true"  
                    CloseAction="CloseButton" Width="320px">                      
                    <ClientSideEvents Shown="function(s,e){                                                
                                                if(NuevoRegistroConv){cbxCODIGO_DEPARTAMENTO.PerformCallback(cbxID_FUENTE.GetValue())}
                                             }"  />
                 <ContentCollection>
                     <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server" >          
                        <table>               
                            <tr>
                                <td>
                                <uc1:ucVistaDetalleMUNICIPIO_CONVOCATORIA ID="ucVistaDetalleMUNICIPIO_CONVOCATORIA1" runat="server" 
                                    VerUSERID="false" VerLASTUPDATE="false" />     
                                </td>
                            </tr>                            
                            <tr>
                                <td align="center" >
                                    <table width="50%">
                                        <tr align="center" >
                                            <td>
                                                <dx:ASPxButton ID="btnAceptar" ClientInstanceName="btnAceptar" 
                                                    AutoPostBack="false" CausesValidation="True" Text="Aceptar" runat="server" >                                                
                                                <ClientSideEvents Click="function(s,e){    
                                                                            if (ASPxClientEdit.ValidateEditorsInContainer(null,null,true)){                                                                                
                                                                                cMunicipioConv.PerformCallback('GuardarConvocatoria');
                                                                            }                                                                                                                                   
                                                                          }" />                                                
                                                </dx:ASPxButton>
                                            </td>
                                            <td>
                                                <dx:ASPxButton ID="btnCancelar" ClientInstanceName="btnCancelar" 
                                                    AutoPostBack="false" CausesValidation="False" Text="Cancelar" runat="server" >                                                
                                                <ClientSideEvents Click="function(s,e){
                                                                            popupRegistroConvocatoria.Hide();                                                                                 
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
            
             <dx:ASPxPopupControl ID="popupCursosPorLiquidar" Modal="true" runat="server"  
                    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" PopupElementID="BuscarNombresbtn" 
                    AllowResize="False" DragElement="Window" HeaderStyle-Font-Bold="true" HeaderText="Selección de Cursos a Liquidar"    
                    AllowDragging="True" ClientInstanceName="popupCursosPorLiquidar" ShowShadow="true" EnableClientSideAPI="true"  
                    CloseAction="CloseButton" Width="600px" >  
                 <ContentCollection>
                     <dx:PopupControlContentControl ID="PopupControlContentControl4" runat="server" >                              
                        <table width="100%" >               
                            <tr>
                                <td>
                                    <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Seleccione los Cursos que se incluirán en la Liquidación:"  />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <dx:ASPxGridView ID="dxgvCursosPorLiquidar" DataSourceID="odsListaCursosPorLiquidar" runat="server" AutoGenerateColumns="False" KeyFieldName="ID_ACCION_FORMATIVA" ClientInstanceName="dxgvCursosPorLiquidar" Font-Size="XX-Small" >                                        
                                        <Columns>
                                            <dx:GridViewCommandColumn ShowSelectCheckbox="True" Name="#" Caption="#" Visible="true" VisibleIndex="0" >                                                                                                                                     
                                                 <HeaderTemplate>
                                                    <dx:ASPxCheckBox ID="SelectAllCheckBox" runat="server" ToolTip="Seleccionar/Quitar selección de todos los cursos de la página"
                                                        ClientSideEvents-CheckedChanged="function(s, e) { dxgvCursosPorLiquidar.SelectAllRowsOnPage(s.GetChecked()); }" />
                                                </HeaderTemplate>
                                                <HeaderStyle HorizontalAlign="Center" />
                                            </dx:GridViewCommandColumn>
                                            <dx:GridViewDataTextColumn FieldName="NOMBRE_MUNICIPIO" ReadOnly="True" VisibleIndex="1" Caption="Municipio" />
                                            <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" ReadOnly="True" VisibleIndex="2" Caption="Proveedor" />
                                            <dx:GridViewDataTextColumn FieldName="NOMBRE_ACCION_FORMATIVA" VisibleIndex="3" Caption="Curso" />
                                            <dx:GridViewDataTextColumn FieldName="CODIGO_GRUPO" VisibleIndex="4" Caption="Código Curso" />
                                            <dx:GridViewDataTextColumn FieldName="NUMERO_DOCUMENTO" VisibleIndex="5" 
                                                Caption="N° Factura" CellStyle-HorizontalAlign="Right"  >
<CellStyle HorizontalAlign="Right"></CellStyle>
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn FieldName="NUMERO_QUEDAN" VisibleIndex="6" 
                                                Caption="N° Quedan" CellStyle-HorizontalAlign="Right" >
<CellStyle HorizontalAlign="Right"></CellStyle>
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn FieldName="NUMERO_CHEQUE" VisibleIndex="7" 
                                                Caption="N° Cheque" CellStyle-HorizontalAlign="Right" >
<CellStyle HorizontalAlign="Right"></CellStyle>
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn FieldName="PARTICIPANTES_FINALES" VisibleIndex="8" Caption="Activos"/>                                            
                                            <dx:GridViewDataTextColumn FieldName="TOTAL" VisibleIndex="10" >                                                                                      
                                                 <PropertiesTextEdit DisplayFormatString="#,##0.00"     />
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataTextColumn FieldName="ID_ACCION_FORMATIVA" VisibleIndex="11" Visible="false" />    
                                         </Columns>                                         
                                        <Settings ShowFilterRow="True" />
                                        <SettingsLoadingPanel Text = "Cargando..." />
                                        <SettingsEditing Mode="PopupEditForm" PopupEditFormModal="True" PopupEditFormHorizontalAlign="Center" PopupEditFormVerticalAlign="Middle"  />
                                        <SettingsText GroupPanel="Arrastre la columna aqui para agrupar"    
                                            EmptyDataRow="No existen registros para mostrar"                                             
                                            CommandCancel="Cerrar" CommandUpdate="Aceptar" />
                                        <SettingsPager PageSize="5">
                                            <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" Text="Pag. {0} de {1} ({2} registros)" />                                            
                                        </SettingsPager>                                            
                                    </dx:ASPxGridView>    
                                </td>
                            </tr>
                        </table>
                        <table>
                            <tr>
                                <td>
                                    <dx:ASPxButton ID="btnAceptarCursosPorLiquidar" ClientInstanceName="btnAceptarCursosPorLiquidar" AutoPostBack="False" runat="server" Text="Aceptar" Width="60px" Font-Names="Verdana, Arial" Font-Size="10px" >                            
                                        <ClientSideEvents Click="function(s,e){  
                                                                        if(dxgvCursosPorLiquidar.GetSelectedRowCount()==0){
                                                                            AsignarMensaje('Seleccione al menos un Curso.');
                                                                        }
                                                                        else{
                                                                            popupCursosPorLiquidar.Hide();    
                                                                            MostrarPanelModal(true, 'Generando Liquidación por Municipio...');                                                                                                                                                 
                                                                            cMunicipioConv.PerformCallback('GenerarLiquidacionPorMunicipio;' + cbxFuenteFinanciamiento.GetValue() + ';' + speConvocatoria.GetValue());                                                                                                                                                        
                                                                        }                                                                                                                                                                                                                                                                                 
                                                                    
                                                                 }"  />         
                                    </dx:ASPxButton>
                                </td>
                                <td>
                                    <dx:ASPxButton ID="btnCancelarCursosPorLiquidar" ClientInstanceName="btnCancelarCursosPorLiquidar" AutoPostBack="False" CausesValidation="false" runat="server" Text="Cancelar" Width="60px" Font-Names="Verdana, Arial" Font-Size="10px" >  
                                        <ClientSideEvents Click="function(s,e){                                                                    
                                                                    popupCursosPorLiquidar.Hide();                                                                    
                                                                 }"  />                                                                                  
                                    </dx:ASPxButton>
                                </td>
                            </tr>
                        </table>
                     </dx:PopupControlContentControl>
                 </ContentCollection>

                <HeaderStyle Font-Bold="True"></HeaderStyle>
            </dx:ASPxPopupControl> 
            
            
            <dx:ASPxPopupControl ID="popupAnexosTAF" Modal="true" runat="server" 
                    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" PopupElementID="BuscarNombresbtn" 
                    AllowResize="False" DragElement="Header" HeaderStyle-Font-Bold="true" HeaderText="Anexos TAF"    
                    AllowDragging="True" ClientInstanceName="popupAnexosTAF" ShowShadow="true" EnableClientSideAPI="true"  
                    CloseAction="CloseButton" Width="200px" Font-Size="XX-Small" >                                         
                 <ContentCollection>
                     <dx:PopupControlContentControl ID="PopupControlContentControl3" runat="server" >          
                        <table>               
                            <tr>
                                <td>
                                <dx:ASPxLabel ID="lblMsjAnexosTAF" runat="server" ClientInstanceName="lblMsjAnexosTAF"  Text="Seleccione la Fecha de Liquidación y haga clic en el Anexo a imprimir." Font-Size="XX-Small" />
                                </td>
                            </tr>                            
                            <tr>
                                <td>
                                <dx:ASPxComboBox runat="server" ID="cbxFechasLiquidacion" DataSourceID="odsFechasLiquidacion" TextField="FECHA_ELABORACION" 
                                    ValueField="FECHA_ELABORACION" ClientInstanceName="cbxFechasLiquidacion" AutoPostBack="False"  
                                     ValueType="System.String" TextFormatString="{0:dd/MM/yyy}" Width="120px" Font-Size="XX-Small" >  
                                     <ClientSideEvents SelectedIndexChanged="function(s,e){ActualizarURLreportes(s);}" />                                                                                                         
                                </dx:ASPxComboBox>
                                </td>
                            </tr>  
                            <tr>
                                <td><dx:ASPxHyperLink ID="lnkTAF3AFec" Text="TAF-3A" NavigateUrl="../Reportes/wfReporteAnexosTAF.aspx" ClientInstanceName="lnkTAF3AFec" runat="server" Target="_blank"  Font-Size="XX-Small" /></td>
                                <td></td>
                            </tr>
                            <tr>
                                <td><dx:ASPxHyperLink ID="lnkTAF3AFec2" Text="TAF-3A" NavigateUrl="../Reportes/wfReporteAnexosTAF.aspx" ClientInstanceName="lnkTAF3AFec2" runat="server" Target="_blank"  Font-Size="XX-Small" /></td>
                                <td></td>
                            </tr>
                            <tr>
                                <td><dx:ASPxHyperLink ID="lnkTAF4AFec" Text="TAF-4A" NavigateUrl="../Reportes/wfReporteAnexosTAF.aspx" ClientInstanceName="lnkTAF4AFec" runat="server" Target="_blank" Font-Size="XX-Small" /></td>
                            </tr>
                             <tr>
                                <td><dx:ASPxHyperLink ID="lnkTAF5RevFec" Text="TAF-5 Revisión" NavigateUrl="../Reportes/wfReporteAnexosTAF.aspx" ClientInstanceName="lnkTAF5RevFec" runat="server" Target="_blank" Font-Size="XX-Small" /></td>
                            </tr>
                            <tr>
                                <td><dx:ASPxHyperLink ID="lnkTAF5Fec" Text="TAF-5" NavigateUrl="../Reportes/wfReporteAnexosTAF.aspx" ClientInstanceName="lnkTAF5Fecha" runat="server" Target="_blank" Font-Size="XX-Small" /></td>
                            </tr>
                            <tr>
                                <td><dx:ASPxHyperLink ID="lnkTAF9Fec" Text="TAF-9" NavigateUrl="../Reportes/wfReporteAnexosTAF.aspx" ClientInstanceName="lnkTAF9Fecha" runat="server" Target="_blank" Font-Size="XX-Small" /></td>
                            </tr>                            
                        </table>             
                     </dx:PopupControlContentControl>
                 </ContentCollection>

                <HeaderStyle Font-Bold="True"></HeaderStyle>
            </dx:ASPxPopupControl> 
            <dx:ASPxHiddenField runat="server" ID="hfConvLiq" /> 
        </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>
<dx:ASPxLoadingPanel ID="LoadingPanel" runat="server" ClientInstanceName="LoadingPanel" Text="Cargando..."  Modal="True" Font-Size="XX-Small" />

<asp:ObjectDataSource ID="odsListaCursosPorLiquidar" runat="server" SelectMethod="ObtenerDataSetPorFACTURA_AF_ParaLiquidacion"
    TypeName="SGAFP.BL.cFACTURA_DET">
    <SelectParameters>
        <asp:Parameter DefaultValue="-1" Name="ID_FUENTE" Type="Decimal" />    
        <asp:Parameter DefaultValue="-1" Name="NO_CONVOCATORIA" Type="Decimal" />    
        <asp:Parameter DefaultValue="" Name="CODIGO_DEPARTAMENTO" Type="String" />  
        <asp:Parameter DefaultValue="" Name="CODIGO_MUNICIPIO" Type="String" />                  
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsFechasLiquidacion" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerFechasLiquidacionPorFUENTE_CONVOCATORIA" TypeName="SGAFP.BL.cMUNICIPIO_CONVOCATORIA">
<SelectParameters>                     
    <asp:Parameter Name="ID_FUENTE" Type="Decimal" />    
    <asp:Parameter Name="NO_CONVOCATORIA" Type="Decimal" />    
</SelectParameters>
</asp:ObjectDataSource>