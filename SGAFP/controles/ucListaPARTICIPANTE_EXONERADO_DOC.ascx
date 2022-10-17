<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaPARTICIPANTE_EXONERADO_DOC.ascx.vb" Inherits="controles_ucListaPARTICIPANTE_EXONERADO_DOC" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register src="ucVistaDetallePARTICIPANTE_EXONERADO_DOC.ascx" tagname="ucVistaDetallePARTICIPANTE_EXONERADO_DOC" tagprefix="uc1" %>
<dx:ASPxLabel ID="lblMensajeGrid" runat="server" Visible="false"   
    Text="ALERTA!!! Existen uno o varios Participantes que coinciden con algunos datos del nuevo participante. Busque en la lista el participante que coincida con el que usted esta ingresando. Si el estado del participante esta APROBADO entonces proceda a inscribirlo en el curso buscandolo por sus nombres y apellidos, de lo contrario haga clic en la opción: Guardar" 
    Width="800px" Font-Size="XX-Small" Font-Bold="true" ForeColor="DarkBlue" />
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" Width="100%"  KeyFieldName="ID_PARTICIPANTE_EXONERADO" CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx">
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
                    CommandArgument='<%# Bind("ID_PARTICIPANTE_EXONERADO") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_PARTICIPANTE_EXONERADO") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_PARTICIPANTE_EXONERADO" VisibleIndex="1" Caption="Id participante exonerado" />
        <dx:GridViewDataTextColumn FieldName="ID_PARTICIPANTE"  VisibleIndex="2" Caption="Id participante" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_PROVEEDOR" VisibleIndex="3" Caption="Proveedor" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_SITIO" VisibleIndex="4" Caption="Centro Formación" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="USERID" VisibleIndex="5" Caption="Userid" />
        <dx:GridViewDataTextColumn FieldName="LASTUPDATE" VisibleIndex="6" Caption="Lastupdate" />
        <dx:GridViewDataTextColumn FieldName="ID_PROVEEDOR_AF" VisibleIndex="7" Caption="Id proveedor af" />
        <dx:GridViewDataTextColumn FieldName="ID_SITIO_CAPACITACION" VisibleIndex="8" Caption="Id sitio capacitacion" />
        <dx:GridViewDataTextColumn FieldName="NOMBRES" VisibleIndex="9" Caption="Nombres" />
        <dx:GridViewDataTextColumn FieldName="APELLIDOS" VisibleIndex="10" Caption="Apellidos" />
        <dx:GridViewDataTextColumn FieldName="FECHA_NACIMIENTO" VisibleIndex="11" Caption="Fecha nacimiento" >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyy" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="DEPARTAMENTO_RESIDENCIA" VisibleIndex="11" Caption="Departamento Residencia" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="MUNICIPIO_RESIDENCIA" VisibleIndex="11" Caption="Municipio Residencia" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="GENERO" VisibleIndex="12" Caption="Genero" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_DEPARTAMENTO" VisibleIndex="13" Caption="Codigo departamento" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_MUNICIPIO" VisibleIndex="14" Caption="Codigo municipio" />
        <dx:GridViewDataTextColumn FieldName="DEPARTAMENTO_NAC" VisibleIndex="15" Caption="Departamento nac" />
        <dx:GridViewDataTextColumn FieldName="MUNICIPIO_NAC" VisibleIndex="16" Caption="Municipio nac" />
        <dx:GridViewDataTextColumn FieldName="DIRECCION" VisibleIndex="17" Caption="Direccion" />
        <dx:GridViewDataTextColumn FieldName="TELEFONO" VisibleIndex="18" Caption="Telefono" />
        <dx:GridViewDataTextColumn FieldName="MOVIL" VisibleIndex="19" Caption="Movil" />
        <dx:GridViewDataTextColumn FieldName="CON_DISCAPACIDAD" VisibleIndex="20" Caption="Con discapacidad" />
        <dx:GridViewDataTextColumn FieldName="EMAIL" VisibleIndex="21" Caption="Email" />
        <dx:GridViewDataTextColumn FieldName="ID_NIVEL_ACADEMICO" VisibleIndex="22" Caption="Id nivel academico" />
        <dx:GridViewDataTextColumn FieldName="ID_PAIS" VisibleIndex="23" Caption="Id pais" />
        <dx:GridViewDataTextColumn FieldName="ID_ESTADO_CIVIL" VisibleIndex="24" Caption="Id estado civil" />
        <dx:GridViewDataTextColumn FieldName="FECHA_INGRESO" VisibleIndex="25" Caption="Fecha ingreso" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_EVALUA" VisibleIndex="26" Caption="Usuario evalua" />
        <dx:GridViewDataTextColumn FieldName="FECHA_EVALUA" VisibleIndex="27" Caption="Fecha evalua" />
        <dx:GridViewDataTextColumn FieldName="ESTADO" VisibleIndex="28" Caption="Estado" /> 
        <dx:GridViewDataTextColumn FieldName="ESTADO_DESCRIP" VisibleIndex="28" Caption="Estado" UnboundType="String" />       
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="29">
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
            <uc1:ucVistaDetallePARTICIPANTE_EXONERADO_DOC ID="ucVistaDetallePARTICIPANTE_EXONERADO_DOC1" runat="server" 
                ID_PARTICIPANTE_EXONERADO='<%# Bind("ID_PARTICIPANTE_EXONERADO") %>'
                ID_PARTICIPANTE='<%# Bind("ID_PARTICIPANTE") %>' USERID='<%# Bind("USERID") %>' LASTUPDATE='<%# Bind("LASTUPDATE") %>' ID_PROVEEDOR_AF='<%# Bind("ID_PROVEEDOR_AF") %>' ID_SITIO_CAPACITACION='<%# Bind("ID_SITIO_CAPACITACION") %>' NOMBRES='<%# Bind("NOMBRES") %>' APELLIDOS='<%# Bind("APELLIDOS") %>' FECHA_NACIMIENTO='<%# Bind("FECHA_NACIMIENTO") %>' GENERO='<%# Bind("GENERO") %>' CODIGO_DEPARTAMENTO='<%# Bind("CODIGO_DEPARTAMENTO") %>' CODIGO_MUNICIPIO='<%# Bind("CODIGO_MUNICIPIO") %>' DEPARTAMENTO_NAC='<%# Bind("DEPARTAMENTO_NAC") %>' MUNICIPIO_NAC='<%# Bind("MUNICIPIO_NAC") %>' DIRECCION='<%# Bind("DIRECCION") %>' TELEFONO='<%# Bind("TELEFONO") %>' MOVIL='<%# Bind("MOVIL") %>' CON_DISCAPACIDAD='<%# Bind("CON_DISCAPACIDAD") %>' EMAIL='<%# Bind("EMAIL") %>' ID_NIVEL_ACADEMICO='<%# Bind("ID_NIVEL_ACADEMICO") %>' ID_PAIS='<%# Bind("ID_PAIS") %>' ID_ESTADO_CIVIL='<%# Bind("ID_ESTADO_CIVIL") %>' FECHA_INGRESO='<%# Bind("FECHA_INGRESO") %>' USUARIO_EVALUA='<%# Bind("USUARIO_EVALUA") %>' FECHA_EVALUA='<%# Bind("FECHA_EVALUA") %>' ESTADO='<%# Bind("ESTADO") %>' />
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
<asp:ObjectDataSource ID="odsListaParticipantesSemejantes" runat="server" 
    SelectMethod="ObtenerListaParticipantesSemejantes" TypeName="SGAFP.BL.cPARTICIPANTE_EXONERADO_DOC">
    <SelectParameters>
        <asp:Parameter Name="mPARTICIPANTE_EXONERADO_DOC" Type="Object" />
        <asp:Parameter Name="duplicadoPorFonetico" type="Int32" />      
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaCriterios" runat="server" 
    SelectMethod="ObtenerListaPorCriterios" TypeName="SGAFP.BL.cPARTICIPANTE_EXONERADO_DOC">
    <SelectParameters>
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="ESTADO" Type="Decimal" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="Object" /> 
        <asp:Parameter Name="NOMBRES" Type="String" /> 
        <asp:Parameter Name="APELLIDOS" Type="String" /> 
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarPARTICIPANTE_EXONERADO_DOC" DeleteMethod="EliminarPARTICIPANTE_EXONERADO_DOC" UpdateMethod="ActualizarPARTICIPANTE_EXONERADO_DOC"
    TypeName="SGAFP.BL.cPARTICIPANTE_EXONERADO_DOC">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="FECHA_INGRESO" Type="DateTime" />
        <asp:Parameter Name="USUARIO_EVALUA" Type="String" />
        <asp:Parameter Name="FECHA_EVALUA" Type="DateTime" />
        <asp:Parameter Name="ESTADO" Type="Decimal" />
        <asp:Parameter DefaultValue="0" Name="ID_PARTICIPANTE_EXONERADO" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="FECHA_INGRESO" Type="DateTime" />
        <asp:Parameter Name="USUARIO_EVALUA" Type="String" />
        <asp:Parameter Name="FECHA_EVALUA" Type="DateTime" />
        <asp:Parameter Name="ESTADO" Type="Decimal" />
        <asp:Parameter Name="ID_PARTICIPANTE_EXONERADO" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPARTICIPANTE" runat="server" 
    SelectMethod="ObtenerListaPorPARTICIPANTE" InsertMethod="AgregarPARTICIPANTE_EXONERADO_DOC" DeleteMethod="EliminarPARTICIPANTE_EXONERADO_DOC" UpdateMethod="ActualizarPARTICIPANTE_EXONERADO_DOC"
    TypeName="SGAFP.BL.cPARTICIPANTE_EXONERADO_DOC">
    <SelectParameters>
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="FECHA_INGRESO" Type="DateTime" />
        <asp:Parameter Name="USUARIO_EVALUA" Type="String" />
        <asp:Parameter Name="FECHA_EVALUA" Type="DateTime" />
        <asp:Parameter Name="ESTADO" Type="Decimal" />
        <asp:Parameter DefaultValue="0" Name="ID_PARTICIPANTE_EXONERADO" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="FECHA_INGRESO" Type="DateTime" />
        <asp:Parameter Name="USUARIO_EVALUA" Type="String" />
        <asp:Parameter Name="FECHA_EVALUA" Type="DateTime" />
        <asp:Parameter Name="ESTADO" Type="Decimal" />
        <asp:Parameter Name="ID_PARTICIPANTE_EXONERADO" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPROVEEDOR_AF" runat="server" 
    SelectMethod="ObtenerListaPorPROVEEDOR_AF" InsertMethod="AgregarPARTICIPANTE_EXONERADO_DOC" DeleteMethod="EliminarPARTICIPANTE_EXONERADO_DOC" UpdateMethod="ActualizarPARTICIPANTE_EXONERADO_DOC"
    TypeName="SGAFP.BL.cPARTICIPANTE_EXONERADO_DOC">
    <SelectParameters>
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="FECHA_INGRESO" Type="DateTime" />
        <asp:Parameter Name="USUARIO_EVALUA" Type="String" />
        <asp:Parameter Name="FECHA_EVALUA" Type="DateTime" />
        <asp:Parameter Name="ESTADO" Type="Decimal" />
        <asp:Parameter DefaultValue="0" Name="ID_PARTICIPANTE_EXONERADO" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="FECHA_INGRESO" Type="DateTime" />
        <asp:Parameter Name="USUARIO_EVALUA" Type="String" />
        <asp:Parameter Name="FECHA_EVALUA" Type="DateTime" />
        <asp:Parameter Name="ESTADO" Type="Decimal" />
        <asp:Parameter Name="ID_PARTICIPANTE_EXONERADO" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorSITIO_CAPACITACION" runat="server" 
    SelectMethod="ObtenerListaPorSITIO_CAPACITACION" InsertMethod="AgregarPARTICIPANTE_EXONERADO_DOC" DeleteMethod="EliminarPARTICIPANTE_EXONERADO_DOC" UpdateMethod="ActualizarPARTICIPANTE_EXONERADO_DOC"
    TypeName="SGAFP.BL.cPARTICIPANTE_EXONERADO_DOC">
    <SelectParameters>
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="FECHA_INGRESO" Type="DateTime" />
        <asp:Parameter Name="USUARIO_EVALUA" Type="String" />
        <asp:Parameter Name="FECHA_EVALUA" Type="DateTime" />
        <asp:Parameter Name="ESTADO" Type="Decimal" />
        <asp:Parameter DefaultValue="0" Name="ID_PARTICIPANTE_EXONERADO" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="FECHA_INGRESO" Type="DateTime" />
        <asp:Parameter Name="USUARIO_EVALUA" Type="String" />
        <asp:Parameter Name="FECHA_EVALUA" Type="DateTime" />
        <asp:Parameter Name="ESTADO" Type="Decimal" />
        <asp:Parameter Name="ID_PARTICIPANTE_EXONERADO" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
