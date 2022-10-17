<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaSUPERVISION_AF_DET
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
        Me.ListaSUPERVISION_AF_DETBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaSUPERVISION_AF_DETDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxID_SUPERVISION_DET = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_LISTA_SUPERVISION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_SUPERVISION_AF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCOMENTARIOS = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaSUPERVISION_AF_DETBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaSUPERVISION_AF_DETDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaSUPERVISION_AF_DETBindingSource
        '
        Me.ListaSUPERVISION_AF_DETBindingSource.DataSource = GetType(SGAFP.EL.SUPERVISION_AF_DET)
        '
        'ListaSUPERVISION_AF_DETDataGridView
        '
        Me.ListaSUPERVISION_AF_DETDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaSUPERVISION_AF_DETDataGridView.AutoGenerateColumns = False
        Me.ListaSUPERVISION_AF_DETDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxID_SUPERVISION_DET, Me.DataGridViewTextBoxID_LISTA_SUPERVISION, Me.DataGridViewTextBoxID_SUPERVISION_AF, Me.DataGridViewTextBoxCOMENTARIOS})
        Me.ListaSUPERVISION_AF_DETDataGridView.DataSource = Me.ListaSUPERVISION_AF_DETBindingSource
        Me.ListaSUPERVISION_AF_DETDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaSUPERVISION_AF_DETDataGridView.Name = "ListaSUPERVISION_AF_DETDataGridView"
        Me.ListaSUPERVISION_AF_DETDataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaSUPERVISION_AF_DETDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxID_SUPERVISION_DET
        '
        Me.DataGridViewTextBoxID_SUPERVISION_DET.DataPropertyName = "ID_SUPERVISION_DET"
        Me.DataGridViewTextBoxID_SUPERVISION_DET.HeaderText = "Id supervision det"
        Me.DataGridViewTextBoxID_SUPERVISION_DET.Name = "DataGridViewTextBoxID_SUPERVISION_DET"
        '
        'DataGridViewTextBoxID_LISTA_SUPERVISION
        '
        Me.DataGridViewTextBoxID_LISTA_SUPERVISION.DataPropertyName = "ID_LISTA_SUPERVISION"
        Me.DataGridViewTextBoxID_LISTA_SUPERVISION.HeaderText = "Id lista supervision"
        Me.DataGridViewTextBoxID_LISTA_SUPERVISION.Name = "DataGridViewTextBoxID_LISTA_SUPERVISION"
        '
        'DataGridViewTextBoxID_SUPERVISION_AF
        '
        Me.DataGridViewTextBoxID_SUPERVISION_AF.DataPropertyName = "ID_SUPERVISION_AF"
        Me.DataGridViewTextBoxID_SUPERVISION_AF.HeaderText = "Id supervision af"
        Me.DataGridViewTextBoxID_SUPERVISION_AF.Name = "DataGridViewTextBoxID_SUPERVISION_AF"
        '
        'DataGridViewTextBoxCOMENTARIOS
        '
        Me.DataGridViewTextBoxCOMENTARIOS.DataPropertyName = "COMENTARIOS"
        Me.DataGridViewTextBoxCOMENTARIOS.HeaderText = "Comentarios"
        Me.DataGridViewTextBoxCOMENTARIOS.Name = "DataGridViewTextBoxCOMENTARIOS"
        '
        'ucListaSUPERVISION_AF_DET
        '
        Me.Controls.Add(Me.ListaSUPERVISION_AF_DETDataGridView)
        Me.Name = "ucListaSUPERVISION_AF_DET"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaSUPERVISION_AF_DETDataGridView, 0)
        CType(Me.ListaSUPERVISION_AF_DETBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaSUPERVISION_AF_DETDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaSUPERVISION_AF_DETBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaSUPERVISION_AF_DETDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxID_SUPERVISION_DET As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_LISTA_SUPERVISION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_SUPERVISION_AF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCOMENTARIOS As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
