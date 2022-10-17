<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantSOLIC_EMPLEO_ACTUAL.ascx.vb" Inherits="controles_ucMantSOLIC_EMPLEO_ACTUAL" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaSOLIC_EMPLEO_ACTUAL" Src="~/controles/ucListaSOLIC_EMPLEO_ACTUAL.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleSOLIC_EMPLEO_ACTUAL" Src="~/controles/ucVistaDetalleSOLIC_EMPLEO_ACTUAL.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Solic empleo actual</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaSOLIC_EMPLEO_ACTUAL id="ucListaSOLIC_EMPLEO_ACTUAL1" runat="server"></uc1:ucListaSOLIC_EMPLEO_ACTUAL>
                <uc1:ucVistaDetalleSOLIC_EMPLEO_ACTUAL ID="ucVistaDetalleSOLIC_EMPLEO_ACTUAL1" runat="server" Visible="false" ></uc1:ucVistaDetalleSOLIC_EMPLEO_ACTUAL></TD>
        </TR>
    </TBODY>
</TABLE>
