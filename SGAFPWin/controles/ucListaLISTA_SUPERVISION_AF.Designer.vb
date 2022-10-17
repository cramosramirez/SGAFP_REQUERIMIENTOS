<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaLISTA_SUPERVISION_AF
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
        Me.ListaLISTA_SUPERVISION_AFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaLISTA_SUPERVISION_AFDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxID_LISTA_SUPERVISION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxLISTA_SUPERVISION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOTAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaLISTA_SUPERVISION_AFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaLISTA_SUPERVISION_AFDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaLISTA_SUPERVISION_AFBindingSource
        '
        Me.ListaLISTA_SUPERVISION_AFBindingSource.DataSource = GetType(SGAFP.EL.LISTA_SUPERVISION_AF)
        '
        'ListaLISTA_SUPERVISION_AFDataGridView
        '
        Me.ListaLISTA_SUPERVISION_AFDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaLISTA_SUPERVISION_AFDataGridView.AutoGenerateColumns = False
        Me.ListaLISTA_SUPERVISION_AFDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxID_LISTA_SUPERVISION, Me.DataGridViewTextBoxLISTA_SUPERVISION, Me.DataGridViewTextBoxNOTAS})
        Me.ListaLISTA_SUPERVISION_AFDataGridView.DataSource = Me.ListaLISTA_SUPERVISION_AFBindingSource
        Me.ListaLISTA_SUPERVISION_AFDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaLISTA_SUPERVISION_AFDataGridView.Name = "ListaLISTA_SUPERVISION_AFDataGridView"
        Me.ListaLISTA_SUPERVISION_AFDataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaLISTA_SUPERVISION_AFDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxID_LISTA_SUPERVISION
        '
        Me.DataGridViewTextBoxID_LISTA_SUPERVISION.DataPropertyName = "ID_LISTA_SUPERVISION"
        Me.DataGridViewTextBoxID_LISTA_SUPERVISION.HeaderText = "Id lista supervision"
        Me.DataGridViewTextBoxID_LISTA_SUPERVISION.Name = "DataGridViewTextBoxID_LISTA_SUPERVISION"
        '
        'DataGridViewTextBoxLISTA_SUPERVISION
        '
        Me.DataGridViewTextBoxLISTA_SUPERVISION.DataPropertyName = "LISTA_SUPERVISION"
        Me.DataGridViewTextBoxLISTA_SUPERVISION.HeaderText = "Lista supervision"
        Me.DataGridViewTextBoxLISTA_SUPERVISION.Name = "DataGridViewTextBoxLISTA_SUPERVISION"
        '
        'DataGridViewTextBoxNOTAS
        '
        Me.DataGridViewTextBoxNOTAS.DataPropertyName = "NOTAS"
        Me.DataGridViewTextBoxNOTAS.HeaderText = "Notas"
        Me.DataGridViewTextBoxNOTAS.Name = "DataGridViewTextBoxNOTAS"
        '
        'ucListaLISTA_SUPERVISION_AF
        '
        Me.Controls.Add(Me.ListaLISTA_SUPERVISION_AFDataGridView)
        Me.Name = "ucListaLISTA_SUPERVISION_AF"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaLISTA_SUPERVISION_AFDataGridView, 0)
        CType(Me.ListaLISTA_SUPERVISION_AFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaLISTA_SUPERVISION_AFDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaLISTA_SUPERVISION_AFBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaLISTA_SUPERVISION_AFDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxID_LISTA_SUPERVISION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxLISTA_SUPERVISION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOTAS As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
