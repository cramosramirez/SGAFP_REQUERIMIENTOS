Imports DevExpress.XtraPivotGrid

Public Class xrSubReporteProyEspecialAnexo3
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
    Private WithEvents fechaInicio As DevExpress.XtraReports.Parameters.Parameter
    Private WithEvents fechaFin As DevExpress.XtraReports.Parameters.Parameter
    Private WithEvents Valor1 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents AnexoAsistenciaPeriodoProyEspecialTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.AnexoAsistenciaPeriodoProyEspecialTableAdapter
    Friend WithEvents fieldNOMBRECOMPLETO As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldPERIODO As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldHORASASISTIDAS As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldCORRELATIVO As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.xrPivotGrid1 = New DevExpress.XtraReports.UI.XRPivotGrid
        Me.dS_DL1 = New SGAFP.DL.DS_DL
        Me.fieldNOMBRECOMPLETO = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.fieldPERIODO = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.fieldHORASASISTIDAS = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.fechaInicio = New DevExpress.XtraReports.Parameters.Parameter
        Me.fechaFin = New DevExpress.XtraReports.Parameters.Parameter
        Me.Valor1 = New DevExpress.XtraReports.UI.CalculatedField
        Me.AnexoAsistenciaPeriodoProyEspecialTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.AnexoAsistenciaPeriodoProyEspecialTableAdapter
        Me.fieldCORRELATIVO = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
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
        Me.xrPivotGrid1.Appearance.Cell.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrPivotGrid1.Appearance.Cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrPivotGrid1.Appearance.CustomTotalCell.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.xrPivotGrid1.Appearance.FieldHeader.BackColor = System.Drawing.Color.Transparent
        Me.xrPivotGrid1.Appearance.FieldHeader.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrPivotGrid1.Appearance.FieldHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrPivotGrid1.Appearance.FieldValue.BackColor = System.Drawing.Color.Transparent
        Me.xrPivotGrid1.Appearance.FieldValue.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrPivotGrid1.Appearance.FieldValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xrPivotGrid1.Appearance.FieldValueGrandTotal.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrPivotGrid1.Appearance.FieldValueGrandTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrPivotGrid1.Appearance.FieldValueTotal.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrPivotGrid1.Appearance.FilterSeparator.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrPivotGrid1.Appearance.GrandTotalCell.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrPivotGrid1.Appearance.GrandTotalCell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrPivotGrid1.Appearance.HeaderGroupLine.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrPivotGrid1.Appearance.Lines.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrPivotGrid1.Appearance.TotalCell.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrPivotGrid1.DataMember = "AnexoAsistenciaPeriodoProyEspecial"
        Me.xrPivotGrid1.DataSource = Me.dS_DL1
        Me.xrPivotGrid1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCORRELATIVO, Me.fieldNOMBRECOMPLETO, Me.fieldPERIODO, Me.fieldHORASASISTIDAS})
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
        Me.xrPivotGrid1.SizeF = New System.Drawing.SizeF(650.0!, 100.0!)
        '
        'dS_DL1
        '
        Me.dS_DL1.DataSetName = "DS_DL"
        Me.dS_DL1.EnforceConstraints = False
        Me.dS_DL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fieldNOMBRECOMPLETO
        '
        Me.fieldNOMBRECOMPLETO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldNOMBRECOMPLETO.AreaIndex = 1
        Me.fieldNOMBRECOMPLETO.Caption = "APELLIDOS NOMBRES"
        Me.fieldNOMBRECOMPLETO.FieldName = "NOMBRE_COMPLETO"
        Me.fieldNOMBRECOMPLETO.Name = "fieldNOMBRECOMPLETO"
        Me.fieldNOMBRECOMPLETO.Width = 300
        '
        'fieldPERIODO
        '
        Me.fieldPERIODO.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldPERIODO.AreaIndex = 0
        Me.fieldPERIODO.ColumnValueLineCount = 5
        Me.fieldPERIODO.FieldName = "PERIODO"
        Me.fieldPERIODO.Name = "fieldPERIODO"
        Me.fieldPERIODO.RowValueLineCount = 5
        Me.fieldPERIODO.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Custom
        Me.fieldPERIODO.Width = 80
        '
        'fieldHORASASISTIDAS
        '
        Me.fieldHORASASISTIDAS.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldHORASASISTIDAS.AreaIndex = 0
        Me.fieldHORASASISTIDAS.FieldName = "HORAS_ASISTIDAS"
        Me.fieldHORASASISTIDAS.GrandTotalText = "TOTAL HORAS POR PARTICIPANTE"
        Me.fieldHORASASISTIDAS.Name = "fieldHORASASISTIDAS"
        Me.fieldHORASASISTIDAS.RunningTotal = True
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
        Me.Valor1.DataMember = "ListadoAsistencia"
        Me.Valor1.Expression = "iif([VALOR] = 0 , '', [VALOR])"
        Me.Valor1.Name = "Valor1"
        '
        'AnexoAsistenciaPeriodoProyEspecialTableAdapter1
        '
        Me.AnexoAsistenciaPeriodoProyEspecialTableAdapter1.ClearBeforeFill = True
        '
        'fieldCORRELATIVO
        '
        Me.fieldCORRELATIVO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldCORRELATIVO.AreaIndex = 0
        Me.fieldCORRELATIVO.Caption = "N°"
        Me.fieldCORRELATIVO.FieldName = "CORRELATIVO"
        Me.fieldCORRELATIVO.Name = "fieldCORRELATIVO"
        Me.fieldCORRELATIVO.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Value
        Me.fieldCORRELATIVO.Width = 70
        '
        'xrSubReporteProyEspecialAnexo3
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.Valor1})
        Me.DataAdapter = Me.AnexoAsistenciaPeriodoProyEspecialTableAdapter1
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
        Me.AnexoAsistenciaPeriodoProyEspecialTableAdapter1.FillPorPeriodo(Me.dS_DL1.AnexoAsistenciaPeriodoProyEspecial, _ID_ACCION_FORMATIVA, _fechaInicial, _fechaFinal)
        Me.DataMember = "AnexoAsistenciaPeriodoProyEspecial"
        Me.DataSource = Me.dS_DL1.AnexoAsistenciaPeriodoProyEspecial
    End Sub

    Private Sub xrPivotGrid1_CustomCellValue(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCellValueEventArgs) Handles xrPivotGrid1.CustomCellValue
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

    Private Sub xrPivotGrid1_CustomFieldSort(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotGridCustomFieldSortEventArgs) Handles xrPivotGrid1.CustomFieldSort
        If e.Field Is fieldPERIODO Then
            If e.Value1 Is Nothing OrElse e.Value2 Is Nothing Then
                Return
            End If
            e.Handled = True
            Dim s1 As String = e.Value1.ToString()
            Dim s2 As String = e.Value2.ToString()

            s1 = Strings.Left(s1, Strings.InStr(s1, " ") - 1)
            s2 = Strings.Left(s2, Strings.InStr(s2, " ") - 1)

            If Convert.ToInt32(s1) > Convert.ToInt32(s2) Then
                e.Result = 1
            Else
                If Convert.ToInt32(s1) = Convert.ToInt32(s2) Then
                    e.Result = Comparer(Of Int32).Default.Compare(Convert.ToInt32(s1), _
                      Convert.ToInt32(s2))
                Else
                    e.Result = -1
                End If
            End If
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