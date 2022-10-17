<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.ascx.vb" Inherits="controles_ucVistaDetalleSOLICITUD_INSCRIPCION_AF2" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxTabControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxClasses" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxLoadingPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" Tagprefix="dx" %>
<%@ Register TagName="ucListaPARTICIPANTE" Src="~/controles/ucListaPARTICIPANTE.ascx" TagPrefix="uc1" %>

<style type="text/css">
       .req{color:Red; font-size:x-small; font-family:Arial; font-weight:bold}   
       .textUpper input{text-transform:uppercase;}     
</style>

<dx:ASPxCallbackPanel runat="server" ID="cbpucVistaDetalleSOLICITUD_INSCRIPCION_AF"    
         ClientInstanceName="cbpucVistaDetalleSOLICITUD_INSCRIPCION_AF" ShowLoadingPanel="false"  >   
<ClientSideEvents EndCallback="function(s, e){
                                    if(s.cpResultCallback != undefined){
                                        switch(s.cpResultCallback){
                                            case '':
                                                break;
                                            //case 'MostrarCursosRecibidosPorParticipante':
                                                //CargarCursosRecParticipanteEjercicio(s.cpIdParticipante, s.cpIdEjercicio);
                                                //break;
                                            default:
                                                AsignarMensaje(s.cpResultCallback);
                                                SetContenido(380, 0);
                                        }
                                    }
                               }"  />     
        <PanelCollection>        
            <dx:PanelContent runat="server">      
                 
<div id="contenedor_principal" style="width:800px; font-family:Verdana,Arial; font-size:xx-small;">
    <table width="100%" >        
        <tr align="center">
           <td>
               <dx:ASPxLabel ID="ASPxLabel1" runat="server" Font-Names="Verdana,Arial,Tahoma" Font-Bold="True" Font-Size="X-Small" Text="FORMULARIO DE INSCRIPCIÓN/MATRÍCULA" />
           </td> 
        </tr>
        <tr align="left">
            <td style="color:red">(*) Las respuestas a las preguntas color rojo son obligatorios.</td>
        </tr>
    </table>    
    <table width="100%">        
        <tr>
            <td style="width:80px; font-family:Verdana,Arial; font-size:xx-small;  ">
                <dx:ASPxLabel ID="lblSolicitud" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="ID. SOLICITUD:" />
            </td>
             <td style="width:100px">
                <dx:ASPxTextBox ID="ID_SOLICITUDtxt" ClientInstanceName="ID_SOLICITUDtxt" 
                    Font-Names="Arial,Tahoma" Font-Size="Small" ForeColor="Blue" Font-Bold="true" ReadOnly="true" runat="server" Width="100px" />
            </td>
            <td align="right">
                <dx:ASPxLabel ID="lblInscripcion" runat="server" ForeColor="Red" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="FECHA DE INSCRIPCIÓN: *" />
            </td>
            <td>
                <dx:ASPxDateEdit ID="FECHA_PRESENTACIONDateEdit" Width="120px"  runat="server" EditFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="true"  
                    ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Fecha de presentación es requerida.">
<ValidationSettings ErrorDisplayMode="ImageWithTooltip">
<RequiredField IsRequired="True" ErrorText="Fecha de presentaci&#243;n es requerida."></RequiredField>
</ValidationSettings>
                </dx:ASPxDateEdit>
            </td>
            <td align="right">
                <dx:ASPxLabel ID="lblParticipante" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="ID. PARTICIPANTE:" />
            </td>
            <td>
                <dx:ASPxTextBox ID="ID_PARTICIPANTEtxt" ClientInstanceName="ID_PARTICIPANTEtxt" 
                    Font-Names="Arial,Tahoma" Font-Size="Small"  ForeColor="Blue" Font-Bold="true" ReadOnly="true" runat="server" Width="100px" />
            </td>            
        </tr>
        <tr>
            <td>
                <dx:ASPxTextBox ID="ID_ACCION_FORMATIVAtxt" ClientInstanceName="ID_ACCION_FORMATIVAtxt" 
                    Font-Names="Arial,Tahoma" Font-Size="Small"  Font-Bold="true" ReadOnly="true" runat="server" Width="100px" />
            </td>
            <td>
                <dx:ASPxTextBox ID="ID_TIPO_SOLICITUDtxt" ClientInstanceName="ID_TIPO_SOLICITUDtxt"
                    Font-Names="Arial,Tahoma" Font-Size="Small" Font-Bold="true" ReadOnly="true" runat="server" Width="100px" />
            </td>
            <th colspan="4">
                <dx:ASPxTextBox ID="ID_ESTADO_SOLICITUDtxt" ClientInstanceName="ID_ESTADO_SOLICITUDtxt" 
                    Font-Names="Arial,Tahoma" Font-Size="Small"  Font-Bold="true" ReadOnly="true" runat="server" Width="100px" />
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
                                                <ClientSideEvents ValueChanged="function(s,e){
                                                                                if(DUItxt.GetValue() != null && ID_PARTICIPANTEtxt.GetText() == '')
                                                                                    BuscarParticipantes('DUI', DUItxt.GetValue());     
                                                                              }"   />
                                            </dx:ASPxTextBox>                                          
                                        </td>
                                        <td align="left" style="width:50px">
                                            <dx:ASPxButton ID="BuscarDUIbtn" AutoPostBack="false" 
                                                CausesValidation="False" runat="server" EnableDefaultAppearance="false" Cursor="hand"
                                                ImagePosition="Left" Width="20px" Height="20px" ToolTip="Buscar Participante por DUI" >
                                                <Image Url="../imagenes/buscar.gif" />
                                                <ClientSideEvents Click="function(s,e){   
                                                                            if(DUItxt.GetValue()==null){
                                                                                AsignarMensaje('Escriba el Número de DUI del Participante');           
                                                                              }
                                                                              else{
                                                                                BuscarParticipantes('DUI', DUItxt.GetValue());                                                                                                                                                             
                                                                              }      
                                                                    }" 
                                                />
                                            </dx:ASPxButton>
                                        </td>
                                        <td>NIT:</td>
                                        <td>
                                            <dx:ASPxTextBox ID="NITtxt" ClientInstanceName="NITtxt" runat="server" Width="120px" ValidationSettings-Display="Dynamic">
                                                <MaskSettings Mask="9999-999999-999-9" IncludeLiterals="None" />                                            
                                                <ValidationSettings Display="Dynamic"></ValidationSettings>
                                                <ClientSideEvents ValueChanged="function(s,e){
                                                                                if(NITtxt.GetValue() != null && ID_PARTICIPANTEtxt.GetText() == '')
                                                                                    BuscarParticipantes('NIT', NITtxt.GetValue());     
                                                                              }" />
                                            </dx:ASPxTextBox>
                                        </td>
                                        <td align="left" style="width:50px">
                                            <dx:ASPxButton ID="BuscarNITbtn" AutoPostBack="false" CausesValidation="False" Cursor="hand" 
                                                runat="server" EnableDefaultAppearance="false" ImagePosition="Left" Width="20px" 
                                                Height="20px" ToolTip="Buscar Participante por NIT" >
                                                <Image Url="../imagenes/buscar.gif" />
                                                <ClientSideEvents Click="function(s,e){     
                                                                            if(NITtxt.GetValue()==null){
                                                                                AsignarMensaje('Escriba el Número de NIT del Participante');           
                                                                              }
                                                                              else{
                                                                                BuscarParticipantes('NIT', NITtxt.GetValue());                                                                                      
                                                                              }      
                                                                    }" 
                                                />
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
                                            </dx:ASPxTextBox>
                                        </td>
                                        <td style="width:70px; text-align:right">Apellidos:</td>
                                        <td><dx:ASPxTextBox ID="APELLIDOStxt" CssClass="textUpper" ClientInstanceName="APELLIDOStxt" MaxLength="60" runat="server" Width="300px" 
                                                ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Apellidos son requeridos." >
<ValidationSettings ErrorDisplayMode="ImageWithTooltip">
<RequiredField IsRequired="True" ErrorText="Apellidos son requeridos."></RequiredField>
</ValidationSettings>
                                            </dx:ASPxTextBox>
                                        </td>     
                                        <td>
                                            <dx:ASPxButton ID="BuscarNombresbtn" ClientInstanceName="BuscarNombresbtn" 
                                                    AutoPostBack="false" CausesValidation="False" runat="server" 
                                                    EnableDefaultAppearance="false" ImagePosition="Left" Cursor="hand"
                                                    Width="20px" Height="20px" ToolTip="Buscar Participante por Nombres y Apellidos" >
                                                <Image Url="../imagenes/buscar.gif" />
                                                <ClientSideEvents Click="function(s,e){                                                                               
                                                                              if(NOMBREStxt.GetValue()==null && APELLIDOStxt.GetValue()==null){
                                                                                AsignarMensaje('Escriba el Nombre y/o Apellido del Participante');           
                                                                              }
                                                                              else{                                                                                
                                                                                BuscarParticipantes('NOMBRES_APELLIDOS', NOMBREStxt.GetText() + ' ' + APELLIDOStxt.GetText());
                                                                              }   
                                                                            }" 
                                                />
                                            </dx:ASPxButton>
                                             <dx:ASPxButton ID="BuscarNombres_InscritoProveedor" ClientInstanceName="BuscarNombres_InscritoProveedor" 
                                                    AutoPostBack="false" CausesValidation="False" runat="server" 
                                                    EnableDefaultAppearance="false" ImagePosition="Left" Cursor="hand"
                                                    Width="20px" Height="20px" ToolTip="Buscar Participante Referido de Ciudad Mujer" >
                                                <Image Url="../imagenes/ciudadmujer.png" />
                                                <ClientSideEvents Click="function(s,e){                                                                               
                                                                              if(NOMBREStxt.GetValue()==null && APELLIDOStxt.GetValue()==null){
                                                                                AsignarMensaje('Escriba el Nombre y/o Apellido del Participante');           
                                                                              }
                                                                              else{                                                                                
                                                                                BuscarParticipanteReferido('NOMBRES_APELLIDOS_InscritosPorProveedor', gID_PROVEEDOR_REFERIDO + ';' + NOMBREStxt.GetText() + ' ' + APELLIDOStxt.GetText());
                                                                              }   
                                                                            }" 
                                                />
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
                                            <dx:ASPxRadioButtonList ID="NACIONALIDADRadioButtonList" runat="server" 
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
                                    <ClientSideEvents ValueChanged="function(s,e){                                                                      
                                                                        if (s.GetValue()==1){
                                                                            ID_PAIScbx.SetValue(57);
                                                                            ID_PAIScbx.SetEnabled(false);
                                                                            DEPARTAMENTO_NACcbx.SetEnabled(true);
                                                                            MUNICIPIO_NACcbx.SetEnabled(true);
                                                                        }
                                                                        else{
                                                                            ID_PAIScbx.SetText('');
                                                                            ID_PAIScbx.SetEnabled(true);
                                                                            DEPARTAMENTO_NACcbx.SetText('');
                                                                            DEPARTAMENTO_NACcbx.SetEnabled(false);
                                                                            MUNICIPIO_NACcbx.SetText('');
                                                                            MUNICIPIO_NACcbx.SetEnabled(false);
                                                                        }
                                                                    }"  />
                                            </dx:ASPxRadioButtonList>
                                        </td>            
                                        <td align="right" style="width:50px">País:</td>
                                        <td><dx:ASPxComboBox ID="ID_PAIScbx" ClientInstanceName="ID_PAIScbx"  Width="120px" runat="server" IncrementalFilteringMode="StartsWith" DropDownStyle="DropDownList"    
                                            DataSourceID="odsPais" TextField="NOMBRE_PAIS" ValueField="ID_PAIS" ValueType="System.Int32" >
                                            <ClientSideEvents ValueChanged="function(s,e){if(s.GetValue==57){NACIONALIDADRadioButtonList.SetValue(1);ID_PAIScbx.SetEnabled(false);}}" /> 
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
                                            <dx:ASPxComboBox ID="DEPARTAMENTO_NACcbx" ClientInstanceName="DEPARTAMENTO_NACcbx"  Width="120px" runat="server" IncrementalFilteringMode="StartsWith" DropDownStyle="DropDownList"
                                                DataSourceID="odsDepartamento" TextField="NOMBRE" ValueField="CODIGO_DEPARTAMENTO">
                                                <ClientSideEvents SelectedIndexChanged="function(s,e){
                                                                                            MUNICIPIO_NACcbx.PerformCallback(DEPARTAMENTO_NACcbx.GetValue().toString());                                                                                                                
                                                                                        }"  />
                                            </dx:ASPxComboBox>
                                        </td>
                                        <td>Municipio:</td>
                                        <td><dx:ASPxComboBox ID="MUNICIPIO_NACcbx" ClientInstanceName="MUNICIPIO_NACcbx"  Width="120px" runat="server" IncrementalFilteringMode="StartsWith" DropDownStyle="DropDownList"
                                               DataSourceID="odsMUNICIPIO_NACcbx" TextField="NOMBRE" ValueField="CODIGO_MUNICIPIO" EnableSynchronization="False" >                                                                                                               
                                            </dx:ASPxComboBox>                                        
                                        </td>                            
                                        <td>Fecha:</td>
                                        <td><dx:ASPxDateEdit ID="FECHA_NACIMIENTODateEdit" ClientInstanceName="FECHA_NACIMIENTODateEdit" EditFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="true"  Width="120px" runat="server" >
                                            <ClientSideEvents DateChanged="function(s,e){                                                        
                                                        EDADtxt.SetText(CalcularEdad(s.GetValue()));
                                                    }"  />
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
                                    <ClientSideEvents Validation="validarMiembrosGrupoFamiliar" /> 
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
                                            <dx:ASPxRadioButtonList ID="TIENE_HIJOSRadioButtonList" runat="server" 
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
                                            <ClientSideEvents ValueChanged="function(s,e){if (s.GetValue()==1){NO_DE_HIJOStxt.SetEnabled(true);}else{NO_DE_HIJOStxt.SetEnabled(false);NO_DE_HIJOStxt.SetText('');}}" /> 
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
                            <td style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">11. Se dedica a alguna Profesión u Oficio *</span></td>   
                            <td>
                                <table>
                                    <tr>
                                        <td>                                        
                                            <dx:ASPxRadioButtonList ID="PROFESION_OFICIORadioButtonList" runat="server" 
                                                    Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                    TextSpacing="3px" ClientInstanceName="PROFESION_OFICIORadioButtonList"  
                                                    RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px"
                                                    ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Profesión u oficio es requerido." >
<Paddings Padding="0px"></Paddings>
                                                    <Items>
                                                    <dx:ListEditItem Text="Si" Value="1" />
                                                    <dx:ListEditItem Text="No" Value="2"  />                                                                                          
                                                    </Items>
                                                    <ClientSideEvents ValueChanged="function(s,e){if (s.GetValue()==1){PROFESION_OFICIOtxt.SetEnabled(true);}else{PROFESION_OFICIOtxt.SetEnabled(false);PROFESION_OFICIOtxt.SetText('');}}" /> 

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
                            <td style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0">11.1 ¿A qué profesión u oficio se dedica?:</td>   
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
                                        <td><dx:ASPxComboBox ID="CODIGO_DEPARTAMENTOcbx" ClientInstanceName="CODIGO_DEPARTAMENTOcbx"  Width="120px" runat="server" IncrementalFilteringMode="StartsWith" DropDownStyle="DropDownList"
                                                    DataSourceID="odsDepartamento" TextField="NOMBRE" ValueField="CODIGO_DEPARTAMENTO" 
                                                    ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Departamento de residencia es requerido." >                                                    
                                                     <ClientSideEvents SelectedIndexChanged="function(s,e){
                                                                                            CODIGO_MUNICIPIOcbx.PerformCallback(CODIGO_DEPARTAMENTOcbx.GetValue().toString());                                                                                                                
                                                                                        }"  />

<ValidationSettings ErrorDisplayMode="ImageWithTooltip">
<RequiredField IsRequired="True" ErrorText="Departamento de residencia es requerido."></RequiredField>
</ValidationSettings>
                                            </dx:ASPxComboBox>
                                        </td>
                                        <td>Municipio:</td>
                                        <td><dx:ASPxComboBox ID="CODIGO_MUNICIPIOcbx" ClientInstanceName="CODIGO_MUNICIPIOcbx" Width="120px" runat="server" IncrementalFilteringMode="StartsWith" DropDownStyle="DropDownList"
                                             DataSourceID="odsCODIGO_MUNICIPIOcbx" TextField="NOMBRE" ValueField="CODIGO_MUNICIPIO" EnableSynchronization="False"
                                             ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Municipio de residencia es requerido." >                                                   
<ValidationSettings ErrorDisplayMode="ImageWithTooltip">
<RequiredField IsRequired="True" ErrorText="Municipio de residencia es requerido."></RequiredField>
</ValidationSettings>
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
                            <td style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">13. ¿Tiene usted alguna discapacidad permanente? *</span></td>   
                            <td>
                                <table>
                                    <tr>                                       
                                        <td>
                                            <dx:ASPxRadioButtonList ID="CON_DISCAPACIDADRadioButtonList" runat="server" 
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
                                               <ClientSideEvents ValueChanged="function(s,e){
                                                            if (s.GetValue()==1){
                                                                DISC_MOVERSE_CAMINARchk.SetEnabled(true);
                                                                DISC_HABLARchk.SetEnabled(true);
                                                                DISC_BRAZOS_MANOSchk.SetEnabled(true);
                                                                DISC_RETRASOchk.SetEnabled(true);
                                                                DISC_VERchk.SetEnabled(true);
                                                                DISC_BAN_VESTIR_ALIMchk.SetEnabled(true);
                                                                DISC_OIRchk.SetEnabled(true);  
                                                                DISC_OTRAchk.SetEnabled(true);                                                             
                                                            }
                                                            else{
                                                                DISC_MOVERSE_CAMINARchk.SetValue(false);
                                                                DISC_HABLARchk.SetValue(false);
                                                                DISC_BRAZOS_MANOSchk.SetValue(false);
                                                                DISC_RETRASOchk.SetValue(false);
                                                                DISC_VERchk.SetValue(false);
                                                                DISC_BAN_VESTIR_ALIMchk.SetValue(false);                                                                
                                                                DISC_OIRchk.SetValue(false);  
                                                                DISC_OTRAchk.SetValue(false);           
                                                                DISC_OTRAtxt.SetText('');                                                                 
                                                                DISC_MOVERSE_CAMINARchk.SetEnabled(false);
                                                                DISC_HABLARchk.SetEnabled(false);
                                                                DISC_BRAZOS_MANOSchk.SetEnabled(false);
                                                                DISC_RETRASOchk.SetEnabled(false);
                                                                DISC_VERchk.SetEnabled(false);
                                                                DISC_BAN_VESTIR_ALIMchk.SetEnabled(false);                                                                
                                                                DISC_OIRchk.SetEnabled(false);  
                                                                DISC_OTRAchk.SetEnabled(false);           
                                                                DISC_OTRAtxt.SetEnabled(false); 
                                                            }
                                                        }"  
                                               />
                                            </dx:ASPxRadioButtonList>
                                        </td>        
                                    </tr>
                                </table>
                            </td>
                        </tr> 
                     
                        <tr>
                            <th colspan="2" style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0">13.1 ¿Cuál discapacidad tiene?:</th>
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
                                                <td><dx:ASPxCheckBox ID="DISC_OTRAchk" ClientInstanceName="DISC_OTRAchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Otra:" >
                                                        <ClientSideEvents ValueChanged="function(s,e){HabilitarCampoOtro(DISC_OTRAtxt, s.GetValue())}"/>  
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
                            <th style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">1. ¿Sabe usted leer y escribir? *</span></th>
                        </tr>  
                        <tr>
                            <th align="left">
                                <table>
                                    <tr>                                        
                                        <td>
                                            <dx:ASPxRadioButtonList ID="SABE_LEER_ESCRIBIRRadioButtonList" runat="server" 
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="SABE_LEER_ESCRIBIRRadioButtonList"  
                                                RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px"
                                                ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Sabe leer y escribir es requerido.">
                                                <Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="Si" Value="1" />
                                                <dx:ListEditItem Text="No" Value="2"  />                                                                                          
                                                </Items>

<ValidationSettings ErrorDisplayMode="ImageWithTooltip">
<RequiredField IsRequired="True" ErrorText="Sabe leer y escribir es requerido."></RequiredField>
</ValidationSettings>

                                            <Border BorderStyle="None"></Border>
                                            <ClientSideEvents ValueChanged="function(s,e){
                                                    if(s.GetValue()==1){
                                                        ASPxClientEdit.ClearGroup('grupoSOLO_LEE_ESCRIBE');
                                                        SOLO_LEE_ESCRIBERadioButtonList.SetEnabled(false);
                                                        EDUCACION_FORMAL_SOLO_FIRMAchk.SetValue(false);
                                                        EDUCACION_FORMAL_SOLO_FIRMAchk.SetEnabled(false);
                                                    }
                                                    else{
                                                        SOLO_LEE_ESCRIBERadioButtonList.SetEnabled(true);                                                        
                                                        EDUCACION_FORMAL_SOLO_FIRMAchk.SetEnabled(true);
                                                    }
                                                }" 
                                            />
                                            </dx:ASPxRadioButtonList>
                                        </td>          
                                    </tr>
                                </table>                                
                            </th>
                        </tr>                                                   
                        <tr>   
                            <th align="left">
                                <table style="font-family:Arial,Tahoma,Verdana; font-size:xx-small">
                                    <tr>
                                        <td>
                                            <dx:ASPxRadioButtonList ID="SOLO_LEE_ESCRIBERadioButtonList" runat="server" 
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="SOLO_LEE_ESCRIBERadioButtonList"  
                                                RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px" ValidationSettings-ValidationGroup="grupoSOLO_LEE_ESCRIBE" >
                                                <Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="¿Sólo lee?:" Value="1" />
                                                <dx:ListEditItem Text="¿Sólo escribe?:" Value="2"  />                                                                                          
                                                </Items>

<ValidationSettings ValidationGroup="grupoSOLO_LEE_ESCRIBE"></ValidationSettings>

                                            <Border BorderStyle="None"></Border>
                                            </dx:ASPxRadioButtonList>
                                        </td>                                                                                        
                                        <td style="width:150px; text-align:right">¿Sólo firma? (firma ó huella):
                                        </td>                            
                                        <td><dx:ASPxCheckBox ID="EDUCACION_FORMAL_SOLO_FIRMAchk" ClientInstanceName="EDUCACION_FORMAL_SOLO_FIRMAchk" runat="server" Font-Names="Arial,Tahoma" Text=" " Font-Size="XX-Small"/></td>
                                    </tr>
                                </table>
                            </th>  
                        </tr> 
                        <tr>
                            <th 
                                
                                
                                style="font-family:Verdana; font-weight:bold; font-size:xx-small; padding-left:5px; text-align:left; background-color:#E0E0E0;"><span class="req">2. ¿Cuál es el último grado de estudio finalizado? *</span></th>                       
                        </tr>
                        <tr>
                            <th align="left">
                                <table style="font-family:Verdana,Arial,Tahoma; font-size:xx-small">
                                    <tr>
                                        <td>
                                            <dx:ASPxRadioButton ID="EDUCACION_BASICArdb" Font-Names="Verdana,Arial,Tahoma" Font-Size="XX-Small" runat="server" Text="EDUCACIÓN BÁSICA:"  GroupName="grupoEDUCACION_FORMAL" >
                                                <ClientSideEvents ValueChanged="function(s,e){if(s.GetValue){HabilitarEducacionFormal('EDUCACION_FORMAL');}}" />
                                            </dx:ASPxRadioButton>
                                        </td>
                                        <td>
                                            <dx:ASPxRadioButtonList ID="EDUCACION_BASICARadioButtonList" runat="server" 
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="EDUCACION_BASICARadioButtonList"  ValidationSettings-ValidationGroup="grupoEDUCACION_BASICA"  
                                                RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px">
                                                <Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="Ninguno" Value="8" />
                                                <dx:ListEditItem Text="1° Gdo." Value="9"  />                                                                                          
                                                <dx:ListEditItem Text="2° Gdo." Value="10"  />  
                                                <dx:ListEditItem Text="3° Gdo." Value="11"  />  
                                                <dx:ListEditItem Text="4° Gdo." Value="12"  />  
                                                <dx:ListEditItem Text="5° Gdo." Value="13"  />  
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
                                            <dx:ASPxRadioButton ID="BACHILLERATOrdb" Font-Names="Verdana,Arial,Tahoma" Font-Size="XX-Small" runat="server" Text="BACHILLERATO:" GroupName="grupoEDUCACION_FORMAL" >                                                
                                                <ClientSideEvents ValueChanged="function(s,e){if(s.GetValue){HabilitarEducacionFormal('BACHILLERATO');}}" />
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
                                            <dx:ASPxRadioButton ID="TECNOLOGICArdb" Font-Names="Verdana,Arial,Tahoma" Font-Size="XX-Small" runat="server" Text="TECNOLOGICA:"  GroupName="grupoEDUCACION_FORMAL" >
                                                <ClientSideEvents ValueChanged="function(s,e){if(s.GetValue){HabilitarEducacionFormal('TECNOLOGICA');}}" />
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
                                            <dx:ASPxRadioButton ID="UNIVERSITARIArdb" Font-Names="Verdana,Arial,Tahoma" Font-Size="XX-Small" runat="server" Text="UNIVERSITARIA:" GroupName="grupoEDUCACION_FORMAL" >
                                                <ClientSideEvents ValueChanged="function(s,e){if(s.GetValue){HabilitarEducacionFormal('UNIVERSITARIA');}}" />
                                            </dx:ASPxRadioButton>                                          
                                        </td>  
                                        <td>
                                            <dx:ASPxRadioButtonList ID="UNIVERSITARIARadioButtonList" runat="server" 
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
                                            <dx:ASPxCheckBox ID="OTRA_EDUCACION_FORMALchk" ClientInstanceName="OTRA_EDUCACION_FORMALchk" runat="server" Font-Bold="true" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Otra educación formal:">
                                                <ClientSideEvents ValueChanged="function(s,e){HabilitarCampoOtro(OTRA_EDUCACION_FORMALtxt, s.GetValue())}"/>  
                                            </dx:ASPxCheckBox>
                                        </td>
                                        <td><dx:ASPxTextBox ID="OTRA_EDUCACION_FORMALtxt" CssClass="textUpper" ClientInstanceName="OTRA_EDUCACION_FORMALtxt" MaxLength="60" runat="server" Width="170px"/></td>  
                                        <td>
                                            <dx:ASPxCheckBox ID="TITULO_CERTIFICADO_OBTENIDOchk" runat="server" Font-Bold="true" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Título o certificado obtenido:">
                                                <ClientSideEvents ValueChanged="function(s,e){
                                                        if(s.GetValue()){
                                                            TITULO_CERTIFICADO_OBTENIDOtxt.SetEnabled(true);                                                          
                                                        }
                                                        else{
                                                            TITULO_CERTIFICADO_OBTENIDOtxt.SetText('');         
                                                            TITULO_CERTIFICADO_OBTENIDOtxt.SetEnabled(false);         
                                                        }
                                                    }" 
                                                />
                                            </dx:ASPxCheckBox>
                                        </td>
                                        <td><dx:ASPxTextBox ID="TITULO_CERTIFICADO_OBTENIDOtxt" CssClass="textUpper" ClientInstanceName="TITULO_CERTIFICADO_OBTENIDOtxt" MaxLength="60" runat="server" Width="200px"/></td>
                                    </tr>
                                </table>
                            </th>                            
                        </tr>                        
                        <tr>
                            <th 
                                
                                style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">3. ¿Estudia usted actualmente? *</span></th>                             
                        </tr>                        
                        <tr>
                            <th align="left" >
                                <table>
                                    <tr>
                                        <td>
                                        <dx:ASPxRadioButtonList ID="ESTUDIA_ACTUALMENTERadioButtonlist" runat="server" 
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="ESTUDIA_ACTUALMENTERadioButtonlist" ValidationSettings-ValidationGroup="grupoESTUDIA_ACTUALMENTE"  
                                                ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Estudia actualmente es requerido." 
                                                RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px">
                                                <Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="Si" Value="1" />
                                                <dx:ListEditItem Text="No" Value="2" />
                                                </Items>
                                             <ClientSideEvents ValueChanged="function(s, e){
                                                                if(s.GetValue()==1){                                                                    
                                                                    TIEMPO_DEJO_ESTUDIARRadioButtonList.SetEnabled(false);
                                                                    OCUACT_ESTUDIAchk.SetValue(true); 
                                                                    ASPxClientEdit.ClearGroup('grupoTIEMPO_DEJO_ESTUDIAR');
                                                                    TIEMPO_DEJO_ESTUDIARRadioButtonList.SetEnabled(false);
                                                                                                                                       
                                                                }
                                                                else{
                                                                    ASPxClientEdit.ClearGroup('grupoTIEMPO_DEJO_ESTUDIAR');
                                                                    TIEMPO_DEJO_ESTUDIARRadioButtonList.SetEnabled(true);
                                                                    OCUACT_ESTUDIAchk.SetValue(false);                                                                    
                                                                }
                                                            }"/>                                             

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
                           <th 
                                
                                style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0">3.1 ¿Hace cuánto tiempo dejó de estudiar?</th>                              
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
                                                <dx:ListEditItem Text="Menos de 1 año" Value="1" />
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
                            <th 
                                
                                style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">4. ¿Ha recibido antes algún(os) curso(s) de capacitación? *</span></th>                              
                        </tr>
                        
                        <tr>    
                            <th align="left" >
                                <table>
                                    <tr>           
                                    <td>                        
                                    <dx:ASPxRadioButtonList ID="RECIBIO_CURSO_ANTERIORRadioButtonList" runat="server" 
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="RECIBIO_CURSO_ANTERIORRadioButtonList"  
                                                ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Ha recibido cursos de capacitación es requerido."
                                                RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px">
                                                <Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="Si" Value="1" />
                                                <dx:ListEditItem Text="No" Value="2" />                                               
                                                </Items>
                                                <ClientSideEvents ValueChanged="function(s,e){
                                                        if(s.GetValue()==1){
                                                            CURSO1txt.SetEnabled(true);
                                                            CURSO2txt.SetEnabled(true);
                                                            CURSO3txt.SetEnabled(true);
                                                            IMPARTIO_INSAFORP1ButtonList.SetEnabled(true);
                                                            IMPARTIO_INSAFORP2ButtonList.SetEnabled(true);
                                                            IMPARTIO_INSAFORP3ButtonList.SetEnabled(true);
                                                            ANIO1txt.SetEnabled(true);
                                                            ANIO2txt.SetEnabled(true);
                                                            ANIO3txt.SetEnabled(true);
                                                            CURSO_DIO_BENEFICIOS1ButtonList.SetEnabled(true);
                                                            CURSO_DIO_BENEFICIOS2ButtonList.SetEnabled(true);
                                                            CURSO_DIO_BENEFICIOS3ButtonList.SetEnabled(true);                                                          
                                                                                                     
                                                        }
                                                        else{
                                                            CURSO1txt.SetText('');
                                                            CURSO2txt.SetText('');
                                                            CURSO3txt.SetText('');
                                                            CURSO1txt.SetEnabled(false);
                                                            CURSO2txt.SetEnabled(false);
                                                            CURSO3txt.SetEnabled(false);
                                                            ASPxClientEdit.ClearGroup('grupoIMPARTIO_INSAFORP1');
                                                            ASPxClientEdit.ClearGroup('grupoIMPARTIO_INSAFORP2');
                                                            ASPxClientEdit.ClearGroup('grupoIMPARTIO_INSAFORP3');
                                                            IMPARTIO_INSAFORP1ButtonList.SetEnabled(false);
                                                            IMPARTIO_INSAFORP2ButtonList.SetEnabled(false);
                                                            IMPARTIO_INSAFORP3ButtonList.SetEnabled(false);
                                                            ANIO1txt.SetText('');
                                                            ANIO2txt.SetText('');
                                                            ANIO3txt.SetText('');
                                                            ANIO1txt.SetEnabled(false);
                                                            ANIO2txt.SetEnabled(false);
                                                            ANIO3txt.SetEnabled(false);
                                                            ASPxClientEdit.ClearGroup('grupoCURSO_DIO_BENEFICIOS1');
                                                            ASPxClientEdit.ClearGroup('grupoCURSO_DIO_BENEFICIOS2');
                                                            ASPxClientEdit.ClearGroup('grupoCURSO_DIO_BENEFICIOS3');
                                                            CURSO_DIO_BENEFICIOS1ButtonList.SetEnabled(false);
                                                            CURSO_DIO_BENEFICIOS2ButtonList.SetEnabled(false);
                                                            CURSO_DIO_BENEFICIOS3ButtonList.SetEnabled(false);
                                                            
                                                            BENEF_OBT_EMPLEOchk.SetValue(false);
                                                            BENEF_CAMB_EMP_X_CURSOchk.SetValue(false);
                                                            BENEF_TRAB_CTA_PROPIAchk.SetValue(false);
                                                            BENEF_ING_EXTRAchk.SetValue(false);
                                                            BENEF_PROM_EMP_ACTchk.SetValue(false);
                                                            BENEF_OTROchk.SetValue(false);
                                                            BENEF_OTROtxt.SetText('');         
                                                            BENEF_OTROtxt.SetEnabled(false); 
                                                            RAZON_NO_BENEFICIOtxt.SetText('');
                                                            
                                                            BENEF_OBT_EMPLEOchk.SetEnabled(false);
                                                            BENEF_CAMB_EMP_X_CURSOchk.SetEnabled(false);
                                                            BENEF_TRAB_CTA_PROPIAchk.SetEnabled(false);
                                                            BENEF_ING_EXTRAchk.SetEnabled(false);
                                                            BENEF_PROM_EMP_ACTchk.SetEnabled(false);
                                                            BENEF_OTROchk.SetEnabled(false);
                                                            RAZON_NO_BENEFICIOtxt.SetEnabled(false);
                                                        }                                                        
                                                    }" 
                                                /> 

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
                                        <td style="background-color:#E0E0E0; width:340px; text-align:left">5. Si, ¿Cuál(es)? Mencione solamente las recibidas en los últimos 3 años</td>
                                        <td style="background-color:#E0E0E0">¿Lo impartió INSAFORP?</td>
                                        <td style="background-color:#E0E0E0; width:50px">Año</td>
                                        <td style="background-color:#E0E0E0">¿El curso le dió beneficios?</td>
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
                                        <td><dx:ASPxTextBox ID="ANIO1txt" CssClass="textUpper" ClientInstanceName="ANIO1txt" MaxLength="4" runat="server" Width="50px">
                                                <MaskSettings Mask="9999" PromptChar="_" IncludeLiterals="None" />   
                                            </dx:ASPxTextBox>
                                        </td>
                                        <td>
                                            <dx:ASPxRadioButtonList ID="CURSO_DIO_BENEFICIOS1ButtonList" runat="server" 
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="CURSO_DIO_BENEFICIOS1ButtonList" ValidationSettings-ValidationGroup="grupoCURSO_DIO_BENEFICIOS1"    
                                                RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px">
                                                <Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="Si" Value="1" />
                                                <dx:ListEditItem Text="No" Value="2" />                                               
                                                <dx:ListEditItem Text="NR" Value="3" />
                                                </Items>
                                                <ClientSideEvents ValueChanged="function(s,e){HabilitarCursoDioBeneficios_RazonNoBeneficio()}" /> 

<ValidationSettings ValidationGroup="grupoCURSO_DIO_BENEFICIOS1"></ValidationSettings>

                                                <Border BorderStyle="None"></Border>
                                            </dx:ASPxRadioButtonList>
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
                                        <td><dx:ASPxTextBox ID="ANIO2txt" CssClass="textUpper" ClientInstanceName="ANIO2txt" MaxLength="4" runat="server" Width="50px">
                                                <MaskSettings Mask="9999" PromptChar="_" IncludeLiterals="None" />   
                                            </dx:ASPxTextBox>
                                        </td>
                                        <td>
                                            <dx:ASPxRadioButtonList ID="CURSO_DIO_BENEFICIOS2ButtonList" runat="server" 
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="CURSO_DIO_BENEFICIOS2ButtonList" ValidationSettings-ValidationGroup="grupoCURSO_DIO_BENEFICIOS2"     
                                                RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px">
                                                <Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="Si" Value="1" />
                                                <dx:ListEditItem Text="No" Value="2" />                                               
                                                <dx:ListEditItem Text="NR" Value="3" />
                                                </Items>
                                                <ClientSideEvents ValueChanged="function(s,e){HabilitarCursoDioBeneficios_RazonNoBeneficio()}" /> 

<ValidationSettings ValidationGroup="grupoCURSO_DIO_BENEFICIOS2"></ValidationSettings>

                                                <Border BorderStyle="None"></Border>
                                            </dx:ASPxRadioButtonList>
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
                                        <td><dx:ASPxTextBox ID="ANIO3txt" CssClass="textUpper" ClientInstanceName="ANIO3txt" MaxLength="4" runat="server" Width="50px" >
                                                <MaskSettings Mask="9999" PromptChar="_" IncludeLiterals="None" />   
                                            </dx:ASPxTextBox>    
                                        </td>
                                        <td>
                                            <dx:ASPxRadioButtonList ID="CURSO_DIO_BENEFICIOS3ButtonList" runat="server" 
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="CURSO_DIO_BENEFICIOS3ButtonList" ValidationSettings-ValidationGroup="grupoCURSO_DIO_BENEFICIOS3"   
                                                RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px">
                                                <Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="Si" Value="1" />
                                                <dx:ListEditItem Text="No" Value="2" />                                               
                                                <dx:ListEditItem Text="NR" Value="3" />
                                                </Items>                                                        
                                                <ClientSideEvents ValueChanged="function(s,e){HabilitarCursoDioBeneficios_RazonNoBeneficio()}" /> 

<ValidationSettings ValidationGroup="grupoCURSO_DIO_BENEFICIOS3"></ValidationSettings>

                                                <Border BorderStyle="None"></Border>
                                            </dx:ASPxRadioButtonList>
                                        </td>
                                    </tr>
                                </table>
                            </th>  
                        </tr>
                        <tr>
                            <th align="left" 
                                style="font-family:Verdana; font-weight:bold; font-size:xx-small; padding-left:5px; text-align:left; background-color:#E0E0E0">6. ¿Para que sirvió(eron) la(s) capacitaciones que recibió?</th>  
                        </tr>
                        <tr>
                            <th align="left">
                                <table>
                                    <tr>
                                        <td><dx:ASPxCheckBox ID="BENEF_OBT_EMPLEOchk" ClientInstanceName="BENEF_OBT_EMPLEOchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Para obtener un empleo"/></td>
                                        <td><dx:ASPxCheckBox ID="BENEF_CAMB_EMP_X_CURSOchk" ClientInstanceName="BENEF_CAMB_EMP_X_CURSOchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Cambiar a un empleo relacionado con la capacitación recibida"/></td>                                        
                                    </tr>
                                    <tr>
                                        <td><dx:ASPxCheckBox ID="BENEF_TRAB_CTA_PROPIAchk" ClientInstanceName="BENEF_TRAB_CTA_PROPIAchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Para trabajar por cuenta propia"/></td>
                                        <td><dx:ASPxCheckBox ID="BENEF_ING_EXTRAchk" ClientInstanceName="BENEF_ING_EXTRAchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Obtener otros ingresos por trabajos extras"/></td>                                        
                                    </tr>
                                    <tr>
                                        <td><dx:ASPxCheckBox ID="BENEF_PROM_EMP_ACTchk" ClientInstanceName="BENEF_PROM_EMP_ACTchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Obtener oportunidades de promoción en mi empleo actual"/></td>                                        
                                        <td>
                                            <table cellpadding="0" cellspacing="0">
                                                <tr>
                                                    <td>
                                                        <dx:ASPxCheckBox ID="BENEF_OTROchk" ClientInstanceName="BENEF_OTROchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Otro:">
                                                            <ClientSideEvents ValueChanged="function(s,e){HabilitarCampoOtro(BENEF_OTROtxt, s.GetValue())}"/> 
                                                        </dx:ASPxCheckBox>
                                                    </td>
                                                    <td><dx:ASPxTextBox ID="BENEF_OTROtxt" CssClass="textUpper" ClientInstanceName="BENEF_OTROtxt" MaxLength="100" runat="server" Width="170px" />
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>                                        
                                    </tr>
                                </table> 
                            </th> 
                        </tr>
                        <tr> 
                            <th align="left" 
                                style="font-family:Verdana; font-weight:bold; font-size:xx-small; padding-left:5px; text-align:left; background-color:#E0E0E0">7. ¿Por que cree que no recibió beneficios como producto de la/las capacitación/es?</th>                              
                        </tr>
                        <tr>
                            <th align="left"><dx:ASPxTextBox ID="RAZON_NO_BENEFICIOtxt" CssClass="textUpper" ClientInstanceName="RAZON_NO_BENEFICIOtxt" MaxLength="100" runat="server" Width="100%"/></th>  
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
                            <th colspan="2" style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0">SECCIÓN 3.1. INFORMACIÓN SOBRE LA OCUPACIÓN ACTUAL</th> 
                        </tr> 
                        <tr>
                            <th colspan="2" style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">1. ¿A qué actividad se dedica usted actualmente? *</span></th> 
                        </tr> 
                        <tr>
                            <th colspan="2" align="left"> 
                                <table>
                                    <tr>
                                        <td>
                                            <dx:ASPxCheckBox ID="OCUACT_ESTUDIAchk" ClientInstanceName="OCUACT_ESTUDIAchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Estudia" >
                                                <ClientSideEvents ValueChanged="function(s,e){
                                                                                    if(s.GetValue()){
                                                                                        ESTUDIA_ACTUALMENTERadioButtonlist.SetValue(1);
                                                                                        ASPxClientEdit.ClearGroup('grupoTIEMPO_DEJO_ESTUDIAR');
                                                                                        TIEMPO_DEJO_ESTUDIARRadioButtonList.SetEnabled(false);
                                                                                    }
                                                                                    else{
                                                                                        ESTUDIA_ACTUALMENTERadioButtonlist.SetValue(2);
                                                                                        TIEMPO_DEJO_ESTUDIARRadioButtonList.SetEnabled(true);
                                                                                    }                                                                                    
                                                                                }"  />
                                            </dx:ASPxCheckBox>
                                        </td>
                                        <td><dx:ASPxCheckBox ID="OCUACT_OFICIO_HOGARchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Oficios del hogar"/></td>        
                                        <td><dx:ASPxCheckBox ID="OCUACT_TRABAJAchk" ClientInstanceName="OCUACT_TRABAJAchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Trabaja">
                                                <ClientSideEvents ValueChanged="function(s,e){
                                                                    var habilitar;                                                                                                                                         
                                                                    HabilitarTipoEmpleo(s.GetValue());
                                                                }" 
                                                            />                                            
                                            </dx:ASPxCheckBox>
                                        </td>
                                        <td><dx:ASPxCheckBox ID="OCUACT_BUSCA_TRABAJOchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Busca trabajo" /></td>     
                                        <td><dx:ASPxCheckBox ID="OCUACT_OTRAchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Otra:">
                                            <ClientSideEvents ValueChanged="function(s,e){HabilitarCampoOtro(OCUACT_OTRAtxt, s.GetValue())}"/> 
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
                            <th colspan="2" style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0">2. Si usted trabaja, ¿Qué tipo de trabajo tiene?</th> 
                        </tr> 
                        <tr>
                            <th colspan="2" align="left">
                                <table>
                                    <tr>
                                        <td>   
                                            <dx:ASPxRadioButtonList ID="TIPO_EMPLEORadioButtonList" runat="server" 
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px" RepeatColumns="3" 
                                                TextSpacing="1px" ClientInstanceName="TIPO_EMPLEORadioButtonList" ValidationSettings-ValidationGroup="grupoTIPO_EMPLEO"   
                                                RepeatDirection="Vertical" ValueType="System.Int32" ItemSpacing="6px">
                                                <Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="Empleo a tiempo completo" Value="1" />
                                                <dx:ListEditItem Text="Empleo a tiempo parcial" Value="2" />                                               
                                                <dx:ListEditItem Text="Empleo temporal" Value="3" />
                                                <dx:ListEditItem Text="Negocio familiar" Value="4" />
                                                <dx:ListEditItem Text="Independiente o cuenta propia" Value="5" />
                                                <dx:ListEditItem Text="Trabajo informal" Value="6" />
                                                <dx:ListEditItem Text="Otro:" Value="7" />
                                                </Items>
                                                <ValidationSettings ValidationGroup="grupoTIPO_EMPLEO"></ValidationSettings>
                                                <Border BorderStyle="None"></Border>
                                            <ClientSideEvents ValueChanged ="function(s,e){
                                                                                if(s.GetValue()==7){
                                                                                    HabilitarCampoOtro(TIEMP_OTROtxt,true);           
                                                                                    ASPxClientEdit.ClearGroup('grupoSECTOR_EMPLEO');
                                                                                    SECTOR_EMPLEORadioButtonList.SetEnabled(false);                                                             
                                                                                }
                                                                                else{
                                                                                    HabilitarCampoOtro(TIEMP_OTROtxt,false);
                                                                                    if(s.GetValue()==1 || s.GetValue()==2 || s.GetValue()==3){
                                                                                        SECTOR_EMPLEORadioButtonList.SetEnabled(true);  
                                                                                    }
                                                                                    else{
                                                                                        ASPxClientEdit.ClearGroup('grupoSECTOR_EMPLEO');
                                                                                        SECTOR_EMPLEORadioButtonList.SetEnabled(false);
                                                                                    }
                                                                                    
                                                                                }
                                                                             }
                                                                    
                                                                    " />
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
                            <th colspan="2" style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0">3. ¿En qué Sector trabaja?</th> 
                        </tr>
                        <tr>
                            <th colspan="2" align="left" >
                                <table> 
                                    <tr>
                                        <td>
                                            <dx:ASPxRadioButtonList ID="SECTOR_EMPLEORadioButtonList" runat="server" 
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="SECTOR_EMPLEORadioButtonList" ValidationSettings-ValidationGroup="grupoSECTOR_EMPLEO"   
                                                RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px"
                                                ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="En qué Sector trabaja es requerido." >
                                                <Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="Sector Privado" Value="1" />
                                                <dx:ListEditItem Text="Sector Público" Value="2" />                                               
                                                </Items>                                                                                                                          

<ValidationSettings ErrorDisplayMode="ImageWithTooltip" ValidationGroup="grupoSECTOR_EMPLEO">
<RequiredField IsRequired="True" ErrorText="En qu&#233; Sector trabaja es requerido."></RequiredField>
</ValidationSettings>

                                            <Border BorderStyle="None"></Border>                                            
                                            </dx:ASPxRadioButtonList>
                                        </td>                                                    
                                    </tr>
                                </table>
                            </th> 
                        </tr>                       
                        <tr>
                             <th colspan="2"  style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0">SECCIÓN 3.3. EMPLEO FORMAL ANTERIOR. (Completar sólo en caso de NO estar trabajando)</th>                             
                        </tr>
                        <tr>
                            <td style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0; width:50%"><span class="req">1. ¿Ha trabajado antes? *</span></td>    
                            <td>
                                <table style="font-family:Arial,Tahoma,Verdana; font-size:xx-small" cellpadding="0" cellspacing="0"  >
                                    <tr>                                       
                                        <td>
                                            <dx:ASPxRadioButtonList ID="TRABAJO_ANTERIORRadioButtonList" runat="server" 
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="TRABAJO_ANTERIORRadioButtonList"  
                                                RepeatDirection="Horizontal" ValueType="System.String" ItemSpacing="6px" ValidationSettings-ValidationGroup="grupoTRABAJO_ANTERIOR" 
                                                ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Ha trabajado antes es requerido.">
                                                <Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="Si" Value="S" />
                                                <dx:ListEditItem Text="No" Value="N" />                                                                                              
                                                </Items>
                                            <ClientSideEvents ValueChanged="function(s,e){
                                                        if(s.GetValue()=='S'){
                                                            TIEMPO_NO_TRABAJARadioButtonList.SetEnabled(true);                                                                                         
                                                        }
                                                        else{
                                                            ASPxClientEdit.ClearGroup('grupoTIEMPO_NO_TRABAJA');                                                           
                                                            TIEMPO_NO_TRABAJARadioButtonList.SetEnabled(false);                                                         
                                                        }
                                                    }" 
                                            />

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
                            <td style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0; width:50%">2. ¿Cuánto tiempo hace que no trabaja?</td>    
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
                    </table>
                </dx:ContentControl>
            </ContentCollection>
         </dx:TabPage>
         <dx:TabPage Text="SECCION 4." ToolTip="INFORMACIÓN SOBRE LOS INGRESOS" >
            <ContentCollection>       
                <dx:ContentControl ID="ContentControl4" runat="server">
                    <table width="100%" style=" font-family:Arial,Tahoma,Verdana; font-size:xx-small" >   
                        <tr>
                            <th colspan="2" style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:center; background-color:#E0E0E0">SECCIÓN 4. INFORMACIÓN SOBRE LOS INGRESOS</th></tr><tr>                           
                            <td style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0; width:300px"><span class="req">1. ¿Usted recibe ingresos? *</span></td><td>
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
                                            <ClientSideEvents ValueChanged="function(s,e){
                                                            if(s.GetValue()==1){
                                                                MANERA_OBT_ING_TRABAJOchk.SetEnabled(true);
                                                                MANERA_OBT_ING_PENSIONchk.SetEnabled(true);
                                                                MANERA_OBT_ING_REMESAchk.SetEnabled(true);
                                                                MANERA_OBT_ING_AYUDA_FAMchk.SetEnabled(true);
                                                                MANERA_OBT_ING_OTRAchk.SetEnabled(true);                                                                                                                      
                                                            }
                                                            else{
                                                                MANERA_OBT_ING_TRABAJOchk.SetValue(false);
                                                                MANERA_OBT_ING_PENSIONchk.SetValue(false);
                                                                MANERA_OBT_ING_REMESAchk.SetValue(false);
                                                                MANERA_OBT_ING_AYUDA_FAMchk.SetValue(false);
                                                                MANERA_OBT_ING_OTRAchk.SetValue(false);                                                               
                                                                MANERA_OBT_ING_OTRAtxt.SetText('');                                                                
                                                                
                                                                MANERA_OBT_ING_TRABAJOchk.SetEnabled(false);
                                                                MANERA_OBT_ING_PENSIONchk.SetEnabled(false);
                                                                MANERA_OBT_ING_REMESAchk.SetEnabled(false);
                                                                MANERA_OBT_ING_AYUDA_FAMchk.SetEnabled(false);
                                                                MANERA_OBT_ING_OTRAchk.SetEnabled(false);
                                                                MANERA_OBT_ING_OTRAtxt.SetEnabled(false);                                                                
                                                            }                                                            
                                                        }"/>

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
                            <td style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0">2. ¿De qué manera lo obtiene?</td><td>
                                <table style="font-family:Arial,Tahoma,Verdana; font-size:xx-small; width:100%" cellpadding="0" cellspacing="0" >
                                    <tr>
                                        <td>
                                            <table>
                                                <tr>
                                                    <td><dx:ASPxCheckBox ID="MANERA_OBT_ING_TRABAJOchk" ClientInstanceName="MANERA_OBT_ING_TRABAJOchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Trabajo" /></td>
                                                    <td><dx:ASPxCheckBox ID="MANERA_OBT_ING_PENSIONchk" ClientInstanceName="MANERA_OBT_ING_PENSIONchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Pensión" /></td>
                                                    <td></td>
                                                </tr>
                                                <tr>
                                                    <td><dx:ASPxCheckBox ID="MANERA_OBT_ING_REMESAchk" ClientInstanceName="MANERA_OBT_ING_REMESAchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Remesa" /></td>
                                                    <td>
                                                        <dx:ASPxCheckBox ID="MANERA_OBT_ING_OTRAchk" ClientInstanceName="MANERA_OBT_ING_OTRAchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Otro:">
                                                            <ClientSideEvents ValueChanged="function(s,e){HabilitarCampoOtro(MANERA_OBT_ING_OTRAtxt, s.GetValue())}"/> 
                                                        </dx:ASPxCheckBox>
                                                    </td>
                                                    <td style="padding-left:5px">
                                                        <dx:ASPxTextBox ID="MANERA_OBT_ING_OTRAtxt" CssClass="textUpper" ClientInstanceName="MANERA_OBT_ING_OTRAtxt" runat="server" Size="60"  Width="170px"/>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td><dx:ASPxCheckBox ID="MANERA_OBT_ING_AYUDA_FAMchk" ClientInstanceName="MANERA_OBT_ING_AYUDA_FAMchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Ayuda familiar" /></td>
                                                    <td></td>
                                                    <td></td>
                                                </tr>
                                            </table>                                           
                                        </td>                                             
                                    </tr>
                                </table>
                            </td>
                        </tr>                         
                    </table>
                </dx:ContentControl>
            </ContentCollection>
         </dx:TabPage>
         <dx:TabPage Text="SECCION 5." ToolTip="EXPECTATIVA Y PERTINENCIA DE LA FORMACIÓN" >
            <ContentCollection>       
                <dx:ContentControl ID="ContentControl5" runat="server">
                    <table width="100%" style=" font-family:Arial,Tahoma,Verdana; font-size:xx-small" >   
                        <tr>
                            <th style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:center; background-color:#E0E0E0">SECCIÓN 5. EXPECTATIVA Y PERTINENCIA DE LA FORMACIÓN</th></tr><tr>
                            <th style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0">SECCIÓN 5.1 EXPECTATIVAS RESPECTO A LA FORMACIÓN</th></tr><tr>
                            <th style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">1. ¿Qué espera lograr con la capacitación a recibir? *</span></th></tr><tr>
                            <th align="left">
                                <table>
                                    <tr>
                                        <td><dx:ASPxCheckBox ID="EXPFOR_PROMOCION_EMPLEOchk" ClientInstanceName="EXPFOR_PROMOCION_EMPLEOchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Obtener oportunidades de promoción en mi empleo actual"/></td>
                                        <td><dx:ASPxCheckBox ID="EXPFOR_INGRESOS_EXTRAchk" ClientInstanceName="EXPFOR_INGRESOS_EXTRAchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Obtener ingresos extras"/></td>                                        
                                    </tr>
                                    <tr>
                                        <td><dx:ASPxCheckBox ID="EXPFOR_RELACION_EMPLEOchk" ClientInstanceName="EXPFOR_RELACION_EMPLEOchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Cambiar a un empleo relacionado con la capacitación recibida"/></td>
                                        <td align="left">
                                            <table cellpadding="0" cellspacing="0" >
                                                <tr>
                                                    <td><dx:ASPxCheckBox ID="EXPFOR_OTROchk" ClientInstanceName="EXPFOR_OTROchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Otro:">
                                                            <ClientSideEvents ValueChanged="function(s,e){HabilitarCampoOtro(EXPFOR_OTROtxt, s.GetValue())}"/> 
                                                        </dx:ASPxCheckBox>
                                                    </td>
                                                    <td><dx:ASPxTextBox ID="EXPFOR_OTROtxt" CssClass="textUpper" ClientInstanceName="EXPFOR_OTROtxt" runat="server" Width="170px"/></td>
                                                </tr>
                                            </table>                                            
                                        </td>                                        
                                    </tr>
                                    <tr>
                                        <td><dx:ASPxCheckBox ID="EXPFOR_OBTENER_EMPLEOchk" ClientInstanceName="EXPFOR_OBTENER_EMPLEOchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Obtener un empleo formal"/></td>
                                        <td>
                                            <dx:ASPxCheckBox ID="EXPFOR_NINGUNOchk" ClientInstanceName="EXPFOR_NINGUNOchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Ninguno">
                                                <ClientSideEvents ValueChanged="function(s,e){
                                                                                    if(s.GetValue()){
                                                                                        EXPFOR_PROMOCION_EMPLEOchk.SetValue(false);
                                                                                        EXPFOR_INGRESOS_EXTRAchk.SetValue(false);
                                                                                        EXPFOR_RELACION_EMPLEOchk.SetValue(false);
                                                                                        EXPFOR_OTROchk.SetValue(false);
                                                                                        EXPFOR_OTROtxt.SetValue('');
                                                                                        EXPFOR_OBTENER_EMPLEOchk.SetValue(false);
                                                                                        EXPFOR_TRABAJAR_CTA_PROPIAchk.SetValue(false);
                                                                                        
                                                                                        EXPFOR_PROMOCION_EMPLEOchk.SetEnabled(false);
                                                                                        EXPFOR_INGRESOS_EXTRAchk.SetEnabled(false);
                                                                                        EXPFOR_RELACION_EMPLEOchk.SetEnabled(false);
                                                                                        EXPFOR_OTROchk.SetEnabled(false);
                                                                                        EXPFOR_OTROtxt.SetEnabled(false);
                                                                                        EXPFOR_OBTENER_EMPLEOchk.SetEnabled(false);
                                                                                        EXPFOR_TRABAJAR_CTA_PROPIAchk.SetEnabled(false);                                                                                        
                                                                                    }
                                                                                    else{
                                                                                        EXPFOR_PROMOCION_EMPLEOchk.SetEnabled(true);
                                                                                        EXPFOR_INGRESOS_EXTRAchk.SetEnabled(true);
                                                                                        EXPFOR_RELACION_EMPLEOchk.SetEnabled(true);
                                                                                        EXPFOR_OTROchk.SetEnabled(true);                                                                                        
                                                                                        EXPFOR_OBTENER_EMPLEOchk.SetEnabled(true);
                                                                                        EXPFOR_TRABAJAR_CTA_PROPIAchk.SetEnabled(true); 
                                                                                    }
                                                                                    
                                                                                }"  />
                                            </dx:ASPxCheckBox>
                                        </td>                                        
                                    </tr>
                                    <tr>
                                        <th colspan="2" align="left"><dx:ASPxCheckBox ID="EXPFOR_TRABAJAR_CTA_PROPIAchk" ClientInstanceName="EXPFOR_TRABAJAR_CTA_PROPIAchk" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Text="Trabajar por cuenta propia"/></th>                                        
                                    </tr>
                                </table>
                            </th> 
                        </tr>     
                        <tr>
                            <th style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0">SECCIÓN 5.2 PERTINENCIA DE LA FORMACIÓN PROFESIONAL</th></tr><tr>
                            <th style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:left; background-color:#E0E0E0"><span class="req">1. Pertinencia del curso que está solicitando con su ocupación actual *</span></th></tr><tr>
                            <th align="left">
                                <dx:ASPxRadioButtonList ID="CURSO_REL_TRABRadioButtonList" runat="server" 
                                    Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                    TextSpacing="3px" ClientInstanceName="CURSO_REL_TRABRadioButtonList"  
                                    RepeatDirection="Horizontal" ValueType="System.Int32"  ItemSpacing="6px"
                                    ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Ha trabajado antes es requerido.">
                                    <Paddings Padding="0px"></Paddings>
                                    <Items>
                                    <dx:ListEditItem Text="El curso esta relacionado con su trabajo actual" Value="1" />
                                    <dx:ListEditItem Text="El curso esta relacionado con un nuevo trabajo" Value="2" />                                                                                              
                                    </Items>                                

<ValidationSettings ErrorDisplayMode="ImageWithTooltip">
<RequiredField IsRequired="True" ErrorText="Ha trabajado antes es requerido."></RequiredField>
</ValidationSettings>

                                <Border BorderStyle="None"></Border>
                                </dx:ASPxRadioButtonList>
                            </th>
                        </tr>          
                    </table>
                </dx:ContentControl>
            </ContentCollection>
         </dx:TabPage>
         <dx:TabPage Text="SECCION 6." ToolTip="SEGUIMIENTO" >
            <ContentCollection>       
                <dx:ContentControl ID="ContentControl6" runat="server">
                    <table width="100%" style="font-family:Arial,Tahoma,Verdana; font-size:xx-small" >
                        <tr>
                            <th colspan="2" style="font-family:Verdana; font-weight:bold; font-size:xx-small; text-align:center; background-color:#E0E0E0"><span class="req">SECCIÓN 6. SEGUIMIENTO *</span></th>
                        </tr>
                        <tr>
                            <td style="width:80px">Nombre:</td>
                            <td align="left">
                                <table style="font-family:Arial,Tahoma,Verdana; font-size:XX-Small;" cellpadding="0" cellspacing="0">
                                    <tr>
                                        <td><dx:ASPxTextBox ID="NOMBRE_FAMILIARtxt" CssClass="textUpper" ClientInstanceName="NOMBRE_FAMILIARtxt" MaxLength="80" runat="server" Width="350px"
                                               ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Nombre de Familiar es requerido.">
<ValidationSettings ErrorDisplayMode="ImageWithTooltip">
<RequiredField IsRequired="True" ErrorText="Nombre de Familiar es requerido."></RequiredField>
</ValidationSettings>
                                            </dx:ASPxTextBox>
                                        </td>  
                                        <td style="width:100px; text-align:right">Parentesco:</td>
                                        <td><dx:ASPxComboBox ID="ID_PARENTESCOcbx" ClientInstanceName="ID_PARENTESCOcbx"  Width="120px" runat="server" IncrementalFilteringMode="StartsWith" DropDownStyle="DropDownList"
                                            DataSourceID="odsReferencia" TextField="NOMBRE_REFERENCIA" ValueField="ID_REFERENCIA" ValueType="System.Int32"   
                                            ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Parentesco es requerido.">
<ValidationSettings ErrorDisplayMode="ImageWithTooltip">
<RequiredField IsRequired="True" ErrorText="Parentesco es requerido."></RequiredField>
</ValidationSettings>
                                            </dx:ASPxComboBox>
                                        </td>                                        
                                    </tr>
                                </table>
                            </td>
                        </tr>                      
                        <tr>
                            <td>Dirección:</td>                          
                            <td>
                                <table cellspacing="0" cellpadding="0" style="font-family:Arial,Tahoma,Verdana; font-size:xx-small">
                                    <tr>                                       
                                        <td><dx:ASPxTextBox ID="DIRECCION_FAMILIARtxt" CssClass="textUpper" MaxLength="100" runat="server" Width="667px" 
                                            ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Dirección de familiar es requerido.">
<ValidationSettings ErrorDisplayMode="ImageWithTooltip">
<RequiredField IsRequired="True" ErrorText="Direcci&#243;n de familiar es requerido."></RequiredField>
</ValidationSettings>
                                            </dx:ASPxTextBox>
                                        </td>                                    
                                        <td>
                                            <dx:ASPxButton ID="CopiarDomiciliobtn" ClientInstanceName="CopiarDomiciliobtn" 
                                                        AutoPostBack="false" CausesValidation="False" runat="server" 
                                                        EnableDefaultAppearance="false" ImagePosition="Left" Cursor="hand"
                                                        Width="20px" Height="20px" ToolTip="Copiar domicilio del Participante" >
                                                    <Image Url="../imagenes/copiar.png" />
                                                    <ClientSideEvents Click="function(s,e){  
                                                                                CopiarDomicilioParticipante();                                                                             
                                                                            }" 
                                                    />
                                            </dx:ASPxButton>
                                        </td>
                                    </tr>
                                </table>    
                            </td>                        
                        </tr>
                        <tr>
                            <td>Departamento:</td>
                            <td>
                                <table style="font-family:Arial,Tahoma,Verdana; font-size:xx-small;" cellspacing="0">
                                    <tr>                                       
                                        <td><dx:ASPxComboBox ID="CODIGO_DEPARTAMENTO_FAMcbx" ClientInstanceName="CODIGO_DEPARTAMENTO_FAMcbx" Width="120px" runat="server" IncrementalFilteringMode="StartsWith" DropDownStyle="DropDownList"
                                            DataSourceID="odsDepartamento" TextField="NOMBRE" ValueField="CODIGO_DEPARTAMENTO" 
                                            ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Departamento donde vive familiar es requerido.">
                                                 <ClientSideEvents SelectedIndexChanged="function(s,e){
                                                                                            CODIGO_MUNICIPIO_FAMcbx.PerformCallback(CODIGO_DEPARTAMENTO_FAMcbx.GetValue().toString());                                                                                                                
                                                                                        }"  />

<ValidationSettings ErrorDisplayMode="ImageWithTooltip">
<RequiredField IsRequired="True" ErrorText="Departamento donde vive familiar es requerido."></RequiredField>
</ValidationSettings>
                                            </dx:ASPxComboBox>
                                        </td>
                                        <td style="width:80px" align="right">Municipio:</td>
                                        <td><dx:ASPxComboBox ID="CODIGO_MUNICIPIO_FAMcbx" ClientInstanceName="CODIGO_MUNICIPIO_FAMcbx"  Width="150px" runat="server"
                                         DataSourceID="odsCODIGO_MUNICIPIO_FAMcbx" TextField="NOMBRE" ValueField="CODIGO_MUNICIPIO" EnableSynchronization="False" IncrementalFilteringMode="StartsWith" DropDownStyle="DropDownList"
                                         ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithTooltip" ValidationSettings-RequiredField-ErrorText="Municipio donde vive familiar es requerido.">
<ValidationSettings ErrorDisplayMode="ImageWithTooltip">
<RequiredField IsRequired="True" ErrorText="Municipio donde vive familiar es requerido."></RequiredField>
</ValidationSettings>
                                            </dx:ASPxComboBox>
                                        </td>
                                    </tr>
                                </table>
                            </td>                          
                        </tr>
                        <tr>
                            <td>Tel. Fijo:</td>
                            <td align="left">
                                <table style="font-family:Arial,Tahoma,Verdana; font-size:XX-Small;" cellspacing="0">
                                    <tr>                                        
                                        <td><dx:ASPxTextBox ID="TELEFONO_FAMILIARtxt" CssClass="textUpper" MaxLength="8" runat="server" Width="120px" /></td>
                                        <td style="width:80px" align="right">Tel. Movil:</td>
                                        <td><dx:ASPxTextBox ID="MOVIL_FAMILIARtxt" CssClass="textUpper" MaxLength="8" runat="server" Width="150px"/></td>
                                        <td style="width:80px" align="right">Email:</td>
                                        <td>
                                            <dx:ASPxTextBox ID="EMAIL_FAMILIARtxt" CssClass="textUpper" MaxLength="100" runat="server" Width="100px">
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
                            <th colspan="2" style="font-family:Verdana; font-weight:bold; font-size:XX-Small; text-align:left; background-color:#E0E0E0">Observaciones o sugerencias</th></tr><tr>
                            <th colspan="2">
                                <dx:ASPxMemo ID="SUGERENCIASMemo" runat="server" Height="71px" Width="100%">
                                </dx:ASPxMemo></th> 
                        </tr>
                        </table>
                </dx:ContentControl>
            </ContentCollection>
         </dx:TabPage>
        </TabPages>
    </dx:ASPxPageControl>        
</div>


        </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>



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

                      

     
  

  
