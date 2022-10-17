<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEjecucionProgramas
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
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.CbxPROGRAMA_FORMACION1 = New SGAFP.WinUC.cbxPROGRAMA_FORMACION()
        Me.SpnID_EJERCICIO_LICITACION = New DevExpress.XtraEditors.SpinEdit()
        Me.TxtNUM_LICITACION = New DevExpress.XtraEditors.TextEdit()
        Me.SpnNO_CONVOCATORIA = New DevExpress.XtraEditors.SpinEdit()
        Me.CbxClasificacion = New System.Windows.Forms.ComboBox()
        Me.CbxSITIO_CAPACITACION1 = New SGAFP.WinUC.cbxSITIO_CAPACITACION()
        Me.CbxPROVEEDOR_AF1 = New SGAFP.WinUC.cbxPROVEEDOR_AF()
        Me.CbxEJERCICIO1 = New SGAFP.WinUC.cbxEJERCICIO()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabResumen = New DevExpress.XtraTab.XtraTabPage()
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.bsProgramacionCursosFormacion = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_DL1 = New SGAFP.DL.DS_DL()
        Me.fieldIDPROGRAMAFORMACION = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPROVEEDOR1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldSITIOCAPACITACION1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldIDCURSO1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldAREAFORMATIVA1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCURSO1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHAINICIOREAL1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHAFINREAL1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHORARIO1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBREESTADOAF1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDIRECCION1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldENCARGADO1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldEMAIL1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTELEFONO1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOTAS1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCODIGOGRUPO1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDURACIONHORAS1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDEPARTAMENTO1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMUNICIPIO1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldACTIVOS1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCLASIFICACION1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldADJUDICADOSUBAREA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCOSTOXPARTICIPANTE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBRESUBAREA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNUMCONTRATO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTOTALPAGO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNUMLICITACION = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldEJERCICIOLICITACION = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTECNICO_ASIGNADO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldACTUALIZACION = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldResolucion = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDESCRIPCIONESTADOINFORME = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldESTADOINFORME = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHAINGRESO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldREFERENTE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHAFINALIZACENTRO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHAPRESINFORME = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHAVALIDACION = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHOMBRES = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMUJERES = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHAFACTURARECIBIDA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHAREVISION = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFECHATRAMITEPAGO = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCODIGOPROGRAMA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCONTRATOCOMPRA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldITEM = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldULTFECHAVISITA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldULTUSUARIOVISITA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMODALIDADFORMATIVA = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.tabParticipantes = New DevExpress.XtraTab.XtraTabPage()
        Me.GridParticipantes = New DevExpress.XtraGrid.GridControl()
        Me.bsAsistenciaRealAccionFormativa = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridViewParticipantes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNOMBRE_PROVEEDOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE_SITIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCODIGO_GRUPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAPELLIDOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDUI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDURACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMINUTOS_ASISTIDOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDIAS_ASISTIDOS_GEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPORCENTAJE_ASISTENCIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.HORAS_ASISTIDAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID_ACCION_FORMATIVA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID_PARTICIPANTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID_SOLICITUD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ProgramacionCursosFormacionTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.ProgramacionCursosFormacionTableAdapter()
        Me.AsistenciaRealAccionFormativaTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.AsistenciaRealAccionFormativaTableAdapter()
        Me.fieldCODIGOCATEG = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldNOMBRECATEG = New DevExpress.XtraPivotGrid.PivotGridField()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.SpnID_EJERCICIO_LICITACION.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNUM_LICITACION.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpnNO_CONVOCATORIA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabResumen.SuspendLayout()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProgramacionCursosFormacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabParticipantes.SuspendLayout()
        CType(Me.GridParticipantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAsistenciaRealAccionFormativa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewParticipantes, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(995, 589)
        Me.SplitContainerControl1.SplitterPosition = 124
        Me.SplitContainerControl1.TabIndex = 5
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.CbxPROGRAMA_FORMACION1)
        Me.LayoutControl1.Controls.Add(Me.SpnID_EJERCICIO_LICITACION)
        Me.LayoutControl1.Controls.Add(Me.TxtNUM_LICITACION)
        Me.LayoutControl1.Controls.Add(Me.SpnNO_CONVOCATORIA)
        Me.LayoutControl1.Controls.Add(Me.CbxClasificacion)
        Me.LayoutControl1.Controls.Add(Me.CbxSITIO_CAPACITACION1)
        Me.LayoutControl1.Controls.Add(Me.CbxPROVEEDOR_AF1)
        Me.LayoutControl1.Controls.Add(Me.CbxEJERCICIO1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.UseDefaultDragAndDropRendering = False
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(995, 124)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'CbxPROGRAMA_FORMACION1
        '
        Me.CbxPROGRAMA_FORMACION1.AllowFindEntityType = Nothing
        Me.CbxPROGRAMA_FORMACION1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxPROGRAMA_FORMACION1.Location = New System.Drawing.Point(115, 12)
        Me.CbxPROGRAMA_FORMACION1.Name = "CbxPROGRAMA_FORMACION1"
        Me.CbxPROGRAMA_FORMACION1.Size = New System.Drawing.Size(315, 21)
        Me.CbxPROGRAMA_FORMACION1.TabIndex = 17
        '
        'SpnID_EJERCICIO_LICITACION
        '
        Me.SpnID_EJERCICIO_LICITACION.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpnID_EJERCICIO_LICITACION.Location = New System.Drawing.Point(538, 87)
        Me.SpnID_EJERCICIO_LICITACION.Name = "SpnID_EJERCICIO_LICITACION"
        Me.SpnID_EJERCICIO_LICITACION.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SpnID_EJERCICIO_LICITACION.Size = New System.Drawing.Size(445, 20)
        Me.SpnID_EJERCICIO_LICITACION.StyleController = Me.LayoutControl1
        Me.SpnID_EJERCICIO_LICITACION.TabIndex = 16
        '
        'TxtNUM_LICITACION
        '
        Me.TxtNUM_LICITACION.EditValue = "_/____"
        Me.TxtNUM_LICITACION.Location = New System.Drawing.Point(115, 87)
        Me.TxtNUM_LICITACION.Name = "TxtNUM_LICITACION"
        Me.TxtNUM_LICITACION.Properties.Mask.EditMask = "0/0000"
        Me.TxtNUM_LICITACION.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.TxtNUM_LICITACION.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TxtNUM_LICITACION.Size = New System.Drawing.Size(316, 20)
        Me.TxtNUM_LICITACION.StyleController = Me.LayoutControl1
        Me.TxtNUM_LICITACION.TabIndex = 15
        '
        'SpnNO_CONVOCATORIA
        '
        Me.SpnNO_CONVOCATORIA.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpnNO_CONVOCATORIA.Location = New System.Drawing.Point(537, 12)
        Me.SpnNO_CONVOCATORIA.Name = "SpnNO_CONVOCATORIA"
        Me.SpnNO_CONVOCATORIA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.SpnNO_CONVOCATORIA.Size = New System.Drawing.Size(446, 20)
        Me.SpnNO_CONVOCATORIA.StyleController = Me.LayoutControl1
        Me.SpnNO_CONVOCATORIA.TabIndex = 14
        '
        'CbxClasificacion
        '
        Me.CbxClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxClasificacion.FormattingEnabled = True
        Me.CbxClasificacion.Location = New System.Drawing.Point(538, 62)
        Me.CbxClasificacion.Name = "CbxClasificacion"
        Me.CbxClasificacion.Size = New System.Drawing.Size(445, 21)
        Me.CbxClasificacion.TabIndex = 13
        '
        'CbxSITIO_CAPACITACION1
        '
        Me.CbxSITIO_CAPACITACION1.AllowFindEntityType = Nothing
        Me.CbxSITIO_CAPACITACION1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxSITIO_CAPACITACION1.Location = New System.Drawing.Point(538, 37)
        Me.CbxSITIO_CAPACITACION1.Name = "CbxSITIO_CAPACITACION1"
        Me.CbxSITIO_CAPACITACION1.Size = New System.Drawing.Size(445, 21)
        Me.CbxSITIO_CAPACITACION1.TabIndex = 11
        '
        'CbxPROVEEDOR_AF1
        '
        Me.CbxPROVEEDOR_AF1.AllowFindEntityType = Nothing
        Me.CbxPROVEEDOR_AF1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxPROVEEDOR_AF1.Location = New System.Drawing.Point(115, 37)
        Me.CbxPROVEEDOR_AF1.Name = "CbxPROVEEDOR_AF1"
        Me.CbxPROVEEDOR_AF1.Size = New System.Drawing.Size(316, 21)
        Me.CbxPROVEEDOR_AF1.TabIndex = 6
        '
        'CbxEJERCICIO1
        '
        Me.CbxEJERCICIO1.AllowFindEntityType = Nothing
        Me.CbxEJERCICIO1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxEJERCICIO1.Location = New System.Drawing.Point(115, 62)
        Me.CbxEJERCICIO1.Name = "CbxEJERCICIO1"
        Me.CbxEJERCICIO1.Size = New System.Drawing.Size(316, 21)
        Me.CbxEJERCICIO1.TabIndex = 12
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem7, Me.LayoutControlItem9})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(995, 124)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.CbxPROVEEDOR_AF1
        Me.LayoutControlItem8.CustomizationFormText = "Proveedor"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 25)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(423, 25)
        Me.LayoutControlItem8.Text = "Proveedor"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.CbxSITIO_CAPACITACION1
        Me.LayoutControlItem1.CustomizationFormText = "Centro de Formación"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(423, 25)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(552, 25)
        Me.LayoutControlItem1.Text = "Centro de Formación"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.CbxEJERCICIO1
        Me.LayoutControlItem2.CustomizationFormText = "Ejercicio"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(423, 25)
        Me.LayoutControlItem2.Text = "Ejercicio"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.CbxClasificacion
        Me.LayoutControlItem3.CustomizationFormText = "Clasificación"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(423, 50)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(552, 25)
        Me.LayoutControlItem3.Text = "Clasificación"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SpnNO_CONVOCATORIA
        Me.LayoutControlItem4.CustomizationFormText = "Convocatoria"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(422, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(553, 25)
        Me.LayoutControlItem4.Text = "Convocatoria"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.TxtNUM_LICITACION
        Me.LayoutControlItem5.CustomizationFormText = "N° Licitación"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 75)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(423, 29)
        Me.LayoutControlItem5.Text = "N° Licitación"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SpnID_EJERCICIO_LICITACION
        Me.LayoutControlItem7.CustomizationFormText = "Ejercicio Licitación"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(423, 75)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(552, 29)
        Me.LayoutControlItem7.Text = "Ejercicio Licitación"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(100, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.CbxPROGRAMA_FORMACION1
        Me.LayoutControlItem9.CustomizationFormText = "Programa"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(422, 25)
        Me.LayoutControlItem9.Text = "Programa"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(100, 13)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabResumen
        Me.XtraTabControl1.Size = New System.Drawing.Size(995, 460)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabResumen, Me.tabParticipantes})
        '
        'tabResumen
        '
        Me.tabResumen.Controls.Add(Me.PivotGridControl1)
        Me.tabResumen.Name = "tabResumen"
        Me.tabResumen.Size = New System.Drawing.Size(989, 434)
        Me.tabResumen.Text = "Resumen"
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
        Me.PivotGridControl1.DataSource = Me.bsProgramacionCursosFormacion
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldIDPROGRAMAFORMACION, Me.fieldPROVEEDOR1, Me.fieldSITIOCAPACITACION1, Me.fieldIDCURSO1, Me.fieldAREAFORMATIVA1, Me.fieldCURSO1, Me.fieldFECHAINICIOREAL1, Me.fieldFECHAFINREAL1, Me.fieldHORARIO1, Me.fieldNOMBREESTADOAF1, Me.fieldDIRECCION1, Me.fieldENCARGADO1, Me.fieldEMAIL1, Me.fieldTELEFONO1, Me.fieldNOTAS1, Me.fieldCODIGOGRUPO1, Me.fieldDURACIONHORAS1, Me.fieldDEPARTAMENTO1, Me.fieldMUNICIPIO1, Me.fieldACTIVOS1, Me.fieldCLASIFICACION1, Me.fieldADJUDICADOSUBAREA, Me.fieldCOSTOXPARTICIPANTE, Me.fieldNOMBRESUBAREA, Me.fieldNUMCONTRATO, Me.fieldTOTALPAGO, Me.fieldNUMLICITACION, Me.fieldEJERCICIOLICITACION, Me.fieldTECNICO_ASIGNADO, Me.fieldACTUALIZACION, Me.fieldResolucion, Me.fieldDESCRIPCIONESTADOINFORME, Me.fieldESTADOINFORME, Me.fieldFECHAINGRESO, Me.fieldREFERENTE, Me.fieldFECHAFINALIZACENTRO, Me.fieldFECHAPRESINFORME, Me.fieldFECHAVALIDACION, Me.fieldHOMBRES, Me.fieldMUJERES, Me.fieldFECHAFACTURARECIBIDA, Me.fieldFECHAREVISION, Me.fieldFECHATRAMITEPAGO, Me.fieldCODIGOPROGRAMA, Me.fieldCONTRATOCOMPRA, Me.fieldITEM, Me.fieldULTFECHAVISITA, Me.fieldULTUSUARIOVISITA, Me.fieldMODALIDADFORMATIVA, Me.fieldCODIGOCATEG, Me.fieldNOMBRECATEG})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsCustomization.AllowFilter = False
        Me.PivotGridControl1.OptionsCustomization.AllowHideFields = DevExpress.XtraPivotGrid.AllowHideFieldsType.Never
        Me.PivotGridControl1.OptionsLayout.AddNewGroups = True
        Me.PivotGridControl1.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridControl1.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridControl1.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.PivotGridControl1.OptionsPrint.PrintHeadersOnEveryPage = True
        Me.PivotGridControl1.OptionsPrint.PrintHorzLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridControl1.OptionsPrint.PrintRowHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridControl1.OptionsPrint.PrintUnusedFilterFields = False
        Me.PivotGridControl1.OptionsPrint.PrintVertLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.PivotGridControl1.Size = New System.Drawing.Size(989, 434)
        Me.PivotGridControl1.TabIndex = 3
        '
        'bsProgramacionCursosFormacion
        '
        Me.bsProgramacionCursosFormacion.DataMember = "ProgramacionCursosFormacion"
        Me.bsProgramacionCursosFormacion.DataSource = Me.DS_DL1
        '
        'DS_DL1
        '
        Me.DS_DL1.DataSetName = "DS_DL"
        Me.DS_DL1.EnforceConstraints = False
        Me.DS_DL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fieldIDPROGRAMAFORMACION
        '
        Me.fieldIDPROGRAMAFORMACION.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea
        Me.fieldIDPROGRAMAFORMACION.AreaIndex = 1
        Me.fieldIDPROGRAMAFORMACION.Caption = "IdProgramaFormacion"
        Me.fieldIDPROGRAMAFORMACION.FieldName = "ID_PROGRAMA_FORMACION"
        Me.fieldIDPROGRAMAFORMACION.Name = "fieldIDPROGRAMAFORMACION"
        Me.fieldIDPROGRAMAFORMACION.Visible = False
        '
        'fieldPROVEEDOR1
        '
        Me.fieldPROVEEDOR1.AreaIndex = 11
        Me.fieldPROVEEDOR1.Caption = "Proveedor"
        Me.fieldPROVEEDOR1.FieldName = "PROVEEDOR"
        Me.fieldPROVEEDOR1.Name = "fieldPROVEEDOR1"
        Me.fieldPROVEEDOR1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldPROVEEDOR1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldSITIOCAPACITACION1
        '
        Me.fieldSITIOCAPACITACION1.AreaIndex = 12
        Me.fieldSITIOCAPACITACION1.Caption = "Centro Formación"
        Me.fieldSITIOCAPACITACION1.FieldName = "SITIO_CAPACITACION"
        Me.fieldSITIOCAPACITACION1.Name = "fieldSITIOCAPACITACION1"
        Me.fieldSITIOCAPACITACION1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldSITIOCAPACITACION1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldSITIOCAPACITACION1.Options.ShowTotals = False
        '
        'fieldIDCURSO1
        '
        Me.fieldIDCURSO1.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldIDCURSO1.AreaIndex = 2
        Me.fieldIDCURSO1.Caption = "Cantidad Cursos"
        Me.fieldIDCURSO1.CellFormat.FormatString = "#,##0"
        Me.fieldIDCURSO1.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldIDCURSO1.FieldName = "ID_CURSO"
        Me.fieldIDCURSO1.GrandTotalCellFormat.FormatString = "#,##0"
        Me.fieldIDCURSO1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldIDCURSO1.Name = "fieldIDCURSO1"
        Me.fieldIDCURSO1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldIDCURSO1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldIDCURSO1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.fieldIDCURSO1.TotalValueFormat.FormatString = "#,##0"
        Me.fieldIDCURSO1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldIDCURSO1.ValueFormat.FormatString = "#,##0"
        Me.fieldIDCURSO1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldAREAFORMATIVA1
        '
        Me.fieldAREAFORMATIVA1.AreaIndex = 0
        Me.fieldAREAFORMATIVA1.Caption = "Area Formativa"
        Me.fieldAREAFORMATIVA1.FieldName = "AREA_FORMATIVA"
        Me.fieldAREAFORMATIVA1.Name = "fieldAREAFORMATIVA1"
        Me.fieldAREAFORMATIVA1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldAREAFORMATIVA1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldCURSO1
        '
        Me.fieldCURSO1.AreaIndex = 16
        Me.fieldCURSO1.Caption = "Curso"
        Me.fieldCURSO1.FieldName = "CURSO"
        Me.fieldCURSO1.Name = "fieldCURSO1"
        Me.fieldCURSO1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldCURSO1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldCURSO1.Options.ShowTotals = False
        '
        'fieldFECHAINICIOREAL1
        '
        Me.fieldFECHAINICIOREAL1.AreaIndex = 18
        Me.fieldFECHAINICIOREAL1.Caption = "Inicio"
        Me.fieldFECHAINICIOREAL1.CellFormat.FormatString = "dd/MM/yyyy"
        Me.fieldFECHAINICIOREAL1.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldFECHAINICIOREAL1.FieldName = "FECHA_INICIO_REAL"
        Me.fieldFECHAINICIOREAL1.Name = "fieldFECHAINICIOREAL1"
        Me.fieldFECHAINICIOREAL1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldFECHAINICIOREAL1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldFECHAINICIOREAL1.Options.ShowTotals = False
        Me.fieldFECHAINICIOREAL1.ValueFormat.FormatString = "dd/MM/yyyy"
        Me.fieldFECHAINICIOREAL1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldFECHAFINREAL1
        '
        Me.fieldFECHAFINREAL1.AreaIndex = 19
        Me.fieldFECHAFINREAL1.Caption = "Finalización"
        Me.fieldFECHAFINREAL1.CellFormat.FormatString = "dd/MM/yyyy"
        Me.fieldFECHAFINREAL1.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldFECHAFINREAL1.FieldName = "FECHA_FIN_REAL"
        Me.fieldFECHAFINREAL1.Name = "fieldFECHAFINREAL1"
        Me.fieldFECHAFINREAL1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldFECHAFINREAL1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldFECHAFINREAL1.Options.ShowTotals = False
        Me.fieldFECHAFINREAL1.ValueFormat.FormatString = "dd/MM/yyyy"
        Me.fieldFECHAFINREAL1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldHORARIO1
        '
        Me.fieldHORARIO1.AreaIndex = 20
        Me.fieldHORARIO1.Caption = "Horario"
        Me.fieldHORARIO1.FieldName = "HORARIO"
        Me.fieldHORARIO1.Name = "fieldHORARIO1"
        Me.fieldHORARIO1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldHORARIO1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldHORARIO1.Options.ShowTotals = False
        '
        'fieldNOMBREESTADOAF1
        '
        Me.fieldNOMBREESTADOAF1.AreaIndex = 3
        Me.fieldNOMBREESTADOAF1.Caption = "Estado"
        Me.fieldNOMBREESTADOAF1.FieldName = "NOMBRE_ESTADO_AF"
        Me.fieldNOMBREESTADOAF1.Name = "fieldNOMBREESTADOAF1"
        Me.fieldNOMBREESTADOAF1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldNOMBREESTADOAF1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldNOMBREESTADOAF1.Visible = False
        '
        'fieldDIRECCION1
        '
        Me.fieldDIRECCION1.AreaIndex = 13
        Me.fieldDIRECCION1.Caption = "Dirección"
        Me.fieldDIRECCION1.FieldName = "DIRECCION"
        Me.fieldDIRECCION1.Name = "fieldDIRECCION1"
        Me.fieldDIRECCION1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldDIRECCION1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldDIRECCION1.Options.ShowTotals = False
        '
        'fieldENCARGADO1
        '
        Me.fieldENCARGADO1.AreaIndex = 14
        Me.fieldENCARGADO1.Caption = "Contacto"
        Me.fieldENCARGADO1.FieldName = "ENCARGADO"
        Me.fieldENCARGADO1.Name = "fieldENCARGADO1"
        Me.fieldENCARGADO1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldENCARGADO1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldENCARGADO1.Options.ShowTotals = False
        '
        'fieldEMAIL1
        '
        Me.fieldEMAIL1.AreaIndex = 3
        Me.fieldEMAIL1.Caption = "Email"
        Me.fieldEMAIL1.FieldName = "EMAIL"
        Me.fieldEMAIL1.Name = "fieldEMAIL1"
        Me.fieldEMAIL1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldEMAIL1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldTELEFONO1
        '
        Me.fieldTELEFONO1.AreaIndex = 15
        Me.fieldTELEFONO1.Caption = "Teléfono"
        Me.fieldTELEFONO1.FieldName = "TELEFONO"
        Me.fieldTELEFONO1.Name = "fieldTELEFONO1"
        Me.fieldTELEFONO1.Options.ShowTotals = False
        '
        'fieldNOTAS1
        '
        Me.fieldNOTAS1.AreaIndex = 21
        Me.fieldNOTAS1.Caption = "Instructor"
        Me.fieldNOTAS1.FieldName = "NOTAS"
        Me.fieldNOTAS1.Name = "fieldNOTAS1"
        Me.fieldNOTAS1.Options.ShowTotals = False
        '
        'fieldCODIGOGRUPO1
        '
        Me.fieldCODIGOGRUPO1.AreaIndex = 17
        Me.fieldCODIGOGRUPO1.Caption = "Codigo Grupo"
        Me.fieldCODIGOGRUPO1.FieldName = "CODIGO_GRUPO"
        Me.fieldCODIGOGRUPO1.Name = "fieldCODIGOGRUPO1"
        Me.fieldCODIGOGRUPO1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldCODIGOGRUPO1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldCODIGOGRUPO1.Options.ShowTotals = False
        '
        'fieldDURACIONHORAS1
        '
        Me.fieldDURACIONHORAS1.AreaIndex = 1
        Me.fieldDURACIONHORAS1.Caption = "Duracion (horas)"
        Me.fieldDURACIONHORAS1.FieldName = "DURACION_HORAS"
        Me.fieldDURACIONHORAS1.Name = "fieldDURACIONHORAS1"
        Me.fieldDURACIONHORAS1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldDURACIONHORAS1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldDEPARTAMENTO1
        '
        Me.fieldDEPARTAMENTO1.AreaIndex = 9
        Me.fieldDEPARTAMENTO1.Caption = "Departamento"
        Me.fieldDEPARTAMENTO1.FieldName = "DEPARTAMENTO"
        Me.fieldDEPARTAMENTO1.Name = "fieldDEPARTAMENTO1"
        Me.fieldDEPARTAMENTO1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldDEPARTAMENTO1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldDEPARTAMENTO1.Options.ShowTotals = False
        '
        'fieldMUNICIPIO1
        '
        Me.fieldMUNICIPIO1.AreaIndex = 10
        Me.fieldMUNICIPIO1.Caption = "Municipio"
        Me.fieldMUNICIPIO1.FieldName = "MUNICIPIO"
        Me.fieldMUNICIPIO1.Name = "fieldMUNICIPIO1"
        Me.fieldMUNICIPIO1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldMUNICIPIO1.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldMUNICIPIO1.Options.ShowTotals = False
        '
        'fieldACTIVOS1
        '
        Me.fieldACTIVOS1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldACTIVOS1.AreaIndex = 0
        Me.fieldACTIVOS1.Caption = "Activos"
        Me.fieldACTIVOS1.CellFormat.FormatString = "#"
        Me.fieldACTIVOS1.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldACTIVOS1.FieldName = "ACTIVOS"
        Me.fieldACTIVOS1.GrandTotalCellFormat.FormatString = "#"
        Me.fieldACTIVOS1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldACTIVOS1.Name = "fieldACTIVOS1"
        '
        'fieldCLASIFICACION1
        '
        Me.fieldCLASIFICACION1.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea
        Me.fieldCLASIFICACION1.AreaIndex = 18
        Me.fieldCLASIFICACION1.Caption = "Clasificación"
        Me.fieldCLASIFICACION1.FieldName = "CLASIFICACION"
        Me.fieldCLASIFICACION1.Name = "fieldCLASIFICACION1"
        Me.fieldCLASIFICACION1.Visible = False
        '
        'fieldADJUDICADOSUBAREA
        '
        Me.fieldADJUDICADOSUBAREA.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldADJUDICADOSUBAREA.AreaIndex = 3
        Me.fieldADJUDICADOSUBAREA.Caption = "Adjudicado en Sub Area"
        Me.fieldADJUDICADOSUBAREA.CellFormat.FormatString = "#,###,##0.00"
        Me.fieldADJUDICADOSUBAREA.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldADJUDICADOSUBAREA.FieldName = "ADJUDICADO_SUBAREA"
        Me.fieldADJUDICADOSUBAREA.GrandTotalCellFormat.FormatString = "#,###,##0.00"
        Me.fieldADJUDICADOSUBAREA.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldADJUDICADOSUBAREA.Name = "fieldADJUDICADOSUBAREA"
        Me.fieldADJUDICADOSUBAREA.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldADJUDICADOSUBAREA.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldADJUDICADOSUBAREA.Options.ShowTotals = False
        Me.fieldADJUDICADOSUBAREA.TotalCellFormat.FormatString = "#,###,##0.00"
        Me.fieldADJUDICADOSUBAREA.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldADJUDICADOSUBAREA.TotalValueFormat.FormatString = "#,###,##0.00"
        Me.fieldADJUDICADOSUBAREA.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldADJUDICADOSUBAREA.Visible = False
        '
        'fieldCOSTOXPARTICIPANTE
        '
        Me.fieldCOSTOXPARTICIPANTE.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldCOSTOXPARTICIPANTE.AreaIndex = 5
        Me.fieldCOSTOXPARTICIPANTE.Caption = "Costo x Particip."
        Me.fieldCOSTOXPARTICIPANTE.CellFormat.FormatString = "#,###,##0.00"
        Me.fieldCOSTOXPARTICIPANTE.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldCOSTOXPARTICIPANTE.FieldName = "COSTO_X_PARTICIPANTE"
        Me.fieldCOSTOXPARTICIPANTE.GrandTotalCellFormat.FormatString = "#,###,##0.00"
        Me.fieldCOSTOXPARTICIPANTE.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldCOSTOXPARTICIPANTE.Name = "fieldCOSTOXPARTICIPANTE"
        Me.fieldCOSTOXPARTICIPANTE.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldCOSTOXPARTICIPANTE.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldCOSTOXPARTICIPANTE.Options.ShowTotals = False
        Me.fieldCOSTOXPARTICIPANTE.Visible = False
        '
        'fieldNOMBRESUBAREA
        '
        Me.fieldNOMBRESUBAREA.AreaIndex = 6
        Me.fieldNOMBRESUBAREA.Caption = "Sub Area Formativa"
        Me.fieldNOMBRESUBAREA.FieldName = "NOMBRE_SUB_AREA"
        Me.fieldNOMBRESUBAREA.Name = "fieldNOMBRESUBAREA"
        Me.fieldNOMBRESUBAREA.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldNOMBRESUBAREA.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldNOMBRESUBAREA.Visible = False
        '
        'fieldNUMCONTRATO
        '
        Me.fieldNUMCONTRATO.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldNUMCONTRATO.AreaIndex = 3
        Me.fieldNUMCONTRATO.Caption = "Contrato"
        Me.fieldNUMCONTRATO.FieldName = "NUM_CONTRATO"
        Me.fieldNUMCONTRATO.Name = "fieldNUMCONTRATO"
        Me.fieldNUMCONTRATO.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldNUMCONTRATO.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldNUMCONTRATO.Options.ShowTotals = False
        Me.fieldNUMCONTRATO.Visible = False
        '
        'fieldTOTALPAGO
        '
        Me.fieldTOTALPAGO.AllowedAreas = CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldTOTALPAGO.AreaIndex = 2
        Me.fieldTOTALPAGO.Caption = "Total Pago"
        Me.fieldTOTALPAGO.CellFormat.FormatString = "#,###,##0.00"
        Me.fieldTOTALPAGO.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldTOTALPAGO.FieldName = "TOTAL_PAGO"
        Me.fieldTOTALPAGO.GrandTotalCellFormat.FormatString = "#,###,##0.00"
        Me.fieldTOTALPAGO.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldTOTALPAGO.Name = "fieldTOTALPAGO"
        Me.fieldTOTALPAGO.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldTOTALPAGO.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldTOTALPAGO.TotalValueFormat.FormatString = "#,###,##0.00"
        Me.fieldTOTALPAGO.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldTOTALPAGO.ValueFormat.FormatString = "#,###,##0.00"
        Me.fieldTOTALPAGO.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldTOTALPAGO.Visible = False
        '
        'fieldNUMLICITACION
        '
        Me.fieldNUMLICITACION.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldNUMLICITACION.AreaIndex = 7
        Me.fieldNUMLICITACION.Caption = "N° Licitación"
        Me.fieldNUMLICITACION.FieldName = "NUM_LICITACION"
        Me.fieldNUMLICITACION.Name = "fieldNUMLICITACION"
        Me.fieldNUMLICITACION.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldNUMLICITACION.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldNUMLICITACION.Visible = False
        '
        'fieldEJERCICIOLICITACION
        '
        Me.fieldEJERCICIOLICITACION.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldEJERCICIOLICITACION.Caption = "Ejercicio Licitacion"
        Me.fieldEJERCICIOLICITACION.FieldName = "EJERCICIO_LICITACION"
        Me.fieldEJERCICIOLICITACION.Name = "fieldEJERCICIOLICITACION"
        Me.fieldEJERCICIOLICITACION.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldEJERCICIOLICITACION.Visible = False
        '
        'fieldTECNICO_ASIGNADO
        '
        Me.fieldTECNICO_ASIGNADO.AreaIndex = 5
        Me.fieldTECNICO_ASIGNADO.Caption = "Técnico Asignado"
        Me.fieldTECNICO_ASIGNADO.FieldName = "TECNICO_ASIGNADO"
        Me.fieldTECNICO_ASIGNADO.Name = "fieldTECNICO_ASIGNADO"
        Me.fieldTECNICO_ASIGNADO.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldTECNICO_ASIGNADO.Visible = False
        '
        'fieldACTUALIZACION
        '
        Me.fieldACTUALIZACION.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldACTUALIZACION.AreaIndex = 4
        Me.fieldACTUALIZACION.Caption = "Actualización"
        Me.fieldACTUALIZACION.CellFormat.FormatString = "dd/MM/yyyy"
        Me.fieldACTUALIZACION.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldACTUALIZACION.FieldName = "ACTUALIZACION"
        Me.fieldACTUALIZACION.Name = "fieldACTUALIZACION"
        Me.fieldACTUALIZACION.Visible = False
        '
        'fieldResolucion
        '
        Me.fieldResolucion.AreaIndex = 3
        Me.fieldResolucion.Caption = "N° Orden Compra"
        Me.fieldResolucion.FieldName = "Resolucion"
        Me.fieldResolucion.Name = "fieldResolucion"
        Me.fieldResolucion.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldResolucion.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.fieldResolucion.Visible = False
        '
        'fieldDESCRIPCIONESTADOINFORME
        '
        Me.fieldDESCRIPCIONESTADOINFORME.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldDESCRIPCIONESTADOINFORME.AreaIndex = 3
        Me.fieldDESCRIPCIONESTADOINFORME.Caption = "Descrip. Estado Informe"
        Me.fieldDESCRIPCIONESTADOINFORME.FieldName = "DESCRIPCION_ESTADO_INFORME"
        Me.fieldDESCRIPCIONESTADOINFORME.Name = "fieldDESCRIPCIONESTADOINFORME"
        Me.fieldDESCRIPCIONESTADOINFORME.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldDESCRIPCIONESTADOINFORME.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldDESCRIPCIONESTADOINFORME.Visible = False
        '
        'fieldESTADOINFORME
        '
        Me.fieldESTADOINFORME.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldESTADOINFORME.AreaIndex = 4
        Me.fieldESTADOINFORME.Caption = "Estado Informe"
        Me.fieldESTADOINFORME.FieldName = "ESTADO_INFORME"
        Me.fieldESTADOINFORME.Name = "fieldESTADOINFORME"
        Me.fieldESTADOINFORME.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldESTADOINFORME.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldESTADOINFORME.Visible = False
        '
        'fieldFECHAINGRESO
        '
        Me.fieldFECHAINGRESO.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldFECHAINGRESO.AreaIndex = 4
        Me.fieldFECHAINGRESO.Caption = "Fecha ingreso al sistema"
        Me.fieldFECHAINGRESO.CellFormat.FormatString = "dd/MM/yyyy"
        Me.fieldFECHAINGRESO.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldFECHAINGRESO.FieldName = "FECHA_INGRESO"
        Me.fieldFECHAINGRESO.Name = "fieldFECHAINGRESO"
        Me.fieldFECHAINGRESO.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldFECHAINGRESO.ValueFormat.FormatString = "dd/MM/yyyy"
        Me.fieldFECHAINGRESO.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldREFERENTE
        '
        Me.fieldREFERENTE.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldREFERENTE.AreaIndex = 5
        Me.fieldREFERENTE.Caption = "Referente"
        Me.fieldREFERENTE.FieldName = "REFERENTE"
        Me.fieldREFERENTE.Name = "fieldREFERENTE"
        Me.fieldREFERENTE.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldREFERENTE.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldFECHAFINALIZACENTRO
        '
        Me.fieldFECHAFINALIZACENTRO.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldFECHAFINALIZACENTRO.AreaIndex = 6
        Me.fieldFECHAFINALIZACENTRO.Caption = "Fecha finaliza en sistema"
        Me.fieldFECHAFINALIZACENTRO.FieldName = "FECHA_FINALIZA_CENTRO"
        Me.fieldFECHAFINALIZACENTRO.Name = "fieldFECHAFINALIZACENTRO"
        Me.fieldFECHAFINALIZACENTRO.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldFECHAFINALIZACENTRO.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldFECHAFINALIZACENTRO.Options.ShowTotals = False
        Me.fieldFECHAFINALIZACENTRO.ValueFormat.FormatString = "dd/MM/yyyy"
        Me.fieldFECHAFINALIZACENTRO.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldFECHAPRESINFORME
        '
        Me.fieldFECHAPRESINFORME.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldFECHAPRESINFORME.AreaIndex = 7
        Me.fieldFECHAPRESINFORME.Caption = "Fecha presentación"
        Me.fieldFECHAPRESINFORME.FieldName = "FECHA_PRES_INFORME"
        Me.fieldFECHAPRESINFORME.Name = "fieldFECHAPRESINFORME"
        Me.fieldFECHAPRESINFORME.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldFECHAPRESINFORME.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldFECHAPRESINFORME.Options.ShowTotals = False
        Me.fieldFECHAPRESINFORME.ValueFormat.FormatString = "dd/MM/yyyy"
        Me.fieldFECHAPRESINFORME.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldFECHAVALIDACION
        '
        Me.fieldFECHAVALIDACION.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldFECHAVALIDACION.AreaIndex = 8
        Me.fieldFECHAVALIDACION.Caption = "Fecha VoBo"
        Me.fieldFECHAVALIDACION.FieldName = "FECHA_VALIDACION"
        Me.fieldFECHAVALIDACION.Name = "fieldFECHAVALIDACION"
        Me.fieldFECHAVALIDACION.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldFECHAVALIDACION.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldFECHAVALIDACION.Options.ShowTotals = False
        Me.fieldFECHAVALIDACION.ValueFormat.FormatString = "dd/MM/yyyy"
        Me.fieldFECHAVALIDACION.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldHOMBRES
        '
        Me.fieldHOMBRES.AreaIndex = 22
        Me.fieldHOMBRES.Caption = "Hombres"
        Me.fieldHOMBRES.CellFormat.FormatString = "#"
        Me.fieldHOMBRES.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldHOMBRES.FieldName = "HOMBRES"
        Me.fieldHOMBRES.GrandTotalCellFormat.FormatString = "#"
        Me.fieldHOMBRES.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldHOMBRES.Name = "fieldHOMBRES"
        Me.fieldHOMBRES.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldHOMBRES.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldHOMBRES.TotalValueFormat.FormatString = "#"
        Me.fieldHOMBRES.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldHOMBRES.ValueFormat.FormatString = "#"
        Me.fieldHOMBRES.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldMUJERES
        '
        Me.fieldMUJERES.AreaIndex = 23
        Me.fieldMUJERES.Caption = "Mujeres"
        Me.fieldMUJERES.CellFormat.FormatString = "#"
        Me.fieldMUJERES.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldMUJERES.FieldName = "MUJERES"
        Me.fieldMUJERES.GrandTotalCellFormat.FormatString = "#"
        Me.fieldMUJERES.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldMUJERES.Name = "fieldMUJERES"
        Me.fieldMUJERES.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldMUJERES.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldMUJERES.TotalValueFormat.FormatString = "#"
        Me.fieldMUJERES.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldMUJERES.ValueFormat.FormatString = "#"
        Me.fieldMUJERES.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldFECHAFACTURARECIBIDA
        '
        Me.fieldFECHAFACTURARECIBIDA.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldFECHAFACTURARECIBIDA.AreaIndex = 24
        Me.fieldFECHAFACTURARECIBIDA.Caption = "Fecha Factura Recibida"
        Me.fieldFECHAFACTURARECIBIDA.CellFormat.FormatString = "dd/MM/yyyy"
        Me.fieldFECHAFACTURARECIBIDA.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldFECHAFACTURARECIBIDA.FieldName = "FECHA_FACTURA_RECIBIDA"
        Me.fieldFECHAFACTURARECIBIDA.Name = "fieldFECHAFACTURARECIBIDA"
        Me.fieldFECHAFACTURARECIBIDA.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldFECHAFACTURARECIBIDA.ValueFormat.FormatString = "dd/MM/yyyy"
        Me.fieldFECHAFACTURARECIBIDA.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldFECHAREVISION
        '
        Me.fieldFECHAREVISION.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldFECHAREVISION.AreaIndex = 25
        Me.fieldFECHAREVISION.Caption = "Fecha En Revision"
        Me.fieldFECHAREVISION.CellFormat.FormatString = "dd/MM/yyyy"
        Me.fieldFECHAREVISION.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldFECHAREVISION.FieldName = "FECHA_REVISION"
        Me.fieldFECHAREVISION.Name = "fieldFECHAREVISION"
        Me.fieldFECHAREVISION.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldFECHAREVISION.ValueFormat.FormatString = "dd/MM/yyyy"
        Me.fieldFECHAREVISION.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldFECHATRAMITEPAGO
        '
        Me.fieldFECHATRAMITEPAGO.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldFECHATRAMITEPAGO.AreaIndex = 26
        Me.fieldFECHATRAMITEPAGO.Caption = "Fecha En Tramite de Pago"
        Me.fieldFECHATRAMITEPAGO.CellFormat.FormatString = "dd/MM/yyyy"
        Me.fieldFECHATRAMITEPAGO.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.fieldFECHATRAMITEPAGO.FieldName = "FECHA_TRAMITE_PAGO"
        Me.fieldFECHATRAMITEPAGO.Name = "fieldFECHATRAMITEPAGO"
        Me.fieldFECHATRAMITEPAGO.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldFECHATRAMITEPAGO.ValueFormat.FormatString = "dd/MM/yyyy"
        Me.fieldFECHATRAMITEPAGO.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
        '
        'fieldCODIGOPROGRAMA
        '
        Me.fieldCODIGOPROGRAMA.AreaIndex = 30
        Me.fieldCODIGOPROGRAMA.Caption = "Codigo de programa"
        Me.fieldCODIGOPROGRAMA.FieldName = "CODIGO_PROGRAMA"
        Me.fieldCODIGOPROGRAMA.Name = "fieldCODIGOPROGRAMA"
        Me.fieldCODIGOPROGRAMA.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldCODIGOPROGRAMA.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldCONTRATOCOMPRA
        '
        Me.fieldCONTRATOCOMPRA.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldCONTRATOCOMPRA.AreaIndex = 27
        Me.fieldCONTRATOCOMPRA.Caption = "Oferta de compra"
        Me.fieldCONTRATOCOMPRA.FieldName = "CONTRATO_COMPRA"
        Me.fieldCONTRATOCOMPRA.Name = "fieldCONTRATOCOMPRA"
        Me.fieldCONTRATOCOMPRA.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldCONTRATOCOMPRA.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldITEM
        '
        Me.fieldITEM.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldITEM.AreaIndex = 29
        Me.fieldITEM.Caption = "N° Item"
        Me.fieldITEM.FieldName = "ITEM"
        Me.fieldITEM.Name = "fieldITEM"
        Me.fieldITEM.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldITEM.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        Me.fieldITEM.Options.ShowCustomTotals = False
        Me.fieldITEM.Options.ShowGrandTotal = False
        Me.fieldITEM.Options.ShowTotals = False
        '
        'fieldULTFECHAVISITA
        '
        Me.fieldULTFECHAVISITA.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldULTFECHAVISITA.AreaIndex = 28
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
        Me.fieldULTUSUARIOVISITA.AreaIndex = 31
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
        Me.fieldMODALIDADFORMATIVA.AreaIndex = 32
        Me.fieldMODALIDADFORMATIVA.Caption = "Modalidad formativa"
        Me.fieldMODALIDADFORMATIVA.FieldName = "MODALIDAD_FORMATIVA"
        Me.fieldMODALIDADFORMATIVA.Name = "fieldMODALIDADFORMATIVA"
        Me.fieldMODALIDADFORMATIVA.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldMODALIDADFORMATIVA.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'tabParticipantes
        '
        Me.tabParticipantes.Controls.Add(Me.GridParticipantes)
        Me.tabParticipantes.Name = "tabParticipantes"
        Me.tabParticipantes.PageVisible = False
        Me.tabParticipantes.Size = New System.Drawing.Size(989, 434)
        Me.tabParticipantes.Text = "Participantes"
        '
        'GridParticipantes
        '
        Me.GridParticipantes.DataSource = Me.bsAsistenciaRealAccionFormativa
        Me.GridParticipantes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridParticipantes.Location = New System.Drawing.Point(0, 0)
        Me.GridParticipantes.MainView = Me.GridViewParticipantes
        Me.GridParticipantes.Name = "GridParticipantes"
        Me.GridParticipantes.Size = New System.Drawing.Size(989, 434)
        Me.GridParticipantes.TabIndex = 0
        Me.GridParticipantes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewParticipantes})
        '
        'bsAsistenciaRealAccionFormativa
        '
        Me.bsAsistenciaRealAccionFormativa.DataMember = "AsistenciaRealAccionFormativa"
        Me.bsAsistenciaRealAccionFormativa.DataSource = Me.DS_DL1
        '
        'GridViewParticipantes
        '
        Me.GridViewParticipantes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNOMBRE_PROVEEDOR, Me.colNOMBRE_SITIO, Me.colCODIGO_GRUPO, Me.colAPELLIDOS, Me.colNOMBRES, Me.colDUI, Me.colNIT, Me.colDURACION, Me.colMINUTOS_ASISTIDOS, Me.colDIAS_ASISTIDOS_GEN, Me.colPORCENTAJE_ASISTENCIA, Me.HORAS_ASISTIDAS, Me.colID_ACCION_FORMATIVA, Me.colID_PARTICIPANTE, Me.colID_SOLICITUD})
        Me.GridViewParticipantes.GridControl = Me.GridParticipantes
        Me.GridViewParticipantes.Name = "GridViewParticipantes"
        Me.GridViewParticipantes.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridViewParticipantes.OptionsBehavior.Editable = False
        Me.GridViewParticipantes.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colAPELLIDOS, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colNOMBRE_PROVEEDOR
        '
        Me.colNOMBRE_PROVEEDOR.Caption = "Proveedor"
        Me.colNOMBRE_PROVEEDOR.FieldName = "NOMBRE_PROVEEDOR"
        Me.colNOMBRE_PROVEEDOR.Name = "colNOMBRE_PROVEEDOR"
        '
        'colNOMBRE_SITIO
        '
        Me.colNOMBRE_SITIO.Caption = "Centro de Formación"
        Me.colNOMBRE_SITIO.FieldName = "NOMBRE_SITIO"
        Me.colNOMBRE_SITIO.Name = "colNOMBRE_SITIO"
        Me.colNOMBRE_SITIO.Visible = True
        Me.colNOMBRE_SITIO.VisibleIndex = 0
        '
        'colCODIGO_GRUPO
        '
        Me.colCODIGO_GRUPO.Caption = "Código Grupo"
        Me.colCODIGO_GRUPO.FieldName = "CODIGO_GRUPO"
        Me.colCODIGO_GRUPO.Name = "colCODIGO_GRUPO"
        Me.colCODIGO_GRUPO.Visible = True
        Me.colCODIGO_GRUPO.VisibleIndex = 1
        '
        'colAPELLIDOS
        '
        Me.colAPELLIDOS.Caption = "Apellidos"
        Me.colAPELLIDOS.FieldName = "APELLIDOS"
        Me.colAPELLIDOS.Name = "colAPELLIDOS"
        Me.colAPELLIDOS.Visible = True
        Me.colAPELLIDOS.VisibleIndex = 2
        '
        'colNOMBRES
        '
        Me.colNOMBRES.Caption = "Nombres"
        Me.colNOMBRES.FieldName = "NOMBRES"
        Me.colNOMBRES.Name = "colNOMBRES"
        Me.colNOMBRES.Visible = True
        Me.colNOMBRES.VisibleIndex = 3
        '
        'colDUI
        '
        Me.colDUI.Caption = "DUI"
        Me.colDUI.FieldName = "DUI"
        Me.colDUI.Name = "colDUI"
        Me.colDUI.Visible = True
        Me.colDUI.VisibleIndex = 4
        '
        'colNIT
        '
        Me.colNIT.Caption = "NIT"
        Me.colNIT.FieldName = "NIT"
        Me.colNIT.Name = "colNIT"
        Me.colNIT.Visible = True
        Me.colNIT.VisibleIndex = 5
        '
        'colDURACION
        '
        Me.colDURACION.FieldName = "DURACION"
        Me.colDURACION.Name = "colDURACION"
        '
        'colMINUTOS_ASISTIDOS
        '
        Me.colMINUTOS_ASISTIDOS.FieldName = "MINUTOS_ASISTIDOS"
        Me.colMINUTOS_ASISTIDOS.Name = "colMINUTOS_ASISTIDOS"
        '
        'colDIAS_ASISTIDOS_GEN
        '
        Me.colDIAS_ASISTIDOS_GEN.Caption = "Días asistidos"
        Me.colDIAS_ASISTIDOS_GEN.FieldName = "DIAS_ASISTIDOS_GEN"
        Me.colDIAS_ASISTIDOS_GEN.Name = "colDIAS_ASISTIDOS_GEN"
        Me.colDIAS_ASISTIDOS_GEN.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colDIAS_ASISTIDOS_GEN.Visible = True
        Me.colDIAS_ASISTIDOS_GEN.VisibleIndex = 6
        '
        'colPORCENTAJE_ASISTENCIA
        '
        Me.colPORCENTAJE_ASISTENCIA.Caption = "% Asistencia"
        Me.colPORCENTAJE_ASISTENCIA.FieldName = "PORCENTAJE_ASISTENCIA"
        Me.colPORCENTAJE_ASISTENCIA.Name = "colPORCENTAJE_ASISTENCIA"
        Me.colPORCENTAJE_ASISTENCIA.Visible = True
        Me.colPORCENTAJE_ASISTENCIA.VisibleIndex = 7
        '
        'HORAS_ASISTIDAS
        '
        Me.HORAS_ASISTIDAS.Caption = "Horas Asistidas"
        Me.HORAS_ASISTIDAS.FieldName = "HORAS_ASISTIDAS"
        Me.HORAS_ASISTIDAS.Name = "HORAS_ASISTIDAS"
        Me.HORAS_ASISTIDAS.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.HORAS_ASISTIDAS.Visible = True
        Me.HORAS_ASISTIDAS.VisibleIndex = 8
        '
        'colID_ACCION_FORMATIVA
        '
        Me.colID_ACCION_FORMATIVA.FieldName = "ID_ACCION_FORMATIVA"
        Me.colID_ACCION_FORMATIVA.Name = "colID_ACCION_FORMATIVA"
        '
        'colID_PARTICIPANTE
        '
        Me.colID_PARTICIPANTE.FieldName = "ID_PARTICIPANTE"
        Me.colID_PARTICIPANTE.Name = "colID_PARTICIPANTE"
        '
        'colID_SOLICITUD
        '
        Me.colID_SOLICITUD.FieldName = "ID_SOLICITUD"
        Me.colID_SOLICITUD.Name = "colID_SOLICITUD"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ProgramacionCursosFormacionTableAdapter1
        '
        Me.ProgramacionCursosFormacionTableAdapter1.ClearBeforeFill = True
        '
        'AsistenciaRealAccionFormativaTableAdapter1
        '
        Me.AsistenciaRealAccionFormativaTableAdapter1.ClearBeforeFill = True
        '
        'fieldCODIGOCATEG
        '
        Me.fieldCODIGOCATEG.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldCODIGOCATEG.AreaIndex = 33
        Me.fieldCODIGOCATEG.Caption = "Código Categoría"
        Me.fieldCODIGOCATEG.FieldName = "CODIGO_CATEG"
        Me.fieldCODIGOCATEG.Name = "fieldCODIGOCATEG"
        Me.fieldCODIGOCATEG.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldCODIGOCATEG.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'fieldNOMBRECATEG
        '
        Me.fieldNOMBRECATEG.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
            Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldNOMBRECATEG.AreaIndex = 34
        Me.fieldNOMBRECATEG.Caption = "Nombre Categoría"
        Me.fieldNOMBRECATEG.FieldName = "NOMBRE_CATEG"
        Me.fieldNOMBRECATEG.Name = "fieldNOMBRECATEG"
        Me.fieldNOMBRECATEG.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
        Me.fieldNOMBRECATEG.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[True]
        '
        'frmEjecucionProgramas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 589)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "frmEjecucionProgramas"
        Me.Text = "Programación Cursos de Formación"
        Me.Controls.SetChildIndex(Me.SplitContainerControl1, 0)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.SpnID_EJERCICIO_LICITACION.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNUM_LICITACION.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpnNO_CONVOCATORIA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabResumen.ResumeLayout(False)
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProgramacionCursosFormacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabParticipantes.ResumeLayout(False)
        CType(Me.GridParticipantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAsistenciaRealAccionFormativa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewParticipantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents CbxPROVEEDOR_AF1 As SGAFP.WinUC.cbxPROVEEDOR_AF
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CbxSITIO_CAPACITACION1 As SGAFP.WinUC.cbxSITIO_CAPACITACION
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CbxEJERCICIO1 As SGAFP.WinUC.cbxEJERCICIO
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CbxClasificacion As System.Windows.Forms.ComboBox
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SpnNO_CONVOCATORIA As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DS_DL1 As SGAFP.DL.DS_DL
    Friend WithEvents ProgramacionCursosFormacionTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.ProgramacionCursosFormacionTableAdapter
    Friend WithEvents bsProgramacionCursosFormacion As System.Windows.Forms.BindingSource
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SpnID_EJERCICIO_LICITACION As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents TxtNUM_LICITACION As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabResumen As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents fieldPROVEEDOR1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSITIOCAPACITACION1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldIDCURSO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAREAFORMATIVA1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCURSO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHAINICIOREAL1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHAFINREAL1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHORARIO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBREESTADOAF1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDIRECCION1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldENCARGADO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldEMAIL1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTELEFONO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOTAS1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCODIGOGRUPO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDURACIONHORAS1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDEPARTAMENTO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMUNICIPIO1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldACTIVOS1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCLASIFICACION1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldADJUDICADOSUBAREA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCOSTOXPARTICIPANTE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRESUBAREA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNUMCONTRATO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTOTALPAGO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNUMLICITACION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldEJERCICIOLICITACION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTECNICO_ASIGNADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldACTUALIZACION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents tabParticipantes As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridParticipantes As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewParticipantes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AsistenciaRealAccionFormativaTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.AsistenciaRealAccionFormativaTableAdapter
    Friend WithEvents bsAsistenciaRealAccionFormativa As System.Windows.Forms.BindingSource
    Friend WithEvents colNOMBRE_PROVEEDOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_SITIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_GRUPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAPELLIDOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDUI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNIT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDURACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMINUTOS_ASISTIDOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPORCENTAJE_ASISTENCIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDIAS_ASISTIDOS_GEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_ACCION_FORMATIVA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_PARTICIPANTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_SOLICITUD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HORAS_ASISTIDAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldResolucion As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents CbxPROGRAMA_FORMACION1 As SGAFP.WinUC.cbxPROGRAMA_FORMACION
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents fieldIDPROGRAMAFORMACION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDESCRIPCIONESTADOINFORME As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldESTADOINFORME As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHAINGRESO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldREFERENTE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHAFINALIZACENTRO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHAPRESINFORME As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHAVALIDACION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHOMBRES As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMUJERES As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHAFACTURARECIBIDA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHAREVISION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFECHATRAMITEPAGO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCODIGOPROGRAMA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCONTRATOCOMPRA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldITEM As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldULTFECHAVISITA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldULTUSUARIOVISITA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMODALIDADFORMATIVA As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCODIGOCATEG As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOMBRECATEG As DevExpress.XtraPivotGrid.PivotGridField
End Class
