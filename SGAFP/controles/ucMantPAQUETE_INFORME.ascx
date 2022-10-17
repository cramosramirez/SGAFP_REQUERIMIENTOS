<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantPAQUETE_INFORME.ascx.vb" Inherits="controles_ucMantPAQUETE_INFORME" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucCriteriosPaqueteInforme" Src="~/controles/ucCriteriosPaqueteInforme.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPAQUETE_INFORME" Src="~/controles/ucListaPAQUETE_INFORME.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPAQUETE_INFORME_DET" Src="~/controles/ucListaPAQUETE_INFORME_DET.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetallePAQUETE_INFORME" Src="~/controles/ucVistaDetallePAQUETE_INFORME.ascx" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>

<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<uc1:ucBarraNavegacion id="ucBarraNavegacion1" runat="server"
    PermitirAgregar="false"
    PermitirEditar="false" PermitirGuardar="false" PermitirNavegacion="false">
</uc1:ucBarraNavegacion>
<asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" OnMenuItemClick="Menu1_MenuItemClick"
    BackColor="#B5C7DE" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em"
    ForeColor="#284E98" StaticSubMenuIndent="10px">
    <StaticSelectedStyle CssClass="TabSeleccionado" />
    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
    <DynamicMenuStyle BackColor="#B5C7DE" />
    <DynamicSelectedStyle BackColor="#507CD1" />
    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
    <Items>
        <asp:MenuItem Text="Paquetes" Value="0" Selected="true"></asp:MenuItem>
        <asp:MenuItem Text="Informes" Value="1"></asp:MenuItem>      
    </Items>
</asp:Menu>
<asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
    <asp:View ID="View1" runat="server">
        <table cellpadding="0" cellspacing="0" width="90%">
            <tr valign="top">
                <td class="TabArea">
                    <uc1:ucCriteriosPaqueteInforme ID="ucCriteriosPaqueteInforme1" runat="server" /> 
                    <uc1:ucListaPAQUETE_INFORME id="ucListaPAQUETE_INFORME1" runat="server" 
                        VerLASTUPDATE="False" VerUSERID="False" 
                        PermitirEliminar="True" PermitirSeleccionar="True" PermitirEditar="False"  />                    
                </td>
            </tr>
        </table>
    </asp:View>
    <asp:View ID="View2" runat="server">
        <table cellpadding="0" cellspacing="0" width="90%">
            <tr valign="top">
                <td class="TabArea">
                <uc1:ucVistaDetallePAQUETE_INFORME ID="ucVistaDetallePAQUETE_INFORME1" runat="server" Visible="false" VerLASTUPDATE = "false" VerUSERID="false" />    
                <uc1:ucListaPAQUETE_INFORME_DET id="ucListaPAQUETE_INFORME_DET1" runat="server" 
                        PermitirFiltrarEnFila="False" PermitirFiltrarEnEncabezadoColumna = "False"
                        VerLASTUPDATE="False" VerUSERID="False"  VerID_INFORME_FINAL="false"  Visible="False" 
                        PermitirEliminar="False" PermitirSeleccionar="False" PermitirEditar="False" PermitirPaginacion="False"  />                          
                </td>
            </tr>
        </table>
    </asp:View>  
</asp:MultiView>




        
