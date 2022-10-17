<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantSITIO_CAPACITACION.ascx.vb" Inherits="controles_ucMantSITIO_CAPACITACION" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaSITIO_CAPACITACION" Src="~/controles/ucListaSITIO_CAPACITACION.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleSITIO_CAPACITACION" Src="~/controles/ucVistaDetalleSITIO_CAPACITACION.ascx" %>
<table id="TableMant" cellspacing="0" cellpadding="0" width="100%" border="0">
    <tr>
        <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></td>
    </tr>    
    
    <TR>
		<TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">CENTROS DE FORMACION</asp:Label></TD>
	</TR>
	<TR>
		<TD><asp:Image ID="Image2" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
	</TR>
    <tr>
        <td>
            <uc1:ucListaSITIO_CAPACITACION id="ucListaSITIO_CAPACITACION1" runat="server" 
                VerCODIGO_DEPARTAMENTO="false" VerCODIGO_MUNICIPIO="false" VerID_PROVEEDOR_AF="false" 
                VerFORMATO_CODIGO_CURSO="false" VerFAX="false" VerEMAIL="false" VerNUMERO_AULAS="false"
                VerFECHA_REGISTRO="false" VerUSERID="false" VerLASTUPDATE="false" VerLATITUD="false" VerLONGITUD="false"                 
            />
            <uc1:ucVistaDetalleSITIO_CAPACITACION ID="ucVistaDetalleSITIO_CAPACITACION1" runat="server" Visible="false"
                VerID_SITIO_CAPACITACION="false" VerFORMATO_CODIGO_CURSO="false" VerNUMERO_AULAS="false" 
                VerLASTUPDATE="false" VerLATITUD="false" VerLONGITUD="false" 
                verUSERID="false" VerFECHA_REGISTRO="false"  />      
             
        </td>
    </tr>
</table>
