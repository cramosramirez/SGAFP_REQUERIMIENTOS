<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantPROGRAMA_FORMACION.ascx.vb" Inherits="controles_ucMantPROGRAMA_FORMACION" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPROGRAMA_FORMACION" Src="~/controles/ucListaPROGRAMA_FORMACION.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetallePROGRAMA_FORMACION" Src="~/controles/ucVistaDetallePROGRAMA_FORMACION.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Monto de apoyo anual por participante en HTP</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaPROGRAMA_FORMACION id="ucListaPROGRAMA_FORMACION1" VerID_TIPO_PAGO="false" VerLASTUPDATE="false" VerUSERID="false"  PermitirEliminar="false" PermitirEliminarInline="false"  runat="server"></uc1:ucListaPROGRAMA_FORMACION>
                <uc1:ucVistaDetallePROGRAMA_FORMACION ID="ucVistaDetallePROGRAMA_FORMACION1" runat="server" Visible="false" ></uc1:ucVistaDetallePROGRAMA_FORMACION></TD>
        </TR>
    </TBODY>
</TABLE>
