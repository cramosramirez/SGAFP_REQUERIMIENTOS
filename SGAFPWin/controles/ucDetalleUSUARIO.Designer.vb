<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDetalleUSUARIO
    Inherits SGAFP.ucBaseDetalleMant

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
        Me.USUARIOLabel = New System.Windows.Forms.Label
        Me.ID_PROVEEDOR_AFLabel = New System.Windows.Forms.Label
        Me.ID_SITIO_CAPACITACIONLabel = New System.Windows.Forms.Label
        Me.ID_PARTICIPANTELabel = New System.Windows.Forms.Label
        Me.ListaUSUARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USUARIOTextBox = New System.Windows.Forms.TextBox
        Me.ListaPROVEEDORAFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gleSitioCapacitacion = New DevExpress.XtraEditors.GridLookUpEdit
        Me.ListaSITIOCAPACITACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridLookUpEdit3View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colID_SITIO_CAPACITACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_SITIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gleProveedor = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colID_PROVEEDOR_AF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_PROVEEDOR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gleParticipante = New DevExpress.XtraEditors.GridLookUpEdit
        Me.ListaPARTICIPANTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colID_PARTICIPANTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNombresApellidos = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.ListaUSUARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaPROVEEDORAFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleSitioCapacitacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaSITIOCAPACITACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit3View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gleParticipante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaPARTICIPANTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'USUARIOLabel
        '
        Me.USUARIOLabel.Location = New System.Drawing.Point(6, 14)
        Me.USUARIOLabel.Name = "USUARIOLabel"
        Me.USUARIOLabel.Size = New System.Drawing.Size(135, 13)
        Me.USUARIOLabel.TabIndex = 0
        Me.USUARIOLabel.Text = "Usuario:"
        '
        'ID_PROVEEDOR_AFLabel
        '
        Me.ID_PROVEEDOR_AFLabel.Location = New System.Drawing.Point(6, 40)
        Me.ID_PROVEEDOR_AFLabel.Name = "ID_PROVEEDOR_AFLabel"
        Me.ID_PROVEEDOR_AFLabel.Size = New System.Drawing.Size(135, 13)
        Me.ID_PROVEEDOR_AFLabel.TabIndex = 2
        Me.ID_PROVEEDOR_AFLabel.Text = "Id proveedor af:"
        '
        'ID_SITIO_CAPACITACIONLabel
        '
        Me.ID_SITIO_CAPACITACIONLabel.Location = New System.Drawing.Point(6, 66)
        Me.ID_SITIO_CAPACITACIONLabel.Name = "ID_SITIO_CAPACITACIONLabel"
        Me.ID_SITIO_CAPACITACIONLabel.Size = New System.Drawing.Size(135, 13)
        Me.ID_SITIO_CAPACITACIONLabel.TabIndex = 4
        Me.ID_SITIO_CAPACITACIONLabel.Text = "Id sitio capacitacion:"
        '
        'ID_PARTICIPANTELabel
        '
        Me.ID_PARTICIPANTELabel.Location = New System.Drawing.Point(6, 92)
        Me.ID_PARTICIPANTELabel.Name = "ID_PARTICIPANTELabel"
        Me.ID_PARTICIPANTELabel.Size = New System.Drawing.Size(135, 13)
        Me.ID_PARTICIPANTELabel.TabIndex = 6
        Me.ID_PARTICIPANTELabel.Text = "Id participante:"
        '
        'ListaUSUARIOBindingSource
        '
        Me.ListaUSUARIOBindingSource.DataSource = GetType(SGAFP.EL.USUARIO)
        '
        'USUARIOTextBox
        '
        Me.USUARIOTextBox.BackColor = System.Drawing.Color.Linen
        Me.USUARIOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaUSUARIOBindingSource, "USUARIO", True))
        Me.USUARIOTextBox.Location = New System.Drawing.Point(144, 8)
        Me.USUARIOTextBox.MaxLength = 100
        Me.USUARIOTextBox.Name = "USUARIOTextBox"
        Me.USUARIOTextBox.ReadOnly = True
        Me.USUARIOTextBox.Size = New System.Drawing.Size(200, 21)
        Me.USUARIOTextBox.TabIndex = 1
        '
        'ListaPROVEEDORAFBindingSource
        '
        Me.ListaPROVEEDORAFBindingSource.DataSource = GetType(SGAFP.EL.listaPROVEEDOR_AF)
        '
        'gleSitioCapacitacion
        '
        Me.gleSitioCapacitacion.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaUSUARIOBindingSource, "ID_SITIO_CAPACITACION", True))
        Me.gleSitioCapacitacion.Location = New System.Drawing.Point(144, 63)
        Me.gleSitioCapacitacion.Name = "gleSitioCapacitacion"
        Me.gleSitioCapacitacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleSitioCapacitacion.Properties.DataSource = Me.ListaSITIOCAPACITACIONBindingSource
        Me.gleSitioCapacitacion.Properties.DisplayMember = "NOMBRE_SITIO"
        Me.gleSitioCapacitacion.Properties.ValueMember = "ID_SITIO_CAPACITACION"
        Me.gleSitioCapacitacion.Properties.View = Me.GridLookUpEdit3View
        Me.gleSitioCapacitacion.Size = New System.Drawing.Size(282, 20)
        Me.gleSitioCapacitacion.TabIndex = 21
        '
        'ListaSITIOCAPACITACIONBindingSource
        '
        Me.ListaSITIOCAPACITACIONBindingSource.DataSource = GetType(SGAFP.EL.listaSITIO_CAPACITACION)
        '
        'GridLookUpEdit3View
        '
        Me.GridLookUpEdit3View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_SITIO_CAPACITACION, Me.colNOMBRE_SITIO})
        Me.GridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit3View.Name = "GridLookUpEdit3View"
        Me.GridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit3View.OptionsView.ShowGroupPanel = False
        '
        'colID_SITIO_CAPACITACION
        '
        Me.colID_SITIO_CAPACITACION.FieldName = "ID_SITIO_CAPACITACION"
        Me.colID_SITIO_CAPACITACION.Name = "colID_SITIO_CAPACITACION"
        Me.colID_SITIO_CAPACITACION.Visible = True
        Me.colID_SITIO_CAPACITACION.VisibleIndex = 0
        '
        'colNOMBRE_SITIO
        '
        Me.colNOMBRE_SITIO.FieldName = "NOMBRE_SITIO"
        Me.colNOMBRE_SITIO.Name = "colNOMBRE_SITIO"
        Me.colNOMBRE_SITIO.Visible = True
        Me.colNOMBRE_SITIO.VisibleIndex = 1
        '
        'gleProveedor
        '
        Me.gleProveedor.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaUSUARIOBindingSource, "ID_PROVEEDOR_AF", True))
        Me.gleProveedor.Location = New System.Drawing.Point(144, 37)
        Me.gleProveedor.Name = "gleProveedor"
        Me.gleProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleProveedor.Properties.DataSource = Me.ListaPROVEEDORAFBindingSource
        Me.gleProveedor.Properties.DisplayMember = "NOMBRE_PROVEEDOR"
        Me.gleProveedor.Properties.ValueMember = "ID_PROVEEDOR_AF"
        Me.gleProveedor.Properties.View = Me.GridLookUpEdit2View
        Me.gleProveedor.Size = New System.Drawing.Size(282, 20)
        Me.gleProveedor.TabIndex = 20
        '
        'GridLookUpEdit2View
        '
        Me.GridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_PROVEEDOR_AF, Me.colNOMBRE_PROVEEDOR})
        Me.GridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit2View.Name = "GridLookUpEdit2View"
        Me.GridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colID_PROVEEDOR_AF
        '
        Me.colID_PROVEEDOR_AF.FieldName = "ID_PROVEEDOR_AF"
        Me.colID_PROVEEDOR_AF.Name = "colID_PROVEEDOR_AF"
        Me.colID_PROVEEDOR_AF.Visible = True
        Me.colID_PROVEEDOR_AF.VisibleIndex = 0
        '
        'colNOMBRE_PROVEEDOR
        '
        Me.colNOMBRE_PROVEEDOR.FieldName = "NOMBRE_PROVEEDOR"
        Me.colNOMBRE_PROVEEDOR.Name = "colNOMBRE_PROVEEDOR"
        Me.colNOMBRE_PROVEEDOR.Visible = True
        Me.colNOMBRE_PROVEEDOR.VisibleIndex = 1
        '
        'gleParticipante
        '
        Me.gleParticipante.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ListaUSUARIOBindingSource, "ID_PARTICIPANTE", True))
        Me.gleParticipante.Location = New System.Drawing.Point(144, 89)
        Me.gleParticipante.Name = "gleParticipante"
        Me.gleParticipante.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gleParticipante.Properties.DataSource = Me.ListaPARTICIPANTEBindingSource
        Me.gleParticipante.Properties.DisplayMember = "NombresApellidos"
        Me.gleParticipante.Properties.ValueMember = "ID_PARTICIPANTE"
        Me.gleParticipante.Properties.View = Me.GridLookUpEdit1View
        Me.gleParticipante.Size = New System.Drawing.Size(282, 20)
        Me.gleParticipante.TabIndex = 19
        '
        'ListaPARTICIPANTEBindingSource
        '
        Me.ListaPARTICIPANTEBindingSource.DataSource = GetType(SGAFP.EL.listaPARTICIPANTE)
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_PARTICIPANTE, Me.colNombresApellidos})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colID_PARTICIPANTE
        '
        Me.colID_PARTICIPANTE.FieldName = "ID_PARTICIPANTE"
        Me.colID_PARTICIPANTE.Name = "colID_PARTICIPANTE"
        Me.colID_PARTICIPANTE.Visible = True
        Me.colID_PARTICIPANTE.VisibleIndex = 1
        '
        'colNombresApellidos
        '
        Me.colNombresApellidos.FieldName = "NombresApellidos"
        Me.colNombresApellidos.Name = "colNombresApellidos"
        Me.colNombresApellidos.OptionsColumn.ReadOnly = True
        Me.colNombresApellidos.Visible = True
        Me.colNombresApellidos.VisibleIndex = 0
        '
        'ucDetalleUSUARIO
        '
        Me.AutoScroll = True
        Me.Controls.Add(Me.gleSitioCapacitacion)
        Me.Controls.Add(Me.gleProveedor)
        Me.Controls.Add(Me.gleParticipante)
        Me.Controls.Add(Me.USUARIOLabel)
        Me.Controls.Add(Me.USUARIOTextBox)
        Me.Controls.Add(Me.ID_PROVEEDOR_AFLabel)
        Me.Controls.Add(Me.ID_SITIO_CAPACITACIONLabel)
        Me.Controls.Add(Me.ID_PARTICIPANTELabel)
        Me.Name = "ucDetalleUSUARIO"
        Me.Size = New System.Drawing.Size(524, 277)
        CType(Me.ListaUSUARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaPROVEEDORAFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleSitioCapacitacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaSITIOCAPACITACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit3View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gleParticipante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaPARTICIPANTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaUSUARIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents USUARIOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents USUARIOLabel As System.Windows.Forms.Label
    Friend WithEvents ID_PROVEEDOR_AFLabel As System.Windows.Forms.Label
    Friend WithEvents ID_SITIO_CAPACITACIONLabel As System.Windows.Forms.Label
    Friend WithEvents ID_PARTICIPANTELabel As System.Windows.Forms.Label
    Friend WithEvents ListaPROVEEDORAFBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents gleSitioCapacitacion As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_SITIO_CAPACITACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_SITIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gleProveedor As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_PROVEEDOR_AF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_PROVEEDOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gleParticipante As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_PARTICIPANTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombresApellidos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ListaPARTICIPANTEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaSITIOCAPACITACIONBindingSource As System.Windows.Forms.BindingSource

End Class
