<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaSUPERVISION_AF_DET.ascx.vb" Inherits="controles_ucListaSUPERVISION_AF_DET" %>
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
	   	   <asp:TemplateField HeaderText="Id supervision det" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_SUPERVISION_DET") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_SUPERVISION_DET") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_SUPERVISION_DET" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_SUPERVISION_DET") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:TemplateField HeaderText="Lista supervision af">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_LISTA_SUPERVISION1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_LISTA_SUPERVISION") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlLISTA_SUPERVISION_AF id="ddlLISTA_SUPERVISION_AF1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlLISTA_SUPERVISION_AF></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_LISTA_SUPERVISION2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_LISTA_SUPERVISION") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlLISTA_SUPERVISION_AF id="ddlLISTA_SUPERVISION_AF2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlLISTA_SUPERVISION_AF></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Supervision af">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_SUPERVISION_AF1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_SUPERVISION_AF") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlSUPERVISION_AF id="ddlSUPERVISION_AF1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlSUPERVISION_AF></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_SUPERVISION_AF2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_SUPERVISION_AF") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlSUPERVISION_AF id="ddlSUPERVISION_AF2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlSUPERVISION_AF></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:BoundField DataField="COMENTARIOS" HeaderText="Comentarios"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_SUPERVISION_DET") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.gif" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>

</asp:GridView>
