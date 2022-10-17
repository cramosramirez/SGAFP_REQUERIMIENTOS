<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaACCION_FORMATIVA_REPROG.ascx.vb" Inherits="controles_ucListaACCION_FORMATIVA_REPROG" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxMenu" tagprefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" Width="100%" AutoGenerateColumns="False" KeyFieldName="ID_ACCION_FORMATIVA_REPROG" ClientInstanceName="dxgvListaAF_REPROG" CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx"> 
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <Columns>
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1">
            <DataItemTemplate>
                <asp:LinkButton ID="lbtnEvaluar" runat="server" CommandName="Evaluar" 
                    CommandArgument='<%# Bind("ID_ACCION_FORMATIVA_REPROG") %>'>Evaluar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_ACCION_FORMATIVA_REPROG") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_ACCION_FORMATIVA_REPROG" ReadOnly="True" VisibleIndex="2" Caption="Id Repro." />
        <dx:GridViewDataTextColumn FieldName="ID_ESTADO_REPROG" VisibleIndex="3" />
        <dx:GridViewDataTextColumn FieldName="ID_ACCION_FORMATIVA" VisibleIndex="4" Caption="Id Curso" />
        <dx:GridViewDataTextColumn FieldName="ID_OFERTA_FORMATIVA" VisibleIndex="5" />
        <dx:GridViewDataTextColumn FieldName="ID_SITIO_CAPACITACION" VisibleIndex="6" />
        <dx:GridViewDataTextColumn FieldName="ID_PROVEEDOR_AF" VisibleIndex="7" />
        <dx:GridViewDataTextColumn FieldName="ID_TEMA_CURSO" VisibleIndex="8" />
        <dx:GridViewDataTextColumn FieldName="ID_EJERCICIO" VisibleIndex="9" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_ACCION_FORMATIVA" VisibleIndex="10" Caption="Nombre Curso" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_GRUPO" VisibleIndex="11" Caption="Codigo Grupo" />
        <dx:GridViewDataTextColumn FieldName="NUMERO_PARTICIPANTES" VisibleIndex="12" Caption="Cupo" />
        <dx:GridViewDataTextColumn FieldName="PARTICIPANTES_INSCRITOS" VisibleIndex="13" Caption="Participantes Inscritos" />
        <dx:GridViewDataTextColumn FieldName="FECHA_INICIO_REAL" VisibleIndex="14" Caption="Fecha Inicio">
            <PropertiesTextEdit DisplayFormatString="{0:d}"></PropertiesTextEdit>
        </dx:GridViewDataTextColumn> 
        <dx:GridViewDataTextColumn FieldName="FECHA_FIN_REAL" VisibleIndex="15" Caption="Fecha Fin">
            <PropertiesTextEdit DisplayFormatString="{0:d}"></PropertiesTextEdit>
        </dx:GridViewDataTextColumn>            
        <dx:GridViewDataTextColumn FieldName="HORARIO" VisibleIndex="15" Caption="Horario" />
        <dx:GridViewDataTextColumn FieldName="NOTAS" VisibleIndex="17" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_ESTADO_AF" VisibleIndex="18" />
        <dx:GridViewDataTextColumn FieldName="DURACION_HORAS" VisibleIndex="19" Caption="Duracion" />
        <dx:GridViewDataTextColumn FieldName="COSTO_X_PARTICIPANTE" VisibleIndex="20" />
        <dx:GridViewDataTextColumn FieldName="LASTUPDATE" VisibleIndex="21" />
        <dx:GridViewDataTextColumn FieldName="USERID" VisibleIndex="22" />        
        <dx:GridViewDataTextColumn FieldName="MOTIVOREPROG" VisibleIndex="23" />    
        <dx:GridViewDataTextColumn FieldName="MOTIVORECHAZO" VisibleIndex="24" />    
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="23">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>        
        
	   </Columns>
    <Settings ShowFilterRow="True" ShowGroupButtons="False" />
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




<asp:ObjectDataSource ID="odsLista" runat="server" SelectMethod="ObtenerLista" 
    TypeName="SGAFP.BL.cACCION_FORMATIVA_REPROG">
    <SelectParameters>      
        <asp:Parameter Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter Name="asColumnaOrden" Type="String" />
        <asp:Parameter Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorAccionFormativaReprogEstado" runat="server" SelectMethod="ObtenerACCION_FORMATIVA_REPROG_POR_ESTADO"
     TypeName="SGAFP.BL.cACCION_FORMATIVA_REPROG">
    <SelectParameters>        
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />       
        <asp:Parameter Name="ID_ESTADO_REPROG" Type="Int32" />              
    </SelectParameters>     
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsPorCriteriosPeriodoEstado" runat="server" SelectMethod="ObtenerListaPorCriteriosPeriodoEstado"
     TypeName="SGAFP.BL.cACCION_FORMATIVA_REPROG">
    <SelectParameters>
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_FORMACION" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_ACCION_FORMATIVA" Type="String" />
        <asp:Parameter Name="CODIGO_GRUPO" Type="String" />
        <asp:Parameter Name="ID_ESTADO_REPROG" Type="Decimal" />
        <asp:Parameter Name="ID_EJERCICIO" Type="String" />
        <asp:Parameter Name="TDR" Type="String" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>     
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorESTADO_ACCION_FORMATIVA" runat="server" 
    OldValuesParameterFormatString="original_{0}" 
    SelectMethod="ObtenerListaPorESTADO_ACCION_FORMATIVA" 
    TypeName="SGAFP.BL.cACCION_FORMATIVA_REPROG">
    <SelectParameters>
        <asp:Parameter Name="CODIGO_ESTADO_AF" Type="String" />
        <asp:Parameter Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter Name="asColumnaOrden" Type="String" />
        <asp:Parameter Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsListaPorESTADO_REPROG" runat="server" 
    OldValuesParameterFormatString="original_{0}" 
    SelectMethod="ObtenerListaPorESTADO_REPROG" 
    TypeName="SGAFP.BL.cACCION_FORMATIVA_REPROG">
    <SelectParameters>
        <asp:Parameter Name="ID_ESTADO_REPROG" Type="Decimal" />
        <asp:Parameter Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter Name="asColumnaOrden" Type="String" />
        <asp:Parameter Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsListaPorOFERTA_FORMATIVA" runat="server" 
    OldValuesParameterFormatString="original_{0}" 
    SelectMethod="ObtenerListaPorOFERTA_FORMATIVA" 
    TypeName="SGAFP.BL.cACCION_FORMATIVA_REPROG">
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
    TypeName="SGAFP.BL.cACCION_FORMATIVA_REPROG">
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
    TypeName="SGAFP.BL.cACCION_FORMATIVA_REPROG">
    <SelectParameters>
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter Name="asColumnaOrden" Type="String" />
        <asp:Parameter Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsPorCriteriosRoles" runat="server" SelectMethod="ObtenerListaPorCriteriosRoles"
     TypeName="SGAFP.BL.cACCION_FORMATIVA_REPROG">
    <SelectParameters>
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_FORMACION" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_ACCION_FORMATIVA" Type="String" />
        <asp:Parameter Name="CODIGO_GRUPO" Type="String" />        
        <asp:Parameter Name="ID_EJERCICIO" Type="String" />
        <asp:Parameter Name="listaROLES" Type="String" />
        <asp:Parameter Name="ID_ESTADO_REPROG" Type="Decimal" />
        <asp:Parameter Name="TDR" Type="String" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>     
</asp:ObjectDataSource>