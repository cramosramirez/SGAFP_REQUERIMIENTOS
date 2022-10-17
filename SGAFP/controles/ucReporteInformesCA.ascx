<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucReporteInformesCA.ascx.vb" Inherits="controles_ucReporteInformesCA" %>
<%@ Register src="~/controles/ucBarraNavegacion.ascx" tagname="ucBarraNavegacion" tagprefix="uc1" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register src="~/controles/ucReporte.ascx" tagname="ucReporte" tagprefix="uc1" %>


<uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"></uc1:ucBarraNavegacion>
<table>
    <tr>
        <td><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Estado:" /></td>
        <td>
            <dx:ASPxComboBox runat="server" ID="cbxESTADO_INFORME" Width="250px" ValueType="System.Int32"  DropDownStyle="DropDownList">
                <Items>
                    <dx:ListEditItem Text="RECEPCION" Value="1"  />
                    <dx:ListEditItem Text="ASIGNADO" Value="2"  />
                    <dx:ListEditItem Text="DEVUELTO" Value="3"  />
                    <dx:ListEditItem Text="ORDEN DE ENTREGA OBSERVADA" Value="4"  />
                    <dx:ListEditItem Text="FACTURA OBSERVADA" Value="5"  />
                    <dx:ListEditItem Text="EN TRAMITE DE PAGO" Value="6"  />
                    <dx:ListEditItem Text="INFORMES NO PROCESADOS (PLAZO 10 DIAS)" Value="7"  />
                </Items>
            </dx:ASPxComboBox>       
        </td>
    </tr>
    <tr>
        <td><dx:ASPxLabel ID="lblCentro" runat="server" Text="Periodo del:" />  </td>
        <td>
            <dx:ASPxDateEdit ID="dteFECHA_INI" Width="120px"  runat="server" EditFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="true">
                    <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                    <RequiredField IsRequired="True" ErrorText="Fecha inicial es requerida."></RequiredField>
                    </ValidationSettings>
            </dx:ASPxDateEdit>
        </td>
        <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text=" al:" /></td>
        <td>
            <dx:ASPxDateEdit ID="dteFECHA_FIN" Width="120px"  runat="server" EditFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="true">
                    <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                    <RequiredField IsRequired="True" ErrorText="Fecha inicial es requerida."></RequiredField>
                    </ValidationSettings>
            </dx:ASPxDateEdit>
        </td>
    </tr>
</table>
<uc1:ucReporte ID="ucReporte1" runat="server" /> 