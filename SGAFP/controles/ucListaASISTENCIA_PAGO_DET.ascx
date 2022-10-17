<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaASISTENCIA_PAGO_DET.ascx.vb" Inherits="controles_ucListaASISTENCIA_PAGO_DET" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>


<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_ASISTE_PAGO_DET" Width="100%" CssFilePath="~/App_Themes/Office2010Blue/{0}/styles.css" CssPostfix="Office2010Blue" >
    <SettingsPager PageSize="15">
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" />    
    <Columns>       
         <dx:GridViewCommandColumn Name="Edicion" EditButton-Visible="true" ButtonType="Image" VisibleIndex="1" Visible="False" CellStyle-HorizontalAlign="Center" Width="30px" Caption=" "  >
                <NewButton Image-ToolTip="Agregar" Image-Url="../imagenes/ButtonNew.png">
                    <Image ToolTip="Agregar" ></Image>
                </NewButton>      
                <EditButton Image-ToolTip="Editar" Image-Url="../imagenes/ButtonEdit.png" >
                    <Image ToolTip="Editar"></Image>
                </EditButton>            
                <UpdateButton Image-ToolTip="Guardar" Image-Url="../imagenes/ButtonSave.png"  >
                    <Image ToolTip="Guardar"></Image>
                </UpdateButton>                     
                <CancelButton Image-ToolTip="Cancelar" Image-Url="../imagenes/Undo-icon.png"  >
                <Image ToolTip="Cancelar"></Image>
                </CancelButton>                 
                <CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewCommandColumn>       
        <dx:GridViewDataTextColumn FieldName="ID_ASISTE_PAGO_DET" ReadOnly="True" VisibleIndex="2" Caption="Id contra asiste" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_ASISTE_PAGO" VisibleIndex="3" Caption="Id contrato compra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_MODALIDAD_FORMACION" VisibleIndex="4" Caption="Id tipo modalidad" Visible="false"     />
        <dx:GridViewDataTextColumn FieldName="MODALIDAD_FORMACION" VisibleIndex="4" CellStyle-HorizontalAlign="Left" Width="300px"  SortIndex="0" SortOrder="Ascending" Caption="Modalidad" ReadOnly="true" UnboundType="String" />
        <dx:GridViewDataSpinEditColumn FieldName="PORC_ASISTE_INI" VisibleIndex="5" Caption="Asistencia inicial (%)" SortIndex="1" SortOrder="Ascending" Width="80px"  HeaderStyle-Wrap ="True" >
            <PropertiesSpinEdit NumberType="Float" DisplayFormatString="#,##0.00"  >
                <Style BackColor="Yellow" HorizontalAlign="Right"></Style>                                
            </PropertiesSpinEdit>            
            <Settings AllowSort="False" /> 
        </dx:GridViewDataSpinEditColumn>
        <dx:GridViewDataSpinEditColumn FieldName="PORC_ASISTE_FIN" VisibleIndex="6"  Caption="Asistencia final (%)" Width="80px" HeaderStyle-Wrap ="True" >
            <PropertiesSpinEdit NumberType="Float" DisplayFormatString="#,##0.00">
                <Style BackColor="Yellow" HorizontalAlign="Right"></Style>
            </PropertiesSpinEdit>
            <Settings AllowSort="False" /> 
        </dx:GridViewDataSpinEditColumn>
        <dx:GridViewDataSpinEditColumn FieldName="PORC_PAGO_COSTO_PARTI" VisibleIndex="7" Caption="% a Pagar" >
            <PropertiesSpinEdit DisplayFormatString="#,##0.00" >
                <Style BackColor="Yellow" HorizontalAlign="Right"></Style>
            </PropertiesSpinEdit>
            <Settings AllowSort="False" /> 
        </dx:GridViewDataSpinEditColumn>
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="8" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREA" VisibleIndex="9" Caption="Fecha crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="10" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="11" Caption="Fecha act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="REFERENCIA" VisibleIndex="11" Caption="Referencia" Visible="false" />
        <dx:GridViewCommandColumn AllowDragDrop="False" ButtonType="Image"  Caption=" "  Name="Eliminar" VisibleIndex="12">             
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Image-Url="../imagenes/Close-2-icon.png" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>          
        </dx:GridViewCommandColumn>
	   </Columns>
    <Settings ShowFilterRow="False"  ShowHeaderFilterButton="False" />
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


<asp:ObjectDataSource ID="odsASISTENCIA_PAGO_DETcache" runat="server" TypeName="cASISTENCIA_PAGO_DETcache"     
    SelectMethod="ObtenerLista" UpdateMethod="Actualizar" >       
     <SelectParameters>             
        <asp:Parameter Name="nombreSesion_ucListaASISTENCIA_PAGO_DET" Type="String" />
     </SelectParameters>     
     <UpdateParameters>    
        <asp:Parameter Name="ID_ASISTE_PAGO_DET" Type="Decimal" />
        <asp:Parameter Name="ID_ASISTE_PAGO" Type="Decimal" />
        <asp:Parameter Name="ID_MODALIDAD_FORMACION" Type="Decimal" />
        <asp:Parameter Name="PORC_ASISTE_INI" Type="Decimal" />
        <asp:Parameter Name="PORC_ASISTE_FIN" Type="Decimal" />
        <asp:Parameter Name="PORC_PAGO_COSTO_PARTI" Type="Decimal" />        
        <asp:Parameter Name="REFERENCIA" Type="String" />                   
    </UpdateParameters>    
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLista" runat="server" SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cASISTENCIA_PAGO">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>    
</asp:ObjectDataSource>

