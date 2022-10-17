<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantPAQUETE_INFORME_DET.ascx.vb" Inherits="controles_ucMantPAQUETE_INFORME_DET" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPAQUETE_INFORME_DET" Src="~/controles/ucListaPAQUETE_INFORME_DET.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetallePAQUETE_INFORME_DET" Src="~/controles/ucVistaDetallePAQUETE_INFORME_DET.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Paquete informe det</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
		   <TR>
		       <TD><asp:Label id="lblID_PAQUETE" style="Z-INDEX: 101" runat="server" CssClass="Normal">Paquete informe : </asp:Label><cc1:ddlPAQUETE_INFORME id="ddlPAQUETE_INFORME1" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlPAQUETE_INFORME></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="imgSeparador1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaPAQUETE_INFORME_DET id="ucListaPAQUETE_INFORME_DET1" runat="server"></uc1:ucListaPAQUETE_INFORME_DET>
                <uc1:ucVistaDetallePAQUETE_INFORME_DET ID="ucVistaDetallePAQUETE_INFORME_DET1" runat="server" Visible="false" ></uc1:ucVistaDetallePAQUETE_INFORME_DET></TD>
        </TR>
    </TBODY>
</TABLE>
