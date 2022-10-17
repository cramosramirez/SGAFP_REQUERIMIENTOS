<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaACCION_FORMATIVA_HIST.ascx.vb" Inherits="controles_ucListaACCION_FORMATIVA_HIST" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>

<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" Width="100%"  DataSourceID="odsPorCriterioAccionFormativa" KeyFieldName="ID_ACCION_FORMATIVA_HIST" CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx">
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <Settings ShowFilterRow="False"  ShowHeaderFilterButton="False" />    
    <SettingsBehavior AllowSort="False" /> 
    <Columns>
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1">
            <DataItemTemplate>
                <asp:LinkButton ID="lbtnEditar" runat="server" CommandName="Editar" 
                    CommandArgument='<%# Bind("ID_ACCION_FORMATIVA_HIST") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_ACCION_FORMATIVA_HIST") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_ACCION_FORMATIVA_HIST" Caption="Id Hist." ReadOnly="True" VisibleIndex="2" />
        <dx:GridViewDataTextColumn FieldName="ID_ACCION_FORMATIVA" VisibleIndex="3" />
        <dx:GridViewDataTextColumn FieldName="ID_OFERTA_FORMATIVA" VisibleIndex="4" />
        <dx:GridViewDataTextColumn FieldName="ID_SITIO_CAPACITACION" VisibleIndex="5" />
        <dx:GridViewDataTextColumn FieldName="ID_PROVEEDOR_AF" VisibleIndex="6" />
        <dx:GridViewDataTextColumn FieldName="ID_TEMA_CURSO" VisibleIndex="7" />
        <dx:GridViewDataTextColumn FieldName="ID_EJERCICIO" VisibleIndex="8" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ACCION_FORMATIVA" Caption="Nombre curso" VisibleIndex="9" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_GRUPO" Caption="Codigo grupo" VisibleIndex="10" />
        <dx:GridViewDataTextColumn FieldName="NUMERO_PARTICIPANTES" VisibleIndex="11" />
        <dx:GridViewDataTextColumn FieldName="PARTICIPANTES_INSCRITOS" VisibleIndex="12" />
        <dx:GridViewDataTextColumn FieldName="HORARIO" Caption="Horario" VisibleIndex="13" HeaderStyle-Wrap="True" Width="120px"  >
<HeaderStyle Wrap="True"></HeaderStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="NOTAS" VisibleIndex="14" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_ESTADO_AF" VisibleIndex="15" />
        <dx:GridViewDataTextColumn FieldName="DURACION_HORAS" VisibleIndex="16" />
        <dx:GridViewDataTextColumn FieldName="COSTO_X_PARTICIPANTE" VisibleIndex="17" />
        <dx:GridViewDataTextColumn FieldName="FECHA_INICIO_REAL" Caption="Fecha Inicio" VisibleIndex="18">
            <PropertiesTextEdit DisplayFormatString="{0:d}"></PropertiesTextEdit>
        </dx:GridViewDataTextColumn>        
        <dx:GridViewDataTextColumn FieldName="FECHA_FIN_REAL" Caption="Fecha Fin" VisibleIndex="19">        
            <PropertiesTextEdit DisplayFormatString="{0:d}"></PropertiesTextEdit>
        </dx:GridViewDataTextColumn>               
        <dx:GridViewDataTextColumn Caption="Estado" FieldName="NOMBRE_ESTADO" UnboundType="String" VisibleIndex="19"  />           
        <dx:GridViewDataTextColumn FieldName="LASTUPDATE" Caption="Actualizacion" VisibleIndex="20"  HeaderStyle-Wrap="True" Width="130px" >        
<HeaderStyle Wrap="True"></HeaderStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="USERID" Caption="Actualizacion" VisibleIndex="21" Visible="false"    />         
        <dx:GridViewDataTextColumn Caption="Usuario" FieldName="USUARIO" UnboundType="String" VisibleIndex="22"  />           
        <dx:GridViewDataTextColumn FieldName="OBSERVACIONES" Caption="Observaciones" VisibleIndex="23" />     
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="24">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>    
	   <SettingsPager PageSize="5" />
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
<dx:ASPxHiddenField runat="server" ClientInstanceName="hfucListaACCION_FORMATIVA_HIST" ID="hfucListaACCION_FORMATIVA_HIST" />             
<asp:ObjectDataSource ID="odsPorCriterioAccionFormativa" runat="server" SelectMethod="ObtenerACCION_FORMATIVA_HIST_Por_ID_ACCION_FORMATIVA"
     TypeName="SGAFP.BL.cACCION_FORMATIVA_HIST">
    <SelectParameters>
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />      
        <asp:Parameter DefaultValue="ID_ACCION_FORMATIVA_HIST" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>     
</asp:ObjectDataSource>
