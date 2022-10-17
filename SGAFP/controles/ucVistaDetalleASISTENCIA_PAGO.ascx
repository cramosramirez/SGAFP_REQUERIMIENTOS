<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleASISTENCIA_PAGO.ascx.vb" Inherits="controles_ucVistaDetalleASISTENCIA_PAGO" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxTabControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxClasses" TagPrefix="dx" %>
<%@ Register tagprefix="uc1" tagname="ucListaASISTENCIA_PAGO_DET" Src="~/controles/ucListaASISTENCIA_PAGO_DET.ascx" %>

<table>
    <tr>
        <td><dx:ASPxLabel ID="Label1" runat="server" Text="Identificador:"></dx:ASPxLabel></td>
        <td>
            <dx:ASPxTextBox ID="txtID_ASISTE_PAGO" runat="server" Width="150px">
            </dx:ASPxTextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Descripción:"></dx:ASPxLabel></td>
        <th colspan="3">
            <dx:ASPxTextBox ID="txtDESCRIPCION" runat="server" Width="100%">
            </dx:ASPxTextBox>  
        </th>
    </tr>
    <tr>
        <td><dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Ejercicio:"></dx:ASPxLabel></td>
        <td>
            <dx:ASPxComboBox ID="cbxEJERCICIO" runat="server" DataSourceID="odsEJERCICIO" ValueField="ID_EJERCICIO" ValueType="System.String" TextField="ID_EJERCICIO"  Width="150px" >
            </dx:ASPxComboBox>
        </td>
    </tr>  
    <tr>
        <th colspan="4" >
             <dx:ASPxPageControl ID="TabSolicitud" runat="server" ActiveTabIndex="1" ClientInstanceName="TabSolicitud" 
                EnableHierarchyRecreation="True" Width="100%" 
                Font-Names="Verdana,Arial,Tahoma"  Font-Size="XX-Small" CssFilePath="~/App_Themes/SoftOrange/{0}/styles.css" CssPostfix="SoftOrange" SpriteCssFilePath="~/App_Themes/SoftOrange/{0}/sprite.css" TabSpacing="2px" >                 
                 <LoadingPanelImage Url="~/App_Themes/SoftOrange/Web/Loading.gif">
                </LoadingPanelImage>
                 <Paddings Padding="4px" />
                <ContentStyle>
                    <Border BorderColor="LightGray" BorderStyle="Solid" BorderWidth="3px" />            
                </ContentStyle>
                <TabPages>                
                     <dx:TabPage Text="PAGO POR PORCENTAJE DE ASISTENCIA" ToolTip="Pago por porcentaje de asistencia">
                        <ContentCollection>    
                            <dx:ContentControl ID="ContentControl1" runat="server">
                                <table>
                                    <tr>                                        
                                        <td><dx:ASPxButton ID="btnAgregar" runat="server" AutoPostBack="true" Text="Agregar rango" CssFilePath="~/App_Themes/Office2010Silver/{0}/styles.css" CssPostfix="Office2010Silver" SpriteCssFilePath="~/App_Themes/Office2010Silver/{0}/sprite.css" Width="170px" ></dx:ASPxButton> </td>
                                        <td><dx:ASPxButton ID="btnBorrarRangos" runat="server" AutoPostBack="true" Text="Limpiar detalle" CssFilePath="~/App_Themes/Office2010Silver/{0}/styles.css" CssPostfix="Office2010Silver" SpriteCssFilePath="~/App_Themes/Office2010Silver/{0}/sprite.css" Width="170px" ></dx:ASPxButton> </td>
                                        <td></td>                                        
                                    </tr>
                                    <tr>
                                        <th colspan="3" >            
                                            <uc1:ucListaASISTENCIA_PAGO_DET id="ucListaASISTENCIA_PAGO_DET1" PermitirEditarInline="true" PermitirEliminar="true" runat="server"></uc1:ucListaASISTENCIA_PAGO_DET>
                                        </th>
                                    </tr>                                   
                                </table>
                            </dx:ContentControl>
                        </ContentCollection>
                    </dx:TabPage>                   
                </TabPages>
            </dx:ASPxPageControl>
        </th>
    </tr>
</table>
<dx:ASPxLabel ID="lblREFERENCIA" runat="server" Visible="false" />


<asp:ObjectDataSource ID="odsMODALIDAD_FORMACION" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cMODALIDAD_DE_FORMACION">
    <SelectParameters>                             
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean"  />
        <asp:Parameter DefaultValue="ID_MODALIDAD_FORMACION" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsEJERCICIO" runat="server"
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cEJERCICIO">
    <SelectParameters>                             
        <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean"  />   
        <asp:Parameter DefaultValue="ID_EJERCICIO" Name="asColumnaOrden" Type="String" />             
        <asp:Parameter DefaultValue="DESC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>


<dx:ASPxPopupControl ID="popAgregarAsistenciaPago" Modal="True"  runat="server" 
                        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" PopupElementID="BuscarNombresbtn" HeaderText="Agregar rango de asistencia-pago" ContentStyle-Paddings-Padding="7px"   
                        AllowDragging="True" ClientInstanceName="popAgregarAsistenciaPago" 
                        CloseAction="CloseButton" CssFilePath="~/App_Themes/Office2010Blue/{0}/styles.css" CssPostfix="Office2010Blue" SpriteCssFilePath="~/App_Themes/Office2010Blue/{0}/sprite.css" Width="450px" EnableHotTrack="False">  

<ContentStyle>
<Paddings Padding="7px"></Paddings>
</ContentStyle>

                <LoadingPanelStyle ImageSpacing="5px">
                </LoadingPanelStyle>
                <ContentCollection>
                    <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server" >          
                        <table>
                            <tr>
                                <td><dx:ASPxLabel ID="Label30" runat="server" Text="Tipo de modalidad:" /></td>
                                <td>
                                    <dx:ASPxComboBox ID="cbxMODALIDAD_FORMACION" runat="server" DataSourceID="odsMODALIDAD_FORMACION" ValueField="ID_MODALIDAD_FORMACION" ValueType="System.Int32" TextField="MODALIDAD_FORMACION"  Width="300px" >
                                    </dx:ASPxComboBox>
                                </td>
                            </tr>
                            <tr>
                                <td><dx:ASPxLabel ID="ASPxLabel12" runat="server" Text="Asistencia inicial (%):" /></td>
                                <td>
                                    <dx:ASPxSpinEdit ID="spePORC_ASISTE_INI" runat="server" SpinButtons-ShowIncrementButtons="false" NumberType="Float" Width="150px">                                        
<SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                    </dx:ASPxSpinEdit>
                                </td>
                            </tr>
                            <tr>
                                <td><dx:ASPxLabel ID="ASPxLabel13" runat="server" Text="Asistencia final (%):" /></td>
                                <td>
                                    <dx:ASPxSpinEdit ID="spePORC_ASISTE_FIN" runat="server" NumberType="Float" Width="150px">
                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                    </dx:ASPxSpinEdit>
                                </td>
                            </tr>
                            <tr>
                                <td><dx:ASPxLabel ID="ASPxLabel14" runat="server" Text="% a pagar:" /></td>
                                <td>
                                    <dx:ASPxSpinEdit ID="spePORC_PAGO_COSTO_PARTI" runat="server" NumberType="Float" DecimalPlaces="2" DisplayFormatString="#,##0.00"  Width="150px">
                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                    </dx:ASPxSpinEdit>
                                </td>
                            </tr>
                            <tr>
                                <th colspan="2">
                                    <dx:ASPxLabel ID="lblMensajeError" runat="server" Text="" Font-Bold="true" ForeColor="Red" />
                                </th>
                            </tr>
                            <tr>
                                <td>
                                     <dx:ASPxButton ID="btnAceptarPopup" runat="server" AutoPostBack="true" Text="Aceptar" CssFilePath="~/App_Themes/Office2010Silver/{0}/styles.css" CssPostfix="Office2010Silver" SpriteCssFilePath="~/App_Themes/Office2010Silver/{0}/sprite.css" ></dx:ASPxButton>
                                </td>
                                <td>
                                     <dx:ASPxButton ID="btnCancelarPopup" runat="server" Text="Cancelar" CssFilePath="~/App_Themes/Office2010Silver/{0}/styles.css" CssPostfix="Office2010Silver" SpriteCssFilePath="~/App_Themes/Office2010Silver/{0}/sprite.css" >
                                         <ClientSideEvents Click="function(s, e) {popAgregarAsistenciaPago.Hide();}" />
                                     </dx:ASPxButton>
                                </td>
                            </tr>                            
                        </table> 
                    </dx:PopupControlContentControl>
                </ContentCollection>
                <LoadingPanelImage Url="~/App_Themes/Office2010Blue/Web/Loading.gif">
                </LoadingPanelImage>            
</dx:ASPxPopupControl>

