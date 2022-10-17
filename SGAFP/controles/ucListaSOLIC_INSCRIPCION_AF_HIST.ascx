<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaSOLIC_INSCRIPCION_AF_HIST.ascx.vb" Inherits="controles_ucListaSOLIC_INSCRIPCION_AF_HIST" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register src="ucVistaDetalleSOLIC_INSCRIPCION_AF_HIST.ascx" tagname="ucVistaDetalleSOLIC_INSCRIPCION_AF_HIST" tagprefix="uc1" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_SOLICITUD_HIST">
    <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
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
                    CommandArgument='<%# Bind("ID_SOLICITUD_HIST") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_SOLICITUD_HIST") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_SOLICITUD_HIST" ReadOnly="True" VisibleIndex="2" Caption="Id solicitud hist" />
        <dx:GridViewDataTextColumn FieldName="ID_SOLICITUD" VisibleIndex="3" Caption="Id solicitud" />
        <dx:GridViewDataTextColumn FieldName="FECHA_PRESENTACION" VisibleIndex="4" Caption="Fecha presentacion" />
        <dx:GridViewDataTextColumn FieldName="ID_PARTICIPANTE" VisibleIndex="5" Caption="Id participante" />
        <dx:GridViewDataTextColumn FieldName="ID_ACCION_FORMATIVA" VisibleIndex="6" Caption="Id accion formativa" />
        <dx:GridViewDataTextColumn FieldName="ID_ESTADO_SOLICITUD" VisibleIndex="7" Caption="Id estado solicitud" />
        <dx:GridViewDataTextColumn FieldName="NOMBRES" VisibleIndex="8" Caption="Nombres" />
        <dx:GridViewDataTextColumn FieldName="APELLIDOS" VisibleIndex="9" Caption="Apellidos" />
        <dx:GridViewDataTextColumn FieldName="DUI" VisibleIndex="10" Caption="Dui" />
        <dx:GridViewDataTextColumn FieldName="TIPO_DOCTO" VisibleIndex="11" Caption="Tipo docto" />
        <dx:GridViewDataTextColumn FieldName="NUM_DOCTO" VisibleIndex="12" Caption="Num docto" />
        <dx:GridViewDataTextColumn FieldName="NIT" VisibleIndex="13" Caption="Nit" />
        <dx:GridViewDataTextColumn FieldName="ISSS" VisibleIndex="14" Caption="Isss" />
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_SOLICITUD" VisibleIndex="15" Caption="Id tipo solicitud" />
        <dx:GridViewDataTextColumn FieldName="ID_PAIS" VisibleIndex="16" Caption="Id pais" />
        <dx:GridViewDataTextColumn FieldName="DEPARTAMENTO_NAC" VisibleIndex="17" Caption="Departamento nac" />
        <dx:GridViewDataTextColumn FieldName="MUNICIPIO_NAC" VisibleIndex="18" Caption="Municipio nac" />
        <dx:GridViewDataTextColumn FieldName="FECHA_NACIMIENTO" VisibleIndex="19" Caption="Fecha nacimiento" />
        <dx:GridViewDataTextColumn FieldName="GENERO" VisibleIndex="20" Caption="Genero" />
        <dx:GridViewDataTextColumn FieldName="EDAD" VisibleIndex="21" Caption="Edad" />
        <dx:GridViewDataTextColumn FieldName="MIEMBROS_GRUPO_FAMILIAR" VisibleIndex="22" Caption="Miembros grupo familiar" />
        <dx:GridViewDataTextColumn FieldName="ID_ESTADO_CIVIL" VisibleIndex="23" Caption="Id estado civil" />
        <dx:GridViewDataTextColumn FieldName="ES_JEFE_HOGAR" VisibleIndex="24" Caption="Es jefe hogar" />
        <dx:GridViewDataTextColumn FieldName="TIENE_HIJOS" VisibleIndex="25" Caption="Tiene hijos" />
        <dx:GridViewDataTextColumn FieldName="NO_DE_HIJOS" VisibleIndex="26" Caption="No de hijos" />
        <dx:GridViewDataTextColumn FieldName="SE_DEDICA_ALGUNA_PROFESION" VisibleIndex="27" Caption="Se dedica alguna profesion" />
        <dx:GridViewDataTextColumn FieldName="PROFESION_OFICIO" VisibleIndex="28" Caption="Profesion oficio" />
        <dx:GridViewDataTextColumn FieldName="DIRECCION" VisibleIndex="29" Caption="Direccion" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_DEPARTAMENTO" VisibleIndex="30" Caption="Codigo departamento" />
        <dx:GridViewDataTextColumn FieldName="CODIGO_MUNICIPIO" VisibleIndex="31" Caption="Codigo municipio" />
        <dx:GridViewDataTextColumn FieldName="TELEFONO" VisibleIndex="32" Caption="Telefono" />
        <dx:GridViewDataTextColumn FieldName="MOVIL" VisibleIndex="33" Caption="Movil" />
        <dx:GridViewDataTextColumn FieldName="EMAIL" VisibleIndex="34" Caption="Email" />
        <dx:GridViewDataTextColumn FieldName="CON_DISCAPACIDAD" VisibleIndex="35" Caption="Con discapacidad" />
        <dx:GridViewDataTextColumn FieldName="DISC_OTRA" VisibleIndex="36" Caption="Disc otra" />
        <dx:GridViewDataTextColumn FieldName="ID_LEE_ESCRIBE" VisibleIndex="37" Caption="Id lee escribe" />
        <dx:GridViewDataTextColumn FieldName="ID_NIVEL_ACADEMICO" VisibleIndex="38" Caption="Id nivel academico" />
        <dx:GridViewDataTextColumn FieldName="OTRA_EDUCACION_FORMAL" VisibleIndex="39" Caption="Otra educacion formal" />
        <dx:GridViewDataTextColumn FieldName="TITULO_CERTIFICADO_OBTENIDO" VisibleIndex="40" Caption="Titulo certificado obtenido" />
        <dx:GridViewDataTextColumn FieldName="ESTUDIA_ACTUALMENTE" VisibleIndex="41" Caption="Estudia actualmente" />
        <dx:GridViewDataTextColumn FieldName="ID_TIEMPO_DEJO_ESTUDIAR" VisibleIndex="42" Caption="Id tiempo dejo estudiar" />
        <dx:GridViewDataTextColumn FieldName="RECIBIO_CURSO_ANTERIOR" VisibleIndex="43" Caption="Recibio curso anterior" />
        <dx:GridViewDataTextColumn FieldName="BENEF_PROM_EMP_ACT" VisibleIndex="44" Caption="Benef prom emp act" />
        <dx:GridViewDataTextColumn FieldName="BENEF_OBT_EMPLEO" VisibleIndex="45" Caption="Benef obt empleo" />
        <dx:GridViewDataTextColumn FieldName="BENEF_OBT_ING_EXTRA" VisibleIndex="46" Caption="Benef obt ing extra" />
        <dx:GridViewDataTextColumn FieldName="BENEF_CAMB_EMP_X_CURSO" VisibleIndex="47" Caption="Benef camb emp x curso" />
        <dx:GridViewDataTextColumn FieldName="BENEF_TRAB_CTA_PROPIA" VisibleIndex="48" Caption="Benef trab cta propia" />
        <dx:GridViewDataTextColumn FieldName="BENEF_OTRO" VisibleIndex="49" Caption="Benef otro" />
        <dx:GridViewDataTextColumn FieldName="RAZON_NO_BENEFICIO" VisibleIndex="50" Caption="Razon no beneficio" />
        <dx:GridViewDataTextColumn FieldName="OCUACT_TRABAJA" VisibleIndex="51" Caption="Ocuact trabaja" />
        <dx:GridViewDataTextColumn FieldName="OCUACT_ESTUDIA" VisibleIndex="52" Caption="Ocuact estudia" />
        <dx:GridViewDataTextColumn FieldName="OCUACT_DESOCUPADO" VisibleIndex="53" Caption="Ocuact desocupado" />
        <dx:GridViewDataTextColumn FieldName="OCUACT_OFICIO_HOGAR" VisibleIndex="54" Caption="Ocuact oficio hogar" />
        <dx:GridViewDataTextColumn FieldName="OCUACT_BUSCA_TRABAJO" VisibleIndex="55" Caption="Ocuact busca trabajo" />
        <dx:GridViewDataTextColumn FieldName="OCUACT_OTRA" VisibleIndex="56" Caption="Ocuact otra" />
        <dx:GridViewDataTextColumn FieldName="ID_TIPO_EMPLEO" VisibleIndex="57" Caption="Id tipo empleo" />
        <dx:GridViewDataTextColumn FieldName="SECTOR_EMPLEO" VisibleIndex="58" Caption="Sector empleo" />
        <dx:GridViewDataTextColumn FieldName="TRABAJO_ANTERIOR" VisibleIndex="59" Caption="Trabajo anterior" />
        <dx:GridViewDataTextColumn FieldName="RECIBE_INGRESOS" VisibleIndex="60" Caption="Recibe ingresos" />
        <dx:GridViewDataTextColumn FieldName="MANERA_OBT_ING_TRABAJO" VisibleIndex="61" Caption="Manera obt ing trabajo" />
        <dx:GridViewDataTextColumn FieldName="MANERA_OBT_ING_AYUDA_FAM" VisibleIndex="62" Caption="Manera obt ing ayuda fam" />
        <dx:GridViewDataTextColumn FieldName="MANERA_OBT_ING_REMESA" VisibleIndex="63" Caption="Manera obt ing remesa" />
        <dx:GridViewDataTextColumn FieldName="MANERA_OBT_ING_PENSION" VisibleIndex="64" Caption="Manera obt ing pension" />
        <dx:GridViewDataTextColumn FieldName="MANERA_OBT_ING_OTRO" VisibleIndex="65" Caption="Manera obt ing otro" />
        <dx:GridViewDataTextColumn FieldName="EXPFOR_PROMOCION_EMPLEO" VisibleIndex="66" Caption="Expfor promocion empleo" />
        <dx:GridViewDataTextColumn FieldName="EXPFOR_CAMBIAR_EMPLEO" VisibleIndex="67" Caption="Expfor cambiar empleo" />
        <dx:GridViewDataTextColumn FieldName="EXPFOR_OBTENER_EMPLEO" VisibleIndex="68" Caption="Expfor obtener empleo" />
        <dx:GridViewDataTextColumn FieldName="EXPFOR_TRABAJAR_CTA_PROPIA" VisibleIndex="69" Caption="Expfor trabajar cta propia" />
        <dx:GridViewDataTextColumn FieldName="EXPFOR_INGRESOS_EXTRAS" VisibleIndex="70" Caption="Expfor ingresos extras" />
        <dx:GridViewDataTextColumn FieldName="EXPFOR_NINGUNO" VisibleIndex="71" Caption="Expfor ninguno" />
        <dx:GridViewDataTextColumn FieldName="EXPFOR_OTRO" VisibleIndex="72" Caption="Expfor otro" />
        <dx:GridViewDataTextColumn FieldName="CURSO_REL_TRAB_ACTUAL" VisibleIndex="73" Caption="Curso rel trab actual" />
        <dx:GridViewDataTextColumn FieldName="CURSO_REL_TRAB_NUEVO" VisibleIndex="74" Caption="Curso rel trab nuevo" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE_REFERENCIA" VisibleIndex="75" Caption="Nombre referencia" />
        <dx:GridViewDataTextColumn FieldName="ID_REFERENCIA" VisibleIndex="76" Caption="Id referencia" />
        <dx:GridViewDataTextColumn FieldName="DIRECCION_REFERENCIA" VisibleIndex="77" Caption="Direccion referencia" />
        <dx:GridViewDataTextColumn FieldName="DEPARTAMENTO_REFERENCIA" VisibleIndex="78" Caption="Departamento referencia" />
        <dx:GridViewDataTextColumn FieldName="MUNICIPIO_REFERENCIA" VisibleIndex="79" Caption="Municipio referencia" />
        <dx:GridViewDataTextColumn FieldName="TELEFONO_REFERENCIA" VisibleIndex="80" Caption="Telefono referencia" />
        <dx:GridViewDataTextColumn FieldName="MOVIL_REFERENCIA" VisibleIndex="81" Caption="Movil referencia" />
        <dx:GridViewDataTextColumn FieldName="EMAIL_REFERENCIA" VisibleIndex="82" Caption="Email referencia" />
        <dx:GridViewDataTextColumn FieldName="SUGERENCIAS" VisibleIndex="83" Caption="Sugerencias" />
        <dx:GridViewDataTextColumn FieldName="USERID" VisibleIndex="84" Caption="Userid" />
        <dx:GridViewDataTextColumn FieldName="LASTUPDATE" VisibleIndex="85" Caption="Lastupdate" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="86">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>
    <Templates>
        <EditForm>
            <uc1:ucVistaDetalleSOLIC_INSCRIPCION_AF_HIST ID="ucVistaDetalleSOLIC_INSCRIPCION_AF_HIST1" runat="server" 
                ID_SOLICITUD_HIST='<%# Bind("ID_SOLICITUD_HIST") %>' ID_SOLICITUD='<%# Bind("ID_SOLICITUD") %>' FECHA_PRESENTACION='<%# Bind("FECHA_PRESENTACION") %>' ID_PARTICIPANTE='<%# Bind("ID_PARTICIPANTE") %>' ID_ACCION_FORMATIVA='<%# Bind("ID_ACCION_FORMATIVA") %>' ID_ESTADO_SOLICITUD='<%# Bind("ID_ESTADO_SOLICITUD") %>' NOMBRES='<%# Bind("NOMBRES") %>' APELLIDOS='<%# Bind("APELLIDOS") %>' DUI='<%# Bind("DUI") %>' TIPO_DOCTO='<%# Bind("TIPO_DOCTO") %>' NUM_DOCTO='<%# Bind("NUM_DOCTO") %>' NIT='<%# Bind("NIT") %>' ISSS='<%# Bind("ISSS") %>' ID_TIPO_SOLICITUD='<%# Bind("ID_TIPO_SOLICITUD") %>' ID_PAIS='<%# Bind("ID_PAIS") %>' DEPARTAMENTO_NAC='<%# Bind("DEPARTAMENTO_NAC") %>' MUNICIPIO_NAC='<%# Bind("MUNICIPIO_NAC") %>' FECHA_NACIMIENTO='<%# Bind("FECHA_NACIMIENTO") %>' GENERO='<%# Bind("GENERO") %>' EDAD='<%# Bind("EDAD") %>' MIEMBROS_GRUPO_FAMILIAR='<%# Bind("MIEMBROS_GRUPO_FAMILIAR") %>' ID_ESTADO_CIVIL='<%# Bind("ID_ESTADO_CIVIL") %>' ES_JEFE_HOGAR='<%# Bind("ES_JEFE_HOGAR") %>' TIENE_HIJOS='<%# Bind("TIENE_HIJOS") %>' NO_DE_HIJOS='<%# Bind("NO_DE_HIJOS") %>' SE_DEDICA_ALGUNA_PROFESION='<%# Bind("SE_DEDICA_ALGUNA_PROFESION") %>' PROFESION_OFICIO='<%# Bind("PROFESION_OFICIO") %>' DIRECCION='<%# Bind("DIRECCION") %>' CODIGO_DEPARTAMENTO='<%# Bind("CODIGO_DEPARTAMENTO") %>' CODIGO_MUNICIPIO='<%# Bind("CODIGO_MUNICIPIO") %>' TELEFONO='<%# Bind("TELEFONO") %>' MOVIL='<%# Bind("MOVIL") %>' EMAIL='<%# Bind("EMAIL") %>' CON_DISCAPACIDAD='<%# Bind("CON_DISCAPACIDAD") %>' DISC_OTRA='<%# Bind("DISC_OTRA") %>' ID_LEE_ESCRIBE='<%# Bind("ID_LEE_ESCRIBE") %>' ID_NIVEL_ACADEMICO='<%# Bind("ID_NIVEL_ACADEMICO") %>' OTRA_EDUCACION_FORMAL='<%# Bind("OTRA_EDUCACION_FORMAL") %>' TITULO_CERTIFICADO_OBTENIDO='<%# Bind("TITULO_CERTIFICADO_OBTENIDO") %>' ESTUDIA_ACTUALMENTE='<%# Bind("ESTUDIA_ACTUALMENTE") %>' ID_TIEMPO_DEJO_ESTUDIAR='<%# Bind("ID_TIEMPO_DEJO_ESTUDIAR") %>' RECIBIO_CURSO_ANTERIOR='<%# Bind("RECIBIO_CURSO_ANTERIOR") %>' BENEF_PROM_EMP_ACT='<%# Bind("BENEF_PROM_EMP_ACT") %>' BENEF_OBT_EMPLEO='<%# Bind("BENEF_OBT_EMPLEO") %>' BENEF_OBT_ING_EXTRA='<%# Bind("BENEF_OBT_ING_EXTRA") %>' BENEF_CAMB_EMP_X_CURSO='<%# Bind("BENEF_CAMB_EMP_X_CURSO") %>' BENEF_TRAB_CTA_PROPIA='<%# Bind("BENEF_TRAB_CTA_PROPIA") %>' BENEF_OTRO='<%# Bind("BENEF_OTRO") %>' RAZON_NO_BENEFICIO='<%# Bind("RAZON_NO_BENEFICIO") %>' OCUACT_TRABAJA='<%# Bind("OCUACT_TRABAJA") %>' OCUACT_ESTUDIA='<%# Bind("OCUACT_ESTUDIA") %>' OCUACT_DESOCUPADO='<%# Bind("OCUACT_DESOCUPADO") %>' OCUACT_OFICIO_HOGAR='<%# Bind("OCUACT_OFICIO_HOGAR") %>' OCUACT_BUSCA_TRABAJO='<%# Bind("OCUACT_BUSCA_TRABAJO") %>' OCUACT_OTRA='<%# Bind("OCUACT_OTRA") %>' ID_TIPO_EMPLEO='<%# Bind("ID_TIPO_EMPLEO") %>' SECTOR_EMPLEO='<%# Bind("SECTOR_EMPLEO") %>' TRABAJO_ANTERIOR='<%# Bind("TRABAJO_ANTERIOR") %>' RECIBE_INGRESOS='<%# Bind("RECIBE_INGRESOS") %>' MANERA_OBT_ING_TRABAJO='<%# Bind("MANERA_OBT_ING_TRABAJO") %>' MANERA_OBT_ING_AYUDA_FAM='<%# Bind("MANERA_OBT_ING_AYUDA_FAM") %>' MANERA_OBT_ING_REMESA='<%# Bind("MANERA_OBT_ING_REMESA") %>' MANERA_OBT_ING_PENSION='<%# Bind("MANERA_OBT_ING_PENSION") %>' MANERA_OBT_ING_OTRO='<%# Bind("MANERA_OBT_ING_OTRO") %>' EXPFOR_PROMOCION_EMPLEO='<%# Bind("EXPFOR_PROMOCION_EMPLEO") %>' EXPFOR_CAMBIAR_EMPLEO='<%# Bind("EXPFOR_CAMBIAR_EMPLEO") %>' EXPFOR_OBTENER_EMPLEO='<%# Bind("EXPFOR_OBTENER_EMPLEO") %>' EXPFOR_TRABAJAR_CTA_PROPIA='<%# Bind("EXPFOR_TRABAJAR_CTA_PROPIA") %>' EXPFOR_INGRESOS_EXTRAS='<%# Bind("EXPFOR_INGRESOS_EXTRAS") %>' EXPFOR_NINGUNO='<%# Bind("EXPFOR_NINGUNO") %>' EXPFOR_OTRO='<%# Bind("EXPFOR_OTRO") %>' CURSO_REL_TRAB_ACTUAL='<%# Bind("CURSO_REL_TRAB_ACTUAL") %>' CURSO_REL_TRAB_NUEVO='<%# Bind("CURSO_REL_TRAB_NUEVO") %>' NOMBRE_REFERENCIA='<%# Bind("NOMBRE_REFERENCIA") %>' ID_REFERENCIA='<%# Bind("ID_REFERENCIA") %>' DIRECCION_REFERENCIA='<%# Bind("DIRECCION_REFERENCIA") %>' DEPARTAMENTO_REFERENCIA='<%# Bind("DEPARTAMENTO_REFERENCIA") %>' MUNICIPIO_REFERENCIA='<%# Bind("MUNICIPIO_REFERENCIA") %>' TELEFONO_REFERENCIA='<%# Bind("TELEFONO_REFERENCIA") %>' MOVIL_REFERENCIA='<%# Bind("MOVIL_REFERENCIA") %>' EMAIL_REFERENCIA='<%# Bind("EMAIL_REFERENCIA") %>' SUGERENCIAS='<%# Bind("SUGERENCIAS") %>' USERID='<%# Bind("USERID") %>' LASTUPDATE='<%# Bind("LASTUPDATE") %>' />
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
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarSOLIC_INSCRIPCION_AF_HIST" DeleteMethod="EliminarSOLIC_INSCRIPCION_AF_HIST" UpdateMethod="ActualizarSOLIC_INSCRIPCION_AF_HIST"
    TypeName="SGAFP.BL.cSOLIC_INSCRIPCION_AF_HIST">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD_HIST" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
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
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
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
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD_HIST" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
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
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
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
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD_HIST" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorSOLICITUD_INSCRIPCION_AF" runat="server" 
    SelectMethod="ObtenerListaPorSOLICITUD_INSCRIPCION_AF" InsertMethod="AgregarSOLIC_INSCRIPCION_AF_HIST" DeleteMethod="EliminarSOLIC_INSCRIPCION_AF_HIST" UpdateMethod="ActualizarSOLIC_INSCRIPCION_AF_HIST"
    TypeName="SGAFP.BL.cSOLIC_INSCRIPCION_AF_HIST">
    <SelectParameters>
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD_HIST" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
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
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
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
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD_HIST" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
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
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
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
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD_HIST" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPARTICIPANTE" runat="server" 
    SelectMethod="ObtenerListaPorPARTICIPANTE" InsertMethod="AgregarSOLIC_INSCRIPCION_AF_HIST" DeleteMethod="EliminarSOLIC_INSCRIPCION_AF_HIST" UpdateMethod="ActualizarSOLIC_INSCRIPCION_AF_HIST"
    TypeName="SGAFP.BL.cSOLIC_INSCRIPCION_AF_HIST">
    <SelectParameters>
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD_HIST" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
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
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
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
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD_HIST" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
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
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
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
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD_HIST" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorACCION_FORMATIVA" runat="server" 
    SelectMethod="ObtenerListaPorACCION_FORMATIVA" InsertMethod="AgregarSOLIC_INSCRIPCION_AF_HIST" DeleteMethod="EliminarSOLIC_INSCRIPCION_AF_HIST" UpdateMethod="ActualizarSOLIC_INSCRIPCION_AF_HIST"
    TypeName="SGAFP.BL.cSOLIC_INSCRIPCION_AF_HIST">
    <SelectParameters>
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD_HIST" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
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
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
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
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD_HIST" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
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
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
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
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD_HIST" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorESTADO_SOLICITUD" runat="server" 
    SelectMethod="ObtenerListaPorESTADO_SOLICITUD" InsertMethod="AgregarSOLIC_INSCRIPCION_AF_HIST" DeleteMethod="EliminarSOLIC_INSCRIPCION_AF_HIST" UpdateMethod="ActualizarSOLIC_INSCRIPCION_AF_HIST"
    TypeName="SGAFP.BL.cSOLIC_INSCRIPCION_AF_HIST">
    <SelectParameters>
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD_HIST" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
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
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
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
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD_HIST" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
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
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
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
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD_HIST" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIPO_SOLICITUD" runat="server" 
    SelectMethod="ObtenerListaPorTIPO_SOLICITUD" InsertMethod="AgregarSOLIC_INSCRIPCION_AF_HIST" DeleteMethod="EliminarSOLIC_INSCRIPCION_AF_HIST" UpdateMethod="ActualizarSOLIC_INSCRIPCION_AF_HIST"
    TypeName="SGAFP.BL.cSOLIC_INSCRIPCION_AF_HIST">
    <SelectParameters>
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD_HIST" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
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
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
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
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD_HIST" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
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
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
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
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD_HIST" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPAIS" runat="server" 
    SelectMethod="ObtenerListaPorPAIS" InsertMethod="AgregarSOLIC_INSCRIPCION_AF_HIST" DeleteMethod="EliminarSOLIC_INSCRIPCION_AF_HIST" UpdateMethod="ActualizarSOLIC_INSCRIPCION_AF_HIST"
    TypeName="SGAFP.BL.cSOLIC_INSCRIPCION_AF_HIST">
    <SelectParameters>
        <asp:Parameter Name="ID_PAIS" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD_HIST" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
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
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
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
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD_HIST" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
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
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
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
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD_HIST" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorESTADO_CIVIL" runat="server" 
    SelectMethod="ObtenerListaPorESTADO_CIVIL" InsertMethod="AgregarSOLIC_INSCRIPCION_AF_HIST" DeleteMethod="EliminarSOLIC_INSCRIPCION_AF_HIST" UpdateMethod="ActualizarSOLIC_INSCRIPCION_AF_HIST"
    TypeName="SGAFP.BL.cSOLIC_INSCRIPCION_AF_HIST">
    <SelectParameters>
        <asp:Parameter Name="ID_ESTADO_CIVIL" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD_HIST" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
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
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
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
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD_HIST" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
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
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
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
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD_HIST" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorDEPARTAMENTO" runat="server" 
    SelectMethod="ObtenerListaPorDEPARTAMENTO" InsertMethod="AgregarSOLIC_INSCRIPCION_AF_HIST" DeleteMethod="EliminarSOLIC_INSCRIPCION_AF_HIST" UpdateMethod="ActualizarSOLIC_INSCRIPCION_AF_HIST"
    TypeName="SGAFP.BL.cSOLIC_INSCRIPCION_AF_HIST">
    <SelectParameters>
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_REGION" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD_HIST" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
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
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
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
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD_HIST" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
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
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
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
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD_HIST" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorMUNICIPIO" runat="server" 
    SelectMethod="ObtenerListaPorMUNICIPIO" InsertMethod="AgregarSOLIC_INSCRIPCION_AF_HIST" DeleteMethod="EliminarSOLIC_INSCRIPCION_AF_HIST" UpdateMethod="ActualizarSOLIC_INSCRIPCION_AF_HIST"
    TypeName="SGAFP.BL.cSOLIC_INSCRIPCION_AF_HIST">
    <SelectParameters>
        <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter Name="CODIGO_MUNICIPIO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD_HIST" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
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
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
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
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD_HIST" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
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
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
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
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD_HIST" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorEDUC_LEE_ESCRIBE" runat="server" 
    SelectMethod="ObtenerListaPorEDUC_LEE_ESCRIBE" InsertMethod="AgregarSOLIC_INSCRIPCION_AF_HIST" DeleteMethod="EliminarSOLIC_INSCRIPCION_AF_HIST" UpdateMethod="ActualizarSOLIC_INSCRIPCION_AF_HIST"
    TypeName="SGAFP.BL.cSOLIC_INSCRIPCION_AF_HIST">
    <SelectParameters>
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD_HIST" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
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
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
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
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD_HIST" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
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
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
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
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD_HIST" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorNIVEL_ACADEMICO" runat="server" 
    SelectMethod="ObtenerListaPorNIVEL_ACADEMICO" InsertMethod="AgregarSOLIC_INSCRIPCION_AF_HIST" DeleteMethod="EliminarSOLIC_INSCRIPCION_AF_HIST" UpdateMethod="ActualizarSOLIC_INSCRIPCION_AF_HIST"
    TypeName="SGAFP.BL.cSOLIC_INSCRIPCION_AF_HIST">
    <SelectParameters>
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD_HIST" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
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
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
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
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD_HIST" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
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
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
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
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD_HIST" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIEMPO_DEJO_ESTUDIAR" runat="server" 
    SelectMethod="ObtenerListaPorTIEMPO_DEJO_ESTUDIAR" InsertMethod="AgregarSOLIC_INSCRIPCION_AF_HIST" DeleteMethod="EliminarSOLIC_INSCRIPCION_AF_HIST" UpdateMethod="ActualizarSOLIC_INSCRIPCION_AF_HIST"
    TypeName="SGAFP.BL.cSOLIC_INSCRIPCION_AF_HIST">
    <SelectParameters>
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD_HIST" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
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
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
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
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD_HIST" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
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
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
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
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD_HIST" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorTIPO_EMPLEO" runat="server" 
    SelectMethod="ObtenerListaPorTIPO_EMPLEO" InsertMethod="AgregarSOLIC_INSCRIPCION_AF_HIST" DeleteMethod="EliminarSOLIC_INSCRIPCION_AF_HIST" UpdateMethod="ActualizarSOLIC_INSCRIPCION_AF_HIST"
    TypeName="SGAFP.BL.cSOLIC_INSCRIPCION_AF_HIST">
    <SelectParameters>
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD_HIST" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
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
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
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
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD_HIST" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
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
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
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
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD_HIST" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorREFERENCIA" runat="server" 
    SelectMethod="ObtenerListaPorREFERENCIA" InsertMethod="AgregarSOLIC_INSCRIPCION_AF_HIST" DeleteMethod="EliminarSOLIC_INSCRIPCION_AF_HIST" UpdateMethod="ActualizarSOLIC_INSCRIPCION_AF_HIST"
    TypeName="SGAFP.BL.cSOLIC_INSCRIPCION_AF_HIST">
    <SelectParameters>
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD_HIST" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
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
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
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
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_SOLICITUD_HIST" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="FECHA_PRESENTACION" Type="DateTime" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="ID_ACCION_FORMATIVA" Type="Decimal" />
        <asp:Parameter Name="ID_ESTADO_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRES" Type="String" />
        <asp:Parameter Name="APELLIDOS" Type="String" />
        <asp:Parameter Name="DUI" Type="String" />
        <asp:Parameter Name="TIPO_DOCTO" Type="Decimal" />
        <asp:Parameter Name="NUM_DOCTO" Type="String" />
        <asp:Parameter Name="NIT" Type="String" />
        <asp:Parameter Name="ISSS" Type="String" />
        <asp:Parameter Name="ID_TIPO_SOLICITUD" Type="Decimal" />
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
        <asp:Parameter Name="ID_LEE_ESCRIBE" Type="Decimal" />
        <asp:Parameter Name="ID_NIVEL_ACADEMICO" Type="Decimal" />
        <asp:Parameter Name="OTRA_EDUCACION_FORMAL" Type="String" />
        <asp:Parameter Name="TITULO_CERTIFICADO_OBTENIDO" Type="String" />
        <asp:Parameter Name="ESTUDIA_ACTUALMENTE" Type="Decimal" />
        <asp:Parameter Name="ID_TIEMPO_DEJO_ESTUDIAR" Type="Decimal" />
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
        <asp:Parameter Name="OCUACT_DESOCUPADO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OFICIO_HOGAR" Type="Decimal" />
        <asp:Parameter Name="OCUACT_BUSCA_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="OCUACT_OTRA" Type="String" />
        <asp:Parameter Name="ID_TIPO_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="SECTOR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="TRABAJO_ANTERIOR" Type="String" />
        <asp:Parameter Name="RECIBE_INGRESOS" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_TRABAJO" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_AYUDA_FAM" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_REMESA" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_PENSION" Type="Decimal" />
        <asp:Parameter Name="MANERA_OBT_ING_OTRO" Type="String" />
        <asp:Parameter Name="EXPFOR_PROMOCION_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_CAMBIAR_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OBTENER_EMPLEO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_TRABAJAR_CTA_PROPIA" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_INGRESOS_EXTRAS" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_NINGUNO" Type="Decimal" />
        <asp:Parameter Name="EXPFOR_OTRO" Type="String" />
        <asp:Parameter Name="CURSO_REL_TRAB_ACTUAL" Type="Decimal" />
        <asp:Parameter Name="CURSO_REL_TRAB_NUEVO" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_REFERENCIA" Type="String" />
        <asp:Parameter Name="ID_REFERENCIA" Type="Decimal" />
        <asp:Parameter Name="DIRECCION_REFERENCIA" Type="String" />
        <asp:Parameter Name="DEPARTAMENTO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MUNICIPIO_REFERENCIA" Type="String" />
        <asp:Parameter Name="TELEFONO_REFERENCIA" Type="String" />
        <asp:Parameter Name="MOVIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="EMAIL_REFERENCIA" Type="String" />
        <asp:Parameter Name="SUGERENCIAS" Type="String" />
        <asp:Parameter Name="USERID" Type="String" />
        <asp:Parameter Name="LASTUPDATE" Type="DateTime" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="ID_SOLICITUD_HIST" Type="Decimal" />
    </DeleteParameters>
</asp:ObjectDataSource>
