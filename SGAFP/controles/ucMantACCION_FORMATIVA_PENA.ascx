<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantACCION_FORMATIVA_PENA.ascx.vb" Inherits="controles_ucMantACCION_FORMATIVA_PENA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaACCION_FORMATIVA_PENA" Src="~/controles/ucListaACCION_FORMATIVA_PENA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleACCION_FORMATIVA_PENA" Src="~/controles/ucVistaDetalleACCION_FORMATIVA_PENA.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">PENALIZACIONES APLICADAS A CURSO</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaACCION_FORMATIVA_PENA id="ucListaACCION_FORMATIVA_PENA1" PermitirEditar="true" PermitirEditarInline="true" runat="server"></uc1:ucListaACCION_FORMATIVA_PENA>
                <uc1:ucVistaDetalleACCION_FORMATIVA_PENA ID="ucVistaDetalleACCION_FORMATIVA_PENA1" runat="server" Visible="false" ></uc1:ucVistaDetalleACCION_FORMATIVA_PENA></TD>
        </TR>
    </TBODY>
</TABLE>
