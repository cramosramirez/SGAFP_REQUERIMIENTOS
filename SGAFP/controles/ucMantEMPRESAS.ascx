<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantEMPRESAS.ascx.vb" Inherits="controles_ucMantEMPRESAS" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaEMPRESAS" Src="~/controles/ucListaEMPRESAS.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleEMPRESAS" Src="~/controles/ucVistaDetalleEMPRESAS.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Empresas</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaEMPRESAS id="ucListaEMPRESAS1" runat="server"></uc1:ucListaEMPRESAS>
                <uc1:ucVistaDetalleEMPRESAS ID="ucVistaDetalleEMPRESAS1" runat="server" Visible="false" ></uc1:ucVistaDetalleEMPRESAS></TD>
        </TR>
    </TBODY>
</TABLE>
