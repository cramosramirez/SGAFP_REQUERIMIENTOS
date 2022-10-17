<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaSOLICITUD_INSCRIPCION_AF.ascx.vb" Inherits="controles_ucListaSOLICITUD_INSCRIPCION_AF" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>

<style type="text/css">       
       .textUpper input{text-transform:uppercase;}                          
    .style1
    {
        width: 400px;
    }
</style>
<script language="javascript" type="text/javascript">
    var _estadoPropuesto;
    var _visibleIndex_dxgvLista;
    
    function MostrarPopupCambioEstado(estado, id) {
        _visibleIndex_dxgvLista = id;
        _estadoPropuesto = estado;
        
        if(estado == 'Anular'){
            lblMensajePopupListaSolic.SetValue('Ingrese el motivo de la <span style="font-weight:bold; color:Red;">ANULACIÓN</span> de la Solicitud');
        }
        else if(estado == 'Rechazar') {
        lblMensajePopupListaSolic.SetValue('Ingrese el motivo del <span style="font-weight:bold; color:Red;">RECHAZO</span> de la Solicitud');
        } else if (estado == 'CambiarDeGrupo') {
        lblMensajePopupListaSolic.SetValue('Ingrese el motivo de <span style="font-weight:bold; color:Green;">CAMBIO DE CURSO</span> de la Solicitud');
        } else if (estado == 'Revertir') {
            lblMensajePopupListaSolic.SetValue('Ingrese el motivo de <span style="font-weight:bold; color:Green;">REVERSIÓN DE ESTADO</span> de la Solicitud');
        }
        popupListaSolicitudes.SetSize(400, 0);
        popupListaSolicitudes.Show();
        popupListaSolicitudes.UpdatePosition();
    }       
</script>
<dx:ASPxCallbackPanel runat="server" ID="cbpucListaSOLICITUD_INSCRIPCION_AF" ClientInstanceName="cbpucListaSOLICITUD_INSCRIPCION_AF" ShowLoadingPanel="true" LoadingPanelText="Cargando..."  >    
<ClientSideEvents EndCallback="function(s,e){memMotivo.SetText('');}" /> 
        <PanelCollection>        
            <dx:PanelContent ID="PanelContent1" runat="server">  
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" KeyFieldName="ID_SOLICITUD" CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx"  >
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents CustomButtonClick="function(s,e){
                                            switch(e.buttonID){
                                                case 'btnEditar':
                                                    EditarSolicitud('Editar;' + s.cpKeyValues[e.visibleIndex]);                                                    
                                                    break;
                                                case 'btnAnular':                                                    
                                                    MostrarPopupCambioEstado('Anular',e.visibleIndex.toString());
                                                    break;
                                                case 'btnCambiarDeGrupo':
                                                    MostrarPopupCambioEstado('CambiarDeGrupo',e.visibleIndex.toString());
                                                    break;
                                                case 'btnRechazar':
                                                    MostrarPopupCambioEstado('Rechazar',e.visibleIndex.toString());
                                                    break;
                                                case 'btnRevertirEstado':                                                    
                                                    MostrarPopupCambioEstado('Revertir',e.visibleIndex.toString());
                                                    break;
                                                case 'btnDesertar':                                                    
                                                    MostrarPopupCambioEstado('Desertar',e.visibleIndex.toString());
                                                    break;
                                                case 'btnVerReporte':
                                                    window.open('../reportes/wfReporteSolicitudfInscripcion.aspx?IDS=' + s.cpKeyValues[e.visibleIndex],'_blank','');
                                                    break;
                                                default:
                                                    e.processOnServer = true;
                                                    break;    
                                            }
                                        }"  
                                         RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" 
                                         EndCallback="function(s, e){
                                                        if(s.cpResultCallback!=undefined){
                                                            if(s.cpResultCallback=='ParticipanteSobrepasaCuota'){
                                                                CargarCursosRecParticipanteEjercicio(s.cpIdParticipante, s.cpIdEjercicio);
                                                            }
                                                        }
                                                    }"                                        
                                        />
    <Columns>
        <dx:GridViewCommandColumn Name="Edicion" Visible="False" ButtonType="Image" CellStyle-HorizontalAlign="Center" Caption=" " VisibleIndex="0" Width="70px"  >
            <NewButton Visible="False" Text="Agregar" />
            <EditButton Visible="False" Text="Editar" />
            <DeleteButton Visible="False" Text="Eliminar" />           

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewCommandColumn>     
        
        <dx:GridViewCommandColumn Name="colEditar" Visible="True" ButtonType="Image" CellStyle-Border-BorderStyle="None" CellStyle-HorizontalAlign="Center" Caption=" " VisibleIndex="0" Width="20px"  >
            <CustomButtons>      
                 <dx:GridViewCommandColumnCustomButton ID="btnEditar" Text="Editar Solicitud" 
                     Image-Url="../imagenes/modificar.png" >   
<Image Url="../imagenes/modificar.png"></Image>
                 </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>

<CellStyle HorizontalAlign="Center">
<Border BorderStyle="None"></Border>
</CellStyle>
        </dx:GridViewCommandColumn>  
        <dx:GridViewCommandColumn Name="colAprobar" Visible="True" ButtonType="Image" CellStyle-Border-BorderStyle="None" CellStyle-HorizontalAlign="Center" Caption=" " VisibleIndex="0" Width="20px"  >
            <CustomButtons>      
                 <dx:GridViewCommandColumnCustomButton ID="btnAprobar" Text="Aprobar Solicitud" 
                     Image-Url="../imagenes/aprobar.gif" >    
<Image Url="../imagenes/aprobar.gif"></Image>
                 </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>

<CellStyle HorizontalAlign="Center">
<Border BorderStyle="None"></Border>
</CellStyle>
        </dx:GridViewCommandColumn>  
        <dx:GridViewCommandColumn Name="colRechazar" Visible="True" ButtonType="Image" CellStyle-Border-BorderStyle="None" CellStyle-HorizontalAlign="Center" Caption=" " VisibleIndex="0" Width="20px"  >
            <CustomButtons>      
                 <dx:GridViewCommandColumnCustomButton ID="btnRechazar" 
                     Text="Rechazar Solicitud" Image-Url="../imagenes/rechazar.png"> 
<Image Url="../imagenes/rechazar.png"></Image>
                 </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>

<CellStyle HorizontalAlign="Center">
<Border BorderStyle="None"></Border>
</CellStyle>
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn Name="colEspera" Visible="True" ButtonType="Image" CellStyle-Border-BorderStyle="None" CellStyle-HorizontalAlign="Center" Caption=" " VisibleIndex="0" Width="20px"  >
            <CustomButtons>      
                 <dx:GridViewCommandColumnCustomButton ID="btnEspera" 
                     Text="Poner en Espera de cupo" Image-Url="../imagenes/espera.png"> 
<Image Url="../imagenes/espera.png"></Image>
                 </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>

<CellStyle HorizontalAlign="Center">
<Border BorderStyle="None"></Border>
</CellStyle>
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn Name="colAnular" Visible="True" ButtonType="Image" CellStyle-Border-BorderStyle="None" CellStyle-HorizontalAlign="Center" Caption=" " VisibleIndex="0" Width="20px"  >
            <CustomButtons>      
                 <dx:GridViewCommandColumnCustomButton ID="btnAnular" Text="Anular Solicitud" 
                     Image-Url="../imagenes/anular.gif" > 
<Image Url="../imagenes/anular.gif"></Image>
                 </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>

<CellStyle HorizontalAlign="Center">
<Border BorderStyle="None"></Border>
</CellStyle>
        </dx:GridViewCommandColumn>

        <dx:GridViewCommandColumn Name="colDesertar" Visible="True" ButtonType="Image" CellStyle-Border-BorderStyle="None" CellStyle-HorizontalAlign="Center" Caption=" " VisibleIndex="0" Width="20px"  >
            <CustomButtons>      
                 <dx:GridViewCommandColumnCustomButton ID="btnDesertar" Text="Desercion de participante" 
                     Image-Url="../imagenes/Users-Exit-icon.png" > 
<Image Url="../imagenes/Users-Exit-icon.png"></Image>
                 </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>

<CellStyle HorizontalAlign="Center">
<Border BorderStyle="None"></Border>
</CellStyle>
        </dx:GridViewCommandColumn>

        <dx:GridViewCommandColumn Name="colCambioGrupo" Visible="True" ButtonType="Image" CellStyle-Border-BorderStyle="None" CellStyle-HorizontalAlign="Center" Caption=" " VisibleIndex="0" Width="20px"  >
            <CustomButtons>      
                 <dx:GridViewCommandColumnCustomButton ID="btnCambiarDeGrupo" 
                     Text="Cambiar de Curso" Image-Url="../imagenes/people.png" >      
<Image Url="../imagenes/people.png"></Image>
                 </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>

<CellStyle HorizontalAlign="Center">
<Border BorderStyle="None"></Border>
</CellStyle>
        </dx:GridViewCommandColumn>
<dx:GridViewCommandColumn Name="colRevertir" ButtonType="Image"  CellStyle-BorderLeft-BorderStyle="None"
                    CellStyle-BorderTop-BorderStyle="None" CellStyle-BorderBottom-BorderStyle="None"   
                    CellStyle-HorizontalAlign="Center" Caption="..." VisibleIndex="0" Width="15px" Visible="false"  >
            <CustomButtons>      
                 <dx:GridViewCommandColumnCustomButton ID="btnRevertirEstado" Text="Revertir estado" 
                     Image-Url="../imagenes/down.png" >  
<Image Url="../imagenes/down.png"></Image>
                 </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>

<CellStyle HorizontalAlign="Center">
<BorderLeft BorderStyle="None"></BorderLeft>

<BorderTop BorderStyle="None"></BorderTop>

<BorderBottom BorderStyle="None"></BorderBottom>
</CellStyle>
        </dx:GridViewCommandColumn>

        <dx:GridViewCommandColumn Name="colReporte" Visible="True" ButtonType="Image"  CellStyle-BorderLeft-BorderStyle="None"
                    CellStyle-BorderTop-BorderStyle="None" CellStyle-BorderBottom-BorderStyle="None"   
                    CellStyle-HorizontalAlign="Center" Caption=" " VisibleIndex="0" Width="15px"  >
            <CustomButtons>      
                 <dx:GridViewCommandColumnCustomButton ID="btnVerReporte" Text="Ver Solicitud" 
                     Image-Url="../imagenes/imprimir.gif" >  
<Image Url="../imagenes/imprimir.gif"></Image>
                 </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>

<CellStyle HorizontalAlign="Center">
<BorderLeft BorderStyle="None"></BorderLeft>

<BorderTop BorderStyle="None"></BorderTop>

<BorderBottom BorderStyle="None"></BorderBottom>
</CellStyle>
        </dx:GridViewCommandColumn>
        
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="1">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" Name="Seleccion_Edicion">
            <DataItemTemplate>
                <asp:LinkButton ID="lbtnEditar" runat="server" CommandName="Editar" 
                    CommandArgument='<%# Bind("ID_SOLICITUD") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_SOLICITUD") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataColumn VisibleIndex="2" Caption="N°" FieldName="CORRELATIVO" UnboundType="Integer"  />
        <dx:GridViewDataTextColumn FieldName="ID_SOLICITUD" ReadOnly="True" VisibleIndex="2" Caption="Id Solic."  Visible="False" />
        <dx:GridViewDataTextColumn FieldName="FECHA_PRESENTACION" VisibleIndex="3" Caption="Presentacion" Visible="False" >
            <PropertiesTextEdit DisplayFormatString="{0:d}" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_PARTICIPANTE" VisibleIndex="4" Caption="Id participante" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="ID_ACCION_FORMATIVA" VisibleIndex="5" Caption="Id accion formativa" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="ID_ESTADO_SOLICITUD" VisibleIndex="6" Caption="Id estado solicitud" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="APELLIDOS" VisibleIndex="7" Caption="Apellidos" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="NOMBRES" VisibleIndex="8" Caption="Nombres"  Visible="False" />
        <dx:GridViewDataTextColumn FieldName="DUI" VisibleIndex="9" Caption="Dui" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="TIPO_DOCTO" VisibleIndex="10" Caption="Tipo docto"  Visible="False" />
        <dx:GridViewDataTextColumn FieldName="NUM_DOCTO" VisibleIndex="11" Caption="Num docto"  Visible="False" />
        <dx:GridViewDataTextColumn FieldName="NIT" VisibleIndex="12" Caption="Nit"  Visible="False" />
        <dx:GridViewDataTextColumn FieldName="ISSS" VisibleIndex="13" Caption="Isss"  Visible="False" />
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_SOLICITUD" VisibleIndex="14" Caption="Id tipo solicitud"  Visible="False" />
        <dx:GridViewDataTextColumn FieldName="ID_PAIS" VisibleIndex="15" Caption="Id pais" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="DEPARTAMENTO_NAC" VisibleIndex="16" Caption="Departamento nac"  Visible="False" />
        <dx:GridViewDataTextColumn FieldName="MUNICIPIO_NAC" VisibleIndex="17" Caption="Municipio nac" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="FECHA_NACIMIENTO" VisibleIndex="18" Caption="Fecha nacimiento" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="GENERO" VisibleIndex="19" Caption="Genero" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="EDAD" VisibleIndex="20" Caption="Edad" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="MIEMBROS_GRUPO_FAMILIAR" VisibleIndex="21" Caption="Miembros grupo familiar" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="ID_ESTADO_CIVIL" VisibleIndex="22" Caption="Id estado civil" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="ES_JEFE_HOGAR" VisibleIndex="23" Caption="Es jefe hogar" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="TIENE_HIJOS" VisibleIndex="24" Caption="Tiene hijos" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="NO_DE_HIJOS" VisibleIndex="25" Caption="No de hijos" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="SE_DEDICA_ALGUNA_PROFESION" VisibleIndex="26" Caption="Se dedica alguna profesion" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="PROFESION_OFICIO" VisibleIndex="27" Caption="Profesion oficio" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="DIRECCION" VisibleIndex="28" Caption="Direccion" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_DEPARTAMENTO" VisibleIndex="29" Caption="Codigo departamento" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_MUNICIPIO" VisibleIndex="30" Caption="Codigo municipio" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="TELEFONO" VisibleIndex="31" Caption="Telefono" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="MOVIL" VisibleIndex="32" Caption="Movil" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="EMAIL" VisibleIndex="33" Caption="Email" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="CON_DISCAPACIDAD" VisibleIndex="34" Caption="Con discapacidad" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="DISC_OTRA" VisibleIndex="35" Caption="Disc otra" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="ID_LEE_ESCRIBE" VisibleIndex="36" Caption="Id lee escribe" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="ID_NIVEL_ACADEMICO" VisibleIndex="37" Caption="Id nivel academico" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="OTRA_EDUCACION_FORMAL" VisibleIndex="38" Caption="Otra educacion formal" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="TITULO_CERTIFICADO_OBTENIDO" VisibleIndex="39" Caption="Titulo certificado obtenido" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="ESTUDIA_ACTUALMENTE" VisibleIndex="40" Caption="Estudia actualmente" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="ID_TIEMPO_DEJO_ESTUDIAR" VisibleIndex="41" Caption="Id tiempo dejo estudiar" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="RECIBIO_CURSO_ANTERIOR" VisibleIndex="42" Caption="Recibio curso anterior" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="BENEF_PROM_EMP_ACT" VisibleIndex="43" Caption="Benef prom emp act" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="BENEF_OBT_EMPLEO" VisibleIndex="44" Caption="Benef obt empleo" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="BENEF_OBT_ING_EXTRA" VisibleIndex="45" Caption="Benef obt ing extra" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="BENEF_CAMB_EMP_X_CURSO" VisibleIndex="46" Caption="Benef camb emp x curso" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="BENEF_TRAB_CTA_PROPIA" VisibleIndex="47" Caption="Benef trab cta propia" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="BENEF_OTRO" VisibleIndex="48" Caption="Benef otro" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="RAZON_NO_BENEFICIO" VisibleIndex="49" Caption="Razon no beneficio" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="OCUACT_TRABAJA" VisibleIndex="50" Caption="Ocuact trabaja" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="OCUACT_ESTUDIA" VisibleIndex="51" Caption="Ocuact estudia" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="OCUACT_DESOCUPADO" VisibleIndex="52" Caption="Ocuact desocupado" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="OCUACT_OFICIO_HOGAR" VisibleIndex="53" Caption="Ocuact oficio hogar" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="OCUACT_BUSCA_TRABAJO" VisibleIndex="54" Caption="Ocuact busca trabajo" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="OCUACT_OTRA" VisibleIndex="55" Caption="Ocuact otra" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_EMPLEO" VisibleIndex="56" Caption="Id tipo empleo" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="SECTOR_EMPLEO" VisibleIndex="57" Caption="Sector empleo" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="TRABAJO_ANTERIOR" VisibleIndex="58" Caption="Trabajo anterior" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="RECIBE_INGRESOS" VisibleIndex="59" Caption="Recibe ingresos" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="MANERA_OBT_ING_TRABAJO" VisibleIndex="60" Caption="Manera obt ing trabajo" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="MANERA_OBT_ING_AYUDA_FAM" VisibleIndex="61" Caption="Manera obt ing ayuda fam" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="MANERA_OBT_ING_REMESA" VisibleIndex="62" Caption="Manera obt ing remesa" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="MANERA_OBT_ING_PENSION" VisibleIndex="63" Caption="Manera obt ing pension" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="MANERA_OBT_ING_OTRO" VisibleIndex="64" Caption="Manera obt ing otro" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="EXPFOR_PROMOCION_EMPLEO" VisibleIndex="65" Caption="Expfor promocion empleo" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="EXPFOR_CAMBIAR_EMPLEO" VisibleIndex="66" Caption="Expfor cambiar empleo" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="EXPFOR_OBTENER_EMPLEO" VisibleIndex="67" Caption="Expfor obtener empleo" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="EXPFOR_TRABAJAR_CTA_PROPIA" VisibleIndex="68" Caption="Expfor trabajar cta propia" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="EXPFOR_INGRESOS_EXTRAS" VisibleIndex="69" Caption="Expfor ingresos extras" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="EXPFOR_NINGUNO" VisibleIndex="70" Caption="Expfor ninguno" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="EXPFOR_OTRO" VisibleIndex="71" Caption="Expfor otro" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="CURSO_REL_TRAB_ACTUAL" VisibleIndex="72" Caption="Curso rel trab actual" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="CURSO_REL_TRAB_NUEVO" VisibleIndex="73" Caption="Curso rel trab nuevo" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_REFERENCIA" VisibleIndex="74" Caption="Nombre referencia" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="ID_REFERENCIA" VisibleIndex="75" Caption="Id referencia" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="DIRECCION_REFERENCIA" VisibleIndex="76" Caption="Direccion referencia" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="DEPARTAMENTO_REFERENCIA" VisibleIndex="77" Caption="Departamento referencia" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="MUNICIPIO_REFERENCIA" VisibleIndex="78" Caption="Municipio referencia" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="TELEFONO_REFERENCIA" VisibleIndex="79" Caption="Telefono referencia" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="MOVIL_REFERENCIA" VisibleIndex="80" Caption="Movil referencia" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="EMAIL_REFERENCIA" VisibleIndex="81" Caption="Email referencia" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="SUGERENCIAS" VisibleIndex="82" Caption="Sugerencias" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="USERID" VisibleIndex="83" Caption="Userid" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="LASTUPDATE" VisibleIndex="84" Caption="Lastupdate" Visible="False" />
        
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ACCION_FORMATIVA" VisibleIndex="85" Caption="Curso" UnboundType="String" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_GRUPO" VisibleIndex="86" Caption="Codigo Grupo" UnboundType="String" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_SITIO" VisibleIndex="87" Caption="Centro Formación" UnboundType="String" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ESTADO_SOLICITUD" VisibleIndex="88" Caption="Estado" UnboundType="String" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="OBSERVACION" VisibleIndex="89" Caption="Observacion" UnboundType="String" Visible="false" />
                    
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
                        Name="Eliminar" VisibleIndex="90">
                        <CustomButtons>
                            <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                            </dx:GridViewCommandColumnCustomButton>
                        </CustomButtons>
                    </dx:GridViewCommandColumn>
	               </Columns>
                
                <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
                <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
            <Images SpriteCssFilePath="~/App_Themes/DevEx/{0}/sprite.css">
                <LoadingPanelOnStatusBar Url="~/App_Themes/DevEx/GridView/StatusBarLoading.gif">
                </LoadingPanelOnStatusBar>
                <LoadingPanel Url="~/App_Themes/DevEx/GridView/Loading.gif">
                </LoadingPanel>
    </Images>
    <ImagesFilterControl>
        <LoadingPanel Url="~/App_Themes/DevEx/GridView/Loading.gif">
        </LoadingPanel>
    </ImagesFilterControl>
    <Styles CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx">
        <Header ImageSpacing="5px" SortingImageSpacing="5px">
        </Header>
        <LoadingPanel ImageSpacing="5px">
        </LoadingPanel>
    </Styles>
    <StylesEditors ButtonEditCellSpacing="0">
        <ProgressBar Height="21px">
        </ProgressBar>
    </StylesEditors>
            </dx:ASPxGridView>
 <dx:ASPxHiddenField runat="server" ID="hf" /> 
 
 <dx:ASPxPopupControl ID="popupListaSolicitudes" Modal="true" runat="server" 
                    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" PopupElementID="BuscarNombresbtn" 
                    AllowResize="False" DragElement="Header" HeaderStyle-Font-Bold="true" HeaderText="Mensaje"    
                    AllowDragging="True" ClientInstanceName="popupListaSolicitudes" ShowShadow="true" EnableClientSideAPI="true"  
                    CloseAction="CloseButton">  
                 <ContentCollection>
                     <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server" >          
                        <table>               
                            <tr>
                                <td class="style1">
                                    <dx:ASPxLabel ID="lblMensajePopupListaSolic" ClientInstanceName="lblMensajePopupListaSolic" runat="server" Font-Names="Verdana,Arial,Tahoma" Font-Size="XX-Small" />
                                </td>
                            </tr>
                            <tr>
                                <td class="style1">
                                    <dx:ASPxMemo AutoResizeWithContainer="true" CssClass="textUpper" ID="memMotivo"  ClientInstanceName="memMotivo" runat="server" Height="71px" Width="400px"  />                          
                                </td>
                            </tr>
                            <tr>
                                <td align="center" class="style1" >
                                    <table width="50%">
                                        <tr align="center" >
                                            <td>
                                                <dx:ASPxButton ID="btnAceptarPopupListaSolic" ClientInstanceName="btnAceptarPopupListaSolic" 
                                                    AutoPostBack="false" CausesValidation="True" Text="Aceptar" runat="server" >                                                
                                                <ClientSideEvents Click="function(s,e){
                                                                                if(memMotivo.GetValue() != '' && memMotivo.GetValue() != null){                                                                                      
                                                                                    popupListaSolicitudes.Hide();                                                                                                                                                                                                                                                          
                                                                                    cbpucListaSOLICITUD_INSCRIPCION_AF.PerformCallback(_estadoPropuesto + ';' + _visibleIndex_dxgvLista + ';' + memMotivo.GetValue());                                                                                                                                                                     
                                                                                } 
                                                                                else{
                                                                                    AsignarMensaje('El Motivo es requerido para ' + _estadoPropuesto + ' la Solicitud');
                                                                                }                                                                                                                                               
                                                                            }" 
                                                />
                                                </dx:ASPxButton>
                                            </td>
                                            <td>
                                                <dx:ASPxButton ID="btnCancelarPopupListaSolic" ClientInstanceName="btnCancelarPopupListaSolic" 
                                                    AutoPostBack="false" CausesValidation="False" Text="Cancelar" runat="server" >                                                
                                                <ClientSideEvents Click="function(s,e){
                                                                                 popupListaSolicitudes.Hide();                                                                                                                           
                                                                            }" 
                                                />
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
                        
            
       </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>

 
 <asp:ObjectDataSource ID="odsListaPorCriterios" runat="server" SelectMethod="ObtenerListaPorCriterios"
    TypeName="SGAFP.BL.cSOLICITUD_INSCRIPCION_AF">
    <SelectParameters>
        <asp:Parameter DefaultValue="0" Name="idSolicitud" Type="Decimal"  />
        <asp:Parameter DefaultValue="0" Name="idProveedor" Type="Decimal" />
        <asp:Parameter DefaultValue="0" Name="idSitioCapacitacion" Type="Decimal" />
        <asp:Parameter DefaultValue="" Name="idEjercicio" Type="String" />
        <asp:Parameter DefaultValue="0" Name="idEstadoSolicitud" Type="Object"  />
        <asp:Parameter DefaultValue="0" Name="nombreAccionFormativa" Type="String" />
        <asp:Parameter DefaultValue="" Name="codigoGrupo" Type="String" />
        <asp:Parameter DefaultValue="" Name="nombresSolicitante" Type="String" />
        <asp:Parameter DefaultValue="" Name="apellidosSolicitante" Type="String" />        
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarSOLICITUD_INSCRIPCION_AF" DeleteMethod="EliminarSOLICITUD_INSCRIPCION_AF" UpdateMethod="ActualizarSOLICITUD_INSCRIPCION_AF"
    TypeName="SGAFP.BL.cSOLICITUD_INSCRIPCION_AF">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPARTICIPANTE" runat="server" 
    SelectMethod="ObtenerListaPorPARTICIPANTE" InsertMethod="AgregarSOLICITUD_INSCRIPCION_AF" DeleteMethod="EliminarSOLICITUD_INSCRIPCION_AF" UpdateMethod="ActualizarSOLICITUD_INSCRIPCION_AF"
    TypeName="SGAFP.BL.cSOLICITUD_INSCRIPCION_AF">
    <SelectParameters>
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorACCION_FORMATIVA" runat="server" 
    SelectMethod="ObtenerListaPorACCION_FORMATIVA" InsertMethod="AgregarSOLICITUD_INSCRIPCION_AF" DeleteMethod="EliminarSOLICITUD_INSCRIPCION_AF" UpdateMethod="ActualizarSOLICITUD_INSCRIPCION_AF"
    TypeName="SGAFP.BL.cSOLICITUD_INSCRIPCION_AF">
    <SelectParameters>
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorESTADO_SOLICITUD" runat="server" 
    SelectMethod="ObtenerListaPorESTADO_SOLICITUD" InsertMethod="AgregarSOLICITUD_INSCRIPCION_AF" DeleteMethod="EliminarSOLICITUD_INSCRIPCION_AF" UpdateMethod="ActualizarSOLICITUD_INSCRIPCION_AF"
    TypeName="SGAFP.BL.cSOLICITUD_INSCRIPCION_AF">
    <SelectParameters>
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIPO_SOLICITUD" runat="server" 
    SelectMethod="ObtenerListaPorTIPO_SOLICITUD" InsertMethod="AgregarSOLICITUD_INSCRIPCION_AF" DeleteMethod="EliminarSOLICITUD_INSCRIPCION_AF" UpdateMethod="ActualizarSOLICITUD_INSCRIPCION_AF"
    TypeName="SGAFP.BL.cSOLICITUD_INSCRIPCION_AF">
    <SelectParameters>
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPAIS" runat="server" 
    SelectMethod="ObtenerListaPorPAIS" InsertMethod="AgregarSOLICITUD_INSCRIPCION_AF" DeleteMethod="EliminarSOLICITUD_INSCRIPCION_AF" UpdateMethod="ActualizarSOLICITUD_INSCRIPCION_AF"
    TypeName="SGAFP.BL.cSOLICITUD_INSCRIPCION_AF">
    <SelectParameters>
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorESTADO_CIVIL" runat="server" 
    SelectMethod="ObtenerListaPorESTADO_CIVIL" InsertMethod="AgregarSOLICITUD_INSCRIPCION_AF" DeleteMethod="EliminarSOLICITUD_INSCRIPCION_AF" UpdateMethod="ActualizarSOLICITUD_INSCRIPCION_AF"
    TypeName="SGAFP.BL.cSOLICITUD_INSCRIPCION_AF">
    <SelectParameters>
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorEDUC_LEE_ESCRIBE" runat="server" 
    SelectMethod="ObtenerListaPorEDUC_LEE_ESCRIBE" InsertMethod="AgregarSOLICITUD_INSCRIPCION_AF" DeleteMethod="EliminarSOLICITUD_INSCRIPCION_AF" UpdateMethod="ActualizarSOLICITUD_INSCRIPCION_AF"
    TypeName="SGAFP.BL.cSOLICITUD_INSCRIPCION_AF">
    <SelectParameters>
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorNIVEL_ACADEMICO" runat="server" 
    SelectMethod="ObtenerListaPorNIVEL_ACADEMICO" InsertMethod="AgregarSOLICITUD_INSCRIPCION_AF" DeleteMethod="EliminarSOLICITUD_INSCRIPCION_AF" UpdateMethod="ActualizarSOLICITUD_INSCRIPCION_AF"
    TypeName="SGAFP.BL.cSOLICITUD_INSCRIPCION_AF">
    <SelectParameters>
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIEMPO_DEJO_ESTUDIAR" runat="server" 
    SelectMethod="ObtenerListaPorTIEMPO_DEJO_ESTUDIAR" InsertMethod="AgregarSOLICITUD_INSCRIPCION_AF" DeleteMethod="EliminarSOLICITUD_INSCRIPCION_AF" UpdateMethod="ActualizarSOLICITUD_INSCRIPCION_AF"
    TypeName="SGAFP.BL.cSOLICITUD_INSCRIPCION_AF">
    <SelectParameters>
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIPO_EMPLEO" runat="server" 
    SelectMethod="ObtenerListaPorTIPO_EMPLEO" InsertMethod="AgregarSOLICITUD_INSCRIPCION_AF" DeleteMethod="EliminarSOLICITUD_INSCRIPCION_AF" UpdateMethod="ActualizarSOLICITUD_INSCRIPCION_AF"
    TypeName="SGAFP.BL.cSOLICITUD_INSCRIPCION_AF">
    <SelectParameters>
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorREFERENCIA" runat="server" 
    SelectMethod="ObtenerListaPorREFERENCIA" InsertMethod="AgregarSOLICITUD_INSCRIPCION_AF" DeleteMethod="EliminarSOLICITUD_INSCRIPCION_AF" UpdateMethod="ActualizarSOLICITUD_INSCRIPCION_AF"
    TypeName="SGAFP.BL.cSOLICITUD_INSCRIPCION_AF">
    <SelectParameters>
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorDEPARTAMENTO" runat="server" 
    SelectMethod="ObtenerListaPorDEPARTAMENTO" InsertMethod="AgregarSOLICITUD_INSCRIPCION_AF" DeleteMethod="EliminarSOLICITUD_INSCRIPCION_AF" UpdateMethod="ActualizarSOLICITUD_INSCRIPCION_AF"
    TypeName="SGAFP.BL.cSOLICITUD_INSCRIPCION_AF">
    <SelectParameters>
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="TIEMP_TIEMPO_COMPLETO" Type="Decimal" />
        <asp:Parameter Name="TIEMP_NEG_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="TIEMP_INDEP_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="TIEMP_TIEMPO_PARCIAL" Type="Decimal" />
        <asp:Parameter Name="TIEMP_TRABAJO_INFORMAL" Type="Decimal" />
        <asp:Parameter Name="TIEMP_TEMPORAL" Type="Decimal" />
        <asp:Parameter Name="TIEMP_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="TIEMP_TIEMPO_COMPLETO" Type="Decimal" />
        <asp:Parameter Name="TIEMP_NEG_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="TIEMP_INDEP_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="TIEMP_TIEMPO_PARCIAL" Type="Decimal" />
        <asp:Parameter Name="TIEMP_TRABAJO_INFORMAL" Type="Decimal" />
        <asp:Parameter Name="TIEMP_TEMPORAL" Type="Decimal" />
        <asp:Parameter Name="TIEMP_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorMUNICIPIO" runat="server" 
    SelectMethod="ObtenerListaPorMUNICIPIO" InsertMethod="AgregarSOLICITUD_INSCRIPCION_AF" DeleteMethod="EliminarSOLICITUD_INSCRIPCION_AF" UpdateMethod="ActualizarSOLICITUD_INSCRIPCION_AF"
    TypeName="SGAFP.BL.cSOLICITUD_INSCRIPCION_AF">
    <SelectParameters>
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="TIEMP_TIEMPO_COMPLETO" Type="Decimal" />
        <asp:Parameter Name="TIEMP_NEG_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="TIEMP_INDEP_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="TIEMP_TIEMPO_PARCIAL" Type="Decimal" />
        <asp:Parameter Name="TIEMP_TRABAJO_INFORMAL" Type="Decimal" />
        <asp:Parameter Name="TIEMP_TEMPORAL" Type="Decimal" />
        <asp:Parameter Name="TIEMP_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="TIEMP_TIEMPO_COMPLETO" Type="Decimal" />
        <asp:Parameter Name="TIEMP_NEG_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="TIEMP_INDEP_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="TIEMP_TIEMPO_PARCIAL" Type="Decimal" />
        <asp:Parameter Name="TIEMP_TRABAJO_INFORMAL" Type="Decimal" />
        <asp:Parameter Name="TIEMP_TEMPORAL" Type="Decimal" />
        <asp:Parameter Name="TIEMP_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>