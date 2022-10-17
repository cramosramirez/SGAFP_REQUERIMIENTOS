<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalisisEjecucionPATI
    Inherits SGAFP.frmBase

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
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
        Me.CbxPROGRAMA_FORMACION1 = New SGAFP.WinUC.cbxPROGRAMA_FORMACION
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.tabDetalle = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.DS_DL1 = New SGAFP.DL.DS_DL
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNO_CONVOCATORIA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_FUENTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_MUNICIPIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_DEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNO_FICHA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNO_CONVENIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPARTICIPANTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_GRUPO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_ACCION_FORMATIVA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSOLICITADO_POR_ALCALDIA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAGREGADO_POR_ALCALDIA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTOTAL_INSCRITOS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSALIDA_A_OTRO_CURSO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colENTRADA_DE_OTRO_CURSO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNO_ASISTIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colINICIO_CAPACITACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNO_TERMINO_CAPACITACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRECIBIO_CAPACITACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHORAS_ASISTIDAS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_INICIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_FIN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_PROVEEDOR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAUP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPROYECTO_LIQUIDACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tabAnalisis = New DevExpress.XtraTab.XtraTabPage
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.fieldNOASISTIO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldNOTERMINOCAPACITACION = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldINICIOCAPACITACION = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldENTRADADEOTROCURSO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldRECIBIOCAPACITACION = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSALIDAAOTROCURSO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSOLICITADOPORALCALDIA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldTOTALINSCRITOS = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldPARTICIPANTE = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldNOMBREMUNICIPIO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldNOMBREFUENTE = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldNOMBREDEPARTAMENTO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldNOMBREACCIONFORMATIVA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldNOFICHA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldNOCONVOCATORIA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldNOCONVENIO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldAGREGADOPORALCALDIA = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldCODIGOGRUPO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldHORASASISTIDAS = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFECHAINICIO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFECHAFIN = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldESTADO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldNOMBREPROVEEDOR = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldAUP = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldPROYECTOLIQUIDACION = New DevExpress.XtraPivotGrid.PivotGridField
        Me.tabGrafico = New DevExpress.XtraTab.XtraTabPage
        Me.txtTituloGrafico = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl
        Me.PatI_ANALISIS_EJECUCIONTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.PATI_ANALISIS_EJECUCIONTableAdapter
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainerControl1.Size = New System.Drawing.Size(752, 500)
        Me.SplitContainerControl1.SplitterPosition = 85
        Me.SplitContainerControl1.TabIndex = 5
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
        Me.LayoutControl1.Size = New System.Drawing.Size(752, 85)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'CbxPROGRAMA_FORMACION1
        '
        Me.CbxPROGRAMA_FORMACION1.AllowFindEntityType = Nothing
        Me.CbxPROGRAMA_FORMACION1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxPROGRAMA_FORMACION1.Location = New System.Drawing.Point(80, 12)
        Me.CbxPROGRAMA_FORMACION1.Name = "CbxPROGRAMA_FORMACION1"
        Me.CbxPROGRAMA_FORMACION1.Size = New System.Drawing.Size(660, 21)
        Me.CbxPROGRAMA_FORMACION1.TabIndex = 12
        '
        'SpinEdit1
        '
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit1.Location = New System.Drawing.Point(80, 37)
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEdit1.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.SpinEdit1.Size = New System.Drawing.Size(660, 20)
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
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(752, 85)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SpinEdit1
        Me.LayoutControlItem2.CustomizationFormText = "Convocatoria"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 25)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(732, 40)
        Me.LayoutControlItem2.Text = "Convocatoria"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(64, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.CbxPROGRAMA_FORMACION1
        Me.LayoutControlItem3.CustomizationFormText = "Programa"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(732, 25)
        Me.LayoutControlItem3.Text = "Programa"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(64, 13)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabDetalle
        Me.XtraTabControl1.Size = New System.Drawing.Size(752, 410)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabDetalle, Me.tabAnalisis, Me.tabGrafico})
        '
        'tabDetalle
        '
        Me.tabDetalle.Controls.Add(Me.GridControl1)
        Me.tabDetalle.Name = "tabDetalle"
        Me.tabDetalle.Size = New System.Drawing.Size(746, 384)
        Me.tabDetalle.Text = "Detalle"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "PATI_ANALISIS_EJECUCION"
        Me.GridControl1.DataSource = Me.DS_DL1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(746, 384)
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNO_CONVOCATORIA, Me.colNOMBRE_FUENTE, Me.colNOMBRE_MUNICIPIO, Me.colNOMBRE_DEPARTAMENTO, Me.colNO_FICHA, Me.colNO_CONVENIO, Me.colPARTICIPANTE, Me.colCODIGO_GRUPO, Me.colNOMBRE_ACCION_FORMATIVA, Me.colSOLICITADO_POR_ALCALDIA, Me.colAGREGADO_POR_ALCALDIA, Me.colTOTAL_INSCRITOS, Me.colSALIDA_A_OTRO_CURSO, Me.colENTRADA_DE_OTRO_CURSO, Me.colNO_ASISTIO, Me.colINICIO_CAPACITACION, Me.colNO_TERMINO_CAPACITACION, Me.colRECIBIO_CAPACITACION, Me.colHORAS_ASISTIDAS, Me.colFECHA_INICIO, Me.colFECHA_FIN, Me.colESTADO, Me.colNOMBRE_PROVEEDOR, Me.colAUP, Me.colPROYECTO_LIQUIDACION})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "NUME_FICH_PATI", Nothing, "Participantes ({0})")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        '
        'colNO_CONVOCATORIA
        '
        Me.colNO_CONVOCATORIA.DisplayFormat.FormatString = "N0"
        Me.colNO_CONVOCATORIA.FieldName = "NO_CONVOCATORIA"
        Me.colNO_CONVOCATORIA.GroupFormat.FormatString = "N0"
        Me.colNO_CONVOCATORIA.Name = "colNO_CONVOCATORIA"
        Me.colNO_CONVOCATORIA.Visible = True
        Me.colNO_CONVOCATORIA.VisibleIndex = 0
        '
        'colNOMBRE_FUENTE
        '
        Me.colNOMBRE_FUENTE.FieldName = "NOMBRE_FUENTE"
        Me.colNOMBRE_FUENTE.Name = "colNOMBRE_FUENTE"
        Me.colNOMBRE_FUENTE.Visible = True
        Me.colNOMBRE_FUENTE.VisibleIndex = 1
        '
        'colNOMBRE_MUNICIPIO
        '
        Me.colNOMBRE_MUNICIPIO.FieldName = "NOMBRE_MUNICIPIO"
        Me.colNOMBRE_MUNICIPIO.Name = "colNOMBRE_MUNICIPIO"
        Me.colNOMBRE_MUNICIPIO.Visible = True
        Me.colNOMBRE_MUNICIPIO.VisibleIndex = 2
        '
        'colNOMBRE_DEPARTAMENTO
        '
        Me.colNOMBRE_DEPARTAMENTO.FieldName = "NOMBRE_DEPARTAMENTO"
        Me.colNOMBRE_DEPARTAMENTO.Name = "colNOMBRE_DEPARTAMENTO"
        Me.colNOMBRE_DEPARTAMENTO.Visible = True
        Me.colNOMBRE_DEPARTAMENTO.VisibleIndex = 3
        '
        'colNO_FICHA
        '
        Me.colNO_FICHA.DisplayFormat.FormatString = "N0"
        Me.colNO_FICHA.FieldName = "NO_FICHA"
        Me.colNO_FICHA.GroupFormat.FormatString = "N0"
        Me.colNO_FICHA.Name = "colNO_FICHA"
        Me.colNO_FICHA.Visible = True
        Me.colNO_FICHA.VisibleIndex = 4
        '
        'colNO_CONVENIO
        '
        Me.colNO_CONVENIO.DisplayFormat.FormatString = "N0"
        Me.colNO_CONVENIO.FieldName = "NO_CONVENIO"
        Me.colNO_CONVENIO.GroupFormat.FormatString = "N0"
        Me.colNO_CONVENIO.Name = "colNO_CONVENIO"
        Me.colNO_CONVENIO.Visible = True
        Me.colNO_CONVENIO.VisibleIndex = 5
        '
        'colPARTICIPANTE
        '
        Me.colPARTICIPANTE.FieldName = "PARTICIPANTE"
        Me.colPARTICIPANTE.Name = "colPARTICIPANTE"
        Me.colPARTICIPANTE.Visible = True
        Me.colPARTICIPANTE.VisibleIndex = 6
        '
        'colCODIGO_GRUPO
        '
        Me.colCODIGO_GRUPO.FieldName = "CODIGO_GRUPO"
        Me.colCODIGO_GRUPO.Name = "colCODIGO_GRUPO"
        Me.colCODIGO_GRUPO.Visible = True
        Me.colCODIGO_GRUPO.VisibleIndex = 7
        '
        'colNOMBRE_ACCION_FORMATIVA
        '
        Me.colNOMBRE_ACCION_FORMATIVA.FieldName = "NOMBRE_ACCION_FORMATIVA"
        Me.colNOMBRE_ACCION_FORMATIVA.Name = "colNOMBRE_ACCION_FORMATIVA"
        Me.colNOMBRE_ACCION_FORMATIVA.Visible = True
        Me.colNOMBRE_ACCION_FORMATIVA.VisibleIndex = 8
        '
        'colSOLICITADO_POR_ALCALDIA
        '
        Me.colSOLICITADO_POR_ALCALDIA.DisplayFormat.FormatString = "N0"
        Me.colSOLICITADO_POR_ALCALDIA.FieldName = "SOLICITADO_POR_ALCALDIA"
        Me.colSOLICITADO_POR_ALCALDIA.GroupFormat.FormatString = "N0"
        Me.colSOLICITADO_POR_ALCALDIA.Name = "colSOLICITADO_POR_ALCALDIA"
        Me.colSOLICITADO_POR_ALCALDIA.Visible = True
        Me.colSOLICITADO_POR_ALCALDIA.VisibleIndex = 9
        '
        'colAGREGADO_POR_ALCALDIA
        '
        Me.colAGREGADO_POR_ALCALDIA.DisplayFormat.FormatString = "N0"
        Me.colAGREGADO_POR_ALCALDIA.FieldName = "AGREGADO_POR_ALCALDIA"
        Me.colAGREGADO_POR_ALCALDIA.GroupFormat.FormatString = "N0"
        Me.colAGREGADO_POR_ALCALDIA.Name = "colAGREGADO_POR_ALCALDIA"
        Me.colAGREGADO_POR_ALCALDIA.Visible = True
        Me.colAGREGADO_POR_ALCALDIA.VisibleIndex = 10
        '
        'colTOTAL_INSCRITOS
        '
        Me.colTOTAL_INSCRITOS.DisplayFormat.FormatString = "N0"
        Me.colTOTAL_INSCRITOS.FieldName = "TOTAL_INSCRITOS"
        Me.colTOTAL_INSCRITOS.GroupFormat.FormatString = "N0"
        Me.colTOTAL_INSCRITOS.Name = "colTOTAL_INSCRITOS"
        Me.colTOTAL_INSCRITOS.Visible = True
        Me.colTOTAL_INSCRITOS.VisibleIndex = 11
        '
        'colSALIDA_A_OTRO_CURSO
        '
        Me.colSALIDA_A_OTRO_CURSO.DisplayFormat.FormatString = "N0"
        Me.colSALIDA_A_OTRO_CURSO.FieldName = "SALIDA_A_OTRO_CURSO"
        Me.colSALIDA_A_OTRO_CURSO.GroupFormat.FormatString = "N0"
        Me.colSALIDA_A_OTRO_CURSO.Name = "colSALIDA_A_OTRO_CURSO"
        Me.colSALIDA_A_OTRO_CURSO.Visible = True
        Me.colSALIDA_A_OTRO_CURSO.VisibleIndex = 12
        '
        'colENTRADA_DE_OTRO_CURSO
        '
        Me.colENTRADA_DE_OTRO_CURSO.DisplayFormat.FormatString = "N0"
        Me.colENTRADA_DE_OTRO_CURSO.FieldName = "ENTRADA_DE_OTRO_CURSO"
        Me.colENTRADA_DE_OTRO_CURSO.GroupFormat.FormatString = "N0"
        Me.colENTRADA_DE_OTRO_CURSO.Name = "colENTRADA_DE_OTRO_CURSO"
        Me.colENTRADA_DE_OTRO_CURSO.Visible = True
        Me.colENTRADA_DE_OTRO_CURSO.VisibleIndex = 13
        '
        'colNO_ASISTIO
        '
        Me.colNO_ASISTIO.DisplayFormat.FormatString = "N0"
        Me.colNO_ASISTIO.FieldName = "NO_ASISTIO"
        Me.colNO_ASISTIO.GroupFormat.FormatString = "N0"
        Me.colNO_ASISTIO.Name = "colNO_ASISTIO"
        Me.colNO_ASISTIO.Visible = True
        Me.colNO_ASISTIO.VisibleIndex = 14
        '
        'colINICIO_CAPACITACION
        '
        Me.colINICIO_CAPACITACION.DisplayFormat.FormatString = "N0"
        Me.colINICIO_CAPACITACION.FieldName = "INICIO_CAPACITACION"
        Me.colINICIO_CAPACITACION.GroupFormat.FormatString = "N0"
        Me.colINICIO_CAPACITACION.Name = "colINICIO_CAPACITACION"
        Me.colINICIO_CAPACITACION.Visible = True
        Me.colINICIO_CAPACITACION.VisibleIndex = 15
        '
        'colNO_TERMINO_CAPACITACION
        '
        Me.colNO_TERMINO_CAPACITACION.DisplayFormat.FormatString = "N0"
        Me.colNO_TERMINO_CAPACITACION.FieldName = "NO_TERMINO_CAPACITACION"
        Me.colNO_TERMINO_CAPACITACION.GroupFormat.FormatString = "N0"
        Me.colNO_TERMINO_CAPACITACION.Name = "colNO_TERMINO_CAPACITACION"
        Me.colNO_TERMINO_CAPACITACION.Visible = True
        Me.colNO_TERMINO_CAPACITACION.VisibleIndex = 16
        '
        'colRECIBIO_CAPACITACION
        '
        Me.colRECIBIO_CAPACITACION.DisplayFormat.FormatString = "N0"
        Me.colRECIBIO_CAPACITACION.FieldName = "RECIBIO_CAPACITACION"
        Me.colRECIBIO_CAPACITACION.GroupFormat.FormatString = "N0"
        Me.colRECIBIO_CAPACITACION.Name = "colRECIBIO_CAPACITACION"
        Me.colRECIBIO_CAPACITACION.Visible = True
        Me.colRECIBIO_CAPACITACION.VisibleIndex = 17
        '
        'colHORAS_ASISTIDAS
        '
        Me.colHORAS_ASISTIDAS.DisplayFormat.FormatString = "N0"
        Me.colHORAS_ASISTIDAS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colHORAS_ASISTIDAS.FieldName = "HORAS_ASISTIDAS"
        Me.colHORAS_ASISTIDAS.GroupFormat.FormatString = "N0"
        Me.colHORAS_ASISTIDAS.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colHORAS_ASISTIDAS.Name = "colHORAS_ASISTIDAS"
        Me.colHORAS_ASISTIDAS.Visible = True
        Me.colHORAS_ASISTIDAS.VisibleIndex = 18
        '
        'colFECHA_INICIO
        '
        Me.colFECHA_INICIO.FieldName = "FECHA_INICIO"
        Me.colFECHA_INICIO.Name = "colFECHA_INICIO"
        Me.colFECHA_INICIO.Visible = True
        Me.colFECHA_INICIO.VisibleIndex = 20
        '
        'colFECHA_FIN
        '
        Me.colFECHA_FIN.FieldName = "FECHA_FIN"
        Me.colFECHA_FIN.Name = "colFECHA_FIN"
        Me.colFECHA_FIN.Visible = True
        Me.colFECHA_FIN.VisibleIndex = 19
        '
        'colESTADO
        '
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.Visible = True
        Me.colESTADO.VisibleIndex = 21
        '
        'colNOMBRE_PROVEEDOR
        '
        Me.colNOMBRE_PROVEEDOR.FieldName = "NOMBRE_PROVEEDOR"
        Me.colNOMBRE_PROVEEDOR.Name = "colNOMBRE_PROVEEDOR"
        Me.colNOMBRE_PROVEEDOR.Visible = True
        Me.colNOMBRE_PROVEEDOR.VisibleIndex = 22
        '
        'colAUP
        '
        Me.colAUP.FieldName = "AUP"
        Me.colAUP.Name = "colAUP"
        Me.colAUP.Visible = True
        Me.colAUP.VisibleIndex = 23
        '
        'colPROYECTO_LIQUIDACION
        '
        Me.colPROYECTO_LIQUIDACION.FieldName = "PROYECTO_LIQUIDACION"
        Me.colPROYECTO_LIQUIDACION.Name = "colPROYECTO_LIQUIDACION"
        Me.colPROYECTO_LIQUIDACION.Visible = True
        Me.colPROYECTO_LIQUIDACION.VisibleIndex = 24
        '
        'tabAnalisis
        '
        Me.tabAnalisis.Controls.Add(Me.PivotGridControl1)
        Me.tabAnalisis.Name = "tabAnalisis"
        Me.tabAnalisis.Size = New System.Drawing.Size(746, 384)
        Me.tabAnalisis.Text = "Analisis"
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.DataMember = "PATI_ANALISIS_EJECUCION"
        Me.PivotGridControl1.DataSource = Me.DS_DL1
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldNOASISTIO, Me.fieldNOTERMINOCAPACITACION, Me.fieldINICIOCAPACITACION, Me.fieldENTRADADEOTROCURSO, Me.fieldRECIBIOCAPACITACION, Me.fieldSALIDAAOTROCURSO, Me.fieldSOLICITADOPORALCALDIA, Me.fieldTOTALINSCRITOS, Me.fieldPARTICIPANTE, Me.fieldNOMBREMUNICIPIO, Me.fieldNOMBREFUENTE, Me.fieldNOMBREDEPARTAMENTO, Me.fieldNOMBREACCIONFORMATIVA, Me.fieldNOFICHA, Me.fieldNOCONVOCATORIA, Me.fieldNOCONVENIO, Me.fieldAGREGADOPORALCALDIA, Me.fieldCODIGOGRUPO, Me.fieldHORASASISTIDAS, Me.fieldFECHAINICIO, Me.fieldFECHAFIN, Me.fieldESTADO, Me.fieldNOMBREPROVEEDOR, Me.fieldAUP, Me.fieldPROYECTOLIQUIDACION})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText
        Me.PivotGridControl1.Size = New System.Drawing.Size(746, 384)
        Me.PivotGridControl1.TabIndex = 2
        '
        'fieldNOASISTIO
        '
        Me.fieldNOASISTIO.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldNOASISTIO.AreaIndex = 5
        Me.fieldNOASISTIO.CellFormat.FormatString = "N0"
        Me.fieldNOASISTIO.FieldName = "NO_ASISTIO"
        Me.fieldNOASISTIO.GrandTotalCellFormat.FormatString = "N0"
        Me.fieldNOASISTIO.Name = "fieldNOASISTIO"
        Me.fieldNOASISTIO.TotalCellFormat.FormatString = "N0"
        Me.fieldNOASISTIO.TotalValueFormat.FormatString = "N0"
        Me.fieldNOASISTIO.ValueFormat.FormatString = "N0"
        '
        'fieldNOTERMINOCAPACITACION
        '
        Me.fieldNOTERMINOCAPACITACION.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldNOTERMINOCAPACITACION.AreaIndex = 7
        Me.fieldNOTERMINOCAPACITACION.CellFormat.FormatString = "N0"
        Me.fieldNOTERMINOCAPACITACION.FieldName = "NO_TERMINO_CAPACITACION"
        Me.fieldNOTERMINOCAPACITACION.GrandTotalCellFormat.FormatString = "N0"
        Me.fieldNOTERMINOCAPACITACION.Name = "fieldNOTERMINOCAPACITACION"
        Me.fieldNOTERMINOCAPACITACION.TotalCellFormat.FormatString = "N0"
        Me.fieldNOTERMINOCAPACITACION.TotalValueFormat.FormatString = "N0"
        Me.fieldNOTERMINOCAPACITACION.ValueFormat.FormatString = "N0"
        '
        'fieldINICIOCAPACITACION
        '
        Me.fieldINICIOCAPACITACION.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldINICIOCAPACITACION.AreaIndex = 6
        Me.fieldINICIOCAPACITACION.CellFormat.FormatString = "N0"
        Me.fieldINICIOCAPACITACION.FieldName = "INICIO_CAPACITACION"
        Me.fieldINICIOCAPACITACION.GrandTotalCellFormat.FormatString = "N0"
        Me.fieldINICIOCAPACITACION.Name = "fieldINICIOCAPACITACION"
        Me.fieldINICIOCAPACITACION.TotalCellFormat.FormatString = "N0"
        Me.fieldINICIOCAPACITACION.TotalValueFormat.FormatString = "N0"
        Me.fieldINICIOCAPACITACION.ValueFormat.FormatString = "N0"
        '
        'fieldENTRADADEOTROCURSO
        '
        Me.fieldENTRADADEOTROCURSO.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldENTRADADEOTROCURSO.AreaIndex = 4
        Me.fieldENTRADADEOTROCURSO.CellFormat.FormatString = "N0"
        Me.fieldENTRADADEOTROCURSO.FieldName = "ENTRADA_DE_OTRO_CURSO"
        Me.fieldENTRADADEOTROCURSO.GrandTotalCellFormat.FormatString = "N0"
        Me.fieldENTRADADEOTROCURSO.Name = "fieldENTRADADEOTROCURSO"
        Me.fieldENTRADADEOTROCURSO.TotalCellFormat.FormatString = "N0"
        Me.fieldENTRADADEOTROCURSO.TotalValueFormat.FormatString = "N0"
        Me.fieldENTRADADEOTROCURSO.ValueFormat.FormatString = "N0"
        '
        'fieldRECIBIOCAPACITACION
        '
        Me.fieldRECIBIOCAPACITACION.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldRECIBIOCAPACITACION.AreaIndex = 8
        Me.fieldRECIBIOCAPACITACION.CellFormat.FormatString = "N0"
        Me.fieldRECIBIOCAPACITACION.FieldName = "RECIBIO_CAPACITACION"
        Me.fieldRECIBIOCAPACITACION.GrandTotalCellFormat.FormatString = "N0"
        Me.fieldRECIBIOCAPACITACION.Name = "fieldRECIBIOCAPACITACION"
        Me.fieldRECIBIOCAPACITACION.TotalCellFormat.FormatString = "N0"
        Me.fieldRECIBIOCAPACITACION.TotalValueFormat.FormatString = "N0"
        Me.fieldRECIBIOCAPACITACION.ValueFormat.FormatString = "N0"
        '
        'fieldSALIDAAOTROCURSO
        '
        Me.fieldSALIDAAOTROCURSO.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldSALIDAAOTROCURSO.AreaIndex = 3
        Me.fieldSALIDAAOTROCURSO.CellFormat.FormatString = "N0"
        Me.fieldSALIDAAOTROCURSO.FieldName = "SALIDA_A_OTRO_CURSO"
        Me.fieldSALIDAAOTROCURSO.GrandTotalCellFormat.FormatString = "N0"
        Me.fieldSALIDAAOTROCURSO.Name = "fieldSALIDAAOTROCURSO"
        Me.fieldSALIDAAOTROCURSO.TotalCellFormat.FormatString = "N0"
        Me.fieldSALIDAAOTROCURSO.TotalValueFormat.FormatString = "N0"
        Me.fieldSALIDAAOTROCURSO.ValueFormat.FormatString = "N0"
        '
        'fieldSOLICITADOPORALCALDIA
        '
        Me.fieldSOLICITADOPORALCALDIA.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldSOLICITADOPORALCALDIA.AreaIndex = 0
        Me.fieldSOLICITADOPORALCALDIA.CellFormat.FormatString = "N0"
        Me.fieldSOLICITADOPORALCALDIA.FieldName = "SOLICITADO_POR_ALCALDIA"
        Me.fieldSOLICITADOPORALCALDIA.GrandTotalCellFormat.FormatString = "N0"
        Me.fieldSOLICITADOPORALCALDIA.Name = "fieldSOLICITADOPORALCALDIA"
        Me.fieldSOLICITADOPORALCALDIA.TotalCellFormat.FormatString = "N0"
        Me.fieldSOLICITADOPORALCALDIA.TotalValueFormat.FormatString = "N0"
        Me.fieldSOLICITADOPORALCALDIA.ValueFormat.FormatString = "N0"
        '
        'fieldTOTALINSCRITOS
        '
        Me.fieldTOTALINSCRITOS.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldTOTALINSCRITOS.AreaIndex = 2
        Me.fieldTOTALINSCRITOS.CellFormat.FormatString = "N0"
        Me.fieldTOTALINSCRITOS.FieldName = "TOTAL_INSCRITOS"
        Me.fieldTOTALINSCRITOS.GrandTotalCellFormat.FormatString = "N0"
        Me.fieldTOTALINSCRITOS.Name = "fieldTOTALINSCRITOS"
        Me.fieldTOTALINSCRITOS.TotalCellFormat.FormatString = "N0"
        Me.fieldTOTALINSCRITOS.TotalValueFormat.FormatString = "N0"
        Me.fieldTOTALINSCRITOS.ValueFormat.FormatString = "N0"
        '
        'fieldPARTICIPANTE
        '
        Me.fieldPARTICIPANTE.AreaIndex = 2
        Me.fieldPARTICIPANTE.FieldName = "PARTICIPANTE"
        Me.fieldPARTICIPANTE.Name = "fieldPARTICIPANTE"
        '
        'fieldNOMBREMUNICIPIO
        '
        Me.fieldNOMBREMUNICIPIO.AreaIndex = 3
        Me.fieldNOMBREMUNICIPIO.FieldName = "NOMBRE_MUNICIPIO"
        Me.fieldNOMBREMUNICIPIO.Name = "fieldNOMBREMUNICIPIO"
        '
        'fieldNOMBREFUENTE
        '
        Me.fieldNOMBREFUENTE.AreaIndex = 7
        Me.fieldNOMBREFUENTE.FieldName = "NOMBRE_FUENTE"
        Me.fieldNOMBREFUENTE.Name = "fieldNOMBREFUENTE"
        '
        'fieldNOMBREDEPARTAMENTO
        '
        Me.fieldNOMBREDEPARTAMENTO.AreaIndex = 4
        Me.fieldNOMBREDEPARTAMENTO.FieldName = "NOMBRE_DEPARTAMENTO"
        Me.fieldNOMBREDEPARTAMENTO.Name = "fieldNOMBREDEPARTAMENTO"
        '
        'fieldNOMBREACCIONFORMATIVA
        '
        Me.fieldNOMBREACCIONFORMATIVA.AreaIndex = 6
        Me.fieldNOMBREACCIONFORMATIVA.FieldName = "NOMBRE_ACCION_FORMATIVA"
        Me.fieldNOMBREACCIONFORMATIVA.Name = "fieldNOMBREACCIONFORMATIVA"
        '
        'fieldNOFICHA
        '
        Me.fieldNOFICHA.AreaIndex = 0
        Me.fieldNOFICHA.FieldName = "NO_FICHA"
        Me.fieldNOFICHA.Name = "fieldNOFICHA"
        '
        'fieldNOCONVOCATORIA
        '
        Me.fieldNOCONVOCATORIA.AreaIndex = 8
        Me.fieldNOCONVOCATORIA.FieldName = "NO_CONVOCATORIA"
        Me.fieldNOCONVOCATORIA.Name = "fieldNOCONVOCATORIA"
        '
        'fieldNOCONVENIO
        '
        Me.fieldNOCONVENIO.AreaIndex = 1
        Me.fieldNOCONVENIO.FieldName = "NO_CONVENIO"
        Me.fieldNOCONVENIO.Name = "fieldNOCONVENIO"
        '
        'fieldAGREGADOPORALCALDIA
        '
        Me.fieldAGREGADOPORALCALDIA.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldAGREGADOPORALCALDIA.AreaIndex = 1
        Me.fieldAGREGADOPORALCALDIA.CellFormat.FormatString = "N0"
        Me.fieldAGREGADOPORALCALDIA.FieldName = "AGREGADO_POR_ALCALDIA"
        Me.fieldAGREGADOPORALCALDIA.GrandTotalCellFormat.FormatString = "N0"
        Me.fieldAGREGADOPORALCALDIA.Name = "fieldAGREGADOPORALCALDIA"
        Me.fieldAGREGADOPORALCALDIA.TotalCellFormat.FormatString = "N0"
        Me.fieldAGREGADOPORALCALDIA.TotalValueFormat.FormatString = "N0"
        Me.fieldAGREGADOPORALCALDIA.ValueFormat.FormatString = "N0"
        '
        'fieldCODIGOGRUPO
        '
        Me.fieldCODIGOGRUPO.AreaIndex = 5
        Me.fieldCODIGOGRUPO.FieldName = "CODIGO_GRUPO"
        Me.fieldCODIGOGRUPO.Name = "fieldCODIGOGRUPO"
        '
        'fieldHORASASISTIDAS
        '
        Me.fieldHORASASISTIDAS.AreaIndex = 9
        Me.fieldHORASASISTIDAS.CellFormat.FormatString = "N0"
        Me.fieldHORASASISTIDAS.FieldName = "HORAS_ASISTIDAS"
        Me.fieldHORASASISTIDAS.GrandTotalCellFormat.FormatString = "N0"
        Me.fieldHORASASISTIDAS.Name = "fieldHORASASISTIDAS"
        Me.fieldHORASASISTIDAS.TotalCellFormat.FormatString = "N0"
        Me.fieldHORASASISTIDAS.TotalValueFormat.FormatString = "N0"
        Me.fieldHORASASISTIDAS.ValueFormat.FormatString = "N0"
        '
        'fieldFECHAINICIO
        '
        Me.fieldFECHAINICIO.AreaIndex = 10
        Me.fieldFECHAINICIO.FieldName = "FECHA_INICIO"
        Me.fieldFECHAINICIO.Name = "fieldFECHAINICIO"
        '
        'fieldFECHAFIN
        '
        Me.fieldFECHAFIN.AreaIndex = 11
        Me.fieldFECHAFIN.FieldName = "FECHA_FIN"
        Me.fieldFECHAFIN.Name = "fieldFECHAFIN"
        '
        'fieldESTADO
        '
        Me.fieldESTADO.AreaIndex = 12
        Me.fieldESTADO.FieldName = "ESTADO"
        Me.fieldESTADO.Name = "fieldESTADO"
        '
        'fieldNOMBREPROVEEDOR
        '
        Me.fieldNOMBREPROVEEDOR.AreaIndex = 13
        Me.fieldNOMBREPROVEEDOR.FieldName = "NOMBRE_PROVEEDOR"
        Me.fieldNOMBREPROVEEDOR.Name = "fieldNOMBREPROVEEDOR"
        '
        'fieldAUP
        '
        Me.fieldAUP.AreaIndex = 14
        Me.fieldAUP.FieldName = "AUP"
        Me.fieldAUP.Name = "fieldAUP"
        '
        'fieldPROYECTOLIQUIDACION
        '
        Me.fieldPROYECTOLIQUIDACION.AreaIndex = 15
        Me.fieldPROYECTOLIQUIDACION.FieldName = "PROYECTO_LIQUIDACION"
        Me.fieldPROYECTOLIQUIDACION.Name = "fieldPROYECTOLIQUIDACION"
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
        Me.tabGrafico.Size = New System.Drawing.Size(746, 384)
        Me.tabGrafico.Text = "Grafico"
        '
        'txtTituloGrafico
        '
        Me.txtTituloGrafico.EditValue = "Analisis Ejecucion PATI"
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
        Me.ChartControl1.DataAdapter = Me.PatI_ANALISIS_EJECUCIONTableAdapter1
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
        Bar3DSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.[Default]
        Bar3DSeriesLabel1.Visible = True
        Me.ChartControl1.SeriesTemplate.Label = Bar3DSeriesLabel1
        Me.ChartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values"
        Me.ChartControl1.SeriesTemplate.View = ManhattanBarSeriesView1
        Me.ChartControl1.Size = New System.Drawing.Size(738, 348)
        Me.ChartControl1.TabIndex = 8
        ChartTitle1.Text = "Participantes PATI"
        Me.ChartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'PatI_ANALISIS_EJECUCIONTableAdapter1
        '
        Me.PatI_ANALISIS_EJECUCIONTableAdapter1.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmAnalisisEjecucionPATI
        '
        Me.ClientSize = New System.Drawing.Size(752, 500)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "frmAnalisisEjecucionPATI"
        Me.Text = "Analisis Ejecución PATI"
        Me.Controls.SetChildIndex(Me.SplitContainerControl1, 0)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabDetalle As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tabAnalisis As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents tabGrafico As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtTituloGrafico As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DS_DL1 As SGAFP.DL.DS_DL
    Friend WithEvents colNO_CONVOCATORIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_FUENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_MUNICIPIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_DEPARTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNO_FICHA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNO_CONVENIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPARTICIPANTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_GRUPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_ACCION_FORMATIVA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSOLICITADO_POR_ALCALDIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAGREGADO_POR_ALCALDIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTOTAL_INSCRITOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSALIDA_A_OTRO_CURSO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colENTRADA_DE_OTRO_CURSO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNO_ASISTIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colINICIO_CAPACITACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNO_TERMINO_CAPACITACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRECIBIO_CAPACITACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldNOASISTIO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOTERMINOCAPACITACION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldINICIOCAPACITACION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldENTRADADEOTROCURSO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRECIBIOCAPACITACION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSALIDAAOTROCURSO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSOLICITADOPORALCALDIA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTOTALINSCRITOS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPARTICIPANTE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBREMUNICIPIO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBREFUENTE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBREDEPARTAMENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBREACCIONFORMATIVA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOFICHA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOCONVOCATORIA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOCONVENIO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAGREGADOPORALCALDIA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PatI_ANALISIS_EJECUCIONTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.PATI_ANALISIS_EJECUCIONTableAdapter
    Friend WithEvents fieldCODIGOGRUPO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colHORAS_ASISTIDAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldHORASASISTIDAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colFECHA_INICIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_FIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldFECHAINICIO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHAFIN As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldESTADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colNOMBRE_PROVEEDOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldNOMBREPROVEEDOR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colAUP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPROYECTO_LIQUIDACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldAUP As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPROYECTOLIQUIDACION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents CbxPROGRAMA_FORMACION1 As SGAFP.WinUC.cbxPROGRAMA_FORMACION
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
End Class
