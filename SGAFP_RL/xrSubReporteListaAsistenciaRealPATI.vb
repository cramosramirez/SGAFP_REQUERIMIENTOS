Public Class xrSubReporteListaAsistenciaRealPATI
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub
    Private WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Private WithEvents xrPivotGrid1 As DevExpress.XtraReports.UI.XRPivotGrid
    Private WithEvents dS_DL1 As SGAFP.DL.DS_DL
    Private WithEvents xrPivotGridField5 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Private WithEvents xrPivotGridField2 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Private WithEvents xrPivotGridField1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Private WithEvents xrPivotGridField3 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Private WithEvents xrPivotGridField4 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Private WithEvents fechaInicio As DevExpress.XtraReports.Parameters.Parameter
    Private WithEvents fechaFin As DevExpress.XtraReports.Parameters.Parameter
    Private WithEvents Valor1 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrPivotGridField6 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents XrPivotGridField7 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents ListadoAsistenciaPATITableAdapter1 As SGAFP.DL.DS_DLTableAdapters.ListadoAsistenciaPATITableAdapter
    Friend WithEvents xrNUMCONVENIO As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents xrNUMFICHAPATI As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents xrDUICARNETMIN As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim PivotGridCustomTotal1 As DevExpress.XtraPivotGrid.PivotGridCustomTotal = New DevExpress.XtraPivotGrid.PivotGridCustomTotal
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.xrPivotGrid1 = New DevExpress.XtraReports.UI.XRPivotGrid
        Me.dS_DL1 = New SGAFP.DL.DS_DL
        Me.xrPivotGridField5 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.xrNUMCONVENIO = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.xrNUMFICHAPATI = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.xrDUICARNETMIN = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.XrPivotGridField7 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.xrPivotGridField2 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.xrPivotGridField1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.xrPivotGridField3 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.xrPivotGridField4 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.XrPivotGridField6 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.fechaInicio = New DevExpress.XtraReports.Parameters.Parameter
        Me.fechaFin = New DevExpress.XtraReports.Parameters.Parameter
        Me.Valor1 = New DevExpress.XtraReports.UI.CalculatedField
        Me.ListadoAsistenciaPATITableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.ListadoAsistenciaPATITableAdapter
        CType(Me.dS_DL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
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
        Me.BottomMargin.HeightF = 0.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPivotGrid1})
        Me.ReportHeader.Name = "ReportHeader"
        '
        'xrPivotGrid1
        '
        Me.xrPivotGrid1.Appearance.Cell.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrPivotGrid1.Appearance.Cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xrPivotGrid1.Appearance.CustomTotalCell.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.xrPivotGrid1.Appearance.FieldHeader.BackColor = System.Drawing.Color.Transparent
        Me.xrPivotGrid1.Appearance.FieldHeader.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrPivotGrid1.Appearance.FieldHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrPivotGrid1.Appearance.FieldValue.BackColor = System.Drawing.Color.Transparent
        Me.xrPivotGrid1.Appearance.FieldValue.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrPivotGrid1.Appearance.FieldValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xrPivotGrid1.Appearance.FieldValueGrandTotal.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrPivotGrid1.Appearance.FieldValueGrandTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrPivotGrid1.Appearance.FieldValueTotal.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrPivotGrid1.Appearance.GrandTotalCell.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrPivotGrid1.Appearance.GrandTotalCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrPivotGrid1.Appearance.Lines.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrPivotGrid1.Appearance.TotalCell.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrPivotGrid1.DataMember = "ListadoAsistenciaPATI"
        Me.xrPivotGrid1.DataSource = Me.dS_DL1
        Me.xrPivotGrid1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.xrPivotGridField5, Me.xrNUMCONVENIO, Me.xrNUMFICHAPATI, Me.xrDUICARNETMIN, Me.XrPivotGridField7, Me.xrPivotGridField2, Me.xrPivotGridField1, Me.xrPivotGridField3, Me.xrPivotGridField4, Me.XrPivotGridField6})
        Me.xrPivotGrid1.KeepTogether = False
        Me.xrPivotGrid1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.xrPivotGrid1.Name = "xrPivotGrid1"
        Me.xrPivotGrid1.OLAPConnectionString = ""
        Me.xrPivotGrid1.OptionsChartDataSource.UpdateDelay = 300
        Me.xrPivotGrid1.OptionsPrint.MergeRowFieldValues = False
        Me.xrPivotGrid1.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.xrPivotGrid1.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.xrPivotGrid1.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.xrPivotGrid1.OptionsPrint.PrintHeadersOnEveryPage = True
        Me.xrPivotGrid1.OptionsPrint.PrintRowHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.xrPivotGrid1.OptionsView.ShowColumnTotals = False
        Me.xrPivotGrid1.OptionsView.ShowRowGrandTotalHeader = False
        Me.xrPivotGrid1.OptionsView.ShowRowGrandTotals = False
        Me.xrPivotGrid1.OptionsView.ShowRowTotals = False
        Me.xrPivotGrid1.SizeF = New System.Drawing.SizeF(639.9999!, 100.0!)
        '
        'dS_DL1
        '
        Me.dS_DL1.DataSetName = "DS_DL"
        Me.dS_DL1.EnforceConstraints = False
        Me.dS_DL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'xrPivotGridField5
        '
        Me.xrPivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.xrPivotGridField5.AreaIndex = 0
        Me.xrPivotGridField5.Caption = "PARTICIPANTE"
        Me.xrPivotGridField5.Name = "xrPivotGridField5"
        Me.xrPivotGridField5.UnboundExpression = "Concat(Concat([APELLIDOS], ', '), [NOMBRES])"
        Me.xrPivotGridField5.UnboundFieldName = "PARTICIPANTE"
        Me.xrPivotGridField5.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.xrPivotGridField5.Width = 225
        '
        'xrNUMCONVENIO
        '
        Me.xrNUMCONVENIO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.xrNUMCONVENIO.AreaIndex = 1
        Me.xrNUMCONVENIO.Caption = "N° CONVENIO"
        Me.xrNUMCONVENIO.FieldName = "NUM_CONVENIO"
        Me.xrNUMCONVENIO.Name = "xrNUMCONVENIO"
        Me.xrNUMCONVENIO.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.None
        Me.xrNUMCONVENIO.Width = 85
        '
        'xrNUMFICHAPATI
        '
        Me.xrNUMFICHAPATI.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.xrNUMFICHAPATI.AreaIndex = 2
        Me.xrNUMFICHAPATI.Caption = "N° FICHA"
        Me.xrNUMFICHAPATI.FieldName = "NUM_FICHA_PATI"
        Me.xrNUMFICHAPATI.Name = "xrNUMFICHAPATI"
        Me.xrNUMFICHAPATI.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.None
        Me.xrNUMFICHAPATI.Width = 55
        '
        'xrDUICARNETMIN
        '
        Me.xrDUICARNETMIN.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.xrDUICARNETMIN.AreaIndex = 3
        Me.xrDUICARNETMIN.Caption = "DUI/C.M."
        Me.xrDUICARNETMIN.FieldName = "DUI_CARNET_MIN"
        Me.xrDUICARNETMIN.Name = "xrDUICARNETMIN"
        Me.xrDUICARNETMIN.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.None
        Me.xrDUICARNETMIN.Width = 55
        '
        'XrPivotGridField7
        '
        Me.XrPivotGridField7.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.XrPivotGridField7.AreaIndex = 4
        Me.XrPivotGridField7.FieldName = "ID_PARTICIPANTE"
        Me.XrPivotGridField7.Name = "XrPivotGridField7"
        Me.XrPivotGridField7.Visible = False
        Me.XrPivotGridField7.Width = 20
        '
        'xrPivotGridField2
        '
        Me.xrPivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.xrPivotGridField2.AreaIndex = 1
        Me.xrPivotGridField2.FieldName = "APELLIDOS"
        Me.xrPivotGridField2.Name = "xrPivotGridField2"
        Me.xrPivotGridField2.Visible = False
        Me.xrPivotGridField2.Width = 20
        '
        'xrPivotGridField1
        '
        Me.xrPivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.xrPivotGridField1.AreaIndex = 1
        Me.xrPivotGridField1.FieldName = "NOMBRES"
        Me.xrPivotGridField1.Name = "xrPivotGridField1"
        Me.xrPivotGridField1.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        Me.xrPivotGridField1.Visible = False
        Me.xrPivotGridField1.Width = 20
        '
        'xrPivotGridField3
        '
        Me.xrPivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.xrPivotGridField3.AreaIndex = 0
        Me.xrPivotGridField3.Caption = "FECHA"
        Me.xrPivotGridField3.CellFormat.FormatString = "d"
        Me.xrPivotGridField3.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.xrPivotGridField3.FieldName = "FECHA"
        Me.xrPivotGridField3.Name = "xrPivotGridField3"
        Me.xrPivotGridField3.ValueFormat.FormatString = "d"
        Me.xrPivotGridField3.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        '
        'xrPivotGridField4
        '
        Me.xrPivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.xrPivotGridField4.AreaIndex = 0
        Me.xrPivotGridField4.Caption = "FIRMA"
        PivotGridCustomTotal1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Min
        Me.xrPivotGridField4.CustomTotals.AddRange(New DevExpress.XtraPivotGrid.PivotGridCustomTotal() {PivotGridCustomTotal1})
        Me.xrPivotGridField4.EmptyCellText = " "
        Me.xrPivotGridField4.FieldName = "VALOR"
        Me.xrPivotGridField4.Name = "xrPivotGridField4"
        Me.xrPivotGridField4.Options.ShowGrandTotal = False
        Me.xrPivotGridField4.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Min
        Me.xrPivotGridField4.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        Me.xrPivotGridField4.Width = 84
        '
        'XrPivotGridField6
        '
        Me.XrPivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.XrPivotGridField6.AreaIndex = 1
        Me.XrPivotGridField6.Caption = "HRS."
        Me.XrPivotGridField6.EmptyCellText = "0"
        Me.XrPivotGridField6.EmptyValueText = "0"
        Me.XrPivotGridField6.FieldName = "HORAS_ASISTIDAS"
        Me.XrPivotGridField6.GrandTotalText = "Total Horas"
        Me.XrPivotGridField6.Name = "XrPivotGridField6"
        Me.XrPivotGridField6.Width = 30
        '
        'fechaInicio
        '
        Me.fechaInicio.Description = "Fecha Inicial de Periodo"
        Me.fechaInicio.Name = "fechaInicio"
        Me.fechaInicio.Type = GetType(Date)
        Me.fechaInicio.Value = New Date(CType(0, Long))
        '
        'fechaFin
        '
        Me.fechaFin.Description = "Fecha Final de Periodo"
        Me.fechaFin.Name = "fechaFin"
        Me.fechaFin.Type = GetType(Date)
        Me.fechaFin.Value = New Date(CType(0, Long))
        '
        'Valor1
        '
        Me.Valor1.DataMember = "ListadoAsistenciaPATI"
        Me.Valor1.Expression = "iif([VALOR] = 0 , '', [VALOR])"
        Me.Valor1.Name = "Valor1"
        '
        'ListadoAsistenciaPATITableAdapter1
        '
        Me.ListadoAsistenciaPATITableAdapter1.ClearBeforeFill = True
        '
        'xrSubReporteListaAsistenciaRealPATI
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.Valor1})
        Me.DataAdapter = Me.ListadoAsistenciaPATITableAdapter1
        Me.Margins = New System.Drawing.Printing.Margins(100, 100, 0, 0)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.fechaInicio, Me.fechaFin})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "11.1"
        CType(Me.dS_DL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

#End Region

    Private _ID_ACCION_FORMATIVA As Decimal
    Private _fechaInicial As DateTime
    Private _fechaFinal As DateTime

    Private Sub SetearDatos(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal fechaInicio As DateTime, ByVal fechaFin As DateTime)
        _ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA
        _fechaInicial = fechaInicio
        _fechaFinal = fechaFin

        'Dim bAccionFormativa As New cACCION_FORMATIVA
        'Dim EstaFecFinalEnReango As Boolean = (bAccionFormativa.ObtenerACCION_FORMATIVA(ID_ACCION_FORMATIVA).FECHA_FIN_REAL = fechaFin)

        'Me.xrPivotGrid1.OptionsView.ShowColumnGrandTotalHeader = EstaFecFinalEnReango
        'Me.xrPivotGrid1.OptionsView.ShowColumnGrandTotals = EstaFecFinalEnReango
    End Sub

    Public Sub CargarDatos(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal fechaInicio As DateTime, ByVal fechaFin As DateTime)
        Me.SetearDatos(ID_ACCION_FORMATIVA, fechaInicio, fechaFin)
        Me.dS_DL1.Clear()
        Me.ListadoAsistenciaPATITableAdapter1.FillByAccionPeriodoReal(Me.dS_DL1.ListadoAsistenciaPATI, _ID_ACCION_FORMATIVA, _fechaInicial, _fechaFinal)
        Me.DataMember = "ListadoAsistenciaPATI"
        Me.DataSource = Me.dS_DL1.ListadoAsistenciaPATI
    End Sub

    Private Sub xrPivotGrid1_CustomCellValue(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCellValueEventArgs) Handles xrPivotGrid1.CustomCellValue
        'If e.ColumnValueType = DevExpress.XtraPivotGrid.PivotGridValueType.GrandTotal Then
        '    Dim IdParticipante As Decimal = CDec(e.GetFieldValue(Me.XrPivotGridField7))
        '    e.Value = 40
        'End If

        If e.DataField.FieldName = "HORAS_ASISTIDAS" Then
            Dim valorEnMinutos As Decimal = CDec(e.Value)
            Dim hrs As Integer
            hrs = valorEnMinutos \ 60
            e.Value = hrs.ToString("00") + ":" + (valorEnMinutos - (hrs * 60)).ToString("00")
        End If

    End Sub

    Private Sub xrPivotGrid1_CustomColumnWidth(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCustomColumnWidthEventArgs) Handles xrPivotGrid1.CustomColumnWidth
        If e.ValueType = DevExpress.XtraPivotGrid.PivotGridValueType.GrandTotal Then
            e.ColumnWidth = 40
        End If
    End Sub

    Private Sub xrPivotGrid1_FieldValueDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs) Handles xrPivotGrid1.FieldValueDisplayText
        If e.ValueType = DevExpress.XtraPivotGrid.PivotGridValueType.GrandTotal Then
            e.DisplayText = "TOTAL"
            If e.Field IsNot Nothing Then
                e.Field.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
                e.Field.Appearance.Value.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            End If
        End If
    End Sub
End Class