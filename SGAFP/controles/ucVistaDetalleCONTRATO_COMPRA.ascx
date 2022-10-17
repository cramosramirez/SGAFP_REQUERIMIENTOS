<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleCONTRATO_COMPRA.ascx.vb" Inherits="controles_ucVistaDetalleCONTRATO_COMPRA" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxTabControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxClasses" TagPrefix="dx" %>
<%@ Register tagprefix="uc1" tagname="ucListaCONTRATO_COMPRA_PENALIZACION" Src="~/controles/ucListaCONTRATO_COMPRA_PENALIZACION.ascx" %>


<table>
    <tr>
        <td><dx:ASPxLabel ID="Label1" runat="server" Text="Identificador:"></dx:ASPxLabel></td>
        <td>
            <dx:ASPxTextBox ID="txtID_CONTRATO_COMPRA" runat="server" Width="150px">
            </dx:ASPxTextBox>
        </td>
        <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="No. Oferta de Compra:"></dx:ASPxLabel></td>
        <td>
            <dx:ASPxTextBox ID="txtNO_CONTRATO_COMPRA" Font-Bold="true" runat="server" MaxLength="10" Width="150px">
            </dx:ASPxTextBox>
        </td>
    </tr>
    <tr>
        <td><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Unidad organizativa:"></dx:ASPxLabel></td>
        <th colspan="3">
            <dx:ASPxComboBox ID="cbxUNIDAD_ORGANIZATIVA" runat="server" DataSourceID="odsUNIDAD_ORGANIZATIVA" ValueField="ID_UNIDAD_ORGANIZATIVA" ValueType="System.Int32" TextField="NOMBRE_UNIDAD"  Width="100%" >
            </dx:ASPxComboBox>  
        </th>
    </tr>
    <tr>
        <td><dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Fecha de ingreso:"></dx:ASPxLabel></td>
        <td>
            <dx:ASPxDateEdit ID="dteFECHA_INGRESO" runat="server" DisplayFormatString="dd/MM/yyyy"  Width="150px">                                
            </dx:ASPxDateEdit>  
        </td>
    </tr>   
    <tr>
        <td><dx:ASPxLabel ID="ASPxLabel4" runat="server" Font-Bold="true" Text="Período de Validez"></dx:ASPxLabel></td>
        <th colspan="3"><hr /></th>
    </tr>
    <tr>
        <td><dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="Del:"></dx:ASPxLabel></td>
        <td>
            <dx:ASPxDateEdit ID="dteFECHA_INI_EJEC" runat="server" DisplayFormatString="dd/MM/yyyy" Width="150px">                
            </dx:ASPxDateEdit>  
        </td>
        <td><dx:ASPxLabel ID="ASPxLabel6" runat="server" Text="Al:"></dx:ASPxLabel></td>
        <td>
            <dx:ASPxDateEdit ID="dteFECHA_FIN_EJEC" runat="server" DisplayFormatString="dd/MM/yyyy" Width="150px">                
            </dx:ASPxDateEdit>  
        </td>
    </tr>    
    <tr>
        <td><dx:ASPxLabel ID="ASPxLabel7" runat="server" Font-Bold="true" Text="Condiciones para pago"></dx:ASPxLabel></td> 
        <th colspan="3"><hr /></th>        
    </tr>
    <tr>
        <td><dx:ASPxLabel ID="ASPxLabel8" runat="server" Text="Porcentaje mínimo de asistencia:"></dx:ASPxLabel></td>
        <td>
            <dx:ASPxSpinEdit ID="spePORC_ASISTENCIA_MIN" runat="server" Width="150px">
            </dx:ASPxSpinEdit>
        </td>
    </tr>
    <tr>
        <td><dx:ASPxLabel ID="ASPxLabel9" runat="server" Text="Pago en base a:"></dx:ASPxLabel></td>
        <th colspan="3" >
            <dx:ASPxListBox ID="lstPAGO_POR_PARTICIPACION" AutoPostBack="True" runat="server" Width="100%" CssFilePath="~/App_Themes/PlasticBlue/{0}/styles.css" CssPostfix="PlasticBlue" SpriteCssFilePath="~/App_Themes/PlasticBlue/{0}/sprite.css" >
                <LoadingPanelImage Url="~/App_Themes/PlasticBlue/Editors/Loading.gif">
                </LoadingPanelImage>
                <Items>
                    <dx:ListEditItem Text="Pago por curso, independiente de capacitados" Value="0" /> 
                    <dx:ListEditItem Text="Pago por participante capacitado con base a:" Value="1" />
                    <dx:ListEditItem Text="Pago en base a participantes inscritos" Value="2" />
                </Items> 
                <ValidationSettings>
                    <ErrorFrameStyle ImageSpacing="4px">
                        <ErrorTextPaddings PaddingLeft="4px" />
                    </ErrorFrameStyle>
                </ValidationSettings>
            </dx:ASPxListBox>
        </th>
    </tr>
    <tr>
        <td><dx:ASPxLabel ID="ASPxLabel10" runat="server" Text="Número de participante (base pago):"></dx:ASPxLabel></td>
        <td>
            <dx:ASPxSpinEdit ID="speBASE_PARTI" runat="server" NumberType="Integer" Width="150px">
            </dx:ASPxSpinEdit>
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
                     <dx:TabPage Text="PENALIZACIONES AUTOMATICAS" ToolTip="Penalizaciones automáticas de la oferta">
                        <ContentCollection>    
                            <dx:ContentControl ID="ContentControl1" runat="server">
                                <table>
                                    <tr>
                                        <td><dx:ASPxButton ID="btnCargarPlantilla" runat="server" AutoPostBack="true" Text="Cargar plantilla" CssFilePath="~/App_Themes/Office2010Silver/{0}/styles.css" CssPostfix="Office2010Silver" SpriteCssFilePath="~/App_Themes/Office2010Silver/{0}/sprite.css" Width="150px" ></dx:ASPxButton> </td>
                                        <td><dx:ASPxButton ID="btnAgregar" runat="server" AutoPostBack="true" Text="Agregar rango" CssFilePath="~/App_Themes/Office2010Silver/{0}/styles.css" CssPostfix="Office2010Silver" SpriteCssFilePath="~/App_Themes/Office2010Silver/{0}/sprite.css" Width="170px" ></dx:ASPxButton> </td>
                                        <td><dx:ASPxButton ID="btnBorrarRangos" runat="server" AutoPostBack="true" Text="Limpiar detalle" CssFilePath="~/App_Themes/Office2010Silver/{0}/styles.css" CssPostfix="Office2010Silver" SpriteCssFilePath="~/App_Themes/Office2010Silver/{0}/sprite.css" Width="170px" ></dx:ASPxButton> </td>
                                        <td></td>
                                    </tr>
                                    <tr>
                                        <th colspan="4" >            
                                            <uc1:ucListaCONTRATO_COMPRA_PENALIZACION id="ucListaCONTRATO_COMPRA_PENALIZACION1" PermitirEditarInline="true" PermitirEliminar="true" runat="server"></uc1:ucListaCONTRATO_COMPRA_PENALIZACION>
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
<dx:ASPxLabel ID="lblREFERENCIA_PAGO_ASISTE" runat="server" Visible="false" />

<asp:ObjectDataSource ID="odsUNIDAD_ORGANIZATIVA" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerListaPorActivas" TypeName="SGAFP.BL.cUNIDAD_ORGANIZATIVA">
    <SelectParameters>                             
        <asp:Parameter DefaultValue="NOMBRE_UNIDAD" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsTIPO_PENALIZA_AUTO" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerListaPenalizacionAutomatica" TypeName="SGAFP.BL.cTIPO_PENALIZA">
    <SelectParameters>                             
        <asp:Parameter DefaultValue="ID_TIPO_PENA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>


<dx:ASPxPopupControl ID="popAgregarPenalizacion" Modal="True"  runat="server" 
                        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" PopupElementID="BuscarNombresbtn" HeaderText="Agregar rango de penalización" ContentStyle-Paddings-Padding="7px"   
                        AllowDragging="True" ClientInstanceName="popAgregarPenalizacion" 
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
                                <td><dx:ASPxLabel ID="Label30" runat="server" Text="Tipo de penalización:" /></td>
                                <td>
                                    <dx:ASPxComboBox ID="cbxTIPO_PENALIZA" runat="server" DataSourceID="odsTIPO_PENALIZA_AUTO" ValueField="ID_TIPO_PENA" ValueType="System.Int32" TextField="NOMBRE"  Width="300px" >
                                    </dx:ASPxComboBox>
                                </td>
                            </tr>
                            <tr>
                                <td><dx:ASPxLabel ID="ASPxLabel12" runat="server" Text="Rango inicial (días):" /></td>
                                <td>
                                    <dx:ASPxSpinEdit ID="speRANGO_INICIAL" runat="server" SpinButtons-ShowIncrementButtons="false" NumberType="Integer" Width="150px">                                        
<SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                    </dx:ASPxSpinEdit>
                                </td>
                            </tr>
                            <tr>
                                <td><dx:ASPxLabel ID="ASPxLabel13" runat="server" Text="Rango final (días):" /></td>
                                <td>
                                    <dx:ASPxSpinEdit ID="speRANGO_FINAL" runat="server" NumberType="Integer" Width="150px">
                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                    </dx:ASPxSpinEdit>
                                </td>
                            </tr>
                            <tr>
                                <td><dx:ASPxLabel ID="ASPxLabel14" runat="server" Text="% Penalización:" /></td>
                                <td>
                                    <dx:ASPxSpinEdit ID="spePORCENTAJE_PENALIZACION" runat="server" NumberType="Float" DecimalPlaces="2" DisplayFormatString="#,##0.00"  Width="150px">
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
                                         <ClientSideEvents Click="function(s, e) {popAgregarPenalizacion.Hide();}" />
                                     </dx:ASPxButton>
                                </td>
                            </tr>                            
                        </table> 
                    </dx:PopupControlContentControl>
                </ContentCollection>
                <LoadingPanelImage Url="~/App_Themes/Office2010Blue/Web/Loading.gif">
                </LoadingPanelImage>            
</dx:ASPxPopupControl>

<dx:ASPxPopupControl ID="popAgregarPagoAsiste" Modal="True"  runat="server" 
                        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" PopupElementID="BuscarNombresbtn" HeaderText="Agregar rango de pago por asistencia" ContentStyle-Paddings-Padding="7px"   
                        AllowDragging="True" ClientInstanceName="popAgregarPenalizacion" 
                        CloseAction="CloseButton" CssFilePath="~/App_Themes/Office2010Blue/{0}/styles.css" CssPostfix="Office2010Blue" SpriteCssFilePath="~/App_Themes/Office2010Blue/{0}/sprite.css" Width="450px" EnableHotTrack="False">  

<ContentStyle>
<Paddings Padding="7px"></Paddings>
</ContentStyle>

                <LoadingPanelStyle ImageSpacing="5px">
                </LoadingPanelStyle>
                <ContentCollection>
                    <dx:PopupControlContentControl ID="PopupControlContentControl2" runat="server" >          
                        <table>
                            <tr>
                                <td><dx:ASPxLabel ID="ASPxLabel11" runat="server" Text="Modalidad:" /></td>
                                <td>
                                    <dx:ASPxComboBox ID="ASPxComboBox1" runat="server" DataSourceID="odsTIPO_PENALIZA_AUTO" ValueField="ID_TIPO_PENA" ValueType="System.Int32" TextField="NOMBRE"  Width="300px" >
                                    </dx:ASPxComboBox>
                                </td>
                            </tr>
                            <tr>
                                <td><dx:ASPxLabel ID="ASPxLabel15" runat="server" Text="Asistencia inicial (%):" /></td>
                                <td>
                                    <dx:ASPxSpinEdit ID="ASPxSpinEdit1" runat="server" SpinButtons-ShowIncrementButtons="false" NumberType="Integer" Width="150px">                                        
<SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                    </dx:ASPxSpinEdit>
                                </td>
                            </tr>
                            <tr>
                                <td><dx:ASPxLabel ID="ASPxLabel16" runat="server" Text="Asistencia final (%):" /></td>
                                <td>
                                    <dx:ASPxSpinEdit ID="ASPxSpinEdit2" runat="server" NumberType="Integer" Width="150px">
                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                    </dx:ASPxSpinEdit>
                                </td>
                            </tr>
                            <tr>
                                <td><dx:ASPxLabel ID="ASPxLabel17" runat="server" Text="% a Pagar:" /></td>
                                <td>
                                    <dx:ASPxSpinEdit ID="ASPxSpinEdit3" runat="server" NumberType="Float" DecimalPlaces="2" DisplayFormatString="#,##0.00"  Width="150px">
                                        <SpinButtons ShowIncrementButtons="False"></SpinButtons>
                                    </dx:ASPxSpinEdit>
                                </td>
                            </tr>
                            <tr>
                                <th colspan="2">
                                    <dx:ASPxLabel ID="ASPxLabel18" runat="server" Text="" Font-Bold="true" ForeColor="Red" />
                                </th>
                            </tr>
                            <tr>
                                <td>
                                     <dx:ASPxButton ID="ASPxButton1" runat="server" AutoPostBack="true" Text="Aceptar" CssFilePath="~/App_Themes/Office2010Silver/{0}/styles.css" CssPostfix="Office2010Silver" SpriteCssFilePath="~/App_Themes/Office2010Silver/{0}/sprite.css" ></dx:ASPxButton>
                                </td>
                                <td>
                                     <dx:ASPxButton ID="ASPxButton2" runat="server" Text="Cancelar" CssFilePath="~/App_Themes/Office2010Silver/{0}/styles.css" CssPostfix="Office2010Silver" SpriteCssFilePath="~/App_Themes/Office2010Silver/{0}/sprite.css" >
                                         <ClientSideEvents Click="function(s, e) {popAgregarPenalizacion.Hide();}" />
                                     </dx:ASPxButton>
                                </td>
                            </tr>                            
                        </table> 
                    </dx:PopupControlContentControl>
                </ContentCollection>
                <LoadingPanelImage Url="~/App_Themes/Office2010Blue/Web/Loading.gif">
                </LoadingPanelImage>            
</dx:ASPxPopupControl>