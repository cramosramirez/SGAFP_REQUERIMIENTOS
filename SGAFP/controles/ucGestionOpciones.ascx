<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucGestionOpciones.ascx.vb" Inherits="controles_ucGestionOpciones" %>
<%@ Register assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxTreeView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxTreeList.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxTreeList" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxCallback" tagprefix="dx" %>
<%@ Register src="ucBarraNavegacion.ascx" tagname="ucBarraNavegacion" tagprefix="uc1" %>
<style type="text/css">
    .style1
    {
        width: 100%;
    }
</style>
<script language="javascript" type="text/javascript">
    function Sincronizar(valores) {
        if (valores == "") {
            AsignarMensaje("Debe de seleccionar al menos una Opción de Menu");
            return;
        }
        callSync.PerformCallback(valores);
    }
</script>
<table class="style1">
    <tr>
        <td>
            <dx:ASPxLabel ID="lblSistema" runat="server" Text="Sistema:">
            </dx:ASPxLabel>
        </td>
        <td>
            <dx:ASPxComboBox ID="cbSistemas" runat="server" DataSourceID="odsSistemas" ClientInstanceName="cbSistemas" 
                TextField="NombreSistema" ValueField="IdSistema" ValueType="System.Int32">
                <ClientSideEvents SelectedIndexChanged="function(s, e) {
tlOpciones.PerformCallback('Recuperar;'+s.GetText());
}" />
            </dx:ASPxComboBox>
        </td>
    </tr>
    <tr>
        <td colspan="2">
<dx:ASPxTreeList ID="tlOpciones" runat="server" AutoGenerateColumns="False" 
DataSourceID="odsOpcionesMenu" KeyFieldName="IdOpcionMenu" ClientInstanceName="tlOpciones" ParentFieldName="IdPadre">
<SettingsPopupEditForm Caption="Editar" HorizontalAlign="WindowCenter" 
Modal="True" VerticalAlign="WindowCenter" />
<SettingsText ConfirmDelete="Confirmar eliminaci&#243;n" CommandEdit="Editar" CommandNew="Nuevo" CommandDelete="Eliminar" CommandUpdate="Actualizar" CommandCancel="Cancelar" RecursiveDeleteError="El nodo tiene nodos descendientes." CustomizationWindowCaption="Selector de campos" LoadingPanelText="Cargando&amp;hellip;"></SettingsText>
<SettingsLoadingPanel Text="Cargando&amp;hellip;"></SettingsLoadingPanel>
    <SettingsSelection AllowSelectAll="True" Enabled="True" Recursive="True" />
<Settings GridLines="Both" />
<SettingsBehavior AllowFocusedNode="True" FocusNodeOnExpandButtonClick="false" />
<Templates>
<EditForm>
<table class="style1">
<tr>
<td><dx:ASPxLabel ID="lblIdOpcionMenu" runat="server" Text="Id Opcion"></dx:ASPxLabel>
</td>
<td>
<dx:ASPxTextBox ID="txtIdOpcionMenu" runat="server" Text='<%# Bind("IdOpcionMenu") %>' ReadOnly="true"></dx:ASPxTextBox></td>
</tr>
<tr>
<td>
<dx:ASPxLabel ID="lblIdOpcionMenu7" runat="server" Text="Codigo"></dx:ASPxLabel>
</td>
<td>
<dx:ASPxTextBox ID="txtCodigoMenu" runat="server" Width="388px" Text='<%# Bind("CodigoMenu") %>'>
    <ValidationSettings RequiredField-IsRequired="true"></ValidationSettings>
</dx:ASPxTextBox></td>
</tr>
<tr>
<td>
<dx:ASPxLabel ID="lblIdOpcionMenu0" runat="server" Text="Descripcion"></dx:ASPxLabel>
</td>
<td>
<dx:ASPxTextBox ID="txtDescripcion" runat="server" Width="388px" Text='<%# Bind("DescripcionMenu") %>'>
    <ValidationSettings RequiredField-IsRequired="true"></ValidationSettings>
</dx:ASPxTextBox></td>
</tr>
<tr>
<td>
<dx:ASPxLabel ID="lblIdOpcionMenu1" runat="server" Text="Orden"></dx:ASPxLabel>
</td>
<td>
<dx:ASPxSpinEdit ID="seOrden" runat="server" Height="21px" Number="0"  NumberType="Integer" >
    <ValidationSettings>
        <RequiredField IsRequired="true" />
    </ValidationSettings>
</dx:ASPxSpinEdit>
</td>
</tr>
<tr>
<td>
<dx:ASPxLabel ID="lblIdOpcionMenu2" runat="server" Text="URL Imagen"></dx:ASPxLabel>
</td>
<td>
<dx:ASPxTextBox ID="txtURLImagen" runat="server" Width="388px" Text='<%# Bind("UrlImagen") %>'></dx:ASPxTextBox></td>
</tr>
<tr>
<td>
<dx:ASPxLabel ID="lblIdOpcionMenu3" runat="server" Text="URL Opcion"></dx:ASPxLabel>
</td>
<td>
<dx:ASPxTextBox ID="txtURLOpcion" Width="388px" runat="server" Text='<%# Bind("UrlOpcion") %>' >
    <ValidationSettings RequiredField-IsRequired="true"></ValidationSettings>
</dx:ASPxTextBox></td>
</tr>
<tr>
<td>
<dx:ASPxLabel ID="lblIdOpcionMenu4" runat="server" Text="Opcion Padre"></dx:ASPxLabel>
</td>
<td>
<dx:ASPxComboBox ID="cbOpcionPadre" runat="server" DataSourceID="odsOpciones" 
    TextField="NombreOpcionDDL" ValueField="IdOpcionMenu" ValueType="System.String">
</dx:ASPxComboBox>

</td>
</tr>
<tr>
<td>
<dx:ASPxLabel ID="lblIdOpcionMenu5" runat="server" Text="Notas"></dx:ASPxLabel>
</td>
<td>
<dx:ASPxMemo ID="txtNotas" runat="server" Height="71px" Width="388px" Text='<%# Bind("Notas") %>'>
</dx:ASPxMemo>
</td>
</tr>
<tr>
<td>
<dx:ASPxLabel ID="lblIdOpcionMenu6" runat="server" Text="Tipo Opcion"></dx:ASPxLabel>
</td>
<td>
<dx:ASPxComboBox ID="cbTipoOpcion" runat="server" ValueType="System.String">
<ClientSideEvents SelectedIndexChanged="function(s, e) {
	   if(s.GetValue()=='A'){
	       lblCV.SetVisible(true);
	       chkbxCV.SetVisible(true);
	       lblAK.SetVisible(true);
	       txtAK.SetVisible(true);
	       lblAV.SetVisible(true);
	       txtAV.SetVisible(true);
	   }
	   else{
	       lblCV.SetVisible(false);
	       chkbxCV.SetVisible(false);
	       lblAK.SetVisible(false);
	       txtAK.SetVisible(false);
	       lblAV.SetVisible(false);
	       txtAV.SetVisible(false);
	   }
}" />
    <Items>
        <dx:ListEditItem Text="Opcion" Value="O" />
        <dx:ListEditItem Text="Accion" Value="A" />
    </Items>
</dx:ASPxComboBox>
</td>
</tr>
    <tr>
     <td>
         <dx:ASPxLabel ID="lblCausaValidacion" runat="server" 
             Text="Valida Controles del Lado del Cliente:" ClientInstanceName="lblCV" 
             ClientVisible="False">
         </dx:ASPxLabel>
     </td>
     <td class="buttonCell">
         <dx:ASPxCheckBox ID="chkbxCausaValidacion" runat="server" 
             CheckState="Unchecked" ClientInstanceName="chkbxCV" ClientVisible="False" 
             Value='<%# Bind("CausaValidacion") %>'></dx:ASPxCheckBox></td>
 </tr>
    <tr>
        <td>
            <dx:ASPxLabel ID="lblAtributoKey" runat="server" ClientInstanceName="lblAK" 
                ClientVisible="False" Text="Atributo Key:">
            </dx:ASPxLabel>
        </td>
        <td class="buttonCell">
            <dx:ASPxTextBox ID="txtAtributoKey" runat="server" ClientInstanceName="txtAK" 
                ClientVisible="False" Text='<%# Bind("AtributoKey") %>' Width="388px">
            </dx:ASPxTextBox>
        </td>
    </tr>
    <tr>
        <td>
            <dx:ASPxLabel ID="lblAtributoValue" runat="server" ClientInstanceName="lblAV" 
                ClientVisible="False" Text="Atributo Value:">
            </dx:ASPxLabel>
        </td>
        <td class="buttonCell">
            <dx:ASPxTextBox ID="txtAtributoValue" runat="server" ClientInstanceName="txtAV" 
                ClientVisible="False" Text='<%# Bind("AtributoValue") %>' Width="388px">
            </dx:ASPxTextBox>
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td class="buttonCell">
            <table cellpadding="0" cellspacing="0">
                <tr>
                    <td>
                        <dx:ASPxButton ID="btnGuardar" runat="server" AutoPostBack="False" 
                            Text="Guardar" Width="74px">
                            <ClientSideEvents Click="function(s, e){if(!s.CauseValidation())return false;tlOpciones.UpdateEdit();}" />
                        </dx:ASPxButton>
                    </td>
                    <td style="padding-left: 13px;">
                        <dx:ASPxButton ID="btnCancelar" runat="server" AutoPostBack="False" 
                            CausesValidation="False" Text="Cancelar" Width="74px">
                            <ClientSideEvents Click="function(s, e){tlOpciones.CancelEdit();}" />
                        </dx:ASPxButton>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
</EditForm>
</Templates>
<SettingsEditing AllowNodeDragDrop="True" Mode="EditForm" ConfirmDelete="true" />
<Columns>
<dx:TreeListCommandColumn VisibleIndex="0">
<EditButton Visible="True">
</EditButton>
<NewButton Visible="True">
</NewButton>
<DeleteButton Visible="True">
</DeleteButton>
</dx:TreeListCommandColumn>
<dx:TreeListTextColumn FieldName="IdOpcionMenu" VisibleIndex="1" ReadOnly="true">
<propertiestextedit><validationsettings errortext="Valor inválido"><regularexpression errortext="Falló la validación de expresión Regular"></regularexpression></validationsettings></propertiestextedit>
</dx:TreeListTextColumn>
<dx:TreeListTextColumn FieldName="CodigoMenu" VisibleIndex="2">
</dx:TreeListTextColumn>
<dx:TreeListTextColumn FieldName="DescripcionMenu" VisibleIndex="3">
<propertiestextedit><validationsettings errortext="Valor inválido"><regularexpression errortext="Falló la validación de expresión Regular"></regularexpression></validationsettings></propertiestextedit>
</dx:TreeListTextColumn>
<dx:TreeListTextColumn FieldName="UrlImagen" VisibleIndex="4">
<propertiestextedit><validationsettings errortext="Valor inválido"><regularexpression errortext="Falló la validación de expresión Regular"></regularexpression></validationsettings></propertiestextedit>
</dx:TreeListTextColumn>
<dx:TreeListTextColumn FieldName="UrlOpcion" VisibleIndex="6">
<propertiestextedit><validationsettings errortext="Valor inválido"><regularexpression errortext="Falló la validación de expresión Regular"></regularexpression></validationsettings></propertiestextedit>
</dx:TreeListTextColumn>
<dx:TreeListTextColumn FieldName="IdPadre" VisibleIndex="8" Visible="False">
<propertiestextedit><validationsettings errortext="Valor inválido"><regularexpression errortext="Falló la validación de expresión Regular"></regularexpression></validationsettings></propertiestextedit>
</dx:TreeListTextColumn>
<dx:TreeListTextColumn FieldName="Notas" VisibleIndex="10">
<propertiestextedit><validationsettings errortext="Valor inválido"><regularexpression errortext="Falló la validación de expresión Regular"></regularexpression></validationsettings></propertiestextedit>
</dx:TreeListTextColumn>
<dx:TreeListTextColumn FieldName="TipoOpcion" VisibleIndex="12">
<propertiestextedit><validationsettings errortext="Valor inválido"><regularexpression errortext="Falló la validación de expresión Regular"></regularexpression></validationsettings></propertiestextedit>
</dx:TreeListTextColumn>
</Columns>

<SettingsCustomizationWindow Caption="Selector de campos"></SettingsCustomizationWindow>
</dx:ASPxTreeList>
        
            </td>
    </tr>
</table>

<dx:ASPxCallback ID="callSync" runat="server" ClientInstanceName="callSync">
    <ClientSideEvents CallbackComplete="function(s, e) {
	AsignarMensaje(e.result);
}" />
</dx:ASPxCallback>
<asp:ObjectDataSource ID="odsOpcionesMenu" runat="server" 
    SelectMethod="ObtenerListaPorSistemas" InsertMethod="AgregarOpcionesMenu" 
    DeleteMethod="EliminarOpcionesMenu" UpdateMethod="ActualizarOpcionesMenu"
    TypeName="SQLMembershipProvider.BL.cOpcionesMenu" 
    OldValuesParameterFormatString="{0}">
    <SelectParameters>
        <asp:ControlParameter ControlID="cbSistemas" Name="IdSistema" Type="Int32" PropertyName="Value" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="OrdenOpcionMenu" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DefaultValue="0" Name="IdOpcionMenu" Type="Int32" />
        <asp:Parameter Name="OrdenOpcionMenu" Type="Int32" />
        <asp:Parameter Name="CodigoMenu" Type="String" />
        <asp:Parameter Name="DescripcionMenu" Type="String" />
        <asp:Parameter Name="UrlImagen" Type="String" />
        <asp:Parameter Name="UrlOpcion" Type="String" />
        <asp:Parameter Name="IdPadre" Type="Int32" />
        <asp:Parameter Name="Notas" Type="String" />
        <asp:Parameter Name="TipoOpcion" Type="String" />
        <asp:Parameter Name="IdSistema" Type="Int32" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="IdOpcionMenu" Type="Int32" />
        <asp:Parameter Name="OrdenOpcionMenu" Type="Int32" />
        <asp:Parameter Name="CodigoMenu" Type="String" />
        <asp:Parameter Name="DescripcionMenu" Type="String" />
        <asp:Parameter Name="UrlImagen" Type="String" />
        <asp:Parameter Name="UrlOpcion" Type="String" />
        <asp:Parameter Name="IdPadre" Type="Int32" />
        <asp:Parameter Name="Notas" Type="String" />
        <asp:Parameter Name="TipoOpcion" Type="String" />
        <asp:Parameter Name="IdSistema" Type="Int32" />
    </UpdateParameters>
    <DeleteParameters>
        <asp:Parameter Name="IdOpcionMenu" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsOpciones" runat="server" 
                            OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerListaPorSistemas" 
                            TypeName="SQLMembershipProvider.BL.cOpcionesMenu">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="cbSistemas" Name="IdSistema" Type="Int32" PropertyName="Value" />
                                <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
                                <asp:Parameter DefaultValue="True" Name="recuperarForaneas" Type="Boolean" />
                                <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
                                <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
                            </SelectParameters>
                        </asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsSistemas" runat="server" 
    SelectMethod="ObtenerLista" InsertMethod="AgregarSistemas" DeleteMethod="EliminarSistemas" UpdateMethod="ActualizarSistemas"
    TypeName="SQLMembershipProvider.BL.cSistemas">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

                        