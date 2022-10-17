<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucAsistenciaAccionFormativaHoras.ascx.vb" Inherits="controles_ucAsistenciaAccionFormativaHoras" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxCallback" TagPrefix="dx" %>

<%@ Register src="ucListaACCION_FORMATIVA.ascx" tagname="ucListaACCION_FORMATIVA" tagprefix="uc2" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxLoadingPanel" TagPrefix="dx" %>


<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxMenu" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxTabControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxClasses" tagprefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>

<table>
    <tr>
        <td valign="top">
            <table>               
                <tr>
                    <th colspan="2" >
                        <dx:ASPxCalendar ID="ASPxCalendar1" runat="server" TodayButtonText="Hoy" ShowClearButton="False">
                        </dx:ASPxCalendar>          
                    </th>
                </tr>
            </table>
        </td>
        <td valign="top" style=" width:100% " >
            <dx:ASPxCallbackPanel ID="CallbackPanel" ClientInstanceName="CallbackPanel" runat="server" LoadingPanelText="Cargando..." >
                <ClientSideEvents EndCallback="function(s,e){                                                    
                                                    if(s.cpResultCallback != undefined){
                                                        switch(s.cpResultCallback){
                                                            case 'MostrarPopupInasistencia':
                                                                popupInasistencias.Show(); 
                                                                break;
                                                            default:
                                                                popupInasistencias.Hide(); 
                                                        }
                                                    }
                                               }" />
                <PanelCollection>
                <dx:PanelContent ID="PanelContent1" runat="server" >
                    <table width="100%" >
                        <tr>
                            <td>
                                <dx:ASPxLabel ID="lblLabel1"  runat="server" Text="FECHA: " />                       
                                <dx:ASPxLabel ID="lblFecha" ClientInstanceName="lblFecha"  runat="server"  />                        
                            </td>                                        
                        </tr>
                        <tr>
                            <td>
                                <dx:ASPxLabel ID="lblLabel2"  runat="server" Text="HORARIO: " />                        
                                <dx:ASPxLabel ID="lblHorario" runat="server" ClientInstanceName="lblHorario" />         
                            </td>
                        </tr>
                        <tr>                    
                            <td>                                  
                                <table width="100%">                        
                                    <tr>
                                        <td>
                                            <dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" ClientInstanceName="grid" Font-Size="X-Small" Font-Names="Arial" 
                                                    KeyFieldName = "ID_PARTICIPANTE" Width="100%" DataSourceID="odsListaAsistencia">
                                                <ClientSideEvents CustomButtonClick="function(s,e){
                                                                                            if (e.buttonID=='btnReplicarInasistencia'){                                                                                                
                                                                                                CallbackPanel.PerformCallback('Inasistencia;' +  s.cpKeyValues[e.visibleIndex]);                                                                                                
                                                                                            }
                                                                                            else{                                                                                                
                                                                                                e.processOnServer = true;                                                                                               
                                                                                            }
                                                                                        }" /> 
                                                <Columns>
                                                    <dx:GridViewDataColumn VisibleIndex="0" Caption="N°" FieldName="CORRELATIVO" UnboundType="Integer">                                                        
                                                        <EditFormSettings Visible ="False" />                                                    
                                                    </dx:GridViewDataColumn>                                                                                                                                                                                                                                                                                                                                                                                                         
                                                    <dx:GridViewDataTextColumn FieldName="ID_ASISTENCIA_DET" VisibleIndex="1" Caption="ID_ASISTENCIA_DET" Visible="False" >                                                            
                                                        <EditFormSettings Visible ="False" />                                                                                                                                                                                                                                                                                                 
                                                    </dx:GridViewDataTextColumn>               
                                                    <dx:GridViewDataTextColumn FieldName="ID_PARTICIPANTE" VisibleIndex="2" Caption="ID PARTI." >                                                            
                                                        <EditFormSettings Visible ="False" />                                                                                                                                                                                                                                                                                                 
                                                    </dx:GridViewDataTextColumn>                                                    
                                                    <dx:GridViewDataTextColumn FieldName="APELLIDOS" VisibleIndex="3" Caption="APELLIDOS" ReadOnly="true"  />    
                                                    <dx:GridViewDataTextColumn FieldName="NOMBRES" VisibleIndex="4" Caption="NOMBRES" ReadOnly="true" />    
                                                    <dx:GridViewDataCheckColumn FieldName="ASISTIO" VisibleIndex="5" Caption="ASISTIO">                                                        
                                                        <PropertiesCheckEdit ValueType="System.String" ValueChecked="1" ValueUnchecked="0" 
                                                            ClientSideEvents-ValueChanged="function(s,e){                                                                                                                                                                                           
                                                                                                if (s.GetValue() == '1'){                                                                                                                                                                                          
                                                                                                    grid.SetEditValue('PRESENTA_JUSTIFICACION','0');                                                                                                
                                                                                                    grid.SetEditValue('JUSTIFICACION','');
                                                                                                    grid.SetEditValue('HORAS_ASISTIDAS',new Date(1900,1,1,CallbackPanel.cpHorasTotales,CallbackPanel.cpMinutosTotales,0));
                                                                                                    }
                                                                                                else{                                                                                                                                                                                            
                                                                                                    grid.SetEditValue('HORAS_ASISTIDAS',new Date(1900,1,1,0,0,0));
                                                                                                    }                                                                                                                                                                                           
                                                                                            }" >
<ClientSideEvents ValueChanged="function(s,e){                                                                                                                                                                                           
                                                                                                if (s.GetValue() == '1'){                                                                                                                                                                                          
                                                                                                    grid.SetEditValue('PRESENTA_JUSTIFICACION','0');                                                                                                
                                                                                                    grid.SetEditValue('JUSTIFICACION','');
                                                                                                    grid.SetEditValue('HORAS_ASISTIDAS',new Date(1900,1,1,CallbackPanel.cpHorasTotales,CallbackPanel.cpMinutosTotales,0));
                                                                                                    }
                                                                                                else{                                                                                                                                                                                            
                                                                                                    grid.SetEditValue('HORAS_ASISTIDAS',new Date(1900,1,1,0,0,0));
                                                                                                    }                                                                                                                                                                                           
                                                                                            }"></ClientSideEvents>
                                                        </PropertiesCheckEdit>                                                                                                                
                                                    </dx:GridViewDataCheckColumn>  
                                                        
                                                    <dx:GridViewDataTimeEditColumn FieldName="HORAS_ASISTIDAS" VisibleIndex="6" Caption="HORAS ASISTIDAS" UnboundType="DateTime" PropertiesTimeEdit-DisplayFormatString="HH:mm" PropertiesTimeEdit-EditFormat="Custom" PropertiesTimeEdit-EditFormatString="HH:mm" >                                                                                                                                                  
                                                        <PropertiesTimeEdit ClientSideEvents-ValueChanged ="function(s,e){                                                                                                      
                                                                                                if (grid.GetEditValue('ASISTIO') == '0'){                                                                                                                                                                                                    
                                                                                                    grid.SetEditValue('HORAS_ASISTIDAS',new Date(1900,1,1,0,0,0));                                                                                                                                                                                                                                                                                              
                                                                                                }
                                                                                            }" >
<ClientSideEvents ValueChanged="function(s,e){                                                                                                      
                                                                                                if (grid.GetEditValue('ASISTIO') == '0'){                                                                                                                                                                                                    
                                                                                                    grid.SetEditValue('HORAS_ASISTIDAS',new Date(1900,1,1,0,0,0));                                                                                                                                                                                                                                                                                              
                                                                                                }
                                                                                            }"></ClientSideEvents>
                                                        </PropertiesTimeEdit>   
                                                    </dx:GridViewDataTimeEditColumn>                                                                                                                                                                                             
                                                                                        
                                                    <dx:GridViewDataCheckColumn FieldName="PRESENTA_JUSTIFICACION" VisibleIndex="7" Caption="JUSTIFICO">                                                    
                                                        <PropertiesCheckEdit ValueType="System.String" ValueChecked="1" ValueUnchecked="0"
                                                            ClientSideEvents-ValueChanged="function(s,e){                                                                                                      
                                                                                                if (s.GetValue() == '1'){
                                                                                                    grid.SetEditValue('ASISTIO','0');                                                                                                      
                                                                                                    grid.SetEditValue('HORAS_ASISTIDAS',new Date(1900,1,1,0,0,0));                                                                                                                                                                                                                                                                                              
                                                                                                }
                                                                                                else{                                                                                                    
                                                                                                    grid.SetEditValue('JUSTIFICACION','');
                                                                                                }
                                                                                            }" >
<ClientSideEvents ValueChanged="function(s,e){                                                                                                      
                                                                                                if (s.GetValue() == '1'){
                                                                                                    grid.SetEditValue('ASISTIO','0');                                                                                                      
                                                                                                    grid.SetEditValue('HORAS_ASISTIDAS',new Date(1900,1,1,0,0,0));                                                                                                                                                                                                                                                                                              
                                                                                                }
                                                                                                else{                                                                                                    
                                                                                                    grid.SetEditValue('JUSTIFICACION','');
                                                                                                }
                                                                                            }"></ClientSideEvents>
                                                        </PropertiesCheckEdit>   
                                                    </dx:GridViewDataCheckColumn>                                                            
                                                    <dx:GridViewDataTextColumn FieldName="JUSTIFICACION" VisibleIndex="8" Caption="JUSTIFICACION">                                                      
                                                        <PropertiesTextEdit MaxLength="80" />
                                                    </dx:GridViewDataTextColumn>
                                                    <dx:GridViewCommandColumn ButtonType="Image" Name="REPLICAR_INASISTENCIA" Caption=" " VisibleIndex="8" >
                                                        <CustomButtons >
                                                            <dx:GridViewCommandColumnCustomButton ID="btnReplicarInasistencia" Image-ToolTip="Agregar inasistencias desde este día hasta el final del curso "  Image-Url="../imagenes/replicar.png" Image-Width="16px" Image-Height="16px" Image-SpriteProperties-Left="120px"  >
<Image ToolTip="Agregar inasistencias desde este d&#237;a hasta el final del curso " Height="16px" Width="16px" Url="../imagenes/replicar.png">
<SpriteProperties Left="120px"></SpriteProperties>
</Image>
                                                            </dx:GridViewCommandColumnCustomButton>
                                                        </CustomButtons>
                                                    </dx:GridViewCommandColumn>
                                                    <dx:GridViewCommandColumn VisibleIndex="9" Caption=" " Name="COLUMNA_EDICION"  >
                                                        <EditButton Visible="true" Text="Editar" />
                                                    </dx:GridViewCommandColumn>
                                                </Columns>      
                                                <SettingsLoadingPanel Text="Cargando..." />      
                                                <SettingsEditing Mode="EditFormAndDisplayRow"   />                                                                                                                                                                                                                                                                                                                                   
                                            </dx:ASPxGridView>      
                                            <dx:ASPxHiddenField runat="server" ClientInstanceName="hfParametros" ID="hfParametros" />                                         
                                            <asp:ObjectDataSource ID="odsListaAsistencia" runat="server" 
                                                SelectMethod="ObtenerDataSetListaAsistencia"
                                                UpdateMethod="ActualizarASISTENCIA_AF_DET" 
                                                TypeName="SGAFP.BL.cASISTENCIA_AF_DET">
                                                <SelectParameters>
                                                    <asp:Parameter Name="ID_ASISTENCIA_AF" Type="Decimal" />
                                                    <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />                                                    
                                                </SelectParameters> 
                                                <UpdateParameters>
                                                    <asp:Parameter Name="ID_ASISTENCIA_DET" Type="Decimal" />
                                                    <asp:Parameter Name="ID_ASISTENCIA_AF" Type="Decimal" />
                                                    <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
                                                    <asp:Parameter Name="ASISTIO" Type="String" />       
                                                    <asp:Parameter Name="PRESENTA_JUSTIFICACION" Type="String" />       
                                                    <asp:Parameter Name="JUSTIFICACION" Type="String" />       
                                                    <asp:Parameter Name="HORAS_ASISTENCIA" Type="Decimal" />                                                                                                                
                                                </UpdateParameters>                                              
                                            </asp:ObjectDataSource>                    
                                        </td>
                                    </tr>
                                </table>                                                                        
                            </td>                    
                        </tr>                
                    </table>  
                     <dx:ASPxPopupControl ID="popupInasistencias" Modal="true" runat="server" 
                            PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" PopupElementID="BuscarNombresbtn" 
                            AllowResize="False" DragElement="Header" HeaderStyle-Font-Bold="true" HeaderText="Inasistencias"   
                            AllowDragging="True" ClientInstanceName="popupInasistencias" ShowShadow="true"
                            CloseAction="CloseButton" Width="323px">  
                                     <ContentCollection>
                                         <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server" >          
                                            <table>               
                                                <tr>
                                                    <td style="text-align:justify;"><dx:ASPxLabel ID="popuplblInfo" runat="server" Font-Names="Verdana,Arial,Tahoma" Font-Size="X-Small" /></td>
                                                </tr> 
                                                <tr><td></td></tr>
                                                <tr>
                                                    <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Justificación:" Font-Names="Verdana,Arial,Tahoma" Font-Bold="true" Font-Size="X-Small" /></td>
                                                </tr>                                                                      
                                                <tr>
                                                    <td>
                                                        <dx:ASPxMemo ID="popupmmoJustificacion" ClientInstanceName="popupmmoJustificacion" runat="server" Height="60px" Width="100%" />                                                     
                                                    </td>
                                                </tr>
                                                <tr align="center" >
                                                    <td>
                                                        <table>
                                                            <tr>
                                                                <td style="padding-right:5px">
                                                                    <dx:ASPxButton ID="btnAceptar" runat="server" Text="Aceptar" AutoPostBack="False" CausesValidation="False" UseSubmitBehavior="False" >                       
                                                                        <ClientSideEvents Click="function(s,e){ CallbackPanel.PerformCallback('ReplicarInasistencia;' + popupmmoJustificacion.GetText()); }" />
                                                                    </dx:ASPxButton>
                                                                </td>
                                                                <td style="padding-left:5px">
                                                                    <dx:ASPxButton ID="btnCancelar" runat="server" Text="Cancelar" AutoPostBack="False" CausesValidation="False" UseSubmitBehavior="False" >   
                                                                        <ClientSideEvents Click="function(s,e){popupInasistencias.Hide();}" />
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
        </td>       
    </tr>
   
</table>
