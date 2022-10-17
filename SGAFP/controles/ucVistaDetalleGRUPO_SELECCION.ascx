<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleGRUPO_SELECCION.ascx.vb" Inherits="controles_ucVistaDetalleGRUPO_SELECCION" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<table>
    <tr>
        <td><dx:ASPxTextBox CssClass="TextoLlaveDerecha" id="txtID_GRUPO_SELEC" runat="server" ReadOnly="True" Visible="false" Width="170px"></dx:ASPxTextBox></td>
    </tr>
    <tr>
        <td width="300px"></td>
        <td width="150px"><dx:ASPxLabel CssClass="Normal" id="ASPxLabel1" runat="server" Text="No. Contrato/Licitación:"></dx:ASPxLabel></td>
        <td><dx:ASPxTextBox CssClass="TextoLlaveDerecha" id="txtNUM_CONTRATO" runat="server" ReadOnly="True" Width="170px">
            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />     
            </dx:ASPxTextBox></td>
    </tr>
    <tr>
        <td></td>
        <td><dx:ASPxLabel CssClass="Normal" id="ASPxLabel2" runat="server" Text="Fecha de habilitación:"></dx:ASPxLabel></td>
        <td>
            <dx:ASPxDateEdit id="deFECHA_HABILITA" runat="server" EditFormat="Custom" DisplayFormatString="dd/MM/yyyy" Width="170px" >
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />     
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="La fecha es Requerida" IsRequired="True" />                    
			    </ValidationSettings>
			</dx:ASPxDateEdit>
        </td>
    </tr>
    <tr>
        <td></td>
        <td><dx:ASPxLabel CssClass="Normal" id="ASPxLabel5" runat="server" Text="No. de Grupo:"></dx:ASPxLabel></td>
        <td><dx:ASPxTextBox CssClass="TextoLlaveDerecha" id="txtNO_GRUPO" runat="server" ReadOnly="True" Width="170px" >
            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />
            </dx:ASPxTextBox></td>
    </tr>
    <tr id="trCODIGO_GRUPO" runat="server" visible="false" >
        <td></td>
        <td><dx:ASPxLabel CssClass="Normal" id="ASPxLabel6" runat="server" Text="Código de Grupo:"></dx:ASPxLabel></td>
        <td><dx:ASPxTextBox CssClass="TextoLlaveDerecha" id="txtCODIGO" runat="server" ReadOnly="True" Width="170px" >
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />
            </dx:ASPxTextBox></td>
    </tr>
    <tr>
        <td></td>
        <td><dx:ASPxLabel CssClass="Normal" id="ASPxLabel3" runat="server" Text="Fecha de inicio:"></dx:ASPxLabel></td>
        <td>
            <dx:ASPxDateEdit id="deFECHA_INICIO" runat="server" EditFormat="Custom" DisplayFormatString="dd/MM/yyyy" Width="170px" >
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="La fecha es Requerida" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxDateEdit>
        </td>
        <td><dx:ASPxLabel CssClass="Normal" id="ASPxLabel4" runat="server" Text="Fecha de finalización:"></dx:ASPxLabel></td>
        <td>
            <dx:ASPxDateEdit id="deFECHA_FIN" runat="server" EditFormat="Custom" DisplayFormatString="dd/MM/yyyy" Width="170px" >
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="La fecha es Requerida" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxDateEdit>
        </td>
    </tr>
    <tr>
        <td></td>
        <td><dx:ASPxLabel CssClass="Normal" id="ASPxLabel7" runat="server" Text="Lugar de ejecución:"></dx:ASPxLabel></td>
        <th colspan="3" ><dx:ASPxMemo CssClass="TextoLlaveDerecha" id="txtLUGAR_EJECUCION" runat="server" Width="100%" Height="60px" >
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />
            </dx:ASPxMemo></th>
    </tr>
</table>
