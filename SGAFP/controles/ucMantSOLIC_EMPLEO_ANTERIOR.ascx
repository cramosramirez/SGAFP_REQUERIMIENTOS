<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantSOLIC_EMPLEO_ANTERIOR.ascx.vb" Inherits="controles_ucMantSOLIC_EMPLEO_ANTERIOR" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaSOLIC_EMPLEO_ANTERIOR" Src="~/controles/ucListaSOLIC_EMPLEO_ANTERIOR.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleSOLIC_EMPLEO_ANTERIOR" Src="~/controles/ucVistaDetalleSOLIC_EMPLEO_ANTERIOR.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Solic empleo anterior</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaSOLIC_EMPLEO_ANTERIOR id="ucListaSOLIC_EMPLEO_ANTERIOR1" runat="server"></uc1:ucListaSOLIC_EMPLEO_ANTERIOR>
                <uc1:ucVistaDetalleSOLIC_EMPLEO_ANTERIOR ID="ucVistaDetalleSOLIC_EMPLEO_ANTERIOR1" runat="server" Visible="false" ></uc1:ucVistaDetalleSOLIC_EMPLEO_ANTERIOR></TD>
        </TR>
    </TBODY>
</TABLE>
