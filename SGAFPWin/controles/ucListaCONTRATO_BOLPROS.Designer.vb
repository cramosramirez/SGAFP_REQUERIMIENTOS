<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaCONTRATO_BOLPROS
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
        Me.components = New System.ComponentModel.Container()
        Me.ListaCONTRATO_BOLPROSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaCONTRATO_BOLPROSGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ListaCONTRATO_BOLPROSGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_CONTRATO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID_TIPO_CONTRA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID_PROVEEDOR_AF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID_PROGRAMA_FORMACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID_FUENTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrograma = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNUM_CONTRATO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIPO_CONTRATO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMONTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMontoItem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLOTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSUB_LOTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSUARIO_CREACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA_CREACION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSERID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLASTUPDATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtNUM_CONTRATO = New System.Windows.Forms.TextBox()
        Me.CbxPROVEEDOR_AF1 = New SGAFP.WinUC.cbxPROVEEDOR_AF()
        Me.CbxPROGRAMA_FORMACION1 = New SGAFP.WinUC.cbxPROGRAMA_FORMACION()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtNoOfertaCompra = New System.Windows.Forms.TextBox()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.ListaCONTRATO_BOLPROSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaCONTRATO_BOLPROSGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaCONTRATO_BOLPROSGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaCONTRATO_BOLPROSBindingSource
        '
        Me.ListaCONTRATO_BOLPROSBindingSource.DataSource = GetType(SGAFP.EL.CONTRATO_BOLPROS)
        '
        'ListaCONTRATO_BOLPROSGridControl
        '
        Me.ListaCONTRATO_BOLPROSGridControl.DataSource = Me.ListaCONTRATO_BOLPROSBindingSource
        Me.ListaCONTRATO_BOLPROSGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListaCONTRATO_BOLPROSGridControl.Location = New System.Drawing.Point(0, 0)
        Me.ListaCONTRATO_BOLPROSGridControl.MainView = Me.ListaCONTRATO_BOLPROSGridView
        Me.ListaCONTRATO_BOLPROSGridControl.Name = "ListaCONTRATO_BOLPROSGridControl"
        Me.ListaCONTRATO_BOLPROSGridControl.Size = New System.Drawing.Size(813, 344)
        Me.ListaCONTRATO_BOLPROSGridControl.TabIndex = 1
        Me.ListaCONTRATO_BOLPROSGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ListaCONTRATO_BOLPROSGridView})
        '
        'ListaCONTRATO_BOLPROSGridView
        '
        Me.ListaCONTRATO_BOLPROSGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_CONTRATO, Me.colID_TIPO_CONTRA, Me.colID_PROVEEDOR_AF, Me.colID_PROGRAMA_FORMACION, Me.colID_FUENTE, Me.colProveedor, Me.colPrograma, Me.colNUM_CONTRATO, Me.colTIPO_CONTRATO, Me.colMONTO, Me.colMontoItem, Me.colLOTE, Me.colSUB_LOTE, Me.colUSUARIO_CREACION, Me.colFECHA_CREACION, Me.colUSERID, Me.colLASTUPDATE})
        Me.ListaCONTRATO_BOLPROSGridView.GridControl = Me.ListaCONTRATO_BOLPROSGridControl
        Me.ListaCONTRATO_BOLPROSGridView.Name = "ListaCONTRATO_BOLPROSGridView"
        Me.ListaCONTRATO_BOLPROSGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.ListaCONTRATO_BOLPROSGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.ListaCONTRATO_BOLPROSGridView.OptionsBehavior.Editable = False
        Me.ListaCONTRATO_BOLPROSGridView.OptionsBehavior.ReadOnly = True
        Me.ListaCONTRATO_BOLPROSGridView.OptionsView.ShowGroupPanel = False
        '
        'colID_CONTRATO
        '
        Me.colID_CONTRATO.Caption = "ID"
        Me.colID_CONTRATO.FieldName = "ID_CONTRATO"
        Me.colID_CONTRATO.Name = "colID_CONTRATO"
        Me.colID_CONTRATO.Visible = True
        Me.colID_CONTRATO.VisibleIndex = 0
        Me.colID_CONTRATO.Width = 39
        '
        'colID_TIPO_CONTRA
        '
        Me.colID_TIPO_CONTRA.FieldName = "ID_TIPO_CONTRA"
        Me.colID_TIPO_CONTRA.Name = "colID_TIPO_CONTRA"
        '
        'colID_PROVEEDOR_AF
        '
        Me.colID_PROVEEDOR_AF.Caption = "Id proveedor af"
        Me.colID_PROVEEDOR_AF.FieldName = "ID_PROVEEDOR_AF"
        Me.colID_PROVEEDOR_AF.Name = "colID_PROVEEDOR_AF"
        '
        'colID_PROGRAMA_FORMACION
        '
        Me.colID_PROGRAMA_FORMACION.Caption = "Id programa formacion"
        Me.colID_PROGRAMA_FORMACION.FieldName = "ID_PROGRAMA_FORMACION"
        Me.colID_PROGRAMA_FORMACION.Name = "colID_PROGRAMA_FORMACION"
        '
        'colID_FUENTE
        '
        Me.colID_FUENTE.Caption = "Id fuente"
        Me.colID_FUENTE.FieldName = "ID_FUENTE"
        Me.colID_FUENTE.Name = "colID_FUENTE"
        '
        'colProveedor
        '
        Me.colProveedor.Caption = "Proveedor"
        Me.colProveedor.FieldName = "colProveedor"
        Me.colProveedor.Name = "colProveedor"
        Me.colProveedor.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colProveedor.Visible = True
        Me.colProveedor.VisibleIndex = 1
        Me.colProveedor.Width = 154
        '
        'colPrograma
        '
        Me.colPrograma.Caption = "Programa"
        Me.colPrograma.FieldName = "colPrograma"
        Me.colPrograma.Name = "colPrograma"
        Me.colPrograma.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colPrograma.Visible = True
        Me.colPrograma.VisibleIndex = 2
        Me.colPrograma.Width = 165
        '
        'colNUM_CONTRATO
        '
        Me.colNUM_CONTRATO.AppearanceCell.Options.UseTextOptions = True
        Me.colNUM_CONTRATO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNUM_CONTRATO.Caption = "N° Contrato"
        Me.colNUM_CONTRATO.FieldName = "NUM_CONTRATO"
        Me.colNUM_CONTRATO.Name = "colNUM_CONTRATO"
        Me.colNUM_CONTRATO.Visible = True
        Me.colNUM_CONTRATO.VisibleIndex = 3
        Me.colNUM_CONTRATO.Width = 70
        '
        'colTIPO_CONTRATO
        '
        Me.colTIPO_CONTRATO.Caption = "Tipo Contrato"
        Me.colTIPO_CONTRATO.FieldName = "colTIPO_CONTRATO"
        Me.colTIPO_CONTRATO.Name = "colTIPO_CONTRATO"
        Me.colTIPO_CONTRATO.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colTIPO_CONTRATO.Visible = True
        Me.colTIPO_CONTRATO.VisibleIndex = 4
        Me.colTIPO_CONTRATO.Width = 80
        '
        'colMONTO
        '
        Me.colMONTO.Caption = "Monto"
        Me.colMONTO.DisplayFormat.FormatString = "c2"
        Me.colMONTO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMONTO.FieldName = "MONTO"
        Me.colMONTO.Name = "colMONTO"
        Me.colMONTO.Visible = True
        Me.colMONTO.VisibleIndex = 5
        Me.colMONTO.Width = 76
        '
        'colMontoItem
        '
        Me.colMontoItem.Caption = "Monto Items"
        Me.colMontoItem.DisplayFormat.FormatString = "c2"
        Me.colMontoItem.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMontoItem.FieldName = "colMontoItem"
        Me.colMontoItem.Name = "colMontoItem"
        Me.colMontoItem.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.colMontoItem.Visible = True
        Me.colMontoItem.VisibleIndex = 6
        '
        'colLOTE
        '
        Me.colLOTE.AppearanceCell.Options.UseTextOptions = True
        Me.colLOTE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLOTE.AppearanceHeader.Options.UseTextOptions = True
        Me.colLOTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLOTE.Caption = "Lote"
        Me.colLOTE.FieldName = "LOTE"
        Me.colLOTE.Name = "colLOTE"
        Me.colLOTE.Visible = True
        Me.colLOTE.VisibleIndex = 7
        Me.colLOTE.Width = 41
        '
        'colSUB_LOTE
        '
        Me.colSUB_LOTE.AppearanceCell.Options.UseTextOptions = True
        Me.colSUB_LOTE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSUB_LOTE.AppearanceHeader.Options.UseTextOptions = True
        Me.colSUB_LOTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSUB_LOTE.Caption = "Sub lote"
        Me.colSUB_LOTE.FieldName = "SUB_LOTE"
        Me.colSUB_LOTE.Name = "colSUB_LOTE"
        Me.colSUB_LOTE.Visible = True
        Me.colSUB_LOTE.VisibleIndex = 8
        Me.colSUB_LOTE.Width = 41
        '
        'colUSUARIO_CREACION
        '
        Me.colUSUARIO_CREACION.Caption = "Usuario creacion"
        Me.colUSUARIO_CREACION.FieldName = "USUARIO_CREACION"
        Me.colUSUARIO_CREACION.Name = "colUSUARIO_CREACION"
        '
        'colFECHA_CREACION
        '
        Me.colFECHA_CREACION.Caption = "Fecha Creacion"
        Me.colFECHA_CREACION.DisplayFormat.FormatString = "d"
        Me.colFECHA_CREACION.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFECHA_CREACION.FieldName = "FECHA_CREACION"
        Me.colFECHA_CREACION.Name = "colFECHA_CREACION"
        Me.colFECHA_CREACION.Visible = True
        Me.colFECHA_CREACION.VisibleIndex = 9
        Me.colFECHA_CREACION.Width = 73
        '
        'colUSERID
        '
        Me.colUSERID.Caption = "Userid"
        Me.colUSERID.FieldName = "USERID"
        Me.colUSERID.Name = "colUSERID"
        '
        'colLASTUPDATE
        '
        Me.colLASTUPDATE.Caption = "Fecha Actualización"
        Me.colLASTUPDATE.FieldName = "LASTUPDATE"
        Me.colLASTUPDATE.Name = "colLASTUPDATE"
        Me.colLASTUPDATE.Width = 145
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LayoutControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.ListaCONTRATO_BOLPROSGridControl)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(813, 482)
        Me.SplitContainerControl1.SplitterPosition = 133
        Me.SplitContainerControl1.TabIndex = 3
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtNoOfertaCompra)
        Me.LayoutControl1.Controls.Add(Me.txtNUM_CONTRATO)
        Me.LayoutControl1.Controls.Add(Me.CbxPROVEEDOR_AF1)
        Me.LayoutControl1.Controls.Add(Me.CbxPROGRAMA_FORMACION1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(268, 303, 250, 350)
        Me.LayoutControl1.OptionsView.UseDefaultDragAndDropRendering = False
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(813, 133)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtNUM_CONTRATO
        '
        Me.txtNUM_CONTRATO.Location = New System.Drawing.Point(106, 61)
        Me.txtNUM_CONTRATO.Name = "txtNUM_CONTRATO"
        Me.txtNUM_CONTRATO.Size = New System.Drawing.Size(695, 20)
        Me.txtNUM_CONTRATO.TabIndex = 6
        '
        'CbxPROVEEDOR_AF1
        '
        Me.CbxPROVEEDOR_AF1.AllowFindEntityType = Nothing
        Me.CbxPROVEEDOR_AF1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxPROVEEDOR_AF1.Location = New System.Drawing.Point(106, 12)
        Me.CbxPROVEEDOR_AF1.Name = "CbxPROVEEDOR_AF1"
        Me.CbxPROVEEDOR_AF1.Size = New System.Drawing.Size(695, 21)
        Me.CbxPROVEEDOR_AF1.TabIndex = 5
        '
        'CbxPROGRAMA_FORMACION1
        '
        Me.CbxPROGRAMA_FORMACION1.AllowFindEntityType = Nothing
        Me.CbxPROGRAMA_FORMACION1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxPROGRAMA_FORMACION1.Location = New System.Drawing.Point(106, 85)
        Me.CbxPROGRAMA_FORMACION1.Name = "CbxPROGRAMA_FORMACION1"
        Me.CbxPROGRAMA_FORMACION1.Size = New System.Drawing.Size(695, 21)
        Me.CbxPROGRAMA_FORMACION1.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(813, 133)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.CbxPROGRAMA_FORMACION1
        Me.LayoutControlItem1.CustomizationFormText = "Programa:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 73)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(793, 40)
        Me.LayoutControlItem1.Text = "Programa:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(91, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.CbxPROVEEDOR_AF1
        Me.LayoutControlItem2.CustomizationFormText = "Proveedor:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(793, 25)
        Me.LayoutControlItem2.Text = "Proveedor:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(91, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtNUM_CONTRATO
        Me.LayoutControlItem3.CustomizationFormText = "N° de Contrato:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 49)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(793, 24)
        Me.LayoutControlItem3.Text = "N° de Contrato:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(91, 13)
        '
        'txtNoOfertaCompra
        '
        Me.txtNoOfertaCompra.Location = New System.Drawing.Point(106, 37)
        Me.txtNoOfertaCompra.Name = "txtNoOfertaCompra"
        Me.txtNoOfertaCompra.Size = New System.Drawing.Size(695, 20)
        Me.txtNoOfertaCompra.TabIndex = 7
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtNoOfertaCompra
        Me.LayoutControlItem4.CustomizationFormText = "N° Oferta Compra:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 25)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(793, 24)
        Me.LayoutControlItem4.Text = "N° Oferta Compra:"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(91, 13)
        '
        'ucListaCONTRATO_BOLPROS
        '
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "ucListaCONTRATO_BOLPROS"
        Me.Size = New System.Drawing.Size(813, 507)
        Me.Controls.SetChildIndex(Me.SplitContainerControl1, 0)
        CType(Me.ListaCONTRATO_BOLPROSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaCONTRATO_BOLPROSGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaCONTRATO_BOLPROSGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaCONTRATO_BOLPROSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaCONTRATO_BOLPROSGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListaCONTRATO_BOLPROSGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_CONTRATO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_PROVEEDOR_AF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_PROGRAMA_FORMACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_FUENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUM_CONTRATO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLOTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSUB_LOTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSUARIO_CREACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_CREACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSERID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLASTUPDATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents CbxPROGRAMA_FORMACION1 As SGAFP.WinUC.cbxPROGRAMA_FORMACION
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CbxPROVEEDOR_AF1 As SGAFP.WinUC.cbxPROVEEDOR_AF
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colPrograma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_TIPO_CONTRA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIPO_CONTRATO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMontoItem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNUM_CONTRATO As System.Windows.Forms.TextBox
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtNoOfertaCompra As System.Windows.Forms.TextBox
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

End Class
