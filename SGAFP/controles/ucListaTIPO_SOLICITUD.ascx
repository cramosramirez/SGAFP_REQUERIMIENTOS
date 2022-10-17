<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaTIPO_SOLICITUD.ascx.vb" Inherits="controles_ucListaTIPO_SOLICITUD" %>
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
	   	   <asp:TemplateField HeaderText="Id tipo solicitud" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_TIPO_SOLICITUD") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_TIPO_SOLICITUD") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_TIPO_SOLICITUD" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_TIPO_SOLICITUD") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:TemplateField HeaderText="Proceso">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_CODIGO_PROCESO1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.CODIGO_PROCESO") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlPROCESO id="ddlPROCESO1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlPROCESO></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_CODIGO_PROCESO2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.CODIGO_PROCESO") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlPROCESO id="ddlPROCESO2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlPROCESO></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:BoundField DataField="TIPO_SOLICITUD" HeaderText="Tipo solicitud"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="TABLA_RELACIONAL" HeaderText="Tabla relacional"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="NOTAS" HeaderText="Notas"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USERID" HeaderText="Userid"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="LASTUPDATE" HeaderText="Lastupdate"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_TIPO_SOLICITUD") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.gif" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>

</asp:GridView>
