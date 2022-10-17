<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParticipantesActivoYNoActivosPATI
    Inherits frmBase

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim XyDiagram3D1 As DevExpress.XtraCharts.XYDiagram3D = New DevExpress.XtraCharts.XYDiagram3D
        Dim Bar3DSeriesLabel1 As DevExpress.XtraCharts.Bar3DSeriesLabel = New DevExpress.XtraCharts.Bar3DSeriesLabel
        Dim ManhattanBarSeriesView1 As DevExpress.XtraCharts.ManhattanBarSeriesView = New DevExpress.XtraCharts.ManhattanBarSeriesView
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.tabDetalle = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.DS_DL1 = New SGAFP.DL.DS_DL
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNUME_FICH_PATI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNUME_FAMI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colALTA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBAJA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMUNICIPIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colENTREVISTO_INSAFORP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colENTREVISTO_PROVEEDOR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colENTREVISTO_INSAFORP1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colASISTIO_CAPACITACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFINALIZO_CAPACITACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colINSCRITO_NO_ASISTIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_INICIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_FINALIZACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_CURSO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_CURSO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tabAnalisis = New DevExpress.XtraTab.XtraTabPage
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.fieldDEPARTAMENTO1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMUNICIPIO1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldNOMBRECURSO1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFECHAINICIO1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFECHAFINALIZACION1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldNUMEFICHPATI1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldNUMEFAMI1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldNOMBRE1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldALTA1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldBAJA1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldINSCRITONOASISTIO1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.field = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFINALIZOCAPACITACION1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldASISTIOCAPACITACION = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldENTREVISTOINSAFORP = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldENTREVISTOPROVEEDOR = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldENTREVISTADO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldCODIGOCURSO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldCANTSOLICITADAPORALCALDIA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSOLICITOALCALDIA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldAsistio = New DevExpress.XtraPivotGrid.PivotGridField
        Me.tabGrafico = New DevExpress.XtraTab.XtraTabPage
        Me.txtTituloGrafico = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.CbxPROGRAMA_FORMACION1 = New SGAFP.WinUC.cbxPROGRAMA_FORMACION
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabDetalle.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAnalisis.SuspendLayout()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabGrafico.SuspendLayout()
        CType(Me.txtTituloGrafico.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram3D1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Bar3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(ManhattanBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LayoutControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(856, 506)
        Me.SplitContainerControl1.SplitterPosition = 85
        Me.SplitContainerControl1.TabIndex = 4
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.CbxPROGRAMA_FORMACION1)
        Me.LayoutControl1.Controls.Add(Me.SpinEdit1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(856, 85)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SpinEdit1
        '
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SpinEdit1.Location = New System.Drawing.Point(80, 37)
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEdit1.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.SpinEdit1.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SpinEdit1.Size = New System.Drawing.Size(764, 20)
        Me.SpinEdit1.StyleController = Me.LayoutControl1
        Me.SpinEdit1.TabIndex = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(856, 85)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SpinEdit1
        Me.LayoutControlItem2.CustomizationFormText = "Convocatoria"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 25)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(836, 40)
        Me.LayoutControlItem2.Text = "Convocatoria"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(64, 13)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabDetalle
        Me.XtraTabControl1.Size = New System.Drawing.Size(856, 416)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabDetalle, Me.tabAnalisis, Me.tabGrafico})
        '
        'tabDetalle
        '
        Me.tabDetalle.Controls.Add(Me.GridControl1)
        Me.tabDetalle.Name = "tabDetalle"
        Me.tabDetalle.Size = New System.Drawing.Size(850, 390)
        Me.tabDetalle.Text = "Detalle"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "PATIParticipantesActivosYNoActivos"
        Me.GridControl1.DataSource = Me.DS_DL1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(850, 390)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'DS_DL1
        '
        Me.DS_DL1.DataSetName = "DS_DL"
        Me.DS_DL1.EnforceConstraints = False
        Me.DS_DL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNUME_FICH_PATI, Me.colNUME_FAMI, Me.colNOMBRE, Me.colALTA, Me.colBAJA, Me.colMUNICIPIO, Me.colDEPARTAMENTO, Me.colENTREVISTO_INSAFORP, Me.colENTREVISTO_PROVEEDOR, Me.colENTREVISTO_INSAFORP1, Me.colASISTIO_CAPACITACION, Me.colFINALIZO_CAPACITACION, Me.colINSCRITO_NO_ASISTIO, Me.colFECHA_INICIO, Me.colFECHA_FINALIZACION, Me.colNOMBRE_CURSO, Me.colCODIGO_CURSO})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 2
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "NUME_FICH_PATI", Nothing, "Participantes ({0})")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDEPARTAMENTO, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colMUNICIPIO, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCODIGO_CURSO, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNOMBRE_CURSO, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colNUME_FICH_PATI
        '
        Me.colNUME_FICH_PATI.Caption = "No. FICHA"
        Me.colNUME_FICH_PATI.FieldName = "NUME_FICH_PATI"
        Me.colNUME_FICH_PATI.Name = "colNUME_FICH_PATI"
        Me.colNUME_FICH_PATI.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "NUME_FICH_PATI", "# Part. {0}")})
        Me.colNUME_FICH_PATI.Visible = True
        Me.colNUME_FICH_PATI.VisibleIndex = 4
        Me.colNUME_FICH_PATI.Width = 71
        '
        'colNUME_FAMI
        '
        Me.colNUME_FAMI.Caption = "No. Convenio"
        Me.colNUME_FAMI.FieldName = "NUME_FAMI"
        Me.colNUME_FAMI.Name = "colNUME_FAMI"
        Me.colNUME_FAMI.Visible = True
        Me.colNUME_FAMI.VisibleIndex = 5
        Me.colNUME_FAMI.Width = 86
        '
        'colNOMBRE
        '
        Me.colNOMBRE.Caption = "Nombre Completo"
        Me.colNOMBRE.FieldName = "NOMBRE"
        Me.colNOMBRE.Name = "colNOMBRE"
        Me.colNOMBRE.Visible = True
        Me.colNOMBRE.VisibleIndex = 6
        Me.colNOMBRE.Width = 198
        '
        'colALTA
        '
        Me.colALTA.Caption = "Alta"
        Me.colALTA.FieldName = "ALTA"
        Me.colALTA.Name = "colALTA"
        Me.colALTA.Visible = True
        Me.colALTA.VisibleIndex = 7
        Me.colALTA.Width = 47
        '
        'colBAJA
        '
        Me.colBAJA.Caption = "Baja"
        Me.colBAJA.FieldName = "BAJA"
        Me.colBAJA.Name = "colBAJA"
        Me.colBAJA.Visible = True
        Me.colBAJA.VisibleIndex = 8
        Me.colBAJA.Width = 49
        '
        'colMUNICIPIO
        '
        Me.colMUNICIPIO.Caption = "Municipio"
        Me.colMUNICIPIO.FieldName = "MUNICIPIO"
        Me.colMUNICIPIO.Name = "colMUNICIPIO"
        Me.colMUNICIPIO.Width = 109
        '
        'colDEPARTAMENTO
        '
        Me.colDEPARTAMENTO.Caption = "Departamento"
        Me.colDEPARTAMENTO.FieldName = "DEPARTAMENTO"
        Me.colDEPARTAMENTO.Name = "colDEPARTAMENTO"
        Me.colDEPARTAMENTO.Width = 109
        '
        'colENTREVISTO_INSAFORP
        '
        Me.colENTREVISTO_INSAFORP.Caption = "Entrevisto Insaforp"
        Me.colENTREVISTO_INSAFORP.FieldName = "colENTREVISTO_INSAFORP"
        Me.colENTREVISTO_INSAFORP.Name = "colENTREVISTO_INSAFORP"
        Me.colENTREVISTO_INSAFORP.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colENTREVISTO_INSAFORP.Visible = True
        Me.colENTREVISTO_INSAFORP.VisibleIndex = 9
        '
        'colENTREVISTO_PROVEEDOR
        '
        Me.colENTREVISTO_PROVEEDOR.Caption = "Entrevisto Proveedor"
        Me.colENTREVISTO_PROVEEDOR.FieldName = "colENTREVISTO_PROVEEDOR"
        Me.colENTREVISTO_PROVEEDOR.Name = "colENTREVISTO_PROVEEDOR"
        Me.colENTREVISTO_PROVEEDOR.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colENTREVISTO_PROVEEDOR.Visible = True
        Me.colENTREVISTO_PROVEEDOR.VisibleIndex = 10
        '
        'colENTREVISTO_INSAFORP1
        '
        Me.colENTREVISTO_INSAFORP1.Caption = "Entrevistado"
        Me.colENTREVISTO_INSAFORP1.FieldName = "colENTREVISTADO"
        Me.colENTREVISTO_INSAFORP1.Name = "colENTREVISTO_INSAFORP1"
        Me.colENTREVISTO_INSAFORP1.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colENTREVISTO_INSAFORP1.Visible = True
        Me.colENTREVISTO_INSAFORP1.VisibleIndex = 11
        '
        'colASISTIO_CAPACITACION
        '
        Me.colASISTIO_CAPACITACION.Caption = "Asistio"
        Me.colASISTIO_CAPACITACION.FieldName = "ASISTIO_CAPACITACION"
        Me.colASISTIO_CAPACITACION.Name = "colASISTIO_CAPACITACION"
        Me.colASISTIO_CAPACITACION.Visible = True
        Me.colASISTIO_CAPACITACION.VisibleIndex = 13
        Me.colASISTIO_CAPACITACION.Width = 61
        '
        'colFINALIZO_CAPACITACION
        '
        Me.colFINALIZO_CAPACITACION.Caption = "Finalizo"
        Me.colFINALIZO_CAPACITACION.FieldName = "FINALIZO_CAPACITACION"
        Me.colFINALIZO_CAPACITACION.Name = "colFINALIZO_CAPACITACION"
        Me.colFINALIZO_CAPACITACION.Visible = True
        Me.colFINALIZO_CAPACITACION.VisibleIndex = 14
        Me.colFINALIZO_CAPACITACION.Width = 65
        '
        'colINSCRITO_NO_ASISTIO
        '
        Me.colINSCRITO_NO_ASISTIO.Caption = "Inscrito/No Asistio"
        Me.colINSCRITO_NO_ASISTIO.FieldName = "INSCRITO_NO_ASISTIO"
        Me.colINSCRITO_NO_ASISTIO.Name = "colINSCRITO_NO_ASISTIO"
        Me.colINSCRITO_NO_ASISTIO.Visible = True
        Me.colINSCRITO_NO_ASISTIO.VisibleIndex = 12
        Me.colINSCRITO_NO_ASISTIO.Width = 126
        '
        'colFECHA_INICIO
        '
        Me.colFECHA_INICIO.Caption = "Inicio"
        Me.colFECHA_INICIO.FieldName = "FECHA_INICIO"
        Me.colFECHA_INICIO.Name = "colFECHA_INICIO"
        Me.colFECHA_INICIO.Visible = True
        Me.colFECHA_INICIO.VisibleIndex = 2
        Me.colFECHA_INICIO.Width = 110
        '
        'colFECHA_FINALIZACION
        '
        Me.colFECHA_FINALIZACION.Caption = "Fin"
        Me.colFECHA_FINALIZACION.FieldName = "FECHA_FINALIZACION"
        Me.colFECHA_FINALIZACION.Name = "colFECHA_FINALIZACION"
        Me.colFECHA_FINALIZACION.Visible = True
        Me.colFECHA_FINALIZACION.VisibleIndex = 3
        Me.colFECHA_FINALIZACION.Width = 129
        '
        'colNOMBRE_CURSO
        '
        Me.colNOMBRE_CURSO.Caption = "Nombre Curso"
        Me.colNOMBRE_CURSO.FieldName = "NOMBRE_CURSO"
        Me.colNOMBRE_CURSO.Name = "colNOMBRE_CURSO"
        Me.colNOMBRE_CURSO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "NOMBRE_CURSO", "# Cursos {0}")})
        Me.colNOMBRE_CURSO.Visible = True
        Me.colNOMBRE_CURSO.VisibleIndex = 1
        Me.colNOMBRE_CURSO.Width = 300
        '
        'colCODIGO_CURSO
        '
        Me.colCODIGO_CURSO.Caption = "Codigo Curso"
        Me.colCODIGO_CURSO.FieldName = "CODIGO_CURSO"
        Me.colCODIGO_CURSO.Name = "colCODIGO_CURSO"
        Me.colCODIGO_CURSO.Visible = True
        Me.colCODIGO_CURSO.VisibleIndex = 0
        '
        'tabAnalisis
        '
        Me.tabAnalisis.Controls.Add(Me.PivotGridControl1)
        Me.tabAnalisis.Name = "tabAnalisis"
        Me.tabAnalisis.Size = New System.Drawing.Size(850, 390)
        Me.tabAnalisis.Text = "Analisis"
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.DataMember = "PATIParticipantesActivosYNoActivos"
        Me.PivotGridControl1.DataSource = Me.DS_DL1
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldDEPARTAMENTO1, Me.fieldMUNICIPIO1, Me.fieldNOMBRECURSO1, Me.fieldFECHAINICIO1, Me.fieldFECHAFINALIZACION1, Me.fieldNUMEFICHPATI1, Me.fieldNUMEFAMI1, Me.fieldNOMBRE1, Me.fieldALTA1, Me.fieldBAJA1, Me.fieldINSCRITONOASISTIO1, Me.field, Me.fieldFINALIZOCAPACITACION1, Me.fieldASISTIOCAPACITACION, Me.fieldENTREVISTOINSAFORP, Me.fieldENTREVISTOPROVEEDOR, Me.fieldENTREVISTADO, Me.fieldCODIGOCURSO, Me.fieldCANTSOLICITADAPORALCALDIA, Me.fieldSOLICITOALCALDIA, Me.fieldAsistio})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText
        Me.PivotGridControl1.Size = New System.Drawing.Size(850, 390)
        Me.PivotGridControl1.TabIndex = 2
        '
        'fieldDEPARTAMENTO1
        '
        Me.fieldDEPARTAMENTO1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldDEPARTAMENTO1.AreaIndex = 0
        Me.fieldDEPARTAMENTO1.Caption = "Departamento"
        Me.fieldDEPARTAMENTO1.FieldName = "DEPARTAMENTO"
        Me.fieldDEPARTAMENTO1.Name = "fieldDEPARTAMENTO1"
        '
        'fieldMUNICIPIO1
        '
        Me.fieldMUNICIPIO1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldMUNICIPIO1.AreaIndex = 1
        Me.fieldMUNICIPIO1.Caption = "Municipio"
        Me.fieldMUNICIPIO1.FieldName = "MUNICIPIO"
        Me.fieldMUNICIPIO1.Name = "fieldMUNICIPIO1"
        '
        'fieldNOMBRECURSO1
        '
        Me.fieldNOMBRECURSO1.AreaIndex = 7
        Me.fieldNOMBRECURSO1.Caption = "Nombre Curso"
        Me.fieldNOMBRECURSO1.FieldName = "NOMBRE_CURSO"
        Me.fieldNOMBRECURSO1.Name = "fieldNOMBRECURSO1"
        '
        'fieldFECHAINICIO1
        '
        Me.fieldFECHAINICIO1.AreaIndex = 4
        Me.fieldFECHAINICIO1.Caption = "Inicio"
        Me.fieldFECHAINICIO1.FieldName = "FECHA_INICIO"
        Me.fieldFECHAINICIO1.Name = "fieldFECHAINICIO1"
        '
        'fieldFECHAFINALIZACION1
        '
        Me.fieldFECHAFINALIZACION1.AreaIndex = 5
        Me.fieldFECHAFINALIZACION1.Caption = "Fin"
        Me.fieldFECHAFINALIZACION1.FieldName = "FECHA_FINALIZACION"
        Me.fieldFECHAFINALIZACION1.Name = "fieldFECHAFINALIZACION1"
        '
        'fieldNUMEFICHPATI1
        '
        Me.fieldNUMEFICHPATI1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldNUMEFICHPATI1.AreaIndex = 0
        Me.fieldNUMEFICHPATI1.Caption = "Participantes"
        Me.fieldNUMEFICHPATI1.CellFormat.FormatString = "N0"
        Me.fieldNUMEFICHPATI1.FieldName = "NUME_FICH_PATI"
        Me.fieldNUMEFICHPATI1.GrandTotalCellFormat.FormatString = "N0"
        Me.fieldNUMEFICHPATI1.Name = "fieldNUMEFICHPATI1"
        Me.fieldNUMEFICHPATI1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count
        Me.fieldNUMEFICHPATI1.TotalCellFormat.FormatString = "N0"
        Me.fieldNUMEFICHPATI1.TotalValueFormat.FormatString = "N0"
        Me.fieldNUMEFICHPATI1.ValueFormat.FormatString = "N0"
        '
        'fieldNUMEFAMI1
        '
        Me.fieldNUMEFAMI1.AreaIndex = 0
        Me.fieldNUMEFAMI1.Caption = "No Convenio"
        Me.fieldNUMEFAMI1.FieldName = "NUME_FAMI"
        Me.fieldNUMEFAMI1.Name = "fieldNUMEFAMI1"
        '
        'fieldNOMBRE1
        '
        Me.fieldNOMBRE1.AreaIndex = 1
        Me.fieldNOMBRE1.Caption = "Nombre Completo"
        Me.fieldNOMBRE1.FieldName = "NOMBRE"
        Me.fieldNOMBRE1.Name = "fieldNOMBRE1"
        '
        'fieldALTA1
        '
        Me.fieldALTA1.AreaIndex = 2
        Me.fieldALTA1.Caption = "Alta"
        Me.fieldALTA1.FieldName = "ALTA"
        Me.fieldALTA1.Name = "fieldALTA1"
        Me.fieldALTA1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count
        '
        'fieldBAJA1
        '
        Me.fieldBAJA1.AreaIndex = 3
        Me.fieldBAJA1.Caption = "Baja"
        Me.fieldBAJA1.FieldName = "BAJA"
        Me.fieldBAJA1.Name = "fieldBAJA1"
        Me.fieldBAJA1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count
        '
        'fieldINSCRITONOASISTIO1
        '
        Me.fieldINSCRITONOASISTIO1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldINSCRITONOASISTIO1.AreaIndex = 8
        Me.fieldINSCRITONOASISTIO1.Caption = "Inscrito/No Asistio"
        Me.fieldINSCRITONOASISTIO1.FieldName = "INSCRITO_NO_ASISTIO"
        Me.fieldINSCRITONOASISTIO1.Name = "fieldINSCRITONOASISTIO1"
        Me.fieldINSCRITONOASISTIO1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count
        '
        'field
        '
        Me.field.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.field.AreaIndex = 5
        Me.field.Caption = "Asistio/No Finalizo"
        Me.field.CellFormat.FormatString = "N0"
        Me.field.GrandTotalCellFormat.FormatString = "N0"
        Me.field.Name = "field"
        Me.field.TotalCellFormat.FormatString = "N0"
        Me.field.TotalValueFormat.FormatString = "N0"
        Me.field.UnboundFieldName = "AsistioNoFinalizo"
        Me.field.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.field.ValueFormat.FormatString = "N0"
        '
        'fieldFINALIZOCAPACITACION1
        '
        Me.fieldFINALIZOCAPACITACION1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldFINALIZOCAPACITACION1.AreaIndex = 6
        Me.fieldFINALIZOCAPACITACION1.Caption = "Finalizo-70%/Activo(BM)"
        Me.fieldFINALIZOCAPACITACION1.FieldName = "FINALIZO_CAPACITACION"
        Me.fieldFINALIZOCAPACITACION1.Name = "fieldFINALIZOCAPACITACION1"
        Me.fieldFINALIZOCAPACITACION1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count
        '
        'fieldASISTIOCAPACITACION
        '
        Me.fieldASISTIOCAPACITACION.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldASISTIOCAPACITACION.AreaIndex = 0
        Me.fieldASISTIOCAPACITACION.FieldName = "ASISTIO_CAPACITACION"
        Me.fieldASISTIOCAPACITACION.Name = "fieldASISTIOCAPACITACION"
        Me.fieldASISTIOCAPACITACION.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count
        Me.fieldASISTIOCAPACITACION.Visible = False
        '
        'fieldENTREVISTOINSAFORP
        '
        Me.fieldENTREVISTOINSAFORP.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldENTREVISTOINSAFORP.AreaIndex = 1
        Me.fieldENTREVISTOINSAFORP.Caption = "Entrevisto Insaforp"
        Me.fieldENTREVISTOINSAFORP.CellFormat.FormatString = "N0"
        Me.fieldENTREVISTOINSAFORP.FieldName = "ENTREVISTO_INSAFORP"
        Me.fieldENTREVISTOINSAFORP.GrandTotalCellFormat.FormatString = "N0"
        Me.fieldENTREVISTOINSAFORP.Name = "fieldENTREVISTOINSAFORP"
        Me.fieldENTREVISTOINSAFORP.TotalCellFormat.FormatString = "N0"
        Me.fieldENTREVISTOINSAFORP.TotalValueFormat.FormatString = "N0"
        Me.fieldENTREVISTOINSAFORP.ValueFormat.FormatString = "N0"
        Me.fieldENTREVISTOINSAFORP.Width = 113
        '
        'fieldENTREVISTOPROVEEDOR
        '
        Me.fieldENTREVISTOPROVEEDOR.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldENTREVISTOPROVEEDOR.AreaIndex = 2
        Me.fieldENTREVISTOPROVEEDOR.Caption = "Entrevisto Proveedor"
        Me.fieldENTREVISTOPROVEEDOR.CellFormat.FormatString = "N0"
        Me.fieldENTREVISTOPROVEEDOR.FieldName = "ENTREVISTO_PROVEEDOR"
        Me.fieldENTREVISTOPROVEEDOR.GrandTotalCellFormat.FormatString = "N0"
        Me.fieldENTREVISTOPROVEEDOR.Name = "fieldENTREVISTOPROVEEDOR"
        Me.fieldENTREVISTOPROVEEDOR.TotalCellFormat.FormatString = "N0"
        Me.fieldENTREVISTOPROVEEDOR.TotalValueFormat.FormatString = "N0"
        Me.fieldENTREVISTOPROVEEDOR.ValueFormat.FormatString = "N0"
        Me.fieldENTREVISTOPROVEEDOR.Width = 123
        '
        'fieldENTREVISTADO
        '
        Me.fieldENTREVISTADO.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldENTREVISTADO.AreaIndex = 3
        Me.fieldENTREVISTADO.Caption = "Entrevistado"
        Me.fieldENTREVISTADO.CellFormat.FormatString = "N0"
        Me.fieldENTREVISTADO.GrandTotalCellFormat.FormatString = "N0"
        Me.fieldENTREVISTADO.Name = "fieldENTREVISTADO"
        Me.fieldENTREVISTADO.TotalCellFormat.FormatString = "N0"
        Me.fieldENTREVISTADO.TotalValueFormat.FormatString = "N0"
        Me.fieldENTREVISTADO.UnboundFieldName = "Entrevistado"
        Me.fieldENTREVISTADO.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.fieldENTREVISTADO.ValueFormat.FormatString = "N0"
        '
        'fieldCODIGOCURSO
        '
        Me.fieldCODIGOCURSO.AreaIndex = 6
        Me.fieldCODIGOCURSO.Caption = "Codigo Curso"
        Me.fieldCODIGOCURSO.FieldName = "CODIGO_CURSO"
        Me.fieldCODIGOCURSO.Name = "fieldCODIGOCURSO"
        Me.fieldCODIGOCURSO.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count
        '
        'fieldCANTSOLICITADAPORALCALDIA
        '
        Me.fieldCANTSOLICITADAPORALCALDIA.AreaIndex = 8
        Me.fieldCANTSOLICITADAPORALCALDIA.Caption = "Cant. Solic. Por Alcaldia"
        Me.fieldCANTSOLICITADAPORALCALDIA.FieldName = "CANT_SOLICITADA_POR_ALCALDIA"
        Me.fieldCANTSOLICITADAPORALCALDIA.GrandTotalCellFormat.FormatString = "N0"
        Me.fieldCANTSOLICITADAPORALCALDIA.Name = "fieldCANTSOLICITADAPORALCALDIA"
        Me.fieldCANTSOLICITADAPORALCALDIA.TotalCellFormat.FormatString = "N0"
        Me.fieldCANTSOLICITADAPORALCALDIA.TotalValueFormat.FormatString = "N0"
        Me.fieldCANTSOLICITADAPORALCALDIA.ValueFormat.FormatString = "N0"
        '
        'fieldSOLICITOALCALDIA
        '
        Me.fieldSOLICITOALCALDIA.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldSOLICITOALCALDIA.AreaIndex = 4
        Me.fieldSOLICITOALCALDIA.Caption = "Solicitado por Alcaldia"
        Me.fieldSOLICITOALCALDIA.FieldName = "SOLICITO_ALCALDIA"
        Me.fieldSOLICITOALCALDIA.GrandTotalCellFormat.FormatString = "N0"
        Me.fieldSOLICITOALCALDIA.Name = "fieldSOLICITOALCALDIA"
        Me.fieldSOLICITOALCALDIA.TotalCellFormat.FormatString = "N0"
        Me.fieldSOLICITOALCALDIA.TotalValueFormat.FormatString = "N0"
        Me.fieldSOLICITOALCALDIA.ValueFormat.FormatString = "N0"
        Me.fieldSOLICITOALCALDIA.Width = 120
        '
        'fieldAsistio
        '
        Me.fieldAsistio.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldAsistio.AreaIndex = 7
        Me.fieldAsistio.Caption = "Asistio/(Activo-AID)"
        Me.fieldAsistio.Name = "fieldAsistio"
        Me.fieldAsistio.TotalCellFormat.FormatString = "N0"
        Me.fieldAsistio.TotalValueFormat.FormatString = "N0"
        Me.fieldAsistio.UnboundFieldName = "Asistio"
        Me.fieldAsistio.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        '
        'tabGrafico
        '
        Me.tabGrafico.Controls.Add(Me.txtTituloGrafico)
        Me.tabGrafico.Controls.Add(Me.LabelControl2)
        Me.tabGrafico.Controls.Add(Me.CheckEdit1)
        Me.tabGrafico.Controls.Add(Me.LabelControl1)
        Me.tabGrafico.Controls.Add(Me.ComboBoxEdit1)
        Me.tabGrafico.Controls.Add(Me.ChartControl1)
        Me.tabGrafico.Name = "tabGrafico"
        Me.tabGrafico.Size = New System.Drawing.Size(850, 390)
        Me.tabGrafico.Text = "Grafico"
        '
        'txtTituloGrafico
        '
        Me.txtTituloGrafico.EditValue = "Participantes PATI"
        Me.txtTituloGrafico.Location = New System.Drawing.Point(536, 3)
        Me.txtTituloGrafico.Name = "txtTituloGrafico"
        Me.txtTituloGrafico.Size = New System.Drawing.Size(256, 20)
        Me.txtTituloGrafico.TabIndex = 13
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(461, 6)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl2.TabIndex = 12
        Me.LabelControl2.Text = "Texto Grafico:"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(313, 4)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Invertir Grafico"
        Me.CheckEdit1.Size = New System.Drawing.Size(123, 19)
        Me.CheckEdit1.TabIndex = 11
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(5, 6)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl1.TabIndex = 10
        Me.LabelControl1.Text = "Tipo de Grafico:"
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.EditValue = "Barras tipo Manhatan"
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(87, 3)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"Barras tipo Manhatan", "Barras 3D", "Barras en Pila 3D", "Barras 2D", "Barras en Pila 2D", "Pastel 3D", "Pastel 2D"})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(133, 20)
        Me.ComboBoxEdit1.TabIndex = 9
        '
        'ChartControl1
        '
        Me.ChartControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChartControl1.DataSource = Me.PivotGridControl1
        XyDiagram3D1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram3D1.AxisX.Range.SideMarginsEnabled = True
        XyDiagram3D1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram3D1.AxisY.Range.SideMarginsEnabled = True
        XyDiagram3D1.RotationMatrixSerializable = "0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.34" & _
            "2020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;" & _
            "1"
        XyDiagram3D1.RuntimeRotation = True
        XyDiagram3D1.RuntimeZooming = True
        Me.ChartControl1.Diagram = XyDiagram3D1
        Me.ChartControl1.Legend.MaxHorizontalPercentage = 30
        Me.ChartControl1.Location = New System.Drawing.Point(4, 29)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.PaletteName = "Mixed"
        Me.ChartControl1.SeriesDataMember = "Series"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl1.SeriesSorting = DevExpress.XtraCharts.SortingMode.Ascending
        Me.ChartControl1.SeriesTemplate.ArgumentDataMember = "Arguments"
        Bar3DSeriesLabel1.LineVisible = True
        Bar3DSeriesLabel1.Visible = True
        Me.ChartControl1.SeriesTemplate.Label = Bar3DSeriesLabel1
        Me.ChartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values"
        Me.ChartControl1.SeriesTemplate.View = ManhattanBarSeriesView1
        Me.ChartControl1.Size = New System.Drawing.Size(842, 354)
        Me.ChartControl1.TabIndex = 8
        ChartTitle1.Text = "Participantes PATI"
        Me.ChartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CbxPROGRAMA_FORMACION1
        '
        Me.CbxPROGRAMA_FORMACION1.AllowFindEntityType = Nothing
        Me.CbxPROGRAMA_FORMACION1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxPROGRAMA_FORMACION1.Location = New System.Drawing.Point(80, 12)
        Me.CbxPROGRAMA_FORMACION1.Name = "CbxPROGRAMA_FORMACION1"
        Me.CbxPROGRAMA_FORMACION1.Size = New System.Drawing.Size(764, 21)
        Me.CbxPROGRAMA_FORMACION1.TabIndex = 12
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.CbxPROGRAMA_FORMACION1
        Me.LayoutControlItem3.CustomizationFormText = "Programa"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(836, 25)
        Me.LayoutControlItem3.Text = "Programa"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(64, 13)
        '
        'frmParticipantesActivoYNoActivosPATI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 506)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "frmParticipantesActivoYNoActivosPATI"
        Me.Text = "Participantes Activos y No Activos"
        Me.Controls.SetChildIndex(Me.SplitContainerControl1, 0)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabDetalle.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAnalisis.ResumeLayout(False)
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabGrafico.ResumeLayout(False)
        Me.tabGrafico.PerformLayout()
        CType(Me.txtTituloGrafico.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram3D1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Bar3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(ManhattanBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DS_DL1 As SGAFP.DL.DS_DL
    Friend WithEvents colNUME_FICH_PATI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUME_FAMI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colALTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBAJA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMUNICIPIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPARTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colASISTIO_CAPACITACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFINALIZO_CAPACITACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colINSCRITO_NO_ASISTIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_INICIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_FINALIZACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_CURSO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabDetalle As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabAnalisis As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents tabGrafico As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents fieldDEPARTAMENTO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMUNICIPIO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRECURSO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHAINICIO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHAFINALIZACION1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNUMEFICHPATI1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNUMEFAMI1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRE1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldALTA1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBAJA1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldINSCRITONOASISTIO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents field As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFINALIZOCAPACITACION1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldASISTIOCAPACITACION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents txtTituloGrafico As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents colENTREVISTO_INSAFORP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colENTREVISTO_PROVEEDOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldENTREVISTOINSAFORP As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldENTREVISTOPROVEEDOR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldENTREVISTADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colENTREVISTO_INSAFORP1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_CURSO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldCODIGOCURSO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCANTSOLICITADAPORALCALDIA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSOLICITOALCALDIA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAsistio As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents CbxPROGRAMA_FORMACION1 As SGAFP.WinUC.cbxPROGRAMA_FORMACION
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
End Class
