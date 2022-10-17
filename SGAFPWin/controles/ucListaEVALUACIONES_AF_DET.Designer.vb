<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaEVALUACIONES_AF_DET
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
        Me.ListaEVALUACIONES_AF_DETBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaEVALUACIONES_AF_DETDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxID_EVALUACION_DET = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_PARTICIPANTE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_EVALUACION_AF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOTA_OBTENIDA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOTAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaEVALUACIONES_AF_DETBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaEVALUACIONES_AF_DETDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaEVALUACIONES_AF_DETBindingSource
        '
        Me.ListaEVALUACIONES_AF_DETBindingSource.DataSource = GetType(SGAFP.EL.EVALUACIONES_AF_DET)
        '
        'ListaEVALUACIONES_AF_DETDataGridView
        '
        Me.ListaEVALUACIONES_AF_DETDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaEVALUACIONES_AF_DETDataGridView.AutoGenerateColumns = False
        Me.ListaEVALUACIONES_AF_DETDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxID_EVALUACION_DET, Me.DataGridViewTextBoxID_PARTICIPANTE, Me.DataGridViewTextBoxID_EVALUACION_AF, Me.DataGridViewTextBoxNOTA_OBTENIDA, Me.DataGridViewTextBoxNOTAS})
        Me.ListaEVALUACIONES_AF_DETDataGridView.DataSource = Me.ListaEVALUACIONES_AF_DETBindingSource
        Me.ListaEVALUACIONES_AF_DETDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaEVALUACIONES_AF_DETDataGridView.Name = "ListaEVALUACIONES_AF_DETDataGridView"
        Me.ListaEVALUACIONES_AF_DETDataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaEVALUACIONES_AF_DETDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxID_EVALUACION_DET
        '
        Me.DataGridViewTextBoxID_EVALUACION_DET.DataPropertyName = "ID_EVALUACION_DET"
        Me.DataGridViewTextBoxID_EVALUACION_DET.HeaderText = "Id evaluacion det"
        Me.DataGridViewTextBoxID_EVALUACION_DET.Name = "DataGridViewTextBoxID_EVALUACION_DET"
        '
        'DataGridViewTextBoxID_PARTICIPANTE
        '
        Me.DataGridViewTextBoxID_PARTICIPANTE.DataPropertyName = "ID_PARTICIPANTE"
        Me.DataGridViewTextBoxID_PARTICIPANTE.HeaderText = "Id participante"
        Me.DataGridViewTextBoxID_PARTICIPANTE.Name = "DataGridViewTextBoxID_PARTICIPANTE"
        '
        'DataGridViewTextBoxID_EVALUACION_AF
        '
        Me.DataGridViewTextBoxID_EVALUACION_AF.DataPropertyName = "ID_EVALUACION_AF"
        Me.DataGridViewTextBoxID_EVALUACION_AF.HeaderText = "Id evaluacion af"
        Me.DataGridViewTextBoxID_EVALUACION_AF.Name = "DataGridViewTextBoxID_EVALUACION_AF"
        '
        'DataGridViewTextBoxNOTA_OBTENIDA
        '
        Me.DataGridViewTextBoxNOTA_OBTENIDA.DataPropertyName = "NOTA_OBTENIDA"
        Me.DataGridViewTextBoxNOTA_OBTENIDA.HeaderText = "Nota obtenida"
        Me.DataGridViewTextBoxNOTA_OBTENIDA.Name = "DataGridViewTextBoxNOTA_OBTENIDA"
        '
        'DataGridViewTextBoxNOTAS
        '
        Me.DataGridViewTextBoxNOTAS.DataPropertyName = "NOTAS"
        Me.DataGridViewTextBoxNOTAS.HeaderText = "Notas"
        Me.DataGridViewTextBoxNOTAS.Name = "DataGridViewTextBoxNOTAS"
        '
        'ucListaEVALUACIONES_AF_DET
        '
        Me.Controls.Add(Me.ListaEVALUACIONES_AF_DETDataGridView)
        Me.Name = "ucListaEVALUACIONES_AF_DET"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaEVALUACIONES_AF_DETDataGridView, 0)
        CType(Me.ListaEVALUACIONES_AF_DETBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaEVALUACIONES_AF_DETDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaEVALUACIONES_AF_DETBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaEVALUACIONES_AF_DETDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxID_EVALUACION_DET As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_PARTICIPANTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_EVALUACION_AF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOTA_OBTENIDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOTAS As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
