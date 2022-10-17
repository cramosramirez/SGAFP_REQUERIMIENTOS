Public Class xrInformeEjecucion
    Inherits DevExpress.XtraReports.UI.XtraReport
#Region "Generado"


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
    Private WithEvents XrInformeEjecucion_SubReporteRangoEdades1 As SGAFP.RL.xrInformeEjecucion_SubReporteRangoEdades
    Friend WithEvents GroupHeader7 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader8 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrSubreport4 As DevExpress.XtraReports.UI.XRSubreport
    Private WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrInformeEjecucion_SubReporteExpectativasFormacion1 As SGAFP.RL.xrInformeEjecucion_SubReporteExpectativasFormacion
    Friend WithEvents GroupHeader9 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrSubreport5 As DevExpress.XtraReports.UI.XRSubreport
    Private WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrInformeEjecucion_SubReporteSituacionLaboral1 As SGAFP.RL.xrInformeEjecucion_SubReporteSituacionLaboral
    Friend WithEvents XrSubreport6 As DevExpress.XtraReports.UI.XRSubreport
    Private WithEvents XrInformeEjecucion_SubReporteDepartamentoResidencia1 As SGAFP.RL.xrInformeEjecucion_SubReporteDepartamentoResidencia
    Friend WithEvents GroupHeader10 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrSubreport7 As DevExpress.XtraReports.UI.XRSubreport
    Private WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrInformeEjecucion_SubReporteEjecucion1 As SGAFP.RL.xrInformeEjecucion_SubReporteEjecucion
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Private WithEvents xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim SimpleDiagram3D1 As DevExpress.XtraCharts.SimpleDiagram3D = New DevExpress.XtraCharts.SimpleDiagram3D
        Dim Pie3DSeriesLabel1 As DevExpress.XtraCharts.Pie3DSeriesLabel = New DevExpress.XtraCharts.Pie3DSeriesLabel
        Dim PiePointOptions1 As DevExpress.XtraCharts.PiePointOptions = New DevExpress.XtraCharts.PiePointOptions
        Dim PiePointOptions2 As DevExpress.XtraCharts.PiePointOptions = New DevExpress.XtraCharts.PiePointOptions
        Dim Pie3DSeriesView1 As DevExpress.XtraCharts.Pie3DSeriesView = New DevExpress.XtraCharts.Pie3DSeriesView
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xrInformeEjecucion))
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary6 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrChart1 = New DevExpress.XtraReports.UI.XRChart
        Me.ParticipacionPorGeneroTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.ParticipacionPorGeneroTableAdapter
        Me.DS_DL1 = New SGAFP.DL.DS_DL
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel27 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrSubreport6 = New DevExpress.XtraReports.UI.XRSubreport
        Me.XrInformeEjecucion_SubReporteDepartamentoResidencia1 = New SGAFP.RL.xrInformeEjecucion_SubReporteDepartamentoResidencia
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupHeader3 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrPivotGrid1 = New DevExpress.XtraReports.UI.XRPivotGrid
        Me.ParticipacionPorMuniResidenciaTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.ParticipacionPorMuniResidenciaTableAdapter
        Me.fieldCODIGOREGION = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.fieldCODIGODEPTORESIDENCIA = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.XrPivotGridField1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.XrPivotGridField5 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.XrPivotGridField2 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.XrPivotGridField3 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.XrPivotGridField4 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.FormattingRule1 = New DevExpress.XtraReports.UI.FormattingRule
        Me.GroupHeader4 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.xrPivotAreasFormativas = New DevExpress.XtraReports.UI.XRPivotGrid
        Me.ParticipacionPorAreaFormativaTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.ParticipacionPorAreaFormativaTableAdapter
        Me.fieldCORRELATIVO = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.fieldAREAFORMATIVA = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.fieldCURSOS = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.XrPivotGridField6 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.fieldPARTICIPANTES = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.XrPivotGridField7 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupHeader5 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport
        Me.XrInformeEjecucion_SubReporteCursosPorAreas1 = New SGAFP.RL.xrInformeEjecucion_SubReporteCursosPorAreas
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupHeader6 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrSubreport2 = New DevExpress.XtraReports.UI.XRSubreport
        Me.XrInformeEjecucion_SubReporteNivelEscolaridad1 = New SGAFP.RL.xrInformeEjecucion_SubReporteNivelEscolaridad
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrSubreport3 = New DevExpress.XtraReports.UI.XRSubreport
        Me.XrInformeEjecucion_SubReporteRangoEdades1 = New SGAFP.RL.xrInformeEjecucion_SubReporteRangoEdades
        Me.GroupHeader7 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupHeader8 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrSubreport4 = New DevExpress.XtraReports.UI.XRSubreport
        Me.XrInformeEjecucion_SubReporteExpectativasFormacion1 = New SGAFP.RL.xrInformeEjecucion_SubReporteExpectativasFormacion
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupHeader9 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrSubreport5 = New DevExpress.XtraReports.UI.XRSubreport
        Me.XrInformeEjecucion_SubReporteSituacionLaboral1 = New SGAFP.RL.xrInformeEjecucion_SubReporteSituacionLaboral
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupHeader10 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrSubreport7 = New DevExpress.XtraReports.UI.XRSubreport
        Me.XrInformeEjecucion_SubReporteEjecucion1 = New SGAFP.RL.xrInformeEjecucion_SubReporteEjecucion
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        CType(Me.XrChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SimpleDiagram3D1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Pie3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Pie3DSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrInformeEjecucion_SubReporteDepartamentoResidencia1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrInformeEjecucion_SubReporteCursosPorAreas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrInformeEjecucion_SubReporteNivelEscolaridad1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrInformeEjecucion_SubReporteRangoEdades1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrInformeEjecucion_SubReporteExpectativasFormacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrInformeEjecucion_SubReporteSituacionLaboral1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrInformeEjecucion_SubReporteEjecucion1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Expanded = False
        Me.Detail.HeightF = 31.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.ForeColor = System.Drawing.Color.Black
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 442.7917!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(126.0417!, 19.20834!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseForeColor = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Total Participantes:"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipacionPorGenero.PARTICIPANTES")})
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.ForeColor = System.Drawing.Color.Black
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(138.5417!, 442.7917!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(159.3749!, 19.20831!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseForeColor = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:#,#}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel3.Summary = XrSummary1
        Me.XrLabel3.Text = "TotalParticipantes"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrChart1
        '
        Me.XrChart1.BorderColor = System.Drawing.SystemColors.ControlText
        Me.XrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrChart1.DataAdapter = Me.ParticipacionPorGeneroTableAdapter1
        Me.XrChart1.DataMember = "ParticipacionPorGenero"
        Me.XrChart1.DataSource = Me.DS_DL1
        SimpleDiagram3D1.LabelsResolveOverlappingMinIndent = 3
        SimpleDiagram3D1.RotationMatrixSerializable = "1;0;0;0;0;0.5;-0.866025403784439;0;0;0.866025403784439;0.5;0;0;0;0;1"
        Me.XrChart1.Diagram = SimpleDiagram3D1
        Me.XrChart1.Legend.Visible = False
        Me.XrChart1.LocationFloat = New DevExpress.Utils.PointFloat(77.0833!, 32.29167!)
        Me.XrChart1.Name = "XrChart1"
        Me.XrChart1.SeriesDataMember = "PROVEEDOR"
        Me.XrChart1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.XrChart1.SeriesTemplate.ArgumentDataMember = "SEXO"
        Pie3DSeriesLabel1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Pie3DSeriesLabel1.LineVisible = True
        Pie3DSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.[Default]
        Me.XrChart1.SeriesTemplate.Label = Pie3DSeriesLabel1
        PiePointOptions1.PercentOptions.ValueAsPercent = False
        PiePointOptions1.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues
        PiePointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        PiePointOptions1.ValueNumericOptions.Precision = 0
        Me.XrChart1.SeriesTemplate.LegendPointOptions = PiePointOptions1
        PiePointOptions2.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues
        PiePointOptions2.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Percent
        PiePointOptions2.ValueNumericOptions.Precision = 0
        Me.XrChart1.SeriesTemplate.PointOptions = PiePointOptions2
        Me.XrChart1.SeriesTemplate.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending
        Me.XrChart1.SeriesTemplate.SynchronizePointOptions = False
        Me.XrChart1.SeriesTemplate.ValueDataMembersSerializable = "PARTICIPANTES"
        Pie3DSeriesView1.ExplodedPointsFilters.AddRange(New DevExpress.XtraCharts.SeriesPointFilter() {New DevExpress.XtraCharts.SeriesPointFilter(DevExpress.XtraCharts.SeriesPointKey.Argument, DevExpress.XtraCharts.DataFilterCondition.Equal, "MUJERES")})
        Pie3DSeriesView1.ExplodeMode = DevExpress.XtraCharts.PieExplodeMode.UseFilters
        Me.XrChart1.SeriesTemplate.View = Pie3DSeriesView1
        Me.XrChart1.SizeF = New System.Drawing.SizeF(657.999!, 393.75!)
        '
        'ParticipacionPorGeneroTableAdapter1
        '
        Me.ParticipacionPorGeneroTableAdapter1.ClearBeforeFill = True
        '
        'DS_DL1
        '
        Me.DS_DL1.DataSetName = "DS_DL"
        Me.DS_DL1.EnforceConstraints = False
        Me.DS_DL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 32.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 12.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel8, Me.XrLabel1, Me.xrLabel27, Me.XrPictureBox2, Me.xrPictureBox1})
        Me.PageHeader.HeightF = 143.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(10.00013!, 95.79166!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(749.9999!, 19.20834!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "[SITIO_CAPACITACION]"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 73.99998!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(749.9999!, 19.20834!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "[PROVEEDOR]"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel27
        '
        Me.xrLabel27.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(207.2917!, 54.79163!)
        Me.xrLabel27.Name = "xrLabel27"
        Me.xrLabel27.SizeF = New System.Drawing.SizeF(353.8323!, 19.20834!)
        Me.xrLabel27.StylePriority.UseFont = False
        Me.xrLabel27.StylePriority.UseTextAlignment = False
        Me.xrLabel27.Text = "PROGRAMA HABIL TECNICO PERMANENTE [EJERCICIO]"
        Me.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.Image = CType(resources.GetObject("XrPictureBox2.Image"), System.Drawing.Image)
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(680.0!, 0.0!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(80.0!, 70.0!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'xrPictureBox1
        '
        Me.xrPictureBox1.Image = Global.SGAFP.RL.My.Resources.Resources.logoInsaforp
        Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 10.0!)
        Me.xrPictureBox1.Name = "xrPictureBox1"
        Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(145.875!, 45.99999!)
        Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrChart1, Me.XrLabel4, Me.XrLabel3})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("PROVEEDOR", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 472.0!
        Me.GroupHeader1.Level = 9
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.ForeColor = System.Drawing.Color.Navy
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 0.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(749.9999!, 19.20834!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseForeColor = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "PARTICIPACIÓN POR SEXO"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrSubreport6, Me.XrLabel7, Me.XrLabel6, Me.XrLabel5})
        Me.GroupHeader2.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.GroupHeader2.HeightF = 148.0!
        Me.GroupHeader2.Level = 8
        Me.GroupHeader2.Name = "GroupHeader2"
        Me.GroupHeader2.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        Me.GroupHeader2.StylePriority.UseFont = False
        '
        'XrSubreport6
        '
        Me.XrSubreport6.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 36.41663!)
        Me.XrSubreport6.Name = "XrSubreport6"
        Me.XrSubreport6.ReportSource = Me.XrInformeEjecucion_SubReporteDepartamentoResidencia1
        Me.XrSubreport6.SizeF = New System.Drawing.SizeF(770.0!, 54.25!)
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipacionPorGenero.PARTICIPANTES")})
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.ForeColor = System.Drawing.Color.Black
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(139.4584!, 102.165!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(159.3749!, 19.20831!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseForeColor = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:#,#}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel7.Summary = XrSummary2
        Me.XrLabel7.Text = "TotalParticipantes"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.ForeColor = System.Drawing.Color.Black
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(10.91673!, 102.165!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(126.0417!, 19.20834!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseForeColor = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Total Participantes:"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.ForeColor = System.Drawing.Color.Navy
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 0.0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(749.9999!, 19.20834!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseForeColor = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "PARTICIPANTES POR DEPARTAMENTO DE RESIDENCIA"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'GroupHeader3
        '
        Me.GroupHeader3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel9, Me.XrPivotGrid1})
        Me.GroupHeader3.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.GroupHeader3.HeightF = 204.0!
        Me.GroupHeader3.Level = 7
        Me.GroupHeader3.Name = "GroupHeader3"
        Me.GroupHeader3.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        Me.GroupHeader3.StylePriority.UseFont = False
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.ForeColor = System.Drawing.Color.Navy
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(10.00014!, 0.0!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(749.9999!, 19.20834!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseForeColor = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "PARTICIPANTES POR MUNICIPIO DE RESIDENCIA"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrPivotGrid1
        '
        Me.XrPivotGrid1.Appearance.Cell.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrPivotGrid1.Appearance.Cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrPivotGrid1.Appearance.CustomTotalCell.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrPivotGrid1.Appearance.FieldHeader.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrPivotGrid1.Appearance.FieldHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrPivotGrid1.Appearance.FieldValue.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrPivotGrid1.Appearance.FieldValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrPivotGrid1.Appearance.FieldValueGrandTotal.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrPivotGrid1.Appearance.FieldValueTotal.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrPivotGrid1.Appearance.FilterSeparator.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrPivotGrid1.Appearance.GrandTotalCell.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrPivotGrid1.Appearance.GrandTotalCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrPivotGrid1.Appearance.HeaderGroupLine.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrPivotGrid1.Appearance.Lines.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrPivotGrid1.Appearance.TotalCell.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrPivotGrid1.DataAdapter = Me.ParticipacionPorMuniResidenciaTableAdapter1
        Me.XrPivotGrid1.DataMember = "ParticipacionPorMuniResidencia"
        Me.XrPivotGrid1.DataSource = Me.DS_DL1
        Me.XrPivotGrid1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCODIGOREGION, Me.fieldCODIGODEPTORESIDENCIA, Me.XrPivotGridField1, Me.XrPivotGridField5, Me.XrPivotGridField2, Me.XrPivotGridField3, Me.XrPivotGridField4})
        Me.XrPivotGrid1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 40.00003!)
        Me.XrPivotGrid1.Name = "XrPivotGrid1"
        Me.XrPivotGrid1.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrPivotGrid1.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.XrPivotGrid1.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.XrPivotGrid1.OptionsPrint.PrintHeadersOnEveryPage = True
        Me.XrPivotGrid1.OptionsPrint.PrintRowHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.XrPivotGrid1.OptionsPrint.PrintUnusedFilterFields = False
        Me.XrPivotGrid1.OptionsView.ShowColumnGrandTotalHeader = False
        Me.XrPivotGrid1.SizeF = New System.Drawing.SizeF(769.9999!, 154.0!)
        '
        'ParticipacionPorMuniResidenciaTableAdapter1
        '
        Me.ParticipacionPorMuniResidenciaTableAdapter1.ClearBeforeFill = True
        '
        'fieldCODIGOREGION
        '
        Me.fieldCODIGOREGION.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldCODIGOREGION.AreaIndex = 0
        Me.fieldCODIGOREGION.FieldName = "CODIGO_REGION"
        Me.fieldCODIGOREGION.Name = "fieldCODIGOREGION"
        Me.fieldCODIGOREGION.Options.ShowTotals = False
        Me.fieldCODIGOREGION.Width = 0
        '
        'fieldCODIGODEPTORESIDENCIA
        '
        Me.fieldCODIGODEPTORESIDENCIA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldCODIGODEPTORESIDENCIA.AreaIndex = 1
        Me.fieldCODIGODEPTORESIDENCIA.FieldName = "CODIGO_DEPTO_RESIDENCIA"
        Me.fieldCODIGODEPTORESIDENCIA.Name = "fieldCODIGODEPTORESIDENCIA"
        Me.fieldCODIGODEPTORESIDENCIA.Options.ShowTotals = False
        Me.fieldCODIGODEPTORESIDENCIA.Width = 0
        '
        'XrPivotGridField1
        '
        Me.XrPivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.XrPivotGridField1.AreaIndex = 2
        Me.XrPivotGridField1.Caption = "DEPARTAMENTO"
        Me.XrPivotGridField1.FieldName = "DEPARTAMENTO_RESIDENCIA"
        Me.XrPivotGridField1.GrandTotalText = "TOTALES"
        Me.XrPivotGridField1.Name = "XrPivotGridField1"
        Me.XrPivotGridField1.Options.ShowTotals = False
        Me.XrPivotGridField1.Width = 170
        '
        'XrPivotGridField5
        '
        Me.XrPivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.XrPivotGridField5.AreaIndex = 3
        Me.XrPivotGridField5.Caption = "N°"
        Me.XrPivotGridField5.FieldName = "NUM_MUNICIPIO"
        Me.XrPivotGridField5.Name = "XrPivotGridField5"
        Me.XrPivotGridField5.Options.ShowTotals = False
        Me.XrPivotGridField5.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.XrPivotGridField5.Width = 30
        '
        'XrPivotGridField2
        '
        Me.XrPivotGridField2.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
                    Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.XrPivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.XrPivotGridField2.AreaIndex = 4
        Me.XrPivotGridField2.Caption = "MUNICIPIO"
        Me.XrPivotGridField2.FieldName = "MUNICIPIO_RESIDENCIA"
        Me.XrPivotGridField2.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.XrPivotGridField2.GrandTotalText = "TOTALES"
        Me.XrPivotGridField2.Name = "XrPivotGridField2"
        Me.XrPivotGridField2.Options.ShowTotals = False
        Me.XrPivotGridField2.Width = 250
        '
        'XrPivotGridField3
        '
        Me.XrPivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.XrPivotGridField3.AreaIndex = 0
        Me.XrPivotGridField3.Caption = "CANT. PARTICIPANTES"
        Me.XrPivotGridField3.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.XrPivotGridField3.FieldName = "PARTICIPANTES"
        Me.XrPivotGridField3.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.XrPivotGridField3.GrandTotalText = "CANTIDAD DE PARTICIPANTES"
        Me.XrPivotGridField3.Name = "XrPivotGridField3"
        Me.XrPivotGridField3.Options.ShowTotals = False
        Me.XrPivotGridField3.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.XrPivotGridField3.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.XrPivotGridField3.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.XrPivotGridField3.Width = 150
        '
        'XrPivotGridField4
        '
        Me.XrPivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.XrPivotGridField4.AreaIndex = 1
        Me.XrPivotGridField4.Caption = "%"
        Me.XrPivotGridField4.CellFormat.FormatString = "{0:0%}"
        Me.XrPivotGridField4.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.XrPivotGridField4.FieldName = "PORCENTAJE"
        Me.XrPivotGridField4.GrandTotalCellFormat.FormatString = "{0:0%}"
        Me.XrPivotGridField4.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.XrPivotGridField4.Name = "XrPivotGridField4"
        Me.XrPivotGridField4.Options.ShowTotals = False
        Me.XrPivotGridField4.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.XrPivotGridField4.Width = 50
        '
        'FormattingRule1
        '
        Me.FormattingRule1.DataMember = "ParticipacionPorMuniResidencia"
        Me.FormattingRule1.DataSource = Me.DS_DL1
        '
        '
        '
        Me.FormattingRule1.Formatting.Font = New System.Drawing.Font("Times New Roman", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormattingRule1.Name = "FormattingRule1"
        '
        'GroupHeader4
        '
        Me.GroupHeader4.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPivotAreasFormativas, Me.XrLabel10})
        Me.GroupHeader4.HeightF = 204.0!
        Me.GroupHeader4.Level = 6
        Me.GroupHeader4.Name = "GroupHeader4"
        Me.GroupHeader4.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        '
        'xrPivotAreasFormativas
        '
        Me.xrPivotAreasFormativas.Appearance.Cell.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrPivotAreasFormativas.Appearance.Cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrPivotAreasFormativas.Appearance.CustomTotalCell.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrPivotAreasFormativas.Appearance.FieldHeader.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrPivotAreasFormativas.Appearance.FieldHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xrPivotAreasFormativas.Appearance.FieldValue.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrPivotAreasFormativas.Appearance.FieldValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrPivotAreasFormativas.Appearance.FieldValueGrandTotal.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrPivotAreasFormativas.Appearance.FieldValueTotal.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrPivotAreasFormativas.Appearance.FilterSeparator.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrPivotAreasFormativas.Appearance.GrandTotalCell.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrPivotAreasFormativas.Appearance.GrandTotalCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrPivotAreasFormativas.Appearance.HeaderGroupLine.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrPivotAreasFormativas.Appearance.HeaderGroupLine.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrPivotAreasFormativas.Appearance.Lines.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrPivotAreasFormativas.Appearance.TotalCell.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrPivotAreasFormativas.DataAdapter = Me.ParticipacionPorAreaFormativaTableAdapter1
        Me.xrPivotAreasFormativas.DataMember = "ParticipacionPorAreaFormativa"
        Me.xrPivotAreasFormativas.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCORRELATIVO, Me.fieldAREAFORMATIVA, Me.fieldCURSOS, Me.XrPivotGridField6, Me.fieldPARTICIPANTES, Me.XrPivotGridField7})
        Me.xrPivotAreasFormativas.KeepTogether = False
        Me.xrPivotAreasFormativas.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 40.625!)
        Me.xrPivotAreasFormativas.Name = "xrPivotAreasFormativas"
        Me.xrPivotAreasFormativas.OptionsData.FilterByVisibleFieldsOnly = True
        Me.xrPivotAreasFormativas.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.xrPivotAreasFormativas.OptionsPrint.PrintUnusedFilterFields = False
        Me.xrPivotAreasFormativas.OptionsView.ShowColumnGrandTotalHeader = False
        Me.xrPivotAreasFormativas.OptionsView.ShowDataHeaders = False
        Me.xrPivotAreasFormativas.OptionsView.ShowFilterHeaders = False
        Me.xrPivotAreasFormativas.OptionsView.ShowFilterSeparatorBar = False
        Me.xrPivotAreasFormativas.SizeF = New System.Drawing.SizeF(770.0!, 153.375!)
        '
        'ParticipacionPorAreaFormativaTableAdapter1
        '
        Me.ParticipacionPorAreaFormativaTableAdapter1.ClearBeforeFill = True
        '
        'fieldCORRELATIVO
        '
        Me.fieldCORRELATIVO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldCORRELATIVO.AreaIndex = 0
        Me.fieldCORRELATIVO.Caption = "N°"
        Me.fieldCORRELATIVO.FieldName = "CORRELATIVO"
        Me.fieldCORRELATIVO.GrandTotalText = "TOTALES"
        Me.fieldCORRELATIVO.Name = "fieldCORRELATIVO"
        Me.fieldCORRELATIVO.Width = 30
        '
        'fieldAREAFORMATIVA
        '
        Me.fieldAREAFORMATIVA.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldAREAFORMATIVA.AreaIndex = 1
        Me.fieldAREAFORMATIVA.Caption = "AREAS DE FORMACION"
        Me.fieldAREAFORMATIVA.FieldName = "AREA_FORMATIVA"
        Me.fieldAREAFORMATIVA.GrandTotalText = "TOTALES"
        Me.fieldAREAFORMATIVA.Name = "fieldAREAFORMATIVA"
        Me.fieldAREAFORMATIVA.Width = 325
        '
        'fieldCURSOS
        '
        Me.fieldCURSOS.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldCURSOS.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldCURSOS.AreaIndex = 0
        Me.fieldCURSOS.Caption = "N° CURSOS POR AREA"
        Me.fieldCURSOS.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldCURSOS.FieldName = "CURSOS"
        Me.fieldCURSOS.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldCURSOS.GrandTotalText = "TOTALES"
        Me.fieldCURSOS.Name = "fieldCURSOS"
        Me.fieldCURSOS.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldCURSOS.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldCURSOS.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldCURSOS.Width = 135
        '
        'XrPivotGridField6
        '
        Me.XrPivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.XrPivotGridField6.AreaIndex = 1
        Me.XrPivotGridField6.Caption = "%"
        Me.XrPivotGridField6.CellFormat.FormatString = "{0:0.0%}"
        Me.XrPivotGridField6.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.XrPivotGridField6.FieldName = "PORCENTAJE_CURSOS"
        Me.XrPivotGridField6.GrandTotalCellFormat.FormatString = "{0:0.0%}"
        Me.XrPivotGridField6.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.XrPivotGridField6.GrandTotalText = "TOTALES"
        Me.XrPivotGridField6.Name = "XrPivotGridField6"
        Me.XrPivotGridField6.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.XrPivotGridField6.Width = 50
        '
        'fieldPARTICIPANTES
        '
        Me.fieldPARTICIPANTES.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
        Me.fieldPARTICIPANTES.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldPARTICIPANTES.AreaIndex = 2
        Me.fieldPARTICIPANTES.Caption = "N° DE PARTICIPANTES"
        Me.fieldPARTICIPANTES.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldPARTICIPANTES.FieldName = "PARTICIPANTES"
        Me.fieldPARTICIPANTES.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldPARTICIPANTES.GrandTotalText = "TOTALES"
        Me.fieldPARTICIPANTES.Name = "fieldPARTICIPANTES"
        Me.fieldPARTICIPANTES.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldPARTICIPANTES.Options.OLAPFilterUsingWhereClause = False
        Me.fieldPARTICIPANTES.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldPARTICIPANTES.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldPARTICIPANTES.Width = 125
        '
        'XrPivotGridField7
        '
        Me.XrPivotGridField7.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.XrPivotGridField7.AreaIndex = 3
        Me.XrPivotGridField7.Caption = "%"
        Me.XrPivotGridField7.CellFormat.FormatString = "{0:0.0%}"
        Me.XrPivotGridField7.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.XrPivotGridField7.FieldName = "PORCENTAJE_PARTICIPANTES"
        Me.XrPivotGridField7.GrandTotalCellFormat.FormatString = "{0:0.0%}"
        Me.XrPivotGridField7.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.XrPivotGridField7.GrandTotalText = "TOTALES"
        Me.XrPivotGridField7.Name = "XrPivotGridField7"
        Me.XrPivotGridField7.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.XrPivotGridField7.Width = 50
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.ForeColor = System.Drawing.Color.Navy
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(10.00014!, 0.0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(749.9999!, 19.20834!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseForeColor = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "AREAS FORMATIVAS"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'GroupHeader5
        '
        Me.GroupHeader5.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrSubreport1, Me.XrLabel11})
        Me.GroupHeader5.HeightF = 97.0!
        Me.GroupHeader5.Level = 5
        Me.GroupHeader5.Name = "GroupHeader5"
        Me.GroupHeader5.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        '
        'XrSubreport1
        '
        Me.XrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 34.33329!)
        Me.XrSubreport1.Name = "XrSubreport1"
        Me.XrSubreport1.ReportSource = Me.XrInformeEjecucion_SubReporteCursosPorAreas1
        Me.XrSubreport1.SizeF = New System.Drawing.SizeF(769.9999!, 50.08329!)
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.ForeColor = System.Drawing.Color.Navy
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(10.00014!, 0.0!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(749.9999!, 19.20834!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseForeColor = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "DETALLE DE CURSOS POR ÁREA"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'GroupHeader6
        '
        Me.GroupHeader6.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrSubreport2, Me.XrLabel14, Me.XrLabel13, Me.XrLabel12})
        Me.GroupHeader6.HeightF = 139.0!
        Me.GroupHeader6.Level = 4
        Me.GroupHeader6.Name = "GroupHeader6"
        Me.GroupHeader6.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        '
        'XrSubreport2
        '
        Me.XrSubreport2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 35.37496!)
        Me.XrSubreport2.Name = "XrSubreport2"
        Me.XrSubreport2.ReportSource = Me.XrInformeEjecucion_SubReporteNivelEscolaridad1
        Me.XrSubreport2.SizeF = New System.Drawing.SizeF(769.9999!, 54.24995!)
        '
        'XrLabel14
        '
        Me.XrLabel14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel14.ForeColor = System.Drawing.Color.Black
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 100.0!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(126.0417!, 19.20834!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseForeColor = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "Total Participantes:"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel13
        '
        Me.XrLabel13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipacionPorGenero.PARTICIPANTES")})
        Me.XrLabel13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel13.ForeColor = System.Drawing.Color.Black
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(139.4584!, 100.0!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(159.3749!, 19.20831!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseForeColor = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        XrSummary3.FormatString = "{0:#,#}"
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel13.Summary = XrSummary3
        Me.XrLabel13.Text = "TotalParticipantes"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.ForeColor = System.Drawing.Color.Navy
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(10.00021!, 0.0!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(749.9999!, 19.20834!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseForeColor = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "NIVEL DE ESCOLARIDAD DE PARTICIPANTES"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel16
        '
        Me.XrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipacionPorGenero.PARTICIPANTES")})
        Me.XrLabel16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel16.ForeColor = System.Drawing.Color.Black
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(138.5417!, 99.4166!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(159.3749!, 19.20831!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseForeColor = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        XrSummary4.FormatString = "{0:#,#}"
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel16.Summary = XrSummary4
        Me.XrLabel16.Text = "TotalParticipantes"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel15
        '
        Me.XrLabel15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel15.ForeColor = System.Drawing.Color.Black
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(9.083526!, 99.4166!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(126.0417!, 19.20834!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseForeColor = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "Total Participantes:"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrSubreport3
        '
        Me.XrSubreport3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 32.95822!)
        Me.XrSubreport3.Name = "XrSubreport3"
        Me.XrSubreport3.ReportSource = Me.XrInformeEjecucion_SubReporteRangoEdades1
        Me.XrSubreport3.SizeF = New System.Drawing.SizeF(769.9999!, 54.25008!)
        '
        'GroupHeader7
        '
        Me.GroupHeader7.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel17, Me.XrSubreport3, Me.XrLabel16, Me.XrLabel15})
        Me.GroupHeader7.HeightF = 135.0!
        Me.GroupHeader7.Level = 3
        Me.GroupHeader7.Name = "GroupHeader7"
        Me.GroupHeader7.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        '
        'XrLabel17
        '
        Me.XrLabel17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel17.ForeColor = System.Drawing.Color.Navy
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 0.0!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(749.9999!, 19.20834!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseForeColor = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = "RANGO DE EDADES DE LA POBLACIÓN ATENDIDA"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'GroupHeader8
        '
        Me.GroupHeader8.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel20, Me.XrLabel19, Me.XrSubreport4, Me.XrLabel18})
        Me.GroupHeader8.HeightF = 197.0!
        Me.GroupHeader8.Level = 1
        Me.GroupHeader8.Name = "GroupHeader8"
        Me.GroupHeader8.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        '
        'XrLabel20
        '
        Me.XrLabel20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipacionPorGenero.PARTICIPANTES")})
        Me.XrLabel20.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel20.ForeColor = System.Drawing.Color.Black
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(138.5417!, 167.7917!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(159.3749!, 19.20831!)
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UseForeColor = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        XrSummary5.FormatString = "{0:#,#}"
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel20.Summary = XrSummary5
        Me.XrLabel20.Text = "TotalParticipantes"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel19
        '
        Me.XrLabel19.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel19.ForeColor = System.Drawing.Color.Black
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(8.166821!, 167.7917!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(126.0417!, 19.20834!)
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseForeColor = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "Total Participantes:"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrSubreport4
        '
        Me.XrSubreport4.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 35.37496!)
        Me.XrSubreport4.Name = "XrSubreport4"
        Me.XrSubreport4.ReportSource = Me.XrInformeEjecucion_SubReporteExpectativasFormacion1
        Me.XrSubreport4.SizeF = New System.Drawing.SizeF(770.0!, 120.9167!)
        '
        'XrLabel18
        '
        Me.XrLabel18.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel18.ForeColor = System.Drawing.Color.Navy
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(10.00021!, 0.0!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(749.9999!, 19.20834!)
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseForeColor = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "EXPECTATIVAS POSTERIOR A LA CAPACITACIÓN"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'GroupHeader9
        '
        Me.GroupHeader9.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel23, Me.XrLabel22, Me.XrSubreport5, Me.XrLabel21})
        Me.GroupHeader9.HeightF = 138.0!
        Me.GroupHeader9.Level = 2
        Me.GroupHeader9.Name = "GroupHeader9"
        Me.GroupHeader9.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        '
        'XrLabel23
        '
        Me.XrLabel23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipacionPorGenero.PARTICIPANTES")})
        Me.XrLabel23.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel23.ForeColor = System.Drawing.Color.Black
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(138.5417!, 101.7917!)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(159.3749!, 19.20831!)
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.StylePriority.UseForeColor = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        XrSummary6.FormatString = "{0:#,#}"
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel23.Summary = XrSummary6
        Me.XrLabel23.Text = "TotalParticipantes"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel22
        '
        Me.XrLabel22.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel22.ForeColor = System.Drawing.Color.Black
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(9.083526!, 101.7917!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(126.0417!, 19.20834!)
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseForeColor = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.Text = "Total Participantes:"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrSubreport5
        '
        Me.XrSubreport5.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 35.37496!)
        Me.XrSubreport5.Name = "XrSubreport5"
        Me.XrSubreport5.ReportSource = Me.XrInformeEjecucion_SubReporteSituacionLaboral1
        Me.XrSubreport5.SizeF = New System.Drawing.SizeF(770.0!, 54.25!)
        '
        'XrLabel21
        '
        Me.XrLabel21.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel21.ForeColor = System.Drawing.Color.Navy
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(9.083526!, 0.0!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(749.9999!, 19.20834!)
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseForeColor = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = "SITUACION LABORAL DE PARTICIPANTES"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'GroupHeader10
        '
        Me.GroupHeader10.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrSubreport7, Me.XrLabel24})
        Me.GroupHeader10.HeightF = 116.0!
        Me.GroupHeader10.Name = "GroupHeader10"
        '
        'XrSubreport7
        '
        Me.XrSubreport7.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 34.33329!)
        Me.XrSubreport7.Name = "XrSubreport7"
        Me.XrSubreport7.ReportSource = Me.XrInformeEjecucion_SubReporteEjecucion1
        Me.XrSubreport7.SizeF = New System.Drawing.SizeF(770.0!, 54.25!)
        '
        'XrLabel24
        '
        Me.XrLabel24.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel24.ForeColor = System.Drawing.Color.Navy
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(8.166821!, 0.0!)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(749.9999!, 19.20834!)
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.StylePriority.UseForeColor = False
        Me.XrLabel24.StylePriority.UseTextAlignment = False
        Me.XrLabel24.Text = "RESUMEN DE EJECUCIÓN"
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo2, Me.xrPageInfo1})
        Me.PageFooter.HeightF = 41.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'xrPageInfo1
        '
        Me.xrPageInfo1.Format = "{0:dddd, dd' de 'MMMM' de 'yyyy'  Hora: 'hh:mm tt}"
        Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 7.000023!)
        Me.xrPageInfo1.Name = "xrPageInfo1"
        Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
        '
        'xrPageInfo2
        '
        Me.xrPageInfo2.Format = "Pagina {0} de {1}"
        Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(463.0001!, 6.999974!)
        Me.xrPageInfo2.Name = "xrPageInfo2"
        Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(306.9999!, 23.00002!)
        Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrInformeEjecucion
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.GroupHeader1, Me.GroupHeader2, Me.GroupHeader3, Me.GroupHeader4, Me.GroupHeader5, Me.GroupHeader6, Me.GroupHeader7, Me.GroupHeader8, Me.GroupHeader9, Me.GroupHeader10, Me.PageFooter})
        Me.DataMember = "ParticipacionPorGenero"
        Me.DataSource = Me.DS_DL1
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.FormattingRule1})
        Me.Margins = New System.Drawing.Printing.Margins(39, 41, 32, 12)
        Me.Version = "10.1"
        CType(SimpleDiagram3D1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Pie3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Pie3DSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrInformeEjecucion_SubReporteDepartamentoResidencia1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrInformeEjecucion_SubReporteCursosPorAreas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrInformeEjecucion_SubReporteNivelEscolaridad1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrInformeEjecucion_SubReporteRangoEdades1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrInformeEjecucion_SubReporteExpectativasFormacion1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrInformeEjecucion_SubReporteSituacionLaboral1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrInformeEjecucion_SubReporteEjecucion1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Private WithEvents xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Private WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Private WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrChart1 As DevExpress.XtraReports.UI.XRChart
    Private WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DS_DL1 As SGAFP.DL.DS_DL
    Friend WithEvents ParticipacionPorGeneroTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.ParticipacionPorGeneroTableAdapter
    Private WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader3 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrPivotGrid1 As DevExpress.XtraReports.UI.XRPivotGrid
    Friend WithEvents ParticipacionPorMuniResidenciaTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.ParticipacionPorMuniResidenciaTableAdapter
    Friend WithEvents XrPivotGridField1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents XrPivotGridField2 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents XrPivotGridField3 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Private WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Protected WithEvents FormattingRule1 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents XrPivotGridField4 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents XrPivotGridField5 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldCODIGODEPTORESIDENCIA As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldCODIGOREGION As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents GroupHeader4 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrPivotAreasFormativas As DevExpress.XtraReports.UI.XRPivotGrid
    Friend WithEvents ParticipacionPorAreaFormativaTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.ParticipacionPorAreaFormativaTableAdapter
    Friend WithEvents fieldCORRELATIVO As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldAREAFORMATIVA As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldCURSOS As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldPARTICIPANTES As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents XrPivotGridField6 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents XrPivotGridField7 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents GroupHeader5 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    Private WithEvents XrInformeEjecucion_SubReporteCursosPorAreas1 As SGAFP.RL.xrInformeEjecucion_SubReporteCursosPorAreas
    Friend WithEvents GroupHeader6 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrSubreport2 As DevExpress.XtraReports.UI.XRSubreport
    Private WithEvents XrInformeEjecucion_SubReporteNivelEscolaridad1 As SGAFP.RL.xrInformeEjecucion_SubReporteNivelEscolaridad
    Friend WithEvents XrSubreport3 As DevExpress.XtraReports.UI.XRSubreport
    Private WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel


#End Region

    Private Enum Tipo
        Ejercicio
        EjercicioProveedor
        EjercicioProveedorSitio
    End Enum

    Private TotalParticipantes As Integer
    Private TipoInforme As Tipo
    Private mID_EJERCICIO As String
    Private mID_PROVEEDOR_AF As Decimal
    Private mID_SITIO_CAPACITACION As Decimal

    Public Sub CargarDatosPorEjercicio(ByVal ID_EJERCICIO As String)
        Me.DS_DL1.Clear()
        Me.ParticipacionPorGeneroTableAdapter1.FillByEjercicio(DS_DL1.ParticipacionPorGenero, ID_EJERCICIO)
        Me.ParticipacionPorMuniResidenciaTableAdapter1.FillByEjercicio(DS_DL1.ParticipacionPorMuniResidencia, ID_EJERCICIO)
        Me.ParticipacionPorAreaFormativaTableAdapter1.FillByEjercicio(DS_DL1.ParticipacionPorAreaFormativa, ID_EJERCICIO)

        mID_EJERCICIO = ID_EJERCICIO
        TipoInforme = Tipo.Ejercicio
        SetearTotalParticipantes()
    End Sub

    Public Sub CargarDatosPorEjercicioProveedor(ByVal ID_EJERCICIO As String, ByVal ID_PROVEEDOR_AF As Decimal)
        Me.DS_DL1.Clear()
        Me.ParticipacionPorGeneroTableAdapter1.FillByEjercicioProveedor(DS_DL1.ParticipacionPorGenero, ID_PROVEEDOR_AF, ID_EJERCICIO)
        Me.ParticipacionPorMuniResidenciaTableAdapter1.FillByEjercicioProveedor(DS_DL1.ParticipacionPorMuniResidencia, ID_PROVEEDOR_AF, ID_EJERCICIO)
        Me.ParticipacionPorAreaFormativaTableAdapter1.FillByEjercicioProveedor(DS_DL1.ParticipacionPorAreaFormativa, ID_EJERCICIO, ID_PROVEEDOR_AF)

        mID_EJERCICIO = ID_EJERCICIO
        mID_PROVEEDOR_AF = ID_PROVEEDOR_AF
        TipoInforme = Tipo.EjercicioProveedor
        SetearTotalParticipantes()
    End Sub

    Public Sub CargarDatosPorEjercicioSitioCapacitacion(ByVal ID_EJERCICIO As String, ByVal ID_SITIO_CAPACITACION As Decimal)
        Me.DS_DL1.Clear()
        Me.ParticipacionPorGeneroTableAdapter1.FillByEjercicioSitioCapacitacion(DS_DL1.ParticipacionPorGenero, ID_SITIO_CAPACITACION, ID_EJERCICIO)
        Me.ParticipacionPorMuniResidenciaTableAdapter1.FillByEjercicioSitioCapacitacion(DS_DL1.ParticipacionPorMuniResidencia, ID_SITIO_CAPACITACION, ID_EJERCICIO)
        Me.ParticipacionPorAreaFormativaTableAdapter1.FillByEjercicioSitioCapacitacion(DS_DL1.ParticipacionPorAreaFormativa, ID_EJERCICIO, ID_SITIO_CAPACITACION)

        mID_EJERCICIO = ID_EJERCICIO
        mID_SITIO_CAPACITACION = ID_SITIO_CAPACITACION
        TipoInforme = Tipo.EjercicioProveedorSitio
        SetearTotalParticipantes()
    End Sub


    Private Sub XrPivotGrid1_CustomUnboundFieldData(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.CustomFieldDataEventArgs) Handles XrPivotGrid1.CustomUnboundFieldData
        If e.Field.FieldName = "PORCENTAJE" Then
            Dim TotalParticipantes As Object = DS_DL1.ParticipacionPorMuniResidencia.Compute("SUM(PARTICIPANTES)", "EJERCICIO <> ''")
            If Not IsDBNull(TotalParticipantes) Then
                Dim Participantes_x_Munip As Integer = Convert.ToInt32(e.GetListSourceColumnValue("PARTICIPANTES"))
                Dim Total As Integer = Convert.ToInt32(TotalParticipantes)

                e.Value = Participantes_x_Munip / Total
            Else
                e.Value = 0
            End If
        End If
        If e.Field.FieldName = "NUM_MUNICIPIO" Then
            e.Value = e.ListSourceRowIndex + 1
        End If
    End Sub

    Private Sub xrPivotAreasFormativas_CustomUnboundFieldData(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.CustomFieldDataEventArgs) Handles xrPivotAreasFormativas.CustomUnboundFieldData
        If e.Field.FieldName = "PORCENTAJE_CURSOS" Then
            Dim TotalCursos As Object = DS_DL1.ParticipacionPorAreaFormativa.Compute("SUM(CURSOS)", "EJERCICIO <> ''")
            If Not IsDBNull(TotalCursos) Then
                Dim Cursos_x_Area As Integer = Convert.ToInt32(e.GetListSourceColumnValue("CURSOS"))
                Dim Total As Integer = Convert.ToInt32(TotalCursos)

                e.Value = Cursos_x_Area / Total
            Else
                e.Value = 0
            End If
        End If
        If e.Field.FieldName = "PORCENTAJE_PARTICIPANTES" Then
            Dim TotalParticipantes As Object = DS_DL1.ParticipacionPorAreaFormativa.Compute("SUM(PARTICIPANTES)", "EJERCICIO <> ''")
            If Not IsDBNull(TotalParticipantes) Then
                Dim Participantes_x_Area As Integer = Convert.ToInt32(e.GetListSourceColumnValue("PARTICIPANTES"))
                Dim Total As Integer = Convert.ToInt32(TotalParticipantes)

                e.Value = Participantes_x_Area / Total
            Else
                e.Value = 0
            End If
        End If
    End Sub

    Private Sub XrSubreport1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport1.BeforePrint
        Dim detail As xrInformeEjecucion_SubReporteCursosPorAreas = TryCast(Me.XrSubreport1.ReportSource, xrInformeEjecucion_SubReporteCursosPorAreas)
        If detail IsNot Nothing Then
            If Not GetCurrentColumnValue("EJERCICIO") Is DBNull.Value Then
                Select Case TipoInforme
                    Case Tipo.Ejercicio
                        detail.CargarCursosPorEjercicio(mID_EJERCICIO)
                    Case Tipo.EjercicioProveedor
                        detail.CargarCursosPorEjercicioProveedor(mID_EJERCICIO, mID_PROVEEDOR_AF)
                    Case Tipo.EjercicioProveedorSitio
                        detail.CargarCursosPorEjercicioSitioCapacitacion(mID_EJERCICIO, mID_SITIO_CAPACITACION)
                End Select
                detail.FillDataSource()
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub XrSubreport2_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport2.BeforePrint
        Dim detail As xrInformeEjecucion_SubReporteNivelEscolaridad = TryCast(Me.XrSubreport2.ReportSource, xrInformeEjecucion_SubReporteNivelEscolaridad)
        If detail IsNot Nothing Then
            If Not GetCurrentColumnValue("EJERCICIO") Is DBNull.Value Then
                Select Case TipoInforme
                    Case Tipo.Ejercicio
                        detail.CargarNivelEscolaridadPorEjercicio(mID_EJERCICIO)
                    Case Tipo.EjercicioProveedor
                        detail.CargarNivelEscolaridadPorEjercicioProveedor(mID_EJERCICIO, mID_PROVEEDOR_AF)
                    Case Tipo.EjercicioProveedorSitio
                        detail.CargarNivelEscolaridadPorEjercicioSitioCapacitacion(mID_EJERCICIO, mID_SITIO_CAPACITACION)
                End Select
                detail.FillDataSource()
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub XrSubreport3_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport3.BeforePrint
        Dim detail As xrInformeEjecucion_SubReporteRangoEdades = TryCast(Me.XrSubreport3.ReportSource, xrInformeEjecucion_SubReporteRangoEdades)
        If detail IsNot Nothing Then
            If Not GetCurrentColumnValue("EJERCICIO") Is DBNull.Value Then
                Select Case TipoInforme
                    Case Tipo.Ejercicio
                        detail.CargarRangoEdadPorEjercicio(mID_EJERCICIO)
                    Case Tipo.EjercicioProveedor
                        detail.CargarRangoEdadPorEjercicioProveedor(mID_EJERCICIO, mID_PROVEEDOR_AF)
                    Case Tipo.EjercicioProveedorSitio
                        detail.CargarRangoEdadPorEjercicioSitioCapacitacion(mID_EJERCICIO, mID_SITIO_CAPACITACION)
                End Select
                detail.FillDataSource()
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub XrSubreport4_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport4.BeforePrint
        Dim detail As xrInformeEjecucion_SubReporteExpectativasFormacion = TryCast(Me.XrSubreport4.ReportSource, xrInformeEjecucion_SubReporteExpectativasFormacion)
        If detail IsNot Nothing Then
            If Not GetCurrentColumnValue("EJERCICIO") Is DBNull.Value Then
                Select Case TipoInforme
                    Case Tipo.Ejercicio
                        detail.CargarExpectativasPorEjercicio(mID_EJERCICIO)
                    Case Tipo.EjercicioProveedor
                        detail.CargarExpectativasPorEjercicioProveedor(mID_EJERCICIO, mID_PROVEEDOR_AF)
                    Case Tipo.EjercicioProveedorSitio
                        detail.CargarExpectativasPorEjercicioSitioCapacitacion(mID_EJERCICIO, mID_SITIO_CAPACITACION)
                End Select
                detail.FillDataSource()
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub XrSubreport5_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport5.BeforePrint
        Dim detail As xrInformeEjecucion_SubReporteSituacionLaboral = TryCast(Me.XrSubreport5.ReportSource, xrInformeEjecucion_SubReporteSituacionLaboral)
        If detail IsNot Nothing Then
            If Not GetCurrentColumnValue("EJERCICIO") Is DBNull.Value Then
                Select Case TipoInforme
                    Case Tipo.Ejercicio
                        detail.CargarSituacionLaboralPorEjercicio(mID_EJERCICIO)
                    Case Tipo.EjercicioProveedor
                        detail.CargarSituacionLaboralPorEjercicioProveedor(mID_EJERCICIO, mID_PROVEEDOR_AF)
                    Case Tipo.EjercicioProveedorSitio
                        detail.CargarSituacionLaboralPorEjercicioSitioCapacitacion(mID_EJERCICIO, mID_SITIO_CAPACITACION)
                End Select
                detail.FillDataSource()
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub XrSubreport6_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport6.BeforePrint
        Dim detail As xrInformeEjecucion_SubReporteDepartamentoResidencia = TryCast(Me.XrSubreport6.ReportSource, xrInformeEjecucion_SubReporteDepartamentoResidencia)
        If detail IsNot Nothing Then
            If Not GetCurrentColumnValue("EJERCICIO") Is DBNull.Value Then
                Select Case TipoInforme
                    Case Tipo.Ejercicio
                        detail.CargarDepartamentosPorEjercicio(mID_EJERCICIO)
                    Case Tipo.EjercicioProveedor
                        detail.CargarDepartamentosPorEjercicioProveedor(mID_EJERCICIO, mID_PROVEEDOR_AF)
                    Case Tipo.EjercicioProveedorSitio
                        detail.CargarDepartamentosPorEjercicioSitioCapacitacion(mID_EJERCICIO, mID_SITIO_CAPACITACION)
                End Select
                detail.FillDataSource()
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub XrSubreport7_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport7.BeforePrint
        If TipoInforme < Tipo.EjercicioProveedorSitio Then
            Dim detail As xrInformeEjecucion_SubReporteEjecucion = TryCast(Me.XrSubreport7.ReportSource, xrInformeEjecucion_SubReporteEjecucion)
            If detail IsNot Nothing Then
                If Not GetCurrentColumnValue("EJERCICIO") Is DBNull.Value Then
                    Select Case TipoInforme
                        Case Tipo.Ejercicio
                            detail.CargarResumenEjecucionPorEjercicio(mID_EJERCICIO)
                            detail.FillDataSource()
                            e.Cancel = False
                        Case Tipo.EjercicioProveedor
                            detail.CargarResumenEjecucionPorEjercicioProveedor(mID_EJERCICIO, mID_PROVEEDOR_AF)
                            detail.FillDataSource()
                            e.Cancel = False
                    End Select
                Else
                    e.Cancel = True
                End If
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub XrChart1_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.CustomDrawSeriesPointEventArgs) Handles XrChart1.CustomDrawSeriesPoint
        e.LabelText = e.SeriesPoint(0).ToString + vbCrLf + e.SeriesPoint.Argument + vbCrLf + Format(e.SeriesPoint(0) / TotalParticipantes, "0%")
    End Sub

    Private Sub SetearTotalParticipantes()
        Dim Resultado As Object

        TotalParticipantes = 0
        Resultado = Me.DS_DL1.ParticipacionPorGenero.Compute("SUM(PARTICIPANTES)", "EJERCICIO<>''")
        If Resultado IsNot Nothing AndAlso Not IsDBNull(Resultado) Then
            TotalParticipantes = CInt(Resultado)
        End If
    End Sub

End Class