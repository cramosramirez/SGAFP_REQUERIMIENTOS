<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucConsultarDisponibilidadCursos.ascx.vb" Inherits="controles_ucConsultarDisponibilidadCursos" %>
<%@ Register src="ucCriteriosAccionFormativa.ascx" tagname="ucCriteriosAccionFormativa" tagprefix="uc1" %>
<%@ Register Src="ucBarraNavegacion.ascx" TagName="ucBarraNavegacion" TagPrefix="uc1" %>
<%@ Register src="ucListaACCION_FORMATIVA.ascx" tagname="ucListaACCION_FORMATIVA" tagprefix="uc2" %>
<%@ Register src="ucListaFICHA_PATI.ascx" tagname="ucListaFICHA_PATI" tagprefix="uc1" %>

<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxLoadingPanel" TagPrefix="dx" %>

<style type="text/css">         
       .textUpper input{text-transform:uppercase;}     
</style>

<script language="javascript" type="text/javascript">    
    
    function IngresarSolicitud(IdAccionFormativa) {        
        MostrarPanelModal(true, '');
        cDispoCURSOS.PerformCallback('IngresarSolicitud' + ';' + IdAccionFormativa);
    }

    function IngresarFichaDNC(url) {
        window.open(url, 'blank_', '')        
        OcultarMensaje();            
    }
    
    function InscribirParticipanteFichaPATI(NumFicha) {
        MostrarPanelModal(true, 'Procesando Ficha PATI...');
        cDispoCURSOS.PerformCallback('InscribirParticipantePATI' + ';' + NumFicha);
    }

    function SolicitarCambioGrupo(p1, p2) {
        OcultarMensaje();
        MostrarPanelModal(true, 'Solicitando Cambio de Grupo de Capacitacion...');
        cDispoCURSOS.PerformCallback('SolicitarCambioGrupo' + ';' + p1 + ';' + p2)
    }

    function BuscarFichasPATI() {       
        var NUM_CONVENIO = '-1';
        var NUME_FICH = '-1';
        var NOMBRES = '';
        var APELLIDOS = '';
        var DUI = '';
        var FECHA_NACIMIENTO = '';       
        
        if (txtNUM_CONVENIO.GetValue() != null) { NUM_CONVENIO = txtNUM_CONVENIO.GetValue(); }
        if (txtNUME_FICH.GetValue() != null) { NUME_FICH = txtNUME_FICH.GetValue(); }
        if (txtNOMBRES.GetValue() != null) { NOMBRES = txtNOMBRES.GetValue(); }
        if (txtAPELLIDOS.GetValue() != null) { APELLIDOS = txtAPELLIDOS.GetValue(); }
        if (txtDUI.GetValue() != null) { DUI = txtDUI.GetValue(); }
        if (dteFECHA_NACIMIENTO.GetValue() != null) {
            var f = new Date();
            f = dteFECHA_NACIMIENTO.GetValue()
            var anioActual = f.getFullYear();
            var mesActual = f.getMonth() + 1;
            var diaActual = f.getDate();
            FECHA_NACIMIENTO = diaActual  + '/' + mesActual + '/' + anioActual; 
        }
        MostrarPanelModal(true, 'Realizando busqueda...');
        cDispoCURSOS.PerformCallback('BuscarFichasPATI' + ';' + NUM_CONVENIO + ';' + NUME_FICH + ';' + NOMBRES + ';' + APELLIDOS + ';' + DUI + ';' + FECHA_NACIMIENTO);
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

<dx:ASPxCallbackPanel runat="server" ID="cDispoCURSOS" ClientInstanceName="cDispoCURSOS" ShowLoadingPanel="false">  
<ClientSideEvents EndCallback="function(s, e){
                                    MostrarPanelModal(false,'');                                   
                                    if(s.cpResultCallback != undefined){
                                        switch(s.cpResultCallback){       
                                            case 'MostrarSolicitud':                                               
                                                window.location.href = s.cpUrl;
                                                break;                                    
                                            case 'MostrarFichasPATI':                                               
                                                txtNUM_CONVENIO.SetValue('');
                                                txtNUME_FICH.SetValue('');
                                                txtNOMBRES.SetValue('');
                                                txtAPELLIDOS.SetValue('');
                                                txtDUI.SetValue('');                                                                                                                                               
                                                popupFichaPATI.Show();
                                                popupFichaPATI.SetSize(200, 0);
                                                popupFichaPATI.UpdatePosition();  
                                                break;                                            
                                            default:                                                
                                                if(s.cpResultCallback != ''){ 
                                                    AsignarMensaje(s.cpResultCallback);
                                                    if(s.cpOcultarBotonMensaje){
                                                        OcultarBotonAceptar();
                                                    }  
                                                    if(s.cpAjustarAnchoPopup){
                                                        SetContenido(400,0);
                                                    }                                                                                                      
                                                }                                                                                                                           
                                        }                                       
                                    }
                                }"      />  
    <PanelCollection>        
        <dx:PanelContent runat="server">   
            <table border="0" cellpadding="0" cellspacing="0" style="width: 100%">
                <tr>
                    <td style="height: 41px">
                        <uc1:ucBarraNavegacion ID="UcBarraNavegacion1" runat="server" PermitirAgregar="false"
                            PermitirEditar="false" PermitirGuardar="false" PermitirNavegacion="false" Visible="true" />
                    </td>
                </tr>
                <TR>
		               <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">DISPONIBILIDAD DE CURSOS PARA MATRICULA</asp:Label></TD>
		           </TR>
		           <TR>
			           <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		           </TR>
                <tr>
                    <td>
                        <uc1:ucCriteriosAccionFormativa ID="ucCriteriosAccionFormativa1" VerEjercicio="true" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <uc2:ucListaACCION_FORMATIVA ID="ucListaACCION_FORMATIVA1" runat="server" 
                            PermitirEditar="False" PermitirEliminar="False" PermitirPaginacion="True" 
                            VerCODIGO_ESTADO_AF="False" VerCOSTO_X_PARTICIPANTE="False" 
                            VerID_EJERCICIO="False" VerID_OFERTA_FORMATIVA="False" 
                            VerID_PROVEEDOR_AF="False" VerID_SITIO_CAPACITACION="False" 
                            VerID_TEMA_CURSO="False" VerLASTUPDATE="False" VerUSERID="False" VerINFO_CONTRATO="true" 
                            VerNOTAS="False" VerIngresoSolicitud="true" />
                            
                        <dx:ASPxPopupControl ID="popupFichaPATI" Modal="true" runat="server" 
                            PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" PopupElementID="BuscarNombresbtn" 
                            AllowResize="False" DragElement="Header" HeaderStyle-Font-Bold="true" HeaderText="Listado de Fichas PATI"   
                            AllowDragging="True" ClientInstanceName="popupFichaPATI" ShowShadow="true"
                            CloseAction="CloseButton">                              
                                     <ContentCollection>
                                         <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server" >                                               
                                            <table style="font-family:Verdana,Arial;font-size:XX-small">       
                                                                               
                                                <tr>                                                    
                                                    <td>N°. Convenio</td>                                            
                                                    <td><dx:ASPxTextBox ID="txtNUM_CONVENIO" ClientInstanceName="txtNUM_CONVENIO" runat="server" Width="125px">
                                                        </dx:ASPxTextBox>
                                                    </td>
                                                    <td>Num. Ficha:</td>
                                                    <td>
                                                        <dx:ASPxTextBox ID="txtNUME_FICH" ClientInstanceName="txtNUME_FICH" runat="server" Width="125px">
                                                        </dx:ASPxTextBox>
                                                    </td> 
                                                    <th valign="bottom" align="center" rowspan="4" style="width:120px">
                                                        <dx:ASPxButton ID="btnBuscar" AutoPostBack="false" Width="100px" runat="server" Text="Buscar Fichas">
                                                            <ClientSideEvents Click="function(s,e){
                                                                                       BuscarFichasPATI(); 
                                                                                     }"  />
                                                        </dx:ASPxButton>
                                                    </th>          
                                                </tr>
                                                <tr>
                                                    <td>Nombres:</td>
                                                    <td><dx:ASPxTextBox ID="txtNOMBRES" CssClass="textUpper" ClientInstanceName="txtNOMBRES" runat="server" Width="125px">
                                                        </dx:ASPxTextBox>
                                                    </td>
                                                    <td style="text-align:left;width:80px">Apellidos:</td>
                                                    <td>
                                                        <dx:ASPxTextBox ID="txtAPELLIDOS" CssClass="textUpper" ClientInstanceName="txtAPELLIDOS" runat="server" Width="125px">
                                                        </dx:ASPxTextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Dui:</td>
                                                    <td><dx:ASPxTextBox ID="txtDUI" ClientInstanceName="txtDUI" runat="server" Width="125px">
                                                            <MaskSettings Mask="99999999-9" IncludeLiterals="None" />  
                                                        </dx:ASPxTextBox>
                                                    </td>
                                                    <td align="right">Fecha Nacimiento:</td>
                                                    <td>
                                                        <dx:ASPxDateEdit ID="dteFECHA_NACIMIENTO" ClientInstanceName="dteFECHA_NACIMIENTO" Width="125px" runat="server" EditFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="true" />                                                        
                                                    </td>
                                                </tr>
                                            </table>       
                                            <table>               
                                                <tr>
                                                    <td><dx:ASPxLabel ID="popuplblMensaje2" ClientInstanceName="popuplblMensaje2" Text="Haga clic en el botón Aprobar Solicitud para inscribir al Participante en el Curso." runat="server" Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small" Font-Bold="True"  /></td>
                                                </tr>                            
                                                <tr>
                                                    <td>
                                                        <uc1:ucListaFICHA_PATI id="ucListaFICHA_PATI1" runat="server" VerNOMB_CASERIO_AUP="false"    
                                                        VerACT_INGRESOS="false" VerPRIMER_NOMBRE="false" VerSEGUNDO_NOMBRE="false" 
                                                        VerTERCER_NOMBRE="false" VerPRIMER_APELLIDO="false"
                                                        VerSEGUNDO_APELLIDO="false" VerTERCER_APELLIDO="false"  VerSEXO="false" VerEDAD="false"     
                                                        VerANO_CURSO_1="false" VerANO_CURSO_2="false" VerANO_CURSO_3="false" 
                                                        VerBACHILLERATO="false" VerCARNET_MINORIDAD="false" VerCEDULA_IDENTIDAD="false" 
                                                        VerCURSO_1="false" VerCURSO_2="false" VerCURSO_3="false" 
                                                        VerCURSO_LE_DIO_BENEFICIOS_1="false" VerCURSO_LE_DIO_BENEFICIOS_2="false" 
                                                        VerCURSO_LE_DIO_BENEFICIOS_3="false" VerDEDICACION_EMPRESA="false" 
                                                        VerDEPARTAMENTO_CONOCIDO="false" VerDEPARTAMENTO_NACIMIENTO="false" 
                                                        VerDIRECCION_CONOCIDO="false" VerDISCAP_BANARSE="false" 
                                                        VerDISCAP_EXPLIQUE="false" VerDISCAP_HABLAR="false" 
                                                        VerDISCAP_MOVERSE_CAMINAR="false" VerDISCAP_OIR="false" 
                                                        VerDISCAP_RETRASO="false" VerDISCAP_USAR_BRAZOS="false" VerDISCAP_VER="false" 
                                                        VerDISCAPACITADO_PERMANENTE="false" VerEDUCACION_BASICA="false" 
                                                        VerEMAIL_CONOCIDO="false" VerEN_QUE_OCUP_DINERO_AYUDAR="false" 
                                                        VerEN_QUE_OCUP_DINERO_INDEPEND="false" VerEN_QUE_OCUP_DINERO_MANT_HIJOS="false" 
                                                        VerEN_QUE_OCUP_DINERO_MANT_PADRES="false" VerEN_QUE_OCUP_DINERO_OTRO="false" 
                                                        VerEN_QUE_OCUP_DINERO_PAGAR_ESTUD="false" VerES_JEFE_DE_HOGAR="false" 
                                                        VerES_SALVADORENO="false" VerESTADO_FAMILIAR="false" 
                                                        VerGUSTO_UBICACION_TRABAJO="false" VerHA_DEJADO_DE_ESTUDIAR="false" 
                                                        VerHA_RECIBIDO_CURSOS="false" VerHA_TRABAJADO_ANTES="false" 
                                                        VerID_ENTREVISTADOR="false" VerIMPARTIO_INSAFORP_CURSO_1="false" 
                                                        VerIMPARTIO_INSAFORP_CURSO_2="false" VerIMPARTIO_INSAFORP_CURSO_3="false" 
                                                        VerINGRESO_PERSONAL_DIARIO="false" VerINGRESO_PERSONAL_MENSUAL="false" 
                                                        VerLOGROS_ESPERADOS_CUENTA_PROPIA="false" 
                                                        VerLOGROS_ESPERADOS_EMPLEO_FORMAL="false" VerLOGROS_ESPERADOS_OTRO="false" 
                                                        VerMAN_OBTIENE_ING_AYUDA_FAM="false" VerMAN_OBTIENE_ING_OTRA="false" 
                                                        VerMAN_OBTIENE_ING_PENSION="false" VerMAN_OBTIENE_ING_REMESA="false" 
                                                        VerMAN_OBTIENE_ING_TRAB_ACT="false" VerMAN_OBTIENE_ING_TRAB_ACT_REM="false" 
                                                        VerMEDIO_DE_INGRESO="false" VerMOTIVO_SALIDA_EMPRESA_OTRAS="false" 
                                                        VerMUNICIPIO_CONOCIDO="false" VerMUNICIPIO_NACIMIENTO="false" 
                                                        VerNO_DE_HIJOS="false" VerNOMBRE_EMPRESA_ANTERIOR="false" 
                                                        VerNOMBRES_CONOCIDO="false" VerOBSERVACIONES_SUGERENCIAS="false" 
                                                        VerOTRA_ACTIVIDAD_BUSCA_TRABAJO="false" VerOTRA_ACTIVIDAD_ESTUDIA="false" 
                                                        VerOTRA_ACTIVIDAD_OFICIOS_HOGAR="false" VerOTRA_ACTIVIDAD_OTRA="false" 
                                                        VerOTRA_EDUCACION_FORMAL="false" VerPAIS="false" VerPARENTESCO="false" 
                                                        VerPASAPORTE="false" VerPERSONAS_GRUPO_FAMILIAR="false" 
                                                        VerPORQUE_NO_RECIB_BENEFICIO="false" VerPROFESION_SE_DEDICA="false" 
                                                        VerPUESTO_EMPRESA="false" VerQUE_GUSTARIA_APRENDER_1="false" 
                                                        VerQUE_GUSTARIA_APRENDER_2="false" VerQUE_GUSTARIA_APRENDER_3="false" 
                                                        VerREALIZA_ACTIVIDAD_INGRESOS="false" VerRECIBE_INGRESOS="false" 
                                                        VerSABE_LEER_ESCRIBIR="false" VerSE_DEDICA_ALGUNA_PROFESION="false" 
                                                        VerSIRVIO_CAPAC_CAMBIAR_EMPLEO="false" VerSIRVIO_CAPAC_OBTENER_EMPLEO="false" 
                                                        VerSIRVIO_CAPAC_OTRO="false" VerSIRVIO_CAPAC_OTROS_INGRESOS="false" 
                                                        VerSIRVIO_CAPAC_PROMOCION="false" VerSIRVIO_CAPAC_TRAB_CTA_PROPIA="false" 
                                                        VerSOLO_ESCRIBE="false" VerSOLO_FIRMA="false" VerSOLO_LEE="false" 
                                                        VerTECNOLOGICA="false" VerTELEFONO_FIJO="false" 
                                                        VerTELEFONO_FIJO_CONOCIDO="false" VerTELEFONO_MOVIL="false" 
                                                        VerTELEFONO_MOVIL_CONOCIDO="false" VerTIEMPO_DEJO_ESTUDIAR="false" 
                                                        VerTIEMPO_QUE_NO_TRABAJA="false" VerTIEMPO_TRABAJO_EMPRESA="false" 
                                                        VerTIENE_HIJOS="false" VerTIPO_DE_EMPLEO_CTA_PROPIA="false" 
                                                        VerTIPO_DE_EMPLEO_MEDIO_TIEMPO="false" VerTIPO_DE_EMPLEO_NEG_FAMILIAR="false" 
                                                        VerTIPO_DE_EMPLEO_OTRO="false" VerTIPO_DE_EMPLEO_POR_HORAS="false" 
                                                        VerTIPO_DE_EMPLEO_TEMPORAL="false" VerTIPO_DE_EMPLEO_TIEMPO_COMP="false" 
                                                        VerTITULO_OBTENIDO="false" VerUNIVERSITARIA="false" 
                                                        VerDEPARTAMENTO_RESIDENCIA="false" VerMUNICIPIO_RESIDENCIA="false" 
                                                        VerDIRECCION="False" VerCORREO_ELECTRONICO="False" VerLASTUPDATE="False" 
                                                        VerUSERID="False"  
                                                        PermitirEditar="false" PermitirEditarInline="false" PermitirEliminar="false"                                           
                                                        NombreFuente= "Verdana" TamanoFuente ="X-Small" TamanoPagina="4"                                                                              
                                                        />
                                                    </td>
                                                </tr>
                                            </table>             
                                         </dx:PopupControlContentControl>
                                     </ContentCollection>
                            <HeaderStyle Font-Bold="True"></HeaderStyle>
                        </dx:ASPxPopupControl> 
                    </td>
                </tr>
            </table>
        </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>
<dx:ASPxLoadingPanel ID="LoadingPanel" runat="server" ClientInstanceName="LoadingPanel" Text="Cargando..."  Modal="True" /> 


