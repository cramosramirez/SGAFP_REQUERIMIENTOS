<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantHALLAZGO_SUPERVISION.ascx.vb" Inherits="controles_ucMantHALLAZGO_SUPERVISION" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaHALLAZGO_SUPERVISION" Src="~/controles/ucListaHALLAZGO_SUPERVISION.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleHALLAZGO_SUPERVISION" Src="~/controles/ucVistaDetalleHALLAZGO_SUPERVISION.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Hallazgo supervision</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaHALLAZGO_SUPERVISION id="ucListaHALLAZGO_SUPERVISION1" runat="server"></uc1:ucListaHALLAZGO_SUPERVISION>
                <uc1:ucVistaDetalleHALLAZGO_SUPERVISION ID="ucVistaDetalleHALLAZGO_SUPERVISION1" runat="server" Visible="false" ></uc1:ucVistaDetalleHALLAZGO_SUPERVISION></TD>
        </TR>
    </TBODY>
</TABLE>
