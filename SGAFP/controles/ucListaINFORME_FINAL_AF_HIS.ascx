<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaINFORME_FINAL_AF_HIS.ascx.vb" Inherits="controles_ucListaINFORME_FINAL_AF_HIS" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register src="ucVistaDetalleINFORME_FINAL_AF_HIS.ascx" tagname="ucVistaDetalleINFORME_FINAL_AF_HIS" tagprefix="uc1" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" Width="100%"  DataSourceID="odsLista" KeyFieldName="ID_INFORME_FINAL_HIS" CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx">
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
    <Columns>
        <dx:GridViewCommandColumn Name="Edicion" Visible="False">
            <NewButton Visible="False" Text="Agregar">
            </NewButton>
            <EditButton Visible="False" Text="Editar"></EditButton>
            <DeleteButton Visible="False" Text="Eliminar"></DeleteButton>
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1">
            <DataItemTemplate>
                <asp:LinkButton ID="lbtnEditar" runat="server" CommandName="Editar" 
                    CommandArgument='<%# Bind("ID_INFORME_FINAL_HIS") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_INFORME_FINAL_HIS") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_INFORME_FINAL_HIS" ReadOnly="True" VisibleIndex="2" Caption="Id Hist." />
         <dx:GridViewDataTextColumn FieldName="ID_INFORME_FINAL" ReadOnly="True" VisibleIndex="2" Caption="Id Informe" />
        <dx:GridViewDataTextColumn FieldName="ID_ACCION_FORMATIVA" VisibleIndex="3" Caption="Id Curso" />                        
        <dx:GridViewDataTextColumn FieldName="HORARIO" VisibleIndex="6" Caption="Horario" />        
        <dx:GridViewDataTextColumn FieldName="HORAS_DESARROLLADAS" VisibleIndex="8" Caption="Horas Desarrolladas" HeaderStyle-Wrap="True" Width="100px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center"  >        
<HeaderStyle HorizontalAlign="Center" Wrap="True"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="PARTICIPANTES_INSCRITOS" VisibleIndex="10" Caption="Inscritos" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" >
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="PARTICIPANTES_FINALES" VisibleIndex="11" Caption="Activos" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" >
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="FECHA_INICIAL" VisibleIndex="12" Caption="Fecha Inicio" HeaderStyle-Wrap="True" Width="80px" >
        <PropertiesTextEdit DisplayFormatString="dd/MM/yyy" />

<HeaderStyle Wrap="True"></HeaderStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="FECHA_FINAL" VisibleIndex="13" Caption="Fecha Fin" HeaderStyle-Wrap="True" Width="100px" >
        <PropertiesTextEdit DisplayFormatString="dd/MM/yyy" />

<HeaderStyle Wrap="True"></HeaderStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="MONTO_APROBADO" VisibleIndex="14" Caption="Monto aprobado" >
        <PropertiesTextEdit DisplayFormatString="#,##0.00" />
        </dx:GridViewDataTextColumn>                
        <dx:GridViewDataTextColumn FieldName="ID_PROVEEDOR_AF" VisibleIndex="15" Caption="Id proveedor af" />
        <dx:GridViewDataTextColumn FieldName="FECHA_INFORME" VisibleIndex="16" Caption="Fecha informe" />
        <dx:GridViewDataTextColumn FieldName="NUMERO_FACTURA" VisibleIndex="17" Caption="Numero factura" />
        <dx:GridViewDataTextColumn FieldName="ELABORADO_POR" VisibleIndex="18" Caption="Elaborado por" />
        <dx:GridViewDataTextColumn FieldName="MONTO_FACTURA" VisibleIndex="19" Caption="Total a Pagar" HeaderStyle-Wrap="True" Width="100px">
        <PropertiesTextEdit DisplayFormatString="#,##0.00" />

<HeaderStyle Wrap="True"></HeaderStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="PORC_PROM_ASISTENCIA" VisibleIndex="20" Caption="Porc prom asistencia" />
        <dx:GridViewDataTextColumn FieldName="NOTA_PROMEDIO" VisibleIndex="21" Caption="Nota promedio" />
        <dx:GridViewDataTextColumn FieldName="ESTADO" VisibleIndex="22" Caption="Estado" />        
        <dx:GridViewDataTextColumn FieldName="USUARIO_APROBACION" VisibleIndex="24" Caption="Usuario aprobacion" />
        <dx:GridViewDataTextColumn FieldName="LASTUPDATE" VisibleIndex="25" Caption="Actualización" Width="130px"  />
        <dx:GridViewDataTextColumn FieldName="USERID" VisibleIndex="26" Caption="Userid" />
        <dx:GridViewDataTextColumn FieldName="USUARIO" UnboundType="string" VisibleIndex="27" Caption="Usuario" />
        <dx:GridViewDataTextColumn FieldName="ID_ESTADO_INFORME" VisibleIndex="28" Caption="Id estado informe" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ESTADO_INFORME" UnboundType="string" VisibleIndex="29" Caption="Estado" />        
        <dx:GridViewDataTextColumn FieldName="COMENTARIOS" VisibleIndex="30" Caption="Observaciones" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="24">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
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
    <Templates>
        <EditForm>
            <uc1:ucVistaDetalleINFORME_FINAL_AF_HIS ID="ucVistaDetalleINFORME_FINAL_AF_HIS1" runat="server" 
                ID_INFORME_FINAL_HIS='<%# Bind("ID_INFORME_FINAL_HIS") %>' ID_INFORME_FINAL='<%# Bind("ID_INFORME_FINAL") %>' ID_ACCION_FORMATIVA='<%# Bind("ID_ACCION_FORMATIVA") %>' ID_PROVEEDOR_AF='<%# Bind("ID_PROVEEDOR_AF") %>' FECHA_INFORME='<%# Bind("FECHA_INFORME") %>' NUMERO_FACTURA='<%# Bind("NUMERO_FACTURA") %>' ELABORADO_POR='<%# Bind("ELABORADO_POR") %>' MONTO_FACTURA='<%# Bind("MONTO_FACTURA") %>' MONTO_APROBADO='<%# Bind("MONTO_APROBADO") %>' PARTICIPANTES_INSCRITOS='<%# Bind("PARTICIPANTES_INSCRITOS") %>' PARTICIPANTES_FINALES='<%# Bind("PARTICIPANTES_FINALES") %>' PORC_PROM_ASISTENCIA='<%# Bind("PORC_PROM_ASISTENCIA") %>' NOTA_PROMEDIO='<%# Bind("NOTA_PROMEDIO") %>' COMENTARIOS='<%# Bind("COMENTARIOS") %>' USUARIO_APROBACION='<%# Bind("USUARIO_APROBACION") %>' LASTUPDATE='<%# Bind("LASTUPDATE") %>' USERID='<%# Bind("USERID") %>' ID_ESTADO_INFORME='<%# Bind("ID_ESTADO_INFORME") %>' HORAS_DESARROLLADAS='<%# Bind("HORAS_DESARROLLADAS") %>' FECHA_INICIAL='<%# Bind("FECHA_INICIAL") %>' FECHA_FINAL='<%# Bind("FECHA_FINAL") %>' />
             <div style="text-align:right; padding:2px 2px 2px 2px"><table cellpadding="0" cellspacing="0">
                    <tr><td><dx:ASPxButton ID="btnGuardar" runat="server" AutoPostBack="False" Text="Guardar" Width="74px">   
                                <ClientSideEvents Click="function(s, e){if(!s.CauseValidation())return false;eval(s.cp_NombreClienteLista).UpdateEdit();}" />
                            </dx:ASPxButton></td>
                        <td style="padding-left: 13px;"><dx:ASPxButton ID="btnCancelar" runat="server" AutoPostBack="False" Text="Cancelar" Width="74px" CausesValidation="False">
                                <ClientSideEvents Click="function(s, e){eval(s.cp_NombreClienteLista).CancelEdit();}" />                            
             </dx:ASPxButton></td></tr></table></div>
        </EditForm>
        <EmptyDataRow>
            <dx:ASPxButton ID="btnAgregar" runat="server" AutoPostBack="False" Text="Agregar">
                <ClientSideEvents Click="function(s, e) {eval(s.cp_NombreClienteLista).AddNewRow();}" />
            </dx:ASPxButton>
            <dx:ASPxLabel ID="lblEmptyDataRow" runat="server" Text="No existen registros para mostrar"></dx:ASPxLabel>
        </EmptyDataRow>
    </Templates>
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
</dx:ASPxGridView>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarINFORME_FINAL_AF_HIS" DeleteMethod="EliminarINFORME_FINAL_AF_HIS" UpdateMethod="ActualizarINFORME_FINAL_AF_HIS"
    TypeName="SGAFP.BL.cINFORME_FINAL_AF_HIS">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_INFORME_FINAL_HIS" Type="Decimal" />
        <asp:Parameter Name="ID_INFORME_FINAL" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="FECHA_INFORME" Type="DateTime" />
        <asp:Parameter Name="NUMERO_FACTURA" Type="String" />
        <asp:Parameter Name="ELABORADO_POR" Type="String" />
        <asp:Parameter Name="MONTO_FACTURA" Type="Decimal" />
        <asp:Parameter Name="MONTO_APROBADO" Type="Decimal" />
        <asp:Parameter Name="PARTICIPANTES_INSCRITOS" Type="Decimal" />
        <asp:Parameter Name="PARTICIPANTES_FINALES" Type="Decimal" />
        <asp:Parameter Name="PORC_PROM_ASISTENCIA" Type="Decimal" />
        <asp:Parameter Name="NOTA_PROMEDIO" Type="Decimal" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="COMENTARIOS" Type="String" />
        <asp:Parameter Name="USUARIO_APROBACION" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="ID_ESTADO_INFORME" Type="Decimal" />
        <asp:Parameter Name="HORAS_DESARROLLADAS" Type="Decimal" />
        <asp:Parameter Name="FECHA_INICIAL" Type="DateTime" />
        <asp:Parameter Name="FECHA_FINAL" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_INFORME_FINAL_HIS" Type="Decimal" />
        <asp:Parameter Name="ID_INFORME_FINAL" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="FECHA_INFORME" Type="DateTime" />
        <asp:Parameter Name="NUMERO_FACTURA" Type="String" />
        <asp:Parameter Name="ELABORADO_POR" Type="String" />
        <asp:Parameter Name="MONTO_FACTURA" Type="Decimal" />
        <asp:Parameter Name="MONTO_APROBADO" Type="Decimal" />
        <asp:Parameter Name="PARTICIPANTES_INSCRITOS" Type="Decimal" />
        <asp:Parameter Name="PARTICIPANTES_FINALES" Type="Decimal" />
        <asp:Parameter Name="PORC_PROM_ASISTENCIA" Type="Decimal" />
        <asp:Parameter Name="NOTA_PROMEDIO" Type="Decimal" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="COMENTARIOS" Type="String" />
        <asp:Parameter Name="USUARIO_APROBACION" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="ID_ESTADO_INFORME" Type="Decimal" />
        <asp:Parameter Name="HORAS_DESARROLLADAS" Type="Decimal" />
        <asp:Parameter Name="FECHA_INICIAL" Type="DateTime" />
        <asp:Parameter Name="FECHA_FINAL" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_INFORME_FINAL_HIS" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorINFORME_FINAL_AF" runat="server" 
    SelectMethod="ObtenerListaPorINFORME_FINAL_AF" InsertMethod="AgregarINFORME_FINAL_AF_HIS" DeleteMethod="EliminarINFORME_FINAL_AF_HIS" UpdateMethod="ActualizarINFORME_FINAL_AF_HIS"
    TypeName="SGAFP.BL.cINFORME_FINAL_AF_HIS">
    <SelectParameters>
        <asp:Parameter Name="ID_INFORME_FINAL" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_INFORME_FINAL_HIS" Type="Decimal" />
        <asp:Parameter Name="ID_INFORME_FINAL" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="FECHA_INFORME" Type="DateTime" />
        <asp:Parameter Name="NUMERO_FACTURA" Type="String" />
        <asp:Parameter Name="ELABORADO_POR" Type="String" />
        <asp:Parameter Name="MONTO_FACTURA" Type="Decimal" />
        <asp:Parameter Name="MONTO_APROBADO" Type="Decimal" />
        <asp:Parameter Name="PARTICIPANTES_INSCRITOS" Type="Decimal" />
        <asp:Parameter Name="PARTICIPANTES_FINALES" Type="Decimal" />
        <asp:Parameter Name="PORC_PROM_ASISTENCIA" Type="Decimal" />
        <asp:Parameter Name="NOTA_PROMEDIO" Type="Decimal" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="COMENTARIOS" Type="String" />
        <asp:Parameter Name="USUARIO_APROBACION" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="ID_ESTADO_INFORME" Type="Decimal" />
        <asp:Parameter Name="HORAS_DESARROLLADAS" Type="Decimal" />
        <asp:Parameter Name="FECHA_INICIAL" Type="DateTime" />
        <asp:Parameter Name="FECHA_FINAL" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_INFORME_FINAL_HIS" Type="Decimal" />
        <asp:Parameter Name="ID_INFORME_FINAL" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="FECHA_INFORME" Type="DateTime" />
        <asp:Parameter Name="NUMERO_FACTURA" Type="String" />
        <asp:Parameter Name="ELABORADO_POR" Type="String" />
        <asp:Parameter Name="MONTO_FACTURA" Type="Decimal" />
        <asp:Parameter Name="MONTO_APROBADO" Type="Decimal" />
        <asp:Parameter Name="PARTICIPANTES_INSCRITOS" Type="Decimal" />
        <asp:Parameter Name="PARTICIPANTES_FINALES" Type="Decimal" />
        <asp:Parameter Name="PORC_PROM_ASISTENCIA" Type="Decimal" />
        <asp:Parameter Name="NOTA_PROMEDIO" Type="Decimal" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="COMENTARIOS" Type="String" />
        <asp:Parameter Name="USUARIO_APROBACION" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="ID_ESTADO_INFORME" Type="Decimal" />
        <asp:Parameter Name="HORAS_DESARROLLADAS" Type="Decimal" />
        <asp:Parameter Name="FECHA_INICIAL" Type="DateTime" />
        <asp:Parameter Name="FECHA_FINAL" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_INFORME_FINAL_HIS" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorACCION_FORMATIVA" runat="server" 
    SelectMethod="ObtenerListaPorACCION_FORMATIVA" InsertMethod="AgregarINFORME_FINAL_AF_HIS" DeleteMethod="EliminarINFORME_FINAL_AF_HIS" UpdateMethod="ActualizarINFORME_FINAL_AF_HIS"
    TypeName="SGAFP.BL.cINFORME_FINAL_AF_HIS">
    <SelectParameters>
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_INFORME_FINAL_HIS" Type="Decimal" />
        <asp:Parameter Name="ID_INFORME_FINAL" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="FECHA_INFORME" Type="DateTime" />
        <asp:Parameter Name="NUMERO_FACTURA" Type="String" />
        <asp:Parameter Name="ELABORADO_POR" Type="String" />
        <asp:Parameter Name="MONTO_FACTURA" Type="Decimal" />
        <asp:Parameter Name="MONTO_APROBADO" Type="Decimal" />
        <asp:Parameter Name="PARTICIPANTES_INSCRITOS" Type="Decimal" />
        <asp:Parameter Name="PARTICIPANTES_FINALES" Type="Decimal" />
        <asp:Parameter Name="PORC_PROM_ASISTENCIA" Type="Decimal" />
        <asp:Parameter Name="NOTA_PROMEDIO" Type="Decimal" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="COMENTARIOS" Type="String" />
        <asp:Parameter Name="USUARIO_APROBACION" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="ID_ESTADO_INFORME" Type="Decimal" />
        <asp:Parameter Name="HORAS_DESARROLLADAS" Type="Decimal" />
        <asp:Parameter Name="FECHA_INICIAL" Type="DateTime" />
        <asp:Parameter Name="FECHA_FINAL" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_INFORME_FINAL_HIS" Type="Decimal" />
        <asp:Parameter Name="ID_INFORME_FINAL" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="FECHA_INFORME" Type="DateTime" />
        <asp:Parameter Name="NUMERO_FACTURA" Type="String" />
        <asp:Parameter Name="ELABORADO_POR" Type="String" />
        <asp:Parameter Name="MONTO_FACTURA" Type="Decimal" />
        <asp:Parameter Name="MONTO_APROBADO" Type="Decimal" />
        <asp:Parameter Name="PARTICIPANTES_INSCRITOS" Type="Decimal" />
        <asp:Parameter Name="PARTICIPANTES_FINALES" Type="Decimal" />
        <asp:Parameter Name="PORC_PROM_ASISTENCIA" Type="Decimal" />
        <asp:Parameter Name="NOTA_PROMEDIO" Type="Decimal" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="COMENTARIOS" Type="String" />
        <asp:Parameter Name="USUARIO_APROBACION" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="ID_ESTADO_INFORME" Type="Decimal" />
        <asp:Parameter Name="HORAS_DESARROLLADAS" Type="Decimal" />
        <asp:Parameter Name="FECHA_INICIAL" Type="DateTime" />
        <asp:Parameter Name="FECHA_FINAL" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_INFORME_FINAL_HIS" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPROVEEDOR_AF" runat="server" 
    SelectMethod="ObtenerListaPorPROVEEDOR_AF" InsertMethod="AgregarINFORME_FINAL_AF_HIS" DeleteMethod="EliminarINFORME_FINAL_AF_HIS" UpdateMethod="ActualizarINFORME_FINAL_AF_HIS"
    TypeName="SGAFP.BL.cINFORME_FINAL_AF_HIS">
    <SelectParameters>
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_INFORME_FINAL_HIS" Type="Decimal" />
        <asp:Parameter Name="ID_INFORME_FINAL" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="FECHA_INFORME" Type="DateTime" />
        <asp:Parameter Name="NUMERO_FACTURA" Type="String" />
        <asp:Parameter Name="ELABORADO_POR" Type="String" />
        <asp:Parameter Name="MONTO_FACTURA" Type="Decimal" />
        <asp:Parameter Name="MONTO_APROBADO" Type="Decimal" />
        <asp:Parameter Name="PARTICIPANTES_INSCRITOS" Type="Decimal" />
        <asp:Parameter Name="PARTICIPANTES_FINALES" Type="Decimal" />
        <asp:Parameter Name="PORC_PROM_ASISTENCIA" Type="Decimal" />
        <asp:Parameter Name="NOTA_PROMEDIO" Type="Decimal" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="COMENTARIOS" Type="String" />
        <asp:Parameter Name="USUARIO_APROBACION" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="ID_ESTADO_INFORME" Type="Decimal" />
        <asp:Parameter Name="HORAS_DESARROLLADAS" Type="Decimal" />
        <asp:Parameter Name="FECHA_INICIAL" Type="DateTime" />
        <asp:Parameter Name="FECHA_FINAL" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_INFORME_FINAL_HIS" Type="Decimal" />
        <asp:Parameter Name="ID_INFORME_FINAL" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="FECHA_INFORME" Type="DateTime" />
        <asp:Parameter Name="NUMERO_FACTURA" Type="String" />
        <asp:Parameter Name="ELABORADO_POR" Type="String" />
        <asp:Parameter Name="MONTO_FACTURA" Type="Decimal" />
        <asp:Parameter Name="MONTO_APROBADO" Type="Decimal" />
        <asp:Parameter Name="PARTICIPANTES_INSCRITOS" Type="Decimal" />
        <asp:Parameter Name="PARTICIPANTES_FINALES" Type="Decimal" />
        <asp:Parameter Name="PORC_PROM_ASISTENCIA" Type="Decimal" />
        <asp:Parameter Name="NOTA_PROMEDIO" Type="Decimal" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="COMENTARIOS" Type="String" />
        <asp:Parameter Name="USUARIO_APROBACION" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="ID_ESTADO_INFORME" Type="Decimal" />
        <asp:Parameter Name="HORAS_DESARROLLADAS" Type="Decimal" />
        <asp:Parameter Name="FECHA_INICIAL" Type="DateTime" />
        <asp:Parameter Name="FECHA_FINAL" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_INFORME_FINAL_HIS" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorESTADO_INFORME_AF" runat="server" 
    SelectMethod="ObtenerListaPorESTADO_INFORME_AF" InsertMethod="AgregarINFORME_FINAL_AF_HIS" DeleteMethod="EliminarINFORME_FINAL_AF_HIS" UpdateMethod="ActualizarINFORME_FINAL_AF_HIS"
    TypeName="SGAFP.BL.cINFORME_FINAL_AF_HIS">
    <SelectParameters>
        <asp:Parameter Name="ID_ESTADO_INFORME" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_INFORME_FINAL_HIS" Type="Decimal" />
        <asp:Parameter Name="ID_INFORME_FINAL" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="FECHA_INFORME" Type="DateTime" />
        <asp:Parameter Name="NUMERO_FACTURA" Type="String" />
        <asp:Parameter Name="ELABORADO_POR" Type="String" />
        <asp:Parameter Name="MONTO_FACTURA" Type="Decimal" />
        <asp:Parameter Name="MONTO_APROBADO" Type="Decimal" />
        <asp:Parameter Name="PARTICIPANTES_INSCRITOS" Type="Decimal" />
        <asp:Parameter Name="PARTICIPANTES_FINALES" Type="Decimal" />
        <asp:Parameter Name="PORC_PROM_ASISTENCIA" Type="Decimal" />
        <asp:Parameter Name="NOTA_PROMEDIO" Type="Decimal" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="COMENTARIOS" Type="String" />
        <asp:Parameter Name="USUARIO_APROBACION" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="ID_ESTADO_INFORME" Type="Decimal" />
        <asp:Parameter Name="HORAS_DESARROLLADAS" Type="Decimal" />
        <asp:Parameter Name="FECHA_INICIAL" Type="DateTime" />
        <asp:Parameter Name="FECHA_FINAL" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_INFORME_FINAL_HIS" Type="Decimal" />
        <asp:Parameter Name="ID_INFORME_FINAL" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="FECHA_INFORME" Type="DateTime" />
        <asp:Parameter Name="NUMERO_FACTURA" Type="String" />
        <asp:Parameter Name="ELABORADO_POR" Type="String" />
        <asp:Parameter Name="MONTO_FACTURA" Type="Decimal" />
        <asp:Parameter Name="MONTO_APROBADO" Type="Decimal" />
        <asp:Parameter Name="PARTICIPANTES_INSCRITOS" Type="Decimal" />
        <asp:Parameter Name="PARTICIPANTES_FINALES" Type="Decimal" />
        <asp:Parameter Name="PORC_PROM_ASISTENCIA" Type="Decimal" />
        <asp:Parameter Name="NOTA_PROMEDIO" Type="Decimal" />
        <asp:Parameter Name="ESTADO" Type="String" />
        <asp:Parameter Name="COMENTARIOS" Type="String" />
        <asp:Parameter Name="USUARIO_APROBACION" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="ID_ESTADO_INFORME" Type="Decimal" />
        <asp:Parameter Name="HORAS_DESARROLLADAS" Type="Decimal" />
        <asp:Parameter Name="FECHA_INICIAL" Type="DateTime" />
        <asp:Parameter Name="FECHA_FINAL" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_INFORME_FINAL_HIS" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
