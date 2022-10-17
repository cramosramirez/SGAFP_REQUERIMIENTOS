<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantGRUPO_USUARIO.ascx.vb" Inherits="controles_ucMantGRUPO_USUARIO" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaGRUPO_USUARIO" Src="~/controles/ucListaGRUPO_USUARIO.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleGRUPO_USUARIO" Src="~/controles/ucVistaDetalleGRUPO_USUARIO.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Grupo usuario</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaGRUPO_USUARIO id="ucListaGRUPO_USUARIO1" runat="server"></uc1:ucListaGRUPO_USUARIO>
                <uc1:ucVistaDetalleGRUPO_USUARIO ID="ucVistaDetalleGRUPO_USUARIO1" runat="server" Visible="false" ></uc1:ucVistaDetalleGRUPO_USUARIO></TD>
        </TR>
    </TBODY>
</TABLE>
