<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucProgramacionAccionFormativa.ascx.vb" Inherits="controles_ucProgramacionAccionFormativa" %>

<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>

<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxLoadingPanel" TagPrefix="dx" %>
<style type="text/css">   
    .progtbl
    {
        border-style: none;
        border-color: White ;
        border-width: 0px;
        text-align: left;
        font-family: Verdana, Geneva, Arial, Helvetica, sans-serif;
        font-weight: normal;
        font-size: 11px;
        color: #000000;  
        background-color: #FFFFFF;   
        border-collapse: collapse;
        border-spacing: 1px;            
    }   
    .panel
    {
       padding: 5 5 5 5; 
       width: 480px;
    }
    .divresult
    {
      text-align:left; font-weight:bold; 
    }
    .req{color:Red; font-size:x-small; font-family:Arial, Verdad; font-weight:bold}   
</style>

<dx:ASPxCallbackPanel runat="server" ID="ASPxCallbackPanel1" 
    ClientInstanceName="CallbackPanel" Width="480px" 
    HideContentOnCallback="False" LoadingPanelText="" ShowLoadingPanel="False" >           
    <ClientSideEvents EndCallback="function(s,e){
                                        Cargando.Hide();
                                        if(s.cpResultado != undefined){
                                            AsignarMensaje(s.cpResultado);
                                            SetContenido(200, 0);
                                            delete s.cpResultado;
                                        }
                                        else{
                                            dteFechaInicio.SetValue(null);
                                            dteFechaFinalizacion.SetValue(null);
                                            chkLunes.SetValue(false);
                                            chkMartes.SetValue(false);
                                            chkMiercoles.SetValue(false);
                                            chkJueves.SetValue(false);
                                            chkViernes.SetValue(false);
                                            chkSabado.SetValue(false);
                                            chkDomingo.SetValue(false);           
                                            tmeHoraInicio.SetValue(null);
                                            tmeHoraFin.SetValue(null);                
                                        }                                        
                                    }" /> 
    <PanelCollection>        
    <dx:PanelContent runat="server">    
             <asp:Panel BackColor="#FFFFFF" ID="Panel1" runat="server" BorderColor="LightGray" BorderWidth="0px" CssClass="panel" >             
             <table width="100%">
                <tr>
                    <td  align="center" >
                        <span style="font-family: Verdana; font-size: 11px; font-weight:bold;">PROGRAMACION DEL CURSO</span>
                    </td>
                </tr>
             </table>
             <asp:Panel BackColor="#FFFFFF" ID="PanelParametros" runat="server" BorderColor="Transparent" BorderWidth="0px"  >
             <table border="0" cellpadding="2" cellspacing="0" >                      
                <tr>
                    <td>
                        <div class="req">FECHAS *</div>
                    </td>                    
                    <th align="left"  >
                        <table border="0" cellpadding="2" cellspacing="0" class="progtbl">
                            <tr>
                                <td>
                                    <div style="font-family: Verdana; font-size: 11px;">Del</div>
                                </td>
                                <td>
                                    <div style="font-family: Verdana; font-size: 10px;" >
                                    <dx:ASPxDateEdit ID="dteFechaInicio" ClientInstanceName="dteFechaInicio"  runat="server" AllowNull="false" Width="100px" DisplayFormatString="dd/MM/yyyy" />                                
                                    </div>
                                </td>
                                <td>
                                    <div style="font-family: Verdana; font-size: 11px;">Al</div>
                                </td>
                                <td>
                                    <div style="font-family: Verdana; font-size: 11px;" >
                                    <dx:ASPxDateEdit ID="dteFechaFinalizacion" ClientInstanceName="dteFechaFinalizacion" runat="server" AllowNull="True" Width="100px" DisplayFormatString="dd/MM/yyyy" />                                
                                    </div>
                                </td>
                            </tr>
                        </table>
                        
                    </th>                    
                </tr>  
                <tr>
                    <td>
                        <div class="req">DIAS DE LA SEMANA *</div>                 
                    </td>
                    <th align="left" >
                            <table border="0" cellpadding="2" cellspacing="0" class="progtbl" width="100%" >
                                <tr>                                    
                                    <td>
                                        <dx:ASPxCheckBox ID="chkLunes" ClientInstanceName="chkLunes"  runat="server" Text="Lun"  />                                
                                    </td>
                                    <td>
                                        <dx:ASPxCheckBox ID="chkMartes" ClientInstanceName="chkMartes" runat="server" Text="Mar" />                                
                                    </td>
                                    <td>                                
                                        <dx:ASPxCheckBox ID="chkMiercoles" ClientInstanceName="chkMiercoles" runat="server" Text="Mie" />
                                    </td>
                                    <td>                                
                                        <dx:ASPxCheckBox ID="chkJueves" ClientInstanceName="chkJueves" runat="server" Text="Jue" />
                                    </td>                            
                                    <td> 
                                        <dx:ASPxCheckBox ID="chkViernes" ClientInstanceName="chkViernes" runat="server" Text="Vie" />                               
                                    </td>
                                    <td>                                
                                        <dx:ASPxCheckBox ID="chkSabado" ClientInstanceName="chkSabado" runat="server" Text="Sab" />
                                    </td>                            
                                    <td>                                
                                        <dx:ASPxCheckBox ID="chkDomingo" ClientInstanceName="chkDomingo" runat="server" Text="Dom" />
                                    </td>
                                </tr>
                              </table>     
                    </th>
                </tr>                                             
                <tr>
                    <td>
                        <div class="req">HORAS *</div>          
                    </td>
                    <th align="left">
                        <table border="0" cellpadding="2" cellspacing="0" class="progtbl">
                            <tr>
                                <td>
                                   <div style="font-family: Verdana; font-size: 11px; text-align:right;">De</div>            
                                </td>
                                <td>
                                   <dx:ASPxTimeEdit ID="tmeHoraInicio" ClientInstanceName="tmeHoraInicio" runat="server" Width="100px" DisplayFormatString="hh:mm tt" EditFormat="Custom" EditFormatString="hh:mm tt"    />                                                     
                                </td>
                                <td>
                                   <div style="font-family: Verdana; font-size: 11px; text-align:right;">A</div> 
                                </td>
                                <td>  
                                  <dx:ASPxTimeEdit ID="tmeHoraFin" ClientInstanceName="tmeHoraFin" runat="server" Width="100px" DisplayFormatString="hh:mm tt" EditFormat="Custom" EditFormatString="hh:mm tt" />                                                 
                                </td>
                             </tr>
                        </table>
                    </th>                   
                </tr>               
              </table>                      
              
             <table border="0" cellpadding="2" cellspacing="0">
                <tr>
                    <td>
                        <dx:ASPxButton ID="btnAgregarProg" ClientInstanceName="btnAgregarProg" AutoPostBack="False"  runat="server" Text="Agregar Programación >>" Width="160px" Font-Names="Calibri Tahoma Arial" Font-Size="11px" >
                            <ClientSideEvents Click="function(s, e){
                                                if (dteFechaInicio.GetDate() == null) {
                                                    AsignarMensaje('Seleccione la fecha inicial de la programacion');
                                                    return false;
                                                }
                                                if (dteFechaFinalizacion.GetDate() == null) {
                                                    AsignarMensaje('Seleccione la fecha final de la programacion');
                                                    return false;
                                                }
                                                if (dteFechaInicio.GetDate() > dteFechaFinalizacion.GetDate()) {
                                                    AsignarMensaje('La fecha inicial de la programacion no puede ser mayor que la fecha final');
                                                    return false;
                                                }
                                                if (tmeHoraInicio.GetDate() == null) {
                                                    AsignarMensaje('Seleccione la hora inicial de la programacion');
                                                    return false;
                                                }
                                                if (tmeHoraFin.GetDate() == null) {
                                                    AsignarMensaje('Seleccione la hora final de la programacion');
                                                    return false;
                                                }
                                                if (tmeHoraInicio.GetDate() >= tmeHoraFin.GetDate()) {
                                                    AsignarMensaje('La hora inicial de la programacion no puede ser igual o mayor que la hora final');
                                                    return false;
                                                }
                                                if (chkLunes.GetValue() == false && chkMartes.GetValue() == false &&
                                                    chkMiercoles.GetValue() == false && chkJueves.GetValue() == false &&
                                                    chkViernes.GetValue() == false && chkSabado.GetValue() == false &&
                                                    chkDomingo.GetValue() == false) {
                                                    AsignarMensaje('Seleccione el dia o dias de semana del curso');
                                                    return false;
                                                }
                                                Cargando.Show();
                                                CallbackPanel.PerformCallback('Programar');
                            
                            }" /> 
                        </dx:ASPxButton>
                    </td>
                    <td>
                        <dx:ASPxButton ID="btnBorrarProg" ClientInstanceName="btnBorrarProg" AutoPostBack="False"  runat="server" Text="Borrar Programación" Width="120px" Font-Names="Calibri Tahoma Arial" Font-Size="11px" >
                            <ClientSideEvents Click="function(s, e){  
                                                    Cargando.Show();                                                                                                                                                                                                                                                             
                                                    CallbackPanel.PerformCallback('Eliminar');                                                                                                                                                    
                                                }" /> 
                        </dx:ASPxButton>
                    </td>
                </tr>
             </table>
             </asp:Panel>
             <table border="0" cellpadding="2" cellspacing="0" width="100%" >
                <tr>
                    <td>
                    <dx:ASPxGridView ID="dgProgCurso" ClientInstanceName="dgProgCurso" runat="server" AutoGenerateColumns="False" Width="100%" CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx" >
                            <Columns>                                                                
                                <dx:GridViewDataTextColumn VisibleIndex="1" Caption="Id" FieldName="ID_ASISTENCIA_AF" Visible="false"  />                                     
                                <dx:GridViewDataTextColumn VisibleIndex="2" Caption="Fecha" FieldName="FECHA" SortIndex="0" SortOrder="Ascending"   >                          
                                    <PropertiesTextEdit DisplayFormatString="ddd dd-MMM-yyyy">
                                    </PropertiesTextEdit>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn VisibleIndex="3" Caption="Horario" FieldName="HORARIO" UnboundType="String"  />
                                <dx:GridViewDataTextColumn VisibleIndex="4" Caption="Cantidad de Horas" FieldName="HORAS_CAPACITACION" CellStyle-HorizontalAlign="Right" UnboundType="String"   >                                                                
<CellStyle HorizontalAlign="Right"></CellStyle>
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewCommandColumn VisibleIndex="5" Caption=" " Visible="True" ButtonType="Image"   >
                                    <CustomButtons>                                                                            
                                        <dx:GridViewCommandColumnCustomButton ID="cbEliminar" Image-Url="~/imagenes/eliminar_simple.gif"  Text="Eliminar" >
<Image Url="~/imagenes/eliminar_simple.gif"></Image>
                                        </dx:GridViewCommandColumnCustomButton>
                                    </CustomButtons>                                
                                </dx:GridViewCommandColumn>                                
                            </Columns>                                  
                        <SettingsText 
                            EmptyDataRow="No existen programaciones para mostrar" 
                            PopupEditFormCaption = "Programación de curso"          
                            CommandCancel="Cerrar" CommandUpdate="Aceptar" />
                        <SettingsPager>
                            <Summary AllPagesText="Paginas: {0} - {1} ({2} días)" Text="Pagina {0} de {1} ({2} días)" />
                        </SettingsPager> 
                        <SettingsBehavior AllowSort="false" />                        
                        <ClientSideEvents EndCallback="function(s,e){
                                                    lblFechaInicioReal.SetText(dgProgCurso.cpFECHA_INICIO_REAL);
                                                    lblFechaFinalizacionReal.SetText(dgProgCurso.cpFECHA_FIN_REAL);
                                                    lblHorasTotales.SetText(dgProgCurso.cpHORAS_TOTALES);
                                                    lblHorario.SetText(dgProgCurso.cpHORARIO_REAL);                                                                                       
                                                }" >
                        </ClientSideEvents>
                                            
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
                    </td>
                </tr>
             </table>   
             <table border="0" cellpadding="2" cellspacing="0" style="font-family:Arial; font-size:xx-small; color:Red"  >
                <tr>
                    <td>
                       <div class="req">FECHA INICIO REAL *</div>      
                    </td>
                     <td style="width:110px" >
                         <dx:ASPxLabel ID="lblFechaInicioReal" ClientInstanceName="lblFechaInicioReal"  runat="server" Text="" />                         
                    </td>
                    <td>
                       <div class="req">FECHA FIN REAL *</div>      
                    </td>
                    <td>
                         <dx:ASPxLabel ID="lblFechaFinalizacionReal" ClientInstanceName="lblFechaFinalizacionReal" runat="server" Text="" />                         
                    </td>
                </tr>
             </table>
             <table border="0" cellpadding="2" cellspacing="0" style="font-family:Arial; font-size:xx-small; color:Red" >              
                <tr>
                    <td>
                        <div class="req">HORARIO REAL *</div>
                    </td>
                    <td>
                        <dx:ASPxLabel ID="lblHorario" ClientInstanceName="lblHorario"  runat="server" Text="" />     
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class="req">TOTAL HORAS *</div>
                    </td>
                    <td>
                        <dx:ASPxLabel ID="lblHorasTotales" ClientInstanceName="lblHorasTotales" runat="server" Text="" />     
                    </td>
                </tr>
             </table>          
            
             </asp:Panel>
</dx:PanelContent>
    </PanelCollection>    
</dx:ASPxCallbackPanel>
 <dx:ASPxLabel ID="lblREF_ASISTENCIA" runat="server" Text="" ClientVisible="false" />  
<dx:ASPxLabel ID="lblREF_ASISTENCIA_HORARIO" runat="server" Text="" ClientVisible="false" />  
<dx:ASPxLabel ID="lblREF_ASISTENCIA_CAMBIOS" runat="server" Text="" ClientVisible="false" />  
<dx:ASPxLoadingPanel ID="Cargando" runat="server" ClientInstanceName="Cargando"  Text="Cargando..." 
        Modal="True" CssFilePath="~/App_Themes/Aqua/{0}/styles.css" CssPostfix="Aqua"  
        ImagePosition="Top" >
        <Image Url="~/App_Themes/Aqua/Web/Loading.gif">
        </Image>
</dx:ASPxLoadingPanel>


