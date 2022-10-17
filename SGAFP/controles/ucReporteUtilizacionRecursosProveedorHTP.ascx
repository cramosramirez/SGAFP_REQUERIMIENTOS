<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucReporteUtilizacionRecursosProveedorHTP.ascx.vb" Inherits="controles_ucReporteUtilizacionRecursosProveedorHTP" %>
<%@ Register src="~/controles/ucBarraNavegacion.ascx" tagname="ucBarraNavegacion" tagprefix="uc1" %>
<%@ Register src="~/controles/ucCriteriosConsultaEjecucion.ascx" tagname="ucCriteriosConsultaEjecucion" tagprefix="uc1" %>
<%@ Register src="~/controles/ucReporte.ascx" tagname="ucReporte" tagprefix="uc1" %>

<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxLoadingPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v11.1, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>

<script language="javascript" type="text/javascript">    
    
    function VerReporte() {
        var ID_PROVEEDOR_AF = '-1';        
        var EJERCICIO = '';
        var OPCION = '';        
        if (cbxProveedor.GetValue() != null) { ID_PROVEEDOR_AF = cbxProveedor.GetValue(); }        
        if (cbxEjercicio.GetValue() != null) { EJERCICIO = cbxEjercicio.GetValue(); }

        if (ID_PROVEEDOR_AF == '-1') {
            OPCION = 'CargarInformacion';
        }      
        cReporte.PerformCallback(ID_PROVEEDOR_AF + ';' + EJERCICIO);
        LoadingPanel.Show();
    }
</script>
<dx:ASPxCallbackPanel runat="server" ID="cReporte" ClientInstanceName="cReporte" ShowLoadingPanel="false" >      
    <ClientSideEvents EndCallback="function(s,e){ReportViewer1.Refresh();LoadingPanel.Hide();}"  />
     <PanelCollection>        
            <dx:PanelContent ID="PanelContent1" runat="server">   
                <uc1:ucBarraNavegacion ID="ucBarraNavegacion1" HabilitarCallBacks="true" runat="server"  />
                <uc1:ucCriteriosConsultaEjecucion ID="ucCriteriosConsultaEjecucion1" runat="server"  
                     VerPrograma="false" VerBotonMostrar="false" VerCentroFormacion="false" VerAreaFormacion="false" VerClasificacionCursos="false" VerCodigoGrupo="false"  />     
                <uc1:ucReporte ID="ucReporte1" runat="server" />       
                <dx:ASPxHiddenField runat="server" ID="hf" /> 
            </dx:PanelContent>
     </PanelCollection>
</dx:ASPxCallbackPanel>
<dx:ASPxLoadingPanel ID="LoadingPanel" runat="server" ClientInstanceName="LoadingPanel" Text="Cargando reporte..."  Modal="True" />
