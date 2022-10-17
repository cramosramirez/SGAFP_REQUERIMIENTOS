Public Class xrInformeUtilRecursos
    Inherits DevExpress.XtraReports.UI.XtraReport


#Region " Diseñador "

    Public Sub New()
        MyBase.New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
    End Sub

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents xrSubReporteGantt As DevExpress.XtraReports.UI.XRSubreport
    Private WithEvents XrInformeUtilRecursos_SubReporteGantt1 As SGAFP.RL.xrInformeUtilRecursos_SubReporteGantt
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents xrSubReporteAreasFormacion As DevExpress.XtraReports.UI.XRSubreport
    Private WithEvents XrInformeUtilRecursos_SubReporteAreasFormacion1 As SGAFP.RL.xrInformeUtilRecursos_SubReporteAreasFormacion
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Private WithEvents xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Private WithEvents xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents GroupHeader3 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents xrSubReporteCursos As DevExpress.XtraReports.UI.XRSubreport
    Private WithEvents XrInformeUtilRecursos_SubReporteCursos1 As SGAFP.RL.xrInformeUtilRecursos_SubReporteCursos

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xrInformeUtilRecursos))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.xrlblProveedor = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlblTitulo = New DevExpress.XtraReports.UI.XRLabel
        Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.xrSubReporteGantt = New DevExpress.XtraReports.UI.XRSubreport
        Me.XrInformeUtilRecursos_SubReporteGantt1 = New SGAFP.RL.xrInformeUtilRecursos_SubReporteGantt
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.xrSubReporteAreasFormacion = New DevExpress.XtraReports.UI.XRSubreport
        Me.XrInformeUtilRecursos_SubReporteAreasFormacion1 = New SGAFP.RL.xrInformeUtilRecursos_SubReporteAreasFormacion
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.GroupHeader3 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.xrSubReporteCursos = New DevExpress.XtraReports.UI.XRSubreport
        Me.XrInformeUtilRecursos_SubReporteCursos1 = New SGAFP.RL.xrInformeUtilRecursos_SubReporteCursos
        CType(Me.XrInformeUtilRecursos_SubReporteGantt1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrInformeUtilRecursos_SubReporteAreasFormacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrInformeUtilRecursos_SubReporteCursos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Expanded = False
        Me.Detail.HeightF = 4.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 20.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 10.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox2, Me.xrlblProveedor, Me.xrlblTitulo, Me.xrPictureBox1})
        Me.PageHeader.HeightF = 109.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.Image = CType(resources.GetObject("XrPictureBox2.Image"), System.Drawing.Image)
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(931.0!, 1.000023!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(80.0!, 70.0!)
        Me.XrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'xrlblProveedor
        '
        Me.xrlblProveedor.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.xrlblProveedor.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 75.0!)
        Me.xrlblProveedor.Name = "xrlblProveedor"
        Me.xrlblProveedor.SizeF = New System.Drawing.SizeF(998.4999!, 19.20834!)
        Me.xrlblProveedor.StylePriority.UseFont = False
        Me.xrlblProveedor.StylePriority.UseTextAlignment = False
        Me.xrlblProveedor.Text = "PROVEEDOR"
        Me.xrlblProveedor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrlblTitulo
        '
        Me.xrlblTitulo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.xrlblTitulo.LocationFloat = New DevExpress.Utils.PointFloat(210.4167!, 51.7917!)
        Me.xrlblTitulo.Name = "xrlblTitulo"
        Me.xrlblTitulo.SizeF = New System.Drawing.SizeF(628.8323!, 19.20834!)
        Me.xrlblTitulo.StylePriority.UseFont = False
        Me.xrlblTitulo.StylePriority.UseTextAlignment = False
        Me.xrlblTitulo.Text = "PROGRAMA HABIL TECNICO PERMANENTE"
        Me.xrlblTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrPictureBox1
        '
        Me.xrPictureBox1.Image = Global.SGAFP.RL.My.Resources.Resources.logoInsaforp
        Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.xrPictureBox1.Name = "xrPictureBox1"
        Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(145.875!, 45.99999!)
        Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrSubReporteGantt})
        Me.GroupHeader1.HeightF = 122.0!
        Me.GroupHeader1.Level = 2
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        '
        'xrSubReporteGantt
        '
        Me.xrSubReporteGantt.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 10.00001!)
        Me.xrSubReporteGantt.Name = "xrSubReporteGantt"
        Me.xrSubReporteGantt.ReportSource = Me.XrInformeUtilRecursos_SubReporteGantt1
        Me.xrSubReporteGantt.SizeF = New System.Drawing.SizeF(1021.0!, 102.0!)
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrSubReporteAreasFormacion})
        Me.GroupHeader2.HeightF = 124.0!
        Me.GroupHeader2.Level = 1
        Me.GroupHeader2.Name = "GroupHeader2"
        Me.GroupHeader2.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        '
        'xrSubReporteAreasFormacion
        '
        Me.xrSubReporteAreasFormacion.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 10.0!)
        Me.xrSubReporteAreasFormacion.Name = "xrSubReporteAreasFormacion"
        Me.xrSubReporteAreasFormacion.ReportSource = Me.XrInformeUtilRecursos_SubReporteAreasFormacion1
        Me.xrSubReporteAreasFormacion.SizeF = New System.Drawing.SizeF(1021.0!, 102.0!)
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo2, Me.xrPageInfo1})
        Me.PageFooter.HeightF = 36.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'xrPageInfo2
        '
        Me.xrPageInfo2.Format = "Pagina {0} de {1}"
        Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(703.9999!, 7.000033!)
        Me.xrPageInfo2.Name = "xrPageInfo2"
        Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(306.9999!, 23.00002!)
        Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrPageInfo1
        '
        Me.xrPageInfo1.Format = "{0:dddd, dd' de 'MMMM' de 'yyyy'  Hora: 'hh:mm tt}"
        Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 7.000033!)
        Me.xrPageInfo1.Name = "xrPageInfo1"
        Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
        '
        'GroupHeader3
        '
        Me.GroupHeader3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrSubReporteCursos})
        Me.GroupHeader3.HeightF = 126.0!
        Me.GroupHeader3.Name = "GroupHeader3"
        '
        'xrSubReporteCursos
        '
        Me.xrSubReporteCursos.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 11.99997!)
        Me.xrSubReporteCursos.Name = "xrSubReporteCursos"
        Me.xrSubReporteCursos.ReportSource = Me.XrInformeUtilRecursos_SubReporteCursos1
        Me.xrSubReporteCursos.SizeF = New System.Drawing.SizeF(1021.0!, 102.0!)
        '
        'xrInformeUtilRecursos
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.GroupHeader1, Me.GroupHeader2, Me.PageFooter, Me.GroupHeader3})
        Me.DefaultPrinterSettingsUsing.UseLandscape = True
        Me.DefaultPrinterSettingsUsing.UsePaperKind = True
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(40, 39, 20, 10)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.Version = "11.1"
        CType(Me.XrInformeUtilRecursos_SubReporteGantt1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrInformeUtilRecursos_SubReporteAreasFormacion1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrInformeUtilRecursos_SubReporteCursos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Private WithEvents xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Private WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Private WithEvents xrlblProveedor As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrlblTitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
#End Region

    Private mID_EJERCICIO As String
    Private mID_PROVEEDOR_AF As Decimal

    Public Sub CargarDatosPorEjercicioProveedor(ByVal ID_EJERCICIO As String, ByVal ID_PROVEEDOR_AF As Decimal)
        mID_EJERCICIO = ID_EJERCICIO
        mID_PROVEEDOR_AF = ID_PROVEEDOR_AF
        xrlblTitulo.Text += " " + ID_EJERCICIO

        Dim lEntidad As PROVEEDOR_AF
        lEntidad = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(ID_PROVEEDOR_AF)
        If lEntidad IsNot Nothing Then
            xrlblProveedor.Text = lEntidad.NOMBRE_PROVEEDOR
        End If
    End Sub

    Private Sub xrSubReporteGantt_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrSubReporteGantt.BeforePrint
        Dim detail As xrInformeUtilRecursos_SubReporteGantt = TryCast(Me.XrInformeUtilRecursos_SubReporteGantt1, xrInformeUtilRecursos_SubReporteGantt)
        If detail IsNot Nothing Then
            If mID_EJERCICIO <> "" Then
                detail.CargarDatosPorEjercicioProveedor(mID_EJERCICIO, mID_PROVEEDOR_AF)
                detail.FillDataSource()
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub xrSubReporteAreasFormacion_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrSubReporteAreasFormacion.BeforePrint
        Dim detail As xrInformeUtilRecursos_SubReporteAreasFormacion = TryCast(Me.XrInformeUtilRecursos_SubReporteAreasFormacion1, xrInformeUtilRecursos_SubReporteAreasFormacion)
        If detail IsNot Nothing Then
            If mID_EJERCICIO <> "" Then
                detail.CargarDatosPorEjercicioProveedor(mID_EJERCICIO, mID_PROVEEDOR_AF)
                detail.FillDataSource()
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub xrSubReporteCursos_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrSubReporteCursos.BeforePrint
        Dim detail As xrInformeUtilRecursos_SubReporteCursos = TryCast(Me.XrInformeUtilRecursos_SubReporteCursos1, xrInformeUtilRecursos_SubReporteCursos)
        If detail IsNot Nothing Then
            If mID_EJERCICIO <> "" Then
                detail.CargarDatosPorEjercicioProveedor(mID_EJERCICIO, mID_PROVEEDOR_AF)
                detail.FillDataSource()
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub
End Class