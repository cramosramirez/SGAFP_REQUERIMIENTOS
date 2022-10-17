<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaUSUARIO
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
        Me.ListaUSUARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaUSUARIODataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxUSUARIO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_PROVEEDOR_AF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_SITIO_CAPACITACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_PARTICIPANTE = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaUSUARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaUSUARIODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaUSUARIOBindingSource
        '
        Me.ListaUSUARIOBindingSource.DataSource = GetType(SGAFP.EL.USUARIO)
        '
        'ListaUSUARIODataGridView
        '
        Me.ListaUSUARIODataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaUSUARIODataGridView.AutoGenerateColumns = False
        Me.ListaUSUARIODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxUSUARIO, Me.DataGridViewTextBoxID_PROVEEDOR_AF, Me.DataGridViewTextBoxID_SITIO_CAPACITACION, Me.DataGridViewTextBoxID_PARTICIPANTE})
        Me.ListaUSUARIODataGridView.DataSource = Me.ListaUSUARIOBindingSource
        Me.ListaUSUARIODataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaUSUARIODataGridView.Name = "ListaUSUARIODataGridView"
        Me.ListaUSUARIODataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaUSUARIODataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxUSUARIO
        '
        Me.DataGridViewTextBoxUSUARIO.DataPropertyName = "USUARIO"
        Me.DataGridViewTextBoxUSUARIO.HeaderText = "Usuario"
        Me.DataGridViewTextBoxUSUARIO.Name = "DataGridViewTextBoxUSUARIO"
        '
        'DataGridViewTextBoxID_PROVEEDOR_AF
        '
        Me.DataGridViewTextBoxID_PROVEEDOR_AF.DataPropertyName = "ID_PROVEEDOR_AF"
        Me.DataGridViewTextBoxID_PROVEEDOR_AF.HeaderText = "Id proveedor af"
        Me.DataGridViewTextBoxID_PROVEEDOR_AF.Name = "DataGridViewTextBoxID_PROVEEDOR_AF"
        '
        'DataGridViewTextBoxID_SITIO_CAPACITACION
        '
        Me.DataGridViewTextBoxID_SITIO_CAPACITACION.DataPropertyName = "ID_SITIO_CAPACITACION"
        Me.DataGridViewTextBoxID_SITIO_CAPACITACION.HeaderText = "Id sitio capacitacion"
        Me.DataGridViewTextBoxID_SITIO_CAPACITACION.Name = "DataGridViewTextBoxID_SITIO_CAPACITACION"
        '
        'DataGridViewTextBoxID_PARTICIPANTE
        '
        Me.DataGridViewTextBoxID_PARTICIPANTE.DataPropertyName = "ID_PARTICIPANTE"
        Me.DataGridViewTextBoxID_PARTICIPANTE.HeaderText = "Id participante"
        Me.DataGridViewTextBoxID_PARTICIPANTE.Name = "DataGridViewTextBoxID_PARTICIPANTE"
        '
        'ucListaUSUARIO
        '
        Me.Controls.Add(Me.ListaUSUARIODataGridView)
        Me.Name = "ucListaUSUARIO"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaUSUARIODataGridView, 0)
        CType(Me.ListaUSUARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaUSUARIODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaUSUARIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaUSUARIODataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxUSUARIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_PROVEEDOR_AF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_SITIO_CAPACITACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_PARTICIPANTE As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
