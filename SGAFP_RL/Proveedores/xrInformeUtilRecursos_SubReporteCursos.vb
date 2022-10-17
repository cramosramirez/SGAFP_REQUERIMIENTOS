Public Class xrInformeUtilRecursos_SubReporteCursos
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Código Generado "

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
    Friend WithEvents DS_DL1 As SGAFP.DL.DS_DL
    Friend WithEvents InformeUtilRecursos_CursosTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.InformeUtilRecursos_CursosTableAdapter
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable5 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell31 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrTable6 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell35 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell36 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell37 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell38 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell39 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell40 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell41 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell42 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell43 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell44 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell45 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell46 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell47 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell48 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell49 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell51 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell52 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell53 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell54 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell55 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell56 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TOTAL_MONTO As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents TOTAL_PARTICIPANTES As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents TOTAL_CURSOS As DevExpress.XtraReports.UI.CalculatedField

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary6 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary7 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary8 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary9 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary10 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary11 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary12 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary13 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary14 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary15 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary16 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary17 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary18 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary19 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary20 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary21 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary22 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary23 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary24 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable5 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell45 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell46 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell47 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell48 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell49 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell50 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell51 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell52 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell53 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell54 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell55 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell56 = New DevExpress.XtraReports.UI.XRTableCell
        Me.DS_DL1 = New SGAFP.DL.DS_DL
        Me.InformeUtilRecursos_CursosTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.InformeUtilRecursos_CursosTableAdapter
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.XrTable6 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell36 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell37 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell38 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell39 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell40 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell41 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell42 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell43 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell44 = New DevExpress.XtraReports.UI.XRTableCell
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.TOTAL_MONTO = New DevExpress.XtraReports.UI.CalculatedField
        Me.TOTAL_PARTICIPANTES = New DevExpress.XtraReports.UI.CalculatedField
        Me.TOTAL_CURSOS = New DevExpress.XtraReports.UI.CalculatedField
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable5})
        Me.Detail.HeightF = 25.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("TOTAL_MONTO", DevExpress.XtraReports.UI.XRColumnSortOrder.Descending)})
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable5
        '
        Me.XrTable5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable5.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrTable5.LocationFloat = New DevExpress.Utils.PointFloat(14.99999!, 0.0!)
        Me.XrTable5.Name = "XrTable5"
        Me.XrTable5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow5})
        Me.XrTable5.SizeF = New System.Drawing.SizeF(985.9999!, 25.0!)
        Me.XrTable5.StylePriority.UseBorders = False
        Me.XrTable5.StylePriority.UseFont = False
        Me.XrTable5.StylePriority.UseTextAlignment = False
        Me.XrTable5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell30, Me.XrTableCell24, Me.XrTableCell29, Me.XrTableCell17, Me.XrTableCell23, Me.XrTableCell22, Me.XrTableCell26, Me.XrTableCell18, Me.XrTableCell31, Me.XrTableCell21, Me.XrTableCell20, Me.XrTableCell27, Me.XrTableCell19})
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Weight = 1
        '
        'XrTableCell30
        '
        Me.XrTableCell30.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.CURSO")})
        Me.XrTableCell30.Name = "XrTableCell30"
        Me.XrTableCell30.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell30.StylePriority.UsePadding = False
        Me.XrTableCell30.StylePriority.UseTextAlignment = False
        Me.XrTableCell30.Text = "XrTableCell30"
        Me.XrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell30.Weight = 0.77905403611090152
        '
        'XrTableCell24
        '
        Me.XrTableCell24.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.TOTAL_MONTO", "{0:#,##0.00}")})
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.Text = "XrTableCell24"
        Me.XrTableCell24.Weight = 0.21720174156958039
        '
        'XrTableCell29
        '
        Me.XrTableCell29.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.TOTAL_PARTICIPANTES", "{0:#,##0}")})
        Me.XrTableCell29.Name = "XrTableCell29"
        Me.XrTableCell29.Text = "XrTableCell29"
        Me.XrTableCell29.Weight = 0.13748093966662051
        '
        'XrTableCell17
        '
        Me.XrTableCell17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.TOTAL_CURSOS", "{0:#,##0}")})
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.Text = "XrTableCell17"
        Me.XrTableCell17.Weight = 0.20053320031052413
        '
        'XrTableCell23
        '
        Me.XrTableCell23.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.EJECUTADO_MONTO", "{0:#,##0.00}")})
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.Text = "XrTableCell23"
        Me.XrTableCell23.Weight = 0.21721093398465563
        '
        'XrTableCell22
        '
        Me.XrTableCell22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.EJECUTADO_PARTICIPANTES", "{0:#,##0}")})
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.Text = "XrTableCell22"
        Me.XrTableCell22.Weight = 0.13749477471557214
        '
        'XrTableCell26
        '
        Me.XrTableCell26.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.EJECUTADO_NUM_CURSOS", "{0:#,##0}")})
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.Text = "XrTableCell26"
        Me.XrTableCell26.Weight = 0.20053781973123114
        '
        'XrTableCell18
        '
        Me.XrTableCell18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.EJECUCION_MONTO", "{0:#,##0.00}")})
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.Text = "XrTableCell18"
        Me.XrTableCell18.Weight = 0.21721063221345366
        '
        'XrTableCell31
        '
        Me.XrTableCell31.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.EJECUCION_PARTICIPANTES", "{0:#,##0}")})
        Me.XrTableCell31.Name = "XrTableCell31"
        Me.XrTableCell31.Text = "XrTableCell31"
        Me.XrTableCell31.Weight = 0.13749495268320405
        '
        'XrTableCell21
        '
        Me.XrTableCell21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.EJECUCION_NUM_CURSOS", "{0:#,##0}")})
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.Text = "XrTableCell21"
        Me.XrTableCell21.Weight = 0.20053802091203243
        '
        'XrTableCell20
        '
        Me.XrTableCell20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.PROGRAMADO_MONTO", "{0:#,##0.00}")})
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.Text = "XrTableCell20"
        Me.XrTableCell20.Weight = 0.21721063221345371
        '
        'XrTableCell27
        '
        Me.XrTableCell27.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.PROGRAMADO_PARTICIPANTES", "{0:#,##0}")})
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.Text = "XrTableCell27"
        Me.XrTableCell27.Weight = 0.13749493720775779
        '
        'XrTableCell19
        '
        Me.XrTableCell19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.PROGRAMADO_NUM_CURSOS", "{0:#,##0}")})
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.Text = "XrTableCell19"
        Me.XrTableCell19.Weight = 0.20053737868101285
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
        Me.BottomMargin.HeightF = 34.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable4})
        Me.GroupHeader1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("RECURSO_AREA_FORMATIVA", DevExpress.XtraReports.UI.XRColumnSortOrder.Descending), New DevExpress.XtraReports.UI.GroupField("AREA_FORMATIVA", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 25.0!
        Me.GroupHeader1.KeepTogether = True
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.StylePriority.UseFont = False
        '
        'XrTable4
        '
        Me.XrTable4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable4.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrTable4.LocationFloat = New DevExpress.Utils.PointFloat(15.00015!, 0.0!)
        Me.XrTable4.Name = "XrTable4"
        Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
        Me.XrTable4.SizeF = New System.Drawing.SizeF(985.9999!, 25.0!)
        Me.XrTable4.StylePriority.UseBorders = False
        Me.XrTable4.StylePriority.UseFont = False
        Me.XrTable4.StylePriority.UseTextAlignment = False
        Me.XrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell13, Me.XrTableCell45, Me.XrTableCell46, Me.XrTableCell47, Me.XrTableCell48, Me.XrTableCell49, Me.XrTableCell50, Me.XrTableCell51, Me.XrTableCell52, Me.XrTableCell53, Me.XrTableCell54, Me.XrTableCell55, Me.XrTableCell56})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Weight = 1
        '
        'XrTableCell13
        '
        Me.XrTableCell13.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.XrTableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.AREA_FORMATIVA")})
        Me.XrTableCell13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell13.StylePriority.UseBackColor = False
        Me.XrTableCell13.StylePriority.UseFont = False
        Me.XrTableCell13.StylePriority.UsePadding = False
        Me.XrTableCell13.StylePriority.UseTextAlignment = False
        Me.XrTableCell13.Text = "XrTableCell13"
        Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell13.Weight = 0.77905403611090152
        '
        'XrTableCell45
        '
        Me.XrTableCell45.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.XrTableCell45.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.TOTAL_MONTO")})
        Me.XrTableCell45.Name = "XrTableCell45"
        Me.XrTableCell45.StylePriority.UseBackColor = False
        XrSummary1.FormatString = "{0:#,##0.00}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell45.Summary = XrSummary1
        Me.XrTableCell45.Text = "XrTableCell45"
        Me.XrTableCell45.Weight = 0.21720174156958039
        '
        'XrTableCell46
        '
        Me.XrTableCell46.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.XrTableCell46.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.TOTAL_PARTICIPANTES")})
        Me.XrTableCell46.Name = "XrTableCell46"
        Me.XrTableCell46.StylePriority.UseBackColor = False
        XrSummary2.FormatString = "{0:#,##0}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell46.Summary = XrSummary2
        Me.XrTableCell46.Text = "XrTableCell46"
        Me.XrTableCell46.Weight = 0.13748093966662051
        '
        'XrTableCell47
        '
        Me.XrTableCell47.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.XrTableCell47.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.TOTAL_CURSOS")})
        Me.XrTableCell47.Name = "XrTableCell47"
        Me.XrTableCell47.StylePriority.UseBackColor = False
        XrSummary3.FormatString = "{0:#,##0}"
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell47.Summary = XrSummary3
        Me.XrTableCell47.Text = "XrTableCell47"
        Me.XrTableCell47.Weight = 0.20053320031052413
        '
        'XrTableCell48
        '
        Me.XrTableCell48.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.XrTableCell48.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.EJECUTADO_MONTO")})
        Me.XrTableCell48.Name = "XrTableCell48"
        Me.XrTableCell48.StylePriority.UseBackColor = False
        XrSummary4.FormatString = "{0:#,##0.00}"
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell48.Summary = XrSummary4
        Me.XrTableCell48.Text = "XrTableCell48"
        Me.XrTableCell48.Weight = 0.21721093398465563
        '
        'XrTableCell49
        '
        Me.XrTableCell49.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.XrTableCell49.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.EJECUTADO_PARTICIPANTES")})
        Me.XrTableCell49.Name = "XrTableCell49"
        Me.XrTableCell49.StylePriority.UseBackColor = False
        XrSummary5.FormatString = "{0:#,##0}"
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell49.Summary = XrSummary5
        Me.XrTableCell49.Text = "XrTableCell49"
        Me.XrTableCell49.Weight = 0.13749477471557214
        '
        'XrTableCell50
        '
        Me.XrTableCell50.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.XrTableCell50.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.EJECUTADO_NUM_CURSOS")})
        Me.XrTableCell50.Name = "XrTableCell50"
        Me.XrTableCell50.StylePriority.UseBackColor = False
        XrSummary6.FormatString = "{0:#,##0}"
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell50.Summary = XrSummary6
        Me.XrTableCell50.Text = "XrTableCell50"
        Me.XrTableCell50.Weight = 0.20053781973123114
        '
        'XrTableCell51
        '
        Me.XrTableCell51.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.XrTableCell51.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.EJECUCION_MONTO")})
        Me.XrTableCell51.Name = "XrTableCell51"
        Me.XrTableCell51.StylePriority.UseBackColor = False
        XrSummary7.FormatString = "{0:#,##0.00}"
        XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell51.Summary = XrSummary7
        Me.XrTableCell51.Text = "XrTableCell51"
        Me.XrTableCell51.Weight = 0.21721063221345366
        '
        'XrTableCell52
        '
        Me.XrTableCell52.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.XrTableCell52.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.EJECUCION_PARTICIPANTES")})
        Me.XrTableCell52.Name = "XrTableCell52"
        Me.XrTableCell52.StylePriority.UseBackColor = False
        XrSummary8.FormatString = "{0:#,##0}"
        XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell52.Summary = XrSummary8
        Me.XrTableCell52.Text = "XrTableCell52"
        Me.XrTableCell52.Weight = 0.13749495268320405
        '
        'XrTableCell53
        '
        Me.XrTableCell53.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.XrTableCell53.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.EJECUCION_NUM_CURSOS")})
        Me.XrTableCell53.Name = "XrTableCell53"
        Me.XrTableCell53.StylePriority.UseBackColor = False
        XrSummary9.FormatString = "{0:#,##0}"
        XrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell53.Summary = XrSummary9
        Me.XrTableCell53.Text = "XrTableCell53"
        Me.XrTableCell53.Weight = 0.20053802091203243
        '
        'XrTableCell54
        '
        Me.XrTableCell54.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.XrTableCell54.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.PROGRAMADO_MONTO")})
        Me.XrTableCell54.Name = "XrTableCell54"
        Me.XrTableCell54.StylePriority.UseBackColor = False
        XrSummary10.FormatString = "{0:#,##0.00}"
        XrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell54.Summary = XrSummary10
        Me.XrTableCell54.Text = "XrTableCell54"
        Me.XrTableCell54.Weight = 0.21721063221345371
        '
        'XrTableCell55
        '
        Me.XrTableCell55.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.XrTableCell55.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.PROGRAMADO_PARTICIPANTES")})
        Me.XrTableCell55.Name = "XrTableCell55"
        Me.XrTableCell55.StylePriority.UseBackColor = False
        XrSummary11.FormatString = "{0:#,##0}"
        XrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell55.Summary = XrSummary11
        Me.XrTableCell55.Text = "XrTableCell55"
        Me.XrTableCell55.Weight = 0.13749493720775779
        '
        'XrTableCell56
        '
        Me.XrTableCell56.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.XrTableCell56.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.PROGRAMADO_NUM_CURSOS")})
        Me.XrTableCell56.Name = "XrTableCell56"
        Me.XrTableCell56.StylePriority.UseBackColor = False
        XrSummary12.FormatString = "{0:#,##0}"
        XrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell56.Summary = XrSummary12
        Me.XrTableCell56.Text = "XrTableCell56"
        Me.XrTableCell56.Weight = 0.20053737868101285
        '
        'DS_DL1
        '
        Me.DS_DL1.DataSetName = "DS_DL"
        Me.DS_DL1.EnforceConstraints = False
        Me.DS_DL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InformeUtilRecursos_CursosTableAdapter1
        '
        Me.InformeUtilRecursos_CursosTableAdapter1.ClearBeforeFill = True
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3, Me.XrTable1, Me.XrTable2, Me.XrLabel1})
        Me.PageHeader.HeightF = 88.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrTable3
        '
        Me.XrTable3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable3.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(14.99999!, 37.99998!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(256.049!, 50.00002!)
        Me.XrTable3.StylePriority.UseBorders = False
        Me.XrTable3.StylePriority.UseFont = False
        Me.XrTable3.StylePriority.UseTextAlignment = False
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell16})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1
        '
        'XrTableCell16
        '
        Me.XrTableCell16.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.XrTableCell16.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell16.Multiline = True
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.StylePriority.UseBackColor = False
        Me.XrTableCell16.StylePriority.UseFont = False
        Me.XrTableCell16.Text = "AREA FORMATIVA / CURSO"
        Me.XrTableCell16.Weight = 1.1532640745072607
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(271.0491!, 63.0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(729.9509!, 25.0!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell28, Me.XrTableCell15, Me.XrTableCell25, Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell9, Me.XrTableCell3})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1
        '
        'XrTableCell28
        '
        Me.XrTableCell28.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.StylePriority.UseBackColor = False
        Me.XrTableCell28.Text = "MONTO"
        Me.XrTableCell28.Weight = 0.26843419895736409
        '
        'XrTableCell15
        '
        Me.XrTableCell15.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.StylePriority.UseBackColor = False
        Me.XrTableCell15.Text = "# PART."
        Me.XrTableCell15.Weight = 0.16990951001173166
        '
        'XrTableCell25
        '
        Me.XrTableCell25.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.XrTableCell25.Name = "XrTableCell25"
        Me.XrTableCell25.StylePriority.UseBackColor = False
        Me.XrTableCell25.Text = "# CURSOS"
        Me.XrTableCell25.Weight = 0.24783378372463122
        '
        'XrTableCell1
        '
        Me.XrTableCell1.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseBackColor = False
        Me.XrTableCell1.Text = "MONTO"
        Me.XrTableCell1.Weight = 0.26844567806773051
        '
        'XrTableCell2
        '
        Me.XrTableCell2.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseBackColor = False
        Me.XrTableCell2.Text = "# PART."
        Me.XrTableCell2.Weight = 0.169926593546146
        '
        'XrTableCell4
        '
        Me.XrTableCell4.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.XrTableCell4.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseBackColor = False
        Me.XrTableCell4.StylePriority.UseFont = False
        Me.XrTableCell4.Text = "# CURSOS"
        Me.XrTableCell4.Weight = 0.24783942275893694
        '
        'XrTableCell5
        '
        Me.XrTableCell5.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseBackColor = False
        Me.XrTableCell5.Text = "MONTO"
        Me.XrTableCell5.Weight = 0.26844567263804608
        '
        'XrTableCell6
        '
        Me.XrTableCell6.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.StylePriority.UseBackColor = False
        Me.XrTableCell6.Text = "# PART."
        Me.XrTableCell6.Weight = 0.16992658967852584
        '
        'XrTableCell7
        '
        Me.XrTableCell7.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.XrTableCell7.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.StylePriority.UseBackColor = False
        Me.XrTableCell7.StylePriority.UseFont = False
        Me.XrTableCell7.Text = "# CURSOS"
        Me.XrTableCell7.Weight = 0.24783942140824894
        '
        'XrTableCell8
        '
        Me.XrTableCell8.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseBackColor = False
        Me.XrTableCell8.Text = "MONTO"
        Me.XrTableCell8.Weight = 0.26844566166261219
        '
        'XrTableCell9
        '
        Me.XrTableCell9.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StylePriority.UseBackColor = False
        Me.XrTableCell9.Text = "# PART."
        Me.XrTableCell9.Weight = 0.16992662468883046
        '
        'XrTableCell3
        '
        Me.XrTableCell3.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.XrTableCell3.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseBackColor = False
        Me.XrTableCell3.StylePriority.UseFont = False
        Me.XrTableCell3.Text = "# CURSOS"
        Me.XrTableCell3.Weight = 0.24783952965977235
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Arial", 7.0!)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(271.0491!, 37.99998!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(729.9509!, 25.0!)
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell14, Me.XrTableCell10, Me.XrTableCell11, Me.XrTableCell12})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1
        '
        'XrTableCell14
        '
        Me.XrTableCell14.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.XrTableCell14.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.StylePriority.UseBackColor = False
        Me.XrTableCell14.StylePriority.UseFont = False
        Me.XrTableCell14.Text = "TOTAL"
        Me.XrTableCell14.Weight = 0.70230307702571593
        '
        'XrTableCell10
        '
        Me.XrTableCell10.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.XrTableCell10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseBackColor = False
        Me.XrTableCell10.StylePriority.UseFont = False
        Me.XrTableCell10.Text = "EJECUTADO"
        Me.XrTableCell10.Weight = 0.70233807946204385
        '
        'XrTableCell11
        '
        Me.XrTableCell11.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.XrTableCell11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.StylePriority.UseBackColor = False
        Me.XrTableCell11.StylePriority.UseFont = False
        Me.XrTableCell11.Text = "EN EJECUCIÓN"
        Me.XrTableCell11.Weight = 0.70233764764455486
        '
        'XrTableCell12
        '
        Me.XrTableCell12.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.XrTableCell12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.StylePriority.UseBackColor = False
        Me.XrTableCell12.StylePriority.UseFont = False
        Me.XrTableCell12.Text = "POR EJECUTARSE"
        Me.XrTableCell12.Weight = 0.70233793055539073
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(14.99999!, 10.00001!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(963.5414!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "UTILIZACIÓN DE RECURSOS POR ACCION FORMATIVA"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Expanded = False
        Me.GroupFooter1.HeightF = 0.0!
        Me.GroupFooter1.KeepTogether = True
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrTable6
        '
        Me.XrTable6.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable6.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrTable6.LocationFloat = New DevExpress.Utils.PointFloat(15.00015!, 0.0!)
        Me.XrTable6.Name = "XrTable6"
        Me.XrTable6.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow6})
        Me.XrTable6.SizeF = New System.Drawing.SizeF(985.9999!, 25.0!)
        Me.XrTable6.StylePriority.UseBorders = False
        Me.XrTable6.StylePriority.UseFont = False
        Me.XrTable6.StylePriority.UseTextAlignment = False
        Me.XrTable6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell32, Me.XrTableCell33, Me.XrTableCell34, Me.XrTableCell35, Me.XrTableCell36, Me.XrTableCell37, Me.XrTableCell38, Me.XrTableCell39, Me.XrTableCell40, Me.XrTableCell41, Me.XrTableCell42, Me.XrTableCell43, Me.XrTableCell44})
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Weight = 1
        '
        'XrTableCell32
        '
        Me.XrTableCell32.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.XrTableCell32.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell32.Name = "XrTableCell32"
        Me.XrTableCell32.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell32.StylePriority.UseBackColor = False
        Me.XrTableCell32.StylePriority.UseFont = False
        Me.XrTableCell32.StylePriority.UsePadding = False
        Me.XrTableCell32.StylePriority.UseTextAlignment = False
        Me.XrTableCell32.Text = "TOTAL"
        Me.XrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell32.Weight = 0.77905403611090152
        '
        'XrTableCell33
        '
        Me.XrTableCell33.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.XrTableCell33.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.TOTAL_MONTO")})
        Me.XrTableCell33.Name = "XrTableCell33"
        Me.XrTableCell33.StylePriority.UseBackColor = False
        XrSummary13.FormatString = "{0:#,##0.00}"
        XrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell33.Summary = XrSummary13
        Me.XrTableCell33.Text = "XrTableCell33"
        Me.XrTableCell33.Weight = 0.21720174156958039
        '
        'XrTableCell34
        '
        Me.XrTableCell34.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.XrTableCell34.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.TOTAL_PARTICIPANTES")})
        Me.XrTableCell34.Name = "XrTableCell34"
        Me.XrTableCell34.StylePriority.UseBackColor = False
        XrSummary14.FormatString = "{0:#,##0}"
        XrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell34.Summary = XrSummary14
        Me.XrTableCell34.Text = "XrTableCell34"
        Me.XrTableCell34.Weight = 0.13748093966662051
        '
        'XrTableCell35
        '
        Me.XrTableCell35.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.XrTableCell35.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.TOTAL_CURSOS")})
        Me.XrTableCell35.Name = "XrTableCell35"
        Me.XrTableCell35.StylePriority.UseBackColor = False
        XrSummary15.FormatString = "{0:#,##0}"
        XrSummary15.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell35.Summary = XrSummary15
        Me.XrTableCell35.Text = "XrTableCell35"
        Me.XrTableCell35.Weight = 0.20053320031052413
        '
        'XrTableCell36
        '
        Me.XrTableCell36.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.XrTableCell36.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.EJECUTADO_MONTO")})
        Me.XrTableCell36.Name = "XrTableCell36"
        Me.XrTableCell36.StylePriority.UseBackColor = False
        XrSummary16.FormatString = "{0:#,##0.00}"
        XrSummary16.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell36.Summary = XrSummary16
        Me.XrTableCell36.Text = "XrTableCell36"
        Me.XrTableCell36.Weight = 0.21721093398465563
        '
        'XrTableCell37
        '
        Me.XrTableCell37.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.XrTableCell37.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.EJECUTADO_PARTICIPANTES")})
        Me.XrTableCell37.Name = "XrTableCell37"
        Me.XrTableCell37.StylePriority.UseBackColor = False
        XrSummary17.FormatString = "{0:#,##0}"
        XrSummary17.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell37.Summary = XrSummary17
        Me.XrTableCell37.Text = "XrTableCell37"
        Me.XrTableCell37.Weight = 0.13749477471557214
        '
        'XrTableCell38
        '
        Me.XrTableCell38.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.XrTableCell38.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.EJECUTADO_NUM_CURSOS")})
        Me.XrTableCell38.Name = "XrTableCell38"
        Me.XrTableCell38.StylePriority.UseBackColor = False
        XrSummary18.FormatString = "{0:#,##0}"
        XrSummary18.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell38.Summary = XrSummary18
        Me.XrTableCell38.Text = "XrTableCell38"
        Me.XrTableCell38.Weight = 0.20053781973123114
        '
        'XrTableCell39
        '
        Me.XrTableCell39.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.XrTableCell39.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.EJECUCION_MONTO")})
        Me.XrTableCell39.Name = "XrTableCell39"
        Me.XrTableCell39.StylePriority.UseBackColor = False
        XrSummary19.FormatString = "{0:#,##0.00}"
        XrSummary19.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell39.Summary = XrSummary19
        Me.XrTableCell39.Text = "XrTableCell39"
        Me.XrTableCell39.Weight = 0.21721063221345366
        '
        'XrTableCell40
        '
        Me.XrTableCell40.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.XrTableCell40.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.EJECUCION_PARTICIPANTES")})
        Me.XrTableCell40.Name = "XrTableCell40"
        Me.XrTableCell40.StylePriority.UseBackColor = False
        XrSummary20.FormatString = "{0:#,##0}"
        XrSummary20.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell40.Summary = XrSummary20
        Me.XrTableCell40.Text = "XrTableCell40"
        Me.XrTableCell40.Weight = 0.13749495268320405
        '
        'XrTableCell41
        '
        Me.XrTableCell41.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.XrTableCell41.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.EJECUCION_NUM_CURSOS")})
        Me.XrTableCell41.Name = "XrTableCell41"
        Me.XrTableCell41.StylePriority.UseBackColor = False
        XrSummary21.FormatString = "{0:#,##0}"
        XrSummary21.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell41.Summary = XrSummary21
        Me.XrTableCell41.Text = "XrTableCell41"
        Me.XrTableCell41.Weight = 0.20053802091203243
        '
        'XrTableCell42
        '
        Me.XrTableCell42.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.XrTableCell42.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.PROGRAMADO_MONTO")})
        Me.XrTableCell42.Name = "XrTableCell42"
        Me.XrTableCell42.StylePriority.UseBackColor = False
        XrSummary22.FormatString = "{0:#,##0.00}"
        XrSummary22.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell42.Summary = XrSummary22
        Me.XrTableCell42.Text = "XrTableCell42"
        Me.XrTableCell42.Weight = 0.21721063221345371
        '
        'XrTableCell43
        '
        Me.XrTableCell43.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.XrTableCell43.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.PROGRAMADO_PARTICIPANTES")})
        Me.XrTableCell43.Name = "XrTableCell43"
        Me.XrTableCell43.StylePriority.UseBackColor = False
        XrSummary23.FormatString = "{0:#,##0}"
        XrSummary23.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell43.Summary = XrSummary23
        Me.XrTableCell43.Text = "XrTableCell43"
        Me.XrTableCell43.Weight = 0.13749493720775779
        '
        'XrTableCell44
        '
        Me.XrTableCell44.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.XrTableCell44.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "InformeUtilRecursos_Cursos.PROGRAMADO_NUM_CURSOS")})
        Me.XrTableCell44.Name = "XrTableCell44"
        Me.XrTableCell44.StylePriority.UseBackColor = False
        XrSummary24.FormatString = "{0:#,##0}"
        XrSummary24.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell44.Summary = XrSummary24
        Me.XrTableCell44.Text = "XrTableCell44"
        Me.XrTableCell44.Weight = 0.20053737868101285
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable6})
        Me.GroupHeader2.HeightF = 25.0!
        Me.GroupHeader2.Level = 1
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'GroupFooter2
        '
        Me.GroupFooter2.HeightF = 38.0!
        Me.GroupFooter2.Level = 1
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'TOTAL_MONTO
        '
        Me.TOTAL_MONTO.DataMember = "InformeUtilRecursos_Cursos"
        Me.TOTAL_MONTO.DataSource = Me.DS_DL1
        Me.TOTAL_MONTO.Expression = "[EJECUTADO_MONTO] + [EJECUCION_MONTO] + [PROGRAMADO_MONTO]"
        Me.TOTAL_MONTO.Name = "TOTAL_MONTO"
        '
        'TOTAL_PARTICIPANTES
        '
        Me.TOTAL_PARTICIPANTES.DataMember = "InformeUtilRecursos_Cursos"
        Me.TOTAL_PARTICIPANTES.DataSource = Me.DS_DL1
        Me.TOTAL_PARTICIPANTES.Expression = "[EJECUTADO_PARTICIPANTES] + [EJECUCION_PARTICIPANTES] + [PROGRAMADO_PARTICIPANTES" & _
            "]"
        Me.TOTAL_PARTICIPANTES.Name = "TOTAL_PARTICIPANTES"
        '
        'TOTAL_CURSOS
        '
        Me.TOTAL_CURSOS.DataMember = "InformeUtilRecursos_Cursos"
        Me.TOTAL_CURSOS.DataSource = Me.DS_DL1
        Me.TOTAL_CURSOS.Expression = "[EJECUTADO_NUM_CURSOS] + [EJECUCION_NUM_CURSOS] + [PROGRAMADO_NUM_CURSOS]"
        Me.TOTAL_CURSOS.Name = "TOTAL_CURSOS"
        '
        'xrInformeUtilRecursos_SubReporteCursos
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1, Me.PageHeader, Me.GroupFooter1, Me.GroupHeader2, Me.GroupFooter2})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.TOTAL_MONTO, Me.TOTAL_PARTICIPANTES, Me.TOTAL_CURSOS})
        Me.DataAdapter = Me.InformeUtilRecursos_CursosTableAdapter1
        Me.DataMember = "InformeUtilRecursos_Cursos"
        Me.DataSource = Me.DS_DL1
        Me.DefaultPrinterSettingsUsing.UseLandscape = True
        Me.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(47, 50, 0, 34)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.Version = "10.1"
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand

#End Region

    Public Sub CargarDatosPorEjercicioProveedor(ByVal ID_EJERCICIO As String, ByVal ID_PROVEEDOR_AF As Decimal)
        Me.InformeUtilRecursos_CursosTableAdapter1.Fill(Me.DS_DL1.InformeUtilRecursos_Cursos, ID_EJERCICIO, ID_PROVEEDOR_AF)
    End Sub
End Class