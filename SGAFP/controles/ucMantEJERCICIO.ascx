<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantEJERCICIO.ascx.vb" Inherits="controles_ucMantEJERCICIO" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaEJERCICIO" Src="~/controles/ucListaEJERCICIO.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleEJERCICIO" Src="~/controles/ucVistaDetalleEJERCICIO.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Ejercicio</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaEJERCICIO id="ucListaEJERCICIO1" runat="server"></uc1:ucListaEJERCICIO>
                <uc1:ucVistaDetalleEJERCICIO ID="ucVistaDetalleEJERCICIO1" runat="server" Visible="false" ></uc1:ucVistaDetalleEJERCICIO></TD>
        </TR>
    </TBODY>
</TABLE>
