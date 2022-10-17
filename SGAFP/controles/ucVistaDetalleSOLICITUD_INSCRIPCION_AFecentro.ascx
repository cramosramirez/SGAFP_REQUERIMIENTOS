<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro.ascx.vb" Inherits="controles_ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxTabControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxClasses" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxLoadingPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" Tagprefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

<%@ Register TagName="ucListaPARTICIPANTE" Src="~/controles/ucListaPARTICIPANTE.ascx" TagPrefix="uc1" %>

<style type="text/css">
       .req{color:Red; font-size:x-small; font-family:Arial; font-weight:bold}   
       .textUpper input{text-transform:uppercase;}     
    .auto-style1 {
        height: 16px;
    }
    .auto-style2 {
        height: 17px;
    }
</style>

   
                 
<div id="contenedor_principal" style="width:800px; font-family:Verdana,Arial; font-size:xx-small; margin-left: 40px;">
    <table width="100%" >        
        <tr align="center">
           <td>
               <dx:ASPxLabel ID="ASPxLabel1" runat="server" Font-Names="Verdana,Arial,Tahoma" Font-Bold="True" Font-Size="Small" Text="FORMULARIO DE INSCRIPCIÓN PROGRAMA EMPRESA CENTRO" />
           </td> 
        </tr>
        <tr align="center">
           <td>
               <dx:ASPxLabel ID="lblCARRERA" runat="server" Font-Names="Verdana,Arial,Tahoma" Font-Bold="True" Font-Size="Small" Text="" />
           </td> 
        </tr>
        <tr align="left">
            <td style="color:red">(*) Las respuestas a las preguntas color rojo son obligatorios.</td>
        </tr>
    </table>    
    <table width="100%">        
        <tr>
            <td style="width:70px; font-family:Verdana,Arial; font-size:xx-small;  ">
                <dx:ASPxLabel ID="lblSolicitud" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="ID. SOLICITUD:" />
            </td>
             <td style="width:70px">
                <dx:ASPxTextBox ID="ID_SOLIC_PRESELECtxt" ClientInstanceName="ID_SOLIC_PRESELECtxt"  HorizontalAlign="Center" 
                    Font-Names="Arial,Tahoma" Font-Size="Small" ForeColor="Blue" Font-Bold="true" ReadOnly="true" runat="server" Width="70px" />
            </td>
            <td align="right">
                <dx:ASPxLabel ID="lblInscripcion" runat="server" ForeColor="Red" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="FECHA DE INSCRIPCIÓN: *" />
            </td>
            <td>
                <dx:ASPxDateEdit ID="FECHA_PRESENTACIONDateEdit" AutoPostBack="true" Width="120px"  runat="server" EditFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="true">

                </dx:ASPxDateEdit>
            </td>
            <td align="right">
                <dx:ASPxLabel ID="ASPxLabel2" runat="server" ForeColor="Red" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="TIPO: *" />
            </td>
            <td>
                <dx:ASPxComboBox ID="TIPO_SELECCcbx" ClientInstanceName="TIPO_SELECCcbx" ValueType="System.Int32" Width="120px" runat="server" IncrementalFilteringMode="StartsWith" DropDownStyle="DropDownList"
                    DataSourceID="odsTipoSelecc" TextField="NOMBRE" ValueField="ID_TIPO_SELECC">                                                                 
                </dx:ASPxComboBox>
            </td>
            <td align="right">
                <dx:ASPxLabel ID="lblParticipante" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="ID. PARTICIPANTE:" />
            </td>
            <td>
                <dx:ASPxTextBox ID="ID_PARTICIPANTEtxt" ClientInstanceName="ID_PARTICIPANTEtxt" HorizontalAlign="Center" 
                    Font-Names="Arial,Tahoma" Font-Size="Small"  ForeColor="Blue" Font-Bold="true" ReadOnly="true" runat="server" Width="100px" />
            </td>            
        </tr>
        <tr>
            <td>
                <dx:ASPxTextBox ID="ID_GRUPO_SELECtxt" ClientInstanceName="ID_GRUPO_SELECtxt" 
                    Font-Names="Arial,Tahoma" Font-Size="Small" ClientVisible="false" Font-Bold="true" ReadOnly="true" runat="server" Width="100px" />
            </td>
            <td>
                <dx:ASPxTextBox ID="ID_TIPO_SOLICITUDtxt" ClientInstanceName="ID_TIPO_SOLICITUDtxt"
                    Font-Names="Arial,Tahoma" Font-Size="Small" ClientVisible="false" Font-Bold="true" ReadOnly="true" runat="server" Width="100px" />
            </td>
            <th colspan="4">
                <dx:ASPxTextBox ID="ID_ESTADO_SOLICITUDtxt" ClientInstanceName="ID_ESTADO_SOLICITUDtxt" 
                    Font-Names="Arial,Tahoma" Font-Size="Small" ClientVisible="false"  Font-Bold="true" ReadOnly="true" runat="server" Width="100px" />
            </th>
        </tr>
    </table>    
   <dx:ASPxPageControl ID="TabSolicitud" runat="server" ActiveTabIndex="0" ClientInstanceName="TabSolicitud" 
        EnableHierarchyRecreation="True" Width="100%" EnableCallBacks="false" EnableViewState="true" 
        Font-Names="Verdana, Arial, Tahoma"  Font-Size="XX-Small" CssFilePath="~/App_Themes/Aqua/{0}/styles.css" CssPostfix="Aqua" SpriteCssFilePath="~/App_Themes/Aqua/{0}/sprite.css" TabSpacing="3px" >                 
         <LoadingPanelImage Url="~/App_Themes/Aqua/Web/Loading.gif">
        </LoadingPanelImage>
        <ContentStyle>
            <Border BorderColor="#AECAF0" BorderStyle="Solid" BorderWidth="1px" />            
        </ContentStyle>
        <TabPages>                
         <dx:TabPage Text="SECCION 1." ToolTip="DATOS DE IDENTIFICACIÓN">
            <ContentCollection>       
                <dx:ContentControl ID="ContentControl1" runat="server">
                    <table width="100%" style="font-family:Arial,Tahoma,Verdana; font-size:xx-small" >    
                        <tr>
                            <th colspan="2" style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:center; background-color:#E0E0E0">SECCIÓN 1. DATOS DE IDENTIFICACIÓN</th> 
                        </tr>
                         <tr>
                            <th colspan="2" style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">1. Documentos de Identidad *</span></th> 
                        </tr>
                        <tr>
                            <th colspan="2" align="left">
                                <table style="font-family:Arial,Tahoma,Verdana; font-size:xx-small">
                                    <tr>
                                        <td style="width:70px">DUI:</td>
                                        <td>
                                            <dx:ASPxTextBox ID="DUItxt" ClientInstanceName="DUItxt" runat="server" Width="120px" ValidationSettings-Display="Dynamic" >
                                                <MaskSettings Mask="99999999-9" IncludeLiterals="None" />             
                                                <ValidationSettings Display="Dynamic"></ValidationSettings> 
                                                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />                                                
                                            </dx:ASPxTextBox>                                          
                                        </td>
                                        <td align="left" style="width:50px">
                                            <dx:ASPxButton ID="BuscarDUIbtn" AutoPostBack="true" 
                                                CausesValidation="False" runat="server" EnableDefaultAppearance="false" Cursor="hand"
                                                ImagePosition="Left" Width="20px" Height="20px" ToolTip="Buscar Participante por DUI" >
                                                <Image Url="../imagenes/buscar.gif" />                                               
                                            </dx:ASPxButton>
                                        </td>
                                        <td>NIT:</td>
                                        <td>
                                            <dx:ASPxTextBox ID="NITtxt" ClientInstanceName="NITtxt" runat="server" Width="120px" ValidationSettings-Display="Dynamic">
                                                <MaskSettings Mask="9999-999999-999-9" IncludeLiterals="None" />                                            
                                                <ValidationSettings Display="Dynamic"></ValidationSettings>       
                                                <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />                                       
                                            </dx:ASPxTextBox>
                                        </td>
                                        <td align="left" style="width:50px">
                                            <dx:ASPxButton ID="BuscarNITbtn" AutoPostBack="true" CausesValidation="False" Cursor="hand" 
                                                runat="server" EnableDefaultAppearance="false" ImagePosition="Left" Width="20px" 
                                                Height="20px" ToolTip="Buscar Participante por NIT" >
                                                <Image Url="../imagenes/buscar.gif" />                                              
                                            </dx:ASPxButton>
                                        </td>
                                        <td>Carnét Minoridad:</td>
                                        <td><dx:ASPxTextBox ID="CARNET_MINORIDADtxt" CssClass="textUpper" ClientInstanceName="CARNET_MINORIDADtxt"  MaxLength="25" runat="server" Width="120px" /></td>
                                    </tr>
                                    <tr>
                                        <td>ISSS:</td>                                        
                                        <td><dx:ASPxTextBox ID="ISSStxt" CssClass="textUpper" ClientInstanceName="ISSStxt"  MaxLength="9" runat="server" Width="120px"  /></td>
                                        <td></td>
                                        <td>Pasaporte:</td>
                                        <td><dx:ASPxTextBox ID="PASAPORTEtxt" CssClass="textUpper" ClientInstanceName="PASAPORTEtxt"  MaxLength="25" runat="server" Width="120px" Text=""  /></td>
                                        <td></td>
                                        <td>Otro:</td>
                                        <td><dx:ASPxTextBox ID="NUM_DOCTOtxt" CssClass="textUpper" ClientInstanceName="NUM_DOCTOtxt"  MaxLength="25" runat="server" Width="120px" Text=""  /></td>
                                    </tr>
                                </table>
                            </th>                      
                        </tr>  
                        <tr>
                            <th colspan="2" style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">2. Nombre completo *</span></th> 
                        </tr> 
                        <tr>
                            <th colspan="2" align="left">
                                <table style="font-family:Arial,Tahoma,Verdana; font-size:xx-small">
                                    <tr align="left" >
                                        <td style="width:70px">Nombres:</td>
                                        <td><dx:ASPxTextBox ID="NOMBREStxt" CssClass="textUpper" ClientInstanceName="NOMBREStxt" MaxLength="60" runat="server" Width="300px" 
                                               ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Nombres son requeridos." >
<ValidationSettings ErrorDisplayMode="ImageWithTooltip">
<RequiredField IsRequired="True" ErrorText="Nombres son requeridos."></RequiredField>
</ValidationSettings>
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />
                                            </dx:ASPxTextBox>
                                        </td>
                                        <td style="width:70px; text-align:right">Apellidos:</td>
                                        <td><dx:ASPxTextBox ID="APELLIDOStxt" CssClass="textUpper" ClientInstanceName="APELLIDOStxt" MaxLength="60" runat="server" Width="300px" 
                                                ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Apellidos son requeridos." >
<ValidationSettings ErrorDisplayMode="ImageWithTooltip">
<RequiredField IsRequired="True" ErrorText="Apellidos son requeridos."></RequiredField>
</ValidationSettings>
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />
                                            </dx:ASPxTextBox>
                                        </td>     
                                        <td>
                                            <dx:ASPxButton ID="BuscarNombresbtn" ClientInstanceName="BuscarNombresbtn" 
                                                    AutoPostBack="true" CausesValidation="False" runat="server" 
                                                    EnableDefaultAppearance="false" ImagePosition="Left" Cursor="hand"
                                                    Width="20px" Height="20px" ToolTip="Buscar Participante por Nombres y Apellidos" >
                                                <Image Url="../imagenes/buscar.gif" />                                                
                                            </dx:ASPxButton>
                                        </td>                                                               
                                    </tr>                                   
                                </table>
                            </th> 
                        </tr>
                       
                        <tr>
                            <td style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">3. Nacionalidad *</span></td> 
                            <td>
                                <table style="font-family:Arial,Tahoma,Verdana; font-size:xx-small">
                                    <tr>                                       
                                        <td>
                                            <dx:ASPxRadioButtonList ID="NACIONALIDADRadioButtonList" runat="server" AutoPostBack="true"  
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="NACIONALIDADRadioButtonList" ValidationSettings-ValidationGroup="grupoNACIONALIDAD" 
                                                ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Nacionalidad es requerida." 
                                                RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px"  >
<Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="Salvadoreña" Value="1" />
                                                <dx:ListEditItem Text="Extranjera" Value="2" />                                               
                                                </Items>

<ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="grupoNACIONALIDAD">
<RequiredField IsRequired="True" ErrorText="Nacionalidad es requerida."></RequiredField>
</ValidationSettings>

<Border BorderStyle="None"></Border>
                                                                                </dx:ASPxRadioButtonList>
                                        </td>            
                                        <td align="right" style="width:50px">País:</td>
                                        <td><dx:ASPxComboBox ID="ID_PAIScbx" ClientInstanceName="ID_PAIScbx"  Width="120px" runat="server" IncrementalFilteringMode="StartsWith" DropDownStyle="DropDownList"    
                                            DataSourceID="odsPais" TextField="NOMBRE_PAIS" ValueField="ID_PAIS" ValueType="System.Int32" > 
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />                                          
                                            </dx:ASPxComboBox>
                                            
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>                                                    
                        <tr>
                            <th colspan="2" style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">4. Lugar/fecha Nacimiento *</span></th> 
                        </tr>
                        <tr>
                            <th colspan="2" align="left">
                                <table width="50%"  style="font-family:Arial,Tahoma,Verdana; font-size:xx-small">
                                    <tr>
                                        <td>Departamento:</td>
                                        <td>
                                            <dx:ASPxComboBox ID="DEPARTAMENTO_NACcbx" AutoPostBack="true" ClientInstanceName="DEPARTAMENTO_NACcbx"  Width="120px" runat="server" IncrementalFilteringMode="StartsWith" DropDownStyle="DropDownList"
                                                DataSourceID="odsDepartamento" TextField="NOMBRE" ValueField="CODIGO_DEPARTAMENTO">                                               
                                            </dx:ASPxComboBox>
                                        </td>
                                        <td>Municipio:</td>
                                        <td><dx:ASPxComboBox ID="MUNICIPIO_NACcbx" ClientInstanceName="MUNICIPIO_NACcbx"  Width="170px" runat="server" IncrementalFilteringMode="StartsWith" DropDownStyle="DropDownList"
                                               DataSourceID="odsMUNICIPIO_NACcbx" TextField="NOMBRE" ValueField="CODIGO_MUNICIPIO" EnableSynchronization="False" >                                                                                                               
                                            </dx:ASPxComboBox>                                        
                                        </td>                            
                                        <td>Fecha:</td>
                                        <td><dx:ASPxDateEdit ID="FECHA_NACIMIENTODateEdit" AutoPostBack="true" ClientInstanceName="FECHA_NACIMIENTODateEdit" EditFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="true"  Width="120px" runat="server" >
                                            <DisabledStyle BackColor="WhiteSmoke" ForeColor="Black" />
                                        </dx:ASPxDateEdit></td>
                                    </tr>
                                </table>
                            </th>
                        </tr>
                        <tr>
                            <td style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">5. Sexo *</span></td>    
                            <td>
                                <table style="font-family:Arial,Tahoma,Verdana; font-size:xx-small" cellpadding="0" cellspacing="0"  >
                                    <tr>
                                        <td>
                                            <dx:ASPxRadioButtonList ID="GENERORadioButtonList" runat="server"  
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="GENERORadioButtonList"  
                                                RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px" 
                                                ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Sexo es requerido." >
                                                <Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="Masculino" Value="1" />
                                                <dx:ListEditItem Text="Femenino" Value="2"  />                                               
                                                </Items>

<ValidationSettings ErrorDisplayMode="ImageWithTooltip">
<RequiredField IsRequired="True" ErrorText="Sexo es requerido."></RequiredField>
</ValidationSettings>

                                                <Border BorderStyle="None"></Border>
                                            </dx:ASPxRadioButtonList>
                                        </td>                                                                                  
                                    </tr>
                                </table>
                            </td>
                        </tr>                       
                        <tr>
                            <td style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">6. Edad *</span></td>  
                            <td>                          
                            <table cellpadding="0" cellspacing="0">
                                <tr>    
                                    <td><dx:ASPxTextBox ID="EDADtxt" ClientInstanceName="EDADtxt" runat="server" Width="30px" ReadOnly="true"
                                        ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Edad es requerido."  >
<ValidationSettings ErrorDisplayMode="ImageWithTooltip">
<RequiredField IsRequired="True" ErrorText="Edad es requerido."></RequiredField>
</ValidationSettings>
                                        </dx:ASPxTextBox>
                                    </td>
                                    <td style="padding-left:4px" >(años cumplidos)</td>
                                </tr>
                            </table>
                            </td>                                             
                        </tr>                       
                        <tr>
                            <td style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">7. Cuantas Personas integran su grupo familiar *</span></td>    
                            <td>
                                <dx:ASPxSpinEdit ID="MIEMBROS_GRUPO_FAMILIAspn" ClientInstanceName="MIEMBROS_GRUPO_FAMILIAspn" MaxLength="2" AllowUserInput="false"  runat="server" Height="21px" Width="50px"  MinValue="0" MaxValue="99">
                                    <ValidationSettings RequiredField-IsRequired="true" ErrorDisplayMode="ImageWithTooltip" ErrorText="Cantidad de personas del grupo familiar no es válido." EnableCustomValidation="true" RequiredField-ErrorText="Cantidad de personas del grupo familiar no es válido."  >                          
<RequiredField IsRequired="True" ErrorText="Cantidad de personas del grupo familiar no es v&#225;lido."></RequiredField>
                                    </ValidationSettings>
                                    
                                </dx:ASPxSpinEdit> 
                            </td>
                        </tr>
                        <tr>
                            <th colspan="2" style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">8. Estado familiar *</span></th>  
                        </tr>
                        <tr>
                            <th colspan="2" align="left">
                                <table>
                                    <tr>
                                        <td>
                                            <dx:ASPxRadioButtonList ID="ESTADO_CIVILRadioButtonList" runat="server" 
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="ESTADO_CIVILRadioButtonList" ValidationSettings-ValidationGroup="grupoESTADO_CIVIL" 
                                                RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px"
                                                ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Estado familiar es requerido." >
<Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="Soltero(a)" Value="1" />
                                                <dx:ListEditItem Text="Casado(a)" Value="2"  />
                                                <dx:ListEditItem Text="Acompañado(a)" Value="3"  />
                                                <dx:ListEditItem Text="Divorciado(a)" Value="4"  />
                                                <dx:ListEditItem Text="Separado(a)" Value="5"  />
                                                <dx:ListEditItem Text="Viudo(a)" Value="6"  />
                                                </Items>

<ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="grupoESTADO_CIVIL">
<RequiredField IsRequired="True" ErrorText="Estado familiar es requerido."></RequiredField>
</ValidationSettings>

<Border BorderStyle="None"></Border>
                                            </dx:ASPxRadioButtonList>
                                        </td>                                        
                                    </tr>
                                </table>
                            </th>
                        </tr>
                        <tr>
                           <td style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">9. Jefe(a) de hogar *</span></td>   
                           <td>
                                <table>
                                    <tr>
                                        <td>
                                            <dx:ASPxRadioButtonList ID="ES_JEFE_HOGARRadioButotonList" runat="server" 
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="ES_JEFE_HOGARRadioButotonList"  
                                                RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px"
                                                ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Jefe(a) de hogar es requerido.">
<Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="Si" Value="1" />
                                                <dx:ListEditItem Text="No" Value="2"  />
                                                <dx:ListEditItem Text="Compartida" Value="3"  />                                               
                                                </Items>

<ValidationSettings ErrorDisplayMode="ImageWithTooltip">
<RequiredField IsRequired="True" ErrorText="Jefe(a) de hogar es requerido."></RequiredField>
</ValidationSettings>

<Border BorderStyle="None"></Border>
                                            </dx:ASPxRadioButtonList>
                                        </td>                                      
                                    </tr>
                                </table>
                           </td>
                        </tr>                           
                        <tr>
                            <td style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">10. Tiene Hijos *</span></td>   
                            <td>
                                <table style="font-family:Arial,Tahoma,Verdana; font-size:xx-small">
                                    <tr>
                                        <td>
                                            <dx:ASPxRadioButtonList ID="TIENE_HIJOSRadioButtonList" runat="server" AutoPostBack="true" 
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="TIENE_HIJOSRadioButotonList"  
                                                RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px"
                                                ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Tiene hijos es requerido." >
                                                <Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="Si" Value="1" />
                                                <dx:ListEditItem Text="No" Value="2"  />                                                                                          
                                                </Items>

<ValidationSettings ErrorDisplayMode="ImageWithTooltip">
<RequiredField IsRequired="True" ErrorText="Tiene hijos es requerido."></RequiredField>
</ValidationSettings>

                                            <Border BorderStyle="None"></Border>                                           
                                            </dx:ASPxRadioButtonList>
                                        </td>                                        
                                        <td style="text-align:left;padding-left:8px ">N° de hijos:</td>
                                        <td><dx:ASPxTextBox ID="NO_DE_HIJOStxt" ClientInstanceName="NO_DE_HIJOStxt"  MaxLength="2" runat="server" Width="30px" Text="" >
                                                <MaskSettings Mask="99" PromptChar=" " IncludeLiterals="None" />   
                                            </dx:ASPxTextBox>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>                       
                        <tr>
                            <td style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">11. ¿Tiene alguna profesión u oficio? *</span></td>   
                            <td>
                                <table>
                                    <tr>
                                        <td>                                        
                                            <dx:ASPxRadioButtonList ID="PROFESION_OFICIORadioButtonList" runat="server" AutoPostBack="true"  
                                                    Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                    TextSpacing="3px" ClientInstanceName="PROFESION_OFICIORadioButtonList"  
                                                    RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px"
                                                    ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Profesión u oficio es requerido." >
<Paddings Padding="0px"></Paddings>
                                                    <Items>
                                                    <dx:ListEditItem Text="Si" Value="1" />
                                                    <dx:ListEditItem Text="No" Value="2"  />                                                                                          
                                                    </Items>                                                    

<ValidationSettings ErrorDisplayMode="ImageWithTooltip">
<RequiredField IsRequired="True" ErrorText="Profesi&#243;n u oficio es requerido."></RequiredField>
</ValidationSettings>

<Border BorderStyle="None"></Border>
                                            </dx:ASPxRadioButtonList>
                                        </td>   
                                    </tr>
                                </table>
                            </td>
                        </tr>    
                        <tr>
                            <td style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0">11.1 ¿A cuál profesión u oficio se dedica?:</td>   
                            <td><dx:ASPxTextBox ID="PROFESION_OFICIOtxt" CssClass="textUpper" ClientInstanceName="PROFESION_OFICIOtxt" MaxLength="60" runat="server" Width="200px" Text=""  /></td>
                        </tr> 
                        <tr>
                            <th colspan="2" style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">12. Domicilio *</span></th>  
                        </tr> 
                        <tr>                            
                            <th colspan="2" align="left">
                                <table style="font-family:Arial,Tahoma,Verdana; font-size:xx-small">
                                    <tr>
                                        <td>Dirección:</td>
                                        <th colspan="5"><dx:ASPxTextBox ID="DIRECCIONtxt" CssClass="textUpper" ClientInstanceName="DIRECCIONtxt" MaxLength="150" runat="server" Width="100%" Text="" 
                                        ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Dirección es requerido." >
<ValidationSettings ErrorDisplayMode="ImageWithTooltip">
<RequiredField IsRequired="True" ErrorText="Direcci&#243;n es requerido."></RequiredField>
</ValidationSettings>
                                            </dx:ASPxTextBox>
                                        </th>                                   
                                    </tr>
                                    <tr>
                                        <td>Departamento:</td>
                                        <td><dx:ASPxComboBox ID="CODIGO_DEPARTAMENTOcbx" AutoPostBack="true" ClientInstanceName="CODIGO_DEPARTAMENTOcbx"  Width="120px" runat="server" IncrementalFilteringMode="StartsWith" DropDownStyle="DropDownList"
                                                    DataSourceID="odsDepartamento" TextField="NOMBRE" ValueField="CODIGO_DEPARTAMENTO" 
                                                    ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Departamento de residencia es requerido." >                                                    
                                                    

<ValidationSettings ErrorDisplayMode="ImageWithTooltip">
<RequiredField IsRequired="True" ErrorText="Departamento de residencia es requerido."></RequiredField>
</ValidationSettings>
                                            </dx:ASPxComboBox>
                                        </td>
                                        <td>Municipio:</td>
                                        <td><dx:ASPxComboBox ID="CODIGO_MUNICIPIOcbx" ClientInstanceName="CODIGO_MUNICIPIOcbx" Width="120px" runat="server" IncrementalFilteringMode="StartsWith" DropDownStyle="DropDownList"
                                             DataSourceID="odsCODIGO_MUNICIPIOcbx" TextField="NOMBRE" ValueField="CODIGO_MUNICIPIO" EnableSynchronization="False"> 
                                            </dx:ASPxComboBox>
                                        </td>
                                        <td>Tel. Fijo:</td>
                                        <td><dx:ASPxTextBox ID="TELEFONOtxt" CssClass="textUpper" ClientInstanceName="TELEFONOtxt"  MaxLength="40" runat="server" Width="80px" /></td>
                                    </tr>
                                    <tr>
                                        <td>Tel. Movil:</td>
                                        <td><dx:ASPxTextBox ID="MOVILtxt" CssClass="textUpper" ClientInstanceName="MOVILtxt" MaxLength="40" runat="server" Width="80px" /></td>
                                        <td>Email:</td>
                                        <th colspan="3">
                                            <dx:ASPxTextBox ID="EMAILtxt" ClientInstanceName="EMAILtxt"  MaxLength="100" runat="server" Width="100%" Text="" >
                                                <ValidationSettings>
                                                <RegularExpression ErrorText="Email no válido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                                                </ValidationSettings>
                                            </dx:ASPxTextBox>
                                        </th>                                        
                                    </tr>
                                </table>
                            </th>
                        </tr>                                          
                        <tr>
                            <td style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">13. ¿Tiene usted alguna limitación permanente? *</span></td>   
                            <td>
                                <table>
                                    <tr>                                       
                                        <td>
                                            <dx:ASPxRadioButtonList ID="CON_DISCAPACIDADRadioButtonList" runat="server"  AutoPostBack="true" 
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="CON_DISCAPACIDADRadioButtonList"  
                                                RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px" ValidationSettings-ValidationGroup="grupoCON_DISCAPACIDAD" 
                                                ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Si tiene discapacidad es requerido.">
                                                <Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="Si" Value="1" />
                                                <dx:ListEditItem Text="No" Value="2"  />                                                                                          
                                                </Items>

<ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="grupoCON_DISCAPACIDAD">
<RequiredField IsRequired="True" ErrorText="Si tiene discapacidad es requerido."></RequiredField>
</ValidationSettings>

                                               <Border BorderStyle="None"></Border>                                              
                                            </dx:ASPxRadioButtonList>
                                        </td>        
                                    </tr>
                                </table>
                            </td>
                        </tr> 
                     
                        <tr>
                            <th colspan="2" style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0">13.1 ¿Cuál limitación tiene?:</th>
                        </tr>   
                        <tr>
                            <th colspan="2" align="left" >
                               <table>
                                   <tr>
                                    <td><dx:ASPxCheckBox ID="DISC_MOVERSE_CAMINARchk" ClientInstanceName="DISC_MOVERSE_CAMINARchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Moverse o caminar" /></td>
                                    <td><dx:ASPxCheckBox ID="DISC_HABLARchk" ClientInstanceName="DISC_HABLARchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Hablar"/></td>
                                    <td></td>
                                   </tr>
                                   <tr>
                                    <td><dx:ASPxCheckBox ID="DISC_BRAZOS_MANOSchk" ClientInstanceName="DISC_BRAZOS_MANOSchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Usar sus brazos o manos" /></td>
                                    <td><dx:ASPxCheckBox ID="DISC_RETRASOchk" ClientInstanceName="DISC_RETRASOchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Tiene algún restraso o deficiencia mental"/></td>
                                    <td></td>
                                   </tr>
                                   <tr>
                                    <td><dx:ASPxCheckBox ID="DISC_VERchk" ClientInstanceName="DISC_VERchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Ver, aun usando lentes" /></td>
                                    <td><dx:ASPxCheckBox ID="DISC_BAN_VESTIR_ALIMchk" ClientInstanceName="DISC_BAN_VESTIR_ALIMchk"  runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Bañarse, vestirse, alimentarse por si mismo" /></td>
                                    <td></td>
                                   </tr>
                                   <tr>
                                    <td>
                                        <dx:ASPxCheckBox ID="DISC_OIRchk" ClientInstanceName="DISC_OIRchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Oír, aun usando aparatos especiales" />
                                    </td>
                                    <td>
                                        <table cellpadding="0" cellspacing="0" >
                                            <tr>
                                                <td><dx:ASPxCheckBox ID="DISC_OTRAchk" AutoPostBack="true" ClientInstanceName="DISC_OTRAchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Otra:" >                                                        
                                                    </dx:ASPxCheckBox>
                                                </td>
                                                <td style="padding-left:5px"><dx:ASPxTextBox CssClass="textUpper" ID="DISC_OTRAtxt" ClientInstanceName="DISC_OTRAtxt"  runat="server" Width="300px" /></td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td></td>
                                   </tr>
                               </table>
                            </th>
                        </tr>       
                    </table>
                </dx:ContentControl>
            </ContentCollection>
         </dx:TabPage>
         <dx:TabPage Text="SECCION 2." ToolTip="EDUCACIÓN FORMAL Y FORMACIÓN OCUPACIONAL" >
            <ContentCollection>       
                <dx:ContentControl ID="ContentControl2" runat="server">
                    <table width="100%" style="font-family:Arial,Tahoma,Verdana; font-size:xx-small" >    
                        <tr>
                            <th 
                                
                                
                                style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:center; background-color:#E0E0E0">SECCIÓN 2. EDUCACIÓN FORMAL Y FORMACIÓN OCUPACIONAL</th> 
                        </tr>                                                                                                
                        <tr>
                            <th style="font-family:Verdana; font-weight:bold; font-size:xx-small; padding-left:5px; text-align:left; background-color:#E0E0E0;"><span class="req">1. ¿Nivel académico que tiene al iniciar el programa? *</span></th>                       
                        </tr>
                        <tr>
                            <th align="left">
                                <table style="font-family:Verdana,Arial,Tahoma; font-size:xx-small">
                                    <tr>
                                        <td>
                                            <dx:ASPxRadioButton ID="EDUCACION_BASICArdb" AutoPostBack="true" Font-Names="Verdana,Arial,Tahoma" Font-Size="XX-Small" runat="server" Text="EDUCACIÓN BÁSICA:"  GroupName="grupoEDUCACION_FORMAL" >
                                                
                                            </dx:ASPxRadioButton>
                                        </td>
                                        <td>
                                            <dx:ASPxRadioButtonList ID="EDUCACION_BASICARadioButtonList" runat="server" 
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="EDUCACION_BASICARadioButtonList"  ValidationSettings-ValidationGroup="grupoEDUCACION_BASICA"  
                                                RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px">
                                                <Paddings Padding="0px"></Paddings>
                                                <Items>                                                
                                                <dx:ListEditItem Text="6° Gdo." Value="14"  />  
                                                <dx:ListEditItem Text="7° Gdo." Value="15"  />  
                                                <dx:ListEditItem Text="8° Gdo." Value="16"  />  
                                                <dx:ListEditItem Text="9° Gdo." Value="17"  />  
                                                </Items>

<ValidationSettings ValidationGroup="grupoEDUCACION_BASICA"></ValidationSettings>

                                            <Border BorderStyle="None"></Border>
                                            </dx:ASPxRadioButtonList>
                                        </td>                                                 
                                    </tr>
                                </table>
                            </th>
                        </tr>
                        <tr>
                            <th align="left" >
                                <table>
                                    <tr>
                                        <td style="width:140px">
                                            <dx:ASPxRadioButton ID="BACHILLERATOrdb" AutoPostBack="true" Font-Names="Verdana,Arial,Tahoma" Font-Size="XX-Small" runat="server" Text="BACHILLERATO:" GroupName="grupoEDUCACION_FORMAL" >                                                
                                                
                                            </dx:ASPxRadioButton>                                         
                                        </td>                                        
                                        <td>
                                            <dx:ASPxRadioButtonList ID="BACHILLERATORadioButtonList" runat="server" 
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="BACHILLERATORadioButtonList" ValidationSettings-ValidationGroup="grupoBACHILLERATO"   
                                                RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px">
                                                <Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="Completa" Value="18" />
                                                <dx:ListEditItem Text="Incompleta" Value="19" />
                                                </Items>

<ValidationSettings ValidationGroup="grupoBACHILLERATO"></ValidationSettings>

                                            <Border BorderStyle="None"></Border>
                                            </dx:ASPxRadioButtonList>
                                        </td>                                  
                                    </tr>         
                                    <tr>
                                        <td>
                                            <dx:ASPxRadioButton ID="TECNOLOGICArdb" AutoPostBack="true" Font-Names="Verdana,Arial,Tahoma" Font-Size="XX-Small" runat="server" Text="TECNOLOGICA:"  GroupName="grupoEDUCACION_FORMAL" >
                                              
                                            </dx:ASPxRadioButton>                                          
                                        </td>  
                                        <td>
                                            <dx:ASPxRadioButtonList ID="TECNOLOGICARadioButtonList" runat="server" 
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="TECNOLOGICARadioButtonList" ValidationSettings-ValidationGroup="grupoTECNOLOGICA"   
                                                RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px">
                                                <Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="Completa" Value="20" />
                                                <dx:ListEditItem Text="Incompleta" Value="21" />
                                                </Items>

<ValidationSettings ValidationGroup="grupoTECNOLOGICA"></ValidationSettings>

                                            <Border BorderStyle="None"></Border>
                                            </dx:ASPxRadioButtonList>
                                        </td>                     
                                    </tr>                            
                                    <tr>
                                        <td>
                                            <dx:ASPxRadioButton ID="UNIVERSITARIArdb" AutoPostBack="true" Font-Names="Verdana,Arial,Tahoma" Font-Size="XX-Small" runat="server" Text="UNIVERSITARIA:" GroupName="grupoEDUCACION_FORMAL" >                                                
                                            </dx:ASPxRadioButton>                                          
                                        </td>  
                                        <td>
                                            <dx:ASPxRadioButtonList ID="UNIVERSITARIARadioButtonList" runat="server" AutoPostBack="true"   
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="UNIVERSITARIARadioButtonList" ValidationSettings-ValidationGroup="grupoUNIVERSITARIA"   
                                                RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px">
                                                <Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="Completa" Value="22" />
                                                <dx:ListEditItem Text="Incompleta" Value="23" />
                                                </Items>

<ValidationSettings ValidationGroup="grupoUNIVERSITARIA"></ValidationSettings>

                                            <Border BorderStyle="None"></Border>
                                            </dx:ASPxRadioButtonList>
                                        </td>                     
                                    </tr> 
                                </table>
                            </th>                                                       
                        </tr> 
                        <tr>
                            <th align="left" >
                                <table>
                                    <tr>                                        
                                        <td>
                                            <dx:ASPxCheckBox ID="TITULO_CERTIFICADO_OBTENIDOchk" AutoPostBack="true" runat="server" Font-Bold="true" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Título o certificado obtenido:">                                                
                                            </dx:ASPxCheckBox>
                                        </td>
                                        <td><dx:ASPxTextBox ID="TITULO_CERTIFICADO_OBTENIDOtxt" CssClass="textUpper" ClientInstanceName="TITULO_CERTIFICADO_OBTENIDOtxt" MaxLength="60" runat="server" Width="600px"/></td>
                                    </tr>
                                </table>
                            </th>                            
                        </tr>                        
                        <tr>
                            <th 
                                
                                style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">2. ¿Ha dejado de estudiar? *</span></th>                             
                        </tr>                        
                        <tr>
                            <th align="left" >
                                <table>
                                    <tr>
                                        <td>
                                        <dx:ASPxRadioButtonList ID="ESTUDIA_ACTUALMENTERadioButtonlist" runat="server" AutoPostBack="true"  
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="ESTUDIA_ACTUALMENTERadioButtonlist" ValidationSettings-ValidationGroup="grupoESTUDIA_ACTUALMENTE"  
                                                ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Estudia actualmente es requerido." 
                                                RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px">
                                                <Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="Si" Value="2" />
                                                <dx:ListEditItem Text="No" Value="1" />
                                                </Items>                                            
<ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="grupoESTUDIA_ACTUALMENTE">
<RequiredField IsRequired="True" ErrorText="Estudia actualmente es requerido."></RequiredField>
</ValidationSettings>

                                            <Border BorderStyle="None"></Border>
                                       </dx:ASPxRadioButtonList>
                                       </td>                                                                                
                                    </tr>
                                </table>
                            </th>        
                        </tr>
                        <tr>
                           <th style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0" class="auto-style1">2.1 ¿Hace cuánto tiempo?</th>                              
                        </tr>
                        <tr>
                            <th align="left" >
                                <table>
                                    <tr>                                        
                                        <td>
                                            <dx:ASPxRadioButtonList ID="TIEMPO_DEJO_ESTUDIARRadioButtonList" runat="server" 
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="TIEMPO_DEJO_ESTUDIARRadioButtonList" ValidationSettings-ValidationGroup="grupoTIEMPO_DEJO_ESTUDIAR"   
                                                RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px">
                                                <Paddings Padding="0px"></Paddings>
                                                <Items>                                                
                                                <dx:ListEditItem Text="1 año" Value="4" />
                                                <dx:ListEditItem Text="2-3 años" Value="5" />
                                                <dx:ListEditItem Text="Más de 3 años" Value="3" />
                                                <dx:ListEditItem Text="NR" Value="6" />
                                                </Items>

<ValidationSettings ValidationGroup="grupoTIEMPO_DEJO_ESTUDIAR"></ValidationSettings>

                                            <Border BorderStyle="None"></Border>
                                            </dx:ASPxRadioButtonList>
                                        </td>            
                                    </tr>
                                </table>
                            </th>    
                        </tr> 
                        <tr>
                           <th style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0" class="auto-style1">2.2 ¿Motivo por el que dejó de estudiar?</th>                              
                        </tr>   
                        <tr>
                            <th align="left" >
                                <table>
                                    <tr>                                        
                                        <td>
                                            <dx:ASPxRadioButtonList ID="MOTIVO_DEJO_ESTUDIARRadioButtonList" runat="server" 
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="MOTIVO_DEJO_ESTUDIARRadioButtonList" ValidationSettings-ValidationGroup="grupoMOTIVO_DEJO_ESTUDIAR"   
                                                RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px">
                                                <Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="Problemas económicos" Value="1" />
                                                <dx:ListEditItem Text="Problemas familiares" Value="2" />
                                                <dx:ListEditItem Text="Otro" Value="3" />                                                
                                                </Items>
<ValidationSettings ValidationGroup="grupoMOTIVO_DEJO_ESTUDIAR"></ValidationSettings>
                                            <Border BorderStyle="None"></Border>
                                            </dx:ASPxRadioButtonList>
                                        </td>            
                                    </tr>
                                </table>
                            </th>    
                        </tr>                     
                        <tr>
                            <th style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">3. ¿Ha recibido antes algún(os) curso(s) de capacitación? *</span></th>                              
                        </tr>
                        
                        <tr>    
                            <th align="left" >
                                <table>
                                    <tr>           
                                    <td>                        
                                    <dx:ASPxRadioButtonList ID="RECIBIO_CURSO_ANTERIORRadioButtonList" runat="server" AutoPostBack="true"  
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="RECIBIO_CURSO_ANTERIORRadioButtonList"  
                                                ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Ha recibido cursos de capacitación es requerido."
                                                RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px">
                                                <Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="Si" Value="1" />
                                                <dx:ListEditItem Text="No" Value="2" />                                               
                                                </Items>                                               

<ValidationSettings ErrorDisplayMode="ImageWithTooltip">
<RequiredField IsRequired="True" ErrorText="Ha recibido cursos de capacitaci&#243;n es requerido."></RequiredField>
</ValidationSettings>

                                            <Border BorderStyle="None"></Border>
                                    </dx:ASPxRadioButtonList>
                                    </td>  
                                    </tr>
                                </table>
                            </th>
                        </tr>
                        <tr>
                            <th align="left" 
                                style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left">
                                <table style="font-family:Verdana; font-weight:bold; text-align:center;  font-size:xx-small;" width="100%" cellspacing="2px"  >
                                    <tr>
                                        <td style="background-color:#E0E0E0; width:340px; text-align:left">4. Si, ¿Cuál(es)? Mencione solamente las recibidas en los últimos 3 años</td>
                                        <td style="background-color:#E0E0E0">4.1 ¿Lo impartió INSAFORP?</td>
                                        <td style="background-color:#E0E0E0; width:70px">Año</td>                                        
                                    </tr>
                                    <tr>
                                        <td><dx:ASPxTextBox ID="CURSO1txt" CssClass="textUpper" ClientInstanceName="CURSO1txt" MaxLength="150" runat="server" Width="100%"/></td>
                                        <td>
                                            <dx:ASPxRadioButtonList ID="IMPARTIO_INSAFORP1ButtonList" runat="server" 
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="IMPARTIO_INSAFORP1ButtonList" ValidationSettings-ValidationGroup="grupoIMPARTIO_INSAFORP1"  
                                                RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px">
                                                <Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="Si" Value="1" />
                                                <dx:ListEditItem Text="No" Value="2" />                                               
                                                <dx:ListEditItem Text="No sabe" Value="3" />
                                                </Items>

<ValidationSettings ValidationGroup="grupoIMPARTIO_INSAFORP1"></ValidationSettings>

                                                <Border BorderStyle="None"></Border>
                                            </dx:ASPxRadioButtonList>
                                        </td>
                                        <td><dx:ASPxTextBox ID="ANIO1txt" CssClass="textUpper" ClientInstanceName="ANIO1txt" MaxLength="4" runat="server" Width="70px">
                                                <MaskSettings Mask="9999" PromptChar="_" IncludeLiterals="None" />   
                                            </dx:ASPxTextBox>
                                        </td>                                       
                                    </tr>
                                    <tr>
                                        <td><dx:ASPxTextBox ID="CURSO2txt" CssClass="textUpper" ClientInstanceName="CURSO2txt" MaxLength="150" runat="server" Width="100%"/></td>
                                        <td>
                                            <dx:ASPxRadioButtonList ID="IMPARTIO_INSAFORP2ButtonList" runat="server" 
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="IMPARTIO_INSAFORP2ButtonList" ValidationSettings-ValidationGroup="grupoIMPARTIO_INSAFORP2"  
                                                RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px">
                                                <Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="Si" Value="1" />
                                                <dx:ListEditItem Text="No" Value="2" />                                               
                                                <dx:ListEditItem Text="No sabe" Value="3" />
                                                </Items>

<ValidationSettings ValidationGroup="grupoIMPARTIO_INSAFORP2"></ValidationSettings>

                                                <Border BorderStyle="None"></Border>
                                            </dx:ASPxRadioButtonList>
                                        </td>
                                        <td><dx:ASPxTextBox ID="ANIO2txt" CssClass="textUpper" ClientInstanceName="ANIO2txt" MaxLength="4" runat="server" Width="70px">
                                                <MaskSettings Mask="9999" PromptChar="_" IncludeLiterals="None" />   
                                            </dx:ASPxTextBox>
                                        </td>                                       
                                    </tr>
                                    <tr>
                                        <td><dx:ASPxTextBox ID="CURSO3txt" CssClass="textUpper" ClientInstanceName="CURSO3txt" MaxLength="150" runat="server" Width="100%"/></td>
                                        <td>
                                            <dx:ASPxRadioButtonList ID="IMPARTIO_INSAFORP3ButtonList" runat="server" 
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="IMPARTIO_INSAFORP3ButtonList" ValidationSettings-ValidationGroup="grupoIMPARTIO_INSAFORP3"   
                                                RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px">
                                                <Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="Si" Value="1" />
                                                <dx:ListEditItem Text="No" Value="2" />                                               
                                                <dx:ListEditItem Text="No sabe" Value="3" />
                                                </Items>

<ValidationSettings ValidationGroup="grupoIMPARTIO_INSAFORP3"></ValidationSettings>

                                                <Border BorderStyle="None"></Border>
                                            </dx:ASPxRadioButtonList>
                                        </td>
                                        <td><dx:ASPxTextBox ID="ANIO3txt" CssClass="textUpper" ClientInstanceName="ANIO3txt" MaxLength="4" runat="server" Width="70px" >
                                                <MaskSettings Mask="9999" PromptChar="_" IncludeLiterals="None" />   
                                            </dx:ASPxTextBox>    
                                        </td>                                        
                                    </tr>
                                </table>
                            </th>  
                        </tr>                       
                    </table>
                </dx:ContentControl>
            </ContentCollection>
         </dx:TabPage>
         <dx:TabPage Text="SECCION 3." ToolTip="INFORMACIÓN SOBRE SU SITUACIÓN LABORAL" >
            <ContentCollection>       
                <dx:ContentControl ID="ContentControl3" runat="server">
                    <table width="100%" style=" font-family:Arial,Tahoma,Verdana; font-size:xx-small" >    
                        <tr>
                            <th colspan="2" style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:center; background-color:#E0E0E0">SECCIÓN 3. INFORMACIÓN SOBRE SU SITUACIÓN LABORAL</th> 
                        </tr>   
                        <tr>
                            <th colspan="2" style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0">Sub-Sección 3.1. ACTIVIDADES A LAS QUE SE DEDICA</th> 
                        </tr> 
                        <tr>
                            <th colspan="2" style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">1. ¿A qué actividad se dedica usted actualmente? *</span></th> 
                        </tr> 
                        <tr>
                            <th colspan="2" align="left"> 
                                <table>
                                    <tr>
                                        <td><dx:ASPxCheckBox ID="OCUACT_TRABAJAchk" ClientInstanceName="OCUACT_TRABAJAchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Trabaja">
                                                                            
                                            </dx:ASPxCheckBox>
                                        </td>
                                        <td>
                                            <dx:ASPxCheckBox ID="OCUACT_ESTUDIAchk" ClientInstanceName="OCUACT_ESTUDIAchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Estudia" >
                                               </dx:ASPxCheckBox>
                                        </td>
                                        <td><dx:ASPxCheckBox ID="OCUACT_ESTUDIA_TRABAJAchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Estudia y trabaja"/></td>  
                                        <td><dx:ASPxCheckBox ID="OCUACT_OFICIOS_HOGARchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Oficios del Hogar"/></td>  
                                        <td><dx:ASPxCheckBox ID="OCUACT_BUSCA_TRABAJOchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Busca trabajo" /></td>     
                                        <td><dx:ASPxCheckBox ID="OCUACT_OTRAchk" AutoPostBack="true" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Otra:">                                           
                                            </dx:ASPxCheckBox>
                                        </td>                                        
                                        <td><dx:ASPxTextBox ID="OCUACT_OTRAtxt" CssClass="textUpper" ClientInstanceName="OCUACT_OTRAtxt" MaxLength="100" runat="server" Width="200px">
                                            </dx:ASPxTextBox>
                                        </td>
                                    </tr>
                                </table>
                            </th>
                        </tr>
                        <tr>
                            <th colspan="2" style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">2. ¿Alguna de esas actividades le genera ingresos económicos? *</span></th> 
                        </tr>
                        <tr>
                            <td>
                                <table style="font-family:Arial,Tahoma,Verdana; font-size:xx-small" cellpadding="0" cellspacing="0" >
                                    <tr>                                        
                                        <td>
                                            <dx:ASPxRadioButtonList ID="RECIBE_INGRESOSRadioButtonList" runat="server" 
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="RECIBE_INGRESOSRadioButtonList"  
                                                RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px"
                                                ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Recibe ingresos es requerido.">
                                                <Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="Si" Value="1" />
                                                <dx:ListEditItem Text="No" Value="2" />                                                                                          
                                                </Items>
                                           
<ValidationSettings ErrorDisplayMode="ImageWithTooltip">
<RequiredField IsRequired="True" ErrorText="Recibe ingresos es requerido."></RequiredField>
</ValidationSettings>

                                            <Border BorderStyle="None"></Border>
                                            </dx:ASPxRadioButtonList>
                                        </td>     
                                    </tr>
                                </table>
                            </td> 
                        </tr>     
                        <tr>
                            <th colspan="2" style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">3. El ingreso para su sostenimiento lo obtiene por medio de *</span></th> 
                        </tr> 
                        <tr>
                            <th colspan="2" align="left">
                                <table>
                                    <tr>
                                        <td>   
                                            <dx:ASPxRadioButtonList ID="TIPO_EMPLEORadioButtonList" runat="server" AutoPostBack="true"   
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px" RepeatColumns="5" 
                                                TextSpacing="1px" ClientInstanceName="TIPO_EMPLEORadioButtonList" ValidationSettings-ValidationGroup="grupoTIPO_EMPLEO"   
                                                RepeatDirection="Vertical" ValueType="System.Int32" ItemSpacing="6px">
                                                <Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="Trabajo" Value="1" />
                                                <dx:ListEditItem Text="Beca" Value="2" />                                               
                                                <dx:ListEditItem Text="Ayuda Familiar" Value="3" />
                                                <dx:ListEditItem Text="Remesa" Value="4" />                                                
                                                <dx:ListEditItem Text="Otro:" Value="5" />
                                                </Items>
                                                <ValidationSettings ValidationGroup="grupoTIPO_EMPLEO"></ValidationSettings>
                                                <Border BorderStyle="None"></Border>                                           
                                            </dx:ASPxRadioButtonList> 
                                        </td>
                                        <td valign="top" style="padding-left:5px">
                                            <dx:ASPxTextBox ID="TIEMP_OTROtxt" CssClass="textUpper" ClientInstanceName="TIEMP_OTROtxt" MaxLength="100" runat="server" Width="200px" />
                                        </td>
                                    </tr>
                                </table> 
                            </th>
                        </tr>
                        <tr>
                            <th colspan="2" style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">4. ¿De cuanto es el ingreso mensual que usted recibe? *</span></th> 
                        </tr>
                        <tr>
                            <th colspan="2" align="left" >
                                <table> 
                                    <tr>
                                        <td>
                                            <dx:ASPxComboBox ID="INGRESO_MEScbx" ClientInstanceName="INGRESO_MEScbx"  Width="400px" runat="server" IncrementalFilteringMode="StartsWith" DropDownStyle="DropDownList"    
                                            DataSourceID="odsIngresoMes" TextField="NOMBRE_ING" ValueField="ID_INGRESO_MES" ValueType="System.Int32" >                                            
                                            </dx:ASPxComboBox>
                                        </td>                                                    
                                    </tr>
                                </table>
                            </th> 
                        </tr>                       
                        <tr>
                             <th colspan="2"  style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0">SECCIÓN 3.2. EXPERIENCIA LABORAL</th>                             
                        </tr>
                        <tr>
                            <td style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0; width:50%"><span class="req">1. ¿Ha trabajado antes? *</span></td>    
                            <td>
                                <table style="font-family:Arial,Tahoma,Verdana; font-size:xx-small" cellpadding="0" cellspacing="0"  >
                                    <tr>                                       
                                        <td>
                                            <dx:ASPxRadioButtonList ID="TRABAJO_ANTERIORRadioButtonList" runat="server" AutoPostBack="true"   
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="TRABAJO_ANTERIORRadioButtonList"  
                                                RepeatDirection="Horizontal" ValueType="System.String" ItemSpacing="6px" ValidationSettings-ValidationGroup="grupoTRABAJO_ANTERIOR" 
                                                ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Ha trabajado antes es requerido.">
                                                <Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="Si" Value="S" />
                                                <dx:ListEditItem Text="No" Value="N" />                                                                                              
                                                </Items>                                           

<ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="grupoTRABAJO_ANTERIOR">
<RequiredField IsRequired="True" ErrorText="Ha trabajado antes es requerido."></RequiredField>
</ValidationSettings>

                                            <Border BorderStyle="None"></Border>
                                            </dx:ASPxRadioButtonList>
                                        </td>     
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0; width:50%">2. ¿Hace cuánto tiempo hace que no trabaja?</td>    
                            <td>
                                <table style="font-family:Arial,Tahoma,Verdana; font-size:xx-small" cellpadding="0" cellspacing="0" >
                                    <tr>                                        
                                        <td>
                                            <dx:ASPxRadioButtonList ID="TIEMPO_NO_TRABAJARadioButtonList1" runat="server" 
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="TIEMPO_NO_TRABAJARadioButtonList" ValidationSettings-ValidationGroup="grupoTIEMPO_NO_TRABAJA"  
                                                RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px">
                                                <Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="1 año o menos" Value="1" />
                                                <dx:ListEditItem Text="2 años" Value="2" />                                                                                              
                                                <dx:ListEditItem Text="3 años" Value="3" />  
                                                <dx:ListEditItem Text="Más de 3 años" Value="4" />  
                                                </Items>

<ValidationSettings ValidationGroup="grupoTIEMPO_NO_TRABAJA"></ValidationSettings>

                                            <Border BorderStyle="None"></Border>
                                            </dx:ASPxRadioButtonList>
                                        </td>     
                                    </tr>
                                </table>
                            </td>
                        </tr>  
                        <tr>
                            <th colspan="2" style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0">3. Nombre de las últimas 3 empresas en las que ha trabajado (empiece con la mas reciente)</th> 
                        </tr>                        
                        <tr>
                            <th colspan="2" align="left" 
                                style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left">
                                <table style="font-family:Verdana; font-weight:bold; text-align:center;  font-size:xx-small;" width="100%" cellspacing="2px"  >
                                    <tr>
                                        <td style="background-color:#E0E0E0; width:340px; text-align:left">Nombre de la empresa</td>
                                        <td style="background-color:#E0E0E0">Cargo</td>
                                        <td style="background-color:#E0E0E0; width:200px">Principales funciones</td>                                        
                                        <td style="background-color:#E0E0E0; width:100px">Desde/Hasta</td>
                                    </tr>
                                    <tr>
                                        <td><dx:ASPxTextBox ID="NOMBRE_EMPRESA1txt" CssClass="textUpper" ClientInstanceName="NOMBRE_EMPRESA1txt" MaxLength="500" runat="server" Width="100%"/></td>
                                        <td><dx:ASPxTextBox ID="CARGO1txt" CssClass="textUpper" ClientInstanceName="CARGO1txt" MaxLength="200" runat="server" Width="100%"/></td>
                                        <td><dx:ASPxTextBox ID="FUNCIONES1txt" CssClass="textUpper" ClientInstanceName="FUNCIONES1txt" MaxLength="200" runat="server" Width="200px" /></td>                                       
                                        <td><dx:ASPxTextBox ID="DESDE_HASTA1txt" CssClass="textUpper" ClientInstanceName="DESDE_HASTA1txt" MaxLength="200" runat="server" Width="100px" /></td>
                                    </tr>
                                    <tr>
                                        <td><dx:ASPxTextBox ID="NOMBRE_EMPRESA2txt" CssClass="textUpper" ClientInstanceName="NOMBRE_EMPRESA2txt" MaxLength="500" runat="server" Width="100%"/></td>
                                        <td><dx:ASPxTextBox ID="CARGO2txt" CssClass="textUpper" ClientInstanceName="CARGO2txt" MaxLength="200" runat="server" Width="100%"/></td>
                                        <td><dx:ASPxTextBox ID="FUNCIONES2txt" CssClass="textUpper" ClientInstanceName="FUNCIONES2txt" MaxLength="200" runat="server" Width="200px" /></td>                                       
                                        <td><dx:ASPxTextBox ID="DESDE_HASTA2txt" CssClass="textUpper" ClientInstanceName="DESDE_HASTA2txt" MaxLength="200" runat="server" Width="100px" /></td>
                                    </tr>
                                     <tr>
                                        <td><dx:ASPxTextBox ID="NOMBRE_EMPRESA3txt" CssClass="textUpper" ClientInstanceName="NOMBRE_EMPRESA3txt" MaxLength="500" runat="server" Width="100%"/></td>
                                        <td><dx:ASPxTextBox ID="CARGO3txt" CssClass="textUpper" ClientInstanceName="CARGO3txt" MaxLength="200" runat="server" Width="100%"/></td>
                                        <td><dx:ASPxTextBox ID="FUNCIONES3txt" CssClass="textUpper" ClientInstanceName="FUNCIONES3txt" MaxLength="200" runat="server" Width="200px" /></td>                                       
                                        <td><dx:ASPxTextBox ID="DESDE_HASTA3txt" CssClass="textUpper" ClientInstanceName="DESDE_HASTA3txt" MaxLength="200" runat="server" Width="100px" /></td>
                                    </tr>
                                </table>
                            </th>  
                        </tr>                       
                        <tr>
                            <th colspan="2" style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0">4. ¿A cuál rama de la actividad económica se dedica la empresa en la que usted trabajó más tiempo?</th> 
                        </tr> 
                        <tr>
                            <th colspan="2" align="left" >
                                <table> 
                                    <tr>
                                        <td>
                                            <dx:ASPxComboBox ID="ACTI_ECONOMICAcbx" ClientInstanceName="ACTI_ECONOMICAcbx"  Width="400px" runat="server" IncrementalFilteringMode="StartsWith" DropDownStyle="DropDownList"    
                                            DataSourceID="odsActiEconomica" TextField="NOMBRE_ACTI_ECONOMICA" ValueField="ID_ACTI_ECONOMICA" ValueType="System.Int32" >                                            
                                            </dx:ASPxComboBox>
                                        </td>                                                    
                                    </tr>
                                </table>
                            </th> 
                        </tr>    
                         <tr>
                            <td style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0" class="auto-style2">5. Puesto que desempeño en esa empresa</td> 
                            <td valign="top" style="padding-left:5px">
                                            <dx:ASPxTextBox ID="PUESTO_DESEMPENOtxt" CssClass="textUpper" ClientInstanceName="PUESTO_DESEMPENOtxt" MaxLength="100" runat="server" Width="100%" />
                            </td>
                        </tr> 
                         <tr>
                            <td style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0" class="auto-style2">6. ¿En cuál área de la empresa trabajaba usted?</td> 
                            <td valign="top" style="padding-left:5px">
                                <dx:ASPxComboBox ID="AREA_EMPRESAcbx" ClientInstanceName="AREA_EMPRESAcbx"  Width="400px" runat="server" IncrementalFilteringMode="StartsWith" DropDownStyle="DropDownList"    
                                DataSourceID="odsAreaEmpresa" TextField="NOMBRE_AREA_EMPRESA" ValueField="ID_AREA_EMPRESA" ValueType="System.Int32" >                                            
                                </dx:ASPxComboBox>
                            </td>
                        </tr>  
                        <tr>
                            <td style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0" class="auto-style2">7. ¿Por cuál motivo dejo de trabajar?</td> 
                            <td valign="top" style="padding-left:5px">
                                <dx:ASPxComboBox ID="MOTIVO_DEJO_TRABcbx" ClientInstanceName="MOTIVO_DEJO_TRABcbx"  Width="400px" runat="server" IncrementalFilteringMode="StartsWith" DropDownStyle="DropDownList"    
                                DataSourceID="odsMotivoDejoTrab" TextField="NOMBRE_MOTIVO_DEJO_TRAB" ValueField="ID_MOTIVO_DEJO_TRAB" ValueType="System.Int32" >                                            
                                </dx:ASPxComboBox>
                            </td>
                        </tr>    
                        <tr>
                            <td style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0" class="auto-style2">8. ¿De cuánto fué su último salario mensual?</td> 
                            <td valign="top" style="padding-left:5px">
                                <dx:ASPxComboBox ID="ULT_SALARIO_MEScbx" ClientInstanceName="ULT_SALARIO_MEScbx"  Width="400px" runat="server" IncrementalFilteringMode="StartsWith" DropDownStyle="DropDownList"    
                                DataSourceID="odsUltSalarioMes" TextField="NOMBRE_ING" ValueField="ID_INGRESO_MES" ValueType="System.Int32" >                                            
                                </dx:ASPxComboBox>
                            </td>
                        </tr>                     
                    </table>
                </dx:ContentControl>
            </ContentCollection>
         </dx:TabPage>
         <dx:TabPage Text="SECCION 4." ToolTip="EXPECTATIVA Y PERTINENCIA DE LA FORMACIÓN" >
            <ContentCollection>       
                <dx:ContentControl ID="ContentControl4" runat="server">
                    <table width="100%" style=" font-family:Arial,Tahoma,Verdana; font-size:xx-small" >   
                        <tr>
                            <th style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:center; background-color:#E0E0E0">SECCIÓN 4. EXPECTATIVAS RESPECTO A LA FORMACIÓN QUE ESPERA RECIBIR</th>
                        </tr>                
                        <tr>
                            <th style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">1. ¿Cuál es el beneficio que espera recibir como producto de la carrera que le interesa? *</span></th>
                        </tr>
                        <tr>
                            <th align="left">
                                <table>
                                    <tr>
                                        <td>
                                            <dx:ASPxCheckBox ID="EXPFOR_OBTENER_EMPLEOchk" runat="server" CheckState="Unchecked" ClientInstanceName="EXPFOR_OBTENER_EMPLEOchk" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Para obtener un empleo">
                                            </dx:ASPxCheckBox>
                                        </td>
                                        <td>
                                            <dx:ASPxCheckBox ID="EXPFOR_INGRESOS_EXTRAchk" runat="server" CheckState="Unchecked" ClientInstanceName="EXPFOR_INGRESOS_EXTRAchk" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Obtener ingresos por trabajos extras">
                                            </dx:ASPxCheckBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <dx:ASPxCheckBox ID="EXPFOR_TRABAJAR_CTA_PROPIAchk" runat="server" CheckState="Unchecked" ClientInstanceName="EXPFOR_TRABAJAR_CTA_PROPIAchk" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Trabajar por cuenta propia">
                                            </dx:ASPxCheckBox>
                                        </td>
                                        <td align="left">
                                            <table cellpadding="0" cellspacing="0">
                                                <tr>
                                                    <td>
                                                        <dx:ASPxCheckBox ID="EXPFOR_OTROchk" AutoPostBack="true" runat="server" CheckState="Unchecked" ClientInstanceName="EXPFOR_OTROchk" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Otro:">
                                                            
                                                        </dx:ASPxCheckBox>
                                                    </td>
                                                    <td>
                                                        <dx:ASPxTextBox ID="EXPFOR_OTROtxt" runat="server" ClientInstanceName="EXPFOR_OTROtxt" CssClass="textUpper" Width="170px">
                                                        </dx:ASPxTextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </th>
                        </tr>                        
                        <tr>
                            <th style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">2. ¿Por qué eligió usted esta carrera? * (Explique)</span></th>
                        </tr>
                        <tr>
                            <th>
                                <dx:ASPxMemo ID="MOTIVO_ELIGIO_CARRERAtxt" CssClass="textUpper" runat="server" Height="71px" Width="100%">
                                </dx:ASPxMemo>
                            </th>
                        </tr>
                    </table>
                </dx:ContentControl>
            </ContentCollection>
         </dx:TabPage>
         <dx:TabPage Text="SECCION 5." ToolTip="SEGUIMIENTO" >
            <ContentCollection>       
                <dx:ContentControl ID="ContentControl5" runat="server">
                    <table width="100%" style=" font-family:Arial,Tahoma,Verdana; font-size:xx-small" >   
                        <tr>
                            <th style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:center; background-color:#E0E0E0" colspan="2"><span class="req">SECCIÓN 6. SEGUIMIENTO *</span></th></tr>   
                        <tr>
                            <td style="width:80px">Nombre:</td>
                            <td align="left">
                                <table cellpadding="0" cellspacing="0" style="font-family:Arial,Tahoma,Verdana; font-size:XX-Small;">
                                    <tr>
                                        <td>
                                            <dx:ASPxTextBox ID="NOMBRE_FAMILIARtxt" runat="server" ClientInstanceName="NOMBRE_FAMILIARtxt" CssClass="textUpper" MaxLength="80" Width="350px">
                                                <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                                                    <RequiredField ErrorText="Nombre de Familiar es requerido." IsRequired="True" />
                                                </ValidationSettings>
                                            </dx:ASPxTextBox>
                                        </td>
                                        <td style="width:100px; text-align:right">Parentesco:</td>
                                        <td>
                                            <dx:ASPxComboBox ID="ID_PARENTESCOcbx" runat="server" ClientInstanceName="ID_PARENTESCOcbx" DataSourceID="odsReferencia" EnableIncrementalFiltering="True" IncrementalFilteringMode="StartsWith" TextField="NOMBRE_REFERENCIA" ValueField="ID_REFERENCIA" ValueType="System.Int32" Width="100%">
                                                <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                                                    <RequiredField ErrorText="Parentesco es requerido." IsRequired="True" />
                                                </ValidationSettings>
                                            </dx:ASPxComboBox>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr><tr>
                            <td>Dirección:</td>
                            <td>
                                <table cellpadding="0" cellspacing="0" style="font-family:Arial,Tahoma,Verdana; font-size:xx-small">
                                    <tr>
                                        <td>
                                            <dx:ASPxTextBox ID="DIRECCION_FAMILIARtxt" runat="server" CssClass="textUpper" MaxLength="100" Width="667px">
                                                <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                                                    <RequiredField ErrorText="Dirección de familiar es requerido." IsRequired="True" />
                                                </ValidationSettings>
                                            </dx:ASPxTextBox>
                                        </td>
                                        <td>
                                            <dx:ASPxButton ID="CopiarDomiciliobtn" runat="server" AutoPostBack="true" CausesValidation="False" ClientInstanceName="CopiarDomiciliobtn" Cursor="hand" EnableDefaultAppearance="False" Height="20px" ToolTip="Copiar domicilio del Participante" Width="20px">                                               
                                                <Image Url="../imagenes/copiar.png">
                                                </Image>
                                            </dx:ASPxButton>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr><tr>
                            <td>Departamento:</td>
                            <td>
                                <table cellspacing="0" style="font-family:Arial,Tahoma,Verdana; font-size:xx-small;">
                                    <tr>
                                        <td>
                                            <dx:ASPxComboBox ID="CODIGO_DEPARTAMENTO_FAMcbx" AutoPostBack="true" runat="server" ClientInstanceName="CODIGO_DEPARTAMENTO_FAMcbx" DataSourceID="odsDepartamento" EnableIncrementalFiltering="True" IncrementalFilteringMode="StartsWith" TextField="NOMBRE" ValueField="CODIGO_DEPARTAMENTO" ValueType="System.String" Width="120px">                                                
                                                <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                                                    <RequiredField ErrorText="Departamento donde vive familiar es requerido." IsRequired="True" />
                                                </ValidationSettings>
                                            </dx:ASPxComboBox>
                                        </td>
                                        <td align="right" style="width:80px">Municipio:</td>
                                        <td>
                                            <dx:ASPxComboBox ID="CODIGO_MUNICIPIO_FAMcbx" runat="server" ClientInstanceName="CODIGO_MUNICIPIO_FAMcbx" DataSourceID="odsCODIGO_MUNICIPIO_FAMcbx" EnableIncrementalFiltering="True" EnableSynchronization="False" IncrementalFilteringMode="StartsWith" TextField="NOMBRE" ValueField="CODIGO_MUNICIPIO" ValueType="System.String" Width="150px">
                                                <ValidationSettings ErrorDisplayMode="ImageWithTooltip">
                                                    <RequiredField ErrorText="Municipio donde vive familiar es requerido." IsRequired="True" />
                                                </ValidationSettings>
                                            </dx:ASPxComboBox>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr><tr>
                            <td>Tel. Fijo:</td>
                            <td align="left">
                                <table cellspacing="0" style="font-family:Arial,Tahoma,Verdana; font-size:XX-Small;">
                                    <tr>
                                        <td>
                                            <dx:ASPxTextBox ID="TELEFONO_FAMILIARtxt" runat="server" CssClass="textUpper" MaxLength="8" Width="120px">
                                            </dx:ASPxTextBox>
                                        </td>
                                        <td align="right" style="width:80px">Tel. Movil:</td>
                                        <td>
                                            <dx:ASPxTextBox ID="MOVIL_FAMILIARtxt" runat="server" CssClass="textUpper" MaxLength="8" Width="150px">
                                            </dx:ASPxTextBox>
                                        </td>
                                        <td align="right" style="width:80px">Email:</td>
                                        <td>
                                            <dx:ASPxTextBox ID="EMAIL_FAMILIARtxt" runat="server" CssClass="textUpper" MaxLength="100" Width="100px">
                                                <ValidationSettings>
                                                    <RegularExpression ErrorText="Email no válido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                                                </ValidationSettings>
                                            </dx:ASPxTextBox>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>     
                        <tr>
                            <th style="font-family:Verdana; font-weight:bold; font-size:XX-Small; text-align:left; background-color:#E0E0E0" colspan="2">Observaciones o sugerencias</th></tr><tr>
                            <th colspan="2">
                                <dx:ASPxMemo ID="SUGERENCIASMemo" runat="server" Height="71px" Width="100%">
                                </dx:ASPxMemo>
                            </th>
                        </tr>          
                    </table>
                </dx:ContentControl>
            </ContentCollection>
         </dx:TabPage>
        </TabPages>
    </dx:ASPxPageControl>        
</div>

<asp:ObjectDataSource ID="odsTipoSelecc" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cTIPO_SELECC">
    <SelectParameters>               
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />        
        <asp:Parameter DefaultValue="ID_TIPO_SELECC" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="odsUltSalarioMes" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cINGRESO_MES">
    <SelectParameters>               
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />        
        <asp:Parameter DefaultValue="ID_INGRESO_MES" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsMotivoDejoTrab" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cMOTIVO_DEJO_TRAB">
    <SelectParameters>               
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />        
        <asp:Parameter DefaultValue="NOMBRE_MOTIVO_DEJO_TRAB" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsAreaEmpresa" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cAREA_EMPRESA">
    <SelectParameters>               
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />        
        <asp:Parameter DefaultValue="NOMBRE_AREA_EMPRESA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsActiEconomica" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cACTI_ECONOMICA">
    <SelectParameters>               
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />        
        <asp:Parameter DefaultValue="NOMBRE_ACTI_ECONOMICA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsIngresoMes" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cINGRESO_MES">
    <SelectParameters>               
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />        
        <asp:Parameter DefaultValue="ID_INGRESO_MES" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsPais" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cPAIS">
    <SelectParameters>               
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />        
        <asp:Parameter DefaultValue="NOMBRE_PAIS" Name="asColumnaOrden" Type="String" />
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
<asp:ObjectDataSource ID="odsMUNICIPIO_NACcbx" runat="server" 
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
<asp:ObjectDataSource ID="odsCODIGO_MUNICIPIOcbx" runat="server" 
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
<asp:ObjectDataSource ID="odsCODIGO_MUNICIPIO_SOLIC_EMPLEO_ACTUALcbx" runat="server" 
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
<asp:ObjectDataSource ID="odsCODIGO_MUNICIPIO_FAMcbx" runat="server" 
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
<asp:ObjectDataSource ID="odsReferencia" runat="server" 
    OldValuesParameterFormatString="original_{0}"
    SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cREFERENCIA">
    <SelectParameters>               
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />        
        <asp:Parameter DefaultValue="NOMBRE_REFERENCIA" Name="asColumnaOrden" Type="String" />
        <asp:Parameter DefaultValue="ASC" Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

                      

 

  
<dx:ASPxPopupControl ID="popupParticipantes" Modal="true" runat="server" 
        PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" PopupElementID="BuscarNombresbtn" 
        AllowResize="False" DragElement="Header" HeaderStyle-Font-Bold="true" HeaderText="Listado de Participantes"   
        AllowDragging="True" ClientInstanceName="popupParticipantes" ShowShadow="true"
        CloseAction="CloseButton">  
                 <ContentCollection>
                     <dx:PopupControlContentControl ID="PopupControlContentControl1" runat="server" >          
                        <table>               
                            <tr>
                                <td><dx:ASPxLabel ID="popuplblMensaje2" ClientInstanceName="popuplblMensaje2" 
                                        Text="Haga click en la opción Seleccionar para cargar los datos del participante en la solicitud." 
                                        runat="server" Font-Names="Arial,Helveltica" Font-Size="XX-Small" 
                                        Font-Bold="True" ForeColor="#0033CC"  />
                                    <br />
                                    <dx:ASPxLabel ID="lblMensajeGrid" runat="server" 
                                        ClientInstanceName="popuplblMensaje2" Font-Bold="True" 
                                        Font-Names="Arial,Helveltica" Font-Size="XX-Small" 
                                        ForeColor="#0033CC" Visible="false"   
                                        
                                        Text="Existen uno o varios Participantes que coinciden con algunos datos del nuevo participante. Busque en la lista el participante que coincida con el que usted esta ingresando y si lo encuentra haga doble-clic sobre el participante. En caso que ninguno corresponda haga clic en el botón 'Confirmo que no encontre coincidencias'." 
                                        Width="700px">
                                    </dx:ASPxLabel>
                                </td>
                            </tr>                            
                            <tr>
                                <td>
                                    <uc1:ucListaPARTICIPANTE id="ucListaPARTICIPANTE1" runat="server" PermitirSeleccionar="true" ComandoSeleccionar="Check"
                                     VerID_PARTICIPANTE="false" Visible="true"  
                                     VerNOMBRES="true" VerAPELLIDOS="true" VerGENERO="false"
                                     VerID_PAIS="false" VerFECHA_NACIMIENTO="true" VerDIRECCION="true"
                                     VerDUI="true" VerNIT="true" VerISSS="false" VerTIPO_DOCTO="false"
                                     VerNUM_DOCTO="false" VerTELEFONO="true" VerMOVIL="true" VerEMAIL="false"
                                     VerID_ESTADO_CIVIL="false" VerPROFESION_OFICIO="false" VerOCUPACION_ACTUAL="false"
                                     VerTITULO_CERTIFICADO_OBTENIDO="false" VerDEPARTAMENTO_NAC="false" VerMUNICIPIO_NAC="false"
                                     VerCODIGO_DEPARTAMENTO="false" VerCODIGO_MUNICIPIO="false" VerID_NIVEL_ACADEMICO="false"
                                     VerOTRA_EDUCACION_FORMAL="false" VerCON_DISCAPACIDAD="false" VerDISC_OTRA="false"
                                     VerLASTUPDATE="false" VerUSERID="false" PermitirFiltroEnEncabezado="false" PermitirSeleccionParaCombo="true"   
                                     PermitirEditar="false" PermitirEditarInline="false" PermitirEliminar="false"    
                                     NombreFuente= "Verdana" TamanoFuente ="X-Small" TamanoPagina="4"                                                                           
                                    />                                    
                                </td>
                            </tr>
                            <tr>
                                <td>
                                <dx:ASPxButton ID="btnConfirmacion" runat="server" 
                                        Text="Confirmo que no encontre coincidencias" 
                                        CssFilePath="~/App_Themes/BlackGlass/{0}/styles.css" CssPostfix="BlackGlass" 
                                        SpriteCssFilePath="~/App_Themes/BlackGlass/{0}/sprite.css" 
                                        style="font-family: Arial, Helvetica, sans-serif; font-size: xx-small" 
                                        Width="271px" Visible="false" AutoPostBack="false" >
                                            <ClientSideEvents Click="function(s,e){
                                                                        popupParticipantes.Hide();                                                                        
                                                                     }" />                                                  
                                        </dx:ASPxButton>
                                </td>
                            </tr>
                        </table>             
                     </dx:PopupControlContentControl>
                 </ContentCollection>

                <HeaderStyle Font-Bold="True"></HeaderStyle>
   </dx:ASPxPopupControl>
