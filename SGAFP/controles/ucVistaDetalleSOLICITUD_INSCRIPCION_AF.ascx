<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVistaDetalleSOLICITUD_INSCRIPCION_AF.ascx.vb" Inherits="controles_ucVistaDetalleSOLICITUD_INSCRIPCION_AF" %>
<%@ Register TagPrefix="cc1" Namespace="SGAFP.WebUC" Assembly="SGAFP_WebUC" %>
<%@ Register TagPrefix="ajaxToolkit" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<%@ Register src="ucVistaDetalleSOLIC_EMPLEO_ACTUAL.ascx" tagname="ucVistaDetalleSOLIC_EMPLEO_ACTUAL" tagprefix="uc1" %>
<%@ Register src="ucVistaDetalleSOLIC_EMPLEO_ANTERIOR.ascx" tagname="ucVistaDetalleSOLIC_EMPLEO_ANTERIOR" tagprefix="uc2" %>
<%@ Register src="ucListaSOLIC_CURSOS_RECIBIDOS.ascx" tagname="ucListaSOLIC_CURSOS_RECIBIDOS" tagprefix="uc3" %>
<style type="text/css">
                        .style1
                        {
                            height: 42px;
                        }
                    </style>

<script type="text/javascript">
        
        function pageLoad() {
            $addHandler($get("hidePopupParticipantes"), 'click', hidePopupParticipantesViaClient);        
        }

        function hidePopupParticipantesViaClient(ev) {
            ev.preventDefault();
            var modalPopupBehavior = $find('pmpBehaviorParticipantes');
            modalPopupBehavior.hide();
        }
</script>
<table class="insa" id="tableTitulo" runat="server" visible="false">
               <tr>
                    <td class="style2" colspan="6">
                        <p class="style13">
                            <span lang="ES" style="font-size:14.0pt;text-shadow:auto;
mso-ansi-language:ES;mso-bidi-font-weight:normal; text-align: center;">FORMULARIO DE INSCRIPCION /MATRICULA</span></p>
                    </td>
                </tr>
</table>
<asp:UpdatePanel ID="UpdatePanelSeccion1" runat="server" 
    ChildrenAsTriggers="False" UpdateMode="Conditional">
    <ContentTemplate>
        <asp:Panel ID="PanelSeccion1" runat="server">
            <asp:Panel ID="PanelEncabezadoSeccion1" runat="server" CssClass="EncabezadoSecciones"
                Height="20px" Width="95%">
                <div style="padding: 5px; cursor: pointer; vertical-align: middle;">
                    <div style="float: left;">
                        SECCION 1. DATOS DE IDENTIFICACION.</div>
                    <div style="float: left; margin-left: 20px;">
                        <asp:Label ID="LabelDetalleSeccion1" runat="server">(Ver Detalle...)</asp:Label>
                    </div>
                    <div style="float: right; vertical-align: middle;">
                        <asp:ImageButton ID="ImageButtonSeccion1" runat="server" ImageUrl="~/imagenes/expand_blue.jpg"
                            AlternateText="(Ver Detalle...)" CausesValidation="False" />
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel ID="PanelDetalleSeccion1" runat="server" Height="0" Width="95%">
                <table class="insa" width="100%">
                    <tr>
                        <td class="style1">
                            ID_SOLICITUD:
                        </td>
                        <td colspan="2" class="style1">
                            <asp:TextBox ID="txtID_SOLICITUD" SkinID="TextBox" runat="server" ReadOnly="True"
                                Width="70px"></asp:TextBox>
                        </td>
                        <td class="style1">
                            FECHA PRESENTACION:
                        </td>
                        <td class="style1">
                            <asp:TextBox ID="txtFECHA_PRESENTACION" runat="server" SkinID="TextBox" Width="80px"
                                CssClass="TextoNormalCentrado"></asp:TextBox>
                            <asp:ImageButton ID="ibtnCalendarFECHA_PRESENTACION" runat="Server" AlternateText="Click para mostrar el Calendario"
                                ImageUrl="~/imagenes/Calendar_scheduleHS.png" CausesValidation="False" />
                            <ajaxToolkit:MaskedEditValidator ID="mevFECHA_PRESENTACION" runat="server" ControlExtender="meedFECHA_PRESENTACION"
                                ControlToValidate="txtFECHA_PRESENTACION" InvalidValueMessage="Fecha no V&#225;lida"
                                ErrorMessage="*" Display="Dynamic"></ajaxToolkit:MaskedEditValidator>
                            <ajaxToolkit:MaskedEditExtender ID="meedFECHA_PRESENTACION" runat="server" BehaviorID="meedFECHA_PRESENTACION"
                                TargetControlID="txtFECHA_PRESENTACION" MaskType="Date" Mask="99/99/9999">
                            </ajaxToolkit:MaskedEditExtender>
                            <ajaxToolkit:CalendarExtender ID="cbeFECHA_PRESENTACION" runat="server" PopupButtonID="ibtnCalendarFECHA_PRESENTACION"
                                TargetControlID="txtFECHA_PRESENTACION" Format="dd/MM/yyyy" Animated="true" CssClass="calendario">
                            </ajaxToolkit:CalendarExtender>
                        </td>
                    </tr>
                    <tr>
                        <td class="style10">
                            ID PARTICIPANTE:
                        </td>
                        <td colspan="2">
                            <asp:TextBox ID="txtID_PARTICIPANTE" runat="server" Columns="8" AutoPostBack="True" ReadOnly="True"
                                SkinID="TextBox" />
                            <ajaxToolkit:MaskedEditExtender ID="txtID_PARTICIPANTE_MaskedEditExtender" runat="server"
                                AutoComplete="False" Mask="99999999" MaskType="Number" TargetControlID="txtID_PARTICIPANTE">
                            </ajaxToolkit:MaskedEditExtender>
                        </td>
                        <td class="style11">
                            &nbsp;
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style10">
                            DUI*:
                        </td>
                        <td colspan="2">
                            <asp:TextBox ID="DUITextBox" runat="server" Columns="9" SkinID="TextBox" MaxLength="9" />
                            <ajaxToolkit:MaskedEditExtender ID="DUITextBox_MaskedEditExtender" runat="server"
                                Mask="99999999-9" TargetControlID="DUITextBox" AutoCompleteValue="0">
                            </ajaxToolkit:MaskedEditExtender>
                            <ajaxToolkit:MaskedEditValidator ID="MaskedEditValidator3" runat="server" ControlExtender="DUITextBox_MaskedEditExtender"
                                ControlToValidate="DUITextBox" InvalidValueMessage="DUI No es V&#225;lido!" Display="Dynamic">*</ajaxToolkit:MaskedEditValidator>
                        </td>
                        <td class="style11">
                            NIT*:
                        </td>
                        <td>
                            <asp:TextBox ID="NITTextBox" runat="server" Columns="14" SkinID="TextBox" MaxLength="14"
                                Width="110px" />
                            <ajaxToolkit:MaskedEditExtender ID="NITTextBox_MaskedEditExtender" runat="server"
                                CultureName="es-SV" Mask="9999-999999-999-9" TargetControlID="NITTextBox">
                            </ajaxToolkit:MaskedEditExtender>
                            <ajaxToolkit:MaskedEditValidator ID="MaskedEditValidator11" runat="server" ControlExtender="NITTextBox_MaskedEditExtender"
                                ControlToValidate="NITTextBox" InvalidValueMessage="Nit No es V&#225;lido!" Display="Dynamic">*</ajaxToolkit:MaskedEditValidator>
                            <asp:ImageButton ID="ibtnBuscarParticipante" runat="server" 
                                AlternateText="Buscar" CausesValidation="False" Height="18px" 
                                ImageUrl="~/imagenes/ButtonSearch.png" Width="18px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style10">
                            NOMBRES*:
                        </td>
                        <td colspan="2">
                            <asp:TextBox ID="NOMBRESTextBox" runat="server" Columns="25" SkinID="TextBox" 
                                CssClass="NormalUPPER" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="NOMBRESTextBox"
                                ErrorMessage="Nombres son Requeridos!" Display="Dynamic">*</asp:RequiredFieldValidator>
                        </td>
                        <td class="style11">
                            APELLIDOS*:
                        </td>
                        <td>
                            <asp:TextBox ID="APELLIDOSTextBox" runat="server" Columns="25" SkinID="TextBox" 
                                CssClass="NormalUPPER" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="APELLIDOSTextBox"
                                ErrorMessage="Apellidos son Requeridos!" Display="Dynamic">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style10">
                            DIRECCION*:
                        </td>
                        <td colspan="4">
                            <asp:TextBox ID="DIRECCIONTextBox" runat="server" Width="500px" 
                                SkinID="TextBox" CssClass="NormalUPPER" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="DIRECCIONTextBox"
                                ErrorMessage="Direccion es Requerida!" Display="Dynamic">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style10">
                            DEPARTAMENTO:
                        </td>
                        <td colspan="2">
                            <cc1:ddlBase ID="CODIGO_DEPARTAMENTODropDownList" runat="server" SkinID="ddlBase">
                            </cc1:ddlBase>
                            <ajaxToolkit:CascadingDropDown ID="CODIGO_DEPARTAMENTODropDownList_CascadingDropDown"
                                runat="server" Category="Departamento" Enabled="True" LoadingText="[Cargando ...]"
                                ServiceMethod="GetDropDownContents" TargetControlID="CODIGO_DEPARTAMENTODropDownList"
                                SelectedValue="15" ServicePath="~/Regiones.asmx">
                            </ajaxToolkit:CascadingDropDown>
                        </td>
                        <td class="style11">
                            MUNICIPIO:
                        </td>
                        <td>
                            <cc1:ddlBase ID="CODIGO_MUNICIPIODropDownList" runat="server" SkinID="ddlBase">
                            </cc1:ddlBase>
                            <ajaxToolkit:CascadingDropDown ID="CODIGO_MUNICIPIODropDownList_CascadingDropDown"
                                runat="server" Category="Municipio" Enabled="True" LoadingText="[Cargando ...]"
                                ParentControlID="CODIGO_DEPARTAMENTODropDownList" ServiceMethod="GetDropDownContents"
                                TargetControlID="CODIGO_MUNICIPIODropDownList" ServicePath="~/Regiones.asmx">
                            </ajaxToolkit:CascadingDropDown>
                        </td>
                    </tr>
                    <tr>
                        <td class="style10">
                            ZONA*:
                        </td>
                        <td colspan="3">
                            <asp:RadioButtonList ID="ZONARadioButtonList" runat="server" RepeatDirection="Horizontal"
                                Style="font-size: small" SkinID="RadioButton">
                                <asp:ListItem Value="1">Urbana</asp:ListItem>
                                <asp:ListItem Value="2">Rural</asp:ListItem>
                            </asp:RadioButtonList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="ZONARadioButtonList"
                                ErrorMessage="Zona es Requerida!" Display="Dynamic">*</asp:RequiredFieldValidator>
                        </td>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td class="style10">
                            TELEFONO(S):
                        </td>
                        <td colspan="2">
                            <asp:TextBox ID="TELEFONOTextBox" runat="server" SkinID="TextBox" Columns="30" MaxLength="30" />
                        </td>
                        <td class="style11">
                            MOVIL(ES):
                        </td>
                        <td>
                            <asp:TextBox ID="MOVILTextBox" runat="server" SkinID="TextBox" Columns="30" MaxLength="30" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style10">
                            FAX(ES):
                        </td>
                        <td colspan="2">
                            <asp:TextBox ID="FAXTextBox" runat="server" SkinID="TextBox" Columns="30" MaxLength="30" />
                        </td>
                        <td class="style11">
                            EMAIL(S):
                        </td>
                        <td>
                            <asp:TextBox ID="EMAILTextBox" runat="server" SkinID="TextBox" Columns="30" MaxLength="60" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style10">
                            ISSS:
                        </td>
                        <td colspan="2">
                            <asp:TextBox ID="ISSSTextBox" runat="server" Columns="9" SkinID="TextBox" MaxLength="9" />
                        </td>
                        <td class="style11">
                            EDAD:
                        </td>
                        <td>
                            <asp:TextBox ID="EDADTextBox" runat="server" Columns="3" Enabled="false" SkinID="TextBox" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style10">
                            LUGAR NACIMIENTO:
                        </td>
                        <td colspan="2">
                            <asp:TextBox ID="LUGAR_NACIMIENTOTextBox" runat="server" SkinID="TextBox" 
                                CssClass="NormalUPPER" />
                        </td>
                        <td class="style11">
                            FECHA NACIMIENTO*:
                        </td>
                        <td>
                            <asp:TextBox ID="FECHA_NACIMIENTOTextBox" runat="server" Columns="10" SkinID="TextBox"
                                MaxLength="10" />
                            <ajaxToolkit:MaskedEditExtender ID="FECHA_NACIMIENTOTextBox_MaskedEditExtender" runat="server"
                                ClearMaskOnLostFocus="False" CultureName="es-SV" Mask="99/99/9999"
                                MaskType="Date" TargetControlID="FECHA_NACIMIENTOTextBox">
                            </ajaxToolkit:MaskedEditExtender>
                            <asp:ImageButton ID="ibtnCalendarFECHA_NACIMIENTO" runat="Server" 
                                AlternateText="Click para mostrar el Calendario" CausesValidation="False" 
                                ImageUrl="~/imagenes/Calendar_scheduleHS.png" />
                            <ajaxToolkit:MaskedEditValidator ID="MaskedEditValidator2" runat="server" ControlExtender="FECHA_NACIMIENTOTextBox_MaskedEditExtender"
                                ControlToValidate="FECHA_NACIMIENTOTextBox" EmptyValueMessage="Fecha de Nacimiento es Requerida!"
                                ErrorMessage="MaskedEditValidator2" InvalidValueMessage="Fecha de Nacimiento No V&#225;lida!"
                                IsValidEmpty="False" Display="Dynamic">*</ajaxToolkit:MaskedEditValidator>
                            <ajaxToolkit:CalendarExtender ID="ceFECHA_NACIMIENTO" runat="server" PopupButtonID="ibtnCalendarFECHA_NACIMIENTO"
                                TargetControlID="FECHA_NACIMIENTOTextBox" Format="dd/MM/yyyy" Animated="true"
                                CssClass="calendario">
                            </ajaxToolkit:CalendarExtender>
                        </td>
                    </tr>
                    <tr>
                        <td class="style10">
                            DEPARTAMENTO
                        </td>
                        <td colspan="2">
                            <cc1:ddlBase ID="DEPARTAMENTO_NACDropDownList" runat="server" SkinID="ddlBase">
                            </cc1:ddlBase>
                            <ajaxToolkit:CascadingDropDown ID="DEPARTAMENTO_NACDropDownListCascadingDropDown"
                                runat="server" Category="Departamento" Enabled="True" LoadingText="[Cargando ...]"
                                ServiceMethod="GetDropDownContents" TargetControlID="DEPARTAMENTO_NACDropDownList"
                                SelectedValue="15" ServicePath="~/Regiones.asmx">
                            </ajaxToolkit:CascadingDropDown>
                        </td>
                        <td class="style11">
                            MUNICIPIO:
                        </td>
                        <td>
                            <cc1:ddlBase ID="MUNICIPIO_NACDropDownList" runat="server" SkinID="ddlBase">
                            </cc1:ddlBase>
                            <ajaxToolkit:CascadingDropDown ID="MUNICIPIO_NACDropDownListCascadingDropDown" runat="server"
                                Category="Municipio" Enabled="True" LoadingText="[Cargando ...]" ParentControlID="DEPARTAMENTO_NACDropDownList"
                                ServiceMethod="GetDropDownContents" TargetControlID="MUNICIPIO_NACDropDownList"
                                ServicePath="~/Regiones.asmx">
                            </ajaxToolkit:CascadingDropDown>
                        </td>
                    </tr>
                    <tr>
                        <td class="style10">
                            GENERO*:
                        </td>
                        <td colspan="2">
                            <asp:RadioButtonList ID="GENERORadioButtonList" runat="server" RepeatDirection="Horizontal"
                                Style="font-size: small" SkinID="RadioButton">
                                <asp:ListItem Value="M">Masculino</asp:ListItem>
                                <asp:ListItem Value="F">Femenino</asp:ListItem>
                            </asp:RadioButtonList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="GENERORadioButtonList"
                                ErrorMessage="Genero es Requerido!" Display="Dynamic">*</asp:RequiredFieldValidator>
                        </td>
                        <td class="style11">
                            PROFESION U OFICIO:
                        </td>
                        <td>
                            <asp:TextBox ID="PROFESION_OFICIOTextBox" runat="server" SkinID="TextBox" />
                        </td>
                    </tr>
                    <tr id="trOcupacion" runat="server" visible="false">
                        <td class="style10">
                            OCUPACION:
                        </td>
                        <td colspan="4">
                            <asp:DropDownList ID="CIUODropDownList" runat="server" DataSourceID="CIUODataSource"
                                DataTextField="DESCRIPCION_NACIONAL" DataValueField="CIUO" SkinID="DropDownList"
                                Width="500px">
                            </asp:DropDownList>
                            <asp:ObjectDataSource ID="CIUODataSource" runat="server" OldValuesParameterFormatString="original_{0}"
                                SelectMethod="ObtenerLista" TypeName="SGAFP.BL.cCIUO">
                                <SelectParameters>
                                    <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean" />
                                    <asp:Parameter Name="asColumnaOrden" Type="String" />
                                    <asp:Parameter Name="asTipoOrden" Type="String" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                        </td>
                    </tr>
                    <tr>
                        <td class="style10">
                            ESTADO CIVIL*:
                        </td>
                        <td colspan="4">
                            <asp:RadioButtonList ID="ESTADO_CIVILRadioButtonList" runat="server" RepeatColumns="3"
                                RepeatDirection="Horizontal" SkinID="RadioButton">
                                <asp:ListItem Value="S">Soltero(a)</asp:ListItem>
                                <asp:ListItem Value="C">Casado(a)</asp:ListItem>
                                <asp:ListItem Value="U">Union No Matrimonial</asp:ListItem>
                                <asp:ListItem Value="D">Divorciado(a)</asp:ListItem>
                                <asp:ListItem Value="V">Viudo(a)</asp:ListItem>
                            </asp:RadioButtonList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="ESTADO_CIVILRadioButtonList"
                                ErrorMessage="Estado Civil es Requerido!" Display="Dynamic">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style10">
                            NOMBRE DE FAMILIAR:
                        </td>
                        <td colspan="2">
                            <asp:TextBox ID="NOMBRE_FAMILIARTextBox" runat="server" SkinID="TextBox" 
                                CssClass="NormalUPPER" />
                        </td>
                        <td class="style11">
                            PARENTESCO:
                        </td>
                        <td>
                            <asp:TextBox ID="PARENTESCOTextBox" runat="server" SkinID="TextBox" 
                                MaxLength="40" CssClass="NormalUPPER" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style10">
                            DIRECCION:
                        </td>
                        <td colspan="4">
                            <asp:TextBox ID="DIRECCION_FAMILIARTextBox" runat="server" Width="500px" SkinID="TextBox"
                                MaxLength="150" CssClass="NormalUPPER" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style10">
                            TELEFONO:
                        </td>
                        <td colspan="2">
                            <asp:TextBox ID="TELEFONO_FAMILIARTextBox" runat="server" SkinID="TextBox" MaxLength="8"
                                Columns="8" />
                            <ajaxToolkit:MaskedEditExtender ID="TELEFONO_FAMILIARTextBox_MaskedEditExtender"
                                runat="server" AutoComplete="False" CultureName="es-SV" Mask="9999-9999" TargetControlID="TELEFONO_FAMILIARTextBox">
                            </ajaxToolkit:MaskedEditExtender>
                            <ajaxToolkit:MaskedEditValidator ID="MaskedEditValidator5" runat="server" ControlExtender="TELEFONO_FAMILIARTextBox_MaskedEditExtender"
                                ControlToValidate="TELEFONO_FAMILIARTextBox" InvalidValueMessage="Telefono Familiar No Valido!"
                                Display="Dynamic">*</ajaxToolkit:MaskedEditValidator>
                        </td>
                        <td class="style11">
                            &nbsp;
                        </td>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="5">
                            A QUE SE DEDICA ACTUALMENTE ? PUEDE MARCAR MAS DE UNA CASILLA.
                        </td>
                    </tr>
                    <tr>
                        <td class="style10">
                            <asp:CheckBox ID="OCUACT_TRABAJACheckBox" runat="server" Text="TRABAJA" />
                            <ajaxToolkit:MutuallyExclusiveCheckBoxExtender ID="OCUACT_TRABAJACheckBox_MutuallyExclusiveCheckBoxExtender"
                                runat="server" Enabled="True" Key="DESOCUPADOTrabajo" TargetControlID="OCUACT_TRABAJACheckBox">
                            </ajaxToolkit:MutuallyExclusiveCheckBoxExtender>
                        </td>
                        <td colspan="2">
                            <asp:CheckBox ID="OCUACT_ESTUDIACheckBox" runat="server" Text="ESTUDIA" />
                            <ajaxToolkit:MutuallyExclusiveCheckBoxExtender ID="OCUACT_ESTUDIACheckBox_MutuallyExclusiveCheckBoxExtender"
                                runat="server" Enabled="True" Key="DESOCUPADOEstudia" TargetControlID="OCUACT_ESTUDIACheckBox">
                            </ajaxToolkit:MutuallyExclusiveCheckBoxExtender>
                        </td>
                        <td class="style11">
                            <asp:CheckBox ID="OCUACT_DESOCUPADOCheckBox" runat="server" Text="DESOCUPADO" />
                            <ajaxToolkit:MutuallyExclusiveCheckBoxExtender ID="OCUACT_DESOCUPADOCheckBox_MutuallyExclusiveCheckBoxExtender"
                                runat="server" Enabled="True" Key="DESOCUPADOTrabajo" TargetControlID="OCUACT_DESOCUPADOCheckBox">
                            </ajaxToolkit:MutuallyExclusiveCheckBoxExtender>
                            <ajaxToolkit:MutuallyExclusiveCheckBoxExtender ID="MutuallyExclusiveCheckBoxExtender1"
                                runat="server" Enabled="True" Key="DESOCUPADOEstudia" TargetControlID="OCUACT_DESOCUPADOCheckBox">
                            </ajaxToolkit:MutuallyExclusiveCheckBoxExtender>
                        </td>
                        <td>
                            <asp:CheckBox ID="OCUACT_OFICIO_HOGARCheckBox" runat="server" Text="OFICIOS DEL HOGAR" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="5">
                            SI TRABAJA, QUE TIPO DE TRABAJO TIENE ?
                        </td>
                    </tr>
                    <tr>
                        <td class="style10">
                            <asp:CheckBox ID="TIPTRA_EMPLEADO_EMPRESACheckBox" runat="server" Text="EN UNA EMPRESA" />
                        </td>
                        <td>
                            <asp:CheckBox ID="TIPTRA_EMPRESA_PROPIACheckBox" runat="server" Text="EMPRESA PROPIA" />
                        </td>
                        <td class="style9">
                            <asp:CheckBox ID="TIPTRA_EVENTUALCheckBox" runat="server" Text="EVENTUAL" />
                        </td>
                        <td class="style11">
                            <asp:CheckBox ID="TIPTRA_MEDIO_TIEMPOCheckBox" runat="server" Text="MEDIO TIEMPO" />
                        </td>
                        <td>
                            <asp:CheckBox ID="TIPTRA_INDEPENDIENTECheckBox" runat="server" Text="INDEPENDIENTE" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="5">
                            PERTINENCIA DEL CURSO CON SU OCUPACION ACTUAL. PUEDE MARCAR MAS DE UNA CASILLA.
                        </td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="3">
                            <asp:CheckBox ID="RTC_OCUPACION_EMPRESACheckBox" runat="server" Text="Mi ocupaci&#243;n en la empresa tiene relaci&#243;n con el curso" />
                            <ajaxToolkit:MutuallyExclusiveCheckBoxExtender ID="RTC_OCUPACION_EMPRESACheckBox_MutuallyExclusiveCheckBoxExtender"
                                runat="server" Enabled="True" Key="OcupacionEmpresaRelacion" TargetControlID="RTC_OCUPACION_EMPRESACheckBox">
                            </ajaxToolkit:MutuallyExclusiveCheckBoxExtender>
                            <ajaxToolkit:MutuallyExclusiveCheckBoxExtender ID="MutuallyExclusiveCheckBoxExtender2"
                                runat="server" Enabled="True" Key="OcupacionSeRelacionaConCurso" TargetControlID="RTC_OCUPACION_EMPRESACheckBox">
                            </ajaxToolkit:MutuallyExclusiveCheckBoxExtender>
                        </td>
                        <td colspan="2">
                            <asp:CheckBox ID="RTC_NO_OCUPACION_EMPRESACheckBox" runat="server" Text="Mi ocupaci&#243;n en la empresa no tiene relaci&#243;n con el curso" />
                            <ajaxToolkit:MutuallyExclusiveCheckBoxExtender ID="RTC_NO_OCUPACION_EMPRESACheckBox_MutuallyExclusiveCheckBoxExtender"
                                runat="server" Enabled="True" Key="OcupacionEmpresaRelacion" TargetControlID="RTC_NO_OCUPACION_EMPRESACheckBox">
                            </ajaxToolkit:MutuallyExclusiveCheckBoxExtender>
                            <ajaxToolkit:MutuallyExclusiveCheckBoxExtender ID="MutuallyExclusiveCheckBoxExtender5"
                                runat="server" Enabled="True" Key="OcupacionNoSeRelacionaConCurso" TargetControlID="RTC_NO_OCUPACION_EMPRESACheckBox">
                            </ajaxToolkit:MutuallyExclusiveCheckBoxExtender>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="3">
                            <asp:CheckBox ID="RTC_EMPRESA_PROPIACheckBox" runat="server" Text="El curso tiene relaci&#243;n con el trabajo de mi propia empresa" />
                            <ajaxToolkit:MutuallyExclusiveCheckBoxExtender ID="RTC_EMPRESA_PROPIACheckBox_MutuallyExclusiveCheckBoxExtender"
                                runat="server" Enabled="True" Key="OcupacionEmpresaPropiaRelacion" TargetControlID="RTC_EMPRESA_PROPIACheckBox">
                            </ajaxToolkit:MutuallyExclusiveCheckBoxExtender>
                            <ajaxToolkit:MutuallyExclusiveCheckBoxExtender ID="MutuallyExclusiveCheckBoxExtender3"
                                runat="server" Enabled="True" Key="OcupacionSeRelacionaConCurso" TargetControlID="RTC_EMPRESA_PROPIACheckBox">
                            </ajaxToolkit:MutuallyExclusiveCheckBoxExtender>
                        </td>
                        <td class="style2" colspan="2">
                            <asp:CheckBox ID="RTC_NO_PROPIA_EMPRESACheckBox" runat="server" Text="El curso no tiene relaci&#243;n con el trabajo de mi propia empresa" />
                            <ajaxToolkit:MutuallyExclusiveCheckBoxExtender ID="RTC_NO_PROPIA_EMPRESACheckBox_MutuallyExclusiveCheckBoxExtender"
                                runat="server" Enabled="True" Key="OcupacionEmpresaPropiaRelacion" TargetControlID="RTC_NO_PROPIA_EMPRESACheckBox">
                            </ajaxToolkit:MutuallyExclusiveCheckBoxExtender>
                            <ajaxToolkit:MutuallyExclusiveCheckBoxExtender ID="MutuallyExclusiveCheckBoxExtender6"
                                runat="server" Enabled="True" Key="OcupacionNoSeRelacionaConCurso" TargetControlID="RTC_NO_PROPIA_EMPRESACheckBox">
                            </ajaxToolkit:MutuallyExclusiveCheckBoxExtender>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="3">
                            <asp:CheckBox ID="RTC_EVENTUALCheckBox" runat="server" Text="Mi trabajo eventual tiene relaci&#243;n con el curso" />
                            <ajaxToolkit:MutuallyExclusiveCheckBoxExtender ID="RTC_EVENTUALCheckBox_MutuallyExclusiveCheckBoxExtender"
                                runat="server" Enabled="True" Key="TrabajoEventualRelacion" TargetControlID="RTC_EVENTUALCheckBox">
                            </ajaxToolkit:MutuallyExclusiveCheckBoxExtender>
                            <ajaxToolkit:MutuallyExclusiveCheckBoxExtender ID="MutuallyExclusiveCheckBoxExtender4"
                                runat="server" Enabled="True" Key="OcupacionSeRelacionaConCurso" TargetControlID="RTC_EVENTUALCheckBox">
                            </ajaxToolkit:MutuallyExclusiveCheckBoxExtender>
                        </td>
                        <td colspan="2">
                            <asp:CheckBox ID="RTC_NO_TRABAJO_EVENTUALCheckBox" runat="server" Text="Mi trabajo eventual no tiene relaci&#243;n con el curso" />
                            <ajaxToolkit:MutuallyExclusiveCheckBoxExtender ID="RTC_NO_TRABAJO_EVENTUALCheckBox_MutuallyExclusiveCheckBoxExtender"
                                runat="server" Enabled="True" Key="TrabajoEventualRelacion" TargetControlID="RTC_NO_TRABAJO_EVENTUALCheckBox">
                            </ajaxToolkit:MutuallyExclusiveCheckBoxExtender>
                            <ajaxToolkit:MutuallyExclusiveCheckBoxExtender ID="MutuallyExclusiveCheckBoxExtender7"
                                runat="server" Enabled="True" Key="OcupacionNoSeRelacionaConCurso" TargetControlID="RTC_NO_TRABAJO_EVENTUALCheckBox">
                            </ajaxToolkit:MutuallyExclusiveCheckBoxExtender>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="3">
                            <asp:CheckBox ID="RTC_TRABAJO_MEDIO_TIEMPOCheckBox" runat="server" Text="Mi trabajo de medio tiempo tiene relaci&#243;n con el curso" />
                            <ajaxToolkit:MutuallyExclusiveCheckBoxExtender ID="RTC_TRABAJO_MEDIO_TIEMPOCheckBox_MutuallyExclusiveCheckBoxExtender"
                                runat="server" Enabled="True" Key="TrabajoMedioTiempoRelacion" TargetControlID="RTC_TRABAJO_MEDIO_TIEMPOCheckBox">
                            </ajaxToolkit:MutuallyExclusiveCheckBoxExtender>
                            <ajaxToolkit:MutuallyExclusiveCheckBoxExtender ID="MutuallyExclusiveCheckBoxExtender8"
                                runat="server" Enabled="True" Key="OcupacionSeRelacionaConCurso" TargetControlID="RTC_TRABAJO_MEDIO_TIEMPOCheckBox">
                            </ajaxToolkit:MutuallyExclusiveCheckBoxExtender>
                        </td>
                        <td colspan="2">
                            <asp:CheckBox ID="RTC_NO_TRABAJO_MEDIO_TIEMPOCheckBox" runat="server" Text="Mi trabajo de medio tiempo no tiene relaci&#243;n con el curso" />
                            <ajaxToolkit:MutuallyExclusiveCheckBoxExtender ID="RTC_NO_TRABAJO_MEDIO_TIEMPOCheckBox_MutuallyExclusiveCheckBoxExtender"
                                runat="server" Enabled="True" Key="TrabajoMedioTiempoRelacion" TargetControlID="RTC_NO_TRABAJO_MEDIO_TIEMPOCheckBox">
                            </ajaxToolkit:MutuallyExclusiveCheckBoxExtender>
                            <ajaxToolkit:MutuallyExclusiveCheckBoxExtender ID="MutuallyExclusiveCheckBoxExtender9"
                                runat="server" Enabled="True" Key="OcupacionNoSeRelacionaConCurso" TargetControlID="RTC_NO_TRABAJO_MEDIO_TIEMPOCheckBox">
                            </ajaxToolkit:MutuallyExclusiveCheckBoxExtender>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="3">
                            <asp:CheckBox ID="RTC_INDEPENDIENTECheckBox" runat="server" Text="Mi trabajo independiente tiene relaci&#243;n con el curso" />
                            <ajaxToolkit:MutuallyExclusiveCheckBoxExtender ID="RTC_INDEPENDIENTECheckBox_MutuallyExclusiveCheckBoxExtender"
                                runat="server" Enabled="True" Key="TrabajoIndependienteRelacion" TargetControlID="RTC_INDEPENDIENTECheckBox">
                            </ajaxToolkit:MutuallyExclusiveCheckBoxExtender>
                            <ajaxToolkit:MutuallyExclusiveCheckBoxExtender ID="MutuallyExclusiveCheckBoxExtender10"
                                runat="server" Enabled="True" Key="OcupacionSeRelacionaConCurso" TargetControlID="RTC_INDEPENDIENTECheckBox">
                            </ajaxToolkit:MutuallyExclusiveCheckBoxExtender>
                        </td>
                        <td colspan="2">
                            <asp:CheckBox ID="RTC_NO_INDEPENDIENTECheckBox" runat="server" Text="Mi trabajo independiente no tiene relaci&#243;n con el curso" />
                            <ajaxToolkit:MutuallyExclusiveCheckBoxExtender ID="RTC_NO_INDEPENDIENTECheckBox_MutuallyExclusiveCheckBoxExtender"
                                runat="server" Enabled="True" Key="TrabajoIndependienteRelacion" TargetControlID="RTC_NO_INDEPENDIENTECheckBox">
                            </ajaxToolkit:MutuallyExclusiveCheckBoxExtender>
                            <ajaxToolkit:MutuallyExclusiveCheckBoxExtender ID="MutuallyExclusiveCheckBoxExtender11"
                                runat="server" Enabled="True" Key="OcupacionNoSeRelacionaConCurso" TargetControlID="RTC_NO_INDEPENDIENTECheckBox">
                            </ajaxToolkit:MutuallyExclusiveCheckBoxExtender>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <ajaxToolkit:CollapsiblePanelExtender ID="CollapsiblePanelExtenderSeccion1" runat="Server"
                TargetControlID="PanelDetalleSeccion1" ExpandControlID="PanelEncabezadoSeccion1"
                CollapseControlID="PanelEncabezadoSeccion1" Collapsed="False" TextLabelID="LabelDetalleSeccion1"
                ImageControlID="ImageButtonSeccion1" ExpandedText="(Ocultar Detalles...)" CollapsedText="(Ver Detalles...)"
                ExpandedImage="~/imagenes/collapse_blue.jpg" CollapsedImage="~/imagenes/expand_blue.jpg"
                SuppressPostBack="true" />
        </asp:Panel>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="txtID_PARTICIPANTE" EventName="TextChanged" />
        <asp:AsyncPostBackTrigger ControlID="gvParticipantes" EventName="SelectedIndexChanged" />
    </Triggers>
</asp:UpdatePanel>
<asp:UpdatePanel ID="UpdatePanelSeccion2" runat="server" 
    ChildrenAsTriggers="False"  UpdateMode="Conditional">
    <ContentTemplate>
        <asp:Panel ID="PanelSeccion2" runat="server">
            <asp:Panel ID="PanelEncabezadoSeccion2" runat="server" CssClass="EncabezadoSecciones"
                Height="20px" Width="95%">
                <div style="padding: 5px; cursor: pointer; vertical-align: middle;">
                    <div style="float: left;">
                        SECCION 2. EDUCACION FORMAL Y OCUPACIONAL.</div>
                    <div style="float: left; margin-left: 20px;">
                        <asp:Label ID="LabelDetalleSeccion2" runat="server">(Ver Detalle...)</asp:Label>
                    </div>
                    <div style="float: right; vertical-align: middle;">
                        <asp:ImageButton ID="ImageButtonSeccion2" runat="server" ImageUrl="~/imagenes/expand_blue.jpg"
                            AlternateText="(Ver Detalle...)" CausesValidation="False" />
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel ID="PanelDetalleSeccion2" runat="server" Height="0" Width="95%">
                <table class="insa" width="100%">
                    <tr>
                        <td class="style2" colspan="4">
                            <span lang="ES-MX">Grado de escolaridad alcanzado*:<asp:RadioButtonList ID="NIVEL_ACADEMICORadioButtonList"
                                runat="server" DataSourceID="NivelAcademicoDataSource" DataTextField="DESCRIPCION"
                                DataValueField="NIVEL_ACADEMICO" Style="font-size: small" RepeatColumns="4" SkinID="RadioButton"
                                ValidationGroup="Solicitud">
                            </asp:RadioButtonList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="NIVEL_ACADEMICORadioButtonList"
                                    ErrorMessage="Nivel Acad&#233;mico Alcanzado es Requerido!" Display="Dynamic">*</asp:RequiredFieldValidator>
                            </span>
                        </td>
                    </tr>
                    <tr>
                        <td class="style10">
                            <span lang="ES-MX">T&#205;TULO O CERTIFICADO OBTENIDO:</span>
                        </td>
                        <td>
                            <asp:TextBox ID="TITULO_CERTIFICADO_OBTENIDOTextBox" runat="server" Width="200px"
                                SkinID="TextBox" MaxLength="60" CssClass="NormalUPPER" />
                        </td>
                        <td class="style11">
                            &nbsp;
                        </td>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td class="style10">
                            HACE CUANTO TIEMPO DEJO DE ESTUDIAR FORMALMENTE?
                        </td>
                        <td colspan="3">
                            <asp:RadioButtonList ID="TIEMPO_DEJO_ESTUDIARRadioButtonList1" runat="server" RepeatDirection="Horizontal"
                                Style="font-size: small" SkinID="RadioButton">
                                <asp:ListItem Value="0" Selected="True">No Aplica</asp:ListItem>
                                <asp:ListItem Value="1">Menos de 1 A&#241;o</asp:ListItem>
                                <asp:ListItem Value="2">De 1 a 3 A&#241;os</asp:ListItem>
                                <asp:ListItem Value="3">Mas de 3 A&#241;os</asp:ListItem>
                            </asp:RadioButtonList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" ControlToValidate="TIEMPO_DEJO_ESTUDIARRadioButtonList1"
                                ErrorMessage="Tiempo desde que dej&#243; estudiar es Requerido!" Display="Dynamic">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style10">
                            HA RECIBIDO ANTES ALGUN&nbsp; CURSO DE CAPACITACION*:
                        </td>
                        <td>
                            <asp:RadioButtonList ID="RECIBIO_CURSO_ANTERIORRadioButtonList" runat="server" RepeatDirection="Horizontal"
                                Style="font-size: small" SkinID="RadioButton" AutoPostBack="True">
                                <asp:ListItem Value="S">Si</asp:ListItem>
                                <asp:ListItem Value="N">No</asp:ListItem>
                            </asp:RadioButtonList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="RECIBIO_CURSO_ANTERIORRadioButtonList"
                                ErrorMessage="Es Requerido si ha Recibido Curso!" Display="Dynamic">*</asp:RequiredFieldValidator>
                        </td>
                        <td class="style11">
                            OBTUVO BENEFICIOS DEL CURSO RECIBIDO:
                        </td>
                        <td>
                            <asp:RadioButtonList ID="OBTUVO_BENEFICIO_CURSORadioButtonList" runat="server" RepeatDirection="Horizontal"
                                Style="font-size: small" SkinID="RadioButton">
                                <asp:ListItem Value="S">Si</asp:ListItem>
                                <asp:ListItem Value="N">No</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="4">
                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="MensajeError"
                                ShowMessageBox="True" Width="100%" ShowSummary="False" ValidationGroup="AgregarCursoRecibido">
                            </asp:ValidationSummary>
                            <asp:ValidationSummary ID="ValidationSummary2" runat="server" CssClass="MensajeError"
                                ShowMessageBox="True" Width="100%" ShowSummary="False" ValidationGroup="CursosRecibidos">
                            </asp:ValidationSummary>
                            <asp:GridView ID="gvCursosRecibidos" runat="server" AutoGenerateColumns="False" CssClass="Normal"
                                DataKeyNames="ID_CURSO_RECIBIDO" ShowFooter="True" Visible="False">
                                <Columns>
                                    <asp:TemplateField HeaderText="Id" ItemStyle-HorizontalAlign="Right" Visible="false">
                                        <ItemTemplate>
                                            <asp:Label ID="Label_ID_CURSO_RECIBIDO" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ID_CURSO_RECIBIDO") %>'
                                                Visible="False">
                                            </asp:Label>
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Nombre de Curso">
                                        <EditItemTemplate>
                                            <asp:TextBox ID="TextBox_NOMBRE_CURSO1" runat="server" Text='<%# Bind("NOMBRE_CURSO") %>'
                                                MaxLength="100"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfvTextBox_NOMBRE_CURSO1" runat="server" ControlToValidate="TextBox_NOMBRE_CURSO1"
                                                ErrorMessage="Instituci&#243;n es Requerida" ValidationGroup="CursosRecibidos">*</asp:RequiredFieldValidator>
                                        </EditItemTemplate>
                                        <ItemTemplate>
                                            <asp:Label ID="Label_NOMBRE_CURSO1" runat="server" Text='<%# Bind("NOMBRE_CURSO") %>'></asp:Label>
                                        </ItemTemplate>
                                        <FooterTemplate>
                                            <asp:TextBox ID="NOMBRE_CURSOTextBox" runat="server" MaxLength="100"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="NOMBRE_CURSOTextBox"
                                                ErrorMessage="Nombre del Curso es Requerido" ValidationGroup="AgregarCursoRecibido">*</asp:RequiredFieldValidator>
                                        </FooterTemplate>
                                        <ItemStyle HorizontalAlign="Left" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Instituci&#243;n que lo Imparti&#243;">
                                        <EditItemTemplate>
                                            <asp:TextBox ID="TextBox_INSTITUCION_CURSO1" runat="server" Text='<%# Bind("INSTITUCION_CURSO") %>'
                                                MaxLength="100"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfvTextBox_INSTITUCION_CURSO1" runat="server" ControlToValidate="TextBox_INSTITUCION_CURSO1"
                                                ErrorMessage="Instituci&#243;n es Requerida" ValidationGroup="CursosRecibidos">*</asp:RequiredFieldValidator>
                                        </EditItemTemplate>
                                        <ItemTemplate>
                                            <asp:Label ID="Label_INSTITUCION_CURSO1" runat="server" Text='<%# Bind("INSTITUCION_CURSO") %>'></asp:Label>
                                        </ItemTemplate>
                                        <FooterTemplate>
                                            <asp:TextBox ID="INSTITUCION_CURSOTextBox" runat="server" MaxLength="100"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="INSTITUCION_CURSOTextBox"
                                                ErrorMessage="Instituci&#243;n es Requerida" ValidationGroup="AgregarCursoRecibido">*</asp:RequiredFieldValidator>
                                        </FooterTemplate>
                                        <ItemStyle HorizontalAlign="Left" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Apoyado Por INSAFORP">
                                        <ItemTemplate>
                                            <asp:DropDownList ID="ddlAPOYO_INSAFORP1" runat="server" Enabled="False" SelectedValue='<%# Bind("APOYO_INSAFORP") %>'>
                                                <asp:ListItem Selected="True" Value="1">Si</asp:ListItem>
                                                <asp:ListItem Value="0">No</asp:ListItem>
                                            </asp:DropDownList>
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:DropDownList ID="ddlAPOYO_INSAFORP2" runat="server" SelectedValue='<%# Bind("APOYO_INSAFORP") %>'>
                                                <asp:ListItem Selected="True" Value="1">Si</asp:ListItem>
                                                <asp:ListItem Value="0">No</asp:ListItem>
                                            </asp:DropDownList>
                                        </EditItemTemplate>
                                        <FooterTemplate>
                                            <asp:DropDownList ID="APOYO_INSAFORPDropDownList" runat="server">
                                                <asp:ListItem Selected="True" Value="1">Si</asp:ListItem>
                                                <asp:ListItem Value="0">No</asp:ListItem>
                                            </asp:DropDownList>
                                        </FooterTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="A&#241;o">
                                        <EditItemTemplate>
                                            <asp:TextBox ID="TextBox_ANIO1" runat="server" Text='<%# Bind("ANIO") %>'></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfvTextBox_ANIO1" runat="server" ControlToValidate="TextBox_ANIO1"
                                                ErrorMessage="Año del Curso es Requerido" ValidationGroup="CursosRecibidos">*</asp:RequiredFieldValidator>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidatorDURACION_HORAS" runat="server"
                                                ControlToValidate="TextBox_ANIO1" Display="Dynamic" ErrorMessage="Debe ingresar un valor valido"
                                                ValidationExpression="^[+]?\d*$" ValidationGroup="CursosRecibidos">*</asp:RegularExpressionValidator>
                                            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox_ANIO1"
                                                ErrorMessage="Verifique el valor ingresado" MaximumValue="2010" MinimumValue="1950"
                                                Type="Integer" ValidationGroup="CursosRecibidos">*</asp:RangeValidator>
                                        </EditItemTemplate>
                                        <FooterTemplate>
                                            <asp:TextBox ID="ANIOTextBox" runat="server" Text='<%# Bind("ANIO") %>'></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" ControlToValidate="ANIOTextBox"
                                                ErrorMessage="Año del Curso es Requerido" ValidationGroup="AgregarCursoRecibido">*</asp:RequiredFieldValidator>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidatorDURACION_HORAS" runat="server"
                                                ControlToValidate="ANIOTextBox" Display="Dynamic" ErrorMessage="Debe ingresar un valor valido"
                                                ValidationExpression="^[+]?\d*$" ValidationGroup="AgregarCursoRecibido">*</asp:RegularExpressionValidator>
                                            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="ANIOTextBox"
                                                ErrorMessage="Verifique el valor ingresado" MaximumValue="2010" MinimumValue="1950"
                                                Type="Integer" ValidationGroup="AgregarCursoRecibido">*</asp:RangeValidator>
                                        </FooterTemplate>
                                        <ItemTemplate>
                                            <asp:Label ID="Label_ANIO1" runat="server" Text='<%# Bind("ANIO", "{0:G}") %>'></asp:Label>
                                        </ItemTemplate>
                                        <ItemStyle HorizontalAlign="Right" />
                                    </asp:TemplateField>
                                    <asp:TemplateField ShowHeader="False">
                                        <EditItemTemplate>
                                            <asp:LinkButton ID="LinkButton3" runat="server" CausesValidation="True" CommandName="Update"
                                                Text="Actualizar" ValidationGroup="CursosRecibidos"></asp:LinkButton>
                                            &nbsp;<asp:LinkButton ID="LinkButton4" runat="server" CausesValidation="False" CommandName="Cancel"
                                                Text="Cancelar"></asp:LinkButton>
                                        </EditItemTemplate>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="LinkButton5" runat="server" CausesValidation="False" CommandName="Edit"
                                                Text="Editar"></asp:LinkButton>
                                            &nbsp;<asp:LinkButton ID="LinkButton6" runat="server" CausesValidation="False" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.ID_CURSO_RECIBIDO") %>'
                                                CommandName="Delete" Text="Eliminar"></asp:LinkButton>
                                        </ItemTemplate>
                                        <FooterTemplate>
                                            <asp:LinkButton ID="InsertLinkButton" runat="server" CommandName="Agregar" ValidationGroup="AgregarCursoRecibido">Agregar</asp:LinkButton>
                                        </FooterTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="4">
                            CUAL ES EL BENEFICIO OBTENIDO COMO PRODUCTO DEL CURSO:
                        </td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="2">
                            <asp:CheckBox ID="BENEF_PROM_EMP_ACTCheckBox" runat="server" Text="Obtener oportunidades de promoci&#243;n en mi empleo actual" />
                        </td>
                        <td colspan="2">
                            <asp:CheckBox ID="BENEF_CAMB_EMP_X_CURSOCheckBox2" runat="server" Text="Cambiar a un empleo relacionado con la capacitaci&#243;n recibida" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="2">
                            <asp:CheckBox ID="BENEF_OBT_EMPCheckBox" runat="server" Text="Para obtener un empleo" />
                        </td>
                        <td colspan="2">
                            <asp:CheckBox ID="BENEF_TRAB_CTA_PROPIACheckBox" runat="server" Text="Para trabajar por cuenta propia" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="2">
                            <asp:CheckBox ID="BENEF_OBT_ING_EXTCheckBox" runat="server" Text="Obtener otros ingresos por trabajos extras" />
                        </td>
                        <td colspan="2">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="4">
                            OTRO:<br />
                            <asp:TextBox ID="BENEF_OTROTextBox" runat="server" Columns="100" MaxLength="100"
                                SkinID="TextBox" CssClass="NormalUPPER" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="4">
                            <p>
                                &#191;Porqu&#233; cree que no obtuvo beneficios como producto del curso?<span lang="es-pa"><asp:TextBox
                                    ID="RAZON_NO_BENEFICIOTextBox" runat="server" Columns="100" 
                                    MaxLength="100" SkinID="TextBox" CssClass="NormalUPPER" />
                                </span>
                            </p>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <ajaxToolkit:CollapsiblePanelExtender ID="CollapsiblePanelExtenderSeccion2" runat="Server"
                TargetControlID="PanelDetalleSeccion2" ExpandControlID="PanelEncabezadoSeccion2"
                CollapseControlID="PanelEncabezadoSeccion2" Collapsed="False" TextLabelID="LabelDetalleSeccion2"
                ImageControlID="ImageButtonSeccion2" ExpandedText="(Ocultar Detalles...)" CollapsedText="(Ver Detalles...)"
                ExpandedImage="~/imagenes/collapse_blue.jpg" CollapsedImage="~/imagenes/expand_blue.jpg"
                SuppressPostBack="true" />
        </asp:Panel>
    </ContentTemplate>
    <Triggers>
<%--        <asp:AsyncPostBackTrigger ControlID="ucListaSOLIC_CURSOS_RECIBIDOS1" EventName="Editar" />
--%>        
        <asp:AsyncPostBackTrigger ControlID="gvCursosRecibidos" 
            EventName="RowCancelingEdit" />
        <asp:AsyncPostBackTrigger ControlID="RECIBIO_CURSO_ANTERIORRadioButtonList" 
            EventName="SelectedIndexChanged" />
        <asp:AsyncPostBackTrigger ControlID="gvCursosRecibidos" 
            EventName="RowCommand" />
        <asp:AsyncPostBackTrigger ControlID="gvCursosRecibidos" 
            EventName="RowDeleting" />
        <asp:AsyncPostBackTrigger ControlID="gvCursosRecibidos" 
            EventName="RowEditing" />
        <asp:AsyncPostBackTrigger ControlID="gvCursosRecibidos" 
            EventName="RowUpdating" />
    </Triggers>
</asp:UpdatePanel>
<asp:UpdatePanel ID="UpdatePanelSeccion3" runat="server" 
    ChildrenAsTriggers="False" UpdateMode="Conditional">
    <ContentTemplate>
        <asp:Panel ID="PanelSeccion3" runat="server">
            <asp:Panel ID="PanelEncabezadoSeccion3" runat="server" CssClass="EncabezadoSecciones"
                Height="20px" Width="95%">
                <div style="padding: 5px; cursor: pointer; vertical-align: middle;">
                    <div style="float: left;">
                        SECCION 3. INFORMACION DEL TRABAJO ACTUAL.</div>
                    <div style="float: left; margin-left: 20px;">
                        <asp:Label ID="LabelDetalleSeccion3" runat="server">(Ver Detalle...)</asp:Label>
                    </div>
                    <div style="float: right; vertical-align: middle;">
                        <asp:ImageButton ID="ImageButtonSeccion3" runat="server" ImageUrl="~/imagenes/expand_blue.jpg"
                            AlternateText="(Ver Detalle...)" CausesValidation="False" />
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel ID="PanelDetalleSeccion3" runat="server" Height="0" Width="95%">
                <table class="insa" width="100%">
                    <tr>
                        <td class="style2">
                            TRABAJA ACTUALMENTE*:
                        </td>
                        <td class="style2">
                            <asp:RadioButtonList ID="TRABAJA_ACTUALMENTERadioButtonList" runat="server" RepeatDirection="Horizontal"
                                SkinID="RadioButton" AutoPostBack="True">
                                <asp:ListItem Value="S">Si</asp:ListItem>
                                <asp:ListItem Value="N">No</asp:ListItem>
                            </asp:RadioButtonList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="TRABAJA_ACTUALMENTERadioButtonList"
                                ErrorMessage="Es requerido si Trabaja Actualmente!" Display="Dynamic">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr id="trTrabajoActual" runat="server" visible="false">
                        <td colspan="2">
                            <uc1:ucVistaDetalleSOLIC_EMPLEO_ACTUAL ID="ucVistaDetalleSOLIC_EMPLEO_ACTUAL1" runat="server" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <ajaxToolkit:CollapsiblePanelExtender ID="CollapsiblePanelExtenderSeccion3" runat="Server"
                TargetControlID="PanelDetalleSeccion3" ExpandControlID="PanelEncabezadoSeccion3"
                CollapseControlID="PanelEncabezadoSeccion3" Collapsed="False" TextLabelID="LabelDetalleSeccion3"
                ImageControlID="ImageButtonSeccion3" ExpandedText="(Ocultar Detalles...)" CollapsedText="(Ver Detalles...)"
                ExpandedImage="~/imagenes/collapse_blue.jpg" CollapsedImage="~/imagenes/expand_blue.jpg"
                SuppressPostBack="true" />
        </asp:Panel>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="TRABAJA_ACTUALMENTERadioButtonList" 
            EventName="SelectedIndexChanged" />
    </Triggers>
</asp:UpdatePanel>
<asp:UpdatePanel ID="UpdatePanelSeccion4" runat="server" ChildrenAsTriggers="False"
    UpdateMode="Conditional">
    <ContentTemplate>
        <asp:Panel ID="PanelSeccion4" runat="server">
            <asp:Panel ID="PanelEncabezadoSeccion4" runat="server" CssClass="EncabezadoSecciones"
                Height="20px" Width="95%">
                <div style="padding: 5px; cursor: pointer; vertical-align: middle;">
                    <div style="float: left;">
                        SECCION 4. INFORMACION DEL TRABAJO ANTERIOR.</div>
                    <div style="float: left; margin-left: 20px;">
                        <asp:Label ID="LabelDetalleSeccion4" runat="server">(Ver Detalle...)</asp:Label>
                    </div>
                    <div style="float: right; vertical-align: middle;">
                        <asp:ImageButton ID="ImageButtonSeccion4" runat="server" ImageUrl="~/imagenes/expand_blue.jpg"
                            AlternateText="(Ver Detalle...)" CausesValidation="False" />
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel ID="PanelDetalleSeccion4" runat="server" Height="0" Width="95%">
                <table class="insa" width="100%">
                    <tr>
                        <td class="style2">
                            HA TRABAJADO ANTERIORMENTE*:
                        </td>
                        <td class="style2">
                            <asp:RadioButtonList ID="TRABAJO_ANTERIORRadioButtonList" runat="server" RepeatDirection="Horizontal"
                                SkinID="RadioButton" AutoPostBack="True">
                                <asp:ListItem Value="S">Si</asp:ListItem>
                                <asp:ListItem Value="N">No</asp:ListItem>
                            </asp:RadioButtonList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="TRABAJO_ANTERIORRadioButtonList"
                                ErrorMessage="Es requerido si ha trabajado anteriormente!" Display="Dynamic">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr id="trTrabajoAnterior" runat="server" visible="false">
                        <td colspan="2">
                            <uc2:ucVistaDetalleSOLIC_EMPLEO_ANTERIOR ID="ucVistaDetalleSOLIC_EMPLEO_ANTERIOR1"
                                runat="server" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <ajaxToolkit:CollapsiblePanelExtender ID="CollapsiblePanelExtenderSeccion4" runat="Server"
                TargetControlID="PanelDetalleSeccion4" ExpandControlID="PanelEncabezadoSeccion4"
                CollapseControlID="PanelEncabezadoSeccion4" Collapsed="False" TextLabelID="LabelDetalleSeccion4"
                ImageControlID="ImageButtonSeccion4" ExpandedText="(Ocultar Detalles...)" CollapsedText="(Ver Detalles...)"
                ExpandedImage="~/imagenes/collapse_blue.jpg" CollapsedImage="~/imagenes/expand_blue.jpg"
                SuppressPostBack="true" />
        </asp:Panel>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="TRABAJO_ANTERIORRadioButtonList" 
            EventName="SelectedIndexChanged" />
    </Triggers>
</asp:UpdatePanel>
<asp:UpdatePanel ID="UpdatePanelSeccion5" runat="server" ChildrenAsTriggers="False"
    UpdateMode="Conditional">
    <ContentTemplate>
        <asp:Panel ID="PanelSeccion5" runat="server">
            <asp:Panel ID="PanelEncabezadoSeccion5" runat="server" CssClass="EncabezadoSecciones"
                Height="20px" Width="95%">
                <div style="padding: 5px; cursor: pointer; vertical-align: middle;">
                    <div style="float: left;">
                        SECCION 5. EXPECTATIVAS DE LA FORMACION</div>
                    <div style="float: left; margin-left: 20px;">
                        <asp:Label ID="LabelDetalleSeccion5" runat="server">(Ver Detalle...)</asp:Label>
                    </div>
                    <div style="float: right; vertical-align: middle;">
                        <asp:ImageButton ID="ImageButtonSeccion5" runat="server" ImageUrl="~/imagenes/expand_blue.jpg"
                            AlternateText="(Ver Detalle...)" CausesValidation="False" />
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel ID="PanelDetalleSeccion5" runat="server" Height="0" Width="95%">
                <table class="insa" width="100%">
                    <tr>
                        <td class="style2" colspan="2">
                            <span>&#191;Cu&#225;l es el beneficio socio-econ&#243;mico que espera recibir como producto
                                del curso?</span>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            <asp:CheckBox ID="EXPFOR_PROMOCION_EMPLEOCheckBox" runat="server" Text="Obtener oportunidades de promoci&#243;n en mi empleo actual" />
                        </td>
                        <td>
                            <asp:CheckBox ID="EXPFOR_CAMBIAR_EMPLEOCheckBox" runat="server" Text="Cambiar a un empleo relacionado con la capacitaci&#243;n recibida" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            <asp:CheckBox ID="EXPFOR_OBTENER_EMPLEOCheckBox" runat="server" Text="Para obtener un empleo formal" />
                        </td>
                        <td>
                            <asp:CheckBox ID="EXPFOR_TRABAJAR_CTA_PROPIACheckBox" runat="server" Text="Para trabajar por cuenta propia" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            <asp:CheckBox ID="EXPFOR_INGRESOS_EXTRASCheckBox" runat="server" Text="Obtener otros ingresos por trabajos extras" />
                        </td>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="2">
                            OTRO:<br />
                            <asp:TextBox ID="EXPFOR_OTROTextBox" runat="server" Columns="100" MaxLength="100"
                                SkinID="TextBox" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <ajaxToolkit:CollapsiblePanelExtender ID="CollapsiblePanelExtenderSeccion5" runat="Server"
                TargetControlID="PanelDetalleSeccion5" ExpandControlID="PanelEncabezadoSeccion5"
                CollapseControlID="PanelEncabezadoSeccion5" Collapsed="False" TextLabelID="LabelDetalleSeccion5"
                ImageControlID="ImageButtonSeccion5" ExpandedText="(Ocultar Detalles...)" CollapsedText="(Ver Detalles...)"
                ExpandedImage="~/imagenes/collapse_blue.jpg" CollapsedImage="~/imagenes/expand_blue.jpg"
                SuppressPostBack="true" />
        </asp:Panel>
    </ContentTemplate>
</asp:UpdatePanel>
<asp:UpdatePanel ID="UpdatePanelSeccion6" runat="server" ChildrenAsTriggers="False"
    UpdateMode="Conditional">
    <ContentTemplate>
        <asp:Panel ID="PanelSeccion6" runat="server">
            <asp:Panel ID="PanelEncabezadoSeccion6" runat="server" CssClass="EncabezadoSecciones"
                Height="20px" Width="95%">
                <div style="padding: 5px; cursor: pointer; vertical-align: middle;">
                    <div style="float: left;">
                        SECCION 6. INFORMACION SOCIO-ECONOMICA</div>
                    <div style="float: left; margin-left: 20px;">
                        <asp:Label ID="LabelDetalleSeccion6" runat="server">(Ver Detalle...)</asp:Label>
                    </div>
                    <div style="float: right; vertical-align: middle;">
                        <asp:ImageButton ID="ImageButtonSeccion6" runat="server" ImageUrl="~/imagenes/expand_blue.jpg"
                            AlternateText="(Ver Detalle...)" CausesValidation="False" />
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel ID="PanelDetalleSeccion6" runat="server" Height="0" Width="95%">
                <table class="insa" width="100%">
                    <tr>
                        <td class="style2" colspan="4">
                            <span>&#191;En cu&#225;nto calcula su ingreso mensual?</span>
                            *</td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="4">
                            <asp:RadioButtonList ID="INGRESO_MENSUAL_INDIVIDUALRadioButtonList" runat="server"
                                RepeatColumns="2" Style="font-size: small" SkinID="RadioButton">
                                <asp:ListItem Value="1">Ninguno</asp:ListItem>
                                <asp:ListItem Value="2">Inferior al Salario M&#237;nimo</asp:ListItem>
                                <asp:ListItem Value="2">Un Salario M&#237;nimo</asp:ListItem>
                                <asp:ListItem Value="4">Mayor al Salario M&#237;nimo pero Menor de $500</asp:ListItem>
                                <asp:ListItem Value="5">De $500 a $1,000</asp:ListItem>
                                <asp:ListItem Value="6">Mas de $1,000</asp:ListItem>
                            </asp:RadioButtonList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="INGRESO_MENSUAL_INDIVIDUALRadioButtonList"
                                ErrorMessage="Ingreso Mensual Individual es Requerido!">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="2">
                            CUANTAS PERSONAS INTEGRAN SU&nbsp; GRUPO FAMILIAR*:
                        </td>
                        <td class="style11">
                            <asp:TextBox ID="MIEMBROS_GRUPO_FAMILIARTextBox" runat="server" SkinID="TextBox"
                                Columns="2" MaxLength="2" />
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="MIEMBROS_GRUPO_FAMILIARTextBox"
                                ErrorMessage="# de Personas del Grupo Familiar es Requerido" ValidationExpression="^[1-9]\d{0,2}$"
                                Display="Dynamic">*</asp:RegularExpressionValidator>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" ControlToValidate="MIEMBROS_GRUPO_FAMILIARTextBox"
                                Display="Dynamic" ErrorMessage="Miembros de Grupo Familiar es Requerido!">*</asp:RequiredFieldValidator>
                        </td>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="4">
                            <span>&#191;En cu&#225;nto calcula el ingreso mensual del grupo familiar?</span>
                            *</td>
                    </tr>
                    <tr>
                        <td class="style2" colspan="4">
                            <asp:RadioButtonList ID="INGRESO_MENSUAL_FAMILIARRadioButtonList" runat="server"
                                RepeatColumns="2" Style="font-size: small" SkinID="RadioButton">
                                <asp:ListItem Value="1">Ninguno</asp:ListItem>
                                <asp:ListItem Value="2">Inferior al Salario M&#237;nimo</asp:ListItem>
                                <asp:ListItem Value="3">Un Salario M&#237;nimo</asp:ListItem>
                                <asp:ListItem Value="4">Mayor al Salario M&#237;nimo pero Menor de $500</asp:ListItem>
                                <asp:ListItem Value="5">De $500 a $1,000</asp:ListItem>
                                <asp:ListItem Value="6">Mas de $1,000</asp:ListItem>
                            </asp:RadioButtonList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ControlToValidate="INGRESO_MENSUAL_FAMILIARRadioButtonList"
                                ErrorMessage="Ingreso Mensual Familiar es Requerido!" Display="Dynamic">*</asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                ControlToCompare="INGRESO_MENSUAL_INDIVIDUALRadioButtonList" 
                                ControlToValidate="INGRESO_MENSUAL_FAMILIARRadioButtonList" Display="Dynamic" 
                                ErrorMessage="El Ingreso Familiar no concuerda con el Ingreso Personal." 
                                Operator="GreaterThanEqual" SetFocusOnError="True">*</asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style10">
                            SUGERENCIAS:
                        </td>
                        <td colspan="3">
                            <asp:TextBox ID="SUGERENCIASTextBox" runat="server" Height="50px" TextMode="MultiLine"
                                Width="500px" SkinID="TextBox" MaxLength="600" CssClass="NormalUPPER" />
                        </td>
                    </tr>
                    <tr id="trLugarPresentacion" runat="server" visible="false">
                        <td class="style10">
                            LUGAR_PRESENTACION:
                        </td>
                        <td colspan="3">
                            <asp:TextBox ID="LUGAR_PRESENTACIONTextBox" runat="server" SkinID="TextBox" Columns="50"
                                MaxLength="50" CssClass="NormalUPPER" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <ajaxToolkit:CollapsiblePanelExtender ID="CollapsiblePanelExtenderSeccion6" runat="Server"
                TargetControlID="PanelDetalleSeccion6" ExpandControlID="PanelEncabezadoSeccion6"
                CollapseControlID="PanelEncabezadoSeccion6" Collapsed="False" TextLabelID="LabelDetalleSeccion6"
                ImageControlID="ImageButtonSeccion6" ExpandedText="(Ocultar Detalles...)" CollapsedText="(Ver Detalles...)"
                ExpandedImage="~/imagenes/collapse_blue.jpg" CollapsedImage="~/imagenes/expand_blue.jpg"
                SuppressPostBack="true" />
        </asp:Panel>
    </ContentTemplate>
</asp:UpdatePanel>

<asp:ObjectDataSource ID="NivelAcademicoDataSource" runat="server" 
                        OldValuesParameterFormatString="original_{0}" 
                        SelectMethod="ObtenerLista" 
                        TypeName="SGAFP.BL.cNIVEL_ACADEMICO">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="false" Name="recuperarHijas" Type="Boolean" />
                            <asp:Parameter Name="asColumnaOrden" Type="String" />
                            <asp:Parameter DefaultValue="" Name="asTipoOrden" Type="String" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
<div style=" visibility:hidden">
<asp:TextBox ID="ID_ACCION_FORMATIVATextBox" runat="server" 
                         ReadOnly="True" 
                        Visible="False" />
<asp:TextBox ID="NUMERO_DOCUMENTOTextBox" runat="server" 
                         ReadOnly="True" 
                        Visible="False" />
<asp:TextBox ID="ID_PROVEEDORTextBox" runat="server" 
                         ReadOnly="True" 
                        Visible="False" />
                    <asp:TextBox ID="MunicipioTextBox" runat="server"></asp:TextBox>
                    <asp:TextBox ID="ID_ESTADO_SOLICITUDTextBox" runat="server" 
                        ReadOnly="True" 
                        Visible="False" />
                    <asp:TextBox ID="MunicipioNacTextBox" runat="server"></asp:TextBox>
                    <asp:TextBox ID="ID_TIPO_SOLICITUDTextBox" runat="server" 
                        ReadOnly="True" Visible="False" />
</div>

<asp:UpdatePanel ID="UpdatePanelBusquedaParticipantes1" runat="server" ChildrenAsTriggers="False" UpdateMode="Conditional">
    <ContentTemplate>
    <ajaxToolkit:ModalPopupExtender runat="server" ID="pmpParticipantes"
            BehaviorID="pmpBehaviorParticipantes"
            TargetControlID="htcParticipantes"
            PopupControlID="ppParticipantes" 
            BackgroundCssClass="modalBackground"
            DropShadow="True"
            PopupDragHandleControlID="ppDragHandleParticipantes"
            RepositionMode="RepositionOnWindowScroll" >
        </ajaxToolkit:ModalPopupExtender>
        <asp:Button runat="server" ID="htcParticipantes" Style="display: none" />
        <asp:Panel runat="server" CssClass="modalPopup" ID="ppParticipantes" Style="padding: 10px;
    background-color: #fef5c9; overflow: hidden;">
            <asp:Panel runat="Server" ID="ppDragHandleParticipantes" Style="cursor: move; background-color: #DDDDDD;
                border: solid 1px Gray; color: Black; text-align: center;">
                Busqueda de Participantes
            </asp:Panel>
            <div style="overflow:auto;height:375px">
                <asp:GridView ID="gvParticipantes" runat="server" AllowPaging="True" AutoGenerateColumns="False">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="ID_PARTICIPANTE" HeaderText="ID PARTICIPANTE" 
                            SortExpression="ID_PARTICIPANTE" />
                        <asp:BoundField DataField="NOMBRES" HeaderText="NOMBRES" 
                            SortExpression="NOMBRES" />
                        <asp:BoundField DataField="APELLIDOS" HeaderText="APELLIDOS" 
                            SortExpression="APELLIDOS" />
                        <asp:BoundField DataField="FECHA_NACIMIENTO" HeaderText="FECHA NAC." 
                            SortExpression="FECHA_NACIMIENTO" DataFormatString="{0:d}" />
                        <asp:BoundField DataField="LUGAR_NACIMIENTO" HeaderText="LUGAR NAC." 
                            SortExpression="LUGAR_NACIMIENTO" />
                        <asp:BoundField DataField="DIRECCION" HeaderText="DIRECCION" 
                            SortExpression="DIRECCION" />
                        <asp:BoundField DataField="DUI" HeaderText="DUI" SortExpression="DUI" />
                        <asp:BoundField DataField="NIT" HeaderText="NIT" SortExpression="NIT" />
                        <asp:BoundField DataField="TELEFONO" HeaderText="TELEFONO" 
                            SortExpression="TELEFONO" />
                        <asp:BoundField DataField="EMAIL" HeaderText="EMAIL" SortExpression="EMAIL" />
                    </Columns>
                </asp:GridView>  
            </div>          
            <a id="hidePopupParticipantes" href="#">Cerrar</a>
        </asp:Panel>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="ibtnBuscarParticipante" EventName="Click" />
        <asp:AsyncPostBackTrigger ControlID="gvParticipantes" 
            EventName="PageIndexChanging" />
        <asp:AsyncPostBackTrigger ControlID="gvParticipantes" EventName="SelectedIndexChanged" />
    </Triggers>
</asp:UpdatePanel>
