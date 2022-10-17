<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMantPARTICIPANTE.ascx.vb" Inherits="controles_ucMantPARTICIPANTE" %>
<%@ Register TagPrefix="uc1" TagName="ucBarraNavegacion" Src="~/controles/ucBarraNavegacion.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucListaPARTICIPANTE" Src="~/controles/ucListaPARTICIPANTE.ascx" %>
<%@ Register TagPrefix="uc1" TagName="ucVistaDetallePARTICIPANTE" Src="~/controles/ucVistaDetallePARTICIPANTE.ascx" %>
<%@ Register src="ucCriteriosParticipante.ascx" tagname="ucCriteriosParticipante" tagprefix="uc2" %>

<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxLoadingPanel" TagPrefix="dx" %>

<script language="javascript" type="text/javascript">
    function CargarParticipantes() {  
        var NOMBRES = '';
        var APELLIDOS = '';
        var FECHA_NACIMIENTO = '';
        var ID_PARTICIPANTE = '-1';
        var DUI = '';
        var NIT = '';
        if (txtNOMBRES.GetValue() != null) { NOMBRES = txtNOMBRES.GetValue(); }
        if (txtAPELLIDOS.GetValue() != null) { APELLIDOS = txtAPELLIDOS.GetValue(); }
        if (dteFECHA_NACIMIENTO.GetValue() != null) {
            var fecha = new Date();
            fecha = dteFECHA_NACIMIENTO.GetDate();            
            FECHA_NACIMIENTO = fecha.getDate() + '/' + (fecha.getMonth() + 1) + '/' + fecha.getFullYear();            
        }
        if (txtID_PARTICIPANTE.GetValue() != null) { ID_PARTICIPANTE = txtID_PARTICIPANTE.GetValue(); }
        if (txtDUI.GetValue() != null) { DUI = txtDUI.GetValue(); }
        if (txtNIT.GetValue() != null) { NIT = txtNIT.GetValue(); }

        if (NOMBRES == '' && APELLIDOS == '' && FECHA_NACIMIENTO == '' && ID_PARTICIPANTE == '-1' && DUI == '' && NIT == '') {
            AsignarMensaje('Especifique por lo menos un Criterio de Búsqueda');
            return 
        }

        MostrarPanelModal(true, 'Buscando participantes...');
        cMantPARTICIPANTES.PerformCallback('BuscarPartipantes;CRITERIOS;' + NOMBRES + ';' + APELLIDOS + ';' + FECHA_NACIMIENTO + ';' + ID_PARTICIPANTE + ';' + DUI + ';' + NIT);
    }

    function MostrarPanelModal(mostrar, mensaje) {
        if (mostrar) {
            if (mensaje == '') {
                LoadingPanel.SetText('Cargando...');
            }
            else {
                LoadingPanel.SetText(mensaje);
            }
            LoadingPanel.Show();

        }
        else {
            LoadingPanel.Hide();
        }
    }
</script>
<dx:ASPxCallbackPanel runat="server" ID="cMantPARTICIPANTES" ClientInstanceName="cMantPARTICIPANTES" ShowLoadingPanel="false"  > 
<ClientSideEvents EndCallback="function(s,e){MostrarPanelModal(false,'');}" /> 
    <PanelCollection>        
        <dx:PanelContent runat="server">   
            <table id="TableMant" cellSpacing="0" cellPadding="0" width="100%" border="0">
                    <tr>
			               <td><uc1:ucBarraNavegacion id="ucBarraNavegacion1" HabilitarCallBacks="true" runat="server"></uc1:ucBarraNavegacion></td>
                    </tr>
                <tr>
		               <td align="center" class="EncabezadoSecciones"><asp:Label id="lblTitulo" style="Z-INDEX: 101" runat="server">CONSULTA DE PARTICIPANTES</asp:Label></td>
		           </tr>
		           <tr>
			           <td><asp:Image ID="Image2" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></td>
		           </tr>
		               <tr>
		                   <td>
                               <uc2:ucCriteriosParticipante ID="ucCriteriosParticipante1" runat="server" />
                           </td>
		               </tr>
		               <tr>
			               <td><asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/spacer.gif" Width="17px" Height="12px" BorderStyle="None" /></td>
		               </tr>
	                   <tr>
                        <td><uc1:ucListaPARTICIPANTE ID="ucListaPARTICIPANTE1" runat="server" VerCARGO="false"
                                VerCIUO="false" VerCLAVE_USUARIO="false" VerCODIGO_DEPARTAMENTO="false" VerCODIGO_MUNICIPIO="false"
                                VerCODIGO_REGION="false" VerCUENTA_USUARIO="false" VerDEPARTAMENTO_NAC="false"
                                VerDIRECCION="false" VerEMAIL="false" VerESTADO_CIVIL="false" VerESTADO_FAMILIAR="false"
                                VerFAX="false" VerFECHA_VENCIMIENTO_CLAVE="false" VerISSS="false" VerLASTUPDATE="false"
                                VerLUGAR_NACIMIENTO="false" VerMUNICIPIO_NAC="false" VerNIT_EMPRESA="false" VerNOMBRE_EMPRESA="false"
                                VerOCUPACION_ACTUAL="false" VerPROFESION_OFICIO="false" VerTITULO_CERTIFICADO_OBTENIDO="false"
                                VerUSERID="false" VerZONA="false" VerGENERO="false" VerID_PAIS="false" VerTIPO_DOCTO="false"
                                VerNUM_DOCTO="false" VerID_ESTADO_CIVIL="false" VerID_NIVEL_ACADEMICO="false" VerOTRA_EDUCACION_FORMAL="false"         
                                VerCON_DISCAPACIDAD="false" VerDISC_OTRA="false" PermitirFiltroEnEncabezado="false" PermitirEditar="false"
                                PermitirSeleccionar="false" VerCursosRecibidos="true" 
                                />
                            <uc1:ucVistaDetallePARTICIPANTE ID="ucVistaDetallePARTICIPANTE1" runat="server" 
                                Visible="False" VerCIUO="False" ></uc1:ucVistaDetallePARTICIPANTE></td>
                    </tr>                
            </table>
            <dx:ASPxHiddenField runat="server" ID="hf" /> 
       </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>
<dx:ASPxLoadingPanel ID="LoadingPanel" runat="server" ClientInstanceName="LoadingPanel" Text="Cargando..."  Modal="True" />