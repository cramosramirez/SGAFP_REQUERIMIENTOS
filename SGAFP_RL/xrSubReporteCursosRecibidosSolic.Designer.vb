<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class xrSubReporteCursosRecibidosSolic
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrPanel21 = New DevExpress.XtraReports.UI.XRPanel
        Me.XrLabel204 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel205 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel226 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel227 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel228 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel229 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrPanel20 = New DevExpress.XtraReports.UI.XRPanel
        Me.XrLabel202 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel201 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel197 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel198 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel199 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel200 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.DS_DL1 = New SGAFP.DL.DS_DL
        Me.CursosRecibidosTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.CursosRecibidosTableAdapter
        Me._APOYO_INSAFORP_SI = New DevExpress.XtraReports.UI.CalculatedField
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand
        Me._APOYO_INSAFORP_NO = New DevExpress.XtraReports.UI.CalculatedField
        Me._APOYO_INSAFORP_NS = New DevExpress.XtraReports.UI.CalculatedField
        Me._CURSO_BENEF_SI = New DevExpress.XtraReports.UI.CalculatedField
        Me._CURSO_BENEF_NO = New DevExpress.XtraReports.UI.CalculatedField
        Me._CURSO_BENEF_NR = New DevExpress.XtraReports.UI.CalculatedField
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanel21, Me.XrPanel20, Me.XrLabel2, Me.XrLabel1})
        Me.Detail.HeightF = 15.74804!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("ANIO", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("NOMBRE_CURSO", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPanel21
        '
        Me.XrPanel21.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPanel21.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel204, Me.XrLabel205, Me.XrLabel226, Me.XrLabel227, Me.XrLabel228, Me.XrLabel229})
        Me.XrPanel21.LocationFloat = New DevExpress.Utils.PointFloat(483.4138!, 0.00006357829!)
        Me.XrPanel21.Name = "XrPanel21"
        Me.XrPanel21.SizeF = New System.Drawing.SizeF(156.4454!, 15.74798!)
        Me.XrPanel21.StylePriority.UseBorders = False
        '
        'XrLabel204
        '
        Me.XrLabel204.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel204.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrLabel204.LocationFloat = New DevExpress.Utils.PointFloat(111.624!, 1.181115!)
        Me.XrLabel204.Multiline = True
        Me.XrLabel204.Name = "XrLabel204"
        Me.XrLabel204.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel204.SizeF = New System.Drawing.SizeF(26.20436!, 12.38004!)
        Me.XrLabel204.StylePriority.UseBorders = False
        Me.XrLabel204.StylePriority.UseFont = False
        Me.XrLabel204.Text = "NR"
        '
        'XrLabel205
        '
        Me.XrLabel205.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel205.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CursosRecibidos._CURSO_BENEF_NR")})
        Me.XrLabel205.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel205.LocationFloat = New DevExpress.Utils.PointFloat(98.33666!, 1.181115!)
        Me.XrLabel205.Name = "XrLabel205"
        Me.XrLabel205.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel205.SizeF = New System.Drawing.SizeF(12.38!, 12.38002!)
        Me.XrLabel205.StylePriority.UseBorders = False
        Me.XrLabel205.StylePriority.UseFont = False
        Me.XrLabel205.StylePriority.UsePadding = False
        Me.XrLabel205.StylePriority.UseTextAlignment = False
        Me.XrLabel205.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel226
        '
        Me.XrLabel226.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel226.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrLabel226.LocationFloat = New DevExpress.Utils.PointFloat(33.08063!, 1.18103!)
        Me.XrLabel226.Multiline = True
        Me.XrLabel226.Name = "XrLabel226"
        Me.XrLabel226.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel226.SizeF = New System.Drawing.SizeF(15.72776!, 12.38004!)
        Me.XrLabel226.StylePriority.UseBorders = False
        Me.XrLabel226.StylePriority.UseFont = False
        Me.XrLabel226.Text = "Si"
        '
        'XrLabel227
        '
        Me.XrLabel227.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel227.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrLabel227.LocationFloat = New DevExpress.Utils.PointFloat(72.01644!, 0.787523!)
        Me.XrLabel227.Multiline = True
        Me.XrLabel227.Name = "XrLabel227"
        Me.XrLabel227.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel227.SizeF = New System.Drawing.SizeF(19.47787!, 12.38002!)
        Me.XrLabel227.StylePriority.UseBorders = False
        Me.XrLabel227.StylePriority.UseFont = False
        Me.XrLabel227.Text = "No"
        '
        'XrLabel228
        '
        Me.XrLabel228.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel228.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CursosRecibidos._CURSO_BENEF_NO")})
        Me.XrLabel228.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel228.LocationFloat = New DevExpress.Utils.PointFloat(57.98051!, 0.787523!)
        Me.XrLabel228.Name = "XrLabel228"
        Me.XrLabel228.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel228.SizeF = New System.Drawing.SizeF(12.38!, 12.38002!)
        Me.XrLabel228.StylePriority.UseBorders = False
        Me.XrLabel228.StylePriority.UseFont = False
        Me.XrLabel228.StylePriority.UsePadding = False
        Me.XrLabel228.StylePriority.UseTextAlignment = False
        Me.XrLabel228.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel229
        '
        Me.XrLabel229.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel229.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CursosRecibidos._CURSO_BENEF_SI")})
        Me.XrLabel229.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel229.LocationFloat = New DevExpress.Utils.PointFloat(18.74697!, 0.787523!)
        Me.XrLabel229.Name = "XrLabel229"
        Me.XrLabel229.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel229.SizeF = New System.Drawing.SizeF(12.38!, 12.38002!)
        Me.XrLabel229.StylePriority.UseBorders = False
        Me.XrLabel229.StylePriority.UseFont = False
        Me.XrLabel229.StylePriority.UsePadding = False
        Me.XrLabel229.StylePriority.UseTextAlignment = False
        Me.XrLabel229.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrPanel20
        '
        Me.XrPanel20.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPanel20.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel202, Me.XrLabel201, Me.XrLabel197, Me.XrLabel198, Me.XrLabel199, Me.XrLabel200})
        Me.XrPanel20.LocationFloat = New DevExpress.Utils.PointFloat(277.4513!, 0.0!)
        Me.XrPanel20.Name = "XrPanel20"
        Me.XrPanel20.SizeF = New System.Drawing.SizeF(149.4454!, 15.74803!)
        Me.XrPanel20.StylePriority.UseBorders = False
        '
        'XrLabel202
        '
        Me.XrLabel202.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel202.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrLabel202.LocationFloat = New DevExpress.Utils.PointFloat(98.67813!, 1.51!)
        Me.XrLabel202.Multiline = True
        Me.XrLabel202.Name = "XrLabel202"
        Me.XrLabel202.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel202.SizeF = New System.Drawing.SizeF(43.08899!, 12.38!)
        Me.XrLabel202.StylePriority.UseBorders = False
        Me.XrLabel202.StylePriority.UseFont = False
        Me.XrLabel202.Text = "No sabe"
        '
        'XrLabel201
        '
        Me.XrLabel201.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel201.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CursosRecibidos._APOYO_INSAFORP_NS")})
        Me.XrLabel201.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel201.LocationFloat = New DevExpress.Utils.PointFloat(85.39076!, 1.51!)
        Me.XrLabel201.Name = "XrLabel201"
        Me.XrLabel201.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel201.SizeF = New System.Drawing.SizeF(12.38!, 12.38002!)
        Me.XrLabel201.StylePriority.UseBorders = False
        Me.XrLabel201.StylePriority.UseFont = False
        Me.XrLabel201.StylePriority.UsePadding = False
        Me.XrLabel201.StylePriority.UseTextAlignment = False
        Me.XrLabel201.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel197
        '
        Me.XrLabel197.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel197.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrLabel197.LocationFloat = New DevExpress.Utils.PointFloat(20.92214!, 1.901701!)
        Me.XrLabel197.Multiline = True
        Me.XrLabel197.Name = "XrLabel197"
        Me.XrLabel197.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel197.SizeF = New System.Drawing.SizeF(15.72776!, 12.38004!)
        Me.XrLabel197.StylePriority.UseBorders = False
        Me.XrLabel197.StylePriority.UseFont = False
        Me.XrLabel197.Text = "Si"
        '
        'XrLabel198
        '
        Me.XrLabel198.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel198.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrLabel198.LocationFloat = New DevExpress.Utils.PointFloat(59.85792!, 1.508119!)
        Me.XrLabel198.Multiline = True
        Me.XrLabel198.Name = "XrLabel198"
        Me.XrLabel198.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel198.SizeF = New System.Drawing.SizeF(19.47787!, 12.38002!)
        Me.XrLabel198.StylePriority.UseBorders = False
        Me.XrLabel198.StylePriority.UseFont = False
        Me.XrLabel198.Text = "No"
        '
        'XrLabel199
        '
        Me.XrLabel199.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel199.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CursosRecibidos._APOYO_INSAFORP_NO")})
        Me.XrLabel199.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel199.LocationFloat = New DevExpress.Utils.PointFloat(45.82199!, 1.508119!)
        Me.XrLabel199.Name = "XrLabel199"
        Me.XrLabel199.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel199.SizeF = New System.Drawing.SizeF(12.38!, 12.38002!)
        Me.XrLabel199.StylePriority.UseBorders = False
        Me.XrLabel199.StylePriority.UseFont = False
        Me.XrLabel199.StylePriority.UsePadding = False
        Me.XrLabel199.StylePriority.UseTextAlignment = False
        Me.XrLabel199.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel200
        '
        Me.XrLabel200.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel200.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CursosRecibidos._APOYO_INSAFORP_SI")})
        Me.XrLabel200.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel200.LocationFloat = New DevExpress.Utils.PointFloat(6.194788!, 1.508079!)
        Me.XrLabel200.Name = "XrLabel200"
        Me.XrLabel200.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel200.SizeF = New System.Drawing.SizeF(12.38!, 12.38002!)
        Me.XrLabel200.StylePriority.UseBorders = False
        Me.XrLabel200.StylePriority.UseFont = False
        Me.XrLabel200.StylePriority.UsePadding = False
        Me.XrLabel200.StylePriority.UseTextAlignment = False
        Me.XrLabel200.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CursosRecibidos.ANIO")})
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(433.8967!, 0.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(41.1004!, 15.74803!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UsePadding = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "XrLabel2"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CursosRecibidos.NOMBRE_CURSO")})
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(269.618!, 15.74803!)
        Me.XrLabel1.StylePriority.UseFont = False
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
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel6, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3})
        Me.ReportHeader.HeightF = 15.0!
        Me.ReportHeader.KeepTogether = True
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(478.4138!, 0.0!)
        Me.XrLabel6.Multiline = True
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(161.4454!, 14.99999!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UsePadding = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "¿El curso le dió beneficios ?"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(433.8967!, 0.0!)
        Me.XrLabel5.Multiline = True
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(41.10043!, 14.99999!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UsePadding = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Año"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(270.4513!, 0.0!)
        Me.XrLabel4.Multiline = True
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(156.4454!, 14.99999!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UsePadding = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "¿Lo impartió INSAFORP?"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLabel3.Multiline = True
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(269.618!, 14.99999!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UsePadding = False
        Me.XrLabel3.Text = "5. Cursos recibidos en los últimos 3 años"
        '
        'DS_DL1
        '
        Me.DS_DL1.DataSetName = "DS_DL"
        Me.DS_DL1.EnforceConstraints = False
        Me.DS_DL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CursosRecibidosTableAdapter1
        '
        Me.CursosRecibidosTableAdapter1.ClearBeforeFill = True
        '
        '_APOYO_INSAFORP_SI
        '
        Me._APOYO_INSAFORP_SI.DataMember = "CursosRecibidos"
        Me._APOYO_INSAFORP_SI.DataSource = Me.DS_DL1
        Me._APOYO_INSAFORP_SI.Expression = "Iif([APOYO_INSAFORP]=1,'X','')"
        Me._APOYO_INSAFORP_SI.Name = "_APOYO_INSAFORP_SI"
        '
        'ReportFooter
        '
        Me.ReportFooter.HeightF = 0.0!
        Me.ReportFooter.Name = "ReportFooter"
        '
        '_APOYO_INSAFORP_NO
        '
        Me._APOYO_INSAFORP_NO.DataMember = "CursosRecibidos"
        Me._APOYO_INSAFORP_NO.Expression = "Iif([APOYO_INSAFORP]=2,'X','')"
        Me._APOYO_INSAFORP_NO.Name = "_APOYO_INSAFORP_NO"
        '
        '_APOYO_INSAFORP_NS
        '
        Me._APOYO_INSAFORP_NS.DataMember = "CursosRecibidos"
        Me._APOYO_INSAFORP_NS.Expression = "Iif([APOYO_INSAFORP]=3,'X','')"
        Me._APOYO_INSAFORP_NS.Name = "_APOYO_INSAFORP_NS"
        '
        '_CURSO_BENEF_SI
        '
        Me._CURSO_BENEF_SI.DataMember = "CursosRecibidos"
        Me._CURSO_BENEF_SI.Expression = "Iif([BENEFICIO_CURSO]=1,'X','')"
        Me._CURSO_BENEF_SI.Name = "_CURSO_BENEF_SI"
        '
        '_CURSO_BENEF_NO
        '
        Me._CURSO_BENEF_NO.DataMember = "CursosRecibidos"
        Me._CURSO_BENEF_NO.Expression = "Iif([BENEFICIO_CURSO]=2,'X','')"
        Me._CURSO_BENEF_NO.Name = "_CURSO_BENEF_NO"
        '
        '_CURSO_BENEF_NR
        '
        Me._CURSO_BENEF_NR.DataMember = "CursosRecibidos"
        Me._CURSO_BENEF_NR.Expression = "Iif([BENEFICIO_CURSO]=3,'X','')"
        Me._CURSO_BENEF_NR.Name = "_CURSO_BENEF_NR"
        '
        'xrSubReporteCursosRecibidosSolic
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.ReportFooter})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me._APOYO_INSAFORP_SI, Me._APOYO_INSAFORP_NO, Me._APOYO_INSAFORP_NS, Me._CURSO_BENEF_SI, Me._CURSO_BENEF_NO, Me._CURSO_BENEF_NR})
        Me.DataAdapter = Me.CursosRecibidosTableAdapter1
        Me.DataMember = "CursosRecibidos"
        Me.DataSource = Me.DS_DL1
        Me.Margins = New System.Drawing.Printing.Margins(16, 169, 0, 0)
        Me.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        Me.Version = "10.1"
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents DS_DL1 As SGAFP.DL.DS_DL
    Friend WithEvents CursosRecibidosTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.CursosRecibidosTableAdapter
    Friend WithEvents _APOYO_INSAFORP_SI As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrPanel20 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel202 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel201 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel197 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel198 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel199 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel200 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPanel21 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel204 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel205 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel226 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel227 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel228 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel229 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents _APOYO_INSAFORP_NO As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents _APOYO_INSAFORP_NS As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents _CURSO_BENEF_SI As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents _CURSO_BENEF_NO As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents _CURSO_BENEF_NR As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
End Class
