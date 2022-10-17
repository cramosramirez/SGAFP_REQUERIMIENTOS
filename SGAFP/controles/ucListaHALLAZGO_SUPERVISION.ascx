<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaHALLAZGO_SUPERVISION.ascx.vb" Inherits="controles_ucListaHALLAZGO_SUPERVISION" %>
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
	   	   <asp:TemplateField HeaderText="Id hallazgo supervision" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_HALLAZGO_SUPERVISION") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_HALLAZGO_SUPERVISION") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_HALLAZGO_SUPERVISION" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_HALLAZGO_SUPERVISION") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:TemplateField HeaderText="Area supervision">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_AREA_SUPERVISION1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_AREA_SUPERVISION") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlAREA_SUPERVISION id="ddlAREA_SUPERVISION1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlAREA_SUPERVISION></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_AREA_SUPERVISION2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_AREA_SUPERVISION") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlAREA_SUPERVISION id="ddlAREA_SUPERVISION2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlAREA_SUPERVISION></TD>
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
	   	   <asp:BoundField DataField="HALLAZGO_SUPERVISION" HeaderText="Hallazgo supervision"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA" HeaderText="Fecha"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="TIPO_SANCION" HeaderText="Tipo sancion"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="TIEMPO_SANCION" HeaderText="Tiempo sancion"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="MONTO_SANCION" HeaderText="Monto sancion"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="TIEMPO_SUBSANACION" HeaderText="Tiempo subsanacion"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_HALLAZGO_SUPERVISION") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.gif" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>

</asp:GridView>
