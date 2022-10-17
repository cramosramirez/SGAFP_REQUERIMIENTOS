<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucListaEVALUACIONES_AF_DET.ascx.vb" Inherits="controles_ucListaEVALUACIONES_AF_DET" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>

<script language="javascript" type="text/javascript">
    function ValidarNota(s, e) {       
        if (e.Value >= 0 && e.Value <= 10) {
            var _numero = e.Value.toString();
            var pos = _numero.indexOf('.');            
            if (pos != -1) {
                var res = _numero.substring(pos + 1, _numero.length);                
                if (res.length > 2 || res.length == 0) { e.IsValid = false; } else { e.IsValid = true; }                
            }
            else {
                e.IsValid = true;
            }            
        }
        else {
            e.IsValid = false;
        }         
    } 
</script>
<asp:GridView ID="gvLista" CssClass="Normal" AutoGenerateColumns="False" Font-Size="X-Small" Font-Names="Arial" AllowSorting="True" runat="server" AllowPaging="True" >
	   <Columns>
         <asp:TemplateField ShowHeader="False" Visible="False">
             <ItemTemplate>
                 <asp:LinkButton ID="LinkButton_Seleccionar" runat="server" CausesValidation="False" CommandName="Select"
                     Text="Seleccionar"></asp:LinkButton>
                 <asp:CheckBox ID="CheckBox_Seleccionar" runat="server" Visible="False" />
             </ItemTemplate>
         </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Id evaluacion det" ItemStyle-HorizontalAlign="Right"> 
	   	   	   <ItemTemplate> 
                 <asp:LinkButton ID="LinkButtonDetalle" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_EVALUACION_DET") %>'
                     CommandName="Editar" Text='<%# DataBinder.Eval(Container, "DataItem.ID_EVALUACION_DET") %>'></asp:LinkButton>
	   	   	   	   <asp:Label id="Label_ID_EVALUACION_DET" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_EVALUACION_DET") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate> 
                <ItemStyle HorizontalAlign="Right"></ItemStyle>
	   	   </asp:TemplateField>
           <asp:TemplateField HeaderText="ID_PARTIC.">
               <ItemTemplate>
                   <asp:Label ID="Label_ID_PARTICIPANTE1" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ID_PARTICIPANTE") %>'>
                   </asp:Label>
               </ItemTemplate>
               <EditItemTemplate>
                   <asp:Label ID="Label_ID_PARTICIPANTE2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_PARTICIPANTE") %>'>
                   </asp:Label>
                   <cc1:ddlPARTICIPANTE ID="ddlPARTICIPANTE2" runat="server" AutoPostBack="True" CssClass="DDLClass">
                   </cc1:ddlPARTICIPANTE>
                   </TD>
               </EditItemTemplate>
           </asp:TemplateField>
           <asp:TemplateField HeaderText="APELLIDOS">
               <ItemTemplate>
                   <asp:Label ID="Label_Apellidos" runat="server">
                   </asp:Label>
               </ItemTemplate>
           </asp:TemplateField>
           <asp:TemplateField HeaderText="NOMBRES">
               <ItemTemplate>
                   <asp:Label ID="Label_Nombres" runat="server">
                   </asp:Label>
               </ItemTemplate>
           </asp:TemplateField>           
           <asp:TemplateField HeaderText="Evaluacion af">
	   	   	   <ItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_EVALUACION_AF1" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_EVALUACION_AF") %>'>
	   	   	   	   </asp:Label>
	   	   	   </ItemTemplate>
	   	   	   <EditItemTemplate>
	   	   	   	   <asp:Label id="Label_ID_EVALUACION_AF2" runat="server" Visible="False" Text='<%# DataBinder.Eval(Container, "DataItem.ID_EVALUACION_AF") %>'>
	   	   	   	   </asp:Label>
	   	   	   </EditItemTemplate>
	   	   </asp:TemplateField>
	   	   <asp:TemplateField HeaderText="Nota obtenida">
               <EditItemTemplate>
                   <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("NOTA_OBTENIDA") %>'></asp:TextBox>
                   <asp:RangeValidator ID="RangeValidator1" runat="server" 
                       ErrorMessage="Nota debe ser  de 0-10" MaximumValue="10" MinimumValue="0" 
                       Type="Integer"></asp:RangeValidator>
               </EditItemTemplate>
               <ItemTemplate>
                   <asp:Label ID="Label1" runat="server" 
                       Text='<%# Bind("NOTA_OBTENIDA", "{0:c}") %>'></asp:Label>
               </ItemTemplate>
               <ItemStyle HorizontalAlign="Right" />
           </asp:TemplateField>
	   	   <asp:BoundField DataField="NOTAS" HeaderText="Notas"  ItemStyle-HorizontalAlign="Left">
<ItemStyle HorizontalAlign="Left"></ItemStyle>
           </asp:BoundField>
	   	   <asp:TemplateField HeaderText="Nota Obtenida" Visible="False">
               <ItemTemplate>
                   <asp:TextBox ID="TextBox_NotaObtenida" runat="server"   
                       Text='<%# Bind("NOTA_OBTENIDA") %>'></asp:TextBox>
                   <asp:CustomValidator ID="cusValidator1" runat="server" ControlToValidate="TextBox_NotaObtenida" Display="Dynamic" ClientValidationFunction="ValidarNota" ErrorMessage="Nota no válida"></asp:CustomValidator>                    
               </ItemTemplate>
           </asp:TemplateField>
           <asp:TemplateField HeaderText="Observacion" Visible="False">
               <ItemTemplate>
                   <asp:TextBox ID="TextBox_Notas" runat="server" Text='<%# Bind("NOTAS") %>'></asp:TextBox>
               </ItemTemplate>
           </asp:TemplateField>
	   	   <asp:TemplateField>
	   	   	   <ItemTemplate>
	   	   	   	   <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" CausesValidation="False" ToolTip='<%# DataBinder.Eval(Container, "DataItem.ID_EVALUACION_DET") %>'>
	   	   	   	   <asp:Image ID="Image1" AlternateText="Eliminar el Registro" runat="server" ImageUrl="~/imagenes/Eliminar.gif" Width="18px" Height="18px" BorderStyle="None" /></asp:LinkButton>
	   	   	   </ItemTemplate>
	   	   </asp:TemplateField>
	   </Columns>

</asp:GridView>
