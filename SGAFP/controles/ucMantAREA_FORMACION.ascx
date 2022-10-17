<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantAREA_FORMACION.ascx.vb" Inherits="controles_ucMantAREA_FORMACION" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaAREA_FORMACION" Src="~/controles/ucListaAREA_FORMACION.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleAREA_FORMACION" Src="~/controles/ucVistaDetalleAREA_FORMACION.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Area formacion</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaAREA_FORMACION id="ucListaAREA_FORMACION1" runat="server"></uc1:ucListaAREA_FORMACION>
                <uc1:ucVistaDetalleAREA_FORMACION ID="ucVistaDetalleAREA_FORMACION1" runat="server" Visible="false" ></uc1:ucVistaDetalleAREA_FORMACION></TD>
        </TR>
    </TBODY>
</TABLE>
