<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaOFERTA_FORMATIVA.ascx.vb" Inherits="controles_ucListaOFERTA_FORMATIVA" %>
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
	   	   <asp:TemplateField HeaderText="Id" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_OFERTA_FORMATIVA") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_OFERTA_FORMATIVA") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_OFERTA_FORMATIVA" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_OFERTA_FORMATIVA") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 

<ItemStyle HorizontalAlign="Right"></ItemStyle>
	   	   </asp:TemplateField> 
	   	   <asp:TemplateField HeaderText="Ejercicio">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_EJERCICIO1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_EJERCICIO") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlEJERCICIO id="ddlEJERCICIO1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlEJERCICIO></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_EJERCICIO2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_EJERCICIO") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlEJERCICIO id="ddlEJERCICIO2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlEJERCICIO></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Curso Tema">
	   	   	   <ItemTemplate>
                         <asp:Label ID="Label_ID_TEMA_CURSO1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_TEMA_CURSO") %>'>
                         </asp:Label>
                         <asp:Label ID="Label_TEMA_CURSO" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.TEMA_CURSO") %>'>
                         </asp:Label>
                     </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_TEMA_CURSO2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_TEMA_CURSO") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlCURSO_TEMA id="ddlCURSO_TEMA2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlCURSO_TEMA></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Proveedor">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_PROVEEDOR_AF1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_PROVEEDOR_AF") %>'>
	   	   	   	   </asp:Label>
                         <asp:Label ID="Label_NOMBRE_PROVEEDOR" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.NOMBRE_PROVEEDOR") %>'>
                         </asp:Label>
                     </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_PROVEEDOR_AF2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_PROVEEDOR_AF") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlPROVEEDOR_AF id="ddlPROVEEDOR_AF2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlPROVEEDOR_AF></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:BoundField DataField="DURACION_HORAS" HeaderText="Duracion Horas"  DataFormatString="{0:G}"  ItemStyle-HorizontalAlign="Right">
<ItemStyle HorizontalAlign="Right"></ItemStyle>
           </asp:BoundField>
	   	   <asp:BoundField DataField="COSTO_X_PARTICIPANTE" HeaderText="Costo x Participante"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right">
<ItemStyle HorizontalAlign="Right"></ItemStyle>
           </asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_INICIO_REAL" HeaderText="Fecha Inicio"  
               DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left">
<ItemStyle HorizontalAlign="Left"></ItemStyle>
           </asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_FIN_REAL" HeaderText="Fecha Fin"  
               DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left">
<ItemStyle HorizontalAlign="Left"></ItemStyle>
           </asp:BoundField>
	   	   <asp:BoundField DataField="NOTAS" HeaderText="Notas"  ItemStyle-HorizontalAlign="Left">
<ItemStyle HorizontalAlign="Left"></ItemStyle>
           </asp:BoundField>
	   	   <asp:BoundField DataField="ESTADO" HeaderText="Estado"  ItemStyle-HorizontalAlign="Left">
<ItemStyle HorizontalAlign="Left"></ItemStyle>
           </asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_APROBACION" HeaderText="Fecha Aprobacion"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left">
<ItemStyle HorizontalAlign="Left"></ItemStyle>
           </asp:BoundField>
	   	   <asp:BoundField DataField="USUARIO_APROBACION" HeaderText="Usuario Aprobacion"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left">
<ItemStyle HorizontalAlign="Left"></ItemStyle>
           </asp:BoundField>
	   	   <asp:BoundField DataField="USERID" HeaderText="Usuario Modifica"  ItemStyle-HorizontalAlign="Left">
<ItemStyle HorizontalAlign="Left"></ItemStyle>
           </asp:BoundField>
	   	   <asp:BoundField DataField="LASTUPDATE" HeaderText="Fh Ult. Modificacion"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left">
<ItemStyle HorizontalAlign="Left"></ItemStyle>
           </asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_OFERTA_FORMATIVA") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.gif" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>

</asp:GridView>
