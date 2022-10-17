<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantINFORME_FINAL_AF.ascx.vb" Inherits="controles_ucMantINFORME_FINAL_AF" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaINFORME_FINAL_AF" Src="~/controles/ucListaINFORME_FINAL_AF.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleINFORME_FINAL_AF" Src="~/controles/ucVistaDetalleINFORME_FINAL_AF.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Informe final af</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaINFORME_FINAL_AF id="ucListaINFORME_FINAL_AF1" runat="server"></uc1:ucListaINFORME_FINAL_AF>
                <uc1:ucVistaDetalleINFORME_FINAL_AF ID="ucVistaDetalleINFORME_FINAL_AF1" runat="server" Visible="false" ></uc1:ucVistaDetalleINFORME_FINAL_AF></TD>
        </TR>
    </TBODY>
</TABLE>
