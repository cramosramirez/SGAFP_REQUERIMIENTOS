<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaASISTENCIA_AF.ascx.vb" Inherits="controles_ucListaASISTENCIA_AF" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<asp:GridView ID="gvLista" AutoGenerateColumns="False" AllowSorting="True" runat="server" AllowPaging="True" >
	   <Columns>
         <asp:TemplateField ShowHeader="False" Visible="False">
             <ItemTemplate>
                 <asp:LinkButton ID="LinkButton_Seleccionar" runat="server" CausesValidation="False" CommandName="Select"
                     Text="Seleccionar"></asp:LinkButton>
                 <asp:CheckBox ID="CheckBox_Seleccionar" runat="server" Visible="False" />
             </ItemTemplate>
         </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Id asistencia af" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_ASISTENCIA_AF") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ASISTENCIA_AF") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_ASISTENCIA_AF" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ASISTENCIA_AF") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:TemplateField HeaderText="Accion formativa">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_ACCION_FORMATIVA1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ACCION_FORMATIVA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlACCION_FORMATIVA id="ddlACCION_FORMATIVA1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlACCION_FORMATIVA></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_ACCION_FORMATIVA2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ACCION_FORMATIVA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlACCION_FORMATIVA id="ddlACCION_FORMATIVA2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlACCION_FORMATIVA></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:BoundField DataField="FECHA" HeaderText="Fecha"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="INSTRUCTOR" HeaderText="Instructor"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="NOTAS" HeaderText="Comentarios"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_ASISTENCIA_AF") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.gif" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>

</asp:GridView>
