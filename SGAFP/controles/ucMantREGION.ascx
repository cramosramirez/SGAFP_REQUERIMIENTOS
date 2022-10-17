<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantREGION.ascx.vb" Inherits="controles_ucMantREGION" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaREGION" Src="~/controles/ucListaREGION.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleREGION" Src="~/controles/ucVistaDetalleREGION.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Region</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaREGION id="ucListaREGION1" runat="server"></uc1:ucListaREGION>
                <uc1:ucVistaDetalleREGION ID="ucVistaDetalleREGION1" runat="server" Visible="false" ></uc1:ucVistaDetalleREGION></TD>
        </TR>
    </TBODY>
</TABLE>
