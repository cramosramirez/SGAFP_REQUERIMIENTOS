<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantTIPO_SOLICITUD.ascx.vb" Inherits="controles_ucMantTIPO_SOLICITUD" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaTIPO_SOLICITUD" Src="~/controles/ucListaTIPO_SOLICITUD.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleTIPO_SOLICITUD" Src="~/controles/ucVistaDetalleTIPO_SOLICITUD.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Tipo solicitud</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaTIPO_SOLICITUD id="ucListaTIPO_SOLICITUD1" runat="server"></uc1:ucListaTIPO_SOLICITUD>
                <uc1:ucVistaDetalleTIPO_SOLICITUD ID="ucVistaDetalleTIPO_SOLICITUD1" runat="server" Visible="false" ></uc1:ucVistaDetalleTIPO_SOLICITUD></TD>
        </TR>
    </TBODY>
</TABLE>
