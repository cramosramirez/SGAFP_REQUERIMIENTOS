<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantACCION_PARTI_SINDOCTOS.ascx.vb" Inherits="controles_ucMantACCION_PARTI_SINDOCTOS" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaACCION_PARTI_SINDOCTOS" Src="~/controles/ucListaACCION_PARTI_SINDOCTOS.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetalleACCION_PARTI_SINDOCTOS" Src="~/controles/ucVistaDetalleACCION_PARTI_SINDOCTOS.ascx" %>
<TABLE id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
    <TBODY>
	       <TR>
			   <TD><uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion></TD>
        </TR>
		   <TR>
		      <TD align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">AUTORIZACIONES PARA PARTICIPANTES SIN DOCUMENTOS Y MENORES DE EDAD</asp:Label></TD>
		   </TR>
		   <TR>
			   <TD><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></TD>
		   </TR>
	       <TR>
            <TD><uc1:ucListaACCION_PARTI_SINDOCTOS id="ucListaACCION_PARTI_SINDOCTOS1" runat="server" 
                     VerID_ACCION_PARTI="false" VerUSERID="false" VerLASTUPDATE="false"  
                    PermitirAgregarInline="false" PermitirEditar="false" PermitirEliminar="false"></uc1:ucListaACCION_PARTI_SINDOCTOS>
                <uc1:ucVistaDetalleACCION_PARTI_SINDOCTOS ID="ucVistaDetalleACCION_PARTI_SINDOCTOS1" runat="server" 
                    Visible="false" VerUSERID="false" VerFECHA_CREACION="false" VerUSUARIO_CREACION="false" VerES_ACTIVA="false" VerLASTUPDATE="false" />                
        </TR>
    </TBODY>
</TABLE>
