<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaACCION_CONTRATADA.ascx.vb" Inherits="controles_ucListaACCION_CONTRATADA" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" KeyFieldName="ID_ACCION_CONTRATADA" Width="100%" CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx" >
    <SettingsPager PageSize="10">
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />   
    <Columns>
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" CellStyle-HorizontalAlign="Center" Visible="false">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_ACCION_CONTRATADA") %>'></asp:ImageButton>
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_ACCION_CONTRATADA") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" Caption="..." Width="90px" CellStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" >
            <DataItemTemplate>
                <asp:LinkButton ID="lbtnHabilitarGrupo" runat="server" CommandName="HabilitarGrupo" 
                    CommandArgument='<%# Bind("ID_ACCION_CONTRATADA")%>'>Habilitar Grupo</asp:LinkButton>                                  
            </DataItemTemplate>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_ACCION_CONTRATADA" ReadOnly="True" VisibleIndex="2" Caption="Id accion contratada" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_CONTRATO" VisibleIndex="3" Caption="Id contrato" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" VisibleIndex="4" Caption="Proveedor" UnboundType="String" HeaderStyle-HorizontalAlign="Center" >
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="NO_CONTRATO_COMPRA" VisibleIndex="4" Caption="No. Oferta" UnboundType="String" Width="80px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" >
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="NUM_CONTRATO" VisibleIndex="4" Caption="Contrato" UnboundType="String" Width="80px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" >
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="NUM_ITEM" VisibleIndex="4" Caption="No. Item" Width="50px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" >
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CURSO" VisibleIndex="4" Caption="Carrera" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="PERIODO_EJECUCION" VisibleIndex="4" Caption="Período de ejecución" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="DURACION" VisibleIndex="7" Caption="Duracion (horas)" Width="50px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" >
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="DEPARTAMENTO" VisibleIndex="4" Caption="Departamento" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="MUNICIPIO" VisibleIndex="4" Caption="Municipio" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_DEPARTAMENTO" VisibleIndex="4" Caption="Codigo departamento" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_MUNICIPIO" VisibleIndex="5" Caption="Codigo municipio" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_PROGRAMA" VisibleIndex="6" Caption="Codigo programa" Visible="false" />        
        <dx:GridViewDataTextColumn FieldName="CANT_CURSOS" VisibleIndex="8" Caption="Grupos contratados" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" Width="80px"  CellStyle-Wrap="True" HeaderStyle-Wrap="True" >
<HeaderStyle HorizontalAlign="Center" Wrap="True"></HeaderStyle>

<CellStyle HorizontalAlign="Center" Wrap="True"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CANT_GRUPOS_GENERADOS" VisibleIndex="8" Caption="Grupos habilitados" Width="80px" CellStyle-Wrap="True" HeaderStyle-Wrap="True"  UnboundType="Integer" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" >
<HeaderStyle HorizontalAlign="Center" Wrap="True"></HeaderStyle>

<CellStyle HorizontalAlign="Center" Wrap="True"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREACION" VisibleIndex="9" Caption="Usuario creacion" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREACION" VisibleIndex="10" Caption="Fecha creacion" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USERID" VisibleIndex="11" Caption="Userid" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="LASTUPDATE" VisibleIndex="12" Caption="Lastupdate" Visible="false" />        
        <dx:GridViewDataTextColumn FieldName="COSTO_PARTICIPANTE" VisibleIndex="14" Caption="Costo por Aspirante" >            
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="COSTO_HORA" VisibleIndex="14" Caption="Costo Hora" >            
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="COSTO_VISITA" VisibleIndex="14" Caption="Costo Visita" >            
        </dx:GridViewDataTextColumn>        
        <dx:GridViewDataTextColumn FieldName="MONTO" VisibleIndex="14" Caption="Monto (USD)" >
            <PropertiesTextEdit DisplayFormatString="#,##0.00" /> 
        </dx:GridViewDataTextColumn>        
        <dx:GridViewDataTextColumn FieldName="NO_CONVOCATORIA" VisibleIndex="15" Caption="No convocatoria" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="COSTO_PARTICIPANTE" VisibleIndex="16" Caption="Costo participante" Visible="false" />        
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

<asp:ObjectDataSource ID="odsCriterios" runat="server" SelectMethod="ObtenerListaPorCriterios" TypeName="SGAFP.BL.cACCION_CONTRATADA">
    <SelectParameters>
        <asp:Parameter DefaultValue="-2" Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter DefaultValue="-2" Name="ID_PROGRAMA_FORMACION" Type="Decimal" />
        <asp:Parameter DefaultValue="" Name="NUM_CONTRATO" Type="String" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarACCION_CONTRATADA" DeleteMethod="EliminarACCION_CONTRATADA" UpdateMethod="ActualizarACCION_CONTRATADA"
    TypeName="SGAFP.BL.cACCION_CONTRATADA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ACCION_CONTRATADA" Type="Decimal" />
        <asp:Parameter Name="ID_CONTRATO" Type="Decimal" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_PROGRAMA" Type="String" />
        <asp:Parameter Name="DURACION" Type="Decimal" />
        <asp:Parameter Name="CANT_CURSOS" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="NUM_ITEM" Type="Decimal" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="NO_CONVOCATORIA" Type="Decimal" />
        <asp:Parameter Name="COSTO_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_ACCION_FORMATIVA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ACCION_CONTRATADA" Type="Decimal" />
        <asp:Parameter Name="ID_CONTRATO" Type="Decimal" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_PROGRAMA" Type="String" />
        <asp:Parameter Name="DURACION" Type="Decimal" />
        <asp:Parameter Name="CANT_CURSOS" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="NUM_ITEM" Type="Decimal" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="NO_CONVOCATORIA" Type="Decimal" />
        <asp:Parameter Name="COSTO_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_ACCION_FORMATIVA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ACCION_CONTRATADA" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorCONTRATO_BOLPROS" runat="server" 
    SelectMethod="ObtenerListaPorCONTRATO_BOLPROS" InsertMethod="AgregarACCION_CONTRATADA" DeleteMethod="EliminarACCION_CONTRATADA" UpdateMethod="ActualizarACCION_CONTRATADA"
    TypeName="SGAFP.BL.cACCION_CONTRATADA">
    <SelectParameters>
        <asp:Parameter Name="ID_CONTRATO" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ACCION_CONTRATADA" Type="Decimal" />
        <asp:Parameter Name="ID_CONTRATO" Type="Decimal" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_PROGRAMA" Type="String" />
        <asp:Parameter Name="DURACION" Type="Decimal" />
        <asp:Parameter Name="CANT_CURSOS" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="NUM_ITEM" Type="Decimal" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="NO_CONVOCATORIA" Type="Decimal" />
        <asp:Parameter Name="COSTO_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_ACCION_FORMATIVA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ACCION_CONTRATADA" Type="Decimal" />
        <asp:Parameter Name="ID_CONTRATO" Type="Decimal" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_PROGRAMA" Type="String" />
        <asp:Parameter Name="DURACION" Type="Decimal" />
        <asp:Parameter Name="CANT_CURSOS" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="NUM_ITEM" Type="Decimal" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="NO_CONVOCATORIA" Type="Decimal" />
        <asp:Parameter Name="COSTO_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_ACCION_FORMATIVA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ACCION_CONTRATADA" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorDEPARTAMENTO" runat="server" 
    SelectMethod="ObtenerListaPorDEPARTAMENTO" InsertMethod="AgregarACCION_CONTRATADA" DeleteMethod="EliminarACCION_CONTRATADA" UpdateMethod="ActualizarACCION_CONTRATADA"
    TypeName="SGAFP.BL.cACCION_CONTRATADA">
    <SelectParameters>
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ACCION_CONTRATADA" Type="Decimal" />
        <asp:Parameter Name="ID_CONTRATO" Type="Decimal" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_PROGRAMA" Type="String" />
        <asp:Parameter Name="DURACION" Type="Decimal" />
        <asp:Parameter Name="CANT_CURSOS" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="NUM_ITEM" Type="Decimal" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="NO_CONVOCATORIA" Type="Decimal" />
        <asp:Parameter Name="COSTO_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_ACCION_FORMATIVA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ACCION_CONTRATADA" Type="Decimal" />
        <asp:Parameter Name="ID_CONTRATO" Type="Decimal" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_PROGRAMA" Type="String" />
        <asp:Parameter Name="DURACION" Type="Decimal" />
        <asp:Parameter Name="CANT_CURSOS" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="NUM_ITEM" Type="Decimal" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="NO_CONVOCATORIA" Type="Decimal" />
        <asp:Parameter Name="COSTO_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_ACCION_FORMATIVA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ACCION_CONTRATADA" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorMUNICIPIO" runat="server" 
    SelectMethod="ObtenerListaPorMUNICIPIO" InsertMethod="AgregarACCION_CONTRATADA" DeleteMethod="EliminarACCION_CONTRATADA" UpdateMethod="ActualizarACCION_CONTRATADA"
    TypeName="SGAFP.BL.cACCION_CONTRATADA">
    <SelectParameters>
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_ACCION_CONTRATADA" Type="Decimal" />
        <asp:Parameter Name="ID_CONTRATO" Type="Decimal" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_PROGRAMA" Type="String" />
        <asp:Parameter Name="DURACION" Type="Decimal" />
        <asp:Parameter Name="CANT_CURSOS" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="NUM_ITEM" Type="Decimal" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="NO_CONVOCATORIA" Type="Decimal" />
        <asp:Parameter Name="COSTO_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_ACCION_FORMATIVA" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_ACCION_CONTRATADA" Type="Decimal" />
        <asp:Parameter Name="ID_CONTRATO" Type="Decimal" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="CODIGO_PROGRAMA" Type="String" />
        <asp:Parameter Name="DURACION" Type="Decimal" />
        <asp:Parameter Name="CANT_CURSOS" Type="Decimal" />
        <asp:Parameter Name="USUARIO_CREACION" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="NUM_ITEM" Type="Decimal" />
        <asp:Parameter Name="MONTO" Type="Decimal" />
        <asp:Parameter Name="NO_CONVOCATORIA" Type="Decimal" />
        <asp:Parameter Name="COSTO_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_ACCION_FORMATIVA" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_ACCION_CONTRATADA" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
