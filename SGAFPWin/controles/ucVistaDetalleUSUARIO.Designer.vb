<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucVistaDetalleUSUARIO
    Inherits SGAFP.ucBaseDetalleMant

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
        Me.components = New System.ComponentModel.Container
        Me.CbxPARTICIPANTE1 = New SGAFP.WinUC.cbxPARTICIPANTE
        Me.CbxSITIO_CAPACITACION1 = New SGAFP.WinUC.cbxSITIO_CAPACITACION
        Me.CbxPROVEEDOR_AF1 = New SGAFP.WinUC.cbxPROVEEDOR_AF
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GridLookUpEdit3 = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit3View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colID_SITIO_CAPACITACION = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_SITIO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridLookUpEdit2 = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colID_PROVEEDOR_AF = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNOMBRE_PROVEEDOR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colID_PARTICIPANTE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNombresApellidos = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ListaSITIOCAPACITACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaPARTICIPANTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.GridLookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit3View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaSITIOCAPACITACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaPARTICIPANTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CbxPARTICIPANTE1
        '
        Me.CbxPARTICIPANTE1.AllowFindEntityType = Nothing
        Me.CbxPARTICIPANTE1.Location = New System.Drawing.Point(88, 101)
        Me.CbxPARTICIPANTE1.Name = "CbxPARTICIPANTE1"
        Me.CbxPARTICIPANTE1.Size = New System.Drawing.Size(121, 21)
        Me.CbxPARTICIPANTE1.TabIndex = 0
        Me.CbxPARTICIPANTE1.Text = "CbxPARTICIPANTE1"
        '
        'CbxSITIO_CAPACITACION1
        '
        Me.CbxSITIO_CAPACITACION1.AllowFindEntityType = Nothing
        Me.CbxSITIO_CAPACITACION1.Location = New System.Drawing.Point(88, 74)
        Me.CbxSITIO_CAPACITACION1.Name = "CbxSITIO_CAPACITACION1"
        Me.CbxSITIO_CAPACITACION1.Size = New System.Drawing.Size(121, 21)
        Me.CbxSITIO_CAPACITACION1.TabIndex = 1
        Me.CbxSITIO_CAPACITACION1.Text = "CbxSITIO_CAPACITACION1"
        '
        'CbxPROVEEDOR_AF1
        '
        Me.CbxPROVEEDOR_AF1.AllowFindEntityType = Nothing
        Me.CbxPROVEEDOR_AF1.Location = New System.Drawing.Point(88, 47)
        Me.CbxPROVEEDOR_AF1.Name = "CbxPROVEEDOR_AF1"
        Me.CbxPROVEEDOR_AF1.Size = New System.Drawing.Size(121, 21)
        Me.CbxPROVEEDOR_AF1.TabIndex = 2
        Me.CbxPROVEEDOR_AF1.Text = "CbxPROVEEDOR_AF1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(88, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 21)
        Me.TextBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Label4"
        '
        'GridLookUpEdit3
        '
        Me.GridLookUpEdit3.Location = New System.Drawing.Point(88, 206)
        Me.GridLookUpEdit3.Name = "GridLookUpEdit3"
        Me.GridLookUpEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit3.Properties.DisplayMember = "NOMBRE_SITIO"
        Me.GridLookUpEdit3.Properties.ValueMember = "ID_SITIO_CAPACITACION"
        Me.GridLookUpEdit3.Properties.View = Me.GridLookUpEdit3View
        Me.GridLookUpEdit3.Size = New System.Drawing.Size(282, 20)
        Me.GridLookUpEdit3.TabIndex = 18
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
        'GridLookUpEdit2
        '
        Me.GridLookUpEdit2.Location = New System.Drawing.Point(88, 165)
        Me.GridLookUpEdit2.Name = "GridLookUpEdit2"
        Me.GridLookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit2.Properties.DisplayMember = "NOMBRE_PROVEEDOR"
        Me.GridLookUpEdit2.Properties.ValueMember = "ID_PROVEEDOR_AF"
        Me.GridLookUpEdit2.Properties.View = Me.GridLookUpEdit2View
        Me.GridLookUpEdit2.Size = New System.Drawing.Size(282, 20)
        Me.GridLookUpEdit2.TabIndex = 17
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
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(88, 128)
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.DisplayMember = "NombresApellidos"
        Me.GridLookUpEdit1.Properties.ValueMember = "ID_PARTICIPANTE"
        Me.GridLookUpEdit1.Properties.View = Me.GridLookUpEdit1View
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(282, 20)
        Me.GridLookUpEdit1.TabIndex = 16
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
        'ListaSITIOCAPACITACIONBindingSource
        '
        Me.ListaSITIOCAPACITACIONBindingSource.DataSource = GetType(SGAFP.EL.listaSITIO_CAPACITACION)
        '
        'ListaPARTICIPANTEBindingSource
        '
        Me.ListaPARTICIPANTEBindingSource.DataSource = GetType(SGAFP.EL.listaPARTICIPANTE)
        '
        'ucVistaDetalleUSUARIO
        '
        Me.Controls.Add(Me.GridLookUpEdit3)
        Me.Controls.Add(Me.GridLookUpEdit2)
        Me.Controls.Add(Me.GridLookUpEdit1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CbxPROVEEDOR_AF1)
        Me.Controls.Add(Me.CbxSITIO_CAPACITACION1)
        Me.Controls.Add(Me.CbxPARTICIPANTE1)
        Me.Name = "ucVistaDetalleUSUARIO"
        Me.Size = New System.Drawing.Size(524, 237)
        CType(Me.GridLookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit3View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaSITIOCAPACITACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaPARTICIPANTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbxPARTICIPANTE1 As SGAFP.WinUC.cbxPARTICIPANTE
    Friend WithEvents CbxSITIO_CAPACITACION1 As SGAFP.WinUC.cbxSITIO_CAPACITACION
    Friend WithEvents CbxPROVEEDOR_AF1 As SGAFP.WinUC.cbxPROVEEDOR_AF
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GridLookUpEdit3 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_SITIO_CAPACITACION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_SITIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridLookUpEdit2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_PROVEEDOR_AF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_PROVEEDOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_PARTICIPANTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombresApellidos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ListaSITIOCAPACITACIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaPARTICIPANTEBindingSource As System.Windows.Forms.BindingSource

End Class
