<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantNIVEL_ACADEMICO.ascx.vb" Inherits="controles_ucMantNIVEL_ACADEMICO" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaNIVEL_ACADEMICO" Src="~/controles/ucListaNIVEL_ACADEMICO.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleNIVEL_ACADEMICO" Src="~/controles/ucVistaDetalleNIVEL_ACADEMICO.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Nivel academico</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaNIVEL_ACADEMICO id="ucListaNIVEL_ACADEMICO1" runat="server"></uc1:ucListaNIVEL_ACADEMICO>
                <uc1:ucVistaDetalleNIVEL_ACADEMICO ID="ucVistaDetalleNIVEL_ACADEMICO1" runat="server" Visible="false" ></uc1:ucVistaDetalleNIVEL_ACADEMICO></TD>
        </TR>
    </TBODY>
</TABLE>
