Public Class xrParticipantesInscritosPATI
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
    Private WithEvents dS_DL1 As SGAFP.DL.DS_DL
    Private WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Private WithEvents xrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLine1 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Private WithEvents xrLabelTitulo As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLine3 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Private WithEvents xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents xrLabelNombreProveedor As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabelNombreAccionFormativa As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabelHorario As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabelCodigoGrupo As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabelFechaInicio As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabelFechaFinal As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrTable1 As DevExpress.XtraReports.UI.XRTable
    Private WithEvents xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Private WithEvents xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents nombresApellidos As DevExpress.XtraReports.UI.CalculatedField
    Private WithEvents xrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrTable2 As DevExpress.XtraReports.UI.XRTable
    Private WithEvents xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Private WithEvents xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Private WithEvents xrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ParticipantesInscritosPATITableAdapter1 As SGAFP.DL.DS_DLTableAdapters.ParticipantesInscritosPATITableAdapter
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.dS_DL1 = New SGAFP.DL.DS_DL
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell
        Me.xrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabelFechaFinal = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabelFechaInicio = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabelCodigoGrupo = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabelHorario = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabelNombreAccionFormativa = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabelNombreProveedor = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.xrLabelTitulo = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.nombresApellidos = New DevExpress.XtraReports.UI.CalculatedField
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.ParticipantesInscritosPATITableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.ParticipantesInscritosPATITableAdapter
        CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dS_DL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1})
        Me.Detail.HeightF = 18.99999!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrTable1
        '
        Me.xrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrTable1.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 0.0!)
        Me.xrTable1.Name = "xrTable1"
        Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
        Me.xrTable1.SizeF = New System.Drawing.SizeF(761.9999!, 18.99999!)
        Me.xrTable1.StylePriority.UseBorders = False
        Me.xrTable1.StylePriority.UseFont = False
        '
        'xrTableRow1
        '
        Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell12, Me.XrTableCell9, Me.XrTableCell7, Me.XrTableCell4, Me.xrTableCell1})
        Me.xrTableRow1.Name = "xrTableRow1"
        Me.xrTableRow1.Weight = 1
        '
        'xrTableCell12
        '
        Me.xrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesInscritosPATI.NUM_FICHA_PATI")})
        Me.xrTableCell12.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrTableCell12.Name = "xrTableCell12"
        Me.xrTableCell12.StylePriority.UseFont = False
        Me.xrTableCell12.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:#}"
        XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.xrTableCell12.Summary = XrSummary1
        Me.xrTableCell12.Text = "xrTableCell12"
        Me.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.xrTableCell12.Weight = 0.11120275529459284
        '
        'XrTableCell9
        '
        Me.XrTableCell9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesInscritosPATI.NUM_CONVENIO")})
        Me.XrTableCell9.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        Me.XrTableCell9.StylePriority.UseFont = False
        Me.XrTableCell9.StylePriority.UsePadding = False
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.Text = "XrTableCell9"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell9.Weight = 0.49599444525909
        '
        'XrTableCell7
        '
        Me.XrTableCell7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesInscritosPATI.NUM_FICHA_PATI")})
        Me.XrTableCell7.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        Me.XrTableCell7.StylePriority.UseFont = False
        Me.XrTableCell7.StylePriority.UsePadding = False
        Me.XrTableCell7.StylePriority.UseTextAlignment = False
        Me.XrTableCell7.Text = "XrTableCell7"
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell7.Weight = 0.42777051305365354
        '
        'XrTableCell4
        '
        Me.XrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesInscritosPATI.DUI_CARNET_MIN")})
        Me.XrTableCell4.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseFont = False
        Me.XrTableCell4.StylePriority.UseTextAlignment = False
        Me.XrTableCell4.Text = "XrTableCell4"
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell4.Weight = 0.7175724212854715
        '
        'xrTableCell1
        '
        Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesInscritosPATI.nombresApellidos")})
        Me.xrTableCell1.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrTableCell1.Name = "xrTableCell1"
        Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.xrTableCell1.StylePriority.UseFont = False
        Me.xrTableCell1.StylePriority.UsePadding = False
        Me.xrTableCell1.Text = "xrTableCell1"
        Me.xrTableCell1.Weight = 2.1112096869022623
        '
        'TopMargin
        '
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'dS_DL1
        '
        Me.dS_DL1.DataSetName = "DS_DL"
        Me.dS_DL1.EnforceConstraints = False
        Me.dS_DL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable2, Me.xrLabel15, Me.xrLabel14, Me.xrLabel12, Me.xrLabel11, Me.xrLabel10, Me.xrLabel9, Me.xrLabelFechaFinal, Me.xrLabelFechaInicio, Me.xrLabelCodigoGrupo, Me.xrLabelHorario, Me.xrLabelNombreAccionFormativa, Me.xrLabelNombreProveedor, Me.xrLabel4, Me.xrLine1, Me.xrPictureBox1, Me.xrLabelTitulo, Me.xrLine3, Me.xrLabel2, Me.xrLabel1})
        Me.PageHeader.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.PageHeader.HeightF = 203.1666!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.StylePriority.UseFont = False
        '
        'xrTable2
        '
        Me.xrTable2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrTable2.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 188.3335!)
        Me.xrTable2.Name = "xrTable2"
        Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow2})
        Me.xrTable2.SizeF = New System.Drawing.SizeF(762.0!, 14.83313!)
        Me.xrTable2.StylePriority.UseBorders = False
        Me.xrTable2.StylePriority.UseFont = False
        '
        'xrTableRow2
        '
        Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell11, Me.XrTableCell5, Me.XrTableCell2, Me.XrTableCell3, Me.xrTableCell6})
        Me.xrTableRow2.Name = "xrTableRow2"
        Me.xrTableRow2.Weight = 1
        '
        'xrTableCell11
        '
        Me.xrTableCell11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrTableCell11.Name = "xrTableCell11"
        Me.xrTableCell11.StylePriority.UseFont = False
        Me.xrTableCell11.StylePriority.UseTextAlignment = False
        Me.xrTableCell11.Text = "N°"
        Me.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.xrTableCell11.Weight = 0.10343763831215608
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseFont = False
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        Me.XrTableCell5.Text = "N° CONVENIO"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell5.Weight = 0.46135997143563617
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseFont = False
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        Me.XrTableCell2.Text = "N° FICHA"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell2.Weight = 0.39790016569352094
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell3.Multiline = True
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseFont = False
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.Text = "DUI/CARNET MINORIDAD"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell3.Weight = 0.6674657138272847
        '
        'xrTableCell6
        '
        Me.xrTableCell6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrTableCell6.Name = "xrTableCell6"
        Me.xrTableCell6.StylePriority.UseFont = False
        Me.xrTableCell6.StylePriority.UseTextAlignment = False
        Me.xrTableCell6.Text = "PARTICIPANTE"
        Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.xrTableCell6.Weight = 1.9637876197473165
        '
        'xrLabel15
        '
        Me.xrLabel15.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(479.6248!, 136.0!)
        Me.xrLabel15.Name = "xrLabel15"
        Me.xrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel15.SizeF = New System.Drawing.SizeF(82.24998!, 23.0!)
        Me.xrLabel15.StylePriority.UseFont = False
        Me.xrLabel15.Text = "FECHA FINAL:"
        '
        'xrLabel14
        '
        Me.xrLabel14.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(479.6248!, 67.00001!)
        Me.xrLabel14.Name = "xrLabel14"
        Me.xrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel14.SizeF = New System.Drawing.SizeF(82.24998!, 23.0!)
        Me.xrLabel14.StylePriority.UseFont = False
        Me.xrLabel14.Text = "HORARIO:"
        '
        'xrLabel12
        '
        Me.xrLabel12.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 136.0!)
        Me.xrLabel12.Name = "xrLabel12"
        Me.xrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel12.SizeF = New System.Drawing.SizeF(105.1667!, 23.00002!)
        Me.xrLabel12.StylePriority.UseFont = False
        Me.xrLabel12.Text = "FECHA INICIO:"
        '
        'xrLabel11
        '
        Me.xrLabel11.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 113.0!)
        Me.xrLabel11.Name = "xrLabel11"
        Me.xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel11.SizeF = New System.Drawing.SizeF(105.1667!, 22.99998!)
        Me.xrLabel11.StylePriority.UseFont = False
        Me.xrLabel11.Text = "CODIGO GRUPO:"
        '
        'xrLabel10
        '
        Me.xrLabel10.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 89.99999!)
        Me.xrLabel10.Name = "xrLabel10"
        Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel10.SizeF = New System.Drawing.SizeF(105.1667!, 23.0!)
        Me.xrLabel10.StylePriority.UseFont = False
        Me.xrLabel10.Text = "CURSO:"
        '
        'xrLabel9
        '
        Me.xrLabel9.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 67.00001!)
        Me.xrLabel9.Name = "xrLabel9"
        Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel9.SizeF = New System.Drawing.SizeF(105.1667!, 23.0!)
        Me.xrLabel9.StylePriority.UseFont = False
        Me.xrLabel9.Text = "PROVEEDOR:"
        '
        'xrLabelFechaFinal
        '
        Me.xrLabelFechaFinal.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesInscritosPATI.FECHA_FIN", "{0:dd/MM/yyyy}")})
        Me.xrLabelFechaFinal.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabelFechaFinal.LocationFloat = New DevExpress.Utils.PointFloat(561.8748!, 136.0!)
        Me.xrLabelFechaFinal.Name = "xrLabelFechaFinal"
        Me.xrLabelFechaFinal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabelFechaFinal.SizeF = New System.Drawing.SizeF(210.1252!, 23.00002!)
        Me.xrLabelFechaFinal.StylePriority.UseFont = False
        Me.xrLabelFechaFinal.Text = "xrLabelFechaFinal"
        '
        'xrLabelFechaInicio
        '
        Me.xrLabelFechaInicio.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesInscritosPATI.FECHA_INICIO", "{0:dd/MM/yyyy}")})
        Me.xrLabelFechaInicio.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabelFechaInicio.LocationFloat = New DevExpress.Utils.PointFloat(115.1667!, 136.0!)
        Me.xrLabelFechaInicio.Name = "xrLabelFechaInicio"
        Me.xrLabelFechaInicio.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabelFechaInicio.SizeF = New System.Drawing.SizeF(285.875!, 23.00002!)
        Me.xrLabelFechaInicio.StylePriority.UseFont = False
        Me.xrLabelFechaInicio.Text = "xrLabelFechaInicio"
        '
        'xrLabelCodigoGrupo
        '
        Me.xrLabelCodigoGrupo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesInscritosPATI.CODIGO_GRUPO")})
        Me.xrLabelCodigoGrupo.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabelCodigoGrupo.LocationFloat = New DevExpress.Utils.PointFloat(115.1667!, 113.0!)
        Me.xrLabelCodigoGrupo.Name = "xrLabelCodigoGrupo"
        Me.xrLabelCodigoGrupo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabelCodigoGrupo.SizeF = New System.Drawing.SizeF(285.875!, 23.00002!)
        Me.xrLabelCodigoGrupo.StylePriority.UseFont = False
        Me.xrLabelCodigoGrupo.Text = "xrLabelCodigoGrupo"
        '
        'xrLabelHorario
        '
        Me.xrLabelHorario.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesInscritosPATI.HORARIO")})
        Me.xrLabelHorario.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabelHorario.LocationFloat = New DevExpress.Utils.PointFloat(561.8747!, 67.00001!)
        Me.xrLabelHorario.Name = "xrLabelHorario"
        Me.xrLabelHorario.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabelHorario.SizeF = New System.Drawing.SizeF(210.1251!, 23.00002!)
        Me.xrLabelHorario.StylePriority.UseFont = False
        Me.xrLabelHorario.Text = "xrLabelHorario"
        '
        'xrLabelNombreAccionFormativa
        '
        Me.xrLabelNombreAccionFormativa.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesInscritosPATI.NOMBRE_ACCION_FORMATIVA")})
        Me.xrLabelNombreAccionFormativa.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabelNombreAccionFormativa.LocationFloat = New DevExpress.Utils.PointFloat(115.1667!, 89.99999!)
        Me.xrLabelNombreAccionFormativa.Name = "xrLabelNombreAccionFormativa"
        Me.xrLabelNombreAccionFormativa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabelNombreAccionFormativa.SizeF = New System.Drawing.SizeF(285.875!, 23.0!)
        Me.xrLabelNombreAccionFormativa.StylePriority.UseFont = False
        Me.xrLabelNombreAccionFormativa.Text = "xrLabelNombreAccionFormativa"
        '
        'xrLabelNombreProveedor
        '
        Me.xrLabelNombreProveedor.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesInscritosPATI.NOMBRE_PROVEEDOR")})
        Me.xrLabelNombreProveedor.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabelNombreProveedor.LocationFloat = New DevExpress.Utils.PointFloat(115.1667!, 67.00001!)
        Me.xrLabelNombreProveedor.Name = "xrLabelNombreProveedor"
        Me.xrLabelNombreProveedor.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabelNombreProveedor.SizeF = New System.Drawing.SizeF(285.875!, 23.0!)
        Me.xrLabelNombreProveedor.StylePriority.UseFont = False
        Me.xrLabelNombreProveedor.Text = "xrLabelNombreProveedor"
        '
        'xrLabel4
        '
        Me.xrLabel4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(150.0!, 30.79166!)
        Me.xrLabel4.Name = "xrLabel4"
        Me.xrLabel4.SizeF = New System.Drawing.SizeF(584.0!, 19.20834!)
        Me.xrLabel4.StylePriority.UseFont = False
        Me.xrLabel4.StylePriority.UseTextAlignment = False
        Me.xrLabel4.Text = "PARTICIPANTES INSCRITOS EN CURSO"
        Me.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLine1
        '
        Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 50.0!)
        Me.xrLine1.Name = "xrLine1"
        Me.xrLine1.SizeF = New System.Drawing.SizeF(772.0!, 2.0!)
        '
        'xrPictureBox1
        '
        Me.xrPictureBox1.Image = Global.SGAFP.RL.My.Resources.Resources.logoInsaforp
        Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 2.0!)
        Me.xrPictureBox1.Name = "xrPictureBox1"
        Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(145.875!, 45.99999!)
        Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'xrLabelTitulo
        '
        Me.xrLabelTitulo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabelTitulo.LocationFloat = New DevExpress.Utils.PointFloat(150.0!, 1.999982!)
        Me.xrLabelTitulo.Name = "xrLabelTitulo"
        Me.xrLabelTitulo.SizeF = New System.Drawing.SizeF(584.0!, 19.20834!)
        Me.xrLabelTitulo.StylePriority.UseFont = False
        Me.xrLabelTitulo.StylePriority.UseTextAlignment = False
        Me.xrLabelTitulo.Text = "PROGRAMA DE APOYO TEMPORAL AL INGRESO - PATI [EJERCICIO]"
        Me.xrLabelTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLine3
        '
        Me.xrLine3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.xrLine3.Name = "xrLine3"
        Me.xrLine3.SizeF = New System.Drawing.SizeF(772.0!, 2.0!)
        '
        'xrLabel2
        '
        Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesInscritosPATI.INSTRUCTOR")})
        Me.xrLabel2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(176.614!, 159.0!)
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel2.SizeF = New System.Drawing.SizeF(595.386!, 23.00002!)
        Me.xrLabel2.StylePriority.UseFont = False
        Me.xrLabel2.Text = "xrLabel2"
        '
        'xrLabel1
        '
        Me.xrLabel1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 159.0!)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(166.614!, 23.00002!)
        Me.xrLabel1.StylePriority.UseFont = False
        Me.xrLabel1.Text = "INSTRUCTOR/COMENTARIOS:"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo2, Me.xrPageInfo1})
        Me.PageFooter.HeightF = 34.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'xrPageInfo2
        '
        Me.xrPageInfo2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrPageInfo2.Format = "Pagina {0} de {1}"
        Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(337.5!, 9.999974!)
        Me.xrPageInfo2.Name = "xrPageInfo2"
        Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(434.4999!, 23.00002!)
        Me.xrPageInfo2.StylePriority.UseFont = False
        Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrPageInfo1
        '
        Me.xrPageInfo1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrPageInfo1.Format = "{0:dddd, dd' de 'MMMM' de 'yyyy'  Hora: 'hh:mm tt}"
        Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 10.00001!)
        Me.xrPageInfo1.Name = "xrPageInfo1"
        Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
        Me.xrPageInfo1.StylePriority.UseFont = False
        '
        'nombresApellidos
        '
        Me.nombresApellidos.DataMember = "ParticipantesInscritosPATI"
        Me.nombresApellidos.DataSource = Me.dS_DL1
        Me.nombresApellidos.Expression = "Concat([APELLIDOS], Concat(', ', [NOMBRES]) )"
        Me.nombresApellidos.Name = "nombresApellidos"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel5, Me.xrLabel3})
        Me.GroupFooter1.HeightF = 39.0!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'xrLabel5
        '
        Me.xrLabel5.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 15.99998!)
        Me.xrLabel5.Name = "xrLabel5"
        Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel5.SizeF = New System.Drawing.SizeF(161.5!, 22.99999!)
        Me.xrLabel5.StylePriority.UseFont = False
        Me.xrLabel5.Text = "TOTAL DE PARTICIPANTES:"
        '
        'xrLabel3
        '
        Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesInscritosPATI.NUM_FICHA_PATI")})
        Me.xrLabel3.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(171.5!, 15.99998!)
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel3.SizeF = New System.Drawing.SizeF(51.09727!, 22.99999!)
        Me.xrLabel3.StylePriority.UseFont = False
        XrSummary2.FormatString = "{0:#,#}"
        XrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.Count
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.xrLabel3.Summary = XrSummary2
        Me.xrLabel3.Text = "TOTAL PARTICIPANTES: [NUM_FICHA_PATI]"
        '
        'ParticipantesInscritosPATITableAdapter1
        '
        Me.ParticipantesInscritosPATITableAdapter1.ClearBeforeFill = True
        '
        'xrParticipantesInscritosPATI
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.PageFooter, Me.GroupFooter1})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.nombresApellidos})
        Me.DataAdapter = Me.ParticipantesInscritosPATITableAdapter1
        Me.DataMember = "ParticipantesInscritosPATI"
        Me.DataSource = Me.dS_DL1
        Me.Margins = New System.Drawing.Printing.Margins(42, 36, 100, 100)
        Me.Version = "10.1"
        CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dS_DL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

#End Region

    Public Sub CargarDatosPorCurso(ByVal idAccionFormativa As Decimal)
        Me.dS_DL1.Clear()
        Me.ParticipantesInscritosPATITableAdapter1.Fill(Me.dS_DL1.ParticipantesInscritosPATI, idAccionFormativa)
    End Sub
End Class