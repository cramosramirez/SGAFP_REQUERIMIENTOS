<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucInformeFinalAccionFormativa.ascx.vb" Inherits="controles_ucInformeFinalAccionFormativa" %>
<%@ Register Assembly="SGAFP_WebUC" Namespace="SGAFP.WebUC" TagPrefix="cc1" %>
<%@ Register Src="ucBarraNavegacion.ascx" TagName="ucBarraNavegacion" TagPrefix="uc1" %>
<%@ Register Src="ucCriteriosAccionFormativa.ascx" TagName="ucCriteriosAccionFormativa" TagPrefix="uc1" %>
<%@ Register Src="ucListaACCION_FORMATIVA.ascx" TagName="ucListaACCION_FORMATIVA" TagPrefix="uc2" %>
<%@ Register Src="ucListaINFORME_FINAL_AF.ascx" TagName="ucListaINFORME_FINAL_AF" TagPrefix="uc2" %>
<%@ Register Src="ucListaACCION_FORMATIVA_REPROG.ascx" TagName="ucListaACCION_FORMATIVA_REPROG" TagPrefix="uc4" %>
<%@ Register src="ucVistaDetalleINFORME_FINAL_AF.ascx" tagname="ucVistaDetalleINFORME_FINAL_AF" tagprefix="uc3" %>
<%@ Register src="ucListaINFORME_FINAL_DET.ascx" tagname="ucListaINFORME_FINAL_DET" tagprefix="uc4" %>
<%@ Register src="ucListaACCION_FORMATIVA_PENA.ascx" tagname="ucListaACCION_FORMATIVA_PENA" tagprefix="uc5" %>
<%@ Register TagPrefix="uc6" TagName="ucListaACCION_PROGRA_RETRO" Src="~/controles/ucListaACCION_PROGRA_RETRO.ascx" %>
<%@ Register Assembly="DevExpress.XtraReports.v11.1.Web, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register src="ucAsistenciaAccionFormativa.ascx" tagname="ucAsistenciaAccionFormativa" tagprefix="uc5" %>
<%@ Register src="ucEvaluacionesAccionFormativa.ascx" tagname="ucEvaluacionesAccionFormativa" tagprefix="uc6" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<%@ Register TagName="ucVistaDetalleACCION_FORMATIVA" Src="~/controles/ucVistaDetalleACCION_FORMATIVA.ascx" TagPrefix="uc1" %>
<%@ Register TagName="ucListaACCION_FORMATIVA_HIST" Src="~/controles/ucListaACCION_FORMATIVA_HIST.ascx" TagPrefix="uc7" %>
<%@ Register TagName="ucListaINFORME_FINAL_AF_HIS" Src="~/controles/ucListaINFORME_FINAL_AF_HIS.ascx" TagPrefix="uc7" %>

<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>


<script language="javascript" type="text/javascript"  >
    function CantidadesValidas() {        
        var cantInscritos;
        var cantActivos;        

        cantInscritos = parseInt(txtInscritos.GetText());f
        cantActivos = parseInt(txtActivos.GetText());
        
        if (cantActivos > cantInscritos) {
            alert('Activos HTP no puede ser mayor que Inscritos HTP');
            return false;
        }
        if (cantInscritos == 0) {
            alert('Inscritos HTP no puede ser cero');
            return false;
        }
        if (cantActivos == 0) {
            alert('Activos HTP no puede ser cero');
            return false;
        }
        if (cantInscritos > 22) {
            alert('Inscritos HTP no puede ser mayor a 22');
            return false;
        }
        if (cantActivos > 22) {
            alert('Activos HTP no puede ser mayor a 22');
            return false;
        }
        return true;
    } 
    
</script>  
<uc1:ucBarraNavegacion ID="UcBarraNavegacion1" runat="server" PermitirAgregar="false"
    PermitirEditar="false" PermitirGuardar="false" PermitirNavegacion="false" Visible="true" />
<table width="100%">
    <tr>
	    <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">INFORME DE EJECUCION</asp:Label></td>
    </tr>
    <tr>
	    <td><asp:Image ID="Image2" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></td>
    </tr>
</table>
<uc1:ucCriteriosAccionFormativa ID="ucCriteriosAccionFormativa1" runat="server"  
    VerEjercicio="True" EsInforme="true" FiltrarSitioPorTecnico="True" VerAreaFormacion="false"  />
<asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" OnMenuItemClick="Menu1_MenuItemClick"
    BackColor="#B5C7DE" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em"
    ForeColor="#284E98" StaticSubMenuIndent="10px">
    <StaticSelectedStyle CssClass="TabSeleccionado" />
    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
    <DynamicMenuStyle BackColor="#B5C7DE" />
    <DynamicSelectedStyle BackColor="#507CD1" />
    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
    <Items>
        <asp:MenuItem Text="Lista de Informes" Value="0" Selected="true"></asp:MenuItem>
        <asp:MenuItem Enabled="False" Text="Informe" Value="1"></asp:MenuItem>
        <asp:MenuItem Enabled="False" Text="Asistencia" Value="2"></asp:MenuItem>
        <asp:MenuItem Enabled="False" Text="Notas" Value="3"></asp:MenuItem>
        <asp:MenuItem Enabled="False" Text="Reprogramaciones" Value="4"></asp:MenuItem>
        <asp:MenuItem Enabled="False" Text="Programacion" Value="5"></asp:MenuItem>
        <asp:MenuItem Enabled="False" Text="Historico" Value="6"></asp:MenuItem>
        <asp:MenuItem Enabled="False" Text="Penalizaciones" Value="7"></asp:MenuItem>
        <asp:MenuItem Enabled="False" Text="Autorizaciones" Value="8"></asp:MenuItem>
    </Items>
</asp:Menu>
<asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
    <asp:View ID="View1" runat="server">
        <table cellpadding="0" cellspacing="0" width="100%">
            <tr valign="top">
                <td class="TabArea">
                    <uc2:ucListaINFORME_FINAL_AF ID="ucListaINFORME_FINAL_AF1" runat="server" PermitirEditar="False"
                        PermitirEliminar="False" PermitirPaginacion="True" PermitirSeleccionar="true"
                        VerCODIGO_ESTADO_AF="False" VerID_PROVEEDOR_AF="False" 
                        VerLASTUPDATE="False" VerUSERID="False" 
                        VerID_ACCION_FORMATIVA="false" VerFECHA_INFORME="false" VerNUMERO_FACTURA="False"
                        VerELABORADO_POR="False" VerMONTO_APROBADO="False" VerPORC_PROM_ASISTENCIA="False"
                        VerNOTA_PROMEDIO="false" VerESTADO="false" VerCOMENTARIOS="false" VerUSUARIO_APROBACION="false"
                        VerID_ESTADO_INFORME="false" PermitirFiltroEnEncabezado="false"          
                        />                    
                </td>
            </tr>
        </table>
    </asp:View>
    <asp:View ID="View2" runat="server">
        <table cellpadding="0" cellspacing="0" width="100%">
            <tr valign="top">
                <td class="TabArea">
                    <table>
                        <tr>
                            <td><dx:ASPxLabel ID="ASPxLabel2" runat="server" Font-Size="Small" Font-Names="Arial Narrow" Text="FASE: " Font-Bold="True" /></td>
                            <td><dx:ASPxLabel ID="dxlblFase" runat="server" Font-Size="Small" Font-Names="Arial Narrow" ForeColor="DarkBlue" Text="" Font-Bold="True" /></td>
                            <td><dx:ASPxLabel ID="ASPxLabel5" runat="server" Font-Size="Small" Font-Names="Arial Narrow" Text="Días calendario transcurridos desde la finalización del curso hasta su recepción: " Font-Bold="True" /></td>
                            <td><dx:ASPxLabel ID="dxlblDiasTransRecepcion" runat="server" Font-Size="Small" Font-Names="Arial Narrow" ForeColor="DarkBlue" Text="" Font-Bold="True" /></td>
                        </tr>
                        <tr>
                            <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Font-Size="Small" Font-Names="Arial Narrow" Text="Estado Actual: " Font-Bold="True" /></td>
                            <td style="width:600px" ><dx:ASPxLabel ID="dxlblEstado" runat="server" Font-Size="Small" Font-Names="Arial Narrow" ForeColor="Red" Text="" Font-Bold="True" /></td>                            
                            <td><dx:ASPxLabel ID="lblMsjPenalizacion1" runat="server" Font-Size="Small" ForeColor="Blue" Text="Monto ejecutado:"  Font-Names="Arial Narrow" Font-Bold="True" /></td>
                            <td><dx:ASPxLabel ID="lblMontoEjecutado" runat="server" Font-Size="Small" ForeColor="Blue" Font-Names="Arial Narrow" Font-Bold="True" /></td>
                        </tr>
                        <tr>
                            <td><dx:ASPxLabel ID="ASPxLabel6" runat="server" Font-Size="Small" Font-Names="Arial Narrow" Text="Usuario que asignó el estado: " Font-Bold="True" /></td>
                            <td style="width:600px" ><dx:ASPxLabel ID="dxlblNombreUsuario" runat="server" Font-Size="Small" Font-Names="Arial Narrow" ForeColor="DarkBlue" Text="" Font-Bold="True" /></td>  
                            <td><dx:ASPxLabel ID="lblMsjPenalizacion2" runat="server" Font-Size="Small" ForeColor="Blue" Text="Menos 10% de penalización sobre contrato:" Font-Names="Arial Narrow" Font-Bold="True" /></td>                          
                            <td><dx:ASPxLabel ID="lblMontoPena" runat="server" Font-Size="Small" ForeColor="Blue"  Font-Names="Arial Narrow" Font-Bold="True" /></td>
                        </tr>
                        <tr>
                            <td><dx:ASPxLabel ID="ASPxLabel8" runat="server" Font-Size="Small" Font-Names="Arial Narrow" Text="Informe asignado al técnico: " Font-Bold="True" /></td>
                            <td style="width:600px" ><dx:ASPxLabel ID="lblTecnicoAsignado" runat="server" Font-Size="Small" Font-Names="Arial Narrow" ForeColor="DarkBlue" Text="" Font-Bold="True" /></td> 
                            <td><dx:ASPxLabel ID="lblMsjPenalizacion3" runat="server" Font-Size="Small" ForeColor="Blue" Text="Total a pagar:" Font-Names="Arial Narrow" Font-Bold="True" /></td> 
                            <td><dx:ASPxLabel ID="lblMontoPagar" runat="server" Font-Size="Small" ForeColor="Blue"  Font-Names="Arial Narrow" Font-Bold="True" /></td> 
                        </tr>
                        <tr runat="server" id="trALERTA" visible="false">
                            <td><dx:ASPxLabel ID="ASPxLabel7" runat="server" Font-Size="Small" Font-Names="Arial Narrow" Text="NOTIFICACION: " Font-Bold="True" /></td>
                            <td style="width:600px" ><dx:ASPxLabel ID="dxlblALERTA" runat="server" Font-Size="Medium" Font-Names="Arial Narrow" ForeColor="Red" Text="" Font-Bold="True" /></td>                              
                        </tr>
                    </table>                                        
                    <dx:ASPxGridView ID="ASPxGridView2" runat="server" AutoGenerateColumns="False" Width="100%"  
                        DataSourceID="ObjectDataSource1" CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx">
                        <Columns>                       
                            <dx:GridViewDataTextColumn Caption="Proveedor" FieldName="NOMBRE_PROVEEDOR" HeaderStyle-Wrap="True" Width="100px"
                                VisibleIndex="0">
                                <HeaderStyle Wrap="True" />
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Modalidad" 
                                FieldName="MODALIDAD_FORMACION" VisibleIndex="1">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Curso" 
                                FieldName="NOMBRE_ACCION_FORMATIVA" VisibleIndex="1">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="No. HI" FieldName="CODIGO_GRUPO"  
                                VisibleIndex="2">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Lugar Ejecución"
                                FieldName="LUGAR_EJECUCION" VisibleIndex="3" HeaderStyle-Wrap="True" Width="80px">
                                <HeaderStyle Wrap="True" />
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataDateColumn Caption="Inicio" 
                                FieldName="FECHA_INICIO_REAL" VisibleIndex="4">
                                <PropertiesDateEdit Spacing="0">
                                </PropertiesDateEdit>
                            </dx:GridViewDataDateColumn>
                            <dx:GridViewDataDateColumn Caption="Finalización" 
                                FieldName="FECHA_FIN_REAL" VisibleIndex="5">
                                <PropertiesDateEdit Spacing="0">
                                </PropertiesDateEdit>
                            </dx:GridViewDataDateColumn>
                            <dx:GridViewDataTextColumn FieldName="HORARIO" Caption="Horario" VisibleIndex="6" HeaderStyle-Wrap="True">
                                <HeaderStyle Wrap="True" />
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Horas<br>Totales" FieldName="DURACION_HORAS" 
                                VisibleIndex="7">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Horas<br>Desarrolladas" FieldName="HORAS_DESARROLLADAS" Visible="false"                              
                                VisibleIndex="7">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Horas<br>Acumuladas" FieldName="HORAS_ACUMULADAS" Visible="false" UnboundType="Decimal"                                
                                VisibleIndex="7">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Inscritos" 
                                FieldName="PARTICIPANTES_INSCRITOS" VisibleIndex="8">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Activos" 
                                FieldName="PARTICIPANTES_FINALES" VisibleIndex="9">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Costo por<br>Participante" 
                                FieldName="COSTO_X_PARTICIPANTE" VisibleIndex="10">
                                <PropertiesTextEdit DisplayFormatString="#,##0.00" />
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Costo hora<br>Curso" 
                                FieldName="COSTO_X_HORA"  Visible="false" UnboundType="Decimal" VisibleIndex="10">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn Caption="Total a<br>Pagar" FieldName="MONTO_FACTURA"  
                                VisibleIndex="11">
                                <PropertiesTextEdit DisplayFormatString="#,##0.00" />                                 
                            </dx:GridViewDataTextColumn>
                        </Columns>                        
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
                    <table width="100%">
                        <tr>
                           <td><dx:ASPxLabel ID="lblHorario" runat="server" Font-Size="Small" Width="100%" Font-Names="Arial Narrow"/></td>
                        </tr>
                    </table>                     
                    <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" Width="100%"  DataSourceID="ObjectDataSource2" CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx">
                        <Columns>
                            <dx:GridViewDataColumn VisibleIndex="0" Caption="N°" FieldName="CORRELATIVO" UnboundType="Integer" CellStyle-Font-Bold="true" HeaderStyle-Font-Bold="true" >
                                <HeaderStyle Font-Bold="True" />
                                <CellStyle Font-Bold="True">
                                </CellStyle>
                            </dx:GridViewDataColumn>
                            <dx:GridViewDataTextColumn FieldName="NOMBRES_APELLIDOS" VisibleIndex="1" Caption="Apellidos y Nombres"  />                            
                            <dx:GridViewDataTextColumn FieldName="NOTA_TEORICA" VisibleIndex="2" Caption="Nota Final<br>Teórica"  />                            
                            <dx:GridViewDataTextColumn FieldName="NOTA_PRACTICA" VisibleIndex="3" Caption="Nota Final<br>Practica"  />                            
                            <dx:GridViewDataTextColumn FieldName="NOTA_FINAL" VisibleIndex="4" Caption="Promedio<br>Final" CellStyle-Font-Bold="true"  >                            
                                <CellStyle Font-Bold="True">
                                </CellStyle>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="PORC_ASISTENCIA" VisibleIndex="5" Caption="Porcentaje<br>Asistencia" CellStyle-Font-Bold="true" >                            
                                <CellStyle Font-Bold="True">
                                </CellStyle>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="PORC_PAGO" VisibleIndex="5" Caption="Porcentaje<br>pago" CellStyle-Font-Bold="true" >                            
                                <CellStyle Font-Bold="True">
                                </CellStyle>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="NOTAS" VisibleIndex="6" Caption="Observaciones" />     
                            <dx:GridViewDataTextColumn UnboundType="String" Caption=" " FieldName="COMENTARIO"  VisibleIndex="7" CellStyle-ForeColor="Red" >  
                                <CellStyle ForeColor="Red">
                                </CellStyle>
                            </dx:GridViewDataTextColumn>
                        </Columns>
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
                            <AlternatingRow Enabled="true" />
                            <LoadingPanel ImageSpacing="5px">
                            </LoadingPanel>
                        </Styles>
                        <SettingsPager  Mode="ShowAllRecords"  >                        
                        </SettingsPager>
                        <StylesEditors ButtonEditCellSpacing="0">
                            <ProgressBar Height="21px">
                            </ProgressBar>
                        </StylesEditors>
                    </dx:ASPxGridView>
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                        OldValuesParameterFormatString="original_{0}" SelectMethod="GetPorInforme" 
                        TypeName="SGAFP.DL.DS_DLTableAdapters.InformeFinal1TableAdapter">
                        <SelectParameters>
                            <asp:Parameter Name="ID_INFORME_FINAL" Type="Decimal" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" 
                        OldValuesParameterFormatString="original_{0}" SelectMethod="GetPorInforme" 
                        TypeName="SGAFP.DL.DS_DLTableAdapters.InformeFinal22TableAdapter">
                        <SelectParameters>
                            <asp:Parameter Name="ID_INFORME_FINAL" Type="Decimal" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </td>
            </tr>
        </table>
    </asp:View>
    <asp:View ID="View3" runat="server">
        <table cellpadding="0" cellspacing="0" width="100%">
            <tr valign="top">
                <td class="TabArea">
                    <uc5:ucAsistenciaAccionFormativa ID="ucAsistenciaAccionFormativa1" 
                        runat="server" />
                    </td>
            </tr>
        </table>
    </asp:View>
    <asp:View ID="View4" runat="server">
        <table cellpadding="0" cellspacing="0" width="100%">
            <tr valign="top">               
                <td class="TabArea"><uc6:ucEvaluacionesAccionFormativa ID="ucEvaluacionesAccionFormativa1" runat="server"
                        EsInformeFinal="true" />
                </td>
            </tr>
        </table>
    </asp:View>    
    <asp:View ID="View5" runat="server">
        <table cellpadding="0" cellspacing="0" width="100%">
            <tr valign="top">               
                <td class="TabArea">
                 <uc4:ucListaACCION_FORMATIVA_REPROG id="ucListaACCION_FORMATIVA_REPROG1" runat="server" 
                       VerCODIGO_ESTADO_AF="False" VerCOSTO_X_PARTICIPANTE="False" VerID_ESTADO_REPROG="False" 
                       VerID_EJERCICIO="False" VerID_OFERTA_FORMATIVA="False" PermitirEvaluar="False"  
                       VerID_PROVEEDOR_AF="False" VerID_SITIO_CAPACITACION="False" 
                       VerID_TEMA_CURSO="False" VerLASTUPDATE="True"  VerDURACION_HORAS="False" VerID_ACCION_FORMATIVA="False"  
                       VerNOMBRE_ACCION_FORMATIVA="False" VerNOTAS="False" VerMOTIVORECHAZO="False" VerMOTIVOREPROG="True"
                       VerNUMERO_PARTICIPANTES="False" VerPARTICIPANTES_INSCRITOS="False" 
                       VerUSERID="False" PermitirCambiarEstado="True" PermitirEliminar="False" VerColumnaReporte="true"></uc4:ucListaACCION_FORMATIVA_REPROG>
                </td>
            </tr>
        </table>
    </asp:View>    
    <asp:View ID="View6" runat="server">
        <table cellpadding="0" cellspacing="0" width="100%">
            <tr valign="top">
                <td class="TabArea">   
                <uc1:ucBarraNavegacion ID="ucBarraNavegacion2" PermitirAgregar="false"
                        PermitirEditar="false" PermitirGuardar="false" PermitirNavegacion="false" runat="server" />             
                 <uc1:ucVistaDetalleACCION_FORMATIVA ID="ucVistaDetalleACCION_FORMATIVA1" PermitirEditarProgramacion="true"  
                       runat="server" Visible="false" VerNOMBRE_ACCION_FORMATIVA="False" 
                       VerFECHA_INICIO="False" VerFECHA_FIN="False" ES_INFORME_FINAL="true"   
                       VerFECHA_INICIO_REAL="False" VerFECHA_FIN_REAL="False" VerHORARIO="False"                         
                       VerPARTICIPANTES_INSCRITOS="False" VerID_ACCION_FORMATIVA="False" />
                </td>
            </tr>
        </table>
    </asp:View>    
    <asp:View ID="View7" runat="server">
        <table cellpadding="0" cellspacing="0" width="100%">
            <tr valign="top">
                <td class="TabArea">
                <dx:ASPxLabel ID="ASPxLabel3" runat="server" Font-Size="Small" Font-Names="Arial" Text="Estados del Curso" Font-Bold="True" />
                <uc7:ucListaACCION_FORMATIVA_HIST ID="ucListaACCION_FORMATIVA_HIST1" runat="server" PermitirEditar="False"
                        PermitirEliminar="False" PermitirPaginacion="True" PermitirSeleccionar="False"  VerHORARIO="True" 
                        VerCODIGO_ESTADO_AF="False" VerCOSTO_X_PARTICIPANTE="False" VerID_EJERCICIO="False" VerNOMBRE_ACCION_FORMATIVA="false" 
                        VerID_OFERTA_FORMATIVA="False" VerID_PROVEEDOR_AF="False" VerID_SITIO_CAPACITACION="False"
                        VerID_TEMA_CURSO="False" VerNOTAS="False" VerID_ACCION_FORMATIVA="False" VerCODIGO_GRUPO="False"  
                        VerNUMERO_PARTICIPANTES ="False" VerDURACION_HORAS = "False" VerPARTICIPANTES_INSCRITOS="False" />
                   <br />    
               <dx:ASPxLabel ID="ASPxLabel4" runat="server" Font-Size="Small" Font-Names="Arial" Text="Estados del Informe" Font-Bold="True" />               
               <uc7:ucListaINFORME_FINAL_AF_HIS ID="ucListaINFORME_FINAL_AF_HIS1" runat="server" PermitirEditar="False"
                        PermitirEliminar="False" PermitirPaginacion="True" PermitirSeleccionar="False" PermitirFiltroEnEncabezado="False"                         
                        VerCODIGO_ESTADO_AF="False" VerID_PROVEEDOR_AF="False" 
                        VerUSERID="False" VerHORARIO="false" VerFECHA_INICIAL="false" VerFECHA_FINAL="false" VerMONTO_FACTURA="false"   
                        VerID_ACCION_FORMATIVA="false" VerFECHA_INFORME="false" VerNUMERO_FACTURA="False"
                        VerELABORADO_POR="False" VerMONTO_APROBADO="False" VerPORC_PROM_ASISTENCIA="False"
                        VerNOTA_PROMEDIO="false" VerESTADO="false" VerUSUARIO_APROBACION="false"
                        VerID_ESTADO_INFORME="false" VerID_INFORME_FINAL="false" VerHORAS_DESARROLLADAS="false" VerPARTICIPANTES_INSCRITOS="false"
                        VerPARTICIPANTES_FINALES="false" PermitirFilaDeFiltro="false"   />
                </td>
            </tr>
        </table>
    </asp:View>    
    <asp:View ID="View8" runat="server">
        <table cellpadding="0" cellspacing="0" width="100%">
            <tr valign="top">
                <td class="TabArea">    
                    <uc5:ucListaACCION_FORMATIVA_PENA ID="ucListaACCION_FORMATIVA_PENA1" runat="server" PermitirEditar="False" PermitirRowHotTrack="false" PermitirSeleccionar="false"
                        PermitirPaginacion="True" PermitirFiltroEnEncabezado="false" PermitirFilaDeFiltro="false"           
                        />                  
                </td>
            </tr>
        </table>
    </asp:View> 
    <asp:View ID="View9" runat="server">
        <table cellpadding="0" cellspacing="0" width="100%">
            <tr valign="top">
                <td class="TabArea">    
                   <uc6:ucListaACCION_PROGRA_RETRO id="ucListaACCION_PROGRA_RETRO1" VerNOMBRE_PROVEEDOR="false" VerNOMBRE_ACCION_FORMATIVA="false" PermitirEliminar="false" PermitirEditar="false" PermitirEliminarInline="false" runat="server"></uc6:ucListaACCION_PROGRA_RETRO>           
                </td>
            </tr>
        </table>
    </asp:View> 
</asp:MultiView>


<ajaxToolkit:ModalPopupExtender runat="server" ID="mpObservacionEvaluacion" BehaviorID="mpObservacionEvaluacionBehavior"
    TargetControlID="hiddenTargetControlForMpObservacionEvaluacion" PopupControlID="pObservacionEvaluacion" CancelControlID="btnCancelar" 
    BackgroundCssClass="modalBackground" DropShadow="True" PopupDragHandleControlID="pObservacionEvaluacionDragHandle"
    RepositionMode="RepositionOnWindowScroll" X="10" Y="10" >
        </ajaxtoolkit:ModalPopupExtender>
<asp:Button runat="server" ID="hiddenTargetControlForMpObservacionEvaluacion" Style="display: none" />
<asp:Panel runat="server" CssClass="modalPopup" ID="pObservacionEvaluacion" Style="padding: 5px;
    background-color: #EAF4F9; overflow: hidden; font:8pt Verdana, Arial; width: 400px; height: 200px  ">
    <asp:Panel runat="Server" ID="pObservacionEvaluacionDragHandle" Style="cursor: move;
        background-color: #DDDDDD; border: solid 1px Gray; color: Black; text-align: center;">        
        <asp:Label ID="Label2" runat="server" Text="Ingreso de Comentario"></asp:Label>
    </asp:Panel>
    <div style="overflow: auto; height: 200px; width: 400px ">
        <table>
            <tr id="trlbl_ESTADO_INFORME" runat="server" >
                <td class="style3"><asp:Label ID="lblDescripEstado" runat="server" Text=""></asp:Label></td>                               
            </tr>            
            <tr>
                <td class="style3">
                    <asp:Label ID="lblObservacion" runat="server" Text="Comentario/Observacion:"></asp:Label>
                </td>
            </tr>
            <tr>
                 <td>
                <asp:TextBox ID="txtObservacion" runat="server" Height="66px" ValidationGroup="Observaciones" Width="385px" 
                    TextMode="MultiLine"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtObservacion"
                    Display="Dynamic" ErrorMessage="*" ValidationGroup="Observaciones">Es requerida una observacion</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" 
                        ValidationGroup="Observaciones" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
                </td>
            </tr>
        </table>
    </div>  
</asp:Panel>


<ajaxToolkit:ModalPopupExtender runat="server" ID="mpAsignarTecnico" BehaviorID="mpAsignarTecnicoBehavior"
    TargetControlID="hiddenTargetControlFormpAsignarTecnico" PopupControlID="pAsignarTecnico" CancelControlID="btnCancelar" 
    BackgroundCssClass="modalBackground" DropShadow="True" PopupDragHandleControlID="pAsignarTecnicoDragHandle"
    RepositionMode="RepositionOnWindowScroll" X="10" Y="10" >
        </ajaxtoolkit:ModalPopupExtender>
<asp:Button runat="server" ID="hiddenTargetControlFormpAsignarTecnico" Style="display: none" />
<asp:Panel runat="server" CssClass="modalPopup" ID="pAsignarTecnico" Style="padding: 5px;
    background-color: #EAF4F9; overflow: hidden; font:8pt Verdana, Arial; width: 400px; height: 200px  ">
    <asp:Panel runat="Server" ID="Panel2" Style="cursor: move;
        background-color: #DDDDDD; border: solid 1px Gray; color: Black; text-align: center;">        
        <asp:Label ID="Label1" runat="server" Text="Asignación de informe a técnico"></asp:Label>
    </asp:Panel>
    <div style="overflow: auto; height: 200px; width: 400px ">
        <table>
            <tr id="tr1" runat="server" >
                <td class="style3"><asp:Label ID="Label3" runat="server" Text=""></asp:Label></td>                               
            </tr>            
            <tr>
                <td class="style3">
                    <asp:Label ID="Label4" runat="server" Text="Seleccione el técnico al que asignará el informe:"></asp:Label>                    
                </td>                
            </tr>
            <tr>
                 <td>
                <cc1:ddlUSUARIO ID="ddlUSUARIO1" runat="server" Width="300px"  ></cc1:ddlUSUARIO>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddlUSUARIO1"
                    Display="Dynamic" ErrorMessage="*" ValidationGroup="Usuario">Seleccione un técnico</asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnAsignarTecnico" runat="server" Text="Aceptar" 
                        ValidationGroup="Usuario" />
                    <asp:Button ID="btnCancelarAsignacion" runat="server" Text="Cancelar" />
                </td>
            </tr>
        </table>
    </div>  
</asp:Panel>




