<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantINFORME_FINAL_DET.ascx.vb" Inherits="controles_ucMantINFORME_FINAL_DET" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaINFORME_FINAL_DET" Src="~/controles/ucListaINFORME_FINAL_DET.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleINFORME_FINAL_DET" Src="~/controles/ucVistaDetalleINFORME_FINAL_DET.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Informe final det</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaINFORME_FINAL_DET id="ucListaINFORME_FINAL_DET1" runat="server"></uc1:ucListaINFORME_FINAL_DET>
                <uc1:ucVistaDetalleINFORME_FINAL_DET ID="ucVistaDetalleINFORME_FINAL_DET1" runat="server" Visible="false" ></uc1:ucVistaDetalleINFORME_FINAL_DET></TD>
        </TR>
    </TBODY>
</TABLE>
