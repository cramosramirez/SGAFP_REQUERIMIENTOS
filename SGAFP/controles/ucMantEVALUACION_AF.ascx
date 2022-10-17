<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantEVALUACION_AF.ascx.vb" Inherits="controles_ucMantEVALUACION_AF" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaEVALUACION_AF" Src="~/controles/ucListaEVALUACION_AF.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleEVALUACION_AF" Src="~/controles/ucVistaDetalleEVALUACION_AF.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Evaluacion af</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaEVALUACION_AF id="ucListaEVALUACION_AF1" runat="server"></uc1:ucListaEVALUACION_AF>
                <uc1:ucVistaDetalleEVALUACION_AF ID="ucVistaDetalleEVALUACION_AF1" runat="server" Visible="false" ></uc1:ucVistaDetalleEVALUACION_AF></TD>
        </TR>
    </TBODY>
</TABLE>
