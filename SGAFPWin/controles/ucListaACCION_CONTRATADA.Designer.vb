<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaACCION_CONTRATADA
    Inherits SGAFP.ucBaseLista

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
        Me.components = New System.ComponentModel.Container
        Me.ListaACCION_CONTRATADABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaACCION_CONTRATADAGridControl = New DevExpress.XtraGrid.GridControl
        Me.ListaACCION_CONTRATADAGridView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colProveedor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrograma = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colContrato = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLote = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSubLote = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNUM_ITEM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDeptoMunicipio = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colProgramaSIFP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDURACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCANT_CURSOS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMONTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGruposPATI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_ACCION_CONTRATADA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_CONTRATO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_PROGRAMA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_CREACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUSERID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLASTUPDATE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUSUARIO_CREACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_DEPARTAMENTO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCODIGO_MUNICIPIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHabilitada = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl
        Me.TextEditNUM_CONTRATO = New DevExpress.XtraEditors.TextEdit
        Me.CbxPROVEEDOR_AF1 = New SGAFP.WinUC.cbxPROVEEDOR_AF
        Me.CbxPROGRAMA_FORMACION1 = New SGAFP.WinUC.cbxPROGRAMA_FORMACION
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        CType(Me.ListaACCION_CONTRATADABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaACCION_CONTRATADAGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaACCION_CONTRATADAGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.TextEditNUM_CONTRATO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaACCION_CONTRATADABindingSource
        '
        Me.ListaACCION_CONTRATADABindingSource.DataSource = GetType(SGAFP.EL.ACCION_CONTRATADA)
        '
        'ListaACCION_CONTRATADAGridControl
        '
        Me.ListaACCION_CONTRATADAGridControl.DataSource = Me.ListaACCION_CONTRATADABindingSource
        Me.ListaACCION_CONTRATADAGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListaACCION_CONTRATADAGridControl.Location = New System.Drawing.Point(0, 0)
        Me.ListaACCION_CONTRATADAGridControl.MainView = Me.ListaACCION_CONTRATADAGridView
        Me.ListaACCION_CONTRATADAGridControl.Name = "ListaACCION_CONTRATADAGridControl"
        Me.ListaACCION_CONTRATADAGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.ListaACCION_CONTRATADAGridControl.Size = New System.Drawing.Size(884, 243)
        Me.ListaACCION_CONTRATADAGridControl.TabIndex = 1
        Me.ListaACCION_CONTRATADAGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListaACCION_CONTRATADAGridView})
        '
        'ListaACCION_CONTRATADAGridView
        '
        Me.ListaACCION_CONTRATADAGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProveedor, Me.colPrograma, Me.colContrato, Me.colLote, Me.colSubLote, Me.colNUM_ITEM, Me.colDeptoMunicipio, Me.colProgramaSIFP, Me.colDURACION, Me.colMONTO, Me.colCANT_CURSOS, Me.colGruposPATI, Me.colID_ACCION_CONTRATADA, Me.colID_CONTRATO, Me.colCODIGO_PROGRAMA, Me.colFECHA_CREACION, Me.colUSERID, Me.colLASTUPDATE, Me.colUSUARIO_CREACION, Me.colCODIGO_DEPARTAMENTO, Me.colCODIGO_MUNICIPIO, Me.colHabilitada})
        Me.ListaACCION_CONTRATADAGridView.GridControl = Me.ListaACCION_CONTRATADAGridControl
        Me.ListaACCION_CONTRATADAGridView.Name = "ListaACCION_CONTRATADAGridView"
        Me.ListaACCION_CONTRATADAGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.ListaACCION_CONTRATADAGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.ListaACCION_CONTRATADAGridView.OptionsBehavior.Editable = False
        Me.ListaACCION_CONTRATADAGridView.OptionsBehavior.ReadOnly = True
        Me.ListaACCION_CONTRATADAGridView.OptionsView.ShowGroupPanel = False
        '
        'colProveedor
        '
        Me.colProveedor.Caption = "Proveedor"
        Me.colProveedor.FieldName = "colProveedor"
        Me.colProveedor.Name = "colProveedor"
        Me.colProveedor.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colProveedor.Visible = True
        Me.colProveedor.VisibleIndex = 0
        Me.colProveedor.Width = 76
        '
        'colPrograma
        '
        Me.colPrograma.Caption = "Programa"
        Me.colPrograma.FieldName = "colPrograma"
        Me.colPrograma.Name = "colPrograma"
        Me.colPrograma.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colPrograma.Visible = True
        Me.colPrograma.VisibleIndex = 1
        Me.colPrograma.Width = 76
        '
        'colContrato
        '
        Me.colContrato.AppearanceCell.Options.UseTextOptions = True
        Me.colContrato.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContrato.AppearanceHeader.Options.UseTextOptions = True
        Me.colContrato.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContrato.Caption = "Contrato"
        Me.colContrato.FieldName = "colContrato"
        Me.colContrato.Name = "colContrato"
        Me.colContrato.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colContrato.Visible = True
        Me.colContrato.VisibleIndex = 2
        Me.colContrato.Width = 76
        '
        'colLote
        '
        Me.colLote.AppearanceCell.Options.UseTextOptions = True
        Me.colLote.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLote.AppearanceHeader.Options.UseTextOptions = True
        Me.colLote.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLote.Caption = "Lote"
        Me.colLote.FieldName = "colLote"
        Me.colLote.Name = "colLote"
        Me.colLote.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        '
        'colSubLote
        '
        Me.colSubLote.AppearanceCell.Options.UseTextOptions = True
        Me.colSubLote.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSubLote.AppearanceHeader.Options.UseTextOptions = True
        Me.colSubLote.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSubLote.Caption = "Sub Lote"
        Me.colSubLote.FieldName = "colSubLote"
        Me.colSubLote.Name = "colSubLote"
        Me.colSubLote.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        '
        'colNUM_ITEM
        '
        Me.colNUM_ITEM.AppearanceCell.Options.UseTextOptions = True
        Me.colNUM_ITEM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNUM_ITEM.AppearanceHeader.Options.UseTextOptions = True
        Me.colNUM_ITEM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNUM_ITEM.Caption = "Item"
        Me.colNUM_ITEM.FieldName = "NUM_ITEM"
        Me.colNUM_ITEM.Name = "colNUM_ITEM"
        Me.colNUM_ITEM.Visible = True
        Me.colNUM_ITEM.VisibleIndex = 3
        Me.colNUM_ITEM.Width = 76
        '
        'colDeptoMunicipio
        '
        Me.colDeptoMunicipio.Caption = "Depto., Municipio"
        Me.colDeptoMunicipio.FieldName = "colDeptoMunicipio"
        Me.colDeptoMunicipio.Name = "colDeptoMunicipio"
        Me.colDeptoMunicipio.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colDeptoMunicipio.Visible = True
        Me.colDeptoMunicipio.VisibleIndex = 4
        Me.colDeptoMunicipio.Width = 128
        '
        'colProgramaSIFP
        '
        Me.colProgramaSIFP.Caption = "Curso"
        Me.colProgramaSIFP.FieldName = "colProgramaSIFP"
        Me.colProgramaSIFP.Name = "colProgramaSIFP"
        Me.colProgramaSIFP.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colProgramaSIFP.Visible = True
        Me.colProgramaSIFP.VisibleIndex = 5
        Me.colProgramaSIFP.Width = 68
        '
        'colDURACION
        '
        Me.colDURACION.AppearanceCell.Options.UseTextOptions = True
        Me.colDURACION.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDURACION.AppearanceHeader.Options.UseTextOptions = True
        Me.colDURACION.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDURACION.Caption = "Duración"
        Me.colDURACION.FieldName = "DURACION"
        Me.colDURACION.Name = "colDURACION"
        Me.colDURACION.Visible = True
        Me.colDURACION.VisibleIndex = 6
        Me.colDURACION.Width = 73
        '
        'colCANT_CURSOS
        '
        Me.colCANT_CURSOS.AppearanceCell.Options.UseTextOptions = True
        Me.colCANT_CURSOS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCANT_CURSOS.AppearanceHeader.Options.UseTextOptions = True
        Me.colCANT_CURSOS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCANT_CURSOS.Caption = "Cantidad Cursos"
        Me.colCANT_CURSOS.FieldName = "CANT_CURSOS"
        Me.colCANT_CURSOS.Name = "colCANT_CURSOS"
        Me.colCANT_CURSOS.Visible = True
        Me.colCANT_CURSOS.VisibleIndex = 7
        Me.colCANT_CURSOS.Width = 68
        '
        'colMONTO
        '
        Me.colMONTO.Caption = "Monto Total"
        Me.colMONTO.DisplayFormat.FormatString = "c2"
        Me.colMONTO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO.FieldName = "MONTO"
        Me.colMONTO.Name = "colMONTO"
        Me.colMONTO.Visible = True
        Me.colMONTO.VisibleIndex = 7
        Me.colMONTO.Width = 68
        '
        'colGruposPATI
        '
        Me.colGruposPATI.AppearanceCell.Options.UseTextOptions = True
        Me.colGruposPATI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGruposPATI.AppearanceHeader.Options.UseTextOptions = True
        Me.colGruposPATI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGruposPATI.Caption = "N° Grupos Asoc."
        Me.colGruposPATI.FieldName = "colGruposPATI"
        Me.colGruposPATI.Name = "colGruposPATI"
        Me.colGruposPATI.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.colGruposPATI.Visible = True
        Me.colGruposPATI.VisibleIndex = 9
        Me.colGruposPATI.Width = 100
        '
        'colID_ACCION_CONTRATADA
        '
        Me.colID_ACCION_CONTRATADA.FieldName = "ID_ACCION_CONTRATADA"
        Me.colID_ACCION_CONTRATADA.Name = "colID_ACCION_CONTRATADA"
        '
        'colID_CONTRATO
        '
        Me.colID_CONTRATO.FieldName = "ID_CONTRATO"
        Me.colID_CONTRATO.Name = "colID_CONTRATO"
        '
        'colCODIGO_PROGRAMA
        '
        Me.colCODIGO_PROGRAMA.FieldName = "CODIGO_PROGRAMA"
        Me.colCODIGO_PROGRAMA.Name = "colCODIGO_PROGRAMA"
        '
        'colFECHA_CREACION
        '
        Me.colFECHA_CREACION.FieldName = "FECHA_CREACION"
        Me.colFECHA_CREACION.Name = "colFECHA_CREACION"
        '
        'colUSERID
        '
        Me.colUSERID.FieldName = "USERID"
        Me.colUSERID.Name = "colUSERID"
        '
        'colLASTUPDATE
        '
        Me.colLASTUPDATE.FieldName = "LASTUPDATE"
        Me.colLASTUPDATE.Name = "colLASTUPDATE"
        '
        'colUSUARIO_CREACION
        '
        Me.colUSUARIO_CREACION.FieldName = "USUARIO_CREACION"
        Me.colUSUARIO_CREACION.Name = "colUSUARIO_CREACION"
        '
        'colCODIGO_DEPARTAMENTO
        '
        Me.colCODIGO_DEPARTAMENTO.FieldName = "CODIGO_DEPARTAMENTO"
        Me.colCODIGO_DEPARTAMENTO.Name = "colCODIGO_DEPARTAMENTO"
        '
        'colCODIGO_MUNICIPIO
        '
        Me.colCODIGO_MUNICIPIO.FieldName = "CODIGO_MUNICIPIO"
        Me.colCODIGO_MUNICIPIO.Name = "colCODIGO_MUNICIPIO"
        '
        'colHabilitada
        '
        Me.colHabilitada.AppearanceCell.Options.UseTextOptions = True
        Me.colHabilitada.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHabilitada.AppearanceHeader.Options.UseTextOptions = True
        Me.colHabilitada.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHabilitada.Caption = "Grupos Habilitados"
        Me.colHabilitada.FieldName = "colHabilitada"
        Me.colHabilitada.Name = "colHabilitada"
        Me.colHabilitada.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.colHabilitada.Visible = True
        Me.colHabilitada.VisibleIndex = 10
        Me.colHabilitada.Width = 57
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 28)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LayoutControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.ListaACCION_CONTRATADAGridControl)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(884, 326)
        Me.SplitContainerControl1.SplitterPosition = 78
        Me.SplitContainerControl1.TabIndex = 3
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.TextEditNUM_CONTRATO)
        Me.LayoutControl1.Controls.Add(Me.CbxPROVEEDOR_AF1)
        Me.LayoutControl1.Controls.Add(Me.CbxPROGRAMA_FORMACION1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(884, 78)
        Me.LayoutControl1.TabIndex = 1
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'TextEditNUM_CONTRATO
        '
        Me.TextEditNUM_CONTRATO.Location = New System.Drawing.Point(497, 37)
        Me.TextEditNUM_CONTRATO.Name = "TextEditNUM_CONTRATO"
        Me.TextEditNUM_CONTRATO.Size = New System.Drawing.Size(375, 20)
        Me.TextEditNUM_CONTRATO.StyleController = Me.LayoutControl1
        Me.TextEditNUM_CONTRATO.TabIndex = 6
        '
        'CbxPROVEEDOR_AF1
        '
        Me.CbxPROVEEDOR_AF1.AllowFindEntityType = Nothing
        Me.CbxPROVEEDOR_AF1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxPROVEEDOR_AF1.Location = New System.Drawing.Point(70, 12)
        Me.CbxPROVEEDOR_AF1.Name = "CbxPROVEEDOR_AF1"
        Me.CbxPROVEEDOR_AF1.Size = New System.Drawing.Size(802, 21)
        Me.CbxPROVEEDOR_AF1.TabIndex = 5
        '
        'CbxPROGRAMA_FORMACION1
        '
        Me.CbxPROGRAMA_FORMACION1.AllowFindEntityType = Nothing
        Me.CbxPROGRAMA_FORMACION1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxPROGRAMA_FORMACION1.Location = New System.Drawing.Point(70, 37)
        Me.CbxPROGRAMA_FORMACION1.Name = "CbxPROGRAMA_FORMACION1"
        Me.CbxPROGRAMA_FORMACION1.Size = New System.Drawing.Size(365, 21)
        Me.CbxPROGRAMA_FORMACION1.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(884, 78)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.CbxPROGRAMA_FORMACION1
        Me.LayoutControlItem1.CustomizationFormText = "Programa:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 25)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(427, 33)
        Me.LayoutControlItem1.Text = "Programa:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(54, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.CbxPROVEEDOR_AF1
        Me.LayoutControlItem2.CustomizationFormText = "Proveedor:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(864, 25)
        Me.LayoutControlItem2.Text = "Proveedor:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(54, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.TextEditNUM_CONTRATO
        Me.LayoutControlItem3.CustomizationFormText = "Contrato:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(427, 25)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(437, 33)
        Me.LayoutControlItem3.Text = "Contrato:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(54, 13)
        '
        'ucListaACCION_CONTRATADA
        '
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "ucListaACCION_CONTRATADA"
        Me.Size = New System.Drawing.Size(884, 354)
        Me.Controls.SetChildIndex(Me.SplitContainerControl1, 0)
        CType(Me.ListaACCION_CONTRATADABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaACCION_CONTRATADAGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaACCION_CONTRATADAGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.TextEditNUM_CONTRATO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaACCION_CONTRATADABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaACCION_CONTRATADAGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListaACCION_CONTRATADAGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents TextEditNUM_CONTRATO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CbxPROVEEDOR_AF1 As SGAFP.WinUC.cbxPROVEEDOR_AF
    Friend WithEvents CbxPROGRAMA_FORMACION1 As SGAFP.WinUC.cbxPROGRAMA_FORMACION
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colProveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrograma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContrato As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubLote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUM_ITEM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgramaSIFP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCANT_CURSOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGruposPATI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeptoMunicipio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_ACCION_CONTRATADA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_CONTRATO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_PROGRAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_CREACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSERID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLASTUPDATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSUARIO_CREACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_DEPARTAMENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO_MUNICIPIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDURACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHabilitada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit

End Class
