<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantPROVEEDOR_AF.ascx.vb" Inherits="controles_ucMantPROVEEDOR_AF" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPROVEEDOR_AF" Src="~/controles/ucListaPROVEEDOR_AF.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetallePROVEEDOR_AF" Src="~/controles/ucVistaDetallePROVEEDOR_AF.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">PROVEEDORES DE CAPACITACION</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaPROVEEDOR_AF id="ucListaPROVEEDOR_AF1" runat="server"></uc1:ucListaPROVEEDOR_AF>
                <uc1:ucVistaDetallePROVEEDOR_AF ID="ucVistaDetallePROVEEDOR_AF1" runat="server" Visible="false" ></uc1:ucVistaDetallePROVEEDOR_AF></TD>
        </TR>
    </TBODY>
</TABLE>
