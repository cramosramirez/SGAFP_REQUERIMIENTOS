<%@ Page Title="" Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfCorreccionDatosParticipante.aspx.vb" Inherits="GFI_wfCorreccionDatosParticipante" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register src="~/controles/ucListaFICHA_PATI.ascx" tagname="ucListaFICHA_PATI" tagprefix="uc1" %>
<%@ Register Src="~/controles/ucBarraNavegacion.ascx" TagName="ucBarraNavegacion" TagPrefix="uc1" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxLoadingPanel" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">     
    <style type="text/css">
        .TextoInfo
        {
            font-family:Verdana, Arial;
            font-size: 8pt;             
        }
        .TextoCelda
        {
            font-family:Verdana, Arial;
            font-size: 8pt;            
            text-align:left; 
            font-weight:normal;  
         }        
         .textUpper input{text-transform:uppercase;}   
    </style>
    <script language="javascript" type="text/javascript">
        function BuscarFichasPATI() {
            var NUM_CONVENIO = '-1';
            var NUME_FICH = '-1';
            var NOMBRES = '';
            var APELLIDOS = '';
            var DUI = '';
            var FECHA_NACIMIENTO = '';

            if (txtNUM_CONVENIO.GetValue() != null) {
                NUM_CONVENIO = txtNUM_CONVENIO.GetValue();
            }
            else {
                AsignarMensaje('Ingrese el Número de convenio');
                return;
            }               
            MostrarPanelModal(true, 'Realizando busqueda...');
            cCDatosParticipante.PerformCallback('BuscarFichasPATI' + ';' + NUM_CONVENIO + ';' + NUME_FICH + ';' + NOMBRES + ';' + APELLIDOS + ';' + DUI + ';' + FECHA_NACIMIENTO);
        }

        function GuardarCambiosParticipante() {
            if (txtID_PARTICIPANTE.GetValue() == null || txtID_PARTICIPANTE.GetValue() == '') {
                AsignarMensaje('No se ha encontrado participante por DUI');
                return;
            }
            if (txtNOMBRES.GetValue() == null || txtNOMBRES.GetValue() =='') {
                AsignarMensaje('Ingrese los nombres del participante');
                return;
            }
            if (txtAPELLIDOS.GetValue() == null || txtAPELLIDOS.GetValue() == '') {
                AsignarMensaje('Ingrese los apellidos del participante');
                return;
            }
            MostrarPanelModal(true, 'Guardando cambios...');
            cCDatosParticipante.PerformCallback('GuardarCambios;');
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
<dx:ASPxCallbackPanel runat="server" ID="cCDatosParticipante" ClientInstanceName="cCDatosParticipante" ShowLoadingPanel="false">  
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
        <uc1:ucBarraNavegacion ID="UcBarraNavegacion1" runat="server" />
        <table>            
            <tr>   
                <th>
                    <table>
                        <tr>
                        <td class="TextoCelda" style="width:125px" >N° DE CONVENIO:</td>
                        <td><dx:ASPxTextBox ID="txtNUM_CONVENIO" CssClass="textUpper" ClientInstanceName="txtNUM_CONVENIO" runat="server" Width="125px"></dx:ASPxTextBox></td>
                        <td></td>
                        <td></td>           
                        <td></td>
                        <td></td> 
                        </tr>
                    </table>    
                </th>            
            </tr>
            <tr>
                <th class="TextoCelda" colspan="4">DATOS DEL PARTICIPANTE EN FICHA PATI</th>
            </tr>
            <tr>
                <th colspan="6"><hr /></th>
            </tr>
            <tr>
                <th colspan="6">
                    <uc1:ucListaFICHA_PATI id="ucListaFICHA_PATI1" runat="server" VerNOMB_CASERIO_AUP="false"    
                        VerACT_INGRESOS="false" VerPRIMER_NOMBRE="true" VerSEGUNDO_NOMBRE="true"  
                        VerTERCER_NOMBRE="true" VerPRIMER_APELLIDO="true" VerNOMBRES="False" VerAPELLIDOS="false"  
                        VerSEGUNDO_APELLIDO="true" VerTERCER_APELLIDO="true"  VerSEXO="false" VerEDAD="false"     
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
                        NombreFuente= "Verdana" TamanoFuente ="Small" TamanoPagina="4"                                                                              
                        />
                </th>
            </tr>
            <tr>
                <th class="TextoCelda" colspan="6"><br />DATOS DEL PARTICIPANTE EN SGAFP</th>
            </tr>
            <tr>
                <th colspan="6"><hr /></th>
            </tr>
            <tr>
                <th>
                   <table>
                        <tr>
                            <td class="TextoCelda">ID PARTICIPANTE:</td>
                            <td><dx:ASPxTextBox ID="txtID_PARTICIPANTE" ClientEnabled="false" CssClass="textUpper" ClientInstanceName="txtID_PARTICIPANTE" runat="server" Width="100px"></dx:ASPxTextBox></td> 
                            <td class="TextoCelda">NOMBRES:</td>
                            <td><dx:ASPxTextBox ID="txtNOMBRES" CssClass="textUpper" ClientInstanceName="txtNOMBRES" runat="server" Width="200px"></dx:ASPxTextBox></td>
                            <td class="TextoCelda">APELLIDOS:</td>
                            <td><dx:ASPxTextBox ID="txtAPELLIDOS" CssClass="textUpper" ClientInstanceName="txtAPELLIDOS" runat="server" Width="200px"></dx:ASPxTextBox></td>
                            <td class="TextoCelda">FECHA NACIMIENTO:</td>
                            <td><dx:ASPxTextBox ID="txtFECHA_NACIMIENTO" ClientEnabled="false" CssClass="textUpper" ClientInstanceName="txtFECHA_NACIMIENTO" runat="server" Width="100px"></dx:ASPxTextBox></td>
                        </tr>
                        <tr>
                            <td class="TextoCelda">DEPARTAMENTO:</td>
                            <td><dx:ASPxTextBox ID="txtDEPARTAMENTO" ClientEnabled="false" ClientInstanceName="txtDEPARTAMENTO" runat="server" Width="100px"></dx:ASPxTextBox></td> 
                            <td class="TextoCelda">MUNICIPIO:</td>
                            <td><dx:ASPxTextBox ID="txtMUNICIPIO" ClientEnabled="false" ClientInstanceName="txtMUNICIPIO" runat="server" Width="200px"></dx:ASPxTextBox></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                        </tr>
                   </table>                
                </th>
            </tr>
        </table>
    </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>
<dx:ASPxLoadingPanel ID="LoadingPanel" runat="server" ClientInstanceName="LoadingPanel" Text="Cargando..."  Modal="True" /> 
</asp:Content>


