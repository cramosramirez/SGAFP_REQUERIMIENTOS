<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantDESEMBOLSO.ascx.vb" Inherits="controles_ucMantDESEMBOLSO" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaDESEMBOLSO" Src="~/controles/ucListaDESEMBOLSO.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleDESEMBOLSO" Src="~/controles/ucVistaDetalleDESEMBOLSO.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Desembolso</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaDESEMBOLSO id="ucListaDESEMBOLSO1" runat="server"></uc1:ucListaDESEMBOLSO>
                <uc1:ucVistaDetalleDESEMBOLSO ID="ucVistaDetalleDESEMBOLSO1" runat="server" Visible="false" ></uc1:ucVistaDetalleDESEMBOLSO></TD>
        </TR>
    </TBODY>
</TABLE>
