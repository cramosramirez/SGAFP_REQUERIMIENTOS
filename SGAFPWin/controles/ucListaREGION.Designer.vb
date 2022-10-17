<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaREGION
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
        Me.ListaREGIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaREGIONDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxCODIGO_REGION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxUSERID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxLASTUPDATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaREGIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaREGIONDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaREGIONBindingSource
        '
        Me.ListaREGIONBindingSource.DataSource = GetType(SGAFP.EL.REGION)
        '
        'ListaREGIONDataGridView
        '
        Me.ListaREGIONDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaREGIONDataGridView.AutoGenerateColumns = False
        Me.ListaREGIONDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxCODIGO_REGION, Me.DataGridViewTextBoxNOMBRE, Me.DataGridViewTextBoxUSERID, Me.DataGridViewTextBoxLASTUPDATE})
        Me.ListaREGIONDataGridView.DataSource = Me.ListaREGIONBindingSource
        Me.ListaREGIONDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaREGIONDataGridView.Name = "ListaREGIONDataGridView"
        Me.ListaREGIONDataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaREGIONDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxCODIGO_REGION
        '
        Me.DataGridViewTextBoxCODIGO_REGION.DataPropertyName = "CODIGO_REGION"
        Me.DataGridViewTextBoxCODIGO_REGION.HeaderText = "Codigo region"
        Me.DataGridViewTextBoxCODIGO_REGION.Name = "DataGridViewTextBoxCODIGO_REGION"
        '
        'DataGridViewTextBoxNOMBRE
        '
        Me.DataGridViewTextBoxNOMBRE.DataPropertyName = "NOMBRE"
        Me.DataGridViewTextBoxNOMBRE.HeaderText = "Nombre"
        Me.DataGridViewTextBoxNOMBRE.Name = "DataGridViewTextBoxNOMBRE"
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
        'ucListaREGION
        '
        Me.Controls.Add(Me.ListaREGIONDataGridView)
        Me.Name = "ucListaREGION"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaREGIONDataGridView, 0)
        CType(Me.ListaREGIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaREGIONDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaREGIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaREGIONDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxCODIGO_REGION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxUSERID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxLASTUPDATE As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
