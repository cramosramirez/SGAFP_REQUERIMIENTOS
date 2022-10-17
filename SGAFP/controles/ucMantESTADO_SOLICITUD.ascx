<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantESTADO_SOLICITUD.ascx.vb" Inherits="controles_ucMantESTADO_SOLICITUD" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaESTADO_SOLICITUD" Src="~/controles/ucListaESTADO_SOLICITUD.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleESTADO_SOLICITUD" Src="~/controles/ucVistaDetalleESTADO_SOLICITUD.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Estado solicitud</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaESTADO_SOLICITUD id="ucListaESTADO_SOLICITUD1" runat="server"></uc1:ucListaESTADO_SOLICITUD>
                <uc1:ucVistaDetalleESTADO_SOLICITUD ID="ucVistaDetalleESTADO_SOLICITUD1" runat="server" Visible="false" ></uc1:ucVistaDetalleESTADO_SOLICITUD></TD>
        </TR>
    </TBODY>
</TABLE>
