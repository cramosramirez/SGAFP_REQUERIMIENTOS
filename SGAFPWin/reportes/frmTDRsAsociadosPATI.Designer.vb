<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTDRsAsociadosPATI
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
        Me.fieldIDSOLICITUD = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldIDGRUPOAF = New DevExpress.XtraPivotGrid.PivotGridField
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.tabDetalle = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNOMBRE_MUNICIPIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colESPECIALIDAD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNO_PARTICIPANTES = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_SOLICITUD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_GRUPO_AF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPROVEEDOR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTDR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEstadoTDR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMONTO_ADJUDICADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTITULO_TDR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colRESOLUCION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tabAnalisis = New DevExpress.XtraTab.XtraTabPage
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.fieldNOMBREMUNICIPIO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldESPECIALIDAD = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldPROVEEDOR = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldNOPARTICIPANTES = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldTDR = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldIDGRUPOAF1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldEstadoTDR = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldCANTTDR = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldTITULO_TDR = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMONTO_ADJUDICADO = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldRESOLUCION = New DevExpress.XtraPivotGrid.PivotGridField
        Me.tabGrafico = New DevExpress.XtraTab.XtraTabPage
        Me.txtTituloGrafico = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl
        Me.DS_DL1 = New SGAFP.DL.DS_DL
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.ReportE_TDR_ASOCIADOSTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.REPORTE_TDR_ASOCIADOSTableAdapter
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
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fieldIDSOLICITUD
        '
        Me.fieldIDSOLICITUD.AreaIndex = 1
        Me.fieldIDSOLICITUD.Caption = "Id Solicitud"
        Me.fieldIDSOLICITUD.ExpandedInFieldsGroup = False
        Me.fieldIDSOLICITUD.FieldName = "ID_SOLICITUD"
        Me.fieldIDSOLICITUD.Name = "fieldIDSOLICITUD"
        '
        'fieldIDGRUPOAF
        '
        Me.fieldIDGRUPOAF.AllowedAreas = CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) _
                    Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas)
        Me.fieldIDGRUPOAF.AreaIndex = 2
        Me.fieldIDGRUPOAF.Caption = "Id Grupo AF"
        Me.fieldIDGRUPOAF.FieldName = "ID_GRUPO_AF"
        Me.fieldIDGRUPOAF.Name = "fieldIDGRUPOAF"
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
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(746, 384)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNOMBRE_MUNICIPIO, Me.colESPECIALIDAD, Me.colNO_PARTICIPANTES, Me.colID_SOLICITUD, Me.colID_GRUPO_AF, Me.colPROVEEDOR, Me.colTDR, Me.colEstadoTDR, Me.colMONTO_ADJUDICADO, Me.colTITULO_TDR, Me.colRESOLUCION})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "NUME_FICH_PATI", Nothing, "Participantes ({0})")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        '
        'colNOMBRE_MUNICIPIO
        '
        Me.colNOMBRE_MUNICIPIO.Caption = "Municipio"
        Me.colNOMBRE_MUNICIPIO.FieldName = "NOMBRE_MUNICIPIO"
        Me.colNOMBRE_MUNICIPIO.Name = "colNOMBRE_MUNICIPIO"
        Me.colNOMBRE_MUNICIPIO.Visible = True
        Me.colNOMBRE_MUNICIPIO.VisibleIndex = 0
        '
        'colESPECIALIDAD
        '
        Me.colESPECIALIDAD.Caption = "Especialidad"
        Me.colESPECIALIDAD.FieldName = "ESPECIALIDAD"
        Me.colESPECIALIDAD.Name = "colESPECIALIDAD"
        Me.colESPECIALIDAD.Visible = True
        Me.colESPECIALIDAD.VisibleIndex = 1
        '
        'colNO_PARTICIPANTES
        '
        Me.colNO_PARTICIPANTES.Caption = "Cant. Participantes"
        Me.colNO_PARTICIPANTES.FieldName = "NO_PARTICIPANTES"
        Me.colNO_PARTICIPANTES.Name = "colNO_PARTICIPANTES"
        Me.colNO_PARTICIPANTES.Visible = True
        Me.colNO_PARTICIPANTES.VisibleIndex = 2
        '
        'colID_SOLICITUD
        '
        Me.colID_SOLICITUD.Caption = "Id Solicitud"
        Me.colID_SOLICITUD.FieldName = "ID_SOLICITUD"
        Me.colID_SOLICITUD.Name = "colID_SOLICITUD"
        Me.colID_SOLICITUD.Visible = True
        Me.colID_SOLICITUD.VisibleIndex = 3
        '
        'colID_GRUPO_AF
        '
        Me.colID_GRUPO_AF.Caption = "Id Grupo AF"
        Me.colID_GRUPO_AF.FieldName = "ID_GRUPO_AF"
        Me.colID_GRUPO_AF.Name = "colID_GRUPO_AF"
        Me.colID_GRUPO_AF.Visible = True
        Me.colID_GRUPO_AF.VisibleIndex = 4
        '
        'colPROVEEDOR
        '
        Me.colPROVEEDOR.Caption = "Proveedor"
        Me.colPROVEEDOR.FieldName = "PROVEEDOR"
        Me.colPROVEEDOR.Name = "colPROVEEDOR"
        Me.colPROVEEDOR.Visible = True
        Me.colPROVEEDOR.VisibleIndex = 5
        '
        'colTDR
        '
        Me.colTDR.FieldName = "TDR"
        Me.colTDR.Name = "colTDR"
        Me.colTDR.Visible = True
        Me.colTDR.VisibleIndex = 6
        '
        'colEstadoTDR
        '
        Me.colEstadoTDR.Caption = "Estado TDR"
        Me.colEstadoTDR.FieldName = "ESTADO"
        Me.colEstadoTDR.Name = "colEstadoTDR"
        Me.colEstadoTDR.Visible = True
        Me.colEstadoTDR.VisibleIndex = 7
        '
        'colMONTO_ADJUDICADO
        '
        Me.colMONTO_ADJUDICADO.Caption = "Monto Adjudicado"
        Me.colMONTO_ADJUDICADO.FieldName = "MONTO_ADJUDICADO"
        Me.colMONTO_ADJUDICADO.Name = "colMONTO_ADJUDICADO"
        Me.colMONTO_ADJUDICADO.Visible = True
        Me.colMONTO_ADJUDICADO.VisibleIndex = 8
        '
        'colTITULO_TDR
        '
        Me.colTITULO_TDR.Caption = "Titulo TDR"
        Me.colTITULO_TDR.FieldName = "TITULO_TDR"
        Me.colTITULO_TDR.Name = "colTITULO_TDR"
        Me.colTITULO_TDR.Visible = True
        Me.colTITULO_TDR.VisibleIndex = 9
        '
        'colRESOLUCION
        '
        Me.colRESOLUCION.Caption = "Orden Compra"
        Me.colRESOLUCION.FieldName = "RESOLUCION"
        Me.colRESOLUCION.Name = "colRESOLUCION"
        Me.colRESOLUCION.Visible = True
        Me.colRESOLUCION.VisibleIndex = 10
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
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldNOMBREMUNICIPIO, Me.fieldESPECIALIDAD, Me.fieldPROVEEDOR, Me.fieldNOPARTICIPANTES, Me.fieldIDSOLICITUD, Me.fieldIDGRUPOAF, Me.fieldTDR, Me.fieldIDGRUPOAF1, Me.fieldEstadoTDR, Me.fieldCANTTDR, Me.fieldTITULO_TDR, Me.fieldMONTO_ADJUDICADO, Me.fieldRESOLUCION})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText
        Me.PivotGridControl1.Size = New System.Drawing.Size(746, 384)
        Me.PivotGridControl1.TabIndex = 2
        '
        'fieldNOMBREMUNICIPIO
        '
        Me.fieldNOMBREMUNICIPIO.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldNOMBREMUNICIPIO.AreaIndex = 0
        Me.fieldNOMBREMUNICIPIO.Caption = "Municipio"
        Me.fieldNOMBREMUNICIPIO.FieldName = "NOMBRE_MUNICIPIO"
        Me.fieldNOMBREMUNICIPIO.Name = "fieldNOMBREMUNICIPIO"
        Me.fieldNOMBREMUNICIPIO.UnboundFieldName = "fieldNOMBREMUNICIPIO"
        '
        'fieldESPECIALIDAD
        '
        Me.fieldESPECIALIDAD.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldESPECIALIDAD.AreaIndex = 1
        Me.fieldESPECIALIDAD.Caption = "Especialidad"
        Me.fieldESPECIALIDAD.FieldName = "ESPECIALIDAD"
        Me.fieldESPECIALIDAD.Name = "fieldESPECIALIDAD"
        '
        'fieldPROVEEDOR
        '
        Me.fieldPROVEEDOR.AreaIndex = 0
        Me.fieldPROVEEDOR.Caption = "Proveedor"
        Me.fieldPROVEEDOR.FieldName = "PROVEEDOR"
        Me.fieldPROVEEDOR.Name = "fieldPROVEEDOR"
        '
        'fieldNOPARTICIPANTES
        '
        Me.fieldNOPARTICIPANTES.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldNOPARTICIPANTES.AreaIndex = 2
        Me.fieldNOPARTICIPANTES.Caption = "Cant. Participantes"
        Me.fieldNOPARTICIPANTES.CellFormat.FormatString = "N0"
        Me.fieldNOPARTICIPANTES.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldNOPARTICIPANTES.FieldName = "NO_PARTICIPANTES"
        Me.fieldNOPARTICIPANTES.GrandTotalCellFormat.FormatString = "N0"
        Me.fieldNOPARTICIPANTES.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldNOPARTICIPANTES.Name = "fieldNOPARTICIPANTES"
        Me.fieldNOPARTICIPANTES.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.fieldNOPARTICIPANTES.TotalCellFormat.FormatString = "N0"
        Me.fieldNOPARTICIPANTES.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldNOPARTICIPANTES.TotalValueFormat.FormatString = "N0"
        Me.fieldNOPARTICIPANTES.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldNOPARTICIPANTES.UnboundFieldName = "fieldNOPARTICIPANTES"
        Me.fieldNOPARTICIPANTES.ValueFormat.FormatString = "N0"
        Me.fieldNOPARTICIPANTES.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldNOPARTICIPANTES.Width = 118
        '
        'fieldTDR
        '
        Me.fieldTDR.AreaIndex = 3
        Me.fieldTDR.FieldName = "TDR"
        Me.fieldTDR.Name = "fieldTDR"
        '
        'fieldIDGRUPOAF1
        '
        Me.fieldIDGRUPOAF1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldIDGRUPOAF1.AreaIndex = 1
        Me.fieldIDGRUPOAF1.Caption = "Cant. Grupo"
        Me.fieldIDGRUPOAF1.CellFormat.FormatString = "N0"
        Me.fieldIDGRUPOAF1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldIDGRUPOAF1.FieldName = "ID_GRUPO_AF"
        Me.fieldIDGRUPOAF1.GrandTotalCellFormat.FormatString = "N0"
        Me.fieldIDGRUPOAF1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldIDGRUPOAF1.Name = "fieldIDGRUPOAF1"
        Me.fieldIDGRUPOAF1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.fieldIDGRUPOAF1.TotalCellFormat.FormatString = "N0"
        Me.fieldIDGRUPOAF1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldIDGRUPOAF1.TotalValueFormat.FormatString = "N0"
        Me.fieldIDGRUPOAF1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldIDGRUPOAF1.ValueFormat.FormatString = "N0"
        Me.fieldIDGRUPOAF1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldEstadoTDR
        '
        Me.fieldEstadoTDR.AreaIndex = 5
        Me.fieldEstadoTDR.Caption = "Estado TDR"
        Me.fieldEstadoTDR.FieldName = "ESTADO"
        Me.fieldEstadoTDR.Name = "fieldEstadoTDR"
        '
        'fieldCANTTDR
        '
        Me.fieldCANTTDR.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldCANTTDR.AreaIndex = 0
        Me.fieldCANTTDR.Caption = "Cant. TDR"
        Me.fieldCANTTDR.CellFormat.FormatString = "N0"
        Me.fieldCANTTDR.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldCANTTDR.FieldName = "TDR"
        Me.fieldCANTTDR.GrandTotalCellFormat.FormatString = "N0"
        Me.fieldCANTTDR.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldCANTTDR.Name = "fieldCANTTDR"
        Me.fieldCANTTDR.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.fieldCANTTDR.TotalCellFormat.FormatString = "N0"
        Me.fieldCANTTDR.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldCANTTDR.TotalValueFormat.FormatString = "N0"
        Me.fieldCANTTDR.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldCANTTDR.ValueFormat.FormatString = "N0"
        Me.fieldCANTTDR.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldTITULO_TDR
        '
        Me.fieldTITULO_TDR.AreaIndex = 4
        Me.fieldTITULO_TDR.Caption = "Titulo TDR"
        Me.fieldTITULO_TDR.FieldName = "TITULO_TDR"
        Me.fieldTITULO_TDR.Name = "fieldTITULO_TDR"
        '
        'fieldMONTO_ADJUDICADO
        '
        Me.fieldMONTO_ADJUDICADO.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldMONTO_ADJUDICADO.AreaIndex = 3
        Me.fieldMONTO_ADJUDICADO.Caption = "Monto Adjudicado"
        Me.fieldMONTO_ADJUDICADO.FieldName = "MONTO_ADJUDICADO"
        Me.fieldMONTO_ADJUDICADO.Name = "fieldMONTO_ADJUDICADO"
        Me.fieldMONTO_ADJUDICADO.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        '
        'fieldRESOLUCION
        '
        Me.fieldRESOLUCION.AreaIndex = 6
        Me.fieldRESOLUCION.Caption = "Orden Compra"
        Me.fieldRESOLUCION.FieldName = "RESOLUCION"
        Me.fieldRESOLUCION.Name = "fieldRESOLUCION"
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
        Me.txtTituloGrafico.EditValue = "Analisis TDRs PATI"
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
        Bar3DSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.[Default]
        Bar3DSeriesLabel1.Visible = True
        Me.ChartControl1.SeriesTemplate.Label = Bar3DSeriesLabel1
        Me.ChartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values"
        Me.ChartControl1.SeriesTemplate.View = ManhattanBarSeriesView1
        Me.ChartControl1.Size = New System.Drawing.Size(738, 348)
        Me.ChartControl1.TabIndex = 8
        ChartTitle1.Text = "TDRs PATI"
        Me.ChartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'DS_DL1
        '
        Me.DS_DL1.DataSetName = "DS_DL"
        Me.DS_DL1.EnforceConstraints = False
        Me.DS_DL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ReportE_TDR_ASOCIADOSTableAdapter1
        '
        Me.ReportE_TDR_ASOCIADOSTableAdapter1.ClearBeforeFill = True
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
        'frmTDRsAsociadosPATI
        '
        Me.ClientSize = New System.Drawing.Size(752, 500)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "frmTDRsAsociadosPATI"
        Me.Text = "Asociacion TDRs PATI"
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
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents fieldNOMBREMUNICIPIO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ReportE_TDR_ASOCIADOSTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.REPORTE_TDR_ASOCIADOSTableAdapter
    Friend WithEvents colNOMBRE_MUNICIPIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESPECIALIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNO_PARTICIPANTES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_SOLICITUD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_GRUPO_AF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPROVEEDOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTDR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldESPECIALIDAD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPROVEEDOR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNOPARTICIPANTES As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldIDSOLICITUD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldIDGRUPOAF As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTDR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldIDGRUPOAF1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colEstadoTDR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldEstadoTDR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCANTTDR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colMONTO_ADJUDICADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTITULO_TDR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldTITULO_TDR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMONTO_ADJUDICADO As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colRESOLUCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fieldRESOLUCION As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents CbxPROGRAMA_FORMACION1 As SGAFP.WinUC.cbxPROGRAMA_FORMACION
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

End Class
