<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaSUPERVISION_AF.ascx.vb" Inherits="controles_ucListaSUPERVISION_AF" %>
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
	   	   <asp:TemplateField HeaderText="Id supervision af" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_SUPERVISION_AF") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_SUPERVISION_AF") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_SUPERVISION_AF" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_SUPERVISION_AF") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:TemplateField HeaderText="Modalidad de formacion">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_MODALIDAD_FORMACION1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_MODALIDAD_FORMACION") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlMODALIDAD_DE_FORMACION id="ddlMODALIDAD_DE_FORMACION1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlMODALIDAD_DE_FORMACION></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_MODALIDAD_FORMACION2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_MODALIDAD_FORMACION") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlMODALIDAD_DE_FORMACION id="ddlMODALIDAD_DE_FORMACION2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlMODALIDAD_DE_FORMACION></TD>
	   	   	   </EditItemTemplate>
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
	   	   <asp:BoundField DataField="NOMBRE_AF" HeaderText="Nombre af"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="CENTRO_FORMACION" HeaderText="Centro formacion"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="OPCION" HeaderText="Opcion"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="GRUPO" HeaderText="Grupo"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="HORARIO" HeaderText="Horario"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="CODIGO" HeaderText="Codigo"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="COORDINADOR_CFP" HeaderText="Coordinador cfp"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="DIRECTOR_CFP" HeaderText="Director cfp"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="PARTICIPANTES_PRESENTES" HeaderText="Participantes presentes"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="PARTICIPANTES_AUSENTES" HeaderText="Participantes ausentes"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="PARTICIPANTES_INSCRITOS" HeaderText="Participantes inscritos"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="PARTICIPANTES_DESERTADOS" HeaderText="Participantes desertados"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="PARTICIPANTES_SUPLENTES" HeaderText="Participantes suplentes"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="OBJETIVO_VISITA" HeaderText="Objetivo visita"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="NOTAS" HeaderText="Notas"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="DURACION_VISITA" HeaderText="Duracion visita"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_SUPERVISION_AF") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.gif" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>

</asp:GridView>
