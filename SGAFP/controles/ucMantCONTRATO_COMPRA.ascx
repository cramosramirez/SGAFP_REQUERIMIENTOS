<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantCONTRATO_COMPRA.ascx.vb" Inherits="controles_ucMantCONTRATO_COMPRA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaCONTRATO_COMPRA" Src="~/controles/ucListaCONTRATO_COMPRA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleCONTRATO_COMPRA" Src="~/controles/ucVistaDetalleCONTRATO_COMPRA.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" runat="server">OFERTA DE COMPRA</asp:Label></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaCONTRATO_COMPRA id="ucListaCONTRATO_COMPRA1" PermitirFiltroEnEncabezado="true" PermitirFilaDeFiltro="false" runat="server"></uc1:ucListaCONTRATO_COMPRA>
                <uc1:ucVistaDetalleCONTRATO_COMPRA ID="ucVistaDetalleCONTRATO_COMPRA1" runat="server" Visible="false" ></uc1:ucVistaDetalleCONTRATO_COMPRA></TD>
        </TR>
    </TBODY>
</TABLE>
