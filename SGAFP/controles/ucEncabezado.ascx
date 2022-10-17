<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucEncabezado.ascx.vb" Inherits="controles_ucEncabezado" %>
<table cellSpacing="0" cellPadding="0" width="100%" bgColor="darkblue" border="0">
	<tr>
		<td width="8" height="27"><IMG height="27" src="imagenes/spacer.gif" width="8"></td>
		<td vAlign="bottom" align="center"><a href="Default.aspx"><IMG style="WIDTH: 70px; HEIGHT: 56px" height="56" src="imagenes/logoAplicacion.gif" width="70"/></a>
		</td>
		<td vAlign="bottom" align="center"><IMG height="27" src="imagenes/spacer.gif" width="8"/>
		</td>
		<td vAlign="bottom" align="center"><IMG height="27" src="imagenes/spacer.gif" width="8"/>
		</td>
		<td vAlign="bottom" align="center"><A href="#" target="_blank"><IMG alt="" src="imagenes/Ayuda.gif"></A>&nbsp;
			<asp:label id="Label_Usuario" runat="server" CssClass="EncabezadoSecciones"></asp:label></td>
		<td width="8"><IMG height="1" src="imagenes/spacer.gif" width="8"></td>
	</tr>
</table>
<asp:label id="Label_Mensaje" runat="server" CssClass="MensajeError"></asp:label>
<asp:validationsummary id="ValidationSummary1" runat="server" CssClass="MensajeError" ShowMessageBox="True" Width="100%"></asp:validationsummary>
