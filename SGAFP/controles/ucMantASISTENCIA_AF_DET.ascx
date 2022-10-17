<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantASISTENCIA_AF_DET.ascx.vb" Inherits="controles_ucMantASISTENCIA_AF_DET" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaASISTENCIA_AF_DET" Src="~/controles/ucListaASISTENCIA_AF_DET.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleASISTENCIA_AF_DET" Src="~/controles/ucVistaDetalleASISTENCIA_AF_DET.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Asistencia af det</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaASISTENCIA_AF_DET id="ucListaASISTENCIA_AF_DET1" runat="server"></uc1:ucListaASISTENCIA_AF_DET>
                <uc1:ucVistaDetalleASISTENCIA_AF_DET ID="ucVistaDetalleASISTENCIA_AF_DET1" runat="server" Visible="false" ></uc1:ucVistaDetalleASISTENCIA_AF_DET></TD>
        </TR>
    </TBODY>
</TABLE>
