Imports System.Collections.Generic

Public Class xrAnexoTAF4A
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Código Generado "

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel37 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel38 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel40 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel43 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel42 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel41 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel44 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel46 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel45 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel49 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel48 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel47 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel52 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel50 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel55 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel54 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel53 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel57 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel56 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrLiquidadoAnteriorFISDL As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel60 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel59 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel58 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLabel68 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrSaldoPorLiquidarFISDL As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel66 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel65 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel63 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel62 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel61 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrLiquidadoAnteriorTOTAL As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel69 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrSaldoPorLiquidarTOTAL As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel70 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel73 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel72 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrEstaLiquidacionFISDL As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel74 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrEstaLiquidacionTOTAL As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel71 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel67 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel64 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrNuevoSaldoPendienteFISDL As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel76 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel78 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel77 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrNuevoSaldoPendienteTOTAL As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel80 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel82 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel83 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel85 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel84 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel86 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel87 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel91 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel90 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel89 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel93 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel92 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel99 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel98 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel96 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel95 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel94 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel105 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel104 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel103 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel102 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel101 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel100 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel106 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel112 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel111 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel110 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel108 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel107 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrServiciosCapacitacionTOTAL As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel117 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel116 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel115 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrServiciosCapacitacionFISDL As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel113 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel120 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel119 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel118 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel114 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel121 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel128 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel127 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel126 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel125 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel124 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel123 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel129 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrTotalLiquidacionFISDL As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel130 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel132 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel131 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel134 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel133 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrTotalLiquidacionTOTAL As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel137 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel136 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel140 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel138 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel141 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel145 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel146 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel143 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel144 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel149 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel150 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel147 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel148 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel154 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel155 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel153 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel151 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel152 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel156 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DS_DL1 As SGAFP.DL.DS_DL
    Friend WithEvents AnexoTAF4ATableAdapter1 As SGAFP.DL.DS_DLTableAdapters.AnexoTAF4ATableAdapter
    Friend WithEvents XrLabel157 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel79 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel81 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel88 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel159 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel158 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel160 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel161 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel162 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLabel164 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel163 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel142 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel167 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel166 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel165 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel139 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel97 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel75 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel51 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel135 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel122 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel109 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel169 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel170 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel171 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel172 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel168 As DevExpress.XtraReports.UI.XRLabel

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel171 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel170 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel169 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel162 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel161 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel160 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel159 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel158 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel88 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel81 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel79 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLiquidadoAnteriorTOTAL = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel37 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel38 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel39 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel40 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel41 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel42 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel43 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel44 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel45 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel46 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel47 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel48 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel49 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel50 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel52 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel53 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel54 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel55 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel56 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel57 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel58 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel59 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel60 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLiquidadoAnteriorFISDL = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel61 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel62 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel63 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel65 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel66 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrSaldoPorLiquidarFISDL = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel68 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel69 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrSaldoPorLiquidarTOTAL = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel72 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel73 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel74 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel64 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel67 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel71 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrEstaLiquidacionTOTAL = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel76 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrNuevoSaldoPendienteFISDL = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel78 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel77 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel80 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrNuevoSaldoPendienteTOTAL = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel82 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel83 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel84 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel85 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel86 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel87 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel89 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel90 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel91 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel92 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel94 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel95 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel96 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel98 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel99 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel100 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel101 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel102 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel103 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel104 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel105 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel106 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel107 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel108 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel110 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel111 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel112 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel113 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrServiciosCapacitacionFISDL = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel115 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel116 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrServiciosCapacitacionTOTAL = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel114 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel118 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel119 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel120 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel121 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel123 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel124 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel125 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel126 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel127 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel128 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel129 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel130 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrTotalLiquidacionFISDL = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel132 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel131 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel133 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel134 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel136 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel137 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrTotalLiquidacionTOTAL = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel138 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel140 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel141 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel157 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrEstaLiquidacionFISDL = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel70 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel156 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel154 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel155 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel153 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel151 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel152 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel149 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel150 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel147 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel148 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel145 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel146 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel143 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel144 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DS_DL1 = New SGAFP.DL.DS_DL()
        Me.AnexoTAF4ATableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.AnexoTAF4ATableAdapter()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel51 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel122 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel135 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel109 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel75 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel97 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel139 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel165 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel166 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel167 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel142 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel163 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel164 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel168 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel172 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Expanded = False
        Me.Detail.HeightF = 0.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 20.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 24.04162!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel171, Me.XrLabel170, Me.XrLabel169, Me.XrLabel162, Me.XrLabel161, Me.XrLabel160, Me.XrLabel159, Me.XrLabel158, Me.XrLabel88, Me.XrLabel81, Me.XrLabel79, Me.XrLabel5, Me.XrLabel17, Me.XrLabel16, Me.xrLiquidadoAnteriorTOTAL, Me.XrLabel4, Me.XrLabel3, Me.XrLabel6, Me.XrLabel7, Me.XrLabel8, Me.XrLabel9, Me.XrLabel10, Me.XrLabel11, Me.XrLabel12, Me.XrLabel13, Me.XrLabel14, Me.XrLabel15, Me.XrLabel18, Me.XrLabel19, Me.XrLabel20, Me.XrLabel21, Me.XrLabel22, Me.XrLabel23, Me.XrLabel24, Me.XrLabel25, Me.XrLabel26, Me.XrLabel27, Me.XrLabel28, Me.XrLabel29, Me.XrLabel30, Me.XrLabel31, Me.XrLabel32, Me.XrLabel33, Me.XrLabel34, Me.XrLabel35, Me.XrLabel37, Me.XrLabel36, Me.XrLabel38, Me.XrLabel39, Me.XrLabel40, Me.XrLabel41, Me.XrLabel42, Me.XrLabel43, Me.XrLabel44, Me.XrLabel45, Me.XrLabel46, Me.XrLabel47, Me.XrLabel48, Me.XrLabel49, Me.XrLabel50, Me.XrLabel52, Me.XrLabel53, Me.XrLabel54, Me.XrLabel55, Me.XrLabel56, Me.XrLabel57, Me.XrLabel58, Me.XrLabel59, Me.XrLabel60, Me.xrLiquidadoAnteriorFISDL, Me.XrLabel61, Me.XrLabel62, Me.XrLabel63, Me.XrLabel65, Me.XrLabel66, Me.xrSaldoPorLiquidarFISDL, Me.XrLabel68, Me.XrLabel69, Me.xrSaldoPorLiquidarTOTAL, Me.XrLabel72, Me.XrLabel73, Me.XrLabel74, Me.XrLabel64, Me.XrLabel67, Me.XrLabel71, Me.xrEstaLiquidacionTOTAL, Me.XrLabel76, Me.xrNuevoSaldoPendienteFISDL, Me.XrLabel78, Me.XrLabel77, Me.XrLabel80, Me.xrNuevoSaldoPendienteTOTAL, Me.XrLabel82, Me.XrLabel83, Me.XrLabel84, Me.XrLabel85, Me.XrLabel86, Me.XrLabel87, Me.XrLabel89, Me.XrLabel90, Me.XrLabel91, Me.XrLabel92, Me.XrLabel94, Me.XrLabel95, Me.XrLabel96, Me.XrLabel98, Me.XrLabel99, Me.XrLabel100, Me.XrLabel101, Me.XrLabel102, Me.XrLabel103, Me.XrLabel104, Me.XrLabel105, Me.XrLabel106, Me.XrLabel107, Me.XrLabel108, Me.XrLabel110, Me.XrLabel111, Me.XrLabel112, Me.XrLabel113, Me.xrServiciosCapacitacionFISDL, Me.XrLabel115, Me.XrLabel116, Me.xrServiciosCapacitacionTOTAL, Me.XrLabel114, Me.XrLabel118, Me.XrLabel119, Me.XrLabel120, Me.XrLabel121, Me.XrLabel123, Me.XrLabel124, Me.XrLabel125, Me.XrLabel126, Me.XrLabel127, Me.XrLabel128, Me.XrLabel129, Me.XrLabel130, Me.xrTotalLiquidacionFISDL, Me.XrLabel132, Me.XrLabel131, Me.XrLabel133, Me.XrLabel134, Me.XrLabel136, Me.XrLabel137, Me.xrTotalLiquidacionTOTAL, Me.XrLabel138, Me.XrLabel140, Me.XrLabel141, Me.XrLabel157, Me.xrEstaLiquidacionFISDL, Me.XrLabel70})
        Me.GroupHeader1.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("ID_LIQUIDACION", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 783.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.StylePriority.UseFont = False
        '
        'XrLabel171
        '
        Me.XrLabel171.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel171.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel171.LocationFloat = New DevExpress.Utils.PointFloat(635.2082!, 734.875!)
        Me.XrLabel171.Name = "XrLabel171"
        Me.XrLabel171.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel171.SizeF = New System.Drawing.SizeF(115.7919!, 4.0!)
        Me.XrLabel171.StylePriority.UseBorders = False
        Me.XrLabel171.StylePriority.UseFont = False
        Me.XrLabel171.StylePriority.UseTextAlignment = False
        Me.XrLabel171.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel170
        '
        Me.XrLabel170.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel170.LocationFloat = New DevExpress.Utils.PointFloat(51.0416!, 613.6251!)
        Me.XrLabel170.Name = "XrLabel170"
        Me.XrLabel170.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel170.SizeF = New System.Drawing.SizeF(311.5415!, 18.0!)
        Me.XrLabel170.StylePriority.UseFont = False
        Me.XrLabel170.StylePriority.UseTextAlignment = False
        Me.XrLabel170.Text = "Servicios Profesionales para Fortalecer Capacidad Financiera"
        Me.XrLabel170.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel169
        '
        Me.XrLabel169.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel169.LocationFloat = New DevExpress.Utils.PointFloat(51.04167!, 508.625!)
        Me.XrLabel169.Name = "XrLabel169"
        Me.XrLabel169.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel169.SizeF = New System.Drawing.SizeF(293.5002!, 18.0!)
        Me.XrLabel169.StylePriority.UseFont = False
        Me.XrLabel169.StylePriority.UseTextAlignment = False
        Me.XrLabel169.Text = "Nuevo saldo pendiente de liquidar"
        Me.XrLabel169.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel162
        '
        Me.XrLabel162.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel162.LocationFloat = New DevExpress.Utils.PointFloat(505.9167!, 424.6249!)
        Me.XrLabel162.Name = "XrLabel162"
        Me.XrLabel162.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel162.SizeF = New System.Drawing.SizeF(17.04172!, 18.00003!)
        Me.XrLabel162.StylePriority.UseFont = False
        Me.XrLabel162.StylePriority.UseTextAlignment = False
        Me.XrLabel162.Text = "$"
        Me.XrLabel162.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel161
        '
        Me.XrLabel161.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel161.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel161.LocationFloat = New DevExpress.Utils.PointFloat(619.2082!, 705.875!)
        Me.XrLabel161.Name = "XrLabel161"
        Me.XrLabel161.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel161.SizeF = New System.Drawing.SizeF(15.0!, 28.0!)
        Me.XrLabel161.StylePriority.UseBorders = False
        Me.XrLabel161.StylePriority.UseFont = False
        Me.XrLabel161.StylePriority.UseTextAlignment = False
        Me.XrLabel161.Text = "%"
        Me.XrLabel161.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel160
        '
        Me.XrLabel160.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel160.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel160.LocationFloat = New DevExpress.Utils.PointFloat(505.9167!, 613.6251!)
        Me.XrLabel160.Name = "XrLabel160"
        Me.XrLabel160.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel160.SizeF = New System.Drawing.SizeF(17.04172!, 18.00006!)
        Me.XrLabel160.StylePriority.UseBorders = False
        Me.XrLabel160.StylePriority.UseFont = False
        Me.XrLabel160.StylePriority.UseTextAlignment = False
        Me.XrLabel160.Text = "$"
        Me.XrLabel160.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel159
        '
        Me.XrLabel159.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel159.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel159.LocationFloat = New DevExpress.Utils.PointFloat(635.2082!, 634.6249!)
        Me.XrLabel159.Name = "XrLabel159"
        Me.XrLabel159.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel159.SizeF = New System.Drawing.SizeF(15.04169!, 18.0!)
        Me.XrLabel159.StylePriority.UseBorders = False
        Me.XrLabel159.StylePriority.UseFont = False
        Me.XrLabel159.StylePriority.UseTextAlignment = False
        Me.XrLabel159.Text = "$"
        Me.XrLabel159.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel158
        '
        Me.XrLabel158.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel158.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel158.LocationFloat = New DevExpress.Utils.PointFloat(650.7919!, 655.6248!)
        Me.XrLabel158.Name = "XrLabel158"
        Me.XrLabel158.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel158.SizeF = New System.Drawing.SizeF(100.2082!, 18.0!)
        Me.XrLabel158.StylePriority.UseBorders = False
        Me.XrLabel158.StylePriority.UseFont = False
        Me.XrLabel158.StylePriority.UseTextAlignment = False
        Me.XrLabel158.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel88
        '
        Me.XrLabel88.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel88.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel88.LocationFloat = New DevExpress.Utils.PointFloat(522.9584!, 571.625!)
        Me.XrLabel88.Name = "XrLabel88"
        Me.XrLabel88.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel88.SizeF = New System.Drawing.SizeF(94.99994!, 18.00006!)
        Me.XrLabel88.StylePriority.UseBorders = False
        Me.XrLabel88.StylePriority.UseFont = False
        Me.XrLabel88.StylePriority.UseTextAlignment = False
        Me.XrLabel88.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel81
        '
        Me.XrLabel81.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel81.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel81.LocationFloat = New DevExpress.Utils.PointFloat(650.7919!, 592.6249!)
        Me.XrLabel81.Name = "XrLabel81"
        Me.XrLabel81.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel81.SizeF = New System.Drawing.SizeF(100.2082!, 18.0!)
        Me.XrLabel81.StylePriority.UseBorders = False
        Me.XrLabel81.StylePriority.UseFont = False
        Me.XrLabel81.StylePriority.UseTextAlignment = False
        Me.XrLabel81.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel79
        '
        Me.XrLabel79.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel79.LocationFloat = New DevExpress.Utils.PointFloat(635.2082!, 466.6251!)
        Me.XrLabel79.Name = "XrLabel79"
        Me.XrLabel79.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel79.SizeF = New System.Drawing.SizeF(15.04169!, 18.0!)
        Me.XrLabel79.StylePriority.UseFont = False
        Me.XrLabel79.StylePriority.UseTextAlignment = False
        Me.XrLabel79.Text = "$"
        Me.XrLabel79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(0.0001271566!, 32.49995!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(750.9999!, 23.0!)
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Fecha de elaboración: [FECHA_ELABORACION!dd' de 'MMMM' de 'yyyy]."
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel17
        '
        Me.XrLabel17.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(126.1249!, 150.2083!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(204.8748!, 18.0!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "[NOMBRE_DEPARTAMENTO]"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel16
        '
        Me.XrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel16.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(330.9997!, 150.2083!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(13.54211!, 18.0!)
        Me.XrLabel16.StylePriority.UseBorders = False
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = ","
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLiquidadoAnteriorTOTAL
        '
        Me.xrLiquidadoAnteriorTOTAL.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.xrLiquidadoAnteriorTOTAL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrLiquidadoAnteriorTOTAL.LocationFloat = New DevExpress.Utils.PointFloat(650.2914!, 445.6249!)
        Me.xrLiquidadoAnteriorTOTAL.Name = "xrLiquidadoAnteriorTOTAL"
        Me.xrLiquidadoAnteriorTOTAL.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLiquidadoAnteriorTOTAL.SizeF = New System.Drawing.SizeF(100.7085!, 17.99997!)
        Me.xrLiquidadoAnteriorTOTAL.StylePriority.UseBorders = False
        Me.xrLiquidadoAnteriorTOTAL.StylePriority.UseFont = False
        Me.xrLiquidadoAnteriorTOTAL.StylePriority.UseTextAlignment = False
        Me.xrLiquidadoAnteriorTOTAL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(337.5418!, 0.0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(48.91656!, 23.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "No."
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(386.4583!, 0.0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(59.33331!, 23.0!)
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = " [NO_LIQUIDACION]"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(21.87513!, 55.50003!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(16.6249!, 23.0!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "I."
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(51.04167!, 55.50003!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(405.1666!, 23.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "GENERALIDADES"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(21.87513!, 85.49995!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(16.6249!, 23.0!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "A."
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(21.87513!, 115.5!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(16.6249!, 23.0!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "B."
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(51.04167!, 85.49995!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(113.4999!, 23.00001!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Código del Proyecto:"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(51.04167!, 115.5!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(113.4999!, 23.00001!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Nombre del Proyecto:"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(21.87513!, 147.5!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(16.6249!, 23.0!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "C."
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(51.04167!, 147.5!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(72.87489!, 23.00002!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "Localización:"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel14
        '
        Me.XrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel14.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(126.1249!, 168.2083!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(211.4169!, 15.0!)
        Me.XrLabel14.StylePriority.UseBorders = False
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "Departamento"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel15
        '
        Me.XrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel15.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(337.5418!, 168.2083!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(211.8749!, 15.0!)
        Me.XrLabel15.StylePriority.UseBorders = False
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "Municipio"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel18
        '
        Me.XrLabel18.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(368.4999!, 310.4999!)
        Me.XrLabel18.Multiline = True
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(119.7502!, 31.0!)
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "Aporte" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FISDL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel19
        '
        Me.XrLabel19.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(21.87513!, 181.875!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(16.6249!, 23.0!)
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "D."
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel20
        '
        Me.XrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel20.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(164.5416!, 85.49995!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(586.4584!, 23.00001!)
        Me.XrLabel20.StylePriority.UseBorders = False
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = "[CODIGO_PROYECTO]"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel21
        '
        Me.XrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel21.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(164.5416!, 115.5!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(586.4584!, 23.00002!)
        Me.XrLabel21.StylePriority.UseBorders = False
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = "[NOMBRE_PROYECTO]"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel22
        '
        Me.XrLabel22.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(51.04167!, 181.875!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(45.79156!, 23.00002!)
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.Text = "Banco:"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel23
        '
        Me.XrLabel23.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(96.83323!, 183.875!)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(654.1667!, 18.99998!)
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.Text = "[NOMBRE_BANCO_LIQ]"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel24
        '
        Me.XrLabel24.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(21.87513!, 215.5833!)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(16.6249!, 23.0!)
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.StylePriority.UseTextAlignment = False
        Me.XrLabel24.Text = "E."
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel25
        '
        Me.XrLabel25.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(51.04167!, 215.5833!)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(131.2082!, 23.00002!)
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        Me.XrLabel25.Text = "No. de Cuenta Corriente:"
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel26
        '
        Me.XrLabel26.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(182.2499!, 215.5833!)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(568.7501!, 23.00002!)
        Me.XrLabel26.StylePriority.UseFont = False
        Me.XrLabel26.StylePriority.UseTextAlignment = False
        Me.XrLabel26.Text = "[NO_CTA_LIQ]"
        Me.XrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel27
        '
        Me.XrLabel27.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(21.87513!, 247.9167!)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(16.6249!, 23.0!)
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        Me.XrLabel27.Text = "F."
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel28
        '
        Me.XrLabel28.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(51.04167!, 247.9167!)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(152.0416!, 23.00003!)
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.StylePriority.UseTextAlignment = False
        Me.XrLabel28.Text = "Nombre de Cuenta Corriente:"
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel29
        '
        Me.XrLabel29.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(203.0832!, 247.9167!)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(547.9167!, 23.00003!)
        Me.XrLabel29.StylePriority.UseFont = False
        Me.XrLabel29.StylePriority.UseTextAlignment = False
        Me.XrLabel29.Text = "[NOMBRE_CTA_LIQ]"
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel30
        '
        Me.XrLabel30.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(21.87513!, 280.5!)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(16.6249!, 23.0!)
        Me.XrLabel30.StylePriority.UseFont = False
        Me.XrLabel30.StylePriority.UseTextAlignment = False
        Me.XrLabel30.Text = "G."
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel31
        '
        Me.XrLabel31.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(51.04167!, 280.5!)
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(137.0!, 23.00003!)
        Me.XrLabel31.StylePriority.UseFont = False
        Me.XrLabel31.StylePriority.UseTextAlignment = False
        Me.XrLabel31.Text = "Fuente de Financiamiento:"
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel32
        '
        Me.XrLabel32.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(188.0417!, 280.5!)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(562.9582!, 23.00003!)
        Me.XrLabel32.StylePriority.UseFont = False
        Me.XrLabel32.StylePriority.UseTextAlignment = False
        Me.XrLabel32.Text = "[CODIGO_FINANCIAMIENTO]"
        Me.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel33
        '
        Me.XrLabel33.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel33.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 303.5!)
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(750.9999!, 6.999939!)
        Me.XrLabel33.StylePriority.UseBorders = False
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.StylePriority.UseTextAlignment = False
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel34
        '
        Me.XrLabel34.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(21.87513!, 341.5!)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel34.SizeF = New System.Drawing.SizeF(16.6249!, 23.0!)
        Me.XrLabel34.StylePriority.UseFont = False
        Me.XrLabel34.StylePriority.UseTextAlignment = False
        Me.XrLabel34.Text = "II."
        Me.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel35
        '
        Me.XrLabel35.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel35.LocationFloat = New DevExpress.Utils.PointFloat(51.04162!, 341.5!)
        Me.XrLabel35.Name = "XrLabel35"
        Me.XrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel35.SizeF = New System.Drawing.SizeF(293.5002!, 23.0!)
        Me.XrLabel35.StylePriority.UseFont = False
        Me.XrLabel35.StylePriority.UseTextAlignment = False
        Me.XrLabel35.Text = "MONTO ASIGNADO"
        Me.XrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel37
        '
        Me.XrLabel37.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel37.LocationFloat = New DevExpress.Utils.PointFloat(386.4584!, 341.5!)
        Me.XrLabel37.Name = "XrLabel37"
        Me.XrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel37.SizeF = New System.Drawing.SizeF(101.7917!, 18.0!)
        Me.XrLabel37.StylePriority.UseFont = False
        Me.XrLabel37.StylePriority.UseTextAlignment = False
        Me.XrLabel37.Text = "[APORTE_FISDL!#,##0.00]"
        Me.XrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel36
        '
        Me.XrLabel36.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel36.LocationFloat = New DevExpress.Utils.PointFloat(368.4999!, 341.5!)
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel36.SizeF = New System.Drawing.SizeF(17.95844!, 18.0!)
        Me.XrLabel36.StylePriority.UseFont = False
        Me.XrLabel36.StylePriority.UseTextAlignment = False
        Me.XrLabel36.Text = "$"
        Me.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel38
        '
        Me.XrLabel38.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel38.LocationFloat = New DevExpress.Utils.PointFloat(503.9167!, 310.4998!)
        Me.XrLabel38.Multiline = True
        Me.XrLabel38.Name = "XrLabel38"
        Me.XrLabel38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel38.SizeF = New System.Drawing.SizeF(118.25!, 31.0!)
        Me.XrLabel38.StylePriority.UseFont = False
        Me.XrLabel38.StylePriority.UseTextAlignment = False
        Me.XrLabel38.Text = "Aporte" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Municipalidad" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel39
        '
        Me.XrLabel39.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel39.LocationFloat = New DevExpress.Utils.PointFloat(503.9167!, 341.5!)
        Me.XrLabel39.Name = "XrLabel39"
        Me.XrLabel39.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel39.SizeF = New System.Drawing.SizeF(15.04169!, 18.0!)
        Me.XrLabel39.StylePriority.UseFont = False
        Me.XrLabel39.StylePriority.UseTextAlignment = False
        Me.XrLabel39.Text = "$"
        Me.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel40
        '
        Me.XrLabel40.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel40.LocationFloat = New DevExpress.Utils.PointFloat(518.9584!, 341.4998!)
        Me.XrLabel40.Name = "XrLabel40"
        Me.XrLabel40.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel40.SizeF = New System.Drawing.SizeF(103.2083!, 18.0!)
        Me.XrLabel40.StylePriority.UseFont = False
        Me.XrLabel40.StylePriority.UseTextAlignment = False
        Me.XrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel41
        '
        Me.XrLabel41.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel41.LocationFloat = New DevExpress.Utils.PointFloat(635.2499!, 341.5!)
        Me.XrLabel41.Name = "XrLabel41"
        Me.XrLabel41.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel41.SizeF = New System.Drawing.SizeF(15.0!, 18.0!)
        Me.XrLabel41.StylePriority.UseFont = False
        Me.XrLabel41.StylePriority.UseTextAlignment = False
        Me.XrLabel41.Text = "$"
        Me.XrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel42
        '
        Me.XrLabel42.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel42.LocationFloat = New DevExpress.Utils.PointFloat(650.2914!, 341.5!)
        Me.XrLabel42.Name = "XrLabel42"
        Me.XrLabel42.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel42.SizeF = New System.Drawing.SizeF(100.7084!, 18.0!)
        Me.XrLabel42.StylePriority.UseFont = False
        Me.XrLabel42.StylePriority.UseTextAlignment = False
        Me.XrLabel42.Text = "[APORTE_FISDL!#,##0.00]"
        Me.XrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel43
        '
        Me.XrLabel43.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel43.LocationFloat = New DevExpress.Utils.PointFloat(635.75!, 310.4998!)
        Me.XrLabel43.Multiline = True
        Me.XrLabel43.Name = "XrLabel43"
        Me.XrLabel43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel43.SizeF = New System.Drawing.SizeF(115.2499!, 31.0!)
        Me.XrLabel43.StylePriority.UseFont = False
        Me.XrLabel43.StylePriority.UseTextAlignment = False
        Me.XrLabel43.Text = "TOTAL"
        Me.XrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel44
        '
        Me.XrLabel44.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel44.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrLabel44.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 369.5!)
        Me.XrLabel44.Name = "XrLabel44"
        Me.XrLabel44.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel44.SizeF = New System.Drawing.SizeF(750.9999!, 5.0!)
        Me.XrLabel44.StylePriority.UseBorders = False
        Me.XrLabel44.StylePriority.UseFont = False
        Me.XrLabel44.StylePriority.UseTextAlignment = False
        Me.XrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel45
        '
        Me.XrLabel45.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel45.LocationFloat = New DevExpress.Utils.PointFloat(21.87513!, 391.625!)
        Me.XrLabel45.Name = "XrLabel45"
        Me.XrLabel45.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel45.SizeF = New System.Drawing.SizeF(18.0!, 23.0!)
        Me.XrLabel45.StylePriority.UseFont = False
        Me.XrLabel45.StylePriority.UseTextAlignment = False
        Me.XrLabel45.Text = "III."
        Me.XrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel46
        '
        Me.XrLabel46.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel46.LocationFloat = New DevExpress.Utils.PointFloat(51.04162!, 391.625!)
        Me.XrLabel46.Name = "XrLabel46"
        Me.XrLabel46.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel46.SizeF = New System.Drawing.SizeF(293.5002!, 23.0!)
        Me.XrLabel46.StylePriority.UseFont = False
        Me.XrLabel46.StylePriority.UseTextAlignment = False
        Me.XrLabel46.Text = "LIQUIDACION DE GASTOS"
        Me.XrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel47
        '
        Me.XrLabel47.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel47.LocationFloat = New DevExpress.Utils.PointFloat(368.5!, 391.625!)
        Me.XrLabel47.Multiline = True
        Me.XrLabel47.Name = "XrLabel47"
        Me.XrLabel47.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel47.SizeF = New System.Drawing.SizeF(119.7501!, 31.0!)
        Me.XrLabel47.StylePriority.UseFont = False
        Me.XrLabel47.StylePriority.UseTextAlignment = False
        Me.XrLabel47.Text = "Aporte" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FISDL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel48
        '
        Me.XrLabel48.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel48.LocationFloat = New DevExpress.Utils.PointFloat(368.4999!, 424.625!)
        Me.XrLabel48.Name = "XrLabel48"
        Me.XrLabel48.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel48.SizeF = New System.Drawing.SizeF(17.95847!, 17.99997!)
        Me.XrLabel48.StylePriority.UseFont = False
        Me.XrLabel48.StylePriority.UseTextAlignment = False
        Me.XrLabel48.Text = "$"
        Me.XrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel49
        '
        Me.XrLabel49.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel49.LocationFloat = New DevExpress.Utils.PointFloat(386.4584!, 424.625!)
        Me.XrLabel49.Name = "XrLabel49"
        Me.XrLabel49.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel49.SizeF = New System.Drawing.SizeF(102.7501!, 18.0!)
        Me.XrLabel49.StylePriority.UseFont = False
        Me.XrLabel49.StylePriority.UseTextAlignment = False
        Me.XrLabel49.Text = "[FINANCIAMIENTO!#,##0.00]"
        Me.XrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel50
        '
        Me.XrLabel50.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel50.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel50.LocationFloat = New DevExpress.Utils.PointFloat(522.9584!, 424.625!)
        Me.XrLabel50.Name = "XrLabel50"
        Me.XrLabel50.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel50.SizeF = New System.Drawing.SizeF(95.0!, 17.99997!)
        Me.XrLabel50.StylePriority.UseBorders = False
        Me.XrLabel50.StylePriority.UseFont = False
        Me.XrLabel50.StylePriority.UseTextAlignment = False
        Me.XrLabel50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel52
        '
        Me.XrLabel52.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel52.LocationFloat = New DevExpress.Utils.PointFloat(505.9167!, 391.625!)
        Me.XrLabel52.Multiline = True
        Me.XrLabel52.Name = "XrLabel52"
        Me.XrLabel52.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel52.SizeF = New System.Drawing.SizeF(112.0417!, 31.0!)
        Me.XrLabel52.StylePriority.UseFont = False
        Me.XrLabel52.StylePriority.UseTextAlignment = False
        Me.XrLabel52.Text = "Aporte" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Municipalidad" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel53
        '
        Me.XrLabel53.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel53.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel53.LocationFloat = New DevExpress.Utils.PointFloat(650.7919!, 424.625!)
        Me.XrLabel53.Name = "XrLabel53"
        Me.XrLabel53.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel53.SizeF = New System.Drawing.SizeF(100.2081!, 17.99997!)
        Me.XrLabel53.StylePriority.UseBorders = False
        Me.XrLabel53.StylePriority.UseFont = False
        Me.XrLabel53.StylePriority.UseTextAlignment = False
        Me.XrLabel53.Text = "[FINANCIAMIENTO!#,##0.00]"
        Me.XrLabel53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel54
        '
        Me.XrLabel54.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel54.LocationFloat = New DevExpress.Utils.PointFloat(635.2498!, 424.625!)
        Me.XrLabel54.Name = "XrLabel54"
        Me.XrLabel54.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel54.SizeF = New System.Drawing.SizeF(15.04169!, 18.0!)
        Me.XrLabel54.StylePriority.UseFont = False
        Me.XrLabel54.StylePriority.UseTextAlignment = False
        Me.XrLabel54.Text = "$"
        Me.XrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel55
        '
        Me.XrLabel55.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel55.LocationFloat = New DevExpress.Utils.PointFloat(635.2498!, 391.625!)
        Me.XrLabel55.Multiline = True
        Me.XrLabel55.Name = "XrLabel55"
        Me.XrLabel55.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel55.SizeF = New System.Drawing.SizeF(115.7501!, 31.0!)
        Me.XrLabel55.StylePriority.UseFont = False
        Me.XrLabel55.StylePriority.UseTextAlignment = False
        Me.XrLabel55.Text = "TOTAL"
        Me.XrLabel55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel56
        '
        Me.XrLabel56.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrLabel56.LocationFloat = New DevExpress.Utils.PointFloat(21.87513!, 419.625!)
        Me.XrLabel56.Name = "XrLabel56"
        Me.XrLabel56.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel56.SizeF = New System.Drawing.SizeF(18.0!, 22.99994!)
        Me.XrLabel56.StylePriority.UseFont = False
        Me.XrLabel56.StylePriority.UseTextAlignment = False
        Me.XrLabel56.Text = "A."
        Me.XrLabel56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel57
        '
        Me.XrLabel57.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel57.LocationFloat = New DevExpress.Utils.PointFloat(51.04167!, 419.625!)
        Me.XrLabel57.Name = "XrLabel57"
        Me.XrLabel57.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel57.SizeF = New System.Drawing.SizeF(293.5002!, 23.0!)
        Me.XrLabel57.StylePriority.UseFont = False
        Me.XrLabel57.StylePriority.UseTextAlignment = False
        Me.XrLabel57.Text = "FINANCIAMIENTO"
        Me.XrLabel57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel58
        '
        Me.XrLabel58.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel58.LocationFloat = New DevExpress.Utils.PointFloat(51.04162!, 445.6249!)
        Me.XrLabel58.Name = "XrLabel58"
        Me.XrLabel58.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel58.SizeF = New System.Drawing.SizeF(293.5002!, 18.0!)
        Me.XrLabel58.StylePriority.UseFont = False
        Me.XrLabel58.StylePriority.UseTextAlignment = False
        Me.XrLabel58.Text = "Monto liquidado anteriormente"
        Me.XrLabel58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel59
        '
        Me.XrLabel59.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrLabel59.LocationFloat = New DevExpress.Utils.PointFloat(21.87513!, 445.6249!)
        Me.XrLabel59.Name = "XrLabel59"
        Me.XrLabel59.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel59.SizeF = New System.Drawing.SizeF(18.0!, 18.0!)
        Me.XrLabel59.StylePriority.UseFont = False
        Me.XrLabel59.StylePriority.UseTextAlignment = False
        Me.XrLabel59.Text = "(-)"
        Me.XrLabel59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel60
        '
        Me.XrLabel60.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel60.LocationFloat = New DevExpress.Utils.PointFloat(368.5!, 445.6249!)
        Me.XrLabel60.Name = "XrLabel60"
        Me.XrLabel60.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel60.SizeF = New System.Drawing.SizeF(17.00003!, 18.0!)
        Me.XrLabel60.StylePriority.UseFont = False
        Me.XrLabel60.StylePriority.UseTextAlignment = False
        Me.XrLabel60.Text = "$"
        Me.XrLabel60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrLiquidadoAnteriorFISDL
        '
        Me.xrLiquidadoAnteriorFISDL.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLiquidadoAnteriorFISDL.LocationFloat = New DevExpress.Utils.PointFloat(386.4584!, 445.6249!)
        Me.xrLiquidadoAnteriorFISDL.Name = "xrLiquidadoAnteriorFISDL"
        Me.xrLiquidadoAnteriorFISDL.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLiquidadoAnteriorFISDL.SizeF = New System.Drawing.SizeF(102.7501!, 18.0!)
        Me.xrLiquidadoAnteriorFISDL.StylePriority.UseFont = False
        Me.xrLiquidadoAnteriorFISDL.StylePriority.UseTextAlignment = False
        Me.xrLiquidadoAnteriorFISDL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel61
        '
        Me.XrLabel61.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel61.LocationFloat = New DevExpress.Utils.PointFloat(505.9583!, 445.6249!)
        Me.XrLabel61.Name = "XrLabel61"
        Me.XrLabel61.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel61.SizeF = New System.Drawing.SizeF(17.00003!, 18.0!)
        Me.XrLabel61.StylePriority.UseFont = False
        Me.XrLabel61.StylePriority.UseTextAlignment = False
        Me.XrLabel61.Text = "$"
        Me.XrLabel61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel62
        '
        Me.XrLabel62.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel62.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel62.LocationFloat = New DevExpress.Utils.PointFloat(522.9583!, 445.6249!)
        Me.XrLabel62.Name = "XrLabel62"
        Me.XrLabel62.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel62.SizeF = New System.Drawing.SizeF(95.00006!, 17.99997!)
        Me.XrLabel62.StylePriority.UseBorders = False
        Me.XrLabel62.StylePriority.UseFont = False
        Me.XrLabel62.StylePriority.UseTextAlignment = False
        Me.XrLabel62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel63
        '
        Me.XrLabel63.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel63.LocationFloat = New DevExpress.Utils.PointFloat(635.2082!, 445.6249!)
        Me.XrLabel63.Name = "XrLabel63"
        Me.XrLabel63.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel63.SizeF = New System.Drawing.SizeF(15.04169!, 18.0!)
        Me.XrLabel63.StylePriority.UseFont = False
        Me.XrLabel63.StylePriority.UseTextAlignment = False
        Me.XrLabel63.Text = "$"
        Me.XrLabel63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel65
        '
        Me.XrLabel65.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel65.LocationFloat = New DevExpress.Utils.PointFloat(51.04167!, 466.6251!)
        Me.XrLabel65.Name = "XrLabel65"
        Me.XrLabel65.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel65.SizeF = New System.Drawing.SizeF(293.5002!, 18.0!)
        Me.XrLabel65.StylePriority.UseFont = False
        Me.XrLabel65.StylePriority.UseTextAlignment = False
        Me.XrLabel65.Text = "Saldo por liquidar"
        Me.XrLabel65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel66
        '
        Me.XrLabel66.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel66.LocationFloat = New DevExpress.Utils.PointFloat(368.4999!, 466.6251!)
        Me.XrLabel66.Name = "XrLabel66"
        Me.XrLabel66.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel66.SizeF = New System.Drawing.SizeF(17.00003!, 18.0!)
        Me.XrLabel66.StylePriority.UseFont = False
        Me.XrLabel66.StylePriority.UseTextAlignment = False
        Me.XrLabel66.Text = "$"
        Me.XrLabel66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrSaldoPorLiquidarFISDL
        '
        Me.xrSaldoPorLiquidarFISDL.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrSaldoPorLiquidarFISDL.LocationFloat = New DevExpress.Utils.PointFloat(386.4584!, 466.6251!)
        Me.xrSaldoPorLiquidarFISDL.Name = "xrSaldoPorLiquidarFISDL"
        Me.xrSaldoPorLiquidarFISDL.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrSaldoPorLiquidarFISDL.SizeF = New System.Drawing.SizeF(102.7501!, 18.0!)
        Me.xrSaldoPorLiquidarFISDL.StylePriority.UseFont = False
        Me.xrSaldoPorLiquidarFISDL.StylePriority.UseTextAlignment = False
        Me.xrSaldoPorLiquidarFISDL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel68
        '
        Me.XrLabel68.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel68.LocationFloat = New DevExpress.Utils.PointFloat(505.9584!, 466.6251!)
        Me.XrLabel68.Name = "XrLabel68"
        Me.XrLabel68.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel68.SizeF = New System.Drawing.SizeF(17.00003!, 18.0!)
        Me.XrLabel68.StylePriority.UseFont = False
        Me.XrLabel68.StylePriority.UseTextAlignment = False
        Me.XrLabel68.Text = "$"
        Me.XrLabel68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel69
        '
        Me.XrLabel69.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel69.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel69.LocationFloat = New DevExpress.Utils.PointFloat(522.9584!, 466.6251!)
        Me.XrLabel69.Name = "XrLabel69"
        Me.XrLabel69.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel69.SizeF = New System.Drawing.SizeF(95.00006!, 18.00006!)
        Me.XrLabel69.StylePriority.UseBorders = False
        Me.XrLabel69.StylePriority.UseFont = False
        Me.XrLabel69.StylePriority.UseTextAlignment = False
        Me.XrLabel69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xrSaldoPorLiquidarTOTAL
        '
        Me.xrSaldoPorLiquidarTOTAL.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.xrSaldoPorLiquidarTOTAL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrSaldoPorLiquidarTOTAL.LocationFloat = New DevExpress.Utils.PointFloat(650.7917!, 466.6251!)
        Me.xrSaldoPorLiquidarTOTAL.Name = "xrSaldoPorLiquidarTOTAL"
        Me.xrSaldoPorLiquidarTOTAL.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrSaldoPorLiquidarTOTAL.SizeF = New System.Drawing.SizeF(100.2082!, 18.00006!)
        Me.xrSaldoPorLiquidarTOTAL.StylePriority.UseBorders = False
        Me.xrSaldoPorLiquidarTOTAL.StylePriority.UseFont = False
        Me.xrSaldoPorLiquidarTOTAL.StylePriority.UseTextAlignment = False
        Me.xrSaldoPorLiquidarTOTAL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel72
        '
        Me.XrLabel72.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel72.LocationFloat = New DevExpress.Utils.PointFloat(51.04167!, 487.625!)
        Me.XrLabel72.Name = "XrLabel72"
        Me.XrLabel72.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel72.SizeF = New System.Drawing.SizeF(293.5002!, 18.0!)
        Me.XrLabel72.StylePriority.UseFont = False
        Me.XrLabel72.StylePriority.UseTextAlignment = False
        Me.XrLabel72.Text = "Esta liquidación"
        Me.XrLabel72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel73
        '
        Me.XrLabel73.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrLabel73.LocationFloat = New DevExpress.Utils.PointFloat(21.87513!, 487.625!)
        Me.XrLabel73.Name = "XrLabel73"
        Me.XrLabel73.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel73.SizeF = New System.Drawing.SizeF(18.0!, 18.0!)
        Me.XrLabel73.StylePriority.UseFont = False
        Me.XrLabel73.StylePriority.UseTextAlignment = False
        Me.XrLabel73.Text = "(-)"
        Me.XrLabel73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel74
        '
        Me.XrLabel74.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel74.LocationFloat = New DevExpress.Utils.PointFloat(368.4999!, 487.625!)
        Me.XrLabel74.Name = "XrLabel74"
        Me.XrLabel74.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel74.SizeF = New System.Drawing.SizeF(17.00003!, 18.0!)
        Me.XrLabel74.StylePriority.UseFont = False
        Me.XrLabel74.StylePriority.UseTextAlignment = False
        Me.XrLabel74.Text = "$"
        Me.XrLabel74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel64
        '
        Me.XrLabel64.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel64.LocationFloat = New DevExpress.Utils.PointFloat(505.9584!, 487.6251!)
        Me.XrLabel64.Name = "XrLabel64"
        Me.XrLabel64.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel64.SizeF = New System.Drawing.SizeF(17.00003!, 18.0!)
        Me.XrLabel64.StylePriority.UseFont = False
        Me.XrLabel64.StylePriority.UseTextAlignment = False
        Me.XrLabel64.Text = "$"
        Me.XrLabel64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel67
        '
        Me.XrLabel67.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel67.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel67.LocationFloat = New DevExpress.Utils.PointFloat(522.9584!, 487.6251!)
        Me.XrLabel67.Name = "XrLabel67"
        Me.XrLabel67.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel67.SizeF = New System.Drawing.SizeF(95.00006!, 17.99988!)
        Me.XrLabel67.StylePriority.UseBorders = False
        Me.XrLabel67.StylePriority.UseFont = False
        Me.XrLabel67.StylePriority.UseTextAlignment = False
        Me.XrLabel67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel71
        '
        Me.XrLabel71.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel71.LocationFloat = New DevExpress.Utils.PointFloat(635.2082!, 487.6251!)
        Me.XrLabel71.Name = "XrLabel71"
        Me.XrLabel71.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel71.SizeF = New System.Drawing.SizeF(15.04169!, 18.0!)
        Me.XrLabel71.StylePriority.UseFont = False
        Me.XrLabel71.StylePriority.UseTextAlignment = False
        Me.XrLabel71.Text = "$"
        Me.XrLabel71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrEstaLiquidacionTOTAL
        '
        Me.xrEstaLiquidacionTOTAL.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.xrEstaLiquidacionTOTAL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrEstaLiquidacionTOTAL.LocationFloat = New DevExpress.Utils.PointFloat(650.7917!, 487.6252!)
        Me.xrEstaLiquidacionTOTAL.Name = "xrEstaLiquidacionTOTAL"
        Me.xrEstaLiquidacionTOTAL.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrEstaLiquidacionTOTAL.SizeF = New System.Drawing.SizeF(100.2082!, 18.0!)
        Me.xrEstaLiquidacionTOTAL.StylePriority.UseBorders = False
        Me.xrEstaLiquidacionTOTAL.StylePriority.UseFont = False
        Me.xrEstaLiquidacionTOTAL.StylePriority.UseTextAlignment = False
        Me.xrEstaLiquidacionTOTAL.Text = "[MONTO_LIQUIDADO!#,##0.00]"
        Me.xrEstaLiquidacionTOTAL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel76
        '
        Me.XrLabel76.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel76.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel76.LocationFloat = New DevExpress.Utils.PointFloat(368.4999!, 508.625!)
        Me.XrLabel76.Name = "XrLabel76"
        Me.XrLabel76.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel76.SizeF = New System.Drawing.SizeF(17.95847!, 18.0!)
        Me.XrLabel76.StylePriority.UseBorders = False
        Me.XrLabel76.StylePriority.UseFont = False
        Me.XrLabel76.StylePriority.UseTextAlignment = False
        Me.XrLabel76.Text = "$"
        Me.XrLabel76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrNuevoSaldoPendienteFISDL
        '
        Me.xrNuevoSaldoPendienteFISDL.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.xrNuevoSaldoPendienteFISDL.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrNuevoSaldoPendienteFISDL.LocationFloat = New DevExpress.Utils.PointFloat(386.4584!, 508.625!)
        Me.xrNuevoSaldoPendienteFISDL.Name = "xrNuevoSaldoPendienteFISDL"
        Me.xrNuevoSaldoPendienteFISDL.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrNuevoSaldoPendienteFISDL.SizeF = New System.Drawing.SizeF(102.7501!, 18.0!)
        Me.xrNuevoSaldoPendienteFISDL.StylePriority.UseBorders = False
        Me.xrNuevoSaldoPendienteFISDL.StylePriority.UseFont = False
        Me.xrNuevoSaldoPendienteFISDL.StylePriority.UseTextAlignment = False
        Me.xrNuevoSaldoPendienteFISDL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel78
        '
        Me.XrLabel78.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel78.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel78.LocationFloat = New DevExpress.Utils.PointFloat(368.4999!, 527.5!)
        Me.XrLabel78.Name = "XrLabel78"
        Me.XrLabel78.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel78.SizeF = New System.Drawing.SizeF(120.7085!, 4.0!)
        Me.XrLabel78.StylePriority.UseBorders = False
        Me.XrLabel78.StylePriority.UseFont = False
        Me.XrLabel78.StylePriority.UseTextAlignment = False
        Me.XrLabel78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel77
        '
        Me.XrLabel77.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel77.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel77.LocationFloat = New DevExpress.Utils.PointFloat(505.9167!, 508.625!)
        Me.XrLabel77.Name = "XrLabel77"
        Me.XrLabel77.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel77.SizeF = New System.Drawing.SizeF(17.04178!, 18.00003!)
        Me.XrLabel77.StylePriority.UseBorders = False
        Me.XrLabel77.StylePriority.UseFont = False
        Me.XrLabel77.StylePriority.UseTextAlignment = False
        Me.XrLabel77.Text = "$"
        Me.XrLabel77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel80
        '
        Me.XrLabel80.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel80.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel80.LocationFloat = New DevExpress.Utils.PointFloat(635.2082!, 508.625!)
        Me.XrLabel80.Name = "XrLabel80"
        Me.XrLabel80.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel80.SizeF = New System.Drawing.SizeF(15.04169!, 18.0!)
        Me.XrLabel80.StylePriority.UseBorders = False
        Me.XrLabel80.StylePriority.UseFont = False
        Me.XrLabel80.StylePriority.UseTextAlignment = False
        Me.XrLabel80.Text = "$"
        Me.XrLabel80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrNuevoSaldoPendienteTOTAL
        '
        Me.xrNuevoSaldoPendienteTOTAL.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.xrNuevoSaldoPendienteTOTAL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrNuevoSaldoPendienteTOTAL.LocationFloat = New DevExpress.Utils.PointFloat(650.7917!, 508.625!)
        Me.xrNuevoSaldoPendienteTOTAL.Name = "xrNuevoSaldoPendienteTOTAL"
        Me.xrNuevoSaldoPendienteTOTAL.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrNuevoSaldoPendienteTOTAL.SizeF = New System.Drawing.SizeF(100.2082!, 18.0!)
        Me.xrNuevoSaldoPendienteTOTAL.StylePriority.UseBorders = False
        Me.xrNuevoSaldoPendienteTOTAL.StylePriority.UseFont = False
        Me.xrNuevoSaldoPendienteTOTAL.StylePriority.UseTextAlignment = False
        Me.xrNuevoSaldoPendienteTOTAL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel82
        '
        Me.XrLabel82.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel82.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel82.LocationFloat = New DevExpress.Utils.PointFloat(505.9584!, 527.5!)
        Me.XrLabel82.Name = "XrLabel82"
        Me.XrLabel82.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel82.SizeF = New System.Drawing.SizeF(112.0!, 4.0!)
        Me.XrLabel82.StylePriority.UseBorders = False
        Me.XrLabel82.StylePriority.UseFont = False
        Me.XrLabel82.StylePriority.UseTextAlignment = False
        Me.XrLabel82.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel83
        '
        Me.XrLabel83.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel83.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel83.LocationFloat = New DevExpress.Utils.PointFloat(635.2082!, 527.5!)
        Me.XrLabel83.Name = "XrLabel83"
        Me.XrLabel83.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel83.SizeF = New System.Drawing.SizeF(115.7917!, 4.0!)
        Me.XrLabel83.StylePriority.UseBorders = False
        Me.XrLabel83.StylePriority.UseFont = False
        Me.XrLabel83.StylePriority.UseTextAlignment = False
        Me.XrLabel83.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel84
        '
        Me.XrLabel84.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrLabel84.LocationFloat = New DevExpress.Utils.PointFloat(21.87513!, 541.6249!)
        Me.XrLabel84.Name = "XrLabel84"
        Me.XrLabel84.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel84.SizeF = New System.Drawing.SizeF(18.0!, 23.0!)
        Me.XrLabel84.StylePriority.UseFont = False
        Me.XrLabel84.StylePriority.UseTextAlignment = False
        Me.XrLabel84.Text = "B."
        Me.XrLabel84.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel85
        '
        Me.XrLabel85.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel85.LocationFloat = New DevExpress.Utils.PointFloat(51.04162!, 541.6249!)
        Me.XrLabel85.Name = "XrLabel85"
        Me.XrLabel85.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel85.SizeF = New System.Drawing.SizeF(293.5002!, 23.0!)
        Me.XrLabel85.StylePriority.UseFont = False
        Me.XrLabel85.StylePriority.UseTextAlignment = False
        Me.XrLabel85.Text = "EGRESOS"
        Me.XrLabel85.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel86
        '
        Me.XrLabel86.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel86.LocationFloat = New DevExpress.Utils.PointFloat(51.04167!, 571.625!)
        Me.XrLabel86.Name = "XrLabel86"
        Me.XrLabel86.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel86.SizeF = New System.Drawing.SizeF(293.5002!, 18.0!)
        Me.XrLabel86.StylePriority.UseFont = False
        Me.XrLabel86.StylePriority.UseTextAlignment = False
        Me.XrLabel86.Text = "Servicios Profesionales para PPL"
        Me.XrLabel86.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel87
        '
        Me.XrLabel87.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel87.LocationFloat = New DevExpress.Utils.PointFloat(51.04167!, 592.6249!)
        Me.XrLabel87.Name = "XrLabel87"
        Me.XrLabel87.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel87.SizeF = New System.Drawing.SizeF(293.5002!, 18.0!)
        Me.XrLabel87.StylePriority.UseFont = False
        Me.XrLabel87.StylePriority.UseTextAlignment = False
        Me.XrLabel87.Text = "Servicios Profesionales de Auditoría Social"
        Me.XrLabel87.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel89
        '
        Me.XrLabel89.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel89.LocationFloat = New DevExpress.Utils.PointFloat(51.04162!, 634.625!)
        Me.XrLabel89.Name = "XrLabel89"
        Me.XrLabel89.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel89.SizeF = New System.Drawing.SizeF(311.5416!, 18.0!)
        Me.XrLabel89.StylePriority.UseFont = False
        Me.XrLabel89.StylePriority.UseTextAlignment = False
        Me.XrLabel89.Text = "Servicios de Capacitación"
        Me.XrLabel89.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel90
        '
        Me.XrLabel90.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel90.LocationFloat = New DevExpress.Utils.PointFloat(51.04162!, 655.625!)
        Me.XrLabel90.Name = "XrLabel90"
        Me.XrLabel90.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel90.SizeF = New System.Drawing.SizeF(311.5415!, 18.0!)
        Me.XrLabel90.StylePriority.UseFont = False
        Me.XrLabel90.StylePriority.UseTextAlignment = False
        Me.XrLabel90.Text = "Equipo de Computación y Software"
        Me.XrLabel90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel91
        '
        Me.XrLabel91.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel91.LocationFloat = New DevExpress.Utils.PointFloat(51.04162!, 676.6249!)
        Me.XrLabel91.Name = "XrLabel91"
        Me.XrLabel91.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel91.SizeF = New System.Drawing.SizeF(153.0!, 18.0!)
        Me.XrLabel91.StylePriority.UseFont = False
        Me.XrLabel91.StylePriority.UseTextAlignment = False
        Me.XrLabel91.Text = "Otros Servicios Profesionales"
        Me.XrLabel91.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel92
        '
        Me.XrLabel92.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel92.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel92.LocationFloat = New DevExpress.Utils.PointFloat(204.0416!, 692.6249!)
        Me.XrLabel92.Name = "XrLabel92"
        Me.XrLabel92.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel92.SizeF = New System.Drawing.SizeF(158.5416!, 2.0!)
        Me.XrLabel92.StylePriority.UseBorders = False
        Me.XrLabel92.StylePriority.UseFont = False
        Me.XrLabel92.StylePriority.UseTextAlignment = False
        Me.XrLabel92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel94
        '
        Me.XrLabel94.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel94.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel94.LocationFloat = New DevExpress.Utils.PointFloat(368.5!, 571.625!)
        Me.XrLabel94.Name = "XrLabel94"
        Me.XrLabel94.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel94.SizeF = New System.Drawing.SizeF(17.95847!, 18.0!)
        Me.XrLabel94.StylePriority.UseBorders = False
        Me.XrLabel94.StylePriority.UseFont = False
        Me.XrLabel94.StylePriority.UseTextAlignment = False
        Me.XrLabel94.Text = "$"
        Me.XrLabel94.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel95
        '
        Me.XrLabel95.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel95.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel95.LocationFloat = New DevExpress.Utils.PointFloat(386.4584!, 571.6251!)
        Me.XrLabel95.Name = "XrLabel95"
        Me.XrLabel95.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel95.SizeF = New System.Drawing.SizeF(102.7501!, 18.0!)
        Me.XrLabel95.StylePriority.UseBorders = False
        Me.XrLabel95.StylePriority.UseFont = False
        Me.XrLabel95.StylePriority.UseTextAlignment = False
        Me.XrLabel95.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel96
        '
        Me.XrLabel96.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel96.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel96.LocationFloat = New DevExpress.Utils.PointFloat(505.9584!, 571.625!)
        Me.XrLabel96.Name = "XrLabel96"
        Me.XrLabel96.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel96.SizeF = New System.Drawing.SizeF(17.00003!, 18.0!)
        Me.XrLabel96.StylePriority.UseBorders = False
        Me.XrLabel96.StylePriority.UseFont = False
        Me.XrLabel96.StylePriority.UseTextAlignment = False
        Me.XrLabel96.Text = "$"
        Me.XrLabel96.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel98
        '
        Me.XrLabel98.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel98.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel98.LocationFloat = New DevExpress.Utils.PointFloat(635.2082!, 571.6251!)
        Me.XrLabel98.Name = "XrLabel98"
        Me.XrLabel98.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel98.SizeF = New System.Drawing.SizeF(15.04169!, 18.0!)
        Me.XrLabel98.StylePriority.UseBorders = False
        Me.XrLabel98.StylePriority.UseFont = False
        Me.XrLabel98.StylePriority.UseTextAlignment = False
        Me.XrLabel98.Text = "$"
        Me.XrLabel98.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel99
        '
        Me.XrLabel99.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel99.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel99.LocationFloat = New DevExpress.Utils.PointFloat(650.7917!, 571.625!)
        Me.XrLabel99.Name = "XrLabel99"
        Me.XrLabel99.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel99.SizeF = New System.Drawing.SizeF(100.2082!, 18.0!)
        Me.XrLabel99.StylePriority.UseBorders = False
        Me.XrLabel99.StylePriority.UseFont = False
        Me.XrLabel99.StylePriority.UseTextAlignment = False
        Me.XrLabel99.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel100
        '
        Me.XrLabel100.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel100.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel100.LocationFloat = New DevExpress.Utils.PointFloat(368.4999!, 592.6249!)
        Me.XrLabel100.Name = "XrLabel100"
        Me.XrLabel100.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel100.SizeF = New System.Drawing.SizeF(17.95847!, 18.0!)
        Me.XrLabel100.StylePriority.UseBorders = False
        Me.XrLabel100.StylePriority.UseFont = False
        Me.XrLabel100.StylePriority.UseTextAlignment = False
        Me.XrLabel100.Text = "$"
        Me.XrLabel100.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel101
        '
        Me.XrLabel101.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel101.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel101.LocationFloat = New DevExpress.Utils.PointFloat(386.4584!, 592.6249!)
        Me.XrLabel101.Name = "XrLabel101"
        Me.XrLabel101.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel101.SizeF = New System.Drawing.SizeF(102.7501!, 18.0!)
        Me.XrLabel101.StylePriority.UseBorders = False
        Me.XrLabel101.StylePriority.UseFont = False
        Me.XrLabel101.StylePriority.UseTextAlignment = False
        Me.XrLabel101.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel102
        '
        Me.XrLabel102.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel102.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel102.LocationFloat = New DevExpress.Utils.PointFloat(505.9584!, 592.6249!)
        Me.XrLabel102.Name = "XrLabel102"
        Me.XrLabel102.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel102.SizeF = New System.Drawing.SizeF(17.00003!, 18.0!)
        Me.XrLabel102.StylePriority.UseBorders = False
        Me.XrLabel102.StylePriority.UseFont = False
        Me.XrLabel102.StylePriority.UseTextAlignment = False
        Me.XrLabel102.Text = "$"
        Me.XrLabel102.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel103
        '
        Me.XrLabel103.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel103.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel103.LocationFloat = New DevExpress.Utils.PointFloat(522.9583!, 592.6252!)
        Me.XrLabel103.Name = "XrLabel103"
        Me.XrLabel103.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel103.SizeF = New System.Drawing.SizeF(95.00006!, 17.99994!)
        Me.XrLabel103.StylePriority.UseBorders = False
        Me.XrLabel103.StylePriority.UseFont = False
        Me.XrLabel103.StylePriority.UseTextAlignment = False
        Me.XrLabel103.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel104
        '
        Me.XrLabel104.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel104.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel104.LocationFloat = New DevExpress.Utils.PointFloat(635.2082!, 592.6249!)
        Me.XrLabel104.Name = "XrLabel104"
        Me.XrLabel104.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel104.SizeF = New System.Drawing.SizeF(15.04169!, 18.0!)
        Me.XrLabel104.StylePriority.UseBorders = False
        Me.XrLabel104.StylePriority.UseFont = False
        Me.XrLabel104.StylePriority.UseTextAlignment = False
        Me.XrLabel104.Text = "$"
        Me.XrLabel104.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel105
        '
        Me.XrLabel105.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel105.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel105.LocationFloat = New DevExpress.Utils.PointFloat(522.9584!, 508.625!)
        Me.XrLabel105.Name = "XrLabel105"
        Me.XrLabel105.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel105.SizeF = New System.Drawing.SizeF(95.0!, 18.00003!)
        Me.XrLabel105.StylePriority.UseBorders = False
        Me.XrLabel105.StylePriority.UseFont = False
        Me.XrLabel105.StylePriority.UseTextAlignment = False
        Me.XrLabel105.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel106
        '
        Me.XrLabel106.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel106.LocationFloat = New DevExpress.Utils.PointFloat(344.5419!, 150.2083!)
        Me.XrLabel106.Name = "XrLabel106"
        Me.XrLabel106.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel106.SizeF = New System.Drawing.SizeF(192.3748!, 18.0!)
        Me.XrLabel106.StylePriority.UseFont = False
        Me.XrLabel106.StylePriority.UseTextAlignment = False
        Me.XrLabel106.Text = "[NOMBRE_MUNICIPIO]"
        Me.XrLabel106.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel107
        '
        Me.XrLabel107.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel107.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel107.LocationFloat = New DevExpress.Utils.PointFloat(368.5!, 613.6251!)
        Me.XrLabel107.Name = "XrLabel107"
        Me.XrLabel107.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel107.SizeF = New System.Drawing.SizeF(17.95847!, 18.0!)
        Me.XrLabel107.StylePriority.UseBorders = False
        Me.XrLabel107.StylePriority.UseFont = False
        Me.XrLabel107.StylePriority.UseTextAlignment = False
        Me.XrLabel107.Text = "$"
        Me.XrLabel107.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel108
        '
        Me.XrLabel108.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel108.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel108.LocationFloat = New DevExpress.Utils.PointFloat(386.4584!, 613.6251!)
        Me.XrLabel108.Name = "XrLabel108"
        Me.XrLabel108.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel108.SizeF = New System.Drawing.SizeF(102.7501!, 18.0!)
        Me.XrLabel108.StylePriority.UseBorders = False
        Me.XrLabel108.StylePriority.UseFont = False
        Me.XrLabel108.StylePriority.UseTextAlignment = False
        Me.XrLabel108.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel110
        '
        Me.XrLabel110.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel110.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel110.LocationFloat = New DevExpress.Utils.PointFloat(522.9583!, 613.6251!)
        Me.XrLabel110.Name = "XrLabel110"
        Me.XrLabel110.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel110.SizeF = New System.Drawing.SizeF(95.00006!, 18.0!)
        Me.XrLabel110.StylePriority.UseBorders = False
        Me.XrLabel110.StylePriority.UseFont = False
        Me.XrLabel110.StylePriority.UseTextAlignment = False
        Me.XrLabel110.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel111
        '
        Me.XrLabel111.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel111.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel111.LocationFloat = New DevExpress.Utils.PointFloat(635.2082!, 613.6251!)
        Me.XrLabel111.Name = "XrLabel111"
        Me.XrLabel111.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel111.SizeF = New System.Drawing.SizeF(15.04169!, 18.0!)
        Me.XrLabel111.StylePriority.UseBorders = False
        Me.XrLabel111.StylePriority.UseFont = False
        Me.XrLabel111.StylePriority.UseTextAlignment = False
        Me.XrLabel111.Text = "$"
        Me.XrLabel111.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel112
        '
        Me.XrLabel112.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel112.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel112.LocationFloat = New DevExpress.Utils.PointFloat(650.7917!, 613.6251!)
        Me.XrLabel112.Name = "XrLabel112"
        Me.XrLabel112.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel112.SizeF = New System.Drawing.SizeF(100.2082!, 18.0!)
        Me.XrLabel112.StylePriority.UseBorders = False
        Me.XrLabel112.StylePriority.UseFont = False
        Me.XrLabel112.StylePriority.UseTextAlignment = False
        Me.XrLabel112.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel113
        '
        Me.XrLabel113.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel113.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel113.LocationFloat = New DevExpress.Utils.PointFloat(368.5!, 634.6249!)
        Me.XrLabel113.Name = "XrLabel113"
        Me.XrLabel113.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel113.SizeF = New System.Drawing.SizeF(17.95847!, 18.0!)
        Me.XrLabel113.StylePriority.UseBorders = False
        Me.XrLabel113.StylePriority.UseFont = False
        Me.XrLabel113.StylePriority.UseTextAlignment = False
        Me.XrLabel113.Text = "$"
        Me.XrLabel113.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrServiciosCapacitacionFISDL
        '
        Me.xrServiciosCapacitacionFISDL.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrServiciosCapacitacionFISDL.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrServiciosCapacitacionFISDL.LocationFloat = New DevExpress.Utils.PointFloat(386.4584!, 634.6249!)
        Me.xrServiciosCapacitacionFISDL.Name = "xrServiciosCapacitacionFISDL"
        Me.xrServiciosCapacitacionFISDL.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrServiciosCapacitacionFISDL.SizeF = New System.Drawing.SizeF(102.7501!, 18.0!)
        Me.xrServiciosCapacitacionFISDL.StylePriority.UseBorders = False
        Me.xrServiciosCapacitacionFISDL.StylePriority.UseFont = False
        Me.xrServiciosCapacitacionFISDL.StylePriority.UseTextAlignment = False
        Me.xrServiciosCapacitacionFISDL.Text = "[MONTO_LIQUIDADO!#,##0.00]"
        Me.xrServiciosCapacitacionFISDL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel115
        '
        Me.XrLabel115.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel115.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel115.LocationFloat = New DevExpress.Utils.PointFloat(505.9584!, 634.6249!)
        Me.XrLabel115.Name = "XrLabel115"
        Me.XrLabel115.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel115.SizeF = New System.Drawing.SizeF(17.00003!, 18.0!)
        Me.XrLabel115.StylePriority.UseBorders = False
        Me.XrLabel115.StylePriority.UseFont = False
        Me.XrLabel115.StylePriority.UseTextAlignment = False
        Me.XrLabel115.Text = "$"
        Me.XrLabel115.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel116
        '
        Me.XrLabel116.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel116.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel116.LocationFloat = New DevExpress.Utils.PointFloat(522.9584!, 634.625!)
        Me.XrLabel116.Name = "XrLabel116"
        Me.XrLabel116.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel116.SizeF = New System.Drawing.SizeF(95.0!, 18.0!)
        Me.XrLabel116.StylePriority.UseBorders = False
        Me.XrLabel116.StylePriority.UseFont = False
        Me.XrLabel116.StylePriority.UseTextAlignment = False
        Me.XrLabel116.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'xrServiciosCapacitacionTOTAL
        '
        Me.xrServiciosCapacitacionTOTAL.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrServiciosCapacitacionTOTAL.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrServiciosCapacitacionTOTAL.LocationFloat = New DevExpress.Utils.PointFloat(650.7917!, 634.6251!)
        Me.xrServiciosCapacitacionTOTAL.Name = "xrServiciosCapacitacionTOTAL"
        Me.xrServiciosCapacitacionTOTAL.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrServiciosCapacitacionTOTAL.SizeF = New System.Drawing.SizeF(100.2082!, 18.0!)
        Me.xrServiciosCapacitacionTOTAL.StylePriority.UseBorders = False
        Me.xrServiciosCapacitacionTOTAL.StylePriority.UseFont = False
        Me.xrServiciosCapacitacionTOTAL.StylePriority.UseTextAlignment = False
        Me.xrServiciosCapacitacionTOTAL.Text = "[MONTO_LIQUIDADO!#,##0.00]"
        Me.xrServiciosCapacitacionTOTAL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel114
        '
        Me.XrLabel114.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel114.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel114.LocationFloat = New DevExpress.Utils.PointFloat(368.5!, 655.6249!)
        Me.XrLabel114.Name = "XrLabel114"
        Me.XrLabel114.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel114.SizeF = New System.Drawing.SizeF(17.95847!, 18.0!)
        Me.XrLabel114.StylePriority.UseBorders = False
        Me.XrLabel114.StylePriority.UseFont = False
        Me.XrLabel114.StylePriority.UseTextAlignment = False
        Me.XrLabel114.Text = "$"
        Me.XrLabel114.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel118
        '
        Me.XrLabel118.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel118.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel118.LocationFloat = New DevExpress.Utils.PointFloat(386.4584!, 655.6251!)
        Me.XrLabel118.Name = "XrLabel118"
        Me.XrLabel118.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel118.SizeF = New System.Drawing.SizeF(102.7501!, 18.0!)
        Me.XrLabel118.StylePriority.UseBorders = False
        Me.XrLabel118.StylePriority.UseFont = False
        Me.XrLabel118.StylePriority.UseTextAlignment = False
        Me.XrLabel118.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel119
        '
        Me.XrLabel119.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel119.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel119.LocationFloat = New DevExpress.Utils.PointFloat(505.9584!, 655.6251!)
        Me.XrLabel119.Name = "XrLabel119"
        Me.XrLabel119.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel119.SizeF = New System.Drawing.SizeF(17.00003!, 18.0!)
        Me.XrLabel119.StylePriority.UseBorders = False
        Me.XrLabel119.StylePriority.UseFont = False
        Me.XrLabel119.StylePriority.UseTextAlignment = False
        Me.XrLabel119.Text = "$"
        Me.XrLabel119.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel120
        '
        Me.XrLabel120.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel120.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel120.LocationFloat = New DevExpress.Utils.PointFloat(522.9584!, 655.6251!)
        Me.XrLabel120.Name = "XrLabel120"
        Me.XrLabel120.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel120.SizeF = New System.Drawing.SizeF(95.0!, 18.0!)
        Me.XrLabel120.StylePriority.UseBorders = False
        Me.XrLabel120.StylePriority.UseFont = False
        Me.XrLabel120.StylePriority.UseTextAlignment = False
        Me.XrLabel120.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel121
        '
        Me.XrLabel121.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel121.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel121.LocationFloat = New DevExpress.Utils.PointFloat(635.2082!, 655.6251!)
        Me.XrLabel121.Name = "XrLabel121"
        Me.XrLabel121.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel121.SizeF = New System.Drawing.SizeF(15.04169!, 18.0!)
        Me.XrLabel121.StylePriority.UseBorders = False
        Me.XrLabel121.StylePriority.UseFont = False
        Me.XrLabel121.StylePriority.UseTextAlignment = False
        Me.XrLabel121.Text = "$"
        Me.XrLabel121.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel123
        '
        Me.XrLabel123.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel123.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel123.LocationFloat = New DevExpress.Utils.PointFloat(368.5!, 676.6251!)
        Me.XrLabel123.Name = "XrLabel123"
        Me.XrLabel123.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel123.SizeF = New System.Drawing.SizeF(17.95847!, 18.0!)
        Me.XrLabel123.StylePriority.UseBorders = False
        Me.XrLabel123.StylePriority.UseFont = False
        Me.XrLabel123.StylePriority.UseTextAlignment = False
        Me.XrLabel123.Text = "$"
        Me.XrLabel123.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel124
        '
        Me.XrLabel124.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel124.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel124.LocationFloat = New DevExpress.Utils.PointFloat(386.4584!, 676.6251!)
        Me.XrLabel124.Name = "XrLabel124"
        Me.XrLabel124.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel124.SizeF = New System.Drawing.SizeF(102.7501!, 18.0!)
        Me.XrLabel124.StylePriority.UseBorders = False
        Me.XrLabel124.StylePriority.UseFont = False
        Me.XrLabel124.StylePriority.UseTextAlignment = False
        Me.XrLabel124.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel125
        '
        Me.XrLabel125.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel125.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel125.LocationFloat = New DevExpress.Utils.PointFloat(505.9584!, 676.6251!)
        Me.XrLabel125.Name = "XrLabel125"
        Me.XrLabel125.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel125.SizeF = New System.Drawing.SizeF(17.00003!, 18.0!)
        Me.XrLabel125.StylePriority.UseBorders = False
        Me.XrLabel125.StylePriority.UseFont = False
        Me.XrLabel125.StylePriority.UseTextAlignment = False
        Me.XrLabel125.Text = "$"
        Me.XrLabel125.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel126
        '
        Me.XrLabel126.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel126.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel126.LocationFloat = New DevExpress.Utils.PointFloat(522.9584!, 676.6251!)
        Me.XrLabel126.Name = "XrLabel126"
        Me.XrLabel126.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel126.SizeF = New System.Drawing.SizeF(95.0!, 18.0!)
        Me.XrLabel126.StylePriority.UseBorders = False
        Me.XrLabel126.StylePriority.UseFont = False
        Me.XrLabel126.StylePriority.UseTextAlignment = False
        Me.XrLabel126.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel127
        '
        Me.XrLabel127.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel127.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel127.LocationFloat = New DevExpress.Utils.PointFloat(635.2082!, 676.6249!)
        Me.XrLabel127.Name = "XrLabel127"
        Me.XrLabel127.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel127.SizeF = New System.Drawing.SizeF(15.04169!, 18.0!)
        Me.XrLabel127.StylePriority.UseBorders = False
        Me.XrLabel127.StylePriority.UseFont = False
        Me.XrLabel127.StylePriority.UseTextAlignment = False
        Me.XrLabel127.Text = "$"
        Me.XrLabel127.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel128
        '
        Me.XrLabel128.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel128.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel128.LocationFloat = New DevExpress.Utils.PointFloat(650.7918!, 676.6251!)
        Me.XrLabel128.Name = "XrLabel128"
        Me.XrLabel128.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel128.SizeF = New System.Drawing.SizeF(100.2081!, 18.0!)
        Me.XrLabel128.StylePriority.UseBorders = False
        Me.XrLabel128.StylePriority.UseFont = False
        Me.XrLabel128.StylePriority.UseTextAlignment = False
        Me.XrLabel128.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel129
        '
        Me.XrLabel129.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel129.LocationFloat = New DevExpress.Utils.PointFloat(51.04167!, 715.875!)
        Me.XrLabel129.Name = "XrLabel129"
        Me.XrLabel129.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel129.SizeF = New System.Drawing.SizeF(293.5002!, 23.0!)
        Me.XrLabel129.StylePriority.UseFont = False
        Me.XrLabel129.StylePriority.UseTextAlignment = False
        Me.XrLabel129.Text = "TOTAL LIQUIDACION"
        Me.XrLabel129.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel130
        '
        Me.XrLabel130.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel130.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel130.LocationFloat = New DevExpress.Utils.PointFloat(368.5!, 715.875!)
        Me.XrLabel130.Name = "XrLabel130"
        Me.XrLabel130.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel130.SizeF = New System.Drawing.SizeF(17.95847!, 18.0!)
        Me.XrLabel130.StylePriority.UseBorders = False
        Me.XrLabel130.StylePriority.UseFont = False
        Me.XrLabel130.StylePriority.UseTextAlignment = False
        Me.XrLabel130.Text = "$"
        Me.XrLabel130.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrTotalLiquidacionFISDL
        '
        Me.xrTotalLiquidacionFISDL.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.xrTotalLiquidacionFISDL.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrTotalLiquidacionFISDL.LocationFloat = New DevExpress.Utils.PointFloat(386.4585!, 715.8749!)
        Me.xrTotalLiquidacionFISDL.Name = "xrTotalLiquidacionFISDL"
        Me.xrTotalLiquidacionFISDL.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrTotalLiquidacionFISDL.SizeF = New System.Drawing.SizeF(102.7501!, 18.0!)
        Me.xrTotalLiquidacionFISDL.StylePriority.UseBorders = False
        Me.xrTotalLiquidacionFISDL.StylePriority.UseFont = False
        Me.xrTotalLiquidacionFISDL.StylePriority.UseTextAlignment = False
        Me.xrTotalLiquidacionFISDL.Text = "[MONTO_LIQUIDADO!#,##0.00]"
        Me.xrTotalLiquidacionFISDL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel132
        '
        Me.XrLabel132.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel132.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel132.LocationFloat = New DevExpress.Utils.PointFloat(368.5!, 734.875!)
        Me.XrLabel132.Name = "XrLabel132"
        Me.XrLabel132.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel132.SizeF = New System.Drawing.SizeF(120.7085!, 4.0!)
        Me.XrLabel132.StylePriority.UseBorders = False
        Me.XrLabel132.StylePriority.UseFont = False
        Me.XrLabel132.StylePriority.UseTextAlignment = False
        Me.XrLabel132.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel131
        '
        Me.XrLabel131.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel131.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel131.LocationFloat = New DevExpress.Utils.PointFloat(490.2085!, 705.8749!)
        Me.XrLabel131.Name = "XrLabel131"
        Me.XrLabel131.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel131.SizeF = New System.Drawing.SizeF(15.0!, 28.0!)
        Me.XrLabel131.StylePriority.UseBorders = False
        Me.XrLabel131.StylePriority.UseFont = False
        Me.XrLabel131.StylePriority.UseTextAlignment = False
        Me.XrLabel131.Text = "%"
        Me.XrLabel131.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel133
        '
        Me.XrLabel133.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel133.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel133.LocationFloat = New DevExpress.Utils.PointFloat(505.9584!, 715.8749!)
        Me.XrLabel133.Name = "XrLabel133"
        Me.XrLabel133.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel133.SizeF = New System.Drawing.SizeF(17.00003!, 18.0!)
        Me.XrLabel133.StylePriority.UseBorders = False
        Me.XrLabel133.StylePriority.UseFont = False
        Me.XrLabel133.StylePriority.UseTextAlignment = False
        Me.XrLabel133.Text = "$"
        Me.XrLabel133.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel134
        '
        Me.XrLabel134.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel134.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel134.LocationFloat = New DevExpress.Utils.PointFloat(522.9584!, 715.8749!)
        Me.XrLabel134.Name = "XrLabel134"
        Me.XrLabel134.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel134.SizeF = New System.Drawing.SizeF(95.0!, 18.0!)
        Me.XrLabel134.StylePriority.UseBorders = False
        Me.XrLabel134.StylePriority.UseFont = False
        Me.XrLabel134.StylePriority.UseTextAlignment = False
        Me.XrLabel134.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel136
        '
        Me.XrLabel136.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel136.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel136.LocationFloat = New DevExpress.Utils.PointFloat(505.9584!, 734.875!)
        Me.XrLabel136.Name = "XrLabel136"
        Me.XrLabel136.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel136.SizeF = New System.Drawing.SizeF(112.0!, 4.0!)
        Me.XrLabel136.StylePriority.UseBorders = False
        Me.XrLabel136.StylePriority.UseFont = False
        Me.XrLabel136.StylePriority.UseTextAlignment = False
        Me.XrLabel136.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel137
        '
        Me.XrLabel137.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel137.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel137.LocationFloat = New DevExpress.Utils.PointFloat(635.2082!, 715.8749!)
        Me.XrLabel137.Name = "XrLabel137"
        Me.XrLabel137.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel137.SizeF = New System.Drawing.SizeF(15.04169!, 18.0!)
        Me.XrLabel137.StylePriority.UseBorders = False
        Me.XrLabel137.StylePriority.UseFont = False
        Me.XrLabel137.StylePriority.UseTextAlignment = False
        Me.XrLabel137.Text = "$"
        Me.XrLabel137.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrTotalLiquidacionTOTAL
        '
        Me.xrTotalLiquidacionTOTAL.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.xrTotalLiquidacionTOTAL.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrTotalLiquidacionTOTAL.LocationFloat = New DevExpress.Utils.PointFloat(650.7919!, 715.8749!)
        Me.xrTotalLiquidacionTOTAL.Name = "xrTotalLiquidacionTOTAL"
        Me.xrTotalLiquidacionTOTAL.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrTotalLiquidacionTOTAL.SizeF = New System.Drawing.SizeF(100.2081!, 18.0!)
        Me.xrTotalLiquidacionTOTAL.StylePriority.UseBorders = False
        Me.xrTotalLiquidacionTOTAL.StylePriority.UseFont = False
        Me.xrTotalLiquidacionTOTAL.StylePriority.UseTextAlignment = False
        Me.xrTotalLiquidacionTOTAL.Text = "[MONTO_LIQUIDADO!#,##0.00]"
        Me.xrTotalLiquidacionTOTAL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel138
        '
        Me.XrLabel138.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrLabel138.LocationFloat = New DevExpress.Utils.PointFloat(21.87513!, 749.9583!)
        Me.XrLabel138.Name = "XrLabel138"
        Me.XrLabel138.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel138.SizeF = New System.Drawing.SizeF(18.0!, 23.0!)
        Me.XrLabel138.StylePriority.UseFont = False
        Me.XrLabel138.StylePriority.UseTextAlignment = False
        Me.XrLabel138.Text = "C."
        Me.XrLabel138.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel140
        '
        Me.XrLabel140.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel140.LocationFloat = New DevExpress.Utils.PointFloat(51.04162!, 749.9583!)
        Me.XrLabel140.Name = "XrLabel140"
        Me.XrLabel140.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel140.SizeF = New System.Drawing.SizeF(293.5002!, 23.0!)
        Me.XrLabel140.StylePriority.UseFont = False
        Me.XrLabel140.StylePriority.UseTextAlignment = False
        Me.XrLabel140.Text = "Aporte Comunal"
        Me.XrLabel140.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel141
        '
        Me.XrLabel141.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel141.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel141.LocationFloat = New DevExpress.Utils.PointFloat(635.2082!, 749.9583!)
        Me.XrLabel141.Name = "XrLabel141"
        Me.XrLabel141.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel141.SizeF = New System.Drawing.SizeF(15.04169!, 18.0!)
        Me.XrLabel141.StylePriority.UseBorders = False
        Me.XrLabel141.StylePriority.UseFont = False
        Me.XrLabel141.StylePriority.UseTextAlignment = False
        Me.XrLabel141.Text = "$"
        Me.XrLabel141.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel157
        '
        Me.XrLabel157.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel157.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel157.LocationFloat = New DevExpress.Utils.PointFloat(549.4167!, 168.2083!)
        Me.XrLabel157.Name = "XrLabel157"
        Me.XrLabel157.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel157.SizeF = New System.Drawing.SizeF(198.5833!, 14.99998!)
        Me.XrLabel157.StylePriority.UseBorders = False
        Me.XrLabel157.StylePriority.UseFont = False
        Me.XrLabel157.StylePriority.UseTextAlignment = False
        Me.XrLabel157.Text = "Cantón / Caserío"
        Me.XrLabel157.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrEstaLiquidacionFISDL
        '
        Me.xrEstaLiquidacionFISDL.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrEstaLiquidacionFISDL.LocationFloat = New DevExpress.Utils.PointFloat(386.4583!, 487.625!)
        Me.xrEstaLiquidacionFISDL.Name = "xrEstaLiquidacionFISDL"
        Me.xrEstaLiquidacionFISDL.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrEstaLiquidacionFISDL.SizeF = New System.Drawing.SizeF(102.7503!, 18.00003!)
        Me.xrEstaLiquidacionFISDL.StylePriority.UseFont = False
        Me.xrEstaLiquidacionFISDL.StylePriority.UsePadding = False
        Me.xrEstaLiquidacionFISDL.StylePriority.UseTextAlignment = False
        Me.xrEstaLiquidacionFISDL.Text = "[MONTO_LIQUIDADO!#,##0.00]"
        Me.xrEstaLiquidacionFISDL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel70
        '
        Me.XrLabel70.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel70.LocationFloat = New DevExpress.Utils.PointFloat(650.7919!, 749.9583!)
        Me.XrLabel70.Name = "XrLabel70"
        Me.XrLabel70.SizeF = New System.Drawing.SizeF(100.2081!, 18.0!)
        Me.XrLabel70.StylePriority.UseBorders = False
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrLabel1})
        Me.PageHeader.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.PageHeader.HeightF = 47.0!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.StylePriority.UseFont = False
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.0001192093!, 23.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(750.9999!, 23.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "INFORME DE LIQUIDACION DE FONDOS PARA ASISTENCIA TECNICA Y CAPACITACION"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0001033147!, 0.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(750.9999!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "ANEXO No. TAF - 4A"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'ReportFooter
        '
        Me.ReportFooter.Expanded = False
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLabel156
        '
        Me.XrLabel156.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrLabel156.LocationFloat = New DevExpress.Utils.PointFloat(530.6249!, 171.1667!)
        Me.XrLabel156.Name = "XrLabel156"
        Me.XrLabel156.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel156.SizeF = New System.Drawing.SizeF(220.3751!, 18.83328!)
        Me.XrLabel156.StylePriority.UseFont = False
        Me.XrLabel156.Text = "Fecha de recibida:"
        '
        'XrLabel154
        '
        Me.XrLabel154.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel154.LocationFloat = New DevExpress.Utils.PointFloat(21.87502!, 143.75!)
        Me.XrLabel154.Name = "XrLabel154"
        Me.XrLabel154.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel154.SizeF = New System.Drawing.SizeF(50.79166!, 18.83336!)
        Me.XrLabel154.StylePriority.UseFont = False
        Me.XrLabel154.Text = "Nombre:"
        '
        'XrLabel155
        '
        Me.XrLabel155.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel155.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 168.75!)
        Me.XrLabel155.Multiline = True
        Me.XrLabel155.Name = "XrLabel155"
        Me.XrLabel155.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel155.SizeF = New System.Drawing.SizeF(209.9166!, 30.0!)
        Me.XrLabel155.StylePriority.UseFont = False
        Me.XrLabel155.Text = "Original: FISDL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Copia: INSAFORP"
        '
        'XrLabel153
        '
        Me.XrLabel153.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel153.LocationFloat = New DevExpress.Utils.PointFloat(72.66668!, 143.75!)
        Me.XrLabel153.Name = "XrLabel153"
        Me.XrLabel153.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel153.SizeF = New System.Drawing.SizeF(224.125!, 18.83336!)
        Me.XrLabel153.StylePriority.UseFont = False
        Me.XrLabel153.Text = "[ASESOR_MUNICIPAL]"
        '
        'XrLabel151
        '
        Me.XrLabel151.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel151.LocationFloat = New DevExpress.Utils.PointFloat(21.87502!, 118.75!)
        Me.XrLabel151.Name = "XrLabel151"
        Me.XrLabel151.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel151.SizeF = New System.Drawing.SizeF(209.9165!, 18.83335!)
        Me.XrLabel151.StylePriority.UseFont = False
        Me.XrLabel151.Text = "Firma:"
        '
        'XrLabel152
        '
        Me.XrLabel152.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel152.LocationFloat = New DevExpress.Utils.PointFloat(21.87502!, 93.75!)
        Me.XrLabel152.Name = "XrLabel152"
        Me.XrLabel152.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel152.SizeF = New System.Drawing.SizeF(209.9166!, 18.83335!)
        Me.XrLabel152.StylePriority.UseFont = False
        Me.XrLabel152.Text = "Asesor Municipal FISDL"
        '
        'XrLabel149
        '
        Me.XrLabel149.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLabel149.Name = "XrLabel149"
        Me.XrLabel149.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        '
        'XrLabel150
        '
        Me.XrLabel150.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel150.LocationFloat = New DevExpress.Utils.PointFloat(368.5!, 59.99997!)
        Me.XrLabel150.Name = "XrLabel150"
        Me.XrLabel150.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel150.SizeF = New System.Drawing.SizeF(50.79166!, 18.83336!)
        Me.XrLabel150.StylePriority.UseFont = False
        Me.XrLabel150.Text = "Nombre:"
        '
        'XrLabel147
        '
        Me.XrLabel147.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel147.LocationFloat = New DevExpress.Utils.PointFloat(368.4999!, 34.99997!)
        Me.XrLabel147.Name = "XrLabel147"
        Me.XrLabel147.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel147.SizeF = New System.Drawing.SizeF(209.9165!, 18.83335!)
        Me.XrLabel147.StylePriority.UseFont = False
        Me.XrLabel147.Text = "Firma:"
        '
        'XrLabel148
        '
        Me.XrLabel148.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel148.LocationFloat = New DevExpress.Utils.PointFloat(368.4999!, 9.999974!)
        Me.XrLabel148.Name = "XrLabel148"
        Me.XrLabel148.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel148.SizeF = New System.Drawing.SizeF(209.9166!, 18.83335!)
        Me.XrLabel148.StylePriority.UseFont = False
        Me.XrLabel148.Text = "Tesorero INSAFORP"
        '
        'XrLabel145
        '
        Me.XrLabel145.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLabel145.Name = "XrLabel145"
        Me.XrLabel145.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        '
        'XrLabel146
        '
        Me.XrLabel146.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel146.LocationFloat = New DevExpress.Utils.PointFloat(72.66663!, 59.99997!)
        Me.XrLabel146.Name = "XrLabel146"
        Me.XrLabel146.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel146.SizeF = New System.Drawing.SizeF(159.125!, 18.83336!)
        Me.XrLabel146.StylePriority.UseFont = False
        Me.XrLabel146.Text = "Joel Antonio Morán Olmos"
        '
        'XrLabel143
        '
        Me.XrLabel143.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel143.LocationFloat = New DevExpress.Utils.PointFloat(21.87513!, 9.999974!)
        Me.XrLabel143.Name = "XrLabel143"
        Me.XrLabel143.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel143.SizeF = New System.Drawing.SizeF(209.9166!, 18.83335!)
        Me.XrLabel143.StylePriority.UseFont = False
        Me.XrLabel143.Text = "Director Ejecutivo"
        '
        'XrLabel144
        '
        Me.XrLabel144.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel144.LocationFloat = New DevExpress.Utils.PointFloat(21.87513!, 34.99997!)
        Me.XrLabel144.Name = "XrLabel144"
        Me.XrLabel144.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel144.SizeF = New System.Drawing.SizeF(209.9165!, 18.83335!)
        Me.XrLabel144.StylePriority.UseFont = False
        Me.XrLabel144.Text = "Firma:"
        '
        'DS_DL1
        '
        Me.DS_DL1.DataSetName = "DS_DL"
        Me.DS_DL1.EnforceConstraints = False
        Me.DS_DL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnexoTAF4ATableAdapter1
        '
        Me.AnexoTAF4ATableAdapter1.ClearBeforeFill = True
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel51, Me.XrLabel122, Me.XrLabel135, Me.XrLabel109, Me.XrLabel75, Me.XrLabel97, Me.XrLabel139, Me.XrLabel165, Me.XrLabel166, Me.XrLabel167, Me.XrLabel142, Me.XrLabel163, Me.XrLabel164, Me.xrPageInfo1, Me.XrLabel168, Me.XrLabel172})
        Me.GroupFooter1.HeightF = 223.3333!
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        '
        'XrLabel51
        '
        Me.XrLabel51.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel51.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLabel51.Name = "XrLabel51"
        Me.XrLabel51.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel51.SizeF = New System.Drawing.SizeF(209.9166!, 18.83335!)
        Me.XrLabel51.StylePriority.UseFont = False
        Me.XrLabel51.Text = "Director Ejecutivo INSAFORP"
        '
        'XrLabel122
        '
        Me.XrLabel122.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel122.LocationFloat = New DevExpress.Utils.PointFloat(375.0!, 23.00008!)
        Me.XrLabel122.Name = "XrLabel122"
        Me.XrLabel122.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel122.SizeF = New System.Drawing.SizeF(209.9165!, 18.83335!)
        Me.XrLabel122.StylePriority.UseFont = False
        Me.XrLabel122.Text = "Firma:"
        '
        'XrLabel135
        '
        Me.XrLabel135.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel135.LocationFloat = New DevExpress.Utils.PointFloat(375.0!, 0.0!)
        Me.XrLabel135.Name = "XrLabel135"
        Me.XrLabel135.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel135.SizeF = New System.Drawing.SizeF(209.9166!, 18.83335!)
        Me.XrLabel135.StylePriority.UseFont = False
        Me.XrLabel135.Text = "Tesorero INSAFORP"
        '
        'XrLabel109
        '
        Me.XrLabel109.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel109.LocationFloat = New DevExpress.Utils.PointFloat(50.99999!, 47.5001!)
        Me.XrLabel109.Name = "XrLabel109"
        Me.XrLabel109.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel109.SizeF = New System.Drawing.SizeF(175.7917!, 18.83335!)
        Me.XrLabel109.StylePriority.UseFont = False
        Me.XrLabel109.Text = "Carlos Enrique Gómez Benítez"
        '
        'XrLabel75
        '
        Me.XrLabel75.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel75.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 23.00008!)
        Me.XrLabel75.Name = "XrLabel75"
        Me.XrLabel75.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel75.SizeF = New System.Drawing.SizeF(209.9165!, 18.83335!)
        Me.XrLabel75.StylePriority.UseFont = False
        Me.XrLabel75.Text = "Firma:"
        '
        'XrLabel97
        '
        Me.XrLabel97.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel97.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 47.5001!)
        Me.XrLabel97.Name = "XrLabel97"
        Me.XrLabel97.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel97.SizeF = New System.Drawing.SizeF(50.79166!, 18.83336!)
        Me.XrLabel97.StylePriority.UseFont = False
        Me.XrLabel97.Text = "Nombre:"
        '
        'XrLabel139
        '
        Me.XrLabel139.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel139.LocationFloat = New DevExpress.Utils.PointFloat(426.0!, 47.5001!)
        Me.XrLabel139.Name = "XrLabel139"
        Me.XrLabel139.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel139.SizeF = New System.Drawing.SizeF(159.125!, 18.83336!)
        Me.XrLabel139.StylePriority.UseFont = False
        Me.XrLabel139.Text = "Carlos Alfredo Quintanilla"
        '
        'XrLabel165
        '
        Me.XrLabel165.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel165.LocationFloat = New DevExpress.Utils.PointFloat(52.0!, 123.5001!)
        Me.XrLabel165.Name = "XrLabel165"
        Me.XrLabel165.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel165.SizeF = New System.Drawing.SizeF(346.9999!, 18.83342!)
        Me.XrLabel165.StylePriority.UseFont = False
        Me.XrLabel165.Text = "[ASESOR_MUNICIPAL]"
        '
        'XrLabel166
        '
        Me.XrLabel166.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel166.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 123.5001!)
        Me.XrLabel166.Name = "XrLabel166"
        Me.XrLabel166.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel166.SizeF = New System.Drawing.SizeF(50.79166!, 18.83336!)
        Me.XrLabel166.StylePriority.UseFont = False
        Me.XrLabel166.Text = "Nombre:"
        '
        'XrLabel167
        '
        Me.XrLabel167.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel167.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 146.3334!)
        Me.XrLabel167.Multiline = True
        Me.XrLabel167.Name = "XrLabel167"
        Me.XrLabel167.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel167.SizeF = New System.Drawing.SizeF(209.9166!, 30.0!)
        Me.XrLabel167.StylePriority.UseFont = False
        Me.XrLabel167.Text = "Original: FISDL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Copia: INSAFORP"
        '
        'XrLabel142
        '
        Me.XrLabel142.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel142.LocationFloat = New DevExpress.Utils.PointFloat(375.0!, 47.5001!)
        Me.XrLabel142.Name = "XrLabel142"
        Me.XrLabel142.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel142.SizeF = New System.Drawing.SizeF(50.79166!, 18.83336!)
        Me.XrLabel142.StylePriority.UseFont = False
        Me.XrLabel142.Text = "Nombre:"
        '
        'XrLabel163
        '
        Me.XrLabel163.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel163.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 100.0!)
        Me.XrLabel163.Name = "XrLabel163"
        Me.XrLabel163.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel163.SizeF = New System.Drawing.SizeF(209.9165!, 18.83335!)
        Me.XrLabel163.StylePriority.UseFont = False
        Me.XrLabel163.Text = "Firma:"
        '
        'XrLabel164
        '
        Me.XrLabel164.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel164.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 77.00005!)
        Me.XrLabel164.Name = "XrLabel164"
        Me.XrLabel164.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel164.SizeF = New System.Drawing.SizeF(209.9166!, 18.83335!)
        Me.XrLabel164.StylePriority.UseFont = False
        Me.XrLabel164.Text = "Asesor Municipal FISDL"
        '
        'xrPageInfo1
        '
        Me.xrPageInfo1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrPageInfo1.Format = "{0:'FECHA DE IMPRESIÓN: 'dd/MM/yyyy}"
        Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 191.75!)
        Me.xrPageInfo1.Name = "xrPageInfo1"
        Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(199.9583!, 18.99999!)
        Me.xrPageInfo1.StylePriority.UseFont = False
        '
        'XrLabel168
        '
        Me.XrLabel168.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrLabel168.LocationFloat = New DevExpress.Utils.PointFloat(615.7497!, 210.75!)
        Me.XrLabel168.Name = "XrLabel168"
        Me.XrLabel168.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel168.SizeF = New System.Drawing.SizeF(132.2503!, 12.58329!)
        Me.XrLabel168.StylePriority.UseBorders = False
        '
        'XrLabel172
        '
        Me.XrLabel172.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel172.LocationFloat = New DevExpress.Utils.PointFloat(465.7497!, 191.75!)
        Me.XrLabel172.Name = "XrLabel172"
        Me.XrLabel172.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel172.SizeF = New System.Drawing.SizeF(282.2503!, 18.99998!)
        Me.XrLabel172.StylePriority.UseFont = False
        Me.XrLabel172.Text = "FECHA DE RECIBIDO FISDL:"
        '
        'PageFooter
        '
        Me.PageFooter.HeightF = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'xrAnexoTAF4A
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1, Me.PageHeader, Me.ReportFooter, Me.GroupFooter1, Me.PageFooter})
        Me.DataAdapter = Me.AnexoTAF4ATableAdapter1
        Me.DataMember = "AnexoTAF4A"
        Me.DataSource = Me.DS_DL1
        Me.Margins = New System.Drawing.Printing.Margins(28, 64, 20, 24)
        Me.Version = "11.1"
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
#End Region

    Public Sub CargarLiquidacion(ByVal ID_LIQUIDACION As Decimal)
        Me.AnexoTAF4ATableAdapter1.FillByIdLiquidacion(Me.DS_DL1.AnexoTAF4A, ID_LIQUIDACION)
    End Sub

    Public Sub CargarLiquidacion(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal, ByVal FECHA_ELABORACION As Date)
        Me.AnexoTAF4ATableAdapter1.FillByFuenteConvFecha(Me.DS_DL1.AnexoTAF4A, ID_FUENTE, NO_CONVOCATORIA, FECHA_ELABORACION)
    End Sub

    Private Sub GroupHeader1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GroupHeader1.BeforePrint
        Dim lMontoLiquidadoAnteriormente As Decimal = 0
        Dim lSaldoPorLiquidar As Decimal = 0

        Dim lbMunicipioLiquidacion As New cMUNICIPIO_LIQUIDACION
        Dim lEntidad As MUNICIPIO_LIQUIDACION = lbMunicipioLiquidacion.ObtenerMUNICIPIO_LIQUIDACION(GetCurrentColumnValue("ID_LIQUIDACION"))
        If lEntidad IsNot Nothing Then
            'Obtener:   Monto liquidado anteriormente   
            Dim lListaLiquidaciones As listaMUNICIPIO_LIQUIDACION
            Dim Criterios As New List(Of Criteria)
            Criterios.Add(New Criteria("ID_FUENTE", "=", lEntidad.ID_FUENTE, "AND"))
            Criterios.Add(New Criteria("NO_CONVOCATORIA", "=", lEntidad.NO_CONVOCATORIA, "AND"))
            Criterios.Add(New Criteria("CODIGO_DEPARTAMENTO", "=", lEntidad.CODIGO_DEPARTAMENTO, "AND"))
            Criterios.Add(New Criteria("CODIGO_MUNICIPIO", "=", lEntidad.CODIGO_MUNICIPIO, "AND"))
            Criterios.Add(New Criteria("NO_LIQUIDACION", "<", lEntidad.NO_LIQUIDACION, ""))

            lListaLiquidaciones = lbMunicipioLiquidacion.ObtenerListaPorBusqueda(New MUNICIPIO_LIQUIDACION, Criterios.ToArray)
            If lListaLiquidaciones IsNot Nothing AndAlso lListaLiquidaciones.Count > 0 Then
                For Each _liquidacion As MUNICIPIO_LIQUIDACION In lListaLiquidaciones
                    lMontoLiquidadoAnteriormente += _liquidacion.MONTO_LIQUIDADO
                Next
            End If
        End If
        Me.xrLiquidadoAnteriorFISDL.Text = String.Format("{0:##,##0.00}", lMontoLiquidadoAnteriormente)
        Me.xrLiquidadoAnteriorTOTAL.Text = Me.xrLiquidadoAnteriorFISDL.Text

        'Obtener: Saldo por liquidar
        lSaldoPorLiquidar = GetCurrentColumnValue("FINANCIAMIENTO") - lMontoLiquidadoAnteriormente
        Me.xrSaldoPorLiquidarFISDL.Text = String.Format("{0:##,##0.00}", lSaldoPorLiquidar)
        Me.xrSaldoPorLiquidarTOTAL.Text = Me.xrSaldoPorLiquidarFISDL.Text

        'Nuevo saldo pendiente
        Me.xrNuevoSaldoPendienteFISDL.Text = String.Format("{0:##,##0.00}", lSaldoPorLiquidar - lEntidad.MONTO_LIQUIDADO)
        Me.xrNuevoSaldoPendienteTOTAL.Text = Me.xrNuevoSaldoPendienteFISDL.Text
    End Sub
End Class