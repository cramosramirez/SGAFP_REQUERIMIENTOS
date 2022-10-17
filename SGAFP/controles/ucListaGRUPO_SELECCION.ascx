<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaGRUPO_SELECCION.ascx.vb" Inherits="controles_ucListaGRUPO_SELECCION" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" Width="100%"  KeyFieldName="ID_GRUPO_SELEC" CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx">
    <SettingsPager PageSize="15">
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />
       <Columns>
        <dx:GridViewCommandColumn Caption=" "  ShowSelectCheckbox="True" Name="CheckSeleccionar" Width="10px" Visible="false" VisibleIndex="0">                               
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" CellStyle-HorizontalAlign="Center" Name="colEditar" Visible="false">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_GRUPO_SELEC") %>'></asp:ImageButton>
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_GRUPO_SELEC") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" CellStyle-HorizontalAlign="Center" Caption="Generar informe de preselección" HeaderStyle-Wrap="True" CellStyle-Wrap="True" Width="20px" HeaderStyle-HorizontalAlign="Center"  Name="colGenerarInforme" Visible="false" >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnInformePreseleccion" runat="server" AlternateText="Generar informe de preselección" ToolTip="Generar informe de preselección" CommandName="GenerarInformePreseleccion" ImageUrl="~/imagenes/run.png"  CommandArgument='<%# Bind("ID_GRUPO_SELEC") %>'></asp:ImageButton>                
            </DataItemTemplate>

<HeaderStyle HorizontalAlign="Center" Wrap="True"></HeaderStyle>

<CellStyle HorizontalAlign="Center" Wrap="True"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" CellStyle-HorizontalAlign="Center" Caption="Ver informe de Preselección" HeaderStyle-Wrap="True" CellStyle-Wrap="True" Width="20px" HeaderStyle-HorizontalAlign="Center"  Name="colInformeAvance" Visible="false" >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnInformeAvance" runat="server" AlternateText="Ver primer informe de avance" ToolTip="Informe de avance" CommandName="InformeAvance" ImageUrl="~/imagenes/ButtonPrintPreview.png"  CommandArgument='<%# Bind("ID_GRUPO_SELEC") %>'></asp:ImageButton>                
            </DataItemTemplate>

<HeaderStyle HorizontalAlign="Center" Wrap="True"></HeaderStyle>

<CellStyle HorizontalAlign="Center" Wrap="True"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" CellStyle-HorizontalAlign="Center" Caption="Informe de inicio aspirantes" HeaderStyle-Wrap="True" CellStyle-Wrap="True" Width="20px" HeaderStyle-HorizontalAlign="Center"  Name="colAspirantesSeleccionados" Visible="false" >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnInformeSeleccionados" runat="server" AlternateText="Ver informe inicio aspirantes" ToolTip="Ver informe inicio aspirantes" CommandName="AspirantesSeleccionados" ImageUrl="~/imagenes/ButtonPrintPreview.png"  CommandArgument='<%# Bind("ID_GRUPO_SELEC") %>'></asp:ImageButton>                
            </DataItemTemplate>

<HeaderStyle HorizontalAlign="Center" Wrap="True"></HeaderStyle>

<CellStyle HorizontalAlign="Center" Wrap="True"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" CellStyle-HorizontalAlign="Center" Caption="Aspirantes reclutados en periodo extraordinario" HeaderStyle-Wrap="True" CellStyle-Wrap="True" Width="20px" HeaderStyle-HorizontalAlign="Center"  Name="colReclutamientoExtraordinario" Visible="false" >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnReclutamientoExtra" runat="server" AlternateText="Reclutamiento extraordinario" ToolTip="Reclutamiento extraordinario" CommandName="ReclutamientoExtraordinario" ImageUrl="~/imagenes/ButtonPrintPreview.png"  CommandArgument='<%# Bind("ID_GRUPO_SELEC") %>'></asp:ImageButton>                
            </DataItemTemplate>

<HeaderStyle HorizontalAlign="Center" Wrap="True"></HeaderStyle>

<CellStyle HorizontalAlign="Center" Wrap="True"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" Caption="..." Name="colRegistrarAspirante"  Width="110px" CellStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" Visible="false" >
            <DataItemTemplate>
                <asp:LinkButton ID="lbtnRegistrarAspirante" runat="server" CommandName="RegistrarAspirante" 
                    CommandArgument='<%# Bind("ID_ACCION_CONTRATADA")%>'>Registrar aspirante</asp:LinkButton>                                  
            </DataItemTemplate>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" Caption="..." Name="colCalendarizarGrupo"  Width="100px" CellStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" Visible="false" >
            <DataItemTemplate>
                <asp:LinkButton ID="lbtnCalendarizarGrupo" runat="server" CommandName="CalendarizarGrupo" 
                    CommandArgument='<%# Bind("ID_ACCION_CONTRATADA")%>'>Calendarizar grupo</asp:LinkButton>                                  
            </DataItemTemplate>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_GRUPO_SELEC" ReadOnly="True" VisibleIndex="2" Caption="Id grupo selec" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_ACCION_CONTRATADA" VisibleIndex="3" Caption="Id accion contratada" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" VisibleIndex="3" Caption="Proveedor" UnboundType="String" HeaderStyle-HorizontalAlign="Center" >
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
           </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="NO_CONTRATO_COMPRA" VisibleIndex="3" Caption="No. Oferta" UnboundType="String" Width="80px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" >
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
           </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="NUM_CONTRATO" VisibleIndex="3" Caption="Contrato" UnboundType="String" Width="80px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" >
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
           </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="NUM_ITEM" VisibleIndex="3" Caption="No. Item" Width="50px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" UnboundType="String" >
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
           </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CURSO" VisibleIndex="3" Caption="Carrera" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="FECHA_HABILITA" VisibleIndex="3" Caption="Fecha habilitación" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" /> 

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="NO_GRUPO" VisibleIndex="3" Caption="N° Grupo" Width="80px"  HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" >
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
           </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CODIGO" VisibleIndex="3" Caption="Codigo Grupo Principal" Width="100px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" >        
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
           </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="FECHA_INICIO" VisibleIndex="5" Caption="Fecha inicio" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" />

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="FECHA_FIN" VisibleIndex="6" Caption="Fecha finalización" Width="120px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" />

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>  
        <dx:GridViewDataTextColumn FieldName="LUGAR_EJECUCION" VisibleIndex="7" Caption="Lugar de ejecución" UnboundType="String" />
        <dx:GridViewDataTextColumn Caption="Departamento" FieldName="DEPARTAMENTO" UnboundType="String" VisibleIndex="7" /> 
        <dx:GridViewDataTextColumn Caption="Municipio" FieldName="MUNICIPIO" UnboundType="String" VisibleIndex="7" />       
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="9" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="10" Caption="Fecha crea" Visible="false" /> 
        <dx:GridViewDataTextColumn FieldName="HORAS_TOTALES" VisibleIndex="11" Caption="Horas Totales" UnboundType="Decimal" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" Visible="false" >
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
           </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="HORAS_CALENDARIZADAS" VisibleIndex="11" Caption="Horas Calendarizadas" UnboundType="String" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" Visible="false" >
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
           </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ULT_PERIODO" VisibleIndex="11" Caption="Ultimo periodo calendarizado" UnboundType="String" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" Visible="false" >
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
           </dx:GridViewDataTextColumn>
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

<asp:ObjectDataSource ID="odsCriterios" runat="server" SelectMethod="ObtenerListaPorCriterios" TypeName="SGAFP.BL.cGRUPO_SELECCION">
    <SelectParameters>
        <asp:Parameter DefaultValue="-2" Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter DefaultValue="-2" Name="ID_PROGRAMA_FORMACION" Type="Decimal" />
        <asp:Parameter DefaultValue="" Name="NUM_CONTRATO" Type="String" />
        <asp:Parameter DefaultValue="-1" Name="CON_INFORME_PRESELECCION" Type="Int32" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>


<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarGRUPO_SELECCION" DeleteMethod="EliminarGRUPO_SELECCION" UpdateMethod="ActualizarGRUPO_SELECCION"
    TypeName="SGAFP.BL.cGRUPO_SELECCION">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_CONTRATADA" Type="Decimal" />
        <asp:Parameter Name="FECHA_HABILITA" Type="DateTime" />
        <asp:Parameter Name="FECHA_INICIO" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN" Type="DateTime" />
        <asp:Parameter Name="NO_GRUPO" Type="Decimal" />
        <asp:Parameter Name="CODIGO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_CONTRATADA" Type="Decimal" />
        <asp:Parameter Name="FECHA_HABILITA" Type="DateTime" />
        <asp:Parameter Name="FECHA_INICIO" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN" Type="DateTime" />
        <asp:Parameter Name="NO_GRUPO" Type="Decimal" />
        <asp:Parameter Name="CODIGO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorACCION_CONTRATADA" runat="server" 
    SelectMethod="ObtenerListaPorACCION_CONTRATADA" InsertMethod="AgregarGRUPO_SELECCION" DeleteMethod="EliminarGRUPO_SELECCION" UpdateMethod="ActualizarGRUPO_SELECCION"
    TypeName="SGAFP.BL.cGRUPO_SELECCION">
    <SelectParameters>
        <asp:Parameter Name="ID_ACCION_CONTRATADA" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_CONTRATADA" Type="Decimal" />
        <asp:Parameter Name="FECHA_HABILITA" Type="DateTime" />
        <asp:Parameter Name="FECHA_INICIO" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN" Type="DateTime" />
        <asp:Parameter Name="NO_GRUPO" Type="Decimal" />
        <asp:Parameter Name="CODIGO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_CONTRATADA" Type="Decimal" />
        <asp:Parameter Name="FECHA_HABILITA" Type="DateTime" />
        <asp:Parameter Name="FECHA_INICIO" Type="DateTime" />
        <asp:Parameter Name="FECHA_FIN" Type="DateTime" />
        <asp:Parameter Name="NO_GRUPO" Type="Decimal" />
        <asp:Parameter Name="CODIGO" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREA" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
