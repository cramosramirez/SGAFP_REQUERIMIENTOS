<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantCONTROL_DOCUMENTOS.ascx.vb" Inherits="controles_ucMantCONTROL_DOCUMENTOS" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaCONTROL_DOCUMENTOS" Src="~/controles/ucListaCONTROL_DOCUMENTOS.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleCONTROL_DOCUMENTOS" Src="~/controles/ucVistaDetalleCONTROL_DOCUMENTOS.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Control documentos</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaCONTROL_DOCUMENTOS id="ucListaCONTROL_DOCUMENTOS1" runat="server"></uc1:ucListaCONTROL_DOCUMENTOS>
                <uc1:ucVistaDetalleCONTROL_DOCUMENTOS ID="ucVistaDetalleCONTROL_DOCUMENTOS1" runat="server" Visible="false" ></uc1:ucVistaDetalleCONTROL_DOCUMENTOS></TD>
        </TR>
    </TBODY>
</TABLE>
