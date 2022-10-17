<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucFacturaBolproes.ascx.vb" Inherits="controles_ucFacturaBolproes" %>
<%@ Register TagName="ucListaINFORME_FINAL_AF" Src="ucListaINFORME_FINAL_AF.ascx"  TagPrefix="uc1" %>
<%@ Register TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" TagPrefix="uc1" %>

<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxLoadingPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>

<style type="text/css">
    .style1 {
        height: 24px;
    }
</style>

<script language="javascript" type="text/javascript">
    function Guardar() {
        cFacturaBolproes.PerformCallback('Guardar;');
    }

    function MostrarBusqueda() {        
        if (cbxProgramaFormacion.GetValue() == null) {
            AsignarMensaje('Seleccione el Programa antes de agregar cursos');
            return; 
        }
        cFacturaBolproes.PerformCallback('MostrarBusqueda;');       
    }

    function Cancelar() {
        window.open('../PagoAccionesFormativas/wfFacturaAccionFormativa.aspx', '_self', '');
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

<dx:ASPxCallbackPanel runat="server" ID="cFacturaBolproes" ClientInstanceName="cFacturaBolproes" ShowLoadingPanel="False" >                           
    <ClientSideEvents EndCallback="function(s,e){                                                                                      
                                            MostrarPanelModal(false,'');
                                            if(s.cpResultCallback != undefined){                                               
                                                switch(s.cpResultCallback){            
                                                    case 'MostrarPopupCursos':                                               
                                                        popupCursos.SetSize(600, 0);
                                                        popupCursos.Show();
                                                        popupCursos.UpdatePosition();
                                                        break;
                                                    case 'OcultarPopupCursos':
                                                        popupCursos.Hide();
                                                        break;
                                                    case 'Factura registrada con exito!':                                                       
                                                        popupCursos.Hide();
                                                        popupConfirmacion.Show();
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
        <dx:PanelContent ID="PanelContent1" runat="server" meta:resourcekey="PanelContent1Resource1">   
             <uc1:ucBarraNavegacion ID="ucBarraNavegacion1" HabilitarCallBacks="true" runat="server" />
             <table width="600px" >               
                            <tr>                                
                                <td class="style1">  
                                    <dx:ASPxLabel ID="lblTipoSolicitud"  Text="Programa:" runat="server" 
                                        meta:resourcekey="lblTipoSolicitudResource1" />                                  
                                </td>
                                <td class="style1"> 
                                    <dx:ASPxComboBox runat="server" ID="cbxProgramaFormacion" 
                                        LoadingPanelText="Cargando Programas..." ShowLoadingPanel="true" 
                                        DataSourceID="odsProgramaFormacion" TextField="NOMBRE_PROGRAMA_FORMACION" 
                                        ValueField="ID_PROGRAMA_FORMACION" 
                                        ClientInstanceName="cbxProgramaFormacion" ValueType="System.Decimal" >                                                                                                   
                                    </dx:ASPxComboBox>                                            
                                </td>
                                <td class="style1">
                                    <dx:ASPxLabel ID="lblRegNumeroDocumento"  Text="N° Documento:" runat="server" 
                                        meta:resourcekey="lblRegNumeroDocumentoResource1" />
                                </td>
                                <td class="style1">                                    
                                    <dx:ASPxSpinEdit ID="speRegNumeroDocumento" 
                                        ClientInstanceName="speRegNumeroDocumento" Width="130px" runat="server" 
                                        NumberType="Integer" AllowUserInput="true" Number="0" MinValue="0" 
                                        meta:resourcekey="speRegNumeroDocumentoResource1" >                                          
                                    </dx:ASPxSpinEdit>     
                                </td>
                            </tr>    
                            <tr>
                                 <td>
                                    <dx:ASPxLabel ID="ASPxLabel2"  Text="Tipo Documento:" runat="server" 
                                         meta:resourcekey="ASPxLabel2Resource1" />
                                </td>
                                <td>
                                    <dx:ASPxComboBox runat="server" ID="cbxRegTipoDocumento" 
                                        ClientInstanceName="cbxRegTipoDocumento" 
                                        meta:resourcekey="cbxRegTipoDocumentoResource1"  >                              
                                        <Items>
                                            <dx:ListEditItem Text="FACTURA" Value="1" Selected="true" 
                                                meta:resourcekey="ListEditItemResource1"  />
                                            <dx:ListEditItem Text="RECIBO" Value="2" 
                                                meta:resourcekey="ListEditItemResource2" />
                                        </Items>                                        
                                    </dx:ASPxComboBox>
                                </td>
                                <td>
                                    <dx:ASPxLabel ID="lblRegFechaEmision" runat="server" Text="Fecha Emisión:" 
                                        meta:resourcekey="lblRegFechaEmisionResource1"  />
                                </td>
                                <td>                                    
                                    <dx:ASPxDateEdit ID="dteRegFechaEmision" Width="130px"  runat="server" 
                                        EditFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="true" 
                                        ClientInstanceName="dteRegFechaEmision" 
                                        meta:resourcekey="dteRegFechaEmisionResource1" >
                                        <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                                        <RequiredField IsRequired="True" ErrorText="Fecha de emisi&#243;n es requerida."></RequiredField>
                                        </ValidationSettings>
                                    </dx:ASPxDateEdit>
                                </td>                               
                            </tr>
                        </table> 
                        <table width="100%" >                                        
                            <tr>                               
                                <td>
                                    <uc1:ucListaINFORME_FINAL_AF ID="ucListaINFORME_FINAL_AF1" runat="server" PermitirEditar="False"
                                    PermitirEliminar="False" PermitirPaginacion="True" PermitirSeleccionar="false" 
                                    VerCODIGO_ESTADO_AF="False" VerID_PROVEEDOR_AF="False"  VerID_INFORME_FINAL="false" NombreGridCliente="Informe_FacturadosBOLPROS"  
                                    VerLASTUPDATE="False" VerUSERID="False"  PermitirFocoEnFilas="false" PermitirRowHotTrack="false"
                                    VerHORAS_ACUMULADAS="false" VerHORARIO="false" VerPARTICIPANTES_INSCRITOS="false" 
                                    VerDEPARTAMENTO="True" VerMUNICIPIO="True" VerDURACION="False"        
                                    VerID_ACCION_FORMATIVA="false" VerFECHA_INFORME="false" VerNUMERO_FACTURA="False"
                                    VerELABORADO_POR="False" VerMONTO_APROBADO="False" VerPORC_PROM_ASISTENCIA="False"
                                    VerNOTA_PROMEDIO="false" VerESTADO="false" VerCOMENTARIOS="false" VerUSUARIO_APROBACION="false"
                                    VerID_ESTADO_INFORME="false" PermitirFiltroEnEncabezado="false" />   
                                </td>
                            </tr>
                        </table>                       
                        
            <dx:ASPxPopupControl ID="popupCursos" Modal="true" runat="server"  
                    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" PopupElementID="BuscarNombresbtn" 
                    AllowResize="False" DragElement="Header" HeaderStyle-Font-Bold="true" HeaderText="Registro de Factura"    
                    AllowDragging="True" ClientInstanceName="popupCursos" 
                ShowShadow="true" EnableClientSideAPI="true"  
                    CloseAction="CloseButton" Width="600px" >  
                 <ContentCollection>
                     <dx:PopupControlContentControl ID="PopupControlContentControl2" runat="server">          
                        <table >               
                            <tr>                                
                                <td>  
                                    <dx:ASPxLabel ID="ASPxLabel1"  Text="Contrato:" runat="server" />                                  
                                </td>
                                <td> 
                                    <dx:ASPxComboBox runat="server" ID="cbxContrato" 
                                        LoadingPanelText="Cargando Contratos..." ShowLoadingPanel="true" 
                                        DataSourceID="odsContratoBolproes" TextField="NUM_CONTRATO" 
                                        ValueField="ID_CONTRATO" 
                                        ClientInstanceName="cbxContrato" ValueType="System.Decimal" >                                                                                                   
                                    </dx:ASPxComboBox>                                            
                                </td>
                                <td>
                                    <dx:ASPxLabel ID="ASPxLabel3"  Text="N° Item:" runat="server"  />
                                </td>
                                <td>                                    
                                    <dx:ASPxSpinEdit ID="speNumItem" 
                                        ClientInstanceName="speNumItem" Width="80px" runat="server" 
                                        NumberType="Integer" AllowUserInput="true" Number="0" Increment="1"  MinValue="0">                                          
                                    </dx:ASPxSpinEdit>     
                                </td>
                                <td>                                    
                                      <dx:ASPxButton ID="btnBuscar" ClientInstanceName="btnBuscar" CausesValidation="false"   
                                       AutoPostBack="False" runat="server" Text="Buscar" Width="60px" 
                                       Font-Names="Verdana, Arial" Font-Size="10px">           
                                        <ClientSideEvents Click="function(s,e){                                                          
                                                            cFacturaBolproes.PerformCallback('BuscarCursos');
                                                      }"  />     
                                       </dx:ASPxButton>
                                </td>
                            </tr>                               
                        </table> 
                        <table width="100%" >                                           
                            <tr>                               
                                <td>
                                    <uc1:ucListaINFORME_FINAL_AF ID="ucListaINFORME_FINAL_AF2" runat="server" PermitirEditar="False"
                                    PermitirEliminar="False" PermitirPaginacion="True" PermitirSeleccionar="false" PermitirMarcar="true"
                                    VerCODIGO_ESTADO_AF="False" VerID_PROVEEDOR_AF="False"  VerID_INFORME_FINAL="false" 
                                    VerDEPARTAMENTO="True" VerMUNICIPIO="True" NombreGridCliente="dxgvListaINFORME"    
                                    VerLASTUPDATE="False" VerUSERID="False"  PermitirFocoEnFilas="false" PermitirRowHotTrack="false"
                                    VerID_ACCION_FORMATIVA="false" VerFECHA_INFORME="false" VerNUMERO_FACTURA="False"
                                    VerELABORADO_POR="False" VerMONTO_APROBADO="False" VerPORC_PROM_ASISTENCIA="False"
                                    VerNOTA_PROMEDIO="false" VerESTADO="false" VerCOMENTARIOS="false" VerUSUARIO_APROBACION="false"
                                    VerID_ESTADO_INFORME="false" PermitirFiltroEnEncabezado="false" 
                                    VerHORARIO="False"
                                    VerDURACION="False" VerHORAS_ACUMULADAS="False" VerPARTICIPANTES_INSCRITOS="False"    />   
                                </td>
                            </tr>
                        </table>
                        <table>
                            <tr>
                                <td>
                                    <dx:ASPxButton ID="btnAgregar" ClientInstanceName="btnAceptar" 
                                        AutoPostBack="False" runat="server" Text="Agregar a Factura" Width="130px" 
                                        Font-Names="Verdana, Arial" Font-Size="10px" >                            
                                        <ClientSideEvents Click="function(s,e){    
                                                                   if(dxgvListaINFORME.GetSelectedRowCount()==0){
                                                                        AsignarMensaje('Seleccione al menos un curso.');
                                                                   }
                                                                   else{
                                                                        cFacturaBolproes.PerformCallback('AgregarCursos');
                                                                   }                                                                                                
                                                                 }"  />         
                                    </dx:ASPxButton>
                                </td>
                                <td>
                                    <dx:ASPxButton ID="btnCancelar" ClientInstanceName="btnCancelar" 
                                        AutoPostBack="False" CausesValidation="false" runat="server" Text="Cancelar" 
                                        Width="60px" Font-Names="Verdana, Arial" Font-Size="10px" 
                                        meta:resourcekey="btnCancelarResource1" >  
                                        <ClientSideEvents Click="function(s,e){                                                                                        
                                                                    popupCursos.Hide();
                                                                    cFacturaBolproes.PerformCallback('LimpiarBusqueda');
                                                                 }"  />                                                                                  
                                    </dx:ASPxButton>
                                </td>
                            </tr>
                        </table>
                     </dx:PopupControlContentControl>
                 </ContentCollection>

                <HeaderStyle Font-Bold="True"></HeaderStyle>
            </dx:ASPxPopupControl> 
            
            <dx:ASPxPopupControl ID="popupConfirmacion" Modal="true" runat="server" 
                    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" PopupElementID="BuscarNombresbtn" 
                    AllowResize="False" DragElement="Header" HeaderStyle-Font-Bold="true" HeaderText="Registro de Factura"    
                    AllowDragging="True" ClientInstanceName="popupConfirmacion" 
                    ShowShadow="true" EnableClientSideAPI="true" CloseAction="CloseButton"    
                    Width="270px" >  
                 <ContentCollection>                                        
                     <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server">     
                        <dx:ASPxLabel ID="ASPxLabel4"  
                             Text="La factura ha sido registrada con exito!.
                             Cierre esta ventana para continuar" runat="server" 
                                         meta:resourcekey="ASPxLabel2Resource1" />
                     
                       </dx:PopupControlContentControl>
                 </ContentCollection>
<ClientSideEvents CloseButtonClick="function(s,e){Cancelar()}" />
                <HeaderStyle Font-Bold="True"></HeaderStyle>
            </dx:ASPxPopupControl> 
                        
            <dx:ASPxHiddenField runat="server" ID="hf" />                                     
        </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>
<asp:ObjectDataSource ID="odsProgramaFormacion" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerListaPorROLES" TypeName="SGAFP.BL.cPROGRAMA_FORMACION">  
    <SelectParameters>                
    <asp:Parameter Name="listaRoles" Type="Object" />        
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsContratoBolproes" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerListaPorPROGRAMA_TIPO_CONTRATACION" TypeName="SGAFP.BL.cCONTRATO_BOLPROS">  
    <SelectParameters>                
    <asp:Parameter Name="ID_PROGRAMA_FORMACION" Type="Decimal" DefaultValue="-1" />        
    <asp:Parameter Name="ID_TIPO_CONTRA" Type="Decimal" DefaultValue="-1" />        
    <asp:Parameter Name="asColumnaOrden" Type="String" />  
    <asp:Parameter Name="asTipoOrden" Type="String" />  
    </SelectParameters>
</asp:ObjectDataSource>
<dx:ASPxLoadingPanel ID="LoadingPanel" runat="server" 
    ClientInstanceName="LoadingPanel" Text="Cargando..."  Modal="True" 
    meta:resourcekey="LoadingPanelResource1" />