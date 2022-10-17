<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantOPCION_MENU.ascx.vb" Inherits="controles_ucMantOPCION_MENU" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaOPCION_MENU" Src="~/controles/ucListaOPCION_MENU.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleOPCION_MENU" Src="~/controles/ucVistaDetalleOPCION_MENU.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Opcion menu</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaOPCION_MENU id="ucListaOPCION_MENU1" runat="server"></uc1:ucListaOPCION_MENU>
                <uc1:ucVistaDetalleOPCION_MENU ID="ucVistaDetalleOPCION_MENU1" runat="server" Visible="false" ></uc1:ucVistaDetalleOPCION_MENU></TD>
        </TR>
    </TBODY>
</TABLE>
