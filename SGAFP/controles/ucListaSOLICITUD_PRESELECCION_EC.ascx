<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaSOLICITUD_PRESELECCION_EC.ascx.vb" Inherits="controles_ucListaSOLICITUD_PRESELECCION_EC" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" Width="100%"  KeyFieldName="ID_SOLIC_PRESELEC" CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx">
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
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" CellStyle-HorizontalAlign="Center">
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEditar" runat="server" AlternateText="Editar" ToolTip="Editar" CommandName="Editar" ImageUrl="~/imagenes/Editar.png"  CommandArgument='<%# Bind("ID_SOLIC_PRESELEC") %>'></asp:ImageButton>
                <asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_SOLIC_PRESELEC") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" CellStyle-HorizontalAlign="Center" Caption="Pendiente de Aprobación" Name="colAutorizar" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Wrap="True" Width="50px"    >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnAutorizar" runat="server" AlternateText="Autorizar" ToolTip="Autorizar" CommandName="Autorizar" ImageUrl="~/imagenes/Aprobar.gif"  CommandArgument='<%# Bind("ID_SOLIC_PRESELEC") %>'></asp:ImageButton>                
            </DataItemTemplate>

<HeaderStyle HorizontalAlign="Center" Wrap="True"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_SOLIC_PRESELEC" ReadOnly="True" VisibleIndex="2" Caption="Id solic preselec" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NUM_CONTRATO" VisibleIndex="3" Caption="Contrato" UnboundType="String" Width="80px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" >
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CODIGO" VisibleIndex="3" Caption="Codigo Grupo" Width="50px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" UnboundType="String" >
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="NO_GRUPO" VisibleIndex="3" Caption="No. Grupo" Width="50px" HeaderStyle-HorizontalAlign="Center" CellStyle-HorizontalAlign="Center" UnboundType="String" >
<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<CellStyle HorizontalAlign="Center"></CellStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CURSO" VisibleIndex="3" Caption="Carrera" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="FECHA_PRESENTACION" VisibleIndex="3" Caption="Fecha Presentacion" Width="130px"  >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_PARTICIPANTE" VisibleIndex="4" Caption="Id participante" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_ESTADO_SOLICITUD" VisibleIndex="5" Caption="Id estado solicitud" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_GRUPO_SELEC" VisibleIndex="6" Caption="Id grupo selec" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_SELECC" VisibleIndex="7" Caption="Id tipo selecc" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOMBRES" VisibleIndex="8" Caption="Nombres" />
        <dx:GridViewDataTextColumn FieldName="APELLIDOS" VisibleIndex="9" Caption="Apellidos" />
        <dx:GridViewDataTextColumn FieldName="DUI" VisibleIndex="10" Caption="Dui" />
        <dx:GridViewDataTextColumn FieldName="TIPO_DOCTO" VisibleIndex="11" Caption="Tipo docto" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NUM_DOCTO" VisibleIndex="12" Caption="Num docto" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NIT" VisibleIndex="13" Caption="Nit" />
        <dx:GridViewDataTextColumn FieldName="ISSS" VisibleIndex="14" Caption="Isss" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_PAIS" VisibleIndex="15" Caption="Id pais" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="DEPARTAMENTO_NAC" VisibleIndex="16" Caption="Departamento nac" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="MUNICIPIO_NAC" VisibleIndex="17" Caption="Municipio nac" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_NACIMIENTO" VisibleIndex="18" Caption="Fecha Nacimiento" Width="120px" >
        <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="GENERO" VisibleIndex="19" Caption="Genero" Width="80px" Visible="false"  />
        <dx:GridViewDataTextColumn FieldName="EDAD" VisibleIndex="20" Caption="Edad" />
        <dx:GridViewDataTextColumn FieldName="TIPO_SOLICITUD" VisibleIndex="20" Caption="Tipo" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="MIEMBROS_GRUPO_FAMILIAR" VisibleIndex="21" Caption="Miembros grupo familiar" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_ESTADO_CIVIL" VisibleIndex="22" Caption="Id estado civil" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ES_JEFE_HOGAR" VisibleIndex="23" Caption="Es jefe hogar" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="TIENE_HIJOS" VisibleIndex="24" Caption="Tiene hijos" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NO_DE_HIJOS" VisibleIndex="25" Caption="No de hijos" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="SE_DEDICA_ALGUNA_PROFESION" VisibleIndex="26" Caption="Se dedica alguna profesion" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="PROFESION_OFICIO" VisibleIndex="27" Caption="Profesion oficio" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="DIRECCION" VisibleIndex="28" Caption="Direccion" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_DEPARTAMENTO" VisibleIndex="29" Caption="Codigo departamento" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_MUNICIPIO" VisibleIndex="30" Caption="Codigo municipio" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="TELEFONO" VisibleIndex="31" Caption="Telefono" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="MOVIL" VisibleIndex="32" Caption="Movil" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="EMAIL" VisibleIndex="33" Caption="Email" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="CON_DISCAPACIDAD" VisibleIndex="34" Caption="Con discapacidad" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="DISC_OTRA" VisibleIndex="35" Caption="Disc otra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_NIVEL_ACADEMICO" VisibleIndex="36" Caption="Id nivel academico" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="OTRA_EDUCACION_FORMAL" VisibleIndex="37" Caption="Otra educacion formal" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="TITULO_CERTIFICADO_OBTENIDO" VisibleIndex="38" Caption="Titulo certificado obtenido" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ESTUDIA_ACTUALMENTE" VisibleIndex="39" Caption="Estudia actualmente" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_TIEMPO_DEJO_ESTUDIAR" VisibleIndex="40" Caption="Id tiempo dejo estudiar" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_MOTIVO_DEJO_ESTU" VisibleIndex="41" Caption="Id motivo dejo estu" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="OTRO_MOTIVO_DEJO_ESTU" VisibleIndex="42" Caption="Otro motivo dejo estu" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="RECIBIO_CURSO_ANTERIOR" VisibleIndex="43" Caption="Recibio curso anterior" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="BENEF_PROM_EMP_ACT" VisibleIndex="44" Caption="Benef prom emp act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="BENEF_OBT_EMPLEO" VisibleIndex="45" Caption="Benef obt empleo" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="BENEF_OBT_ING_EXTRA" VisibleIndex="46" Caption="Benef obt ing extra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="BENEF_CAMB_EMP_X_CURSO" VisibleIndex="47" Caption="Benef camb emp x curso" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="BENEF_TRAB_CTA_PROPIA" VisibleIndex="48" Caption="Benef trab cta propia" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="BENEF_OTRO" VisibleIndex="49" Caption="Benef otro" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="RAZON_NO_BENEFICIO" VisibleIndex="50" Caption="Razon no beneficio" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="OCUACT_TRABAJA" VisibleIndex="51" Caption="Ocuact trabaja" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="OCUACT_ESTUDIA" VisibleIndex="52" Caption="Ocuact estudia" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="OCUACT_ESTU_TRAB" VisibleIndex="53" Caption="Ocuact estu trab" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="OCUACT_OFICIO_HOGAR" VisibleIndex="54" Caption="Ocuact oficio hogar" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="OCUACT_BUSCA_TRAB" VisibleIndex="55" Caption="Ocuact busca trab" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="OCUACT_OTRA" VisibleIndex="56" Caption="Ocuact otra" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="RECIBE_INGRESOS" VisibleIndex="57" Caption="Recibe ingresos" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="MANERA_OBT_ING_TRABAJO" VisibleIndex="58" Caption="Manera obt ing trabajo" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="MANERA_OBT_ING_BECA" VisibleIndex="59" Caption="Manera obt ing beca" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="MANERA_OBT_ING_AYUDA_FAM" VisibleIndex="60" Caption="Manera obt ing ayuda fam" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="MANERA_OBT_ING_REMESA" VisibleIndex="61" Caption="Manera obt ing remesa" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="MANERA_OBT_ING_OTRO" VisibleIndex="62" Caption="Manera obt ing otro" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_INGRESO_MES" VisibleIndex="63" Caption="Id ingreso mes" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_TIEMPO_NOTRAB" VisibleIndex="64" Caption="Id tiempo notrab" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_ACTI_ECONOMICA" VisibleIndex="65" Caption="Id acti economica" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_AREA_EMPRESA" VisibleIndex="66" Caption="Id area empresa" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_MOTIVO_DEJO_TRAB" VisibleIndex="67" Caption="Id motivo dejo trab" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="EXPFOR_OBTENER_EMPLEO" VisibleIndex="68" Caption="Expfor obtener empleo" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="EXPFOR_INGRESOS_EXTRAS" VisibleIndex="69" Caption="Expfor ingresos extras" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="EXPFOR_TRABAJAR_CTA_PROPIA" VisibleIndex="70" Caption="Expfor trabajar cta propia" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="EXPFOR_OTRO" VisibleIndex="71" Caption="Expfor otro" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="MOTIVO_ELIGIO_CARRERA" VisibleIndex="72" Caption="Motivo eligio carrera" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_REFERENCIA" VisibleIndex="73" Caption="Nombre referencia" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_REFERENCIA" VisibleIndex="74" Caption="Id referencia" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="DIRECCION_REFERENCIA" VisibleIndex="75" Caption="Direccion referencia" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="DEPARTAMENTO_REFERENCIA" VisibleIndex="76" Caption="Departamento referencia" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="MUNICIPIO_REFERENCIA" VisibleIndex="77" Caption="Municipio referencia" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="TELEFONO_REFERENCIA" VisibleIndex="78" Caption="Telefono referencia" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="MOVIL_REFERENCIA" VisibleIndex="79" Caption="Movil referencia" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="EMAIL_REFERENCIA" VisibleIndex="80" Caption="Email referencia" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="SUGERENCIAS" VisibleIndex="81" Caption="Sugerencias" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_CREA" VisibleIndex="82" Caption="Usuario crea" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_CREACION" VisibleIndex="83" Caption="Fecha creacion" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="USUARIO_ACT" VisibleIndex="84" Caption="Usuario act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ACT" VisibleIndex="85" Caption="Fecha act" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="TIPO_EMPLEO_OTRO" VisibleIndex="86" Caption="Tipo empleo otro" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="TRABAJO_ANTERIOR" VisibleIndex="87" Caption="Trabajo anterior" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="PUESTO_DESEMPENO" VisibleIndex="88" Caption="Puesto desempeno" Visible="false" />
        <dx:GridViewDataTextColumn FieldName="ID_ULT_SALARIO_MES" VisibleIndex="89" Caption="Id ult salario mes" Visible="false" />
        <dx:GridViewDataCheckColumn FieldName="AUTORIZADO" VisibleIndex="89" Caption="Aspirante aprobado" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" Width="30px"  Visible="true" >   
<HeaderStyle HorizontalAlign="Center" Wrap="True"></HeaderStyle>
        </dx:GridViewDataCheckColumn>
        <dx:GridViewDataCheckColumn FieldName="REQUI_AUTORIZACION" VisibleIndex="89" Caption="Requiere aprobación" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" Width="30px"  Visible="true" >   
<HeaderStyle HorizontalAlign="Center" Wrap="True"></HeaderStyle>
        </dx:GridViewDataCheckColumn>
        <dx:GridViewDataTextColumn FieldName="OBSERVACION_AURIZACION" VisibleIndex="89" Caption="Motivo requiere aprobación" HeaderStyle-Wrap="True" HeaderStyle-HorizontalAlign="Center" >
<HeaderStyle HorizontalAlign="Center" Wrap="True"></HeaderStyle>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_ULT_SALARIO_MES" VisibleIndex="89" Caption="Id ult salario mes" Visible="false" />
        <dx:GridViewDataTextColumn VisibleIndex="90" Name="Eliminar" Caption=" " CellStyle-HorizontalAlign="Center" >
            <DataItemTemplate>
                <asp:ImageButton ID="lbtnEliminar" runat="server" AlternateText="Eliminar" ToolTip="Eliminar" CommandName="Eliminar" ImageUrl="~/imagenes/eliminar.png"  CommandArgument='<%# Bind("ID_SOLIC_PRESELEC")%>'></asp:ImageButton>                             
            </DataItemTemplate>

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

<asp:ObjectDataSource ID="odsCriterios" runat="server" SelectMethod="ObtenerListaPorCriterios" TypeName="SGAFP.BL.cSOLICITUD_PRESELECCION_EC">
    <SelectParameters>
        <asp:Parameter DefaultValue="-2" Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter DefaultValue="-2" Name="ID_PROGRAMA_FORMACION" Type="Decimal" />
        <asp:Parameter DefaultValue="" Name="NUM_CONTRATO" Type="String" />
        <asp:Parameter DefaultValue="" Name="CODIGO" Type="String" />
        <asp:Parameter DefaultValue="" Name="NO_GRUPO" Type="Decimal" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>


<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarSOLICITUD_PRESELECCION_EC" DeleteMethod="EliminarSOLICITUD_PRESELECCION_EC" UpdateMethod="ActualizarSOLICITUD_PRESELECCION_EC"
    TypeName="SGAFP.BL.cSOLICITUD_PRESELECCION_EC">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPARTICIPANTE" runat="server" 
    SelectMethod="ObtenerListaPorPARTICIPANTE" InsertMethod="AgregarSOLICITUD_PRESELECCION_EC" DeleteMethod="EliminarSOLICITUD_PRESELECCION_EC" UpdateMethod="ActualizarSOLICITUD_PRESELECCION_EC"
    TypeName="SGAFP.BL.cSOLICITUD_PRESELECCION_EC">
    <SelectParameters>
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorESTADO_SOLICITUD" runat="server" 
    SelectMethod="ObtenerListaPorESTADO_SOLICITUD" InsertMethod="AgregarSOLICITUD_PRESELECCION_EC" DeleteMethod="EliminarSOLICITUD_PRESELECCION_EC" UpdateMethod="ActualizarSOLICITUD_PRESELECCION_EC"
    TypeName="SGAFP.BL.cSOLICITUD_PRESELECCION_EC">
    <SelectParameters>
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorGRUPO_SELECCION" runat="server" 
    SelectMethod="ObtenerListaPorGRUPO_SELECCION" InsertMethod="AgregarSOLICITUD_PRESELECCION_EC" DeleteMethod="EliminarSOLICITUD_PRESELECCION_EC" UpdateMethod="ActualizarSOLICITUD_PRESELECCION_EC"
    TypeName="SGAFP.BL.cSOLICITUD_PRESELECCION_EC">
    <SelectParameters>
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIPO_SELECC" runat="server" 
    SelectMethod="ObtenerListaPorTIPO_SELECC" InsertMethod="AgregarSOLICITUD_PRESELECCION_EC" DeleteMethod="EliminarSOLICITUD_PRESELECCION_EC" UpdateMethod="ActualizarSOLICITUD_PRESELECCION_EC"
    TypeName="SGAFP.BL.cSOLICITUD_PRESELECCION_EC">
    <SelectParameters>
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPAIS" runat="server" 
    SelectMethod="ObtenerListaPorPAIS" InsertMethod="AgregarSOLICITUD_PRESELECCION_EC" DeleteMethod="EliminarSOLICITUD_PRESELECCION_EC" UpdateMethod="ActualizarSOLICITUD_PRESELECCION_EC"
    TypeName="SGAFP.BL.cSOLICITUD_PRESELECCION_EC">
    <SelectParameters>
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorESTADO_CIVIL" runat="server" 
    SelectMethod="ObtenerListaPorESTADO_CIVIL" InsertMethod="AgregarSOLICITUD_PRESELECCION_EC" DeleteMethod="EliminarSOLICITUD_PRESELECCION_EC" UpdateMethod="ActualizarSOLICITUD_PRESELECCION_EC"
    TypeName="SGAFP.BL.cSOLICITUD_PRESELECCION_EC">
    <SelectParameters>
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorDEPARTAMENTO" runat="server" 
    SelectMethod="ObtenerListaPorDEPARTAMENTO" InsertMethod="AgregarSOLICITUD_PRESELECCION_EC" DeleteMethod="EliminarSOLICITUD_PRESELECCION_EC" UpdateMethod="ActualizarSOLICITUD_PRESELECCION_EC"
    TypeName="SGAFP.BL.cSOLICITUD_PRESELECCION_EC">
    <SelectParameters>
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorMUNICIPIO" runat="server" 
    SelectMethod="ObtenerListaPorMUNICIPIO" InsertMethod="AgregarSOLICITUD_PRESELECCION_EC" DeleteMethod="EliminarSOLICITUD_PRESELECCION_EC" UpdateMethod="ActualizarSOLICITUD_PRESELECCION_EC"
    TypeName="SGAFP.BL.cSOLICITUD_PRESELECCION_EC">
    <SelectParameters>
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorNIVEL_ACADEMICO" runat="server" 
    SelectMethod="ObtenerListaPorNIVEL_ACADEMICO" InsertMethod="AgregarSOLICITUD_PRESELECCION_EC" DeleteMethod="EliminarSOLICITUD_PRESELECCION_EC" UpdateMethod="ActualizarSOLICITUD_PRESELECCION_EC"
    TypeName="SGAFP.BL.cSOLICITUD_PRESELECCION_EC">
    <SelectParameters>
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIEMPO_DEJO_ESTUDIAR" runat="server" 
    SelectMethod="ObtenerListaPorTIEMPO_DEJO_ESTUDIAR" InsertMethod="AgregarSOLICITUD_PRESELECCION_EC" DeleteMethod="EliminarSOLICITUD_PRESELECCION_EC" UpdateMethod="ActualizarSOLICITUD_PRESELECCION_EC"
    TypeName="SGAFP.BL.cSOLICITUD_PRESELECCION_EC">
    <SelectParameters>
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorMOTIVO_DEJO_ESTU" runat="server" 
    SelectMethod="ObtenerListaPorMOTIVO_DEJO_ESTU" InsertMethod="AgregarSOLICITUD_PRESELECCION_EC" DeleteMethod="EliminarSOLICITUD_PRESELECCION_EC" UpdateMethod="ActualizarSOLICITUD_PRESELECCION_EC"
    TypeName="SGAFP.BL.cSOLICITUD_PRESELECCION_EC">
    <SelectParameters>
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorINGRESO_MES" runat="server" 
    SelectMethod="ObtenerListaPorINGRESO_MES" InsertMethod="AgregarSOLICITUD_PRESELECCION_EC" DeleteMethod="EliminarSOLICITUD_PRESELECCION_EC" UpdateMethod="ActualizarSOLICITUD_PRESELECCION_EC"
    TypeName="SGAFP.BL.cSOLICITUD_PRESELECCION_EC">
    <SelectParameters>
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIEMPO_NOTRAB" runat="server" 
    SelectMethod="ObtenerListaPorTIEMPO_NOTRAB" InsertMethod="AgregarSOLICITUD_PRESELECCION_EC" DeleteMethod="EliminarSOLICITUD_PRESELECCION_EC" UpdateMethod="ActualizarSOLICITUD_PRESELECCION_EC"
    TypeName="SGAFP.BL.cSOLICITUD_PRESELECCION_EC">
    <SelectParameters>
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorACTI_ECONOMICA" runat="server" 
    SelectMethod="ObtenerListaPorACTI_ECONOMICA" InsertMethod="AgregarSOLICITUD_PRESELECCION_EC" DeleteMethod="EliminarSOLICITUD_PRESELECCION_EC" UpdateMethod="ActualizarSOLICITUD_PRESELECCION_EC"
    TypeName="SGAFP.BL.cSOLICITUD_PRESELECCION_EC">
    <SelectParameters>
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorAREA_EMPRESA" runat="server" 
    SelectMethod="ObtenerListaPorAREA_EMPRESA" InsertMethod="AgregarSOLICITUD_PRESELECCION_EC" DeleteMethod="EliminarSOLICITUD_PRESELECCION_EC" UpdateMethod="ActualizarSOLICITUD_PRESELECCION_EC"
    TypeName="SGAFP.BL.cSOLICITUD_PRESELECCION_EC">
    <SelectParameters>
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorMOTIVO_DEJO_TRAB" runat="server" 
    SelectMethod="ObtenerListaPorMOTIVO_DEJO_TRAB" InsertMethod="AgregarSOLICITUD_PRESELECCION_EC" DeleteMethod="EliminarSOLICITUD_PRESELECCION_EC" UpdateMethod="ActualizarSOLICITUD_PRESELECCION_EC"
    TypeName="SGAFP.BL.cSOLICITUD_PRESELECCION_EC">
    <SelectParameters>
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorREFERENCIA" runat="server" 
    SelectMethod="ObtenerListaPorREFERENCIA" InsertMethod="AgregarSOLICITUD_PRESELECCION_EC" DeleteMethod="EliminarSOLICITUD_PRESELECCION_EC" UpdateMethod="ActualizarSOLICITUD_PRESELECCION_EC"
    TypeName="SGAFP.BL.cSOLICITUD_PRESELECCION_EC">
    <SelectParameters>
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="ID_GRUPO_SELEC" Type="Decimal" />
        <asp:Parameter Name="ID_TIPO_SELECC" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter Name="DEPARTAMENTO_NAC" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NAC" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="GENERO" Type="String" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="MIEMBROS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_OFICIO" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter Name="TELEFONO" Type="String" />
        <asp:Parameter Name="MOVIL" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />
        <asp:Parameter Name="CON_DISCAPACIDAD" Type="Decimal" />
        <asp:Parameter Name="DISC_OTRA" Type="String" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_ESTU" Type="Decimal" />
        <asp:Parameter Name="OTRO_MOTIVO_DEJO_ESTU" Type="String" />
        <asp:Parameter Name="RECIBIO_CURSO_ANTERIOR" Type="String" />
        <asp:Parameter Name="BENEF_PROM_EMP_ACT" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="BENEF_OBT_ING_EXTRA" Type="Decimal" />
        <asp:Parameter Name="BENEF_CAMB_EMP_X_CURSO" Type="Decimal" />
        <asp:Parameter Name="BENEF_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="BENEF_OTRO" Type="String" />
        <asp:Parameter Name="RAZON_NO_BENEFICIO" Type="String" />
        <asp:Parameter Name="OCUACT_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OCUACT_ESTU_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRAB" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_BECA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="ID_INGRESO_MES" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_NOTRAB" Type="Decimal" />
        <asp:Parameter Name="ID_ACTI_ECONOMICA" Type="Decimal" />
        <asp:Parameter Name="ID_AREA_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="ID_MOTIVO_DEJO_TRAB" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="MOTIVO_ELIGIO_CARRERA" Type="String" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USUARIO_CREA" Type="String" />
        <asp:Parameter Name="FECHA_CREACION" Type="DateTime" />
        <asp:Parameter Name="USUARIO_ACT" Type="String" />
        <asp:Parameter Name="FECHA_ACT" Type="DateTime" />
        <asp:Parameter Name="TIPO_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="PUESTO_DESEMPENO" Type="String" />
        <asp:Parameter Name="ID_ULT_SALARIO_MES" Type="Decimal" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLIC_PRESELEC" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
