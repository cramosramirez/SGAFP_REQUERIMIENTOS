<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCursosProgramaPATI
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
        Me.CbxESTADO_ACCION_FORMATIVA1 = New SGAFP.WinUC.cbxESTADO_ACCION_FORMATIVA()
        Me.txtOrdenCompra = New DevExpress.XtraEditors.TextEdit()
        Me.txtTDR = New DevExpress.XtraEditors.TextEdit()
        Me.CbxPROVEEDOR_AF1 = New SGAFP.WinUC.cbxPROVEEDOR_AF()
        Me.txtNO_CONVOCATORIA = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.bsPatiEjecucion = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_DL1 = New SGAFP.DL.DS_DL()
        Me.fieldNOMBREDEPARTAMENTO1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBREMUNICIPIO1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPROVEEDOR1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTDR1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRESOLUCION1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBREACCIONFORMATIVA1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCODIGOGRUPO1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHORARIO1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHAINICIOREAL1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHAFINREAL1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCODIGOESTADOAF1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMONTO1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNUMERODOCUMENTO1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNUMEROQUEDAN1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHAQUEDAN1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNUMEROCHEQUE1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHACHEQUE1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldIDACCIONFORMATIVA1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCOSTOXPARTICIPANTE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMONTOFUENTE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSEXO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBREESTADOAF = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHAELABORACION = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOLIQUIDACION = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSOLICITADOS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldINSCRITOS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldINICIADOS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldACTIVOS1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCOSTO_X_PARTICIPANTE_PROMEDIO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRANGO_INICIADOS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRANGO_INSCRITOS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBREFUENTE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOCONVOCATORIA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHOMBRES = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMUJERES = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOTAS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHARECEPCION = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHOMBRESCAPACITADOS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHOMBRESCAPACITADOSMONTO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMUJERESCAPACITADAS = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMUJERESCAPACITADASMONTO = New DevExpress.XtraPivotGrid.PivotGridField()
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
        Me.PatiEjecucionTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.PATIEjecucionTableAdapter()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtOrdenCompra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTDR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNO_CONVOCATORIA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPatiEjecucion, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1020, 569)
        Me.SplitContainerControl1.SplitterPosition = 95
        Me.SplitContainerControl1.TabIndex = 4
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.CbxPROGRAMA_FORMACION1)
        Me.LayoutControl1.Controls.Add(Me.CbxESTADO_ACCION_FORMATIVA1)
        Me.LayoutControl1.Controls.Add(Me.txtOrdenCompra)
        Me.LayoutControl1.Controls.Add(Me.txtTDR)
        Me.LayoutControl1.Controls.Add(Me.CbxPROVEEDOR_AF1)
        Me.LayoutControl1.Controls.Add(Me.txtNO_CONVOCATORIA)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.UseDefaultDragAndDropRendering = False
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1020, 95)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'CbxPROGRAMA_FORMACION1
        '
        Me.CbxPROGRAMA_FORMACION1.AllowFindEntityType = Nothing
        Me.CbxPROGRAMA_FORMACION1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxPROGRAMA_FORMACION1.Location = New System.Drawing.Point(101, 12)
        Me.CbxPROGRAMA_FORMACION1.Name = "CbxPROGRAMA_FORMACION1"
        Me.CbxPROGRAMA_FORMACION1.Size = New System.Drawing.Size(350, 21)
        Me.CbxPROGRAMA_FORMACION1.TabIndex = 11
        '
        'CbxESTADO_ACCION_FORMATIVA1
        '
        Me.CbxESTADO_ACCION_FORMATIVA1.AllowFindEntityType = Nothing
        Me.CbxESTADO_ACCION_FORMATIVA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxESTADO_ACCION_FORMATIVA1.Location = New System.Drawing.Point(101, 61)
        Me.CbxESTADO_ACCION_FORMATIVA1.Name = "CbxESTADO_ACCION_FORMATIVA1"
        Me.CbxESTADO_ACCION_FORMATIVA1.Size = New System.Drawing.Size(350, 21)
        Me.CbxESTADO_ACCION_FORMATIVA1.TabIndex = 9
        '
        'txtOrdenCompra
        '
        Me.txtOrdenCompra.Location = New System.Drawing.Point(544, 61)
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.Size = New System.Drawing.Size(464, 20)
        Me.txtOrdenCompra.StyleController = Me.LayoutControl1
        Me.txtOrdenCompra.TabIndex = 8
        '
        'txtTDR
        '
        Me.txtTDR.Location = New System.Drawing.Point(544, 37)
        Me.txtTDR.Name = "txtTDR"
        Me.txtTDR.Size = New System.Drawing.Size(464, 20)
        Me.txtTDR.StyleController = Me.LayoutControl1
        Me.txtTDR.TabIndex = 7
        '
        'CbxPROVEEDOR_AF1
        '
        Me.CbxPROVEEDOR_AF1.AllowFindEntityType = Nothing
        Me.CbxPROVEEDOR_AF1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxPROVEEDOR_AF1.Location = New System.Drawing.Point(544, 12)
        Me.CbxPROVEEDOR_AF1.Name = "CbxPROVEEDOR_AF1"
        Me.CbxPROVEEDOR_AF1.Size = New System.Drawing.Size(464, 21)
        Me.CbxPROVEEDOR_AF1.TabIndex = 6
        '
        'txtNO_CONVOCATORIA
        '
        Me.txtNO_CONVOCATORIA.Location = New System.Drawing.Point(101, 37)
        Me.txtNO_CONVOCATORIA.Name = "txtNO_CONVOCATORIA"
        Me.txtNO_CONVOCATORIA.Size = New System.Drawing.Size(350, 20)
        Me.txtNO_CONVOCATORIA.StyleController = Me.LayoutControl1
        Me.txtNO_CONVOCATORIA.TabIndex = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlItem9, Me.LayoutControlItem8, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1020, 95)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtNO_CONVOCATORIA
        Me.LayoutControlItem7.CustomizationFormText = "Convocatoria"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 25)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(443, 24)
        Me.LayoutControlItem7.Text = "Convocatoria"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(85, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtTDR
        Me.LayoutControlItem9.CustomizationFormText = "TDR"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(443, 25)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(557, 24)
        Me.LayoutControlItem9.Text = "TDR"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(85, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.CbxPROVEEDOR_AF1
        Me.LayoutControlItem8.CustomizationFormText = "Proveedor"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(443, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(557, 25)
        Me.LayoutControlItem8.Text = "Proveedor"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(85, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtOrdenCompra
        Me.LayoutControlItem10.CustomizationFormText = "Orden de Compra"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(443, 49)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(557, 26)
        Me.LayoutControlItem10.Text = "Orden de Compra"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(85, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.CbxESTADO_ACCION_FORMATIVA1
        Me.LayoutControlItem11.CustomizationFormText = "Estado Curso"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 49)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(443, 26)
        Me.LayoutControlItem11.Text = "Estado Curso"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(85, 13)
        Me.LayoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.CbxPROGRAMA_FORMACION1
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(443, 25)
        Me.LayoutControlItem12.Text = "Programa"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(85, 13)
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
        Me.PivotGridControl1.DataSource = Me.bsPatiEjecucion
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldNOMBREDEPARTAMENTO1, Me.fieldNOMBREMUNICIPIO1, Me.fieldPROVEEDOR1, Me.fieldTDR1, Me.fieldRESOLUCION1, Me.fieldNOMBREACCIONFORMATIVA1, Me.fieldCODIGOGRUPO1, Me.fieldHORARIO1, Me.fieldFECHAINICIOREAL1, Me.fieldFECHAFINREAL1, Me.fieldCODIGOESTADOAF1, Me.fieldMONTO1, Me.fieldNUMERODOCUMENTO1, Me.fieldNUMEROQUEDAN1, Me.fieldFECHAQUEDAN1, Me.fieldNUMEROCHEQUE1, Me.fieldFECHACHEQUE1, Me.fieldIDACCIONFORMATIVA1, Me.fieldCOSTOXPARTICIPANTE, Me.fieldMONTOFUENTE, Me.fieldSEXO, Me.fieldNOMBREESTADOAF, Me.PivotGridField1, Me.fieldFECHAELABORACION, Me.fieldNOLIQUIDACION, Me.fieldSOLICITADOS, Me.fieldINSCRITOS, Me.fieldINICIADOS, Me.fieldACTIVOS1, Me.fieldCOSTO_X_PARTICIPANTE_PROMEDIO, Me.fieldRANGO_INICIADOS, Me.fieldRANGO_INSCRITOS, Me.fieldNOMBREFUENTE, Me.fieldNOCONVOCATORIA, Me.fieldHOMBRES, Me.fieldMUJERES, Me.fieldNOTAS, Me.fieldFECHARECEPCION, Me.fieldHOMBRESCAPACITADOS, Me.fieldHOMBRESCAPACITADOSMONTO, Me.fieldMUJERESCAPACITADAS, Me.fieldMUJERESCAPACITADASMONTO})
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
        Me.PivotGridControl1.Size = New System.Drawing.Size(1020, 469)
        Me.PivotGridControl1.TabIndex = 2
        '
        'bsPatiEjecucion
        '
        Me.bsPatiEjecucion.DataMember = "PATIEjecucion"
        Me.bsPatiEjecucion.DataSource = Me.DS_DL1
        '
        'DS_DL1
        '
        Me.DS_DL1.DataSetName = "DS_DL"
        Me.DS_DL1.EnforceConstraints = False
        Me.DS_DL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fieldNOMBREDEPARTAMENTO1
        '
        Me.fieldNOMBREDEPARTAMENTO1.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldNOMBREDEPARTAMENTO1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldNOMBREDEPARTAMENTO1.AreaIndex = 2
        Me.fieldNOMBREDEPARTAMENTO1.Caption = "Departamento"
        Me.fieldNOMBREDEPARTAMENTO1.FieldName = "NOMBRE_DEPARTAMENTO"
        Me.fieldNOMBREDEPARTAMENTO1.Name = "fieldNOMBREDEPARTAMENTO1"
        Me.fieldNOMBREDEPARTAMENTO1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldNOMBREDEPARTAMENTO1.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        '
        'fieldNOMBREMUNICIPIO1
        '
        Me.fieldNOMBREMUNICIPIO1.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldNOMBREMUNICIPIO1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldNOMBREMUNICIPIO1.AreaIndex = 1
        Me.fieldNOMBREMUNICIPIO1.Caption = "Municipio"
        Me.fieldNOMBREMUNICIPIO1.FieldName = "NOMBRE_MUNICIPIO"
        Me.fieldNOMBREMUNICIPIO1.Name = "fieldNOMBREMUNICIPIO1"
        Me.fieldNOMBREMUNICIPIO1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldNOMBREMUNICIPIO1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldNOMBREMUNICIPIO1.Options.ShowGrandTotal = False
        Me.fieldNOMBREMUNICIPIO1.Options.ShowTotals = False
        Me.fieldNOMBREMUNICIPIO1.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        '
        'fieldPROVEEDOR1
        '
        Me.fieldPROVEEDOR1.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldPROVEEDOR1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldPROVEEDOR1.AreaIndex = 0
        Me.fieldPROVEEDOR1.Caption = "Proveedor"
        Me.fieldPROVEEDOR1.FieldName = "PROVEEDOR"
        Me.fieldPROVEEDOR1.Name = "fieldPROVEEDOR1"
        Me.fieldPROVEEDOR1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldPROVEEDOR1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldPROVEEDOR1.Options.ShowGrandTotal = False
        Me.fieldPROVEEDOR1.Options.ShowTotals = False
        Me.fieldPROVEEDOR1.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        Me.fieldPROVEEDOR1.Width = 200
        '
        'fieldTDR1
        '
        Me.fieldTDR1.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldTDR1.AreaIndex = 9
        Me.fieldTDR1.Caption = "TDR"
        Me.fieldTDR1.FieldName = "TDR"
        Me.fieldTDR1.Name = "fieldTDR1"
        Me.fieldTDR1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldTDR1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldTDR1.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        '
        'fieldRESOLUCION1
        '
        Me.fieldRESOLUCION1.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldRESOLUCION1.AreaIndex = 10
        Me.fieldRESOLUCION1.Caption = "O/C"
        Me.fieldRESOLUCION1.FieldName = "RESOLUCION"
        Me.fieldRESOLUCION1.Name = "fieldRESOLUCION1"
        Me.fieldRESOLUCION1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldRESOLUCION1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldRESOLUCION1.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        '
        'fieldNOMBREACCIONFORMATIVA1
        '
        Me.fieldNOMBREACCIONFORMATIVA1.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldNOMBREACCIONFORMATIVA1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldNOMBREACCIONFORMATIVA1.AreaIndex = 3
        Me.fieldNOMBREACCIONFORMATIVA1.Caption = "Curso"
        Me.fieldNOMBREACCIONFORMATIVA1.FieldName = "NOMBRE_ACCION_FORMATIVA"
        Me.fieldNOMBREACCIONFORMATIVA1.Name = "fieldNOMBREACCIONFORMATIVA1"
        Me.fieldNOMBREACCIONFORMATIVA1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldNOMBREACCIONFORMATIVA1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldNOMBREACCIONFORMATIVA1.Options.ShowGrandTotal = False
        Me.fieldNOMBREACCIONFORMATIVA1.Options.ShowTotals = False
        Me.fieldNOMBREACCIONFORMATIVA1.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        Me.fieldNOMBREACCIONFORMATIVA1.Width = 200
        '
        'fieldCODIGOGRUPO1
        '
        Me.fieldCODIGOGRUPO1.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldCODIGOGRUPO1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldCODIGOGRUPO1.AreaIndex = 4
        Me.fieldCODIGOGRUPO1.Caption = "Código Grupo"
        Me.fieldCODIGOGRUPO1.FieldName = "CODIGO_GRUPO"
        Me.fieldCODIGOGRUPO1.Name = "fieldCODIGOGRUPO1"
        Me.fieldCODIGOGRUPO1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldCODIGOGRUPO1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldCODIGOGRUPO1.Options.ShowGrandTotal = False
        Me.fieldCODIGOGRUPO1.Options.ShowTotals = False
        Me.fieldCODIGOGRUPO1.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        '
        'fieldHORARIO1
        '
        Me.fieldHORARIO1.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldHORARIO1.AreaIndex = 0
        Me.fieldHORARIO1.Caption = "Horario"
        Me.fieldHORARIO1.FieldName = "HORARIO"
        Me.fieldHORARIO1.Name = "fieldHORARIO1"
        Me.fieldHORARIO1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldHORARIO1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldHORARIO1.Options.ShowGrandTotal = False
        Me.fieldHORARIO1.Options.ShowTotals = False
        Me.fieldHORARIO1.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        '
        'fieldFECHAINICIOREAL1
        '
        Me.fieldFECHAINICIOREAL1.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldFECHAINICIOREAL1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldFECHAINICIOREAL1.AreaIndex = 5
        Me.fieldFECHAINICIOREAL1.Caption = "Inicio"
        Me.fieldFECHAINICIOREAL1.FieldName = "FECHA_INICIO_REAL"
        Me.fieldFECHAINICIOREAL1.Name = "fieldFECHAINICIOREAL1"
        Me.fieldFECHAINICIOREAL1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldFECHAINICIOREAL1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldFECHAINICIOREAL1.Options.ShowGrandTotal = False
        Me.fieldFECHAINICIOREAL1.Options.ShowTotals = False
        Me.fieldFECHAINICIOREAL1.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        Me.fieldFECHAINICIOREAL1.ValueFormat.FormatString = "dd/MM/yyyy"
        Me.fieldFECHAINICIOREAL1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldFECHAFINREAL1
        '
        Me.fieldFECHAFINREAL1.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldFECHAFINREAL1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldFECHAFINREAL1.AreaIndex = 6
        Me.fieldFECHAFINREAL1.Caption = "Finalización"
        Me.fieldFECHAFINREAL1.FieldName = "FECHA_FIN_REAL"
        Me.fieldFECHAFINREAL1.Name = "fieldFECHAFINREAL1"
        Me.fieldFECHAFINREAL1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldFECHAFINREAL1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldFECHAFINREAL1.Options.ShowGrandTotal = False
        Me.fieldFECHAFINREAL1.Options.ShowTotals = False
        Me.fieldFECHAFINREAL1.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        Me.fieldFECHAFINREAL1.ValueFormat.FormatString = "dd/MM/yyyy"
        Me.fieldFECHAFINREAL1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldCODIGOESTADOAF1
        '
        Me.fieldCODIGOESTADOAF1.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldCODIGOESTADOAF1.AreaIndex = 1
        Me.fieldCODIGOESTADOAF1.Caption = "Codigo Estado"
        Me.fieldCODIGOESTADOAF1.FieldName = "CODIGO_ESTADO_AF"
        Me.fieldCODIGOESTADOAF1.Name = "fieldCODIGOESTADOAF1"
        Me.fieldCODIGOESTADOAF1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldCODIGOESTADOAF1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldCODIGOESTADOAF1.Options.ShowGrandTotal = False
        Me.fieldCODIGOESTADOAF1.Options.ShowTotals = False
        Me.fieldCODIGOESTADOAF1.Visible = False
        '
        'fieldMONTO1
        '
        Me.fieldMONTO1.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldMONTO1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldMONTO1.AreaIndex = 1
        Me.fieldMONTO1.Caption = "Costo Curso"
        Me.fieldMONTO1.CellFormat.FormatString = "#,##0.00"
        Me.fieldMONTO1.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldMONTO1.FieldName = "MONTO"
        Me.fieldMONTO1.GrandTotalCellFormat.FormatString = "#,##0.00"
        Me.fieldMONTO1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldMONTO1.Name = "fieldMONTO1"
        Me.fieldMONTO1.ValueFormat.FormatString = "#,##0.00"
        Me.fieldMONTO1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldNUMERODOCUMENTO1
        '
        Me.fieldNUMERODOCUMENTO1.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldNUMERODOCUMENTO1.AreaIndex = 1
        Me.fieldNUMERODOCUMENTO1.Caption = "N° Factura"
        Me.fieldNUMERODOCUMENTO1.FieldName = "NUMERO_DOCUMENTO"
        Me.fieldNUMERODOCUMENTO1.Name = "fieldNUMERODOCUMENTO1"
        Me.fieldNUMERODOCUMENTO1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldNUMERODOCUMENTO1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldNUMERODOCUMENTO1.Options.ShowGrandTotal = False
        Me.fieldNUMERODOCUMENTO1.Options.ShowTotals = False
        Me.fieldNUMERODOCUMENTO1.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        '
        'fieldNUMEROQUEDAN1
        '
        Me.fieldNUMEROQUEDAN1.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldNUMEROQUEDAN1.AreaIndex = 3
        Me.fieldNUMEROQUEDAN1.Caption = "N° Quedan"
        Me.fieldNUMEROQUEDAN1.FieldName = "NUMERO_QUEDAN"
        Me.fieldNUMEROQUEDAN1.Name = "fieldNUMEROQUEDAN1"
        Me.fieldNUMEROQUEDAN1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldNUMEROQUEDAN1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldNUMEROQUEDAN1.Options.ShowGrandTotal = False
        Me.fieldNUMEROQUEDAN1.Options.ShowTotals = False
        Me.fieldNUMEROQUEDAN1.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        '
        'fieldFECHAQUEDAN1
        '
        Me.fieldFECHAQUEDAN1.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldFECHAQUEDAN1.AreaIndex = 4
        Me.fieldFECHAQUEDAN1.Caption = "Fecha Quedan"
        Me.fieldFECHAQUEDAN1.FieldName = "FECHA_QUEDAN"
        Me.fieldFECHAQUEDAN1.Name = "fieldFECHAQUEDAN1"
        Me.fieldFECHAQUEDAN1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldFECHAQUEDAN1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldFECHAQUEDAN1.Options.ShowGrandTotal = False
        Me.fieldFECHAQUEDAN1.Options.ShowTotals = False
        Me.fieldFECHAQUEDAN1.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        Me.fieldFECHAQUEDAN1.ValueFormat.FormatString = "dd/MM/yyyy"
        Me.fieldFECHAQUEDAN1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldNUMEROCHEQUE1
        '
        Me.fieldNUMEROCHEQUE1.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldNUMEROCHEQUE1.AreaIndex = 5
        Me.fieldNUMEROCHEQUE1.Caption = "N° Cheque"
        Me.fieldNUMEROCHEQUE1.FieldName = "NUMERO_CHEQUE"
        Me.fieldNUMEROCHEQUE1.Name = "fieldNUMEROCHEQUE1"
        Me.fieldNUMEROCHEQUE1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldNUMEROCHEQUE1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldNUMEROCHEQUE1.Options.ShowGrandTotal = False
        Me.fieldNUMEROCHEQUE1.Options.ShowTotals = False
        Me.fieldNUMEROCHEQUE1.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        '
        'fieldFECHACHEQUE1
        '
        Me.fieldFECHACHEQUE1.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldFECHACHEQUE1.AreaIndex = 6
        Me.fieldFECHACHEQUE1.Caption = "Fecha Cheque"
        Me.fieldFECHACHEQUE1.FieldName = "FECHA_CHEQUE"
        Me.fieldFECHACHEQUE1.Name = "fieldFECHACHEQUE1"
        Me.fieldFECHACHEQUE1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldFECHACHEQUE1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldFECHACHEQUE1.Options.ShowGrandTotal = False
        Me.fieldFECHACHEQUE1.Options.ShowTotals = False
        Me.fieldFECHACHEQUE1.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        Me.fieldFECHACHEQUE1.ValueFormat.FormatString = "dd/MM/yyyy"
        Me.fieldFECHACHEQUE1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldIDACCIONFORMATIVA1
        '
        Me.fieldIDACCIONFORMATIVA1.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldIDACCIONFORMATIVA1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldIDACCIONFORMATIVA1.AreaIndex = 0
        Me.fieldIDACCIONFORMATIVA1.Caption = "Cantidad Cursos"
        Me.fieldIDACCIONFORMATIVA1.CellFormat.FormatString = "#,##0"
        Me.fieldIDACCIONFORMATIVA1.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldIDACCIONFORMATIVA1.FieldName = "ID_ACCION_FORMATIVA"
        Me.fieldIDACCIONFORMATIVA1.Name = "fieldIDACCIONFORMATIVA1"
        Me.fieldIDACCIONFORMATIVA1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldIDACCIONFORMATIVA1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldIDACCIONFORMATIVA1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.fieldIDACCIONFORMATIVA1.ValueFormat.FormatString = "#,##0"
        Me.fieldIDACCIONFORMATIVA1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldCOSTOXPARTICIPANTE
        '
        Me.fieldCOSTOXPARTICIPANTE.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldCOSTOXPARTICIPANTE.AreaIndex = 7
        Me.fieldCOSTOXPARTICIPANTE.Caption = "Costo Participante"
        Me.fieldCOSTOXPARTICIPANTE.CellFormat.FormatString = "#,##0.#"
        Me.fieldCOSTOXPARTICIPANTE.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldCOSTOXPARTICIPANTE.FieldName = "COSTO_X_PARTICIPANTE"
        Me.fieldCOSTOXPARTICIPANTE.GrandTotalCellFormat.FormatString = "#,##0.#"
        Me.fieldCOSTOXPARTICIPANTE.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldCOSTOXPARTICIPANTE.Name = "fieldCOSTOXPARTICIPANTE"
        Me.fieldCOSTOXPARTICIPANTE.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldCOSTOXPARTICIPANTE.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldCOSTOXPARTICIPANTE.TotalCellFormat.FormatString = "#,##0.#"
        Me.fieldCOSTOXPARTICIPANTE.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldCOSTOXPARTICIPANTE.TotalValueFormat.FormatString = "#,##0.#"
        Me.fieldCOSTOXPARTICIPANTE.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldCOSTOXPARTICIPANTE.ValueFormat.FormatString = "#,##0.#"
        Me.fieldCOSTOXPARTICIPANTE.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldMONTOFUENTE
        '
        Me.fieldMONTOFUENTE.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldMONTOFUENTE.AreaIndex = 8
        Me.fieldMONTOFUENTE.Caption = "Costo Liquidacion"
        Me.fieldMONTOFUENTE.CellFormat.FormatString = "#,##0.00"
        Me.fieldMONTOFUENTE.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldMONTOFUENTE.FieldName = "MONTO_FUENTE"
        Me.fieldMONTOFUENTE.GrandTotalCellFormat.FormatString = "#,##0.00"
        Me.fieldMONTOFUENTE.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldMONTOFUENTE.Name = "fieldMONTOFUENTE"
        Me.fieldMONTOFUENTE.TotalCellFormat.FormatString = "#,##0.00"
        Me.fieldMONTOFUENTE.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldMONTOFUENTE.TotalValueFormat.FormatString = "#,##0.00"
        Me.fieldMONTOFUENTE.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldMONTOFUENTE.ValueFormat.FormatString = "#,##0.00"
        Me.fieldMONTOFUENTE.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldSEXO
        '
        Me.fieldSEXO.AreaIndex = 2
        Me.fieldSEXO.Caption = "Sexo"
        Me.fieldSEXO.FieldName = "SEXO"
        Me.fieldSEXO.Name = "fieldSEXO"
        Me.fieldSEXO.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldSEXO.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldNOMBREESTADOAF
        '
        Me.fieldNOMBREESTADOAF.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldNOMBREESTADOAF.AreaIndex = 11
        Me.fieldNOMBREESTADOAF.Caption = "Estado Curso"
        Me.fieldNOMBREESTADOAF.FieldName = "NOMBRE_ESTADO_AF"
        Me.fieldNOMBREESTADOAF.Name = "fieldNOMBREESTADOAF"
        Me.fieldNOMBREESTADOAF.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldNOMBREESTADOAF.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'PivotGridField1
        '
        Me.PivotGridField1.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.PivotGridField1.AreaIndex = 12
        Me.PivotGridField1.Caption = "AUP"
        Me.PivotGridField1.FieldName = "fieldAUP"
        Me.PivotGridField1.Name = "PivotGridField1"
        Me.PivotGridField1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridField1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridField1.UnboundFieldName = "fieldAUP"
        Me.PivotGridField1.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        '
        'fieldFECHAELABORACION
        '
        Me.fieldFECHAELABORACION.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldFECHAELABORACION.AreaIndex = 13
        Me.fieldFECHAELABORACION.Caption = "Fecha Liquidacion"
        Me.fieldFECHAELABORACION.CellFormat.FormatString = "dd/MM/yyyy"
        Me.fieldFECHAELABORACION.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldFECHAELABORACION.FieldName = "FECHA_ELABORACION"
        Me.fieldFECHAELABORACION.Name = "fieldFECHAELABORACION"
        Me.fieldFECHAELABORACION.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldFECHAELABORACION.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldFECHAELABORACION.ValueFormat.FormatString = "dd/MM/yyyy"
        Me.fieldFECHAELABORACION.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldNOLIQUIDACION
        '
        Me.fieldNOLIQUIDACION.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldNOLIQUIDACION.AreaIndex = 14
        Me.fieldNOLIQUIDACION.Caption = "N° Liquidacion"
        Me.fieldNOLIQUIDACION.CellFormat.FormatString = "d"
        Me.fieldNOLIQUIDACION.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldNOLIQUIDACION.FieldName = "NO_LIQUIDACION"
        Me.fieldNOLIQUIDACION.Name = "fieldNOLIQUIDACION"
        Me.fieldNOLIQUIDACION.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldNOLIQUIDACION.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldNOLIQUIDACION.ValueFormat.FormatString = "d"
        Me.fieldNOLIQUIDACION.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldSOLICITADOS
        '
        Me.fieldSOLICITADOS.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldSOLICITADOS.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldSOLICITADOS.AreaIndex = 2
        Me.fieldSOLICITADOS.Caption = "Solicitados"
        Me.fieldSOLICITADOS.CellFormat.FormatString = "#,##0"
        Me.fieldSOLICITADOS.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldSOLICITADOS.FieldName = "SOLICITADOS"
        Me.fieldSOLICITADOS.GrandTotalCellFormat.FormatString = "#,##0"
        Me.fieldSOLICITADOS.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldSOLICITADOS.Name = "fieldSOLICITADOS"
        Me.fieldSOLICITADOS.TotalCellFormat.FormatString = "#,##0"
        Me.fieldSOLICITADOS.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldSOLICITADOS.TotalValueFormat.FormatString = "#,##0"
        Me.fieldSOLICITADOS.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldSOLICITADOS.ValueFormat.FormatString = "#,##0"
        Me.fieldSOLICITADOS.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldINSCRITOS
        '
        Me.fieldINSCRITOS.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldINSCRITOS.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldINSCRITOS.AreaIndex = 3
        Me.fieldINSCRITOS.Caption = "Inscritos"
        Me.fieldINSCRITOS.CellFormat.FormatString = "#,##0"
        Me.fieldINSCRITOS.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldINSCRITOS.FieldName = "INSCRITOS"
        Me.fieldINSCRITOS.GrandTotalCellFormat.FormatString = "#,##0"
        Me.fieldINSCRITOS.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldINSCRITOS.Name = "fieldINSCRITOS"
        Me.fieldINSCRITOS.TotalCellFormat.FormatString = "#,##0"
        Me.fieldINSCRITOS.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldINSCRITOS.TotalValueFormat.FormatString = "#,##0"
        Me.fieldINSCRITOS.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldINSCRITOS.ValueFormat.FormatString = "#,##0"
        Me.fieldINSCRITOS.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldINICIADOS
        '
        Me.fieldINICIADOS.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldINICIADOS.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldINICIADOS.AreaIndex = 4
        Me.fieldINICIADOS.Caption = "Iniciados"
        Me.fieldINICIADOS.CellFormat.FormatString = "#,##0"
        Me.fieldINICIADOS.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldINICIADOS.FieldName = "INICIADOS"
        Me.fieldINICIADOS.GrandTotalCellFormat.FormatString = "#,##0"
        Me.fieldINICIADOS.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldINICIADOS.Name = "fieldINICIADOS"
        Me.fieldINICIADOS.ValueFormat.FormatString = "#,##0"
        Me.fieldINICIADOS.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldACTIVOS1
        '
        Me.fieldACTIVOS1.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldACTIVOS1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldACTIVOS1.AreaIndex = 5
        Me.fieldACTIVOS1.Caption = "Activos"
        Me.fieldACTIVOS1.CellFormat.FormatString = "#,##0"
        Me.fieldACTIVOS1.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldACTIVOS1.FieldName = "ACTIVOS"
        Me.fieldACTIVOS1.GrandTotalCellFormat.FormatString = "#,##0"
        Me.fieldACTIVOS1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldACTIVOS1.Name = "fieldACTIVOS1"
        Me.fieldACTIVOS1.TotalCellFormat.FormatString = "#,##0"
        Me.fieldACTIVOS1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldACTIVOS1.TotalValueFormat.FormatString = "#,##0"
        Me.fieldACTIVOS1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldACTIVOS1.ValueFormat.FormatString = "#,##0"
        Me.fieldACTIVOS1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldCOSTO_X_PARTICIPANTE_PROMEDIO
        '
        Me.fieldCOSTO_X_PARTICIPANTE_PROMEDIO.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldCOSTO_X_PARTICIPANTE_PROMEDIO.AreaIndex = 17
        Me.fieldCOSTO_X_PARTICIPANTE_PROMEDIO.Caption = "Costo Promedio Participante"
        Me.fieldCOSTO_X_PARTICIPANTE_PROMEDIO.CellFormat.FormatString = "#,##0.#"
        Me.fieldCOSTO_X_PARTICIPANTE_PROMEDIO.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldCOSTO_X_PARTICIPANTE_PROMEDIO.GrandTotalCellFormat.FormatString = "#,##0.#"
        Me.fieldCOSTO_X_PARTICIPANTE_PROMEDIO.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldCOSTO_X_PARTICIPANTE_PROMEDIO.Name = "fieldCOSTO_X_PARTICIPANTE_PROMEDIO"
        Me.fieldCOSTO_X_PARTICIPANTE_PROMEDIO.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.fieldCOSTO_X_PARTICIPANTE_PROMEDIO.TotalCellFormat.FormatString = "#,##0.#"
        Me.fieldCOSTO_X_PARTICIPANTE_PROMEDIO.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldCOSTO_X_PARTICIPANTE_PROMEDIO.TotalValueFormat.FormatString = "#,##0.#"
        Me.fieldCOSTO_X_PARTICIPANTE_PROMEDIO.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldCOSTO_X_PARTICIPANTE_PROMEDIO.ValueFormat.FormatString = "#,##0.#"
        Me.fieldCOSTO_X_PARTICIPANTE_PROMEDIO.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldCOSTO_X_PARTICIPANTE_PROMEDIO.Width = 174
        '
        'fieldRANGO_INICIADOS
        '
        Me.fieldRANGO_INICIADOS.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldRANGO_INICIADOS.AreaIndex = 15
        Me.fieldRANGO_INICIADOS.Caption = "Rango Iniciados"
        Me.fieldRANGO_INICIADOS.Name = "fieldRANGO_INICIADOS"
        Me.fieldRANGO_INICIADOS.UnboundFieldName = "fieldRANGO_INICIADOS"
        Me.fieldRANGO_INICIADOS.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        '
        'fieldRANGO_INSCRITOS
        '
        Me.fieldRANGO_INSCRITOS.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldRANGO_INSCRITOS.AreaIndex = 16
        Me.fieldRANGO_INSCRITOS.Caption = "Rango Inscritos"
        Me.fieldRANGO_INSCRITOS.Name = "fieldRANGO_INSCRITOS"
        Me.fieldRANGO_INSCRITOS.UnboundFieldName = "fieldRANGO_INSCRITOS"
        Me.fieldRANGO_INSCRITOS.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        '
        'fieldNOMBREFUENTE
        '
        Me.fieldNOMBREFUENTE.AreaIndex = 18
        Me.fieldNOMBREFUENTE.Caption = "Fuente"
        Me.fieldNOMBREFUENTE.FieldName = "NOMBRE_FUENTE"
        Me.fieldNOMBREFUENTE.Name = "fieldNOMBREFUENTE"
        Me.fieldNOMBREFUENTE.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldNOCONVOCATORIA
        '
        Me.fieldNOCONVOCATORIA.AreaIndex = 19
        Me.fieldNOCONVOCATORIA.Caption = "Convocatoria"
        Me.fieldNOCONVOCATORIA.FieldName = "NO_CONVOCATORIA"
        Me.fieldNOCONVOCATORIA.Name = "fieldNOCONVOCATORIA"
        Me.fieldNOCONVOCATORIA.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldHOMBRES
        '
        Me.fieldHOMBRES.AreaIndex = 20
        Me.fieldHOMBRES.Caption = "Hombres"
        Me.fieldHOMBRES.CellFormat.FormatString = "#,##0"
        Me.fieldHOMBRES.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldHOMBRES.FieldName = "HOMBRES"
        Me.fieldHOMBRES.GrandTotalCellFormat.FormatString = "#,##0"
        Me.fieldHOMBRES.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldHOMBRES.Name = "fieldHOMBRES"
        Me.fieldHOMBRES.ValueFormat.FormatString = "#,##0"
        Me.fieldHOMBRES.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldMUJERES
        '
        Me.fieldMUJERES.AreaIndex = 21
        Me.fieldMUJERES.Caption = "Mujeres"
        Me.fieldMUJERES.CellFormat.FormatString = "#,##0"
        Me.fieldMUJERES.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldMUJERES.FieldName = "MUJERES"
        Me.fieldMUJERES.GrandTotalCellFormat.FormatString = "#,##0"
        Me.fieldMUJERES.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldMUJERES.Name = "fieldMUJERES"
        Me.fieldMUJERES.ValueFormat.FormatString = "#,##0"
        Me.fieldMUJERES.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldNOTAS
        '
        Me.fieldNOTAS.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldNOTAS.AreaIndex = 22
        Me.fieldNOTAS.Caption = "Instructor"
        Me.fieldNOTAS.FieldName = "NOTAS"
        Me.fieldNOTAS.Name = "fieldNOTAS"
        '
        'fieldFECHARECEPCION
        '
        Me.fieldFECHARECEPCION.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldFECHARECEPCION.AreaIndex = 22
        Me.fieldFECHARECEPCION.Caption = "Fecha Recepción"
        Me.fieldFECHARECEPCION.FieldName = "FECHA_RECEPCION"
        Me.fieldFECHARECEPCION.Name = "fieldFECHARECEPCION"
        Me.fieldFECHARECEPCION.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldFECHARECEPCION.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldFECHARECEPCION.Options.ShowGrandTotal = False
        Me.fieldFECHARECEPCION.Options.ShowTotals = False
        Me.fieldFECHARECEPCION.ValueFormat.FormatString = "dd/MM/yyyy"
        Me.fieldFECHARECEPCION.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldFECHARECEPCION.Visible = False
        '
        'fieldHOMBRESCAPACITADOS
        '
        Me.fieldHOMBRESCAPACITADOS.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldHOMBRESCAPACITADOS.AreaIndex = 23
        Me.fieldHOMBRESCAPACITADOS.Caption = "Hombres Capacitados"
        Me.fieldHOMBRESCAPACITADOS.CellFormat.FormatString = "#,##0"
        Me.fieldHOMBRESCAPACITADOS.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldHOMBRESCAPACITADOS.FieldName = "HOMBRES_CAPACITADOS"
        Me.fieldHOMBRESCAPACITADOS.GrandTotalCellFormat.FormatString = "#,##0"
        Me.fieldHOMBRESCAPACITADOS.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldHOMBRESCAPACITADOS.Name = "fieldHOMBRESCAPACITADOS"
        '
        'fieldHOMBRESCAPACITADOSMONTO
        '
        Me.fieldHOMBRESCAPACITADOSMONTO.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldHOMBRESCAPACITADOSMONTO.AreaIndex = 24
        Me.fieldHOMBRESCAPACITADOSMONTO.Caption = "Monto Hombres Capacitados"
        Me.fieldHOMBRESCAPACITADOSMONTO.CellFormat.FormatString = "#,##0.00"
        Me.fieldHOMBRESCAPACITADOSMONTO.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldHOMBRESCAPACITADOSMONTO.FieldName = "HOMBRES_CAPACITADOS_MONTO"
        Me.fieldHOMBRESCAPACITADOSMONTO.GrandTotalCellFormat.FormatString = "#,##0.00"
        Me.fieldHOMBRESCAPACITADOSMONTO.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldHOMBRESCAPACITADOSMONTO.Name = "fieldHOMBRESCAPACITADOSMONTO"
        '
        'fieldMUJERESCAPACITADAS
        '
        Me.fieldMUJERESCAPACITADAS.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldMUJERESCAPACITADAS.AreaIndex = 25
        Me.fieldMUJERESCAPACITADAS.Caption = "Mujeres Capacitadas"
        Me.fieldMUJERESCAPACITADAS.CellFormat.FormatString = "#,##0"
        Me.fieldMUJERESCAPACITADAS.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldMUJERESCAPACITADAS.FieldName = "MUJERES_CAPACITADAS"
        Me.fieldMUJERESCAPACITADAS.GrandTotalCellFormat.FormatString = "#,##0"
        Me.fieldMUJERESCAPACITADAS.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldMUJERESCAPACITADAS.Name = "fieldMUJERESCAPACITADAS"
        '
        'fieldMUJERESCAPACITADASMONTO
        '
        Me.fieldMUJERESCAPACITADASMONTO.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldMUJERESCAPACITADASMONTO.AreaIndex = 26
        Me.fieldMUJERESCAPACITADASMONTO.Caption = "Monto Mujeres Capacitadas"
        Me.fieldMUJERESCAPACITADASMONTO.CellFormat.FormatString = "#,##0.00"
        Me.fieldMUJERESCAPACITADASMONTO.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldMUJERESCAPACITADASMONTO.FieldName = "MUJERES_CAPACITADAS_MONTO"
        Me.fieldMUJERESCAPACITADASMONTO.GrandTotalCellFormat.FormatString = "#,##0.00"
        Me.fieldMUJERESCAPACITADASMONTO.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldMUJERESCAPACITADASMONTO.Name = "fieldMUJERESCAPACITADASMONTO"
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
        'PatiEjecucionTableAdapter1
        '
        Me.PatiEjecucionTableAdapter1.ClearBeforeFill = True
        '
        'frmCursosProgramaPATI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 569)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "frmCursosProgramaPATI"
        Me.Text = "PATI - Consulta de Cursos"
        Me.Controls.SetChildIndex(Me.SplitContainerControl1, 0)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtOrdenCompra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTDR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNO_CONVOCATORIA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPatiEjecucion, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CbxPROVEEDOR_AF1 As SGAFP.WinUC.cbxPROVEEDOR_AF
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtOrdenCompra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTDR As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CbxESTADO_ACCION_FORMATIVA1 As SGAFP.WinUC.cbxESTADO_ACCION_FORMATIVA
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents DS_DL1 As SGAFP.DL.DS_DL
    Friend WithEvents txtNO_CONVOCATORIA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PatiEjecucionTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.PATIEjecucionTableAdapter
    Friend WithEvents bsPatiEjecucion As System.Windows.Forms.BindingSource
    Friend WithEvents fieldIDACCIONFORMATIVA1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBREDEPARTAMENTO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBREMUNICIPIO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPROVEEDOR1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTDR1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRESOLUCION1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBREACCIONFORMATIVA1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCODIGOGRUPO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHORARIO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHAINICIOREAL1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHAFINREAL1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCODIGOESTADOAF1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldACTIVOS1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMONTO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNUMERODOCUMENTO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNUMEROQUEDAN1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHAQUEDAN1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNUMEROCHEQUE1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHACHEQUE1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCOSTOXPARTICIPANTE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSEXO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents fieldMONTOFUENTE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldINSCRITOS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBREESTADOAF As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHAELABORACION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOLIQUIDACION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldINICIADOS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRANGO_INICIADOS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCOSTO_X_PARTICIPANTE_PROMEDIO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRANGO_INSCRITOS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSOLICITADOS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBREFUENTE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOCONVOCATORIA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHOMBRES As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMUJERES As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOTAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHARECEPCION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CbxPROGRAMA_FORMACION1 As SGAFP.WinUC.cbxPROGRAMA_FORMACION
    Friend WithEvents fieldHOMBRESCAPACITADOS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHOMBRESCAPACITADOSMONTO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMUJERESCAPACITADAS As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMUJERESCAPACITADASMONTO As DevExpress.XtraPivotGrid.PivotGridField
End Class
