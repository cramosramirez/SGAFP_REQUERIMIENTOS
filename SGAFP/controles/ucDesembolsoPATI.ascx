<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucDesembolsoPATI.ascx.vb" Inherits="controles_ucDesembolsoPATI" %>
<%@ Register Src="ucCriteriosMunicipiosPATI.ascx" TagName="ucCriteriosMunicipiosPATI" TagPrefix="uc1" %>
<%@ Register Src="ucBarraNavegacion.ascx" TagName="ucBarraNavegacion" TagPrefix="uc1" %>
<%@ Register Src="ucListaDESEMBOLSO.ascx" TagName="ucListaDESEMBOLSO" TagPrefix="uc1" %>
<%@ Register src="ucVistaDetalleDESEMBOLSO.ascx" tagname="ucVistaDetalleDESEMBOLSO" tagprefix="uc1" %>
<%@ Register src="ucDesembolsoPATI_Aplicacion.ascx" tagname="ucDesembolsoPATI_Aplicacion" tagprefix="uc1" %>

<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxLoadingPanel" TagPrefix="dx" %>

<script language="javascript" type="text/javascript">    
    var _visibleIndex_dxgvLista;

    function CargarDesembolsos() {
        var ID_FUENTE = '-1';
        var NO_CONVOCATORIA = '-1';

        if (cbxFuenteFinanciamiento.GetValue() != null) {
            ID_FUENTE = cbxFuenteFinanciamiento.GetValue();
            }
        else {
            AsignarMensaje('Seleccione Fuente de Financiamiento');
            return;
        }
        if (speConvocatoria.GetValue() != null) {
            NO_CONVOCATORIA = speConvocatoria.GetValue();
        }
        else {
            AsignarMensaje('Seleccione la Convocatoria');
            return;
        }    

        MostrarPanelModal(true, 'Mostrando Desembolsos...');
        cMantDESEMBOLSO.PerformCallback('CargarDesembolsos;' +
                                        ID_FUENTE + ';' +
                                        NO_CONVOCATORIA);
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
<dx:ASPxCallbackPanel runat="server" ID="cMantDESEMBOLSO" ClientInstanceName="cMantDESEMBOLSO" ShowLoadingPanel="false"> 
    <ClientSideEvents EndCallback="function(s,e){                                            
                                            MostrarPanelModal(false,'');                                           
                                        }" />          
    <PanelCollection>        
        <dx:PanelContent ID="PanelContent1" runat="server">   
                <uc1:ucBarraNavegacion ID="UcBarraNavegacion1" runat="server" 
                                PermitirAgregar="false"  PermitirEditar="false" 
                                PermitirGuardar="false"  
                                PermitirNavegacion="false" Visible="true" />
            
                <uc1:ucCriteriosMunicipiosPATI ID="ucCriteriosMunicipiosPATI1" VerMunicipio="false" VerDepartamento="false" runat="server"   />
            
                <uc1:ucListaDESEMBOLSO ID="ucListaDESEMBOLSO1" runat="server" VerID_FUENTE="false" NombreGridCliente="ucListaDESEMBOLSO1"    
                                     VerID_DESEMBOLSO="false" PermitirAplicarInline="true" PermitirEliminar="false" PermitirEliminarInline="true" PermitirPaginacion="True" PermitirEditar="false"  
                                    VerLASTUPDATE="False" VerUSERID="False" PermitirFiltroPorFila="True"  PermitirSeleccionar="true"  PermitirAgregarInline="true" PermitirEditarInline="true" 
                                     TamanoFuente="X-Small" NombreFuente="tahoma" TamanoPagina="30" />                        
           
                <uc1:ucDesembolsoPATI_Aplicacion ID="ucDesembolsoPATI_Aplicacion1" runat="server" />
         </dx:PanelContent>
    </PanelCollection>
</dx:ASPxCallbackPanel>
<dx:ASPxLoadingPanel ID="LoadingPanel" runat="server" ClientInstanceName="LoadingPanel" Text="Cargando..."  Modal="True" />
