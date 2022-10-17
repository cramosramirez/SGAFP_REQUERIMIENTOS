<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantDESEMBOLSO_MUNI_LIQUI_DET.ascx.vb" Inherits="controles_ucMantDESEMBOLSO_MUNI_LIQUI_DET" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaDESEMBOLSO_MUNI_LIQUI_DET" Src="~/controles/ucListaDESEMBOLSO_MUNI_LIQUI_DET.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleDESEMBOLSO_MUNI_LIQUI_DET" Src="~/controles/ucVistaDetalleDESEMBOLSO_MUNI_LIQUI_DET.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Desembolso muni liqui det</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaDESEMBOLSO_MUNI_LIQUI_DET id="ucListaDESEMBOLSO_MUNI_LIQUI_DET1" runat="server"></uc1:ucListaDESEMBOLSO_MUNI_LIQUI_DET>
                <uc1:ucVistaDetalleDESEMBOLSO_MUNI_LIQUI_DET ID="ucVistaDetalleDESEMBOLSO_MUNI_LIQUI_DET1" runat="server" Visible="false" ></uc1:ucVistaDetalleDESEMBOLSO_MUNI_LIQUI_DET></TD>
        </TR>
    </TBODY>
</TABLE>
