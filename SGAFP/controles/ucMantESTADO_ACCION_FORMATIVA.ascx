<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantESTADO_ACCION_FORMATIVA.ascx.vb" Inherits="controles_ucMantESTADO_ACCION_FORMATIVA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaESTADO_ACCION_FORMATIVA" Src="~/controles/ucListaESTADO_ACCION_FORMATIVA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleESTADO_ACCION_FORMATIVA" Src="~/controles/ucVistaDetalleESTADO_ACCION_FORMATIVA.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Estado accion formativa</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaESTADO_ACCION_FORMATIVA id="ucListaESTADO_ACCION_FORMATIVA1" runat="server"></uc1:ucListaESTADO_ACCION_FORMATIVA>
                <uc1:ucVistaDetalleESTADO_ACCION_FORMATIVA ID="ucVistaDetalleESTADO_ACCION_FORMATIVA1" runat="server" Visible="false" ></uc1:ucVistaDetalleESTADO_ACCION_FORMATIVA></TD>
        </TR>
    </TBODY>
</TABLE>
