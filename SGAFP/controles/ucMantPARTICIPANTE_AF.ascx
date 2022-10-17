<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantPARTICIPANTE_AF.ascx.vb" Inherits="controles_ucMantPARTICIPANTE_AF" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPARTICIPANTE_AF" Src="~/controles/ucListaPARTICIPANTE_AF.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetallePARTICIPANTE_AF" Src="~/controles/ucVistaDetallePARTICIPANTE_AF.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Participante af</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
		   <TR>
		       <TD><asp:Label id="lblID_ACCION_FORMATIVA" style="Z-INDEX: 101" runat="server" CssClass="Normal">Accion formativa : </asp:Label><cc1:ddlACCION_FORMATIVA id="ddlACCION_FORMATIVA1" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlACCION_FORMATIVA></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image2" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaPARTICIPANTE_AF id="ucListaPARTICIPANTE_AF1" runat="server"></uc1:ucListaPARTICIPANTE_AF>
                <uc1:ucVistaDetallePARTICIPANTE_AF ID="ucVistaDetallePARTICIPANTE_AF1" runat="server" Visible="false" ></uc1:ucVistaDetallePARTICIPANTE_AF></TD>
        </TR>
    </TBODY>
</TABLE>
