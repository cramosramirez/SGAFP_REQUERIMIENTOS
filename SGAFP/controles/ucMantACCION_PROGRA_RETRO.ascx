<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantACCION_PROGRA_RETRO.ascx.vb" Inherits="controles_ucMantACCION_PROGRA_RETRO" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaACCION_PROGRA_RETRO" Src="~/controles/ucListaACCION_PROGRA_RETRO.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleACCION_PROGRA_RETRO" Src="~/controles/ucVistaDetalleACCION_PROGRA_RETRO.ascx" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

<uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion>
<TABLE width="100%" border="0">    	     
		   <TR>
		       <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">Aplicación de Autorizaciones por curso</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
           <tr>
               <td>
               <table>
                   <tr>
                       <td><dx:ASPxLabel ID="lblProveedor" runat="server" Text="PROVEEDOR:" /></td>
                       <td>
                           <cc1:ddlPROVEEDOR_AF ID="ddlPROVEEDOR_AF1" runat="server" AutoPostBack="True" CssClass="DDLClass" Width="400px">
                            </cc1:ddlPROVEEDOR_AF>
                       </td>
                   </tr>
               </table>
               </td>
           </tr>
	       <TR>
            <TD><uc1:ucListaACCION_PROGRA_RETRO id="ucListaACCION_PROGRA_RETRO1" PermitirEliminar="false" PermitirEliminarInline="false" runat="server"></uc1:ucListaACCION_PROGRA_RETRO>
                <uc1:ucVistaDetalleACCION_PROGRA_RETRO ID="ucVistaDetalleACCION_PROGRA_RETRO1" runat="server" Visible="false" ></uc1:ucVistaDetalleACCION_PROGRA_RETRO></TD>
        </TR>
    
</TABLE>
