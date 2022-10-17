<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCIUO.ascx.vb" Inherits="controles_ucListaCIUO" %>
<asp:GridView ID="gvLista" CssClass="Normal" AutoGenerateColumns="False" AllowSorting="True" runat="server" AllowPaging="True" >





	   <Columns>
         <asp:TemplateField ShowHeader="False" Visible="False">
             <ItemTemplate>
                 <asp:LinkButton ID="LinkButton_Seleccionar" runat="server" CausesValidation="False" CommandName="Select"
                     Text="Seleccionar"></asp:LinkButton>
                 <asp:CheckBox ID="CheckBox_Seleccionar" runat="server" Visible="False" />
             </ItemTemplate>
         </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Ciuo" ItemStyle-HorizontalAlign="Left"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.CIUO") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.CIUO") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_CIUO" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.CIUO") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:BoundField DataField="DESCRIPCION" HeaderText="Descripcion"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="DESCRIPCION_NACIONAL" HeaderText="Descripcion nacional"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USERID" HeaderText="Userid"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="LASTUPDATE" HeaderText="Lastupdate"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.CIUO") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.gif" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>

</asp:GridView>
