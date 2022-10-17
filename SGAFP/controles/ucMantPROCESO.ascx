<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantPROCESO.ascx.vb" Inherits="controles_ucMantPROCESO" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPROCESO" Src="~/controles/ucListaPROCESO.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetallePROCESO" Src="~/controles/ucVistaDetallePROCESO.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Proceso</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaPROCESO id="ucListaPROCESO1" runat="server"></uc1:ucListaPROCESO>
                <uc1:ucVistaDetallePROCESO ID="ucVistaDetallePROCESO1" runat="server" Visible="false" ></uc1:ucVistaDetallePROCESO></TD>
        </TR>
    </TBODY>
</TABLE>
