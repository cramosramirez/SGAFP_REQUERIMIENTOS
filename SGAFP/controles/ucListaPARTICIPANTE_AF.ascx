<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaPARTICIPANTE_AF.ascx.vb" Inherits="controles_ucListaPARTICIPANTE_AF" %>
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
	   	   <asp:TemplateField HeaderText="Id participante" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_PARTICIPANTE") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_PARTICIPANTE") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_PARTICIPANTE" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_PARTICIPANTE") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
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
	   	   <asp:BoundField DataField="ESTADO" HeaderText="Estado"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_INSCRIPCION" HeaderText="Fecha inscripcion"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="NOTA_FINAL" HeaderText="Nota final"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="PORC_ASISTENCIA" HeaderText="Porc asistencia"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="ENTREGA_DIPLOMA" HeaderText="Entrega diploma"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="NOTAS" HeaderText="Notas"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_PARTICIPANTE") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.gif" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>

</asp:GridView>
