<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucReporte.ascx.vb" Inherits="controles_ucReporte" %>
<%@ Register assembly="DevExpress.XtraReports.v11.1.Web, Version=11.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraReports.Web" tagprefix="dx" %>
    <dx:ReportToolbar ID="ReportToolbar1" runat='server' 
    ShowDefaultButtons='False' ReportViewer="<%# ReportViewer1 %>">
        <Items>
            <dx:ReportToolbarButton ItemKind='Search' ToolTip="Desplegar Ventana de Busqueda" />
            <dx:ReportToolbarSeparator />
            <dx:ReportToolbarButton ItemKind='PrintReport' ToolTip="Imprimir Reporte" />
            <dx:ReportToolbarButton ItemKind='PrintPage' ToolTip="Imprimir Pagina Actual" />
            <dx:ReportToolbarSeparator />
            <dx:ReportToolbarButton Enabled='False' ItemKind='FirstPage' ToolTip="Primer Pagina" />
            <dx:ReportToolbarButton Enabled='False' ItemKind='PreviousPage' ToolTip="Pagina Anterior" />
            <dx:ReportToolbarLabel ItemKind='PageLabel' Text="Pagina" />
            <dx:ReportToolbarComboBox ItemKind='PageNumber' Width='65px'>
            </dx:ReportToolbarComboBox>
            <dx:ReportToolbarLabel ItemKind='OfLabel' Text="de" />
            <dx:ReportToolbarTextBox IsReadOnly='True' ItemKind='PageCount' />
            <dx:ReportToolbarButton ItemKind='NextPage' ToolTip="Siguiente Pagina" />
            <dx:ReportToolbarButton ItemKind='LastPage' ToolTip="Ultima Pagina" />
            <dx:ReportToolbarSeparator />
            <dx:ReportToolbarButton ItemKind='SaveToDisk' ToolTip="Exportar reporte a Disco" />
            <dx:ReportToolbarButton ItemKind='SaveToWindow' ToolTip="Exportar reporte a Disco y Visualizar en Pantalla" />
            <dx:ReportToolbarComboBox ItemKind='SaveFormat' Width='70px'>
                <Elements>
                    <dx:ListElement Value='pdf' />
                    <dx:ListElement Value='xls' />
                    <dx:ListElement Value='xlsx' />
                    <dx:ListElement Value='rtf' />
                    <dx:ListElement Value='mht' />
                    <dx:ListElement Value='txt' />
                    <dx:ListElement Value='csv' />
                    <dx:ListElement Value='png' />
                </Elements>
            </dx:ReportToolbarComboBox>
        </Items>
        <Styles>
            <LabelStyle>
                <Margins MarginLeft='3px' MarginRight='3px' />
            </LabelStyle>
        </Styles>
    </dx:ReportToolbar>
        <dx:ReportViewer ID="ReportViewer1" runat="server" ClientInstanceName="ReportViewer1"  
    Border-BorderStyle="Solid" Border-BorderWidth="1px" Border-BorderColor="Silver" 
    LoadingPanelText="Cargando&amp;hellip;">
<Border BorderColor="#A8A8A8" BorderStyle="Solid" BorderWidth="1px"></Border>
                </dx:ReportViewer>
