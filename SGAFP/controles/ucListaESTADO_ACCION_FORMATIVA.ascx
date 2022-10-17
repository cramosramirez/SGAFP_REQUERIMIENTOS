<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaESTADO_ACCION_FORMATIVA.ascx.vb" Inherits="controles_ucListaESTADO_ACCION_FORMATIVA" %>
<asp:GridView ID="gvLista" CssClass="Normal" AutoGenerateColumns="False" AllowSorting="True" runat="server" AllowPaging="True" >





	   <Columns>
         <asp:TemplateField ShowHeader="False" Visible="False">
             <ItemTemplate>
                 <asp:LinkButton ID="LinkButton_Seleccionar" runat="server" CausesValidation="False" CommandName="Select"
                     Text="Seleccionar"></asp:LinkButton>
                 <asp:CheckBox ID="CheckBox_Seleccionar" runat="server" Visible="False" />
             </ItemTemplate>
         </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Codigo estado af" ItemStyle-HorizontalAlign="Left"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.CODIGO_ESTADO_AF") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.CODIGO_ESTADO_AF") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_CODIGO_ESTADO_AF" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.CODIGO_ESTADO_AF") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:BoundField DataField="NOMBRE_ESTADO_AF" HeaderText="Nombre estado af"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="ESTADO_INICIAL" HeaderText="Estado inicial"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="PERMITE_INSCRIPCION" HeaderText="Permite inscripcion"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="ESTADO_FINAL" HeaderText="Estado final"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="NOTAS" HeaderText="Notas"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.CODIGO_ESTADO_AF") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.gif" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>

</asp:GridView>
