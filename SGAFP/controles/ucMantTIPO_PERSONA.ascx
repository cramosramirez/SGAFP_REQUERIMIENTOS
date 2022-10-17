<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantTIPO_PERSONA.ascx.vb" Inherits="controles_ucMantTIPO_PERSONA" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaTIPO_PERSONA" Src="~/controles/ucListaTIPO_PERSONA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleTIPO_PERSONA" Src="~/controles/ucVistaDetalleTIPO_PERSONA.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Tipo persona</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaTIPO_PERSONA id="ucListaTIPO_PERSONA1" runat="server"></uc1:ucListaTIPO_PERSONA>
                <uc1:ucVistaDetalleTIPO_PERSONA ID="ucVistaDetalleTIPO_PERSONA1" runat="server" Visible="false" ></uc1:ucVistaDetalleTIPO_PERSONA></TD>
        </TR>
    </TBODY>
</TABLE>
