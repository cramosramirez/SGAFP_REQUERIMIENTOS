Public Class xrInformeEjecucionDE_SubReporteGenero
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region "Codigo Region"
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
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents DS_DL1 As SGAFP.DL.DS_DL
    Friend WithEvents InformeDEGeneroTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.InformeDEGeneroTableAdapter
    Friend WithEvents XrChart1 As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents pCantidadParticipantes As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents xrlblTotal As DevExpress.XtraReports.UI.XRLabel

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
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.xrlblTotal = New DevExpress.XtraReports.UI.XRLabel
        Me.XrChart1 = New DevExpress.XtraReports.UI.XRChart
        Me.DS_DL1 = New SGAFP.DL.DS_DL
        Me.InformeDEGeneroTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.InformeDEGeneroTableAdapter
        Me.pCantidadParticipantes = New DevExpress.XtraReports.Parameters.Parameter
        CType(Me.XrChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SimpleDiagram3D1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Pie3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Pie3DSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 8.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 15.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 8.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrlblTotal, Me.XrChart1})
        Me.GroupHeader1.HeightF = 415.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'xrlblTotal
        '
        Me.xrlblTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.xrlblTotal.LocationFloat = New DevExpress.Utils.PointFloat(62.5!, 386.1667!)
        Me.xrlblTotal.Name = "xrlblTotal"
        Me.xrlblTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlblTotal.SizeF = New System.Drawing.SizeF(635.0823!, 23.0!)
        Me.xrlblTotal.StylePriority.UseFont = False
        Me.xrlblTotal.Text = "Participantes Totales: [Parameters.pCantidadParticipantes!#,#]"
        '
        'XrChart1
        '
        Me.XrChart1.BorderColor = System.Drawing.SystemColors.ControlText
        Me.XrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrChart1.DataAdapter = Me.InformeDEGeneroTableAdapter1
        Me.XrChart1.DataMember = "InformeDEGenero"
        Me.XrChart1.DataSource = Me.DS_DL1
        SimpleDiagram3D1.LabelsResolveOverlappingMinIndent = 3
        SimpleDiagram3D1.RotationMatrixSerializable = "1;0;0;0;0;0.5;-0.866025403784439;0;0;0.866025403784439;0.5;0;0;0;0;1"
        Me.XrChart1.Diagram = SimpleDiagram3D1
        Me.XrChart1.Legend.Visible = False
        Me.XrChart1.LocationFloat = New DevExpress.Utils.PointFloat(62.5!, 0.0!)
        Me.XrChart1.Name = "XrChart1"
        Me.XrChart1.SeriesDataMember = "EJERCICIO"
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
        Pie3DSeriesView1.ExplodedDistancePercentage = 15
        Pie3DSeriesView1.ExplodedPointsFilters.AddRange(New DevExpress.XtraCharts.SeriesPointFilter() {New DevExpress.XtraCharts.SeriesPointFilter(DevExpress.XtraCharts.SeriesPointKey.Argument, DevExpress.XtraCharts.DataFilterCondition.Equal, "MUJERES")})
        Pie3DSeriesView1.ExplodeMode = DevExpress.XtraCharts.PieExplodeMode.UseFilters
        Me.XrChart1.SeriesTemplate.View = Pie3DSeriesView1
        Me.XrChart1.SizeF = New System.Drawing.SizeF(635.0824!, 384.0!)
        '
        'DS_DL1
        '
        Me.DS_DL1.DataSetName = "DS_DL"
        Me.DS_DL1.EnforceConstraints = False
        Me.DS_DL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InformeDEGeneroTableAdapter1
        '
        Me.InformeDEGeneroTableAdapter1.ClearBeforeFill = True
        '
        'pCantidadParticipantes
        '
        Me.pCantidadParticipantes.Name = "pCantidadParticipantes"
        Me.pCantidadParticipantes.ParameterType = DevExpress.XtraReports.Parameters.ParameterType.[Decimal]
        Me.pCantidadParticipantes.Value = 0
        '
        'xrInformeEjecucionDE_SubReporteGenero
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1})
        Me.DataSource = Me.DS_DL1
        Me.Margins = New System.Drawing.Printing.Margins(38, 40, 15, 8)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.pCantidadParticipantes})
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
#End Region

    Public Sub CargarGeneroPorEjercicioTipoSolic(ByVal ID_EJERCICIO As String, ByVal TIPO_SOLICITUD As Decimal)
        Me.InformeDEGeneroTableAdapter1.FillByEjercicioTipoSolic(Me.DS_DL1.InformeDEGenero, ID_EJERCICIO, TIPO_SOLICITUD)
    End Sub

    Private Sub XrChart1_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.CustomDrawSeriesPointEventArgs) Handles XrChart1.CustomDrawSeriesPoint
        e.LabelText = e.SeriesPoint(0).ToString + vbCrLf + e.SeriesPoint.Argument + vbCrLf + Format(e.SeriesPoint(0) / Me.Parameters("pCantidadParticipantes").Value, "0%")
    End Sub
End Class