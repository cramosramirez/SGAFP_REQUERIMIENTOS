<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantETAPA.ascx.vb" Inherits="controles_ucMantETAPA" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaETAPA" Src="~/controles/ucListaETAPA.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleETAPA" Src="~/controles/ucVistaDetalleETAPA.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Etapa</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
		   <TR>
		       <TD><asp:Label id="lblCODIGO_PROCESO" style="Z-INDEX: 101" runat="server" CssClass="Normal">Proceso : </asp:Label><cc1:ddlPROCESO id="ddlPROCESO1" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlPROCESO></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image2" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaETAPA id="ucListaETAPA1" runat="server"></uc1:ucListaETAPA>
                <uc1:ucVistaDetalleETAPA ID="ucVistaDetalleETAPA1" runat="server" Visible="false" ></uc1:ucVistaDetalleETAPA></TD>
        </TR>
    </TBODY>
</TABLE>
