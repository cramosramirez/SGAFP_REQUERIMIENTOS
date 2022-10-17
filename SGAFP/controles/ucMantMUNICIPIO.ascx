<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantMUNICIPIO.ascx.vb" Inherits="controles_ucMantMUNICIPIO" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaMUNICIPIO" Src="~/controles/ucListaMUNICIPIO.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleMUNICIPIO" Src="~/controles/ucVistaDetalleMUNICIPIO.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Municipio</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
		   <TR>
		       <TD><asp:Label id="lblCODIGO_REGION" style="Z-INDEX: 101" runat="server" CssClass="Normal">Region : </asp:Label><cc1:ddlREGION id="ddlREGION1" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlREGION></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image2" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
		   <TR>
		       <TD><asp:Label id="lblCODIGO_DEPARTAMENTO" style="Z-INDEX: 101" runat="server" CssClass="Normal">Departamento : </asp:Label><cc1:ddlDEPARTAMENTO id="ddlDEPARTAMENTO1" runat="server" AutoPostBack="True" CssClass="DDLClass"></cc1:ddlDEPARTAMENTO></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image3" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaMUNICIPIO id="ucListaMUNICIPIO1" runat="server"></uc1:ucListaMUNICIPIO>
                <uc1:ucVistaDetalleMUNICIPIO ID="ucVistaDetalleMUNICIPIO1" runat="server" Visible="false" ></uc1:ucVistaDetalleMUNICIPIO></TD>
        </TR>
    </TBODY>
</TABLE>
