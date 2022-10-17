<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantLISTA_SUPERVISION_AF.ascx.vb" Inherits="controles_ucMantLISTA_SUPERVISION_AF" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaLISTA_SUPERVISION_AF" Src="~/controles/ucListaLISTA_SUPERVISION_AF.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleLISTA_SUPERVISION_AF" Src="~/controles/ucVistaDetalleLISTA_SUPERVISION_AF.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Lista supervision af</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaLISTA_SUPERVISION_AF id="ucListaLISTA_SUPERVISION_AF1" runat="server"></uc1:ucListaLISTA_SUPERVISION_AF>
                <uc1:ucVistaDetalleLISTA_SUPERVISION_AF ID="ucVistaDetalleLISTA_SUPERVISION_AF1" runat="server" Visible="false" ></uc1:ucVistaDetalleLISTA_SUPERVISION_AF></TD>
        </TR>
    </TBODY>
</TABLE>
