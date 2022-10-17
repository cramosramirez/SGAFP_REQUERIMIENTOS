<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaINFORME_FINAL_AF.ascx.vb" Inherits="controles_ucListaINFORME_FINAL_AF" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxHiddenField" tagprefix="dx" %>


<dx:ASPxCallbackPanel runat="server" ID="cbpucListaINFORME_FINAL_AF" ClientInstanceName="cbpucListaINFORME_FINAL_AF">    
        <PanelCollection>
            <dx:PanelContent ID="PanelContent1" runat="server"> 
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" ClientInstanceName="dxgvListaINFORME" KeyFieldName="ID_INFORME_FINAL" Width="100%" CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx">
    <SettingsPager PageSize="5" >
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)"  
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    
    <Columns>
        <dx:GridViewCommandColumn ShowSelectCheckbox="True" Name="#" Caption="#" Visible="false" VisibleIndex="0" />      
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
                    CommandArgument='<%# Bind("ID_INFORME_FINAL") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_INFORME_FINAL") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="NOMBRE_DEPARTAMENTO" ReadOnly="True" VisibleIndex="2" Caption="Departamento" UnboundType="String" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_MUNICIPIO" ReadOnly="True" VisibleIndex="2" Caption="Municipio" UnboundType="String" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROGRAMA_FORMACION" CellStyle-ForeColor="Blue"  ReadOnly="True" VisibleIndex="2" Caption="Programa Formación" UnboundType="String" Visible="False" >        
<CellStyle ForeColor="Blue"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" ReadOnly="True" VisibleIndex="2" Caption="Proveedor" UnboundType="String" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="LUGAR_EJECUCION" ReadOnly="True" VisibleIndex="2" Caption="Lugar Ejecución" UnboundType="String" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="ID_INFORME_FINAL" ReadOnly="True" VisibleIndex="2" Caption="Id Informe" />
        <dx:GridViewDataTextColumn FieldName="ID_ACCION_FORMATIVA" VisibleIndex="3" Caption="Id Curso" />        
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ACCION_FORMATIVA" VisibleIndex="4" Caption="Nombre Curso" UnboundType="String" />                
        <dx:GridViewDataTextColumn FieldName="CODIGO_GRUPO" VisibleIndex="5" Caption="Codigo Grupo" UnboundType="String" Width="120px"  />    
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ESTADO_INFORME" CellStyle-ForeColor="Blue" ReadOnly="True" VisibleIndex="5" Caption="Estado" UnboundType="String" >
<CellStyle ForeColor="Blue"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="HORARIO" VisibleIndex="6" Caption="Horario" />
        <dx:GridViewDataTextColumn FieldName="DURACION" VisibleIndex="7" 
            UnboundType="Decimal" Caption="Horas Totales" HeaderStyle-Wrap="True" 
            Width="50px" HeaderStyle-HorizontalAlign="Center" 
            CellStyle-HorizontalAlign="Center"  >
<HeaderStyle HorizontalAlign="Center" Wrap="True"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="HORAS_DESARROLLADAS" VisibleIndex="8" 
            Caption="Horas Desarrolladas" HeaderStyle-Wrap="True" Width="50px" 
            HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center"  >
<HeaderStyle HorizontalAlign="Center" Wrap="True"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="HORAS_ACUMULADAS" VisibleIndex="9"  
            UnboundType="Decimal" Caption="Horas Acumuladas" HeaderStyle-Wrap="True" 
            Width="50px" HeaderStyle-HorizontalAlign="Center" 
            CellStyle-HorizontalAlign="Center" >            
<HeaderStyle HorizontalAlign="Center" Wrap="True"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="PARTICIPANTES_INSCRITOS" 
            VisibleIndex="10" Caption="Inscritos" HeaderStyle-HorizontalAlign="Center" 
            CellStyle-HorizontalAlign="Center" >
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="PARTICIPANTES_FINALES" VisibleIndex="11" 
            Caption="Activos" HeaderStyle-HorizontalAlign="Center" 
            CellStyle-HorizontalAlign="Center" >
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="FECHA_INICIAL" VisibleIndex="12" Caption="Fecha Inicio" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" Width="50px" >
        <PropertiesTextEdit DisplayFormatString="dd/MM/yyy" />

<HeaderStyle Wrap="True"></HeaderStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="FECHA_FINAL" VisibleIndex="13" Caption="Fecha Finalización" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" Width="70px" >
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
        <dx:GridViewDataTextColumn FieldName="MONTO_FACTURA" VisibleIndex="19" Caption="Total a Pagar" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" Width="80px">
        <PropertiesTextEdit DisplayFormatString="#,##0.00" />

<HeaderStyle Wrap="True"></HeaderStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="PORC_PROM_ASISTENCIA" VisibleIndex="20" Caption="Porc prom asistencia" />
        <dx:GridViewDataTextColumn FieldName="NOTA_PROMEDIO" VisibleIndex="21" Caption="Nota promedio" />
        <dx:GridViewDataTextColumn FieldName="ESTADO" VisibleIndex="22" Caption="Estado" />        
        <dx:GridViewDataTextColumn FieldName="USUARIO_APROBACION" VisibleIndex="23" Caption="Usuario aprobacion" />
        <dx:GridViewDataTextColumn FieldName="LASTUPDATE" VisibleIndex="24" Caption="Lastupdate" >
        <PropertiesTextEdit DisplayFormatString="dd/MM/yyy hh:mm tt" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="NOMBRE_USUARIO" VisibleIndex="25" Caption="Usuario" UnboundType="String" Visible="False" />
        <dx:GridViewDataTextColumn FieldName="USERID" VisibleIndex="26" Caption="Userid" />
        <dx:GridViewDataTextColumn FieldName="ID_ESTADO_INFORME" VisibleIndex="27" Caption="Id estado informe" />       
        <dx:GridViewDataTextColumn FieldName="COMENTARIOS" VisibleIndex="28" Caption="Comentarios" />        
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="29">
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

 </dx:PanelContent>
         </PanelCollection>
</dx:ASPxCallbackPanel>


<asp:ObjectDataSource ID="odsListaPorCriterios" runat="server" SelectMethod="ObtenerListaPorCriterios"
        TypeName="SGAFP.BL.cINFORME_FINAL_AF">
    <SelectParameters>
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />        
        <asp:Parameter Name="CODIGO_GRUPO" Type="String" />        
        <asp:Parameter Name="ID_EJERCICIO" Type="String" />                
        <asp:Parameter Name="listaID_ESTADO_INFORME" Type="Object" />               
        <asp:Parameter Name="listaID_PROGRAMA_FORMACION" Type="Object" />       
        <asp:Parameter Name="ID_CONTRATO" Type="Decimal" />       
        <asp:Parameter Name="NUM_LICITACION" Type="String" />       
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>      
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCriteriosRoles" runat="server" SelectMethod="ObtenerListaPorCriteriosRoles"
        TypeName="SGAFP.BL.cINFORME_FINAL_AF">
    <SelectParameters>
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />                     
        <asp:Parameter Name="CODIGO_GRUPO" Type="String" />   
        <asp:Parameter Name="ID_EJERCICIO" Type="String" />   
        <asp:Parameter Name="listaROLES" Type="Object" />               
        <asp:Parameter Name="listaID_ESTADO_INFORME" Type="Object" />               
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>      
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarINFORME_FINAL_AF" DeleteMethod="EliminarINFORME_FINAL_AF" UpdateMethod="ActualizarINFORME_FINAL_AF"
    TypeName="SGAFP.BL.cINFORME_FINAL_AF">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_INFORME_FINAL" Type="Decimal" />
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
        <asp:Parameter Name="ID_INFORME_FINAL" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorACCION_FORMATIVA" runat="server" 
    SelectMethod="ObtenerListaPorACCION_FORMATIVA" InsertMethod="AgregarINFORME_FINAL_AF" DeleteMethod="EliminarINFORME_FINAL_AF" UpdateMethod="ActualizarINFORME_FINAL_AF"
    TypeName="SGAFP.BL.cINFORME_FINAL_AF">
    <SelectParameters>
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_INFORME_FINAL" Type="Decimal" />
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
        <asp:Parameter Name="ID_INFORME_FINAL" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPROVEEDOR_AF" runat="server" 
    SelectMethod="ObtenerListaPorPROVEEDOR_AF" InsertMethod="AgregarINFORME_FINAL_AF" DeleteMethod="EliminarINFORME_FINAL_AF" UpdateMethod="ActualizarINFORME_FINAL_AF"
    TypeName="SGAFP.BL.cINFORME_FINAL_AF">
    <SelectParameters>
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_INFORME_FINAL" Type="Decimal" />
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
        <asp:Parameter Name="ID_INFORME_FINAL" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorESTADO_INFORME_AF" runat="server" 
    SelectMethod="ObtenerListaPorESTADO_INFORME_AF" InsertMethod="AgregarINFORME_FINAL_AF" DeleteMethod="EliminarINFORME_FINAL_AF" UpdateMethod="ActualizarINFORME_FINAL_AF"
    TypeName="SGAFP.BL.cINFORME_FINAL_AF">
    <SelectParameters>
        <asp:Parameter Name="ID_ESTADO_INFORME" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_INFORME_FINAL" Type="Decimal" />
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
        <asp:Parameter Name="ID_INFORME_FINAL" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorInformeFacturar" runat="server" SelectMethod="ObtenerListaPorInformeFacturar"
    TypeName="SGAFP.BL.cINFORME_FINAL_AF">
    <SelectParameters>        
        <asp:Parameter Name="ID_PROGRAMA_FORMACION" Type="Decimal" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaFacturarContratoItemBolpros" runat="server" SelectMethod="ObtenerListaFacturarContratoItemBolpros"
    TypeName="SGAFP.BL.cINFORME_FINAL_AF">
    <SelectParameters>        
        <asp:Parameter Name="ID_PROGRAMA_FORMACION" Type="Decimal" />
        <asp:Parameter Name="ID_CONTRATO" Type="Decimal" />
        <asp:Parameter Name="NUM_ITEM" Type="Decimal" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
