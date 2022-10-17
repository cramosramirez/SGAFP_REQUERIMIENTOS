<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCALE_FECHA.ascx.vb" Inherits="controles_ucListaCALE_FECHA" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" KeyFieldName="ID_CALE" Width="100%" CssFilePath="~/App_Themes/Office2010Blue/{0}/styles.css" CssPostfix="Office2010Blue" >
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
        <dx:GridViewDataTextColumn VisibleIndex="1" CellStyle-HorizontalAlign="Center" Caption=" " Name="Edicion"  Width="50px"  >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_CALE") %>'></asp:ImageButton>
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_CALE") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_CALE" ReadOnly="True" VisibleIndex="2" Caption="Id cale" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA" VisibleIndex="3" Caption="Fecha" Width="100px" HeaderStyle-HorizontalAlign="Center" SortIndex="0" SortOrder="Ascending" CellStyle-HorizontalAlign="Center" >
            <PropertiesTextEdit DisplayFormatString="ddd dd/MM/yyyy" />
            <Settings AllowSort="True" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="HORARIO" VisibleIndex="4" Caption="Horario" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Left" >
            <Settings AllowSort="False" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="MINUTOS" VisibleIndex="5" Caption="Minutos" Visible="false" >        
            <Settings AllowSort="False" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="HORAS" VisibleIndex="5" Caption="Horas" Width="100px" UnboundType="String" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" >
            <Settings AllowSort="False" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn VisibleIndex="6" Name="Eliminar" Caption=" " Width="50px"  CellStyle-HorizontalAlign="Center" >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEliminar" runat="server" AlternateText="Eliminar" ToolTip="Eliminar" CommandName="Eliminar" ImageUrl="~/imagenes/eliminar.png"  CommandArgument='<%# Bind("ID_CALE")%>'></asp:ImageButton>                             
            </DataItemTemplate>
            <Settings AllowSort="False" />
        </dx:GridViewDataTextColumn>
	   </Columns>
    <Settings ShowFilterRow="True"  ShowHeaderFilterButton="True" />
    <SettingsBehavior EnableRowHotTrack="True" AllowFocusedRow="True"  />    
    <Images SpriteCssFilePath="~/App_Themes/Office2010Blue/{0}/sprite.css">
        <LoadingPanelOnStatusBar Url="~/App_Themes/Office2010Blue/GridView/Loading.gif">
        </LoadingPanelOnStatusBar>
        <LoadingPanel Url="~/App_Themes/Office2010Blue/GridView/Loading.gif">
        </LoadingPanel>
    </Images>
    <ImagesFilterControl>
        <LoadingPanel Url="~/App_Themes/Office2010Blue/GridView/Loading.gif">
        </LoadingPanel>
    </ImagesFilterControl>
    <Styles CssFilePath="~/App_Themes/Office2010Blue/{0}/styles.css" CssPostfix="Office2010Blue">
        <Header ImageSpacing="5px" SortingImageSpacing="5px">
        </Header>
        <LoadingPanel ImageSpacing="5px">
        </LoadingPanel>
    </Styles>
    <StylesPager>
        <PageNumber ForeColor="#3E4846">
        </PageNumber>
        <Summary ForeColor="#1E395B">
        </Summary>
    </StylesPager>
    <StylesEditors ButtonEditCellSpacing="0">
        <ProgressBar Height="21px">
        </ProgressBar>
    </StylesEditors>
</dx:ASPxGridView>

<asp:ObjectDataSource ID="odsCALE_FECHAcache" runat="server" TypeName="cCALE_FECHAcache"     
    SelectMethod="ObtenerLista" 
    UpdateMethod="Actualizar" DeleteMethod="Eliminar">       
     <SelectParameters>             
        <asp:Parameter Name="nombreSesion_ucListaCALE_FECHA" Type="String" />
     </SelectParameters>     
     <UpdateParameters>    
        <asp:Parameter Name="ID_CALE" Type="Int32" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="listaHorario" Type="Object" />       
        <asp:Parameter Name="MINUTOS" Type="Int32" />       
        <asp:Parameter Name="REFERENCIA" Type="String" />                   
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CALE" Type="Int32" />
        <asp:Parameter Name="REFERENCIA" Type="String" />  
    </DeleteParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarCALE_FECHA" DeleteMethod="EliminarCALE_FECHA" UpdateMethod="ActualizarCALE_FECHA"
    TypeName="SGAFP.BL.cCALE_FECHA">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_CALE" Type="Decimal" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="HORARIO" Type="String" />
        <asp:Parameter Name="MINUTOS" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CALE" Type="Decimal" />
        <asp:Parameter Name="FECHA" Type="DateTime" />
        <asp:Parameter Name="HORARIO" Type="String" />
        <asp:Parameter Name="MINUTOS" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_CALE" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
