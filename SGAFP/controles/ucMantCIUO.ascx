<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantCIUO.ascx.vb" Inherits="controles_ucMantCIUO" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaCIUO" Src="~/controles/ucListaCIUO.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleCIUO" Src="~/controles/ucVistaDetalleCIUO.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Ciuo</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaCIUO id="ucListaCIUO1" runat="server"></uc1:ucListaCIUO>
                <uc1:ucVistaDetalleCIUO ID="ucVistaDetalleCIUO1" runat="server" Visible="false" ></uc1:ucVistaDetalleCIUO></TD>
        </TR>
    </TBODY>
</TABLE>
