Public Class xrResumenEjecucion
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Código generado "
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
    Private WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Private WithEvents xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Private WithEvents xrlblTitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Private WithEvents xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    Private WithEvents XrResumenEjecucion_SubReporteMontosPorProveedor1 As SGAFP.RL.xrResumenEjecucion_SubReporteMontosPorProveedor

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xrResumenEjecucion))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.xrlblTitulo = New DevExpress.XtraReports.UI.XRLabel
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport
        Me.XrResumenEjecucion_SubReporteMontosPorProveedor1 = New SGAFP.RL.xrResumenEjecucion_SubReporteMontosPorProveedor
        CType(Me.XrResumenEjecucion_SubReporteMontosPorProveedor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 31.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 26.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 12.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrlblTitulo, Me.XrPictureBox2, Me.xrPictureBox1})
        Me.PageHeader.HeightF = 108.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'xrlblTitulo
        '
        Me.xrlblTitulo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.xrlblTitulo.LocationFloat = New DevExpress.Utils.PointFloat(214.5001!, 47.00001!)
        Me.xrlblTitulo.Name = "xrlblTitulo"
        Me.xrlblTitulo.SizeF = New System.Drawing.SizeF(628.8323!, 19.20834!)
        Me.xrlblTitulo.StylePriority.UseFont = False
        Me.xrlblTitulo.StylePriority.UseTextAlignment = False
        Me.xrlblTitulo.Text = "PROGRAMA HABIL TECNICO PERMANENTE"
        Me.xrlblTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.Image = CType(resources.GetObject("XrPictureBox2.Image"), System.Drawing.Image)
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(925.0!, 0.0!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(80.0!, 70.0!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'xrPictureBox1
        '
        Me.xrPictureBox1.Image = Global.SGAFP.RL.My.Resources.Resources.logoInsaforp
        Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.xrPictureBox1.Name = "xrPictureBox1"
        Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(145.875!, 45.99999!)
        Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo2, Me.xrPageInfo1})
        Me.PageFooter.HeightF = 40.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'xrPageInfo2
        '
        Me.xrPageInfo2.Format = "Pagina {0} de {1}"
        Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(697.5!, 7.000007!)
        Me.xrPageInfo2.Name = "xrPageInfo2"
        Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(306.9999!, 23.00002!)
        Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrPageInfo1
        '
        Me.xrPageInfo1.Format = "{0:dddd, dd' de 'MMMM' de 'yyyy'  Hora: 'hh:mm tt}"
        Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 7.000007!)
        Me.xrPageInfo1.Name = "xrPageInfo1"
        Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrSubreport1})
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrSubreport1
        '
        Me.XrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(14.5001!, 10.00001!)
        Me.XrSubreport1.Name = "XrSubreport1"
        Me.XrSubreport1.ReportSource = Me.XrResumenEjecucion_SubReporteMontosPorProveedor1
        Me.XrSubreport1.SizeF = New System.Drawing.SizeF(998.4999!, 79.99998!)
        '
        'xrResumenEjecucion
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.PageFooter, Me.GroupHeader1})
        Me.DefaultPrinterSettingsUsing.UseLandscape = True
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(38, 39, 26, 12)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.Version = "10.1"
        CType(Me.XrResumenEjecucion_SubReporteMontosPorProveedor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
#End Region

    Private mID_EJERCICIO As String

    Public Sub CargarDatosPorEjercicio(ByVal ID_EJERCICIO As String)
        mID_EJERCICIO = ID_EJERCICIO
        xrlblTitulo.Text += " " + ID_EJERCICIO
    End Sub

    Private Sub XrSubreport1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport1.BeforePrint
        Dim detail As xrResumenEjecucion_SubReporteMontosPorProveedor = TryCast(Me.XrSubreport1.ReportSource, xrResumenEjecucion_SubReporteMontosPorProveedor)
        If detail IsNot Nothing Then
            If Not GetCurrentColumnValue("EJERCICIO") Is DBNull.Value Then
                detail.CargarDatosPorEjercicio(mID_EJERCICIO)
                detail.FillDataSource()
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub
End Class