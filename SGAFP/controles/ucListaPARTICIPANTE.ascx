<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaPARTICIPANTE.ascx.vb" EnableViewState="false" Inherits="controles_ucListaPARTICIPANTE" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>


<dx:ASPxCallbackPanel runat="server" ID="cbpucListaPARTICIPANTE" ClientInstanceName="cbpucListaPARTICIPANTE">        
<ClientSideEvents EndCallback="function(s,e){
                                    if(popupParticipantes!=undefined){
                                        popupParticipantes.SetSize(400, 0);
                                        popupParticipantes.Show();                                        
                                        popupParticipantes.UpdatePosition();
                                    }
                               }" /> 
        <PanelCollection>
            <dx:PanelContent runat="server"> 

<dx:ASPxLabel ID="lblMensajeGrid" runat="server" Visible="false"   
    Text="ALERTA!!! Existen uno o varios Participantes que coinciden con algunos datos del nuevo participante. Busque en la lista el participante que coincida con los datos que esta ingresando. Si lo encuentra inscribalo por medio del DUI o el NIT, de lo contrario haga clic en la opción: Guardar" 
    Width="800px" Font-Size="XX-Small" Font-Bold="true" ForeColor="DarkBlue" />
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" KeyFieldName="ID_PARTICIPANTE" Width="100%" ClientInstanceName="dxgvListaPARTICIPANTE" CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx" >
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {                    
                    var combo = eval(s.cpNombreComboCliente);
                    combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);
                    combo.SetText(s.cpKeyNames[e.visibleIndex]);
                    combo.HideDropDown();}" 
                    
                    RowDblClick="function(s,e){                        
                        CargarParticipante(s,e);
                    }" 
                    CustomButtonClick="function(s,e){                        
                        if(e.buttonID == 'btnCursosRecibidos') {                                
                            window.open('../Reportes/wfReporteCursosRecibidosParticipante.aspx?IDPA=' + s.GetRowKey(e.visibleIndex));
                        }
                    }"
                    />
    <Columns>
        <dx:GridViewCommandColumn Name="Edicion" Visible="False" VisibleIndex="0" ButtonType="Image" Caption=" ">          
            <CustomButtons>  
                <dx:GridViewCommandColumnCustomButton ID="btnCursosRecibidos" Text="Cursos Recibidos" Visibility="Invisible" Image-Url="../imagenes/libros.png" >                                                                                                  
<Image Url="../imagenes/libros.png"></Image>
                </dx:GridViewCommandColumnCustomButton>
           </CustomButtons>
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
            <DataItemTemplate>     
            <asp:LinkButton ID="lbtnSeleccionar" runat="server" CommandName="Seleccionar"  
                    CommandArgument='<%# Bind("ID_PARTICIPANTE")%>'>Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" Name="Seleccion_Edicion" Visible="false" CellStyle-HorizontalAlign="Center" Width="20px"  >
            <DataItemTemplate>                
                 <asp:LinkButton ID="lbtnEditar" runat="server" CommandName="Editar"  
                    CommandArgument='<%# Bind("ID_PARTICIPANTE")%>'>Editar</asp:LinkButton>
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_PARTICIPANTE") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_PARTICIPANTE" ReadOnly="True" VisibleIndex="2" Caption="Id participante" Width="100px" />
        <dx:GridViewDataTextColumn FieldName="NOMBRES" VisibleIndex="3" Caption="Nombres" />
        <dx:GridViewDataTextColumn FieldName="APELLIDOS" VisibleIndex="4" Caption="Apellidos" />
        <dx:GridViewDataTextColumn FieldName="GENERO" VisibleIndex="5" Caption="Genero" />
        <dx:GridViewDataTextColumn FieldName="ID_PAIS" VisibleIndex="6" Caption="Id pais" />
        <dx:GridViewDataTextColumn FieldName="FECHA_NACIMIENTO" VisibleIndex="7" Caption="F. Nacimiento" >
            <PropertiesTextEdit DisplayFormatString="{0:d}">
            </PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="DIRECCION" VisibleIndex="8" Caption="Direccion" />
        <dx:GridViewDataTextColumn FieldName="DUI" VisibleIndex="9" Caption="Dui" />
        <dx:GridViewDataTextColumn FieldName="NIT" VisibleIndex="10" Caption="Nit" />                
        <dx:GridViewDataTextColumn FieldName="ISSS" VisibleIndex="11" Caption="Isss" />
        <dx:GridViewDataTextColumn FieldName="TIPO_DOCTO" VisibleIndex="12" Caption="Tipo docto" />
        <dx:GridViewDataTextColumn FieldName="NUM_DOCTO" VisibleIndex="13" Caption="Num docto" />
        <dx:GridViewDataTextColumn FieldName="TELEFONO" VisibleIndex="14" Caption="Telefono" />
        <dx:GridViewDataTextColumn FieldName="MOVIL" VisibleIndex="15" Caption="Movil" />
        <dx:GridViewDataTextColumn FieldName="EMAIL" VisibleIndex="16" Caption="Email" />
        <dx:GridViewDataTextColumn FieldName="ID_ESTADO_CIVIL" VisibleIndex="17" Caption="Id estado civil" />
        <dx:GridViewDataTextColumn FieldName="PROFESION_OFICIO" VisibleIndex="18" Caption="Profesion oficio" />
        <dx:GridViewDataTextColumn FieldName="OCUPACION_ACTUAL" VisibleIndex="19" Caption="Ocupacion actual" />
        <dx:GridViewDataTextColumn FieldName="TITULO_CERTIFICADO_OBTENIDO" VisibleIndex="20" Caption="Titulo certificado obtenido" />
        <dx:GridViewDataTextColumn FieldName="DEPARTAMENTO_NAC" VisibleIndex="21" Caption="Departamento nac" />
        <dx:GridViewDataTextColumn FieldName="MUNICIPIO_NAC" VisibleIndex="22" Caption="Municipio nac" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_DEPARTAMENTO" VisibleIndex="23" Caption="Codigo departamento" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_MUNICIPIO" VisibleIndex="24" Caption="Codigo municipio" />
        <dx:GridViewDataTextColumn FieldName="ID_NIVEL_ACADEMICO" VisibleIndex="25" Caption="Id nivel academico" />
        <dx:GridViewDataTextColumn FieldName="OTRA_EDUCACION_FORMAL" VisibleIndex="26" Caption="Otra educacion formal" />
        <dx:GridViewDataTextColumn FieldName="CON_DISCAPACIDAD" VisibleIndex="27" Caption="Con discapacidad" />
        <dx:GridViewDataTextColumn FieldName="DISC_OTRA" VisibleIndex="28" Caption="Disc otra" />
        <dx:GridViewDataTextColumn FieldName="LASTUPDATE" VisibleIndex="29" Caption="Lastupdate" />
        <dx:GridViewDataTextColumn FieldName="USERID" VisibleIndex="30" Caption="Userid" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" " Name="Eliminar" VisibleIndex="31">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Image-Url="../imagenes/eliminar.png" >
<Image Url="../imagenes/eliminar.png"></Image>
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

<asp:ObjectDataSource ID="odsListaParticipantesSemejantes" runat="server" 
    SelectMethod="ObtenerListaParticipantesSemejantes" TypeName="SGAFP.BL.cPARTICIPANTE">
    <SelectParameters>
        <asp:Parameter Name="mPARTICIPANTE" Type="Object" />
        <asp:Parameter Name="duplicadoPorFonetico" type="Int32" />      
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsListaPorCriterios" runat="server" 
    SelectMethod="ObtenerListaPorCriterios" TypeName="SGAFP.BL.cPARTICIPANTE">
    <SelectParameters>
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="String" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Int32" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter DefaultValue="NOMBRES" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarPARTICIPANTE" DeleteMethod="EliminarPARTICIPANTE" UpdateMethod="ActualizarPARTICIPANTE"
    TypeName="SGAFP.BL.cPARTICIPANTE">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="OCUPACION_ACTUAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="OCUPACION_ACTUAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPAIS" runat="server" 
    SelectMethod="ObtenerListaPorPAIS" InsertMethod="AgregarPARTICIPANTE" DeleteMethod="EliminarPARTICIPANTE" UpdateMethod="ActualizarPARTICIPANTE"
    TypeName="SGAFP.BL.cPARTICIPANTE">
    <SelectParameters>
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="OCUPACION_ACTUAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="OCUPACION_ACTUAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorESTADO_CIVIL" runat="server" 
    SelectMethod="ObtenerListaPorESTADO_CIVIL" InsertMethod="AgregarPARTICIPANTE" DeleteMethod="EliminarPARTICIPANTE" UpdateMethod="ActualizarPARTICIPANTE"
    TypeName="SGAFP.BL.cPARTICIPANTE">
    <SelectParameters>
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="OCUPACION_ACTUAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="OCUPACION_ACTUAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorDEPARTAMENTO" runat="server" 
    SelectMethod="ObtenerListaPorDEPARTAMENTO" InsertMethod="AgregarPARTICIPANTE" DeleteMethod="EliminarPARTICIPANTE" UpdateMethod="ActualizarPARTICIPANTE"
    TypeName="SGAFP.BL.cPARTICIPANTE">
    <SelectParameters>
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="OCUPACION_ACTUAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="OCUPACION_ACTUAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorMUNICIPIO" runat="server" 
    SelectMethod="ObtenerListaPorMUNICIPIO" InsertMethod="AgregarPARTICIPANTE" DeleteMethod="EliminarPARTICIPANTE" UpdateMethod="ActualizarPARTICIPANTE"
    TypeName="SGAFP.BL.cPARTICIPANTE">
    <SelectParameters>
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="OCUPACION_ACTUAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="OCUPACION_ACTUAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorNIVEL_ACADEMICO" runat="server" 
    SelectMethod="ObtenerListaPorNIVEL_ACADEMICO" InsertMethod="AgregarPARTICIPANTE" DeleteMethod="EliminarPARTICIPANTE" UpdateMethod="ActualizarPARTICIPANTE"
    TypeName="SGAFP.BL.cPARTICIPANTE">
    <SelectParameters>
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="OCUPACION_ACTUAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="OCUPACION_ACTUAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
        <asp:Parameter Name="USERID" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsListaPorNOMBRES_APELLIDOS" runat="server" 
    SelectMethod="ObtenerListaPorNOMBRES_APELLIDOS" TypeName="SGAFP.BL.cPARTICIPANTE">
    <SelectParameters>
        <asp:Parameter DefaultValue="" Name="NOMBRES_APELLIDOS" Type="String" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorNOMBRES_APELLIDOS_InscritosPorProveedor" runat="server" 
    SelectMethod="ObtenerListaPorNOMBRES_APELLIDOS_InscritosPorProveedor" TypeName="SGAFP.BL.cPARTICIPANTE">
    <SelectParameters>
        <asp:Parameter DefaultValue="" Name="ID_PROVEEDOR_AF" Type="Decimal"  />
        <asp:Parameter DefaultValue="" Name="NOMBRES_APELLIDOS" Type="String" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorBusqueda" runat="server" 
    SelectMethod="ObtenerListaPorBusqueda" TypeName="SGAFP.BL.cPARTICIPANTE">
    <SelectParameters>
        <asp:Parameter DefaultValue="" Name="aEntidad" Type="Object" />
        <asp:Parameter DefaultValue="" Name="aCriterios" Type="Object" />
        <asp:Parameter DefaultValue="APELLIDOS" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorDUI" runat="server" 
    SelectMethod="ObtenerListaPorDUI" TypeName="SGAFP.BL.cPARTICIPANTE">
    <SelectParameters>
        <asp:Parameter DefaultValue="" Name="DUI" Type="String" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorNIT" runat="server" 
    SelectMethod="ObtenerListaPorNIT" TypeName="SGAFP.BL.cPARTICIPANTE">
    <SelectParameters>
        <asp:Parameter DefaultValue="" Name="NIT" Type="String" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
    SelectMethod="ObtenerListaParticipantesSemejantes" TypeName="SGAFP.BL.cPARTICIPANTE_EXONERADO_DOC">
    <SelectParameters>
        <asp:Parameter Name="mPARTICIPANTE_EXONERADO_DOC" Type="Object" />
        <asp:Parameter Name="duplicadoPorFonetico" type="Int32" />      
    </SelectParameters>
</asp:ObjectDataSource>
