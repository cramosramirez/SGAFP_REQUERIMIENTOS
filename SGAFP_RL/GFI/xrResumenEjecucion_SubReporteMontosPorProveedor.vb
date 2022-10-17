Imports DevExpress.XtraCharts
Imports SGAFP.DL
Imports System.Text

Public Class xrResumenEjecucion_SubReporteMontosPorProveedor
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region "  CODIGO GENERADO "

    Public Sub New()
        MyBase.New()

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
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell35 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrtcMonto_Disponible As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrtcPorc_Disponible As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell31 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents DS_DL1 As SGAFP.DL.DS_DL
    Friend WithEvents ResumenEjecucion_MontosCapacitadosTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.ResumenEjecucion_MontosCapacitadosTableAdapter
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrChart1 As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents GroupHeader3 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrTable5 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell36 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell37 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell38 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable7 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell39 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable6 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell49 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell47 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell48 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell40 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell43 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell41 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell45 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell44 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell46 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrtcMonto_Disponible2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrtcPorc_Disponible2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable8 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell51 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell52 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrPorcentajeAdjudicadoProveedor As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell54 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell55 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell56 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell57 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell58 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell59 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrMontoDisponibleProveedor As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrPorcDisponibleProveedor As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary6 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary7 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary8 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim RangeBarSeriesLabel1 As DevExpress.XtraCharts.RangeBarSeriesLabel = New DevExpress.XtraCharts.RangeBarSeriesLabel
        Dim OverlappedGanttSeriesView1 As DevExpress.XtraCharts.OverlappedGanttSeriesView = New DevExpress.XtraCharts.OverlappedGanttSeriesView
        Dim XrSummary9 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary10 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary11 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary12 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary13 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary14 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary15 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable8 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell51 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell52 = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrPorcentajeAdjudicadoProveedor = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell54 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell55 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell56 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell57 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell58 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell59 = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrMontoDisponibleProveedor = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrPorcDisponibleProveedor = New DevExpress.XtraReports.UI.XRTableCell
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrtcMonto_Disponible = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrtcPorc_Disponible = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.DS_DL1 = New SGAFP.DL.DS_DL
        Me.ResumenEjecucion_MontosCapacitadosTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.ResumenEjecucion_MontosCapacitadosTableAdapter
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrChart1 = New DevExpress.XtraReports.UI.XRChart
        Me.GroupHeader3 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrTable6 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell49 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell47 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell48 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell40 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell43 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell41 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell45 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell44 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell46 = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrtcMonto_Disponible2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrtcPorc_Disponible2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTable7 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell39 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTable5 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell36 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell37 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell38 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand
        CType(Me.XrTable8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RangeBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(OverlappedGanttSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable8})
        Me.Detail.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Detail.HeightF = 25.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("ADJUDICADO", DevExpress.XtraReports.UI.XRColumnSortOrder.Descending)})
        Me.Detail.StylePriority.UseFont = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable8
        '
        Me.XrTable8.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable8.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrTable8.LocationFloat = New DevExpress.Utils.PointFloat(37.50006!, 0.0!)
        Me.XrTable8.Name = "XrTable8"
        Me.XrTable8.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow8})
        Me.XrTable8.SizeF = New System.Drawing.SizeF(949.5831!, 25.0!)
        Me.XrTable8.StylePriority.UseBorders = False
        Me.XrTable8.StylePriority.UseFont = False
        Me.XrTable8.StylePriority.UseTextAlignment = False
        Me.XrTable8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow8
        '
        Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell51, Me.XrTableCell52, Me.xrPorcentajeAdjudicadoProveedor, Me.XrTableCell54, Me.XrTableCell55, Me.XrTableCell56, Me.XrTableCell57, Me.XrTableCell58, Me.XrTableCell59, Me.xrMontoDisponibleProveedor, Me.xrPorcDisponibleProveedor})
        Me.XrTableRow8.Name = "XrTableRow8"
        Me.XrTableRow8.Weight = 1
        '
        'XrTableCell51
        '
        Me.XrTableCell51.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ResumenEjecucion_MontosCapacitados.PROVEEDOR")})
        Me.XrTableCell51.Name = "XrTableCell51"
        Me.XrTableCell51.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell51.StylePriority.UsePadding = False
        Me.XrTableCell51.StylePriority.UseTextAlignment = False
        Me.XrTableCell51.Text = "XrTableCell51"
        Me.XrTableCell51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell51.Weight = 2.3293321228027342
        '
        'XrTableCell52
        '
        Me.XrTableCell52.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ResumenEjecucion_MontosCapacitados.ADJUDICADO", "{0:#,##0.00}")})
        Me.XrTableCell52.Name = "XrTableCell52"
        Me.XrTableCell52.Text = "XrTableCell52"
        Me.XrTableCell52.Weight = 1.0999996948242186
        '
        'xrPorcentajeAdjudicadoProveedor
        '
        Me.xrPorcentajeAdjudicadoProveedor.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ResumenEjecucion_MontosCapacitados.ADJUDICADO")})
        Me.xrPorcentajeAdjudicadoProveedor.Name = "xrPorcentajeAdjudicadoProveedor"
        Me.xrPorcentajeAdjudicadoProveedor.Text = "xrPorcentajeAdjudicadoProveedor"
        Me.xrPorcentajeAdjudicadoProveedor.Weight = 0.33330017089843778
        '
        'XrTableCell54
        '
        Me.XrTableCell54.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ResumenEjecucion_MontosCapacitados.EJECUTADO_MONTO", "{0:#,##0.00}")})
        Me.XrTableCell54.Name = "XrTableCell54"
        Me.XrTableCell54.Text = "XrTableCell54"
        Me.XrTableCell54.Weight = 1.1000009155273436
        '
        'XrTableCell55
        '
        Me.XrTableCell55.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ResumenEjecucion_MontosCapacitados.EJECUTADO_PORC", "{0:##0.0}")})
        Me.XrTableCell55.Name = "XrTableCell55"
        Me.XrTableCell55.Text = "XrTableCell55"
        Me.XrTableCell55.Weight = 0.33330017089843755
        '
        'XrTableCell56
        '
        Me.XrTableCell56.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ResumenEjecucion_MontosCapacitados.EJECUCION_MONTO", "{0:#,##0.00}")})
        Me.XrTableCell56.Name = "XrTableCell56"
        Me.XrTableCell56.Text = "XrTableCell56"
        Me.XrTableCell56.Weight = 1.0999987792968748
        '
        'XrTableCell57
        '
        Me.XrTableCell57.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ResumenEjecucion_MontosCapacitados.EJECUCION_PORC", "{0:##0.0}")})
        Me.XrTableCell57.Name = "XrTableCell57"
        Me.XrTableCell57.Text = "XrTableCell57"
        Me.XrTableCell57.Weight = 0.333300170898438
        '
        'XrTableCell58
        '
        Me.XrTableCell58.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ResumenEjecucion_MontosCapacitados.PROGRAMADO_MONTO", "{0:#,##0.00}")})
        Me.XrTableCell58.Name = "XrTableCell58"
        Me.XrTableCell58.Text = "XrTableCell58"
        Me.XrTableCell58.Weight = 1.1000006103515623
        '
        'XrTableCell59
        '
        Me.XrTableCell59.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ResumenEjecucion_MontosCapacitados.PROGRAMADO_PORC", "{0:##0.0}")})
        Me.XrTableCell59.Name = "XrTableCell59"
        Me.XrTableCell59.Text = "XrTableCell59"
        Me.XrTableCell59.Weight = 0.33330078124999996
        '
        'xrMontoDisponibleProveedor
        '
        Me.xrMontoDisponibleProveedor.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ResumenEjecucion_MontosCapacitados.ADJUDICADO")})
        Me.xrMontoDisponibleProveedor.Name = "xrMontoDisponibleProveedor"
        Me.xrMontoDisponibleProveedor.Text = "xrMontoDisponibleProveedor"
        Me.xrMontoDisponibleProveedor.Weight = 1.1000006103515627
        '
        'xrPorcDisponibleProveedor
        '
        Me.xrPorcDisponibleProveedor.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ResumenEjecucion_MontosCapacitados.ADJUDICADO")})
        Me.xrPorcDisponibleProveedor.Name = "xrPorcDisponibleProveedor"
        Me.xrPorcDisponibleProveedor.Text = "xrPorcDisponibleProveedor"
        Me.xrPorcDisponibleProveedor.Weight = 0.33329727172851553
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 0.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 39.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3, Me.XrTable1, Me.XrTable2})
        Me.GroupHeader1.HeightF = 185.0!
        Me.GroupHeader1.Level = 2
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrTable3
        '
        Me.XrTable3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable3.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(62.5!, 82.5!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(916.65!, 25.0!)
        Me.XrTable3.StylePriority.UseBorders = False
        Me.XrTable3.StylePriority.UseFont = False
        Me.XrTable3.StylePriority.UseTextAlignment = False
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell35, Me.XrTableCell34, Me.XrTableCell13, Me.XrTableCell14, Me.XrTableCell16, Me.XrTableCell17, Me.XrTableCell19, Me.XrTableCell20, Me.xrtcMonto_Disponible, Me.xrtcPorc_Disponible})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1
        '
        'XrTableCell35
        '
        Me.XrTableCell35.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ResumenEjecucion_MontosCapacitados.ADJUDICADO")})
        Me.XrTableCell35.Name = "XrTableCell35"
        XrSummary1.FormatString = "{0:#,##0.00}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell35.Summary = XrSummary1
        Me.XrTableCell35.Text = "XrTableCell35"
        Me.XrTableCell35.Weight = 0.5639277065151973
        '
        'XrTableCell34
        '
        Me.XrTableCell34.Name = "XrTableCell34"
        XrSummary2.FormatString = "{0:#,##0.00}"
        Me.XrTableCell34.Summary = XrSummary2
        Me.XrTableCell34.Text = "100"
        Me.XrTableCell34.Weight = 0.17453563305322556
        '
        'XrTableCell13
        '
        Me.XrTableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ResumenEjecucion_MontosCapacitados.EJECUTADO_MONTO")})
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.StylePriority.UseTextAlignment = False
        XrSummary3.FormatString = "{0:#,##0.00}"
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell13.Summary = XrSummary3
        Me.XrTableCell13.Text = "XrTableCell13"
        Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell13.Weight = 0.56392775265515782
        '
        'XrTableCell14
        '
        Me.XrTableCell14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ResumenEjecucion_MontosCapacitados.EJECUTADO_PORC")})
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.StylePriority.UseTextAlignment = False
        XrSummary4.FormatString = "{0:##0.0}"
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell14.Summary = XrSummary4
        Me.XrTableCell14.Text = "XrTableCell14"
        Me.XrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell14.Weight = 0.17453581296423959
        '
        'XrTableCell16
        '
        Me.XrTableCell16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ResumenEjecucion_MontosCapacitados.EJECUCION_MONTO")})
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.StylePriority.UseTextAlignment = False
        XrSummary5.FormatString = "{0:#,##0.00}"
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell16.Summary = XrSummary5
        Me.XrTableCell16.Text = "XrTableCell16"
        Me.XrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell16.Weight = 0.5639275766637184
        '
        'XrTableCell17
        '
        Me.XrTableCell17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ResumenEjecucion_MontosCapacitados.EJECUCION_PORC")})
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.StylePriority.UseTextAlignment = False
        XrSummary6.FormatString = "{0:##0.0}"
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell17.Summary = XrSummary6
        Me.XrTableCell17.Text = "XrTableCell17"
        Me.XrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell17.Weight = 0.17453618422188233
        '
        'XrTableCell19
        '
        Me.XrTableCell19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ResumenEjecucion_MontosCapacitados.PROGRAMADO_MONTO")})
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.StylePriority.UseTextAlignment = False
        XrSummary7.FormatString = "{0:#,##0.00}"
        XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell19.Summary = XrSummary7
        Me.XrTableCell19.Text = "XrTableCell19"
        Me.XrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell19.Weight = 0.56392723111519971
        '
        'XrTableCell20
        '
        Me.XrTableCell20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ResumenEjecucion_MontosCapacitados.PROGRAMADO_PORC")})
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.StylePriority.UseTextAlignment = False
        XrSummary8.FormatString = "{0:##0.0}"
        XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell20.Summary = XrSummary8
        Me.XrTableCell20.Text = "XrTableCell20"
        Me.XrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell20.Weight = 0.17453593034634718
        '
        'xrtcMonto_Disponible
        '
        Me.xrtcMonto_Disponible.Name = "xrtcMonto_Disponible"
        Me.xrtcMonto_Disponible.Text = "xrtcMonto_Disponible"
        Me.xrtcMonto_Disponible.Weight = 0.56392747097020646
        '
        'xrtcPorc_Disponible
        '
        Me.xrtcPorc_Disponible.Name = "xrtcPorc_Disponible"
        Me.xrtcPorc_Disponible.Text = "xrtcPorc_Disponible"
        Me.xrtcPorc_Disponible.Weight = 0.17453544140572863
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(62.5!, 57.5!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(916.6501!, 25.0!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell30, Me.XrTableCell29, Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell5, Me.XrTableCell6, Me.XrTableCell8, Me.XrTableCell9, Me.XrTableCell32, Me.XrTableCell33})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1
        '
        'XrTableCell30
        '
        Me.XrTableCell30.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.XrTableCell30.Name = "XrTableCell30"
        Me.XrTableCell30.StylePriority.UseBackColor = False
        Me.XrTableCell30.Text = "MONTO"
        Me.XrTableCell30.Weight = 0.56392772811924208
        '
        'XrTableCell29
        '
        Me.XrTableCell29.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.XrTableCell29.Name = "XrTableCell29"
        Me.XrTableCell29.StylePriority.UseBackColor = False
        Me.XrTableCell29.Text = "%"
        Me.XrTableCell29.Weight = 0.17453563234418623
        '
        'XrTableCell1
        '
        Me.XrTableCell1.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseBackColor = False
        Me.XrTableCell1.Text = "MONTO"
        Me.XrTableCell1.Weight = 0.56392773000733887
        '
        'XrTableCell2
        '
        Me.XrTableCell2.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseBackColor = False
        Me.XrTableCell2.Text = "%"
        Me.XrTableCell2.Weight = 0.17453563713284717
        '
        'XrTableCell5
        '
        Me.XrTableCell5.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseBackColor = False
        Me.XrTableCell5.Text = "MONTO"
        Me.XrTableCell5.Weight = 0.56392770325683039
        '
        'XrTableCell6
        '
        Me.XrTableCell6.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.StylePriority.UseBackColor = False
        Me.XrTableCell6.Text = "%"
        Me.XrTableCell6.Weight = 0.17453563508122788
        '
        'XrTableCell8
        '
        Me.XrTableCell8.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseBackColor = False
        Me.XrTableCell8.Text = "MONTO"
        Me.XrTableCell8.Weight = 0.56392771323539859
        '
        'XrTableCell9
        '
        Me.XrTableCell9.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StylePriority.UseBackColor = False
        Me.XrTableCell9.Text = "%"
        Me.XrTableCell9.Weight = 0.1745356381482554
        '
        'XrTableCell32
        '
        Me.XrTableCell32.Name = "XrTableCell32"
        Me.XrTableCell32.Text = "MONTO"
        Me.XrTableCell32.Weight = 0.56392770760943955
        '
        'XrTableCell33
        '
        Me.XrTableCell33.Name = "XrTableCell33"
        Me.XrTableCell33.Text = "%"
        Me.XrTableCell33.Weight = 0.17453586941992938
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(62.5!, 32.5!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(916.6501!, 25.0!)
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell28, Me.XrTableCell10, Me.XrTableCell11, Me.XrTableCell12, Me.XrTableCell31})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1
        '
        'XrTableCell28
        '
        Me.XrTableCell28.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.StylePriority.UseBackColor = False
        Me.XrTableCell28.Text = "ADJUDICADO"
        Me.XrTableCell28.Weight = 0.73846342070327553
        '
        'XrTableCell10
        '
        Me.XrTableCell10.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseBackColor = False
        Me.XrTableCell10.Text = "EJECUTADO"
        Me.XrTableCell10.Weight = 0.738463631011334
        '
        'XrTableCell11
        '
        Me.XrTableCell11.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.StylePriority.UseBackColor = False
        Me.XrTableCell11.Text = "EJECUCIÓN"
        Me.XrTableCell11.Weight = 0.73846358884149543
        '
        'XrTableCell12
        '
        Me.XrTableCell12.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.StylePriority.UseBackColor = False
        Me.XrTableCell12.Text = "POR EJECUTARSE"
        Me.XrTableCell12.Weight = 0.73846322621676741
        '
        'XrTableCell31
        '
        Me.XrTableCell31.Name = "XrTableCell31"
        Me.XrTableCell31.Text = "DISPONIBLE"
        Me.XrTableCell31.Weight = 0.73846349708413817
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1})
        Me.PageHeader.HeightF = 47.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(62.5!, 12.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(924.5833!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "RESUMEN DE EJECUCIÓN POR MONTOS"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DS_DL1
        '
        Me.DS_DL1.DataSetName = "DS_DL"
        Me.DS_DL1.EnforceConstraints = False
        Me.DS_DL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ResumenEjecucion_MontosCapacitadosTableAdapter1
        '
        Me.ResumenEjecucion_MontosCapacitadosTableAdapter1.ClearBeforeFill = True
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrChart1})
        Me.GroupHeader2.HeightF = 414.0!
        Me.GroupHeader2.Level = 1
        Me.GroupHeader2.Name = "GroupHeader2"
        Me.GroupHeader2.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        '
        'XrChart1
        '
        Me.XrChart1.BorderColor = System.Drawing.SystemColors.ControlText
        Me.XrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrChart1.LocationFloat = New DevExpress.Utils.PointFloat(37.5!, 0.0!)
        Me.XrChart1.Name = "XrChart1"
        Me.XrChart1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.XrChart1.SeriesTemplate.Label = RangeBarSeriesLabel1
        Me.XrChart1.SeriesTemplate.View = OverlappedGanttSeriesView1
        Me.XrChart1.SizeF = New System.Drawing.SizeF(950.0417!, 414.0!)
        '
        'GroupHeader3
        '
        Me.GroupHeader3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable6, Me.XrTable7, Me.XrTable5, Me.XrTable4})
        Me.GroupHeader3.Name = "GroupHeader3"
        '
        'XrTable6
        '
        Me.XrTable6.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable6.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrTable6.LocationFloat = New DevExpress.Utils.PointFloat(37.50006!, 75.0!)
        Me.XrTable6.Name = "XrTable6"
        Me.XrTable6.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow6})
        Me.XrTable6.SizeF = New System.Drawing.SizeF(949.5831!, 25.0!)
        Me.XrTable6.StylePriority.UseBorders = False
        Me.XrTable6.StylePriority.UseFont = False
        Me.XrTable6.StylePriority.UseTextAlignment = False
        Me.XrTable6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell49, Me.XrTableCell47, Me.XrTableCell48, Me.XrTableCell40, Me.XrTableCell43, Me.XrTableCell41, Me.XrTableCell45, Me.XrTableCell44, Me.XrTableCell46, Me.xrtcMonto_Disponible2, Me.xrtcPorc_Disponible2})
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Weight = 1
        '
        'XrTableCell49
        '
        Me.XrTableCell49.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.XrTableCell49.Name = "XrTableCell49"
        Me.XrTableCell49.StylePriority.UseBackColor = False
        Me.XrTableCell49.Text = "TOTAL"
        Me.XrTableCell49.Weight = 2.3293321228027342
        '
        'XrTableCell47
        '
        Me.XrTableCell47.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.XrTableCell47.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ResumenEjecucion_MontosCapacitados.ADJUDICADO")})
        Me.XrTableCell47.Name = "XrTableCell47"
        Me.XrTableCell47.StylePriority.UseBackColor = False
        XrSummary9.FormatString = "{0:#,##0.00}"
        XrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell47.Summary = XrSummary9
        Me.XrTableCell47.Text = "XrTableCell47"
        Me.XrTableCell47.Weight = 1.0999996948242186
        '
        'XrTableCell48
        '
        Me.XrTableCell48.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.XrTableCell48.Name = "XrTableCell48"
        Me.XrTableCell48.StylePriority.UseBackColor = False
        Me.XrTableCell48.Text = "100"
        Me.XrTableCell48.Weight = 0.33330017089843778
        '
        'XrTableCell40
        '
        Me.XrTableCell40.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.XrTableCell40.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ResumenEjecucion_MontosCapacitados.EJECUTADO_MONTO")})
        Me.XrTableCell40.Name = "XrTableCell40"
        Me.XrTableCell40.StylePriority.UseBackColor = False
        XrSummary10.FormatString = "{0:#,##0.00}"
        XrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell40.Summary = XrSummary10
        Me.XrTableCell40.Text = "XrTableCell40"
        Me.XrTableCell40.Weight = 1.1000009155273436
        '
        'XrTableCell43
        '
        Me.XrTableCell43.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.XrTableCell43.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ResumenEjecucion_MontosCapacitados.EJECUTADO_PORC")})
        Me.XrTableCell43.Name = "XrTableCell43"
        Me.XrTableCell43.StylePriority.UseBackColor = False
        XrSummary11.FormatString = "{0:0.0}"
        XrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell43.Summary = XrSummary11
        Me.XrTableCell43.Text = "XrTableCell43"
        Me.XrTableCell43.Weight = 0.33330017089843755
        '
        'XrTableCell41
        '
        Me.XrTableCell41.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.XrTableCell41.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ResumenEjecucion_MontosCapacitados.EJECUCION_MONTO")})
        Me.XrTableCell41.Name = "XrTableCell41"
        Me.XrTableCell41.StylePriority.UseBackColor = False
        XrSummary12.FormatString = "{0:#,##0.00}"
        XrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell41.Summary = XrSummary12
        Me.XrTableCell41.Text = "XrTableCell41"
        Me.XrTableCell41.Weight = 1.0999987792968748
        '
        'XrTableCell45
        '
        Me.XrTableCell45.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.XrTableCell45.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ResumenEjecucion_MontosCapacitados.EJECUCION_PORC")})
        Me.XrTableCell45.Name = "XrTableCell45"
        Me.XrTableCell45.StylePriority.UseBackColor = False
        XrSummary13.FormatString = "{0:##0.0}"
        XrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell45.Summary = XrSummary13
        Me.XrTableCell45.Text = "XrTableCell45"
        Me.XrTableCell45.Weight = 0.333300170898438
        '
        'XrTableCell44
        '
        Me.XrTableCell44.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.XrTableCell44.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ResumenEjecucion_MontosCapacitados.PROGRAMADO_MONTO")})
        Me.XrTableCell44.Name = "XrTableCell44"
        Me.XrTableCell44.StylePriority.UseBackColor = False
        XrSummary14.FormatString = "{0:#,##0.00}"
        XrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell44.Summary = XrSummary14
        Me.XrTableCell44.Text = "XrTableCell44"
        Me.XrTableCell44.Weight = 1.1000006103515623
        '
        'XrTableCell46
        '
        Me.XrTableCell46.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.XrTableCell46.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ResumenEjecucion_MontosCapacitados.PROGRAMADO_PORC")})
        Me.XrTableCell46.Name = "XrTableCell46"
        Me.XrTableCell46.StylePriority.UseBackColor = False
        XrSummary15.FormatString = "{0:##0.0}"
        XrSummary15.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell46.Summary = XrSummary15
        Me.XrTableCell46.Text = "XrTableCell46"
        Me.XrTableCell46.Weight = 0.33330078124999996
        '
        'xrtcMonto_Disponible2
        '
        Me.xrtcMonto_Disponible2.Name = "xrtcMonto_Disponible2"
        Me.xrtcMonto_Disponible2.Text = "xrtcMonto_Disponible2"
        Me.xrtcMonto_Disponible2.Weight = 1.1000006103515627
        '
        'xrtcPorc_Disponible2
        '
        Me.xrtcPorc_Disponible2.Name = "xrtcPorc_Disponible2"
        Me.xrtcPorc_Disponible2.Text = "xrtcPorc_Disponible2"
        Me.xrtcPorc_Disponible2.Weight = 0.33329727172851553
        '
        'XrTable7
        '
        Me.XrTable7.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable7.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrTable7.LocationFloat = New DevExpress.Utils.PointFloat(37.5!, 25.0!)
        Me.XrTable7.Name = "XrTable7"
        Me.XrTable7.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow7})
        Me.XrTable7.SizeF = New System.Drawing.SizeF(232.9333!, 50.0!)
        Me.XrTable7.StylePriority.UseBorders = False
        Me.XrTable7.StylePriority.UseFont = False
        Me.XrTable7.StylePriority.UseTextAlignment = False
        Me.XrTable7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow7
        '
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell39})
        Me.XrTableRow7.Name = "XrTableRow7"
        Me.XrTableRow7.Weight = 1
        '
        'XrTableCell39
        '
        Me.XrTableCell39.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.XrTableCell39.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell39.Name = "XrTableCell39"
        Me.XrTableCell39.StylePriority.UseBackColor = False
        Me.XrTableCell39.StylePriority.UseFont = False
        Me.XrTableCell39.Text = "PROVEEDOR"
        Me.XrTableCell39.Weight = 1.1532640745072607
        '
        'XrTable5
        '
        Me.XrTable5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable5.LocationFloat = New DevExpress.Utils.PointFloat(270.4333!, 50.0!)
        Me.XrTable5.Name = "XrTable5"
        Me.XrTable5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow5})
        Me.XrTable5.SizeF = New System.Drawing.SizeF(716.65!, 25.0!)
        Me.XrTable5.StylePriority.UseBorders = False
        Me.XrTable5.StylePriority.UseFont = False
        Me.XrTable5.StylePriority.UseTextAlignment = False
        Me.XrTable5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell21, Me.XrTableCell22, Me.XrTableCell23, Me.XrTableCell24, Me.XrTableCell25, Me.XrTableCell26, Me.XrTableCell27, Me.XrTableCell36, Me.XrTableCell37, Me.XrTableCell38})
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Weight = 1
        '
        'XrTableCell21
        '
        Me.XrTableCell21.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.StylePriority.UseBackColor = False
        Me.XrTableCell21.Text = "MONTO"
        Me.XrTableCell21.Weight = 0.44308604626143744
        '
        'XrTableCell22
        '
        Me.XrTableCell22.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.StylePriority.UseBackColor = False
        Me.XrTableCell22.Text = "%"
        Me.XrTableCell22.Weight = 0.13425508196879166
        '
        'XrTableCell23
        '
        Me.XrTableCell23.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.StylePriority.UseBackColor = False
        Me.XrTableCell23.Text = "MONTO"
        Me.XrTableCell23.Weight = 0.44308604814953423
        '
        'XrTableCell24
        '
        Me.XrTableCell24.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.StylePriority.UseBackColor = False
        Me.XrTableCell24.Text = "%"
        Me.XrTableCell24.Weight = 0.13425508675745262
        '
        'XrTableCell25
        '
        Me.XrTableCell25.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.XrTableCell25.Name = "XrTableCell25"
        Me.XrTableCell25.StylePriority.UseBackColor = False
        Me.XrTableCell25.Text = "MONTO"
        Me.XrTableCell25.Weight = 0.44308605213064689
        '
        'XrTableCell26
        '
        Me.XrTableCell26.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.StylePriority.UseBackColor = False
        Me.XrTableCell26.Text = "%"
        Me.XrTableCell26.Weight = 0.13425508470583325
        '
        'XrTableCell27
        '
        Me.XrTableCell27.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.StylePriority.UseBackColor = False
        Me.XrTableCell27.Text = "MONTO"
        Me.XrTableCell27.Weight = 0.44308600064597292
        '
        'XrTableCell36
        '
        Me.XrTableCell36.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.XrTableCell36.Name = "XrTableCell36"
        Me.XrTableCell36.StylePriority.UseBackColor = False
        Me.XrTableCell36.Text = "%"
        Me.XrTableCell36.Weight = 0.13425508777286077
        '
        'XrTableCell37
        '
        Me.XrTableCell37.Name = "XrTableCell37"
        Me.XrTableCell37.Text = "MONTO"
        Me.XrTableCell37.Weight = 0.44308605648325605
        '
        'XrTableCell38
        '
        Me.XrTableCell38.Name = "XrTableCell38"
        Me.XrTableCell38.Text = "%"
        Me.XrTableCell38.Weight = 0.13425513465480843
        '
        'XrTable4
        '
        Me.XrTable4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable4.LocationFloat = New DevExpress.Utils.PointFloat(270.4333!, 25.0!)
        Me.XrTable4.Name = "XrTable4"
        Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
        Me.XrTable4.SizeF = New System.Drawing.SizeF(716.65!, 25.0!)
        Me.XrTable4.StylePriority.UseBorders = False
        Me.XrTable4.StylePriority.UseFont = False
        Me.XrTable4.StylePriority.UseTextAlignment = False
        Me.XrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell7, Me.XrTableCell15, Me.XrTableCell18})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Weight = 1
        '
        'XrTableCell3
        '
        Me.XrTableCell3.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseBackColor = False
        Me.XrTableCell3.Text = "ADJUDICADO"
        Me.XrTableCell3.Weight = 0.56475234373733652
        '
        'XrTableCell4
        '
        Me.XrTableCell4.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseBackColor = False
        Me.XrTableCell4.Text = "EJECUTADO"
        Me.XrTableCell4.Weight = 0.56475219330719162
        '
        'XrTableCell7
        '
        Me.XrTableCell7.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.StylePriority.UseBackColor = False
        Me.XrTableCell7.Text = "EJECUCIÓN"
        Me.XrTableCell7.Weight = 0.56475203089128512
        '
        'XrTableCell15
        '
        Me.XrTableCell15.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.StylePriority.UseBackColor = False
        Me.XrTableCell15.Text = "POR EJECUTARSE"
        Me.XrTableCell15.Weight = 0.56475202900476051
        '
        'XrTableCell18
        '
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.Text = "DISPONIBLE"
        Me.XrTableCell18.Weight = 0.564752540364267
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'xrResumenEjecucion_SubReporteMontosPorProveedor
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1, Me.PageHeader, Me.GroupHeader2, Me.GroupHeader3, Me.GroupFooter1})
        Me.DataAdapter = Me.ResumenEjecucion_MontosCapacitadosTableAdapter1
        Me.DataMember = "ResumenEjecucion_MontosCapacitados"
        Me.DataSource = Me.DS_DL1
        Me.DefaultPrinterSettingsUsing.UseLandscape = True
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(38, 39, 0, 39)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.Version = "10.1"
        CType(Me.XrTable8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RangeBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(OverlappedGanttSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
#End Region

    Private TotalAdjudicado As Decimal = 0

    Sub CalcTotal_Adjudicado()
        Dim lResult As Object

        lResult = Me.DS_DL1.ResumenEjecucion_MontosCapacitados.Compute("SUM(ADJUDICADO)", "PROVEEDOR<>''")
        If lResult IsNot Nothing AndAlso Not IsDBNull(lResult) Then
            TotalAdjudicado = CDec(lResult)
        Else
            TotalAdjudicado = 0
        End If
    End Sub

    Public Sub CargarDatosPorEjercicio(ByVal ID_EJERCICIO As String)
        Me.ResumenEjecucion_MontosCapacitadosTableAdapter1.Fill(Me.DS_DL1.ResumenEjecucion_MontosCapacitados, ID_EJERCICIO)
        Me.CargarGrafico()
        CalcTotal_Adjudicado()
        Me.xrtcPorc_Disponible.Text = Format(ObtenerPorcentajeDisponible, "#0.0")
        Me.xrtcMonto_Disponible.Text = Format(ObtenerMontoDisponible, "#,##0.00")
        Me.xrtcPorc_Disponible2.Text = Me.xrtcPorc_Disponible.Text
        Me.xrtcMonto_Disponible2.Text = Me.xrtcMonto_Disponible.Text
    End Sub

    Function ObtenerFecha(ByVal resultado As String, ByVal ParamArray parametros() As Object) As Date
        Dim listaFechas As New List(Of Date)
        For Each obj As Object In parametros
            If IsDate(obj) Then
                listaFechas.Add(CDate(obj))
            End If
        Next
        listaFechas.Sort()
        If resultado.ToLower = "menor" Then
            Return listaFechas.Min
        Else
            Return listaFechas.Max()
        End If
    End Function

    Private Sub CargarGrafico()
        Dim dt As DS_DL.ResumenEjecucion_MontosCapacitadosDataTable = Me.DS_DL1.ResumenEjecucion_MontosCapacitados
        Dim serieDesarrollado As New Series("Desarrollado", ViewType.Gantt)
        Dim serieEjecutado As New Series("Ejecutado", ViewType.Gantt)
        Dim serieEjecucion As New Series("Ejecucion", ViewType.Gantt)
        Dim serieProgramado As New Series("Programado", ViewType.Gantt)
        Dim diagrama As New GanttDiagram
        Dim valorMinimoEje As Date
        Dim valorMaximoEje As Date

        Dim punto As SeriesPoint

        'Configurando las Series
        serieDesarrollado.ValueScaleType = ScaleType.DateTime
        serieEjecutado.ValueScaleType = ScaleType.DateTime
        serieEjecucion.ValueScaleType = ScaleType.DateTime
        serieProgramado.ValueScaleType = ScaleType.DateTime
        For i As Integer = 0 To dt.Rows.Count - 1
            Dim nombrePunto As New StringBuilder
            Dim PuntoSerie As New SeriesPoint
            Dim FechaInicial As Date = ObtenerFecha("menor", New Object() {dt(i)("EJECUTADO_INICIO"), dt(i)("EJECUCION_INICIO"), dt(i)("PROGRAMADO_INICIO")})
            Dim FechaFinal As Date = ObtenerFecha("mayor", New Object() {dt(i)("EJECUTADO_FIN"), dt(i)("EJECUCION_FIN"), dt(i)("PROGRAMADO_FIN")})

            If i = 0 Then
                valorMinimoEje = FechaInicial
                valorMaximoEje = FechaFinal
            Else
                If FechaInicial < valorMinimoEje Then valorMinimoEje = FechaInicial
                If FechaFinal > valorMaximoEje Then valorMaximoEje = FechaFinal
            End If
            nombrePunto.Append(dt(i)("PROVEEDOR").ToString)
            nombrePunto.Append("  (")
            nombrePunto.Append(Format(dt(i)("EJECUTADO_PORC") + dt(i)("EJECUCION_PORC") + dt(i)("PROGRAMADO_PORC"), "##0.0"))
            nombrePunto.Append("%)")
            serieDesarrollado.Points.Add(New SeriesPoint(nombrePunto.ToString, New DateTime() { _
                    New DateTime(FechaInicial.Year, FechaInicial.Month, FechaInicial.Day), _
                    New DateTime(FechaFinal.Year, FechaFinal.Month, FechaFinal.Day)}))
            If IsDate(dt(i)("EJECUTADO_INICIO")) Then
                Dim f As Date = CDate(dt(i)("EJECUTADO_FIN"))
                punto = New SeriesPoint(nombrePunto.ToString, New DateTime() { _
                    New DateTime(FechaInicial.Year, FechaInicial.Month, FechaInicial.Day), New DateTime(f.Year, f.Month, f.Day)})
                serieEjecutado.Points.Add(punto)
                Dim anotacion As TextAnnotation = punto.Annotations.AddTextAnnotation
                anotacion.Name = dt(i)("PROVEEDOR").ToString.Replace(" ", "_") + "_Ejecutado" + CStr(i)
                anotacion.Text = Format(dt(i)("EJECUTADO_PORC"), "#0") + "% " + Format(dt(i)("EJECUTADO_MONTO"), "#,##0.00")
                anotacion.Font = New System.Drawing.Font("Arial", 7)
                anotacion.ShapeKind = ShapeKind.RoundedRectangle
                anotacion.Angle = 0
                CType(anotacion.ShapePosition, RelativePosition).ConnectorLength = 0

                FechaInicial = f
            End If
            If IsDate(dt(i)("EJECUCION_INICIO")) Then
                Dim f As Date = CDate(dt(i)("EJECUCION_FIN"))
                punto = New SeriesPoint(nombrePunto.ToString, New DateTime() { _
                    New DateTime(FechaInicial.Year, FechaInicial.Month, FechaInicial.Day), New DateTime(f.Year, f.Month, f.Day)})
                serieEjecucion.Points.Add(punto)
                Dim anotacion As TextAnnotation = punto.Annotations.AddTextAnnotation
                anotacion.Name = dt(i)("PROVEEDOR").ToString.Replace(" ", "_") + "_Ejecucion" + CStr(i)
                anotacion.Text = Format(dt(i)("EJECUCION_PORC"), "#0") + "% " + Format(dt(i)("EJECUCION_MONTO"), "#,##0.00")
                anotacion.Font = New System.Drawing.Font("Arial", 7)
                anotacion.ShapeKind = ShapeKind.RoundedRectangle
                anotacion.Angle = 0
                CType(anotacion.ShapePosition, RelativePosition).ConnectorLength = 0

                FechaInicial = f
            End If
            If IsDate(dt(i)("PROGRAMADO_INICIO")) Then
                Dim f As Date = CDate(dt(i)("PROGRAMADO_FIN"))
                punto = New SeriesPoint(nombrePunto.ToString, New DateTime() { _
                    New DateTime(FechaInicial.Year, FechaInicial.Month, FechaInicial.Day), New DateTime(f.Year, f.Month, f.Day)})
                serieProgramado.Points.Add(punto)
                Dim anotacion As TextAnnotation = punto.Annotations.AddTextAnnotation
                anotacion.Name = dt(i)("PROVEEDOR").ToString.Replace(" ", "_") + "_Programado" + CStr(i)
                anotacion.Text = Format(dt(i)("PROGRAMADO_PORC"), "#0") + "% " + Format(dt(i)("PROGRAMADO_MONTO"), "#,##0.00")
                anotacion.Font = New System.Drawing.Font("Arial", 7)
                anotacion.ShapeKind = ShapeKind.RoundedRectangle
                anotacion.Angle = 0
                CType(anotacion.ShapePosition, RelativePosition).ConnectorLength = 0
            End If
        Next i

        Me.XrChart1.Series.AddRange(New Series() {serieDesarrollado, serieEjecutado, serieEjecucion, serieProgramado})

        TryCast(serieDesarrollado.View, GanttSeriesView).BarWidth = 0.1
        TryCast(serieEjecutado.View, GanttSeriesView).BarWidth = 0.7
        TryCast(serieEjecucion.View, GanttSeriesView).BarWidth = 0.7
        TryCast(serieProgramado.View, GanttSeriesView).BarWidth = 0.7

        serieDesarrollado.Label.Visible = False
        serieEjecutado.Label.Visible = False
        serieEjecucion.Label.Visible = False
        serieProgramado.Label.Visible = False

        diagrama = TryCast(Me.XrChart1.Diagram, GanttDiagram)
        Me.XrChart1.Legend.Visible = False
        Me.XrChart1.Legend.AlignmentVertical = LegendAlignmentVertical.Center
        Me.XrChart1.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside
        Me.XrChart1.Legend.Direction = LegendDirection.TopToBottom

        With diagrama.AxisX
            .Title.Text = "Proveedores"
            .Title.Visible = False
            .GridLines.Visible = True
            .Range.SideMarginsEnabled = True
            .Label.Font = New System.Drawing.Font("Arial", 8)
        End With

        Dim linea As ConstantLine = New ConstantLine("Hoy", New DateTime(Now.Year, Now.Month, Now.Day))
        linea.ShowInLegend = False
        linea.Title.Alignment = ConstantLineTitleAlignment.Far
        linea.Title.TextColor = Drawing.Color.Blue
        linea.LegendText = "Hoy" + Now.ToString("dd/MM/yyyy")
        linea.Color = Drawing.Color.Blue

        With diagrama.AxisY
            .ConstantLines.Add(linea)
            .Title.Text = "Meses"
            .Title.Visible = True
            .GridSpacingAuto = False
            .GridSpacing = 0.5
            .GridLines.MinorVisible = True
            '.MinorCount = 4
            .Interlaced = True
            .DateTimeGridAlignment = DateTimeMeasurementUnit.Month
            .DateTimeOptions.Format = DateTimeFormat.MonthAndDay
            .Range.Auto = False
            .Range.SideMarginsEnabled = False
        End With

        'Agregar un eje Y secundario
        Dim EjeSecundarioY As New SecondaryAxisY("EjeY")
        With EjeSecundarioY
            .GridSpacingAuto = False
            .GridSpacing = 0.5
            .GridLines.MinorVisible = True
            .Interlaced = True
            .DateTimeGridAlignment = DateTimeMeasurementUnit.Month
            .DateTimeOptions.Format = DateTimeFormat.MonthAndDay
            .Range.Auto = False
            .Range.SideMarginsEnabled = False
            .Visible = True
        End With
        If diagrama.SecondaryAxesY.Count = 0 Then diagrama.SecondaryAxesY.Add(EjeSecundarioY)
        CType(Me.XrChart1.GetSeriesByName("Desarrollado").View, XYDiagramSeriesViewBase).AxisY = EjeSecundarioY
    End Sub

    Private Function ObtenerPorcentajeDisponible() As Decimal
        Dim Total As Decimal = 0
        Dim lResult As Object

        lResult = Me.DS_DL1.ResumenEjecucion_MontosCapacitados.Compute("SUM(EJECUTADO_PORC)", "PROVEEDOR<>''")
        If lResult IsNot Nothing AndAlso Not IsDBNull(lResult) Then
            Total += CDec(lResult)
        End If
        lResult = Me.DS_DL1.ResumenEjecucion_MontosCapacitados.Compute("SUM(EJECUCION_PORC)", "PROVEEDOR<>''")
        If lResult IsNot Nothing AndAlso Not IsDBNull(lResult) Then
            Total += CDec(lResult)
        End If
        lResult = Me.DS_DL1.ResumenEjecucion_MontosCapacitados.Compute("SUM(PROGRAMADO_PORC)", "PROVEEDOR<>''")
        If lResult IsNot Nothing AndAlso Not IsDBNull(lResult) Then
            Total += CDec(lResult)
        End If
        If Total > 100 Then Return 0 Else Return (100 - Total)
    End Function

    Private Function ObtenerMontoDisponible() As Decimal
        Dim lAdjudicado As Decimal = 0
        Dim Total As Decimal = 0
        Dim lResult As Object

        lResult = Me.DS_DL1.ResumenEjecucion_MontosCapacitados.Compute("SUM(EJECUTADO_MONTO)", "PROVEEDOR<>''")
        If lResult IsNot Nothing AndAlso Not IsDBNull(lResult) Then
            Total += CDec(lResult)
        End If
        lResult = Me.DS_DL1.ResumenEjecucion_MontosCapacitados.Compute("SUM(EJECUCION_MONTO)", "PROVEEDOR<>''")
        If lResult IsNot Nothing AndAlso Not IsDBNull(lResult) Then
            Total += CDec(lResult)
        End If
        lResult = Me.DS_DL1.ResumenEjecucion_MontosCapacitados.Compute("SUM(PROGRAMADO_MONTO)", "PROVEEDOR<>''")
        If lResult IsNot Nothing AndAlso Not IsDBNull(lResult) Then
            Total += CDec(lResult)
        End If
        lResult = Me.DS_DL1.ResumenEjecucion_MontosCapacitados.Compute("SUM(ADJUDICADO)", "PROVEEDOR<>''")
        If lResult IsNot Nothing AndAlso Not IsDBNull(lResult) Then
            lAdjudicado = CDec(lResult)
        End If
        If Total > lAdjudicado Then Return 0 Else Return (lAdjudicado - Total)
    End Function

    Private Sub xrPorcentajeAdjudicadoProveedor_EvaluateBinding(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.BindingEventArgs) Handles xrPorcentajeAdjudicadoProveedor.EvaluateBinding
        e.Value = Format((CDec(GetCurrentColumnValue("ADJUDICADO")) / TotalAdjudicado) * 100, "##0.0")
    End Sub

    Private Sub xrMontoDisponibleProveedor_EvaluateBinding(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.BindingEventArgs) Handles xrMontoDisponibleProveedor.EvaluateBinding
        Dim lMontoDisponible As Decimal = CDec(GetCurrentColumnValue("ADJUDICADO")) - (CDec(GetCurrentColumnValue("EJECUTADO_MONTO")) + CDec(GetCurrentColumnValue("EJECUCION_MONTO")) + CDec(GetCurrentColumnValue("PROGRAMADO_MONTO")))

        If lMontoDisponible > 0 Then
            e.Value = Format(lMontoDisponible, "#,##0.00")
        Else
            e.Value = "0.00"
        End If
    End Sub

    Private Sub xrPorcDisponibleProveedor_EvaluateBinding(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.BindingEventArgs) Handles xrPorcDisponibleProveedor.EvaluateBinding
        Dim lMontoUtilizado As Decimal = CDec(GetCurrentColumnValue("EJECUTADO_MONTO")) + CDec(GetCurrentColumnValue("EJECUCION_MONTO")) + CDec(GetCurrentColumnValue("PROGRAMADO_MONTO"))
        Dim lPorcDisponible As Decimal = 100 - (lMontoUtilizado / CDec(GetCurrentColumnValue("ADJUDICADO"))) * 100

        If lPorcDisponible > 0 Then
            e.Value = Format(lPorcDisponible, "##0.0")
        Else
            e.Value = "0.0"
        End If
    End Sub
End Class