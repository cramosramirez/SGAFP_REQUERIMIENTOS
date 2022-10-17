<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantSUPERVISION_AF.ascx.vb" Inherits="controles_ucMantSUPERVISION_AF" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaSUPERVISION_AF" Src="~/controles/ucListaSUPERVISION_AF.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleSUPERVISION_AF" Src="~/controles/ucVistaDetalleSUPERVISION_AF.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Supervision af</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaSUPERVISION_AF id="ucListaSUPERVISION_AF1" runat="server"></uc1:ucListaSUPERVISION_AF>
                <uc1:ucVistaDetalleSUPERVISION_AF ID="ucVistaDetalleSUPERVISION_AF1" runat="server" Visible="false" ></uc1:ucVistaDetalleSUPERVISION_AF></TD>
        </TR>
    </TBODY>
</TABLE>
