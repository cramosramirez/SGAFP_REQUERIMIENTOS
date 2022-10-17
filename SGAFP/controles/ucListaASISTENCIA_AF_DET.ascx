<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaASISTENCIA_AF_DET.ascx.vb" Inherits="controles_ucListaASISTENCIA_AF_DET" %>
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
	   	   <asp:TemplateField HeaderText="Id asistencia det" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                   <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_ASISTENCIA_DET") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ASISTENCIA_DET") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_ASISTENCIA_DET" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ASISTENCIA_DET") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 

<ItemStyle HorizontalAlign="Right"></ItemStyle>
	   	   </asp:TemplateField> 
	   	   <asp:TemplateField HeaderText="Asistencia af">
	   	   	   <ItemTemplate>
<%--	   	   	   	   <asp:Label id="Label_ID_ASISTENCIA_AF1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ASISTENCIA_AF") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlASISTENCIA_AF id="ddlASISTENCIA_AF1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlASISTENCIA_AF></TD>
--%>	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
<%--	   	   	   	   <asp:Label id="Label_ID_ASISTENCIA_AF2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_ASISTENCIA_AF") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlASISTENCIA_AF id="ddlASISTENCIA_AF2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlASISTENCIA_AF></TD>
--%>	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="ID PARTIC.">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_PARTICIPANTE1" runat="server" Visible="True" Text='<%# DataBinder.Eval(Container, "DataItem.ID_PARTICIPANTE") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
<%--	   	   	   	   <asp:Label id="Label_ID_PARTICIPANTE2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_PARTICIPANTE") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlPARTICIPANTE id="ddlPARTICIPANTE2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlPARTICIPANTE></TD>
--%>	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:BoundField HeaderText="APELLIDOS" DataField="APELLIDOS" />
           <asp:BoundField HeaderText="NOMBRES" DataField="NOMBRES" />           
           <asp:TemplateField HeaderText="ASISTIO">
               <ItemTemplate>
                   <asp:CheckBox ID="CheckBox_ASISTIO" runat="server" Checked='<%# IIF(Eval("ASISTIO")="SI",True,False) %>'
                       AutoPostBack="True" />
               </ItemTemplate>
               <ItemStyle HorizontalAlign="Left" />
           </asp:TemplateField>
           <asp:TemplateField HeaderText="JUSTIFICO">
               <ItemTemplate>
                   <asp:CheckBox ID="CheckBox_PRESENTA_JUSTIFICACION" runat="server" Checked='<%# IIF(Eval("PRESENTA_JUSTIFICACION")="SI",True,False) %>'
                       AutoPostBack="True" OnCheckedChanged="CheckBox_PRESENTA_JUSTIFICACION_CheckedChanged" />
               </ItemTemplate>
               <ItemStyle HorizontalAlign="Left" />
           </asp:TemplateField>
           <asp:TemplateField HeaderText="JUSTIFICACION">
               <ItemTemplate>
                   <asp:TextBox ID="TextBox_JUSTIFICACION" runat="server" Text='<%# Bind("JUSTIFICACION") %>'
                       Enabled='<%# IIF(Eval("PRESENTA_JUSTIFICACION")="SI",True,False) %>'></asp:TextBox>
               </ItemTemplate>
               <ItemStyle HorizontalAlign="Left" />
           </asp:TemplateField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_ASISTENCIA_DET") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.gif" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>

</asp:GridView>
