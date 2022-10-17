<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCriteriosAccionFormativa.ascx.vb" Inherits="controles_ucCriteriosAccionFormativa" %>
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
        }        
    </style>
    <table border="0" cellpadding="0" cellspacing="4">
        <tr id="trProveedor" runat="server">
            <td class="TextoCelda" style="width:125px" >
                PROVEEDOR:     
            </td>
            <td style="font-size: small;" class="TextoInfo">
                <cc1:ddlPROVEEDOR_AF ID="ddlPROVEEDOR_AF1" runat="server" AutoPostBack="True" Width="600px"  class="TextoInfo">
                </cc1:ddlPROVEEDOR_AF>
                </td>
            <td class="TextoCelda" style="width:125px"></td>
            <td class="TextoCelda"></td>            
        </tr>
        <tr id="trCentroFormacion" runat="server">
            <td class="TextoCelda">
                CENTRO: 
            </td>
            <td class="TextoInfo">
                <cc1:ddlSITIO_CAPACITACION ID="ddlSITIO_CAPACITACION1" runat="server" class="TextoInfo">
                </cc1:ddlSITIO_CAPACITACION>
                </td>
            <td class="TextoCelda">
            </td>
            <td class="TextoCelda">
            </td>
        </tr>
        
        <tr id="trAreaFormacion" runat="server">
            <td class="TextoCelda">
                AREA FORMACION:         
            </td>
            <td style="font-size: small;" class="TextoInfo">
                <cc1:ddlAREA_FORMACION ID="ddlAREA_FORMACION1" runat="server" class="TextoInfo">
                </cc1:ddlAREA_FORMACION>
            </td>
            <td class="TextoCelda" align="right">
            NOMBRE CURSO:
            </td>
            <td class="TextoCelda">
                <asp:TextBox ID="NOMBRE_CURSOTextBox" runat="server" Columns="8" MaxLength="200"
                    class="TextoInfo" Width="261px" CssClass="NormalUPPER"></asp:TextBox>
            </td>
        </tr>
         <tr id="trCodigoGrupo" runat="server" visible="true">            
            <td class="TextoCelda">
                CODIGO GRUPO:
            </td>
            <td class="TextoCelda">
                <asp:TextBox ID="CODIGO_GRUPOTextBox" runat="server" Columns="8" MaxLength="40"
                    class="TextoInfo" Width="150px" CssClass="NormalUPPER"></asp:TextBox>
                </td>            
            <td class="TextoCelda" align="right">
                <asp:Label ID="Label_TDR" runat="server" Text="TDR/CONTRATO-ITEM:" Visible="False"></asp:Label>
            </td>
            <td class="TextoCelda">
                <asp:TextBox ID="TDRTextBox" runat="server" Columns="8" MaxLength="40"
                    class="TextoInfo" Width="120px" CssClass="NormalUPPER" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr id="trEstado" runat="server" visible="false">
            <td class="TextoCelda">
                ESTADO CURSO:
            </td>
            <td class="TextoCelda">
                <cc1:ddlESTADO_ACCION_FORMATIVA ID="ddlESTADO_ACCION_FORMATIVA1" runat="server" class="TextoInfo">
                </cc1:ddlESTADO_ACCION_FORMATIVA>
                </td>
            <td class="TextoCelda">
                &nbsp;</td>
            <td class="TextoCelda">
            </td>
        </tr>
         <tr id="trEstadoInforme" runat="server" visible="false">
            <td class="TextoCelda">
                ESTADO INFORME:
            </td>
            <td class="TextoCelda">
                <cc1:ddlESTADO_INFORME_AF ID="ddlESTADO_INFORME_AF1" runat="server" class="TextoInfo">
                </cc1:ddlESTADO_INFORME_AF>
                </td>
            <td class="TextoCelda">
                &nbsp;</td>
            <td class="TextoCelda">
            </td>
        </tr>
        <tr id="trEjercicio" runat="server" visible="false">
            <td class="TextoCelda">
                EJERCICIO:                
            </td>
            <td class="TextoCelda">
                <cc1:ddlEJERCICIO ID="ddlEJERCICIO1" runat="server" class="TextoInfo">
                </cc1:ddlEJERCICIO>
                </td>
            <td class="TextoCelda">
            </td>
            <td class="TextoCelda">
            </td>
        </tr>
        <tr id="trContratoLici" runat="server" visible="false">
            <td class="TextoCelda">
                CONTRATO:                
            </td> 
            <td class="TextoCelda">
                <asp:TextBox ID="txtNUM_CONTRATO" runat="server" Columns="8" MaxLength="40"
                    class="TextoInfo" Width="150px" CssClass="NormalUPPER"></asp:TextBox>
            </td>        
        </tr>
        </table>
                