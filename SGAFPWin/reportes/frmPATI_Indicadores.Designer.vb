<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPATI_Indicadores
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
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.CbxPROGRAMA_FORMACION1 = New SGAFP.WinUC.cbxPROGRAMA_FORMACION()
        Me.txtNO_CONVOCATORIA = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.bsPati_Indicadores = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_DL1 = New SGAFP.DL.DS_DL()
        Me.fieldDEPARTAMENTO1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMUNICIPIO1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldIDACCIONFORMATIVA1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBREACCIONFORMATIVA1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHAINICIOREAL1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHAFINREAL1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPARTICIPANTESFINALES1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCONVENIO1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCODIGODEPARTAMENTO1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCODIGOMUNICIPIO1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldIDESTADO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldIDPARTICIPANTE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldIDPARTICIPANTE1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PatI_INDICADORESTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.PATI_IndicadoresTableAdapter()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtNO_CONVOCATORIA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPati_Indicadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LayoutControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.PivotGridControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(999, 546)
        Me.SplitContainerControl1.SplitterPosition = 78
        Me.SplitContainerControl1.TabIndex = 4
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.CbxPROGRAMA_FORMACION1)
        Me.LayoutControl1.Controls.Add(Me.txtNO_CONVOCATORIA)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.UseDefaultDragAndDropRendering = False
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(999, 78)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'CbxPROGRAMA_FORMACION1
        '
        Me.CbxPROGRAMA_FORMACION1.AllowFindEntityType = Nothing
        Me.CbxPROGRAMA_FORMACION1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxPROGRAMA_FORMACION1.Location = New System.Drawing.Point(80, 12)
        Me.CbxPROGRAMA_FORMACION1.Name = "CbxPROGRAMA_FORMACION1"
        Me.CbxPROGRAMA_FORMACION1.Size = New System.Drawing.Size(907, 21)
        Me.CbxPROGRAMA_FORMACION1.TabIndex = 11
        '
        'txtNO_CONVOCATORIA
        '
        Me.txtNO_CONVOCATORIA.Location = New System.Drawing.Point(80, 37)
        Me.txtNO_CONVOCATORIA.Name = "txtNO_CONVOCATORIA"
        Me.txtNO_CONVOCATORIA.Size = New System.Drawing.Size(907, 20)
        Me.txtNO_CONVOCATORIA.StyleController = Me.LayoutControl1
        Me.txtNO_CONVOCATORIA.TabIndex = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlItem12})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(999, 78)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtNO_CONVOCATORIA
        Me.LayoutControlItem7.CustomizationFormText = "Convocatoria"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 25)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(979, 33)
        Me.LayoutControlItem7.Text = "Convocatoria"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(64, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.CbxPROGRAMA_FORMACION1
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(979, 25)
        Me.LayoutControlItem12.Text = "Programa"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(64, 13)
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.Appearance.Cell.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.PivotGridControl1.Appearance.Cell.Options.UseFont = True
        Me.PivotGridControl1.Appearance.ColumnHeaderArea.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.PivotGridControl1.Appearance.ColumnHeaderArea.Options.UseFont = True
        Me.PivotGridControl1.Appearance.CustomTotalCell.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.PivotGridControl1.Appearance.CustomTotalCell.Options.UseFont = True
        Me.PivotGridControl1.Appearance.DataHeaderArea.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.PivotGridControl1.Appearance.DataHeaderArea.Options.UseFont = True
        Me.PivotGridControl1.Appearance.Empty.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.PivotGridControl1.Appearance.Empty.Options.UseFont = True
        Me.PivotGridControl1.Appearance.ExpandButton.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.PivotGridControl1.Appearance.ExpandButton.Options.UseFont = True
        Me.PivotGridControl1.Appearance.FieldHeader.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.PivotGridControl1.Appearance.FieldHeader.Options.UseFont = True
        Me.PivotGridControl1.Appearance.FieldValue.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.PivotGridControl1.Appearance.FieldValue.Options.UseFont = True
        Me.PivotGridControl1.Appearance.FieldValueGrandTotal.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.PivotGridControl1.Appearance.FieldValueGrandTotal.Options.UseFont = True
        Me.PivotGridControl1.Appearance.FieldValueTotal.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.PivotGridControl1.Appearance.FieldValueTotal.Options.UseFont = True
        Me.PivotGridControl1.Appearance.FilterHeaderArea.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.PivotGridControl1.Appearance.FilterHeaderArea.Options.UseFont = True
        Me.PivotGridControl1.Appearance.FilterSeparator.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.PivotGridControl1.Appearance.FilterSeparator.Options.UseFont = True
        Me.PivotGridControl1.Appearance.FocusedCell.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.PivotGridControl1.Appearance.FocusedCell.Options.UseFont = True
        Me.PivotGridControl1.Appearance.GrandTotalCell.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.PivotGridControl1.Appearance.GrandTotalCell.Options.UseFont = True
        Me.PivotGridControl1.Appearance.HeaderArea.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.PivotGridControl1.Appearance.HeaderArea.Options.UseFont = True
        Me.PivotGridControl1.Appearance.HeaderFilterButton.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.PivotGridControl1.Appearance.HeaderFilterButton.Options.UseFont = True
        Me.PivotGridControl1.Appearance.HeaderFilterButtonActive.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.PivotGridControl1.Appearance.HeaderFilterButtonActive.Options.UseFont = True
        Me.PivotGridControl1.Appearance.HeaderGroupLine.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.PivotGridControl1.Appearance.HeaderGroupLine.Options.UseFont = True
        Me.PivotGridControl1.Appearance.Lines.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.PivotGridControl1.Appearance.Lines.Options.UseFont = True
        Me.PivotGridControl1.Appearance.RowHeaderArea.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.PivotGridControl1.Appearance.RowHeaderArea.Options.UseFont = True
        Me.PivotGridControl1.Appearance.SelectedCell.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.PivotGridControl1.Appearance.SelectedCell.Options.UseFont = True
        Me.PivotGridControl1.Appearance.TotalCell.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.PivotGridControl1.Appearance.TotalCell.Options.UseFont = True
        Me.PivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PivotGridControl1.DataSource = Me.bsPati_Indicadores
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldDEPARTAMENTO1, Me.fieldMUNICIPIO1, Me.fieldIDACCIONFORMATIVA1, Me.fieldNOMBREACCIONFORMATIVA1, Me.fieldFECHAINICIOREAL1, Me.fieldFECHAFINREAL1, Me.fieldPARTICIPANTESFINALES1, Me.fieldCONVENIO1, Me.fieldCODIGODEPARTAMENTO1, Me.fieldCODIGOMUNICIPIO1, Me.fieldIDESTADO, Me.fieldIDPARTICIPANTE, Me.fieldIDPARTICIPANTE1})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsCustomization.AllowFilter = False
        Me.PivotGridControl1.OptionsCustomization.AllowHideFields = DevExpress.XtraPivotGrid.AllowHideFieldsType.Never
        Me.PivotGridControl1.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridControl1.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridControl1.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.PivotGridControl1.OptionsPrint.PrintHeadersOnEveryPage = True
        Me.PivotGridControl1.OptionsPrint.PrintHorzLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridControl1.OptionsPrint.PrintRowHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridControl1.OptionsPrint.PrintUnusedFilterFields = False
        Me.PivotGridControl1.OptionsPrint.PrintVertLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridControl1.Size = New System.Drawing.Size(999, 463)
        Me.PivotGridControl1.TabIndex = 2
        '
        'bsPati_Indicadores
        '
        Me.bsPati_Indicadores.DataMember = "PATI_INDICADORES"
        Me.bsPati_Indicadores.DataSource = Me.DS_DL1
        '
        'DS_DL1
        '
        Me.DS_DL1.DataSetName = "DS_DL"
        Me.DS_DL1.EnforceConstraints = False
        Me.DS_DL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fieldDEPARTAMENTO1
        '
        Me.fieldDEPARTAMENTO1.AreaIndex = 0
        Me.fieldDEPARTAMENTO1.Caption = "Departamento"
        Me.fieldDEPARTAMENTO1.FieldName = "DEPARTAMENTO"
        Me.fieldDEPARTAMENTO1.Name = "fieldDEPARTAMENTO1"
        Me.fieldDEPARTAMENTO1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count
        '
        'fieldMUNICIPIO1
        '
        Me.fieldMUNICIPIO1.AreaIndex = 1
        Me.fieldMUNICIPIO1.Caption = "Municipio"
        Me.fieldMUNICIPIO1.FieldName = "MUNICIPIO"
        Me.fieldMUNICIPIO1.Name = "fieldMUNICIPIO1"
        '
        'fieldIDACCIONFORMATIVA1
        '
        Me.fieldIDACCIONFORMATIVA1.AreaIndex = 2
        Me.fieldIDACCIONFORMATIVA1.Caption = "Id Curso"
        Me.fieldIDACCIONFORMATIVA1.FieldName = "ID_ACCION_FORMATIVA"
        Me.fieldIDACCIONFORMATIVA1.Name = "fieldIDACCIONFORMATIVA1"
        Me.fieldIDACCIONFORMATIVA1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count
        '
        'fieldNOMBREACCIONFORMATIVA1
        '
        Me.fieldNOMBREACCIONFORMATIVA1.AreaIndex = 3
        Me.fieldNOMBREACCIONFORMATIVA1.Caption = "Curso"
        Me.fieldNOMBREACCIONFORMATIVA1.FieldName = "NOMBRE_ACCION_FORMATIVA"
        Me.fieldNOMBREACCIONFORMATIVA1.Name = "fieldNOMBREACCIONFORMATIVA1"
        '
        'fieldFECHAINICIOREAL1
        '
        Me.fieldFECHAINICIOREAL1.AreaIndex = 4
        Me.fieldFECHAINICIOREAL1.Caption = "Fecha inicio"
        Me.fieldFECHAINICIOREAL1.FieldName = "FECHA_INICIO_REAL"
        Me.fieldFECHAINICIOREAL1.Name = "fieldFECHAINICIOREAL1"
        '
        'fieldFECHAFINREAL1
        '
        Me.fieldFECHAFINREAL1.AreaIndex = 5
        Me.fieldFECHAFINREAL1.Caption = "Fecha finalización"
        Me.fieldFECHAFINREAL1.FieldName = "FECHA_FIN_REAL"
        Me.fieldFECHAFINREAL1.Name = "fieldFECHAFINREAL1"
        '
        'fieldPARTICIPANTESFINALES1
        '
        Me.fieldPARTICIPANTESFINALES1.AreaIndex = 6
        Me.fieldPARTICIPANTESFINALES1.Caption = "Activos"
        Me.fieldPARTICIPANTESFINALES1.CellFormat.FormatString = "n"
        Me.fieldPARTICIPANTESFINALES1.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldPARTICIPANTESFINALES1.FieldName = "PARTICIPANTES_FINALES"
        Me.fieldPARTICIPANTESFINALES1.GrandTotalCellFormat.FormatString = "n"
        Me.fieldPARTICIPANTESFINALES1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldPARTICIPANTESFINALES1.Name = "fieldPARTICIPANTESFINALES1"
        Me.fieldPARTICIPANTESFINALES1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count
        Me.fieldPARTICIPANTESFINALES1.Visible = False
        '
        'fieldCONVENIO1
        '
        Me.fieldCONVENIO1.AreaIndex = 6
        Me.fieldCONVENIO1.Caption = "Convenio"
        Me.fieldCONVENIO1.FieldName = "CONVENIO"
        Me.fieldCONVENIO1.Name = "fieldCONVENIO1"
        '
        'fieldCODIGODEPARTAMENTO1
        '
        Me.fieldCODIGODEPARTAMENTO1.AreaIndex = 8
        Me.fieldCODIGODEPARTAMENTO1.Caption = "CODIGO_DEPARTAMENTO"
        Me.fieldCODIGODEPARTAMENTO1.FieldName = "CODIGO_DEPARTAMENTO"
        Me.fieldCODIGODEPARTAMENTO1.Name = "fieldCODIGODEPARTAMENTO1"
        Me.fieldCODIGODEPARTAMENTO1.Visible = False
        '
        'fieldCODIGOMUNICIPIO1
        '
        Me.fieldCODIGOMUNICIPIO1.AreaIndex = 8
        Me.fieldCODIGOMUNICIPIO1.Caption = "CODIGO_MUNICIPIO"
        Me.fieldCODIGOMUNICIPIO1.FieldName = "CODIGO_MUNICIPIO"
        Me.fieldCODIGOMUNICIPIO1.Name = "fieldCODIGOMUNICIPIO1"
        Me.fieldCODIGOMUNICIPIO1.Visible = False
        '
        'fieldIDESTADO
        '
        Me.fieldIDESTADO.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldIDESTADO.AreaIndex = 8
        Me.fieldIDESTADO.Caption = "Id Estado"
        Me.fieldIDESTADO.FieldName = "ID_ESTADO"
        Me.fieldIDESTADO.Name = "fieldIDESTADO"
        '
        'fieldIDPARTICIPANTE
        '
        Me.fieldIDPARTICIPANTE.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldIDPARTICIPANTE.AreaIndex = 7
        Me.fieldIDPARTICIPANTE.Caption = "Cant. Participantes"
        Me.fieldIDPARTICIPANTE.CellFormat.FormatString = "#,##0"
        Me.fieldIDPARTICIPANTE.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldIDPARTICIPANTE.FieldName = "ID_PARTICIPANTE"
        Me.fieldIDPARTICIPANTE.Name = "fieldIDPARTICIPANTE"
        Me.fieldIDPARTICIPANTE.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count
        '
        'fieldIDPARTICIPANTE1
        '
        Me.fieldIDPARTICIPANTE1.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldIDPARTICIPANTE1.AreaIndex = 9
        Me.fieldIDPARTICIPANTE1.Caption = "Id Participante"
        Me.fieldIDPARTICIPANTE1.FieldName = "ID_PARTICIPANTE"
        Me.fieldIDPARTICIPANTE1.Name = "fieldIDPARTICIPANTE1"
        Me.fieldIDPARTICIPANTE1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(441, 117)
        Me.LayoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup2.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.CustomizationFormText = "Proveedor"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1008, 30)
        Me.LayoutControlItem2.Text = "Proveedor"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(100, 13)
        Me.LayoutControlItem2.TextToControlDistance = 5
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.CustomizationFormText = "Proveedor"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 30)
        Me.LayoutControlItem1.Name = "LayoutControlItem2"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1008, 30)
        Me.LayoutControlItem1.Text = "Proveedor"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(100, 13)
        Me.LayoutControlItem1.TextToControlDistance = 5
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.CustomizationFormText = "Proveedor"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 60)
        Me.LayoutControlItem3.Name = "LayoutControlItem2"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1008, 30)
        Me.LayoutControlItem3.Text = "Proveedor"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(100, 13)
        Me.LayoutControlItem3.TextToControlDistance = 5
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.CustomizationFormText = "Estado"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 90)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(1008, 30)
        Me.LayoutControlItem5.Text = "Estado Curso"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(100, 13)
        Me.LayoutControlItem5.TextToControlDistance = 5
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup4.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(1008, 97)
        Me.LayoutControlGroup4.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup4.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup5.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup5.GroupBordersVisible = False
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem5, Me.LayoutControlItem3, Me.LayoutControlItem1})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup5.OptionsItemText.TextToControlDistance = 5
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(1008, 120)
        Me.LayoutControlGroup5.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup5.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup5.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.CustomizationFormText = "Proveedor"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem2"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(498, 25)
        Me.LayoutControlItem4.Text = "Proveedor"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(100, 13)
        Me.LayoutControlItem4.TextToControlDistance = 5
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PatI_INDICADORESTableAdapter1
        '
        Me.PatI_INDICADORESTableAdapter1.ClearBeforeFill = True
        '
        'frmPATI_Indicadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 546)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "frmPATI_Indicadores"
        Me.Text = "PATI - Consulta de Cursos"
        Me.Controls.SetChildIndex(Me.SplitContainerControl1, 0)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtNO_CONVOCATORIA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPati_Indicadores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents DS_DL1 As SGAFP.DL.DS_DL
    Friend WithEvents txtNO_CONVOCATORIA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsPati_Indicadores As System.Windows.Forms.BindingSource
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CbxPROGRAMA_FORMACION1 As SGAFP.WinUC.cbxPROGRAMA_FORMACION
    Friend WithEvents PatI_INDICADORESTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.PATI_INDICADORESTableAdapter
    Friend WithEvents fieldIDACCIONFORMATIVA1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBREACCIONFORMATIVA1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHAINICIOREAL1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHAFINREAL1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPARTICIPANTESFINALES1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCONVENIO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCODIGODEPARTAMENTO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCODIGOMUNICIPIO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDEPARTAMENTO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMUNICIPIO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldIDESTADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldIDPARTICIPANTE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldIDPARTICIPANTE1 As DevExpress.XtraPivotGrid.PivotGridField
End Class
