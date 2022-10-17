<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaAREA_SUPERVISION.ascx.vb" Inherits="controles_ucListaAREA_SUPERVISION" %>
<asp:GridView ID="gvLista" AutoGenerateColumns="False" AllowSorting="True" runat="server" AllowPaging="True" >
	   <Columns>
         <asp:TemplateField ShowHeader="False" Visible="False">
             <ItemTemplate>
                 <asp:LinkButton ID="LinkButton_Seleccionar" runat="server" CausesValidation="False" CommandName="Select"
                     Text="Seleccionar"></asp:LinkButton>
                 <asp:CheckBox ID="CheckBox_Seleccionar" runat="server" Visible="False" />
             </ItemTemplate>
         </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Id area supervision" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_AREA_SUPERVISION") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_AREA_SUPERVISION") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_AREA_SUPERVISION" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_AREA_SUPERVISION") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:BoundField DataField="AREA_SUPERVISION" HeaderText="Area supervision"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="SANCIONATORIA" HeaderText="Sancionatoria"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="MONTO_SANCION" HeaderText="Monto sancion"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="TIEMPO_SANCION" HeaderText="Tiempo sancion"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="NOTAS" HeaderText="Notas"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_AREA_SUPERVISION") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.gif" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>
</asp:GridView>
