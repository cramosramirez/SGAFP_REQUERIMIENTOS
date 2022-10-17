<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarProyEsp
    Inherits frmBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim XyDiagram3D1 As DevExpress.XtraCharts.XYDiagram3D = New DevExpress.XtraCharts.XYDiagram3D()
        Dim Bar3DSeriesLabel1 As DevExpress.XtraCharts.Bar3DSeriesLabel = New DevExpress.XtraCharts.Bar3DSeriesLabel()
        Dim ManhattanBarSeriesView1 As DevExpress.XtraCharts.ManhattanBarSeriesView = New DevExpress.XtraCharts.ManhattanBarSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.ProyectosEspecialesDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_DL1 = New SGAFP.DL.DS_DL()
        Me.fieldCENTRORESPONSABILIDAD = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCODIGOSIFP = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCONTRATO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCOSTOHORACURSO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDEPARTAMENTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDURACIONHORAS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldESTADOCURSO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHAFINREAL = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHAINICIOREAL = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHORARIO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldINSTRUCTOR = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldLUGAREJECUCION = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMUNICIPIO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBREACCIONFORMATIVA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNUMEROITEM = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPRECIOUNITARIOCURSO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPROVEEDOR = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldREFERENTE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPARTICIPANTESACTIVOS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPARTICIPANTESINSCRITOS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCODIGOGRUPO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTIPOCONTRATACION = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHOMBRESCAPACITADOS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMUJERESCAPACITADAS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMONTOHOMBRESCAPACITADOS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMONTOMUJERESCAPACITADAS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHAINGRESOSIS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldOFERTACOMPRA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBREESTADOINFORME = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldAREAFORMACION = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSUBAREA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldIDSOLICITUD = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMONTOINFORME = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOPRODUCTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldIncremento1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldULTFECHAVISITA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldULTUSUARIOVISITA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMODALIDADFORMATIVA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.tabDatosGrafico = New DevExpress.XtraTab.XtraTabControl()
        Me.tabPageDatos = New DevExpress.XtraTab.XtraTabPage()
        Me.tabPageGrafico = New DevExpress.XtraTab.XtraTabPage()
        Me.txtTituloGrafico = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.ProyectosEspecialesTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.ProyectosEspecialesTableAdapter()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtNoOfertaCompra = New System.Windows.Forms.TextBox()
        Me.CbxUNIDAD_ORGANIZATIVA1 = New SGAFP.WinUC.cbxUNIDAD_ORGANIZATIVA()
        Me.CbxPROGRAMA_FORMACION1 = New SGAFP.WinUC.cbxPROGRAMA_FORMACION()
        Me.CbxREFERENTE1 = New SGAFP.WinUC.cbxREFERENTE()
        Me.txtItem = New DevExpress.XtraEditors.TextEdit()
        Me.txtNoContrato = New DevExpress.XtraEditors.TextEdit()
        Me.CbxPROVEEDOR_AF1 = New SGAFP.WinUC.cbxPROVEEDOR_AF()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.fieldCODIGOCATEG = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBRECATEG = New DevExpress.XtraPivotGrid.PivotGridField()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosEspecialesDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.tabDatosGrafico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDatosGrafico.SuspendLayout()
        Me.tabPageDatos.SuspendLayout()
        Me.tabPageGrafico.SuspendLayout()
        CType(Me.txtTituloGrafico.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram3D1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Bar3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(ManhattanBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.txtItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoContrato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PivotGridControl1.DataSource = Me.ProyectosEspecialesDataTableBindingSource
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCENTRORESPONSABILIDAD, Me.fieldCODIGOSIFP, Me.fieldCONTRATO, Me.fieldCOSTOHORACURSO, Me.fieldDEPARTAMENTO, Me.fieldDURACIONHORAS, Me.fieldESTADOCURSO, Me.fieldFECHAFINREAL, Me.fieldFECHAINICIOREAL, Me.fieldHORARIO, Me.fieldINSTRUCTOR, Me.fieldLUGAREJECUCION, Me.fieldMUNICIPIO, Me.fieldNOMBREACCIONFORMATIVA, Me.fieldNUMEROITEM, Me.fieldPRECIOUNITARIOCURSO, Me.fieldPROVEEDOR, Me.fieldREFERENTE, Me.fieldPARTICIPANTESACTIVOS, Me.fieldPARTICIPANTESINSCRITOS, Me.fieldCODIGOGRUPO, Me.fieldTIPOCONTRATACION, Me.fieldHOMBRESCAPACITADOS, Me.fieldMUJERESCAPACITADAS, Me.fieldMONTOHOMBRESCAPACITADOS, Me.fieldMONTOMUJERESCAPACITADAS, Me.fieldFECHAINGRESOSIS, Me.fieldOFERTACOMPRA, Me.fieldNOMBREESTADOINFORME, Me.fieldAREAFORMACION, Me.fieldSUBAREA, Me.fieldIDSOLICITUD, Me.fieldMONTOINFORME, Me.fieldNOPRODUCTO, Me.fieldIncremento1, Me.fieldULTFECHAVISITA, Me.fieldULTUSUARIOVISITA, Me.fieldMODALIDADFORMATIVA, Me.fieldCODIGOCATEG, Me.fieldNOMBRECATEG})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText
        Me.PivotGridControl1.OptionsCustomization.AllowFilter = False
        Me.PivotGridControl1.OptionsPrint.MergeRowFieldValues = False
        Me.PivotGridControl1.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridControl1.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridControl1.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridControl1.OptionsPrint.PrintHeadersOnEveryPage = True
        Me.PivotGridControl1.OptionsPrint.PrintHorzLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridControl1.OptionsPrint.PrintRowHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridControl1.OptionsPrint.PrintVertLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridControl1.Size = New System.Drawing.Size(1002, 287)
        Me.PivotGridControl1.TabIndex = 1
        '
        'ProyectosEspecialesDataTableBindingSource
        '
        Me.ProyectosEspecialesDataTableBindingSource.DataMember = "ProyectosEspeciales"
        Me.ProyectosEspecialesDataTableBindingSource.DataSource = Me.DS_DL1
        '
        'DS_DL1
        '
        Me.DS_DL1.DataSetName = "DS_DL"
        Me.DS_DL1.EnforceConstraints = False
        Me.DS_DL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fieldCENTRORESPONSABILIDAD
        '
        Me.fieldCENTRORESPONSABILIDAD.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldCENTRORESPONSABILIDAD.AreaIndex = 1
        Me.fieldCENTRORESPONSABILIDAD.Caption = "Centro Respon."
        Me.fieldCENTRORESPONSABILIDAD.FieldName = "CENTRO_RESPONSABILIDAD"
        Me.fieldCENTRORESPONSABILIDAD.Name = "fieldCENTRORESPONSABILIDAD"
        Me.fieldCENTRORESPONSABILIDAD.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldCENTRORESPONSABILIDAD.Options.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldCENTRORESPONSABILIDAD.Options.ShowTotals = False
        Me.fieldCENTRORESPONSABILIDAD.Width = 61
        '
        'fieldCODIGOSIFP
        '
        Me.fieldCODIGOSIFP.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldCODIGOSIFP.AreaIndex = 2
        Me.fieldCODIGOSIFP.Caption = "Codigo SIFP"
        Me.fieldCODIGOSIFP.FieldName = "CODIGO_SIFP"
        Me.fieldCODIGOSIFP.Name = "fieldCODIGOSIFP"
        Me.fieldCODIGOSIFP.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldCODIGOSIFP.Options.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldCODIGOSIFP.Options.ShowTotals = False
        Me.fieldCODIGOSIFP.Width = 108
        '
        'fieldCONTRATO
        '
        Me.fieldCONTRATO.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldCONTRATO.AreaIndex = 3
        Me.fieldCONTRATO.Caption = "Contrato / OC"
        Me.fieldCONTRATO.FieldName = "CONTRATO"
        Me.fieldCONTRATO.Name = "fieldCONTRATO"
        Me.fieldCONTRATO.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldCONTRATO.Options.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldCONTRATO.Options.ShowTotals = False
        Me.fieldCONTRATO.Width = 98
        '
        'fieldCOSTOHORACURSO
        '
        Me.fieldCOSTOHORACURSO.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldCOSTOHORACURSO.AreaIndex = 18
        Me.fieldCOSTOHORACURSO.Caption = "Costo Hora"
        Me.fieldCOSTOHORACURSO.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldCOSTOHORACURSO.FieldName = "COSTO_HORA_CURSO"
        Me.fieldCOSTOHORACURSO.Name = "fieldCOSTOHORACURSO"
        '
        'fieldDEPARTAMENTO
        '
        Me.fieldDEPARTAMENTO.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldDEPARTAMENTO.AreaIndex = 4
        Me.fieldDEPARTAMENTO.Caption = "Departamento"
        Me.fieldDEPARTAMENTO.FieldName = "DEPARTAMENTO"
        Me.fieldDEPARTAMENTO.Name = "fieldDEPARTAMENTO"
        Me.fieldDEPARTAMENTO.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldDEPARTAMENTO.Options.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldDEPARTAMENTO.Options.ShowTotals = False
        Me.fieldDEPARTAMENTO.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        Me.fieldDEPARTAMENTO.Width = 60
        '
        'fieldDURACIONHORAS
        '
        Me.fieldDURACIONHORAS.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldDURACIONHORAS.AreaIndex = 0
        Me.fieldDURACIONHORAS.Caption = "Duración (Horas)"
        Me.fieldDURACIONHORAS.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldDURACIONHORAS.FieldName = "DURACION_HORAS"
        Me.fieldDURACIONHORAS.Name = "fieldDURACIONHORAS"
        '
        'fieldESTADOCURSO
        '
        Me.fieldESTADOCURSO.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldESTADOCURSO.AreaIndex = 5
        Me.fieldESTADOCURSO.Caption = "Estado Curso"
        Me.fieldESTADOCURSO.FieldName = "ESTADO_CURSO"
        Me.fieldESTADOCURSO.Name = "fieldESTADOCURSO"
        Me.fieldESTADOCURSO.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldESTADOCURSO.Options.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldESTADOCURSO.Options.ShowTotals = False
        Me.fieldESTADOCURSO.Width = 46
        '
        'fieldFECHAFINREAL
        '
        Me.fieldFECHAFINREAL.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldFECHAFINREAL.AreaIndex = 6
        Me.fieldFECHAFINREAL.Caption = "Fecha Finalización"
        Me.fieldFECHAFINREAL.FieldName = "FECHA_FIN_REAL"
        Me.fieldFECHAFINREAL.Name = "fieldFECHAFINREAL"
        Me.fieldFECHAFINREAL.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldFECHAFINREAL.Options.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldFECHAFINREAL.Options.ShowTotals = False
        Me.fieldFECHAFINREAL.Width = 54
        '
        'fieldFECHAINICIOREAL
        '
        Me.fieldFECHAINICIOREAL.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldFECHAINICIOREAL.AreaIndex = 7
        Me.fieldFECHAINICIOREAL.Caption = "Fecha Inicio"
        Me.fieldFECHAINICIOREAL.FieldName = "FECHA_INICIO_REAL"
        Me.fieldFECHAINICIOREAL.Name = "fieldFECHAINICIOREAL"
        Me.fieldFECHAINICIOREAL.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldFECHAINICIOREAL.Options.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldFECHAINICIOREAL.Options.ShowTotals = False
        Me.fieldFECHAINICIOREAL.Width = 69
        '
        'fieldHORARIO
        '
        Me.fieldHORARIO.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldHORARIO.AreaIndex = 8
        Me.fieldHORARIO.Caption = "Horario"
        Me.fieldHORARIO.FieldName = "HORARIO"
        Me.fieldHORARIO.Name = "fieldHORARIO"
        Me.fieldHORARIO.Options.ShowTotals = False
        Me.fieldHORARIO.Width = 45
        '
        'fieldINSTRUCTOR
        '
        Me.fieldINSTRUCTOR.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldINSTRUCTOR.AreaIndex = 9
        Me.fieldINSTRUCTOR.Caption = "Instructor"
        Me.fieldINSTRUCTOR.FieldName = "INSTRUCTOR"
        Me.fieldINSTRUCTOR.Name = "fieldINSTRUCTOR"
        Me.fieldINSTRUCTOR.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldINSTRUCTOR.Options.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldINSTRUCTOR.Options.ShowTotals = False
        Me.fieldINSTRUCTOR.Width = 164
        '
        'fieldLUGAREJECUCION
        '
        Me.fieldLUGAREJECUCION.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldLUGAREJECUCION.AreaIndex = 10
        Me.fieldLUGAREJECUCION.Caption = "Lugar ejecución"
        Me.fieldLUGAREJECUCION.FieldName = "LUGAR_EJECUCION"
        Me.fieldLUGAREJECUCION.Name = "fieldLUGAREJECUCION"
        Me.fieldLUGAREJECUCION.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldLUGAREJECUCION.Options.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldLUGAREJECUCION.Options.ShowTotals = False
        Me.fieldLUGAREJECUCION.Width = 62
        '
        'fieldMUNICIPIO
        '
        Me.fieldMUNICIPIO.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldMUNICIPIO.AreaIndex = 11
        Me.fieldMUNICIPIO.Caption = "Municipio"
        Me.fieldMUNICIPIO.FieldName = "MUNICIPIO"
        Me.fieldMUNICIPIO.Name = "fieldMUNICIPIO"
        Me.fieldMUNICIPIO.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldMUNICIPIO.Options.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldMUNICIPIO.Options.ShowTotals = False
        Me.fieldMUNICIPIO.Width = 56
        '
        'fieldNOMBREACCIONFORMATIVA
        '
        Me.fieldNOMBREACCIONFORMATIVA.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldNOMBREACCIONFORMATIVA.AreaIndex = 14
        Me.fieldNOMBREACCIONFORMATIVA.Caption = "Curso"
        Me.fieldNOMBREACCIONFORMATIVA.FieldName = "NOMBRE_ACCION_FORMATIVA"
        Me.fieldNOMBREACCIONFORMATIVA.Name = "fieldNOMBREACCIONFORMATIVA"
        Me.fieldNOMBREACCIONFORMATIVA.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldNOMBREACCIONFORMATIVA.Options.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldNOMBREACCIONFORMATIVA.Options.ShowTotals = False
        Me.fieldNOMBREACCIONFORMATIVA.Width = 509
        '
        'fieldNUMEROITEM
        '
        Me.fieldNUMEROITEM.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldNUMEROITEM.AreaIndex = 15
        Me.fieldNUMEROITEM.Caption = "Item / TDR"
        Me.fieldNUMEROITEM.FieldName = "NUMERO_ITEM"
        Me.fieldNUMEROITEM.Name = "fieldNUMEROITEM"
        Me.fieldNUMEROITEM.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldNUMEROITEM.Options.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldNUMEROITEM.Options.ShowTotals = False
        Me.fieldNUMEROITEM.Width = 63
        '
        'fieldPRECIOUNITARIOCURSO
        '
        Me.fieldPRECIOUNITARIOCURSO.AreaIndex = 19
        Me.fieldPRECIOUNITARIOCURSO.Caption = "Monto Contratado"
        Me.fieldPRECIOUNITARIOCURSO.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldPRECIOUNITARIOCURSO.FieldName = "PRECIO_UNITARIO_CURSO"
        Me.fieldPRECIOUNITARIOCURSO.Name = "fieldPRECIOUNITARIOCURSO"
        Me.fieldPRECIOUNITARIOCURSO.Width = 101
        '
        'fieldPROVEEDOR
        '
        Me.fieldPROVEEDOR.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldPROVEEDOR.AreaIndex = 16
        Me.fieldPROVEEDOR.Caption = "Proveedor"
        Me.fieldPROVEEDOR.FieldName = "PROVEEDOR"
        Me.fieldPROVEEDOR.Name = "fieldPROVEEDOR"
        Me.fieldPROVEEDOR.Options.AllowDragInCustomizationForm = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldPROVEEDOR.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldPROVEEDOR.Options.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldPROVEEDOR.Options.ShowTotals = False
        Me.fieldPROVEEDOR.Width = 522
        '
        'fieldREFERENTE
        '
        Me.fieldREFERENTE.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldREFERENTE.AreaIndex = 17
        Me.fieldREFERENTE.Caption = "Referente"
        Me.fieldREFERENTE.FieldName = "REFERENTE"
        Me.fieldREFERENTE.Name = "fieldREFERENTE"
        Me.fieldREFERENTE.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldREFERENTE.Options.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldREFERENTE.Options.ShowTotals = False
        Me.fieldREFERENTE.Width = 361
        '
        'fieldPARTICIPANTESACTIVOS
        '
        Me.fieldPARTICIPANTESACTIVOS.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldPARTICIPANTESACTIVOS.AreaIndex = 12
        Me.fieldPARTICIPANTESACTIVOS.Caption = "Parti. asistentes"
        Me.fieldPARTICIPANTESACTIVOS.CellFormat.FormatString = "#,#"
        Me.fieldPARTICIPANTESACTIVOS.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldPARTICIPANTESACTIVOS.FieldName = "PARTICIPANTES_ACTIVOS"
        Me.fieldPARTICIPANTESACTIVOS.Name = "fieldPARTICIPANTESACTIVOS"
        '
        'fieldPARTICIPANTESINSCRITOS
        '
        Me.fieldPARTICIPANTESINSCRITOS.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldPARTICIPANTESINSCRITOS.AreaIndex = 13
        Me.fieldPARTICIPANTESINSCRITOS.Caption = "Parti. inscritos"
        Me.fieldPARTICIPANTESINSCRITOS.CellFormat.FormatString = "#,#"
        Me.fieldPARTICIPANTESINSCRITOS.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldPARTICIPANTESINSCRITOS.FieldName = "PARTICIPANTES_INSCRITOS"
        Me.fieldPARTICIPANTESINSCRITOS.Name = "fieldPARTICIPANTESINSCRITOS"
        '
        'fieldCODIGOGRUPO
        '
        Me.fieldCODIGOGRUPO.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldCODIGOGRUPO.AreaIndex = 20
        Me.fieldCODIGOGRUPO.Caption = "Código Grupo"
        Me.fieldCODIGOGRUPO.FieldName = "CODIGO_GRUPO"
        Me.fieldCODIGOGRUPO.Name = "fieldCODIGOGRUPO"
        Me.fieldCODIGOGRUPO.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldCODIGOGRUPO.Options.ShowTotals = False
        '
        'fieldTIPOCONTRATACION
        '
        Me.fieldTIPOCONTRATACION.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldTIPOCONTRATACION.AreaIndex = 21
        Me.fieldTIPOCONTRATACION.Caption = "Tipo de Contratación"
        Me.fieldTIPOCONTRATACION.FieldName = "TIPO_CONTRATACION"
        Me.fieldTIPOCONTRATACION.Name = "fieldTIPOCONTRATACION"
        Me.fieldTIPOCONTRATACION.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldTIPOCONTRATACION.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldHOMBRESCAPACITADOS
        '
        Me.fieldHOMBRESCAPACITADOS.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldHOMBRESCAPACITADOS.AreaIndex = 25
        Me.fieldHOMBRESCAPACITADOS.Caption = "Hombres"
        Me.fieldHOMBRESCAPACITADOS.CellFormat.FormatString = "#,##0"
        Me.fieldHOMBRESCAPACITADOS.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldHOMBRESCAPACITADOS.FieldName = "HOMBRES_CAPACITADOS"
        Me.fieldHOMBRESCAPACITADOS.Name = "fieldHOMBRESCAPACITADOS"
        Me.fieldHOMBRESCAPACITADOS.TotalCellFormat.FormatString = "#,##0"
        Me.fieldHOMBRESCAPACITADOS.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldHOMBRESCAPACITADOS.TotalValueFormat.FormatString = "#,##0"
        Me.fieldHOMBRESCAPACITADOS.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldMUJERESCAPACITADAS
        '
        Me.fieldMUJERESCAPACITADAS.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldMUJERESCAPACITADAS.AreaIndex = 22
        Me.fieldMUJERESCAPACITADAS.Caption = "Mujeres"
        Me.fieldMUJERESCAPACITADAS.CellFormat.FormatString = "#,##0"
        Me.fieldMUJERESCAPACITADAS.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldMUJERESCAPACITADAS.FieldName = "MUJERES_CAPACITADAS"
        Me.fieldMUJERESCAPACITADAS.Name = "fieldMUJERESCAPACITADAS"
        Me.fieldMUJERESCAPACITADAS.ValueFormat.FormatString = "#,##0"
        Me.fieldMUJERESCAPACITADAS.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldMONTOHOMBRESCAPACITADOS
        '
        Me.fieldMONTOHOMBRESCAPACITADOS.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldMONTOHOMBRESCAPACITADOS.AreaIndex = 24
        Me.fieldMONTOHOMBRESCAPACITADOS.Caption = "Monto Hombres"
        Me.fieldMONTOHOMBRESCAPACITADOS.CellFormat.FormatString = "#,##0.00"
        Me.fieldMONTOHOMBRESCAPACITADOS.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldMONTOHOMBRESCAPACITADOS.FieldName = "MONTO_HOMBRES_CAPACITADOS"
        Me.fieldMONTOHOMBRESCAPACITADOS.Name = "fieldMONTOHOMBRESCAPACITADOS"
        Me.fieldMONTOHOMBRESCAPACITADOS.TotalCellFormat.FormatString = "#,##0.00"
        Me.fieldMONTOHOMBRESCAPACITADOS.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldMONTOMUJERESCAPACITADAS
        '
        Me.fieldMONTOMUJERESCAPACITADAS.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldMONTOMUJERESCAPACITADAS.AreaIndex = 23
        Me.fieldMONTOMUJERESCAPACITADAS.Caption = "Monto Mujeres"
        Me.fieldMONTOMUJERESCAPACITADAS.CellFormat.FormatString = "#,##0.00"
        Me.fieldMONTOMUJERESCAPACITADAS.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldMONTOMUJERESCAPACITADAS.FieldName = "MONTO_MUJERES_CAPACITADAS"
        Me.fieldMONTOMUJERESCAPACITADAS.Name = "fieldMONTOMUJERESCAPACITADAS"
        Me.fieldMONTOMUJERESCAPACITADAS.TotalCellFormat.FormatString = "#,##0.00"
        Me.fieldMONTOMUJERESCAPACITADAS.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldFECHAINGRESOSIS
        '
        Me.fieldFECHAINGRESOSIS.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldFECHAINGRESOSIS.AreaIndex = 26
        Me.fieldFECHAINGRESOSIS.Caption = "Fecha Ingreso Sistema"
        Me.fieldFECHAINGRESOSIS.FieldName = "FECHA_INGRESO_SIS"
        Me.fieldFECHAINGRESOSIS.Name = "fieldFECHAINGRESOSIS"
        Me.fieldFECHAINGRESOSIS.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldOFERTACOMPRA
        '
        Me.fieldOFERTACOMPRA.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldOFERTACOMPRA.AreaIndex = 28
        Me.fieldOFERTACOMPRA.Caption = "Oferta Compra"
        Me.fieldOFERTACOMPRA.FieldName = "OFERTA_COMPRA"
        Me.fieldOFERTACOMPRA.Name = "fieldOFERTACOMPRA"
        Me.fieldOFERTACOMPRA.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldNOMBREESTADOINFORME
        '
        Me.fieldNOMBREESTADOINFORME.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldNOMBREESTADOINFORME.AreaIndex = 27
        Me.fieldNOMBREESTADOINFORME.Caption = "Estado Informe"
        Me.fieldNOMBREESTADOINFORME.FieldName = "NOMBRE_ESTADO_INFORME"
        Me.fieldNOMBREESTADOINFORME.Name = "fieldNOMBREESTADOINFORME"
        Me.fieldNOMBREESTADOINFORME.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldNOMBREESTADOINFORME.Options.ShowTotals = False
        '
        'fieldAREAFORMACION
        '
        Me.fieldAREAFORMACION.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldAREAFORMACION.AreaIndex = 29
        Me.fieldAREAFORMACION.Caption = "Area Formativa"
        Me.fieldAREAFORMACION.FieldName = "AREA_FORMACION"
        Me.fieldAREAFORMACION.Name = "fieldAREAFORMACION"
        Me.fieldAREAFORMACION.Options.ShowTotals = False
        '
        'fieldSUBAREA
        '
        Me.fieldSUBAREA.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldSUBAREA.AreaIndex = 30
        Me.fieldSUBAREA.Caption = "Sub Area Formativa"
        Me.fieldSUBAREA.FieldName = "SUB_AREA"
        Me.fieldSUBAREA.Name = "fieldSUBAREA"
        Me.fieldSUBAREA.Options.ShowTotals = False
        '
        'fieldIDSOLICITUD
        '
        Me.fieldIDSOLICITUD.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldIDSOLICITUD.AreaIndex = 31
        Me.fieldIDSOLICITUD.Caption = "Id. Solicitud"
        Me.fieldIDSOLICITUD.FieldName = "ID_SOLICITUD"
        Me.fieldIDSOLICITUD.Name = "fieldIDSOLICITUD"
        '
        'fieldMONTOINFORME
        '
        Me.fieldMONTOINFORME.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldMONTOINFORME.AreaIndex = 32
        Me.fieldMONTOINFORME.Caption = "Monto Pago Informe"
        Me.fieldMONTOINFORME.CellFormat.FormatString = "#,##0.00"
        Me.fieldMONTOINFORME.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldMONTOINFORME.FieldName = "MONTO_INFORME"
        Me.fieldMONTOINFORME.GrandTotalCellFormat.FormatString = "#,##0.00"
        Me.fieldMONTOINFORME.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldMONTOINFORME.Name = "fieldMONTOINFORME"
        Me.fieldMONTOINFORME.Options.AllowEdit = False
        Me.fieldMONTOINFORME.Options.ShowTotals = False
        Me.fieldMONTOINFORME.TotalCellFormat.FormatString = "#,##0.00"
        Me.fieldMONTOINFORME.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldMONTOINFORME.ValueFormat.FormatString = "#,##0.00"
        Me.fieldMONTOINFORME.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldNOPRODUCTO
        '
        Me.fieldNOPRODUCTO.AreaIndex = 33
        Me.fieldNOPRODUCTO.Caption = "N° de Producto"
        Me.fieldNOPRODUCTO.FieldName = "NO_PRODUCTO"
        Me.fieldNOPRODUCTO.Name = "fieldNOPRODUCTO"
        '
        'fieldIncremento1
        '
        Me.fieldIncremento1.AreaIndex = 34
        Me.fieldIncremento1.FieldName = "Incremento"
        Me.fieldIncremento1.Name = "fieldIncremento1"
        '
        'fieldULTFECHAVISITA
        '
        Me.fieldULTFECHAVISITA.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldULTFECHAVISITA.AreaIndex = 36
        Me.fieldULTFECHAVISITA.Caption = "Fecha de ultima visita"
        Me.fieldULTFECHAVISITA.CellFormat.FormatString = "dd/MM/yyyy"
        Me.fieldULTFECHAVISITA.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldULTFECHAVISITA.FieldName = "ULT_FECHA_VISITA"
        Me.fieldULTFECHAVISITA.Name = "fieldULTFECHAVISITA"
        Me.fieldULTFECHAVISITA.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldULTFECHAVISITA.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldULTFECHAVISITA.ValueFormat.FormatString = "dd/MM/yyyy"
        Me.fieldULTFECHAVISITA.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldULTUSUARIOVISITA
        '
        Me.fieldULTUSUARIOVISITA.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldULTUSUARIOVISITA.AreaIndex = 35
        Me.fieldULTUSUARIOVISITA.Caption = "Usuario de ultima visita"
        Me.fieldULTUSUARIOVISITA.FieldName = "ULT_USUARIO_VISITA"
        Me.fieldULTUSUARIOVISITA.Name = "fieldULTUSUARIOVISITA"
        Me.fieldULTUSUARIOVISITA.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldULTUSUARIOVISITA.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldMODALIDADFORMATIVA
        '
        Me.fieldMODALIDADFORMATIVA.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldMODALIDADFORMATIVA.AreaIndex = 37
        Me.fieldMODALIDADFORMATIVA.Caption = "Modalidad formativa"
        Me.fieldMODALIDADFORMATIVA.FieldName = "MODALIDAD_FORMATIVA"
        Me.fieldMODALIDADFORMATIVA.Name = "fieldMODALIDADFORMATIVA"
        Me.fieldMODALIDADFORMATIVA.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldMODALIDADFORMATIVA.Options.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldMODALIDADFORMATIVA.Options.ShowTotals = False
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.tabDatosGrafico)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1008, 321)
        Me.SplitContainerControl1.SplitterPosition = 3
        Me.SplitContainerControl1.TabIndex = 4
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'tabDatosGrafico
        '
        Me.tabDatosGrafico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabDatosGrafico.Location = New System.Drawing.Point(0, 0)
        Me.tabDatosGrafico.Name = "tabDatosGrafico"
        Me.tabDatosGrafico.SelectedTabPage = Me.tabPageDatos
        Me.tabDatosGrafico.Size = New System.Drawing.Size(1008, 313)
        Me.tabDatosGrafico.TabIndex = 3
        Me.tabDatosGrafico.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabPageDatos, Me.tabPageGrafico})
        '
        'tabPageDatos
        '
        Me.tabPageDatos.Controls.Add(Me.PivotGridControl1)
        Me.tabPageDatos.Name = "tabPageDatos"
        Me.tabPageDatos.Size = New System.Drawing.Size(1002, 287)
        Me.tabPageDatos.Text = "Datos"
        '
        'tabPageGrafico
        '
        Me.tabPageGrafico.Controls.Add(Me.txtTituloGrafico)
        Me.tabPageGrafico.Controls.Add(Me.LabelControl2)
        Me.tabPageGrafico.Controls.Add(Me.CheckEdit1)
        Me.tabPageGrafico.Controls.Add(Me.LabelControl1)
        Me.tabPageGrafico.Controls.Add(Me.ComboBoxEdit1)
        Me.tabPageGrafico.Controls.Add(Me.ChartControl1)
        Me.tabPageGrafico.Name = "tabPageGrafico"
        Me.tabPageGrafico.Size = New System.Drawing.Size(1002, 287)
        Me.tabPageGrafico.Text = "Grafico"
        '
        'txtTituloGrafico
        '
        Me.txtTituloGrafico.EditValue = "Solicitudes por Proveedor/Centro/Curso en Periodo"
        Me.txtTituloGrafico.Location = New System.Drawing.Point(542, 12)
        Me.txtTituloGrafico.Name = "txtTituloGrafico"
        Me.txtTituloGrafico.Size = New System.Drawing.Size(256, 20)
        Me.txtTituloGrafico.TabIndex = 7
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(467, 15)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Texto Grafico:"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(319, 13)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Invertir Grafico"
        Me.CheckEdit1.Size = New System.Drawing.Size(123, 19)
        Me.CheckEdit1.TabIndex = 5
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(11, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Tipo de Grafico:"
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.EditValue = "Barras tipo Manhatan"
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(93, 12)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"Barras tipo Manhatan", "Barras 3D", "Barras en Pila 3D", "Barras 2D", "Barras en Pila 2D", "Pastel 3D", "Pastel 2D"})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(133, 20)
        Me.ComboBoxEdit1.TabIndex = 3
        '
        'ChartControl1
        '
        Me.ChartControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChartControl1.DataAdapter = Me.ProyectosEspecialesTableAdapter1
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
        Me.ChartControl1.Location = New System.Drawing.Point(10, 38)
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
        Me.ChartControl1.Size = New System.Drawing.Size(984, 326)
        Me.ChartControl1.TabIndex = 2
        ChartTitle1.Text = "Solicitudes por Proveedor/Centro/Curso en Periodo"
        Me.ChartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'ProyectosEspecialesTableAdapter1
        '
        Me.ProyectosEspecialesTableAdapter1.ClearBeforeFill = True
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.Horizontal = False
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.LayoutControl2)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.SplitContainerControl1)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(1008, 462)
        Me.SplitContainerControl2.SplitterPosition = 136
        Me.SplitContainerControl2.TabIndex = 5
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.txtNoOfertaCompra)
        Me.LayoutControl2.Controls.Add(Me.CbxUNIDAD_ORGANIZATIVA1)
        Me.LayoutControl2.Controls.Add(Me.CbxPROGRAMA_FORMACION1)
        Me.LayoutControl2.Controls.Add(Me.CbxREFERENTE1)
        Me.LayoutControl2.Controls.Add(Me.txtItem)
        Me.LayoutControl2.Controls.Add(Me.txtNoContrato)
        Me.LayoutControl2.Controls.Add(Me.CbxPROVEEDOR_AF1)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup4
        Me.LayoutControl2.Size = New System.Drawing.Size(1008, 136)
        Me.LayoutControl2.TabIndex = 1
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'txtNoOfertaCompra
        '
        Me.txtNoOfertaCompra.Location = New System.Drawing.Point(128, 62)
        Me.txtNoOfertaCompra.Name = "txtNoOfertaCompra"
        Me.txtNoOfertaCompra.Size = New System.Drawing.Size(369, 20)
        Me.txtNoOfertaCompra.TabIndex = 15
        '
        'CbxUNIDAD_ORGANIZATIVA1
        '
        Me.CbxUNIDAD_ORGANIZATIVA1.AllowFindEntityType = Nothing
        Me.CbxUNIDAD_ORGANIZATIVA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxUNIDAD_ORGANIZATIVA1.Location = New System.Drawing.Point(128, 37)
        Me.CbxUNIDAD_ORGANIZATIVA1.Name = "CbxUNIDAD_ORGANIZATIVA1"
        Me.CbxUNIDAD_ORGANIZATIVA1.Size = New System.Drawing.Size(851, 21)
        Me.CbxUNIDAD_ORGANIZATIVA1.TabIndex = 14
        '
        'CbxPROGRAMA_FORMACION1
        '
        Me.CbxPROGRAMA_FORMACION1.AllowFindEntityType = Nothing
        Me.CbxPROGRAMA_FORMACION1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxPROGRAMA_FORMACION1.Location = New System.Drawing.Point(128, 12)
        Me.CbxPROGRAMA_FORMACION1.Name = "CbxPROGRAMA_FORMACION1"
        Me.CbxPROGRAMA_FORMACION1.Size = New System.Drawing.Size(851, 21)
        Me.CbxPROGRAMA_FORMACION1.TabIndex = 13
        '
        'CbxREFERENTE1
        '
        Me.CbxREFERENTE1.AllowFindEntityType = Nothing
        Me.CbxREFERENTE1.Location = New System.Drawing.Point(617, 110)
        Me.CbxREFERENTE1.Name = "CbxREFERENTE1"
        Me.CbxREFERENTE1.Size = New System.Drawing.Size(362, 21)
        Me.CbxREFERENTE1.TabIndex = 12
        Me.CbxREFERENTE1.Text = "CbxREFERENTE1"
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(617, 62)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(362, 20)
        Me.txtItem.StyleController = Me.LayoutControl2
        Me.txtItem.TabIndex = 11
        '
        'txtNoContrato
        '
        Me.txtNoContrato.Location = New System.Drawing.Point(128, 86)
        Me.txtNoContrato.Name = "txtNoContrato"
        Me.txtNoContrato.Size = New System.Drawing.Size(369, 20)
        Me.txtNoContrato.StyleController = Me.LayoutControl2
        Me.txtNoContrato.TabIndex = 10
        '
        'CbxPROVEEDOR_AF1
        '
        Me.CbxPROVEEDOR_AF1.AllowFindEntityType = Nothing
        Me.CbxPROVEEDOR_AF1.Location = New System.Drawing.Point(128, 110)
        Me.CbxPROVEEDOR_AF1.Name = "CbxPROVEEDOR_AF1"
        Me.CbxPROVEEDOR_AF1.Size = New System.Drawing.Size(369, 21)
        Me.CbxPROVEEDOR_AF1.TabIndex = 5
        Me.CbxPROVEEDOR_AF1.Text = "CbxPROVEEDOR_AF1"
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlItem4, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem1, Me.LayoutControlItem5, Me.LayoutControlItem6})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(991, 143)
        Me.LayoutControlGroup4.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtNoContrato
        Me.LayoutControlItem7.CustomizationFormText = "Contrato / OC"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 74)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(489, 24)
        Me.LayoutControlItem7.Text = "Contrato / OC"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtItem
        Me.LayoutControlItem4.CustomizationFormText = "Item"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(489, 50)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(482, 48)
        Me.LayoutControlItem4.Text = "Item / TDR"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.CbxPROVEEDOR_AF1
        Me.LayoutControlItem2.CustomizationFormText = "Proveedor"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 98)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(489, 25)
        Me.LayoutControlItem2.Text = "Proveedor"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.CbxREFERENTE1
        Me.LayoutControlItem3.CustomizationFormText = "Referente"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(489, 98)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(482, 25)
        Me.LayoutControlItem3.Text = "Referente"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.CbxPROGRAMA_FORMACION1
        Me.LayoutControlItem1.CustomizationFormText = "Programa de Formación"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(971, 25)
        Me.LayoutControlItem1.Text = "Programa de Formación"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.CbxUNIDAD_ORGANIZATIVA1
        Me.LayoutControlItem5.CustomizationFormText = "Unidad Organizativa"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 25)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(971, 25)
        Me.LayoutControlItem5.Text = "Unidad Organizativa"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtNoOfertaCompra
        Me.LayoutControlItem6.CustomizationFormText = "N° Oferta de Compra"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(489, 24)
        Me.LayoutControlItem6.Text = "N° Oferta de Compra"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, -32)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(640, 145)
        Me.LayoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup2.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, -32)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup3.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(640, 145)
        Me.LayoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup3.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup3.TextVisible = False
        '
        'fieldCODIGOCATEG
        '
        Me.fieldCODIGOCATEG.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldCODIGOCATEG.AreaIndex = 38
        Me.fieldCODIGOCATEG.Caption = "Código Categoría"
        Me.fieldCODIGOCATEG.FieldName = "CODIGO_CATEG"
        Me.fieldCODIGOCATEG.Name = "fieldCODIGOCATEG"
        Me.fieldCODIGOCATEG.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldCODIGOCATEG.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldCODIGOCATEG.Options.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldCODIGOCATEG.Options.ShowTotals = False
        '
        'fieldNOMBRECATEG
        '
        Me.fieldNOMBRECATEG.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldNOMBRECATEG.AreaIndex = 39
        Me.fieldNOMBRECATEG.Caption = "Nombre Categoría"
        Me.fieldNOMBRECATEG.FieldName = "NOMBRE_CATEG"
        Me.fieldNOMBRECATEG.Name = "fieldNOMBRECATEG"
        Me.fieldNOMBRECATEG.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldNOMBRECATEG.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldNOMBRECATEG.Options.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldNOMBRECATEG.Options.ShowTotals = False
        '
        'frmConsultarProyEsp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 462)
        Me.Controls.Add(Me.SplitContainerControl2)
        Me.Name = "frmConsultarProyEsp"
        Me.Text = "Consultas de Cursos por Libre Gestión, Bolpros, Licitación por Bolpros"
        Me.Controls.SetChildIndex(Me.SplitContainerControl2, 0)
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosEspecialesDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.tabDatosGrafico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDatosGrafico.ResumeLayout(False)
        Me.tabPageDatos.ResumeLayout(False)
        Me.tabPageGrafico.ResumeLayout(False)
        Me.tabPageGrafico.PerformLayout()
        CType(Me.txtTituloGrafico.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram3D1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Bar3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(ManhattanBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.txtItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoContrato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    'Friend WithEvents VSOLIC_INGRESADASTableAdapter As CuboHTP.SolicitudesDataSetTableAdapters.VSOLIC_INGRESADASTableAdapter
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents tabDatosGrafico As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabPageDatos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabPageGrafico As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTituloGrafico As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents CbxPROVEEDOR_AF1 As SGAFP.WinUC.cbxPROVEEDOR_AF
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtItem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNoContrato As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DS_DL1 As SGAFP.DL.DS_DL
    Friend WithEvents ProyectosEspecialesDataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents fieldCENTRORESPONSABILIDAD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCODIGOSIFP As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCONTRATO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCOSTOHORACURSO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDEPARTAMENTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDURACIONHORAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldESTADOCURSO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHAFINREAL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHAINICIOREAL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHORARIO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldINSTRUCTOR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldLUGAREJECUCION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMUNICIPIO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBREACCIONFORMATIVA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNUMEROITEM As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPRECIOUNITARIOCURSO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPROVEEDOR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldREFERENTE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ProyectosEspecialesTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.ProyectosEspecialesTableAdapter
    Friend WithEvents CbxREFERENTE1 As SGAFP.WinUC.cbxREFERENTE
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents fieldPARTICIPANTESACTIVOS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPARTICIPANTESINSCRITOS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCODIGOGRUPO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents CbxPROGRAMA_FORMACION1 As SGAFP.WinUC.cbxPROGRAMA_FORMACION
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CbxUNIDAD_ORGANIZATIVA1 As SGAFP.WinUC.cbxUNIDAD_ORGANIZATIVA
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents fieldTIPOCONTRATACION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHOMBRESCAPACITADOS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMUJERESCAPACITADAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMONTOHOMBRESCAPACITADOS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMONTOMUJERESCAPACITADAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHAINGRESOSIS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldOFERTACOMPRA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBREESTADOINFORME As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents txtNoOfertaCompra As System.Windows.Forms.TextBox
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents fieldAREAFORMACION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSUBAREA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldIDSOLICITUD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMONTOINFORME As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOPRODUCTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldIncremento1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldULTFECHAVISITA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldULTUSUARIOVISITA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMODALIDADFORMATIVA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCODIGOCATEG As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRECATEG As DevExpress.XtraPivotGrid.PivotGridField
End Class
