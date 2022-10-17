<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleCALENDARIZACION.ascx.vb" Inherits="controles_ucVistaDetalleCALENDARIZACION" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxTabControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxClasses" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaCALE_FECHA" Src="~/controles/ucListaCALE_FECHA.ascx" %>

<style type="text/css">   
    .auto-style1 {
        height: 24px;
    }
    .progtbl
    {
        border-style: none;
        border-color: White ;
        border-width: 0px;
        text-align: left;
        font-family: Verdana, Geneva, Arial, Helvetica, sans-serif;
        font-weight: normal;
        font-size: 11px;
        color: #000000;  
        background-color: #FFFFFF;   
        border-collapse: collapse;
        border-spacing: 1px;   
        margin-right:5px;          
    }   
    .panel
    {
       padding: 5 5 5 5; 
       width: 480px;
    }
    .divresult
    {
      text-align:left; font-weight:bold; 
    }
    .req{color:Red; font-size:x-small; font-family:Arial, Verdad; font-weight:bold}    
</style>

<table border="0" cellspacing="3" >
    <tr>
        <td width="180px">
            <dx:ASPxLabel ID="Label1" runat="server" Text="Proveedor:" />   
        </td>
        <td>
            <dx:ASPxComboBox Id="cbxPROVEEDOR_AF" runat="server" AutoPostBack="true" Width="600px" DataSourceID="odsProveedor" ValueType="System.Int32" ValueField="ID_PROVEEDOR_AF" DropDownStyle="DropDown" IncrementalFilteringMode="Contains" TextField="NOMBRE_PROVEEDOR" >
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>   
            </dx:ASPxComboBox>  
        </td>
    </tr>
    <tr id="trSITIO_CAPACITACION" runat="server">
        <td><dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Centro de formación:" /> </td>
        <td>
            <dx:ASPxComboBox Id="cbxSITIO_CAPACITACION" ValueField="ID_SITIO_CAPACITACION" TextField="NOMBRE_SITIO" runat="server" Width="600px"  >
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>  
            </dx:ASPxComboBox> 
        </td>
    </tr>
    <tr>
        <td><dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="No. Oferta Compra / Licitación:" /> </td>
        <td>
            <dx:ASPxTextBox ID="txtNO_COMPRA_LICITACION" runat="server" Width="170px"  >
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>  
            </dx:ASPxTextBox>   
        </td>
    </tr>
    <tr>
        <td><dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Contrato:" /> </td>
        <td>
            <dx:ASPxTextBox ID="txtNUM_CONTRATO" runat="server" Width="170px"  >
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>  
            </dx:ASPxTextBox>   
        </td>
    </tr>
    <tr>
        <td><dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Código programa:" /> </td>
        <td>
            <dx:ASPxTextBox ID="txtCODIGO_PROGRAMA" runat="server" Width="600px"  >
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>  
            </dx:ASPxTextBox>
        </td>
    </tr>    
    <tr>
        <td><dx:ASPxLabel ID="ASPxLabel16" runat="server" Text="Nombre de curso:" /> </td>
        <td>
            <dx:ASPxTextBox ID="txtNOMBRE_ACCION_FORMATIVA" runat="server" Width="600px"  >
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>  
            </dx:ASPxTextBox>
        </td>
    </tr>
    <tr>
        <td><dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="Código de curso:" /> </td>
        <td>
            <dx:ASPxTextBox ID="txtCODIGO_GRUPO" runat="server" Width="600px"  >
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>  
            </dx:ASPxTextBox>
        </td>
    </tr>
    <tr>
        <td><dx:ASPxLabel ID="ASPxLabel6" runat="server" Text="Duración (Horas):" /> </td>
        <td>             
            <dx:ASPxSpinEdit ID="txtDURACION" runat="server" Width="170px" NumberType="Integer" >
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>  
            </dx:ASPxSpinEdit>
        </td>
    </tr>
    <tr>
        <td class="auto-style1"><dx:ASPxLabel ID="ASPxLabel7" runat="server" Text="Costo por participante:" /> </td>
        <td class="auto-style1">
            <dx:ASPxTextBox ID="txtCOSTO_X_PARTICIPANTE" runat="server" Width="170px"  >
                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>  
            </dx:ASPxTextBox>
        </td>
    </tr>
    <tr>
        <th colspan="2">
            <table cellspacing="3">
                <tr>
                    <td><dx:ASPxLabel ID="ASPxLabel8" runat="server" Text="Ejercicio:" /></td>
                    <td>
                        <dx:ASPxComboBox Id="cbxEJERCICIO" runat="server" DataSourceID="odsEjercicio" ValueField="ID_EJERCICIO" TextField="ID_EJERCICIO" ValueType="System.String" Width="120px"  >
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>  
                        </dx:ASPxComboBox>  
                    </td>               
                    <td><dx:ASPxLabel ID="ASPxLabel9" runat="server" Text="Mes:" /></td>
                    <td>
                        <dx:ASPxComboBox Id="cbxMES" runat="server" Width="134px"  >
                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>  
                        </dx:ASPxComboBox>  
                    </td>
                </tr>
            </table>
        </th>
    </tr>
    <tr>
        <th colspan="2">
             <dx:ASPxPageControl ID="TabCalendarizacion" runat="server" ActiveTabIndex="2" 
                EnableHierarchyRecreation="True" Width="100%" 
                Font-Names="Verdana,Arial,Tahoma"  Font-Size="Small" CssFilePath="~/App_Themes/Office2010Blue/{0}/styles.css" CssPostfix="Office2010Blue" SpriteCssFilePath="~/App_Themes/Office2010Blue/{0}/sprite.css" TabSpacing="0px" >                 
                 <LoadingPanelImage Url="~/App_Themes/Office2010Blue/Web/Loading.gif">
                </LoadingPanelImage>
                 <LoadingPanelStyle ImageSpacing="5px">
                 </LoadingPanelStyle>
                 <Paddings PaddingLeft="5px" PaddingRight="5px" Padding="2px" />
                <ContentStyle>
                    <Paddings Padding="12px" />
                    <Border BorderWidth="1px" BorderColor="#859EBF" BorderStyle="Solid" />            
                </ContentStyle>
                <TabPages>                
                     <dx:TabPage Text="PROGRAMACION DEL CURSO" ToolTip="Programación del curso">
                        <ContentCollection>       
                            <dx:ContentControl ID="ContentControl1" runat="server">
                                <table border="0" cellpadding="3px" cellspacing="0" >                      
                                    <tr>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel10" runat="server" Text="Fechas:" />
                                        </td>                    
                                        <th align="left"  >
                                            <table border="0" cellpadding="2" cellspacing="0" class="progtbl">
                                                <tr>
                                                    <td>
                                                        <div style="font-family: Verdana; font-size: 11px;">Del</div>
                                                    </td>
                                                    <td>
                                                        <div style="font-family: Verdana; font-size: 10px;" >
                                                        <dx:ASPxDateEdit ID="dteFechaInicio" ClientInstanceName="dteFechaInicio"  runat="server" AllowNull="false" Width="100px" DisplayFormatString="dd/MM/yyyy" CssFilePath="~/App_Themes/Office2010Black/{0}/styles.css" CssPostfix="Office2010Black" Spacing="0" SpriteCssFilePath="~/App_Themes/Office2010Black/{0}/sprite.css" >                                
                                                            <CalendarProperties>
                                                                




<HeaderStyle Spacing="1px" />
                                                            




</CalendarProperties>
                                                            <ButtonStyle Width="13px">
                                                            </ButtonStyle>
                                                            </dx:ASPxDateEdit>
                                                        </div>
                                                    </td>
                                                    <td>
                                                        <div style="font-family: Verdana; font-size: 11px;">Al</div>
                                                    </td>
                                                    <td>
                                                        <div style="font-family: Verdana; font-size: 11px;" >
                                                        <dx:ASPxDateEdit ID="dteFechaFinalizacion" ClientInstanceName="dteFechaFinalizacion" runat="server" AllowNull="True" Width="100px" DisplayFormatString="dd/MM/yyyy" CssFilePath="~/App_Themes/Office2010Black/{0}/styles.css" CssPostfix="Office2010Black" Spacing="0" SpriteCssFilePath="~/App_Themes/Office2010Black/{0}/sprite.css" >                                
                                                            <CalendarProperties>
                                                                




<HeaderStyle Spacing="1px" />
                                                            




</CalendarProperties>
                                                            <ButtonStyle Width="13px">
                                                            </ButtonStyle>
                                                            </dx:ASPxDateEdit>
                                                        </div>
                                                    </td>
                                                </tr>
                                            </table>
                        
                                        </th>                    
                                    </tr>  
                                    <tr>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel11" runat="server" Text="Dias de la semana:" />                
                                        </td>
                                        <th align="left" >
                                                <table border="0" cellpadding="5" cellspacing="0" class="progtbl" width="100%" >
                                                    <tr>                                    
                                                        <td>
                                                            <dx:ASPxCheckBox ID="chkLunes" ClientInstanceName="chkLunes"  runat="server" Text="Lunes" CssFilePath="~/App_Themes/SoftOrange/{0}/styles.css" CssPostfix="SoftOrange" SpriteCssFilePath="~/App_Themes/SoftOrange/{0}/sprite.css"  />                                
                                                        </td>
                                                        <td>
                                                            <dx:ASPxCheckBox ID="chkMartes" ClientInstanceName="chkMartes" runat="server" Text="Martes" CssFilePath="~/App_Themes/SoftOrange/{0}/styles.css" CssPostfix="SoftOrange" SpriteCssFilePath="~/App_Themes/SoftOrange/{0}/sprite.css" />                                
                                                        </td>
                                                        <td>                                
                                                            <dx:ASPxCheckBox ID="chkMiercoles" ClientInstanceName="chkMiercoles" runat="server" Text="Miércoles" CssFilePath="~/App_Themes/SoftOrange/{0}/styles.css" CssPostfix="SoftOrange" SpriteCssFilePath="~/App_Themes/SoftOrange/{0}/sprite.css" />
                                                        </td>
                                                        <td>                                
                                                            <dx:ASPxCheckBox ID="chkJueves" ClientInstanceName="chkJueves" runat="server" Text="Jueves" CssFilePath="~/App_Themes/SoftOrange/{0}/styles.css" CssPostfix="SoftOrange" SpriteCssFilePath="~/App_Themes/SoftOrange/{0}/sprite.css" />
                                                        </td>                            
                                                        <td> 
                                                            <dx:ASPxCheckBox ID="chkViernes" ClientInstanceName="chkViernes" runat="server" Text="Viernes" CssFilePath="~/App_Themes/SoftOrange/{0}/styles.css" CssPostfix="SoftOrange" SpriteCssFilePath="~/App_Themes/SoftOrange/{0}/sprite.css" />                               
                                                        </td>
                                                        <td>                                
                                                            <dx:ASPxCheckBox ID="chkSabado" ClientInstanceName="chkSabado" runat="server" Text="Sábado" CssFilePath="~/App_Themes/SoftOrange/{0}/styles.css" CssPostfix="SoftOrange" SpriteCssFilePath="~/App_Themes/SoftOrange/{0}/sprite.css" />
                                                        </td>                            
                                                        <td>                                
                                                            <dx:ASPxCheckBox ID="chkDomingo" ClientInstanceName="chkDomingo" runat="server" Text="Domingo" CssFilePath="~/App_Themes/SoftOrange/{0}/styles.css" CssPostfix="SoftOrange" SpriteCssFilePath="~/App_Themes/SoftOrange/{0}/sprite.css" />
                                                        </td>
                                                    </tr>
                                                  </table>     
                                        </th>
                                    </tr>                                             
                                    <tr>
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel12" runat="server" Text="Horario:" />    
                                        </td>
                                        <th align="left">
                                            <table width="100%">
                                                <tr>
                                                    <td>
                                                        <table border="0" style="padding-right:10px" cellpadding="2" cellspacing="0" class="progtbl">
                                                            <tr>
                                                                <td>
                                                                   <div style="font-family: Verdana; font-size: 11px; text-align:right;">De</div>            
                                                                </td>
                                                                <td>
                                                                   <dx:ASPxTimeEdit ID="tmeHoraInicio" ClientInstanceName="tmeHoraInicio" runat="server" Width="100px" DisplayFormatString="hh:mm tt" EditFormat="Custom" EditFormatString="hh:mm tt" CssFilePath="~/App_Themes/Office2010Black/{0}/styles.css" CssPostfix="Office2010Black" Spacing="0" SpriteCssFilePath="~/App_Themes/Office2010Black/{0}/sprite.css"    />                                                     
                                                                </td>
                                                                <td>
                                                                   <div style="font-family: Verdana; font-size: 11px; text-align:right;">A</div> 
                                                                </td>
                                                                <td>  
                                                                  <dx:ASPxTimeEdit ID="tmeHoraFin" ClientInstanceName="tmeHoraFin" runat="server" Width="100px" DisplayFormatString="hh:mm tt" EditFormat="Custom" EditFormatString="hh:mm tt" CssFilePath="~/App_Themes/Office2010Black/{0}/styles.css" CssPostfix="Office2010Black" Spacing="0" SpriteCssFilePath="~/App_Themes/Office2010Black/{0}/sprite.css" />                                                 
                                                                </td>
                                                             </tr>
                                                        </table>
                                                    </td>
                                                    <td style="text-align:right" >
                                                        <dx:ASPxButton ID="btnAgregar" runat="server" AutoPostBack="true" Text="Agregar horario" Width="120px" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css" CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"  />  
                                                    </td>
                                                    <td>
                                                        <dx:ASPxButton ID="btnEliminar" runat="server" AutoPostBack="true" Text="Borrar todo" Width="120px" CssFilePath="~/App_Themes/Office2003Blue/{0}/styles.css" CssPostfix="Office2003Blue" SpriteCssFilePath="~/App_Themes/Office2003Blue/{0}/sprite.css"  />  
                                                    </td>
                                                </tr>
                                            </table>
                                        </th>                                                              
                                    </tr>               
                                  </table> 
                                
                                
                                  <table border="0" cellpadding="2" cellspacing="0" width="100%" >
                                    <tr>
                                        <td>
                                        <uc1:ucListaCALE_FECHA id="ucListaCALE_FECHA1" PermitirEditar="false" PermitirFiltroEnEncabezado="false" PermitirFilaDeFiltro="false"  runat="server"></uc1:ucListaCALE_FECHA>
                                        </td>
                                    </tr>
                                 </table>   
                                 <table border="0" cellpadding="2" cellspacing="0" >
                                    <tr align="left">
                                        <td>
                                            <dx:ASPxLabel ID="lbletiqueta1"   runat="server" Text="FECHA DE INICIO:" ></dx:ASPxLabel>     
                                        </td>
                                         <td style="width:110px" >
                                             <dx:ASPxLabel ID="lblFechaInicioReal" ClientInstanceName="lblFechaInicioReal"  runat="server" Text="" />                         
                                        </td>
                                        <td>
                                           <dx:ASPxLabel ID="ASPxLabel13"   runat="server" Text="FECHA DE FINALIZACION:" ></dx:ASPxLabel>      
                                        </td>
                                        <td>
                                             <dx:ASPxLabel ID="lblFechaFinalizacionReal" ClientInstanceName="lblFechaFinalizacionReal" runat="server" Text="" />                         
                                        </td>
                                    </tr>
                                 </table>
                                 <table border="0" cellpadding="2" cellspacing="0" >              
                                    <tr align="left">
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel14"   runat="server" Text="HORARIO:" ></dx:ASPxLabel>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="lblHorario" ClientInstanceName="lblHorario"  runat="server" Text="" />     
                                        </td>
                                    </tr>
                                    <tr align="left">
                                        <td>
                                            <dx:ASPxLabel ID="ASPxLabel15"   runat="server" Text="TOTAL HORAS:" ></dx:ASPxLabel>
                                        </td>
                                        <td>
                                            <dx:ASPxLabel ID="lblHorasTotales" ClientInstanceName="lblHorasTotales" runat="server" Text="" />     
                                        </td>
                                    </tr>
                                 </table>                  
                            </dx:ContentControl>
                        </ContentCollection>
                     </dx:TabPage>
                     <dx:TabPage Text="LUGAR DE EJECUCION" ToolTip="Lugar de ejecución">
                        <ContentCollection>       
                            <dx:ContentControl ID="ContentControl2" runat="server">
                                <table border="0" cellpadding="2" cellspacing="0" width="100%" >
                                    <tr align="left">
                                        <td width="130px">
                                            <dx:ASPxLabel ID="ASPxLabel17"   runat="server" Text="Dirección:" />
                                        </td>
                                        <td>
                                            <dx:ASPxMemo ID="txtLUGAR_EJECUCION" ClientInstanceName="txtLUGAR_EJECUCION"  runat="server" Height="50px" Width="100%" >                                                 
                                            </dx:ASPxMemo>
                                        </td>
                                    </tr>
                                    <tr align="left">
                                        <td><dx:ASPxLabel ID="ASPxLabel18"   runat="server" Text="Departamento:" /></td>
                                        <td>
                                            <dx:ASPxComboBox ID="cbxDEPARTAMENTO_EJECUCION" AutoPostBack="true" Width="200px" runat="server" IncrementalFilteringMode="StartsWith" DropDownStyle="DropDownList"
                                                DataSourceID="odsDepartamento" TextField="NOMBRE" ValueField="CODIGO_DEPARTAMENTO">                                               
                                            </dx:ASPxComboBox>
                                        </td>
                                    </tr>
                                    <tr align="left">
                                        <td><dx:ASPxLabel ID="ASPxLabel19"   runat="server" Text="Municipio:" /></td>
                                        <td>
                                            <dx:ASPxComboBox ID="cbxMUNICIPIO_EJECUCION" Width="200px" runat="server" IncrementalFilteringMode="StartsWith" DropDownStyle="DropDownList"
                                               DataSourceID="odsMUNICIPIO" TextField="NOMBRE" ValueField="CODIGO_MUNICIPIO" EnableSynchronization="False" >                                                                                                               
                                            </dx:ASPxComboBox>
                                        </td>
                                    </tr>
                                </table>
                            </dx:ContentControl>
                        </ContentCollection>
                     </dx:TabPage>
                     <dx:TabPage Text="FORMADOR" ToolTip="Formador">
                        <ContentCollection>       
                            <dx:ContentControl ID="ContentControl3" runat="server">
                                    <table border="0" cellpadding="2" cellspacing="0" width="100%" >
                                        <tr align="left">
                                            <td width="130px">
                                                <dx:ASPxLabel ID="ASPxLabel20"   runat="server" Text="NIT del formador:" />
                                            </td>
                                            <td>
                                                <dx:ASPxTextBox ID="txtCODI_FORMADOR" AutoPostBack="true" runat="server" Width="300px" ValidationSettings-Display="Dynamic">
                                                    <MaskSettings Mask="9999-999999-999-9" IncludeLiterals="None" />                                            
                                                    <ValidationSettings Display="Dynamic"></ValidationSettings>       
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />                                       
                                                </dx:ASPxTextBox>
                                            </td>
                                        </tr>
                                        <tr align="left">
                                            <td>
                                                <dx:ASPxLabel ID="ASPxLabel21"   runat="server" Text="Nombre del formador:" />
                                            </td>
                                            <td>
                                                <dx:ASPxTextBox ID="txtNOMBRE_FORMADOR" runat="server" Width="300px" MaxLength="150"   >
                                                    <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black"></DisabledStyle>  
                                                </dx:ASPxTextBox>
                                            </td>
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

<asp:ObjectDataSource ID="odsProveedor" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SGAFP.BL.cPROVEEDOR_AF">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter DefaultValue="NOMBRE_PROVEEDOR" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsEjercicio" runat="server" 
    OldValuesParameterFormatString="original_{0}" SelectMethod="ObtenerLista" 
    TypeName="SGAFP.BL.cEJERCICIO">  
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />        
        <asp:Parameter DefaultValue="ID_EJERCICIO" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsDepartamento" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cDEPARTAMENTO">
    <SelectParameters>               
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />        
        <asp:Parameter DefaultValue="NOMBRE" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsMunicipio" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cMUNICIPIO">
    <SelectParameters>               
        <asp:Parameter DefaultValue="False" Name="CODIGO_DEPARTAMENTO" Type="String" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />        
        <asp:Parameter DefaultValue="NOMBRE" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
