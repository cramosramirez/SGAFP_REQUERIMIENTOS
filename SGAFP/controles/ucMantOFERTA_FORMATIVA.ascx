<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantOFERTA_FORMATIVA.ascx.vb" Inherits="controles_ucMantOFERTA_FORMATIVA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaOFERTA_FORMATIVA" Src="~/controles/ucListaOFERTA_FORMATIVA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleOFERTA_FORMATIVA" Src="~/controles/ucVistaDetalleOFERTA_FORMATIVA.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Oferta formativa</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaOFERTA_FORMATIVA id="ucListaOFERTA_FORMATIVA1" runat="server"></uc1:ucListaOFERTA_FORMATIVA>
                <uc1:ucVistaDetalleOFERTA_FORMATIVA ID="ucVistaDetalleOFERTA_FORMATIVA1" runat="server" Visible="false" ></uc1:ucVistaDetalleOFERTA_FORMATIVA></TD>
        </TR>
    </TBODY>
</TABLE>
