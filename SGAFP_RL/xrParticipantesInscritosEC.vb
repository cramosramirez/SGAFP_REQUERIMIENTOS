Public Class xrParticipantesInscritosEC
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
    Private WithEvents participantesInscritosTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.ParticipantesInscritosTableAdapter
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
    Private WithEvents xrLabelNombreSitio As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabelNombreAccionFormativa As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabelHorario As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabelCodigoGrupo As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabelFechaInicio As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabelFechaFinal As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrTable1 As DevExpress.XtraReports.UI.XRTable
    Private WithEvents xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Private WithEvents xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents nombresApellidos As DevExpress.XtraReports.UI.CalculatedField
    Private WithEvents xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabelCentro As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrTable2 As DevExpress.XtraReports.UI.XRTable
    Private WithEvents xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Private WithEvents xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Private WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Private WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Private WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xrParticipantesInscritosEC))
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.dS_DL1 = New SGAFP.DL.DS_DL()
        Me.participantesInscritosTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.ParticipantesInscritosTableAdapter()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabelCentro = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabelFechaFinal = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabelFechaInicio = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabelCodigoGrupo = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabelHorario = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabelNombreAccionFormativa = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabelNombreSitio = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabelNombreProveedor = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.xrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabelTitulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.nombresApellidos = New DevExpress.XtraReports.UI.CalculatedField()
        Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dS_DL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.xrTable1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
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
        Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell12, Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3, Me.xrTableCell4, Me.xrTableCell5})
        Me.xrTableRow1.Name = "xrTableRow1"
        Me.xrTableRow1.Weight = 1.0R
        '
        'xrTableCell12
        '
        Me.xrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesInscritos.DUI")})
        Me.xrTableCell12.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrTableCell12.Name = "xrTableCell12"
        Me.xrTableCell12.StylePriority.UseFont = False
        Me.xrTableCell12.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:#}"
        XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.xrTableCell12.Summary = XrSummary1
        Me.xrTableCell12.Text = "xrTableCell12"
        Me.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrTableCell12.Weight = 0.10343769390161045R
        '
        'xrTableCell1
        '
        Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesInscritos.nombresApellidos")})
        Me.xrTableCell1.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrTableCell1.Name = "xrTableCell1"
        Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100.0!)
        Me.xrTableCell1.StylePriority.UseFont = False
        Me.xrTableCell1.StylePriority.UsePadding = False
        Me.xrTableCell1.StylePriority.UseTextAlignment = False
        Me.xrTableCell1.Text = "xrTableCell1"
        Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xrTableCell1.Weight = 0.89927100724393172R
        '
        'xrTableCell2
        '
        Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesInscritos.FECHA_PRESENTACION", "{0:dd/MM/yyyy}")})
        Me.xrTableCell2.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrTableCell2.Name = "xrTableCell2"
        Me.xrTableCell2.StylePriority.UseFont = False
        Me.xrTableCell2.StylePriority.UseTextAlignment = False
        Me.xrTableCell2.Text = "xrTableCell2"
        Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrTableCell2.Weight = 0.257244518444122R
        '
        'xrTableCell3
        '
        Me.xrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesInscritos.DUI")})
        Me.xrTableCell3.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrTableCell3.Name = "xrTableCell3"
        Me.xrTableCell3.StylePriority.UseFont = False
        Me.xrTableCell3.StylePriority.UseTextAlignment = False
        Me.xrTableCell3.Text = "xrTableCell3"
        Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrTableCell3.Weight = 0.25528261524907603R
        '
        'xrTableCell4
        '
        Me.xrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesInscritos.NIT")})
        Me.xrTableCell4.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrTableCell4.Name = "xrTableCell4"
        Me.xrTableCell4.StylePriority.UseFont = False
        Me.xrTableCell4.StylePriority.UseTextAlignment = False
        Me.xrTableCell4.Text = "xrTableCell4"
        Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrTableCell4.Weight = 0.39788275485039709R
        '
        'xrTableCell5
        '
        Me.xrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesInscritos.DIRECCION")})
        Me.xrTableCell5.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrTableCell5.Name = "xrTableCell5"
        Me.xrTableCell5.StylePriority.UseFont = False
        Me.xrTableCell5.StylePriority.UseTextAlignment = False
        Me.xrTableCell5.Text = "xrTableCell5"
        Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xrTableCell5.Weight = 1.5470150623910999R
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
        'participantesInscritosTableAdapter1
        '
        Me.participantesInscritosTableAdapter1.ClearBeforeFill = True
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel13, Me.XrLabel8, Me.XrLabel7, Me.xrTable2, Me.xrLabel15, Me.xrLabel14, Me.xrLabelCentro, Me.xrLabel12, Me.xrLabel11, Me.xrLabel10, Me.xrLabel9, Me.xrLabelFechaFinal, Me.xrLabelFechaInicio, Me.xrLabelCodigoGrupo, Me.xrLabelHorario, Me.xrLabelNombreAccionFormativa, Me.xrLabelNombreSitio, Me.xrLabelNombreProveedor, Me.xrLabel4, Me.xrLine1, Me.xrPictureBox1, Me.xrLine3, Me.xrLabel2, Me.xrLabel1, Me.xrLabelTitulo, Me.XrLabel6})
        Me.PageHeader.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.PageHeader.HeightF = 241.4585!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.StylePriority.UseFont = False
        '
        'XrLabel13
        '
        Me.XrLabel13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesInscritos.MUNICIPIO", "{0:dd/MM/yyyy}")})
        Me.XrLabel13.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(561.8748!, 159.0!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(210.1252!, 23.00002!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.Text = "XrLabel13"
        '
        'XrLabel8
        '
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesInscritos.DEPARTAMENTO", "{0:dd/MM/yyyy}")})
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(115.1667!, 159.0!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(285.875!, 23.00002!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.Text = "XrLabel8"
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(449.4165!, 159.0!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(105.1667!, 23.00002!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.Text = "MUNICIPIO:"
        '
        'xrTable2
        '
        Me.xrTable2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrTable2.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 224.7918!)
        Me.xrTable2.Name = "xrTable2"
        Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow2})
        Me.xrTable2.SizeF = New System.Drawing.SizeF(762.0!, 16.66666!)
        Me.xrTable2.StylePriority.UseBorders = False
        Me.xrTable2.StylePriority.UseFont = False
        '
        'xrTableRow2
        '
        Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell11, Me.xrTableCell6, Me.xrTableCell7, Me.xrTableCell10, Me.xrTableCell8, Me.xrTableCell9})
        Me.xrTableRow2.Name = "xrTableRow2"
        Me.xrTableRow2.Weight = 1.0R
        '
        'xrTableCell11
        '
        Me.xrTableCell11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrTableCell11.Name = "xrTableCell11"
        Me.xrTableCell11.StylePriority.UseFont = False
        Me.xrTableCell11.StylePriority.UseTextAlignment = False
        Me.xrTableCell11.Text = "N°"
        Me.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.xrTableCell11.Weight = 0.10343763831215608R
        '
        'xrTableCell6
        '
        Me.xrTableCell6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrTableCell6.Name = "xrTableCell6"
        Me.xrTableCell6.StylePriority.UseFont = False
        Me.xrTableCell6.StylePriority.UseTextAlignment = False
        Me.xrTableCell6.Text = "PARTICIPANTE"
        Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.xrTableCell6.Weight = 0.93804978335680844R
        '
        'xrTableCell7
        '
        Me.xrTableCell7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrTableCell7.Name = "xrTableCell7"
        Me.xrTableCell7.StylePriority.UseFont = False
        Me.xrTableCell7.Text = "PRESEN."
        Me.xrTableCell7.Weight = 0.26719317028789435R
        '
        'xrTableCell10
        '
        Me.xrTableCell10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrTableCell10.Name = "xrTableCell10"
        Me.xrTableCell10.StylePriority.UseFont = False
        Me.xrTableCell10.StylePriority.UseTextAlignment = False
        Me.xrTableCell10.Text = "DUI"
        Me.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.xrTableCell10.Weight = 0.26515540621881772R
        '
        'xrTableCell8
        '
        Me.xrTableCell8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrTableCell8.Name = "xrTableCell8"
        Me.xrTableCell8.StylePriority.UseFont = False
        Me.xrTableCell8.StylePriority.UseTextAlignment = False
        Me.xrTableCell8.Text = "NIT"
        Me.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.xrTableCell8.Weight = 0.4132702654037545R
        '
        'xrTableCell9
        '
        Me.xrTableCell9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrTableCell9.Name = "xrTableCell9"
        Me.xrTableCell9.StylePriority.UseFont = False
        Me.xrTableCell9.StylePriority.UseTextAlignment = False
        Me.xrTableCell9.Text = "DIRECCION"
        Me.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.xrTableCell9.Weight = 1.6068448454364841R
        '
        'xrLabel15
        '
        Me.xrLabel15.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(449.4165!, 136.0!)
        Me.xrLabel15.Name = "xrLabel15"
        Me.xrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel15.SizeF = New System.Drawing.SizeF(105.1667!, 23.0!)
        Me.xrLabel15.StylePriority.UseFont = False
        Me.xrLabel15.Text = "FECHA FINAL:"
        '
        'xrLabel14
        '
        Me.xrLabel14.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(449.4166!, 90.00006!)
        Me.xrLabel14.Name = "xrLabel14"
        Me.xrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel14.SizeF = New System.Drawing.SizeF(105.1667!, 23.0!)
        Me.xrLabel14.StylePriority.UseFont = False
        Me.xrLabel14.Text = "HORARIO:"
        '
        'xrLabelCentro
        '
        Me.xrLabelCentro.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabelCentro.LocationFloat = New DevExpress.Utils.PointFloat(449.4166!, 67.00001!)
        Me.xrLabelCentro.Name = "xrLabelCentro"
        Me.xrLabelCentro.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabelCentro.SizeF = New System.Drawing.SizeF(105.1667!, 23.0!)
        Me.xrLabelCentro.StylePriority.UseFont = False
        Me.xrLabelCentro.Text = "CENTRO:"
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
        Me.xrLabelFechaFinal.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesInscritos.FECHA_FIN", "{0:dd/MM/yyyy}")})
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
        Me.xrLabelFechaInicio.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesInscritos.FECHA_INICIO", "{0:dd/MM/yyyy}")})
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
        Me.xrLabelCodigoGrupo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesInscritos.CODIGO_GRUPO")})
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
        Me.xrLabelHorario.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesInscritos.HORARIO")})
        Me.xrLabelHorario.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabelHorario.LocationFloat = New DevExpress.Utils.PointFloat(561.8749!, 89.99999!)
        Me.xrLabelHorario.Name = "xrLabelHorario"
        Me.xrLabelHorario.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabelHorario.SizeF = New System.Drawing.SizeF(210.1251!, 23.00002!)
        Me.xrLabelHorario.StylePriority.UseFont = False
        Me.xrLabelHorario.Text = "xrLabelHorario"
        '
        'xrLabelNombreAccionFormativa
        '
        Me.xrLabelNombreAccionFormativa.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesInscritos.NOMBRE_ACCION_FORMATIVA")})
        Me.xrLabelNombreAccionFormativa.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabelNombreAccionFormativa.LocationFloat = New DevExpress.Utils.PointFloat(115.1667!, 89.99999!)
        Me.xrLabelNombreAccionFormativa.Name = "xrLabelNombreAccionFormativa"
        Me.xrLabelNombreAccionFormativa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabelNombreAccionFormativa.SizeF = New System.Drawing.SizeF(285.875!, 23.0!)
        Me.xrLabelNombreAccionFormativa.StylePriority.UseFont = False
        Me.xrLabelNombreAccionFormativa.Text = "xrLabelNombreAccionFormativa"
        '
        'xrLabelNombreSitio
        '
        Me.xrLabelNombreSitio.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesInscritos.NOMBRE_SITIO")})
        Me.xrLabelNombreSitio.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabelNombreSitio.LocationFloat = New DevExpress.Utils.PointFloat(561.8749!, 67.00001!)
        Me.xrLabelNombreSitio.Name = "xrLabelNombreSitio"
        Me.xrLabelNombreSitio.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabelNombreSitio.SizeF = New System.Drawing.SizeF(210.1251!, 23.0!)
        Me.xrLabelNombreSitio.StylePriority.UseFont = False
        Me.xrLabelNombreSitio.Text = "xrLabelNombreSitio"
        '
        'xrLabelNombreProveedor
        '
        Me.xrLabelNombreProveedor.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesInscritos.NOMBRE_PROVEEDOR")})
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
        Me.xrPictureBox1.Image = CType(resources.GetObject("xrPictureBox1.Image"), System.Drawing.Image)
        Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 2.0!)
        Me.xrPictureBox1.Name = "xrPictureBox1"
        Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(145.875!, 45.99999!)
        Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'xrLine3
        '
        Me.xrLine3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.xrLine3.Name = "xrLine3"
        Me.xrLine3.SizeF = New System.Drawing.SizeF(772.0!, 2.0!)
        '
        'xrLabel2
        '
        Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesInscritos.INSTRUCTOR")})
        Me.xrLabel2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(176.6139!, 191.2917!)
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel2.SizeF = New System.Drawing.SizeF(595.386!, 23.00002!)
        Me.xrLabel2.StylePriority.UseFont = False
        Me.xrLabel2.Text = "xrLabel2"
        '
        'xrLabel1
        '
        Me.xrLabel1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(9.999911!, 191.2917!)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(166.614!, 23.00002!)
        Me.xrLabel1.StylePriority.UseFont = False
        Me.xrLabel1.Text = "INSTRUCTOR/COMENTARIOS:"
        '
        'xrLabelTitulo
        '
        Me.xrLabelTitulo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabelTitulo.LocationFloat = New DevExpress.Utils.PointFloat(150.0!, 7.583321!)
        Me.xrLabelTitulo.Name = "xrLabelTitulo"
        Me.xrLabelTitulo.SizeF = New System.Drawing.SizeF(584.0!, 19.20834!)
        Me.xrLabelTitulo.StylePriority.UseFont = False
        Me.xrLabelTitulo.StylePriority.UseTextAlignment = False
        Me.xrLabelTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 159.0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(105.1667!, 23.00002!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.Text = "DEPARTAMENTO:"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo2, Me.xrPageInfo1})
        Me.PageFooter.HeightF = 93.37502!
        Me.PageFooter.Name = "PageFooter"
        '
        'xrPageInfo2
        '
        Me.xrPageInfo2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrPageInfo2.Format = "Pagina {0} de {1}"
        Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(337.5!, 60.37496!)
        Me.xrPageInfo2.Name = "xrPageInfo2"
        Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(434.4999!, 23.00002!)
        Me.xrPageInfo2.StylePriority.UseFont = False
        Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrPageInfo1
        '
        Me.xrPageInfo1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrPageInfo1.Format = "{0:dddd, dd' de 'MMMM' de 'yyyy'  Hora: 'hh:mm tt}"
        Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 60.37502!)
        Me.xrPageInfo1.Name = "xrPageInfo1"
        Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
        Me.xrPageInfo1.StylePriority.UseFont = False
        '
        'nombresApellidos
        '
        Me.nombresApellidos.DataMember = "ParticipantesInscritos"
        Me.nombresApellidos.DataSource = Me.dS_DL1
        Me.nombresApellidos.Expression = "Concat([APELLIDOS], Concat(', ', [NOMBRES]) )"
        Me.nombresApellidos.Name = "nombresApellidos"
        '
        'xrLabel5
        '
        Me.xrLabel5.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 30.54167!)
        Me.xrLabel5.Name = "xrLabel5"
        Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel5.SizeF = New System.Drawing.SizeF(161.5!, 22.99999!)
        Me.xrLabel5.StylePriority.UseFont = False
        Me.xrLabel5.Text = "TOTAL DE PARTICIPANTES:"
        '
        'xrLabel3
        '
        Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesInscritos.FECHA_PRESENTACION")})
        Me.xrLabel3.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(171.5!, 30.54167!)
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel3.SizeF = New System.Drawing.SizeF(51.09727!, 22.99999!)
        Me.xrLabel3.StylePriority.UseFont = False
        XrSummary2.FormatString = "{0:#,#}"
        XrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.Count
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.xrLabel3.Summary = XrSummary2
        Me.xrLabel3.Text = "TOTAL PARTICIPANTES: [FECHA_PRESENTACION]"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("ID_TIPO_SELECC", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 16.66666!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrTable3
        '
        Me.XrTable3.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable3.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 0.0!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(762.0!, 16.66666!)
        Me.XrTable3.StylePriority.UseBorders = False
        Me.XrTable3.StylePriority.UseFont = False
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell14})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1.0R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100.0!)
        Me.XrTableCell14.StylePriority.UseFont = False
        Me.XrTableCell14.StylePriority.UsePadding = False
        Me.XrTableCell14.StylePriority.UseTextAlignment = False
        Me.XrTableCell14.Text = "[TIPO_SELECC]"
        Me.XrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell14.Weight = 3.5939511090159151R
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel5, Me.xrLabel3})
        Me.GroupFooter2.HeightF = 63.54167!
        Me.GroupFooter2.Level = 1
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'xrParticipantesInscritosEC
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.PageFooter, Me.GroupHeader1, Me.GroupFooter2})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.nombresApellidos})
        Me.DataAdapter = Me.participantesInscritosTableAdapter1
        Me.DataMember = "ParticipantesInscritos"
        Me.DataSource = Me.dS_DL1
        Me.Margins = New System.Drawing.Printing.Margins(42, 36, 100, 100)
        Me.Version = "11.1"
        CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dS_DL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

#End Region

    Public Sub CargarDatosPorCurso(ByVal idAccionFormativa As Decimal)
        Dim idProgramaFormacion As Decimal = (New cACCION_FORMATIVA).ObtenerProgramaFormacionCurso(idAccionFormativa)
        Dim lProgramaFormacion As PROGRAMA_FORMACION = (New cPROGRAMA_FORMACION).ObtenerPROGRAMA_FORMACION(idProgramaFormacion)
        Dim lAccionFormativa As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(idAccionFormativa)

        Me.dS_DL1.Clear()
        Me.participantesInscritosTableAdapter1.FillPorCurso(Me.dS_DL1.ParticipantesInscritos, idAccionFormativa)

        If lProgramaFormacion IsNot Nothing Then
            Me.xrLabelTitulo.Text = "PROGRAMA: " + lProgramaFormacion.NOMBRE_PROGRAMA_FORMACION + " " + lAccionFormativa.ID_EJERCICIO.ToString
        End If
    End Sub

End Class