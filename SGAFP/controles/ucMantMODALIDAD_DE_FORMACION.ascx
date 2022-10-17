<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantMODALIDAD_DE_FORMACION.ascx.vb" Inherits="controles_ucMantMODALIDAD_DE_FORMACION" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaMODALIDAD_DE_FORMACION" Src="~/controles/ucListaMODALIDAD_DE_FORMACION.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleMODALIDAD_DE_FORMACION" Src="~/controles/ucVistaDetalleMODALIDAD_DE_FORMACION.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Modalidad de formacion</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaMODALIDAD_DE_FORMACION id="ucListaMODALIDAD_DE_FORMACION1" runat="server"></uc1:ucListaMODALIDAD_DE_FORMACION>
                <uc1:ucVistaDetalleMODALIDAD_DE_FORMACION ID="ucVistaDetalleMODALIDAD_DE_FORMACION1" runat="server" Visible="false" ></uc1:ucVistaDetalleMODALIDAD_DE_FORMACION></TD>
        </TR>
    </TBODY>
</TABLE>
