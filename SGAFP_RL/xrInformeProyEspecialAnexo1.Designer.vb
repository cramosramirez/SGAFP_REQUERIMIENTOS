<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class xrInformeProyEspecialAnexo1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xrInformeProyEspecialAnexo1))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.xrDeta = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrLugarEjecucionDeta = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrHorarioDeta = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrtHorasAcumuladas = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.DS_DL1 = New SGAFP.DL.DS_DL()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.xrlModalidad = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLugarEjecucionEnca = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrHorarioEnca = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrPeriodoReportado = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrlNoAnexo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrContrato = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.xrlPrograma = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLine6 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.InformeEjecucionProyEspecialTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.InformeEjecucionProyEspecialTableAdapter()
        CType(Me.xrDeta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrDeta})
        Me.Detail.HeightF = 25.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrDeta
        '
        Me.xrDeta.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrDeta.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.xrDeta.LocationFloat = New DevExpress.Utils.PointFloat(0.0001907349!, 0.0!)
        Me.xrDeta.Name = "xrDeta"
        Me.xrDeta.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.xrDeta.SizeF = New System.Drawing.SizeF(899.9998!, 25.0!)
        Me.xrDeta.StylePriority.UseBorders = False
        Me.xrDeta.StylePriority.UseFont = False
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.xrLugarEjecucionDeta, Me.xrHorarioDeta, Me.XrTableCell7, Me.XrTableCell8, Me.xrtHorasAcumuladas, Me.XrTableCell9, Me.XrTableCell11, Me.XrTableCell5, Me.XrTableCell10})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeEjecucionProyEspecial.NOMBRE_ACCION_FORMATIVA")})
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.Text = "XrTableCell1"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell1.Weight = 0.555943479363748R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeEjecucionProyEspecial.CODIGO_GRUPO")})
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        Me.XrTableCell2.Text = "XrTableCell2"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell2.Weight = 0.35971512646099763R
        '
        'xrLugarEjecucionDeta
        '
        Me.xrLugarEjecucionDeta.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeEjecucionProyEspecial.LUGAR_EJECUCION")})
        Me.xrLugarEjecucionDeta.Name = "xrLugarEjecucionDeta"
        Me.xrLugarEjecucionDeta.StylePriority.UseTextAlignment = False
        Me.xrLugarEjecucionDeta.Text = "xrLugarEjecucionDeta"
        Me.xrLugarEjecucionDeta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrLugarEjecucionDeta.Weight = 0.508400083430379R
        '
        'xrHorarioDeta
        '
        Me.xrHorarioDeta.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeEjecucionProyEspecial.HORARIO")})
        Me.xrHorarioDeta.Name = "xrHorarioDeta"
        Me.xrHorarioDeta.StylePriority.UseTextAlignment = False
        Me.xrHorarioDeta.Text = "xrHorarioDeta"
        Me.xrHorarioDeta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrHorarioDeta.Weight = 0.8710270181017381R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeEjecucionProyEspecial.DURACION_HORAS", "{0:}")})
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.StylePriority.UseTextAlignment = False
        Me.XrTableCell7.Text = "XrTableCell7"
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell7.Weight = 0.31957218675768773R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeEjecucionProyEspecial.HORAS_DESARROLLADAS", "{0:}")})
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseTextAlignment = False
        Me.XrTableCell8.Text = "XrTableCell8"
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell8.Weight = 0.3765350671416372R
        '
        'xrtHorasAcumuladas
        '
        Me.xrtHorasAcumuladas.Name = "xrtHorasAcumuladas"
        Me.xrtHorasAcumuladas.StylePriority.UseTextAlignment = False
        Me.xrtHorasAcumuladas.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrtHorasAcumuladas.Weight = 0.37653376570025304R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeEjecucionProyEspecial.PARTICIPANTES_INSCRITOS")})
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.Text = "XrTableCell9"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell9.Weight = 0.26530419353748874R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeEjecucionProyEspecial.PARTICIPANTES_FINALES")})
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.StylePriority.UseTextAlignment = False
        Me.XrTableCell11.Text = "XrTableCell11"
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell11.Weight = 0.31709655024673949R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeEjecucionProyEspecial.FECHA_INICIAL", "{0:dd/MM/yyyy}")})
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        Me.XrTableCell5.Text = "XrTableCell5"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell5.Weight = 0.4619861400759771R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeEjecucionProyEspecial.FECHA_FINAL", "{0:dd/MM/yyyy}")})
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseTextAlignment = False
        Me.XrTableCell10.Text = "XrTableCell10"
        Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell10.Weight = 0.431926702223586R
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 72.91666!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.StylePriority.UseTextAlignment = False
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 43.24996!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'DS_DL1
        '
        Me.DS_DL1.DataSetName = "DS_DL"
        Me.DS_DL1.EnforceConstraints = False
        Me.DS_DL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrlModalidad, Me.XrLabel10, Me.XrLabel25, Me.XrLabel24, Me.XrLabel26, Me.XrLabel29, Me.XrLabel28, Me.XrLabel15, Me.XrLabel22, Me.xrLugarEjecucionEnca, Me.XrLabel23, Me.xrHorarioEnca, Me.XrLabel9, Me.xrPeriodoReportado, Me.XrLabel8, Me.xrlNoAnexo, Me.XrLine1, Me.XrLabel3, Me.xrContrato, Me.XrLabel2, Me.xrLabel1, Me.xrLabel4, Me.xrPictureBox1, Me.xrlPrograma, Me.xrLine3})
        Me.PageHeader.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.PageHeader.HeightF = 242.6252!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.StylePriority.UseFont = False
        '
        'xrlModalidad
        '
        Me.xrlModalidad.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeEjecucionProyEspecial.MODALIDAD_FORMACION")})
        Me.xrlModalidad.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrlModalidad.LocationFloat = New DevExpress.Utils.PointFloat(119.7074!, 132.75!)
        Me.xrlModalidad.Name = "xrlModalidad"
        Me.xrlModalidad.SizeF = New System.Drawing.SizeF(419.0009!, 17.25!)
        Me.xrlModalidad.StylePriority.UseFont = False
        Me.xrlModalidad.Text = "xrlModalidad"
        '
        'XrLabel10
        '
        Me.XrLabel10.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(555.7496!, 173.4584!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(69.95831!, 69.16678!)
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Horas Acumuladas"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel25
        '
        Me.XrLabel25.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel25.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(625.7079!, 173.4584!)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(49.29224!, 69.16678!)
        Me.XrLabel25.StylePriority.UseBorders = False
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        Me.XrLabel25.Text = "Inscritos"
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel24
        '
        Me.XrLabel24.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel24.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(485.7913!, 173.4583!)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(69.95837!, 69.16678!)
        Me.XrLabel24.StylePriority.UseBorders = False
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.StylePriority.UseTextAlignment = False
        Me.XrLabel24.Text = "Horas formativas Desarrolladas"
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel26
        '
        Me.XrLabel26.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel26.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(675.0001!, 173.4584!)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(58.91498!, 69.16675!)
        Me.XrLabel26.StylePriority.UseBorders = False
        Me.XrLabel26.StylePriority.UseFont = False
        Me.XrLabel26.StylePriority.UseTextAlignment = False
        Me.XrLabel26.Text = "Asistentes"
        Me.XrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel29
        '
        Me.XrLabel29.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel29.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(819.75!, 173.4584!)
        Me.XrLabel29.Multiline = True
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(80.25!, 69.16675!)
        Me.XrLabel29.StylePriority.UseBorders = False
        Me.XrLabel29.StylePriority.UseFont = False
        Me.XrLabel29.StylePriority.UseTextAlignment = False
        Me.XrLabel29.Text = "Fecha de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Finalización"
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel28
        '
        Me.XrLabel28.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel28.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(733.9151!, 173.4584!)
        Me.XrLabel28.Multiline = True
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(85.8349!, 69.16675!)
        Me.XrLabel28.StylePriority.UseBorders = False
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.StylePriority.UseTextAlignment = False
        Me.XrLabel28.Text = "Fecha de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Inicio"
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel15
        '
        Me.XrLabel15.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel15.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(103.2916!, 173.4583!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(66.83362!, 69.16678!)
        Me.XrLabel15.StylePriority.UseBorders = False
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "No HI"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel22
        '
        Me.XrLabel22.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel22.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 173.4583!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(103.2916!, 69.16678!)
        Me.XrLabel22.StylePriority.UseBorders = False
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.Text = "Curso Ejecutado"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrLugarEjecucionEnca
        '
        Me.xrLugarEjecucionEnca.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrLugarEjecucionEnca.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrLugarEjecucionEnca.LocationFloat = New DevExpress.Utils.PointFloat(170.1252!, 173.4583!)
        Me.xrLugarEjecucionEnca.Name = "xrLugarEjecucionEnca"
        Me.xrLugarEjecucionEnca.SizeF = New System.Drawing.SizeF(94.45833!, 69.16678!)
        Me.xrLugarEjecucionEnca.StylePriority.UseBorders = False
        Me.xrLugarEjecucionEnca.StylePriority.UseFont = False
        Me.xrLugarEjecucionEnca.StylePriority.UseTextAlignment = False
        Me.xrLugarEjecucionEnca.Text = "Lugar de Ejecucion del Curso( Municipio, Departamento)"
        Me.xrLugarEjecucionEnca.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel23
        '
        Me.XrLabel23.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel23.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(426.4163!, 173.4583!)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(59.375!, 69.16678!)
        Me.XrLabel23.StylePriority.UseBorders = False
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.Text = "Horas totales del Curso"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrHorarioEnca
        '
        Me.xrHorarioEnca.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrHorarioEnca.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrHorarioEnca.LocationFloat = New DevExpress.Utils.PointFloat(264.5836!, 173.4584!)
        Me.xrHorarioEnca.Name = "xrHorarioEnca"
        Me.xrHorarioEnca.SizeF = New System.Drawing.SizeF(161.8327!, 69.16675!)
        Me.xrHorarioEnca.StylePriority.UseBorders = False
        Me.xrHorarioEnca.StylePriority.UseFont = False
        Me.xrHorarioEnca.StylePriority.UseTextAlignment = False
        Me.xrHorarioEnca.Text = "Horario del Programa"
        Me.xrHorarioEnca.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 132.75!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(119.7072!, 17.24999!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.Text = "MODALIDAD:"
        '
        'xrPeriodoReportado
        '
        Me.xrPeriodoReportado.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrPeriodoReportado.LocationFloat = New DevExpress.Utils.PointFloat(687.2485!, 96.29167!)
        Me.xrPeriodoReportado.Name = "xrPeriodoReportado"
        Me.xrPeriodoReportado.SizeF = New System.Drawing.SizeF(198.3765!, 34.45831!)
        Me.xrPeriodoReportado.StylePriority.UseFont = False
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(555.7496!, 96.29167!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(130.499!, 17.24999!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.Text = "PERIODO REPORTADO:"
        '
        'xrlNoAnexo
        '
        Me.xrlNoAnexo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrlNoAnexo.LocationFloat = New DevExpress.Utils.PointFloat(798.5416!, 5.000014!)
        Me.xrlNoAnexo.Name = "xrlNoAnexo"
        Me.xrlNoAnexo.SizeF = New System.Drawing.SizeF(87.08334!, 17.25!)
        Me.xrlNoAnexo.StylePriority.UseFont = False
        Me.xrlNoAnexo.StylePriority.UseTextAlignment = False
        Me.xrlNoAnexo.Text = "ANEXO I"
        Me.xrlNoAnexo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(3.416586!, 48.00002!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(886.5834!, 2.0!)
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(3.416586!, 73.08334!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(886.5834!, 19.20834!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "REFERENTE: [NOMBRE_REFERENTE]"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrContrato
        '
        Me.xrContrato.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrContrato.LocationFloat = New DevExpress.Utils.PointFloat(0.0002066294!, 152.2083!)
        Me.xrContrato.Name = "xrContrato"
        Me.xrContrato.SizeF = New System.Drawing.SizeF(538.7081!, 17.24998!)
        Me.xrContrato.StylePriority.UseFont = False
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeEjecucionProyEspecial.NOMBRE_PROVEEDOR")})
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(87.08334!, 96.29167!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(451.625!, 34.45833!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.Text = "XrLabel2"
        '
        'xrLabel1
        '
        Me.xrLabel1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 96.29167!)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(87.08334!, 17.25!)
        Me.xrLabel1.StylePriority.UseFont = False
        Me.xrLabel1.Text = "PROVEEDOR:"
        '
        'xrLabel4
        '
        Me.xrLabel4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(3.416586!, 53.875!)
        Me.xrLabel4.Name = "xrLabel4"
        Me.xrLabel4.SizeF = New System.Drawing.SizeF(886.5834!, 19.20833!)
        Me.xrLabel4.StylePriority.UseFont = False
        Me.xrLabel4.StylePriority.UseTextAlignment = False
        Me.xrLabel4.Text = "INFORME DE EJECUCIÓN DE ACCIÓN FORMATIVA"
        Me.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrPictureBox1
        '
        Me.xrPictureBox1.Image = CType(resources.GetObject("xrPictureBox1.Image"), System.Drawing.Image)
        Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(3.416586!, 2.000014!)
        Me.xrPictureBox1.Name = "xrPictureBox1"
        Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(145.875!, 45.99999!)
        Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'xrlPrograma
        '
        Me.xrlPrograma.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.xrlPrograma.LocationFloat = New DevExpress.Utils.PointFloat(161.4585!, 9.999974!)
        Me.xrlPrograma.Name = "xrlPrograma"
        Me.xrlPrograma.SizeF = New System.Drawing.SizeF(611.6246!, 34.20835!)
        Me.xrlPrograma.StylePriority.UseFont = False
        Me.xrlPrograma.StylePriority.UseTextAlignment = False
        Me.xrlPrograma.Text = "PROGRAMA: [NOMBRE_PROYECTO_FORMACION]"
        Me.xrlPrograma.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLine3
        '
        Me.xrLine3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.xrLine3.Name = "xrLine3"
        Me.xrLine3.SizeF = New System.Drawing.SizeF(890.0!, 2.0!)
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine6, Me.XrLine5, Me.XrLabel13, Me.XrLine4, Me.XrLabel12, Me.XrLabel11, Me.xrLine2, Me.XrLabel20})
        Me.ReportFooter.HeightF = 196.3334!
        Me.ReportFooter.Name = "ReportFooter"
        Me.ReportFooter.PrintAtBottom = True
        '
        'XrLine6
        '
        Me.XrLine6.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 46.91666!)
        Me.XrLine6.Name = "XrLine6"
        Me.XrLine6.SizeF = New System.Drawing.SizeF(899.9999!, 12.5!)
        '
        'XrLine5
        '
        Me.XrLine5.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 29.41668!)
        Me.XrLine5.Name = "XrLine5"
        Me.XrLine5.SizeF = New System.Drawing.SizeF(899.9999!, 12.5!)
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(103.2919!, 17.99997!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "OBSERVACIONES"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine4
        '
        Me.XrLine4.LocationFloat = New DevExpress.Utils.PointFloat(103.2916!, 11.00001!)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.SizeF = New System.Drawing.SizeF(796.7083!, 12.5!)
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 154.7501!)
        Me.XrLabel12.Multiline = True
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(900.0!, 32.875!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.Text = "EL REFERENTE HACE CONSTAR QUE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "LOS DATOS PRESENTADOS EN ESTE REPORTE SON REALES Y" & _
    " QUE LA EJECUCIÓN DE LOS CURSOS ESTÁ DE ACUERDO CON ESTOS DATOS"
        '
        'XrLabel11
        '
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(62.5!, 126.0!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(229.5418!, 17.99998!)
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "NOMBRE:"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrLine2
        '
        Me.xrLine2.LocationFloat = New DevExpress.Utils.PointFloat(62.5!, 93.0!)
        Me.xrLine2.Name = "xrLine2"
        Me.xrLine2.SizeF = New System.Drawing.SizeF(312.5!, 12.5!)
        '
        'XrLabel20
        '
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(112.5!, 106.0!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(229.5418!, 17.99998!)
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = "REFERENTE"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'InformeEjecucionProyEspecialTableAdapter1
        '
        Me.InformeEjecucionProyEspecialTableAdapter1.ClearBeforeFill = True
        '
        'xrInformeProyEspecialAnexo1
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.ReportFooter})
        Me.DataAdapter = Me.InformeEjecucionProyEspecialTableAdapter1
        Me.DataMember = "InformeEjecucionProyEspecial"
        Me.DataSource = Me.DS_DL1
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(100, 100, 73, 43)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.Version = "11.1"
        CType(Me.xrDeta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents DS_DL1 As SGAFP.DL.DS_DL
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Private WithEvents xrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Private WithEvents xrlPrograma As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Private WithEvents xrLine2 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrDeta As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrLugarEjecucionDeta As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrContrato As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrlNoAnexo As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrLine3 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrPeriodoReportado As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLugarEjecucionEnca As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLine6 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents xrtHorasAcumuladas As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Private WithEvents xrlModalidad As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents InformeEjecucionProyEspecialTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.InformeEjecucionProyEspecialTableAdapter
    Private WithEvents xrHorarioEnca As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrHorarioDeta As DevExpress.XtraReports.UI.XRTableCell
End Class
