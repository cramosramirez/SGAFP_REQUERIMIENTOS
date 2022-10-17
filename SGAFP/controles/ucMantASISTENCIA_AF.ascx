<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantASISTENCIA_AF.ascx.vb" Inherits="controles_ucMantASISTENCIA_AF" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaASISTENCIA_AF" Src="~/controles/ucListaASISTENCIA_AF.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleASISTENCIA_AF" Src="~/controles/ucVistaDetalleASISTENCIA_AF.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Asistencia af</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaASISTENCIA_AF id="ucListaASISTENCIA_AF1" runat="server"></uc1:ucListaASISTENCIA_AF>
                <uc1:ucVistaDetalleASISTENCIA_AF ID="ucVistaDetalleASISTENCIA_AF1" runat="server" Visible="false" ></uc1:ucVistaDetalleASISTENCIA_AF></TD>
        </TR>
    </TBODY>
</TABLE>
