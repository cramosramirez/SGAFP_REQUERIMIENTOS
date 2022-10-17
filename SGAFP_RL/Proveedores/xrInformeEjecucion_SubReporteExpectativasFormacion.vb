Public Class xrInformeEjecucion_SubReporteExpectativasFormacion
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region "Codigo Generado"

    Public Sub New()
        MyBase.New()

        Me.InitializeComponent()
    End Sub

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents XrChart1 As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents DS_DL1 As SGAFP.DL.DS_DL
    Friend WithEvents ParticipacionPorExpectativasFormacionTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.ParticipacionPorExpectativasFormacionTableAdapter

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim SimpleDiagram3D1 As DevExpress.XtraCharts.SimpleDiagram3D = New DevExpress.XtraCharts.SimpleDiagram3D
        Dim Pie3DSeriesLabel1 As DevExpress.XtraCharts.Pie3DSeriesLabel = New DevExpress.XtraCharts.Pie3DSeriesLabel
        Dim PiePointOptions1 As DevExpress.XtraCharts.PiePointOptions = New DevExpress.XtraCharts.PiePointOptions
        Dim PiePointOptions2 As DevExpress.XtraCharts.PiePointOptions = New DevExpress.XtraCharts.PiePointOptions
        Dim Pie3DSeriesView1 As DevExpress.XtraCharts.Pie3DSeriesView = New DevExpress.XtraCharts.Pie3DSeriesView
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.XrChart1 = New DevExpress.XtraReports.UI.XRChart
        Me.ParticipacionPorExpectativasFormacionTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.ParticipacionPorExpectativasFormacionTableAdapter
        Me.DS_DL1 = New SGAFP.DL.DS_DL
        CType(Me.XrChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SimpleDiagram3D1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Pie3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Pie3DSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 3.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 3.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 4.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrChart1})
        Me.ReportHeader.HeightF = 516.0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrChart1
        '
        Me.XrChart1.BorderColor = System.Drawing.SystemColors.ControlText
        Me.XrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrChart1.DataAdapter = Me.ParticipacionPorExpectativasFormacionTableAdapter1
        Me.XrChart1.DataMember = "ParticipacionPorExpectativasFormacion"
        Me.XrChart1.DataSource = Me.DS_DL1
        SimpleDiagram3D1.LabelsResolveOverlappingMinIndent = 3
        SimpleDiagram3D1.LayoutDirection = DevExpress.XtraCharts.LayoutDirection.Vertical
        SimpleDiagram3D1.RotationMatrixSerializable = "1;0;0;0;0;0.5;-0.866025403784439;0;0;0.866025403784439;0.5;0;0;0;0;1"
        Me.XrChart1.Diagram = SimpleDiagram3D1
        Me.XrChart1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
        Me.XrChart1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
        Me.XrChart1.Legend.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrChart1.Legend.Visible = False
        Me.XrChart1.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 0.0!)
        Me.XrChart1.Name = "XrChart1"
        Me.XrChart1.SeriesDataMember = "PROVEEDOR"
        Me.XrChart1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.XrChart1.SeriesTemplate.ArgumentDataMember = "EXPECTATIVA"
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
        Pie3DSeriesView1.ExplodeMode = DevExpress.XtraCharts.PieExplodeMode.All
        Pie3DSeriesView1.SizeAsPercentage = 80
        Me.XrChart1.SeriesTemplate.View = Pie3DSeriesView1
        Me.XrChart1.SizeF = New System.Drawing.SizeF(748.9999!, 511.25!)
        '
        'ParticipacionPorExpectativasFormacionTableAdapter1
        '
        Me.ParticipacionPorExpectativasFormacionTableAdapter1.ClearBeforeFill = True
        '
        'DS_DL1
        '
        Me.DS_DL1.DataSetName = "DS_DL"
        Me.DS_DL1.EnforceConstraints = False
        Me.DS_DL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'xrInformeEjecucion_SubReporteExpectativasFormacion
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
        Me.DataAdapter = Me.ParticipacionPorExpectativasFormacionTableAdapter1
        Me.DataMember = "ParticipacionPorExpectativasFormacion"
        Me.DataSource = Me.DS_DL1
        Me.Margins = New System.Drawing.Printing.Margins(39, 42, 3, 4)
        Me.Version = "10.1"
        CType(SimpleDiagram3D1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Pie3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Pie3DSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
#End Region
    Dim TotalParticipantes As Integer

    Public Sub CargarExpectativasPorEjercicio(ByVal ID_EJERCICIO As String)
        Me.ParticipacionPorExpectativasFormacionTableAdapter1.FillByEjercicio(Me.DS_DL1.ParticipacionPorExpectativasFormacion, ID_EJERCICIO)
        SetearTotalParticipantes()
    End Sub

    Public Sub CargarExpectativasPorEjercicioProveedor(ByVal ID_EJERCICIO As String, ByVal ID_PROVEEDOR_AF As Decimal)
        Me.ParticipacionPorExpectativasFormacionTableAdapter1.FillByEjercicioProveedor(Me.DS_DL1.ParticipacionPorExpectativasFormacion, ID_PROVEEDOR_AF, ID_EJERCICIO)
        SetearTotalParticipantes()
    End Sub

    Public Sub CargarExpectativasPorEjercicioSitioCapacitacion(ByVal ID_EJERCICIO As String, ByVal ID_SITIO_CAPACITACION As Decimal)
        Me.ParticipacionPorExpectativasFormacionTableAdapter1.FillByEjercicioSitioCapacitacion(Me.DS_DL1.ParticipacionPorExpectativasFormacion, ID_SITIO_CAPACITACION, ID_EJERCICIO)
        SetearTotalParticipantes()
    End Sub

    Private Sub SetearTotalParticipantes()
        Dim Resultado As Object

        TotalParticipantes = 0
        Resultado = Me.DS_DL1.ParticipacionPorExpectativasFormacion.Compute("SUM(PARTICIPANTES)", "EJERCICIO<>''")
        If Resultado IsNot Nothing AndAlso Not IsDBNull(Resultado) Then
            TotalParticipantes = CInt(Resultado)
        End If
    End Sub

    Private Sub XrChart1_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.CustomDrawSeriesPointEventArgs) Handles XrChart1.CustomDrawSeriesPoint
        e.LabelText = e.SeriesPoint(0).ToString + vbCrLf + e.SeriesPoint.Argument + vbCrLf + Format(e.SeriesPoint(0) / TotalParticipantes, "0%")
    End Sub
End Class