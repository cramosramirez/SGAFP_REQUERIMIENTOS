<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaSOLIC_EMPLEO_ANTERIOR.ascx.vb" Inherits="controles_ucListaSOLIC_EMPLEO_ANTERIOR" %>
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
	   	   <asp:TemplateField HeaderText="Id empleo ant" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_EMPLEO_ANT") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_EMPLEO_ANT") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_EMPLEO_ANT" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_EMPLEO_ANT") %>'>
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
	   	   <asp:BoundField DataField="NOMBRE_EMPRESA" HeaderText="Nombre empresa"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="DIRECCION" HeaderText="Direccion"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="ZONA" HeaderText="Zona"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="TELEFONO" HeaderText="Telefono"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FAX" HeaderText="Fax"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="EMAIL" HeaderText="Email"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="ISSS" HeaderText="Isss"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="JEFE_INMEDIATO" HeaderText="Jefe inmediato"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField HeaderText="Ciuu">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ACTIVIDAD_ECONOMICA1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ACTIVIDAD_ECONOMICA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlCIUU id="ddlCIUU1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlCIUU></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ACTIVIDAD_ECONOMICA2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ACTIVIDAD_ECONOMICA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlCIUU id="ddlCIUU2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlCIUU></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:BoundField DataField="PUESTO_CONTRATADO" HeaderText="Puesto contratado"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="PUESTO_ACTUAL" HeaderText="Puesto actual"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="TIEMPO_TRABAJO" HeaderText="Tiempo trabajo"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="AREA_TRABAJO" HeaderText="Area trabajo"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="AREA_OTRO" HeaderText="Area otro"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField HeaderText="Municipio">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_CODIGO_MUNICIPIO1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.CODIGO_MUNICIPIO") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlMUNICIPIO id="ddlMUNICIPIO1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlMUNICIPIO></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_CODIGO_MUNICIPIO2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.CODIGO_MUNICIPIO") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlMUNICIPIO id="ddlMUNICIPIO2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlMUNICIPIO></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Region">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_CODIGO_REGION1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.CODIGO_REGION") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlREGION id="ddlREGION1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlREGION></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_CODIGO_REGION2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.CODIGO_REGION") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlREGION id="ddlREGION2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlREGION></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Departamento">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_CODIGO_DEPARTAMENTO1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.CODIGO_DEPARTAMENTO") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlDEPARTAMENTO id="ddlDEPARTAMENTO1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlDEPARTAMENTO></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_CODIGO_DEPARTAMENTO2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.CODIGO_DEPARTAMENTO") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlDEPARTAMENTO id="ddlDEPARTAMENTO2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlDEPARTAMENTO></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_EMPLEO_ANT") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.gif" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>

</asp:GridView>
