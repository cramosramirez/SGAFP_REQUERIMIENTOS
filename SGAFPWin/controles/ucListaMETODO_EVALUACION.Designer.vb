<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaMETODO_EVALUACION
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
        Me.ListaMETODO_EVALUACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaMETODO_EVALUACIONDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxID_METODO_EVALUACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxMETODO_EVALUACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOTAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaMETODO_EVALUACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaMETODO_EVALUACIONDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaMETODO_EVALUACIONBindingSource
        '
        Me.ListaMETODO_EVALUACIONBindingSource.DataSource = GetType(SGAFP.EL.METODO_EVALUACION)
        '
        'ListaMETODO_EVALUACIONDataGridView
        '
        Me.ListaMETODO_EVALUACIONDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaMETODO_EVALUACIONDataGridView.AutoGenerateColumns = False
        Me.ListaMETODO_EVALUACIONDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxID_METODO_EVALUACION, Me.DataGridViewTextBoxMETODO_EVALUACION, Me.DataGridViewTextBoxNOTAS})
        Me.ListaMETODO_EVALUACIONDataGridView.DataSource = Me.ListaMETODO_EVALUACIONBindingSource
        Me.ListaMETODO_EVALUACIONDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaMETODO_EVALUACIONDataGridView.Name = "ListaMETODO_EVALUACIONDataGridView"
        Me.ListaMETODO_EVALUACIONDataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaMETODO_EVALUACIONDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxID_METODO_EVALUACION
        '
        Me.DataGridViewTextBoxID_METODO_EVALUACION.DataPropertyName = "ID_METODO_EVALUACION"
        Me.DataGridViewTextBoxID_METODO_EVALUACION.HeaderText = "Id metodo evaluacion"
        Me.DataGridViewTextBoxID_METODO_EVALUACION.Name = "DataGridViewTextBoxID_METODO_EVALUACION"
        '
        'DataGridViewTextBoxMETODO_EVALUACION
        '
        Me.DataGridViewTextBoxMETODO_EVALUACION.DataPropertyName = "METODO_EVALUACION"
        Me.DataGridViewTextBoxMETODO_EVALUACION.HeaderText = "Metodo evaluacion"
        Me.DataGridViewTextBoxMETODO_EVALUACION.Name = "DataGridViewTextBoxMETODO_EVALUACION"
        '
        'DataGridViewTextBoxNOTAS
        '
        Me.DataGridViewTextBoxNOTAS.DataPropertyName = "NOTAS"
        Me.DataGridViewTextBoxNOTAS.HeaderText = "Notas"
        Me.DataGridViewTextBoxNOTAS.Name = "DataGridViewTextBoxNOTAS"
        '
        'ucListaMETODO_EVALUACION
        '
        Me.Controls.Add(Me.ListaMETODO_EVALUACIONDataGridView)
        Me.Name = "ucListaMETODO_EVALUACION"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaMETODO_EVALUACIONDataGridView, 0)
        CType(Me.ListaMETODO_EVALUACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaMETODO_EVALUACIONDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaMETODO_EVALUACIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaMETODO_EVALUACIONDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxID_METODO_EVALUACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxMETODO_EVALUACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOTAS As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
