Public Class xrCursosRecibidosParticipante
    Inherits DevExpress.XtraReports.UI.XtraReport

    Private mID_PARTICIPANTE As Decimal

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
    Private WithEvents cursosRecibidosParticipanteTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.CursosRecibidosParticipanteTableAdapter
    Private WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Private WithEvents xrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Private WithEvents xrLine3 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLine1 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Private WithEvents xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents nombresApellidos As DevExpress.XtraReports.UI.CalculatedField
    Private WithEvents xrTable1 As DevExpress.XtraReports.UI.XRTable
    Private WithEvents xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Private WithEvents xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents nombreSitioProveedor As DevExpress.XtraReports.UI.CalculatedField
    Private WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Private WithEvents xrNombresApellidos As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrIdParticipante As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents formattingRule1 As DevExpress.XtraReports.UI.FormattingRule
    Private WithEvents xrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Private WithEvents xrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    Private WithEvents XrSubReporteCursosSolicitadosParticipante1 As SGAFP.RL.xrSubReporteCursosSolicitadosParticipante
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Private WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrNIT As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrDUI As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrFechaNacimiento As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrPageInfo3 As DevExpress.XtraReports.UI.XRPageInfo

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xrCursosRecibidosParticipante))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.dS_DL1 = New SGAFP.DL.DS_DL()
        Me.cursosRecibidosParticipanteTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.CursosRecibidosParticipanteTableAdapter()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrPageInfo3 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.xrNIT = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrDUI = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrFechaNacimiento = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrIdParticipante = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.xrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.xrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrNombresApellidos = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.XrSubReporteCursosSolicitadosParticipante1 = New SGAFP.RL.xrSubReporteCursosSolicitadosParticipante()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.nombresApellidos = New DevExpress.XtraReports.UI.CalculatedField()
        Me.nombreSitioProveedor = New DevExpress.XtraReports.UI.CalculatedField()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.formattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dS_DL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrSubReporteCursosSolicitadosParticipante1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1})
        Me.Detail.HeightF = 22.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrTable1
        '
        Me.xrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0.000007947286!, 0.0!)
        Me.xrTable1.Name = "xrTable1"
        Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
        Me.xrTable1.SizeF = New System.Drawing.SizeF(797.0!, 21.99999!)
        Me.xrTable1.StylePriority.UseBorders = False
        '
        'xrTableRow1
        '
        Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell3, Me.XrTableCell12, Me.XrTableCell5, Me.xrTableCell1, Me.XrTableCell4, Me.xrTableCell2})
        Me.xrTableRow1.Name = "xrTableRow1"
        Me.xrTableRow1.Weight = 1.9166665649414063R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CursosRecibidosParticipante.PROGRAMA")})
        Me.XrTableCell3.Font = New System.Drawing.Font("Arial Narrow", 8.0!)
        Me.XrTableCell3.Multiline = True
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseBorders = False
        Me.XrTableCell3.StylePriority.UseFont = False
        Me.XrTableCell3.Text = "XrTableCell3"
        Me.XrTableCell3.Weight = 0.48665764248992704R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CursosRecibidosParticipante.NOMBRE_PROVEEDOR")})
        Me.XrTableCell12.Font = New System.Drawing.Font("Arial Narrow", 8.0!)
        Me.XrTableCell12.Multiline = True
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100.0!)
        Me.XrTableCell12.StylePriority.UseBorders = False
        Me.XrTableCell12.StylePriority.UseFont = False
        Me.XrTableCell12.StylePriority.UsePadding = False
        Me.XrTableCell12.Text = "XrTableCell12"
        Me.XrTableCell12.Weight = 0.51914207214088059R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CursosRecibidosParticipante.NOMBRE_SITIO")})
        Me.XrTableCell5.Font = New System.Drawing.Font("Arial Narrow", 8.0!)
        Me.XrTableCell5.Multiline = True
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100.0!)
        Me.XrTableCell5.StylePriority.UseBorders = False
        Me.XrTableCell5.StylePriority.UseFont = False
        Me.XrTableCell5.StylePriority.UsePadding = False
        Me.XrTableCell5.Text = "[NOMBRE_SITIO]"
        Me.XrTableCell5.Weight = 0.75823371551310481R
        '
        'xrTableCell1
        '
        Me.xrTableCell1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CursosRecibidosParticipante.NOMBRE_ACCION_FORMATIVA")})
        Me.xrTableCell1.Font = New System.Drawing.Font("Arial Narrow", 8.0!)
        Me.xrTableCell1.Multiline = True
        Me.xrTableCell1.Name = "xrTableCell1"
        Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100.0!)
        Me.xrTableCell1.StylePriority.UseBorders = False
        Me.xrTableCell1.StylePriority.UseFont = False
        Me.xrTableCell1.StylePriority.UsePadding = False
        Me.xrTableCell1.Text = "xrTableCell1"
        Me.xrTableCell1.Weight = 0.79065455897833292R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CursosRecibidosParticipante.CODIGO_GRUPO")})
        Me.XrTableCell4.Font = New System.Drawing.Font("Arial Narrow", 8.0!)
        Me.XrTableCell4.Multiline = True
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100.0!)
        Me.XrTableCell4.StylePriority.UseBorders = False
        Me.XrTableCell4.StylePriority.UseFont = False
        Me.XrTableCell4.StylePriority.UsePadding = False
        Me.XrTableCell4.Text = "XrTableCell4"
        Me.XrTableCell4.Weight = 0.37584006745103193R
        '
        'xrTableCell2
        '
        Me.xrTableCell2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CursosRecibidosParticipante.ID_EJERCICIO")})
        Me.xrTableCell2.Font = New System.Drawing.Font("Arial Narrow", 8.0!)
        Me.xrTableCell2.Multiline = True
        Me.xrTableCell2.Name = "xrTableCell2"
        Me.xrTableCell2.StylePriority.UseBorders = False
        Me.xrTableCell2.StylePriority.UseFont = False
        Me.xrTableCell2.StylePriority.UseTextAlignment = False
        Me.xrTableCell2.Text = "[CursosRecibidosParticipante.ID_EJERCICIO]"
        Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.xrTableCell2.Weight = 0.33613779629130613R
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 35.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 40.0!
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
        'cursosRecibidosParticipanteTableAdapter1
        '
        Me.cursosRecibidosParticipanteTableAdapter1.ClearBeforeFill = True
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo3, Me.xrNIT, Me.xrDUI, Me.xrFechaNacimiento, Me.XrLabel8, Me.XrLabel7, Me.XrLabel2, Me.xrIdParticipante, Me.xrLine1, Me.xrLabel4, Me.xrPictureBox1, Me.xrLine3, Me.xrLabel27, Me.xrLabel1, Me.xrNombresApellidos, Me.xrSubreport1})
        Me.PageHeader.HeightF = 288.3334!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrPageInfo3
        '
        Me.XrPageInfo3.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrPageInfo3.Format = "{0:dd/MM/yyyy HH:mm}"
        Me.XrPageInfo3.LocationFloat = New DevExpress.Utils.PointFloat(689.625!, 32.99999!)
        Me.XrPageInfo3.Name = "XrPageInfo3"
        Me.XrPageInfo3.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo3.SizeF = New System.Drawing.SizeF(97.37495!, 23.0!)
        Me.XrPageInfo3.StylePriority.UseFont = False
        '
        'xrNIT
        '
        Me.xrNIT.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrNIT.LocationFloat = New DevExpress.Utils.PointFloat(91.54179!, 128.5417!)
        Me.xrNIT.Name = "xrNIT"
        Me.xrNIT.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrNIT.SizeF = New System.Drawing.SizeF(695.4582!, 18.0!)
        Me.xrNIT.StylePriority.UseFont = False
        '
        'xrDUI
        '
        Me.xrDUI.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrDUI.LocationFloat = New DevExpress.Utils.PointFloat(91.54167!, 110.5417!)
        Me.xrDUI.Name = "xrDUI"
        Me.xrDUI.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrDUI.SizeF = New System.Drawing.SizeF(695.4582!, 18.0!)
        Me.xrDUI.StylePriority.UseFont = False
        '
        'xrFechaNacimiento
        '
        Me.xrFechaNacimiento.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrFechaNacimiento.LocationFloat = New DevExpress.Utils.PointFloat(91.54167!, 92.54166!)
        Me.xrFechaNacimiento.Name = "xrFechaNacimiento"
        Me.xrFechaNacimiento.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrFechaNacimiento.SizeF = New System.Drawing.SizeF(695.4582!, 18.0!)
        Me.xrFechaNacimiento.StylePriority.UseFont = False
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 128.5417!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(81.54166!, 18.0!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.Text = "NIT:"
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 110.5417!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(81.54166!, 18.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.Text = "DUI:"
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 92.54166!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(81.54166!, 18.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.Text = "Fecha Nac.:"
        '
        'xrIdParticipante
        '
        Me.xrIdParticipante.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrIdParticipante.LocationFloat = New DevExpress.Utils.PointFloat(91.54167!, 74.54166!)
        Me.xrIdParticipante.Name = "xrIdParticipante"
        Me.xrIdParticipante.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrIdParticipante.SizeF = New System.Drawing.SizeF(58.33334!, 18.0!)
        Me.xrIdParticipante.StylePriority.UseFont = False
        '
        'xrLine1
        '
        Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 56.00001!)
        Me.xrLine1.Name = "xrLine1"
        Me.xrLine1.SizeF = New System.Drawing.SizeF(786.9999!, 5.000004!)
        '
        'xrLabel4
        '
        Me.xrLabel4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(149.875!, 36.79168!)
        Me.xrLabel4.Name = "xrLabel4"
        Me.xrLabel4.SizeF = New System.Drawing.SizeF(506.7087!, 19.20834!)
        Me.xrLabel4.StylePriority.UseFont = False
        Me.xrLabel4.StylePriority.UseTextAlignment = False
        Me.xrLabel4.Text = "CURSOS SOLICITADOS Y RECIBIDOS POR PARTICIPANTE"
        Me.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrPictureBox1
        '
        Me.xrPictureBox1.Image = CType(resources.GetObject("xrPictureBox1.Image"), System.Drawing.Image)
        Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 10.0!)
        Me.xrPictureBox1.Name = "xrPictureBox1"
        Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(145.875!, 45.99999!)
        Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'xrLine3
        '
        Me.xrLine3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.xrLine3.Name = "xrLine3"
        Me.xrLine3.SizeF = New System.Drawing.SizeF(787.0!, 2.083333!)
        '
        'xrLabel27
        '
        Me.xrLabel27.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(149.875!, 10.00001!)
        Me.xrLabel27.Name = "xrLabel27"
        Me.xrLabel27.SizeF = New System.Drawing.SizeF(505.7086!, 19.20834!)
        Me.xrLabel27.StylePriority.UseFont = False
        Me.xrLabel27.StylePriority.UseTextAlignment = False
        Me.xrLabel27.Text = "SISTEMA DE GESTIÓN Y ADMINISTRACIÓN DE LA FORMACIÓN PROFESIONAL"
        Me.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel1
        '
        Me.xrLabel1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 74.54166!)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(81.54166!, 18.0!)
        Me.xrLabel1.StylePriority.UseFont = False
        Me.xrLabel1.Text = "Participante:"
        '
        'xrNombresApellidos
        '
        Me.xrNombresApellidos.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrNombresApellidos.LocationFloat = New DevExpress.Utils.PointFloat(149.875!, 74.54166!)
        Me.xrNombresApellidos.Name = "xrNombresApellidos"
        Me.xrNombresApellidos.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrNombresApellidos.SizeF = New System.Drawing.SizeF(637.1249!, 17.99998!)
        Me.xrNombresApellidos.StylePriority.UseFont = False
        '
        'xrSubreport1
        '
        Me.xrSubreport1.CanShrink = True
        Me.xrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(0.000007947286!, 179.5834!)
        Me.xrSubreport1.Name = "xrSubreport1"
        Me.xrSubreport1.ReportSource = Me.XrSubReporteCursosSolicitadosParticipante1
        Me.xrSubreport1.SizeF = New System.Drawing.SizeF(797.0!, 108.75!)
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo2})
        Me.PageFooter.HeightF = 34.00002!
        Me.PageFooter.Name = "PageFooter"
        '
        'xrPageInfo2
        '
        Me.xrPageInfo2.Format = "Pagina {0} de {1}"
        Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(491.0002!, 9.999974!)
        Me.xrPageInfo2.Name = "xrPageInfo2"
        Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(296.9998!, 23.00002!)
        Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'nombresApellidos
        '
        Me.nombresApellidos.DataMember = "CursosRecibidosParticipante"
        Me.nombresApellidos.DataSource = Me.dS_DL1
        Me.nombresApellidos.Expression = "Concat(Concat([APELLIDOS], ', '), [NOMBRES])"
        Me.nombresApellidos.Name = "nombresApellidos"
        '
        'nombreSitioProveedor
        '
        Me.nombreSitioProveedor.DataMember = "CursosRecibidosParticipante"
        Me.nombreSitioProveedor.DataSource = Me.dS_DL1
        Me.nombreSitioProveedor.Expression = "Concat(Concat([NOMBRE_PROVEEDOR], ' - '), [NOMBRE_SITIO])"
        Me.nombreSitioProveedor.Name = "nombreSitioProveedor"
        '
        'ReportHeader
        '
        Me.ReportHeader.HeightF = 34.0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'formattingRule1
        '
        Me.formattingRule1.Name = "formattingRule1"
        '
        'xrLabel6
        '
        Me.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrLabel6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0.000007947286!, 42.70833!)
        Me.xrLabel6.Name = "xrLabel6"
        Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel6.SizeF = New System.Drawing.SizeF(797.0!, 18.0!)
        Me.xrLabel6.StylePriority.UseBorders = False
        Me.xrLabel6.StylePriority.UseFont = False
        Me.xrLabel6.StylePriority.UseTextAlignment = False
        Me.xrLabel6.Text = "CURSOS RECIBIDOS"
        Me.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2, Me.xrLabel6})
        Me.GroupHeader1.HeightF = 86.45833!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0.000007947286!, 60.70836!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(797.0!, 25.74997!)
        Me.XrTable2.StylePriority.UseBorders = False
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell6, Me.XrTableCell11, Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell9, Me.XrTableCell10})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.9166665649414063R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell6.CanGrow = False
        Me.XrTableCell6.Font = New System.Drawing.Font("Arial Narrow", 8.0!)
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100.0!)
        Me.XrTableCell6.StylePriority.UseBorders = False
        Me.XrTableCell6.StylePriority.UseFont = False
        Me.XrTableCell6.StylePriority.UsePadding = False
        Me.XrTableCell6.StylePriority.UseTextAlignment = False
        Me.XrTableCell6.Text = "PROGRAMA"
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell6.Weight = 0.486657611219309R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell11.CanGrow = False
        Me.XrTableCell11.Font = New System.Drawing.Font("Arial Narrow", 8.0!)
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100.0!)
        Me.XrTableCell11.StylePriority.UseBorders = False
        Me.XrTableCell11.StylePriority.UseFont = False
        Me.XrTableCell11.StylePriority.UsePadding = False
        Me.XrTableCell11.StylePriority.UseTextAlignment = False
        Me.XrTableCell11.Text = "PROVEEDOR"
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell11.Weight = 0.519142228493971R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell7.CanGrow = False
        Me.XrTableCell7.Font = New System.Drawing.Font("Arial Narrow", 8.0!)
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100.0!)
        Me.XrTableCell7.StylePriority.UseBorders = False
        Me.XrTableCell7.StylePriority.UseFont = False
        Me.XrTableCell7.StylePriority.UsePadding = False
        Me.XrTableCell7.StylePriority.UseTextAlignment = False
        Me.XrTableCell7.Text = "CENTRO FORMACIÓN"
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell7.Weight = 0.75823346534816038R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell8.CanGrow = False
        Me.XrTableCell8.Font = New System.Drawing.Font("Arial Narrow", 8.0!)
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100.0!)
        Me.XrTableCell8.StylePriority.UseBorders = False
        Me.XrTableCell8.StylePriority.UseFont = False
        Me.XrTableCell8.StylePriority.UsePadding = False
        Me.XrTableCell8.StylePriority.UseTextAlignment = False
        Me.XrTableCell8.Text = "CURSO"
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell8.Weight = 0.79065468406080486R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell9.CanGrow = False
        Me.XrTableCell9.Font = New System.Drawing.Font("Arial Narrow", 8.0!)
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100.0!)
        Me.XrTableCell9.StylePriority.UseBorders = False
        Me.XrTableCell9.StylePriority.UseFont = False
        Me.XrTableCell9.StylePriority.UsePadding = False
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.Text = "CÓDIGO"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell9.Weight = 0.37584006745103193R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell10.CanGrow = False
        Me.XrTableCell10.Font = New System.Drawing.Font("Arial Narrow", 8.0!)
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 0, 0, 0, 100.0!)
        Me.XrTableCell10.StylePriority.UseBorders = False
        Me.XrTableCell10.StylePriority.UseFont = False
        Me.XrTableCell10.StylePriority.UsePadding = False
        Me.XrTableCell10.StylePriority.UseTextAlignment = False
        Me.XrTableCell10.Text = "AÑO"
        Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell10.Weight = 0.33613779629130613R
        '
        'xrCursosRecibidosParticipante
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.PageHeader, Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageFooter, Me.ReportHeader, Me.GroupHeader1})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.nombresApellidos, Me.nombreSitioProveedor})
        Me.DataAdapter = Me.cursosRecibidosParticipanteTableAdapter1
        Me.DataMember = "CursosRecibidosParticipante"
        Me.DataSource = Me.dS_DL1
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.formattingRule1})
        Me.Margins = New System.Drawing.Printing.Margins(29, 24, 35, 40)
        Me.Version = "11.1"
        CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dS_DL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrSubReporteCursosSolicitadosParticipante1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

#End Region

    Public Sub CargarDatosPorParticipante(ByVal idParticipante As Decimal)
        mID_PARTICIPANTE = idParticipante
        Me.dS_DL1.Clear()
        Me.cursosRecibidosParticipanteTableAdapter1.FillPorIDParticipante(Me.dS_DL1.CursosRecibidosParticipante, idParticipante)

        Dim lParticipante As PARTICIPANTE = (New cPARTICIPANTE).ObtenerPARTICIPANTE(idParticipante)
        If lParticipante IsNot Nothing Then
            Me.xrIdParticipante.Text = idParticipante.ToString
            Me.xrNombresApellidos.Text = lParticipante.NOMBRES + " " + lParticipante.APELLIDOS
            Me.xrFechaNacimiento.Text = lParticipante.FECHA_NACIMIENTO.ToString("dd/MM/yyyy")
            Me.xrDUI.Text = Utilerias.FormatearDUI(lParticipante.DUI)
            Me.xrNIT.Text = Utilerias.FormatearNIT(lParticipante.NIT)
        End If
    End Sub

    Private Sub xrSubreport1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrSubreport1.BeforePrint
        Dim detail As xrSubReporteCursosSolicitadosParticipante = TryCast(xrSubreport1.ReportSource, xrSubReporteCursosSolicitadosParticipante)
        If detail IsNot Nothing Then
            detail.CargarDatosPorParticipante(mID_PARTICIPANTE)
            detail.FillDataSource()
            e.Cancel = False
        End If
    End Sub
 
End Class