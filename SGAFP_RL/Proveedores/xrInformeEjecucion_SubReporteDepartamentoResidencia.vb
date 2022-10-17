Public Class xrInformeEjecucion_SubReporteDepartamentoResidencia
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region "  Código Generado"
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
    Friend WithEvents XrChart2 As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents DS_DL1 As SGAFP.DL.DS_DL
    Friend WithEvents ParticipacionPorDeptoResidenciaTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.ParticipacionPorDeptoResidenciaTableAdapter

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim XyDiagram3D1 As DevExpress.XtraCharts.XYDiagram3D = New DevExpress.XtraCharts.XYDiagram3D
        Dim Bar3DSeriesLabel1 As DevExpress.XtraCharts.Bar3DSeriesLabel = New DevExpress.XtraCharts.Bar3DSeriesLabel
        Dim PointOptions1 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions
        Dim PointOptions2 As DevExpress.XtraCharts.PointOptions = New DevExpress.XtraCharts.PointOptions
        Dim SideBySideBar3DSeriesView1 As DevExpress.XtraCharts.SideBySideBar3DSeriesView = New DevExpress.XtraCharts.SideBySideBar3DSeriesView
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.XrChart2 = New DevExpress.XtraReports.UI.XRChart
        Me.ParticipacionPorDeptoResidenciaTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.ParticipacionPorDeptoResidenciaTableAdapter
        Me.DS_DL1 = New SGAFP.DL.DS_DL
        CType(Me.XrChart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram3D1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Bar3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBar3DSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 9.0!
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
        Me.BottomMargin.HeightF = 0.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrChart2})
        Me.ReportHeader.HeightF = 437.0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrChart2
        '
        Me.XrChart2.BorderColor = System.Drawing.SystemColors.ControlText
        Me.XrChart2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrChart2.DataAdapter = Me.ParticipacionPorDeptoResidenciaTableAdapter1
        Me.XrChart2.DataMember = "ParticipacionPorDeptoResidencia"
        Me.XrChart2.DataSource = Me.DS_DL1
        XyDiagram3D1.AxisX.Label.Angle = -40
        XyDiagram3D1.AxisX.Label.Antialiasing = True
        XyDiagram3D1.AxisX.Label.Font = New System.Drawing.Font("Arial", 8.0!)
        XyDiagram3D1.AxisX.Label.Position = DevExpress.XtraCharts.AxisLabel3DPosition.Left
        XyDiagram3D1.AxisX.Range.SideMarginsEnabled = False
        XyDiagram3D1.AxisY.Range.SideMarginsEnabled = True
        XyDiagram3D1.PerspectiveAngle = 0
        XyDiagram3D1.RotationMatrixSerializable = "0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.34" & _
            "2020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;" & _
            "1"
        XyDiagram3D1.VerticalScrollPercent = 10
        XyDiagram3D1.ZoomPercent = 110
        Me.XrChart2.Diagram = XyDiagram3D1
        Me.XrChart2.Legend.Visible = False
        Me.XrChart2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrChart2.Name = "XrChart2"
        Me.XrChart2.SeriesDataMember = "DEPARTAMENTO_RESIDENCIA"
        Me.XrChart2.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.XrChart2.SeriesSorting = DevExpress.XtraCharts.SortingMode.Ascending
        Me.XrChart2.SeriesTemplate.ArgumentDataMember = "DEPARTAMENTO_RESIDENCIA"
        Bar3DSeriesLabel1.LineVisible = True
        Bar3DSeriesLabel1.Visible = True
        Me.XrChart2.SeriesTemplate.Label = Bar3DSeriesLabel1
        PointOptions1.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues
        PointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Percent
        PointOptions1.ValueNumericOptions.Precision = 0
        Me.XrChart2.SeriesTemplate.LegendPointOptions = PointOptions1
        PointOptions2.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
        PointOptions2.ValueNumericOptions.Precision = 0
        Me.XrChart2.SeriesTemplate.PointOptions = PointOptions2
        Me.XrChart2.SeriesTemplate.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending
        Me.XrChart2.SeriesTemplate.SynchronizePointOptions = False
        Me.XrChart2.SeriesTemplate.ValueDataMembersSerializable = "PARTICIPANTES"
        SideBySideBar3DSeriesView1.BarWidth = 0.5
        Me.XrChart2.SeriesTemplate.View = SideBySideBar3DSeriesView1
        Me.XrChart2.SideBySideBarDistanceVariable = 2
        Me.XrChart2.SideBySideEqualBarWidth = True
        Me.XrChart2.SizeF = New System.Drawing.SizeF(767.0!, 437.0!)
        '
        'ParticipacionPorDeptoResidenciaTableAdapter1
        '
        Me.ParticipacionPorDeptoResidenciaTableAdapter1.ClearBeforeFill = True
        '
        'DS_DL1
        '
        Me.DS_DL1.DataSetName = "DS_DL"
        Me.DS_DL1.EnforceConstraints = False
        Me.DS_DL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'xrInformeEjecucion_SubReporteDepartamentoResidencia
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
        Me.DataAdapter = Me.ParticipacionPorDeptoResidenciaTableAdapter1
        Me.DataMember = "ParticipacionPorDeptoResidencia"
        Me.DataSource = Me.DS_DL1
        Me.Margins = New System.Drawing.Printing.Margins(40, 43, 3, 0)
        Me.Version = "10.1"
        CType(XyDiagram3D1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Bar3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBar3DSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
#End Region


    Public Sub CargarDepartamentosPorEjercicio(ByVal ID_EJERCICIO As String)
        Me.ParticipacionPorDeptoResidenciaTableAdapter1.FillByEjercicio(Me.DS_DL1.ParticipacionPorDeptoResidencia, ID_EJERCICIO)
        SetearTotalParticipantes()
    End Sub

    Public Sub CargarDepartamentosPorEjercicioProveedor(ByVal ID_EJERCICIO As String, ByVal ID_PROVEEDOR_AF As Decimal)
        Me.ParticipacionPorDeptoResidenciaTableAdapter1.FillByEjercicioProveedor(Me.DS_DL1.ParticipacionPorDeptoResidencia, ID_PROVEEDOR_AF, ID_EJERCICIO)
        SetearTotalParticipantes()
    End Sub

    Public Sub CargarDepartamentosPorEjercicioSitioCapacitacion(ByVal ID_EJERCICIO As String, ByVal ID_SITIO_CAPACITACION As Decimal)
        Me.ParticipacionPorDeptoResidenciaTableAdapter1.FillByEjercicioSitioCapacitacion(Me.DS_DL1.ParticipacionPorDeptoResidencia, ID_SITIO_CAPACITACION, ID_EJERCICIO)
        SetearTotalParticipantes()
    End Sub
    
    Private Sub XrChart2_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.CustomDrawSeriesPointEventArgs) Handles XrChart2.CustomDrawSeriesPoint
        e.LabelText = e.SeriesPoint(0).ToString + vbCrLf + Format(e.SeriesPoint(0) / TotalParticipantes, "0%")
    End Sub

    Private TotalParticipantes As Integer
    Private Sub SetearTotalParticipantes()
        Dim Resultado As Object

        TotalParticipantes = 0
        Resultado = Me.DS_DL1.ParticipacionPorDeptoResidencia.Compute("SUM(PARTICIPANTES)", "EJERCICIO<>''")
        If Resultado IsNot Nothing AndAlso Not IsDBNull(Resultado) Then
            TotalParticipantes = CInt(Resultado)
        End If
    End Sub
End Class