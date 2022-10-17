<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucGestionRoles.ascx.vb" Inherits="controles_ucGestionRoles" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<dx:ASPxGridView ID="grid" runat="server" AutoGenerateColumns="False" 
    DataSourceID="odsRoles" KeyFieldName="RoleId">
    <Columns>
        <dx:GridViewCommandColumn ShowSelectCheckbox="True" VisibleIndex="0" Caption=" ">
        </dx:GridViewCommandColumn>
        <dx:GridViewCommandColumn VisibleIndex="1">
            <EditButton Visible="True">
            </EditButton>
            <NewButton Visible="True">
            </NewButton>
            <DeleteButton Visible="True"></DeleteButton>
            <ClearFilterButton Visible="True">
            </ClearFilterButton>
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn FieldName="RoleId" ReadOnly="True" VisibleIndex="2" Visible="false">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ApplicationId" VisibleIndex="3" 
            Visible="False">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="RoleName" VisibleIndex="4">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="LoweredRoleName" VisibleIndex="5" 
            Visible="False">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="Description" VisibleIndex="6">
        </dx:GridViewDataTextColumn>
    </Columns>
    <Settings ShowFilterRow="True" />
</dx:ASPxGridView>
<asp:ObjectDataSource ID="odsRoles" runat="server" DeleteMethod="EliminarAspnet_Roles" 
    InsertMethod="AgregarAspnet_Roles" 
    OldValuesParameterFormatString="{0}" SelectMethod="ObtenerLista" 
    TypeName="SQLMembershipProvider.BL.cAspnet_Roles" 
    UpdateMethod="ActualizarAspnet_Roles">
    <UpdateParameters>
        <asp:Parameter DbType="Guid" Name="RoleId" />
        <asp:Parameter DbType="Guid" Name="ApplicationId" />
        <asp:Parameter Name="RoleName" Type="String" />
        <asp:Parameter Name="LoweredRoleName" Type="String" />
        <asp:Parameter Name="Description" Type="String" />
    </UpdateParameters>
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter DbType="Guid" Name="RoleId" />
        <asp:Parameter DbType="Guid" Name="ApplicationId" />
        <asp:Parameter Name="RoleName" Type="String" />
        <asp:Parameter Name="LoweredRoleName" Type="String" />
        <asp:Parameter Name="Description" Type="String" />
    </InsertParameters>
</asp:ObjectDataSource>
