<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCriteriosPaqueteInforme.ascx.vb" Inherits="controles_ucCriteriosPaqueteInforme" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register assembly="SGAFP_WebUC" namespace="SGAFP.WebUC" tagprefix="cc1" %>

    <style type="text/css">
        .TextoInfo
        {
            font-family:Verdana, Arial;
            font-size: 8pt;
        }
        .TextoCelda
        {
            font-family:Verdana, Arial;
            font-size: 8pt;
            width:100px; 
        }        
    </style>
    <table style="width: 100%" border="0" cellpadding="0" cellspacing="0">
        <tr id="trPaquete" runat="server">
            <td class="TextoCelda">
                ID PAQUETE:     
            </td>
            <td style="font-size: small;" class="TextoInfo">
                <dx:ASPxTextBox runat="server" ID="txtID_PAQUETE" Width="120px">                     
                </dx:ASPxTextBox>
            </td>
        </tr>
        <tr id="trTecnico" runat="server">            
            <td class="TextoCelda">
                TECNICO:     
            </td>
            <td style="font-size: small;" class="TextoInfo">
                <cc1:ddlUSUARIO ID="ddlUSUARIO1" runat="server" AutoPostBack="True" class="TextoInfo" >
                </cc1:ddlUSUARIO>                
            </td>           
        </tr>
        <tr id="trFecha" runat="server">
            <td class="TextoCelda">
                FECHA: 
            </td>
            <td class="TextoInfo">
              <dx:ASPxDateEdit ID="dteFECHA" Width="120px"  runat="server" EditFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="true" />
            </td>           
        </tr>   
        </table>