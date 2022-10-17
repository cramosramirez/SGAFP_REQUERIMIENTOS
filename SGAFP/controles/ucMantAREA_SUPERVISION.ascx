<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantAREA_SUPERVISION.ascx.vb" Inherits="controles_ucMantAREA_SUPERVISION" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaAREA_SUPERVISION" Src="~/controles/ucListaAREA_SUPERVISION.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleAREA_SUPERVISION" Src="~/controles/ucVistaDetalleAREA_SUPERVISION.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Area supervision</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaAREA_SUPERVISION id="ucListaAREA_SUPERVISION1" runat="server"></uc1:ucListaAREA_SUPERVISION>
                <uc1:ucVistaDetalleAREA_SUPERVISION ID="ucVistaDetalleAREA_SUPERVISION1" runat="server" Visible="false" ></uc1:ucVistaDetalleAREA_SUPERVISION></TD>
        </TR>
    </TBODY>
</TABLE>
