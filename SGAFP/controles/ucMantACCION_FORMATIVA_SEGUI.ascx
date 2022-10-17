<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantACCION_FORMATIVA_SEGUI.ascx.vb" Inherits="controles_ucMantACCION_FORMATIVA_SEGUI" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaACCION_FORMATIVA_SEGUI" Src="~/controles/ucListaACCION_FORMATIVA_SEGUI.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleACCION_FORMATIVA_SEGUI" Src="~/controles/ucVistaDetalleACCION_FORMATIVA_SEGUI.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">VISITAS DE SEGUIMIENTO</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaACCION_FORMATIVA_SEGUI id="ucListaACCION_FORMATIVA_SEGUI1" PermitirEditar="true" PermitirEditarInline="true" runat="server"></uc1:ucListaACCION_FORMATIVA_SEGUI>
                <uc1:ucVistaDetalleACCION_FORMATIVA_SEGUI ID="ucVistaDetalleACCION_FORMATIVA_SEGUI1" runat="server" Visible="false" ></uc1:ucVistaDetalleACCION_FORMATIVA_SEGUI></TD>
        </TR>
    </TBODY>
</TABLE>
