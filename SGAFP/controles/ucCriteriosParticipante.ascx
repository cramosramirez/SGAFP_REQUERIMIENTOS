<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCriteriosParticipante.ascx.vb" Inherits="controles_ucCriteriosParticipante" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

<style type="text/css">       
       .textUpper input{text-transform:uppercase;}     
</style>
<table cellpadding="0" cellspacing="0">
    <tr>
        <td style="width:150px">
             <dx:ASPxLabel ID="lblNOMBRES" runat="server" Font-Names="Verdana,Arial,Tahoma" Font-Size="XX-Small" Text="NOMBRES PARTICIPANTE:" />
        </td>
        <td style="width:220px">
            <dx:ASPxTextBox ID="txtNOMBRES" CssClass="textUpper" ClientInstanceName="txtNOMBRES" MaxLength="50" runat="server" Width="200px" />
        </td>
        <td style="width:170px">
            <dx:ASPxLabel ID="lblAPELLIDOS" runat="server" Font-Names="Verdana,Arial,Tahoma" Font-Size="XX-Small" Text="APELLIDOS PARTICIPANTE:" />    
        </td>
        <td>
            <dx:ASPxTextBox ID="txtAPELLIDOS" CssClass="textUpper" ClientInstanceName="txtAPELLIDOS" MaxLength="50" runat="server" Width="200px" />
        </td>
    </tr>
    <tr>
        <td>
            <dx:ASPxLabel ID="lblFECHA" runat="server" Font-Names="Verdana,Arial,Tahoma" Font-Size="XX-Small" Text="FECHA NACIMIENTO:" />    
        </td>
        <td>
            <dx:ASPxDateEdit ID="dteFECHA_NACIMIENTO" ClientInstanceName="dteFECHA_NACIMIENTO" Width="200px"  runat="server" EditFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="true" />            
        </td>
        <td>
            <dx:ASPxLabel ID="lblID_PARTICIPANTE" runat="server" Font-Names="Verdana,Arial,Tahoma" Font-Size="XX-Small" Text="ID PARTICIPANTE:" />    
        </td>
        <td>
            <dx:ASPxTextBox ID="txtID_PARTICIPANTE" CssClass="textUpper" ClientInstanceName="txtID_PARTICIPANTE" MaxLength="50" runat="server" Width="200px" />
        </td>
    </tr>
    <tr>
        <td>
            <dx:ASPxLabel ID="lblDUI" runat="server" Font-Names="Verdana,Arial,Tahoma" Font-Size="XX-Small" Text="DUI:" />    
        </td>
        <td>
            <dx:ASPxTextBox ID="txtDUI" ClientInstanceName="txtDUI" runat="server" Width="200px" >
                <MaskSettings Mask="99999999-9" IncludeLiterals="None" />      
            </dx:ASPxTextBox>                                                            
        </td>
        <td>
            <dx:ASPxLabel ID="lblNIT" runat="server" Font-Names="Verdana,Arial,Tahoma" Font-Size="XX-Small" Text="NIT:" />    
        </td>
        <td>
            <dx:ASPxTextBox ID="txtNIT" ClientInstanceName="txtNIT" runat="server" Width="200px" >
                <MaskSettings Mask="9999-999999-999-9" IncludeLiterals="None" />              
            </dx:ASPxTextBox>
        </td>
    </tr>
    </table>


            