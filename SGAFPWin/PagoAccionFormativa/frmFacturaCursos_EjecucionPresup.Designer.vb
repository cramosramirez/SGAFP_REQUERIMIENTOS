<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturaCursos_EjecucionPresup
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
        Me.components = New System.ComponentModel.Container
        Me.DataTableEjecucionPresBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridEjecucionPres = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colID_COMPROMISO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colID_CONTRATO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNUM_COMPROMISO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMONTO_COMPROMETIDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_INICIAL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFECHA_FINAL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMONTO_PROVISIONADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMONTO_DEVENGADO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDISTRIBUCION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSALDO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUSERID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLASTUPDATE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButtonCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButtonAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.DS_DL1 = New SGAFP.DL.DS_DL
        Me.EjecucionPresupuestariaFacturaTableAdapter1 = New SGAFP.DL.DS_DLTableAdapters.EjecucionPresupuestariaFacturaTableAdapter
        CType(Me.DataTableEjecucionPresBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEjecucionPres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataTableEjecucionPresBindingSource1
        '
        Me.DataTableEjecucionPresBindingSource1.DataSource = GetType(SGAFP.DL.DS_DL.EjecucionPresupuestariaFacturaDataTable)
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataMember = Nothing
        Me.GridControl1.DataSource = Me.DataTableEjecucionPresBindingSource1
        Me.GridControl1.Location = New System.Drawing.Point(-2, 37)
        Me.GridControl1.MainView = Me.GridEjecucionPres
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(913, 121)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridEjecucionPres})
        '
        'GridEjecucionPres
        '
        Me.GridEjecucionPres.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_COMPROMISO, Me.colID_CONTRATO, Me.colNUM_COMPROMISO, Me.colMONTO_COMPROMETIDO, Me.colFECHA_INICIAL, Me.colFECHA_FINAL, Me.colMONTO_PROVISIONADO, Me.colMONTO_DEVENGADO, Me.colDISTRIBUCION, Me.colSALDO, Me.colUSERID, Me.colLASTUPDATE})
        Me.GridEjecucionPres.GridControl = Me.GridControl1
        Me.GridEjecucionPres.Name = "GridEjecucionPres"
        Me.GridEjecucionPres.OptionsView.ShowGroupPanel = False
        Me.GridEjecucionPres.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSALDO, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colID_COMPROMISO
        '
        Me.colID_COMPROMISO.FieldName = "ID_COMPROMISO"
        Me.colID_COMPROMISO.Name = "colID_COMPROMISO"
        Me.colID_COMPROMISO.OptionsColumn.AllowEdit = False
        Me.colID_COMPROMISO.Width = 96
        '
        'colID_CONTRATO
        '
        Me.colID_CONTRATO.FieldName = "ID_CONTRATO"
        Me.colID_CONTRATO.Name = "colID_CONTRATO"
        Me.colID_CONTRATO.OptionsColumn.AllowEdit = False
        Me.colID_CONTRATO.Width = 82
        '
        'colNUM_COMPROMISO
        '
        Me.colNUM_COMPROMISO.Caption = "N° de Compromiso"
        Me.colNUM_COMPROMISO.FieldName = "NUM_COMPROMISO"
        Me.colNUM_COMPROMISO.Name = "colNUM_COMPROMISO"
        Me.colNUM_COMPROMISO.OptionsColumn.AllowEdit = False
        Me.colNUM_COMPROMISO.Visible = True
        Me.colNUM_COMPROMISO.VisibleIndex = 0
        Me.colNUM_COMPROMISO.Width = 126
        '
        'colMONTO_COMPROMETIDO
        '
        Me.colMONTO_COMPROMETIDO.Caption = "Valor Compromiso"
        Me.colMONTO_COMPROMETIDO.DisplayFormat.FormatString = "#,##0.00"
        Me.colMONTO_COMPROMETIDO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colMONTO_COMPROMETIDO.FieldName = "MONTO_COMPROMETIDO"
        Me.colMONTO_COMPROMETIDO.Name = "colMONTO_COMPROMETIDO"
        Me.colMONTO_COMPROMETIDO.OptionsColumn.AllowEdit = False
        Me.colMONTO_COMPROMETIDO.Visible = True
        Me.colMONTO_COMPROMETIDO.VisibleIndex = 3
        Me.colMONTO_COMPROMETIDO.Width = 131
        '
        'colFECHA_INICIAL
        '
        Me.colFECHA_INICIAL.Caption = "Inicio"
        Me.colFECHA_INICIAL.DisplayFormat.FormatString = "dd/MM/yyy"
        Me.colFECHA_INICIAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colFECHA_INICIAL.FieldName = "FECHA_INICIAL"
        Me.colFECHA_INICIAL.Name = "colFECHA_INICIAL"
        Me.colFECHA_INICIAL.OptionsColumn.AllowEdit = False
        Me.colFECHA_INICIAL.Visible = True
        Me.colFECHA_INICIAL.VisibleIndex = 1
        Me.colFECHA_INICIAL.Width = 86
        '
        'colFECHA_FINAL
        '
        Me.colFECHA_FINAL.Caption = "Vencimiento"
        Me.colFECHA_FINAL.DisplayFormat.FormatString = "dd/MM/yyy"
        Me.colFECHA_FINAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colFECHA_FINAL.FieldName = "FECHA_FINAL"
        Me.colFECHA_FINAL.Name = "colFECHA_FINAL"
        Me.colFECHA_FINAL.OptionsColumn.AllowEdit = False
        Me.colFECHA_FINAL.Visible = True
        Me.colFECHA_FINAL.VisibleIndex = 2
        Me.colFECHA_FINAL.Width = 95
        '
        'colMONTO_PROVISIONADO
        '
        Me.colMONTO_PROVISIONADO.Caption = "Provisión"
        Me.colMONTO_PROVISIONADO.DisplayFormat.FormatString = "#,##0.00"
        Me.colMONTO_PROVISIONADO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colMONTO_PROVISIONADO.FieldName = "MONTO_PROVISIONADO"
        Me.colMONTO_PROVISIONADO.Name = "colMONTO_PROVISIONADO"
        Me.colMONTO_PROVISIONADO.OptionsColumn.AllowEdit = False
        Me.colMONTO_PROVISIONADO.Visible = True
        Me.colMONTO_PROVISIONADO.VisibleIndex = 4
        Me.colMONTO_PROVISIONADO.Width = 96
        '
        'colMONTO_DEVENGADO
        '
        Me.colMONTO_DEVENGADO.AppearanceCell.Options.UseTextOptions = True
        Me.colMONTO_DEVENGADO.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colMONTO_DEVENGADO.Caption = "Monto Ejecutado"
        Me.colMONTO_DEVENGADO.DisplayFormat.FormatString = "#,##0.00"
        Me.colMONTO_DEVENGADO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colMONTO_DEVENGADO.FieldName = "MONTO_DEVENGADO"
        Me.colMONTO_DEVENGADO.Name = "colMONTO_DEVENGADO"
        Me.colMONTO_DEVENGADO.OptionsColumn.AllowEdit = False
        Me.colMONTO_DEVENGADO.Visible = True
        Me.colMONTO_DEVENGADO.VisibleIndex = 5
        Me.colMONTO_DEVENGADO.Width = 126
        '
        'colDISTRIBUCION
        '
        Me.colDISTRIBUCION.AppearanceCell.BackColor = System.Drawing.Color.LightSkyBlue
        Me.colDISTRIBUCION.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDISTRIBUCION.AppearanceCell.Options.UseBackColor = True
        Me.colDISTRIBUCION.AppearanceCell.Options.UseFont = True
        Me.colDISTRIBUCION.Caption = "Distribución Factura"
        Me.colDISTRIBUCION.DisplayFormat.FormatString = "#,##0.00"
        Me.colDISTRIBUCION.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colDISTRIBUCION.FieldName = "DISTRIBUCION"
        Me.colDISTRIBUCION.Name = "colDISTRIBUCION"
        Me.colDISTRIBUCION.Visible = True
        Me.colDISTRIBUCION.VisibleIndex = 6
        Me.colDISTRIBUCION.Width = 144
        '
        'colSALDO
        '
        Me.colSALDO.Caption = "Pendiente"
        Me.colSALDO.DisplayFormat.FormatString = "#,##0.00"
        Me.colSALDO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colSALDO.FieldName = "SALDO"
        Me.colSALDO.Name = "colSALDO"
        Me.colSALDO.OptionsColumn.AllowEdit = False
        Me.colSALDO.Visible = True
        Me.colSALDO.VisibleIndex = 7
        Me.colSALDO.Width = 273
        '
        'colUSERID
        '
        Me.colUSERID.FieldName = "USERID"
        Me.colUSERID.Name = "colUSERID"
        Me.colUSERID.OptionsColumn.AllowEdit = False
        '
        'colLASTUPDATE
        '
        Me.colLASTUPDATE.FieldName = "LASTUPDATE"
        Me.colLASTUPDATE.Name = "colLASTUPDATE"
        Me.colLASTUPDATE.OptionsColumn.AllowEdit = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(165, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Ejecución Presupuestaria Sugerida"
        '
        'SimpleButtonCancelar
        '
        Me.SimpleButtonCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SimpleButtonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SimpleButtonCancelar.Location = New System.Drawing.Point(127, 166)
        Me.SimpleButtonCancelar.Name = "SimpleButtonCancelar"
        Me.SimpleButtonCancelar.Size = New System.Drawing.Size(86, 22)
        Me.SimpleButtonCancelar.TabIndex = 6
        Me.SimpleButtonCancelar.Text = "Cancelar"
        '
        'SimpleButtonAceptar
        '
        Me.SimpleButtonAceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SimpleButtonAceptar.Location = New System.Drawing.Point(17, 166)
        Me.SimpleButtonAceptar.Name = "SimpleButtonAceptar"
        Me.SimpleButtonAceptar.Size = New System.Drawing.Size(86, 22)
        Me.SimpleButtonAceptar.TabIndex = 5
        Me.SimpleButtonAceptar.Text = "Aceptar"
        '
        'DS_DL1
        '
        Me.DS_DL1.DataSetName = "DS_DL"
        Me.DS_DL1.EnforceConstraints = False
        Me.DS_DL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EjecucionPresupuestariaFacturaTableAdapter1
        '
        Me.EjecucionPresupuestariaFacturaTableAdapter1.ClearBeforeFill = True
        '
        'frmFacturaCursos_EjecucionPresup
        '
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.SimpleButtonCancelar
        Me.ClientSize = New System.Drawing.Size(909, 200)
        Me.Controls.Add(Me.SimpleButtonCancelar)
        Me.Controls.Add(Me.SimpleButtonAceptar)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.GridControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFacturaCursos_EjecucionPresup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ejecución Presupuestaria"
        Me.Controls.SetChildIndex(Me.GridControl1, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.SimpleButtonAceptar, 0)
        Me.Controls.SetChildIndex(Me.SimpleButtonCancelar, 0)
        CType(Me.DataTableEjecucionPresBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEjecucionPres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_DL1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataTableEjecucionPresBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridEjecucionPres As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_COMPROMISO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_CONTRATO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUM_COMPROMISO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_INICIAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_FINAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_COMPROMETIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_PROVISIONADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_DEVENGADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSERID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLASTUPDATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDISTRIBUCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSALDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButtonCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButtonAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DS_DL1 As SGAFP.DL.DS_DL
    Friend WithEvents EjecucionPresupuestariaFacturaTableAdapter1 As SGAFP.DL.DS_DLTableAdapters.EjecucionPresupuestariaFacturaTableAdapter
End Class
