<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantSOLICITUD_INSCRIPCION_AF.ascx.vb" Inherits="controles_ucMantSOLICITUD_INSCRIPCION_AF" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucCriteriosSolicitudes" Src="~/controles/ucCriteriosSolicitudes.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaSOLICITUD_INSCRIPCION_AF" Src="~/controles/ucListaSOLICITUD_INSCRIPCION_AF.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleSOLICITUD_INSCRIPCION_AF2" Src="~/controles/ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPARTICIPANTE" Src="~/controles/ucListaPARTICIPANTE.ascx" %>

<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" Tagprefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxLoadingPanel" TagPrefix="dx" %>

<script language="javascript" type="text/javascript">
    var gID_PROVEEDOR_REFERIDO = 39; //CIUDAD MUJER
    function CargarSolicitudes() {        
        var ID_SOLICITUD = '-1';
        var PROVEEDOR_AF = '-1';
        var SITIO_CAPACITACION = '-1';
        var EJERCICIO = '';
        var ESTADO_SOLICITUD = '-1';
        var NOMBRE_ACCION_FORMATIVA = '';
        var CODIGO_GRUPO = '';
        var NOMBRES_SOLICITANTE = '';
        var APELLIDOS_SOLICITANTE = '';

        if (txtID_SOLICITUD.GetValue() != null) { ID_SOLICITUD = txtID_SOLICITUD.GetValue(); }
        if (cbxPROVEEDOR_AF.GetValue() != null) { PROVEEDOR_AF = cbxPROVEEDOR_AF.GetValue(); }
        //if (cbxSITIO_CAPACITACION.GetValue()!=null) {SITIO_CAPACITACION = cbxSITIO_CAPACITACION.GetValue();}
        if (cbxEJERCICIO.GetValue() != null) {EJERCICIO = cbxEJERCICIO.GetValue();}
        if (cbxESTADO_SOLICITUD.GetValue() != null) {ESTADO_SOLICITUD = cbxESTADO_SOLICITUD.GetValue();}
        if (txtNOMBRE_ACCION_FORMATIVA.GetValue() != null) {NOMBRE_ACCION_FORMATIVA = txtNOMBRE_ACCION_FORMATIVA.GetValue();}       
        if (txtCODIGO_GRUPO.GetValue() != null) {CODIGO_GRUPO = txtCODIGO_GRUPO.GetValue();}
        if (txtNOMBRES_SOLICITANTE.GetValue() != null) {NOMBRES_SOLICITANTE = txtNOMBRES_SOLICITANTE.GetValue();}
        if (txtAPELLIDOS_SOLICITANTE.GetValue() != null) { APELLIDOS_SOLICITANTE = txtAPELLIDOS_SOLICITANTE.GetValue(); }
        if (CODIGO_GRUPO == '') {
            AsignarMensaje('Digite el Código de Curso');
            return;
        }
        cbpucListaSOLICITUD_INSCRIPCION_AF.PerformCallback('CargarDatos;CargarDatosPorCriterios;' +
                                        ID_SOLICITUD + ';' +
                                        PROVEEDOR_AF + ';' +
                                        SITIO_CAPACITACION + ';' +
                                        EJERCICIO + ';' +
                                        ESTADO_SOLICITUD + ';' +
                                        NOMBRE_ACCION_FORMATIVA + ';' +
                                        CODIGO_GRUPO + ';' +
                                        NOMBRES_SOLICITANTE + ';' +
                                        APELLIDOS_SOLICITANTE);
    }

    function BuscarParticipantes(p1, p2) {
        MostrarPanelModal(true, 'Buscando participantes...');
        cMantSOLICITUDES.PerformCallback('BuscarPartipantes;' + p1 + ';' + p2);
        //cbpucListaPARTICIPANTE.PerformCallback(p1 + ';' + p2 + ';' + p3);
    }

    function BuscarParticipanteReferido(p1, p2) {
        MostrarPanelModal(true, 'Buscando participantes...');
        cMantSOLICITUDES.PerformCallback('BuscarParticipanteReferido;' + p1 + ';' + p2);        
    }   

    function CargarParticipante(s, e) {
        popupParticipantes.Hide();
        MostrarPanelModal(true, 'Cargando información del participante...');
        cMantSOLICITUDES.PerformCallback('CargarDatosParticipante;' + s.cpKeyValues[e.visibleIndex]);                   
    }

    function GuardarSolicitud(p1) {
        MostrarPanelModal(true, 'Procesando información de la solicitud...');
        cMantSOLICITUDES.PerformCallback(p1);
    }

    function EditarSolicitud(p1) {
        MostrarPanelModal(true, 'Cargando información de la solicitud...');
        cMantSOLICITUDES.PerformCallback(p1);
    }

    function CargarCursosRecParticipanteEjercicio(idparticipante, idejercicio) {
        MostrarPanelModal(true, 'Cargando cursos recibidos por el participante...');
        cMantSOLICITUDES.PerformCallback('MostrarCursosRecibidosPorParticipante;' + idparticipante + ';' + idejercicio);
    }

    function CopiarDomicilioParticipante() {
        MostrarPanelModal(true, 'Copiando datos de domicilio del Participante...');
        cMantSOLICITUDES.PerformCallback('CopiarDatosDomicilio');
    }

    function CalcularEdad(fechaNac) {
        var fechaActual = new Date();
        var edad = 0

        var anioActual = fechaActual.getFullYear();
        var mesActual = fechaActual.getMonth() + 1;
        var diaActual = fechaActual.getDate();

        var anioNac = fechaNac.getFullYear();
        var mesNac = fechaNac.getMonth() + 1;
        var diaNac = fechaNac.getDate();

        if (anioActual <= anioNac) {
            return edad;
        }
        edad = anioActual - anioNac;
        if (mesActual < mesNac) {
            edad -= 1;
        }
        else if (mesActual == mesNac) {
            if (diaActual < diaNac) {
                edad -= 1;
            }
        }
        return edad;
    }

    function validarMiembrosGrupoFamiliar(s, e) {
        var cantidad = e.value;
        if (cantidad == null)
            return;
        if (cantidad <= 0)
            e.isValid = false;
    }

    function MostrarPanelModal(mostrar,mensaje) {
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










    var postponedCallbackValue = null;
    var validando = false;

    

    function MostrarPopup(tipo, criterio) {
        cMantSOLICITUDES.PerformCallback(tipo + ';' + criterio);
    }

    
    function OnEndCallbackucListaPARTICIPANTE(s, e) {
        if (postponedCallbackValue != null) {
            cbpucListaPARTICIPANTE.PerformCallback(postponedCallbackValue);
            postponedCallbackValue = null;
        }
        else {
            switch (hfucListaPARTICIPANTE.Get('Miembro')) {
                case 'CargarDatosPorNOMBRES_APELLIDOS':
                    popuplblMensaje.SetText('Criterio de búsqueda por Nombres/Apellidos: ' + hfucListaPARTICIPANTE.Get('parametro1'));
                    popupParticipantes.Show();
                    break;
                case 'CargarDatosPorDUI':
                    popuplblMensaje.SetText('Criterio de búsqueda por DUI: ' + hfucListaPARTICIPANTE.Get('parametro1'));
                    popupParticipantes.Show();
                    break;
                case 'CargarDatosPorNIT':
                    popuplblMensaje.SetText('Criterio de búsqueda por NIT: ' + hfucListaPARTICIPANTE.Get('parametro1'));
                    popupParticipantes.Show();
                    break;
            }
        }
    }

 

    function HabilitarCampoOtro(s, habilitar) {
        if (!habilitar) { s.SetText('') } s.SetEnabled(habilitar);
    }

    function Inicializar() {
        cbpucVistaDetalleSOLICITUD_INSCRIPCION_AF.PerformCallback('Inicializar');
        LoadingPanel.Show();
    }

    function OnEndCallback_cbpucVistaDetalleSOLICITUD_INSCRIPCION_AF(s, e) {
        if (postponedCallbackValue != null) {
            cbpucVistaDetalleSOLICITUD_INSCRIPCION_AF.PerformCallback(postponedCallbackValue);
            postponedCallbackValue = null;
        }
        else {
            LoadingPanel.Hide();
            switch (s.cpResultadoActualizar) {
                case 'MostrarCursosRecibidos':
                    alert('');
                    break;
                default:
                    if (s.cpResultadoActualizar != '') {
                        AsignarMensaje(s.cpResultadoActualizar);
                        SetContenido(380, 0);
                    }
            }

        }
    }

    function Guardar_cbpucVistaDetalleSOLICITUD_INSCRIPCION_AF(accion) {
        //if (ValidarCamposSolicitud()) {
            cbpucVistaDetalleSOLICITUD_INSCRIPCION_AF.PerformCallback(accion);
            LoadingPanel.Show();
        //}
        return false;
    }

    function ValidarCamposSolicitud() {
        return ASPxClientEdit.ValidateEditorsInContainerById('contenedor_principal', null, true);
    }

    function HabilitarTipoEmpleo(habilitar) {
        if (habilitar) {
            TIPO_EMPLEORadioButtonList.SetEnabled(true);
            ASPxClientEdit.ClearGroup('grupoTRABAJO_ANTERIOR');
            TRABAJO_ANTERIORRadioButtonList.SetEnabled(false);
            ASPxClientEdit.ClearGroup('grupoTIEMPO_NO_TRABAJA');
            TIEMPO_NO_TRABAJARadioButtonList.SetEnabled(false);
            
        }
        else {
            ASPxClientEdit.ClearGroup('grupoTIPO_EMPLEO');
            TIPO_EMPLEORadioButtonList.SetEnabled(false);
            ASPxClientEdit.ClearGroup('grupoSECTOR_EMPLEO');
            SECTOR_EMPLEORadioButtonList.SetEnabled(false);
            ASPxClientEdit.ClearGroup('grupoTRABAJO_ANTERIOR');
            TRABAJO_ANTERIORRadioButtonList.SetEnabled(true);
        }
    }

    function HabilitarCursoDioBeneficios_RazonNoBeneficio() {
        var ConBenef = (CURSO_DIO_BENEFICIOS1ButtonList.GetValue() == 1 || CURSO_DIO_BENEFICIOS2ButtonList.GetValue() == 1 || CURSO_DIO_BENEFICIOS3ButtonList.GetValue() == 1);
        var SinBenef = (CURSO_DIO_BENEFICIOS1ButtonList.GetValue() == 2 || CURSO_DIO_BENEFICIOS2ButtonList.GetValue() == 2 || CURSO_DIO_BENEFICIOS3ButtonList.GetValue() == 2);
        if (ConBenef) {          
            BENEF_OBT_EMPLEOchk.SetEnabled(true);
            BENEF_CAMB_EMP_X_CURSOchk.SetEnabled(true);
            BENEF_TRAB_CTA_PROPIAchk.SetEnabled(true);
            BENEF_ING_EXTRAchk.SetEnabled(true);
            BENEF_PROM_EMP_ACTchk.SetEnabled(true);
            BENEF_OTROchk.SetEnabled(true);            
            RAZON_NO_BENEFICIOtxt.SetEnabled(true);
        }
        else {
            BENEF_OBT_EMPLEOchk.SetValue(false);
            BENEF_CAMB_EMP_X_CURSOchk.SetValue(false);
            BENEF_TRAB_CTA_PROPIAchk.SetValue(false);
            BENEF_ING_EXTRAchk.SetValue(false);
            BENEF_PROM_EMP_ACTchk.SetValue(false);
            BENEF_OTROchk.SetValue(false);       
            BENEF_OTROtxt.SetText('');
            RAZON_NO_BENEFICIOtxt.SetText('');

            BENEF_OBT_EMPLEOchk.SetEnabled(false);
            BENEF_CAMB_EMP_X_CURSOchk.SetEnabled(false);
            BENEF_TRAB_CTA_PROPIAchk.SetEnabled(false);
            BENEF_ING_EXTRAchk.SetEnabled(false);
            BENEF_PROM_EMP_ACTchk.SetEnabled(false);
            BENEF_OTROchk.SetEnabled(false);
            BENEF_OTROtxt.SetEnabled(false);
            RAZON_NO_BENEFICIOtxt.SetEnabled(false);
        }
        if (SinBenef) {
            RAZON_NO_BENEFICIOtxt.SetEnabled(true);
        }
        else {
            RAZON_NO_BENEFICIOtxt.SetText('');
            RAZON_NO_BENEFICIOtxt.SetEnabled(false);
        }
    }

    function HabilitarEducacionFormal(seleccion) {
        switch (seleccion) {
            case 'EDUCACION_FORMAL':
                ASPxClientEdit.ClearGroup('grupoEDUCACION_BASICA');
                EDUCACION_BASICARadioButtonList.SetEnabled(true);
                ASPxClientEdit.ClearGroup('grupoBACHILLERATO');
                BACHILLERATORadioButtonList.SetEnabled(false);
                ASPxClientEdit.ClearGroup('grupoTECNOLOGICA');
                TECNOLOGICARadioButtonList.SetEnabled(false);
                ASPxClientEdit.ClearGroup('grupoUNIVERSITARIA');
                UNIVERSITARIARadioButtonList.SetEnabled(false);
                break;
            case 'BACHILLERATO':
                ASPxClientEdit.ClearGroup('grupoEDUCACION_BASICA');
                EDUCACION_BASICARadioButtonList.SetEnabled(false);
                ASPxClientEdit.ClearGroup('grupoBACHILLERATO');
                BACHILLERATORadioButtonList.SetEnabled(true);
                ASPxClientEdit.ClearGroup('grupoTECNOLOGICA');
                TECNOLOGICARadioButtonList.SetEnabled(false);
                ASPxClientEdit.ClearGroup('grupoUNIVERSITARIA');
                UNIVERSITARIARadioButtonList.SetEnabled(false);
                break;
            case 'TECNOLOGICA':
                ASPxClientEdit.ClearGroup('grupoEDUCACION_BASICA');
                EDUCACION_BASICARadioButtonList.SetEnabled(false);
                ASPxClientEdit.ClearGroup('grupoBACHILLERATO');
                BACHILLERATORadioButtonList.SetEnabled(false);
                ASPxClientEdit.ClearGroup('grupoTECNOLOGICA');
                TECNOLOGICARadioButtonList.SetEnabled(true);
                ASPxClientEdit.ClearGroup('grupoUNIVERSITARIA');
                UNIVERSITARIARadioButtonList.SetEnabled(false);
                break;
            case 'UNIVERSITARIA':
                ASPxClientEdit.ClearGroup('grupoEDUCACION_BASICA');
                EDUCACION_BASICARadioButtonList.SetEnabled(false);
                ASPxClientEdit.ClearGroup('grupoBACHILLERATO');
                BACHILLERATORadioButtonList.SetEnabled(false);
                ASPxClientEdit.ClearGroup('grupoTECNOLOGICA');
                TECNOLOGICARadioButtonList.SetEnabled(false);
                ASPxClientEdit.ClearGroup('grupoUNIVERSITARIA');
                UNIVERSITARIARadioButtonList.SetEnabled(true);
                break;
        }
    }
</script>

<dx:ASPxCallbackPanel runat="server" ID="cMantSOLICITUDES" ClientInstanceName="cMantSOLICITUDES" ShowLoadingPanel="false">  
<ClientSideEvents EndCallback="function(s, e){
                                    MostrarPanelModal(false,'');
                                    if(s.cpResultCallback != undefined){
                                        switch(s.cpResultCallback){
                                            case 'ValidarCamposRequeridos':
                                                ASPxClientEdit.ValidateEditorsInContainer(null,null,true);
                                                break;
                                            case 'DatosDomicilioCopiados':
                                                ASPxClientEdit.ValidateEditorsInContainer(null,null,true);
                                                break;
                                            case 'MostrarBusquedaParticipantes':
                                                popupParticipantes.Show();
                                                popupParticipantes.SetSize(400, 0);
                                                popupParticipantes.UpdatePosition();  
                                                break;
                                            case 'ParticipanteSobrepasaCuota':
                                                CargarCursosRecParticipanteEjercicio(s.cpIdParticipante, s.cpIdEjercicio);
                                                break;
                                            case 'MostrarCursosDelParticipante':
                                                popupCursosRecibidosParticipante.Show();
                                                popupCursosRecibidosParticipante.SetSize(400, 0);
                                                popupCursosRecibidosParticipante.UpdatePosition();                                                
                                                break;
                                            default:
                                                if(s.cpResultCallback !=''){                                                   
                                                    AsignarMensaje(s.cpResultCallback);
                                                    SetContenido(380, 0);
                                                }
                                                break;
                                        }                                       
                                    }
                                }"      />     
        <PanelCollection>        
            <dx:PanelContent runat="server">   
                <table id="TableMant" cellspacing="0" cellpadding="0" width="100%" border="0">
                    <tr>
                        <td>
                        <uc1:ucBarraNavegacion id="ucBarraNavegacion1" HabilitarCallBacks="true" runat="server"></uc1:ucBarraNavegacion>
                        </td>
                    </tr>
                    <tr>
		               <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">GESTION DE SOLICITUDES</asp:Label></td>
		           </tr>
		           <tr>
			           <td><asp:Image ID="Image2" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></td>
		           </tr>
                    <tr>
	                    <td>
	                    <uc1:uccriteriossolicitudes ID="ucCriteriosSolicitudes1"  runat="server" />
	                    </td>   
                    </tr>
                    <tr>
                        <td>
                        <asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" />
                        </td>
                    </tr>		  
                    <tr>
                        <td>
                        <uc1:ucVistaDetalleSOLICITUD_INSCRIPCION_AF2 ID="ucVistaDetalleSOLICITUD_INSCRIPCION_AF2" runat="server"></uc1:ucVistaDetalleSOLICITUD_INSCRIPCION_AF2>
                        </td>
                    </tr>
                    <tr>	       
                        <td>
                        <uc1:ucListaSOLICITUD_INSCRIPCION_AF ID="ucListaSOLICITUD_INSCRIPCION_AF1" runat="server" 
                            PermitirEditar="false" PermitirEliminar="false" PermitirSeleccionar="false" PermitirSeleccionParaCombo="true" PermitirRowHotTrack="true"
                            PermitirFocoEnFilas="false" TamanoPagina="30"    
                            VerID_SOLICITUD="true" VerFECHA_PRESENTACION="true" VerOBSERVACION="true" 
                            VerAPELLIDOS="true" VerNOMBRES="true" VerNOMBRE_ACCION_FORMATIVA="true" VerCODIGO_GRUPO="true" VerNOMBRE_SITIO="true" VerESTADO_SOLICITUD="true"   />                                   
                        </td>    
                    </tr>
                </table>
 
 <dx:ASPxPopupControl ID="popupParticipantes" Modal="true" runat="server" 
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" PopupElementID="BuscarNombresbtn" 
        AllowResize="False" DragElement="Header" HeaderStyle-Font-Bold="true" HeaderText="Listado de Participantes"   
        AllowDragging="True" ClientInstanceName="popupParticipantes" ShowShadow="true"
        CloseAction="CloseButton">  
                 <ContentCollection>
                     <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server" >          
                        <table>               
                            <tr>
                                <td><dx:ASPxLabel ID="popuplblMensaje2" ClientInstanceName="popuplblMensaje2" 
                                        Text="Haga doble-click sobre el Participante para cargar la información en la solicitud." 
                                        runat="server" Font-Names="Arial,Helveltica" Font-Size="XX-Small" 
                                        Font-Bold="True" ForeColor="#0033CC"  />
                                    <br />
                                    <dx:ASPxLabel ID="lblMensajeGrid" runat="server" 
                                        ClientInstanceName="popuplblMensaje2" Font-Bold="True" 
                                        Font-Names="Arial,Helveltica" Font-Size="XX-Small" 
                                        ForeColor="#0033CC" Visible="false"   
                                        
                                        Text="Existen uno o varios Participantes que coinciden con algunos datos del nuevo participante. Busque en la lista el participante que coincida con el que usted esta ingresando y si lo encuentra haga doble-clic sobre el participante. En caso que ninguno corresponda haga clic en el botón 'Confirmo que no encontre coincidencias'." 
                                        Width="700px">
                                    </dx:ASPxLabel>
                                </td>
                            </tr>                            
                            <tr>
                                <td>
                                    <uc1:ucListaPARTICIPANTE id="ucListaPARTICIPANTE1" runat="server" 
                                     VerID_PARTICIPANTE="false" Visible="true"  
                                     VerNOMBRES="true" VerAPELLIDOS="true" VerGENERO="false"
                                     VerID_PAIS="false" VerFECHA_NACIMIENTO="true" VerDIRECCION="true"
                                     VerDUI="true" VerNIT="true" VerISSS="false" VerTIPO_DOCTO="false"
                                     VerNUM_DOCTO="false" VerTELEFONO="true" VerMOVIL="true" VerEMAIL="false"
                                     VerID_ESTADO_CIVIL="false" VerPROFESION_OFICIO="false" VerOCUPACION_ACTUAL="false"
                                     VerTITULO_CERTIFICADO_OBTENIDO="false" VerDEPARTAMENTO_NAC="false" VerMUNICIPIO_NAC="false"
                                     VerCODIGO_DEPARTAMENTO="false" VerCODIGO_MUNICIPIO="false" VerID_NIVEL_ACADEMICO="false"
                                     VerOTRA_EDUCACION_FORMAL="false" VerCON_DISCAPACIDAD="false" VerDISC_OTRA="false"
                                     VerLASTUPDATE="false" VerUSERID="false" PermitirFiltroEnEncabezado="false" PermitirSeleccionParaCombo="true"   
                                     PermitirEditar="false" PermitirEditarInline="false" PermitirEliminar="false"    
                                     NombreFuente= "Verdana" TamanoFuente ="X-Small" TamanoPagina="4"                                                                           
                                    />                                    
                                </td>
                            </tr>
                            <tr>
                                <td>
                                <dx:ASPxButton ID="btnConfirmacion" runat="server" 
                                        Text="Confirmo que no encontre coincidencias" 
                                        CssFilePath="~/App_Themes/BlackGlass/{0}/styles.css" CssPostfix="BlackGlass" 
                                        SpriteCssFilePath="~/App_Themes/BlackGlass/{0}/sprite.css" 
                                        style="font-family: Arial, Helvetica, sans-serif; font-size: xx-small" 
                                        Width="271px" Visible="false" AutoPostBack="false" >
                                            <ClientSideEvents Click="function(s,e){
                                                                        popupParticipantes.Hide();
                                                                        GuardarSolicitud('GuardarConCoincidencias');
                                                                     }" />                                                  
                                        </dx:ASPxButton>
                                </td>
                            </tr>
                        </table>             
                     </dx:PopupControlContentControl>
                 </ContentCollection>

                <HeaderStyle Font-Bold="True"></HeaderStyle>
   </dx:ASPxPopupControl> 
            
    <dx:ASPxPopupControl ID="popupCursosRecibidosParticipante" Modal="true" runat="server" 
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" PopupElementID="BuscarNombresbtn" 
        AllowResize="True" DragElement="Header" HeaderStyle-Font-Bold="true" HeaderText="Cursos"   
        AllowDragging="True" ClientInstanceName="popupCursosRecibidosParticipante" ShowShadow="true"
        CloseAction="CloseButton">  
     <ContentCollection>
         <dx:PopupControlContentControl ID="PopupControlContentControl2" runat="server" >  
                <table width="100%" >
                    <tr>
                        <td align="center">
                        <dx:ASPxLabel ID="CursosRecibidosMsjlbl" runat="server" Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small" Font-Bold="True"  />
                        </td>
                    </tr>
                    <tr>
                        <td>
                        <dx:ASPxLabel ID="CursosRecibidosPartlbl" runat="server" Text="Cursos en los que esta inscrito el Participante" Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <dx:ASPxGridView ID="gridCursos" runat="server" DataSourceID="odsCursosRecibidos" Width="100%" AutoGenerateColumns="false" >
                                <Columns>
                                    <dx:GridViewDataColumn FieldName="AREA_FORMACION" Caption="Area de Formación"  VisibleIndex="0" />
                                    <dx:GridViewDataColumn FieldName="NOMBRE_ACCION_FORMATIVA" Caption="Curso"  VisibleIndex="1" />                            
                                </Columns>       
                                <Settings ShowHeaderFilterButton="false"  ShowFilterRow="false" />
                                <SettingsBehavior AllowSort="false" />
                                <SettingsPager Mode="ShowAllRecords"  /> 
                                <SettingsCustomizationWindow Enabled="True" />                                            
                            </dx:ASPxGridView>                                            
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <hr />
                        </td>
                    </tr>
                    <tr>
                        <td>                            
                            <dx:ASPxLabel ID="CursosRecibidosPartCentrolbl" runat="server" Text="Centros de Formación en los que esta inscrito"  Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <dx:ASPxGridView ID="gridCentroFormacion" runat="server" DataSourceID="odsCursosRecibidosPorCentro" Width="100%" AutoGenerateColumns="false" >
                                <Columns>
                                    <dx:GridViewDataColumn FieldName="NOMBRE_PROVEEDOR" Caption="Institución"  VisibleIndex="0" />
                                    <dx:GridViewDataColumn FieldName="NOMBRE_SITIO" Caption="Centro de Formación"  VisibleIndex="1" />                            
                                </Columns>       
                                <Settings ShowHeaderFilterButton="false"  ShowFilterRow="false" />
                                <SettingsPager Mode="ShowAllRecords"  /> 
                                <SettingsCustomizationWindow Enabled="True" />                                            
                            </dx:ASPxGridView>
                        </td>
                    </tr>
                </table> 
        </dx:PopupControlContentControl>
    </ContentCollection>
    <HeaderStyle Font-Bold="True"></HeaderStyle>
    </dx:ASPxPopupControl>        
                
      
       <dx:ASPxHiddenField runat="server" ID="hf" /> 
       </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>



 <asp:ObjectDataSource ID="odsCursosRecibidosPorCentro" runat="server" OldValuesParameterFormatString="original_{0}"                                                 
    SelectMethod="GetCursosPorIDParticipanteEjercicio" TypeName="SGAFP.DL.DS_DLTableAdapters.ProveedorCentroFormacionCursosRecPartTableAdapter">
    <SelectParameters>                                                                         
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_EJERCICIO"  Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsCursosRecibidos" runat="server" OldValuesParameterFormatString="original_{0}"                                                 
    SelectMethod="GetCursosPorIDParticipanteEjercicio" TypeName="SGAFP.DL.DS_DLTableAdapters.CursosRecibidosParticipanteTableAdapter">
    <SelectParameters>                                                                         
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_EJERCICIO"  Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>  
<dx:ASPxLoadingPanel ID="LoadingPanel" runat="server" ClientInstanceName="LoadingPanel" Text="Cargando..."  Modal="True" />