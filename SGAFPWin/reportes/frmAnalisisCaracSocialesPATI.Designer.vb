<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalisisCaracSocialesPATI
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
        Dim PivotGridGroup1 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
        Dim XyDiagram3D1 As DevExpress.XtraCharts.XYDiagram3D = New DevExpress.XtraCharts.XYDiagram3D()
        Dim Bar3DSeriesLabel1 As DevExpress.XtraCharts.Bar3DSeriesLabel = New DevExpress.XtraCharts.Bar3DSeriesLabel()
        Dim ManhattanBarSeriesView1 As DevExpress.XtraCharts.ManhattanBarSeriesView = New DevExpress.XtraCharts.ManhattanBarSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.fieldHABLAR = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMOVERSEOCAMINAR = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldOIRAUNUSANDOAPAESP = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldOTRALIMITACIONPERMANENTE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTIENEALGUNRETRASO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldUSARSUSBRAZOSOMANOS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldVERAUNUSANDOLENTES = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldVESTIRALIMENTARPORSIMISMO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtNUM_LICITACION = New DevExpress.XtraEditors.TextEdit()
        Me.dteFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dteFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.CbxPROGRAMA_FORMACION1 = New SGAFP.WinUC.cbxPROGRAMA_FORMACION()
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lytConvocatoria = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lytFechaInicial = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lytFechaFinal = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lytLicitacion = New DevExpress.XtraLayout.LayoutControlItem()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabDetalle = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.DS_DL1 = New SGAFP.DL.DS_DL()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNO_CONVOCATORIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE_FUENTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE_MUNICIPIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE_DEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCON_DISCAPACIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCODIGO_GRUPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCURSO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colES_JEFE_DE_HOGAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXP_OBTENER_EMPLEO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXP_TRABAJO_PROPIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXP_OTRA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXP_UBICACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHABLAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHIJOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID_FUENTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMOVERSE_O_CAMINAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNIVEL_ACADEMICO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOCUPACION_BUSCA_TRABAJO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOCUPACION_ESTUDIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOCUPACION_OFICIOS_HOGAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOCUPACION_OTRA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOIR_AUN_USANDO_APA_ESP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOTRA_LIMITACION_PERMANENTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRANGO_EDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRANGO_EDAD2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRANGO_NIVEL_ACAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSEXO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIENE_ALGUN_RETRASO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSAR_SUS_BRAZOS_O_MANOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVER_AUN_USANDO_LENTES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVESTIR_ALIMENTAR_POR_SI_MISMO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLEE_ESCRIBE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRangoEdad3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_INICIO_REAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_FIN_REAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAREA_FORMATIVA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabAnalisis = New DevExpress.XtraTab.XtraTabPage()
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.fieldNOMBREMUNICIPIO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBREFUENTE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBREDEPARTAMENTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOCONVOCATORIA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCURSO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCONDISCAPACIDAD = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldESJEFEDEHOGAR = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldEXPOBTENEREMPLEO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldEXPOTRA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldEXPTRABAJOPROPIO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHIJOS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNIVELACADEMICO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldOCUPACIONBUSCATRABAJO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldOCUPACIONESTUDIA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldOCUPACIONOFICIOSHOGAR = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldOCUPACIONOTRA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRANGOEDAD = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRANGOEDAD2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRANGONIVELACAD = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSEXO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldIDSOLICITUD = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldEXPUBICACION = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldLEEESCRIBE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRangoEdad3 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCODIGOGRUPO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHAINICIOREAL = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHAFINREAL = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldAREAFORMATIVA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.tabGrafico = New DevExpress.XtraTab.XtraTabPage()
        Me.txtTituloGrafico = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PatiAnalisisCaractSocialesTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.PATIAnalisisCaractSocialesTableAdapter()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtNUM_LICITACION.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytConvocatoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytFechaInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytFechaFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytLicitacion, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'fieldHABLAR
        '
        Me.fieldHABLAR.AreaIndex = 20
        Me.fieldHABLAR.FieldName = "HABLAR"
        Me.fieldHABLAR.Name = "fieldHABLAR"
        '
        'fieldMOVERSEOCAMINAR
        '
        Me.fieldMOVERSEOCAMINAR.AreaIndex = 21
        Me.fieldMOVERSEOCAMINAR.FieldName = "MOVERSE_O_CAMINAR"
        Me.fieldMOVERSEOCAMINAR.Name = "fieldMOVERSEOCAMINAR"
        '
        'fieldOIRAUNUSANDOAPAESP
        '
        Me.fieldOIRAUNUSANDOAPAESP.AreaIndex = 22
        Me.fieldOIRAUNUSANDOAPAESP.FieldName = "OIR_AUN_USANDO_APA_ESP"
        Me.fieldOIRAUNUSANDOAPAESP.Name = "fieldOIRAUNUSANDOAPAESP"
        '
        'fieldOTRALIMITACIONPERMANENTE
        '
        Me.fieldOTRALIMITACIONPERMANENTE.AreaIndex = 23
        Me.fieldOTRALIMITACIONPERMANENTE.FieldName = "OTRA_LIMITACION_PERMANENTE"
        Me.fieldOTRALIMITACIONPERMANENTE.Name = "fieldOTRALIMITACIONPERMANENTE"
        '
        'fieldTIENEALGUNRETRASO
        '
        Me.fieldTIENEALGUNRETRASO.AreaIndex = 24
        Me.fieldTIENEALGUNRETRASO.FieldName = "TIENE_ALGUN_RETRASO"
        Me.fieldTIENEALGUNRETRASO.Name = "fieldTIENEALGUNRETRASO"
        '
        'fieldUSARSUSBRAZOSOMANOS
        '
        Me.fieldUSARSUSBRAZOSOMANOS.AreaIndex = 25
        Me.fieldUSARSUSBRAZOSOMANOS.FieldName = "USAR_SUS_BRAZOS_O_MANOS"
        Me.fieldUSARSUSBRAZOSOMANOS.Name = "fieldUSARSUSBRAZOSOMANOS"
        '
        'fieldVERAUNUSANDOLENTES
        '
        Me.fieldVERAUNUSANDOLENTES.AreaIndex = 26
        Me.fieldVERAUNUSANDOLENTES.FieldName = "VER_AUN_USANDO_LENTES"
        Me.fieldVERAUNUSANDOLENTES.Name = "fieldVERAUNUSANDOLENTES"
        '
        'fieldVESTIRALIMENTARPORSIMISMO
        '
        Me.fieldVESTIRALIMENTARPORSIMISMO.AreaIndex = 27
        Me.fieldVESTIRALIMENTARPORSIMISMO.FieldName = "VESTIR_ALIMENTAR_POR_SI_MISMO"
        Me.fieldVESTIRALIMENTARPORSIMISMO.Name = "fieldVESTIRALIMENTARPORSIMISMO"
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
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1081, 534)
        Me.SplitContainerControl1.SplitterPosition = 92
        Me.SplitContainerControl1.TabIndex = 5
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtNUM_LICITACION)
        Me.LayoutControl1.Controls.Add(Me.dteFechaFinal)
        Me.LayoutControl1.Controls.Add(Me.dteFechaInicial)
        Me.LayoutControl1.Controls.Add(Me.CbxPROGRAMA_FORMACION1)
        Me.LayoutControl1.Controls.Add(Me.SpinEdit1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1081, 92)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtNUM_LICITACION
        '
        Me.txtNUM_LICITACION.EditValue = "_/____"
        Me.txtNUM_LICITACION.Location = New System.Drawing.Point(80, 61)
        Me.txtNUM_LICITACION.Name = "txtNUM_LICITACION"
        Me.txtNUM_LICITACION.Properties.Mask.EditMask = "0/0000"
        Me.txtNUM_LICITACION.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtNUM_LICITACION.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNUM_LICITACION.Size = New System.Drawing.Size(185, 20)
        Me.txtNUM_LICITACION.StyleController = Me.LayoutControl1
        Me.txtNUM_LICITACION.TabIndex = 16
        '
        'dteFechaFinal
        '
        Me.dteFechaFinal.CustomFormat = "dd/MM/yyyy"
        Me.dteFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dteFechaFinal.Location = New System.Drawing.Point(677, 61)
        Me.dteFechaFinal.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dteFechaFinal.Name = "dteFechaFinal"
        Me.dteFechaFinal.Size = New System.Drawing.Size(375, 21)
        Me.dteFechaFinal.TabIndex = 14
        Me.dteFechaFinal.Value = New Date(2014, 10, 24, 0, 0, 0, 0)
        '
        'dteFechaInicial
        '
        Me.dteFechaInicial.CustomFormat = "dd/MM/yyyy"
        Me.dteFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dteFechaInicial.Location = New System.Drawing.Point(337, 61)
        Me.dteFechaInicial.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dteFechaInicial.Name = "dteFechaInicial"
        Me.dteFechaInicial.Size = New System.Drawing.Size(268, 21)
        Me.dteFechaInicial.TabIndex = 13
        Me.dteFechaInicial.Value = New Date(2014, 11, 3, 0, 0, 0, 0)
        '
        'CbxPROGRAMA_FORMACION1
        '
        Me.CbxPROGRAMA_FORMACION1.AllowFindEntityType = Nothing
        Me.CbxPROGRAMA_FORMACION1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxPROGRAMA_FORMACION1.Location = New System.Drawing.Point(80, 12)
        Me.CbxPROGRAMA_FORMACION1.Name = "CbxPROGRAMA_FORMACION1"
        Me.CbxPROGRAMA_FORMACION1.Size = New System.Drawing.Size(972, 21)
        Me.CbxPROGRAMA_FORMACION1.TabIndex = 12
        '
        'SpinEdit1
        '
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit1.Location = New System.Drawing.Point(80, 37)
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SpinEdit1.Properties.MaxValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.SpinEdit1.Size = New System.Drawing.Size(972, 20)
        Me.SpinEdit1.StyleController = Me.LayoutControl1
        Me.SpinEdit1.TabIndex = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lytConvocatoria, Me.LayoutControlItem3, Me.lytFechaInicial, Me.lytFechaFinal, Me.lytLicitacion})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1064, 93)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'lytConvocatoria
        '
        Me.lytConvocatoria.Control = Me.SpinEdit1
        Me.lytConvocatoria.CustomizationFormText = "Convocatoria"
        Me.lytConvocatoria.Location = New System.Drawing.Point(0, 25)
        Me.lytConvocatoria.Name = "lytConvocatoria"
        Me.lytConvocatoria.Size = New System.Drawing.Size(1044, 24)
        Me.lytConvocatoria.Text = "Convocatoria"
        Me.lytConvocatoria.TextSize = New System.Drawing.Size(64, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.CbxPROGRAMA_FORMACION1
        Me.LayoutControlItem3.CustomizationFormText = "Programa"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1044, 25)
        Me.LayoutControlItem3.Text = "Programa"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(64, 13)
        '
        'lytFechaInicial
        '
        Me.lytFechaInicial.Control = Me.dteFechaInicial
        Me.lytFechaInicial.CustomizationFormText = "Fecha Inicial"
        Me.lytFechaInicial.Location = New System.Drawing.Point(257, 49)
        Me.lytFechaInicial.Name = "lytFechaInicial"
        Me.lytFechaInicial.Size = New System.Drawing.Size(340, 24)
        Me.lytFechaInicial.Text = "Fecha Inicial"
        Me.lytFechaInicial.TextSize = New System.Drawing.Size(64, 13)
        '
        'lytFechaFinal
        '
        Me.lytFechaFinal.Control = Me.dteFechaFinal
        Me.lytFechaFinal.CustomizationFormText = "Fecha Final"
        Me.lytFechaFinal.Location = New System.Drawing.Point(597, 49)
        Me.lytFechaFinal.Name = "lytFechaFinal"
        Me.lytFechaFinal.Size = New System.Drawing.Size(447, 24)
        Me.lytFechaFinal.Text = "Fecha Final"
        Me.lytFechaFinal.TextSize = New System.Drawing.Size(64, 13)
        '
        'lytLicitacion
        '
        Me.lytLicitacion.Control = Me.txtNUM_LICITACION
        Me.lytLicitacion.CustomizationFormText = "N° Licitacion"
        Me.lytLicitacion.Location = New System.Drawing.Point(0, 49)
        Me.lytLicitacion.Name = "lytLicitacion"
        Me.lytLicitacion.Size = New System.Drawing.Size(257, 24)
        Me.lytLicitacion.Text = "N° Licitacion"
        Me.lytLicitacion.TextSize = New System.Drawing.Size(64, 13)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabDetalle
        Me.XtraTabControl1.Size = New System.Drawing.Size(1081, 437)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabDetalle, Me.tabAnalisis, Me.tabGrafico})
        '
        'tabDetalle
        '
        Me.tabDetalle.Controls.Add(Me.GridControl1)
        Me.tabDetalle.Name = "tabDetalle"
        Me.tabDetalle.Size = New System.Drawing.Size(1075, 411)
        Me.tabDetalle.Text = "Detalle"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "PATIAnalisisCaractSociales"
        Me.GridControl1.DataSource = Me.DS_DL1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1075, 411)
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNO_CONVOCATORIA, Me.colNOMBRE_FUENTE, Me.colNOMBRE_MUNICIPIO, Me.colNOMBRE_DEPARTAMENTO, Me.colCON_DISCAPACIDAD, Me.colCODIGO_GRUPO, Me.colCURSO, Me.colES_JEFE_DE_HOGAR, Me.colEXP_OBTENER_EMPLEO, Me.colEXP_TRABAJO_PROPIO, Me.colEXP_OTRA, Me.colEXP_UBICACION, Me.colHABLAR, Me.colHIJOS, Me.colID_FUENTE, Me.colMOVERSE_O_CAMINAR, Me.colNIVEL_ACADEMICO, Me.colOCUPACION_BUSCA_TRABAJO, Me.colOCUPACION_ESTUDIA, Me.colOCUPACION_OFICIOS_HOGAR, Me.colOCUPACION_OTRA, Me.colOIR_AUN_USANDO_APA_ESP, Me.colOTRA_LIMITACION_PERMANENTE, Me.colRANGO_EDAD, Me.colRANGO_EDAD2, Me.colRANGO_NIVEL_ACAD, Me.colSEXO, Me.colTIENE_ALGUN_RETRASO, Me.colUSAR_SUS_BRAZOS_O_MANOS, Me.colVER_AUN_USANDO_LENTES, Me.colVESTIR_ALIMENTAR_POR_SI_MISMO, Me.colLEE_ESCRIBE, Me.colRangoEdad3, Me.colFECHA_INICIO_REAL, Me.colFECHA_FIN_REAL, Me.colAREA_FORMATIVA})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 4
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "NUME_FICH_PATI", Nothing, "Participantes ({0})")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNOMBRE_FUENTE, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNO_CONVOCATORIA, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNOMBRE_DEPARTAMENTO, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNOMBRE_MUNICIPIO, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCURSO, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colNO_CONVOCATORIA
        '
        Me.colNO_CONVOCATORIA.DisplayFormat.FormatString = "N0"
        Me.colNO_CONVOCATORIA.FieldName = "NO_CONVOCATORIA"
        Me.colNO_CONVOCATORIA.GroupFormat.FormatString = "N0"
        Me.colNO_CONVOCATORIA.Name = "colNO_CONVOCATORIA"
        Me.colNO_CONVOCATORIA.Width = 107
        '
        'colNOMBRE_FUENTE
        '
        Me.colNOMBRE_FUENTE.FieldName = "NOMBRE_FUENTE"
        Me.colNOMBRE_FUENTE.Name = "colNOMBRE_FUENTE"
        Me.colNOMBRE_FUENTE.Width = 90
        '
        'colNOMBRE_MUNICIPIO
        '
        Me.colNOMBRE_MUNICIPIO.FieldName = "NOMBRE_MUNICIPIO"
        Me.colNOMBRE_MUNICIPIO.Name = "colNOMBRE_MUNICIPIO"
        Me.colNOMBRE_MUNICIPIO.Width = 96
        '
        'colNOMBRE_DEPARTAMENTO
        '
        Me.colNOMBRE_DEPARTAMENTO.FieldName = "NOMBRE_DEPARTAMENTO"
        Me.colNOMBRE_DEPARTAMENTO.Name = "colNOMBRE_DEPARTAMENTO"
        Me.colNOMBRE_DEPARTAMENTO.Width = 31
        '
        'colCON_DISCAPACIDAD
        '
        Me.colCON_DISCAPACIDAD.FieldName = "CON_DISCAPACIDAD"
        Me.colCON_DISCAPACIDAD.Name = "colCON_DISCAPACIDAD"
        Me.colCON_DISCAPACIDAD.Visible = True
        Me.colCON_DISCAPACIDAD.VisibleIndex = 15
        Me.colCON_DISCAPACIDAD.Width = 102
        '
        'colCODIGO_GRUPO
        '
        Me.colCODIGO_GRUPO.Caption = "Codigo Grupo"
        Me.colCODIGO_GRUPO.FieldName = "CODIGO_GRUPO"
        Me.colCODIGO_GRUPO.Name = "colCODIGO_GRUPO"
        Me.colCODIGO_GRUPO.Visible = True
        Me.colCODIGO_GRUPO.VisibleIndex = 28
        '
        'colCURSO
        '
        Me.colCURSO.Caption = "ACCION FORMATIVA"
        Me.colCURSO.FieldName = "CURSO"
        Me.colCURSO.Name = "colCURSO"
        Me.colCURSO.Visible = True
        Me.colCURSO.VisibleIndex = 0
        Me.colCURSO.Width = 106
        '
        'colES_JEFE_DE_HOGAR
        '
        Me.colES_JEFE_DE_HOGAR.FieldName = "ES_JEFE_DE_HOGAR"
        Me.colES_JEFE_DE_HOGAR.Name = "colES_JEFE_DE_HOGAR"
        Me.colES_JEFE_DE_HOGAR.Visible = True
        Me.colES_JEFE_DE_HOGAR.VisibleIndex = 6
        Me.colES_JEFE_DE_HOGAR.Width = 31
        '
        'colEXP_OBTENER_EMPLEO
        '
        Me.colEXP_OBTENER_EMPLEO.Caption = "Expectativa Empleo"
        Me.colEXP_OBTENER_EMPLEO.FieldName = "EXP_OBTENER_EMPLEO"
        Me.colEXP_OBTENER_EMPLEO.Name = "colEXP_OBTENER_EMPLEO"
        Me.colEXP_OBTENER_EMPLEO.Visible = True
        Me.colEXP_OBTENER_EMPLEO.VisibleIndex = 9
        Me.colEXP_OBTENER_EMPLEO.Width = 31
        '
        'colEXP_TRABAJO_PROPIO
        '
        Me.colEXP_TRABAJO_PROPIO.Caption = "Expectativa Autoempleo"
        Me.colEXP_TRABAJO_PROPIO.FieldName = "EXP_TRABAJO_PROPIO"
        Me.colEXP_TRABAJO_PROPIO.Name = "colEXP_TRABAJO_PROPIO"
        Me.colEXP_TRABAJO_PROPIO.Visible = True
        Me.colEXP_TRABAJO_PROPIO.VisibleIndex = 8
        Me.colEXP_TRABAJO_PROPIO.Width = 31
        '
        'colEXP_OTRA
        '
        Me.colEXP_OTRA.Caption = "Expectativa Otra"
        Me.colEXP_OTRA.FieldName = "EXP_OTRA"
        Me.colEXP_OTRA.Name = "colEXP_OTRA"
        Me.colEXP_OTRA.Visible = True
        Me.colEXP_OTRA.VisibleIndex = 10
        Me.colEXP_OTRA.Width = 31
        '
        'colEXP_UBICACION
        '
        Me.colEXP_UBICACION.Caption = "Expectativa Ubicación"
        Me.colEXP_UBICACION.FieldName = "EXP_UBICACION"
        Me.colEXP_UBICACION.Name = "colEXP_UBICACION"
        Me.colEXP_UBICACION.Visible = True
        Me.colEXP_UBICACION.VisibleIndex = 24
        '
        'colHABLAR
        '
        Me.colHABLAR.FieldName = "HABLAR"
        Me.colHABLAR.Name = "colHABLAR"
        Me.colHABLAR.Visible = True
        Me.colHABLAR.VisibleIndex = 16
        Me.colHABLAR.Width = 32
        '
        'colHIJOS
        '
        Me.colHIJOS.FieldName = "HIJOS"
        Me.colHIJOS.Name = "colHIJOS"
        Me.colHIJOS.Visible = True
        Me.colHIJOS.VisibleIndex = 7
        Me.colHIJOS.Width = 31
        '
        'colID_FUENTE
        '
        Me.colID_FUENTE.FieldName = "ID_FUENTE"
        Me.colID_FUENTE.Name = "colID_FUENTE"
        Me.colID_FUENTE.Width = 37
        '
        'colMOVERSE_O_CAMINAR
        '
        Me.colMOVERSE_O_CAMINAR.FieldName = "MOVERSE_O_CAMINAR"
        Me.colMOVERSE_O_CAMINAR.Name = "colMOVERSE_O_CAMINAR"
        Me.colMOVERSE_O_CAMINAR.Visible = True
        Me.colMOVERSE_O_CAMINAR.VisibleIndex = 17
        Me.colMOVERSE_O_CAMINAR.Width = 77
        '
        'colNIVEL_ACADEMICO
        '
        Me.colNIVEL_ACADEMICO.FieldName = "NIVEL_ACADEMICO"
        Me.colNIVEL_ACADEMICO.Name = "colNIVEL_ACADEMICO"
        Me.colNIVEL_ACADEMICO.Visible = True
        Me.colNIVEL_ACADEMICO.VisibleIndex = 5
        Me.colNIVEL_ACADEMICO.Width = 31
        '
        'colOCUPACION_BUSCA_TRABAJO
        '
        Me.colOCUPACION_BUSCA_TRABAJO.FieldName = "OCUPACION_BUSCA_TRABAJO"
        Me.colOCUPACION_BUSCA_TRABAJO.Name = "colOCUPACION_BUSCA_TRABAJO"
        Me.colOCUPACION_BUSCA_TRABAJO.Visible = True
        Me.colOCUPACION_BUSCA_TRABAJO.VisibleIndex = 11
        Me.colOCUPACION_BUSCA_TRABAJO.Width = 31
        '
        'colOCUPACION_ESTUDIA
        '
        Me.colOCUPACION_ESTUDIA.FieldName = "OCUPACION_ESTUDIA"
        Me.colOCUPACION_ESTUDIA.Name = "colOCUPACION_ESTUDIA"
        Me.colOCUPACION_ESTUDIA.Visible = True
        Me.colOCUPACION_ESTUDIA.VisibleIndex = 12
        Me.colOCUPACION_ESTUDIA.Width = 31
        '
        'colOCUPACION_OFICIOS_HOGAR
        '
        Me.colOCUPACION_OFICIOS_HOGAR.FieldName = "OCUPACION_OFICIOS_HOGAR"
        Me.colOCUPACION_OFICIOS_HOGAR.Name = "colOCUPACION_OFICIOS_HOGAR"
        Me.colOCUPACION_OFICIOS_HOGAR.Visible = True
        Me.colOCUPACION_OFICIOS_HOGAR.VisibleIndex = 13
        Me.colOCUPACION_OFICIOS_HOGAR.Width = 31
        '
        'colOCUPACION_OTRA
        '
        Me.colOCUPACION_OTRA.FieldName = "OCUPACION_OTRA"
        Me.colOCUPACION_OTRA.Name = "colOCUPACION_OTRA"
        Me.colOCUPACION_OTRA.Visible = True
        Me.colOCUPACION_OTRA.VisibleIndex = 14
        Me.colOCUPACION_OTRA.Width = 31
        '
        'colOIR_AUN_USANDO_APA_ESP
        '
        Me.colOIR_AUN_USANDO_APA_ESP.FieldName = "OIR_AUN_USANDO_APA_ESP"
        Me.colOIR_AUN_USANDO_APA_ESP.Name = "colOIR_AUN_USANDO_APA_ESP"
        Me.colOIR_AUN_USANDO_APA_ESP.Visible = True
        Me.colOIR_AUN_USANDO_APA_ESP.VisibleIndex = 18
        Me.colOIR_AUN_USANDO_APA_ESP.Width = 54
        '
        'colOTRA_LIMITACION_PERMANENTE
        '
        Me.colOTRA_LIMITACION_PERMANENTE.FieldName = "OTRA_LIMITACION_PERMANENTE"
        Me.colOTRA_LIMITACION_PERMANENTE.Name = "colOTRA_LIMITACION_PERMANENTE"
        Me.colOTRA_LIMITACION_PERMANENTE.Visible = True
        Me.colOTRA_LIMITACION_PERMANENTE.VisibleIndex = 19
        Me.colOTRA_LIMITACION_PERMANENTE.Width = 49
        '
        'colRANGO_EDAD
        '
        Me.colRANGO_EDAD.FieldName = "RANGO_EDAD"
        Me.colRANGO_EDAD.Name = "colRANGO_EDAD"
        Me.colRANGO_EDAD.Visible = True
        Me.colRANGO_EDAD.VisibleIndex = 2
        Me.colRANGO_EDAD.Width = 81
        '
        'colRANGO_EDAD2
        '
        Me.colRANGO_EDAD2.FieldName = "RANGO_EDAD2"
        Me.colRANGO_EDAD2.Name = "colRANGO_EDAD2"
        Me.colRANGO_EDAD2.Width = 37
        '
        'colRANGO_NIVEL_ACAD
        '
        Me.colRANGO_NIVEL_ACAD.FieldName = "RANGO_NIVEL_ACAD"
        Me.colRANGO_NIVEL_ACAD.Name = "colRANGO_NIVEL_ACAD"
        Me.colRANGO_NIVEL_ACAD.Visible = True
        Me.colRANGO_NIVEL_ACAD.VisibleIndex = 4
        Me.colRANGO_NIVEL_ACAD.Width = 64
        '
        'colSEXO
        '
        Me.colSEXO.FieldName = "SEXO"
        Me.colSEXO.Name = "colSEXO"
        Me.colSEXO.Visible = True
        Me.colSEXO.VisibleIndex = 1
        Me.colSEXO.Width = 37
        '
        'colTIENE_ALGUN_RETRASO
        '
        Me.colTIENE_ALGUN_RETRASO.FieldName = "TIENE_ALGUN_RETRASO"
        Me.colTIENE_ALGUN_RETRASO.Name = "colTIENE_ALGUN_RETRASO"
        Me.colTIENE_ALGUN_RETRASO.Visible = True
        Me.colTIENE_ALGUN_RETRASO.VisibleIndex = 20
        Me.colTIENE_ALGUN_RETRASO.Width = 42
        '
        'colUSAR_SUS_BRAZOS_O_MANOS
        '
        Me.colUSAR_SUS_BRAZOS_O_MANOS.FieldName = "USAR_SUS_BRAZOS_O_MANOS"
        Me.colUSAR_SUS_BRAZOS_O_MANOS.Name = "colUSAR_SUS_BRAZOS_O_MANOS"
        Me.colUSAR_SUS_BRAZOS_O_MANOS.Visible = True
        Me.colUSAR_SUS_BRAZOS_O_MANOS.VisibleIndex = 21
        Me.colUSAR_SUS_BRAZOS_O_MANOS.Width = 40
        '
        'colVER_AUN_USANDO_LENTES
        '
        Me.colVER_AUN_USANDO_LENTES.FieldName = "VER_AUN_USANDO_LENTES"
        Me.colVER_AUN_USANDO_LENTES.Name = "colVER_AUN_USANDO_LENTES"
        Me.colVER_AUN_USANDO_LENTES.Visible = True
        Me.colVER_AUN_USANDO_LENTES.VisibleIndex = 22
        Me.colVER_AUN_USANDO_LENTES.Width = 53
        '
        'colVESTIR_ALIMENTAR_POR_SI_MISMO
        '
        Me.colVESTIR_ALIMENTAR_POR_SI_MISMO.FieldName = "VESTIR_ALIMENTAR_POR_SI_MISMO"
        Me.colVESTIR_ALIMENTAR_POR_SI_MISMO.Name = "colVESTIR_ALIMENTAR_POR_SI_MISMO"
        Me.colVESTIR_ALIMENTAR_POR_SI_MISMO.Visible = True
        Me.colVESTIR_ALIMENTAR_POR_SI_MISMO.VisibleIndex = 23
        Me.colVESTIR_ALIMENTAR_POR_SI_MISMO.Width = 177
        '
        'colLEE_ESCRIBE
        '
        Me.colLEE_ESCRIBE.Caption = "Lee-Escribe"
        Me.colLEE_ESCRIBE.FieldName = "LEE_ESCRIBE"
        Me.colLEE_ESCRIBE.Name = "colLEE_ESCRIBE"
        Me.colLEE_ESCRIBE.Visible = True
        Me.colLEE_ESCRIBE.VisibleIndex = 25
        '
        'colRangoEdad3
        '
        Me.colRangoEdad3.Caption = "Rango Edad 3"
        Me.colRangoEdad3.FieldName = "colRangoEdad3"
        Me.colRangoEdad3.Name = "colRangoEdad3"
        Me.colRangoEdad3.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colRangoEdad3.Visible = True
        Me.colRangoEdad3.VisibleIndex = 3
        '
        'colFECHA_INICIO_REAL
        '
        Me.colFECHA_INICIO_REAL.Caption = "Fecha Inicio"
        Me.colFECHA_INICIO_REAL.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colFECHA_INICIO_REAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colFECHA_INICIO_REAL.FieldName = "FECHA_INICIO_REAL"
        Me.colFECHA_INICIO_REAL.Name = "colFECHA_INICIO_REAL"
        Me.colFECHA_INICIO_REAL.Visible = True
        Me.colFECHA_INICIO_REAL.VisibleIndex = 26
        '
        'colFECHA_FIN_REAL
        '
        Me.colFECHA_FIN_REAL.Caption = "Fecha Fin"
        Me.colFECHA_FIN_REAL.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.colFECHA_FIN_REAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colFECHA_FIN_REAL.FieldName = "FECHA_FIN_REAL"
        Me.colFECHA_FIN_REAL.Name = "colFECHA_FIN_REAL"
        Me.colFECHA_FIN_REAL.Visible = True
        Me.colFECHA_FIN_REAL.VisibleIndex = 27
        '
        'colAREA_FORMATIVA
        '
        Me.colAREA_FORMATIVA.Caption = "AREA FORMATIVA"
        Me.colAREA_FORMATIVA.FieldName = "AREA_FORMATIVA"
        Me.colAREA_FORMATIVA.Name = "colAREA_FORMATIVA"
        Me.colAREA_FORMATIVA.Visible = True
        Me.colAREA_FORMATIVA.VisibleIndex = 29
        '
        'tabAnalisis
        '
        Me.tabAnalisis.Controls.Add(Me.PivotGridControl1)
        Me.tabAnalisis.Name = "tabAnalisis"
        Me.tabAnalisis.Size = New System.Drawing.Size(1075, 411)
        Me.tabAnalisis.Text = "Analisis"
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.DataMember = "PATIAnalisisCaractSociales"
        Me.PivotGridControl1.DataSource = Me.DS_DL1
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldNOMBREMUNICIPIO, Me.fieldNOMBREFUENTE, Me.fieldNOMBREDEPARTAMENTO, Me.fieldNOCONVOCATORIA, Me.fieldCURSO, Me.fieldCONDISCAPACIDAD, Me.fieldESJEFEDEHOGAR, Me.fieldEXPOBTENEREMPLEO, Me.fieldEXPOTRA, Me.fieldEXPTRABAJOPROPIO, Me.fieldHABLAR, Me.fieldHIJOS, Me.fieldMOVERSEOCAMINAR, Me.fieldNIVELACADEMICO, Me.fieldOCUPACIONBUSCATRABAJO, Me.fieldOCUPACIONESTUDIA, Me.fieldOCUPACIONOFICIOSHOGAR, Me.fieldOCUPACIONOTRA, Me.fieldOIRAUNUSANDOAPAESP, Me.fieldOTRALIMITACIONPERMANENTE, Me.fieldRANGOEDAD, Me.fieldRANGOEDAD2, Me.fieldRANGONIVELACAD, Me.fieldSEXO, Me.fieldTIENEALGUNRETRASO, Me.fieldUSARSUSBRAZOSOMANOS, Me.fieldVERAUNUSANDOLENTES, Me.fieldVESTIRALIMENTARPORSIMISMO, Me.fieldIDSOLICITUD, Me.fieldEXPUBICACION, Me.fieldLEEESCRIBE, Me.fieldRangoEdad3, Me.fieldCODIGOGRUPO, Me.fieldFECHAINICIOREAL, Me.fieldFECHAFINREAL, Me.fieldAREAFORMATIVA})
        PivotGridGroup1.Caption = "DISCAPACIDAD"
        PivotGridGroup1.Fields.Add(Me.fieldHABLAR)
        PivotGridGroup1.Fields.Add(Me.fieldMOVERSEOCAMINAR)
        PivotGridGroup1.Fields.Add(Me.fieldOIRAUNUSANDOAPAESP)
        PivotGridGroup1.Fields.Add(Me.fieldOTRALIMITACIONPERMANENTE)
        PivotGridGroup1.Fields.Add(Me.fieldTIENEALGUNRETRASO)
        PivotGridGroup1.Fields.Add(Me.fieldUSARSUSBRAZOSOMANOS)
        PivotGridGroup1.Fields.Add(Me.fieldVERAUNUSANDOLENTES)
        PivotGridGroup1.Fields.Add(Me.fieldVESTIRALIMENTARPORSIMISMO)
        PivotGridGroup1.Hierarchy = Nothing
        Me.PivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() {PivotGridGroup1})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText
        Me.PivotGridControl1.Size = New System.Drawing.Size(1075, 411)
        Me.PivotGridControl1.TabIndex = 2
        '
        'fieldNOMBREMUNICIPIO
        '
        Me.fieldNOMBREMUNICIPIO.AreaIndex = 0
        Me.fieldNOMBREMUNICIPIO.FieldName = "NOMBRE_MUNICIPIO"
        Me.fieldNOMBREMUNICIPIO.Name = "fieldNOMBREMUNICIPIO"
        '
        'fieldNOMBREFUENTE
        '
        Me.fieldNOMBREFUENTE.AreaIndex = 2
        Me.fieldNOMBREFUENTE.FieldName = "NOMBRE_FUENTE"
        Me.fieldNOMBREFUENTE.Name = "fieldNOMBREFUENTE"
        '
        'fieldNOMBREDEPARTAMENTO
        '
        Me.fieldNOMBREDEPARTAMENTO.AreaIndex = 1
        Me.fieldNOMBREDEPARTAMENTO.FieldName = "NOMBRE_DEPARTAMENTO"
        Me.fieldNOMBREDEPARTAMENTO.Name = "fieldNOMBREDEPARTAMENTO"
        '
        'fieldNOCONVOCATORIA
        '
        Me.fieldNOCONVOCATORIA.AreaIndex = 3
        Me.fieldNOCONVOCATORIA.FieldName = "NO_CONVOCATORIA"
        Me.fieldNOCONVOCATORIA.Name = "fieldNOCONVOCATORIA"
        '
        'fieldCURSO
        '
        Me.fieldCURSO.AreaIndex = 4
        Me.fieldCURSO.Caption = "ACCION FORMATIVA"
        Me.fieldCURSO.FieldName = "CURSO"
        Me.fieldCURSO.Name = "fieldCURSO"
        '
        'fieldCONDISCAPACIDAD
        '
        Me.fieldCONDISCAPACIDAD.AreaIndex = 19
        Me.fieldCONDISCAPACIDAD.FieldName = "CON_DISCAPACIDAD"
        Me.fieldCONDISCAPACIDAD.Name = "fieldCONDISCAPACIDAD"
        '
        'fieldESJEFEDEHOGAR
        '
        Me.fieldESJEFEDEHOGAR.AreaIndex = 7
        Me.fieldESJEFEDEHOGAR.FieldName = "ES_JEFE_DE_HOGAR"
        Me.fieldESJEFEDEHOGAR.Name = "fieldESJEFEDEHOGAR"
        '
        'fieldEXPOBTENEREMPLEO
        '
        Me.fieldEXPOBTENEREMPLEO.AreaIndex = 9
        Me.fieldEXPOBTENEREMPLEO.Caption = "Expectativa Empleo"
        Me.fieldEXPOBTENEREMPLEO.FieldName = "EXP_OBTENER_EMPLEO"
        Me.fieldEXPOBTENEREMPLEO.Name = "fieldEXPOBTENEREMPLEO"
        '
        'fieldEXPOTRA
        '
        Me.fieldEXPOTRA.AreaIndex = 10
        Me.fieldEXPOTRA.Caption = "Expectativa Otra"
        Me.fieldEXPOTRA.FieldName = "EXP_OTRA"
        Me.fieldEXPOTRA.Name = "fieldEXPOTRA"
        '
        'fieldEXPTRABAJOPROPIO
        '
        Me.fieldEXPTRABAJOPROPIO.AreaIndex = 11
        Me.fieldEXPTRABAJOPROPIO.Caption = "Expectativa AutoEmpleo"
        Me.fieldEXPTRABAJOPROPIO.FieldName = "EXP_TRABAJO_PROPIO"
        Me.fieldEXPTRABAJOPROPIO.Name = "fieldEXPTRABAJOPROPIO"
        '
        'fieldHIJOS
        '
        Me.fieldHIJOS.AreaIndex = 8
        Me.fieldHIJOS.FieldName = "HIJOS"
        Me.fieldHIJOS.Name = "fieldHIJOS"
        '
        'fieldNIVELACADEMICO
        '
        Me.fieldNIVELACADEMICO.AreaIndex = 13
        Me.fieldNIVELACADEMICO.Caption = "Nivel Academico"
        Me.fieldNIVELACADEMICO.FieldName = "NIVEL_ACADEMICO"
        Me.fieldNIVELACADEMICO.Name = "fieldNIVELACADEMICO"
        '
        'fieldOCUPACIONBUSCATRABAJO
        '
        Me.fieldOCUPACIONBUSCATRABAJO.AreaIndex = 15
        Me.fieldOCUPACIONBUSCATRABAJO.FieldName = "OCUPACION_BUSCA_TRABAJO"
        Me.fieldOCUPACIONBUSCATRABAJO.Name = "fieldOCUPACIONBUSCATRABAJO"
        '
        'fieldOCUPACIONESTUDIA
        '
        Me.fieldOCUPACIONESTUDIA.AreaIndex = 16
        Me.fieldOCUPACIONESTUDIA.FieldName = "OCUPACION_ESTUDIA"
        Me.fieldOCUPACIONESTUDIA.Name = "fieldOCUPACIONESTUDIA"
        '
        'fieldOCUPACIONOFICIOSHOGAR
        '
        Me.fieldOCUPACIONOFICIOSHOGAR.AreaIndex = 17
        Me.fieldOCUPACIONOFICIOSHOGAR.FieldName = "OCUPACION_OFICIOS_HOGAR"
        Me.fieldOCUPACIONOFICIOSHOGAR.Name = "fieldOCUPACIONOFICIOSHOGAR"
        '
        'fieldOCUPACIONOTRA
        '
        Me.fieldOCUPACIONOTRA.AreaIndex = 18
        Me.fieldOCUPACIONOTRA.FieldName = "OCUPACION_OTRA"
        Me.fieldOCUPACIONOTRA.Name = "fieldOCUPACIONOTRA"
        '
        'fieldRANGOEDAD
        '
        Me.fieldRANGOEDAD.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldRANGOEDAD.AreaIndex = 0
        Me.fieldRANGOEDAD.FieldName = "RANGO_EDAD"
        Me.fieldRANGOEDAD.Name = "fieldRANGOEDAD"
        '
        'fieldRANGOEDAD2
        '
        Me.fieldRANGOEDAD2.AreaIndex = 5
        Me.fieldRANGOEDAD2.FieldName = "RANGO_EDAD2"
        Me.fieldRANGOEDAD2.Name = "fieldRANGOEDAD2"
        '
        'fieldRANGONIVELACAD
        '
        Me.fieldRANGONIVELACAD.AreaIndex = 6
        Me.fieldRANGONIVELACAD.FieldName = "RANGO_NIVEL_ACAD"
        Me.fieldRANGONIVELACAD.Name = "fieldRANGONIVELACAD"
        '
        'fieldSEXO
        '
        Me.fieldSEXO.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldSEXO.AreaIndex = 0
        Me.fieldSEXO.FieldName = "SEXO"
        Me.fieldSEXO.Name = "fieldSEXO"
        '
        'fieldIDSOLICITUD
        '
        Me.fieldIDSOLICITUD.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldIDSOLICITUD.AreaIndex = 0
        Me.fieldIDSOLICITUD.Caption = "Participacion"
        Me.fieldIDSOLICITUD.FieldName = "ID_SOLICITUD"
        Me.fieldIDSOLICITUD.Name = "fieldIDSOLICITUD"
        Me.fieldIDSOLICITUD.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count
        '
        'fieldEXPUBICACION
        '
        Me.fieldEXPUBICACION.AreaIndex = 12
        Me.fieldEXPUBICACION.Caption = "Expectativa Ubicacion"
        Me.fieldEXPUBICACION.FieldName = "EXP_UBICACION"
        Me.fieldEXPUBICACION.Name = "fieldEXPUBICACION"
        '
        'fieldLEEESCRIBE
        '
        Me.fieldLEEESCRIBE.AreaIndex = 14
        Me.fieldLEEESCRIBE.Caption = "Lee-Escribe"
        Me.fieldLEEESCRIBE.FieldName = "LEE_ESCRIBE"
        Me.fieldLEEESCRIBE.Name = "fieldLEEESCRIBE"
        '
        'fieldRangoEdad3
        '
        Me.fieldRangoEdad3.AreaIndex = 28
        Me.fieldRangoEdad3.Caption = "Rango Edad 3"
        Me.fieldRangoEdad3.Name = "fieldRangoEdad3"
        Me.fieldRangoEdad3.UnboundFieldName = "fieldRangoEdad3"
        Me.fieldRangoEdad3.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        '
        'fieldCODIGOGRUPO
        '
        Me.fieldCODIGOGRUPO.AreaIndex = 29
        Me.fieldCODIGOGRUPO.Caption = "Codigo Grupo"
        Me.fieldCODIGOGRUPO.FieldName = "CODIGO_GRUPO"
        Me.fieldCODIGOGRUPO.Name = "fieldCODIGOGRUPO"
        '
        'fieldFECHAINICIOREAL
        '
        Me.fieldFECHAINICIOREAL.AreaIndex = 30
        Me.fieldFECHAINICIOREAL.Caption = "Fecha Inicio"
        Me.fieldFECHAINICIOREAL.FieldName = "FECHA_INICIO_REAL"
        Me.fieldFECHAINICIOREAL.Name = "fieldFECHAINICIOREAL"
        Me.fieldFECHAINICIOREAL.ValueFormat.FormatString = "dd/MM/yyyy"
        Me.fieldFECHAINICIOREAL.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldFECHAFINREAL
        '
        Me.fieldFECHAFINREAL.AreaIndex = 31
        Me.fieldFECHAFINREAL.Caption = "Fecha Fin"
        Me.fieldFECHAFINREAL.FieldName = "FECHA_FIN_REAL"
        Me.fieldFECHAFINREAL.Name = "fieldFECHAFINREAL"
        Me.fieldFECHAFINREAL.ValueFormat.FormatString = "dd/MM/yyyy"
        Me.fieldFECHAFINREAL.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldAREAFORMATIVA
        '
        Me.fieldAREAFORMATIVA.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldAREAFORMATIVA.AreaIndex = 32
        Me.fieldAREAFORMATIVA.Caption = "AREA FORMATIVA"
        Me.fieldAREAFORMATIVA.FieldName = "AREA_FORMATIVA"
        Me.fieldAREAFORMATIVA.Name = "fieldAREAFORMATIVA"
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
        Me.tabGrafico.Size = New System.Drawing.Size(1075, 411)
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
        Me.ChartControl1.Legend.MaxHorizontalPercentage = 30.0R
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
        Me.ChartControl1.Size = New System.Drawing.Size(1067, 382)
        Me.ChartControl1.TabIndex = 8
        ChartTitle1.Text = "Participantes PATI"
        Me.ChartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PatiAnalisisCaractSocialesTableAdapter1
        '
        Me.PatiAnalisisCaractSocialesTableAdapter1.ClearBeforeFill = True
        '
        'frmAnalisisCaracSocialesPATI
        '
        Me.ClientSize = New System.Drawing.Size(1081, 534)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "frmAnalisisCaracSocialesPATI"
        Me.Text = "Analisis Caracteristicas Sociales"
        Me.Controls.SetChildIndex(Me.SplitContainerControl1, 0)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtNUM_LICITACION.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytConvocatoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytFechaInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytFechaFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytLicitacion, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lytConvocatoria As DevExpress.XtraLayout.LayoutControlItem
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
    Friend WithEvents fieldNOMBREMUNICIPIO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBREFUENTE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBREDEPARTAMENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOCONVOCATORIA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PatiAnalisisCaractSocialesTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.PATIAnalisisCaractSocialesTableAdapter
    Friend WithEvents colCON_DISCAPACIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCURSO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colES_JEFE_DE_HOGAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXP_OBTENER_EMPLEO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXP_OTRA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXP_TRABAJO_PROPIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHABLAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHIJOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_FUENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMOVERSE_O_CAMINAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNIVEL_ACADEMICO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOCUPACION_BUSCA_TRABAJO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOCUPACION_ESTUDIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOCUPACION_OFICIOS_HOGAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOCUPACION_OTRA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOIR_AUN_USANDO_APA_ESP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOTRA_LIMITACION_PERMANENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRANGO_EDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRANGO_EDAD2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRANGO_NIVEL_ACAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSEXO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIENE_ALGUN_RETRASO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSAR_SUS_BRAZOS_O_MANOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVER_AUN_USANDO_LENTES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVESTIR_ALIMENTAR_POR_SI_MISMO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldCURSO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCONDISCAPACIDAD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldESJEFEDEHOGAR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldEXPOBTENEREMPLEO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldEXPOTRA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldEXPTRABAJOPROPIO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHABLAR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHIJOS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMOVERSEOCAMINAR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNIVELACADEMICO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldOCUPACIONBUSCATRABAJO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldOCUPACIONESTUDIA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldOCUPACIONOFICIOSHOGAR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldOCUPACIONOTRA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldOIRAUNUSANDOAPAESP As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldOTRALIMITACIONPERMANENTE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRANGOEDAD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRANGOEDAD2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRANGONIVELACAD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSEXO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTIENEALGUNRETRASO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldUSARSUSBRAZOSOMANOS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldVERAUNUSANDOLENTES As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldVESTIRALIMENTARPORSIMISMO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldIDSOLICITUD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colEXP_UBICACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldEXPUBICACION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldLEEESCRIBE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colLEE_ESCRIBE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRangoEdad3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldRangoEdad3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents CbxPROGRAMA_FORMACION1 As SGAFP.WinUC.cbxPROGRAMA_FORMACION
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colCODIGO_GRUPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_INICIO_REAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_FIN_REAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldCODIGOGRUPO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHAINICIOREAL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHAFINREAL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents dteFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dteFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents lytFechaInicial As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lytFechaFinal As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtNUM_LICITACION As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lytLicitacion As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colAREA_FORMATIVA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldAREAFORMATIVA As DevExpress.XtraPivotGrid.PivotGridField

End Class
