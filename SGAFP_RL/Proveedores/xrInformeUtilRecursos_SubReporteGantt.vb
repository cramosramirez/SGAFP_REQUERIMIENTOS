Imports DevExpress.XtraCharts
Imports SGAFP.DL
Imports System.Text

Public Class xrInformeUtilRecursos_SubReporteGantt
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Diseñador "
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
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DS_DL1 As SGAFP.DL.DS_DL
    Friend WithEvents InformeUtilRecursos_GanttTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.InformeUtilRecursos_GanttTableAdapter
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents MONTO_UTILIZADO As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents PORC_UTILIZADO As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell31 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell35 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrtcPorc_Disponible As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrtcMonto_Disponible As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrChart1 As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand

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
        Dim XrSummary9 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim RangeBarSeriesLabel1 As DevExpress.XtraCharts.RangeBarSeriesLabel = New DevExpress.XtraCharts.RangeBarSeriesLabel
        Dim OverlappedGanttSeriesView1 As DevExpress.XtraCharts.OverlappedGanttSeriesView = New DevExpress.XtraCharts.OverlappedGanttSeriesView
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrtcPorc_Disponible = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrtcMonto_Disponible = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.DS_DL1 = New SGAFP.DL.DS_DL
        Me.InformeUtilRecursos_GanttTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.InformeUtilRecursos_GanttTableAdapter
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrChart1 = New DevExpress.XtraReports.UI.XRChart
        Me.MONTO_UTILIZADO = New DevExpress.XtraReports.UI.CalculatedField
        Me.PORC_UTILIZADO = New DevExpress.XtraReports.UI.CalculatedField
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(RangeBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(OverlappedGanttSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Expanded = False
        Me.Detail.HeightF = 3.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        Me.BottomMargin.HeightF = 9.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1, Me.XrTable3, Me.XrTable2})
        Me.GroupHeader1.HeightF = 140.0!
        Me.GroupHeader1.Level = 1
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(68.0!, 47.95836!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(904.2173!, 25.0!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell30, Me.XrTableCell29, Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell9, Me.XrTableCell3, Me.XrTableCell32, Me.XrTableCell33})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1
        '
        'XrTableCell30
        '
        Me.XrTableCell30.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.XrTableCell30.Name = "XrTableCell30"
        Me.XrTableCell30.StylePriority.UseBackColor = False
        Me.XrTableCell30.Text = "%"
        Me.XrTableCell30.Weight = 0.14098192042882374
        '
        'XrTableCell29
        '
        Me.XrTableCell29.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.XrTableCell29.Name = "XrTableCell29"
        Me.XrTableCell29.StylePriority.UseBackColor = False
        Me.XrTableCell29.Text = "MONTO"
        Me.XrTableCell29.Weight = 0.37661259706467543
        '
        'XrTableCell1
        '
        Me.XrTableCell1.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseBackColor = False
        Me.XrTableCell1.Text = "%"
        Me.XrTableCell1.Weight = 0.14098192231672105
        '
        'XrTableCell2
        '
        Me.XrTableCell2.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseBackColor = False
        Me.XrTableCell2.Text = "MONTO"
        Me.XrTableCell2.Weight = 0.36224298703443369
        '
        'XrTableCell4
        '
        Me.XrTableCell4.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseBackColor = False
        Me.XrTableCell4.Text = "PARTICIPANTES"
        Me.XrTableCell4.Weight = 0.37058106346369868
        '
        'XrTableCell5
        '
        Me.XrTableCell5.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseBackColor = False
        Me.XrTableCell5.Text = "%"
        Me.XrTableCell5.Weight = 0.14098192407910615
        '
        'XrTableCell6
        '
        Me.XrTableCell6.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.StylePriority.UseBackColor = False
        Me.XrTableCell6.Text = "MONTO"
        Me.XrTableCell6.Weight = 0.36224296193409772
        '
        'XrTableCell7
        '
        Me.XrTableCell7.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.StylePriority.UseBackColor = False
        Me.XrTableCell7.Text = "PARTICIPANTES"
        Me.XrTableCell7.Weight = 0.37058104134940933
        '
        'XrTableCell8
        '
        Me.XrTableCell8.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseBackColor = False
        Me.XrTableCell8.Text = "%"
        Me.XrTableCell8.Weight = 0.14098191775743685
        '
        'XrTableCell9
        '
        Me.XrTableCell9.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StylePriority.UseBackColor = False
        Me.XrTableCell9.Text = "MONTO"
        Me.XrTableCell9.Weight = 0.3622429726840305
        '
        'XrTableCell3
        '
        Me.XrTableCell3.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseBackColor = False
        Me.XrTableCell3.Text = "PARTICIPANTES"
        Me.XrTableCell3.Weight = 0.37058104319010143
        '
        'XrTableCell32
        '
        Me.XrTableCell32.Name = "XrTableCell32"
        Me.XrTableCell32.Text = "%"
        Me.XrTableCell32.Weight = 0.14098191797369058
        '
        'XrTableCell33
        '
        Me.XrTableCell33.Name = "XrTableCell33"
        Me.XrTableCell33.Text = "MONTO"
        Me.XrTableCell33.Weight = 0.36224285054204991
        '
        'XrTable3
        '
        Me.XrTable3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable3.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(68.00003!, 72.95836!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(904.2173!, 25.0!)
        Me.XrTable3.StylePriority.UseBorders = False
        Me.XrTable3.StylePriority.UseFont = False
        Me.XrTable3.StylePriority.UseTextAlignment = False
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell35, Me.XrTableCell34, Me.XrTableCell13, Me.XrTableCell14, Me.XrTableCell15, Me.XrTableCell16, Me.XrTableCell17, Me.XrTableCell18, Me.XrTableCell19, Me.XrTableCell20, Me.XrTableCell21, Me.xrtcPorc_Disponible, Me.xrtcMonto_Disponible})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1
        '
        'XrTableCell35
        '
        Me.XrTableCell35.Name = "XrTableCell35"
        Me.XrTableCell35.Text = "100"
        Me.XrTableCell35.Weight = 0.14098192855761243
        '
        'XrTableCell34
        '
        Me.XrTableCell34.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Gantt.ADJUDICADO", "{0:#,##0.00}")})
        Me.XrTableCell34.Name = "XrTableCell34"
        Me.XrTableCell34.Text = "XrTableCell34"
        Me.XrTableCell34.Weight = 0.376612528665742
        '
        'XrTableCell13
        '
        Me.XrTableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Gantt.EJECUTADO_PORC")})
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:0.0}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell13.Summary = XrSummary1
        Me.XrTableCell13.Text = "XrTableCell13"
        Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell13.Weight = 0.14098186713689939
        '
        'XrTableCell14
        '
        Me.XrTableCell14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Gantt.EJECUTADO_MONTO")})
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:#,##0.00}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell14.Summary = XrSummary2
        Me.XrTableCell14.Text = "XrTableCell14"
        Me.XrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell14.Weight = 0.36224295600917256
        '
        'XrTableCell15
        '
        Me.XrTableCell15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Gantt.EJECUTADO_PARTICIPANTES")})
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.StylePriority.UseTextAlignment = False
        XrSummary3.FormatString = "{0:#,##0}"
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell15.Summary = XrSummary3
        Me.XrTableCell15.Text = "XrTableCell15"
        Me.XrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell15.Weight = 0.370580937271658
        '
        'XrTableCell16
        '
        Me.XrTableCell16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Gantt.EJECUCION_PORC")})
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.StylePriority.UseTextAlignment = False
        XrSummary4.FormatString = "{0:0.0}"
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell16.Summary = XrSummary4
        Me.XrTableCell16.Text = "XrTableCell16"
        Me.XrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell16.Weight = 0.14098192402588333
        '
        'XrTableCell17
        '
        Me.XrTableCell17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Gantt.EJECUCION_MONTO")})
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.StylePriority.UseTextAlignment = False
        XrSummary5.FormatString = "{0:#,##0.00}"
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell17.Summary = XrSummary5
        Me.XrTableCell17.Text = "XrTableCell17"
        Me.XrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell17.Weight = 0.36224319665742621
        '
        'XrTableCell18
        '
        Me.XrTableCell18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Gantt.EJECUCION_PARTICIPANTES")})
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.StylePriority.UseTextAlignment = False
        XrSummary6.FormatString = "{0:#,##0}"
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell18.Summary = XrSummary6
        Me.XrTableCell18.Text = "XrTableCell18"
        Me.XrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell18.Weight = 0.37058056588701371
        '
        'XrTableCell19
        '
        Me.XrTableCell19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Gantt.PROGRAMADO_PORC")})
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.StylePriority.UseTextAlignment = False
        XrSummary7.FormatString = "{0:0.0}"
        XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell19.Summary = XrSummary7
        Me.XrTableCell19.Text = "XrTableCell19"
        Me.XrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell19.Weight = 0.1409821726662609
        '
        'XrTableCell20
        '
        Me.XrTableCell20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Gantt.PROGRAMADO_MONTO")})
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.StylePriority.UseTextAlignment = False
        XrSummary8.FormatString = "{0:#,##0.00}"
        XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell20.Summary = XrSummary8
        Me.XrTableCell20.Text = "XrTableCell20"
        Me.XrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell20.Weight = 0.36224295046479632
        '
        'XrTableCell21
        '
        Me.XrTableCell21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Gantt.PROGRAMADO_PARTICIPANTES")})
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.StylePriority.UseTextAlignment = False
        XrSummary9.FormatString = "{0:#,##0}"
        XrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell21.Summary = XrSummary9
        Me.XrTableCell21.Text = "XrTableCell21"
        Me.XrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell21.Weight = 0.37058071264231462
        '
        'xrtcPorc_Disponible
        '
        Me.xrtcPorc_Disponible.Name = "xrtcPorc_Disponible"
        Me.xrtcPorc_Disponible.Text = "xrtcPorc_Disponible"
        Me.xrtcPorc_Disponible.Weight = 0.14098225808306164
        '
        'xrtcMonto_Disponible
        '
        Me.xrtcMonto_Disponible.Name = "xrtcMonto_Disponible"
        Me.xrtcMonto_Disponible.Text = "xrtcMonto_Disponible"
        Me.xrtcMonto_Disponible.Weight = 0.36224298396173488
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(68.00003!, 22.95836!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(904.2173!, 25.0!)
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
        Me.XrTableCell28.Weight = 0.51759437744893211
        '
        'XrTableCell10
        '
        Me.XrTableCell10.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseBackColor = False
        Me.XrTableCell10.Text = "EJECUTADO"
        Me.XrTableCell10.Weight = 0.87380607254915021
        '
        'XrTableCell11
        '
        Me.XrTableCell11.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.StylePriority.UseBackColor = False
        Me.XrTableCell11.Text = "EN EJECUCIÓN"
        Me.XrTableCell11.Weight = 0.87380584598956668
        '
        'XrTableCell12
        '
        Me.XrTableCell12.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.StylePriority.UseBackColor = False
        Me.XrTableCell12.Text = "POR EJECUTARSE"
        Me.XrTableCell12.Weight = 0.87380572921783173
        '
        'XrTableCell31
        '
        Me.XrTableCell31.Name = "XrTableCell31"
        Me.XrTableCell31.Text = "DISPONIBLE"
        Me.XrTableCell31.Weight = 0.50322532978904422
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(68.0!, 12.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(930.5834!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "UTILIZACIÓN DE RECURSOS"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'DS_DL1
        '
        Me.DS_DL1.DataSetName = "DS_DL"
        Me.DS_DL1.EnforceConstraints = False
        Me.DS_DL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InformeUtilRecursos_GanttTableAdapter1
        '
        Me.InformeUtilRecursos_GanttTableAdapter1.ClearBeforeFill = True
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrChart1})
        Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("PROVEEDOR", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader2.HeightF = 414.0!
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'XrChart1
        '
        Me.XrChart1.BorderColor = System.Drawing.SystemColors.ControlText
        Me.XrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrChart1.LocationFloat = New DevExpress.Utils.PointFloat(48.54167!, 0.0!)
        Me.XrChart1.Name = "XrChart1"
        Me.XrChart1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.XrChart1.SeriesTemplate.Label = RangeBarSeriesLabel1
        Me.XrChart1.SeriesTemplate.View = OverlappedGanttSeriesView1
        Me.XrChart1.SizeF = New System.Drawing.SizeF(950.0417!, 414.0!)
        Me.XrChart1.Visible = False
        '
        'MONTO_UTILIZADO
        '
        Me.MONTO_UTILIZADO.DataMember = "InformeUtilRecursos_Gantt"
        Me.MONTO_UTILIZADO.DataSource = Me.DS_DL1
        Me.MONTO_UTILIZADO.Expression = "[EJECUCION_MONTO] + [EJECUTADO_MONTO] + [PROGRAMADO_MONTO]"
        Me.MONTO_UTILIZADO.Name = "MONTO_UTILIZADO"
        '
        'PORC_UTILIZADO
        '
        Me.PORC_UTILIZADO.DataMember = "InformeUtilRecursos_Gantt"
        Me.PORC_UTILIZADO.DataSource = Me.DS_DL1
        Me.PORC_UTILIZADO.Expression = "[EJECUTADO_PORC] + [EJECUCION_PORC] + [PROGRAMADO_PORC]"
        Me.PORC_UTILIZADO.Name = "PORC_UTILIZADO"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1})
        Me.PageHeader.HeightF = 45.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'xrInformeUtilRecursos_SubReporteGantt
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1, Me.GroupHeader2, Me.PageHeader})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.MONTO_UTILIZADO, Me.PORC_UTILIZADO})
        Me.DataAdapter = Me.InformeUtilRecursos_GanttTableAdapter1
        Me.DataMember = "InformeUtilRecursos_Gantt"
        Me.DataSource = Me.DS_DL1
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(41, 40, 0, 9)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.Version = "11.1"
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(RangeBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(OverlappedGanttSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
#End Region

    Public Sub CargarDatosPorEjercicioProveedor(ByVal ID_EJERCICIO As String, ByVal ID_PROVEEDOR_AF As Decimal)
        Me.InformeUtilRecursos_GanttTableAdapter1.Fill(Me.DS_DL1.InformeUtilRecursos_Gantt, ID_EJERCICIO, ID_PROVEEDOR_AF)
        Me.CargarGrafico()
        Me.xrtcPorc_Disponible.Text = Format(ObtenerPorcentajeDisponible, "#0.0")
        Me.xrtcMonto_Disponible.Text = Format(ObtenerMontoDisponible, "#,##0.00")
    End Sub

    Private Function ObtenerPorcentajeDisponible() As Decimal
        Dim Total As Decimal = 0
        Dim lResult As Object

        lResult = Me.DS_DL1.InformeUtilRecursos_Gantt.Compute("SUM(EJECUTADO_PORC)", "PROVEEDOR<>''")
        If lResult IsNot Nothing AndAlso Not IsDBNull(lResult) Then
            Total += CDec(lResult)
        End If
        lResult = Me.DS_DL1.InformeUtilRecursos_Gantt.Compute("SUM(EJECUCION_PORC)", "PROVEEDOR<>''")
        If lResult IsNot Nothing AndAlso Not IsDBNull(lResult) Then
            Total += CDec(lResult)
        End If
        lResult = Me.DS_DL1.InformeUtilRecursos_Gantt.Compute("SUM(PROGRAMADO_PORC)", "PROVEEDOR<>''")
        If lResult IsNot Nothing AndAlso Not IsDBNull(lResult) Then
            Total += CDec(lResult)
        End If
        If Total > 100 Then Return 0 Else Return (100 - Total)
    End Function

    Private Function ObtenerMontoDisponible() As Decimal
        Dim lAdjudicado As Decimal = 0
        Dim Total As Decimal = 0
        Dim lResult As Object

        lResult = Me.DS_DL1.InformeUtilRecursos_Gantt.Compute("SUM(EJECUTADO_MONTO)", "PROVEEDOR<>''")
        If lResult IsNot Nothing AndAlso Not IsDBNull(lResult) Then
            Total += CDec(lResult)
        End If
        lResult = Me.DS_DL1.InformeUtilRecursos_Gantt.Compute("SUM(EJECUCION_MONTO)", "PROVEEDOR<>''")
        If lResult IsNot Nothing AndAlso Not IsDBNull(lResult) Then
            Total += CDec(lResult)
        End If
        lResult = Me.DS_DL1.InformeUtilRecursos_Gantt.Compute("SUM(PROGRAMADO_MONTO)", "PROVEEDOR<>''")
        If lResult IsNot Nothing AndAlso Not IsDBNull(lResult) Then
            Total += CDec(lResult)
        End If
        If Me.DS_DL1.InformeUtilRecursos_Gantt.Rows.Count > 0 Then
            lAdjudicado = CDec(Me.DS_DL1.InformeUtilRecursos_Gantt.Rows(0)("ADJUDICADO"))
        End If
        If Total > lAdjudicado Then Return 0 Else Return (lAdjudicado - Total)
    End Function

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
        Dim dt As DS_DL.InformeUtilRecursos_GanttDataTable = Me.DS_DL1.InformeUtilRecursos_Gantt
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
            nombrePunto.Append(dt(i)("AREA_FORMATIVA").ToString)
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
                anotacion.Name = dt(i)("AREA_FORMATIVA").ToString.Replace(" ", "_") + "_Ejecutado" + CStr(i)
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
                anotacion.Name = dt(i)("AREA_FORMATIVA").ToString.Replace(" ", "_") + "_Ejecucion" + CStr(i)
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
                anotacion.Name = dt(i)("AREA_FORMATIVA").ToString.Replace(" ", "_") + "_Programado" + CStr(i)
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
            .Title.Text = "Areas Formativas"
            .Title.Visible = True
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

    Private Sub XrChart1_CustomDrawSeries(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.CustomDrawSeriesEventArgs) Handles XrChart1.CustomDrawSeries
        'Select Case e.Series.Name
        '    Case "Ejecutado"
        '        e.LegendText = "Ejecutado"
        '    Case "Ejecucion"
        '        e.LegendText = "Comprometido"
        '    Case "Programado"
        '        e.LegendText = "Proyectado"
        '    Case Else
        '        e.LegendTextVisible = False
        '        e.LegendMarkerVisible = False
        'End Select

    End Sub

    'Function ObtenerEtiquetaSerie(ByVal NombreSerie As String) As String
    '    Dim TotalPorcentaje As Object
    '    Dim TotalMonto As Object
    '    Dim TotalParticipantes As Object
    '    Dim Resultado As New StringBuilder

    '    Select Case NombreSerie
    '        Case "Ejecutado"
    '            TotalPorcentaje = Me.DS_DL1.InformeUtilRecursos_Gantt.Compute("SUM(EJECUTADO_PORC)", "PROVEEDOR<>''")
    '            TotalMonto = Me.DS_DL1.InformeUtilRecursos_Gantt.Compute("SUM(EJECUTADO_MONTO)", "PROVEEDOR<>''")
    '            TotalParticipantes = Me.DS_DL1.InformeUtilRecursos_Gantt.Compute("SUM(EJECUTADO_PARTICIPANTES)", "PROVEEDOR<>''")
    '        Case "Comprometido"
    '            TotalPorcentaje = Me.DS_DL1.InformeUtilRecursos_Gantt.Compute("SUM(EJECUCION_PORC)", "PROVEEDOR<>''")
    '            TotalMonto = Me.DS_DL1.InformeUtilRecursos_Gantt.Compute("SUM(EJECUCION_MONTO)", "PROVEEDOR<>''")
    '            TotalParticipantes = Me.DS_DL1.InformeUtilRecursos_Gantt.Compute("SUM(EJECUCION_PARTICIPANTES)", "PROVEEDOR<>''")
    '        Case "Proyectado"
    '            TotalPorcentaje = Me.DS_DL1.InformeUtilRecursos_Gantt.Compute("SUM(PROGRAMADO_PORC)", "PROVEEDOR<>''")
    '            TotalMonto = Me.DS_DL1.InformeUtilRecursos_Gantt.Compute("SUM(PROGRAMADO_MONTO)", "PROVEEDOR<>''")
    '            TotalParticipantes = Me.DS_DL1.InformeUtilRecursos_Gantt.Compute("SUM(PROGRAMADO_PARTICIPANTES)", "PROVEEDOR<>''")
    '        Case Else
    '            Return ""
    '    End Select

    '    Resultado.Append(NombreSerie.ToUpper + ":")
    '    Resultado.Append("  Recurso utilizado:")
    '    If TotalPorcentaje IsNot Nothing AndAlso Not IsDBNull(TotalPorcentaje) Then
    '        Resultado.Append(Format(CDec(TotalPorcentaje), "0%"))
    '    End If
    '    If TotalMonto IsNot Nothing AndAlso Not IsDBNull(TotalMonto) Then
    '        Resultado.Append("  Monto:")
    '        Resultado.Append(Format(CDec(TotalMonto), "$ #,##0.00"))
    '    End If
    '    If TotalParticipantes IsNot Nothing AndAlso Not IsDBNull(TotalParticipantes) Then
    '        Resultado.Append("  Participantes:")
    '        Resultado.Append(Format(CInt(TotalParticipantes), "#,##0"))
    '    End If

    '    Return Resultado.ToString
    'End Function
End Class