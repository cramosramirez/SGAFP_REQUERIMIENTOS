<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantUSUARIO.ascx.vb" Inherits="controles_ucMantUsuario" %>
<%@ Register assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxCallback" tagprefix="dx" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucCriteriosUSUARIO" Src="~/controles/ucCriteriosUSUARIO.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaUSUARIO" Src="~/controles/ucListaUSUARIO.ascx" %>
<script language="javascript" type="text/javascript">
    function Sincronizar(valores) {
        alert('prueba');
        if (valores == "") {
            AsignarMensaje("Debe de seleccionar al menos un Usuario");
            return;
        }
        callSync.PerformCallback(valores);
    }
</script>

<table id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <tbody>             
	        <tr>
			   <td><uc1:ucbarranavegacion id="ucBarraNavegacion1" runat="server" JSClienteItemClick="function(s,e){alert(e.item.name);}" /></td>
            </tr>
            <TR>
		            <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">USUARIOS</asp:Label></td>
	            </TR>
	            <TR>
		            <TD><asp:Image ID="Image2" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
	            </TR>
            <tr>
                <td><uc1:ucCriteriosUSUARIO ID="ucCriteriosUSUARIO1" runat="server" /></td>
            </tr>		   
            <tr>	       
               <td><uc1:ucListaUSUARIO id="ucListaUSUARIO1" runat="server" 
                        PermitirAgregar="True" PermitirEditar="True" PermitirAgregarInline="True" PermitirEliminar="True" />
               </td>
            </tr>
    </tbody>
</table>
<dx:ASPxCallback ID="callSync" runat="server" ClientInstanceName="callSync">
    <ClientSideEvents CallbackComplete="function(s, e) {
	AsignarMensaje(e.result);
}" />
</dx:ASPxCallback>






