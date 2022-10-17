Imports System.Text
Imports SGAFP.DL

Public Class xrInformeFinalAnexo1A
#Region " Designer generated code "
    Inherits DevExpress.XtraReports.UI.XtraReport

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
    Friend WithEvents DS_DL1 As SGAFP.DL.DS_DL
    Friend WithEvents InformeFinal1aTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.InformeFinal1aTableAdapter
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents AsistenciA_AF_HORARIOTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.ASISTENCIA_AF_HORARIOTableAdapter
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTotalHoras As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents FormattingRule1 As DevExpress.XtraReports.UI.FormattingRule
    Private WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblFUENTE_FINANCIAMIENTO As DevExpress.XtraReports.UI.XRLabel

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xrInformeFinalAnexo1A))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrTitulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.lblFUENTE_FINANCIAMIENTO = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DS_DL1 = New SGAFP.DL.DS_DL()
        Me.InformeFinal1aTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.InformeFinal1aTableAdapter()
        Me.AsistenciA_AF_HORARIOTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.ASISTENCIA_AF_HORARIOTableAdapter()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTotalHoras = New DevExpress.XtraReports.UI.XRTableCell()
        Me.FormattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.HeightF = 25.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(649.9999!, 25.0!)
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeFinal1a.FECHA", "{0:ddd dd/MM/yyyy}")})
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Text = "XrTableCell4"
        Me.XrTableCell4.Weight = 1.2916668701171876R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeFinal1a.ID_ASISTENCIA_AF")})
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        Me.XrTableCell5.Text = "XrTableCell5"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell5.Weight = 3.9937506103515625R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeFinal1a.CANTIDAD_HORAS")})
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Text = "XrTableCell6"
        Me.XrTableCell6.Weight = 1.2145812988281253R
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 59.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 42.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel10, Me.XrLabel21})
        Me.ReportFooter.HeightF = 141.0!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLabel10
        '
        Me.XrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(378.4888!, 80.00002!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(271.5112!, 23.00002!)
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.Text = "                                                                                 " & _
    "               "
        '
        'XrLabel21
        '
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(378.4888!, 105.0!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(271.5112!, 17.99997!)
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = "Responsable Proveedor/Capacitador"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrPictureBox1
        '
        Me.xrPictureBox1.Image = CType(resources.GetObject("xrPictureBox1.Image"), System.Drawing.Image)
        Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.xrPictureBox1.Name = "xrPictureBox1"
        Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(145.875!, 45.99999!)
        Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(590.6666!, 0.0!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(59.33337!, 23.0!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.Text = "Anexo I-A"
        '
        'xrTitulo
        '
        Me.xrTitulo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.xrTitulo.LocationFloat = New DevExpress.Utils.PointFloat(145.875!, 23.00002!)
        Me.xrTitulo.Name = "xrTitulo"
        Me.xrTitulo.SizeF = New System.Drawing.SizeF(494.1249!, 36.70832!)
        Me.xrTitulo.StylePriority.UseFont = False
        Me.xrTitulo.StylePriority.UseTextAlignment = False
        Me.xrTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblFUENTE_FINANCIAMIENTO, Me.XrLabel17, Me.XrLabel16, Me.XrLabel15, Me.XrLabel13, Me.XrLabel12, Me.XrLabel11, Me.XrLabel9, Me.XrLabel7, Me.XrLabel6, Me.XrLabel5, Me.XrLabel3, Me.XrLabel2, Me.xrLabel1, Me.XrTable1, Me.xrLabel4, Me.xrPictureBox1, Me.XrLabel8, Me.xrTitulo})
        Me.PageHeader.HeightF = 241.875!
        Me.PageHeader.Name = "PageHeader"
        '
        'lblFUENTE_FINANCIAMIENTO
        '
        Me.lblFUENTE_FINANCIAMIENTO.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.lblFUENTE_FINANCIAMIENTO.LocationFloat = New DevExpress.Utils.PointFloat(178.2502!, 105.9167!)
        Me.lblFUENTE_FINANCIAMIENTO.Name = "lblFUENTE_FINANCIAMIENTO"
        Me.lblFUENTE_FINANCIAMIENTO.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblFUENTE_FINANCIAMIENTO.SizeF = New System.Drawing.SizeF(471.7497!, 17.24997!)
        Me.lblFUENTE_FINANCIAMIENTO.StylePriority.UseFont = False
        Me.lblFUENTE_FINANCIAMIENTO.Text = "lblFUENTE_FINANCIAMIENTO"
        '
        'XrLabel17
        '
        Me.XrLabel17.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 105.9167!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(178.2502!, 17.24999!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.Text = "FUENTE DE FINANCIAMIENTO:"
        '
        'XrLabel16
        '
        Me.XrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeFinal1a.CODIGO_GRUPO")})
        Me.XrLabel16.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(129.1666!, 143.9167!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(214.5417!, 19.00002!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.Text = "XrLabel16"
        '
        'XrLabel15
        '
        Me.XrLabel15.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 143.9167!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(114.625!, 17.24997!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.Text = "CÓDIGO:"
        '
        'XrLabel13
        '
        Me.XrLabel13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeFinal1a.FECHA_FIN_REAL", "{0:dd/MM/yyyy}")})
        Me.XrLabel13.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(528.5417!, 164.9167!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(121.4582!, 17.24992!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.Text = "XrLabel13"
        '
        'XrLabel12
        '
        Me.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeFinal1a.FECHA_INICIO_REAL", "{0:dd/MM/yyyy}")})
        Me.XrLabel12.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(131.2083!, 164.9167!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(212.5!, 17.99994!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.Text = "XrLabel12"
        '
        'XrLabel11
        '
        Me.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeFinal1a.NOMBRE_PROVEEDOR")})
        Me.XrLabel11.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(164.365!, 88.66665!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(485.635!, 17.25!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.Text = "XrLabel11"
        '
        'XrLabel9
        '
        Me.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeFinal1a.NOMBRE_ACCION_FORMATIVA")})
        Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(129.1667!, 124.9167!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(520.8332!, 17.25001!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.Text = "XrLabel9"
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeFinal1a.DURACION_HORAS")})
        Me.XrLabel7.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(131.2083!, 184.1667!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(212.5!, 17.24995!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.Text = "XrLabel7"
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 183.4167!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(129.1666!, 17.24994!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.Text = "HORAS REPORTADAS:"
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(378.4888!, 164.9167!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(139.7085!, 17.24997!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "FECHA FINALIZACIÓN:"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 164.1667!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(114.625!, 17.24997!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.Text = "FECHA INICIO:"
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 124.9167!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(100.1252!, 17.24998!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.Text = "CURSO:"
        '
        'xrLabel1
        '
        Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 88.66666!)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(161.5835!, 17.24999!)
        Me.xrLabel1.StylePriority.UseFont = False
        Me.xrLabel1.Text = "PROVEEDOR/CAPACITADOR:"
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 216.875!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(649.9999!, 25.0!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Text = "FECHA"
        Me.XrTableCell1.Weight = 0.59615377031133R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Text = "HORARIO"
        Me.XrTableCell2.Weight = 1.8432698586369176R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Text = "CANTIDAD DE HORAS"
        Me.XrTableCell3.Weight = 0.5605763710517524R
        '
        'xrLabel4
        '
        Me.xrLabel4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 59.70834!)
        Me.xrLabel4.Name = "xrLabel4"
        Me.xrLabel4.SizeF = New System.Drawing.SizeF(649.9999!, 19.20834!)
        Me.xrLabel4.StylePriority.UseFont = False
        Me.xrLabel4.StylePriority.UseTextAlignment = False
        Me.xrLabel4.Text = "DETALLE DE PROGRAMACIÓN DE ACCION FORMATIVA DEL PROVEEDOR/CAPACITADOR"
        Me.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'DS_DL1
        '
        Me.DS_DL1.DataSetName = "DS_DL"
        Me.DS_DL1.EnforceConstraints = False
        Me.DS_DL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InformeFinal1aTableAdapter1
        '
        Me.InformeFinal1aTableAdapter1.ClearBeforeFill = True
        '
        'AsistenciA_AF_HORARIOTableAdapter1
        '
        Me.AsistenciA_AF_HORARIOTableAdapter1.ClearBeforeFill = True
        '
        'GroupHeader1
        '
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("ID_ACCION_FORMATIVA", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 0.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3})
        Me.GroupFooter1.HeightF = 26.0!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrTable3
        '
        Me.XrTable3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(649.9999!, 25.0!)
        Me.XrTable3.StylePriority.UseBorders = False
        Me.XrTable3.StylePriority.UseFont = False
        Me.XrTable3.StylePriority.UseTextAlignment = False
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell8, Me.xrTotalHoras})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1.0R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseTextAlignment = False
        Me.XrTableCell8.Text = "TOTAL HORAS "
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell8.Weight = 2.4394236289482478R
        '
        'xrTotalHoras
        '
        Me.xrTotalHoras.Name = "xrTotalHoras"
        Me.xrTotalHoras.Text = "xrTotalHoras"
        Me.xrTotalHoras.Weight = 0.5605763710517524R
        '
        'FormattingRule1
        '
        Me.FormattingRule1.Name = "FormattingRule1"
        '
        'xrInformeFinalAnexo1A
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportFooter, Me.PageHeader, Me.GroupHeader1, Me.GroupFooter1})
        Me.DataAdapter = Me.InformeFinal1aTableAdapter1
        Me.DataMember = "InformeFinal1a"
        Me.DataSource = Me.DS_DL1
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.FormattingRule1})
        Me.Margins = New System.Drawing.Printing.Margins(100, 100, 59, 42)
        Me.Version = "11.1"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Private WithEvents xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrTitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Private WithEvents xrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
#End Region


    Public Sub CargarDatosPorInformeEjecucion(ByVal ID_INFORME_AF As Decimal)
        Dim lInforme As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(ID_INFORME_AF)
        Dim lAccionFormativa As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(lInforme.ID_ACCION_FORMATIVA)
        Dim lAccionDetalle As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(lInforme.ID_ACCION_FORMATIVA)
        Dim lListaGrupoAccionBolsa As listaGRUPO_ACCION_CONTRATADA = (New cGRUPO_ACCION_CONTRATADA).ObtenerListaPorACCION_FORMATIVA(lInforme.ID_ACCION_FORMATIVA)
        Dim esCursoBOLSA As Boolean = (lListaGrupoAccionBolsa IsNot Nothing AndAlso lListaGrupoAccionBolsa.Count > 0)

        Me.DS_DL1.Clear()
        Me.InformeFinal1aTableAdapter1.Fill(DS_DL1.InformeFinal1a, ID_INFORME_AF)
        Me.AsistenciA_AF_HORARIOTableAdapter1.FillPorInforme(DS_DL1.ASISTENCIA_AF_HORARIO, ID_INFORME_AF)
        TotalizarHoras()

        Select Case True
            Case lAccionDetalle.ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE AndAlso Not esCursoBOLSA
                xrTitulo.Text = "PROGRAMA HABIL TECNICO PERMANENTE " + lAccionFormativa.ID_EJERCICIO
                XrLabel17.Visible = False
                lblFUENTE_FINANCIAMIENTO.Visible = False

            Case Utilerias.EsProgramaPATI(lAccionDetalle.ID_PROGRAMA_FORMACION)
                Dim lFuenteFinanciamiento As FUENTE_FINANCIAMIENTO
                lFuenteFinanciamiento = (New cFUENTE_FINANCIAMIENTO).ObtenerFUENTE_FINANCIAMIENTO(lAccionDetalle.ID_FUENTE)

                xrTitulo.Text = "PROGRAMA DE APOYO TEMPORAL AL INGRESO - PATI " + lAccionFormativa.ID_EJERCICIO
                Me.lblFUENTE_FINANCIAMIENTO.Text = lFuenteFinanciamiento.NOMBRE_FUENTE

            Case (lAccionDetalle.ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE AndAlso esCursoBOLSA)
                xrTitulo.Text = "PROGRAMA HABIL TECNICO PERMANENTE"
                XrLabel17.Visible = False
                lblFUENTE_FINANCIAMIENTO.Visible = False

            Case lAccionDetalle.ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.PROYECTO_ESPECIAL
                Dim listaTerminosRef As listaTERMINO_REFERENCIA_AF = (New cTERMINO_REFERENCIA_AF).ObtenerListaPorACCION_FORMATIVA(lInforme.ID_ACCION_FORMATIVA)
                If listaTerminosRef IsNot Nothing AndAlso listaTerminosRef.Count > 0 Then
                    Dim lSolicitud As SOLICITUD_CAPACITACION = (New cSOLICITUD_CAPACITACION).ObtenerSOLICITUD_CAPACITACION(listaTerminosRef(0).ID_SOLICITUD)
                    If lSolicitud IsNot Nothing Then
                        Dim lEntidadProyecto As PROYECTO_FORMACION = (New cPROYECTO_FORMACION).ObtenerPROYECTO_FORMACION(lSolicitud.ID_PROYECTO_FORMACION)
                        xrTitulo.Text = lEntidadProyecto.NOMBRE_PROYECTO_FORMACION
                    End If
                End If
                XrLabel17.Visible = False
                lblFUENTE_FINANCIAMIENTO.Visible = False
        End Select
    End Sub

    Private Sub TotalizarHoras()
        Dim Resultado As Object

        Resultado = DS_DL1.ASISTENCIA_AF_HORARIO.Compute("SUM(CANTIDAD_MINUTOS)", "ID_ASISTENCIA_AF<>-1")
        If Resultado IsNot Nothing AndAlso Not IsDBNull(Resultado) Then
            Dim valorEnMinutos As Decimal = CDec(Resultado)
            Dim hrs As Integer

            hrs = Fix(valorEnMinutos / 60)
            Me.xrTotalHoras.Text = hrs.ToString("00") + ":" + (valorEnMinutos - (hrs * 60)).ToString("00")
        Else
            Me.xrTotalHoras.Text = "00:00"
        End If
    End Sub

    Private Sub XrTableCell6_EvaluateBinding(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.BindingEventArgs) Handles XrTableCell6.EvaluateBinding
        Dim valorEnMinutos As Decimal = e.Value
        Dim hrs As Integer

        hrs = Fix(valorEnMinutos / 60)
        e.Value = hrs.ToString("00") + ":" + (valorEnMinutos - (hrs * 60)).ToString("00")
    End Sub

    Private Sub XrTableCell5_EvaluateBinding(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.BindingEventArgs) Handles XrTableCell5.EvaluateBinding
        e.Value = ExpresionHorarioPorDia(e.Value)
    End Sub

    Private Function ExpresionHorarioPorDia(ByVal ID_ASISTENCIA_AF As Decimal) As String
        Dim drResult() As DataRow
        Dim sHorario As New StringBuilder
        Dim Conta As Integer = 0

        drResult = DS_DL1.ASISTENCIA_AF_HORARIO.Select("ID_ASISTENCIA_AF = " + ID_ASISTENCIA_AF.ToString, "HORA_INICIO ASC")
        For Each dr As DataRow In drResult
            If Conta > 0 Then
                sHorario.Append(" Y ")
            End If
            sHorario.Append("DE ")
            sHorario.Append(Date.Parse(dr("HORA_INICIO")).ToString("h:mmtt").ToUpper)
            sHorario.Append(" A ")
            sHorario.Append(Date.Parse(dr("HORA_FIN")).ToString("h:mmtt").ToUpper)
            Conta += 1
        Next

        Return sHorario.ToString
    End Function

    Private Sub XrTableCell9_SummaryGetResult(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.SummaryGetResultEventArgs) Handles xrTotalHoras.SummaryGetResult
        Dim valorEnMinutos As Decimal = e.Result
        Dim hrs As Integer

        hrs = Fix(valorEnMinutos / 60)
        e.Result = hrs.ToString("00") + ":" + (valorEnMinutos - (hrs * 60)).ToString("00")
    End Sub
End Class