<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaNIVEL_ACADEMICO
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
        Me.ListaNIVEL_ACADEMICOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaNIVEL_ACADEMICODataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxNIVEL_ACADEMICO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxDESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxUSERID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxLASTUPDATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaNIVEL_ACADEMICOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaNIVEL_ACADEMICODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaNIVEL_ACADEMICOBindingSource
        '
        Me.ListaNIVEL_ACADEMICOBindingSource.DataSource = GetType(SGAFP.EL.NIVEL_ACADEMICO)
        '
        'ListaNIVEL_ACADEMICODataGridView
        '
        Me.ListaNIVEL_ACADEMICODataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaNIVEL_ACADEMICODataGridView.AutoGenerateColumns = False
        Me.ListaNIVEL_ACADEMICODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxNIVEL_ACADEMICO, Me.DataGridViewTextBoxDESCRIPCION, Me.DataGridViewTextBoxUSERID, Me.DataGridViewTextBoxLASTUPDATE})
        Me.ListaNIVEL_ACADEMICODataGridView.DataSource = Me.ListaNIVEL_ACADEMICOBindingSource
        Me.ListaNIVEL_ACADEMICODataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaNIVEL_ACADEMICODataGridView.Name = "ListaNIVEL_ACADEMICODataGridView"
        Me.ListaNIVEL_ACADEMICODataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaNIVEL_ACADEMICODataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxNIVEL_ACADEMICO
        '
        Me.DataGridViewTextBoxNIVEL_ACADEMICO.DataPropertyName = "NIVEL_ACADEMICO"
        Me.DataGridViewTextBoxNIVEL_ACADEMICO.HeaderText = "Nivel academico"
        Me.DataGridViewTextBoxNIVEL_ACADEMICO.Name = "DataGridViewTextBoxNIVEL_ACADEMICO"
        '
        'DataGridViewTextBoxDESCRIPCION
        '
        Me.DataGridViewTextBoxDESCRIPCION.DataPropertyName = "DESCRIPCION"
        Me.DataGridViewTextBoxDESCRIPCION.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxDESCRIPCION.Name = "DataGridViewTextBoxDESCRIPCION"
        '
        'DataGridViewTextBoxUSERID
        '
        Me.DataGridViewTextBoxUSERID.DataPropertyName = "USERID"
        Me.DataGridViewTextBoxUSERID.HeaderText = "Userid"
        Me.DataGridViewTextBoxUSERID.Name = "DataGridViewTextBoxUSERID"
        '
        'DataGridViewTextBoxLASTUPDATE
        '
        Me.DataGridViewTextBoxLASTUPDATE.DataPropertyName = "LASTUPDATE"
        Me.DataGridViewTextBoxLASTUPDATE.HeaderText = "Lastupdate"
        Me.DataGridViewTextBoxLASTUPDATE.Name = "DataGridViewTextBoxLASTUPDATE"
        '
        'ucListaNIVEL_ACADEMICO
        '
        Me.Controls.Add(Me.ListaNIVEL_ACADEMICODataGridView)
        Me.Name = "ucListaNIVEL_ACADEMICO"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaNIVEL_ACADEMICODataGridView, 0)
        CType(Me.ListaNIVEL_ACADEMICOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaNIVEL_ACADEMICODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaNIVEL_ACADEMICOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaNIVEL_ACADEMICODataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxNIVEL_ACADEMICO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxDESCRIPCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxUSERID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxLASTUPDATE As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
