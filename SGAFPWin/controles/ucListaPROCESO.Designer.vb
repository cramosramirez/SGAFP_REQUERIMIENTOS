<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaPROCESO
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
        Me.ListaPROCESOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaPROCESODataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxCODIGO_PROCESO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOMBRE_PROCESO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxDURACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxUNIDAD_DE_TIEMPO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxUSERID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxLASTUPDATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaPROCESOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaPROCESODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaPROCESOBindingSource
        '
        Me.ListaPROCESOBindingSource.DataSource = GetType(SGAFP.EL.PROCESO)
        '
        'ListaPROCESODataGridView
        '
        Me.ListaPROCESODataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaPROCESODataGridView.AutoGenerateColumns = False
        Me.ListaPROCESODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxCODIGO_PROCESO, Me.DataGridViewTextBoxNOMBRE_PROCESO, Me.DataGridViewTextBoxDURACION, Me.DataGridViewTextBoxUNIDAD_DE_TIEMPO, Me.DataGridViewTextBoxUSERID, Me.DataGridViewTextBoxLASTUPDATE})
        Me.ListaPROCESODataGridView.DataSource = Me.ListaPROCESOBindingSource
        Me.ListaPROCESODataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaPROCESODataGridView.Name = "ListaPROCESODataGridView"
        Me.ListaPROCESODataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaPROCESODataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxCODIGO_PROCESO
        '
        Me.DataGridViewTextBoxCODIGO_PROCESO.DataPropertyName = "CODIGO_PROCESO"
        Me.DataGridViewTextBoxCODIGO_PROCESO.HeaderText = "Codigo proceso"
        Me.DataGridViewTextBoxCODIGO_PROCESO.Name = "DataGridViewTextBoxCODIGO_PROCESO"
        '
        'DataGridViewTextBoxNOMBRE_PROCESO
        '
        Me.DataGridViewTextBoxNOMBRE_PROCESO.DataPropertyName = "NOMBRE_PROCESO"
        Me.DataGridViewTextBoxNOMBRE_PROCESO.HeaderText = "Nombre proceso"
        Me.DataGridViewTextBoxNOMBRE_PROCESO.Name = "DataGridViewTextBoxNOMBRE_PROCESO"
        '
        'DataGridViewTextBoxDURACION
        '
        Me.DataGridViewTextBoxDURACION.DataPropertyName = "DURACION"
        Me.DataGridViewTextBoxDURACION.HeaderText = "Duracion"
        Me.DataGridViewTextBoxDURACION.Name = "DataGridViewTextBoxDURACION"
        '
        'DataGridViewTextBoxUNIDAD_DE_TIEMPO
        '
        Me.DataGridViewTextBoxUNIDAD_DE_TIEMPO.DataPropertyName = "UNIDAD_DE_TIEMPO"
        Me.DataGridViewTextBoxUNIDAD_DE_TIEMPO.HeaderText = "Unidad de tiempo"
        Me.DataGridViewTextBoxUNIDAD_DE_TIEMPO.Name = "DataGridViewTextBoxUNIDAD_DE_TIEMPO"
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
        'ucListaPROCESO
        '
        Me.Controls.Add(Me.ListaPROCESODataGridView)
        Me.Name = "ucListaPROCESO"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaPROCESODataGridView, 0)
        CType(Me.ListaPROCESOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaPROCESODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaPROCESOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaPROCESODataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxCODIGO_PROCESO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOMBRE_PROCESO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxDURACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxUNIDAD_DE_TIEMPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxUSERID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxLASTUPDATE As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
