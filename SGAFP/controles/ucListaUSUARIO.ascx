<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaUSUARIO.ascx.vb" Inherits="controles_ucListaUSUARIO" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<%@ Register src="ucVistaDetalleUSUARIO.ascx" tagname="ucVistaDetalleUSUARIO" tagprefix="uc1" %>

<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>

<style type="text/css">
    .td
    {
        font-family:Verdana, Arial;
        font-size:xx-small;
    }
</style>  
<script language="javascript" type="text/javascript">
    function ValidarRolesSeleccionados() {        
        var SeleccProveedor = false;
        var SeleccCentroCapacitador = false;     
        var items = lbxRoles.GetSelectedItems();
        for (var i = items.length - 1; i >= 0; i = i - 1) {
            switch (items[i].text) {
                case 'Proveedor':
                    SeleccProveedor = true;
                    break;
                case 'CentroCapacitador':
                    SeleccCentroCapacitador = true;
                    break;               
            }       
        }
        if (SeleccProveedor && SeleccCentroCapacitador) {
            AsignarMensaje('No puede aplicar el Rol Proveedor y CentroCapacitador al mismo tiempo');
            return false;
        }       
        return true;
    }

    function SeleccionRol() {
        var SeleccProveedor = false;
        var SeleccCentroCapacitador = false;
        var SeleccProveedorPATI = false;
        var SeleccProveedorHTP = false;
        var items = lbxRoles.GetSelectedItems();        
        for (var i = items.length - 1; i >= 0; i = i - 1) {
            switch (items[i].text) {
                case 'Proveedor':
                    SeleccProveedor = true;
                    break;
                case 'CentroCapacitador':
                    SeleccCentroCapacitador = true;
                    break;
                case 'ProveedorPATI':
                    SeleccProveedorPATI = true;
                    break;
                case 'ProveedorPROYESPECIAL':
                    SeleccProveedorPATI = true;
                    break;
                case 'Bolproes':
                    SeleccProveedorPATI = true;
                    break;
                case 'ProveedorFacturacionPATI':
                    SeleccProveedorPATI = true;
                    break;
                case 'ProveedorFacturacionHTP':
                    SeleccProveedorHTP = true;
                    break;
            }            
        }
        if (!SeleccProveedor && !SeleccProveedorPATI && !SeleccCentroCapacitador && !SeleccProveedorHTP) {
            cbxProveedor.SetText('');
            cbxCentroFormacion.SetText('');
        }
        else if (!SeleccCentroCapacitador || (SeleccCentroCapacitador && SeleccProveedor)) {
            cbxCentroFormacion.SetText('');
        }
    }    

    function MostrarCentrosFormacion() {
        var SeleccProveedor = false;
        var SeleccCentroCapacitador = false;
        var SeleccProveedorPATI = false;
        var SeleccProveedorHTP = false;
        var items = lbxRoles.GetSelectedItems();
        for (var i = items.length - 1; i >= 0; i = i - 1) {
            switch (items[i].text) {
                case 'Proveedor':
                    SeleccProveedor = true;
                    break;
                case 'CentroCapacitador':
                    SeleccCentroCapacitador = true;
                    break;
                case 'ProveedorPATI':
                    SeleccProveedorPATI = true;
                    break;
                case 'ProveedorPROYESPECIAL':
                    SeleccProveedorPATI = true;
                    break;
                case 'Bolproes':
                    SeleccProveedorPATI = true;
                    break;
                case 'ProveedorFacturacionPATI':
                    SeleccProveedorPATI = true;
                    break;
                case 'ProveedorFacturacionHTP':
                    SeleccProveedorHTP = true;
                    break;
            }
        }
        if (!SeleccProveedor && !SeleccProveedorPATI && !SeleccCentroCapacitador && !SeleccProveedorHTP) {
            cbxProveedor.SetText('');
            cbxCentroFormacion.SetText('');
        }
        else if (SeleccCentroCapacitador && !SeleccProveedor) {
            cbxCentroFormacion.PerformCallback(cbxProveedor.GetValue().toString());
        }
    }

    function MostrarMunicipios() {
        var SeleccRolAlcaldia = false;
        var items = lbxRoles.GetSelectedItems();
        for (var i = items.length - 1; i >= 0; i = i - 1) {
            switch (items[i].text) {
                case 'Alcaldia':
                    SeleccRolAlcaldia = true;
                    break;
            }
        }
        if (!SeleccRolAlcaldia) {
            cbxDepartamento.SetText('');
            cbxMunicipio.SetText('');
        }
        else{
            cbxMunicipio.PerformCallback(cbxDepartamento.GetValue().toString());
        }
    }    
</script>        
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" Width="100%"  DataSourceID="odsListaPorCRITERIOS" ClientInstanceName="grid" KeyFieldName="USUARIO" CssFilePath="~/App_Themes/DevEx/{0}/styles.css" CssPostfix="DevEx" >
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar"  PopupEditFormCaption="Usuario" />    
    <ClientSideEvents CustomButtonClick="function(s,e){                                            
                                            if(e.buttonID == 'btnEliminar'){
                                                if(confirm('Desea eliminar el registro?'))
                                                    e.processOnServer = true;   
                                                }                                             
                                            else{
                                                    e.processOnServer = true;
                                                }
                                         }" 
                       EndCallback="function(s, e){
                                            if(grid.cpMensaje != '' && grid.cpMensaje != undefined){
                                                    AsignarMensaje(grid.cpMensaje);
                                                    grid.cpMensaje = '';
                                            }
                                         }" /> 
    <Columns>
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="True" VisibleIndex="0" ShowSelectCheckbox="true">
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn Name="Comandos" Visible="True" VisibleIndex="1" Caption=" " Width="100px"  ButtonType="Image">
           <NewButton Visible="False" Text="Agregar Usuario" Image-Url="../imagenes/nuevo.png">
<Image Url="../imagenes/nuevo.png"></Image>
            </NewButton>
           <EditButton Visible="False" Text="Editar Usuario" Image-Url="../imagenes/modificar.png" >
<Image Url="../imagenes/modificar.png"></Image>
            </EditButton>                     
           <CustomButtons>                   
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar Usuario" Image-Url="../imagenes/eliminar.png"  >
<Image Url="../imagenes/eliminar.png"></Image>
                </dx:GridViewCommandColumnCustomButton>
                <%--<dx:GridViewCommandColumnCustomButton ID="btnEnviarClave" Text="Enviar nueva Contraseña" Image-Url="../imagenes/enviarclave.png"/>          --%>      
                <dx:GridViewCommandColumnCustomButton ID="btnDesbloquear" Text="Desbloquear Usuario" Image-Url="../imagenes/unlock.png"> 
<Image Url="../imagenes/unlock.png"></Image>
                </dx:GridViewCommandColumnCustomButton>
           </CustomButtons>
        </dx:GridViewCommandColumn>             
        <dx:GridViewDataTextColumn FieldName="USUARIO"  VisibleIndex="2" Caption="Usuario" />
        <dx:GridViewDataTextColumn FieldName="NOMBRE" VisibleIndex="3" Caption="Nombre" />
        <dx:GridViewDataTextColumn FieldName="EMAIL" VisibleIndex="4" Caption="Email" UnboundType="String"   />
        <dx:GridViewDataTextColumn FieldName="EMAIL_ADICIONAL" VisibleIndex="4" Caption="Email(s) Adicional(es)" UnboundType="String"   />
        <dx:GridViewDataComboBoxColumn FieldName="ROL" VisibleIndex="5" Caption="Rol" UnboundType="String" >                  
<PropertiesComboBox ValueType="System.String" Spacing="0"></PropertiesComboBox>
        </dx:GridViewDataComboBoxColumn>
        <dx:GridViewDataComboBoxColumn FieldName="NOMBRE_PROVEEDOR" VisibleIndex="6" Caption="Proveedor" UnboundType="String"  >
<PropertiesComboBox ValueType="System.String" Spacing="0"></PropertiesComboBox>
        </dx:GridViewDataComboBoxColumn>
        <dx:GridViewDataComboBoxColumn FieldName="NOMBRE_SITIO" VisibleIndex="7" Caption="Centro Formación" UnboundType="String"   >
<PropertiesComboBox ValueType="System.String" Spacing="0"></PropertiesComboBox>
        </dx:GridViewDataComboBoxColumn>
        <dx:GridViewDataCheckColumn FieldName="ACTIVO" VisibleIndex="8" Caption="Activo" UnboundType="Boolean"  />
        <dx:GridViewDataCheckColumn FieldName="BLOQUEADO" VisibleIndex="9" Caption="Bloqueado" UnboundType="Boolean"  />
        <dx:GridViewDataDateColumn  FieldName="CREACION" VisibleIndex="10" Caption="Creación" UnboundType="DateTime" >         
            <PropertiesDateEdit Spacing="0">
            </PropertiesDateEdit>
        </dx:GridViewDataDateColumn>
        <dx:GridViewDataDateColumn FieldName="ULTIMO_ACCESO" VisibleIndex="11" Caption="Último acceso" UnboundType="DateTime" >                                           
	        <PropertiesDateEdit Spacing="0">
            </PropertiesDateEdit>
        </dx:GridViewDataDateColumn>
	   </Columns>    
    <Settings ShowFilterRow="True" ShowHeaderFilterButton="True" />       
    <SettingsEditing Mode="PopupEditForm" PopupEditFormHorizontalAlign="WindowCenter" PopupEditFormVerticalAlign="WindowCenter" />                        
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
            <div style="padding:4,4,4,4;" >
            <table>
                <tr>
                  <td>
                      Usuario:               
                  </td>  
                  <td>
                      <dx:ASPxTextBox ID="txtUsuario" runat="server" Width="200px" ClientInstanceName="txtUsuario"  MaxLength="100" >
                        <ValidationSettings ValidationGroup="editForm" Display="Dynamic" RequiredField-IsRequired="true" RequiredField-ErrorText="Usuario no puede estar vacio."   />
                      </dx:ASPxTextBox>
                  </td>                   
                </tr>
                <tr>
                  <td>
                      Nombre:               
                  </td>  
                  <td>
                      <dx:ASPxTextBox ID="txtNombre" runat="server" Width="200px" MaxLength="256" >
                           <ValidationSettings ValidationGroup="editForm" Display="Dynamic" RequiredField-IsRequired="true" RequiredField-ErrorText="Nombre no puede estar vacio."   />
                      </dx:ASPxTextBox>
                  </td>  
                </tr>
                <tr>
                  <td>
                      Email:                  
                  </td>  
                  <td>
                      <dx:ASPxTextBox ID="txtCorreo" runat="server" ClientInstanceName="txtCorreo"  Width="200px" MaxLength="256"  >
                         <ValidationSettings ValidationGroup="editForm" Display="Dynamic" RequiredField-IsRequired="true" RequiredField-ErrorText="Email no puede estar vacio." RegularExpression-ErrorText="Email no valido."  RegularExpression-ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"  />                                                                
                      </dx:ASPxTextBox>
                  </td>                 
                 </tr>   
                 <tr>
                  <td>
                      Emails Adicionales:                  
                  </td>  
                  <td>
                      <dx:ASPxTextBox ID="txtCorreoAdicional" runat="server" Width="200px" MaxLength="1000"  />                      
                  </td>                 
                 </tr>   
                 <tr>
                    <td>Rol(es):</td>
                    <td>
                        <dx:ASPxListBox ID="lbxRoles" ClientInstanceName="lbxRoles" runat="server" ValueType="System.String" SelectionMode="CheckColumn" Width="200px" Font-Names="Arial, Verdana" Font-Size="X-Small" Height="190px" >
                            <ValidationSettings ValidationGroup="editForm" Display="Dynamic" RequiredField-IsRequired="true" RequiredField-ErrorText="Rol no puede estar vacio."   />                            
                            <ClientSideEvents SelectedIndexChanged="function(s,e){SeleccionRol();}" />
                        </dx:ASPxListBox>    
                    </td>                   
                 </tr>            
                 <tr>
                  <td>
                      Proveedor:                  
                  </td>  
                  <td>
                      <dx:ASPxComboBox ID="cbxProveedor" runat="server" ClientInstanceName="cbxProveedor"  TextField="NOMBRE_PROVEEDOR" ValueField="ID_PROVEEDOR_AF" Width="200px" >              
                           <ClientSideEvents SelectedIndexChanged = "function(s,e){MostrarCentrosFormacion();}" />                           
                      </dx:ASPxComboBox>
                  </td>                   
                </tr>    
                <tr>
                  <td>
                      Centro:
                  </td>  
                  <td>
                   
                      <dx:ASPxComboBox ID="cbxCentroFormacion" OnCallback="cbxCentroFormacion_Callback" 
                      TextField="NOMBRE_SITIO" ValueField="ID_SITIO_CAPACITACION"
                      ClientInstanceName="cbxCentroFormacion" runat="server" Width="200px" >                             
                           <ClientSideEvents EndCallback="function(s,e){cbxCentroFormacion.SetText('');}" />                       
                      </dx:ASPxComboBox>                    
                  </td>  
                </tr>  
                <tr>
                  <td>
                      Departamento:                  
                  </td>  
                  <td>
                      <dx:ASPxComboBox ID="cbxDepartamento" runat="server" ClientInstanceName="cbxDepartamento"  
                      TextField="NOMBRE" ValueField="CODIGO_DEPARTAMENTO" Width="200px" >              
                           <ClientSideEvents SelectedIndexChanged = "function(s,e){MostrarMunicipios();}" />                           
                      </dx:ASPxComboBox>
                  </td>                   
                </tr>    
                <tr>
                  <td>
                      Municipio:
                  </td>  
                  <td>
                   
                      <dx:ASPxComboBox ID="cbxMunicipio" OnCallback="cbxMunicipio_Callback" 
                      TextField="NOMBRE" ValueField="CODIGO_MUNICIPIO"
                      ClientInstanceName="cbxMunicipio" runat="server" Width="200px" >                             
                           <ClientSideEvents EndCallback="function(s,e){cbxMunicipio.SetText('');}" />                       
                      </dx:ASPxComboBox>                    
                  </td>  
                </tr>  
                <tr>
                  <td>
                     <dx:ASPxLabel ID="lblPassword" runat="server" Text="Password:" />                          
                  </td>  
                  <td>
                      <dx:ASPxTextBox ID="txtPassword" runat="server" Width="200px" Password="true" MaxLength="30" >    
                        <ValidationSettings ValidationGroup="editForm" Display="Dynamic" RequiredField-IsRequired="true" RequiredField-ErrorText="Password no puede estar vacio."   />                              
                      </dx:ASPxTextBox>
                  </td>  
                  <td></td>  
                  <td></td>  
                </tr> 
                <tr>
                    <td>
                        <dx:ASPxLabel ID="lblConfirmarPassword" runat="server" Text="Confirmar:" />                        
                    </td>
                    <td>
                        <dx:ASPxTextBox ID="txtConfirmarPassword" runat="server" Width="200px" Password="true" MaxLength="30" >  
                            <ValidationSettings ValidationGroup="editForm" Display="Dynamic" RequiredField-IsRequired="true" RequiredField-ErrorText="Confirmacion del Password no puede estar vacio."   />                               
                        </dx:ASPxTextBox>
                    </td>
                    <td></td>  
                    <td></td>  
                </tr>                       
                <tr>
                  <td></td>  
                  <td>
                      <dx:ASPxCheckBox ID="chkActivo" runat="server" ValueType="System.Boolean" ValueChecked="True" ValueUnchecked="False" Text="Activo"  />                               
                  </td>  
                  <td></td>  
                  <td></td>  
                </tr>        
            </table>             
            <table>
                <tr>
                    <td>
                        <dx:ASPxButton ID="btnActualizar" runat="server" Text="Guardar" AutoPostBack="false" ClientSideEvents-Click="function(s,e){if( ASPxClientEdit.ValidateGroup('editForm') || ValidarRolesSeleccionados() ){grid.UpdateEdit();}}"   />
                    </td>
                    <td>
                        <dx:ASPxButton ID="btnCancelar" runat="server" Text="Cancelar" AutoPostBack="false" ClientSideEvents-Click="function(s,e){grid.CancelEdit();}"   />                                                                        
                    </td>
                </tr>    
            </table>
            <table>
                <tr><th colspan="2"><hr /></th></tr>
                <tr>
                    <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Enviar nueva clave al correo:" /></td>
                    <td>
                        <dx:ASPxTextBox ID="txtENVIO_CORREO" ClientInstanceName="txtENVIO_CORREO" runat="server" Width="200px" MaxLength="100" >                            
                        </dx:ASPxTextBox>
                    </td>
                </tr>
                <tr>
                    <th colspan="2" style="text-align:center" >
                        <dx:ASPxButton ID="btnEnviarClave" runat="server" Text="Enviar Clave" AutoPostBack="false" >
                                <ClientSideEvents Click="function(s, e) {                                        
                                        if (txtENVIO_CORREO.GetText()=='')
                                        {
                                            alert('Ingrese el correo donde se enviara la nueva clave');
                                            return;
                                        }
                                        grid.PerformCallback(txtENVIO_CORREO.GetText());                                       
                                    }" />
                        </dx:ASPxButton>
                    </th>
                </tr>
            </table>
            </div>                    
        </EditForm>        
    </Templates>  
</dx:ASPxGridView>

<asp:ObjectDataSource ID="odsLista" runat="server" SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cUSUARIO">
    <SelectParameters>        
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="USUARIO" Type="String" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="NOMBRE" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="USUARIO" Type="String" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="NOMBRE" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="USUARIO" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPROVEEDOR_AF" runat="server" 
    SelectMethod="ObtenerListaPorPROVEEDOR_AF"  TypeName="SGAFP.BL.cUSUARIO">
    <SelectParameters>
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />        
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="USUARIO" Type="String" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="NOMBRE" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="USUARIO" Type="String" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="NOMBRE" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="USUARIO" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorSITIO_CAPACITACION" runat="server" 
    SelectMethod="ObtenerListaPorSITIO_CAPACITACION" TypeName="SGAFP.BL.cUSUARIO">
    <SelectParameters>
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="USUARIO" Type="String" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="NOMBRE" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="USUARIO" Type="String" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="NOMBRE" Type="String" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="USUARIO" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsListaPorPARTICIPANTE" runat="server" 
    SelectMethod="ObtenerListaPorPARTICIPANTE" TypeName="SGAFP.BL.cUSUARIO">
    <SelectParameters>
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="USUARIO" Type="String" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="NOMBRE" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="USUARIO" Type="String" />
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />
        <asp:Parameter Name="NOMBRE" Type="String" />
    </UpdateParameters>
    <DeleteParameters>    
        <asp:Parameter Name="USUARIO" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>

    <asp:ObjectDataSource ID="odsListaPorCRITERIOS" runat="server" 
    SelectMethod="ObtenerListaPorCRITERIOS" UpdateMethod="ActualizarUSUARIO_cmembershipProvider" 
    InsertMethod="AgregarUSUARIO_cmembershipProvider" DeleteMethod="EliminarUSUARIO_cmembershipProvider"  
    TypeName="SGAFP.BL.cUSUARIO">  
    <SelectParameters>
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="USUARIOS" Type="Object" />        
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter Name="USUARIO" Type="String" />
        <asp:Parameter Name="NOMBRE" Type="String" />
        <asp:Parameter Name="CLAVE" Type="String" />
        <asp:Parameter Name="EMAIL" Type="String" />      
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />        
        <asp:Parameter Name="ROLES" Type="Object" /> 
        <asp:Parameter Name="CORREO_ADICIONAL" Type="String" /> 
        <asp:Parameter Name="DEPARTAMENTO_ALCALDIA" Type="String" /> 
        <asp:Parameter Name="MUNICIPIO_ALCALDIA" Type="String" /> 
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="USUARIO" Type="String" />
        <asp:Parameter Name="NOMBRE" Type="String" />        
        <asp:Parameter Name="EMAIL" Type="String" /> 
        <asp:Parameter Name="APROBADO" Type="Boolean" />     
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="ID_SITIO_CAPACITACION" Type="Decimal" />
        <asp:Parameter Name="ID_PARTICIPANTE" Type="Decimal" />        
        <asp:Parameter Name="ROLES" Type="Object" /> 
        <asp:Parameter Name="CORREO_ADICIONAL" Type="String" /> 
        <asp:Parameter Name="DEPARTAMENTO_ALCALDIA" Type="String" /> 
        <asp:Parameter Name="MUNICIPIO_ALCALDIA" Type="String" /> 
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="USUARIO" Type="String" />
    </DeleteParameters>
</asp:ObjectDataSource>


<asp:ObjectDataSource ID="odsProveedoresPorTecnico" runat="server"
    SelectMethod="ObtenerListaPorTecnico" TypeName="SGAFP.BL.cPROVEEDOR_AF" >
    <SelectParameters>
        <asp:Parameter Name="USUARIO" Type="String" />        
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />        
        <asp:Parameter DefaultValue="NOMBRE_PROVEEDOR" Name="asColumnaOrden" Type="String" />    
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />    
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsProveedor" runat="server" 
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cPROVEEDOR_AF">
    <SelectParameters> 
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />        
        <asp:Parameter DefaultValue="NOMBRE_PROVEEDOR" Name="asColumnaOrden" Type="String" />    
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />    
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsCentroFormacionPorTecnico" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerListaPorTECNICO" TypeName="SGAFP.BL.cSITIO_CAPACITACION">
    <SelectParameters>            
        <asp:Parameter DefaultValue="" Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter Name="USUARIO" Type="String" />     
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />        
        <asp:Parameter DefaultValue="NOMBRE_SITIO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsCentroFormacion" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerListaPorPROVEEDOR_AF" TypeName="SGAFP.BL.cSITIO_CAPACITACION">
    <SelectParameters>            
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />        
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />        
        <asp:Parameter DefaultValue="NOMBRE_SITIO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsDepartamento" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerListaParaPATI" TypeName="SGAFP.BL.cDEPARTAMENTO">
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsMunicipio" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerListaParaPATIPorDEPARTAMENTO" TypeName="SGAFP.BL.cMUNICIPIO">
<SelectParameters>                    
    <asp:Parameter Name="CODIGO_DEPARTAMENTO" Type="String" />    
</SelectParameters>
</asp:ObjectDataSource>