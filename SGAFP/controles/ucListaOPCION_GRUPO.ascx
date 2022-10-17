<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaOPCION_GRUPO.ascx.vb" Inherits="controles_ucListaOPCION_GRUPO" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<asp:GridView ID="gvLista" CssClass="Normal" AutoGenerateColumns="False" AllowSorting="True" runat="server" AllowPaging="True" >





	   <Columns>
         <asp:TemplateField ShowHeader="False" Visible="False">
             <ItemTemplate>
                 <asp:LinkButton ID="LinkButton_Seleccionar" runat="server" CausesValidation="False" CommandName="Select"
                     Text="Seleccionar"></asp:LinkButton>
                 <asp:CheckBox ID="CheckBox_Seleccionar" runat="server" Visible="False" />
             </ItemTemplate>
         </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Id opcion grupo" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_OPCION_GRUPO") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_OPCION_GRUPO") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_OPCION_GRUPO" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_OPCION_GRUPO") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:TemplateField HeaderText="Opcion menu">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_OPCION_MENU1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_OPCION_MENU") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlOPCION_MENU id="ddlOPCION_MENU1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlOPCION_MENU></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_OPCION_MENU2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_OPCION_MENU") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlOPCION_MENU id="ddlOPCION_MENU2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlOPCION_MENU></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Grupo usuario">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_GRUPO_USUARIO1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_GRUPO_USUARIO") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlGRUPO_USUARIO id="ddlGRUPO_USUARIO1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlGRUPO_USUARIO></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_GRUPO_USUARIO2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_GRUPO_USUARIO") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlGRUPO_USUARIO id="ddlGRUPO_USUARIO2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlGRUPO_USUARIO></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:BoundField DataField="FECHA_INGRESO" HeaderText="Fecha ingreso"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="ESTADO" HeaderText="Estado"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USERID" HeaderText="Userid"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="LASTUPDATE" HeaderText="Lastupdate"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_OPCION_GRUPO") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.gif" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>

</asp:GridView>
