<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaTIPO_PERSONA
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
        Me.ListaTIPO_PERSONABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaTIPO_PERSONADataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxID_TIPO_PERSONA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxTIPO_PERSONA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOTAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaTIPO_PERSONABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaTIPO_PERSONADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaTIPO_PERSONABindingSource
        '
        Me.ListaTIPO_PERSONABindingSource.DataSource = GetType(SGAFP.EL.TIPO_PERSONA)
        '
        'ListaTIPO_PERSONADataGridView
        '
        Me.ListaTIPO_PERSONADataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaTIPO_PERSONADataGridView.AutoGenerateColumns = False
        Me.ListaTIPO_PERSONADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxID_TIPO_PERSONA, Me.DataGridViewTextBoxTIPO_PERSONA, Me.DataGridViewTextBoxNOTAS})
        Me.ListaTIPO_PERSONADataGridView.DataSource = Me.ListaTIPO_PERSONABindingSource
        Me.ListaTIPO_PERSONADataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaTIPO_PERSONADataGridView.Name = "ListaTIPO_PERSONADataGridView"
        Me.ListaTIPO_PERSONADataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaTIPO_PERSONADataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxID_TIPO_PERSONA
        '
        Me.DataGridViewTextBoxID_TIPO_PERSONA.DataPropertyName = "ID_TIPO_PERSONA"
        Me.DataGridViewTextBoxID_TIPO_PERSONA.HeaderText = "Id tipo persona"
        Me.DataGridViewTextBoxID_TIPO_PERSONA.Name = "DataGridViewTextBoxID_TIPO_PERSONA"
        '
        'DataGridViewTextBoxTIPO_PERSONA
        '
        Me.DataGridViewTextBoxTIPO_PERSONA.DataPropertyName = "TIPO_PERSONA"
        Me.DataGridViewTextBoxTIPO_PERSONA.HeaderText = "Tipo persona"
        Me.DataGridViewTextBoxTIPO_PERSONA.Name = "DataGridViewTextBoxTIPO_PERSONA"
        '
        'DataGridViewTextBoxNOTAS
        '
        Me.DataGridViewTextBoxNOTAS.DataPropertyName = "NOTAS"
        Me.DataGridViewTextBoxNOTAS.HeaderText = "Notas"
        Me.DataGridViewTextBoxNOTAS.Name = "DataGridViewTextBoxNOTAS"
        '
        'ucListaTIPO_PERSONA
        '
        Me.Controls.Add(Me.ListaTIPO_PERSONADataGridView)
        Me.Name = "ucListaTIPO_PERSONA"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaTIPO_PERSONADataGridView, 0)
        CType(Me.ListaTIPO_PERSONABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaTIPO_PERSONADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaTIPO_PERSONABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaTIPO_PERSONADataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxID_TIPO_PERSONA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxTIPO_PERSONA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOTAS As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
