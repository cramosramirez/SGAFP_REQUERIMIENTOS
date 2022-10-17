<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCURSO_TEMA.ascx.vb" Inherits="controles_ucListaCURSO_TEMA" %>
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
	   	   <asp:TemplateField HeaderText="Id tema curso" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_TEMA_CURSO") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_TEMA_CURSO") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_TEMA_CURSO" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_TEMA_CURSO") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:TemplateField HeaderText="Area formacion">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_AREA_FORMACION1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_AREA_FORMACION") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlAREA_FORMACION id="ddlAREA_FORMACION1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlAREA_FORMACION></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_AREA_FORMACION2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_AREA_FORMACION") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlAREA_FORMACION id="ddlAREA_FORMACION2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlAREA_FORMACION></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:BoundField DataField="TEMA_CURSO" HeaderText="Tema curso"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="DURACION_HORAS" HeaderText="Duracion horas"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_ACREDITACION" HeaderText="Fecha acreditacion"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="NOTAS" HeaderText="Notas"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USERID" HeaderText="Userid"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="LASTUPDATE" HeaderText="Lastupdate"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_TEMA_CURSO") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.gif" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>

</asp:GridView>
