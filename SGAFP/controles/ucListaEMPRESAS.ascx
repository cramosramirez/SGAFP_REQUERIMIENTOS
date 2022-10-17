<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaEMPRESAS.ascx.vb" Inherits="controles_ucListaEMPRESAS" %>
<asp:GridView ID="gvLista" CssClass="Normal" AutoGenerateColumns="False" AllowSorting="True" runat="server" AllowPaging="True" >





	   <Columns>
         <asp:TemplateField ShowHeader="False" Visible="False">
             <ItemTemplate>
                 <asp:LinkButton ID="LinkButton_Seleccionar" runat="server" CausesValidation="False" CommandName="Select"
                     Text="Seleccionar"></asp:LinkButton>
                 <asp:CheckBox ID="CheckBox_Seleccionar" runat="server" Visible="False" />
             </ItemTemplate>
         </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Numero patronal" ItemStyle-HorizontalAlign="Left"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.NUMERO_PATRONAL") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.NUMERO_PATRONAL") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_NUMERO_PATRONAL" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.NUMERO_PATRONAL") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
	   	   </asp:TemplateField> 
	   	   <asp:BoundField DataField="NIT_EMPRESA" HeaderText="Nit empresa"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="CIUU" HeaderText="Ciuu"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="SECTOR_PRODUCTIVO" HeaderText="Sector productivo"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="CODIGO_ASESOR" HeaderText="Codigo asesor"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="CODIGO_MUNICIPIO" HeaderText="Codigo municipio"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="CODIGO_DEPARTAMENTO" HeaderText="Codigo departamento"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="CODIGO_REGION" HeaderText="Codigo region"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="NOMBRE_EMPRESA" HeaderText="Nombre empresa"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="TIPO_EMPRESA" HeaderText="Tipo empresa"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="CONTACTO_EMPRESA" HeaderText="Contacto empresa"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="TELEFONO_CONTACTO" HeaderText="Telefono contacto"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="CARGO_CONTACTO" HeaderText="Cargo contacto"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="DIRECCION_EMPRESA" HeaderText="Direccion empresa"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="TELEFONO_EMPRESA" HeaderText="Telefono empresa"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FAX_EMPRESA" HeaderText="Fax empresa"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="EMAIL_EMPRESA" HeaderText="Email empresa"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="ESPECIALIDAD_EMPRESA" HeaderText="Especialidad empresa"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="TOTAL_PERSONA" HeaderText="Total persona"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="TOTAL_PLANILLA" HeaderText="Total planilla"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="REPRESENTANTE_LEGAL" HeaderText="Representante legal"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="FECHA_REGISTRO" HeaderText="Fecha registro"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="TOTAL_TRABAJADORES" HeaderText="Total trabajadores"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="FEMENINOS" HeaderText="Femeninos"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="MASCULINOS" HeaderText="Masculinos"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="TAMANO_EMPRESA" HeaderText="Tamano empresa"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="CON_MANDO" HeaderText="Con mando"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="SIN_MANDO" HeaderText="Sin mando"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="ADMINISTRATIVOS" HeaderText="Administrativos"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="MANDOS_MEDIOS" HeaderText="Mandos medios"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="OPERATIVOS" HeaderText="Operativos"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="GERENCIAL" HeaderText="Gerencial"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="SIGLAS" HeaderText="Siglas"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="USERID" HeaderText="Userid"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="LASTUPDATE" HeaderText="Lastupdate"  DataFormatString="{0:d}"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="OBSERVACION" HeaderText="Observacion"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="NUM_PAT_ISSS" HeaderText="Num pat isss"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="TIPOPERSON" HeaderText="Tipoperson"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="NUM" HeaderText="Num"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="REPRESENTANTE_PROFESION" HeaderText="Representante profesion"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="CONTACTO_EMAIL" HeaderText="Contacto email"  ItemStyle-HorizontalAlign="Left"></asp:BoundField>
	   	   <asp:BoundField DataField="APORTE_INSAFORP" HeaderText="Aporte insaforp"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:BoundField DataField="ZONA" HeaderText="Zona"  DataFormatString="{0:c}"  ItemStyle-HorizontalAlign="Right"></asp:BoundField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.NUMERO_PATRONAL") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.gif" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>

</asp:GridView>
