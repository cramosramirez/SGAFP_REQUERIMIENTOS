<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantOPCION_GRUPO.ascx.vb" Inherits="controles_ucMantOPCION_GRUPO" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaOPCION_GRUPO" Src="~/controles/ucListaOPCION_GRUPO.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleOPCION_GRUPO" Src="~/controles/ucVistaDetalleOPCION_GRUPO.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Opcion grupo</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaOPCION_GRUPO id="ucListaOPCION_GRUPO1" runat="server"></uc1:ucListaOPCION_GRUPO>
                <uc1:ucVistaDetalleOPCION_GRUPO ID="ucVistaDetalleOPCION_GRUPO1" runat="server" Visible="false" ></uc1:ucVistaDetalleOPCION_GRUPO></TD>
        </TR>
    </TBODY>
</TABLE>
