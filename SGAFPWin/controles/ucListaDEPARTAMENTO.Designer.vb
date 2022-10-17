<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaDEPARTAMENTO
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
        Me.ListaDEPARTAMENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaDEPARTAMENTODataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxCODIGO_REGION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCODIGO_DEPARTAMENTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxUSERID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxLASTUPDATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaDEPARTAMENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaDEPARTAMENTODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaDEPARTAMENTOBindingSource
        '
        Me.ListaDEPARTAMENTOBindingSource.DataSource = GetType(SGAFP.EL.DEPARTAMENTO)
        '
        'ListaDEPARTAMENTODataGridView
        '
        Me.ListaDEPARTAMENTODataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaDEPARTAMENTODataGridView.AutoGenerateColumns = False
        Me.ListaDEPARTAMENTODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxCODIGO_REGION, Me.DataGridViewTextBoxCODIGO_DEPARTAMENTO, Me.DataGridViewTextBoxNOMBRE, Me.DataGridViewTextBoxUSERID, Me.DataGridViewTextBoxLASTUPDATE})
        Me.ListaDEPARTAMENTODataGridView.DataSource = Me.ListaDEPARTAMENTOBindingSource
        Me.ListaDEPARTAMENTODataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaDEPARTAMENTODataGridView.Name = "ListaDEPARTAMENTODataGridView"
        Me.ListaDEPARTAMENTODataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaDEPARTAMENTODataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxCODIGO_REGION
        '
        Me.DataGridViewTextBoxCODIGO_REGION.DataPropertyName = "CODIGO_REGION"
        Me.DataGridViewTextBoxCODIGO_REGION.HeaderText = "Codigo region"
        Me.DataGridViewTextBoxCODIGO_REGION.Name = "DataGridViewTextBoxCODIGO_REGION"
        '
        'DataGridViewTextBoxCODIGO_DEPARTAMENTO
        '
        Me.DataGridViewTextBoxCODIGO_DEPARTAMENTO.DataPropertyName = "CODIGO_DEPARTAMENTO"
        Me.DataGridViewTextBoxCODIGO_DEPARTAMENTO.HeaderText = "Codigo departamento"
        Me.DataGridViewTextBoxCODIGO_DEPARTAMENTO.Name = "DataGridViewTextBoxCODIGO_DEPARTAMENTO"
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
        'ucListaDEPARTAMENTO
        '
        Me.Controls.Add(Me.ListaDEPARTAMENTODataGridView)
        Me.Name = "ucListaDEPARTAMENTO"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaDEPARTAMENTODataGridView, 0)
        CType(Me.ListaDEPARTAMENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaDEPARTAMENTODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaDEPARTAMENTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaDEPARTAMENTODataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxCODIGO_REGION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCODIGO_DEPARTAMENTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxUSERID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxLASTUPDATE As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
