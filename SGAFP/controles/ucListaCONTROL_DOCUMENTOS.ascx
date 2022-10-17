<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaCONTROL_DOCUMENTOS.ascx.vb" Inherits="controles_ucListaCONTROL_DOCUMENTOS" %>
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
	   	   <asp:TemplateField HeaderText="Numero documento" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.NUMERO_DOCUMENTO") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.NUMERO_DOCUMENTO") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_NUMERO_DOCUMENTO" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.NUMERO_DOCUMENTO") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:BoundField DataField="NUMERO_PATRONAL" HeaderText="Numero patronal"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="NUMERO_FOLIO" HeaderText="Numero folio"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField HeaderText="Tipo solicitud">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_TIPO_SOLICITUD1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_TIPO_SOLICITUD") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlTIPO_SOLICITUD id="ddlTIPO_SOLICITUD1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlTIPO_SOLICITUD></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_TIPO_SOLICITUD2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_TIPO_SOLICITUD") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlTIPO_SOLICITUD id="ddlTIPO_SOLICITUD2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlTIPO_SOLICITUD></TD>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Etapa">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_CODIGO_ETAPA1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.CODIGO_ETAPA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlETAPA id="ddlETAPA1" runat="server" AutoPostBack="True" Enabled="False" CssClass="DDLClassDisabled"></cc1:ddlETAPA></TD>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_CODIGO_ETAPA2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.CODIGO_ETAPA") %>'>
	   	   	   	   </asp:Label>
	   	   	   	   <cc1:ddlETAPA id="ddlETAPA2" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlETAPA></TD>
	   	   	   </EditItemTemplate>
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
	   	   <asp:BoundField DataField="NIT" HeaderText="Nit"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="PRESENTADO_POR" HeaderText="Presentado por"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_RECEPCION" HeaderText="Fecha recepcion"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="RESPONSABLE_ACTUAL" HeaderText="Responsable actual"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="RESPONSABLE_ANTERIOR" HeaderText="Responsable anterior"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="PRIORIDAD" HeaderText="Prioridad"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="NO_DOCUMENTO_ORIGEN" HeaderText="No documento origen"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="NO_DOCUMENTO_PADRE" HeaderText="No documento padre"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_REQUERIDA_FIN" HeaderText="Fecha requerida fin"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="NOTAS" HeaderText="Notas"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USERID" HeaderText="Userid"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="LASTUPDATE" HeaderText="Lastupdate"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.NUMERO_DOCUMENTO") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.gif" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>

</asp:GridView>
