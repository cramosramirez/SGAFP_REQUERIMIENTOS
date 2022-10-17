<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaFICHA_PATI.ascx.vb" Inherits="controles_ucListaFICHA_PATI" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>

<dx:ASPxCallbackPanel runat="server" ID="cbpucListaFICHA_PATI" ClientInstanceName="cbpucListaFICHA_PATI">    
        <PanelCollection>
            <dx:PanelContent runat="server"> 
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" KeyFieldName="NUME_FICH" EnableViewState="False" Font-Size="X-Small">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <ClientSideEvents RowClick="function(s, e) {var combo = eval(s.cpNombreComboCliente);combo.SetKeyValue(s.cpKeyValues[e.visibleIndex]);combo.SetText(s.cpKeyNames[e.visibleIndex]);combo.HideDropDown();}" 
                      CustomButtonClick="function(s,e){
                                            if (e.buttonID=='btnAprobar'){
                                                InscribirParticipanteFichaPATI(s.GetRowKey(e.visibleIndex));    
                                            }
                                         }"   
                />
    <Columns>
        <dx:GridViewCommandColumn Name="Edicion" Visible="False" ButtonType="Image" VisibleIndex="0"   >
             <CustomButtons>  
                <dx:GridViewCommandColumnCustomButton ID="btnAprobar" Text="Aprobar Solicitud" Visibility="Invisible" Image-Url="../imagenes/aprobar.gif" />                                                                                                  
            </CustomButtons>
            <NewButton Visible="False" Text="Agregar">
            </NewButton>
            <EditButton Visible="False" Text="Editar"></EditButton>
            <DeleteButton Visible="False" Text="Eliminar"></DeleteButton>
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1" Visible="False">
            <DataItemTemplate>
                <asp:LinkButton ID="lbtnEditar" runat="server" CommandName="Editar" 
                    CommandArgument='<%# Bind("NUME_FICH") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("NUME_FICH") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
         <dx:GridViewDataTextColumn FieldName="NUM_CONVENIO" Caption="No. CONVENIO" UnboundType="Decimal" VisibleIndex="1" />
        <dx:GridViewDataTextColumn FieldName="NUME_FICH" ReadOnly="True" VisibleIndex="2" Caption="No. FICHA" SortOrder="Ascending"/>
        <dx:GridViewDataTextColumn FieldName="APELLIDOS" VisibleIndex="3" Caption="APELLIDOS" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="NOMBRES" VisibleIndex="3" Caption="NOMBRES" UnboundType="String" />
        <dx:GridViewDataTextColumn FieldName="ID_ENTREVISTADOR" VisibleIndex="3" Caption="ID ENTREVISTADOR" />
        <dx:GridViewDataTextColumn FieldName="NOMB_CASERIO_AUP" VisibleIndex="4" Caption="NOMBRE CASERIO AUP" />
        <dx:GridViewDataTextColumn FieldName="FECHA_ING_FICHA" VisibleIndex="5" Caption="FECHA FICHA"  >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy"></PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CODIGO_PROYECTO" VisibleIndex="6" Caption="CODIGO PROYECTO" Visible="False" />
        <dx:GridViewDataTextColumn Caption="NOMBRE PROYECTO COMUNITARIO" FieldName="NOMBRE_PROYECTO" UnboundType="String" VisibleIndex="7" Width="300px" />
        <dx:GridViewDataTextColumn FieldName="PRIMER_NOMBRE" VisibleIndex="8" Caption="PRIMER NOMBRE" SortOrder="Ascending"/>
        <dx:GridViewDataTextColumn FieldName="SEGUNDO_NOMBRE" VisibleIndex="9" Caption="SEGUNDO NOMBRE" SortOrder="Ascending"/>
        <dx:GridViewDataTextColumn FieldName="TERCER_NOMBRE" VisibleIndex="10" Caption="TERCER NOMBRE" SortOrder="Ascending"/>
        <dx:GridViewDataTextColumn FieldName="PRIMER_APELLIDO" VisibleIndex="11" Caption="PRIMER APELLIDO" SortOrder="Ascending"/>
        <dx:GridViewDataTextColumn FieldName="SEGUNDO_APELLIDO" VisibleIndex="12" Caption="SEGUNDO APELLIDO" SortOrder="Ascending"/>
        <dx:GridViewDataTextColumn FieldName="TERCER_APELLIDO" VisibleIndex="13" Caption="APELLIDO CASADA" SortOrder="Ascending"/>
        <dx:GridViewDataTextColumn FieldName="ES_SALVADORENO" VisibleIndex="14" Caption="Es salvadoreno" />
        <dx:GridViewDataTextColumn FieldName="PAIS" VisibleIndex="15" Caption="Pais" />
        <dx:GridViewDataTextColumn FieldName="DUI" VisibleIndex="16" Caption="DUI" >
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="CEDULA_IDENTIDAD" VisibleIndex="17" Caption="Cedula identidad" />
        <dx:GridViewDataTextColumn FieldName="CARNET_MINORIDAD" VisibleIndex="18" Caption="Carnet minoridad" />
        <dx:GridViewDataTextColumn FieldName="PASAPORTE" VisibleIndex="19" Caption="Pasaporte" />
        <dx:GridViewDataTextColumn FieldName="DEPARTAMENTO_NACIMIENTO" VisibleIndex="20" Caption="Departamento nacimiento" />
        <dx:GridViewDataTextColumn FieldName="MUNICIPIO_NACIMIENTO" VisibleIndex="21" Caption="Municipio nacimiento" />
        <dx:GridViewDataTextColumn FieldName="FECHA_NACIMIENTO" VisibleIndex="22" Caption="FECHA NAC." >
            <PropertiesTextEdit DisplayFormatString="dd/MM/yyyy"></PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="Sexo" VisibleIndex="23" Caption="Sexo" visible="false"/>
        <dx:GridViewDataTextColumn Caption="SEXO" FieldName="descripcion_sexo" UnboundType="String" VisibleIndex="24">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="EDAD" VisibleIndex="23" Caption="EDAD" />
        <dx:GridViewDataTextColumn FieldName="ES_JEFE_DE_HOGAR" VisibleIndex="24" Caption="Es jefe de hogar" />
        <dx:GridViewDataTextColumn FieldName="ESTADO_FAMILIAR" VisibleIndex="25" Caption="Estado familiar" />
        <dx:GridViewDataTextColumn FieldName="TIENE_HIJOS" VisibleIndex="26" Caption="Tiene hijos" />
        <dx:GridViewDataTextColumn FieldName="NO_DE_HIJOS" VisibleIndex="27" Caption="No de hijos" />
        <dx:GridViewDataTextColumn FieldName="PERSONAS_GRUPO_FAMILIAR" VisibleIndex="28" Caption="Personas grupo familiar" />
        <dx:GridViewDataTextColumn FieldName="SE_DEDICA_ALGUNA_PROFESION" VisibleIndex="29" Caption="Se dedica alguna profesion" />
        <dx:GridViewDataTextColumn FieldName="PROFESION_SE_DEDICA" VisibleIndex="30" Caption="Profesion se dedica" />
        <dx:GridViewDataTextColumn FieldName="DIRECCION" VisibleIndex="31" 
            Caption="Direccion" Width="300px" ShowInCustomizationForm="True" />
        <dx:GridViewDataTextColumn FieldName="DEPARTAMENTO_RESIDENCIA" VisibleIndex="32" Caption="Departamento residencia" />
        <dx:GridViewDataTextColumn Caption="DEPARTAMENTO" FieldName="departamento" UnboundType="String" VisibleIndex="33" Visible="False">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="MUNICIPIO_RESIDENCIA" VisibleIndex="34" Caption="Municipio residencia" />
        <dx:GridViewDataTextColumn Caption="MUNICIPIO" FieldName="municipio" UnboundType="String" VisibleIndex="35" Visible="False">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="TELEFONO_FIJO" VisibleIndex="36" Caption="Telefono fijo" />
        <dx:GridViewDataTextColumn FieldName="TELEFONO_MOVIL" VisibleIndex="37" Caption="Telefono movil" />
        <dx:GridViewDataTextColumn FieldName="CORREO_ELECTRONICO" VisibleIndex="38" Caption="CORREO ELECTRONICO" />
        <dx:GridViewDataTextColumn FieldName="DISCAPACITADO_PERMANENTE" VisibleIndex="39" Caption="Discapacitado permanente" />
        <dx:GridViewDataTextColumn FieldName="DISCAP_MOVERSE_CAMINAR" VisibleIndex="40" Caption="Discap moverse caminar" />
        <dx:GridViewDataTextColumn FieldName="DISCAP_USAR_BRAZOS" VisibleIndex="39" Caption="Discap usar brazos" />
        <dx:GridViewDataTextColumn FieldName="DISCAP_VER" VisibleIndex="40" Caption="Discap ver" />
        <dx:GridViewDataTextColumn FieldName="DISCAP_OIR" VisibleIndex="41" Caption="Discap oir" />
        <dx:GridViewDataTextColumn FieldName="DISCAP_HABLAR" VisibleIndex="42" Caption="Discap hablar" />
        <dx:GridViewDataTextColumn FieldName="DISCAP_RETRASO" VisibleIndex="43" Caption="Discap retraso" />
        <dx:GridViewDataTextColumn FieldName="DISCAP_BANARSE" VisibleIndex="44" Caption="Discap banarse" />
        <dx:GridViewDataTextColumn FieldName="DISCAP_EXPLIQUE" VisibleIndex="45" Caption="Discap explique" />
        <dx:GridViewDataTextColumn FieldName="SABE_LEER_ESCRIBIR" VisibleIndex="46" Caption="Sabe leer escribir" />
        <dx:GridViewDataTextColumn FieldName="SOLO_LEE" VisibleIndex="47" Caption="Solo lee" />
        <dx:GridViewDataTextColumn FieldName="SOLO_ESCRIBE" VisibleIndex="48" Caption="Solo escribe" />
        <dx:GridViewDataTextColumn FieldName="SOLO_FIRMA" VisibleIndex="49" Caption="Solo firma" />
        <dx:GridViewDataTextColumn FieldName="EDUCACION_BASICA" VisibleIndex="50" Caption="Educacion basica" />
        <dx:GridViewDataTextColumn FieldName="BACHILLERATO" VisibleIndex="51" Caption="Bachillerato" />
        <dx:GridViewDataTextColumn FieldName="TECNOLOGICA" VisibleIndex="52" Caption="Tecnologica" />
        <dx:GridViewDataTextColumn FieldName="UNIVERSITARIA" VisibleIndex="53" Caption="Universitaria" />
        <dx:GridViewDataTextColumn FieldName="OTRA_EDUCACION_FORMAL" VisibleIndex="54" Caption="Otra educacion formal" />
        <dx:GridViewDataTextColumn FieldName="TITULO_OBTENIDO" VisibleIndex="55" Caption="Titulo obtenido" />
        <dx:GridViewDataTextColumn FieldName="HA_DEJADO_DE_ESTUDIAR" VisibleIndex="56" Caption="Ha dejado de estudiar" />
        <dx:GridViewDataTextColumn FieldName="TIEMPO_DEJO_ESTUDIAR" VisibleIndex="57" Caption="Tiempo dejo estudiar" />
        <dx:GridViewDataTextColumn FieldName="HA_RECIBIDO_CURSOS" VisibleIndex="58" Caption="Ha recibido cursos" />
        <dx:GridViewDataTextColumn FieldName="CURSO_1" VisibleIndex="59" Caption="Curso 1" />
        <dx:GridViewDataTextColumn FieldName="CURSO_2" VisibleIndex="60" Caption="Curso 2" />
        <dx:GridViewDataTextColumn FieldName="CURSO_3" VisibleIndex="61" Caption="Curso 3" />
        <dx:GridViewDataTextColumn FieldName="IMPARTIO_INSAFORP_CURSO_1" VisibleIndex="62" Caption="Impartio insaforp curso 1" />
        <dx:GridViewDataTextColumn FieldName="IMPARTIO_INSAFORP_CURSO_2" VisibleIndex="63" Caption="Impartio insaforp curso 2" />
        <dx:GridViewDataTextColumn FieldName="IMPARTIO_INSAFORP_CURSO_3" VisibleIndex="64" Caption="Impartio insaforp curso 3" />
        <dx:GridViewDataTextColumn FieldName="ANO_CURSO_1" VisibleIndex="65" Caption="Ano curso 1" />
        <dx:GridViewDataTextColumn FieldName="ANO_CURSO_2" VisibleIndex="66" Caption="Ano curso 2" />
        <dx:GridViewDataTextColumn FieldName="ANO_CURSO_3" VisibleIndex="67" Caption="Ano curso 3" />
        <dx:GridViewDataTextColumn FieldName="CURSO_LE_DIO_BENEFICIOS_1" VisibleIndex="68" Caption="Curso le dio beneficios 1" />
        <dx:GridViewDataTextColumn FieldName="CURSO_LE_DIO_BENEFICIOS_2" VisibleIndex="69" Caption="Curso le dio beneficios 2" />
        <dx:GridViewDataTextColumn FieldName="CURSO_LE_DIO_BENEFICIOS_3" VisibleIndex="70" Caption="Curso le dio beneficios 3" />
        <dx:GridViewDataTextColumn FieldName="SIRVIO_CAPAC_OBTENER_EMPLEO" VisibleIndex="71" Caption="Sirvio capac obtener empleo" />
        <dx:GridViewDataTextColumn FieldName="SIRVIO_CAPAC_CAMBIAR_EMPLEO" VisibleIndex="72" Caption="Sirvio capac cambiar empleo" />
        <dx:GridViewDataTextColumn FieldName="SIRVIO_CAPAC_TRAB_CTA_PROPIA" VisibleIndex="73" Caption="Sirvio capac trab cta propia" />
        <dx:GridViewDataTextColumn FieldName="SIRVIO_CAPAC_OTROS_INGRESOS" VisibleIndex="74" Caption="Sirvio capac otros ingresos" />
        <dx:GridViewDataTextColumn FieldName="SIRVIO_CAPAC_PROMOCION" VisibleIndex="75" Caption="Sirvio capac promocion" />
        <dx:GridViewDataTextColumn FieldName="SIRVIO_CAPAC_OTRO" VisibleIndex="76" Caption="Sirvio capac otro" />
        <dx:GridViewDataTextColumn FieldName="PORQUE_NO_RECIB_BENEFICIO" VisibleIndex="77" Caption="Porque no recib beneficio" />
        <dx:GridViewDataTextColumn FieldName="REALIZA_ACTIVIDAD_INGRESOS" VisibleIndex="78" Caption="Realiza actividad ingresos" />
        <dx:GridViewDataTextColumn FieldName="MEDIO_DE_INGRESO" VisibleIndex="79" Caption="Medio de ingreso" />
        <dx:GridViewDataTextColumn FieldName="ACT_INGRESOS" VisibleIndex="80" Caption="Act ingresos" />
        <dx:GridViewDataTextColumn FieldName="OTRA_ACTIVIDAD_ESTUDIA" VisibleIndex="81" Caption="Otra actividad estudia" />
        <dx:GridViewDataTextColumn FieldName="OTRA_ACTIVIDAD_OFICIOS_HOGAR" VisibleIndex="82" Caption="Otra actividad oficios hogar" />
        <dx:GridViewDataTextColumn FieldName="OTRA_ACTIVIDAD_BUSCA_TRABAJO" VisibleIndex="83" Caption="Otra actividad busca trabajo" />
        <dx:GridViewDataTextColumn FieldName="OTRA_ACTIVIDAD_OTRA" VisibleIndex="84" Caption="Otra actividad otra" />
        <dx:GridViewDataTextColumn FieldName="TIPO_DE_EMPLEO_TIEMPO_COMP" VisibleIndex="85" Caption="Tipo de empleo tiempo comp" />
        <dx:GridViewDataTextColumn FieldName="TIPO_DE_EMPLEO_NEG_FAMILIAR" VisibleIndex="86" Caption="Tipo de empleo neg familiar" />
        <dx:GridViewDataTextColumn FieldName="TIPO_DE_EMPLEO_MEDIO_TIEMPO" VisibleIndex="87" Caption="Tipo de empleo medio tiempo" />
        <dx:GridViewDataTextColumn FieldName="TIPO_DE_EMPLEO_CTA_PROPIA" VisibleIndex="88" Caption="Tipo de empleo cta propia" />
        <dx:GridViewDataTextColumn FieldName="TIPO_DE_EMPLEO_POR_HORAS" VisibleIndex="89" Caption="Tipo de empleo por horas" />
        <dx:GridViewDataTextColumn FieldName="TIPO_DE_EMPLEO_TEMPORAL" VisibleIndex="90" Caption="Tipo de empleo temporal" />
        <dx:GridViewDataTextColumn FieldName="TIPO_DE_EMPLEO_OTRO" VisibleIndex="91" Caption="Tipo de empleo otro" />
        <dx:GridViewDataTextColumn FieldName="HA_TRABAJADO_ANTES" VisibleIndex="92" Caption="Ha trabajado antes" />
        <dx:GridViewDataTextColumn FieldName="TIEMPO_QUE_NO_TRABAJA" VisibleIndex="93" Caption="Tiempo que no trabaja" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_EMPRESA_ANTERIOR" VisibleIndex="94" Caption="Nombre empresa anterior" />
        <dx:GridViewDataTextColumn FieldName="DEDICACION_EMPRESA" VisibleIndex="95" Caption="Dedicacion empresa" />
        <dx:GridViewDataTextColumn FieldName="MOTIVO_SALIDA_EMPRESA_OTRAS" VisibleIndex="97" Caption="Motivo salida empresa otras" />
        <dx:GridViewDataTextColumn FieldName="PUESTO_EMPRESA" VisibleIndex="98" Caption="Puesto empresa" />
        <dx:GridViewDataTextColumn FieldName="TIEMPO_TRABAJO_EMPRESA" VisibleIndex="99" Caption="Tiempo trabajo empresa" />
        <dx:GridViewDataTextColumn FieldName="RECIBE_INGRESOS" VisibleIndex="100" Caption="Recibe ingresos" />
        <dx:GridViewDataTextColumn FieldName="MAN_OBTIENE_ING_TRAB_ACT" VisibleIndex="101" Caption="Man obtiene ing trab act" />
        <dx:GridViewDataTextColumn FieldName="MAN_OBTIENE_ING_AYUDA_FAM" VisibleIndex="102" Caption="Man obtiene ing ayuda fam" />
        <dx:GridViewDataTextColumn FieldName="MAN_OBTIENE_ING_REMESA" VisibleIndex="103" Caption="Man obtiene ing remesa" />
        <dx:GridViewDataTextColumn FieldName="MAN_OBTIENE_ING_PENSION" VisibleIndex="104" Caption="Man obtiene ing pension" />
        <dx:GridViewDataTextColumn FieldName="MAN_OBTIENE_ING_TRAB_ACT_REM" VisibleIndex="105" Caption="Man obtiene ing trab act rem" />
        <dx:GridViewDataTextColumn FieldName="MAN_OBTIENE_ING_OTRA" VisibleIndex="106" Caption="Man obtiene ing otra" />
        <dx:GridViewDataTextColumn FieldName="INGRESO_PERSONAL_MENSUAL" VisibleIndex="107" Caption="Ingreso personal mensual" />
        <dx:GridViewDataTextColumn FieldName="INGRESO_PERSONAL_DIARIO" VisibleIndex="108" Caption="Ingreso personal diario" />
        <dx:GridViewDataTextColumn FieldName="QUE_GUSTARIA_APRENDER_1" VisibleIndex="109" Caption="Que gustaria aprender 1" />
        <dx:GridViewDataTextColumn FieldName="QUE_GUSTARIA_APRENDER_2" VisibleIndex="110" Caption="Que gustaria aprender 2" />
        <dx:GridViewDataTextColumn FieldName="QUE_GUSTARIA_APRENDER_3" VisibleIndex="111" Caption="Que gustaria aprender 3" />
        <dx:GridViewDataTextColumn FieldName="LOGROS_ESPERADOS_EMPLEO_FORMAL" VisibleIndex="112" Caption="Logros esperados empleo formal" />
        <dx:GridViewDataTextColumn FieldName="LOGROS_ESPERADOS_CUENTA_PROPIA" VisibleIndex="113" Caption="Logros esperados cuenta propia" />
        <dx:GridViewDataTextColumn FieldName="LOGROS_ESPERADOS_OTRO" VisibleIndex="114" Caption="Logros esperados otro" />
        <dx:GridViewDataTextColumn FieldName="GUSTO_UBICACION_TRABAJO" VisibleIndex="115" Caption="Gusto ubicacion trabajo" />
        <dx:GridViewDataTextColumn FieldName="EN_QUE_OCUP_DINERO_AYUDAR" VisibleIndex="116" Caption="En que ocup dinero ayudar" />
        <dx:GridViewDataTextColumn FieldName="EN_QUE_OCUP_DINERO_INDEPEND" VisibleIndex="117" Caption="En que ocup dinero independ" />
        <dx:GridViewDataTextColumn FieldName="EN_QUE_OCUP_DINERO_MANT_HIJOS" VisibleIndex="118" Caption="En que ocup dinero mant hijos" />
        <dx:GridViewDataTextColumn FieldName="EN_QUE_OCUP_DINERO_MANT_PADRES" VisibleIndex="119" Caption="En que ocup dinero mant padres" />
        <dx:GridViewDataTextColumn FieldName="EN_QUE_OCUP_DINERO_PAGAR_ESTUD" VisibleIndex="120" Caption="En que ocup dinero pagar estud" />
        <dx:GridViewDataTextColumn FieldName="EN_QUE_OCUP_DINERO_OTRO" VisibleIndex="121" Caption="En que ocup dinero otro" />
        <dx:GridViewDataTextColumn FieldName="NOMBRES_CONOCIDO" VisibleIndex="122" Caption="Nombres conocido" />
        <dx:GridViewDataTextColumn FieldName="PARENTESCO" VisibleIndex="123" Caption="Parentesco" />
        <dx:GridViewDataTextColumn FieldName="DIRECCION_CONOCIDO" VisibleIndex="124" Caption="Direccion conocido" />
        <dx:GridViewDataTextColumn FieldName="DEPARTAMENTO_CONOCIDO" VisibleIndex="125" Caption="Departamento conocido" />
        <dx:GridViewDataTextColumn FieldName="MUNICIPIO_CONOCIDO" VisibleIndex="126" Caption="Municipio conocido" />
        <dx:GridViewDataTextColumn FieldName="TELEFONO_FIJO_CONOCIDO" VisibleIndex="127" Caption="Telefono fijo conocido" />
        <dx:GridViewDataTextColumn FieldName="TELEFONO_MOVIL_CONOCIDO" VisibleIndex="128" Caption="Telefono movil conocido" />
        <dx:GridViewDataTextColumn FieldName="EMAIL_CONOCIDO" VisibleIndex="129" Caption="Email conocido" />
        <dx:GridViewDataTextColumn FieldName="OBSERVACIONES_SUGERENCIAS" VisibleIndex="130" Caption="Observaciones sugerencias" />
        <dx:GridViewDataTextColumn FieldName="USERID" VisibleIndex="131" Caption="USERID" />
        <dx:GridViewDataTextColumn FieldName="LASTUPDATE" VisibleIndex="132" Caption="LASTUPDATE" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="133">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>
    <Templates>        
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
 <dx:ASPxHiddenField runat="server" ID="hf" /> 
            
             </dx:PanelContent>
         </PanelCollection>
</dx:ASPxCallbackPanel>
        
<asp:ObjectDataSource ID="odsListaPorCriterios" runat="server" 
    SelectMethod="ObtenerListaPorCriterios" TypeName="PATI.BL.cFICHA_PATI">    
     <SelectParameters>      
        <asp:Parameter Name="NumConvenio" Type="Decimal" />
        <asp:Parameter Name="NumeFich" Type="Decimal" />
        <asp:Parameter Name="Nombres" Type="String" />
        <asp:Parameter Name="Apellidos" Type="String" />
        <asp:Parameter Name="NumeroDui" Type="String" />
        <asp:Parameter Name="FechaNacimiento" Type="DateTime"/>
    </SelectParameters>
</asp:ObjectDataSource> 
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarFICHA_PATI" DeleteMethod="EliminarFICHA_PATI" UpdateMethod="ActualizarFICHA_PATI"
    TypeName="PATI.BL.cFICHA_PATI">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="NUME_FICH" Type="Decimal" />
        <asp:Parameter Name="ID_ENTREVISTADOR" Type="Decimal" />
        <asp:Parameter Name="NOMB_CASERIO_AUP" Type="String" />
        <asp:Parameter Name="FECHA_ING_FICHA" Type="DateTime" />
        <asp:Parameter Name="CODIGO_PROYECTO" Type="String" />
        <asp:Parameter Name="PRIMER_NOMBRE" Type="String" />
        <asp:Parameter Name="SEGUNDO_NOMBRE" Type="String" />
        <asp:Parameter Name="TERCER_NOMBRE" Type="String" />
        <asp:Parameter Name="PRIMER_APELLIDO" Type="String" />
        <asp:Parameter Name="SEGUNDO_APELLIDO" Type="String" />
        <asp:Parameter Name="TERCER_APELLIDO" Type="String" />
        <asp:Parameter Name="ES_SALVADORENO" Type="Decimal" />
        <asp:Parameter Name="PAIS" Type="Decimal" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="CEDULA_IDENTIDAD" Type="String" />
        <asp:Parameter Name="CARNET_MINORIDAD" Type="String" />
        <asp:Parameter Name="PASAPORTE" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_NACIMIENTO" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NACIMIENTO" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="SEXO" Type="Decimal" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_DE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="ESTADO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="PERSONAS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_SE_DEDICA" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String"/>
        <asp:Parameter Name="DEPARTAMENTO_RESIDENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_RESIDENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_FIJO" Type="String" />
        <asp:Parameter Name="TELEFONO_MOVIL" Type="String" />
        <asp:Parameter Name="CORREO_ELECTRONICO" Type="String" />
        <asp:Parameter Name="DISCAPACITADO_PERMANENTE" Type="Decimal" />
        <asp:Parameter Name="DISCAP_MOVERSE_CAMINAR" Type="Decimal" />
        <asp:Parameter Name="DISCAP_USAR_BRAZOS" Type="Decimal" />
        <asp:Parameter Name="DISCAP_VER" Type="Decimal" />
        <asp:Parameter Name="DISCAP_OIR" Type="Decimal" />
        <asp:Parameter Name="DISCAP_HABLAR" Type="Decimal" />
        <asp:Parameter Name="DISCAP_RETRASO" Type="Decimal" />
        <asp:Parameter Name="DISCAP_BANARSE" Type="Decimal" />
        <asp:Parameter Name="DISCAP_EXPLIQUE" Type="String" />
        <asp:Parameter Name="SABE_LEER_ESCRIBIR" Type="Decimal" />
        <asp:Parameter Name="SOLO_LEE" Type="Decimal" />
        <asp:Parameter Name="SOLO_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="SOLO_FIRMA" Type="Decimal" />
        <asp:Parameter Name="EDUCACION_BASICA" Type="Decimal" />
        <asp:Parameter Name="BACHILLERATO" Type="Decimal" />
        <asp:Parameter Name="TECNOLOGICA" Type="Decimal" />
        <asp:Parameter Name="UNIVERSITARIA" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_OBTENIDO" Type="String" />
        <asp:Parameter Name="HA_DEJADO_DE_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="HA_RECIBIDO_CURSOS" Type="Decimal" />
        <asp:Parameter Name="CURSO_1" Type="String" />
        <asp:Parameter Name="CURSO_2" Type="String" />
        <asp:Parameter Name="CURSO_3" Type="String" />
        <asp:Parameter Name="IMPARTIO_INSAFORP_CURSO_1" Type="Decimal" />
        <asp:Parameter Name="IMPARTIO_INSAFORP_CURSO_2" Type="Decimal" />
        <asp:Parameter Name="IMPARTIO_INSAFORP_CURSO_3" Type="Decimal" />
        <asp:Parameter Name="ANO_CURSO_1" Type="Decimal" />
        <asp:Parameter Name="ANO_CURSO_2" Type="Decimal" />
        <asp:Parameter Name="ANO_CURSO_3" Type="Decimal" />
        <asp:Parameter Name="CURSO_LE_DIO_BENEFICIOS_1" Type="Decimal" />
        <asp:Parameter Name="CURSO_LE_DIO_BENEFICIOS_2" Type="Decimal" />
        <asp:Parameter Name="CURSO_LE_DIO_BENEFICIOS_3" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_OTROS_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_PROMOCION" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_OTRO" Type="String" />
        <asp:Parameter Name="PORQUE_NO_RECIB_BENEFICIO" Type="String" />
        <asp:Parameter Name="REALIZA_ACTIVIDAD_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MEDIO_DE_INGRESO" Type="Decimal" />
        <asp:Parameter Name="ACT_INGRESOS" Type="String" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_OFICIOS_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_OTRA" Type="String" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_TIEMPO_COMP" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_NEG_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_MEDIO_TIEMPO" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_POR_HORAS" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_TEMPORAL" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="HA_TRABAJADO_ANTES" Type="Decimal" />
        <asp:Parameter Name="TIEMPO_QUE_NO_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_EMPRESA_ANTERIOR" Type="String" />
        <asp:Parameter Name="DEDICACION_EMPRESA" Type="String" />        
        <asp:Parameter Name="MOTIVO_SALIDA_EMPRESA_OTRAS" Type="String" />
        <asp:Parameter Name="PUESTO_EMPRESA" Type="String" />
        <asp:Parameter Name="TIEMPO_TRABAJO_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_TRAB_ACT" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_TRAB_ACT_REM" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_OTRA" Type="String" />
        <asp:Parameter Name="INGRESO_PERSONAL_MENSUAL" Type="Decimal" />
        <asp:Parameter Name="INGRESO_PERSONAL_DIARIO" Type="Decimal" />
        <asp:Parameter Name="QUE_GUSTARIA_APRENDER_1" Type="String" />
        <asp:Parameter Name="QUE_GUSTARIA_APRENDER_2" Type="String" />
        <asp:Parameter Name="QUE_GUSTARIA_APRENDER_3" Type="String" />
        <asp:Parameter Name="LOGROS_ESPERADOS_EMPLEO_FORMAL" Type="Decimal" />
        <asp:Parameter Name="LOGROS_ESPERADOS_CUENTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="LOGROS_ESPERADOS_OTRO" Type="String" />
        <asp:Parameter Name="GUSTO_UBICACION_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_AYUDAR" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_INDEPEND" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_MANT_HIJOS" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_MANT_PADRES" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_PAGAR_ESTUD" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_OTRO" Type="String" />
        <asp:Parameter Name="NOMBRES_CONOCIDO" Type="String" />
        <asp:Parameter Name="PARENTESCO" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_CONOCIDO" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_CONOCIDO" Type="String" />
        <asp:Parameter Name="MUNICIPIO_CONOCIDO" Type="String" />
        <asp:Parameter Name="TELEFONO_FIJO_CONOCIDO" Type="String" />
        <asp:Parameter Name="TELEFONO_MOVIL_CONOCIDO" Type="String" />
        <asp:Parameter Name="EMAIL_CONOCIDO" Type="String" />
        <asp:Parameter Name="OBSERVACIONES_SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="NUME_FICH" Type="Decimal" />
        <asp:Parameter Name="ID_ENTREVISTADOR" Type="Decimal" />
        <asp:Parameter Name="NOMB_CASERIO_AUP" Type="String" />
        <asp:Parameter Name="FECHA_ING_FICHA" Type="DateTime" />
        <asp:Parameter Name="CODIGO_PROYECTO" Type="String" />
        <asp:Parameter Name="PRIMER_NOMBRE" Type="String" />
        <asp:Parameter Name="SEGUNDO_NOMBRE" Type="String" />
        <asp:Parameter Name="TERCER_NOMBRE" Type="String" />
        <asp:Parameter Name="PRIMER_APELLIDO" Type="String" />
        <asp:Parameter Name="SEGUNDO_APELLIDO" Type="String" />
        <asp:Parameter Name="TERCER_APELLIDO" Type="String" />
        <asp:Parameter Name="ES_SALVADORENO" Type="Decimal" />
        <asp:Parameter Name="PAIS" Type="Decimal" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="CEDULA_IDENTIDAD" Type="String" />
        <asp:Parameter Name="CARNET_MINORIDAD" Type="String" />
        <asp:Parameter Name="PASAPORTE" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_NACIMIENTO" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NACIMIENTO" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="SEXO" Type="Decimal" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_DE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="ESTADO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="PERSONAS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_SE_DEDICA" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_RESIDENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_RESIDENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_FIJO" Type="String" />
        <asp:Parameter Name="TELEFONO_MOVIL" Type="String" />
        <asp:Parameter Name="CORREO_ELECTRONICO" Type="String" />
        <asp:Parameter Name="DISCAPACITADO_PERMANENTE" Type="Decimal" />
        <asp:Parameter Name="DISCAP_MOVERSE_CAMINAR" Type="Decimal" />
        <asp:Parameter Name="DISCAP_USAR_BRAZOS" Type="Decimal" />
        <asp:Parameter Name="DISCAP_VER" Type="Decimal" />
        <asp:Parameter Name="DISCAP_OIR" Type="Decimal" />
        <asp:Parameter Name="DISCAP_HABLAR" Type="Decimal" />
        <asp:Parameter Name="DISCAP_RETRASO" Type="Decimal" />
        <asp:Parameter Name="DISCAP_BANARSE" Type="Decimal" />
        <asp:Parameter Name="DISCAP_EXPLIQUE" Type="String" />
        <asp:Parameter Name="SABE_LEER_ESCRIBIR" Type="Decimal" />
        <asp:Parameter Name="SOLO_LEE" Type="Decimal" />
        <asp:Parameter Name="SOLO_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="SOLO_FIRMA" Type="Decimal" />
        <asp:Parameter Name="EDUCACION_BASICA" Type="Decimal" />
        <asp:Parameter Name="BACHILLERATO" Type="Decimal" />
        <asp:Parameter Name="TECNOLOGICA" Type="Decimal" />
        <asp:Parameter Name="UNIVERSITARIA" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_OBTENIDO" Type="String" />
        <asp:Parameter Name="HA_DEJADO_DE_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="HA_RECIBIDO_CURSOS" Type="Decimal" />
        <asp:Parameter Name="CURSO_1" Type="String" />
        <asp:Parameter Name="CURSO_2" Type="String" />
        <asp:Parameter Name="CURSO_3" Type="String" />
        <asp:Parameter Name="IMPARTIO_INSAFORP_CURSO_1" Type="Decimal" />
        <asp:Parameter Name="IMPARTIO_INSAFORP_CURSO_2" Type="Decimal" />
        <asp:Parameter Name="IMPARTIO_INSAFORP_CURSO_3" Type="Decimal" />
        <asp:Parameter Name="ANO_CURSO_1" Type="Decimal" />
        <asp:Parameter Name="ANO_CURSO_2" Type="Decimal" />
        <asp:Parameter Name="ANO_CURSO_3" Type="Decimal" />
        <asp:Parameter Name="CURSO_LE_DIO_BENEFICIOS_1" Type="Decimal" />
        <asp:Parameter Name="CURSO_LE_DIO_BENEFICIOS_2" Type="Decimal" />
        <asp:Parameter Name="CURSO_LE_DIO_BENEFICIOS_3" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_OTROS_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_PROMOCION" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_OTRO" Type="String" />
        <asp:Parameter Name="PORQUE_NO_RECIB_BENEFICIO" Type="String" />
        <asp:Parameter Name="REALIZA_ACTIVIDAD_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MEDIO_DE_INGRESO" Type="Decimal" />
        <asp:Parameter Name="ACT_INGRESOS" Type="String" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_OFICIOS_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_OTRA" Type="String" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_TIEMPO_COMP" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_NEG_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_MEDIO_TIEMPO" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_POR_HORAS" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_TEMPORAL" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="HA_TRABAJADO_ANTES" Type="Decimal" />
        <asp:Parameter Name="TIEMPO_QUE_NO_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_EMPRESA_ANTERIOR" Type="String" />
        <asp:Parameter Name="DEDICACION_EMPRESA" Type="String" />        
        <asp:Parameter Name="MOTIVO_SALIDA_EMPRESA_OTRAS" Type="String" />
        <asp:Parameter Name="PUESTO_EMPRESA" Type="String" />
        <asp:Parameter Name="TIEMPO_TRABAJO_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_TRAB_ACT" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_TRAB_ACT_REM" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_OTRA" Type="String" />
        <asp:Parameter Name="INGRESO_PERSONAL_MENSUAL" Type="Decimal" />
        <asp:Parameter Name="INGRESO_PERSONAL_DIARIO" Type="Decimal" />
        <asp:Parameter Name="QUE_GUSTARIA_APRENDER_1" Type="String" />
        <asp:Parameter Name="QUE_GUSTARIA_APRENDER_2" Type="String" />
        <asp:Parameter Name="QUE_GUSTARIA_APRENDER_3" Type="String" />
        <asp:Parameter Name="LOGROS_ESPERADOS_EMPLEO_FORMAL" Type="Decimal" />
        <asp:Parameter Name="LOGROS_ESPERADOS_CUENTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="LOGROS_ESPERADOS_OTRO" Type="String" />
        <asp:Parameter Name="GUSTO_UBICACION_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_AYUDAR" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_INDEPEND" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_MANT_HIJOS" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_MANT_PADRES" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_PAGAR_ESTUD" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_OTRO" Type="String" />
        <asp:Parameter Name="NOMBRES_CONOCIDO" Type="String" />
        <asp:Parameter Name="PARENTESCO" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_CONOCIDO" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_CONOCIDO" Type="String" />
        <asp:Parameter Name="MUNICIPIO_CONOCIDO" Type="String" />
        <asp:Parameter Name="TELEFONO_FIJO_CONOCIDO" Type="String" />
        <asp:Parameter Name="TELEFONO_MOVIL_CONOCIDO" Type="String" />
        <asp:Parameter Name="EMAIL_CONOCIDO" Type="String" />
        <asp:Parameter Name="OBSERVACIONES_SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="NUME_FICH" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorENCA_FICH_PATI" runat="server" 
    SelectMethod="ObtenerListaPorENCA_FICH_PATI" InsertMethod="AgregarFICHA_PATI" DeleteMethod="EliminarFICHA_PATI" UpdateMethod="ActualizarFICHA_PATI"
    TypeName="PATI.BL.cFICHA_PATI">
    <SelectParameters>
        <asp:Parameter Name="NUME_FICH" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="NUME_FICH" Type="Decimal" />
        <asp:Parameter Name="ID_ENTREVISTADOR" Type="Decimal" />
        <asp:Parameter Name="NOMB_CASERIO_AUP" Type="String" />
        <asp:Parameter Name="FECHA_ING_FICHA" Type="DateTime" />
        <asp:Parameter Name="CODIGO_PROYECTO" Type="String" />
        <asp:Parameter Name="PRIMER_NOMBRE" Type="String" />
        <asp:Parameter Name="SEGUNDO_NOMBRE" Type="String" />
        <asp:Parameter Name="TERCER_NOMBRE" Type="String" />
        <asp:Parameter Name="PRIMER_APELLIDO" Type="String" />
        <asp:Parameter Name="SEGUNDO_APELLIDO" Type="String" />
        <asp:Parameter Name="TERCER_APELLIDO" Type="String" />
        <asp:Parameter Name="ES_SALVADORENO" Type="Decimal" />
        <asp:Parameter Name="PAIS" Type="Decimal" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="CEDULA_IDENTIDAD" Type="String" />
        <asp:Parameter Name="CARNET_MINORIDAD" Type="String" />
        <asp:Parameter Name="PASAPORTE" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_NACIMIENTO" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NACIMIENTO" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="SEXO" Type="Decimal" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_DE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="ESTADO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="PERSONAS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_SE_DEDICA" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_RESIDENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_RESIDENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_FIJO" Type="String" />
        <asp:Parameter Name="TELEFONO_MOVIL" Type="String" />
        <asp:Parameter Name="CORREO_ELECTRONICO" Type="String" />
        <asp:Parameter Name="DISCAPACITADO_PERMANENTE" Type="Decimal" />
        <asp:Parameter Name="DISCAP_MOVERSE_CAMINAR" Type="Decimal" />
        <asp:Parameter Name="DISCAP_USAR_BRAZOS" Type="Decimal" />
        <asp:Parameter Name="DISCAP_VER" Type="Decimal" />
        <asp:Parameter Name="DISCAP_OIR" Type="Decimal" />
        <asp:Parameter Name="DISCAP_HABLAR" Type="Decimal" />
        <asp:Parameter Name="DISCAP_RETRASO" Type="Decimal" />
        <asp:Parameter Name="DISCAP_BANARSE" Type="Decimal" />
        <asp:Parameter Name="DISCAP_EXPLIQUE" Type="String" />
        <asp:Parameter Name="SABE_LEER_ESCRIBIR" Type="Decimal" />
        <asp:Parameter Name="SOLO_LEE" Type="Decimal" />
        <asp:Parameter Name="SOLO_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="SOLO_FIRMA" Type="Decimal" />
        <asp:Parameter Name="EDUCACION_BASICA" Type="Decimal" />
        <asp:Parameter Name="BACHILLERATO" Type="Decimal" />
        <asp:Parameter Name="TECNOLOGICA" Type="Decimal" />
        <asp:Parameter Name="UNIVERSITARIA" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_OBTENIDO" Type="String" />
        <asp:Parameter Name="HA_DEJADO_DE_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="HA_RECIBIDO_CURSOS" Type="Decimal" />
        <asp:Parameter Name="CURSO_1" Type="String" />
        <asp:Parameter Name="CURSO_2" Type="String" />
        <asp:Parameter Name="CURSO_3" Type="String" />
        <asp:Parameter Name="IMPARTIO_INSAFORP_CURSO_1" Type="Decimal" />
        <asp:Parameter Name="IMPARTIO_INSAFORP_CURSO_2" Type="Decimal" />
        <asp:Parameter Name="IMPARTIO_INSAFORP_CURSO_3" Type="Decimal" />
        <asp:Parameter Name="ANO_CURSO_1" Type="Decimal" />
        <asp:Parameter Name="ANO_CURSO_2" Type="Decimal" />
        <asp:Parameter Name="ANO_CURSO_3" Type="Decimal" />
        <asp:Parameter Name="CURSO_LE_DIO_BENEFICIOS_1" Type="Decimal" />
        <asp:Parameter Name="CURSO_LE_DIO_BENEFICIOS_2" Type="Decimal" />
        <asp:Parameter Name="CURSO_LE_DIO_BENEFICIOS_3" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_OTROS_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_PROMOCION" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_OTRO" Type="String" />
        <asp:Parameter Name="PORQUE_NO_RECIB_BENEFICIO" Type="String" />
        <asp:Parameter Name="REALIZA_ACTIVIDAD_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MEDIO_DE_INGRESO" Type="Decimal" />
        <asp:Parameter Name="ACT_INGRESOS" Type="String" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_OFICIOS_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_OTRA" Type="String" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_TIEMPO_COMP" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_NEG_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_MEDIO_TIEMPO" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_POR_HORAS" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_TEMPORAL" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="HA_TRABAJADO_ANTES" Type="Decimal" />
        <asp:Parameter Name="TIEMPO_QUE_NO_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_EMPRESA_ANTERIOR" Type="String" />
        <asp:Parameter Name="DEDICACION_EMPRESA" Type="String" />
        <%--<asp:Parameter Name="MOTIVO_SALIDA_EMPRESA" Type="Decimal" />--%>
        <asp:Parameter Name="MOTIVO_SALIDA_EMPRESA_OTRAS" Type="String" />
        <asp:Parameter Name="PUESTO_EMPRESA" Type="String" />
        <asp:Parameter Name="TIEMPO_TRABAJO_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_TRAB_ACT" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_TRAB_ACT_REM" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_OTRA" Type="String" />
        <asp:Parameter Name="INGRESO_PERSONAL_MENSUAL" Type="Decimal" />
        <asp:Parameter Name="INGRESO_PERSONAL_DIARIO" Type="Decimal" />
        <asp:Parameter Name="QUE_GUSTARIA_APRENDER_1" Type="String" />
        <asp:Parameter Name="QUE_GUSTARIA_APRENDER_2" Type="String" />
        <asp:Parameter Name="QUE_GUSTARIA_APRENDER_3" Type="String" />
        <asp:Parameter Name="LOGROS_ESPERADOS_EMPLEO_FORMAL" Type="Decimal" />
        <asp:Parameter Name="LOGROS_ESPERADOS_CUENTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="LOGROS_ESPERADOS_OTRO" Type="String" />
        <asp:Parameter Name="GUSTO_UBICACION_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_AYUDAR" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_INDEPEND" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_MANT_HIJOS" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_MANT_PADRES" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_PAGAR_ESTUD" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_OTRO" Type="String" />
        <asp:Parameter Name="NOMBRES_CONOCIDO" Type="String" />
        <asp:Parameter Name="PARENTESCO" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_CONOCIDO" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_CONOCIDO" Type="String" />
        <asp:Parameter Name="MUNICIPIO_CONOCIDO" Type="String" />
        <asp:Parameter Name="TELEFONO_FIJO_CONOCIDO" Type="String" />
        <asp:Parameter Name="TELEFONO_MOVIL_CONOCIDO" Type="String" />
        <asp:Parameter Name="EMAIL_CONOCIDO" Type="String" />
        <asp:Parameter Name="OBSERVACIONES_SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="NUME_FICH" Type="Decimal" />
        <asp:Parameter Name="ID_ENTREVISTADOR" Type="Decimal" />
        <asp:Parameter Name="NOMB_CASERIO_AUP" Type="String" />
        <asp:Parameter Name="FECHA_ING_FICHA" Type="DateTime" />
        <asp:Parameter Name="CODIGO_PROYECTO" Type="String" />
        <asp:Parameter Name="PRIMER_NOMBRE" Type="String" />
        <asp:Parameter Name="SEGUNDO_NOMBRE" Type="String" />
        <asp:Parameter Name="TERCER_NOMBRE" Type="String" />
        <asp:Parameter Name="PRIMER_APELLIDO" Type="String" />
        <asp:Parameter Name="SEGUNDO_APELLIDO" Type="String" />
        <asp:Parameter Name="TERCER_APELLIDO" Type="String" />
        <asp:Parameter Name="ES_SALVADORENO" Type="Decimal" />
        <asp:Parameter Name="PAIS" Type="Decimal" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="CEDULA_IDENTIDAD" Type="String" />
        <asp:Parameter Name="CARNET_MINORIDAD" Type="String" />
        <asp:Parameter Name="PASAPORTE" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_NACIMIENTO" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NACIMIENTO" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="SEXO" Type="Decimal" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_DE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="ESTADO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="PERSONAS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_SE_DEDICA" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_RESIDENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_RESIDENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_FIJO" Type="String" />
        <asp:Parameter Name="TELEFONO_MOVIL" Type="String" />
        <asp:Parameter Name="CORREO_ELECTRONICO" Type="String" />
        <asp:Parameter Name="DISCAPACITADO_PERMANENTE" Type="Decimal" />
        <asp:Parameter Name="DISCAP_MOVERSE_CAMINAR" Type="Decimal" />
        <asp:Parameter Name="DISCAP_USAR_BRAZOS" Type="Decimal" />
        <asp:Parameter Name="DISCAP_VER" Type="Decimal" />
        <asp:Parameter Name="DISCAP_OIR" Type="Decimal" />
        <asp:Parameter Name="DISCAP_HABLAR" Type="Decimal" />
        <asp:Parameter Name="DISCAP_RETRASO" Type="Decimal" />
        <asp:Parameter Name="DISCAP_BANARSE" Type="Decimal" />
        <asp:Parameter Name="DISCAP_EXPLIQUE" Type="String" />
        <asp:Parameter Name="SABE_LEER_ESCRIBIR" Type="Decimal" />
        <asp:Parameter Name="SOLO_LEE" Type="Decimal" />
        <asp:Parameter Name="SOLO_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="SOLO_FIRMA" Type="Decimal" />
        <asp:Parameter Name="EDUCACION_BASICA" Type="Decimal" />
        <asp:Parameter Name="BACHILLERATO" Type="Decimal" />
        <asp:Parameter Name="TECNOLOGICA" Type="Decimal" />
        <asp:Parameter Name="UNIVERSITARIA" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_OBTENIDO" Type="String" />
        <asp:Parameter Name="HA_DEJADO_DE_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="HA_RECIBIDO_CURSOS" Type="Decimal" />
        <asp:Parameter Name="CURSO_1" Type="String" />
        <asp:Parameter Name="CURSO_2" Type="String" />
        <asp:Parameter Name="CURSO_3" Type="String" />
        <asp:Parameter Name="IMPARTIO_INSAFORP_CURSO_1" Type="Decimal" />
        <asp:Parameter Name="IMPARTIO_INSAFORP_CURSO_2" Type="Decimal" />
        <asp:Parameter Name="IMPARTIO_INSAFORP_CURSO_3" Type="Decimal" />
        <asp:Parameter Name="ANO_CURSO_1" Type="Decimal" />
        <asp:Parameter Name="ANO_CURSO_2" Type="Decimal" />
        <asp:Parameter Name="ANO_CURSO_3" Type="Decimal" />
        <asp:Parameter Name="CURSO_LE_DIO_BENEFICIOS_1" Type="Decimal" />
        <asp:Parameter Name="CURSO_LE_DIO_BENEFICIOS_2" Type="Decimal" />
        <asp:Parameter Name="CURSO_LE_DIO_BENEFICIOS_3" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_OTROS_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_PROMOCION" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_OTRO" Type="String" />
        <asp:Parameter Name="PORQUE_NO_RECIB_BENEFICIO" Type="String" />
        <asp:Parameter Name="REALIZA_ACTIVIDAD_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MEDIO_DE_INGRESO" Type="Decimal" />
        <asp:Parameter Name="ACT_INGRESOS" Type="String" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_OFICIOS_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_OTRA" Type="String" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_TIEMPO_COMP" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_NEG_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_MEDIO_TIEMPO" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_POR_HORAS" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_TEMPORAL" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="HA_TRABAJADO_ANTES" Type="Decimal" />
        <asp:Parameter Name="TIEMPO_QUE_NO_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_EMPRESA_ANTERIOR" Type="String" />
        <asp:Parameter Name="DEDICACION_EMPRESA" Type="String" />
        <%--<asp:Parameter Name="MOTIVO_SALIDA_EMPRESA" Type="Decimal" />--%>
        <asp:Parameter Name="MOTIVO_SALIDA_EMPRESA_OTRAS" Type="String" />
        <asp:Parameter Name="PUESTO_EMPRESA" Type="String" />
        <asp:Parameter Name="TIEMPO_TRABAJO_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_TRAB_ACT" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_TRAB_ACT_REM" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_OTRA" Type="String" />
        <asp:Parameter Name="INGRESO_PERSONAL_MENSUAL" Type="Decimal" />
        <asp:Parameter Name="INGRESO_PERSONAL_DIARIO" Type="Decimal" />
        <asp:Parameter Name="QUE_GUSTARIA_APRENDER_1" Type="String" />
        <asp:Parameter Name="QUE_GUSTARIA_APRENDER_2" Type="String" />
        <asp:Parameter Name="QUE_GUSTARIA_APRENDER_3" Type="String" />
        <asp:Parameter Name="LOGROS_ESPERADOS_EMPLEO_FORMAL" Type="Decimal" />
        <asp:Parameter Name="LOGROS_ESPERADOS_CUENTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="LOGROS_ESPERADOS_OTRO" Type="String" />
        <asp:Parameter Name="GUSTO_UBICACION_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_AYUDAR" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_INDEPEND" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_MANT_HIJOS" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_MANT_PADRES" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_PAGAR_ESTUD" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_OTRO" Type="String" />
        <asp:Parameter Name="NOMBRES_CONOCIDO" Type="String" />
        <asp:Parameter Name="PARENTESCO" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_CONOCIDO" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_CONOCIDO" Type="String" />
        <asp:Parameter Name="MUNICIPIO_CONOCIDO" Type="String" />
        <asp:Parameter Name="TELEFONO_FIJO_CONOCIDO" Type="String" />
        <asp:Parameter Name="TELEFONO_MOVIL_CONOCIDO" Type="String" />
        <asp:Parameter Name="EMAIL_CONOCIDO" Type="String" />
        <asp:Parameter Name="OBSERVACIONES_SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="NUME_FICH" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorENTREVISTADORES_PATI" runat="server" 
    SelectMethod="ObtenerListaPorENTREVISTADORES_PATI" InsertMethod="AgregarFICHA_PATI" DeleteMethod="EliminarFICHA_PATI" UpdateMethod="ActualizarFICHA_PATI"
    TypeName="PATI.BL.cFICHA_PATI">
    <SelectParameters>
        <asp:Parameter Name="ID_ENTREVISTADOR" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="NUME_FICH" Type="Decimal" />
        <asp:Parameter Name="ID_ENTREVISTADOR" Type="Decimal" />
        <asp:Parameter Name="NOMB_CASERIO_AUP" Type="String" />
        <asp:Parameter Name="FECHA_ING_FICHA" Type="DateTime" />
        <asp:Parameter Name="CODIGO_PROYECTO" Type="String" />
        <asp:Parameter Name="PRIMER_NOMBRE" Type="String" />
        <asp:Parameter Name="SEGUNDO_NOMBRE" Type="String" />
        <asp:Parameter Name="TERCER_NOMBRE" Type="String" />
        <asp:Parameter Name="PRIMER_APELLIDO" Type="String" />
        <asp:Parameter Name="SEGUNDO_APELLIDO" Type="String" />
        <asp:Parameter Name="TERCER_APELLIDO" Type="String" />
        <asp:Parameter Name="ES_SALVADORENO" Type="Decimal" />
        <asp:Parameter Name="PAIS" Type="Decimal" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="CEDULA_IDENTIDAD" Type="String" />
        <asp:Parameter Name="CARNET_MINORIDAD" Type="String" />
        <asp:Parameter Name="PASAPORTE" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_NACIMIENTO" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NACIMIENTO" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="SEXO" Type="Decimal" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_DE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="ESTADO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="PERSONAS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_SE_DEDICA" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_RESIDENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_RESIDENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_FIJO" Type="String" />
        <asp:Parameter Name="TELEFONO_MOVIL" Type="String" />
        <asp:Parameter Name="CORREO_ELECTRONICO" Type="String" />
        <asp:Parameter Name="DISCAPACITADO_PERMANENTE" Type="Decimal" />
        <asp:Parameter Name="DISCAP_MOVERSE_CAMINAR" Type="Decimal" />
        <asp:Parameter Name="DISCAP_USAR_BRAZOS" Type="Decimal" />
        <asp:Parameter Name="DISCAP_VER" Type="Decimal" />
        <asp:Parameter Name="DISCAP_OIR" Type="Decimal" />
        <asp:Parameter Name="DISCAP_HABLAR" Type="Decimal" />
        <asp:Parameter Name="DISCAP_RETRASO" Type="Decimal" />
        <asp:Parameter Name="DISCAP_BANARSE" Type="Decimal" />
        <asp:Parameter Name="DISCAP_EXPLIQUE" Type="String" />
        <asp:Parameter Name="SABE_LEER_ESCRIBIR" Type="Decimal" />
        <asp:Parameter Name="SOLO_LEE" Type="Decimal" />
        <asp:Parameter Name="SOLO_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="SOLO_FIRMA" Type="Decimal" />
        <asp:Parameter Name="EDUCACION_BASICA" Type="Decimal" />
        <asp:Parameter Name="BACHILLERATO" Type="Decimal" />
        <asp:Parameter Name="TECNOLOGICA" Type="Decimal" />
        <asp:Parameter Name="UNIVERSITARIA" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_OBTENIDO" Type="String" />
        <asp:Parameter Name="HA_DEJADO_DE_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="HA_RECIBIDO_CURSOS" Type="Decimal" />
        <asp:Parameter Name="CURSO_1" Type="String" />
        <asp:Parameter Name="CURSO_2" Type="String" />
        <asp:Parameter Name="CURSO_3" Type="String" />
        <asp:Parameter Name="IMPARTIO_INSAFORP_CURSO_1" Type="Decimal" />
        <asp:Parameter Name="IMPARTIO_INSAFORP_CURSO_2" Type="Decimal" />
        <asp:Parameter Name="IMPARTIO_INSAFORP_CURSO_3" Type="Decimal" />
        <asp:Parameter Name="ANO_CURSO_1" Type="Decimal" />
        <asp:Parameter Name="ANO_CURSO_2" Type="Decimal" />
        <asp:Parameter Name="ANO_CURSO_3" Type="Decimal" />
        <asp:Parameter Name="CURSO_LE_DIO_BENEFICIOS_1" Type="Decimal" />
        <asp:Parameter Name="CURSO_LE_DIO_BENEFICIOS_2" Type="Decimal" />
        <asp:Parameter Name="CURSO_LE_DIO_BENEFICIOS_3" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_OTROS_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_PROMOCION" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_OTRO" Type="String" />
        <asp:Parameter Name="PORQUE_NO_RECIB_BENEFICIO" Type="String" />
        <asp:Parameter Name="REALIZA_ACTIVIDAD_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MEDIO_DE_INGRESO" Type="Decimal" />
        <asp:Parameter Name="ACT_INGRESOS" Type="String" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_OFICIOS_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_OTRA" Type="String" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_TIEMPO_COMP" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_NEG_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_MEDIO_TIEMPO" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_POR_HORAS" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_TEMPORAL" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="HA_TRABAJADO_ANTES" Type="Decimal" />
        <asp:Parameter Name="TIEMPO_QUE_NO_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_EMPRESA_ANTERIOR" Type="String" />
        <asp:Parameter Name="DEDICACION_EMPRESA" Type="String" />
        <%--<asp:Parameter Name="MOTIVO_SALIDA_EMPRESA" Type="Decimal" />--%>
        <asp:Parameter Name="MOTIVO_SALIDA_EMPRESA_OTRAS" Type="String" />
        <asp:Parameter Name="PUESTO_EMPRESA" Type="String" />
        <asp:Parameter Name="TIEMPO_TRABAJO_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_TRAB_ACT" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_TRAB_ACT_REM" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_OTRA" Type="String" />
        <asp:Parameter Name="INGRESO_PERSONAL_MENSUAL" Type="Decimal" />
        <asp:Parameter Name="INGRESO_PERSONAL_DIARIO" Type="Decimal" />
        <asp:Parameter Name="QUE_GUSTARIA_APRENDER_1" Type="String" />
        <asp:Parameter Name="QUE_GUSTARIA_APRENDER_2" Type="String" />
        <asp:Parameter Name="QUE_GUSTARIA_APRENDER_3" Type="String" />
        <asp:Parameter Name="LOGROS_ESPERADOS_EMPLEO_FORMAL" Type="Decimal" />
        <asp:Parameter Name="LOGROS_ESPERADOS_CUENTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="LOGROS_ESPERADOS_OTRO" Type="String" />
        <asp:Parameter Name="GUSTO_UBICACION_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_AYUDAR" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_INDEPEND" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_MANT_HIJOS" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_MANT_PADRES" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_PAGAR_ESTUD" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_OTRO" Type="String" />
        <asp:Parameter Name="NOMBRES_CONOCIDO" Type="String" />
        <asp:Parameter Name="PARENTESCO" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_CONOCIDO" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_CONOCIDO" Type="String" />
        <asp:Parameter Name="MUNICIPIO_CONOCIDO" Type="String" />
        <asp:Parameter Name="TELEFONO_FIJO_CONOCIDO" Type="String" />
        <asp:Parameter Name="TELEFONO_MOVIL_CONOCIDO" Type="String" />
        <asp:Parameter Name="EMAIL_CONOCIDO" Type="String" />
        <asp:Parameter Name="OBSERVACIONES_SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="NUME_FICH" Type="Decimal" />
        <asp:Parameter Name="ID_ENTREVISTADOR" Type="Decimal" />
        <asp:Parameter Name="NOMB_CASERIO_AUP" Type="String" />
        <asp:Parameter Name="FECHA_ING_FICHA" Type="DateTime" />
        <asp:Parameter Name="CODIGO_PROYECTO" Type="String" />
        <asp:Parameter Name="PRIMER_NOMBRE" Type="String" />
        <asp:Parameter Name="SEGUNDO_NOMBRE" Type="String" />
        <asp:Parameter Name="TERCER_NOMBRE" Type="String" />
        <asp:Parameter Name="PRIMER_APELLIDO" Type="String" />
        <asp:Parameter Name="SEGUNDO_APELLIDO" Type="String" />
        <asp:Parameter Name="TERCER_APELLIDO" Type="String" />
        <asp:Parameter Name="ES_SALVADORENO" Type="Decimal" />
        <asp:Parameter Name="PAIS" Type="Decimal" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="CEDULA_IDENTIDAD" Type="String" />
        <asp:Parameter Name="CARNET_MINORIDAD" Type="String" />
        <asp:Parameter Name="PASAPORTE" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_NACIMIENTO" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NACIMIENTO" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="SEXO" Type="Decimal" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_DE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="ESTADO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="PERSONAS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_SE_DEDICA" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_RESIDENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_RESIDENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_FIJO" Type="String" />
        <asp:Parameter Name="TELEFONO_MOVIL" Type="String" />
        <asp:Parameter Name="CORREO_ELECTRONICO" Type="String" />
        <asp:Parameter Name="DISCAPACITADO_PERMANENTE" Type="Decimal" />
        <asp:Parameter Name="DISCAP_MOVERSE_CAMINAR" Type="Decimal" />
        <asp:Parameter Name="DISCAP_USAR_BRAZOS" Type="Decimal" />
        <asp:Parameter Name="DISCAP_VER" Type="Decimal" />
        <asp:Parameter Name="DISCAP_OIR" Type="Decimal" />
        <asp:Parameter Name="DISCAP_HABLAR" Type="Decimal" />
        <asp:Parameter Name="DISCAP_RETRASO" Type="Decimal" />
        <asp:Parameter Name="DISCAP_BANARSE" Type="Decimal" />
        <asp:Parameter Name="DISCAP_EXPLIQUE" Type="String" />
        <asp:Parameter Name="SABE_LEER_ESCRIBIR" Type="Decimal" />
        <asp:Parameter Name="SOLO_LEE" Type="Decimal" />
        <asp:Parameter Name="SOLO_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="SOLO_FIRMA" Type="Decimal" />
        <asp:Parameter Name="EDUCACION_BASICA" Type="Decimal" />
        <asp:Parameter Name="BACHILLERATO" Type="Decimal" />
        <asp:Parameter Name="TECNOLOGICA" Type="Decimal" />
        <asp:Parameter Name="UNIVERSITARIA" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_OBTENIDO" Type="String" />
        <asp:Parameter Name="HA_DEJADO_DE_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="HA_RECIBIDO_CURSOS" Type="Decimal" />
        <asp:Parameter Name="CURSO_1" Type="String" />
        <asp:Parameter Name="CURSO_2" Type="String" />
        <asp:Parameter Name="CURSO_3" Type="String" />
        <asp:Parameter Name="IMPARTIO_INSAFORP_CURSO_1" Type="Decimal" />
        <asp:Parameter Name="IMPARTIO_INSAFORP_CURSO_2" Type="Decimal" />
        <asp:Parameter Name="IMPARTIO_INSAFORP_CURSO_3" Type="Decimal" />
        <asp:Parameter Name="ANO_CURSO_1" Type="Decimal" />
        <asp:Parameter Name="ANO_CURSO_2" Type="Decimal" />
        <asp:Parameter Name="ANO_CURSO_3" Type="Decimal" />
        <asp:Parameter Name="CURSO_LE_DIO_BENEFICIOS_1" Type="Decimal" />
        <asp:Parameter Name="CURSO_LE_DIO_BENEFICIOS_2" Type="Decimal" />
        <asp:Parameter Name="CURSO_LE_DIO_BENEFICIOS_3" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_OTROS_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_PROMOCION" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_OTRO" Type="String" />
        <asp:Parameter Name="PORQUE_NO_RECIB_BENEFICIO" Type="String" />
        <asp:Parameter Name="REALIZA_ACTIVIDAD_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MEDIO_DE_INGRESO" Type="Decimal" />
        <asp:Parameter Name="ACT_INGRESOS" Type="String" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_OFICIOS_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_OTRA" Type="String" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_TIEMPO_COMP" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_NEG_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_MEDIO_TIEMPO" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_POR_HORAS" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_TEMPORAL" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="HA_TRABAJADO_ANTES" Type="Decimal" />
        <asp:Parameter Name="TIEMPO_QUE_NO_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_EMPRESA_ANTERIOR" Type="String" />
        <asp:Parameter Name="DEDICACION_EMPRESA" Type="String" />
        <%--<asp:Parameter Name="MOTIVO_SALIDA_EMPRESA" Type="Decimal" />--%>
        <asp:Parameter Name="MOTIVO_SALIDA_EMPRESA_OTRAS" Type="String" />
        <asp:Parameter Name="PUESTO_EMPRESA" Type="String" />
        <asp:Parameter Name="TIEMPO_TRABAJO_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_TRAB_ACT" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_TRAB_ACT_REM" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_OTRA" Type="String" />
        <asp:Parameter Name="INGRESO_PERSONAL_MENSUAL" Type="Decimal" />
        <asp:Parameter Name="INGRESO_PERSONAL_DIARIO" Type="Decimal" />
        <asp:Parameter Name="QUE_GUSTARIA_APRENDER_1" Type="String" />
        <asp:Parameter Name="QUE_GUSTARIA_APRENDER_2" Type="String" />
        <asp:Parameter Name="QUE_GUSTARIA_APRENDER_3" Type="String" />
        <asp:Parameter Name="LOGROS_ESPERADOS_EMPLEO_FORMAL" Type="Decimal" />
        <asp:Parameter Name="LOGROS_ESPERADOS_CUENTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="LOGROS_ESPERADOS_OTRO" Type="String" />
        <asp:Parameter Name="GUSTO_UBICACION_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_AYUDAR" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_INDEPEND" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_MANT_HIJOS" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_MANT_PADRES" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_PAGAR_ESTUD" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_OTRO" Type="String" />
        <asp:Parameter Name="NOMBRES_CONOCIDO" Type="String" />
        <asp:Parameter Name="PARENTESCO" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_CONOCIDO" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_CONOCIDO" Type="String" />
        <asp:Parameter Name="MUNICIPIO_CONOCIDO" Type="String" />
        <asp:Parameter Name="TELEFONO_FIJO_CONOCIDO" Type="String" />
        <asp:Parameter Name="TELEFONO_MOVIL_CONOCIDO" Type="String" />
        <asp:Parameter Name="EMAIL_CONOCIDO" Type="String" />
        <asp:Parameter Name="OBSERVACIONES_SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="NUME_FICH" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorMunicipioResidencia" runat="server" 
    SelectMethod="ObtenerListaPorMunicipioResidencia" 
    InsertMethod="AgregarFICHA_PATI" DeleteMethod="EliminarFICHA_PATI" UpdateMethod="ActualizarFICHA_PATI"
    TypeName="PATI.BL.cFICHA_PATI" 
    OldValuesParameterFormatString="original_{0}">
    <SelectParameters>
        <asp:Parameter Name="DEPARTAMENTO_RESIDENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_RESIDENCIA" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="NUME_FICH" Type="Decimal" />
        <asp:Parameter Name="ID_ENTREVISTADOR" Type="Decimal" />
        <asp:Parameter Name="NOMB_CASERIO_AUP" Type="String" />
        <asp:Parameter Name="FECHA_ING_FICHA" Type="DateTime" />
        <asp:Parameter Name="CODIGO_PROYECTO" Type="String" />
        <asp:Parameter Name="PRIMER_NOMBRE" Type="String" />
        <asp:Parameter Name="SEGUNDO_NOMBRE" Type="String" />
        <asp:Parameter Name="TERCER_NOMBRE" Type="String" />
        <asp:Parameter Name="PRIMER_APELLIDO" Type="String" />
        <asp:Parameter Name="SEGUNDO_APELLIDO" Type="String" />
        <asp:Parameter Name="TERCER_APELLIDO" Type="String" />
        <asp:Parameter Name="ES_SALVADORENO" Type="Decimal" />
        <asp:Parameter Name="PAIS" Type="Decimal" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="CEDULA_IDENTIDAD" Type="String" />
        <asp:Parameter Name="CARNET_MINORIDAD" Type="String" />
        <asp:Parameter Name="PASAPORTE" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_NACIMIENTO" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NACIMIENTO" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="SEXO" Type="Decimal" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_DE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="ESTADO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="PERSONAS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_SE_DEDICA" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_RESIDENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_RESIDENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_FIJO" Type="String" />
        <asp:Parameter Name="TELEFONO_MOVIL" Type="String" />
        <asp:Parameter Name="CORREO_ELECTRONICO" Type="String" />
        <asp:Parameter Name="DISCAPACITADO_PERMANENTE" Type="Decimal" />
        <asp:Parameter Name="DISCAP_MOVERSE_CAMINAR" Type="Decimal" />
        <asp:Parameter Name="DISCAP_USAR_BRAZOS" Type="Decimal" />
        <asp:Parameter Name="DISCAP_VER" Type="Decimal" />
        <asp:Parameter Name="DISCAP_OIR" Type="Decimal" />
        <asp:Parameter Name="DISCAP_HABLAR" Type="Decimal" />
        <asp:Parameter Name="DISCAP_RETRASO" Type="Decimal" />
        <asp:Parameter Name="DISCAP_BANARSE" Type="Decimal" />
        <asp:Parameter Name="DISCAP_EXPLIQUE" Type="String" />
        <asp:Parameter Name="SABE_LEER_ESCRIBIR" Type="Decimal" />
        <asp:Parameter Name="SOLO_LEE" Type="Decimal" />
        <asp:Parameter Name="SOLO_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="SOLO_FIRMA" Type="Decimal" />
        <asp:Parameter Name="EDUCACION_BASICA" Type="Decimal" />
        <asp:Parameter Name="BACHILLERATO" Type="Decimal" />
        <asp:Parameter Name="TECNOLOGICA" Type="Decimal" />
        <asp:Parameter Name="UNIVERSITARIA" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_OBTENIDO" Type="String" />
        <asp:Parameter Name="HA_DEJADO_DE_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="HA_RECIBIDO_CURSOS" Type="Decimal" />
        <asp:Parameter Name="CURSO_1" Type="String" />
        <asp:Parameter Name="CURSO_2" Type="String" />
        <asp:Parameter Name="CURSO_3" Type="String" />
        <asp:Parameter Name="IMPARTIO_INSAFORP_CURSO_1" Type="Decimal" />
        <asp:Parameter Name="IMPARTIO_INSAFORP_CURSO_2" Type="Decimal" />
        <asp:Parameter Name="IMPARTIO_INSAFORP_CURSO_3" Type="Decimal" />
        <asp:Parameter Name="ANO_CURSO_1" Type="Decimal" />
        <asp:Parameter Name="ANO_CURSO_2" Type="Decimal" />
        <asp:Parameter Name="ANO_CURSO_3" Type="Decimal" />
        <asp:Parameter Name="CURSO_LE_DIO_BENEFICIOS_1" Type="Decimal" />
        <asp:Parameter Name="CURSO_LE_DIO_BENEFICIOS_2" Type="Decimal" />
        <asp:Parameter Name="CURSO_LE_DIO_BENEFICIOS_3" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_OTROS_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_PROMOCION" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_OTRO" Type="String" />
        <asp:Parameter Name="PORQUE_NO_RECIB_BENEFICIO" Type="String" />
        <asp:Parameter Name="REALIZA_ACTIVIDAD_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MEDIO_DE_INGRESO" Type="Decimal" />
        <asp:Parameter Name="ACT_INGRESOS" Type="String" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_OFICIOS_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_OTRA" Type="String" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_TIEMPO_COMP" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_NEG_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_MEDIO_TIEMPO" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_POR_HORAS" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_TEMPORAL" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="HA_TRABAJADO_ANTES" Type="Decimal" />
        <asp:Parameter Name="TIEMPO_QUE_NO_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_EMPRESA_ANTERIOR" Type="String" />
        <asp:Parameter Name="DEDICACION_EMPRESA" Type="String" />
        <%--<asp:Parameter Name="MOTIVO_SALIDA_EMPRESA" Type="Decimal" />--%>
        <asp:Parameter Name="MOTIVO_SALIDA_EMPRESA_OTRAS" Type="String" />
        <asp:Parameter Name="PUESTO_EMPRESA" Type="String" />
        <asp:Parameter Name="TIEMPO_TRABAJO_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_TRAB_ACT" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_TRAB_ACT_REM" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_OTRA" Type="String" />
        <asp:Parameter Name="INGRESO_PERSONAL_MENSUAL" Type="Decimal" />
        <asp:Parameter Name="INGRESO_PERSONAL_DIARIO" Type="Decimal" />
        <asp:Parameter Name="QUE_GUSTARIA_APRENDER_1" Type="String" />
        <asp:Parameter Name="QUE_GUSTARIA_APRENDER_2" Type="String" />
        <asp:Parameter Name="QUE_GUSTARIA_APRENDER_3" Type="String" />
        <asp:Parameter Name="LOGROS_ESPERADOS_EMPLEO_FORMAL" Type="Decimal" />
        <asp:Parameter Name="LOGROS_ESPERADOS_CUENTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="LOGROS_ESPERADOS_OTRO" Type="String" />
        <asp:Parameter Name="GUSTO_UBICACION_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_AYUDAR" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_INDEPEND" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_MANT_HIJOS" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_MANT_PADRES" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_PAGAR_ESTUD" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_OTRO" Type="String" />
        <asp:Parameter Name="NOMBRES_CONOCIDO" Type="String" />
        <asp:Parameter Name="PARENTESCO" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_CONOCIDO" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_CONOCIDO" Type="String" />
        <asp:Parameter Name="MUNICIPIO_CONOCIDO" Type="String" />
        <asp:Parameter Name="TELEFONO_FIJO_CONOCIDO" Type="String" />
        <asp:Parameter Name="TELEFONO_MOVIL_CONOCIDO" Type="String" />
        <asp:Parameter Name="EMAIL_CONOCIDO" Type="String" />
        <asp:Parameter Name="OBSERVACIONES_SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="NUME_FICH" Type="Decimal" />
        <asp:Parameter Name="ID_ENTREVISTADOR" Type="Decimal" />
        <asp:Parameter Name="NOMB_CASERIO_AUP" Type="String" />
        <asp:Parameter Name="FECHA_ING_FICHA" Type="DateTime" />
        <asp:Parameter Name="CODIGO_PROYECTO" Type="String" />
        <asp:Parameter Name="PRIMER_NOMBRE" Type="String" />
        <asp:Parameter Name="SEGUNDO_NOMBRE" Type="String" />
        <asp:Parameter Name="TERCER_NOMBRE" Type="String" />
        <asp:Parameter Name="PRIMER_APELLIDO" Type="String" />
        <asp:Parameter Name="SEGUNDO_APELLIDO" Type="String" />
        <asp:Parameter Name="TERCER_APELLIDO" Type="String" />
        <asp:Parameter Name="ES_SALVADORENO" Type="Decimal" />
        <asp:Parameter Name="PAIS" Type="Decimal" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="CEDULA_IDENTIDAD" Type="String" />
        <asp:Parameter Name="CARNET_MINORIDAD" Type="String" />
        <asp:Parameter Name="PASAPORTE" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_NACIMIENTO" Type="String" />
        <asp:Parameter Name="MUNICIPIO_NACIMIENTO" Type="String" />
        <asp:Parameter Name="FECHA_NACIMIENTO" Type="DateTime" />
        <asp:Parameter Name="SEXO" Type="Decimal" />
        <asp:Parameter Name="EDAD" Type="Decimal" />
        <asp:Parameter Name="ES_JEFE_DE_HOGAR" Type="Decimal" />
        <asp:Parameter Name="ESTADO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="TIENE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="NO_DE_HIJOS" Type="Decimal" />
        <asp:Parameter Name="PERSONAS_GRUPO_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="SE_DEDICA_ALGUNA_PROFESION" Type="Decimal" />
        <asp:Parameter Name="PROFESION_SE_DEDICA" Type="String" />
        <asp:Parameter Name="DIRECCION" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_RESIDENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_RESIDENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_FIJO" Type="String" />
        <asp:Parameter Name="TELEFONO_MOVIL" Type="String" />
        <asp:Parameter Name="CORREO_ELECTRONICO" Type="String" />
        <asp:Parameter Name="DISCAPACITADO_PERMANENTE" Type="Decimal" />
        <asp:Parameter Name="DISCAP_MOVERSE_CAMINAR" Type="Decimal" />
        <asp:Parameter Name="DISCAP_USAR_BRAZOS" Type="Decimal" />
        <asp:Parameter Name="DISCAP_VER" Type="Decimal" />
        <asp:Parameter Name="DISCAP_OIR" Type="Decimal" />
        <asp:Parameter Name="DISCAP_HABLAR" Type="Decimal" />
        <asp:Parameter Name="DISCAP_RETRASO" Type="Decimal" />
        <asp:Parameter Name="DISCAP_BANARSE" Type="Decimal" />
        <asp:Parameter Name="DISCAP_EXPLIQUE" Type="String" />
        <asp:Parameter Name="SABE_LEER_ESCRIBIR" Type="Decimal" />
        <asp:Parameter Name="SOLO_LEE" Type="Decimal" />
        <asp:Parameter Name="SOLO_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="SOLO_FIRMA" Type="Decimal" />
        <asp:Parameter Name="EDUCACION_BASICA" Type="Decimal" />
        <asp:Parameter Name="BACHILLERATO" Type="Decimal" />
        <asp:Parameter Name="TECNOLOGICA" Type="Decimal" />
        <asp:Parameter Name="UNIVERSITARIA" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_OBTENIDO" Type="String" />
        <asp:Parameter Name="HA_DEJADO_DE_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter Name="HA_RECIBIDO_CURSOS" Type="Decimal" />
        <asp:Parameter Name="CURSO_1" Type="String" />
        <asp:Parameter Name="CURSO_2" Type="String" />
        <asp:Parameter Name="CURSO_3" Type="String" />
        <asp:Parameter Name="IMPARTIO_INSAFORP_CURSO_1" Type="Decimal" />
        <asp:Parameter Name="IMPARTIO_INSAFORP_CURSO_2" Type="Decimal" />
        <asp:Parameter Name="IMPARTIO_INSAFORP_CURSO_3" Type="Decimal" />
        <asp:Parameter Name="ANO_CURSO_1" Type="Decimal" />
        <asp:Parameter Name="ANO_CURSO_2" Type="Decimal" />
        <asp:Parameter Name="ANO_CURSO_3" Type="Decimal" />
        <asp:Parameter Name="CURSO_LE_DIO_BENEFICIOS_1" Type="Decimal" />
        <asp:Parameter Name="CURSO_LE_DIO_BENEFICIOS_2" Type="Decimal" />
        <asp:Parameter Name="CURSO_LE_DIO_BENEFICIOS_3" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_TRAB_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_OTROS_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_PROMOCION" Type="Decimal" />
        <asp:Parameter Name="SIRVIO_CAPAC_OTRO" Type="String" />
        <asp:Parameter Name="PORQUE_NO_RECIB_BENEFICIO" Type="String" />
        <asp:Parameter Name="REALIZA_ACTIVIDAD_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MEDIO_DE_INGRESO" Type="Decimal" />
        <asp:Parameter Name="ACT_INGRESOS" Type="String" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_ESTUDIA" Type="Decimal" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_OFICIOS_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OTRA_ACTIVIDAD_OTRA" Type="String" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_TIEMPO_COMP" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_NEG_FAMILIAR" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_MEDIO_TIEMPO" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_POR_HORAS" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_TEMPORAL" Type="Decimal" />
        <asp:Parameter Name="TIPO_DE_EMPLEO_OTRO" Type="String" />
        <asp:Parameter Name="HA_TRABAJADO_ANTES" Type="Decimal" />
        <asp:Parameter Name="TIEMPO_QUE_NO_TRABAJA" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_EMPRESA_ANTERIOR" Type="String" />
        <asp:Parameter Name="DEDICACION_EMPRESA" Type="String" />
        <%--<asp:Parameter Name="MOTIVO_SALIDA_EMPRESA" Type="Decimal" />--%>
        <asp:Parameter Name="MOTIVO_SALIDA_EMPRESA_OTRAS" Type="String" />
        <asp:Parameter Name="PUESTO_EMPRESA" Type="String" />
        <asp:Parameter Name="TIEMPO_TRABAJO_EMPRESA" Type="Decimal" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_TRAB_ACT" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_TRAB_ACT_REM" Type="Decimal" />
        <asp:Parameter Name="MAN_OBTIENE_ING_OTRA" Type="String" />
        <asp:Parameter Name="INGRESO_PERSONAL_MENSUAL" Type="Decimal" />
        <asp:Parameter Name="INGRESO_PERSONAL_DIARIO" Type="Decimal" />
        <asp:Parameter Name="QUE_GUSTARIA_APRENDER_1" Type="String" />
        <asp:Parameter Name="QUE_GUSTARIA_APRENDER_2" Type="String" />
        <asp:Parameter Name="QUE_GUSTARIA_APRENDER_3" Type="String" />
        <asp:Parameter Name="LOGROS_ESPERADOS_EMPLEO_FORMAL" Type="Decimal" />
        <asp:Parameter Name="LOGROS_ESPERADOS_CUENTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="LOGROS_ESPERADOS_OTRO" Type="String" />
        <asp:Parameter Name="GUSTO_UBICACION_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_AYUDAR" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_INDEPEND" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_MANT_HIJOS" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_MANT_PADRES" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_PAGAR_ESTUD" Type="Decimal" />
        <asp:Parameter Name="EN_QUE_OCUP_DINERO_OTRO" Type="String" />
        <asp:Parameter Name="NOMBRES_CONOCIDO" Type="String" />
        <asp:Parameter Name="PARENTESCO" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_CONOCIDO" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_CONOCIDO" Type="String" />
        <asp:Parameter Name="MUNICIPIO_CONOCIDO" Type="String" />
        <asp:Parameter Name="TELEFONO_FIJO_CONOCIDO" Type="String" />
        <asp:Parameter Name="TELEFONO_MOVIL_CONOCIDO" Type="String" />
        <asp:Parameter Name="EMAIL_CONOCIDO" Type="String" />
        <asp:Parameter Name="OBSERVACIONES_SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="NUME_FICH" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>