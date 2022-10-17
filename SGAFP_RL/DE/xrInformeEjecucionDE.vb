Public Class xrInformeEjecucionDE
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region "Codigo Generado"

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
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Private WithEvents xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents xrlblTitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrSubReporteGenero As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents DS_DL1 As SGAFP.DL.DS_DL
    Private WithEvents XrInformeEjecucionDE_SubReporteGenero1 As SGAFP.RL.xrInformeEjecucionDE_SubReporteGenero
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrSubReporteDomicilio As DevExpress.XtraReports.UI.XRSubreport
    Private WithEvents XrInformeEjecucionDE_SubReporteDomicilio1 As SGAFP.RL.xrInformeEjecucionDE_SubReporteDomicilio

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
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.xrlblTitulo = New DevExpress.XtraReports.UI.XRLabel
        Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.xrSubReporteGenero = New DevExpress.XtraReports.UI.XRSubreport
        Me.XrInformeEjecucionDE_SubReporteGenero1 = New SGAFP.RL.xrInformeEjecucionDE_SubReporteGenero
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.DS_DL1 = New SGAFP.DL.DS_DL
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.xrSubReporteDomicilio = New DevExpress.XtraReports.UI.XRSubreport
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrInformeEjecucionDE_SubReporteDomicilio1 = New SGAFP.RL.xrInformeEjecucionDE_SubReporteDomicilio
        CType(Me.XrInformeEjecucionDE_SubReporteGenero1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrInformeEjecucionDE_SubReporteDomicilio1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TopMargin.HeightF = 28.0!
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
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrlblTitulo, Me.xrPictureBox1})
        Me.PageHeader.HeightF = 93.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'xrlblTitulo
        '
        Me.xrlblTitulo.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.xrlblTitulo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.xrlblTitulo.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 54.0!)
        Me.xrlblTitulo.Name = "xrlblTitulo"
        Me.xrlblTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlblTitulo.SizeF = New System.Drawing.SizeF(773.0!, 23.0!)
        Me.xrlblTitulo.StylePriority.UseBorders = False
        Me.xrlblTitulo.StylePriority.UseFont = False
        Me.xrlblTitulo.StylePriority.UseTextAlignment = False
        Me.xrlblTitulo.Text = "INFORME DE EJECUCIÓN"
        Me.xrlblTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
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
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrSubReporteGenero, Me.XrLabel2})
        Me.GroupHeader1.HeightF = 126.0!
        Me.GroupHeader1.Level = 1
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'xrSubReporteGenero
        '
        Me.xrSubReporteGenero.LocationFloat = New DevExpress.Utils.PointFloat(0.00001589457!, 49.66666!)
        Me.xrSubReporteGenero.Name = "xrSubReporteGenero"
        Me.xrSubReporteGenero.ReportSource = Me.XrInformeEjecucionDE_SubReporteGenero1
        Me.xrSubReporteGenero.SizeF = New System.Drawing.SizeF(773.0!, 47.24998!)
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(773.0!, 49.66668!)
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Participantes por Género" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Año - 2011"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'DS_DL1
        '
        Me.DS_DL1.DataSetName = "DS_DL"
        Me.DS_DL1.EnforceConstraints = False
        Me.DS_DL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrSubReporteDomicilio, Me.XrLabel3})
        Me.GroupHeader2.HeightF = 126.0!
        Me.GroupHeader2.Name = "GroupHeader2"
        Me.GroupHeader2.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand
        '
        'xrSubReporteDomicilio
        '
        Me.xrSubReporteDomicilio.LocationFloat = New DevExpress.Utils.PointFloat(0.00003178914!, 49.66666!)
        Me.xrSubReporteDomicilio.Name = "xrSubReporteDomicilio"
        Me.xrSubReporteDomicilio.ReportSource = Me.XrInformeEjecucionDE_SubReporteDomicilio1
        Me.xrSubReporteDomicilio.SizeF = New System.Drawing.SizeF(772.9999!, 51.12499!)
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLabel3.Multiline = True
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(773.0!, 49.66668!)
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Participantes por Domicilio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Año - 2011"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrInformeEjecucionDE
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.GroupHeader1, Me.GroupHeader2})
        Me.DataMember = "ParticipantesInscritos"
        Me.DataSource = Me.DS_DL1
        Me.Margins = New System.Drawing.Printing.Margins(39, 38, 28, 0)
        Me.Version = "10.1"
        CType(Me.XrInformeEjecucionDE_SubReporteGenero1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrInformeEjecucionDE_SubReporteDomicilio1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
#End Region

    Private mID_EJERCICIO As String
    Private mID_PROGRAMA_FORMACION As Decimal
    Private TotalParticipantes As Integer

    Public Sub CargarDatos(ByVal ID_EJERCICIO As String, ByVal ID_PROGRAMA_FORMACION As Decimal)
        If ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE Then
            xrlblTitulo.Text += " - PROGRAMA HABIL TECNICO PERMANENTE " + ID_EJERCICIO
        ElseIf ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.PATI_BM OrElse ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.PATI_USAID Then
            xrlblTitulo.Text += " - PROGRAMA DE APOYO TEMPORAL AL INGRESO " + ID_EJERCICIO
        End If
        Me.DS_DL1.Clear()
        mID_EJERCICIO = ID_EJERCICIO
        mID_PROGRAMA_FORMACION = CDec(ID_PROGRAMA_FORMACION)
        SetearTotalParticipantes()
    End Sub

    Private Sub xrSubReporteGenero_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrSubReporteGenero.BeforePrint
        Dim detail As xrInformeEjecucionDE_SubReporteGenero = TryCast(Me.xrSubReporteGenero.ReportSource, xrInformeEjecucionDE_SubReporteGenero)
        If detail IsNot Nothing Then
            If Not GetCurrentColumnValue("EJERCICIO") Is DBNull.Value Then
                detail.Parameters("pCantidadParticipantes").Value = TotalParticipantes
                detail.CargarGeneroPorEjercicioTipoSolic(mID_EJERCICIO, mID_PROGRAMA_FORMACION)
                detail.FillDataSource()
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub xrSubReporteDomicilio_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrSubReporteDomicilio.BeforePrint
        Dim detail As xrInformeEjecucionDE_SubReporteDomicilio = TryCast(Me.xrSubReporteDomicilio.ReportSource, xrInformeEjecucionDE_SubReporteDomicilio)
        If detail IsNot Nothing Then
            If Not GetCurrentColumnValue("EJERCICIO") Is DBNull.Value Then
                detail.CargarDomicilioPorEjercicioTipoSolic(mID_EJERCICIO, mID_PROGRAMA_FORMACION)
                detail.FillDataSource()
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub SetearTotalParticipantes()
        Dim adapter As New SGAFP.DL.DS_DLTableAdapters.InformeDEGeneroTableAdapter
        Dim Resultado As Object

        TotalParticipantes = 0
        adapter.FillByEjercicioTipoSolic(Me.DS_DL1.InformeDEGenero, mID_EJERCICIO, mID_PROGRAMA_FORMACION)
        Resultado = Me.DS_DL1.InformeDEGenero.Compute("SUM(PARTICIPANTES)", "EJERCICIO<>''")
        If Resultado IsNot Nothing AndAlso Not IsDBNull(Resultado) Then
            TotalParticipantes = CInt(Resultado)
        End If
    End Sub

 
End Class