<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaETAPA.ascx.vb" Inherits="controles_ucListaETAPA" %>
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
	   	   <asp:TemplateField HeaderText="Codigo etapa" ItemStyle-HorizontalAlign="Left"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.CODIGO_ETAPA") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.CODIGO_ETAPA") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_CODIGO_ETAPA" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.CODIGO_ETAPA") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:TemplateField HeaderText="Estado solicitud">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_ESTADO_SOLICITUD1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ESTADO_SOLICITUD") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlESTADO_SOLICITUD id="ddlESTADO_SOLICITUD1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlESTADO_SOLICITUD></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_ESTADO_SOLICITUD2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ESTADO_SOLICITUD") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlESTADO_SOLICITUD id="ddlESTADO_SOLICITUD2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlESTADO_SOLICITUD></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:BoundField DataField="UNIDAD_DE_TIEMPO" HeaderText="Unidad de tiempo"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="NOMBRE_ETAPA" HeaderText="Nombre etapa"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="ETAPA_ANT" HeaderText="Etapa ant"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="ETAPA_SIG" HeaderText="Etapa sig"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="TIPO_ETAPA" HeaderText="Tipo etapa"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="DURACION" HeaderText="Duracion"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="ORDEN_EJECUCION" HeaderText="Orden ejecucion"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="USERID" HeaderText="Userid"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="LASTUPDATE" HeaderText="Lastupdate"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.CODIGO_ETAPA") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.gif" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>

</asp:GridView>
