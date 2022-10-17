<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaASISTENCIA_AF
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
        Me.ListaASISTENCIA_AFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaASISTENCIA_AFDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxID_ASISTENCIA_AF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_ACCION_FORMATIVA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxFECHA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxINSTRUCTOR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOTAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaASISTENCIA_AFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaASISTENCIA_AFDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaASISTENCIA_AFBindingSource
        '
        Me.ListaASISTENCIA_AFBindingSource.DataSource = GetType(SGAFP.EL.ASISTENCIA_AF)
        '
        'ListaASISTENCIA_AFDataGridView
        '
        Me.ListaASISTENCIA_AFDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaASISTENCIA_AFDataGridView.AutoGenerateColumns = False
        Me.ListaASISTENCIA_AFDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxID_ASISTENCIA_AF, Me.DataGridViewTextBoxID_ACCION_FORMATIVA, Me.DataGridViewTextBoxFECHA, Me.DataGridViewTextBoxINSTRUCTOR, Me.DataGridViewTextBoxNOTAS})
        Me.ListaASISTENCIA_AFDataGridView.DataSource = Me.ListaASISTENCIA_AFBindingSource
        Me.ListaASISTENCIA_AFDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaASISTENCIA_AFDataGridView.Name = "ListaASISTENCIA_AFDataGridView"
        Me.ListaASISTENCIA_AFDataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaASISTENCIA_AFDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxID_ASISTENCIA_AF
        '
        Me.DataGridViewTextBoxID_ASISTENCIA_AF.DataPropertyName = "ID_ASISTENCIA_AF"
        Me.DataGridViewTextBoxID_ASISTENCIA_AF.HeaderText = "Id asistencia af"
        Me.DataGridViewTextBoxID_ASISTENCIA_AF.Name = "DataGridViewTextBoxID_ASISTENCIA_AF"
        '
        'DataGridViewTextBoxID_ACCION_FORMATIVA
        '
        Me.DataGridViewTextBoxID_ACCION_FORMATIVA.DataPropertyName = "ID_ACCION_FORMATIVA"
        Me.DataGridViewTextBoxID_ACCION_FORMATIVA.HeaderText = "Id accion formativa"
        Me.DataGridViewTextBoxID_ACCION_FORMATIVA.Name = "DataGridViewTextBoxID_ACCION_FORMATIVA"
        '
        'DataGridViewTextBoxFECHA
        '
        Me.DataGridViewTextBoxFECHA.DataPropertyName = "FECHA"
        Me.DataGridViewTextBoxFECHA.HeaderText = "Fecha"
        Me.DataGridViewTextBoxFECHA.Name = "DataGridViewTextBoxFECHA"
        '
        'DataGridViewTextBoxINSTRUCTOR
        '
        Me.DataGridViewTextBoxINSTRUCTOR.DataPropertyName = "INSTRUCTOR"
        Me.DataGridViewTextBoxINSTRUCTOR.HeaderText = "Instructor"
        Me.DataGridViewTextBoxINSTRUCTOR.Name = "DataGridViewTextBoxINSTRUCTOR"
        '
        'DataGridViewTextBoxNOTAS
        '
        Me.DataGridViewTextBoxNOTAS.DataPropertyName = "NOTAS"
        Me.DataGridViewTextBoxNOTAS.HeaderText = "Notas"
        Me.DataGridViewTextBoxNOTAS.Name = "DataGridViewTextBoxNOTAS"
        '
        'ucListaASISTENCIA_AF
        '
        Me.Controls.Add(Me.ListaASISTENCIA_AFDataGridView)
        Me.Name = "ucListaASISTENCIA_AF"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaASISTENCIA_AFDataGridView, 0)
        CType(Me.ListaASISTENCIA_AFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaASISTENCIA_AFDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaASISTENCIA_AFBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaASISTENCIA_AFDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxID_ASISTENCIA_AF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_ACCION_FORMATIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxFECHA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxINSTRUCTOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOTAS As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
