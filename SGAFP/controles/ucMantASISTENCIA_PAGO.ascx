<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantASISTENCIA_PAGO.ascx.vb" Inherits="controles_ucMantASISTENCIA_PAGO" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaASISTENCIA_PAGO" Src="~/controles/ucListaASISTENCIA_PAGO.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleASISTENCIA_PAGO" Src="~/controles/ucVistaDetalleASISTENCIA_PAGO.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucbarranavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucbarranavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" runat="server">PARAMETRIZACION DE PORCENTAJES DE ASISTENCIA PARA PAGO DE ACCIONES</asp:Label></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaASISTENCIA_PAGO id="ucListaASISTENCIA_PAGO1" PermitirFiltroEnEncabezado="true" PermitirFilaDeFiltro="false" runat="server"></uc1:ucListaASISTENCIA_PAGO>
                <uc1:ucVistaDetalleASISTENCIA_PAGO ID="ucVistaDetalleASISTENCIA_PAGO1" runat="server" Visible="false" ></uc1:ucVistaDetalleASISTENCIA_PAGO></TD>
        </TR>
    </TBODY>
</TABLE>
