<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetallePARTICIPANTE_EXONERADO_DOC.ascx.vb" Inherits="controles_ucVistaDetallePARTICIPANTE_EXONERADO_DOC" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<style type="text/css">
       .textUpper input{text-transform:uppercase;}     
    .style1
    {
        height: 20px;
    }
    .style2
    {
        height: 19px;
    }
    .style3
    {
        width: 50px;
    }
    .style4
    {
        width: 100px;
        height: 20px;
    }
</style>

<script type="text/jscript" >
    function ValidarTelefonos(s, e) {        
        if (txtTELEFONO.GetValue() == null && txtMOVIL.GetValue() == null) {            
            e.isValid = false;            
        }
        else {
            if (txtTELEFONO.GetValue() != null && txtTELEFONO.GetValue().toString().length != 8) {
                e.isValid = false;
            }
            else{
                if (txtMOVIL.GetValue() != null && txtMOVIL.GetValue().toString().length != 8) {
                    e.isValid = false;
                }
            }
        }
    }
    function ValidarNacionalidad(s, e) {
        if (rblNacionalidad.GetValue() == null) {
            e.errorText = 'Campo Nacionalidad es requerido';
            e.isValid = false;
        }
    }
    function ValidarDiscapacidad(s, e) {        
        if (rblDiscapacidad.GetValue() == null) {
            e.errorText = 'Campo Con Discapacidad es requerido';         
            e.isValid = false;
        }
    }
</script>  

<table id="VistaDetalle" cellspacing="0" cellpadding="0" border="0">   
    <tr>
        <td width="10"></td>
        <th colspan="5" style="text-align:left; height:10px; color:Red; vertical-align:middle; font-family:@Arial Unicode MS; font-size:xx-small; font-weight:bold" >
            (*) Campos requeridos
        </th> 
    </tr> 
    <tr>
		<td width="10"></td>
		<td align="right">
            <dx:ASPxLabel CssClass="Normal" id="lblID_PROVEEDOR_AF" 
                Font-Names="Arial,Tahoma" Font-Size="XX-Small" 
                runat="server" Text="Proveedor:"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxComboBox ID="cbxPROVEEDOR_AF" runat="server" ClientInstanceName="cbxPROVEEDOR_AF" Font-Names="Arial,Tahoma" Font-Size="XX-Small"
                DataSourceID="odsPROVEEDOR_AF" Height="18px" TextField="NOMBRE_PROVEEDOR" 
                ValueField="ID_PROVEEDOR_AF"
                ValueType="System.Int32" Width="348px">
                <ClientSideEvents SelectedIndexChanged="function(s,e){
                                                           cbxSITIO_CAPACITACION.PerformCallback(cbxPROVEEDOR_AF.GetValue().toString());                                                                                                                
                                                           }"  />
         </dx:ASPxComboBox></td>
         <td align="right" class="style3"><dx:ASPxLabel CssClass="Normal" 
                 id="lblID_SITIO_CAPACITACION" Font-Names="Arial,Tahoma" Font-Size="XX-Small" 
                runat="server" Text="Centro de Formación:" ></dx:ASPxLabel></td>
		<td>
			<dx:ASPxComboBox ID="cbxSITIO_CAPACITACION" runat="server" 
                ClientInstanceName="cbxSITIO_CAPACITACION" Font-Names="Arial,Tahoma" Font-Size="XX-Small"  
                DataSourceID="odsSITIO_CAPACITACION" Height="18px" TextField="NOMBRE_SITIO" 
                ValueField="ID_SITIO_CAPACITACION"
                ValueType="System.Int32" Width="200px">
         </dx:ASPxComboBox></td>
		<td width="10"></td>
	</tr>	
	<tr>
		<td width="10"></td>
		<td align="right">
            <dx:ASPxLabel CssClass="Normal" id="lblNOMBRES" runat="server" 
                Text="Nombres:*" Font-Names="Arial,Tahoma" Font-Size="XX-Small" ></dx:ASPxLabel></td>
		<td>
			<dx:ASPxTextBox id="txtNOMBRES" runat="server" CssClass="textUpper" ClientInstanceName="txtNOMBRES" Font-Names="Arial,Tahoma" Font-Size="XX-Small"  
                Width="348px" MaxLength="60">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Nombres es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxTextBox>
</td>
        <td align="right" class="style3"><dx:ASPxLabel CssClass="Normal" id="lblAPELLIDOS" 
                runat="server" Text="Apellidos:*" Font-Names="Arial,Tahoma" Font-Size="XX-Small" 
                ></dx:ASPxLabel></td>
		<td>
			<dx:ASPxTextBox CssClass="textUpper" id="txtAPELLIDOS" ClientInstanceName="txtAPELLIDOS" 
                runat="server" Width="200px" MaxLength="60" Font-Names="Arial,Tahoma" 
                Font-Size="XX-Small">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Apellidos es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxTextBox>
</td>
		<td width="10"></td>
	</tr>	
	<tr>
		<td width="10"></td>
		<td align="right"><dx:ASPxLabel CssClass="Normal" id="lblFECHA_NACIMIENTO" 
                Font-Names="Arial,Tahoma" Font-Size="XX-Small" 
                runat="server" Text="Fecha de Nacimiento:*" ></dx:ASPxLabel></td>
		<td>
			<dx:ASPxDateEdit id="deFECHA_NACIMIENTO" runat="server" EditFormatString="dd/MM/yyyy" EditFormat="Custom" UseMaskBehavior="true" ClientInstanceName="deFECHA_NACIMIENTO" Font-Names="Arial,Tahoma" Font-Size="XX-Small">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="La fecha de nacimiento es Requerida" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxDateEdit>
</td>
<td align="right" class="style3"><dx:ASPxLabel CssClass="Normal" id="lblGENERO" runat="server" 
                Text="Genero:*" Font-Names="Arial,Tahoma" Font-Size="XX-Small" 
        ></dx:ASPxLabel></td>
		<td>
			<dx:ASPxComboBox ID="cbxGENERO" runat="server" ValueType="System.String" Width="200px" ClientInstanceName="deFECHA_NACIMIENTO" Font-Names="Arial,Tahoma" Font-Size="XX-Small">
			    <ValidationSettings Display="Dynamic" SetFocusOnError="True">
			        <RequiredField ErrorText="El Campo Genero es Requerido" IsRequired="True" />
			    </ValidationSettings>
                <Items>
                    <dx:ListEditItem Text="MASCULINO" Value="M" />
                    <dx:ListEditItem Text="FEMENINO" Value="F" />
                </Items>
            </dx:ASPxComboBox>
</td>
		<td width="10"></td>
	</tr>
<tr>
		<td width="10"></td>
		<td align="right"><dx:ASPxLabel CssClass="Normal" id="lblID_PAIS" runat="server" 
                Text="Nacionalidad:*" Font-Names="Arial,Tahoma" Font-Size="XX-Small" 
                ></dx:ASPxLabel></td>
		<th colspan="3" style="text-align:left">
		    <table>
		        <tr>
		            <td style="text-align:left"><dx:ASPxRadioButtonList ID="rblNacionalidad" runat="server" 
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" ClientInstanceName="rblNacionalidad"                                                  
                                                RepeatDirection="Horizontal" ValueType="System.Int32" ItemSpacing="6px" ValidationSettings-Display="Dynamic" >                                                
<Paddings Padding="0px"></Paddings>
                                                <Items>
                                                <dx:ListEditItem Text="Salvadoreña" Value="1" />
                                                <dx:ListEditItem Text="Extranjera" Value="2" />                                               
                                                </Items>
<Border BorderStyle="None"></Border>
                                    <ClientSideEvents ValueChanged="function(s,e){                                                                      
                                                                        if (s.GetValue()==1){
                                                                            cbxPAIS.SetValue(57);
                                                                            cbxPAIS.SetEnabled(false);
                                                                            cbxDEPARTAMENTO_NACIMIENTO.SetEnabled(true);
                                                                            cbxMUNICIPIO_NACIMIENTO.SetEnabled(true);
                                                                        }
                                                                        else{
                                                                            cbxPAIS.SetText('');
                                                                            cbxPAIS.SetEnabled(true);
                                                                            cbxDEPARTAMENTO_NACIMIENTO.SetText('');
                                                                            cbxDEPARTAMENTO_NACIMIENTO.SetEnabled(false);
                                                                            cbxMUNICIPIO_NACIMIENTO.SetText('');
                                                                            cbxMUNICIPIO_NACIMIENTO.SetEnabled(false);
                                                                        }
                                                                    }" Validation="ValidarNacionalidad"   />
                                            </dx:ASPxRadioButtonList></td>
		            <td><dx:ASPxComboBox ID="cbxPAIS" runat="server" ValueType="System.Int32" ClientInstanceName="cbxPAIS"  
                Width="140px" Font-Names="Arial,Tahoma" Font-Size="XX-Small" DataSourceID="odsPais" TextField="NOMBRE_PAIS" ValueField="ID_PAIS"
                ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithText" ValidationSettings-RequiredField-ErrorText="País es requerido." >
            </dx:ASPxComboBox></td>
		        </tr>
		    </table>
		     
			
</th>
		<td width="10"></td>
	</tr>
	<tr>
		<td width="10" class="style1"></td>
		<td align="right" class="style1"><dx:ASPxLabel CssClass="Normal" id="lblDEPARTAMENTO_NAC" 
                runat="server" Text="Departamento Nacimiento:*" Font-Names="Arial,Tahoma" 
                Font-Size="XX-Small" ></dx:ASPxLabel></td>
		<td>
			<dx:ASPxComboBox ID="cbxDEPARTAMENTO_NACIMIENTO" DataSourceID="odsDepartamento" runat="server" Font-Names="Arial,Tahoma" Font-Size="XX-Small" 
                ValueType="System.String" TextField="NOMBRE" ClientInstanceName="cbxDEPARTAMENTO_NACIMIENTO" ValueField="CODIGO_DEPARTAMENTO" >
                <ClientSideEvents SelectedIndexChanged="function(s,e){
                                                           cbxMUNICIPIO_NACIMIENTO.PerformCallback(cbxDEPARTAMENTO_NACIMIENTO.GetValue().toString());                                                                                                                
                                                           }"  />
            </dx:ASPxComboBox>
</td>
<td align="right" class="style4"><dx:ASPxLabel CssClass="Normal" id="lblMUNICIPIO_NAC" 
                runat="server" Text="Municipio Nacimiento:*" 
        Font-Names="Arial,Tahoma" Font-Size="XX-Small" ></dx:ASPxLabel></td>
		<td class="style1">
			<dx:ASPxComboBox ID="cbxMUNICIPIO_NACIMIENTO" ClientInstanceName="cbxMUNICIPIO_NACIMIENTO" runat="server" DataSourceID="odsMunicipioNacimiento"  
                ValueType="System.String" TextField="NOMBRE" ValueField="CODIGO_MUNICIPIO" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Width="200px" >
            </dx:ASPxComboBox>
</td>
		<td width="10" class="style1"></td>
	</tr>

	<tr>
		<td width="10"></td>
		<td align="right">
            <dx:ASPxLabel CssClass="Normal" id="lblCODIGO_DEPARTAMENTO" 
                runat="server" Text="Departamento Residencia:*" Font-Names="Arial,Tahoma" 
                Font-Size="XX-Small"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxComboBox ID="cbxDEPARTAMENTO_RESIDENCIA" DataSourceID="odsDepartamento" runat="server" ClientInstanceName="cbxDEPARTAMENTO_RESIDENCIA"  
                ValueType="System.String" TextField="NOMBRE"  ValueField="CODIGO_DEPARTAMENTO" Font-Names="Arial,Tahoma" Font-Size="XX-Small"
                ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithText" ValidationSettings-RequiredField-ErrorText="Departamento de Residencia es requerido.">
                <ClientSideEvents SelectedIndexChanged="function(s,e){
                                                           cbxMUNICIPIO_RESIDENCIA.PerformCallback(cbxDEPARTAMENTO_RESIDENCIA.GetValue().toString());                                                                                                                
                                                           }"  />
            </dx:ASPxComboBox>
</td>
<td align="right" class="style3">
    <dx:ASPxLabel CssClass="Normal" id="lblCODIGO_MUNICIPIO" 
                runat="server" Text="Municipio Residencia:*" 
        Font-Names="Arial,Tahoma" Font-Size="XX-Small"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxComboBox ID="cbxMUNICIPIO_RESIDENCIA" ClientInstanceName="cbxMUNICIPIO_RESIDENCIA"  runat="server" DataSourceID="odsMunicipioResidencia" 
                ValueType="System.String" TextField="NOMBRE" ValueField="CODIGO_MUNICIPIO" Font-Names="Arial,Tahoma" Font-Size="XX-Small" Width="200px"
                ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithText" ValidationSettings-RequiredField-ErrorText="Municipio de Resisdencia es requerido.">
            </dx:ASPxComboBox>
</td>
		<td width="10"></td>
	</tr>
	<tr>
		<td width="10"></td>
		<td align="right"><dx:ASPxLabel CssClass="Normal" id="lblDIRECCION" runat="server" 
                Text="Dirección:*" Font-Names="Arial,Tahoma" Font-Size="XX-Small" 
                ></dx:ASPxLabel></td>
		<th colspan="3" style="text-align:left">
			<dx:ASPxTextBox id="txtDIRECCION" CssClass="textUpper" Font-Names="Arial,Tahoma" Font-Size="XX-Small"
                runat="server"  Width="348px" MaxLength="150" Height="18px">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="Campo Direccion es requerido" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxTextBox>
</th>
		<td width="10"></td>
	</tr>
	<tr>
		<td width="10" class="style2"></td>
		<td align="right" class="style2"><dx:ASPxLabel CssClass="Normal" id="lblTELEFONO" runat="server" 
                Text="Teléfono:*" Font-Names="Arial,Tahoma" Font-Size="XX-Small"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtTELEFONO" runat="server" ClientInstanceName="txtTELEFONO" 
                Width="120px" MaxLength="10" Font-Names="Arial,Tahoma" Font-Size="XX-Small">			   
                <ValidationSettings SetFocusOnError="True" ErrorText="Teléfono fijo no válido" />
			    <MaskSettings Mask="9999-9999" IncludeLiterals="None" PromptChar="_"/>
			    <ClientSideEvents Validation="ValidarTelefonos" />
			</dx:ASPxTextBox>
</td>
<td align="right" class="style3"><dx:ASPxLabel CssClass="Normal" id="lblMOVIL" runat="server" 
                Text="Móvil:*" Font-Names="Arial,Tahoma" Font-Size="XX-Small"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtMOVIL" runat="server" ClientInstanceName="txtMOVIL"  
                Width="200px" MaxLength="10" Font-Names="Arial,Tahoma" Font-Size="XX-Small">	
                <ValidationSettings SetFocusOnError="True" ErrorText="Teléfono móvil no válido" />                    			    
                <MaskSettings Mask="9999-9999" IncludeLiterals="None" PromptChar="_"/>
                <ClientSideEvents Validation="ValidarTelefonos" />
			</dx:ASPxTextBox>
</td>
		<td width="10" class="style2"></td>
	</tr>	
	<tr>
		<td width="10"></td>
		<td align="right"><dx:ASPxLabel CssClass="Normal" id="lblEMAIL" runat="server" 
                Text="Email:" Font-Names="Arial,Tahoma" Font-Size="XX-Small"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtEMAIL" runat="server" 
                Width="348px" MaxLength="100" Font-Names="Arial,Tahoma" Font-Size="XX-Small">
			    <ValidationSettings>
                <RegularExpression ErrorText="Email no válido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                </ValidationSettings>
			</dx:ASPxTextBox>
</td>
		<td></td>
		<td></td>
		<td width="10"></td>
	</tr>
	<tr>
		<td width="10"></td>
		<td align="right">
            <dx:ASPxLabel CssClass="Normal" id="lblID_ESTADO_CIVIL" 
                runat="server" Text="Estado civil: *" Font-Names="Arial,Tahoma" 
                Font-Size="XX-Small"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxComboBox ID="cbxESTADO_CIVIL" runat="server" ValueType="System.Int32" DataSourceID="odsEstadoCivil"
			 TextField="NOMBRE_ESTADO_CIVIL" ValueField="ID_ESTADO_CIVIL"   
                Width="170px" Font-Names="Arial,Tahoma" Font-Size="XX-Small"
             ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithText" ValidationSettings-RequiredField-ErrorText="Estado civil es requerido.">
            </dx:ASPxComboBox>
</td>
		<td align="right" class="style3">
            <dx:ASPxLabel CssClass="Normal" id="lblID_NIVEL_ACADEMICO" 
                runat="server" Text="Nivel Académico:*" Font-Names="Arial,Tahoma" 
                Font-Size="XX-Small"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxComboBox ID="cbxNIVEL_ACADEMICO" runat="server" DataSourceID="odsNivelAcademico" ClientInstanceName="cbxNIVEL_ACADEMICO"   
                ValueType="System.Int32" TextField="NOMBRE_NIVEL_ACADEMICO" ValueField="ID_NIVEL_ACADEMICO" Width="200px" Font-Names="Arial,Tahoma" Font-Size="XX-Small" 
                ValidationSettings-RequiredField-IsRequired="true" ValidationSettings-ErrorDisplayMode="ImageWithText" ValidationSettings-RequiredField-ErrorText="Nivel académico es requerido.">
            </dx:ASPxComboBox>
</td>
		<td width="10"></td>
	</tr>
	
	<tr>
	    <td width="10"></td>
		<td align="right">
            <dx:ASPxLabel CssClass="Normal" id="ASPxLabel2" runat="server" 
                Text="Con discapacidad:*" Font-Names="Arial,Tahoma" Font-Size="XX-Small"></dx:ASPxLabel></td>
		<th colspan="3" style="text-align:left">
		    <table>
		        <tr>
		            <td style="text-align:left"><dx:ASPxRadioButtonList ID="rblDiscapacidad" runat="server" 
                                                Font-Names="Arial,Tahoma" Font-Size="XX-Small" 
                            Border-BorderStyle="None" Paddings-Padding="0px"
                                                TextSpacing="3px" 
                            ClientInstanceName="rblDiscapacidad" 
                                                RepeatDirection="Horizontal" ValueType="System.Int32" 
                            ItemSpacing="6px"  >
<Paddings Padding="0px"></Paddings>
<Border BorderStyle="None"></Border>
<ClientSideEvents Validation="ValidarDiscapacidad" /> 
<ValidationSettings ErrorDisplayMode="ImageWithText" EnableCustomValidation="true" ErrorText="Campo Con Discapacidad es requerido" >
</ValidationSettings>
                                                <Items>
                                                <dx:ListEditItem Text="Sí" Value="1" />
                                                <dx:ListEditItem Text="No" Value="2" />                                               
                                                </Items>
                                            </dx:ASPxRadioButtonList></td>
		            <td></td>
		        </tr>
		    </table>
		     
			
</th>
		<td width="10"></td>
	</tr>
<tr runat="server" id="trES_APROBADO">
		<td width="10"></td>
		<td align="right"><dx:ASPxLabel CssClass="Normal" id="lblEvaluacion" runat="server" Text="Resultado Evaluación:" Font-Names="Arial,Tahoma" Font-Size="XX-Small"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxComboBox ID="cbxEvaluacion" runat="server" ValueType="System.Int32" 
                Width="170px" ClientInstanceName="cbxEvaluacion" Font-Names="Arial,Tahoma" 
                Font-Size="XX-Small">
                <Items>
                    <dx:ListEditItem Text="PENDIENTE DE EVALUAR" Value="0" />
                    <dx:ListEditItem Text="APROBADO" Value="1" />
                    <dx:ListEditItem Text="RECHAZADO" Value="2" />
                </Items>
            </dx:ASPxComboBox>
</td>
        <td class="style3">&nbsp;</td><td></td>
		<td width="10"></td>
	</tr>
    <tr runat="server" id="trID_PARTICIPANTE_EXONERADO">
		<td width="10"></td>
		<td align="right">
			<dx:ASPxLabel CssClass="Normal" id="lblIdParticipanteExonerado" runat="server" 
                Text="Id Participante Exo:"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" 
                id="txtID_PARTICIPANTE_EXONERADO" runat="server" 
                Width="40px" MaxLength="256" ReadOnly="True"></dx:ASPxTextBox>
        </td>
        <td class="style3"></td><td></td>
		<td width="10"></td>
	</tr>
	<tr runat="server" id="trID_PARTICIPANTE">
		<td width="10"></td>
		<td align="right">
			<dx:ASPxLabel CssClass="Normal" id="lblID_PARTICIPANTE" runat="server" 
                Text="Id Participante:"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtID_PARTICIPANTE" runat="server" 
                Width="40px" MaxLength="256" ReadOnly="True"></dx:ASPxTextBox>
        </td>
        <td class="style3"></td><td></td>
		<td width="10"></td>
	</tr>
	<tr runat="server" id="trUSERID">
		<td width="10"></td>
		<td align="right"><dx:ASPxLabel CssClass="Normal" id="lblUSERID" runat="server" Text="Userid:"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtUSERID" runat="server" Width="40px" MaxLength="256" ReadOnly="True"></dx:ASPxTextBox>
</td>
        <td class="style3"></td><td></td>
		<td width="10"></td>
	</tr>
	<tr runat="server" id="trLASTUPDATE">
		<td width="10"></td>
		<td align="right"><dx:ASPxLabel CssClass="Normal" id="lblLASTUPDATE" runat="server" Text="Lastupdate:"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxDateEdit id="deLASTUPDATE" runat="server" EditFormat="DateTime">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="La fecha es Requerida" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxDateEdit>
</td>
        <td class="style3"></td><td></td>
		<td width="10"></td>
	</tr>	
	
	
	<tr runat="server" id="trFECHA_INGRESO">
		<td width="10"></td>
		<td align="right"><dx:ASPxLabel CssClass="Normal" id="lblFECHA_INGRESO" 
                runat="server" Text="Fecha ingreso:"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxDateEdit id="deFECHA_INGRESO" runat="server" EditFormat="DateTime">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			        <RequiredField ErrorText="La fecha es Requerida" IsRequired="True" />
			    </ValidationSettings>
			</dx:ASPxDateEdit>
</td>
        <td class="style3"></td><td></td>
		<td width="10"></td>
	</tr>
	<tr runat="server" id="trUSUARIO_EVALUA">
		<td width="10"></td>
		<td align="right"><dx:ASPxLabel CssClass="Normal" id="lblUSUARIO_EVALUA" runat="server" Text="Usuario evalua:"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxTextBox CssClass="TextoNormalIzquierda" id="txtUSUARIO_EVALUA" runat="server" Width="100px" MaxLength="20">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxTextBox>
</td>
        <td class="style3"></td><td></td>
		<td width="10"></td>
	</tr>
	<tr runat="server" id="trFECHA_EVALUA">
		<td width="10"></td>
		<td align="right"><dx:ASPxLabel CssClass="Normal" id="lblFECHA_EVALUA" runat="server" Text="Fecha evalua:"></dx:ASPxLabel></td>
		<td>
			<dx:ASPxDateEdit id="deFECHA_EVALUA" runat="server" EditFormat="DateTime">
			    <ValidationSettings Display="Dynamic" ErrorText="Valor de Fecha invalido" SetFocusOnError="True">
			    </ValidationSettings>
			</dx:ASPxDateEdit>
</td>
        <td class="style3"></td><td>
        <br />
        </td>
		<td width="10"></td>
	</tr>	
</table>
<asp:ObjectDataSource ID="odsPARTICIPANTE" runat="server" 
    OldValuesParameterFormatString="{0}" SelectMethod="ObtenerLista" 
    TypeName="SGAFP.BL.cPARTICIPANTE">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter Name="asColumnaOrden" Type="String" />
        <asp:Parameter Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsPROVEEDOR_AF" runat="server" 
    OldValuesParameterFormatString="{0}" SelectMethod="ObtenerLista" 
    TypeName="SGAFP.BL.cPROVEEDOR_AF">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter Name="asColumnaOrden" DefaultValue="NOMBRE_PROVEEDOR"  Type="String" />
        <asp:Parameter Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsSITIO_CAPACITACION" runat="server" 
    OldValuesParameterFormatString="{0}" SelectMethod="ObtenerListaPorPROVEEDOR_AF" 
    TypeName="SGAFP.BL.cSITIO_CAPACITACION">
    <SelectParameters>
        <asp:Parameter Name="ID_PROVEEDOR_AF" Type="Decimal" />
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />
        <asp:Parameter DefaultValue="False" Name="recuperarForaneas" Type="Boolean" />
        <asp:Parameter Name="asColumnaOrden" DefaultValue="NOMBRE_SITIO" Type="String" />
        <asp:Parameter Name="asTipoOrden" Type="String" />
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

<asp:ObjectDataSource ID="odsMunicipioNacimiento" runat="server" 
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
<asp:ObjectDataSource ID="odsMunicipioResidencia" runat="server" 
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
<asp:ObjectDataSource ID="odsEstadoCivil" runat="server" 
    OldValuesParameterFormatString="{0}" SelectMethod="ObtenerLista" 
    TypeName="SGAFP.BL.cESTADO_CIVIL">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />        
        <asp:Parameter Name="asColumnaOrden" Type="String" />
        <asp:Parameter Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsNivelAcademico" runat="server" 
    OldValuesParameterFormatString="{0}" SelectMethod="ObtenerListaActualizada" 
    TypeName="SGAFP.BL.cNIVEL_ACADEMICO">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />       
        <asp:Parameter Name="asColumnaOrden" Type="String" />
        <asp:Parameter Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:ObjectDataSource ID="odsPais" runat="server" 
    OldValuesParameterFormatString="{0}" SelectMethod="ObtenerLista" 
    TypeName="SGAFP.BL.cPAIS">
    <SelectParameters>
        <asp:Parameter DefaultValue="False" Name="recuperarHijas" Type="Boolean" />        
        <asp:Parameter Name="asColumnaOrden" Type="String" />
        <asp:Parameter Name="asTipoOrden" Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>