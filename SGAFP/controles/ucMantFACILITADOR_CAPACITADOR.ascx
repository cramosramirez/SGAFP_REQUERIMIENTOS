<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantFACILITADOR_CAPACITADOR.ascx.vb" Inherits="controles_ucMantFACILITADOR_CAPACITADOR" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaFACILITADOR_CAPACITADOR" Src="~/controles/ucListaFACILITADOR_CAPACITADOR.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleFACILITADOR_CAPACITADOR" Src="~/controles/ucVistaDetalleFACILITADOR_CAPACITADOR.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Facilitador capacitador</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaFACILITADOR_CAPACITADOR id="ucListaFACILITADOR_CAPACITADOR1" runat="server"></uc1:ucListaFACILITADOR_CAPACITADOR>
                <uc1:ucVistaDetalleFACILITADOR_CAPACITADOR ID="ucVistaDetalleFACILITADOR_CAPACITADOR1" runat="server" Visible="false" ></uc1:ucVistaDetalleFACILITADOR_CAPACITADOR></TD>
        </TR>
    </TBODY>
</TABLE>
