<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantFASE_ESTADO_INFORME.ascx.vb" Inherits="controles_ucMantFASE_ESTADO_INFORME" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaFASE_ESTADO_INFORME" Src="~/controles/ucListaFASE_ESTADO_INFORME.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleFASE_ESTADO_INFORME" Src="~/controles/ucVistaDetalleFASE_ESTADO_INFORME.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Fase estado informe</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaFASE_ESTADO_INFORME id="ucListaFASE_ESTADO_INFORME1" runat="server"></uc1:ucListaFASE_ESTADO_INFORME>
                <uc1:ucVistaDetalleFASE_ESTADO_INFORME ID="ucVistaDetalleFASE_ESTADO_INFORME1" runat="server" Visible="false" ></uc1:ucVistaDetalleFASE_ESTADO_INFORME></TD>
        </TR>
    </TBODY>
</TABLE>
