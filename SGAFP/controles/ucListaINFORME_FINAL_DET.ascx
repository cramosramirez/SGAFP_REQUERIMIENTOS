<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaINFORME_FINAL_DET.ascx.vb" Inherits="controles_ucListaINFORME_FINAL_DET" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<dx:ASPxGridView ID="dxgvLista" runat="server" AutoGenerateColumns="False" DataSourceID="odsLista" KeyFieldName="ID_INFORME_FINAL_DET">
    <SettingsPager>
        <Summary AllPagesText="Pags: {0} - {1} ({2} registros)" 
            Text="Pag. {0} de {1} ({2} registros)" />
    </SettingsPager>
    <SettingsText GroupPanel="Arrastre la columna aqui para agrupar" 
        EmptyDataRow="No existen registros para mostrar" />
    <Columns>
        <dx:GridViewCommandColumn AllowDragDrop="False" Caption=" " Name="Seleccionar" Visible="False" VisibleIndex="0">
        </dx:GridViewCommandColumn>
        <dx:GridViewDataTextColumn VisibleIndex="1">
            <DataItemTemplate>
                <asp:LinkButton ID="lbtnEditar" runat="server" CommandName="Editar" 
                    CommandArgument='<%# Bind("ID_INFORME_FINAL_DET") %>'>Editar</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="lbtnSeleccionar" runat="server" 
                    CommandArgument='<%# Bind("ID_INFORME_FINAL_DET") %>' CommandName="Seleccionar" 
                    Visible="False">Seleccionar</asp:LinkButton>
            </DataItemTemplate>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="ID_INFORME_FINAL_DET" ReadOnly="True" VisibleIndex="2" />
        <dx:GridViewDataTextColumn FieldName="ID_INFORME_FINAL" VisibleIndex="3" />
        <dx:GridViewDataTextColumn FieldName="ID_PARTICIPANTE" VisibleIndex="4" />
        <dx:GridViewDataTextColumn FieldName="ID_ACCION_FORMATIVA" VisibleIndex="5" />
        <dx:GridViewDataTextColumn FieldName="NOTA_OBTENIDA" VisibleIndex="6" />
        <dx:GridViewDataTextColumn FieldName="PORC_ASISTENCIA" VisibleIndex="7" />
        <dx:GridViewDataTextColumn FieldName="MONTO_SOLICITADO" VisibleIndex="8" />
        <dx:GridViewDataTextColumn FieldName="MONTO_APROBADO" VisibleIndex="9" />
        <dx:GridViewDataTextColumn FieldName="ESTADO" VisibleIndex="10" />
        <dx:GridViewDataTextColumn FieldName="NOTAS" VisibleIndex="11" />
        <dx:GridViewDataTextColumn FieldName="USERID" VisibleIndex="12" />
        <dx:GridViewDataTextColumn FieldName="LASTUPDATE" VisibleIndex="13" />
        <dx:GridViewCommandColumn AllowDragDrop="False"  Caption=" "
            Name="Eliminar" VisibleIndex="14">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton ID="btnEliminar" Text="Eliminar">
                </dx:GridViewCommandColumnCustomButton>
            </CustomButtons>
        </dx:GridViewCommandColumn>
	   </Columns>
</dx:ASPxGridView>
<asp:ObjectDataSource ID="odsLista" runat="server" 
    SelectMethod="ObtenerLista" 
    TypeName="SGAFP.BL.cINFORME_FINAL_DET">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
