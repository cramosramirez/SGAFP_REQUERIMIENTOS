Public Class xrInformeEjecucionDE_SubReporteDomicilio
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Código Generado "
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
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents DS_DL1 As SGAFP.DL.DS_DL
    Friend WithEvents XrPivotGrid1 As DevExpress.XtraReports.UI.XRPivotGrid
    Friend WithEvents InformeDEDomicilioTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.InformeDEDomicilioTableAdapter
    Friend WithEvents fieldINDICADOR As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldCLAS1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldCLAS2 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldTOTAL As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    Friend WithEvents fieldPORCENTAJE As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField

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
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrPivotGrid1 = New DevExpress.XtraReports.UI.XRPivotGrid
        Me.InformeDEDomicilioTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.InformeDEDomicilioTableAdapter
        Me.DS_DL1 = New SGAFP.DL.DS_DL
        Me.fieldINDICADOR = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.fieldCLAS1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.fieldCLAS2 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.fieldTOTAL = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Me.fieldPORCENTAJE = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 4.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 27.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 6.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPivotGrid1})
        Me.GroupHeader1.HeightF = 126.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrPivotGrid1
        '
        Me.XrPivotGrid1.Appearance.Cell.BackColor = System.Drawing.Color.White
        Me.XrPivotGrid1.Appearance.Cell.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrPivotGrid1.Appearance.CustomTotalCell.BackColor = System.Drawing.Color.White
        Me.XrPivotGrid1.Appearance.CustomTotalCell.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrPivotGrid1.Appearance.FieldHeader.BackColor = System.Drawing.Color.White
        Me.XrPivotGrid1.Appearance.FieldHeader.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrPivotGrid1.Appearance.FieldHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrPivotGrid1.Appearance.FieldValue.BackColor = System.Drawing.Color.White
        Me.XrPivotGrid1.Appearance.FieldValue.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrPivotGrid1.Appearance.FieldValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrPivotGrid1.Appearance.FieldValueGrandTotal.BackColor = System.Drawing.Color.White
        Me.XrPivotGrid1.Appearance.FieldValueGrandTotal.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrPivotGrid1.Appearance.FieldValueTotal.BackColor = System.Drawing.Color.White
        Me.XrPivotGrid1.Appearance.FieldValueTotal.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrPivotGrid1.Appearance.FilterSeparator.BackColor = System.Drawing.Color.White
        Me.XrPivotGrid1.Appearance.FilterSeparator.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrPivotGrid1.Appearance.GrandTotalCell.BackColor = System.Drawing.Color.White
        Me.XrPivotGrid1.Appearance.GrandTotalCell.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrPivotGrid1.Appearance.HeaderGroupLine.BackColor = System.Drawing.Color.White
        Me.XrPivotGrid1.Appearance.HeaderGroupLine.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrPivotGrid1.Appearance.Lines.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrPivotGrid1.Appearance.TotalCell.BackColor = System.Drawing.Color.White
        Me.XrPivotGrid1.Appearance.TotalCell.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrPivotGrid1.DataAdapter = Me.InformeDEDomicilioTableAdapter1
        Me.XrPivotGrid1.DataMember = "InformeDEDomicilio"
        Me.XrPivotGrid1.DataSource = Me.DS_DL1
        Me.XrPivotGrid1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldINDICADOR, Me.fieldCLAS1, Me.fieldCLAS2, Me.fieldTOTAL, Me.fieldPORCENTAJE})
        Me.XrPivotGrid1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrPivotGrid1.Name = "XrPivotGrid1"
        Me.XrPivotGrid1.OptionsPrint.PrintHeadersOnEveryPage = True
        Me.XrPivotGrid1.OptionsPrint.PrintUnusedFilterFields = False
        Me.XrPivotGrid1.SizeF = New System.Drawing.SizeF(650.0!, 109.0!)
        '
        'InformeDEDomicilioTableAdapter1
        '
        Me.InformeDEDomicilioTableAdapter1.ClearBeforeFill = True
        '
        'DS_DL1
        '
        Me.DS_DL1.DataSetName = "DS_DL"
        Me.DS_DL1.EnforceConstraints = False
        Me.DS_DL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fieldINDICADOR
        '
        Me.fieldINDICADOR.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldINDICADOR.AreaIndex = 0
        Me.fieldINDICADOR.Caption = "Departamento"
        Me.fieldINDICADOR.FieldName = "INDICADOR"
        Me.fieldINDICADOR.Name = "fieldINDICADOR"
        Me.fieldINDICADOR.Options.ShowGrandTotal = False
        Me.fieldINDICADOR.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.None
        '
        'fieldCLAS1
        '
        Me.fieldCLAS1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldCLAS1.AreaIndex = 0
        Me.fieldCLAS1.Caption = "Participantes"
        Me.fieldCLAS1.FieldName = "CLAS1"
        Me.fieldCLAS1.Name = "fieldCLAS1"
        '
        'fieldCLAS2
        '
        Me.fieldCLAS2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldCLAS2.AreaIndex = 1
        Me.fieldCLAS2.Caption = "Totales"
        Me.fieldCLAS2.FieldName = "CLAS2"
        Me.fieldCLAS2.Name = "fieldCLAS2"
        '
        'fieldTOTAL
        '
        Me.fieldTOTAL.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldTOTAL.AreaIndex = 0
        Me.fieldTOTAL.Caption = "Total"
        Me.fieldTOTAL.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldTOTAL.FieldName = "TOTAL"
        Me.fieldTOTAL.Name = "fieldTOTAL"
        Me.fieldTOTAL.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Value
        Me.fieldTOTAL.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        Me.fieldTOTAL.Width = 60
        '
        'fieldPORCENTAJE
        '
        Me.fieldPORCENTAJE.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldPORCENTAJE.AreaIndex = 1
        Me.fieldPORCENTAJE.Caption = "%"
        Me.fieldPORCENTAJE.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldPORCENTAJE.FieldName = "PORCENTAJE"
        Me.fieldPORCENTAJE.Name = "fieldPORCENTAJE"
        Me.fieldPORCENTAJE.Width = 60
        '
        'xrInformeEjecucionDE_SubReporteDomicilio
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1})
        Me.DataAdapter = Me.InformeDEDomicilioTableAdapter1
        Me.DataMember = "ParticipantesInscritos"
        Me.DataSource = Me.DS_DL1
        Me.Margins = New System.Drawing.Printing.Margins(100, 100, 27, 6)
        Me.Version = "10.1"
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
#End Region

    Public Sub CargarDomicilioPorEjercicioTipoSolic(ByVal ID_EJERCICIO As String, ByVal TIPO_SOLICITUD As Decimal)
        Me.InformeDEDomicilioTableAdapter1.FillByEjercicioTipoSolic(Me.DS_DL1.InformeDEDomicilio, ID_EJERCICIO, TIPO_SOLICITUD)
    End Sub
End Class