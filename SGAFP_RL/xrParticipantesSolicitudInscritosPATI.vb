Public Class xrParticipantesSolicitudInscritosPATI
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
    Private WithEvents xrTable1 As DevExpress.XtraReports.UI.XRTable
    Private WithEvents xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Private WithEvents xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents nombresApellidos As DevExpress.XtraReports.UI.CalculatedField
    Private WithEvents xrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrTable2 As DevExpress.XtraReports.UI.XRTable
    Private WithEvents xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Private WithEvents xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Private WithEvents xrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents NOMBRE_PARTICIPANTE As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents ParticipantesSolicitudInscritosPATITableAdapter1 As SGAFP.DL.DS_DLTableAdapters.ParticipantesSolicitudInscritosPATITableAdapter
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TIPO_PATI As DevExpress.XtraReports.UI.CalculatedField
    Private WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.dS_DL1 = New SGAFP.DL.DS_DL()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.xrLabelTitulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabelNombreAccionFormativa = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabelNombreProveedor = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.nombresApellidos = New DevExpress.XtraReports.UI.CalculatedField()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.NOMBRE_PARTICIPANTE = New DevExpress.XtraReports.UI.CalculatedField()
        Me.ParticipantesSolicitudInscritosPATITableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.ParticipantesSolicitudInscritosPATITableAdapter()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TIPO_PATI = New DevExpress.XtraReports.UI.CalculatedField()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dS_DL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1})
        Me.Detail.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Detail.HeightF = 18.99999!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StylePriority.UseFont = False
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
        Me.xrTable1.SizeF = New System.Drawing.SizeF(987.0!, 18.99999!)
        Me.xrTable1.StylePriority.UseBorders = False
        Me.xrTable1.StylePriority.UseFont = False
        '
        'xrTableRow1
        '
        Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell12, Me.XrTableCell9, Me.XrTableCell4, Me.xrTableCell1, Me.XrTableCell10, Me.XrTableCell15, Me.XrTableCell16})
        Me.xrTableRow1.Name = "xrTableRow1"
        Me.xrTableRow1.Weight = 1.0R
        '
        'xrTableCell12
        '
        Me.xrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesSolicitudInscritosPATI.ID_ACCION_FORMATIVA")})
        Me.xrTableCell12.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrTableCell12.Name = "xrTableCell12"
        Me.xrTableCell12.StylePriority.UseFont = False
        Me.xrTableCell12.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:#}"
        XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.xrTableCell12.Summary = XrSummary1
        Me.xrTableCell12.Text = "xrTableCell12"
        Me.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.xrTableCell12.Weight = 0.11120275529459284R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesSolicitudInscritosPATI.NOMBRE_PARTICIPANTE")})
        Me.XrTableCell9.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        Me.XrTableCell9.StylePriority.UseFont = False
        Me.XrTableCell9.StylePriority.UsePadding = False
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.Text = "XrTableCell9"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell9.Weight = 1.0266530450667664R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesSolicitudInscritosPATI.GENERO")})
        Me.XrTableCell4.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseFont = False
        Me.XrTableCell4.StylePriority.UseTextAlignment = False
        Me.XrTableCell4.Text = "XrTableCell4"
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell4.Weight = 0.22884419199215428R
        '
        'xrTableCell1
        '
        Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesSolicitudInscritosPATI.NUM_CONVENIO")})
        Me.xrTableCell1.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.xrTableCell1.Name = "xrTableCell1"
        Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.xrTableCell1.StylePriority.UseFont = False
        Me.xrTableCell1.StylePriority.UsePadding = False
        Me.xrTableCell1.Text = "xrTableCell1"
        Me.xrTableCell1.Weight = 0.36970203625911369R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesSolicitudInscritosPATI.NUM_FICHA_PATI")})
        Me.XrTableCell10.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseFont = False
        Me.XrTableCell10.Text = "XrTableCell10"
        Me.XrTableCell10.Weight = 0.35331272636182876R
        '
        'XrTableCell15
        '
        Me.XrTableCell15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesSolicitudInscritosPATI.DUI")})
        Me.XrTableCell15.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.StylePriority.UseFont = False
        Me.XrTableCell15.Text = "XrTableCell15"
        Me.XrTableCell15.Weight = 0.343430025006936R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesSolicitudInscritosPATI.ESTADO")})
        Me.XrTableCell16.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.StylePriority.UseFont = False
        Me.XrTableCell16.Text = "XrTableCell16"
        Me.XrTableCell16.Weight = 0.87123975312390889R
        '
        'TopMargin
        '
        Me.TopMargin.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.StylePriority.UseFont = False
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
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel8, Me.xrLabel4, Me.xrLine1, Me.xrPictureBox1, Me.xrLabelTitulo, Me.xrLine3})
        Me.PageHeader.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.PageHeader.HeightF = 61.49998!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.StylePriority.UseFont = False
        '
        'XrLabel8
        '
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesSolicitudInscritosPATI.TIPO_PATI")})
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(418.2251!, 21.20832!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(132.2917!, 18.83333!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "XrLabel8"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel4
        '
        Me.xrLabel4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(187.9999!, 40.04165!)
        Me.xrLabel4.Name = "xrLabel4"
        Me.xrLabel4.SizeF = New System.Drawing.SizeF(584.0!, 19.20834!)
        Me.xrLabel4.StylePriority.UseFont = False
        Me.xrLabel4.StylePriority.UseTextAlignment = False
        Me.xrLabel4.Text = "PARTICIPANTES POR GRUPO"
        Me.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLine1
        '
        Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 59.24999!)
        Me.xrLine1.Name = "xrLine1"
        Me.xrLine1.SizeF = New System.Drawing.SizeF(997.0!, 2.0!)
        '
        'xrPictureBox1
        '
        Me.xrPictureBox1.Image = Global.SGAFP.RL.My.Resources.Resources.logoInsaforp
        Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 1.999982!)
        Me.xrPictureBox1.Name = "xrPictureBox1"
        Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(187.9999!, 57.25001!)
        Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'xrLabelTitulo
        '
        Me.xrLabelTitulo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabelTitulo.LocationFloat = New DevExpress.Utils.PointFloat(187.9999!, 2.0!)
        Me.xrLabelTitulo.Name = "xrLabelTitulo"
        Me.xrLabelTitulo.SizeF = New System.Drawing.SizeF(584.0!, 19.20834!)
        Me.xrLabelTitulo.StylePriority.UseFont = False
        Me.xrLabelTitulo.StylePriority.UseTextAlignment = False
        Me.xrLabelTitulo.Text = "PROGRAMA DE APOYO TEMPORAL AL INGRESO"
        Me.xrLabelTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLine3
        '
        Me.xrLine3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.xrLine3.Name = "xrLine3"
        Me.xrLine3.SizeF = New System.Drawing.SizeF(997.0!, 2.0!)
        '
        'xrTable2
        '
        Me.xrTable2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrTable2.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 98.5002!)
        Me.xrTable2.Name = "xrTable2"
        Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow2})
        Me.xrTable2.SizeF = New System.Drawing.SizeF(987.0!, 14.83313!)
        Me.xrTable2.StylePriority.UseBorders = False
        Me.xrTable2.StylePriority.UseFont = False
        '
        'xrTableRow2
        '
        Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell11, Me.XrTableCell5, Me.XrTableCell3, Me.xrTableCell6, Me.XrTableCell8, Me.XrTableCell13, Me.XrTableCell14})
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
        Me.xrTableCell11.Weight = 0.12468791250924577R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseFont = False
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        Me.XrTableCell5.Text = "NOMBRE PARTICIPANTE"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell5.Weight = 1.1511515963612702R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell3.Multiline = True
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseFont = False
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.Text = "GENERO"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell3.Weight = 0.25659520418305415R
        '
        'xrTableCell6
        '
        Me.xrTableCell6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrTableCell6.Name = "xrTableCell6"
        Me.xrTableCell6.StylePriority.UseFont = False
        Me.xrTableCell6.StylePriority.UseTextAlignment = False
        Me.xrTableCell6.Text = "N° CONVENIO"
        Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.xrTableCell6.Weight = 0.4145344779540579R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Multiline = True
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseTextAlignment = False
        Me.XrTableCell8.Text = "NO. FICHA"
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell8.Weight = 0.39615767147132175R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.StylePriority.UseTextAlignment = False
        Me.XrTableCell13.Text = "NO. DUI"
        Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell13.Weight = 0.3850766499762529R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.StylePriority.UseTextAlignment = False
        Me.XrTableCell14.Text = "OBSERVACIONES"
        Me.XrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell14.Weight = 0.97689208627609569R
        '
        'xrLabel11
        '
        Me.xrLabel11.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(576.0417!, 32.99999!)
        Me.xrLabel11.Name = "xrLabel11"
        Me.xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel11.SizeF = New System.Drawing.SizeF(82.24994!, 22.99998!)
        Me.xrLabel11.StylePriority.UseFont = False
        Me.xrLabel11.Text = "ID GRUPO:"
        '
        'xrLabel10
        '
        Me.xrLabel10.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 32.99996!)
        Me.xrLabel10.Name = "xrLabel10"
        Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel10.SizeF = New System.Drawing.SizeF(105.1667!, 23.0!)
        Me.xrLabel10.StylePriority.UseFont = False
        Me.xrLabel10.Text = "CURSO:"
        '
        'xrLabel9
        '
        Me.xrLabel9.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 9.999974!)
        Me.xrLabel9.Name = "xrLabel9"
        Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel9.SizeF = New System.Drawing.SizeF(105.1667!, 23.0!)
        Me.xrLabel9.StylePriority.UseFont = False
        Me.xrLabel9.Text = "PROVEEDOR:"
        '
        'xrLabelNombreAccionFormativa
        '
        Me.xrLabelNombreAccionFormativa.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesSolicitudInscritosPATI.NOMBRE_ACCION_FORMATIVA")})
        Me.xrLabelNombreAccionFormativa.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabelNombreAccionFormativa.LocationFloat = New DevExpress.Utils.PointFloat(115.1667!, 32.99996!)
        Me.xrLabelNombreAccionFormativa.Name = "xrLabelNombreAccionFormativa"
        Me.xrLabelNombreAccionFormativa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabelNombreAccionFormativa.SizeF = New System.Drawing.SizeF(413.4861!, 22.99998!)
        Me.xrLabelNombreAccionFormativa.StylePriority.UseFont = False
        Me.xrLabelNombreAccionFormativa.Text = "xrLabelNombreAccionFormativa"
        '
        'xrLabelNombreProveedor
        '
        Me.xrLabelNombreProveedor.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesSolicitudInscritosPATI.NOMBRE_PROVEEDOR")})
        Me.xrLabelNombreProveedor.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabelNombreProveedor.LocationFloat = New DevExpress.Utils.PointFloat(115.1667!, 9.999974!)
        Me.xrLabelNombreProveedor.Name = "xrLabelNombreProveedor"
        Me.xrLabelNombreProveedor.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabelNombreProveedor.SizeF = New System.Drawing.SizeF(413.4862!, 23.0!)
        Me.xrLabelNombreProveedor.StylePriority.UseFont = False
        Me.xrLabelNombreProveedor.Text = "xrLabelNombreProveedor"
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
        Me.GroupFooter1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        '
        'xrLabel5
        '
        Me.xrLabel5.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(8.95834!, 9.999974!)
        Me.xrLabel5.Name = "xrLabel5"
        Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel5.SizeF = New System.Drawing.SizeF(161.5!, 22.99999!)
        Me.xrLabel5.StylePriority.UseFont = False
        Me.xrLabel5.Text = "TOTAL DE PARTICIPANTES:"
        '
        'xrLabel3
        '
        Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesSolicitudInscritosPATI.NUM_FICHA_PATI")})
        Me.xrLabel3.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(170.4583!, 9.999974!)
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel3.SizeF = New System.Drawing.SizeF(51.09727!, 22.99999!)
        Me.xrLabel3.StylePriority.UseFont = False
        XrSummary2.FormatString = "{0:#,#}"
        XrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.Count
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.xrLabel3.Summary = XrSummary2
        Me.xrLabel3.Text = "xrLabel3"
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(576.0417!, 10.00001!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(82.24998!, 23.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.Text = "TDR:"
        '
        'XrLabel6
        '
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesSolicitudInscritosPATI.TDR")})
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(671.4169!, 10.00001!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(145.25!, 23.0!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.Text = "XrTerminoReferencia"
        '
        'NOMBRE_PARTICIPANTE
        '
        Me.NOMBRE_PARTICIPANTE.DataMember = "ParticipantesSolicitudInscritosPATI"
        Me.NOMBRE_PARTICIPANTE.DataSource = Me.dS_DL1
        Me.NOMBRE_PARTICIPANTE.Expression = "Concat([NOMBRES], Concat(', ', [APELLIDOS]) )"
        Me.NOMBRE_PARTICIPANTE.Name = "NOMBRE_PARTICIPANTE"
        '
        'ParticipantesSolicitudInscritosPATITableAdapter1
        '
        Me.ParticipantesSolicitudInscritosPATITableAdapter1.ClearBeforeFill = True
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel15, Me.XrLabel14, Me.XrLabel12, Me.XrLabel13, Me.XrLabel7, Me.XrLabel1, Me.xrLabel9, Me.xrLabelNombreProveedor, Me.xrLabelNombreAccionFormativa, Me.xrLabel10, Me.xrLabel11, Me.xrTable2, Me.XrLabel2, Me.XrLabel6, Me.XrLabel16})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("ID_ACCION_FORMATIVA", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 113.9583!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLabel15
        '
        Me.XrLabel15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesSolicitudInscritosPATI.ID_ACCION_FORMATIVA")})
        Me.XrLabel15.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(897.8749!, 32.99993!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(114.1251!, 22.99999!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.Text = "XrLabel15"
        '
        'XrLabel14
        '
        Me.XrLabel14.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(828.125!, 32.99993!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(69.74994!, 22.99998!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.Text = "ID CURSO:"
        '
        'XrLabel12
        '
        Me.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesSolicitudInscritosPATI.NOMBRE_AUP")})
        Me.XrLabel12.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(432.1208!, 55.99998!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(564.8793!, 40.70832!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.Text = "XrLabel12"
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(349.8708!, 55.99998!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(82.24994!, 22.99998!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.Text = "NOMBRE AUP:"
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 55.99995!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(105.1667!, 23.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.Text = "MUNICIPIO:"
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesSolicitudInscritosPATI.CORRELATIVO_GRUPO")})
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(671.4169!, 32.99993!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(145.2499!, 23.00002!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "XrLabel1"
        '
        'TIPO_PATI
        '
        Me.TIPO_PATI.DataMember = "ParticipantesSolicitudInscritosPATI"
        Me.TIPO_PATI.DataSource = Me.dS_DL1
        Me.TIPO_PATI.Expression = "Iif(Substring([TDR],4  ,2 )='10','PATI-BM' ,'PATI-AID' )"
        Me.TIPO_PATI.Name = "TIPO_PATI"
        '
        'XrLabel16
        '
        Me.XrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ParticipantesSolicitudInscritosPATI.NOMBRE_MUNICIPIO")})
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(115.1667!, 55.99998!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(217.7083!, 23.0!)
        Me.XrLabel16.Text = "XrLabel16"
        '
        'xrParticipantesSolicitudInscritosPATI
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.PageFooter, Me.GroupFooter1, Me.GroupHeader1})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.nombresApellidos, Me.NOMBRE_PARTICIPANTE, Me.TIPO_PATI})
        Me.DataMember = "ParticipantesSolicitudInscritosPATI"
        Me.DataSource = Me.dS_DL1
        Me.DefaultPrinterSettingsUsing.UseLandscape = True
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(42, 36, 100, 100)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.Version = "11.1"
        CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dS_DL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

#End Region
    Dim lAccionFormativaDetalle As ACCION_FORMATIVA_DETALLE
    Dim lAccionFormativaDeta As ACCION_FORMATIVA_DETALLE
    Dim codDepto As String
    Dim codMunic As String

    Public Sub CargarDatos(ByVal idAccionFormativa As Decimal)
        Dim lAccionFormativa As ACCION_FORMATIVA
        lAccionFormativa = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(idAccionFormativa)

        Dim lTermino As TERMINO_REFERENCIA_AF
        lTermino = (New cTERMINO_REFERENCIA_AF).ObtenerTERMINO_REFERENCIA_AF(idAccionFormativa)

        lAccionFormativaDetalle = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(idAccionFormativa)
        codDepto = lAccionFormativaDetalle.CODIGO_DEPARTAMENTO
        codMunic = lAccionFormativaDetalle.CODIGO_MUNICIPIO
        Me.dS_DL1.Clear()
        Me.ParticipantesSolicitudInscritosPATITableAdapter1.FillByProveedorTdr(Me.dS_DL1.ParticipantesSolicitudInscritosPATI, lAccionFormativa.ID_PROVEEDOR_AF, lTermino.TDR)
    End Sub

    Public Sub CargarDatosTotal(ByVal idFuente As Decimal, ByVal noConv As Decimal, ByVal acodDepto As String, ByVal acodMunic As String)
        Me.dS_DL1.Clear()
        codDepto = acodDepto
        codMunic = acodMunic
        Me.ParticipantesSolicitudInscritosPATITableAdapter1.FillByFueConDepMun(Me.dS_DL1.ParticipantesSolicitudInscritosPATI, idFuente, noConv, codDepto, codMunic)
    End Sub

    Public Sub CargarDatosIdAF(ByVal idAccionFormativa As Decimal)
        Me.dS_DL1.Clear()
        Me.ParticipantesSolicitudInscritosPATITableAdapter1.FillByIdAF(Me.dS_DL1.ParticipantesSolicitudInscritosPATI, idAccionFormativa)
    End Sub

    Private Sub xrParticipantesSolicitudInscritosPATI_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
        Dim lMunicipio As MUNICIPIO

        lMunicipio = (New cMUNICIPIO).ObtenerMUNICIPIO(codDepto, codMunic)
        'Me.xrlNombreMunicipio.Text = lMunicipio.NOMBRE
    End Sub
End Class