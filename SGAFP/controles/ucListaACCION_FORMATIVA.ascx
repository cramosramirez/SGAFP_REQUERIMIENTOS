<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaACCION_FORMATIVA.ascx.vb" Inherits="controles_ucListaACCION_FORMATIVA" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxMenu" tagprefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxHiddenField" tagprefix="dx" %>
<style type="text/css">
    #Formulario td.label {
    text-align: right;
    white-space: nowrap;
    padding-bottom: 2px;
    }
    #Formulario td.label .dxeBase
    {
	    font-size: 9pt;
    }
    #Formulario td.label span.star {
        color: #E9786E;
    }
    
    #Formulario .buttonCell
    {
	    padding-left: 5px;
	    padding-top: 10px;
    }
    #Formulario .formButton
    {
	    font: 8pt Tahoma;
	    width: 72px;
	    height: 22px;
    }
</style>
<script language="javascript" type="text/javascript">
    var rutaReporteParticipantesInscritos = '';
    var rutaReporteAsistenciaReal = '';
    var rutaReporteFormularioF8 = '';
    var fecha_inicial;
    var fecha_final;
    var rutaReporteSolicitudParticipantesInscritosPATI = '';
      
    function OnFechaInicioValidacion(s, e) {
        var f = e.value;
        fecha_inicial = f;
        if (f == null)
            return;        
    }
    function OnFechaFinValidacion(s, e) {
        var f = e.value;
        fecha_final = f;
        if (f == null)
            return;
    }
    function OnAceptarButtonClick(s, e) {
        if (ASPxClientEdit.ValidateGroup('Editor1')) {
            if (fecha_inicial > fecha_final) {
                AsignarMensaje('Fecha de inicio real debe der menor que fecha de finalización real');
                e.isValid = false;
            }
            else {
                dxgvListaAF.UpdateEdit();
            }
        }
        else {
            e.isValid = false;
        }           
    }
    function OnCerrarButtonClick(s, e) {
        dxgvListaAF.CancelEdit();
    }
    function ConfigurarMenu(idAccionFormativa, e, index) {
        var subMenuParticipantesInscritos = MenuCursos.GetItemByName('ParticipantesInscritos');
        var subMenuAsistenciaReal = MenuCursos.GetItemByName('AsistenciaReal');
        var subMenuFormularioF8 = MenuCursos.GetItemByName('FormularioF8');
        var subMenuParticipantesPreInscritos = MenuCursos.GetItemByName('ParticipantesPreInscritos');

        if (rutaReporteParticipantesInscritos == '')
            rutaReporteParticipantesInscritos = subMenuParticipantesInscritos.GetNavigateUrl();
        subMenuParticipantesInscritos.SetNavigateUrl(rutaReporteParticipantesInscritos + idAccionFormativa);

        if (rutaReporteAsistenciaReal == '')
            rutaReporteAsistenciaReal = subMenuAsistenciaReal.GetNavigateUrl();
        subMenuAsistenciaReal.SetNavigateUrl(rutaReporteAsistenciaReal + idAccionFormativa);
        
        if (dxgvListaAF.cpEstadoCurso[index] == '01') {
            subMenuAsistenciaReal.SetVisible(false);
            subMenuFormularioF8.SetVisible(false);
            subMenuParticipantesInscritos.SetVisible(false);
            MenuCursos.SetVisible(false);

            if (dxgvListaAF.cpProgramaCurso[index] == 'PATI') {
                MenuCursos.ShowAtPos(e.htmlEvent.clientX, e.htmlEvent.clientY);
                subMenuParticipantesPreInscritos.SetVisible(true);
                MenuCursos.SetVisible(true);
                
                if (rutaReporteSolicitudParticipantesInscritosPATI == '')
                    rutaReporteSolicitudParticipantesInscritosPATI = subMenuParticipantesPreInscritos.GetNavigateUrl();
                    subMenuParticipantesPreInscritos.SetNavigateUrl(rutaReporteSolicitudParticipantesInscritosPATI + idAccionFormativa);
                    MenuCursos.ShowAtPos(e.htmlEvent.clientX, e.htmlEvent.clientY);
                } else {
                subMenuParticipantesPreInscritos.SetVisible(false);
            }
            return;
        }

        if (dxgvListaAF.cpProgramaCurso[index] == 'HABIL' || dxgvListaAF.cpProgramaCurso[index] == 'PROESP' || dxgvListaAF.cpProgramaCurso[index] == 'EC') {
            if (dxgvListaAF.cpEstadoCurso[index] == '01' || dxgvListaAF.cpEstadoCurso[index] == '02') {
                subMenuParticipantesPreInscritos.SetVisible(false);
                subMenuAsistenciaReal.SetVisible(false);
            } else {
                subMenuAsistenciaReal.SetVisible(true);
            }
            subMenuFormularioF8.SetVisible(false);
        }

        if (dxgvListaAF.cpProgramaCurso[index] == 'PATI') {
        
            if (dxgvListaAF.cpEstadoCurso[index] == '02') {
                subMenuFormularioF8.SetVisible(true);
            } else {
                subMenuFormularioF8.SetVisible(false);
            }
            subMenuAsistenciaReal.SetVisible(false);
            subMenuParticipantesPreInscritos.SetVisible(false);
    
            if (rutaReporteFormularioF8 == '')
                rutaReporteFormularioF8 = subMenuFormularioF8.GetNavigateUrl();
            subMenuFormularioF8.SetNavigateUrl(rutaReporteFormularioF8 + idAccionFormativa);
        }

        if (dxgvListaAF.cpProgramaCurso[index] != 'HABIL' && dxgvListaAF.cpProgramaCurso[index] != 'PATI' && dxgvListaAF.cpProgramaCurso[index] != 'PROESP' && dxgvListaAF.cpProgramaCurso[index] != 'EC') {
            MenuCursos.SetVisible(false);
            return;
        }
        
        MenuCursos.ShowAtPos(e.htmlEvent.clientX, e.htmlEvent.clientY);
    }
</script>

<dx:ASPxCallbackPanel runat="server" ID="cbpucListaACCION_FORMATIVA" ClientInstanceName="cbpucListaACCION_FORMATIVA">    
        <PanelCollection>
            <dx:PanelContent ID="PanelContent1" runat="server"> 
            
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False"  Width="100%"  KeyFieldName="ID_ACCION_FORMATIVA" ClientInstanceName="dxgvListaAF" CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx">
    <ClientSideEvents EndCallback="function(s, e) {if(dxgvListaAF.cpMensaje != '' && dxgvListaAF.cpMensaje != undefined)AsignarMensaje(dxgvListaAF.cpMensaje);}"
        ContextMenu="function(s, e) { if(e.objectType != 'row') return; ConfigurarMenu(dxgvListaAF.keys[e.index],e,e.index); }" 
        CustomButtonClick="function(s,e){                                                  
                            switch(e.buttonID){
                                case 'btnInscripcion':                                                                                                     
                                    IngresarSolicitud(s.GetRowKey(e.visibleIndex));
                                    break;                               
                                default:
                                    e.processOnServer = true;
                                    break;  
                            }                                                                                                    
                      }"   />
    <Columns>
        <dx:GridViewCommandColumn ShowSelectCheckbox="True" Name="#" Caption="#" Visible="false" VisibleIndex="0" />      
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption="  " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" Caption="..." >
            <DataItemTemplate>
                <asp:LinkButton ID="lbtnEditar" runat="server" CommandName="Editar" 
                    CommandArgument='<%# Bind("ID_ACCION_FORMATIVA") %>'>Editar</asp:LinkButton>
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_ACCION_FORMATIVA") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>  
                <table>
                    <tr>
                        <td><asp:LinkButton ID="lbtnSolicitarReprogramacion" runat="server" CommandName="Reprogramar" 
                            Visible="False" CommandArgument='<%# Bind("ID_ACCION_FORMATIVA") %>'>Reprogramar</asp:LinkButton>
                        </td>
                        <td><asp:LinkButton ID="lbtnInformeParcial" runat="server" CommandName="InformeParcial"
                            Visible="False" CommandArgument='<%# Bind("ID_ACCION_FORMATIVA") %>'>Informe Parcial</asp:LinkButton>
                        </td>                        
                    </tr>
                </table>                              
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn VisibleIndex="2" Name="colVisitasSeguimientoEC"  Caption="..." Visible="false" Width="60px"  >
            <DataItemTemplate>
            <asp:LinkButton ID="lbtnVisitasSeguimientoEC" runat="server" CommandName="IngresoVisitasSeguimiento" 
                    CommandArgument='<%# Bind("ID_ACCION_FORMATIVA") %>'>Ingresar No. de visitas</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_ACCION_FORMATIVA" ReadOnly="True" 
            VisibleIndex="2" Caption="Id Curso" Width="50px"  />
        <dx:GridViewDataTextColumn FieldName="ID_OFERTA_FORMATIVA" VisibleIndex="3" />
        <dx:GridViewDataTextColumn FieldName="ID_SITIO_CAPACITACION" VisibleIndex="4" />
        <dx:GridViewDataTextColumn FieldName="ID_PROVEEDOR_AF" VisibleIndex="5" />
        <dx:GridViewDataTextColumn FieldName="ID_TEMA_CURSO" VisibleIndex="6" />
        <dx:GridViewDataTextColumn FieldName="ID_EJERCICIO" VisibleIndex="7" />
        <dx:GridViewDataTextColumn FieldName="INFO_CONTRATO" VisibleIndex="7" Settings-AutoFilterCondition="Contains"  UnboundType="String" Caption="Contrato" Visible="false"  />
        <dx:GridViewDataTextColumn Caption="Centro Formacion" FieldName="NOMBRE_SITIO" UnboundType="String" VisibleIndex="8" Visible="False"  />           
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" VisibleIndex="9" UnboundType="String" Caption="Proveedor" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ACCION_FORMATIVA" VisibleIndex="9" 
            Caption="Nombre Curso" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_GRUPO" VisibleIndex="10" 
            Caption="Codigo Grupo" />
        <dx:GridViewDataTextColumn FieldName="NUMERO_PARTICIPANTES" VisibleIndex="11" 
            Caption="Cupo" Width="50px" />
        <dx:GridViewDataTextColumn FieldName="PARTICIPANTES_INSCRITOS" 
            VisibleIndex="12" Caption="Inscritos" Width="50px" />               
        <dx:GridViewDataTextColumn FieldName="PARTICIPANTES_FINALES" VisibleIndex="12" Caption="Activos" UnboundType="Decimal" Visible="false" />                
        <dx:GridViewDataTextColumn FieldName="FECHA_INICIO_REAL" VisibleIndex="14" 
            Caption="Fecha Inicio" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy">
            </PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="FECHA_FIN_REAL" VisibleIndex="15" 
            Caption="Fecha Fin" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy">
            </PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="HORARIO" VisibleIndex="16" 
            Caption="Horario" />
        <dx:GridViewDataTextColumn FieldName="NOTAS" VisibleIndex="17" 
            Caption="Notas" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_ESTADO_AF" VisibleIndex="18" />
        <dx:GridViewDataTextColumn FieldName="DURACION_HORAS" VisibleIndex="19" 
            Caption="Duracion" />
        <dx:GridViewDataTextColumn FieldName="COSTO_X_PARTICIPANTE" VisibleIndex="20" 
                        Caption="Costo" />        
        <dx:GridViewDataTextColumn Caption="Departamento" FieldName="DEPARTAMENTO" UnboundType="String" VisibleIndex="20" /> 
        <dx:GridViewDataTextColumn Caption="Municipio" FieldName="MUNICIPIO" UnboundType="String" VisibleIndex="20" /> 
        <dx:GridViewDataTextColumn Caption="Lugar Ejecución" FieldName="LUGAR_EJECUCION" UnboundType="String" VisibleIndex="20" />                    
        <dx:GridViewDataTextColumn Caption="No. de Visitas" FieldName="NO_VISITAS_SEGUIMIENTO" UnboundType="String" VisibleIndex="20" Visible="false"  />       
        <dx:GridViewDataTextColumn Caption="Actualización" FieldName="LASTUPDATE" VisibleIndex="21" />            
        <dx:GridViewDataTextColumn FieldName="USERID" VisibleIndex="22" />
        <dx:GridViewDataTextColumn Caption="Usuario" FieldName="USUARIO" Visible="False"  UnboundType="String" VisibleIndex="23"  />   
        <dx:GridViewDataTextColumn Caption="Observaciones" FieldName="OBSERVACIONES" Visible="False"  VisibleIndex="24" />
        <dx:GridViewCommandColumn Caption="Cambiar a" VisibleIndex="25" Width="85px" Name="CambiarAEnMatricula" Visible="false">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnCambiarAEnMatricula" Text="En Matricula">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>        
        <dx:GridViewCommandColumn Caption="Cambiar a" Name="CambiarAIniciado" VisibleIndex="26"
            Width="85px" Visible="false">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnCambiarAIniciado" Text="Iniciado">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn Caption="Cambiar a" Name="CambiarAFinalizado" VisibleIndex="27"
            Width="85px" Visible="false">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnCambiarAFinalizado" Text="Finalizado">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>               
        <dx:GridViewDataImageColumn Name="Reportes" VisibleIndex="29" Visible="false">
        <DataItemTemplate>
            <dx:ASPxImage ID="ASPxImage1" runat="server" Height="18px" ImageUrl="~/imagenes/imprimir.gif"
                Width="18px">
                <ClientSideEvents Click="function(s, e) {
                var idAccionFormativa;
                if(window.navigator.appVersion.indexOf('IE')==-1){
                idAccionFormativa = e.htmlElement.parentNode.parentNode.cells[1].innerHTML;
                }else{
                idAccionFormativa = e.htmlElement.parentNode.parentNode.cells[1].innerText;
                }
                ConfigurarMenu(idAccionFormativa,e,s.cpIndex);

}" />
        </dx:ASPxImage>
        </DataItemTemplate>
        </dx:GridViewDataImageColumn>         
        <dx:GridViewDataHyperLinkColumn Caption=" " FieldName="ID_ACCION_FORMATIVA" 
            Name="IngresoSolicitud2" VisibleIndex="29" Visible="False" CellStyle-HorizontalAlign="Center">            
            <PropertiesHyperLinkEdit NavigateUrlFormatString="~/CursosFormacion/wfSolicitudInscripcion.aspx?modoOp=1&amp;ID_ACCION_FORMATIVA={0}" 
                Target="_self" Text="Ingresar Solicitud">
            </PropertiesHyperLinkEdit>
            <Settings AllowAutoFilter="False" AllowAutoFilterTextInputTimer="False" 
                AllowDragDrop="False" AllowGroup="False" AllowHeaderFilter="False" 
                AllowSort="False" ShowFilterRowMenu="False" ShowInFilterControl="False" />

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataHyperLinkColumn>
        <dx:GridViewCommandColumn Name="IngresoSolicitud" Visible="False" VisibleIndex="30" ButtonType="Link" Caption=" ">         
            <CustomButtons>  
                <dx:GridViewCommandColumnCustomButton ID="btnInscripcion" Text="IngresarSolicitud" />                                                                                                  
           </CustomButtons>
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn Name="CrearGruposCapacitacion" VisibleIndex="30" Visible="false" Caption=" " >         
            <CustomButtons>  
                <dx:GridViewCommandColumnCustomButton ID="btnCrearGrupos" Text="Crear Grupos" />                                                                                                  
           </CustomButtons>
        </dx:GridViewCommandColumn>   
         <dx:GridViewCommandColumn Name="RevertirEstado" VisibleIndex="30"  Caption=" " Visible="false" >         
            <CustomButtons>  
                <dx:GridViewCommandColumnCustomButton ID="btnRevertirEstado" Text="Revertir a matricula" />                                                                                                  
           </CustomButtons>
        </dx:GridViewCommandColumn> 
        <dx:GridViewCommandColumn Name="SolicitudPartiExo" VisibleIndex="30" Visible="true" Caption=" " >         
            <CustomButtons>  
                <dx:GridViewCommandColumnCustomButton ID="btnSolicitudPartiExo" />                                                                                                  
           </CustomButtons>
        </dx:GridViewCommandColumn>           
        <%--<dx:GridViewDataTextColumn VisibleIndex="30" Name="colPenalizacion" Visible="false"  Caption=" " >
            <DataItemTemplate>
                 <asp:ImageButton ID="lbtnPenalizacion" runat="server" AlternateText="Penalizacion" ToolTip="Penalizacion" CommandName="Penalizacion" ImageUrl="~/imagenes/Finance-Banknotes-icon.png"  CommandArgument='<%# Bind("ID_ACCION_FORMATIVA") %>'></asp:ImageButton>                
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>  --%> 
        <dx:GridViewCommandColumn Name="colPenalizacion" VisibleIndex="30" Visible="false" Caption=" " >         
            <CustomButtons>  
                <dx:GridViewCommandColumnCustomButton ID="btnPenalizacion" Image-AlternateText="Penalizaciones aplicadas" Image-ToolTip="Penalizaciones aplicadas" >                                                                                                  
<Image AlternateText="Penalizaciones aplicadas" ToolTip="Penalizaciones aplicadas"></Image>
                </dx:GridViewCommandColumnCustomButton>
           </CustomButtons>
        </dx:GridViewCommandColumn>  
        <dx:GridViewCommandColumn Name="colSeguimiento" VisibleIndex="30" Visible="false" Caption=" " >         
            <CustomButtons>  
                <dx:GridViewCommandColumnCustomButton ID="btnSeguimiento" Image-AlternateText="Visitas de seguimiento" Image-ToolTip="Visitas de seguimiento" >                                                                                                  
<Image AlternateText="Visitas de seguimiento" ToolTip="Visitas de seguimiento"></Image>
                </dx:GridViewCommandColumnCustomButton>
           </CustomButtons>
        </dx:GridViewCommandColumn>         
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Eliminar" 
            VisibleIndex="30" Visible="False">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>     
        <dx:GridViewDataTextColumn FieldName="ESTADO" VisibleIndex="100" Caption="Estado" UnboundType="String" Visible="false" />           
        <dx:GridViewDataTextColumn FieldName="MONTO_FACTURA" VisibleIndex="101" Caption="Monto a Facturar" UnboundType="Decimal" Visible="false" > 
            <PropertiesTextEdit DisplayFormatString="#,##0.00" />
        </dx:GridViewDataTextColumn>        
	   </Columns>
    <Settings ShowFilterRow="True" />
    <SettingsEditing Mode="PopupEditForm" PopupEditFormModal="True" PopupEditFormHorizontalAlign="Center" PopupEditFormVerticalAlign="Middle"  />
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" 
        PopupEditFormCaption = "Reprogramación de fechas"          
        CommandCancel="Cerrar" CommandUpdate="Aceptar" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>       
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
      <Templates>                    
             <EditForm>                    
                <div style="padding-top:10px;" >
                    <table id="Formulario" >
                        <tr>
                            <td colspan="2" align="justify" style=" padding-left:15px; padding-right:15px; padding-bottom:10px; color:Blue" >
                                En esta pantalla puede reprogramar las fechas de inicio y finalización antes de pasar el curso a Iniciado. Si no necesita modificar estas fechas solo haga clic en el botón Aceptar.
                            </td>
                        </tr>
                        <tr>	
		                    <td class="label">
			                    <dx:ASPxLabel runat="server" ID="dxFechaInicioReal" Text="Fecha de inicio real:"></dx:ASPxLabel>
			                </td>			    
		                    <td class="editor">
		                        <dx:ASPxDateEdit EnableClientSideAPI="true" runat="server"  ID="edFirst" ClientInstanceName="dxFechaInicioReal" Value='<%# Bind("FECHA_INICIO_REAL") %>'>		                                               
		                            <ValidationSettings SetFocusOnError="true" ValidationGroup = "Editor1" >
		                            <RequiredField IsRequired = "true" ErrorText="Fecha no válida" />       		                                                  
		                            </ValidationSettings>	
		                            <ClientSideEvents Validation="OnFechaInicioValidacion" />
		                        </dx:ASPxDateEdit>                             
                            </td>
                        </tr>
	                    <tr id="trFECHA_FIN_REAL">		        
		                    <td class="label">
			                    <dx:ASPxLabel runat="server" ID="dxFechaFinReal" Text="Fecha de finalización real:"></dx:ASPxLabel>
			                </td>            			    
		                    <td class="editor">			        
			                    <dx:ASPxDateEdit EnableClientSideAPI="true" runat="server" ID="edLast" ClientInstanceName="dxFechaFinReal" Value='<%# Bind("FECHA_FIN_REAL") %>'>			                    
			                        <ValidationSettings SetFocusOnError="true" ValidationGroup = "Editor1" >
		                            <RequiredField IsRequired = "true" ErrorText="Fecha no válida"/>       		                                                  
		                            </ValidationSettings>		                            
		                            <ClientSideEvents Validation="OnFechaFinValidacion"  />
                                </dx:ASPxDateEdit> 
                                <dx:ASPxLabel runat="server" Visible ="false"  ID="dxID_ACCION_FORMATIVA" Text='<%# Bind("ID_ACCION_FORMATIVA") %>' ></dx:ASPxLabel>   
                                <dx:ASPxLabel runat="server" Visible ="false" ID="dxCODIGO_ESTADO_AF" Text='<%# Bind("CODIGO_ESTADO_AF") %>' ></dx:ASPxLabel>                  
                             </td>                                                		
	                    </tr>	                    
	                    <tr>
                             <td>
                             </td>
                             <td class="buttonCell">
                                 <table cellpadding="0" cellspacing="0">
                                     <tr>
                                         <td>
                                             <dx:ASPxButton ID="btnAceptar" runat="server" AutoPostBack="False" Text="Aceptar" Width="74px">   
                                             <ClientSideEvents Click="OnAceptarButtonClick" />                                                              
                                             </dx:ASPxButton>
                                         </td>
                                         <td style="padding-left: 13px;">
                                             <dx:ASPxButton ID="botonCerrar" runat="server" AutoPostBack="False" Text="Cerrar" Width="74px" CausesValidation="False">
                                              <ClientSideEvents Click="OnCerrarButtonClick" />    
                                             </dx:ASPxButton>
                                         </td>
                                     </tr>
                                 </table>
                             </td>
                         </tr>
                    </table>                    
                </div>        
             </EditForm>
       </Templates>
</dx:ASPxGridView>

 <dx:ASPxHiddenField runat="server" ID="hf" /> 
            
             </dx:PanelContent>
         </PanelCollection>
</dx:ASPxCallbackPanel>

<asp:ObjectDataSource ID="odsLista" runat="server" OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cACCION_FORMATIVA">
    <SelectParameters>
        <asp:Parameter Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter Name="asColumnaOrden" Type="String" />
        <asp:Parameter Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsPorCriteriosPeriodoEstado" runat="server" SelectMethod="ObtenerListaPorCriteriosPeriodoEstado"
    UpdateMethod="ActualizarFechasRealesACCION_FORMATIVA" TypeName="SGAFP.BL.cACCION_FORMATIVA">
    <SelectParameters>
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_FORMACION" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_ACCION_FORMATIVA" Type="String" />
        <asp:Parameter Name="CODIGO_GRUPO" Type="String" />
        <asp:Parameter Name="CODIGO_ESTADO_AF" Type="String" />
        <asp:Parameter Name="ID_EJERCICIO" Type="String" />
        <asp:Parameter Name="TDR" Type="String" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>   
    <UpdateParameters>
    <asp:Parameter Type="Decimal" Name = "ID_ACCION_FORMATIVA" />
    <asp:Parameter Type="DateTime" Name = "FECHA_INICIO_REAL" />
    <asp:Parameter Type="DateTime" Name = "FECHA_FIN_REAL" />    
    <asp:Parameter Type="String" Name = "CODIGO_ESTADO_AF" />    
    </UpdateParameters>    
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCriteriosRoles" runat="server" SelectMethod="ObtenerListaPorCriteriosRoles"
     TypeName="SGAFP.BL.cACCION_FORMATIVA">
    <SelectParameters>
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_FORMACION" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_ACCION_FORMATIVA" Type="String" />
        <asp:Parameter Name="CODIGO_GRUPO" Type="String" />
        <asp:Parameter Name="ID_EJERCICIO" Type="String" />
        <asp:Parameter Name="listaROLES" Type="String" /> 
        <asp:Parameter Name="listaCODIGO_ESTADO_AF" Type="String" />
        <asp:Parameter Name="TDR" Type="String" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>      
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsPorCriteriosPeriodoEstadosTecnico" runat="server" SelectMethod="ObtenerListaPorCriteriosPeriodoEstadosTecnico"
     TypeName="SGAFP.BL.cACCION_FORMATIVA">
    <SelectParameters>
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_FORMACION" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_ACCION_FORMATIVA" Type="String" />
        <asp:Parameter Name="CODIGO_GRUPO" Type="String" />
        <asp:Parameter Name="CODIGO_ESTADO_AF" Type="Object" ConvertEmptyStringToNull="True"  />
        <asp:Parameter Name="ID_EJERCICIO" Type="String" />
        <asp:Parameter Name="USUARIO_TECNICO" Type="String" />        
        <asp:Parameter Name="TDR" Type="String" /> 
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />        
    </SelectParameters>      
</asp:ObjectDataSource>
<dx:ASPxPopupMenu ID="ASPxPopupMenu1" runat="server" 
    ClientInstanceName="MenuCursos">
    <Items>
        <dx:MenuItem NavigateUrl="~/Reportes/wfReporteParticipantesInscritos.aspx?ID_ACCION_FORMATIVA=" 
            Target="_blank" Text="Participantes Inscritos" 
            ToolTip="Reporte de Participantes Inscritos" Name="ParticipantesInscritos">
        </dx:MenuItem>
        <dx:MenuItem NavigateUrl="~/reportes/wfReporteFormatoAsistencia.aspx?real=1&amp;af=" 
            Target="_blank" Text="Listado de Asistencia Real" 
            ToolTip="Reporte de Asistencia Real al Curso" Name="AsistenciaReal">
        </dx:MenuItem>
        <dx:MenuItem NavigateUrl="~/Reportes/wfReporteFormularioF8.aspx?af=" 
            Target="_blank" Text="Formulario F8" 
            ToolTip="Reporte de Formulario F8" Name="FormularioF8">
        </dx:MenuItem>
        <dx:MenuItem NavigateUrl="~/Reportes/wfReporteSolicitudParticipantesInscritosPATI.aspx?af=" 
            Target="_blank" Text="Participantes Pre-Inscritos" 
            ToolTip="Participantes Pre-Inscritos" Name="ParticipantesPreInscritos">
        </dx:MenuItem>
    </Items>
</dx:ASPxPopupMenu>
<asp:ObjectDataSource ID="odsListaPorCriteriosPeriodo" runat="server" SelectMethod="ObtenerListaPorCriteriosPeriodo"
    TypeName="SGAFP.BL.cACCION_FORMATIVA">
    <SelectParameters>
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_FORMACION" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_ACCION_FORMATIVA" Type="String" />
        <asp:Parameter Name="CODIGO_GRUPO" Type="String" />
        <asp:Parameter Name="ID_EJERCICIO" Type="String" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCriteriosPeriodoCursosMatriculaIniciados" runat="server" SelectMethod="ObtenerListaPorCriteriosPeriodoMatriculaIniciado"
    TypeName="SGAFP.BL.cACCION_FORMATIVA">
    <SelectParameters>
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_FORMACION" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_ACCION_FORMATIVA" Type="String" />
        <asp:Parameter Name="CODIGO_GRUPO" Type="String" />
        <asp:Parameter Name="ID_EJERCICIO" Type="String" />        
        <asp:Parameter Name="listaROLES" Type="String" />     
        <asp:Parameter Name="TDR" Type="String" />      
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCriterios" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerListaPorCriterios" TypeName="SGAFP.BL.cACCION_FORMATIVA">
    <SelectParameters>
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_FORMACION" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_ACCION_FORMATIVA" Type="String" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCURSO_TEMA" runat="server" 
    OldValuesParameterFormatString="original_{0}" 
    SelectMethod="ObtenerListaPorCURSO_TEMA" TypeName="SGAFP.BL.cACCION_FORMATIVA">
    <SelectParameters>
        <asp:Parameter Name="ID_TEMA_CURSO" Type="Decimal" />
        <asp:Parameter Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter Name="asColumnaOrden" Type="String" />
        <asp:Parameter Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorEJERCICIO" runat="server" 
    OldValuesParameterFormatString="original_{0}" 
    SelectMethod="ObtenerListaPorEJERCICIO" TypeName="SGAFP.BL.cACCION_FORMATIVA">
    <SelectParameters>
        <asp:Parameter Name="ID_EJERCICIO" Type="String" />
        <asp:Parameter Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter Name="asColumnaOrden" Type="String" />
        <asp:Parameter Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorESTADO_ACCION_FORMATIVA" runat="server" 
    OldValuesParameterFormatString="original_{0}" 
    SelectMethod="ObtenerListaPorESTADO_ACCION_FORMATIVA" 
    TypeName="SGAFP.BL.cACCION_FORMATIVA">
    <SelectParameters>
        <asp:Parameter Name="CODIGO_ESTADO_AF" Type="String" />
        <asp:Parameter Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter Name="asColumnaOrden" Type="String" />
        <asp:Parameter Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorOFERTA_FORMATIVA" runat="server" 
    OldValuesParameterFormatString="original_{0}" 
    SelectMethod="ObtenerListaPorOFERTA_FORMATIVA" 
    TypeName="SGAFP.BL.cACCION_FORMATIVA">
    <SelectParameters>
        <asp:Parameter Name="ID_OFERTA_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter Name="asColumnaOrden" Type="String" />
        <asp:Parameter Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPROVEEDOR_AF" runat="server" 
    OldValuesParameterFormatString="original_{0}" 
    SelectMethod="ObtenerListaPorPROVEEDOR_AF" 
    TypeName="SGAFP.BL.cACCION_FORMATIVA">
    <SelectParameters>
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter Name="asColumnaOrden" Type="String" />
        <asp:Parameter Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorSITIO_CAPACITACION" runat="server" 
    OldValuesParameterFormatString="original_{0}" 
    SelectMethod="ObtenerListaPorSITIO_CAPACITACION" 
    TypeName="SGAFP.BL.cACCION_FORMATIVA">
    <SelectParameters>
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter Name="asColumnaOrden" Type="String" />
        <asp:Parameter Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorAccionFormativaFacturar" runat="server" SelectMethod="ObtenerListaPorAccionFormativaFacturar"
    TypeName="SGAFP.BL.cACCION_FORMATIVA">
    <SelectParameters>        
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>


