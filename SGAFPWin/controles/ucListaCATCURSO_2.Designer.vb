<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaCATCURSO_2
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
        Me.ListaCATCURSO_2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaCATCURSO_2DataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxID_CURSO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxDURACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaCATCURSO_2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaCATCURSO_2DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaCATCURSO_2BindingSource
        '
        Me.ListaCATCURSO_2BindingSource.DataSource = GetType(SGAFP.EL.CATCURSO_2)
        '
        'ListaCATCURSO_2DataGridView
        '
        Me.ListaCATCURSO_2DataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaCATCURSO_2DataGridView.AutoGenerateColumns = False
        Me.ListaCATCURSO_2DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxID_CURSO, Me.DataGridViewTextBoxNOMBRE, Me.DataGridViewTextBoxDURACION})
        Me.ListaCATCURSO_2DataGridView.DataSource = Me.ListaCATCURSO_2BindingSource
        Me.ListaCATCURSO_2DataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaCATCURSO_2DataGridView.Name = "ListaCATCURSO_2DataGridView"
        Me.ListaCATCURSO_2DataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaCATCURSO_2DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxID_CURSO
        '
        Me.DataGridViewTextBoxID_CURSO.DataPropertyName = "ID_CURSO"
        Me.DataGridViewTextBoxID_CURSO.HeaderText = "Id curso"
        Me.DataGridViewTextBoxID_CURSO.Name = "DataGridViewTextBoxID_CURSO"
        '
        'DataGridViewTextBoxNOMBRE
        '
        Me.DataGridViewTextBoxNOMBRE.DataPropertyName = "NOMBRE"
        Me.DataGridViewTextBoxNOMBRE.HeaderText = "Nombre"
        Me.DataGridViewTextBoxNOMBRE.Name = "DataGridViewTextBoxNOMBRE"
        '
        'DataGridViewTextBoxDURACION
        '
        Me.DataGridViewTextBoxDURACION.DataPropertyName = "DURACION"
        Me.DataGridViewTextBoxDURACION.HeaderText = "Duracion"
        Me.DataGridViewTextBoxDURACION.Name = "DataGridViewTextBoxDURACION"
        '
        'ucListaCATCURSO_2
        '
        Me.Controls.Add(Me.ListaCATCURSO_2DataGridView)
        Me.Name = "ucListaCATCURSO_2"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaCATCURSO_2DataGridView, 0)
        CType(Me.ListaCATCURSO_2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaCATCURSO_2DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaCATCURSO_2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaCATCURSO_2DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxID_CURSO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxDURACION As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
