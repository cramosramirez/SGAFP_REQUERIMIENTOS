<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantDEPARTAMENTO.ascx.vb" Inherits="controles_ucMantDEPARTAMENTO" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaDEPARTAMENTO" Src="~/controles/ucListaDEPARTAMENTO.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleDEPARTAMENTO" Src="~/controles/ucVistaDetalleDEPARTAMENTO.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Mantenimiento de Departamento</asp:Label></TD>
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
            <TD><uc1:ucListaDEPARTAMENTO id="ucListaDEPARTAMENTO1" runat="server"></uc1:ucListaDEPARTAMENTO>
                <uc1:ucVistaDetalleDEPARTAMENTO ID="ucVistaDetalleDEPARTAMENTO1" runat="server" Visible="false" ></uc1:ucVistaDetalleDEPARTAMENTO></TD>
        </TR>
    </TBODY>
</TABLE>
