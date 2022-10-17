<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaSOLIC_CURSOS_RECIBIDOS.ascx.vb" Inherits="controles_ucListaSOLIC_CURSOS_RECIBIDOS" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%--<asp:UpdatePanel ID="UpdatePanelCursosRecibidos" runat="server" ChildrenAsTriggers="False"
    UpdateMode="Conditional">
    <ContentTemplate>
--%>       
 <asp:GridView ID="gvLista" CssClass="Normal" AutoGenerateColumns="False" AllowSorting="True"
     runat="server" AllowPaging="True" ShowFooter="True" Visible="False" DataKeyNames="ID_CURSO_RECIBIDO">
	   <Columns>
         <asp:TemplateField ShowHeader="False" Visible="False">
             <ItemTemplate>
                 <asp:LinkButton ID="LinkButton_Seleccionar" runat="server" CausesValidation="False" CommandName="Select"
                     Text="Seleccionar"></asp:LinkButton>
                 <asp:CheckBox ID="CheckBox_Seleccionar" runat="server" Visible="False" />
             </ItemTemplate>
         </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Id" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_CURSO_RECIBIDO") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_CURSO_RECIBIDO") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_CURSO_RECIBIDO" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_CURSO_RECIBIDO") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 

<ItemStyle HorizontalAlign="Right"></ItemStyle>
	   	   </asp:TemplateField> 
	   	   <asp:TemplateField HeaderText="Solicitud inscripcion af">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_SOLICITUD1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_SOLICITUD") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlSOLICITUD_INSCRIPCION_AF id="ddlSOLICITUD_INSCRIPCION_AF1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlSOLICITUD_INSCRIPCION_AF></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_SOLICITUD2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_SOLICITUD") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlSOLICITUD_INSCRIPCION_AF id="ddlSOLICITUD_INSCRIPCION_AF2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlSOLICITUD_INSCRIPCION_AF></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Nombre de Curso">
               <EditItemTemplate>
                   <asp:TextBox ID="TextBox_NOMBRE_CURSO1" runat="server" 
                       Text='<%# Bind("NOMBRE_CURSO") %>'></asp:TextBox>
                   <asp:RequiredFieldValidator ID="rfvTextBox_NOMBRE_CURSO1" runat="server" 
                       ControlToValidate="TextBox_NOMBRE_CURSO1" 
                       ErrorMessage="Institución es Requerida" ValidationGroup="CursosRecibidos">*</asp:RequiredFieldValidator>
               </EditItemTemplate>
               <ItemTemplate>
                   <asp:Label ID="Label_NOMBRE_CURSO1" runat="server" 
                       Text='<%# Bind("NOMBRE_CURSO") %>'></asp:Label>
               </ItemTemplate>
               <FooterTemplate>
                   <asp:TextBox ID="NOMBRE_CURSOTextBox" runat="server"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="NOMBRE_CURSOTextBox"
                       ErrorMessage="Nombre del Curso es Requerido" ValidationGroup="AgregarCursoRecibido">*</asp:RequiredFieldValidator>
               </FooterTemplate>
               <ItemStyle HorizontalAlign="Left" />
           </asp:TemplateField>
           <asp:TemplateField HeaderText="Instituci&#243;n que lo Imparti&#243;">
               <EditItemTemplate>
                   <asp:TextBox ID="TextBox_INSTITUCION_CURSO1" runat="server" 
                       Text='<%# Bind("INSTITUCION_CURSO") %>'></asp:TextBox>
                   <asp:RequiredFieldValidator ID="rfvTextBox_INSTITUCION_CURSO1" runat="server" 
                       ControlToValidate="TextBox_INSTITUCION_CURSO1" 
                       ErrorMessage="Institución es Requerida" ValidationGroup="CursosRecibidos">*</asp:RequiredFieldValidator>
               </EditItemTemplate>
               <ItemTemplate>
                   <asp:Label ID="Label_INSTITUCION_CURSO1" runat="server" 
                       Text='<%# Bind("INSTITUCION_CURSO") %>'></asp:Label>
               </ItemTemplate>
               <FooterTemplate>
                   <asp:TextBox ID="INSTITUCION_CURSOTextBox" runat="server"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="INSTITUCION_CURSOTextBox"
                       ErrorMessage="Institución es Requerida" ValidationGroup="AgregarCursoRecibido">*</asp:RequiredFieldValidator>
               </FooterTemplate>
               <ItemStyle HorizontalAlign="Left" />
           </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Apoyo INSAFORP">
               <ItemTemplate>
                   <asp:DropDownList ID="ddlAPOYO_INSAFORP1" runat="server" 
                       SelectedValue='<%# Bind("APOYO_INSAFORP") %>' Enabled="False">
                       <asp:ListItem Selected="True" Value="1">Si</asp:ListItem>
                       <asp:ListItem Value="0">No</asp:ListItem>
                   </asp:DropDownList>
               </ItemTemplate>
               <EditItemTemplate>
                   <asp:DropDownList ID="ddlAPOYO_INSAFORP2" runat="server" 
                       SelectedValue='<%# Bind("APOYO_INSAFORP") %>'>
                       <asp:ListItem Selected="True" Value="1">Si</asp:ListItem>
                       <asp:ListItem Value="0">No</asp:ListItem>
                   </asp:DropDownList>
               </EditItemTemplate>
              <FooterTemplate>
                  <asp:DropDownList ID="APOYO_INSAFORPDropDownList" runat="server">
                      <asp:ListItem Selected="True" Value="1">Si</asp:ListItem>
                      <asp:ListItem Value="0">No</asp:ListItem>
                  </asp:DropDownList>
              </FooterTemplate>
           </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Año">
               <EditItemTemplate>
                   <asp:TextBox ID="TextBox_ANIO1" runat="server" Text='<%# Bind("ANIO") %>'></asp:TextBox>
                   <asp:RequiredFieldValidator ID="rfvTextBox_ANIO1" runat="server" 
                       ControlToValidate="TextBox_ANIO1" ErrorMessage="Año del Curso es Requerido" 
                       ValidationGroup="CursosRecibidos">*</asp:RequiredFieldValidator>
               </EditItemTemplate>
               <FooterTemplate>
                   <asp:TextBox ID="ANIOTextBox" runat="server" Text='<%# Bind("ANIO") %>'></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ANIOTextBox"
                       ErrorMessage="Año del Curso es Requerido" ValidationGroup="AgregarCursoRecibido">*</asp:RequiredFieldValidator>
               </FooterTemplate>
               <ItemTemplate>
                   <asp:Label ID="Label_ANIO1" runat="server" Text='<%# Bind("ANIO", "{0:G}") %>'></asp:Label>
               </ItemTemplate>
               <ItemStyle HorizontalAlign="Right" />
           </asp:TemplateField>
           <asp:TemplateField ShowHeader="False">
               <EditItemTemplate>
                   <asp:LinkButton ID="LinkButton3" runat="server" CausesValidation="True" CommandName="Update"
                       Text="Actualizar" ValidationGroup="CursosRecibidos"></asp:LinkButton>
                   &nbsp;<asp:LinkButton ID="LinkButton4" runat="server" CausesValidation="False" CommandName="Cancel"
                       Text="Cancelar"></asp:LinkButton>
               </EditItemTemplate>
               <ItemTemplate>
                   <asp:LinkButton ID="LinkButton5" runat="server" CausesValidation="False" CommandName="Edit"
                       Text="Editar"></asp:LinkButton>
                   &nbsp;<asp:LinkButton ID="LinkButton6" runat="server" CausesValidation="False" CommandName="Eliminar"
                       Text="Eliminar" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_CURSO_RECIBIDO") %>'></asp:LinkButton>
               </ItemTemplate>
               <FooterTemplate>
                   <asp:LinkButton ID="InsertLinkButton" runat="server" CommandName="Agregar" ValidationGroup="AgregarCursoRecibido">Agregar</asp:LinkButton>
               </FooterTemplate>
           </asp:TemplateField>
           <asp:TemplateField>
                  <EditItemTemplate>
                      <asp:LinkButton ID="LinkButton2" runat="server" CommandName="Delete" CausesValidation="False"
                          ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_CURSO_RECIBIDO") %>'>
                          <asp:Image ID="Image2" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.gif"
                              Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
                  </EditItemTemplate>
                  <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_CURSO_RECIBIDO") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.gif" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>

</asp:GridView>

<asp:ObjectDataSource ID="odsLista" runat="server" 
    DeleteMethod="EliminarSOLIC_CURSOS_RECIBIDOS" 
    InsertMethod="AgregarSOLIC_CURSOS_RECIBIDOS" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SGAFP.BL.cSOLIC_CURSOS_RECIBIDOS" 
    UpdateMethod="ActualizarSOLIC_CURSOS_RECIBIDOS">
    <DeleteParameters>
        <asp:Parameter Name="ID_CURSO_RECIBIDO" Type="Decimal" />
    </DeleteParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CURSO_RECIBIDO" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_CURSO" Type="String" />
        <asp:Parameter Name="INSTITUCION_CURSO" Type="String" />
        <asp:Parameter Name="APOYO_INSAFORP" Type="Decimal" />
        <asp:Parameter Name="ANIO" Type="Decimal" />
    </UpdateParameters>
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter Name="ID_CURSO_RECIBIDO" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_CURSO" Type="String" />
        <asp:Parameter Name="INSTITUCION_CURSO" Type="String" />
        <asp:Parameter Name="APOYO_INSAFORP" Type="Decimal" />
        <asp:Parameter Name="ANIO" Type="Decimal" />
    </InsertParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsListaPorSOLICITUD_INSCRIPCION_AF" runat="server" 
    DeleteMethod="EliminarSOLIC_CURSOS_RECIBIDOS" 
    InsertMethod="AgregarSOLIC_CURSOS_RECIBIDOS" 
    OldValuesParameterFormatString="original_{0}" 
    SelectMethod="ObtenerListaPorSOLICITUD_INSCRIPCION_AF" 
    TypeName="SGAFP.BL.cSOLIC_CURSOS_RECIBIDOS" 
    UpdateMethod="ActualizarSOLIC_CURSOS_RECIBIDOS">
    <DeleteParameters>
        <asp:Parameter Name="ID_CURSO_RECIBIDO" Type="Decimal" />
    </DeleteParameters>
    <UpdateParameters>
        <asp:Parameter Name="ID_CURSO_RECIBIDO" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_CURSO" Type="String" />
        <asp:Parameter Name="INSTITUCION_CURSO" Type="String" />
        <asp:Parameter Name="APOYO_INSAFORP" Type="Decimal" />
        <asp:Parameter Name="ANIO" Type="Decimal" />
    </UpdateParameters>
    <SelectParameters>
        <asp:Parameter DefaultValue="0" Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="" Name="asColumnaOrden" Type="String" />
        <asp:Parameter Name="asTipoOrden" Type="String" />
    </SelectParameters>
    <InsertParameters>
        <asp:Parameter Name="ID_CURSO_RECIBIDO" Type="Decimal" />
        <asp:Parameter Name="ID_SOLICITUD" Type="Decimal" />
        <asp:Parameter Name="NOMBRE_CURSO" Type="String" />
        <asp:Parameter Name="INSTITUCION_CURSO" Type="String" />
        <asp:Parameter Name="APOYO_INSAFORP" Type="Decimal" />
        <asp:Parameter Name="ANIO" Type="Decimal" />
    </InsertParameters>
</asp:ObjectDataSource>


<%--    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="gvLista" EventName="RowDeleted" />
        <asp:AsyncPostBackTrigger ControlID="gvLista" EventName="PageIndexChanged" />
        <asp:AsyncPostBackTrigger ControlID="gvLista" EventName="RowEditing" />
        <asp:AsyncPostBackTrigger ControlID="gvLista" EventName="RowUpdated" />
        <asp:AsyncPostBackTrigger ControlID="gvLista" 
            EventName="SelectedIndexChanged" />
        <asp:AsyncPostBackTrigger ControlID="gvLista" EventName="RowCommand" />
        <asp:AsyncPostBackTrigger ControlID="gvLista" EventName="RowCreated" />
    </Triggers>
</asp:UpdatePanel>--%>